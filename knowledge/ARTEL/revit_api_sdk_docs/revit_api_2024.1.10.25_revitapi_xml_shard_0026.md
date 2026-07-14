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
Shard: 26
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `M:Autodesk.Revit.DB.DocumentVersion.IsEqual(Autodesk.Revit.DB.DocumentVersion)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DocumentVersion.IsEqual(Autodesk.Revit.DB.DocumentVersion)`

#### Summary

Checks whether two DocumentVersions are identical.
They are identical if both the GUID and number of saves
are equal. If two DocumentVersions are identical, they
come from the same document, with the same set of changes.

#### Parameter `other`

The DocumentVersion to compare to this DocumentVersion.

#### Returns

True if the two DocumentVersions are equal. False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `P:Autodesk.Revit.DB.DocumentVersion.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.DocumentVersion.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.DocumentVersion.NumberOfSaves`

Member kind: property
Symbol: `Autodesk.Revit.DB.DocumentVersion.NumberOfSaves`

#### Summary

The number of times the document has been saved. The save number and GUID
are both necessary to uniquely identify a document version.

#### Since

2015

### `P:Autodesk.Revit.DB.DocumentVersion.VersionGUID`

Member kind: property
Symbol: `Autodesk.Revit.DB.DocumentVersion.VersionGUID`

#### Summary

The GUID portion of the DocumentVersion. The GUID is updated when changes
are made to the document, but may not update with every change to the document.
The GUID and save number are both necessary to uniquely identify a document version.

#### Since

2015

### `T:Autodesk.Revit.DB.DocumentVersion`

Member kind: type
Symbol: `Autodesk.Revit.DB.DocumentVersion`

#### Summary

This class uniquely identifies an edition of a given document.

#### Remarks

DocumentVersion consists
of two parts - a GUID and an integer. The GUID is updated as new elements
are created in the document, but it is not necessarily changed whenever
any individual change is made to the document. The integer is updated when
the document is saved.

The GUID will change as changes are made to a model, so it should not be treated
as a static value.

This class does not contain any time information - you cannot compare two
DocumentVersions and know which document is newer. It can be used
to tell whether a document has changed since it was last inspected.
See `M:Autodesk.Revit.DB.BasicFileInfo.GetDocumentVersion`

#### Since

2015

### `M:Autodesk.Revit.DB.BasicFileInfo.Extract(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BasicFileInfo.Extract(System.String)`

#### Summary

Returns an instance of BasicFileInfo filled with basic information about a Revit file located at the given file-path

#### Parameter `file`

The full path to the file to be queried, including project (.rvt) and family (.rfa) files.

#### Returns

If successful, basic file data.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The file doesn't exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The file is a newer format file where the structure of the BasicFileInfo storage has changed, or the file is saved in very old version of Revit without basic file data.

#### Since

2013

### `M:Autodesk.Revit.DB.BasicFileInfo.GetDocumentVersion`

Member kind: method
Symbol: `Autodesk.Revit.DB.BasicFileInfo.GetDocumentVersion`

#### Summary

Gets the DocumentVersion for the file.

#### Returns

The DocumentVersion for the file.

#### Since

2015

### `P:Autodesk.Revit.DB.BasicFileInfo.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.BasicFileInfo.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.BasicFileInfo.IsForeign`

Member kind: property
Symbol: `Autodesk.Revit.DB.BasicFileInfo.IsForeign`

#### Summary

Checks if the file was saved by an application that was not developed or licensed by Autodesk.

#### Since

2020

### `P:Autodesk.Revit.DB.BasicFileInfo.ClientAppName`

Member kind: property
Symbol: `Autodesk.Revit.DB.BasicFileInfo.ClientAppName`

#### Summary

Returns ClientAppName.

#### Since

2021

### `P:Autodesk.Revit.DB.BasicFileInfo.Author`

Member kind: property
Symbol: `Autodesk.Revit.DB.BasicFileInfo.Author`

#### Summary

Returns Author.

#### Since

2019

### `P:Autodesk.Revit.DB.BasicFileInfo.ModelIdentity`

Member kind: property
Symbol: `Autodesk.Revit.DB.BasicFileInfo.ModelIdentity`

#### Summary

GUID of current model

#### Since

2013

### `P:Autodesk.Revit.DB.BasicFileInfo.LatestCentralEpisodeGUID`

Member kind: property
Symbol: `Autodesk.Revit.DB.BasicFileInfo.LatestCentralEpisodeGUID`

#### Summary

This is the central model's episode GUID corresponding to the last reload latest
done for this model.

#### Since

2013

### `P:Autodesk.Revit.DB.BasicFileInfo.LatestCentralVersion`

Member kind: property
Symbol: `Autodesk.Revit.DB.BasicFileInfo.LatestCentralVersion`

#### Summary

This is the central model's version number corresponding to the last reload latest
done for this model.

#### Since

2013

### `P:Autodesk.Revit.DB.BasicFileInfo.AllLocalChangesSavedToCentral`

Member kind: property
Symbol: `Autodesk.Revit.DB.BasicFileInfo.AllLocalChangesSavedToCentral`

#### Summary

Are all local changes saved to the central file?

#### Since

2013

### `P:Autodesk.Revit.DB.BasicFileInfo.CentralPath`

Member kind: property
Symbol: `Autodesk.Revit.DB.BasicFileInfo.CentralPath`

#### Summary

Returns the central model path.

#### Since

2013

### `P:Autodesk.Revit.DB.BasicFileInfo.Username`

Member kind: property
Symbol: `Autodesk.Revit.DB.BasicFileInfo.Username`

#### Summary

Returns the username.

#### Since

2013

### `P:Autodesk.Revit.DB.BasicFileInfo.LanguageWhenSaved`

Member kind: property
Symbol: `Autodesk.Revit.DB.BasicFileInfo.LanguageWhenSaved`

#### Summary

Return the language active for the last save

#### Since

2013

### `P:Autodesk.Revit.DB.BasicFileInfo.Format`

Member kind: property
Symbol: `Autodesk.Revit.DB.BasicFileInfo.Format`

#### Summary

The file format indicator (currently, the major release version such as "2019") used for saving the file.

#### Since

2019

### `P:Autodesk.Revit.DB.BasicFileInfo.IsSavedInLaterVersion`

Member kind: property
Symbol: `Autodesk.Revit.DB.BasicFileInfo.IsSavedInLaterVersion`

#### Summary

Checks if the file is saved in a later version of Revit than the running Revit.

#### Remarks

If the structure of the BasicFileInfo storage has not changed in a newer format file,
this will indicate that the file format is newer.
However, if the structure of the storage has changed in a newer format file,
extraction would have failed and this method cannot be used to make that determination.

#### Since

2017

### `P:Autodesk.Revit.DB.BasicFileInfo.IsSavedInCurrentVersion`

Member kind: property
Symbol: `Autodesk.Revit.DB.BasicFileInfo.IsSavedInCurrentVersion`

#### Summary

Checks if the file is saved in the current version.

#### Since

2013

### `P:Autodesk.Revit.DB.BasicFileInfo.IsCreatedLocal`

Member kind: property
Symbol: `Autodesk.Revit.DB.BasicFileInfo.IsCreatedLocal`

#### Summary

Checks if the file is local and created by RevitServerTool.exe.

#### Remarks

The value will be set to false after the file is saved and IsLocal will become true.

#### Since

2013

### `P:Autodesk.Revit.DB.BasicFileInfo.IsInProgress`

Member kind: property
Symbol: `Autodesk.Revit.DB.BasicFileInfo.IsInProgress`

#### Summary

Checks if the file is workshared and is in process of becoming Central.

#### Since

2013

### `P:Autodesk.Revit.DB.BasicFileInfo.IsCentral`

Member kind: property
Symbol: `Autodesk.Revit.DB.BasicFileInfo.IsCentral`

#### Summary

Checks if the file is workshared and Central.

#### Since

2013

### `P:Autodesk.Revit.DB.BasicFileInfo.IsLocal`

Member kind: property
Symbol: `Autodesk.Revit.DB.BasicFileInfo.IsLocal`

#### Summary

Checks if the file is workshared and Local.

#### Since

2013

### `P:Autodesk.Revit.DB.BasicFileInfo.IsWorkshared`

Member kind: property
Symbol: `Autodesk.Revit.DB.BasicFileInfo.IsWorkshared`

#### Summary

Checks if the file is workshared.

#### Since

2013

### `T:Autodesk.Revit.DB.BasicFileInfo`

Member kind: type
Symbol: `Autodesk.Revit.DB.BasicFileInfo`

#### Summary

Encapsulates basic information about a Revit file, including worksharing status, Revit version, username and central path.

#### Remarks

This class provides a fast access to get basic information without fully opening a Revit file. The
`M:Autodesk.Revit.DB.BasicFileInfo.Extract(System.String)` method
can initialize a new instance of this class by providing a full path for Revit file, including project (.rvt) and family (.rfa) files.
This class can extract information from files of older formats.
If the structure of the BasicFileInfo storage has not changed,
it can also extract information from files of newer formats
(making the method `P:Autodesk.Revit.DB.BasicFileInfo.IsSavedInLaterVersion` relevant).
However, if the structure of the storage has changed in a newer file format,
`M:Autodesk.Revit.DB.BasicFileInfo.Extract(System.String)` will not be able to extract the information.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.PostPattern.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.PostPattern.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Architecture.PostPattern.CornerPostCondition`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.PostPattern.CornerPostCondition`

#### Summary

The condition which controls the insertion of corner posts.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2019

### `P:Autodesk.Revit.DB.Architecture.PostPattern.CornerPostAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.PostPattern.CornerPostAngle`

#### Summary

The angle between neighboring railing segments which conditions inserting post along a railing path.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for cornerPostAngle is not finite

#### Since

2019

### `P:Autodesk.Revit.DB.Architecture.PostPattern.CornerPost`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.PostPattern.CornerPost`

#### Summary

Accesses the object containing properties related to the corner post.

#### Since

2019

### `P:Autodesk.Revit.DB.Architecture.PostPattern.EndPost`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.PostPattern.EndPost`

#### Summary

Accesses the object containing properties related to the end post.

#### Since

2019

### `P:Autodesk.Revit.DB.Architecture.PostPattern.StartPost`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.PostPattern.StartPost`

#### Summary

Accesses the object containing properties related to the start post.

#### Since

2019

### `T:Autodesk.Revit.DB.Architecture.PostPattern`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.PostPattern`

#### Summary

Post pattern class.

#### Since

2019

### `T:Autodesk.Revit.DB.Architecture.BreakCornerCondition`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.BreakCornerCondition`

#### Summary

Condition on which the corner post is inserted.

#### Since

2019

### `F:Autodesk.Revit.DB.Architecture.BreakCornerCondition.Never`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.BreakCornerCondition.Never`

#### Summary

Corner posts are not inserted in railings.

### `F:Autodesk.Revit.DB.Architecture.BreakCornerCondition.AnglesGreaterThan`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.BreakCornerCondition.AnglesGreaterThan`

#### Summary

Corner posts are inserted only when the angle between neighboring path segments is greater than the defined.

### `F:Autodesk.Revit.DB.Architecture.BreakCornerCondition.EachSegmentEnd`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.BreakCornerCondition.EachSegmentEnd`

#### Summary

Corner posts are inserted at each segment end.

### `P:Autodesk.Revit.DB.Architecture.BalusterPlacement.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.BalusterPlacement.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Architecture.BalusterPlacement.BalusterPerTreadFamilyId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.BalusterPlacement.BalusterPerTreadFamilyId`

#### Summary

The id of baluster per tread family.

#### Remarks

The property defines a baluster family type which is used for creation of balusters on treads.
The number of such balusters is set by "BalusterPerTreadNumber" property.
It works only for stairs which have treads and have "UseBalusterPerTreadOnStairs" set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The balusterPerTreadFamilyId doesn't refer to a valid baluster family.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2019

### `P:Autodesk.Revit.DB.Architecture.BalusterPlacement.BalusterPerTreadNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.BalusterPlacement.BalusterPerTreadNumber`

#### Summary

The number of balusters per tread.

#### Remarks

Applicable only if UseBalusterPerTreadOnStairs is true.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for balusterPerTreadNumber is not positive.

#### Since

2019

### `P:Autodesk.Revit.DB.Architecture.BalusterPlacement.UseBalusterPerTreadOnStairs`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.BalusterPlacement.UseBalusterPerTreadOnStairs`

#### Summary

If true, one or more balusters will be included on each tread of an associated stair.
If false, this is not guaranteed to happen.

#### Since

2019

### `P:Autodesk.Revit.DB.Architecture.BalusterPlacement.PostPattern`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.BalusterPlacement.PostPattern`

#### Summary

Accesses the object containing properties related to the post pattern.

#### Since

2019

### `P:Autodesk.Revit.DB.Architecture.BalusterPlacement.BalusterPattern`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.BalusterPlacement.BalusterPattern`

#### Summary

Accesses the object containing properties related to the baluster pattern.

#### Since

2019

### `T:Autodesk.Revit.DB.Architecture.BalusterPlacement`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.BalusterPlacement`

#### Summary

A class which contains information regarding baluster and post placement for a given railing type.

#### Since

2019

### `M:Autodesk.Revit.DB.Architecture.BalusterPattern.RemoveBaluster(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.BalusterPattern.RemoveBaluster(System.Int32)`

#### Summary

Removes a baluster from the main baluster pattern.

#### Parameter `index`

Baluster index.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The index index is out of range.

#### Since

2019

### `M:Autodesk.Revit.DB.Architecture.BalusterPattern.DuplicateBaluster(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.BalusterPattern.DuplicateBaluster(System.Int32)`

#### Summary

Duplicates the baluster pointed by given index in the main baluster pattern.

#### Remarks

The new baluster will be inserted just after the source baluster.

#### Parameter `index`

Baluster index.

#### Returns

The duplicated baluster.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The index index is out of range.

#### Since

2019

### `M:Autodesk.Revit.DB.Architecture.BalusterPattern.GetBaluster(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.BalusterPattern.GetBaluster(System.Int32)`

#### Summary

Gets information about the given baluster from the main baluster pattern.

#### Parameter `index`

The baluster index.

#### Returns

The requested baluster or `null` if index is out of range.

#### Since

2019

### `M:Autodesk.Revit.DB.Architecture.BalusterPattern.GetBalusterCount`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.BalusterPattern.GetBalusterCount`

#### Summary

Gets the number of balusters in the main baluster pattern definition.

#### Returns

The number of balusters in the main baluster pattern.

#### Since

2019

### `P:Autodesk.Revit.DB.Architecture.BalusterPattern.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.BalusterPattern.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Architecture.BalusterPattern.Length`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.BalusterPattern.Length`

#### Summary

The length of the main baluster pattern.

#### Since

2019

### `P:Autodesk.Revit.DB.Architecture.BalusterPattern.DistributionJustification`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.BalusterPattern.DistributionJustification`

#### Summary

Determines how baluster pattern distribution is justified.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2019

### `P:Autodesk.Revit.DB.Architecture.BalusterPattern.BreakPattern`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.BalusterPattern.BreakPattern`

#### Summary

The condition which controls breaking baluster patterns distribution.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2019

### `P:Autodesk.Revit.DB.Architecture.BalusterPattern.ExcessLengthFillSpacing`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.BalusterPattern.ExcessLengthFillSpacing`

#### Summary

The value defines the spacing between each baluster instance inserted in the excess length.

#### Remarks

The spacing is used only if a baluster family is set to excess length fill.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for excessLengthFillSpacing must be between 0 and 30000 feet.

#### Since

2019

### `P:Autodesk.Revit.DB.Architecture.BalusterPattern.ExcessLengthFillBalusterId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.BalusterPattern.ExcessLengthFillBalusterId`

#### Summary

The id of a Baluster family used to fill excess length, which is the extra space
along the railing segment that cannot be filled with a pattern.
If set to InvalidElementId, it will be the default - the id of the BaseRailingAttr containing the Baluster pattern.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: Invalid ElementId for leftoverFill of BalusterPattern

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2019

### `P:Autodesk.Revit.DB.Architecture.BalusterPattern.PatternAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.BalusterPattern.PatternAngle`

#### Summary

The angle between neighboring railing segments which conditions breaking patterns distribution along a railing path.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for patternAngle is not finite

#### Since

2019

### `P:Autodesk.Revit.DB.Architecture.BalusterPattern.EndSpace`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.BalusterPattern.EndSpace`

#### Summary

The extra space added after a whole baluster pattern.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for endSpace must be between 0 and 30000 feet.

#### Since

2019

### `T:Autodesk.Revit.DB.Architecture.BalusterPattern`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.BalusterPattern`

#### Summary

Baluster pattern class.

#### Since

2019

### `T:Autodesk.Revit.DB.Architecture.PatternJustification`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.PatternJustification`

#### Summary

Justification of patterns distribution.

#### Since

2019

### `F:Autodesk.Revit.DB.Architecture.PatternJustification.SpreadPatternToFit`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.PatternJustification.SpreadPatternToFit`

#### Summary

Patterns are distributed to not last excess length.

### `F:Autodesk.Revit.DB.Architecture.PatternJustification.Center`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.PatternJustification.Center`

#### Summary

Patterns are distributed starting from the center of a railing path.

### `F:Autodesk.Revit.DB.Architecture.PatternJustification.End`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.PatternJustification.End`

#### Summary

Patterns are distributed starting from the ending of a railing path.

### `F:Autodesk.Revit.DB.Architecture.PatternJustification.Beginning`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.PatternJustification.Beginning`

#### Summary

Patterns are distributed starting from the beginning of a railing path.

### `T:Autodesk.Revit.DB.Architecture.BreakPatternCondition`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.BreakPatternCondition`

#### Summary

Condition on which patterns distribution will be broken.

#### Since

2019

### `F:Autodesk.Revit.DB.Architecture.BreakPatternCondition.Never`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.BreakPatternCondition.Never`

#### Summary

Patterns are distributed along whole path of a railing.

### `F:Autodesk.Revit.DB.Architecture.BreakPatternCondition.AnglesGreaterThan`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.BreakPatternCondition.AnglesGreaterThan`

#### Summary

Patterns distribution is broken if the angle between neighboring path segments is greater than the defined.

### `F:Autodesk.Revit.DB.Architecture.BreakPatternCondition.EachSegmentEnd`

Member kind: field
Symbol: `Autodesk.Revit.DB.Architecture.BreakPatternCondition.EachSegmentEnd`

#### Summary

Patterns distribution is broken at each segment end.

### `M:Autodesk.Revit.DB.Architecture.BalusterInfo.GetReferenceNameForTopRail`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.BalusterInfo.GetReferenceNameForTopRail`

#### Summary

Gets the name string to be used as a reference to Top Rail in the current language.

#### Remarks

This name can be used in the setter for `P:Autodesk.Revit.DB.Architecture.BalusterInfo.BaseReferenceName`
or `P:Autodesk.Revit.DB.Architecture.BalusterInfo.TopReferenceName` .
The name can also be compared with the value coming from the getter.

#### Returns

The name string to be used as a reference to Top Rail.

#### Since

2020

### `M:Autodesk.Revit.DB.Architecture.BalusterInfo.GetReferenceNameForHost`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.BalusterInfo.GetReferenceNameForHost`

#### Summary

Gets the name string to be used as a reference to Host in the current language.

#### Remarks

This name can be used in the setter for `P:Autodesk.Revit.DB.Architecture.BalusterInfo.BaseReferenceName`
or `P:Autodesk.Revit.DB.Architecture.BalusterInfo.TopReferenceName` .
The name can also be compared with the value coming from the getter.

#### Returns

The name string to be used as a reference to Host.

#### Since

2020

### `P:Autodesk.Revit.DB.Architecture.BalusterInfo.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.BalusterInfo.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Architecture.BalusterInfo.TopReferenceName`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.BalusterInfo.TopReferenceName`

#### Summary

Represents the name of the reference for the top of this baluster or post.

#### Remarks

Two pre-defined reference names can be obtained using `!:Autodesk::Revit::DB::Architecture::BalusterInfo::getReferenceNameForHost()` or
`!:Autodesk::Revit::DB::Architecture::BalusterInfo::getReferenceNameForTopRail()` .
The rest of valid reference names that are allowed to be used in the setter for TopReferenceName
are the actual names of non-continuous rails `!:Autodesk::Revit::DB::Architecture::NonContinuousRailInfo::Name`
in `!:Autodesk::Revit::DB::Architecture::NonContinuousRailStructure`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The name doesn't refer to a valid reference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2019

### `P:Autodesk.Revit.DB.Architecture.BalusterInfo.BaseReferenceName`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.BalusterInfo.BaseReferenceName`

#### Summary

Represents the name of the reference for the bottom of this baluster or post.

#### Remarks

Two pre-defined reference names can be obtained using `!:Autodesk::Revit::DB::Architecture::BalusterInfo::getReferenceNameForHost()` or
`!:Autodesk::Revit::DB::Architecture::BalusterInfo::getReferenceNameForTopRail()` .
The rest of valid reference names that are allowed to be used in the setter for BaseReferenceName
are the actual names of non-continuous rails `!:Autodesk::Revit::DB::Architecture::NonContinuousRailInfo::Name`
in `!:Autodesk::Revit::DB::Architecture::NonContinuousRailStructure`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The name doesn't refer to a valid reference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2019

### `P:Autodesk.Revit.DB.Architecture.BalusterInfo.DistanceFromPreviousOrSpace`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.BalusterInfo.DistanceFromPreviousOrSpace`

#### Summary

The length, in case of balusters, it is a distance from a previous one.
For a post, it is a space from the original position of the post.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for distanceFromPreviousOrSpace is not finite

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for distanceFromPreviousOrSpace must be greater than 0 and no more than 30000 feet.

#### Since

2019

### `P:Autodesk.Revit.DB.Architecture.BalusterInfo.Offset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.BalusterInfo.Offset`

#### Summary

The side offset of the baluster/post from the railing path.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for offset must be no more than 30000 feet in absolute value.

#### Since

2019

### `P:Autodesk.Revit.DB.Architecture.BalusterInfo.TopOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.BalusterInfo.TopOffset`

#### Summary

The offset from the top reference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for topOffset must be no more than 30000 feet in absolute value.

#### Since

2019

### `P:Autodesk.Revit.DB.Architecture.BalusterInfo.BaseOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.BalusterInfo.BaseOffset`

#### Summary

The offset from the base reference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for baseOffset must be no more than 30000 feet in absolute value.

#### Since

2019

### `P:Autodesk.Revit.DB.Architecture.BalusterInfo.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.BalusterInfo.Name`

#### Summary

The name of the baluster.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: name is an empty string or contains only whitespace.
-or-
When setting this property: name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2019

### `P:Autodesk.Revit.DB.Architecture.BalusterInfo.BalusterFamilyId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.BalusterInfo.BalusterFamilyId`

#### Summary

The id of the family used for the baluster or post.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The balusterFamilyId doesn't refer to a valid baluster family.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2019

### `T:Autodesk.Revit.DB.Architecture.BalusterInfo`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.BalusterInfo`

#### Summary

The class represents an instance of a railing baluster or post.

#### Since

2019

### `T:Autodesk.Revit.DB.BackClippingParam`

Member kind: type
Symbol: `Autodesk.Revit.DB.BackClippingParam`

#### Summary

The allowed values for the VIEW_BACK_CLIPPING and VIEWER_BOUND_FAR_CLIPPING parameters.

### `F:Autodesk.Revit.DB.BackClippingParam.ClipNoLine`

Member kind: field
Symbol: `Autodesk.Revit.DB.BackClippingParam.ClipNoLine`

#### Summary

Clip without line.

### `F:Autodesk.Revit.DB.BackClippingParam.ClipWithLine`

Member kind: field
Symbol: `Autodesk.Revit.DB.BackClippingParam.ClipWithLine`

#### Summary

Clip with line.

### `F:Autodesk.Revit.DB.BackClippingParam.NoClip`

Member kind: field
Symbol: `Autodesk.Revit.DB.BackClippingParam.NoClip`

#### Summary

No clip

### `P:Autodesk.Revit.DB.PatternPlacer.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.PatternPlacer.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.PatternPlacer.#ctor(Autodesk.Revit.DB.UV,Autodesk.Revit.DB.UV,System.Boolean,Autodesk.Revit.DB.UV)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PatternPlacer.#ctor(Autodesk.Revit.DB.UV,Autodesk.Revit.DB.UV,System.Boolean,Autodesk.Revit.DB.UV)`

#### Summary

Constructor.

#### Parameter `origin`

Origin of the pattern on this face mapping the bottom left corner of the material.

#### Parameter `dir`

Direction of the pattern placement (rotate the material in the face's UV coordinate plane around origin).

#### Parameter `mirror`

Mirror the pattern (rotate the direction another 180 degrees).

#### Parameter `scale`

Non uniform uv scale of the pattern. Larger value means larger pattern.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.PatternPlacer.#ctor(Autodesk.Revit.DB.UV,Autodesk.Revit.DB.UV,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PatternPlacer.#ctor(Autodesk.Revit.DB.UV,Autodesk.Revit.DB.UV,System.Boolean)`

#### Summary

Constructor.

#### Parameter `origin`

Origin of the pattern on this face mapping the bottom left corner of the material.

#### Parameter `dir`

Direction of the pattern placement (rotate the material in the face's UV coordinate plane around origin).

#### Parameter `mirror`

Mirror the pattern (rotate the direction another 180 degrees).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `T:Autodesk.Revit.DB.PatternPlacer`

Member kind: type
Symbol: `Autodesk.Revit.DB.PatternPlacer`

#### Summary

This class defines the pattern placement of material on a face.
This works together with the material settings defined in Texture Editor.

#### Since

2022

### `M:Autodesk.Revit.DB.BRepBuilderSurfaceGeometry.CreateNURBSSurface(System.Int32,System.Int32,System.Collections.Generic.IList{System.Double},System.Collections.Generic.IList{System.Double},System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{System.Double},System.Boolean,Autodesk.Revit.DB.BoundingBoxUV)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilderSurfaceGeometry.CreateNURBSSurface(System.Int32,System.Int32,System.Collections.Generic.IList{System.Double},System.Collections.Generic.IList{System.Double},System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Collections.Generic.IList{System.Double},System.Boolean,Autodesk.Revit.DB.BoundingBoxUV)`

#### Summary

Construct BRepBuilderSurfaceGeometry based on NURBS surface data, where the weights are supplied.
In this case, the NURBS surface will be a piecewise rational polynomial surface.

#### Remarks

A rational polynomial is a quotient of two polynomials; this includes a polynomial,
which can be thought of as a quotient with denominator equal to 1.
If all the weights are equal, then the NURBS surface will be a piecewise polynomial surface.

This class does not handle periodic Nurbs surfaces.

#### Parameter `degreeU`

The degree of the spline in the u-direction; must be positive.

#### Parameter `degreeV`

The degree of the spline in the v-direction; must be positive.

#### Parameter `knotsU`

Knot values in the u-direction.
The number of knots in the u-direction must be at least 2 * (degreeU + 1).

#### Parameter `knotsV`

Knot values in the v-direction.
The number of knots in the v-direction must be at least 2 * (degreeV + 1).

#### Parameter `controlPoints`

One dimensional array of points representing the two dimensional net of control points
of the NURBS surface in u and v directions.

The total number of control points must equal numControlPtsU times numControlPtsV,
where numControlPtsU and numControlPtsV are the numbers of control points in u and v directions,
and they must satisfy the following conditions:
numControlPtsU = number of knots in u - degreeU - 1.

numControlPtsV = number of knots in v - degreeV - 1.
The convention for 2d (idxU, idxV) to 1d (idx) conversion of array indexes: idxV first.
That is, idxU is outer loop and idxV is inner loop. In other words,
idx = idxU * numControlPtsV + idxV.

#### Parameter `weights`

Array of weights assigned to the control points.
The number of weights must equal the number of control points.
All weights should be greater than zero.

#### Parameter `bReverseOrientation`

If true, the surface's orientation is opposite to the canonical parametric orientation, otherwise it is the same.
The canonical parametric orientation is a counter-clockwise sense of rotation in the uv-parameter plane.
Extrinsically, the oriented normal vector for the canonical parametric orientation points in the direction of
the cross product dS/du x dS/dv, which S(u, v) is the parameterized surface.

#### Parameter `surfaceEnvelope`

Envelope of the surface in the uv parametric domain. Defines the domain of interest for the created surface.
This is typically used to identify the domain of the face that references the surface in question.
Expected to either be null or define a valid domain.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The U-degree value must be at least 1.
-or-
The V-degree value must be at least 1.
-or-
The number of knots in the U direction must be at least 2 times the U-degree plus 1.
-or-
The number of knots in the V direction must be at least 2 times the V-degree plus 1.
-or-
The number of control points must equal (number of U-knots - U-degree - 1) * (number of V-knots - V-degree - 1).
-or-
The number of weights must be the same as the number of control points and all weights must be positive or all zero.
-or-
The input data does not define a valid Nurbs surface.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The Nurbs surface could not be converted for use in Revit. It may have C2-discontinuities or be too large.

#### Since

2016

### `M:Autodesk.Revit.DB.BRepBuilderSurfaceGeometry.CreateNURBSSurface(System.Int32,System.Int32,System.Collections.Generic.IList{System.Double},System.Collections.Generic.IList{System.Double},System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Boolean,Autodesk.Revit.DB.BoundingBoxUV)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilderSurfaceGeometry.CreateNURBSSurface(System.Int32,System.Int32,System.Collections.Generic.IList{System.Double},System.Collections.Generic.IList{System.Double},System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},System.Boolean,Autodesk.Revit.DB.BoundingBoxUV)`

#### Summary

Construct a BRepBuilderSurfaceGeometry based on NURBS surface data, where the weights are not supplied.
In this case, the NURBS surface will be a piecewise polynomial surface.

#### Remarks

This function does not handle periodic Nurbs surfaces.

#### Parameter `degreeU`

The degree of the spline in the u-direction; must be positive.

#### Parameter `degreeV`

The degree of the spline in the v-direction; must be positive.

#### Parameter `knotsU`

Knot values in the u-direction.
The number of knots in the u-direction must be at least 2 * (degreeU + 1).

#### Parameter `knotsV`

Knot values in the v-direction.
The number of knots in the v-direction must be at least 2 * (degreeV + 1).

#### Parameter `controlPoints`

One dimensional array of points representing the two dimensional net of control points
of the NURBS surface in u and v directions.

The total number of control points must equal numControlPtsU times numControlPtsV,
where numControlPtsU and numControlPtsV are the numbers of control points in u and v directions,
and they must satisfy the following conditions:
numControlPtsU = number of knots in u - degreeU - 1.

numControlPtsV = number of knots in v - degreeV - 1.
The convention for 2d (idxU, idxV) to 1d (idx) conversion of array indexes: idxV first.
That is, idxU is outer loop and idxV is inner loop. In other words,
idx = idxU * numControlPtsV + idxV.

#### Parameter `bReverseOrientation`

If true, the surface's orientation is opposite to the canonical parametric orientation, otherwise it is the same.
The canonical parametric orientation is a counter-clockwise sense of rotation in the uv-parameter plane.
Extrinsically, the oriented normal vector for the canonical parametric orientation points in the direction of
the cross product dS/du x dS/dv, which S(u, v) is the parameterized surface.

#### Parameter `surfaceEnvelope`

Envelope of the surface in the uv parametric domain. Defines the domain of interest for the created surface.
This is typically used to identify the domain of the face that references the surface in question.
Expected to either be null or define a valid domain.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The U-degree value must be at least 1.
-or-
The V-degree value must be at least 1.
-or-
The number of knots in the U direction must be at least 2 * (U-degree + 1).
-or-
The number of knots in the V direction must be at least 2 * (V-degree + 1).
-or-
The number of control points must equal (number of U-knots - U-degree - 1) * (number of V-knots - V-degree - 1).
-or-
The input data does not define a valid Nurbs surface.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The Nurbs surface could not be converted for use in Revit. It may have C2-discontinuities or be too large.

#### Since

2017_subscription_update

### `M:Autodesk.Revit.DB.BRepBuilderSurfaceGeometry.Create(Autodesk.Revit.DB.Surface,Autodesk.Revit.DB.BoundingBoxUV)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilderSurfaceGeometry.Create(Autodesk.Revit.DB.Surface,Autodesk.Revit.DB.BoundingBoxUV)`

#### Summary

Construct BRepBuilderSurfaceGeometry based on a permitted Revit Surface, including Plane and CylSurf.

#### Parameter `surface`

The Revit surface defining the geometry.
This BRepBuilderSurfaceGeometry stores a copy of the input surface.

#### Parameter `surfaceEnvelope`

Envelope of the surface in the uv parametric domain. Defines the domain of interest for the created surface.
This is typically used to identify the domain of the face that references the surface in question.
Expected to either be null or define a valid domain.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

A surface of this type can not be used as a part of the geometry generated by BRepBuilder.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `P:Autodesk.Revit.DB.BRepBuilderSurfaceGeometry.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.BRepBuilderSurfaceGeometry.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.BRepBuilderSurfaceGeometry`

Member kind: type
Symbol: `Autodesk.Revit.DB.BRepBuilderSurfaceGeometry`

#### Summary

An abstract class used by BRepBuilder to represent the geometry of a surface. Specific surface-geometry representations are represented by subclasses.

#### Since

2016

### `M:Autodesk.Revit.DB.BRepBuilderPersistentIds.IsBRepBuilderGeometryIdFaceOrEdge(Autodesk.Revit.DB.BRepBuilderGeometryId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilderPersistentIds.IsBRepBuilderGeometryIdFaceOrEdge(Autodesk.Revit.DB.BRepBuilderGeometryId)`

#### Summary

Validates the input BRepBuilderGeometryId that will be used to create a correspondence.
In order to be valid, the input BRepBuilderGeometryId must represent the ID of either a Face or an Edge.

#### Remarks

This method returns false also in the case when the associated BRepBuilder is not valid.
Call `M:Autodesk.Revit.DB.BRepBuilderPersistentIds.IsAssociatedBRepBuilderValid` to check the associated BRepBuilder.

#### Parameter `brepBuilderGeometryId`

The BRepBuilderGeometryId to be used in a new correspondence.

#### Returns

True if the input BRepBuilderGeometryId represents the ID of either a Face or an Edge, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.BRepBuilderPersistentIds.IsAssociatedBRepBuilderValid`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilderPersistentIds.IsAssociatedBRepBuilderValid`

#### Summary

Validates the associated (in the constructor) BRepBuilder for this BRepBuilderPersistentIds.

#### Returns

True if the associated BRepBuilder exists, false otherwise.

#### Since

2022

### `M:Autodesk.Revit.DB.BRepBuilderPersistentIds.IsValidBRepBuilderGeometryIdForNewCorrespondence(Autodesk.Revit.DB.BRepBuilderGeometryId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilderPersistentIds.IsValidBRepBuilderGeometryIdForNewCorrespondence(Autodesk.Revit.DB.BRepBuilderGeometryId)`

#### Summary

Validates the input BRepBuilderGeometryId that will be used to create a correspondence.
In order to be valid, a correspondence for the input BRepBuilderGeometryId must not already exist.

#### Parameter `brepBuilderGeometryId`

The BRepBuilderGeometryId to be used in a new correspondence.

#### Returns

True if the input BRepBuilderGeometryId can be used to create a new correspondence.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.BRepBuilderPersistentIds.IsValidExternalGeometryIdForNewCorrespondence(Autodesk.Revit.DB.ExternalGeometryId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilderPersistentIds.IsValidExternalGeometryIdForNewCorrespondence(Autodesk.Revit.DB.ExternalGeometryId)`

#### Summary

Validates the input ExternalGeometryId that will be used to create a correspondence.
In order to be valid, a correspondence for the input ExternalGeometryId must not already exist.

#### Parameter `externalGeometryId`

The ExternalGeometryId to be used in a new correspondence.

#### Returns

True if the input ExternalGeometryId can be used to create a new correspondence.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.BRepBuilderPersistentIds.AddSubTag(Autodesk.Revit.DB.ExternalGeometryId,Autodesk.Revit.DB.BRepBuilderGeometryId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilderPersistentIds.AddSubTag(Autodesk.Revit.DB.ExternalGeometryId,Autodesk.Revit.DB.BRepBuilderGeometryId)`

#### Summary

Adds a correspondence between an ExternalGeometryId and a BRepBuilderGeometryId.
Note that an existing correspondence in the map cannot be updated and that a
particular BRepBuilderGeometryId may be related to at most one ExternalGeometryId.

#### Parameter `externalGeometryId`

An external geometry object Id.

#### Parameter `brepBuilderGeometryId`

A BRepBuilder geometry object Id. It must represent the ID of either a Face or an Edge.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

externalGeometryId cannot be used to create a new correspondence because it is already used.
-or-
brepBuilderGeometryId cannot be used to create a new correspondence because it is already used.
-or-
brepBuilderGeometryId cannot be used to create a new correspondence because it doesn't represent the ID of either a Face or an Edge.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The associated BRepBuilder doesn't exist or is not valid (has no Faces and no Edges).

#### Since

2022

### `P:Autodesk.Revit.DB.BRepBuilderPersistentIds.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.BRepBuilderPersistentIds.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.BRepBuilderPersistentIds.#ctor(Autodesk.Revit.DB.BRepBuilder)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilderPersistentIds.#ctor(Autodesk.Revit.DB.BRepBuilder)`

#### Summary

Constructs a new BRepBuilderPersistentIds and associates the existing BRepBuilder to it.

#### Parameter `bRepBuilder`

The existing BRepBuilder.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `T:Autodesk.Revit.DB.BRepBuilderPersistentIds`

Member kind: type
Symbol: `Autodesk.Revit.DB.BRepBuilderPersistentIds`

#### Summary

This class stores a map from ExternalGeometryIds to BRepBuilderGeometryIds.

#### Since

2022

### `M:Autodesk.Revit.DB.BRepBuilderEdgeGeometry.Create(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilderEdgeGeometry.Create(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Constructs a BRepBuilderEdgeGeometry representing a straight line between the two given points.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

The vectors startPoint and endPoint are coincident.

#### Since

2016

### `M:Autodesk.Revit.DB.BRepBuilderEdgeGeometry.Create(Autodesk.Revit.DB.Curve)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilderEdgeGeometry.Create(Autodesk.Revit.DB.Curve)`

#### Summary

Construct BRepBuilderEdgeGeometry based on any GCurve, including GLine and GArc.
The curve will be simplified if possible, and the concrete type of the returned value will reflect
that simplification: BRepBuilderLinearEdgeGeometry if the curve could be simplified to a line,
BRepBuilderArcEdgeGeometry if it could be simplified to an arc, BRepBuilderGenericCurveEdgeGeometry
otherwise.

#### Parameter `curve`

The 3D curve for this edge. This BRepBuilderEdgeGeometry stores a copy of the input curve.
The use of isCurveOpenOrShort as a validator instead of isCurveOpen is a compromise to allow
the creation of geometry that is normally considered unacceptable due to edges that are shorter
than Revit allows.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input curve is not bound.
-or-
The curve is degenerate (its length is too close to zero).
-or-
The endpoints of the curve are close enough that Revit considers it a closed curve.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `P:Autodesk.Revit.DB.BRepBuilderEdgeGeometry.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.BRepBuilderEdgeGeometry.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.BRepBuilderEdgeGeometry`

Member kind: type
Symbol: `Autodesk.Revit.DB.BRepBuilderEdgeGeometry`

#### Summary

An abstract class used by BRepBuilder to represent the geometry of an edge. Specific edge-geometry representations are represented by subclasses.

#### Since

2016

### `M:Autodesk.Revit.DB.BRepBuilder.SetEdgeHidden(Autodesk.Revit.DB.BRepBuilderGeometryId,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilder.SetEdgeHidden(Autodesk.Revit.DB.BRepBuilderGeometryId,System.Boolean)`

#### Summary

Make BRepBuilder allow edges to be hidden.

#### Remarks

Set the edge to be hidden.

#### Parameter `edgeId`

Id of the edge

#### Parameter `hidden`

True for hidden

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The supplied edge id doesn't correspond to an edge stored in this BRepBuilder object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021.1

### `M:Autodesk.Revit.DB.BRepBuilder.SetFacePatternPlacement(Autodesk.Revit.DB.BRepBuilderGeometryId,Autodesk.Revit.DB.PatternPlacer,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilder.SetFacePatternPlacement(Autodesk.Revit.DB.BRepBuilderGeometryId,Autodesk.Revit.DB.PatternPlacer,System.Boolean)`

#### Summary

Sets pattern placement of material on a face.

#### Parameter `faceId`

Id of the face to which material id will be added. faceId was returned by a call to AddFace().

#### Parameter `pattern`

Pattern placer of material on the face.

#### Parameter `background`

True to set the pattern placement for background of the face, otherwise foreground

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The supplied face id doesn't correspond to a face stored in this BRepBuilder object.
-or-
The input face doesn't have a material assigned with `M:Autodesk.Revit.DB.BRepBuilder.SetFaceMaterialId(Autodesk.Revit.DB.BRepBuilderGeometryId,Autodesk.Revit.DB.ElementId)` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.BRepBuilder.SetAllowShortEdges`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilder.SetAllowShortEdges`

#### Summary

Make BRepBuilder allow edges that it would normally disallow as being too short for Revit geometry.

#### Remarks

When used, this function must be called before any geometry is defined (e.g., just after constructing a BRepBuilder object).
Geometry with short edges may not be as reliable as fully valid geometry.
This option is intended to allow the construction of geometry such as mechanical items with small features
that is not expected to interact much with other Revit elements.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This function was called after the geometry had been defined (e.g. by calls to addFace).

#### Since

2017_subscription_update

### `M:Autodesk.Revit.DB.BRepBuilder.RemovedSomeFaces`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilder.RemovedSomeFaces`

#### Summary

Returns 'true' if BRepBuilder removed some problematic faces from the output geometry, 'false' if not.
If allowRemovalOfProblematicFaces was not called to enable removal of problematic faces, this function
will return 'false'. Note that if some faces were removed, the output geometry's type will be OpenShell
regardless of the expected type that was specified when the BRepBuilder was created.

#### Returns

True if BRepBuilder removed some faces, false if not.

#### Since

2017_subscription_update

### `M:Autodesk.Revit.DB.BRepBuilder.AllowRemovalOfProblematicFaces`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilder.AllowRemovalOfProblematicFaces`

#### Summary

Allow BRepBuilder to remove problematic faces (e.g., due to inaccurate edge geometry). If this option is enabled and
BRepBuilder removes some faces, the output geometry's type will be OpenShell regardless of the expected type specified
when the BRepBuilder was created.

#### Since

2017_subscription_update

### `M:Autodesk.Revit.DB.BRepBuilder.IsValidPersistentIdsMap(Autodesk.Revit.DB.BRepBuilderPersistentIds)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilder.IsValidPersistentIdsMap(Autodesk.Revit.DB.BRepBuilderPersistentIds)`

#### Summary

A validator function that makes sure that all BRepBuilderGeometryIds in the input map can be found in this BRepBuilder object.

#### Parameter `brepPersistentIds`

The map that associates ExternalGeometryIds to BRepBuilderGeometryIds.

#### Returns

True if all BRepBuilderGeometryIds in the input map can be found in this BRepBuilder object, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.BRepBuilder.IsValidEdgeId(Autodesk.Revit.DB.BRepBuilderGeometryId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilder.IsValidEdgeId(Autodesk.Revit.DB.BRepBuilderGeometryId)`

#### Summary

A validator function that checks whether the edge id corresponds to an edge previously added to this BRepBuilder object.

#### Parameter `edgeId`

Edge id to be validated.

#### Returns

True if edgeId corresponds to an edge previously added to this BRepBuilder, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.BRepBuilder.IsValidLoopId(Autodesk.Revit.DB.BRepBuilderGeometryId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilder.IsValidLoopId(Autodesk.Revit.DB.BRepBuilderGeometryId)`

#### Summary

A validator function that checks whether the loop id corresponds to a loop previously added to this BRepBuilder object.

#### Parameter `loopId`

Loop id to be validated.

#### Returns

True if loopId corresponds to a loop previously added to this BRepBuilder, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.BRepBuilder.IsValidFaceId(Autodesk.Revit.DB.BRepBuilderGeometryId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilder.IsValidFaceId(Autodesk.Revit.DB.BRepBuilderGeometryId)`

#### Summary

A validator function that checks whether the face id corresponds to a face previously added to this BRepBuilder object.

#### Parameter `faceId`

Face id to be validated.

#### Returns

True if faceId corresponds to a face previously added to this BRepBuilder, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.BRepBuilder.IsPermittedSurfaceType(Autodesk.Revit.DB.Surface)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilder.IsPermittedSurfaceType(Autodesk.Revit.DB.Surface)`

#### Summary

A validator function that checks whether the surface object is of type supported as face surface by BRepBuilder.

#### Parameter `surface`

Surface object intended to be used as a face surface.

#### Returns

True if surface of this type may be used as a face surface, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.BRepBuilder.IsResultAvailable`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilder.IsResultAvailable`

#### Summary

A validator function that checks the state of this BRepBuilder object. Returns true if this BRepBuilder object has successfully built a b-rep.

#### Remarks

The b-rep object may be retrieved via GetResult().
Use this function before calling GetResult() to avoid an exception being thrown.

#### Returns

True if this BRepBuilder object has successfully built a b-rep.

#### Since

2016

### `M:Autodesk.Revit.DB.BRepBuilder.CanAddGeometry`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilder.CanAddGeometry`

#### Summary

A validator function that checks the state of this BRepBuilder object. Returns true if this BRepBuilder object is accepting b-rep data, false otherwise.

#### Remarks

Use this function before calling AddFace(), AddEdge(), etc. to avoid an exception being thrown.

#### Returns

True if this BRepBuilder object is accepting b-rep data, false otherwise.

#### Since

2016

### `M:Autodesk.Revit.DB.BRepBuilder.GetResult(Autodesk.Revit.DB.ExternalGeometryId,Autodesk.Revit.DB.BRepBuilderPersistentIds)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilder.GetResult(Autodesk.Revit.DB.ExternalGeometryId,Autodesk.Revit.DB.BRepBuilderPersistentIds)`

#### Summary

Get the Geometry object built by this BRepBuilder. This will clear the built Geometry stored in the BRepBuilder.
This function will throw if this BRepBuilder hasn't completed building the b-rep. Use IsResultAvailable() to verify that this BRepBuilder contains a valid result.

#### Parameter `externalId`

The external Id of the Geometry object built by this BRepBuilder.

#### Parameter `brepPersistentIds`

An object storing the relationship between ExternalGeometryIds and BRepBuilderGeometryIds.

#### Returns

The Geometry object built by this BRepBuilder.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

At least one BRepBuilderGeometryId in the supplied BRepBuilderPersistentIds map could not be found in this BRepBuilder object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This BRepBuilder object hasn't completed building data or was unsuccessful building it. Built Geometry is unavailable.
In order to access the built Geometry, Finish() must be called first. That will set the state to completed.

#### Since

2022

### `M:Autodesk.Revit.DB.BRepBuilder.GetResult`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilder.GetResult`

#### Summary

Get the Geometry object built by this BRepBuilder. This will clear the built Geometry stored in the BRepBuilder.
This function will throw if this BRepBuilder hasn't completed building the b-rep. Use IsResultAvailable() to verify that this BRepBuilder contains a valid result.

#### Returns

The Geometry object built by this BRepBuilder.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This BRepBuilder object hasn't completed building data or was unsuccessful building it. Built Geometry is unavailable.
In order to access the built Geometry, Finish() must be called first. That will set the state to completed.

#### Since

2016

### `M:Autodesk.Revit.DB.BRepBuilder.Finish`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilder.Finish`

#### Summary

Complete construction of the geometry. The geometry will be validated and, if valid, stored in this Builder. Otherwise it will be deleted.

#### Remarks

If this function returned anything but BRepBuilderOutcome.Success, this BrepBuilder object should be discarded.
An attempt to retrieve the built b-rep via GetBRep() will cause an exception to be thrown.

#### Returns

BRepBuilderOutcome.Success if successful, BRepBuilderOutcome.Failure otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This BRepBuilder object isn't accepting new data, either because it has already been used to build geometry, or because of an error.
Consult the State property of the BRepBuilder object for more details.
-or-
BRep doesn't have enough faces.
-or-
FinishFace() must be called on all the faces of the BRepBuilder.

#### Since

2016

### `M:Autodesk.Revit.DB.BRepBuilder.AddCoEdge(Autodesk.Revit.DB.BRepBuilderGeometryId,Autodesk.Revit.DB.BRepBuilderGeometryId,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilder.AddCoEdge(Autodesk.Revit.DB.BRepBuilderGeometryId,Autodesk.Revit.DB.BRepBuilderGeometryId,System.Boolean)`

#### Summary

Add a co-edge associated to a previously added edge. A co-edge represents the use of an edge on one
of the edge's faces. BrepBuilder allows at most two faces per edge, hence at most two co-edges per edge,
and the co-edges must have opposite bCoEdgeIsReversed flags. The co-edges in a loop must be added in the
order in which they occur in loop (i.e., in their topological order).

#### Parameter `loopId`

Id of the loop containing the new co-edge.

#### Parameter `edgeId`

Id of the co-edge's edge, previously created by a call to addEdge().

#### Parameter `bCoEdgeIsReversed`

True if the co-edge's topological direction in its face is opposite to the edge's parametric direction, false otherwise.
The topological directions of the co-edges in a loop must be consistent with the direction in which the loop co-edges
appear in the loop, and the loop orientations so defined must follow the convention that outer loops are oriented
counter-clockwise and inner loops are oriented clockwise, with respect to the face's orientation.

#### Returns

Id of the edge, to be used in calls to other BRepBuilder methods such as AddCoEdge().

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The supplied loop id doesn't correspond to a loop stored in this BRepBuilder object.
-or-
The supplied edge id doesn't correspond to an edge stored in this BRepBuilder object.
-or-
FinishLoop() has already been called on loopId.
-or-
The edge already has two coedges associated to it.
-or-
Inconsistent use of the edge by co-edges is detected: both co-edges have the same bCoedgeIsReversed parameter.
-or-
The edge has already been added to this face.
-or-
There is a gap between this co-edge and the previous co-edge in the loop.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This BRepBuilder object isn't accepting new data, either because it has already been used to build geometry, or because of an error.
Consult the State property of the BRepBuilder object for more details.

#### Since

2016

### `M:Autodesk.Revit.DB.BRepBuilder.AddEdge(Autodesk.Revit.DB.BRepBuilderEdgeGeometry)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilder.AddEdge(Autodesk.Revit.DB.BRepBuilderEdgeGeometry)`

#### Summary

Add a new edge to the geometry being built. The BRepBuilder uses edges only to store edge geometry and to track
pairs of co-edges that share an edge.

#### Parameter `edgeGeom`

Information specifying the edge's geometry.

#### Returns

Id of the edge, to be used in calls to other BRepBuilder methods such as AddCoEdge().

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input edge geometry was invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This BRepBuilder object isn't accepting new data, either because it has already been used to build geometry, or because of an error.
Consult the State property of the BRepBuilder object for more details.

#### Since

2016

### `M:Autodesk.Revit.DB.BRepBuilder.FinishLoop(Autodesk.Revit.DB.BRepBuilderGeometryId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilder.FinishLoop(Autodesk.Revit.DB.BRepBuilderGeometryId)`

#### Summary

Indicates that the caller has finished defining the given loop.

#### Remarks

No functions that modify the given loop's definition should be called after calling this function (e.g., `M:Autodesk.Revit.DB.BRepBuilder.AddCoEdge(Autodesk.Revit.DB.BRepBuilderGeometryId,Autodesk.Revit.DB.BRepBuilderGeometryId,System.Boolean)` ).
The BRepBuilder may take the opportunity to validate some of the loop's data and report any problems it finds.

#### Parameter `loopId`

Id of the loop.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The supplied loop id doesn't correspond to a loop stored in this BRepBuilder object.
-or-
FinishLoop() has already been called on loopId.
-or-
The edge loop has fewer than two co-edges.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.BRepBuilder.AddLoop(Autodesk.Revit.DB.BRepBuilderGeometryId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilder.AddLoop(Autodesk.Revit.DB.BRepBuilderGeometryId)`

#### Summary

Creates an empty loop in a given face of the geometry being built. Other BRepBuilder methods are used to add co-edges to the loop.

#### Parameter `faceId`

Id of the face to which the loop should be added. faceId was returned by a call to AddFace().

#### Returns

An id that can be used to identify the loop while the BRepBuilder is actively building geometry (e.g., to add co-edges to the loop).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The supplied face id doesn't correspond to a face stored in this BRepBuilder object.
-or-
FinishFace() has already been called on faceId.
-or-
Please finish the previous loop by calling FinishLoop() before adding a new one.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This BRepBuilder object isn't accepting new data, either because it has already been used to build geometry, or because of an error.
Consult the State property of the BRepBuilder object for more details.

#### Since

2016

### `M:Autodesk.Revit.DB.BRepBuilder.SetFaceMaterialId(Autodesk.Revit.DB.BRepBuilderGeometryId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilder.SetFaceMaterialId(Autodesk.Revit.DB.BRepBuilderGeometryId,Autodesk.Revit.DB.ElementId)`

#### Summary

Sets material id to a face.

#### Parameter `faceId`

Id of the face to which material id will be added. faceId was returned by a call to AddFace().

#### Parameter `materialId`

The material id associated with the face, or invalidElementId if none.
It is not verified that materialId corresponds to a valid Material element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The supplied face id doesn't correspond to a face stored in this BRepBuilder object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This BRepBuilder object isn't accepting new data, either because it has already been used to build geometry, or because of an error.
Consult the State property of the BRepBuilder object for more details.

#### Since

2016

### `M:Autodesk.Revit.DB.BRepBuilder.FinishFace(Autodesk.Revit.DB.BRepBuilderGeometryId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilder.FinishFace(Autodesk.Revit.DB.BRepBuilderGeometryId)`

#### Summary

Indicates that the caller has finished defining the given face.

#### Remarks

No functions that modify the given face's definition should be called after calling this function (e.g., `M:Autodesk.Revit.DB.BRepBuilder.AddLoop(Autodesk.Revit.DB.BRepBuilderGeometryId)` , `M:Autodesk.Revit.DB.BRepBuilder.SetFaceMaterialId(Autodesk.Revit.DB.BRepBuilderGeometryId,Autodesk.Revit.DB.ElementId)` ).
The BRepBuilder may take the opportunity to validate some of the face's data and report any problems it finds.

#### Parameter `faceId`

Id of the face.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The supplied face id doesn't correspond to a face stored in this BRepBuilder object.
-or-
FinishFace() has already been called on faceId.
-or-
The face has no edge loops.
-or-
FinishLoop() must be called on all the edge loops of faceId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.BRepBuilder.AddFace(Autodesk.Revit.DB.BRepBuilderSurfaceGeometry,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilder.AddFace(Autodesk.Revit.DB.BRepBuilderSurfaceGeometry,System.Boolean)`

#### Summary

Creates an empty face in the geometry being built. Other BRepBuilder methods are used to add loops to the face.

#### Parameter `surfaceGeom`

The face's support surface.

#### Parameter `bFaceIsReversed`

True if the face's orientation is opposite to that of the surface, false if the orientations agree.
The faces of each shell must be consistently oriented. For a solid (BRepType == Solid), the oriented face normals
must point out of the solid; for a void (BRepType == Void), the face normals must point into the void.
See the description of the bCoEdgeIsReversed input for AddCoEdge() for a discussion of the loop and co-edge orientation conventions
to use with the BRepBuilder.

#### Returns

An id that can be used to identify the face while the BRepBuilder is actively building geometry (e.g., to add a loop to a face).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This BRepBuilder object isn't accepting new data, either because it has already been used to build geometry, or because of an error.
Consult the State property of the BRepBuilder object for more details.

#### Since

2016

### `M:Autodesk.Revit.DB.BRepBuilder.#ctor(Autodesk.Revit.DB.BRepType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilder.#ctor(Autodesk.Revit.DB.BRepType)`

#### Summary

Construct a BRepBuilder to use in constructing geometry.

#### Parameter `geomType`

Specifies the expected type of the output geometry.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2016

### `T:Autodesk.Revit.DB.BRepBuilder`

Member kind: type
Symbol: `Autodesk.Revit.DB.BRepBuilder`

#### Summary

A class that allows direct construction of geometry objects (solids, open shells, etc.).

#### Since

2016

### `M:Autodesk.Revit.DB.BRepBuilderGeometryId.InvalidGeometryId`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilderGeometryId.InvalidGeometryId`

#### Summary

Returns an invalid BRepBuilderGeometryId, used as a return value to indicate an error.

#### Since

2016

### `P:Autodesk.Revit.DB.BRepBuilderGeometryId.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.BRepBuilderGeometryId.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.BRepBuilderGeometryId.#ctor(Autodesk.Revit.DB.BRepBuilderGeometryId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BRepBuilderGeometryId.#ctor(Autodesk.Revit.DB.BRepBuilderGeometryId)`

#### Summary

Copy constructor

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `T:Autodesk.Revit.DB.BRepBuilderGeometryId`

Member kind: type
Symbol: `Autodesk.Revit.DB.BRepBuilderGeometryId`

#### Summary

This class is used by the BRepBuilder class to identify objects it creates (faces, edges, etc.).

#### Remarks

The user should use these ids to organize the calls to BRepBuilder methods (e.g., addLoop() takes a face id as input,
referring to a face that was previously added by a call to AddFace()). The ids are only valid while the BRepBuilder is in use.

#### Since

2016

### `T:Autodesk.Revit.DB.BRepBuilderOutcome`

Member kind: type
Symbol: `Autodesk.Revit.DB.BRepBuilderOutcome`

#### Summary

This class defines possible outcomes returned by BRepBuilder functions that need to report outcome via a return value.

#### Since

2017

#### Summary

This enumerated type corresponds to possible outcomes returned by BRepBuilder functions.

#### Since

2017

### `F:Autodesk.Revit.DB.BRepBuilderOutcome.Failure`

Member kind: field
Symbol: `Autodesk.Revit.DB.BRepBuilderOutcome.Failure`

#### Summary

Unspecified failure. BRepBuilder object is in invalid state and should not be used.

### `F:Autodesk.Revit.DB.BRepBuilderOutcome.Success`

Member kind: field
Symbol: `Autodesk.Revit.DB.BRepBuilderOutcome.Success`

#### Summary

The function has completed successfully.

### `T:Autodesk.Revit.DB.BRepBuilderState`

Member kind: type
Symbol: `Autodesk.Revit.DB.BRepBuilderState`

#### Summary

This class defines an enumerative type used to specify the state of a BRepBuilder object.

#### Since

2017

#### Summary

This enumerative type corresponds to the possible states of a BRepBuilder object.

#### Since

2017

### `F:Autodesk.Revit.DB.BRepBuilderState.Completed`

Member kind: field
Symbol: `Autodesk.Revit.DB.BRepBuilderState.Completed`

#### Summary

Finish() successfully created a valid Geometry object. No new data may be added.The built object may be retrieved via GetResult().

### `F:Autodesk.Revit.DB.BRepBuilderState.AcceptingData`

Member kind: field
Symbol: `Autodesk.Revit.DB.BRepBuilderState.AcceptingData`

#### Summary

BRepBuilder is accumulating data. New b-rep components such as edges or faces may be added.

### `F:Autodesk.Revit.DB.BRepBuilderState.InvalidState`

Member kind: field
Symbol: `Autodesk.Revit.DB.BRepBuilderState.InvalidState`

#### Summary

BRepBuilder is in an invalid state. No further productive use is possible.

### `T:Autodesk.Revit.DB.BRepType`

Member kind: type
Symbol: `Autodesk.Revit.DB.BRepType`

#### Summary

This class defines an enumerative type used to specify the type of output geometry expected from a BRepBuilder.

#### Since

2016

#### Since

2016

### `F:Autodesk.Revit.DB.BRepType.Void`

Member kind: field
Symbol: `Autodesk.Revit.DB.BRepType.Void`

#### Summary

The output geometry is expected to represent a (possibly disconnected) void (i.e., an inverted solid).

### `F:Autodesk.Revit.DB.BRepType.Solid`

Member kind: field
Symbol: `Autodesk.Revit.DB.BRepType.Solid`

#### Summary

The output geometry is expected to represent a (possibly disconnected) solid.

### `F:Autodesk.Revit.DB.BRepType.OpenShell`

Member kind: field
Symbol: `Autodesk.Revit.DB.BRepType.OpenShell`

#### Summary

The output geometry is expected to represent an open shell.

### `P:Autodesk.Revit.DB.ShapeBuilder.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.ShapeBuilder.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.ShapeBuilder`

Member kind: type
Symbol: `Autodesk.Revit.DB.ShapeBuilder`

#### Summary

The base class for geometry builder classes.

#### Since

2016

### `P:Autodesk.Revit.DB.SpatialElementTag.SpatialElementTagType`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElementTag.SpatialElementTagType`

#### Summary

The spatial element tag type.

### `P:Autodesk.Revit.DB.SpatialElementTag.SpatialElement`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElementTag.SpatialElement`

#### Summary

The element that the tag is associated with.

#### Remarks

Gives you the SpatialElement (native RoomElem) that this tag is tagging. This may return NULL under some circumstances,
for example when an old-style non-attached detail group with a room tag has been saved out to a file.

### `P:Autodesk.Revit.DB.SpatialElementTag.View`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElementTag.View`

#### Summary

The view in which the tag was placed.

### `P:Autodesk.Revit.DB.SpatialElementTag.LeaderElbow`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElementTag.LeaderElbow`

#### Summary

The position of the leader's elbow (middle point).

#### Remarks

Returns the elbow point of the tag leader.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no leader for this tag.
-or-
When setting this property: SpatialElementTag is pinned.
-or-
When setting this property: SpatialElementTag is orphaned.

#### Since

2017

### `P:Autodesk.Revit.DB.SpatialElementTag.LeaderEnd`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElementTag.LeaderEnd`

#### Summary

The position of the leader's end.

#### Remarks

Returns the end point of the tag leader.
Leader end point must be located inside of a room, space or an area.
Use Room.IsPointInRoom or Space.IsPointInSpace method to check whether the leaderEnd is located in the host element or not.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The point is located outside of the spatial element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no leader for this tag.
-or-
When setting this property: SpatialElementTag is pinned.
-or-
When setting this property: SpatialElementTag is orphaned.

#### Since

2017

### `P:Autodesk.Revit.DB.SpatialElementTag.TagHeadPosition`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElementTag.TagHeadPosition`

#### Summary

The position of the tag's head.

#### Remarks

Returns the end point of the tag leader.
Leader end point must be located inside of a room, space or an area.
Use Room.IsPointInRoom or Space.IsPointInSpace method to check whether the leaderEnd is located in the host element or not.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: Head position of the tag with no leader could not be located outside of the host element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: SpatialElementTag is pinned.
-or-
When setting this property: SpatialElementTag is orphaned.

#### Since

2017

### `P:Autodesk.Revit.DB.SpatialElementTag.TagText`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElementTag.TagText`

#### Summary

The text displayed by the tag.

#### Remarks

If there are several strings included in the tag, the strings will be returned concatenated.

#### Since

2018

### `P:Autodesk.Revit.DB.SpatialElementTag.RotationAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElementTag.RotationAngle`

#### Summary

The rotation angle of the tag relative to its view

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: Angle can only be changed for Model orientation

#### Since

2022

### `P:Autodesk.Revit.DB.SpatialElementTag.TagOrientation`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElementTag.TagOrientation`

#### Summary

The orientation of the tag.

#### Remarks

See `!:Autodesk::Revit::DB::getSpatialElementTagOrientation` for the supported orientations.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2017

### `P:Autodesk.Revit.DB.SpatialElementTag.HasElbow`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElementTag.HasElbow`

#### Summary

Identifies if the tag's leader has an elbow point or not.

#### Remarks

Straight leaders do not have elbow points. Use `P:Autodesk.Revit.DB.SpatialElementTag.LeaderElbow` to get or set elbow point.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no leader for this tag.

### `P:Autodesk.Revit.DB.SpatialElementTag.HasLeader`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElementTag.HasLeader`

#### Summary

Identifies if a leader is displayed for the tag or not.

#### Value

True if a leader is displayed, otherwise false.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: SpatialElementTag is orphaned.
-or-
When setting this property: Thrown when attempting to turn off leader of the pinned tag
when the tag's head position is located outside off the host element.

### `P:Autodesk.Revit.DB.SpatialElementTag.IsTaggingLink`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElementTag.IsTaggingLink`

#### Summary

Identifies if the tag has reference to a spatial element in a linked document or not.

#### Since

2017

### `P:Autodesk.Revit.DB.SpatialElementTag.IsOrphaned`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElementTag.IsOrphaned`

#### Summary

Identifies if the tag is orphaned or not.

#### Remarks

The orphan tags are used to tag a spatial element in a link document, but the spatial element was deleted.

#### Since

2017

### `P:Autodesk.Revit.DB.SpatialElementTag.Location`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElementTag.Location`

#### Summary

The location of the tag.

#### Remarks

Allows you to get and set the location of the tag within the level. The
Z location should be the elevation of the level and is not changeable.

### `T:Autodesk.Revit.DB.SpatialElementTag`

Member kind: type
Symbol: `Autodesk.Revit.DB.SpatialElementTag`

#### Summary

A tag attached to a SpatialElement (room, space or area) in Autodesk Revit.

#### Remarks

SpatialElementTag is the base class for RoomTag, SpaceTag and AreaTag.
Zone tag is not derived from SpatialElementTag. See `!:Autodesk::Revit::DB::IndependentTag` for more information.

### `T:Autodesk.Revit.DB.SpatialElementTagOrientation`

Member kind: type
Symbol: `Autodesk.Revit.DB.SpatialElementTagOrientation`

#### Summary

An enumerated type listing tag orientation options that are supported by SpatialElementTags.

### `F:Autodesk.Revit.DB.SpatialElementTagOrientation.Model`

Member kind: field
Symbol: `Autodesk.Revit.DB.SpatialElementTagOrientation.Model`

#### Summary

The Orientation of tag is Model.

### `F:Autodesk.Revit.DB.SpatialElementTagOrientation.Vertical`

Member kind: field
Symbol: `Autodesk.Revit.DB.SpatialElementTagOrientation.Vertical`

#### Summary

The Orientation of tag is Vertical.

### `F:Autodesk.Revit.DB.SpatialElementTagOrientation.Horizontal`

Member kind: field
Symbol: `Autodesk.Revit.DB.SpatialElementTagOrientation.Horizontal`

#### Summary

The Orientation of tag is Horizontal.

### `T:Autodesk.Revit.DB.Architecture.RoomTagType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.RoomTagType`

#### Summary

An object that represents a Room Tag type.

### `M:Autodesk.Revit.DB.Mechanical.Space.IsPointInSpace(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.Space.IsPointInSpace(Autodesk.Revit.DB.XYZ)`

#### Summary

Determines if a point lies within the volume of the Space.

#### Parameter `point`

Point to be checked.

#### Return

Returns true if the point is in the Space, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the point is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The coordinates of the point is not a number.

### `P:Autodesk.Revit.DB.Mechanical.Space.Plenum`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.Plenum`

#### Summary

Reports whether this zone is Plenum or not.

### `P:Autodesk.Revit.DB.Mechanical.Space.Occupiable`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.Occupiable`

#### Summary

Reports whether this zone is Occupiable or not.

### `P:Autodesk.Revit.DB.Mechanical.Space.DesignPowerLoad`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.DesignPowerLoad`

#### Summary

Get or set the Design Power Load of the Space.

#### Remarks

This property is used to get or set the Design Power Load of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.ActualPowerLoad`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.ActualPowerLoad`

#### Summary

Get the Actual Power Load of the Space.

#### Remarks

This property is used to get the Actual Power Load of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.PowerLoadUnit`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.PowerLoadUnit`

#### Summary

Get or set the Power Load Unit of the Space.

#### Remarks

This property is used to get or set the Power Load Unit of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.DesignLightingLoad`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.DesignLightingLoad`

#### Summary

Get or set the Design Lighting Load of the Space.

#### Remarks

This property is used to get or set the Design Lighting Load of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.ActualLightingLoad`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.ActualLightingLoad`

#### Summary

Get the Actual Lighting Load of the Space.

#### Remarks

This property is used to get the Actual Lighting Load of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.LightingLoadUnit`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.LightingLoadUnit`

#### Summary

Get or set the Lighting Load Unit of the Space.

#### Remarks

This property is used to get or set the Lighting Load Unit of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.LatentHeatGainperPerson`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.LatentHeatGainperPerson`

#### Summary

Get or set the Latent Heat Gain per Person of the Space.

#### Remarks

This property is used to get or set the Latent Heat Gain per Person of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.SensibleHeatGainperPerson`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.SensibleHeatGainperPerson`

#### Summary

Get or set the Sensible Heat Gain per Person of the Space.

#### Remarks

This property is used to get or set the Sensible Heat Gain per Person of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.AreaperPerson`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.AreaperPerson`

#### Summary

Get or set the Area per Person of the Space.

#### Remarks

This property is used to get or set Area per Person of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.NumberofPeople`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.NumberofPeople`

#### Summary

Get or set the Number of People of the Space.

#### Remarks

This property is used to get or set Number of People of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.BaseHeatLoadOn`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.BaseHeatLoadOn`

#### Summary

The heat load-on.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the values is not kUseDefaultLoad or kUseEnteredLoad.

### `P:Autodesk.Revit.DB.Mechanical.Space.OccupancyUnit`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.OccupancyUnit`

#### Summary

Get or set the Occupancy Unit of the Space.

#### Remarks

This property is used to get or set the Occupancy Unit of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.DesignCoolingLoad`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.DesignCoolingLoad`

#### Summary

Get or set the Design Cooling Load of the Space.

#### Remarks

This property is used to get or set the Design Cooling Load of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.CalculatedCoolingLoad`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.CalculatedCoolingLoad`

#### Summary

Get the Calculated Cooling Load of the Space.

#### Remarks

This property is used to get the Calculated Cooling Load of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.DesignHeatingLoad`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.DesignHeatingLoad`

#### Summary

Get or set the Design Heating Load of the Space.

#### Remarks

This property is used to get or set the Design Heating Load of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.CalculatedHeatingLoad`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.CalculatedHeatingLoad`

#### Summary

Get the Calculated Heating Load of the Space.

#### Remarks

This property is used to get the Calculated Heating Load of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.SpaceConstruction`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.SpaceConstruction`

#### Summary

Get the Space Construction of the Space.

#### Remarks

This property is used to get the Space Construction of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.SpaceTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.SpaceTypeId`

#### Summary

Get or set the Space type element of the Space.

#### Remarks

This property is used to get or set the Space type of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.SpaceType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.SpaceType`

#### Summary

Get or set the Space type of the Space.

#### Remarks

This property is used to get or set the Space type of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.ConditionType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.ConditionType`

#### Summary

Get or set the Condition type of the Space.

#### Remarks

This property is used to get or set the Condition type of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.Volume`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.Volume`

#### Summary

Get the Volume of the Space.

#### Remarks

This property is used to get the Volume of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.UnboundedHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.UnboundedHeight`

#### Summary

Get the Unbounded Height of the Space.

#### Remarks

This property is used to get the Unbounded Height of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.OutdoorAirFlowStandard`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.OutdoorAirFlowStandard`

#### Summary

Get the OutdoorAirFlowStandard of the Space.

#### Remarks

This property is used to get the OutdoorAirFlowStandard of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.OutdoorAirflow`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.OutdoorAirflow`

#### Summary

Get the Outdoor Airflow of the Space.

#### Remarks

This property is used to get the Outdoor Airflow (Unit: ft3/s) of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.AirChangesPerHour`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.AirChangesPerHour`

#### Summary

Get the Specified AirChangesPerHour of the Space.

#### Remarks

This property is used to get the Specified AirChangesPerHour of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.OutdoorAirPerArea`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.OutdoorAirPerArea`

#### Summary

Get the Specified OutdoorAirPerArea of the Space.

#### Remarks

This property is used to get the Specified OutdoorAirPerArea (Unit: ft/s) of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.OutdoorAirPerPerson`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.OutdoorAirPerPerson`

#### Summary

Get the Specified OutdoorAirPerPerson of the Space.

#### Remarks

This property is used to get the Specified OutdoorAirPerPerson (Unit: ft3/s) of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.ActualExhaustAirflow`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.ActualExhaustAirflow`

#### Summary

Get the Actual Exhaust Airflow of the Space.

#### Remarks

This property is used to get the Actual Exhaust Airflow (Unit: CFM) of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.DesignExhaustAirflow`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.DesignExhaustAirflow`

#### Summary

Get or set the Specified Exhaust Airflow of the Space.

#### Remarks

This property is used to get or set the Specified Exhaust Airflow (Unit: CFM) of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.ActualReturnAirflow`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.ActualReturnAirflow`

#### Summary

Get the Actual Return Airflow of the Space.

#### Remarks

This property is used to get the Actual Return Airflow (Unit: CFM) of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.DesignReturnAirflow`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.DesignReturnAirflow`

#### Summary

Get or set the Specified Return Airflow of the Space.

#### Remarks

This property is used to get or set the Specified Return Airflow (Unit: CFM) of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.ReturnAirflow`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.ReturnAirflow`

#### Summary

Get or set the Return type of Supply Airflow of the Space.

#### Remarks

This property is used to get or set the Return type of Supply Airflow of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.ActualSupplyAirflow`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.ActualSupplyAirflow`

#### Summary

Get the Actual Supply Airflow of the Space.

#### Remarks

This property is used to get the Actual Supply Airflow (Unit: CFM) of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.CalculatedSupplyAirflow`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.CalculatedSupplyAirflow`

#### Summary

Get the Calculated Supply Airflow of the Space.

#### Remarks

This property is used to get the Calculated Supply Airflow (Unit: CFM) of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.DesignSupplyAirflow`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.DesignSupplyAirflow`

#### Summary

Get or set the Specified Supply Airflow of the Space.

#### Remarks

This property is used to get or set the Specified Supply Airflow (Unit: CFM) of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.ActualOtherLoad`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.ActualOtherLoad`

#### Summary

Get the Actual Other Load of the Space.

#### Remarks

This property is used to get the Actual Other Load (Unit: W) of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.DesignOtherLoadperArea`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.DesignOtherLoadperArea`

#### Summary

Get or set the Design Other Load per Area of the Space.

#### Remarks

This property is used to get or set the Design Other Load per Area (Unit: W/ft2) of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.ActualHVACLoad`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.ActualHVACLoad`

#### Summary

Get the Actual HVAC Load of the Space.

#### Remarks

This property is used to get the Actual HVAC Load (Unit: W) of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.DesignHVACLoadperArea`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.DesignHVACLoadperArea`

#### Summary

Get or set the Design HVAC Load per Area of the Space.

#### Remarks

This property is used to get or set the Design HVAC Load per Area (Unit: W/ft2) of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.FloorReflectance`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.FloorReflectance`

#### Summary

Get or set the Floor Reflectance of the Space.

#### Remarks

This property is used to get or set the Floor Reflectance of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.WallReflectance`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.WallReflectance`

#### Summary

Get or set the Wall Reflectance of the Space.

#### Remarks

This property is used to get or set the Wall Reflectance of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.CeilingReflectance`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.CeilingReflectance`

#### Summary

Get or set the Ceiling Reflectance of the Space.

#### Remarks

This property is used to get or set the Ceiling Reflectance of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.LightingCalculationWorkplane`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.LightingCalculationWorkplane`

#### Summary

Get or set the Lighting Calculation Workplane of the Space.

#### Remarks

This property is used to get or set the Lighting Calculation Workplane (Unit: feet) of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.SpaceCavityRatio`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.SpaceCavityRatio`

#### Summary

Get the Space Cavity Ratio of the Space.

#### Remarks

This property is used to get the Space Cavity Ratio of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.AverageEstimatedIllumination`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.AverageEstimatedIllumination`

#### Summary

Get the Average Estimated Illumination of the Space.

#### Remarks

This property is used to get the Average Estimated Illumination of the Space. (Unit: fc)

### `P:Autodesk.Revit.DB.Mechanical.Space.BaseOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.BaseOffset`

#### Summary

Get or set the Base Offset of the Space.

#### Remarks

This property is used to get or set the Base Offset of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.LimitOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.LimitOffset`

#### Summary

Get or set the Limit Offset of the Space.

#### Remarks

This property is used to get or set the Limit Offset of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.UpperLimit`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.UpperLimit`

#### Summary

Get or set the Upper Limit of the Space.

#### Remarks

This property is used to get or set the Upper Limit of the Space.

### `P:Autodesk.Revit.DB.Mechanical.Space.Room`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.Room`

#### Summary

Return the Room of the space.

### `P:Autodesk.Revit.DB.Mechanical.Space.ClosedShell`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.ClosedShell`

#### Summary

Return the closedShell of the space.

### `P:Autodesk.Revit.DB.Mechanical.Space.Zone`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Space.Zone`

#### Summary

Reports this space belong to which Zone.

#### Remarks

This property is used to retrieve the host zone of this space.

### `T:Autodesk.Revit.DB.Mechanical.Space`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.Space`

#### Summary

Provides access to the space topology in Autodesk Revit.

#### Remarks

The space object can be queried for its boundary for use in space planning tools.

### `T:Autodesk.Revit.DB.Phase`

Member kind: type
Symbol: `Autodesk.Revit.DB.Phase`

#### Summary

Represents a phase in the life of a building.

#### Remarks

The lifetime of an element within a building can be controlled by using phases.
Each element will have a construction phase but only those elements that have a finite
lifetime will have a destruction phase. All the phases within a project can be retrieved
from the Document object.

### `M:Autodesk.Revit.DB.Mechanical.Zone.GetDomainData`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.Zone.GetDomainData`

#### Summary

Gets the domain data for the zone.

#### Returns

Returns a pointer to the base class for specific domain requirements for the zone.

#### Since

2023

### `M:Autodesk.Revit.DB.Mechanical.Zone.CreateAreaBasedLoad(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.Zone.CreateAreaBasedLoad(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new instance of an area based load and adds it to the document.

#### Parameter `doc`

The document where the element will be created and added.

#### Parameter `name`

The name of the area based load to be created.

#### Parameter `levelId`

The base level on which the area based load will be created.

#### Parameter `phaseId`

The associative phase on which the area based load is to exist.

#### Returns

The newly created area based load.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
-or-
name is an empty string.
-or-
The ElementId levelId is not a Level.
-or-
The id does not represent a valid phase.

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

2023

### `M:Autodesk.Revit.DB.Mechanical.Zone.RemoveSpaces(Autodesk.Revit.DB.Mechanical.SpaceSet)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.Zone.RemoveSpaces(Autodesk.Revit.DB.Mechanical.SpaceSet)`

#### Summary

Remove a set of existing spaces to the current Zone element.

#### Parameter `spaces`

The spaces which want to delete from the current zone element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the specified parameter Value is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the input spaces cannot be deleted from current zone element.

#### Returns

If successful the current zone element will remove a set of input spaces, otherwise `null` .

### `M:Autodesk.Revit.DB.Mechanical.Zone.AddSpaces(Autodesk.Revit.DB.Mechanical.SpaceSet)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.Zone.AddSpaces(Autodesk.Revit.DB.Mechanical.SpaceSet)`

#### Summary

Add a set of existing spaces to Zone element.

#### Parameter `spaces`

The spaces which want to add to zone element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the specified parameter Value is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the input spaces cannot be added to current zone element.

#### Returns

If successful the current zone element will add a set of input spaces, otherwise `null` .

### `P:Autodesk.Revit.DB.Mechanical.Zone.DehumidificationSetPoint`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Zone.DehumidificationSetPoint`

#### Summary

Get or set the DeHumidification Set Point of the Zone.

#### Remarks

This property is used to get or set the DeHumidification Set Point of the Zone.

### `P:Autodesk.Revit.DB.Mechanical.Zone.HumidificationSetPoint`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Zone.HumidificationSetPoint`

#### Summary

Get or set the Humidification Set Point of the Zone.

#### Remarks

This property is used to get or set the Humidification Set Point of the Zone.

### `P:Autodesk.Revit.DB.Mechanical.Zone.CoolingAirTemperature`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Zone.CoolingAirTemperature`

#### Summary

Get or set the Cooling Air Temperature of the Zone.

#### Remarks

This property is used to get or set the Cooling Air Temperature of the Zone.

### `P:Autodesk.Revit.DB.Mechanical.Zone.HeatingAirTemperature`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Zone.HeatingAirTemperature`

#### Summary

Get or set the Heating Air Temperature of the Zone.

#### Remarks

This property is used to get or set the Heating Air Temperature of the Zone.

### `P:Autodesk.Revit.DB.Mechanical.Zone.CoolingSetPoint`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Zone.CoolingSetPoint`

#### Summary

Get or set the Cooling Set Point of the Zone.

#### Remarks

This property is used to get or set the Cooling Set Point of the Zone.

### `P:Autodesk.Revit.DB.Mechanical.Zone.HeatingSetPoint`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Zone.HeatingSetPoint`

#### Summary

Get or set the Heating Set Point of the Zone.

#### Remarks

This property is used to get or set the Heating Set Point of the Zone.

### `P:Autodesk.Revit.DB.Mechanical.Zone.CalculatedCoolingLoad`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Zone.CalculatedCoolingLoad`

#### Summary

Get the Calculated Cooling Load of the Zone.

#### Remarks

This property is used to get the Calculated Cooling Load of the Zone.

### `P:Autodesk.Revit.DB.Mechanical.Zone.CalculatedHeatingLoad`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Zone.CalculatedHeatingLoad`

#### Summary

Get the Calculated Heating Load of the Zone.

#### Remarks

This property is used to get the Calculated Heating Load of the Zone.

### `P:Autodesk.Revit.DB.Mechanical.Zone.CalculatedSupplyAirflow`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Zone.CalculatedSupplyAirflow`

#### Summary

Get the Calculated Supply Airflow of the Zone.

#### Remarks

This property is used to get the Calculated Supply Airflow (Unit: Airflow ) of the Zone.

### `P:Autodesk.Revit.DB.Mechanical.Zone.ServiceType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Zone.ServiceType`

#### Summary

Get or set the Service Type of the Zone.

#### Remarks

This property is used to get or set the Service Type of the Zone.

### `P:Autodesk.Revit.DB.Mechanical.Zone.Boundary`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Zone.Boundary`

#### Summary

Returns the boundary of the Zone.

#### Remarks

This property is used to retrieve the segments that constitute the boundary of the Zone.
Each Zone may have several regions, each of which have several segments hence the data is returned
in the form of an array of boundary segment arrays. See the Zone.BoundarySegment object for more
details about the segments that make up the Zone topology.

### `P:Autodesk.Revit.DB.Mechanical.Zone.Spaces`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Zone.Spaces`

#### Summary

Get the Spaces of the Zone.

#### Remarks

This property is used to get the Spaces of the Zone.

### `P:Autodesk.Revit.DB.Mechanical.Zone.Perimeter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Zone.Perimeter`

#### Summary

Get the Perimeter of the Zone.

#### Remarks

This property is used to get the Perimeter of the Zone.

### `P:Autodesk.Revit.DB.Mechanical.Zone.GrossVolume`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Zone.GrossVolume`

#### Summary

Get the Gross Volume of the Zone.

#### Remarks

This property is used to get the Gross Volume of the Zone.

### `P:Autodesk.Revit.DB.Mechanical.Zone.Volume`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Zone.Volume`

#### Summary

Get the Volume of the Zone.

#### Remarks

This property is used to get the Volume of the Zone.

### `P:Autodesk.Revit.DB.Mechanical.Zone.GrossArea`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Zone.GrossArea`

#### Summary

Get the Gross Area of the Zone.

#### Remarks

This property is used to get the Gross Area of the Zone.

### `P:Autodesk.Revit.DB.Mechanical.Zone.Area`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Zone.Area`

#### Summary

Get the Area of the Zone.

#### Remarks

This property is used to get the Area of the Zone.

### `P:Autodesk.Revit.DB.Mechanical.Zone.IsDefaultZone`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Zone.IsDefaultZone`

#### Summary

Reports whether this zone is default or not.

#### Remarks

This property can be used to set the current zone as the default zone.

### `P:Autodesk.Revit.DB.Mechanical.Zone.Phase`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Zone.Phase`

#### Summary

Get the Phase of the Zone.

#### Remarks

This property is used to get the Phase of the Zone.

### `P:Autodesk.Revit.DB.Mechanical.Zone.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.Zone.Name`

#### Summary

Get or Set the Name of the Zone.

#### Remarks

This property is used to get or set the Name of the Zone.

### `T:Autodesk.Revit.DB.Mechanical.Zone`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.Zone`

#### Summary

A zone is a collection of one or more spaces.

#### Remarks

The concept of zones is central to the way in which engineers
design HVAC systems. When you are designing HVAC systems, you
relate to zones as spaces that are under the same thermostatic
control. Conceptually, zones are an arbitrary set of areas or
volumes within a building that is controlled by one thermostat.
An area based load is a collection of one or more electrical
load areas. When it has the AreaBasedLoadData, it is an area
based load, otherwise, it is a zone.

### `P:Autodesk.Revit.DB.TilePattern.TilesPerSeedNode`

Member kind: property
Symbol: `Autodesk.Revit.DB.TilePattern.TilesPerSeedNode`

#### Summary

Get the number of tiles located at each seed node.

#### Remarks

Currently the number of tiles per seed node is
always either 1 or 2.

### `P:Autodesk.Revit.DB.TilePattern.TilePatternType`

Member kind: property
Symbol: `Autodesk.Revit.DB.TilePattern.TilePatternType`

#### Summary

The built-in system tile pattern specified by
this object.

### `T:Autodesk.Revit.DB.TilePattern`

Member kind: type
Symbol: `Autodesk.Revit.DB.TilePattern`

#### Summary

An object representing a tile pattern that may
be applied to a DividedSurface.

#### Remarks

TilePatterns cannot be created.
A fixed selection is built into each Conceptual Mass
family. TilePatterns can be retrieved by key from the
Revit::DB::Document::Settings::TilePatternTable object.

### `M:Autodesk.Revit.DB.TilePatterns.GetTilePattern(Autodesk.Revit.DB.TilePatternsBuiltIn)`

Member kind: method
Symbol: `Autodesk.Revit.DB.TilePatterns.GetTilePattern(Autodesk.Revit.DB.TilePatternsBuiltIn)`

#### Summary

Retrieve a TilePattern object from a built-in type.

#### Returns

A TilePattern object, or `null` if the document is not a
Massing Family.

### `T:Autodesk.Revit.DB.TilePatterns`

Member kind: type
Symbol: `Autodesk.Revit.DB.TilePatterns`

#### Summary

The TilePatterns object is an interface for retrieving the TilePattern objects
within the Document.

### `M:Trf.#ctor(Trf!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `Trf.#ctor(Trf!System.Runtime.CompilerServices.IsConst*)`

### `M:Autodesk.Revit.DB.SubTransaction.HasEnded`

Member kind: method
Symbol: `Autodesk.Revit.DB.SubTransaction.HasEnded`

#### Summary

Determines whether the sub-transaction has ended already.

#### Remarks

A sub-transaction is ended by completing either the `M:Autodesk.Revit.DB.SubTransaction.Commit`
or `M:Autodesk.Revit.DB.SubTransaction.RollBack` method.
Another way of testing whether a sub-transaction has ended is by testing
its current status returned from (see `M:Autodesk.Revit.DB.SubTransaction.GetStatus` ). It must be either
'TransactionStatus.Committed' or 'TransactionStatus.RolledBack'

#### Returns

True if the sub-transaction has already been committed or rolled back, False otherwise.

#### Since

2011

### `M:Autodesk.Revit.DB.SubTransaction.HasStarted`

Member kind: method
Symbol: `Autodesk.Revit.DB.SubTransaction.HasStarted`

#### Summary

Determines whether the sub-transaction has been started yet.

#### Remarks

A sub-transaction is considered being started after the `M:Autodesk.Revit.DB.SubTransaction.Start`
method was called and until the sub-transaction is either committed or rolled back.

#### Returns

True if the sub-transaction has already started, False otherwise.

#### Since

2011

### `M:Autodesk.Revit.DB.SubTransaction.GetStatus`

Member kind: method
Symbol: `Autodesk.Revit.DB.SubTransaction.GetStatus`

#### Summary

Returns the current status of the sub-transaction.

#### Returns

The current status of the sub-transaction.

#### Since

2011

### `M:Autodesk.Revit.DB.SubTransaction.RollBack`

Member kind: method
Symbol: `Autodesk.Revit.DB.SubTransaction.RollBack`

#### Summary

Discards all changes made to the model during the sub-transaction.

#### Remarks

The parent transaction (or a parent sub-transaction, if any)
can still be committed, but the changes rolled back by this
method will not be part of the committed transaction.

RollBack can be called only when all inner sub-transaction, if any, are finished,
i.e. they were either committed or rolled back. If there is still a sub-transaction open,
an attempt to roll this outer sub-transaction back will cause an exception.

#### Returns

If finished successfully, this method returns TransactionStatus.RolledBack.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

A sub-transaction can only be active inside an open Transaction.
-or-
The sub-transaction's current status is not TransactionStatus.Started,
therefore it may not be committed or rolled back.

#### Since

2011

### `M:Autodesk.Revit.DB.SubTransaction.Commit`

Member kind: method
Symbol: `Autodesk.Revit.DB.SubTransaction.Commit`

#### Summary

Commits all changes made to the model made during the sub-transaction.

#### Remarks

The changes are not permanently committed to the document yet. They will be
committed only when the active transaction is committed. If the transaction
is rolled back instead, the changes committed during this sub-transaction will be discarded.

Commit can be called only when all inner sub-transactions, if any, are already finished,
i.e. they were either committed or rolled back. If there is still a sub-transaction open,
an attempt to commit this outer sub-transaction will cause an exception.

#### Returns

If finished successfully, this method returns TransactionStatus.Committed

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

A sub-transaction can only be active inside an open Transaction.
-or-
The sub-transaction's current status is not TransactionStatus.Started,
therefore it may not be committed or rolled back.

#### Since

2011

### `M:Autodesk.Revit.DB.SubTransaction.Start`

Member kind: method
Symbol: `Autodesk.Revit.DB.SubTransaction.Start`

#### Summary

Starts the sub-transaction.

#### Remarks

A sub-transaction can only be started in an open transaction,
and it must be closed (committed or rolled back) while still inside the open transaction.

A sub-transaction can be started in another open sub-transaction,
but then it must be closed before the parent sub-transaction is closed.

#### Returns

If started successfully, this method returns TransactionStatus.Started.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Cannot modify the document for either a read-only external command is being executed, or changes to the document are temporarily disabled.
-or-
A sub-transaction can only be active inside an open Transaction.
-or-
The sub-transaction was already started and has not finished yet.

#### Since

2011

### `P:Autodesk.Revit.DB.SubTransaction.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.SubTransaction.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.SubTransaction.#ctor(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SubTransaction.#ctor(Autodesk.Revit.DB.Document)`

#### Summary

Instantiates a sub-transaction object

#### Parameter `document`

The document for which this sub-transaction is going to be used.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `T:Autodesk.Revit.DB.SubTransaction`

Member kind: type
Symbol: `Autodesk.Revit.DB.SubTransaction`

#### Summary

Sub-transactions are objects that provide control over a subset of changes in a document.

#### Remarks

A Sub-transaction can only be active as a part of an open transaction.
Sub-transactions may be nested inside each other, but with the restriction
that every nested sub-transaction is entirely contained (opened and closed)
in the parent sub-transaction.

If a sub-transaction was started and not committed or rolled back by the time
the SubTransaction object is about to be disposed, the destructor will roll back the
sub-transaction automatically, thus all changes made to the document during the
sub-transaction will be discarded. It is not recommended to rely on this default
behavior though. Instead, it is advised to always call either `M:Autodesk.Revit.DB.SubTransaction.Commit`
or `M:Autodesk.Revit.DB.SubTransaction.RollBack` explicitly before the sub-transaction
object gets disposed.
Please note that unless invoked explicitly the actual destruction of an object
in managed code might not happen until the object is collected by the garbage collector.

#### Since

2011

### `T:Autodesk.Revit.DB.Electrical.WireTypeSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.WireTypeSetIterator`

#### Summary

An iterator to a wire type set.

### `T:Autodesk.Revit.DB.Electrical.WireTypeSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.WireTypeSet`

#### Summary

A set that contains wire types.

### `P:Autodesk.Revit.DB.Electrical.WireTypeSetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.WireTypeSetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.Electrical.WireTypeSetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireTypeSetIterator.MoveNext`

#### Returntype

System.Boolean

#### Summary

Move the iterator one item forward.

#### Returns

Returns True if the iterator was successfully moved forward one item and the Current
property will return a valid item. False will be returned it the iterator has reached the end of
the set.

#### Remarks

MoveNext must be called before the Current property is valid with a new or Reset iterator
in line with the expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.Electrical.WireTypeSetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireTypeSetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.Electrical.WireTypeSetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireTypeSetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.Electrical.WireTypeSet.Insert(Autodesk.Revit.DB.Electrical.WireType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireTypeSet.Insert(Autodesk.Revit.DB.Electrical.WireType)`

#### Returntype

System.Int32

#### Summary

Insert the specified wire type into the set.

#### Parameter `item`

The wire type to be inserted into the set.

#### Returns

Returns whether the wire type was inserted into the set.

### `M:Autodesk.Revit.DB.Electrical.WireTypeSet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireTypeSet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.Electrical.WireTypeSet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireTypeSet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.Electrical.WireTypeSetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.Electrical.WireTypeSet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireTypeSet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.Electrical.WireTypeSetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.Electrical.WireTypeSet.Erase(Autodesk.Revit.DB.Electrical.WireType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireTypeSet.Erase(Autodesk.Revit.DB.Electrical.WireType)`

#### Returntype

System.Int32

#### Summary

Removes a specified wire type from the set.

#### Parameter `item`

The wire type to be erased.

#### Returns

The number of wire types that were erased from the set.

### `M:Autodesk.Revit.DB.Electrical.WireTypeSet.Contains(Autodesk.Revit.DB.Electrical.WireType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireTypeSet.Contains(Autodesk.Revit.DB.Electrical.WireType)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of a wire type within the set.

#### Parameter `item`

The wire type to be searched for.

#### Returns

The Contains method returns True if the wire type is within the set, otherwise False.

### `M:Autodesk.Revit.DB.Electrical.WireTypeSet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireTypeSet.Clear`

#### Returntype

void

#### Summary

Removes every wire type from the set, rendering it empty.

### `P:Autodesk.Revit.DB.Electrical.WireTypeSet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.WireTypeSet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of wire types that are in the set.

### `P:Autodesk.Revit.DB.Electrical.WireTypeSet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.WireTypeSet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.Electrical.InsulationTypeSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.InsulationTypeSetIterator`

#### Summary

An iterator to a insulation type set.

### `T:Autodesk.Revit.DB.Electrical.InsulationTypeSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.InsulationTypeSet`

#### Summary

A set that contains insulation types.

### `P:Autodesk.Revit.DB.Electrical.InsulationTypeSetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.InsulationTypeSetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.Electrical.InsulationTypeSetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.InsulationTypeSetIterator.MoveNext`

#### Returntype

System.Boolean

#### Summary

Move the iterator one item forward.

#### Returns

Returns True if the iterator was successfully moved forward one item and the Current
property will return a valid item. False will be returned it the iterator has reached the end of
the set.

#### Remarks

MoveNext must be called before the Current property is valid with a new or Reset iterator
in line with the expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.Electrical.InsulationTypeSetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.InsulationTypeSetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.Electrical.InsulationTypeSetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.InsulationTypeSetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.Electrical.InsulationTypeSet.Insert(Autodesk.Revit.DB.Electrical.InsulationType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.InsulationTypeSet.Insert(Autodesk.Revit.DB.Electrical.InsulationType)`

#### Returntype

System.Int32

#### Summary

Insert the specified insulation type into the set.

#### Parameter `item`

The insulation type to be inserted into the set.

#### Returns

Returns whether the insulation type was inserted into the set.

### `M:Autodesk.Revit.DB.Electrical.InsulationTypeSet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.InsulationTypeSet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.Electrical.InsulationTypeSet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.InsulationTypeSet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.Electrical.InsulationTypeSetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.Electrical.InsulationTypeSet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.InsulationTypeSet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.Electrical.InsulationTypeSetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.Electrical.InsulationTypeSet.Erase(Autodesk.Revit.DB.Electrical.InsulationType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.InsulationTypeSet.Erase(Autodesk.Revit.DB.Electrical.InsulationType)`

#### Returntype

System.Int32

#### Summary

Removes a specified insulation type from the set.

#### Parameter `item`

The insulation type to be erased.

#### Returns

The number of insulation types that were erased from the set.

### `M:Autodesk.Revit.DB.Electrical.InsulationTypeSet.Contains(Autodesk.Revit.DB.Electrical.InsulationType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.InsulationTypeSet.Contains(Autodesk.Revit.DB.Electrical.InsulationType)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of a insulation type within the set.

#### Parameter `item`

The insulation type to be searched for.

#### Returns

The Contains method returns True if the insulation type is within the set, otherwise False.

### `M:Autodesk.Revit.DB.Electrical.InsulationTypeSet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.InsulationTypeSet.Clear`

#### Returntype

void

#### Summary

Removes every insulation type from the set, rendering it empty.

### `P:Autodesk.Revit.DB.Electrical.InsulationTypeSet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.InsulationTypeSet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of insulation types that are in the set.

### `P:Autodesk.Revit.DB.Electrical.InsulationTypeSet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.InsulationTypeSet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSetIterator`

#### Summary

An iterator to a TemperatureRating type set.

### `T:Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSet`

#### Summary

A set that contains TemperatureRating types.

### `P:Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSetIterator.MoveNext`

#### Returntype

System.Boolean

#### Summary

Move the iterator one item forward.

#### Returns

Returns True if the iterator was successfully moved forward one item and the Current
property will return a valid item. False will be returned it the iterator has reached the end of
the set.

#### Remarks

MoveNext must be called before the Current property is valid with a new or Reset iterator
in line with the expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSet.Insert(Autodesk.Revit.DB.Electrical.TemperatureRatingType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSet.Insert(Autodesk.Revit.DB.Electrical.TemperatureRatingType)`

#### Returntype

System.Int32

#### Summary

Insert the specified TemperatureRating type into the set.

#### Parameter `item`

The TemperatureRating type to be inserted into the set.

#### Returns

Returns whether the TemperatureRating type was inserted into the set.

### `M:Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSet.Erase(Autodesk.Revit.DB.Electrical.TemperatureRatingType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSet.Erase(Autodesk.Revit.DB.Electrical.TemperatureRatingType)`

#### Returntype

System.Int32

#### Summary

Removes a specified TemperatureRating type from the set.

#### Parameter `item`

The TemperatureRating type to be erased.

#### Returns

The number of TemperatureRating types that were erased from the set.

### `M:Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSet.Contains(Autodesk.Revit.DB.Electrical.TemperatureRatingType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSet.Contains(Autodesk.Revit.DB.Electrical.TemperatureRatingType)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of a TemperatureRating type within the set.

#### Parameter `item`

The TemperatureRating type to be searched for.

#### Returns

The Contains method returns True if the TemperatureRating type is within the set, otherwise False.

### `M:Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSet.Clear`

#### Returntype

void

#### Summary

Removes every TemperatureRating type from the set, rendering it empty.

### `P:Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of TemperatureRating types that are in the set.

### `P:Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.TemperatureRatingTypeSet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.Electrical.WireMaterialTypeSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.WireMaterialTypeSetIterator`

#### Summary

An iterator to a wire material type set.

### `T:Autodesk.Revit.DB.Electrical.WireMaterialTypeSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.WireMaterialTypeSet`

#### Summary

A set that contains wire material types.

### `P:Autodesk.Revit.DB.Electrical.WireMaterialTypeSetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.WireMaterialTypeSetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.Electrical.WireMaterialTypeSetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireMaterialTypeSetIterator.MoveNext`

#### Returntype

System.Boolean

#### Summary

Move the iterator one item forward.

#### Returns

Returns True if the iterator was successfully moved forward one item and the Current
property will return a valid item. False will be returned it the iterator has reached the end of
the set.

#### Remarks

MoveNext must be called before the Current property is valid with a new or Reset iterator
in line with the expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.Electrical.WireMaterialTypeSetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireMaterialTypeSetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.Electrical.WireMaterialTypeSetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireMaterialTypeSetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.Electrical.WireMaterialTypeSet.Insert(Autodesk.Revit.DB.Electrical.WireMaterialType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireMaterialTypeSet.Insert(Autodesk.Revit.DB.Electrical.WireMaterialType)`

#### Returntype

System.Int32

#### Summary

Insert the specified wire material type into the set.

#### Parameter `item`

The wire material type to be inserted into the set.

#### Returns

Returns whether the wire material type was inserted into the set.

### `M:Autodesk.Revit.DB.Electrical.WireMaterialTypeSet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireMaterialTypeSet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.Electrical.WireMaterialTypeSet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireMaterialTypeSet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.Electrical.WireMaterialTypeSetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.Electrical.WireMaterialTypeSet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireMaterialTypeSet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.Electrical.WireMaterialTypeSetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.Electrical.WireMaterialTypeSet.Erase(Autodesk.Revit.DB.Electrical.WireMaterialType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireMaterialTypeSet.Erase(Autodesk.Revit.DB.Electrical.WireMaterialType)`

#### Returntype

System.Int32

#### Summary

Removes a specified wire material type from the set.

#### Parameter `item`

The wire material type to be erased.

#### Returns

The number of wire material types that were erased from the set.

### `M:Autodesk.Revit.DB.Electrical.WireMaterialTypeSet.Contains(Autodesk.Revit.DB.Electrical.WireMaterialType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireMaterialTypeSet.Contains(Autodesk.Revit.DB.Electrical.WireMaterialType)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of a wire material type within the set.

#### Parameter `item`

The wire material type to be searched for.

#### Returns

The Contains method returns True if the wire material type is within the set, otherwise False.

### `M:Autodesk.Revit.DB.Electrical.WireMaterialTypeSet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireMaterialTypeSet.Clear`

#### Returntype

void

#### Summary

Removes every wire material type from the set, rendering it empty.

### `P:Autodesk.Revit.DB.Electrical.WireMaterialTypeSet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.WireMaterialTypeSet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of wire material types that are in the set.

### `P:Autodesk.Revit.DB.Electrical.WireMaterialTypeSet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.WireMaterialTypeSet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.Electrical.WireConduitTypeSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.WireConduitTypeSetIterator`

#### Summary

An iterator to a conduit type set.

### `T:Autodesk.Revit.DB.Electrical.WireConduitTypeSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.WireConduitTypeSet`

#### Summary

A set that contains conduit types.

### `P:Autodesk.Revit.DB.Electrical.WireConduitTypeSetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.WireConduitTypeSetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.Electrical.WireConduitTypeSetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireConduitTypeSetIterator.MoveNext`

#### Returntype

System.Boolean

#### Summary

Move the iterator one item forward.

#### Returns

Returns True if the iterator was successfully moved forward one item and the Current
property will return a valid item. False will be returned it the iterator has reached the end of
the set.

#### Remarks

MoveNext must be called before the Current property is valid with a new or Reset iterator
in line with the expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.Electrical.WireConduitTypeSetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireConduitTypeSetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.Electrical.WireConduitTypeSetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireConduitTypeSetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.Electrical.WireConduitTypeSet.Insert(Autodesk.Revit.DB.Electrical.WireConduitType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireConduitTypeSet.Insert(Autodesk.Revit.DB.Electrical.WireConduitType)`

#### Returntype

System.Int32

#### Summary

Insert the specified conduit type into the set.

#### Parameter `item`

The conduit type to be inserted into the set.

#### Returns

Returns whether the conduit type was inserted into the set.

### `M:Autodesk.Revit.DB.Electrical.WireConduitTypeSet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireConduitTypeSet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.Electrical.WireConduitTypeSet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireConduitTypeSet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.Electrical.WireConduitTypeSetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.Electrical.WireConduitTypeSet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireConduitTypeSet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.Electrical.WireConduitTypeSetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.Electrical.WireConduitTypeSet.Erase(Autodesk.Revit.DB.Electrical.WireConduitType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireConduitTypeSet.Erase(Autodesk.Revit.DB.Electrical.WireConduitType)`

#### Returntype

System.Int32

#### Summary

Removes a specified conduit type from the set.

#### Parameter `item`

The conduit type to be erased.

#### Returns

The number of conduit types that were erased from the set.

### `M:Autodesk.Revit.DB.Electrical.WireConduitTypeSet.Contains(Autodesk.Revit.DB.Electrical.WireConduitType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireConduitTypeSet.Contains(Autodesk.Revit.DB.Electrical.WireConduitType)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of a conduit type within the set.

#### Parameter `item`

The conduit type to be searched for.

#### Returns

The Contains method returns True if the conduit type is within the set, otherwise False.

### `M:Autodesk.Revit.DB.Electrical.WireConduitTypeSet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireConduitTypeSet.Clear`

#### Returntype

void

#### Summary

Removes every conduit type from the set, rendering it empty.

### `P:Autodesk.Revit.DB.Electrical.WireConduitTypeSet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.WireConduitTypeSet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of conduit types that are in the set.

### `P:Autodesk.Revit.DB.Electrical.WireConduitTypeSet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.WireConduitTypeSet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.Electrical.CorrectionFactorSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.CorrectionFactorSetIterator`

#### Summary

An iterator to a correction factor set.

### `T:Autodesk.Revit.DB.Electrical.CorrectionFactorSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.CorrectionFactorSet`

#### Summary

A set that contains correction factors.

### `P:Autodesk.Revit.DB.Electrical.CorrectionFactorSetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.CorrectionFactorSetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.Electrical.CorrectionFactorSetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CorrectionFactorSetIterator.MoveNext`

#### Returntype

System.Boolean

#### Summary

Move the iterator one item forward.

#### Returns

Returns True if the iterator was successfully moved forward one item and the Current
property will return a valid item. False will be returned it the iterator has reached the end of
the set.

#### Remarks

MoveNext must be called before the Current property is valid with a new or Reset iterator
in line with the expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.Electrical.CorrectionFactorSetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CorrectionFactorSetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.Electrical.CorrectionFactorSetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CorrectionFactorSetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.Electrical.CorrectionFactorSet.Insert(Autodesk.Revit.DB.Electrical.WireSize)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CorrectionFactorSet.Insert(Autodesk.Revit.DB.Electrical.WireSize)`

#### Returntype

System.Int32

#### Summary

Insert the specified correction factor into the set.

#### Parameter `item`

The correction factor to be inserted into the set.

#### Returns

Returns whether the correction factor was inserted into the set.

### `M:Autodesk.Revit.DB.Electrical.CorrectionFactorSet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CorrectionFactorSet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.Electrical.CorrectionFactorSet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CorrectionFactorSet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.Electrical.CorrectionFactorSetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.Electrical.CorrectionFactorSet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CorrectionFactorSet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.Electrical.CorrectionFactorSetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.Electrical.CorrectionFactorSet.Erase(Autodesk.Revit.DB.Electrical.WireSize)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CorrectionFactorSet.Erase(Autodesk.Revit.DB.Electrical.WireSize)`

#### Returntype

System.Int32

#### Summary

Removes a specified correction factor from the set.

#### Parameter `item`

The correction factor to be erased.

#### Returns

The number of correction factors that were erased from the set.

### `M:Autodesk.Revit.DB.Electrical.CorrectionFactorSet.Contains(Autodesk.Revit.DB.Electrical.WireSize)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CorrectionFactorSet.Contains(Autodesk.Revit.DB.Electrical.WireSize)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of a correction factor within the set.

#### Parameter `item`

The correction factor to be searched for.

#### Returns

The Contains method returns True if the correction factor is within the set, otherwise False.

### `M:Autodesk.Revit.DB.Electrical.CorrectionFactorSet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.CorrectionFactorSet.Clear`

#### Returntype

void

#### Summary

Removes every correction factor from the set, rendering it empty.

### `P:Autodesk.Revit.DB.Electrical.CorrectionFactorSet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.CorrectionFactorSet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of correction factors that are in the set.

### `P:Autodesk.Revit.DB.Electrical.CorrectionFactorSet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.CorrectionFactorSet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.Electrical.GroundConductorSizeSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.GroundConductorSizeSetIterator`

#### Summary

An iterator to a GroundConductorSize set.

### `T:Autodesk.Revit.DB.Electrical.GroundConductorSizeSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.GroundConductorSizeSet`

#### Summary

A set that contains GroundConductorSizes.

### `P:Autodesk.Revit.DB.Electrical.GroundConductorSizeSetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.GroundConductorSizeSetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.Electrical.GroundConductorSizeSetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.GroundConductorSizeSetIterator.MoveNext`

#### Returntype

System.Boolean

#### Summary

Move the iterator one item forward.

#### Returns

Returns True if the iterator was successfully moved forward one item and the Current
property will return a valid item. False will be returned it the iterator has reached the end of
the set.

#### Remarks

MoveNext must be called before the Current property is valid with a new or Reset iterator
in line with the expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.Electrical.GroundConductorSizeSetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.GroundConductorSizeSetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.Electrical.GroundConductorSizeSetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.GroundConductorSizeSetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.Electrical.GroundConductorSizeSet.Insert(Autodesk.Revit.DB.Electrical.GroundConductorSize)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.GroundConductorSizeSet.Insert(Autodesk.Revit.DB.Electrical.GroundConductorSize)`

#### Returntype

System.Int32

#### Summary

Insert the specified GroundConductorSize into the set.

#### Parameter `item`

The GroundConductorSize to be inserted into the set.

#### Returns

Returns whether the GroundConductorSize was inserted into the set.

### `M:Autodesk.Revit.DB.Electrical.GroundConductorSizeSet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.GroundConductorSizeSet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.Electrical.GroundConductorSizeSet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.GroundConductorSizeSet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.Electrical.GroundConductorSizeSetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.Electrical.GroundConductorSizeSet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.GroundConductorSizeSet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.Electrical.GroundConductorSizeSetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.Electrical.GroundConductorSizeSet.Erase(Autodesk.Revit.DB.Electrical.GroundConductorSize)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.GroundConductorSizeSet.Erase(Autodesk.Revit.DB.Electrical.GroundConductorSize)`

#### Returntype

System.Int32

#### Summary

Removes a specified GroundConductorSize from the set.

#### Parameter `item`

The GroundConductorSize to be erased.

#### Returns

The number of GroundConductorSizes that were erased from the set.

### `M:Autodesk.Revit.DB.Electrical.GroundConductorSizeSet.Contains(Autodesk.Revit.DB.Electrical.GroundConductorSize)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.GroundConductorSizeSet.Contains(Autodesk.Revit.DB.Electrical.GroundConductorSize)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of a GroundConductorSize within the set.

#### Parameter `item`

The GroundConductorSize to be searched for.

#### Returns

The Contains method returns True if the GroundConductorSize is within the set, otherwise False.

### `M:Autodesk.Revit.DB.Electrical.GroundConductorSizeSet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.GroundConductorSizeSet.Clear`

#### Returntype

void

#### Summary

Removes every GroundConductorSize from the set, rendering it empty.

### `P:Autodesk.Revit.DB.Electrical.GroundConductorSizeSet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.GroundConductorSizeSet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of GroundConductorSizes that are in the set.

### `P:Autodesk.Revit.DB.Electrical.GroundConductorSizeSet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.GroundConductorSizeSet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.Electrical.WireSizeSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.WireSizeSetIterator`

#### Summary

An iterator to a wire size set.

### `T:Autodesk.Revit.DB.Electrical.WireSizeSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.WireSizeSet`

#### Summary

A set that contains wire sizes.

### `P:Autodesk.Revit.DB.Electrical.WireSizeSetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.WireSizeSetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.Electrical.WireSizeSetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireSizeSetIterator.MoveNext`

#### Returntype

System.Boolean

#### Summary

Move the iterator one item forward.

#### Returns

Returns True if the iterator was successfully moved forward one item and the Current
property will return a valid item. False will be returned it the iterator has reached the end of
the set.

#### Remarks

MoveNext must be called before the Current property is valid with a new or Reset iterator
in line with the expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.Electrical.WireSizeSetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireSizeSetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.Electrical.WireSizeSetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireSizeSetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.Electrical.WireSizeSet.Insert(Autodesk.Revit.DB.Electrical.WireSize)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireSizeSet.Insert(Autodesk.Revit.DB.Electrical.WireSize)`

#### Returntype

System.Int32

#### Summary

Insert the specified wire size into the set.

#### Parameter `item`

The wire size to be inserted into the set.

#### Returns

Returns whether the wire size was inserted into the set.

### `M:Autodesk.Revit.DB.Electrical.WireSizeSet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireSizeSet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.Electrical.WireSizeSet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireSizeSet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.Electrical.WireSizeSetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.Electrical.WireSizeSet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireSizeSet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.Electrical.WireSizeSetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.Electrical.WireSizeSet.Erase(Autodesk.Revit.DB.Electrical.WireSize)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireSizeSet.Erase(Autodesk.Revit.DB.Electrical.WireSize)`

#### Returntype

System.Int32

#### Summary

Removes a specified wire size from the set.

#### Parameter `item`

The wire size to be erased.

#### Returns

The number of wire sizes that were erased from the set.

### `M:Autodesk.Revit.DB.Electrical.WireSizeSet.Contains(Autodesk.Revit.DB.Electrical.WireSize)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireSizeSet.Contains(Autodesk.Revit.DB.Electrical.WireSize)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of a wire size within the set.

#### Parameter `item`

The wire size to be searched for.

#### Returns

The Contains method returns True if the wire size is within the set, otherwise False.

### `M:Autodesk.Revit.DB.Electrical.WireSizeSet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireSizeSet.Clear`

#### Returntype

void

#### Summary

Removes every wire size from the set, rendering it empty.

### `P:Autodesk.Revit.DB.Electrical.WireSizeSet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.WireSizeSet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of wire sizes that are in the set.

### `P:Autodesk.Revit.DB.Electrical.WireSizeSet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.WireSizeSet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.Electrical.WireSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.WireSetIterator`

#### Summary

An iterator to a set.

### `T:Autodesk.Revit.DB.Electrical.WireSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.WireSet`

#### Summary

A set that can contain any type of object.

### `P:Autodesk.Revit.DB.Electrical.WireSetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.WireSetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.Electrical.WireSetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireSetIterator.MoveNext`

#### Returntype

System.Boolean

#### Summary

Move the iterator one item forward.

#### Returns

Returns True if the iterator was successfully moved forward one item and the Current
property will return a valid item. False will be returned it the iterator has reached the end of
the set.

#### Remarks

MoveNext must be called before the Current property is valid with a new or Reset iterator
in line with the expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.Electrical.WireSetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireSetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.Electrical.WireSetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireSetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.Electrical.WireSet.Insert(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireSet.Insert(System.Object)`

#### Returntype

System.Int32

#### Summary

Insert the specified item into the set.

#### Parameter `item`

The item to be inserted into the set.

#### Returns

Returns whether the item was inserted into the set.

### `M:Autodesk.Revit.DB.Electrical.WireSet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireSet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.Electrical.WireSet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireSet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.Electrical.WireSetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.Electrical.WireSet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireSet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.Electrical.WireSetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.Electrical.WireSet.Erase(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireSet.Erase(System.Object)`

#### Returntype

System.Int32

#### Summary

Removes a specified object from the set.

#### Parameter `item`

The item to be erased.

#### Returns

The number of items that were erased from the set.

### `M:Autodesk.Revit.DB.Electrical.WireSet.Contains(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireSet.Contains(System.Object)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of an item within the set.

#### Parameter `item`

The item to be searched for.

#### Returns

The Contains method returns True if the item is within the set, otherwise False.

### `M:Autodesk.Revit.DB.Electrical.WireSet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.WireSet.Clear`

#### Returntype

void

#### Summary

Removes every item from the set, rendering it empty.

### `P:Autodesk.Revit.DB.Electrical.WireSet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.WireSet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of objects that are in the set.

### `P:Autodesk.Revit.DB.Electrical.WireSet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.WireSet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.Electrical.VoltageTypeSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.VoltageTypeSetIterator`

#### Summary

An iterator to a voltage type set.

### `T:Autodesk.Revit.DB.Electrical.VoltageTypeSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.VoltageTypeSet`

#### Summary

A set that contains voltage types.

### `P:Autodesk.Revit.DB.Electrical.VoltageTypeSetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.VoltageTypeSetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.Electrical.VoltageTypeSetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.VoltageTypeSetIterator.MoveNext`

#### Returntype

System.Boolean

#### Summary

Move the iterator one item forward.

#### Returns

Returns True if the iterator was successfully moved forward one item and the Current
property will return a valid item. False will be returned it the iterator has reached the end of
the set.

#### Remarks

MoveNext must be called before the Current property is valid with a new or Reset iterator
in line with the expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.Electrical.VoltageTypeSetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.VoltageTypeSetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.Electrical.VoltageTypeSetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.VoltageTypeSetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.Electrical.VoltageTypeSet.Insert(Autodesk.Revit.DB.Electrical.VoltageType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.VoltageTypeSet.Insert(Autodesk.Revit.DB.Electrical.VoltageType)`

#### Returntype

System.Int32

#### Summary

Insert the specified voltage type into the set.

#### Parameter `item`

The voltage type to be inserted into the set.

#### Returns

Returns whether the voltage type was inserted into the set.

### `M:Autodesk.Revit.DB.Electrical.VoltageTypeSet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.VoltageTypeSet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.Electrical.VoltageTypeSet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.VoltageTypeSet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.Electrical.VoltageTypeSetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.Electrical.VoltageTypeSet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.VoltageTypeSet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.Electrical.VoltageTypeSetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.Electrical.VoltageTypeSet.Erase(Autodesk.Revit.DB.Electrical.VoltageType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.VoltageTypeSet.Erase(Autodesk.Revit.DB.Electrical.VoltageType)`

#### Returntype

System.Int32

#### Summary

Removes a specified voltage type from the set.

#### Parameter `item`

The voltage type to be erased.

#### Returns

The number of voltage types that were erased from the set.

### `M:Autodesk.Revit.DB.Electrical.VoltageTypeSet.Contains(Autodesk.Revit.DB.Electrical.VoltageType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.VoltageTypeSet.Contains(Autodesk.Revit.DB.Electrical.VoltageType)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of a voltage type within the set.

#### Parameter `item`

The voltage type to be searched for.

#### Returns

The Contains method returns True if the voltage type is within the set, otherwise False.

### `M:Autodesk.Revit.DB.Electrical.VoltageTypeSet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.VoltageTypeSet.Clear`

#### Returntype

void

#### Summary

Removes every voltage type from the set, rendering it empty.

### `P:Autodesk.Revit.DB.Electrical.VoltageTypeSet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.VoltageTypeSet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of voltage types that are in the set.

### `P:Autodesk.Revit.DB.Electrical.VoltageTypeSet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.VoltageTypeSet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.ViewSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.ViewSetIterator`

#### Summary

An iterator to a view set.

### `T:Autodesk.Revit.DB.ViewSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.ViewSet`

#### Summary

A set that contains views.

### `P:Autodesk.Revit.DB.ViewSetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewSetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.ViewSetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSetIterator.MoveNext`

#### Returntype

System.Boolean

#### Summary

Move the iterator one item forward.

#### Returns

Returns True if the iterator was successfully moved forward one item and the Current
property will return a valid item. False will be returned it the iterator has reached the end of
the set.

#### Remarks

MoveNext must be called before the Current property is valid with a new or Reset iterator
in line with the expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.ViewSetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.ViewSetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.ViewSet.Insert(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSet.Insert(Autodesk.Revit.DB.View)`

#### Returntype

System.Int32

#### Summary

Insert the specified view into the set.

#### Parameter `item`

The view to be inserted into the set.

#### Returns

Returns whether the view was inserted into the set.

### `M:Autodesk.Revit.DB.ViewSet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.ViewSet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.ViewSetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.ViewSet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.ViewSetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.ViewSet.Erase(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSet.Erase(Autodesk.Revit.DB.View)`

#### Returntype

System.Int32

#### Summary

Removes a specified view from the set.

#### Parameter `item`

The view to be erased.

#### Returns

The number of views that were erased from the set.

### `M:Autodesk.Revit.DB.ViewSet.Contains(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSet.Contains(Autodesk.Revit.DB.View)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of a view within the set.

#### Parameter `item`

The view to be searched for.

#### Returns

The Contains method returns True if the view is within the set, otherwise False.

### `M:Autodesk.Revit.DB.ViewSet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSet.Clear`

#### Returntype

void

#### Summary

Removes every view from the set, rendering it empty.

### `P:Autodesk.Revit.DB.ViewSet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewSet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of views that are in the set.

### `P:Autodesk.Revit.DB.ViewSet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewSet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.VertexIndexPairArrayIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.VertexIndexPairArrayIterator`

#### Summary

An iterator to an array of VertexIndex pairs.

### `T:Autodesk.Revit.DB.VertexIndexPairArray`

Member kind: type
Symbol: `Autodesk.Revit.DB.VertexIndexPairArray`

#### Summary

An array that contains VertexIndex pairs.

### `P:Autodesk.Revit.DB.VertexIndexPairArrayIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.VertexIndexPairArrayIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.VertexIndexPairArrayIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.VertexIndexPairArrayIterator.MoveNext`

#### Returntype

System.Boolean

#### Summary

Move the iterator one item forward.

#### Returns

Returns True if the iterator was successfully moved forward one item and the Current
property will return a valid item. False will be returned it the iterator has reached the end of
the array.

#### Remarks

MoveNext must be called before the Current property is valid with a new or Reset iterator
in line with the expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.VertexIndexPairArrayIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.VertexIndexPairArrayIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the array.

#### Remarks

The Reset method will return the iterator back to the start of the array in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.VertexIndexPairArrayIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.VertexIndexPairArrayIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.VertexIndexPairArray.Insert(Autodesk.Revit.DB.Geometry.XYZ@,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.VertexIndexPairArray.Insert(Autodesk.Revit.DB.Geometry.XYZ@,System.Int32)`

#### Returntype

System.Int32

#### Summary

Insert the specified VertexIndex pair into the array.

#### Parameter `item`

The VertexIndex pair to be inserted into the array.

#### Parameter `index`

The VertexIndex pair will be inserted before this index.

#### Returns

Returns whether theVertexIndex pair was inserted into the array.

### `M:Autodesk.Revit.DB.VertexIndexPairArray.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.VertexIndexPairArray.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.VertexIndexPairArray.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.VertexIndexPairArray.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.VertexIndexPairArrayIterator

#### Summary

Retrieve a backward moving iterator to the array.

#### Returns

Returns a backward moving iterator to the array.

### `M:Autodesk.Revit.DB.VertexIndexPairArray.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.VertexIndexPairArray.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.VertexIndexPairArrayIterator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.VertexIndexPairArray.Append(Autodesk.Revit.DB.Geometry.XYZ@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.VertexIndexPairArray.Append(Autodesk.Revit.DB.Geometry.XYZ@)`

#### Returntype

void

#### Summary

Add the VertexIndex pair to the end of the array.

#### Parameter `item`

The VertexIndex pair to be added.

### `M:Autodesk.Revit.DB.VertexIndexPairArray.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.VertexIndexPairArray.Clear`

#### Returntype

void

#### Summary

Removes every VertexIndex pair from the array, rendering it empty.

### `P:Autodesk.Revit.DB.VertexIndexPairArray.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.VertexIndexPairArray.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of VertexIndex pairs that are in the array.

### `P:Autodesk.Revit.DB.VertexIndexPairArray.Item(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.VertexIndexPairArray.Item(System.Int32)`

#### Returntype

System.Object

#### Summary

Gets or sets a VertexIndex pair at a specified index within the array.

#### Parameter `index`

The index of the VertexIndex pair to be set or retrieved.

#### Returns

Returns the VertexIndex pair at the specified index.

### `P:Autodesk.Revit.DB.VertexIndexPairArray.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.VertexIndexPairArray.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the array is empty.

#### Remarks

If the array is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.SymbolicCurveArrayIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.SymbolicCurveArrayIterator`

#### Summary

An iterator to a model curve array.

### `T:Autodesk.Revit.DB.SymbolicCurveArray`

Member kind: type
Symbol: `Autodesk.Revit.DB.SymbolicCurveArray`

#### Summary

An array that contains model curves.

### `P:Autodesk.Revit.DB.SymbolicCurveArrayIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.SymbolicCurveArrayIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.SymbolicCurveArrayIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.SymbolicCurveArrayIterator.MoveNext`

#### Returntype

System.Boolean

#### Summary

Move the iterator one item forward.

#### Returns

Returns True if the iterator was successfully moved forward one item and the Current
property will return a valid item. False will be returned it the iterator has reached the end of
the array.

#### Remarks

MoveNext must be called before the Current property is valid with a new or Reset iterator
in line with the expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.SymbolicCurveArrayIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.SymbolicCurveArrayIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the array.

#### Remarks

The Reset method will return the iterator back to the start of the array in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.SymbolicCurveArrayIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.SymbolicCurveArrayIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.SymbolicCurveArray.Insert(Autodesk.Revit.DB.SymbolicCurve,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SymbolicCurveArray.Insert(Autodesk.Revit.DB.SymbolicCurve,System.Int32)`

#### Returntype

System.Int32

#### Summary

Insert the specified model curve into the array.

#### Parameter `item`

The model curve to be inserted into the array.

#### Parameter `index`

The model curve will be inserted before this index.

#### Returns

Returns whether the model curve was inserted into the array.

### `M:Autodesk.Revit.DB.SymbolicCurveArray.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.SymbolicCurveArray.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.SymbolicCurveArray.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.SymbolicCurveArray.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.SymbolicCurveArrayIterator

#### Summary

Retrieve a backward moving iterator to the array.

#### Returns

Returns a backward moving iterator to the array.

### `M:Autodesk.Revit.DB.SymbolicCurveArray.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.SymbolicCurveArray.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.SymbolicCurveArrayIterator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.SymbolicCurveArray.Append(Autodesk.Revit.DB.SymbolicCurve)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SymbolicCurveArray.Append(Autodesk.Revit.DB.SymbolicCurve)`

#### Returntype

void

#### Summary

Add the model curve to the end of the array.

#### Parameter `item`

The model curve to be added.

### `M:Autodesk.Revit.DB.SymbolicCurveArray.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.SymbolicCurveArray.Clear`

#### Returntype

void

#### Summary

Removes every model curve from the array, rendering it empty.

### `P:Autodesk.Revit.DB.SymbolicCurveArray.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.SymbolicCurveArray.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of model curves that are in the array.

### `P:Autodesk.Revit.DB.SymbolicCurveArray.Item(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.SymbolicCurveArray.Item(System.Int32)`

#### Returntype

Autodesk.Revit.DB.SymbolicCurve

#### Summary

Gets or sets a model curve at a specified index within the array.

#### Parameter `index`

The index of the model curve to be set or retrieved.

#### Returns

Returns the model curve at the specified index.

### `P:Autodesk.Revit.DB.SymbolicCurveArray.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.SymbolicCurveArray.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the array is empty.

#### Remarks

If the array is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.Mechanical.SpaceSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.SpaceSetIterator`

#### Summary

An iterator to a set.

### `T:Autodesk.Revit.DB.Mechanical.SpaceSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.SpaceSet`

#### Summary

A set that can contain any type of object.

### `P:Autodesk.Revit.DB.Mechanical.SpaceSetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.SpaceSetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.Mechanical.SpaceSetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.SpaceSetIterator.MoveNext`

#### Returntype

System.Boolean

#### Summary

Move the iterator one item forward.

#### Returns

Returns True if the iterator was successfully moved forward one item and the Current
property will return a valid item. False will be returned it the iterator has reached the end of
the set.

#### Remarks

MoveNext must be called before the Current property is valid with a new or Reset iterator
in line with the expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.Mechanical.SpaceSetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.SpaceSetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.Mechanical.SpaceSetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.SpaceSetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.Mechanical.SpaceSet.Insert(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.SpaceSet.Insert(System.Object)`

#### Returntype

System.Int32

#### Summary

Insert the specified item into the set.

#### Parameter `item`

The item to be inserted into the set.

#### Returns

Returns whether the item was inserted into the set.

### `M:Autodesk.Revit.DB.Mechanical.SpaceSet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.SpaceSet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.Mechanical.SpaceSet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.SpaceSet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.Mechanical.SpaceSetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.Mechanical.SpaceSet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.SpaceSet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.Mechanical.SpaceSetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.Mechanical.SpaceSet.Erase(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.SpaceSet.Erase(System.Object)`

#### Returntype

System.Int32

#### Summary

Removes a specified object from the set.

#### Parameter `item`

The item to be erased.

#### Returns

The number of items that were erased from the set.

### `M:Autodesk.Revit.DB.Mechanical.SpaceSet.Contains(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.SpaceSet.Contains(System.Object)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of an item within the set.

#### Parameter `item`

The item to be searched for.

#### Returns

The Contains method returns True if the item is within the set, otherwise False.

### `M:Autodesk.Revit.DB.Mechanical.SpaceSet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.SpaceSet.Clear`

#### Returntype

void

#### Summary

Removes every item from the set, rendering it empty.

### `P:Autodesk.Revit.DB.Mechanical.SpaceSet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.SpaceSet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of objects that are in the set.

### `P:Autodesk.Revit.DB.Mechanical.SpaceSet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.SpaceSet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.SlabShapeVertexArrayIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.SlabShapeVertexArrayIterator`

#### Summary

An iterator to an array of vertices used for Slab Shape Editing.

### `T:Autodesk.Revit.DB.SlabShapeVertexArray`

Member kind: type
Symbol: `Autodesk.Revit.DB.SlabShapeVertexArray`

#### Summary

An array that can contain any number of vertices used in Slab Shape Editing.

### `P:Autodesk.Revit.DB.SlabShapeVertexArrayIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.SlabShapeVertexArrayIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.SlabShapeVertexArrayIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.SlabShapeVertexArrayIterator.MoveNext`

#### Returntype

System.Boolean

#### Summary

Move the iterator one item forward.

#### Returns

Returns True if the iterator was successfully moved forward one item and the Current
property will return a valid item. False will be returned it the iterator has reached the end of
the array.

#### Remarks

MoveNext must be called before the Current property is valid with a new or Reset iterator
in line with the expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.SlabShapeVertexArrayIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.SlabShapeVertexArrayIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the array.

#### Remarks

The Reset method will return the iterator back to the start of the array in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.SlabShapeVertexArrayIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.SlabShapeVertexArrayIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.SlabShapeVertexArray.Insert(Autodesk.Revit.DB.SlabShapeVertex,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SlabShapeVertexArray.Insert(Autodesk.Revit.DB.SlabShapeVertex,System.Int32)`

#### Returntype

System.Int32

#### Summary

Insert the specified item into the array.

#### Parameter `item`

The item to be inserted into the array.

#### Parameter `index`

The item will be inserted before this index.

#### Returns

Returns whether the item was inserted into the array.

### `M:Autodesk.Revit.DB.SlabShapeVertexArray.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.SlabShapeVertexArray.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.SlabShapeVertexArray.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.SlabShapeVertexArray.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.SlabShapeVertexArrayIterator

#### Summary

Retrieve a backward moving iterator to the array.

#### Returns

Returns a backward moving iterator to the array.

### `M:Autodesk.Revit.DB.SlabShapeVertexArray.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.SlabShapeVertexArray.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.SlabShapeVertexArrayIterator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.SlabShapeVertexArray.Append(Autodesk.Revit.DB.SlabShapeVertex)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SlabShapeVertexArray.Append(Autodesk.Revit.DB.SlabShapeVertex)`

#### Returntype

void

#### Summary

Add the item to the end of the array.

#### Parameter `item`

The item to be added.

### `M:Autodesk.Revit.DB.SlabShapeVertexArray.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.SlabShapeVertexArray.Clear`

#### Returntype

void

#### Summary

Removes every item from the array, rendering it empty.

### `P:Autodesk.Revit.DB.SlabShapeVertexArray.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.SlabShapeVertexArray.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of objects that are in the array.

### `P:Autodesk.Revit.DB.SlabShapeVertexArray.Item(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.SlabShapeVertexArray.Item(System.Int32)`

#### Returntype

System.Object

#### Summary

Gets or sets an item at a specified index within the array.

#### Parameter `index`

The index of the item to be set or retrieved.

#### Returns

Returns the object at the specified index.

### `P:Autodesk.Revit.DB.SlabShapeVertexArray.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.SlabShapeVertexArray.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the array is empty.

#### Remarks

If the array is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.SlabShapeCreaseArrayIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.SlabShapeCreaseArrayIterator`

#### Summary

An iterator to an array of creases used for Slab Shape Editing.

### `T:Autodesk.Revit.DB.SlabShapeCreaseArray`

Member kind: type
Symbol: `Autodesk.Revit.DB.SlabShapeCreaseArray`

#### Summary

An array that can contain any number of creases used in Slab Shape Editing.

### `P:Autodesk.Revit.DB.SlabShapeCreaseArrayIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.SlabShapeCreaseArrayIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.SlabShapeCreaseArrayIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.SlabShapeCreaseArrayIterator.MoveNext`

#### Returntype

System.Boolean

#### Summary

Move the iterator one item forward.

#### Returns

Returns True if the iterator was successfully moved forward one item and the Current
property will return a valid item. False will be returned it the iterator has reached the end of
the array.

#### Remarks

MoveNext must be called before the Current property is valid with a new or Reset iterator
in line with the expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.SlabShapeCreaseArrayIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.SlabShapeCreaseArrayIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the array.

#### Remarks

The Reset method will return the iterator back to the start of the array in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.SlabShapeCreaseArrayIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.SlabShapeCreaseArrayIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.SlabShapeCreaseArray.Insert(Autodesk.Revit.DB.SlabShapeCrease,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SlabShapeCreaseArray.Insert(Autodesk.Revit.DB.SlabShapeCrease,System.Int32)`

#### Returntype

System.Int32

#### Summary

Insert the specified item into the array.

#### Parameter `item`

The item to be inserted into the array.

#### Parameter `index`

The item will be inserted before this index.

#### Returns

Returns whether the item was inserted into the array.

### `M:Autodesk.Revit.DB.SlabShapeCreaseArray.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.SlabShapeCreaseArray.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.SlabShapeCreaseArray.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.SlabShapeCreaseArray.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.SlabShapeCreaseArrayIterator

#### Summary

Retrieve a backward moving iterator to the array.

#### Returns

Returns a backward moving iterator to the array.

### `M:Autodesk.Revit.DB.SlabShapeCreaseArray.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.SlabShapeCreaseArray.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.SlabShapeCreaseArrayIterator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.SlabShapeCreaseArray.Append(Autodesk.Revit.DB.SlabShapeCrease)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SlabShapeCreaseArray.Append(Autodesk.Revit.DB.SlabShapeCrease)`

#### Returntype

void

#### Summary

Add the item to the end of the array.

#### Parameter `item`

The item to be added.

### `M:Autodesk.Revit.DB.SlabShapeCreaseArray.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.SlabShapeCreaseArray.Clear`

#### Returntype

void

#### Summary

Removes every item from the array, rendering it empty.

### `P:Autodesk.Revit.DB.SlabShapeCreaseArray.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.SlabShapeCreaseArray.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of objects that are in the array.

### `P:Autodesk.Revit.DB.SlabShapeCreaseArray.Item(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.SlabShapeCreaseArray.Item(System.Int32)`

#### Returntype

System.Object

#### Summary

Gets or sets an item at a specified index within the array.

#### Parameter `index`

The index of the item to be set or retrieved.

#### Returns

Returns the object at the specified index.
