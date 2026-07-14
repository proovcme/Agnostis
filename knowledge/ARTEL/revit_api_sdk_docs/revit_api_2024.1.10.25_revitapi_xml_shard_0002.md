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
Shard: 2
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `M:Autodesk.Revit.DB.NumberingSchemaType.#ctor(System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.NumberingSchemaType.#ctor(System.Guid)`

#### Summary

Creates a new NumberingSchemaType instance.

#### Parameter `guid`

The identifier for the NumberingSchemaType.

### `T:Autodesk.Revit.DB.NumberingSchemaType`

Member kind: type
Symbol: `Autodesk.Revit.DB.NumberingSchemaType`

#### Summary

A type for identifying a `T:Autodesk.Revit.DB.NumberingSchema` of a particular kind.

#### Remarks

Each numbering schema is applicable to a certain category of Revit elements. For example, the Rebar
numbering schema (built-in) is used and only applicable to Rebar elements. With that schema present,
all Rebar elements automatically will get their respective numbers and those numbers would not correspond
in any way to numbers of other enumerable elements that belong to different numbering schemas.

There are only built-in schemas available currently.

#### Since

2015

### `M:Autodesk.Revit.DB.NumberingSchema.IsValidPartitionName(System.String,System.String@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.NumberingSchema.IsValidPartitionName(System.String,System.String@)`

#### Summary

Tests if the given string can be used as a name for a numbering partition.

#### Remarks

For a name to be considered valid it must contain only printable characters
excluding any characters that may not be used in name of a file.

#### Parameter `name`

A name to validate.

#### Parameter `message`

Optional string to receive an error message to possibly show to the
end user in case the name is found invalid. This argument may be null.

#### Returns

Returns True if the name can be used; or False if the string contains invalid characters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.NumberingSchema.AssignElementsToSequence(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId},System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.NumberingSchema.AssignElementsToSequence(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId},System.String)`

#### Summary

Assigns the input elements to a sequence identified by the given partition name.

#### Remarks

Elements will be added to the sequence by changing the value of their
Partition parameter. The difference between this method and changing the
parameter value explicitly is that the method here causes sequences to get assigned
and renumbered automatically and immediately without needing to commit a transaction first.

A numbering sequence for the given partition does not need to exist yet;
it will get created automatically by this method as needed.

The elements' numbers are likely to be affected by this operation, which is to be
expected. The values of assigned numbers will depend on whether the given sequence
already exists or not. In both cases the elements will get renumbered in order of their
original creation, but the first value will be 1 if the sequence does not exist yet,
respectively the next highest number if the sequence does exist already. The general
matching policy is always applied causing matched elements to have the same number.

A special case is considered when the given elements are all the elements
of one sequence and are being assigned to a sequence that does not exist yet.
Such an operation is identical in effect to the `M:Autodesk.Revit.DB.NumberingSchema.MoveSequence(System.String,System.String)`
method and all the elements will keep their numbers unchanged.

#### Parameter `elementIds`

Ids of elements which are to be added to a sequence.
All elements must be valid and belonging to this schema.

#### Parameter `partitionName`

Name of the target sequence's partition

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

the given partitionName cannot be used as a valid name of a numbering partition
because it contains characters that are considered invalid, such as
non-printable characters or those that cannot be used in a file's name.
-or-
Thrown when elementIds contains Ids that are either invalid or of elements not from this schema.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Either the schema or its document cannot be modified at present.
-or-
Thrown if there is an element that cannot have new value of the NUMBER_PARTITION_PARAM
parameter assigned. It may be an indication that the element is not free to be edited at present.

#### Since

2015

### `M:Autodesk.Revit.DB.NumberingSchema.MergeSequences(System.Collections.Generic.IList{System.String},System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.NumberingSchema.MergeSequences(System.Collections.Generic.IList{System.String},System.String)`

#### Summary

Merges all elements from given numbering sequences to a new sequence.

#### Remarks

Upon a successful merge, all elements in the new merged sequence
will be renumbered in order of the element creation. There will be no gaps.

There must not be a sequence for the target partition in the schema yet,
otherwise an exception will be thrown.

This operation modifies the Partition parameter of all elements
in the sequences that are being merged. Therefore, all its elements
must be accessible for editing, otherwise this operation will fail.

#### Parameter `sourcePartitions`

A collection of partition names identifying the sequences to be merged together.
There must be at least two names in the list. All the sequences must exist already.

#### Parameter `newPartition`

Name of a new partition into which the source sequences will be merged.
Leading and trailing white space is ignored in the given string and will be removed automatically.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The sourcePartitions list must contain at least two names.
-or-
Either one or more sequences in the sourcePartitions list does
not exist in the schema, or the list contains duplicated names.
-or-
The sequence newPartition does already exist in the schema.
-or-
the given newPartition cannot be used as a valid name of a numbering partition
because it contains characters that are considered invalid, such as
non-printable characters or those that cannot be used in a file's name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Either the schema or its document cannot be modified at present.
-or-
Thrown if there is an element that cannot have new value of the NUMBER_PARTITION_PARAM
parameter assigned. It may be an indication that the element is not free to be edited at present.

#### Since

2015

### `M:Autodesk.Revit.DB.NumberingSchema.AppendSequence(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.NumberingSchema.AppendSequence(System.String,System.String)`

#### Summary

Appends all elements of one numbering sequence to the end of another sequence.

#### Remarks

All numbers assigned to elements in the target sequence remain the same,
but numbers in the source sequence (the one getting appended) will change.
Elements that match elements in the target sequence will get the same
numbers assigned. Remaining elements will get consecutive numbers in the
creation order of the elements starting with the next highest
number available in the target sequence.

This operation modifies the Partition parameter of all elements
in the sequence that is getting appended. Therefore, all its elements
must be accessible for editing, otherwise this operation will fail.

Elements can be appended only to a sequence that already exists. In order to
reassign elements of one sequence to a partition that does not exist yet,
use either the `M:Autodesk.Revit.DB.NumberingSchema.MoveSequence(System.String,System.String)` or
`M:Autodesk.Revit.DB.NumberingSchema.MergeSequences(System.Collections.Generic.IList`1{System.String},System.String)` methods.

#### Parameter `fromPartition`

Name of the partition that determines which numbering sequence to append.
The sequence must exist already, otherwise an exception will be thrown.

#### Parameter `toPartition`

Name of a partition into which the source sequence is going to be appended.
The sequence must exist already, otherwise an exception will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The sequence fromPartition does not exist in the schema.
-or-
The sequence toPartition does not exist in the schema.
-or-
Given partition names fromPartition and toPartition must be different.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Either the schema or its document cannot be modified at present.
-or-
Thrown if there is an element that cannot have new value of the NUMBER_PARTITION_PARAM
parameter assigned. It may be an indication that the element is not free to be edited at present.

#### Since

2015

### `M:Autodesk.Revit.DB.NumberingSchema.MoveSequence(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.NumberingSchema.MoveSequence(System.String,System.String)`

#### Summary

Moves all elements of a numbering sequence from one partition to another.

#### Remarks

All numbers assigned to elements in the sequence remain the same.

This operation modifies the Partition parameter of all elements
in the given sequence. Therefore, all the elements must be accessible
for editing.

Elements can be moved only to a partition that does not exist yet. To move elements
to an existing partition use the `M:Autodesk.Revit.DB.NumberingSchema.AppendSequence(System.String,System.String)` method.

#### Parameter `fromPartition`

Name of the partition that determines which numbering sequence to move.
The sequence must exist already, otherwise an exception will be thrown.

#### Parameter `newPartition`

Name of a partition into which the source sequence is going to be moved.
The schema must not have a sequence for this partition yet
(i.e. the schema does not have an element that was assigned to such a partition.)

Leading and trailing white space is ignored in the given string and will be
removed automatically.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The sequence fromPartition does not exist in the schema.
-or-
The sequence newPartition does already exist in the schema.
-or-
the given newPartition cannot be used as a valid name of a numbering partition
because it contains characters that are considered invalid, such as
non-printable characters or those that cannot be used in a file's name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Either the schema or its document cannot be modified at present.
-or-
Thrown if there is an element that cannot have new value of the NUMBER_PARTITION_PARAM
parameter assigned. It may be an indication that the element is not free to be edited at present.

#### Since

2015

### `M:Autodesk.Revit.DB.NumberingSchema.ChangeNumber(System.String,System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.NumberingSchema.ChangeNumber(System.String,System.Int32,System.Int32)`

#### Summary

Replaces an existing number with a new one (that does not exist yet).

#### Remarks

This method gives the caller the ability to overwrite any number used in a given
numbering sequence as long as the new number does not exist in the same sequence yet.
If an attempt is made to replace a number by another that already exists, an exception
will be thrown.

The new number will automatically be applied to all elements that bear the original
number, thus those elements must be free to be modified. A collection of element Ids
of all the affected elements is returned by this method.

The method is independent of the sequence's current starting number that might have
been assigned previously, meaning that the new number will be accepted even if it is
lower than the previously set start number in the sequence.

#### Parameter `partition`

Name of the partition that identifies the sequence containing the number to be changed.

#### Parameter `fromNumber`

Number to be changed; there must already be an element with that number in the sequence.

#### Parameter `toNumber`

Number to change to; no element must have this number yet in the sequence.

#### Returns

A collection of elements affected by the change of the number

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The sequence partition does not exist in the schema.
-or-
The specified sequence does not contain any elements with the given fromNumber.
-or-
There already are elements with the given toNumber in the specified sequence.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The value of toNumber must be in the range from 1 to the maximum value for an Integer type

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Either the schema or its document cannot be modified at present.

#### Since

2015

### `M:Autodesk.Revit.DB.NumberingSchema.ShiftNumbers(System.String,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.NumberingSchema.ShiftNumbers(System.String,System.Int32)`

#### Summary

Shifts all numbers in the sequence so the starting number has the given value.

#### Remarks

A shift of all numbers in the sequence will be computed and applied
so the first (lowest) number in the sequence would have the given value.
All the other numbers will then be shifted relatively by the same amount.

Any existing gaps in the current numbering sequence will be preserved.

Shifts that would make the start number less than 1 or bigger than
`P:Autodesk.Revit.DB.NumberingSchema.MaximumStartingNumber` are considered invalid.

#### Parameter `partition`

Name of the partition that identifies the sequence. The sequence must exist.

#### Parameter `firstNumber`

Value for the new first (lowest) number of the sequence.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The sequence partition does not exist in the schema.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

firstNumber must be in range between 1 and MaximumStartingNumber.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Either the schema or its document cannot be modified at present.

#### Since

2015

### `M:Autodesk.Revit.DB.NumberingSchema.RemoveGaps(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.NumberingSchema.RemoveGaps(System.String)`

#### Summary

Removes gaps, if any, in a numbering sequence

#### Remarks

Gaps are removed by shifting numbers above each gap down by the amount of
numbers skipped in the gap. The lowest number in the sequence will remain unchanged.

#### Parameter `partition`

Name of the partition that identifies the sequence. The sequence must exist.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The sequence partition does not exist in the schema.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Either the schema or its document cannot be modified at present.

#### Since

2015

### `M:Autodesk.Revit.DB.NumberingSchema.GetNumbers(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.NumberingSchema.GetNumbers(System.String)`

#### Summary

Returns all numbers currently used in the given numbering sequence

#### Remarks

Numbers are returned as a collection of ranges, where each range
is a pair of two integer values, Low and High. As long as there is
no gap currently in the sequence, there will be only one range.

#### Parameter `partition`

Name of the partition that identifies the sequence. The sequence must exist.

#### Returns

A collection of integer ranges

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The sequence partition does not exist in the schema.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.NumberingSchema.GetNumberingSequences`

Member kind: method
Symbol: `Autodesk.Revit.DB.NumberingSchema.GetNumberingSequences`

#### Summary

Returns all numbering sequences within this numbering schema.

#### Remarks

The collection may be empty if there are no elements yet in this schema.

One of the strings can be an empty string, which would indicate presence
of the default partition into which elements automatically belong if left
unassigned to any other partition

#### Returns

A collection of partition names of all numbering sequences currently present in this schema.

#### Since

2015

### `M:Autodesk.Revit.DB.NumberingSchema.SetMinimumNumberOfDigits(Autodesk.Revit.DB.Document,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.NumberingSchema.SetMinimumNumberOfDigits(Autodesk.Revit.DB.Document,System.Int32)`

#### Summary

Sets a new value for the minimum number of digits to be used for formating
the Number parameter of all numbered elements of the given document.

#### Remarks

Valid values range from 1 to 10. Numbers with fewer digits
than the minimum number will be padded with leading zeros.

The value affects all numbering schemas. Thus, once set, numbers for
Rebar and Reinforcement Fabric will be formatted with the same minimum number of digits.

The current value can obtained by invoking the `M:Autodesk.Revit.DB.NumberingSchema.GetMinimumNumberOfDigits(Autodesk.Revit.DB.Document)` method.

#### Parameter `document`

The document in which the new value will be in applied.

#### Parameter `value`

New value for the minimum number of digits.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The minimum number of digits must be in range from 1 to 10.

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

2015

### `M:Autodesk.Revit.DB.NumberingSchema.GetMinimumNumberOfDigits(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.NumberingSchema.GetMinimumNumberOfDigits(Autodesk.Revit.DB.Document)`

#### Summary

Returns the minimum number of digits to be used for formating
the Number parameter of all enumerable elements of the given document.

#### Remarks

The number is used by all numbering schemas in the document.

The value can be modified by using the `M:Autodesk.Revit.DB.NumberingSchema.SetMinimumNumberOfDigits(Autodesk.Revit.DB.Document,System.Int32)` method.

#### Parameter `document`

The document this value is going to be applied to.

#### Returns

The current number of formatting digits

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.NumberingSchema.GetNumberingSchema(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.NumberingSchemaType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.NumberingSchema.GetNumberingSchema(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.NumberingSchemaType)`

#### Summary

Returns an instance of the specified Numbering Schema in the given document.

#### Parameter `document`

A document to get the numbering schema from.

#### Parameter `schemaType`

The type of a built-in schema to get.

#### Returns

Instance of the specified schema.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given schemaType has an invalid Id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.NumberingSchema.GetSchemasInDocument(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.NumberingSchema.GetSchemasInDocument(Autodesk.Revit.DB.Document)`

#### Summary

Returns a set of Ids of all Numbering Schema elements for a given document.

#### Parameter `document`

A document to get numbering schema from.

#### Returns

Ids of NumberingSchema elements. An empty set if no schemas are found in the given document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `P:Autodesk.Revit.DB.NumberingSchema.MaximumStartingNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.NumberingSchema.MaximumStartingNumber`

#### Summary

A static property defining the maximum number a numbering sequence can use
as its starting number (the lowest number in the sequence).

#### Remarks

Use this method to ensure a value given to the
`M:Autodesk.Revit.DB.NumberingSchema.ShiftNumbers(System.String,System.Int32)` is within the valid range.

#### Since

2015

### `P:Autodesk.Revit.DB.NumberingSchema.SchemaType`

Member kind: property
Symbol: `Autodesk.Revit.DB.NumberingSchema.SchemaType`

#### Summary

Identifies the kind of elements/objects this numbering schema is used for.

#### Since

2015

### `P:Autodesk.Revit.DB.NumberingSchema.NumberingParameterId`

Member kind: property
Symbol: `Autodesk.Revit.DB.NumberingSchema.NumberingParameterId`

#### Summary

Id of the parameter that stores values of the numbers on enumerated elements.

#### Remarks

Values of numbers can be obtained by querying this parameter for the respective numbered element.
The value is read-only and thus cannot be set; it is always computed based on the order of created
elements and the matching policy within each numbering sequence.

Note: Although the parameter cannot be changed directly, it can be modified indirectly
(with restrictions) using the `M:Autodesk.Revit.DB.NumberingSchema.ChangeNumber(System.String,System.Int32,System.Int32)` method.

#### Since

2015

### `T:Autodesk.Revit.DB.NumberingSchema`

Member kind: type
Symbol: `Autodesk.Revit.DB.NumberingSchema`

#### Summary

A class to support assigning numbers to elements of a particular kind for the purpose of tagging and scheduling them.

#### Remarks

Each NumberingSchema controls numbering of elements of one particular kind, typically of the same category such
as Rebar or Fabric Reinforcement. Instances of NumberingSchema are also elements and there is always only one of
each type in every Revit document. Available types of all built-in numbering schemas are enumerated in
`T:Autodesk.Revit.DB.NumberingSchemaTypes` class. At present, schema elements cannot be manually
added, deleted, or copied. Attempts to do so will result in a failure warning and/or exceptions thrown.

Elements (e.g. Rebar) belonging to a particular schema (e.g. NumberingSchemaTypes.StructuralNumberingSchemas.Rebar)
are organized and numbered in sequences. A sequence is a collection of elements that share the same numbering partition
as defined by their respective values of the Partition parameter (NUMBER_PARTITION_PARAM). For a numbering sequence
to exist it must contain at least one element. In other words, a sequence is established once there is at least
one element of which the partition parameter has a value that differs from other elements (in the same numbering schema).
If the last element is removed (deleted or moved to a different sequence) the then empty sequence ceases to exist.

Elements get assigned to sequences either upon their creation (based on the then current numbering partition value),
or by explicitly modifying the Partition parameter of an element, or by using the AssignElementsToSequence method.
It is highly recommended using that method over explicitly changing the Partition parameter, because the methods applies changes
to sequences and element numbers immediately, while changed parameters get into effect only after the current transaction is closed.

In addition to directly or indirectly changing the Partition parameter of elements, numbering sequences can be
reorganized by using methods of the NumberingSchema class. The `M:Autodesk.Revit.DB.NumberingSchema.MoveSequence(System.String,System.String)` method moves
all elements of an existing sequence to a new sequence that does not exist yet in the schema, thus effectively renaming
the Partition parameter on all the affected elements. The `M:Autodesk.Revit.DB.NumberingSchema.AppendSequence(System.String,System.String)` method removes
all elements from one sequence and appends them to elements of another existing sequence while applying the matching policy.
The method MergeSequences takes elements of all specified sequences and moves them all into a newly created sequence.
All the merged elements will be renumbered and matched as needed based on the matching algorithm.

Elements in different sequences are numbered independently, meaning that there may be elements with the same
number in two sequences even though the elements are different. Likewise, there may be perfectly identical
elements in two or more sequences bearing different numbers. However, within each one numbering sequence any
two identical elements will always have the same number, while different elements will never have the same
number within a numbering sequence. Revit refers to this rule as the matching policy.

Enumerable elements are always numbered automatically upon their creation. Each new element will get an
incrementally higher number. However, thanks to the matching policy, new elements that match existing elements
within the same sequence will get the same number assigned. Elements will keep their assigned numbers as long
as it is possible. This means, for example, that if some previously created elements (e.g. Rebar) get deleted,
all remaining elements (within the same numbering sequence) will keep their numbers, which may result in gaps in
the respective numbering sequence. Gaps can be removed by invoking `M:Autodesk.Revit.DB.NumberingSchema.RemoveGaps(System.String)` for sequences
in which gaps are not desired.

Numbers are stored as values of a numbering parameter on each numbered element. The Id of the parameter is obtained
by querying the `P:Autodesk.Revit.DB.NumberingSchema.NumberingParameterId` property. The value of the number can be obtained by querying the
parameter for the respective numbered element. The value is read-only and thus cannot be set; it is always computed based
on relations of elements across numbering partitions and the matching policy within the numbering sequence of each element.

Even though numbers are always assigned automatically to all elements of a schema, the method
`M:Autodesk.Revit.DB.NumberingSchema.ChangeNumber(System.String,System.Int32,System.Int32)` gives the programmer a way to explicitly overwrite a specific number as long
as the new number is unique in the numbering sequence. The caller specifies a number to be changed and a new value that is
to be applied, providing the value does not exist yet in the same numbering sequence. Although this operation may seem rather
limited, it provides the programmer with freedom to change practically any number even if it may be achieved in multiple steps.

#### Since

2015

### `M:Autodesk.Revit.DB.Architecture.NonContinuousRailInfo.IsValidNonContinuousRailMaterial(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.NonContinuousRailInfo.IsValidNonContinuousRailMaterial(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks whether an ElementId is a valid material Id of a non-continuous rail.

#### Parameter `materialId`

The material Id to be checked.

#### Returns

True if the ElementId refers to a valid material or it is invalidElementId, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Architecture.NonContinuousRailInfo.IsValidNonContinuousRailProfile(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.NonContinuousRailInfo.IsValidNonContinuousRailProfile(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks whether the input id represents a profile which can be used as the profile of this non-continuous rail.

#### Remarks

`P:Autodesk.Revit.DB.ElementId.InvalidElementId` is considered a valid NonContinuousRail profile (the default profile).

#### Parameter `profileId`

The profile Id to be checked.

#### Returns

True if the ElementId refers to a valid NonContinuousRail profile, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Architecture.NonContinuousRailInfo.IsValidNonContinuousRailName(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.NonContinuousRailInfo.IsValidNonContinuousRailName(System.String)`

#### Summary

Checks whether the input name is valid for a non-continuous rail in its associated railing type.

#### Remarks

The name must be unique within the `!:Autodesk::Revit::DB::Architecture::RailingType`
to which the non-continuous rail belongs.

#### Parameter `name`

The name to be checked.

#### Returns

True if the name is unique for the `!:Autodesk::Revit::DB::Architecture::RailingType` , false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Architecture.NonContinuousRailInfo.IsValidNonContinuousRailHeight(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.NonContinuousRailInfo.IsValidNonContinuousRailHeight(System.Double)`

#### Summary

Checks whether the input height is valid for a non-continuous rail in its associated railing type.

#### Remarks

The height cannot be greater than the height of a `!:Autodesk::Revit::DB::Architecture::RailingType`
to which the non-continuous rail belongs.

#### Parameter `height`

The height to be checked.

#### Returns

True if the height is smaller than the height of `!:Autodesk::Revit::DB::Architecture::RailingType` , false otherwise.

#### Since

2019

### `P:Autodesk.Revit.DB.Architecture.NonContinuousRailInfo.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.NonContinuousRailInfo.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Architecture.NonContinuousRailInfo.MaterialId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.NonContinuousRailInfo.MaterialId`

#### Summary

The material id associated with the non-continuous rail, or invalidElementId if none.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The materialId is not a valid value to be used as a non-continuous rail material Id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2019

### `P:Autodesk.Revit.DB.Architecture.NonContinuousRailInfo.ProfileId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.NonContinuousRailInfo.ProfileId`

#### Summary

The profile id of the non-continuous rail, or invalidElementId if none.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The profileId is not an Id of a valid NonContinuousRail profile.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2019

### `P:Autodesk.Revit.DB.Architecture.NonContinuousRailInfo.Offset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.NonContinuousRailInfo.Offset`

#### Summary

The side offset of the non-continuous rail from a `!:Autodesk::Revit::DB::Architecture::Railing` from the railing center.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for offset must be no more than 30000 feet in absolute value.

#### Since

2019

### `P:Autodesk.Revit.DB.Architecture.NonContinuousRailInfo.Height`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.NonContinuousRailInfo.Height`

#### Summary

The height at which the non-continuous rail will be placed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The height height is not valid for the non-continuous rail.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for height must be no more than 30000 feet in absolute value.

#### Since

2019

### `P:Autodesk.Revit.DB.Architecture.NonContinuousRailInfo.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.NonContinuousRailInfo.Name`

#### Summary

The name of the non-continuous rail.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: name is an empty string or contains only whitespace.
-or-
When setting this property: name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
-or-
When setting this property: The name name is not valid for the non-continuous rail.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2019

### `T:Autodesk.Revit.DB.Architecture.NonContinuousRailInfo`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.NonContinuousRailInfo`

#### Summary

A class which contains information needed to define a single non-continuous rail in a `!:Autodesk::Revit::DB::Architecture::RailingType` .

#### Since

2019

### `P:Autodesk.Revit.DB.Visual.Noise.TextureRealWorldOffsetZ`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Noise.TextureRealWorldOffsetZ`

#### Summary

The property labeled "Offset Z" from the "Noise" schema.

#### Remarks

This property is of type "AssetPropertyDistance".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Noise.TextureRealWorldOffsetY`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Noise.TextureRealWorldOffsetY`

#### Summary

The property labeled "Offset Y" from the "Noise" schema.

#### Remarks

This property is of type "AssetPropertyDistance".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Noise.TextureRealWorldOffsetX`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Noise.TextureRealWorldOffsetX`

#### Summary

The property labeled "Offset X" from the "Noise" schema.

#### Remarks

This property is of type "AssetPropertyDistance".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Noise.TextureLinkTextureTransforms`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Noise.TextureLinkTextureTransforms`

#### Summary

The property labeled "Link Transforms" from the "Noise" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Noise.TextureAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Noise.TextureAngle`

#### Summary

The property labeled "Angle" from the "Noise" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray3d".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Noise.NoisePhase`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Noise.NoisePhase`

#### Summary

The property labeled "Phase" from the "Noise" schema.

#### Remarks

This property is of type "AssetPropertyDouble".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Noise.NoiseLevels`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Noise.NoiseLevels`

#### Summary

The property labeled "Levels" from the "Noise" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "1, 10".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Noise.NoiseSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Noise.NoiseSize`

#### Summary

The property labeled "Size" from the "Noise" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0.001, 10000000000".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Noise.NoiseThresholdLow`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Noise.NoiseThresholdLow`

#### Summary

The property labeled "Low" from the "Noise" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 1".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Noise.NoiseThresholdHigh`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Noise.NoiseThresholdHigh`

#### Summary

The property labeled "High" from the "Noise" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 1".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Noise.NoiseColor2`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Noise.NoiseColor2`

#### Summary

The property labeled "Color 2" from the "Noise" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".
This property allows a connected asset.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Noise.NoiseColor1`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Noise.NoiseColor1`

#### Summary

The property labeled "Color 1" from the "Noise" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".
This property allows a connected asset.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Noise.NoiseType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Noise.NoiseType`

#### Summary

The property labeled "Noise Type" from the "Noise" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "NoiseType".

#### Since

2018.1

### `T:Autodesk.Revit.DB.Visual.Noise`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.Noise`

#### Summary

A static class that provides access to the property names that appear in the Noise visual asset schema.

#### Since

2018.1

### `M:Autodesk.Revit.DB.Analysis.MEPNetworkSegmentId.IsValid`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkSegmentId.IsValid`

#### Summary

Verifies if this is a valid segment id.

#### Returns

True if this is a valid segment id, otherwise false.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.MEPNetworkSegmentId.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkSegmentId.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Analysis.MEPNetworkSegmentId.SegmentId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkSegmentId.SegmentId`

#### Summary

The segment identifier.

#### Since

2024

### `P:Autodesk.Revit.DB.Analysis.MEPNetworkSegmentId.ElementId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkSegmentId.ElementId`

#### Summary

The element id where this analytical segment belongs.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.Analysis.MEPNetworkSegmentId.#ctor(Autodesk.Revit.DB.ElementId,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkSegmentId.#ctor(Autodesk.Revit.DB.ElementId,System.Int32)`

#### Summary

Creates a valid segment id on the network.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.Analysis.MEPNetworkSegmentId.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkSegmentId.#ctor`

#### Summary

Creates a default invalid segment id on the network.

#### Since

2024

### `T:Autodesk.Revit.DB.Analysis.MEPNetworkSegmentId`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.MEPNetworkSegmentId`

#### Summary

Represents a unique identifier for one analytical segment in the network.

#### Since

2024

### `P:Autodesk.Revit.DB.NestedFamilyTypeReference.TypeName`

Member kind: property
Symbol: `Autodesk.Revit.DB.NestedFamilyTypeReference.TypeName`

#### Summary

Type of the referenced family

#### Since

2016

### `P:Autodesk.Revit.DB.NestedFamilyTypeReference.FamilyName`

Member kind: property
Symbol: `Autodesk.Revit.DB.NestedFamilyTypeReference.FamilyName`

#### Summary

Name of the referenced family

#### Since

2016

### `P:Autodesk.Revit.DB.NestedFamilyTypeReference.CategoryId`

Member kind: property
Symbol: `Autodesk.Revit.DB.NestedFamilyTypeReference.CategoryId`

#### Summary

Category Id of the referenced family

#### Since

2016

### `T:Autodesk.Revit.DB.NestedFamilyTypeReference`

Member kind: type
Symbol: `Autodesk.Revit.DB.NestedFamilyTypeReference`

#### Summary

A proxy element representing a nested family type.

#### Remarks

This element represents a value of a FamilyType Parameter of a Loaded Family.
Each such element corresponds to a nested FamilyType Element in the original
Family Document where the family was defined.

This element stores only basic information about the nested FamilyType,
such as the name of the Type, name of the Family, and a Category.

These elements are very low-level and thus bypassed by standard element
filters. However, it is possible to obtain a set of applicable elements
of this class for a FamilyType parameter of a family by calling
`!:Autodesk::Revit::DB::Family::GetFamilyTypeParameterValues`

#### Since

2016

### `M:Autodesk.Revit.DB.NamingUtils.CompareNames(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.NamingUtils.CompareNames(System.String,System.String)`

#### Summary

Compares two object name strings using Revit's comparison rules.

#### Remarks

This routine is similar to System.String.Compare(), but uses Revit rules for comparison. This involves
breaking the names into alphabetic and numeric tokens and comparing tokens individually. Neither comparand is
allowed to be `null` .

Note that this routine does consider case in comparing names. Some Revit element types disallow assignment
of names where the only difference with existing names is the case of one or more characters, while other
element types do not have this restriction. This routine does not take the particular element type into
account, so it may not identify all "duplicates" if the names are to be used for some element types.
Attempting to set the name on the target Element should provide the final indication of whether it is valid.

#### Parameter `nameA`

The first object name to compare.

#### Parameter `nameB`

The second object name to compare.

#### Returns

An integer indicating the result of the lexical comparison between the two names.
Less than zero if nameA comes before nameB in the ordering, zero if nameA and nameB are equivalent,
and greater than zero if nameA is comes after nameB in the ordering.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.NamingUtils.IsValidName(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.NamingUtils.IsValidName(System.String)`

#### Summary

Identifies if the input string is valid for use as an object name in Revit.

#### Remarks

This routine checks only for prohibited characters in the string.
When setting the name for an object there are other specific considerations which are checked
(for example, the same name cannot be used twice for different elements of the same type).
This routine does not check those conditions.

#### Parameter `string`

The name to validate.

#### Returns

True if the name is valid for use as a name in Revit, false if it contains prohibited characters and is invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `T:Autodesk.Revit.DB.NamingUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.NamingUtils`

#### Summary

A collection of utilities related to element naming.

#### Since

2015

### `M:Autodesk.Revit.DB.ViewSheetSetting.Revert`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSheetSetting.Revert`

#### Summary

Revert the current view sheet set.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the current view sheet set is In-Session.

### `M:Autodesk.Revit.DB.ViewSheetSetting.Delete`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSheetSetting.Delete`

#### Summary

Delete the current view sheet set, and make the In-Session set as the current one.

#### Returns

False if Delete operation fails, otherwise True.

#### Remarks

If the current view sheet set is In-Session, an InvalidOperationException
will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the current view sheet set is In-Session.

### `M:Autodesk.Revit.DB.ViewSheetSetting.Rename(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSheetSetting.Rename(System.String)`

#### Summary

Rename the current view sheet set.

#### Parameter `newName`

View sheet set name to be renamed as.

#### Returns

False if Rename operation fails, otherwise True.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the input name is already existed in current view sheet set list.

### `M:Autodesk.Revit.DB.ViewSheetSetting.SaveAs(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSheetSetting.SaveAs(System.String)`

#### Summary

Save the current view sheet set to another view sheet set with the specified name.

#### Parameter `newName`

View sheet set name to be saved as.

#### Returns

False if Save As operation fails, otherwise True.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the input name is already existed in current view sheet set list.

### `M:Autodesk.Revit.DB.ViewSheetSetting.Save`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewSheetSetting.Save`

#### Summary

Save the changes for the current view sheet set.

#### Returns

False if save operation fails, otherwise True.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the current view sheet set is In-Session or the current view sheet set is unchanged.

### `P:Autodesk.Revit.DB.ViewSheetSetting.InSession`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewSheetSetting.InSession`

#### Summary

The in-session view sheet set of Print Setup.

### `P:Autodesk.Revit.DB.ViewSheetSetting.AvailableViews`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewSheetSetting.AvailableViews`

#### Summary

All views that can be printed.

#### Remarks

Users can select the view/sheet from this view set to printing.

### `P:Autodesk.Revit.DB.ViewSheetSetting.CurrentViewSheetSet`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewSheetSetting.CurrentViewSheetSet`

#### Summary

The current view sheet set of PrintSetup.

### `T:Autodesk.Revit.DB.ViewSheetSetting`

Member kind: type
Symbol: `Autodesk.Revit.DB.ViewSheetSetting`

#### Summary

Represents the View/Sheet Set (Application Menu->Print) within Autodesk Revit.

### `P:Autodesk.Revit.DB.PaperSource.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.PaperSource.Name`

#### Summary

Retrieve the paper source name of current project.

### `T:Autodesk.Revit.DB.PaperSource`

Member kind: type
Symbol: `Autodesk.Revit.DB.PaperSource`

#### Summary

An object that represents a Paper Source of Print Setup within the Autodesk Revit project.

#### Remarks

This object derived from the APIObject base object.

### `P:Autodesk.Revit.DB.PaperSize.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.PaperSize.Name`

#### Summary

Retrieve the paper size name of current project.

### `T:Autodesk.Revit.DB.PaperSize`

Member kind: type
Symbol: `Autodesk.Revit.DB.PaperSize`

#### Summary

An object that represents a Paper Size of Print Setup within the Autodesk Revit project.

#### Remarks

This object derived from the APIObject base object.

### `M:FamInstAnalyticalHelper.getAMPlane(FamilyInstance!System.Runtime.CompilerServices.IsConst*,System.Int32,AnalyticalDirection.Enum,ElementId)`

Member kind: method
Symbol: `FamInstAnalyticalHelper.getAMPlane(FamilyInstance!System.Runtime.CompilerServices.IsConst*,System.Int32,AnalyticalDirection.Enum,ElementId)`

### `M:FamInstAnalyticalHelper.createZeroLengthAnalyticalModelLine(XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `FamInstAnalyticalHelper.createZeroLengthAnalyticalModelLine(XYZUtils.XYZ!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

### `M:FamInstAnalyticalHelper.getProjectedAnalyticalModel`

Member kind: method
Symbol: `FamInstAnalyticalHelper.getProjectedAnalyticalModel`

### `M:SiteSurfaceUtil.projectXYZArrToUVArr(Arr<XYZUtils.XYZ>!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `SiteSurfaceUtil.projectXYZArrToUVArr(Arr<XYZUtils.XYZ>!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

### `M:Autodesk.Revit.DB.PlanCircuit.GetPointInside`

Member kind: method
Symbol: `Autodesk.Revit.DB.PlanCircuit.GetPointInside`

#### Summary

Returns a point inside the circuit.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when a valid UV point couldn't be obtained.

#### Since

2015

### `P:Autodesk.Revit.DB.PlanCircuit.IsRoomLocated`

Member kind: property
Symbol: `Autodesk.Revit.DB.PlanCircuit.IsRoomLocated`

#### Summary

Reports whether there is a room located in this circuit.

#### Value

True if there is a room located in this circuit on the circuit's level, false if there is no room
located in this circuit on the circuit's level.

### `P:Autodesk.Revit.DB.PlanCircuit.Area`

Member kind: property
Symbol: `Autodesk.Revit.DB.PlanCircuit.Area`

#### Summary

The enclosed area of the circuit.

### `P:Autodesk.Revit.DB.PlanCircuit.SideNum`

Member kind: property
Symbol: `Autodesk.Revit.DB.PlanCircuit.SideNum`

#### Summary

The number of sides in the circuit.

### `T:Autodesk.Revit.DB.PlanCircuit`

Member kind: type
Symbol: `Autodesk.Revit.DB.PlanCircuit`

#### Summary

An object that represents an enclosed area in a plan view within the Autodesk Revit project.

#### Remarks

Plan circuits are enclosed regions as seen on a plan view. They are used to determine the
boundary extents of rooms based on the placement of walls. In the Autodesk Revit API, you can use
plan circuits to create new rooms.

### `M:Autodesk.Revit.Creation.Document.NewTakeoffFitting(Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.MEPCurve)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewTakeoffFitting(Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.MEPCurve)`

#### Summary

Add a new family instance of an takeoff fitting into the Autodesk Revit document,
using one connector and one MEP curve.

#### Parameter `connector`

The connector to be connected to the takeoff.

#### Parameter `curve`

The duct or pipe which is the trunk for the takeoff.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument connector1 or curve is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the connector and the curve cannot be used for takeoff creation. For example,
they must be of the same domain, the curve must be a duct or pipe,
and the owner of the connector should be (flex) duct or pipe.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when takeoff fitting cannot be created.

#### Returns

If creation was successful then an family instance to the new object is returned,
otherwise an exception with failure information will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the curve does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewUnionFitting(Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewUnionFitting(Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

#### Summary

Add a new family instance of an union fitting into the Autodesk Revit document,
using two connectors.

#### Parameter `connector1`

The first connector to be connected to the union.

#### Parameter `connector2`

The second connector to be connected to the union.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument connector1 or connector2 is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the connectors cannot be used for union creation. For example,
they cannot be from the same element, they must be of the same domain and shape,
and the owner of the connector1 should be a (flex) duct or pipe.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when union fitting cannot be created.

#### Returns

If creation was successful then an family instance to the new object is returned,
otherwise an exception with failure information will be thrown.

### `M:Autodesk.Revit.Creation.Document.NewCrossFitting(Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewCrossFitting(Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

#### Summary

Add a new family instance of a cross fitting into the Autodesk Revit document,
using four connectors.

#### Parameter `connector1`

The first connector to be connected to the cross.

#### Parameter `connector2`

The second connector to be connected to the cross.

#### Parameter `connector3`

The third connector to be connected to the cross.

#### Parameter `connector4`

The fourth connector to be connected to the cross.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument connector1, connector2, connector3, or connector4 is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the connectors cannot be used for cross creation. For example,
they cannot be from the same element, they must be of the same domain,
and the owner of the connectors should be a (flex) duct or pipe.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when cross fitting cannot be created.

#### Returns

If creation was successful then an family instance to the new object is returned,
and the transition fitting will be added at the connectors' end if necessary,
otherwise an exception with failure information will be thrown.

### `M:Autodesk.Revit.Creation.Document.NewTransitionFitting(Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewTransitionFitting(Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

#### Summary

Add a new family instance of an transition fitting into the Autodesk Revit document,
using two connectors.

#### Parameter `connector1`

The first connector to be connected to the transition.

#### Parameter `connector2`

The second connector to be connected to the transition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument connector1 or connector2 is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the connectors cannot be used for transition creation. For example,
they cannot be from the same element, they must be of the same domain,
and the owner of connector1 should be a (flex) duct or pipe.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when transition fitting cannot be created.

#### Returns

If creation was successful then an family instance to the new object is returned,
otherwise an exception with failure information will be thrown.

### `M:Autodesk.Revit.Creation.Document.NewTeeFitting(Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewTeeFitting(Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

#### Summary

Add a new family instance of a tee fitting into the Autodesk Revit document,
using three connectors.

#### Parameter `connector1`

The first connector to be connected to the tee.

#### Parameter `connector2`

The second connector to be connected to the tee.

#### Parameter `connector3`

The third connector to be connected to the tee.
This should be connected to the branch of the tee.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument connector1, connector2 or connector3 is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the connectors cannot be used for the tee creation. For example,
they cannot be from the same element, they must be of the same domain,
and the owner of the connectors should be a (flex) duct or pipe.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when tee fitting cannot be created.

#### Returns

If creation was successful then an family instance to the new object is returned,
and the transition fitting will be added at the connectors' end if necessary,
otherwise an exception with failure information will be thrown.

### `M:Autodesk.Revit.Creation.Document.NewElbowFitting(Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewElbowFitting(Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

#### Summary

Add a new family instance of an elbow fitting into the Autodesk Revit document,
using two connectors.

#### Parameter `connector1`

The first connector to be connected to the elbow.

#### Parameter `connector2`

The second connector to be connected to the elbow.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument connector1 or connector2 is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the connectors cannot be used for the elbow creation. For example,
they cannot be from the same element, they must be of the same domain,
and the angle between them must fall within the valid range (typically 2 to 95 degrees).

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when an elbow fitting cannot be created because the angle between the two connectors is too large or too small,
the connectors are not close enough together, or the connectors are placed at positions with too high of a tolerance.

#### Returns

If creation was successful then an family instance to the new object is returned,
otherwise an exception with failure information will be thrown.

### `M:Autodesk.Revit.Creation.Document.NewFlexPipe(Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Plumbing.FlexPipeType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewFlexPipe(Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Plumbing.FlexPipeType)`

#### Summary

Adds a new flexible pipe into the document,
using two connector, and flexible pipe type.

#### Parameter `connector1`

The first connector to be connected to the pipe.

#### Parameter `connector2`

The second connector to be connected to the pipe.

#### Parameter `pipeType`

The type of the flexible pipe.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument connector1 or connector2 is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the flexible pipe cannot be created or regenerate fails.

#### Returns

If creation was successful then a new flexible pipe is returned,
otherwise an exception with failure information will be thrown.

#### Remarks

If the connectors are fitting or equipment connectors of the correct domain,
and if the connectors' direction match the direction of the flexible pipe to be created,
the connectors will be automatically connected. A transition fitting will be added
at the connector(s) if necessary. If the connector's type, domain,
does not match the one of the input connectors, no connection will be established.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the flexible pipe type does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewFlexPipe(Autodesk.Revit.DB.Connector,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},Autodesk.Revit.DB.Plumbing.FlexPipeType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewFlexPipe(Autodesk.Revit.DB.Connector,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},Autodesk.Revit.DB.Plumbing.FlexPipeType)`

#### Summary

Adds a new flexible pipe into the document,
using a connector, point array and pipe type.

#### Parameter `connector`

The connector to be connected to the flexible pipe, including the end points.

#### Parameter `points`

The point array indicating the path of the flexible pipe.

#### Parameter `pipeType`

The type of the flexible pipe.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument connector or points is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the flexible pipe cannot be created or regenerate fails.

#### Returns

If creation was successful then a new flexible pipe is returned,
otherwise an exception with failure information will be thrown.

#### Remarks

If the connector is a fitting or equipment connector of the correct domain,
and if the connector's direction matches the direction of the flexible pipe to be created,
the connectors will be automatically connected. A transition fitting will be added
at the connector(s) if necessary. If the connector's type, domain,
does not match the one of the input connector, no connection will be established.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the flexible pipe type does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewFlexPipe(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},Autodesk.Revit.DB.Plumbing.FlexPipeType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewFlexPipe(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},Autodesk.Revit.DB.Plumbing.FlexPipeType)`

#### Overloads

Adds a new flexible pipe into the document.

#### Summary

Adds a new flexible pipe into the document,
using a point array and pipe type.

#### Parameter `points`

The point array indicating the path of the flexible pipe, including the end points.

#### Parameter `pipeType`

The type of the flexible pipe.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument points is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the flexible pipe cannot be created or regenerate fails.

#### Returns

If creation was successful then a new flexible pipe is returned,
otherwise an exception with failure information will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the flexible pipe type does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewFlexDuct(Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Mechanical.FlexDuctType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewFlexDuct(Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Mechanical.FlexDuctType)`

#### Summary

Adds a new flexible duct into the document,
using two connector, and duct type.

#### Parameter `connector1`

The first connector to be connected to the duct.

#### Parameter `connector2`

The second connector to be connected to the duct.

#### Parameter `ductType`

The type of the flexible duct.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument connector1 or connector2 is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the flexible duct cannot be created or regenerate fails.

#### Returns

If creation was successful then a new flexible duct is returned,
otherwise an exception with failure information will be thrown.

#### Remarks

If the connectors are fitting or equipment connectors of the correct domain,
and if the connectors' direction match the direction of the flexible duct to be created,
the connectors will be automatically connected. A transition fitting will be added
at the connector(s) if necessary. If the connector's type, domain,
does not match the one of the input connector, no connection will be established.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the flexible duct type does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewFlexDuct(Autodesk.Revit.DB.Connector,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},Autodesk.Revit.DB.Mechanical.FlexDuctType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewFlexDuct(Autodesk.Revit.DB.Connector,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},Autodesk.Revit.DB.Mechanical.FlexDuctType)`

#### Summary

Adds a new flexible duct into the document,
using a connector, point array and duct type.

#### Parameter `connector`

The connector to be connected to the duct, including the end points.

#### Parameter `points`

The point array indicating the path of the flexible duct.

#### Parameter `ductType`

The type of the flexible duct.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument connector or points is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the flexible duct cannot be created or regenerate fails.

#### Returns

If creation was successful then a new flexible duct is returned,
otherwise an exception with failure information will be thrown.

#### Remarks

If the connector is a fitting or equipment connector of the correct domain,
and if the connector's direction matches the direction of the flexible duct to be created,
the connectors will be automatically connected. A transition fitting will be added
at the connector(s) if necessary. If the connector's type, domain,
does not match the one of the input connector, no connection will be established.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the flexible duct type does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewFlexDuct(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},Autodesk.Revit.DB.Mechanical.FlexDuctType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewFlexDuct(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},Autodesk.Revit.DB.Mechanical.FlexDuctType)`

#### Overloads

Adds a new flexible duct into the document.

#### Summary

Adds a new flexible duct into the document,
using a point array and duct type.

#### Parameter `points`

The point array indicating the path of the flexible duct, including the end points.

#### Parameter `ductType`

The type of the flexible duct.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument points is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the flexible duct cannot be created or regenerate fails.

#### Returns

If creation was successful then a new flexible duct is returned,
otherwise an exception with failure information will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the flexible duct type does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewFamilyInstance(Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.Level,Autodesk.Revit.DB.Structure.StructuralType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewFamilyInstance(Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.Level,Autodesk.Revit.DB.Structure.StructuralType)`

#### Summary

Inserts a new instance of a family into the document,
using a curve, type/symbol and reference level.

#### Parameter `curve`

The curve where the instance is based.

#### Parameter `symbol`

A FamilySymbol object that represents the type of the instance that is to be inserted.

#### Parameter `level`

A Level object that is used as the base level for the object.

#### Parameter `structuralType`

If structural then specify the type of the component.

#### Returns

If creation was successful then an instance to the new object is returned, otherwise `null` .

#### Remarks

This method is used to insert one family instance into another element along the geometry of a curve.
If the instance fails to be created an
exception may be thrown.

The type/symbol that is used must be loaded into the document before this
method is called. Families and their symbols can be loaded using the Document.LoadFamily or
Document.LoadFamilySymbol methods.

The host object must be one that supports insertion of
instances otherwise this method will fail. All levels within the document can be found by iterating
over the entire document and searching for objects of type Autodesk.Revit.Elements.Level.

Note: if the created family instance includes nested instances, the API framework will automatically regenerate
the document during this method call.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the family symbol does not exist in the given document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the level does not exist in the given document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if The symbol is not active.

### `M:Autodesk.Revit.Creation.Document.NewFamilyInstance(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Level,Autodesk.Revit.DB.Structure.StructuralType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewFamilyInstance(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Level,Autodesk.Revit.DB.Structure.StructuralType)`

#### Summary

Inserts a new instance of a family into the document,
using a location, type/symbol, the host element and a base level.

#### Parameter `location`

The physical location where the instance is to be placed on the specified level.

#### Parameter `symbol`

A FamilySymbol object that represents the type of the instance that is to be inserted.

#### Parameter `host`

A host object into which the instance will be embedded

#### Parameter `level`

A Level object that is used as the base level for the object.

#### Parameter `structuralType`

If structural then specify the type of the component.

#### Returns

If creation was successful then an instance to the new object is returned, otherwise `null` .

#### Remarks

This form of NewFamilyInstance is the most commonly used in Autodesk Revit since there are
a large number of elements that use levels, such as Walls, Columns etc. If the instance fails to
be created an exception may be thrown.

The type/symbol that is used must be loaded into the document
before this method is called. Families and their symbols can be loaded using the Document.LoadFamily
or Document.LoadFamilySymbol methods.

All levels within the document can be found by iterating over
the entire document and searching for objects of type Autodesk.Revit.Elements.Level.

Some Families, such as Beams, have more than one endpoint and are inserted in the same manner as single point
instances. Once inserted these linear family instances can have their endpoints changed by using
the instance's Element.Location property.

Note: ForbiddenForDynamicUpdateException might be thrown during a dynamic update if the inserted instance establishes a mutual dependency with another structure.

Note: if the created family instance includes nested instances, the API framework will automatically regenerate
the document during this method call.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the family symbol does not exist in the given document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the host does not exist in the given document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the level does not exist in the given document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if The symbol is not active.

### `M:Autodesk.Revit.Creation.Document.NewFascia(Autodesk.Revit.DB.Architecture.FasciaType,Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewFascia(Autodesk.Revit.DB.Architecture.FasciaType,Autodesk.Revit.DB.Reference)`

#### Summary

Creates a fascia along a reference.

#### Parameter `FasciaType`

The type of the fascia to create

#### Parameter `reference`

A planar line or arc that represents the place where you
want to place the fascia.

#### Returns

If successful a new fascia object within the project, otherwise `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the fascia type does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewFascia(Autodesk.Revit.DB.Architecture.FasciaType,Autodesk.Revit.DB.ReferenceArray)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewFascia(Autodesk.Revit.DB.Architecture.FasciaType,Autodesk.Revit.DB.ReferenceArray)`

#### Overloads

Creates a fascia.

#### Summary

Creates a fascia along a reference array.

#### Parameter `FasciaType`

The type of the fascia to create

#### Parameter `references`

An array of planar lines and arcs that represents the place where you
want to place the fascia.

#### Returns

If successful a new fascia object within the project, otherwise `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the fascia type does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewGutter(Autodesk.Revit.DB.Architecture.GutterType,Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewGutter(Autodesk.Revit.DB.Architecture.GutterType,Autodesk.Revit.DB.Reference)`

#### Summary

Creates a gutter along a reference.

#### Parameter `GutterType`

The type of the gutter to create

#### Parameter `reference`

A planar line or arc that represents the place where you
want to place the gutter.

#### Returns

If successful a new gutter object within the project, otherwise `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the gutter type does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewGutter(Autodesk.Revit.DB.Architecture.GutterType,Autodesk.Revit.DB.ReferenceArray)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewGutter(Autodesk.Revit.DB.Architecture.GutterType,Autodesk.Revit.DB.ReferenceArray)`

#### Overloads

Creates a gutter.

#### Summary

Creates a gutter along a reference array.

#### Parameter `GutterType`

The type of the gutter to create

#### Parameter `references`

An array of planar lines and arcs that represents the place where you
want to place the gutter.

#### Returns

If successful a new gutter object within the project, otherwise `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the gutter type does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewSlabEdge(Autodesk.Revit.DB.SlabEdgeType,Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewSlabEdge(Autodesk.Revit.DB.SlabEdgeType,Autodesk.Revit.DB.Reference)`

#### Summary

Creates a slab edge along a reference.

#### Parameter `SlabEdgeType`

The type of the slab edge to create

#### Parameter `reference`

A planar line or arc that represents the place where you
want to place the slab edge.

#### Returns

If successful a new slab edge object within the project, otherwise `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the slab edge type does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewSlabEdge(Autodesk.Revit.DB.SlabEdgeType,Autodesk.Revit.DB.ReferenceArray)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewSlabEdge(Autodesk.Revit.DB.SlabEdgeType,Autodesk.Revit.DB.ReferenceArray)`

#### Overloads

Creates a slab edge.

#### Summary

Creates a slab edge along a reference array.

#### Parameter `SlabEdgeType`

The type of the slab edge to create

#### Parameter `references`

An array of planar lines and arcs that represents the place where you
want to place the slab edge.

#### Returns

If successful a new slab edge object within the project, otherwise `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the slab edge type does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewCurtainSystem(Autodesk.Revit.DB.FaceArray,Autodesk.Revit.DB.CurtainSystemType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewCurtainSystem(Autodesk.Revit.DB.FaceArray,Autodesk.Revit.DB.CurtainSystemType)`

#### Summary

Creates a new CurtainSystem element from a set of faces.

#### Parameter `faces`

The faces new CurtainSystem will be created on.

#### Parameter `curtainSystemType`

The Type of CurtainSystem to be created.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown in following cases:
The input argument faces or curtainSystemType is `null` .
The size of faces is zero.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the CurtainSystem cannot be created or regenerate fails.

#### Returns

The CurtainSystem created will be returned when the operation succeeds.

#### Remarks

The input faces will be copied during the operations so that they can be any
faces.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the curtain system type does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewCurtainSystem2(Autodesk.Revit.DB.ReferenceArray,Autodesk.Revit.DB.CurtainSystemType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewCurtainSystem2(Autodesk.Revit.DB.ReferenceArray,Autodesk.Revit.DB.CurtainSystemType)`

#### Overloads

Creates a new CurtainSystem element.

#### Summary

Creates a new CurtainSystem element from a set of face references.

#### Parameter `faces`

The faces new CurtainSystem will be created on.

#### Parameter `curtainSystemType`

The Type of CurtainSystem to be created.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown in following cases:
The input argument faces or curtainSystemType is `null` .
The size of faces is zero.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the CurtainSystem cannot be created, for example, the input faces don't
belong to same mass or generic model. Or regenerate fails.

#### Returns

A set of ElementIds of CurtainSystems will be returned when the operation succeeds.

#### Remarks

The faces can belong to different masses or generic models. The number of CurtainSystems will be equal to the number of masses and generic models.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the curtain system type does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewZone(Autodesk.Revit.DB.Level,Autodesk.Revit.DB.Phase)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewZone(Autodesk.Revit.DB.Level,Autodesk.Revit.DB.Phase)`

#### Summary

Creates a new Zone element.

#### Parameter `level`

The level on which the Zone is to exist.

#### Parameter `phase`

The associative phase on which the Zone is to exist.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the specified parameter Value is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the electrical system cannot be created by these input phase and level.

#### Returns

If successful a new Zone element within the project, otherwise `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the level does not exist in the given document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the phase does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewRoomBoundaryLines(Autodesk.Revit.DB.SketchPlane,Autodesk.Revit.DB.CurveArray,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewRoomBoundaryLines(Autodesk.Revit.DB.SketchPlane,Autodesk.Revit.DB.CurveArray,Autodesk.Revit.DB.View)`

#### Summary

Creates a new boundary line as an Room border.

#### Parameter `sketchPlane`

The sketch plan

#### Parameter `curves`

The geometry curves on which the boundary lines are

#### Parameter `view`

The View for the new Room

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the sketch plane does not exist in the given document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the view does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewSpaceBoundaryLines(Autodesk.Revit.DB.SketchPlane,Autodesk.Revit.DB.CurveArray,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewSpaceBoundaryLines(Autodesk.Revit.DB.SketchPlane,Autodesk.Revit.DB.CurveArray,Autodesk.Revit.DB.View)`

#### Summary

Creates a new boundary line as an Space border.

#### Parameter `sketchPlane`

The sketch plan

#### Parameter `curves`

The geometry curves on which the boundary lines are

#### Parameter `view`

The View for the new Space

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the sketch plane does not exist in the given document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the view does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewSpaceTag(Autodesk.Revit.DB.Mechanical.Space,Autodesk.Revit.DB.UV,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewSpaceTag(Autodesk.Revit.DB.Mechanical.Space,Autodesk.Revit.DB.UV,Autodesk.Revit.DB.View)`

#### Summary

Creates a new SpaceTag.

#### Parameter `space`

The Space which the tag refers.

#### Parameter `point`

A 2D point that dictates the location on the level of the space.

#### Parameter `view`

The view where the tag will lie.

#### Returns

If successful a SpaceTag object will be returned, otherwise `null` .
Suitable exceptions will be fired if the parameters are invalid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the space does not exist in the given document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the view does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewSpaces2(Autodesk.Revit.DB.Phase,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewSpaces2(Autodesk.Revit.DB.Phase,System.Int32)`

#### Summary

Creates a set of new unplaced spaces on a given phase.

#### Parameter `phase`

The phase in which the spaces are to exist.

#### Returns

If successful, a set of ElementIds of new unplaced spaces are be returned, otherwise `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the phase does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewSpaces2(Autodesk.Revit.DB.Level,Autodesk.Revit.DB.Phase,Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewSpaces2(Autodesk.Revit.DB.Level,Autodesk.Revit.DB.Phase,Autodesk.Revit.DB.View)`

#### Overloads

Creates one or more spaces.

#### Summary

Creates new spaces on the available plan circuits of a the given level.

#### Parameter `level`

The level on which the spaces is to exist.

#### Parameter `phase`

The phase in which the spaces is to exist.

#### Parameter `view`

The view on which the space tags for the spaces are to display.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The view of the relevant level can not be retrieved.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The phase is invalid or regeneration fails at the end of the creation.

#### Returns

If successful, a set of ElementIds which contains the rooms should be returned, otherwise the exception will be thrown.

#### Remarks

This method will regenerate the document even in manual regeneration mode.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the level does not exist in the given document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the phase does not exist in the given document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the view does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewSpace(Autodesk.Revit.DB.Level,Autodesk.Revit.DB.Phase,Autodesk.Revit.DB.UV)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewSpace(Autodesk.Revit.DB.Level,Autodesk.Revit.DB.Phase,Autodesk.Revit.DB.UV)`

#### Summary

Creates a new space element on the given level, at the given location, and assigned to the given phase.

#### Parameter `level`

The level on which the room is to exist.

#### Parameter `phase`

The phase in which the room is to exist.

#### Parameter `point`

A 2D point that dictates the location on that specified level.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when level, phase or point is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the space cannot be created.

#### Returns

If successful a new Space element within the project, otherwise `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the level does not exist in the given document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the phase does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewSpace(Autodesk.Revit.DB.Level,Autodesk.Revit.DB.UV)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewSpace(Autodesk.Revit.DB.Level,Autodesk.Revit.DB.UV)`

#### Summary

Creates a new space element on the given level at the given location.

#### Parameter `level`

The level on which the space is to exist.

#### Parameter `point`

A 2D point that dictates the location on that specified level.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when level or point is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the space cannot be created.

#### Returns

If successful the new space element is returned, otherwise `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the level does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewSpace(Autodesk.Revit.DB.Phase)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewSpace(Autodesk.Revit.DB.Phase)`

#### Overloads

Creates a new space.

#### Summary

Creates a new unplaced space on a given phase.

#### Parameter `phase`

The phase in which the space is to exist.

#### Returns

If successful the new space should be returned, otherwise `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the phase does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewPipingSystem(Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.ConnectorSet,Autodesk.Revit.DB.Plumbing.PipeSystemType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewPipingSystem(Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.ConnectorSet,Autodesk.Revit.DB.Plumbing.PipeSystemType)`

#### Summary

Creates a new MEP piping system element.

#### Parameter `baseEquipmentConnector`

One connector within base equipment which is used to connect with the system.
The base equipment is optional for the system, so this argument may be `null` .
The baseEquipmentConnector should not be included in the connectors.

#### Parameter `connectors`

Connectors that will connect to the system.
The owner elements of these connectors will be added into system as its elements.

#### Parameter `pipingSystemType`

The System type.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when calling this function outside of the Autodesk Revit MEP product.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the connectors parameter value is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the pipingSystemType parameter value is out of permitted scope.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when some connectors can't be used to create the mechanical system.
All the input connectors and base equipment connector should match system type and domain with the system,
and they should not have been used in another system.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the piping system creation failed.

#### Returns

If creation was successful then an instance of piping system is returned,
otherwise an exception with information will be thrown.

#### Remarks

This method will regenerate the document even in manual regeneration mode.

### `M:Autodesk.Revit.Creation.Document.NewMechanicalSystem(Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.ConnectorSet,Autodesk.Revit.DB.Mechanical.DuctSystemType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewMechanicalSystem(Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.ConnectorSet,Autodesk.Revit.DB.Mechanical.DuctSystemType)`

#### Summary

Creates a new MEP mechanical system element.

#### Parameter `baseEquipmentConnector`

One connector within base equipment which is used to connect with the system.
The base equipment is optional for the system, so this argument may be `null` .
The baseEquipmentConnector should not be included in the connectors.

#### Parameter `connectors`

Connectors that will connect to the system.
The owner elements of these connectors will be added into system as its elements.

#### Parameter `ductSystemType`

The system type.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when calling this function outside of the Autodesk Revit MEP product.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input connectors parameter value is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the ductSystemType parameter is out of permitted scope.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when some connectors can't be used to create the mechanical system.
All the input connectors and base equipment connector should match system type and domain with the system,
and they should not have been used in another system.
The owner of BaseConnector should be a mechanical equipment, and the owner of other connectors should be a mechanical equipment or air terminal.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the mechanical system creation failed.

#### Returns

If creation was successful then an instance of mechanical system is returned,
otherwise an exception with information will be thrown.

#### Remarks

This method will regenerate the document even in manual regeneration mode.

### `M:Autodesk.Revit.Creation.Document.NewExtrusionRoof(Autodesk.Revit.DB.CurveArray,Autodesk.Revit.DB.ReferencePlane,Autodesk.Revit.DB.Level,Autodesk.Revit.DB.RoofType,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewExtrusionRoof(Autodesk.Revit.DB.CurveArray,Autodesk.Revit.DB.ReferencePlane,Autodesk.Revit.DB.Level,Autodesk.Revit.DB.RoofType,System.Double,System.Double)`

#### Summary

Creates a new Extrusion Roof.

#### Parameter `profile`

The profile of the extrusion roof. The curves of the profile must be contiguous and form one open loop without self-intersections. The profile curves must lie in the %refPlane% parallel to z-axis.

#### Parameter `refPlane`

The work plane for the extrusion roof. It must be parallel to z-axis.

#### Parameter `level`

The level of the extrusion roof.

#### Parameter `roofType`

Type of the extrusion roof.

#### Parameter `extrusionStart`

Start the extrusion. Measured from %refPlane% in the direction of the plane normal.

#### Parameter `extrusionEnd`

End the extrusion. Measured from %refPlane% in the direction of the plane normal.

#### Remarks

This method will regenerate the document even in manual regeneration mode.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the work plane does not exist in the given document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the level does not exist in the given document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the roof type does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewFootPrintRoof(Autodesk.Revit.DB.CurveArray,Autodesk.Revit.DB.Level,Autodesk.Revit.DB.RoofType,Autodesk.Revit.DB.ModelCurveArray@)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewFootPrintRoof(Autodesk.Revit.DB.CurveArray,Autodesk.Revit.DB.Level,Autodesk.Revit.DB.RoofType,Autodesk.Revit.DB.ModelCurveArray@)`

#### Summary

Creates a new FootPrintRoof element.

#### Parameter `footPrint`

The footprint of the FootPrintRoof.

#### Parameter `level`

The level of the FootPrintRoof.

#### Parameter `roofType`

Type of the FootPrintRoof.

#### Parameter `footPrintToModelCurvesMapping`

An array of Model Curves corresponding to the set of Curves input in the footPrint. By knowing which Model Curve was created by each footPrint curve, you can set properties like SlopeAngle for each curve.

#### Remarks

This method will regenerate the document even in manual regeneration mode.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the level does not exist in the given document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the roof type does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewAreas(System.Collections.Generic.List{Autodesk.Revit.Creation.AreaCreationData})`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewAreas(System.Collections.Generic.List{Autodesk.Revit.Creation.AreaCreationData})`

#### Summary

Creates new areas

#### Parameter `dataList`

A list of AreaCreationData which wraps the creation arguments of the areas to be created.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

If AreaCreationData's areaPoint is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

If the area cannot be created successfully or the phase is invalid or regeneration fails at the end of the batch creation.

#### Returns

If successful an Element Set which contains the areas should be returned, otherwise the exception will be thrown.

### `M:Autodesk.Revit.Creation.Document.NewArea(Autodesk.Revit.DB.ViewPlan,Autodesk.Revit.DB.UV)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewArea(Autodesk.Revit.DB.ViewPlan,Autodesk.Revit.DB.UV)`

#### Summary

Creates a new area

#### Parameter `areaView`

The view of area element.

#### Parameter `point`

The point which lies in the enclosed region of AreaBoundaryLines to put the new created Area

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the area view does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewAreaTag(Autodesk.Revit.DB.ViewPlan,Autodesk.Revit.DB.Area,Autodesk.Revit.DB.UV)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewAreaTag(Autodesk.Revit.DB.ViewPlan,Autodesk.Revit.DB.Area,Autodesk.Revit.DB.UV)`

#### Summary

Creates a new area tag.

#### Parameter `areaView`

The area view

#### Parameter `room`

The area to tag

#### Parameter `point`

The position of the area tag

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the area view does not exist in the given document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the area does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewAreaBoundaryLine(Autodesk.Revit.DB.SketchPlane,Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.ViewPlan)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewAreaBoundaryLine(Autodesk.Revit.DB.SketchPlane,Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.ViewPlan)`

#### Summary

Creates a new boundary line as an Area border.

#### Parameter `sketchPlane`

The sketch plane.

#### Parameter `geometryCurve`

The geometry curve on which the boundary line are

#### Parameter `areaView`

The View for the new Area

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the sketch plane does not exist in the given document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the area view does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewOpening(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.CurveArray,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewOpening(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.CurveArray,System.Boolean)`

#### Summary

Creates a new opening in a roof, floor and ceiling.

#### Parameter `hostElement`

Host element of the opening. Can be a roof, floor, or ceiling.

#### Parameter `profile`

Profile of the opening.

#### Parameter `bPerpendicularFace`

True if the profile is cut perpendicular to the intersecting face of the host. False if the profile is cut vertically.

#### Returns

If successful, an Opening object is returned.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the host element does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewOpening(Autodesk.Revit.DB.Wall,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewOpening(Autodesk.Revit.DB.Wall,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a rectangular opening on a wall.

#### Parameter `wall`

Host element of the opening.

#### Parameter `pntStart`

One corner of the rectangle.

#### Parameter `pntEnd`

The opposite corner of the rectangle.

#### Returns

If successful, an Opening object is returned.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the wall
does not exist in the given document, or if the wall doesn't support
rectangular openings.

#### Remarks

Slanted stacked walls do not support rectangular openings.

### `M:Autodesk.Revit.Creation.Document.NewOpening(Autodesk.Revit.DB.Level,Autodesk.Revit.DB.Level,Autodesk.Revit.DB.CurveArray)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewOpening(Autodesk.Revit.DB.Level,Autodesk.Revit.DB.Level,Autodesk.Revit.DB.CurveArray)`

#### Summary

Creates a new shaft opening between a set of levels.

#### Parameter `bottomLevel`

bottom level

#### Parameter `topLevel`

top level

#### Parameter `profile`

profile of the opening.

#### Returns

If successful, an Opening object is returned.

#### Remarks

This method forms an opening on floor, ceiling and roof. Make sure topLevel is higher than bottomLevel, otherwise an exception will be returned.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the bottom level does not exist in the given document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the top level does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewOpening(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.CurveArray,Autodesk.Revit.Creation.eRefFace)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewOpening(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.CurveArray,Autodesk.Revit.Creation.eRefFace)`

#### Overloads

Creates a new opening.

#### Summary

Creates a new opening in a beam, brace and column.

#### Parameter `famInstElement`

host element of the opening, can be a beam, brace and column.

#### Parameter `profile`

profile of the opening.

#### Parameter `iFace`

face on which opening is based on.

#### Returns

If successful, an Opening object is returned.

#### Remarks

This method forms opening on a beam, brace and column.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the family instance element does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewAreaBoundaryConditions(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewAreaBoundaryConditions(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double)`

#### Summary

Creates a new Area BoundaryConditions element on a host element.

#### Parameter `hostElement`

A Wall, Slab or Slab Foundation to host the boundary conditions.

#### Parameter `X_Translation`

A value indicating the X axis translation option.

#### Parameter `X_TranslationSpringModulus`

Translation Spring Modulus for X axis. Ignored if X_Translation is not "Spring".

#### Parameter `Y_Translation`

A value indicating the Y axis translation option.

#### Parameter `Y_TranslationSpringModulus`

Translation Spring Modulus for Y axis. Ignored if Y_Translation is not "Spring".

#### Parameter `Z_Translation`

A value indicating the Z axis translation option.

#### Parameter `Z_TranslationSpringModulus`

Translation Spring Modulus for Z axis. Ignored if Z_Translation is not "Spring".

#### Returns

If successful, NewAreaBoundaryConditions returns an object for the newly created BoundaryConditions
with the BoundaryType = 2 - "Area". `null` is returned if the operation fails.

#### Remarks

This method will only function with the Autodesk Revit Structure application.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the host element does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewLineBoundaryConditions(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewLineBoundaryConditions(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double)`

#### Summary

Creates a new Line BoundaryConditions element on a host element.

#### Parameter `hostElement`

A Beam.

#### Parameter `X_Translation`

A value indicating the X axis translation option.

#### Parameter `X_TranslationSpringModulus`

Translation Spring Modulus for X axis. Ignored if X_Translation is not "Spring".

#### Parameter `Y_Translation`

A value indicating the Y axis translation option.

#### Parameter `Y_TranslationSpringModulus`

Translation Spring Modulus for Y axis. Ignored if Y_Translation is not "Spring".

#### Parameter `Z_Translation`

A value indicating the Z axis translation option.

#### Parameter `Z_TranslationSpringModulus`

Translation Spring Modulus for Z axis. Ignored if Z_Translation is not "Spring".

#### Parameter `X_Rotation`

A value indicating the option for rotation about the X axis.

#### Parameter `X_RotationSpringModulus`

Rotation Spring Modulus for X axis. Ignored if X_Rotation is not "Spring"

#### Returns

If successful, NewLineBoundaryConditions returns an object for the newly created BoundaryConditions
with the BoundaryType = 1 - "Line". `null` is returned if the operation fails.

#### Remarks

This method will only function with the Autodesk Revit Structure application.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the host element does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewAreaBoundaryConditions(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewAreaBoundaryConditions(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double)`

#### Overloads

Creates a new Area BoundaryConditions element.

#### Summary

Creates a new Area BoundaryConditions element on a reference.

#### Parameter `reference`

The Geometry reference obtained from a Wall, Slab or
Slab Foundation.

#### Parameter `X_Translation`

A value indicating the X axis translation option.

#### Parameter `X_TranslationSpringModulus`

Translation Spring Modulus for X axis. Ignored if X_Translation is not "Spring".

#### Parameter `Y_Translation`

A value indicating the Y axis translation option.

#### Parameter `Y_TranslationSpringModulus`

Translation Spring Modulus for Y axis. Ignored if Y_Translation is not "Spring".

#### Parameter `Z_Translation`

A value indicating the Z axis translation option.

#### Parameter `Z_TranslationSpringModulus`

Translation Spring Modulus for Z axis. Ignored if Z_Translation is not "Spring".

#### Returns

If successful, NewAreaBoundaryConditions returns an object for the newly created BoundaryConditions
with the BoundaryType = 2 - "Area". `null` is returned if the operation fails.

#### Remarks

This method will only function with the Autodesk Revit Structure application.

### `M:Autodesk.Revit.Creation.Document.NewLineBoundaryConditions(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewLineBoundaryConditions(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double)`

#### Overloads

Creates a new Line BoundaryConditions element.

#### Summary

Creates a new Line BoundaryConditions element on a reference.

#### Parameter `reference`

The Geometry reference to a Beam's, Wall's, Wall Foundation's, Slab's or
Slab Foundation's analytical line.

#### Parameter `X_Translation`

A value indicating the X axis translation option.

#### Parameter `X_TranslationSpringModulus`

Translation Spring Modulus for X axis. Ignored if X_Translation is not "Spring".

#### Parameter `Y_Translation`

A value indicating the Y axis translation option.

#### Parameter `Y_TranslationSpringModulus`

Translation Spring Modulus for Y axis. Ignored if Y_Translation is not "Spring".

#### Parameter `Z_Translation`

A value indicating the Z axis translation option.

#### Parameter `Z_TranslationSpringModulus`

Translation Spring Modulus for Z axis. Ignored if Z_Translation is not "Spring".

#### Parameter `X_Rotation`

A value indicating the option for rotation about the X axis.

#### Parameter `X_RotationSpringModulus`

Rotation Spring Modulus for X axis. Ignored if X_Rotation is not "Spring"

#### Returns

If successful, NewLineBoundaryConditions returns an object for the newly created BoundaryConditions
with the BoundaryType = 1 - "Line". `null` is returned if the operation fails.

#### Remarks

This method will only function with the Autodesk Revit Structure application.

### `M:Autodesk.Revit.Creation.Document.NewPointBoundaryConditions(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewPointBoundaryConditions(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double,Autodesk.Revit.DB.Structure.TranslationRotationValue,System.Double)`

#### Summary

Creates a new Point BoundaryConditions Element.

#### Parameter `reference`

A Geometry reference to a Beam's, Brace's or Column's analytical line end.

#### Parameter `X_Translation`

A value indicating the X axis translation option.

#### Parameter `X_TranslationSpringModulus`

Translation Spring Modulus for X axis. Ignored if X_Translation is not "Spring".

#### Parameter `Y_Translation`

A value indicating the Y axis translation option.

#### Parameter `Y_TranslationSpringModulus`

Translation Spring Modulus for Y axis. Ignored if Y_Translation is not "Spring".

#### Parameter `Z_Translation`

A value indicating the Z axis translation option.

#### Parameter `Z_TranslationSpringModulus`

Translation Spring Modulus for Z axis. Ignored if Z_Translation is not "Spring".

#### Parameter `X_Rotation`

A value indicating the option for rotation about the X axis.

#### Parameter `X_RotationSpringModulus`

Rotation Spring Modulus for X axis. Ignored if X_Rotation is not "Spring".

#### Parameter `Y_Rotation`

A value indicating the option for rotation about the Y axis.

#### Parameter `Y_RotationSpringModulus`

Rotation Spring Modulus for Y axis. Ignored if Y_Rotation is not "Spring".

#### Parameter `Z_Rotation`

A value indicating the option for rotation about the Z axis.

#### Parameter `Z_RotationSpringModulus`

Rotation Spring Modulus for Z axis. Ignored if Y_Rotation is not "Spring".

#### Returns

If successful, NewPointBoundaryConditions returns an object for the newly created BoundaryConditions
with the BoundaryType = 0 - "Point". `null` is returned if the operation fails.

#### Remarks

This method will only function with the Autodesk Revit Structure application.

### `M:Autodesk.Revit.Creation.Document.NewRoomTag(Autodesk.Revit.DB.LinkElementId,Autodesk.Revit.DB.UV,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewRoomTag(Autodesk.Revit.DB.LinkElementId,Autodesk.Revit.DB.UV,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new RoomTag referencing a room in the host model or in a Revit link.

#### Parameter `roomId`

The HostOrLinkElementId of the Room.

#### Parameter `point`

A 2D point that defines the tag location on the level of the room.

#### Parameter `viewId`

The id of the view where the tag will be shown. If `null` and the room in not in a Revit link, the view of the room will be used.

#### Returns

If successful a RoomTag object will be returned, otherwise `null` .

#### Since

2014

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

viewId is not associated with a plan view or section view.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

viewId is null and the room is in a linked file.

### `M:Autodesk.Revit.Creation.Document.NewRooms2(Autodesk.Revit.DB.Phase,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewRooms2(Autodesk.Revit.DB.Phase,System.Int32)`

#### Summary

Creates new unplaced rooms in the given phase.

#### Parameter `phase`

The phase on which the rooms are to exist.

#### Parameter `count`

The number of the rooms to be created.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

If the room can not be created successfully or regeneration fails at the end of the creation.

#### Returns

If successful, a set of ElementIds which contains the rooms should be returned, otherwise the exception will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the phase does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewRooms2(Autodesk.Revit.DB.Level,Autodesk.Revit.DB.Phase)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewRooms2(Autodesk.Revit.DB.Level,Autodesk.Revit.DB.Phase)`

#### Summary

Creates new rooms in each plan circuit found in the given level in the given phase.

#### Parameter `level`

The level from which the circuits are found.

#### Parameter `phase`

The phase on which the room is to exist.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

If the view of the relevant level can not be retrieved.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

If the phase is invalid, or regeneration fails at the end of the creation.

#### Returns

If successful, a set of ElementIds which contains the rooms should be returned, otherwise the exception will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the level does not exist in the given document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the phase does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewRooms2(Autodesk.Revit.DB.Level)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewRooms2(Autodesk.Revit.DB.Level)`

#### Summary

Creates new rooms in each plan circuit found in the given level in the last phase.

#### Parameter `level`

The level from which the circuits are found.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

If the view of the relevant level can not be retrieved.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

If the phase is invalid, or regeneration fails at the end of the creation.

#### Returns

If successful, a set of ElementIds which contains the rooms created should be returned, otherwise `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the level does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewRoom(Autodesk.Revit.DB.Architecture.Room,Autodesk.Revit.DB.PlanCircuit)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewRoom(Autodesk.Revit.DB.Architecture.Room,Autodesk.Revit.DB.PlanCircuit)`

#### Summary

Creates a new room within the confines of a plan circuit, or places an unplaced room within the confines of the plan circuit.

#### Parameter `room`

The room which you want to locate in the circuit. Pass `null` to create a new room.

#### Parameter `circuit`

The circuit in which you want to locate a room.

#### Returns

If successful the room is returned, otherwise `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

If the existing room is already placed.

#### Remarks

This method will regenerate the document even in manual regeneration mode.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the room does not exist in the given document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the circuit does not exist in the given document.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if the level obtained from the circuit has no associated view .

### `M:Autodesk.Revit.Creation.Document.NewRoom(Autodesk.Revit.DB.Phase)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewRoom(Autodesk.Revit.DB.Phase)`

#### Summary

Creates a new unplaced room and with an assigned phase.

#### Parameter `phase`

The phase in which the room is to exist.

#### Returns

If successful the new room , otherwise `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the phase does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewRoom(Autodesk.Revit.DB.Level,Autodesk.Revit.DB.UV)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewRoom(Autodesk.Revit.DB.Level,Autodesk.Revit.DB.UV)`

#### Overloads

Creates a new room.

#### Summary

Creates a new room on a level at a specified point.

#### Parameter `level`

The level on which the room is to exist.

#### Parameter `point`

A 2D point that dictates the location of the room on that specified level.

#### Returns

If successful the new room will be returned, otherwise `null` .

#### Remarks

This method will regenerate the document even in manual regeneration mode.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the level does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewSpotElevation(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewSpotElevation(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,System.Boolean)`

#### Summary

Generate a new spot elevation object within the project.

#### Parameter `view`

The view in which the spot elevation is to be visible.

#### Parameter `reference`

The reference to which the spot elevation is to be bound.

#### Parameter `origin`

The point which the spot elevation evaluate.

#### Parameter `bend`

The bend point for the spot elevation.

#### Parameter `end`

The end point for the spot elevation.

#### Parameter `refPt`

The actual point on the reference which the spot elevation evaluate.

#### Parameter `hasLeader`

Indicate if it has leader or not.

#### Returns

If successful a new spot dimension object, otherwise `null` .

#### Remarks

If the origin point is not on the reference, it'll be projected to the reference automatically. And the refPt
is the projected point. If the reference is not valid or the point cannot be projected to
reference correctly, an exception will be thrown

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the view does not exist in the given document.

### `M:Autodesk.Revit.Creation.Document.NewSpotCoordinate(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Document.NewSpotCoordinate(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,System.Boolean)`

#### Summary

Generate a new spot coordinate object within the project.

#### Parameter `view`

The view in which the spot coordinate is to be visible.

#### Parameter `reference`

The reference to which the spot coordinate is to be bound.

#### Parameter `origin`

The point which the spot coordinate evaluate.

#### Parameter `bend`

The bend point for the spot coordinate.

#### Parameter `end`

The end point for the spot coordinate.

#### Parameter `refPt`

The actual point on the reference which the spot coordinate evaluate.

#### Parameter `hasLeader`

Indicate if it has leader or not.

#### Returns

If successful a new spot dimension object, otherwise `null` .

#### Remarks

If the origin point is not on the reference, it'll be projected to the reference automatically. And the refPt
is projected point. If the reference is not valid or the point cannot be projected to
reference correctly, an exception will be thrown

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the view does not exist in the given document.

### `T:Autodesk.Revit.Creation.Document`

Member kind: type
Symbol: `Autodesk.Revit.Creation.Document`

#### Summary

The Document Creation object is used to create new instances of elements within the
Autodesk Revit project.

#### Remarks

The Document Creation object is a utility object that is used to create new
instances of elements within the Autodesk Revit project. This object, available from the
Document.Create property should be used to create elements instead of using New. This
object ensures that the elements created are added to the document correctly.

### `T:Autodesk.Revit.Creation.eRefFace`

Member kind: type
Symbol: `Autodesk.Revit.Creation.eRefFace`

#### Summary

Indicates the reference face. The Opening will be created at the direction perpendicular to
the reference face.

#### Remarks

Direction of the opening.

### `F:Autodesk.Revit.Creation.eRefFace.CenterZ`

Member kind: field
Symbol: `Autodesk.Revit.Creation.eRefFace.CenterZ`

#### Summary

The reference face is at the middle of the element in the direction
of z-axis and its normal is parallel to z-axis.

### `F:Autodesk.Revit.Creation.eRefFace.CenterY`

Member kind: field
Symbol: `Autodesk.Revit.Creation.eRefFace.CenterY`

#### Summary

The reference face is at the middle of the element in the direction
of y-axis and its normal is parallel to y-axis.

### `F:Autodesk.Revit.Creation.eRefFace.CenterX`

Member kind: field
Symbol: `Autodesk.Revit.Creation.eRefFace.CenterX`

#### Summary

The reference face is at the middle of the element in the direction
of x-axis and its normal is parallel to x-axis.

### `M:Autodesk.Revit.DB.PlanTopology.GetRoomIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.PlanTopology.GetRoomIds`

#### Summary

Retrieves room ElementIds of the PlanTopology in the last phase.

#### Remarks

The Rooms Ids returned are in the phase of PlanTopology and the current design option.

#### Returns

The PlanTopology Room ElementIds of the last phase.

#### Since

2013

### `P:Autodesk.Revit.DB.PlanTopology.Phase`

Member kind: property
Symbol: `Autodesk.Revit.DB.PlanTopology.Phase`

#### Summary

The phase of the PlanTopology.

### `P:Autodesk.Revit.DB.PlanTopology.Circuits`

Member kind: property
Symbol: `Autodesk.Revit.DB.PlanTopology.Circuits`

#### Summary

The Circuits of the PlanTopology.

### `P:Autodesk.Revit.DB.PlanTopology.Level`

Member kind: property
Symbol: `Autodesk.Revit.DB.PlanTopology.Level`

#### Summary

The Level of the PlanTopology.

### `T:Autodesk.Revit.DB.PlanTopology`

Member kind: type
Symbol: `Autodesk.Revit.DB.PlanTopology`

#### Summary

An object that represents a Plan Topology within the Autodesk Revit project.

#### Remarks

This object derived from the APIObject base object. It can be used access the properties
of a Plan Topology.

### `M:Autodesk.Revit.DB.FamilyManager.validateFamilySupportParamsOrder(FamilyBase!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.validateFamilySupportParamsOrder(FamilyBase!System.Runtime.CompilerServices.IsConst*)`

### `M:Autodesk.Revit.DB.FamilyManager.SortParameters(Autodesk.Revit.DB.ParametersOrder)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.SortParameters(Autodesk.Revit.DB.ParametersOrder)`

#### Summary

Sorts the family parameters according to the desired sort order.

#### Parameter `order`

The desired sort order.

#### Remarks

The sort only affects visible parameters within the same parameter group.

Parameters that belong to different groups will remain separated, and the groups' order will not be affected.

The sort is a one-time operation and when new parameters are added they will not be automatically sorted.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when this family is a Rebar Shape family which doesn't support parameters reorder.

#### Since

2015

### `M:Autodesk.Revit.DB.FamilyManager.IsUserAssignableParameterGroup(Autodesk.Revit.DB.BuiltInParameterGroup)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.IsUserAssignableParameterGroup(Autodesk.Revit.DB.BuiltInParameterGroup)`

#### Summary

Checks if the given parameter group can be assigned to new parameters.

#### Returns

True if the parameter group can be assigned to new parameters, false otherwise.

#### Since

2015

### `M:Autodesk.Revit.DB.FamilyManager.IsUserAssignableParameterGroup(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.IsUserAssignableParameterGroup(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Checks if the given parameter group can be assigned to new parameters.

#### Returns

True if the parameter group can be assigned to new parameters, false otherwise.

#### Since

2015

### `M:Autodesk.Revit.DB.FamilyManager.ReorderParameters(System.Collections.Generic.IList{Autodesk.Revit.DB.FamilyParameter})`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.ReorderParameters(System.Collections.Generic.IList{Autodesk.Revit.DB.FamilyParameter})`

#### Summary

Reorders the family parameters by the specified parameters order.

#### Parameter `parameters`

The new parameters order for the family.
The contents of this collection should consist of exactly the same parameters returned by the GetParameters() method.
This will include invisible parameters; they can be reordered but this will have no effect when viewing the parameters in the Revit UI.

#### Remarks

Reordering the parameters only affects visible parameters within the same parameter group.

Parameters that belong to different groups will remain separated, and the groups' order will not be affected.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when argument is `null` or empty.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input parameters collection does not contain the same parameters as those returned by GetParameters().

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when this family is a Rebar Shape family which doesn't support parameters reorder.

#### Since

2015

### `M:Autodesk.Revit.DB.FamilyManager.GetParameters`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.GetParameters`

#### Summary

Gets the parameters associated to family types in order.

#### Returns

A collection containing all family parameters.

#### Remarks

The parameters are family built-in parameters, category built-in parameters
and shared parameters associated to the family types.

The collection consists of both visible and invisible parameters associated to the family types.

The parameters are returned in the order in which they appear in the Revit UI within a given group;
however, parameters of different groups may be mixed within this output.

Currently the Revit UI order is determined first by group and next by the order of the individual parameters.

#### Since

2015

### `M:Autodesk.Revit.DB.FamilyManager.SetParameterLocked(Autodesk.Revit.DB.FamilyParameter,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.SetParameterLocked(Autodesk.Revit.DB.FamilyParameter,System.Boolean)`

#### Summary

For Conceptual Mass and Curtain Panel families,
lock or unlock a dimension-driving
parameter.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if this family is not a Conceptual Mass or
Curtain Panel family.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the parameter is not lockable.

### `M:Autodesk.Revit.DB.FamilyManager.IsParameterLocked(Autodesk.Revit.DB.FamilyParameter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.IsParameterLocked(Autodesk.Revit.DB.FamilyParameter)`

#### Summary

For Conceptual Mass and Curtain Panel families,
indicate whether the specified dimension-driving
parameter is locked.

#### Returns

True if the parameter is lockable
and is locked; false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if this family is not a Conceptual Mass or Curtain Panel family.

### `M:Autodesk.Revit.DB.FamilyManager.IsParameterLockable(Autodesk.Revit.DB.FamilyParameter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.IsParameterLockable(Autodesk.Revit.DB.FamilyParameter)`

#### Summary

For Conceptual Mass and Curtain Panel families,
indicate whether the specified parameter can be locked.

#### Returns

True if the family is a Conceptual Mass or Curtain
Panel Family and the parameter drives one or more
dimensions; false otherwise.

### `M:Autodesk.Revit.DB.FamilyManager.GetAssociatedFamilyParameter(Autodesk.Revit.DB.Parameter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.GetAssociatedFamilyParameter(Autodesk.Revit.DB.Parameter)`

#### Summary

Gets the associated family parameter of an element parameter.

#### Parameter `elementParameter`

The parameter of an element in family.

#### Returns

The associated family parameter if there is an association between them, returns `null` if not.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"elementParameter"-is `null` .

### `M:Autodesk.Revit.DB.FamilyManager.CanElementParameterBeAssociated(Autodesk.Revit.DB.Parameter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.CanElementParameterBeAssociated(Autodesk.Revit.DB.Parameter)`

#### Summary

Indicates if this element parameter can be associated with a family parameter.

### `M:Autodesk.Revit.DB.FamilyManager.ReplaceParameter(Autodesk.Revit.DB.FamilyParameter,System.String,Autodesk.Revit.DB.BuiltInParameterGroup,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.ReplaceParameter(Autodesk.Revit.DB.FamilyParameter,System.String,Autodesk.Revit.DB.BuiltInParameterGroup,System.Boolean)`

#### Summary

Replace a shared family parameter with a new non-shared family parameter.

#### Parameter `currentParameter`

The current family parameter.

#### Parameter `parameterName`

The name of the new family parameter.

#### Parameter `parameterGroup`

The group to which the new family parameter belongs.

#### Parameter `isInstance`

Indicates if the new parameter is instance or type.

#### Returns

If replacement was successful the new family parameter is returned,
otherwise an exception with failure information will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"currentParameter" or "parameterName"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-"currentParameter"-is invalid,
or the input parameter group cannot be assigned to the new parameter,
or the input name string contains illegal characters, or duplicated with existing parameter name.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when trying to replace a built-in parameter or family parameter.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when replacement failed, because the replacement would cause a formula error.
Or trying to replace with an instance parameter of image type.

### `M:Autodesk.Revit.DB.FamilyManager.ReplaceParameter(Autodesk.Revit.DB.FamilyParameter,System.String,Autodesk.Revit.DB.ForgeTypeId,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.ReplaceParameter(Autodesk.Revit.DB.FamilyParameter,System.String,Autodesk.Revit.DB.ForgeTypeId,System.Boolean)`

#### Summary

Replace a shared family parameter with a new non-shared family parameter.

#### Parameter `currentParameter`

The current family parameter.

#### Parameter `parameterName`

The name of the new family parameter.

#### Parameter `groupTypeId`

The identifier of the group to which the new family parameter belongs.

#### Parameter `isInstance`

Indicates if the new parameter is instance or type.

#### Returns

If replacement was successful the new family parameter is returned,
otherwise an exception with failure information will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"currentParameter" or "parameterName"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-"currentParameter"-is invalid,
or the input parameter group cannot be assigned to the new parameter,
or the input name string contains illegal characters, or duplicated with existing parameter name.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when trying to replace a built-in parameter or family parameter.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when replacement failed, because the replacement would cause a formula error.
Or trying to replace with an instance parameter of image type.

### `M:Autodesk.Revit.DB.FamilyManager.ReplaceParameter(Autodesk.Revit.DB.FamilyParameter,Autodesk.Revit.DB.ExternalDefinition,Autodesk.Revit.DB.BuiltInParameterGroup,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.ReplaceParameter(Autodesk.Revit.DB.FamilyParameter,Autodesk.Revit.DB.ExternalDefinition,Autodesk.Revit.DB.BuiltInParameterGroup,System.Boolean)`

#### Summary

Replace a family parameter with a shared parameter.

#### Parameter `currentParameter`

The current family parameter.

#### Parameter `familyDefinition`

The definition of the loaded shared parameter.

#### Parameter `parameterGroup`

The group to which the new shared parameter belongs.

#### Parameter `isInstance`

Indicates if the new parameter is instance or type.

#### Returns

If replacement was successful the new shared parameter is returned,
otherwise an exception with failure information will be thrown.

#### Remarks

This operation is invalid for Built-in Parameters.
The formulas and labels which in reference to this parameter will be updated to the new parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"familyParameter" or "name"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-"familyParameter"-is invalid,
or the input parameter group cannot be assigned to the new parameter,
or the input name string contains illegal characters, or duplicated with existing parameter name.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when trying to replace a built-in parameter.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when replacement failed, because the replacement would cause a formula error.
Or trying to replace with an instance parameter of image type.

### `M:Autodesk.Revit.DB.FamilyManager.ReplaceParameter(Autodesk.Revit.DB.FamilyParameter,Autodesk.Revit.DB.ExternalDefinition,Autodesk.Revit.DB.ForgeTypeId,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.ReplaceParameter(Autodesk.Revit.DB.FamilyParameter,Autodesk.Revit.DB.ExternalDefinition,Autodesk.Revit.DB.ForgeTypeId,System.Boolean)`

#### Summary

Replace a family parameter with a shared parameter.

#### Parameter `currentParameter`

The current family parameter.

#### Parameter `familyDefinition`

The definition of the loaded shared parameter.

#### Parameter `groupTypeId`

The identifier of the group to which the new shared parameter belongs.

#### Parameter `isInstance`

Indicates if the new parameter is instance or type.

#### Returns

If replacement was successful the new shared parameter is returned,
otherwise an exception with failure information will be thrown.

#### Remarks

This operation is invalid for Built-in Parameters.
The formulas and labels which in reference to this parameter will be updated to the new parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"familyParameter" or "name"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-"familyParameter"-is invalid,
or the input parameter group cannot be assigned to the new parameter,
or the input name string contains illegal characters, or duplicated with existing parameter name.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when trying to replace a built-in parameter.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when replacement failed, because the replacement would cause a formula error.
Or trying to replace with an instance parameter of image type.

### `M:Autodesk.Revit.DB.FamilyManager.AssociateElementParameterToFamilyParameter(Autodesk.Revit.DB.Parameter,Autodesk.Revit.DB.FamilyParameter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.AssociateElementParameterToFamilyParameter(Autodesk.Revit.DB.Parameter,Autodesk.Revit.DB.FamilyParameter)`

#### Summary

Associates or disassociates the element parameter to an existing family parameter.

#### Parameter `elementParameter`

The parameter of an element in family.

#### Parameter `familyParameter`

The existing family parameter. If the input to this argument is `null` ,
it will disassociate the element parameter from any family parameters.

#### Remarks

The parameter types of these two input parameter should be same, if not an
exception with failure information will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"elementParameter"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-"elementParameter" or "familyParameter"-is an invalid parameter,
or the input argument-"elementParameter"-cannot be associated.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the family parameter binding failed.

### `M:Autodesk.Revit.DB.FamilyManager.RenameParameter(Autodesk.Revit.DB.FamilyParameter,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.RenameParameter(Autodesk.Revit.DB.FamilyParameter,System.String)`

#### Summary

Rename a family parameter.

#### Parameter `familyParameter`

The family parameter.

#### Parameter `name`

The new name.

#### Remarks

This operation is valid only for Family Parameters, and is invalid for Shared Parameters and Built-in Parameters.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"familyParameter" or "name"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-"familyParameter"-is invalid,
or the input name string contains illegal characters, or duplicated with existing parameter name.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when trying to rename a built-in parameter or shared parameter.

### `M:Autodesk.Revit.DB.FamilyManager.SetFormula(Autodesk.Revit.DB.FamilyParameter,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.SetFormula(Autodesk.Revit.DB.FamilyParameter,System.String)`

#### Summary

Set the formula of a family parameter.

#### Parameter `familyParameter`

The family parameter.

#### Parameter `formula`

The formula string, input `null` to clean the formula of the parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"familyParameter"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when there is no valid family type,
or the parameter cannot be assigned a formula,
or the operation make a circular chain of references among the formulas.

### `M:Autodesk.Revit.DB.FamilyManager.MakeNonReporting(Autodesk.Revit.DB.FamilyParameter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.MakeNonReporting(Autodesk.Revit.DB.FamilyParameter)`

#### Summary

Set the reporting family parameter as a regular/driving parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"familyParameter"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when attempting to make a parameter which is labeled to an arc length dimension non-reporting.

#### Since

2011

### `M:Autodesk.Revit.DB.FamilyManager.MakeReporting(Autodesk.Revit.DB.FamilyParameter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.MakeReporting(Autodesk.Revit.DB.FamilyParameter)`

#### Summary

Set the family parameter as a reporting parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"familyParameter"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the parameter can not be changed to a reporting parameter.

#### Since

2011

### `M:Autodesk.Revit.DB.FamilyManager.MakeType(Autodesk.Revit.DB.FamilyParameter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.MakeType(Autodesk.Revit.DB.FamilyParameter)`

#### Summary

Set the family parameter as a type parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"familyParameter"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-"familyParameter"-is an invalid parameter or a builtIn parameter.

### `M:Autodesk.Revit.DB.FamilyManager.MakeInstance(Autodesk.Revit.DB.FamilyParameter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.MakeInstance(Autodesk.Revit.DB.FamilyParameter)`

#### Summary

Set the family parameter as an instance parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"familyParameter"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-"familyParameter"-is an invalid parameter or a builtIn parameter.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when there is Type family parameter driven by this parameter.
Or trying to make a parameter of image type to instance.

### `M:Autodesk.Revit.DB.FamilyManager.RemoveParameter(Autodesk.Revit.DB.FamilyParameter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.RemoveParameter(Autodesk.Revit.DB.FamilyParameter)`

#### Summary

Remove an existing family parameter from the family.

#### Parameter `familyParameter`

The family parameter.

#### Remarks

Only family and shared parameters may be removed, built-in
parameters may not be removed.
If the parameter is used in any formulas, those formulas will be
automatically removed along with the parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"familyParameter"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-"familyParameter"-is an invalid parameter or a builtIn parameter.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the family parameter deletion failed.

### `M:Autodesk.Revit.DB.FamilyManager.SetDescription(Autodesk.Revit.DB.FamilyParameter,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.SetDescription(Autodesk.Revit.DB.FamilyParameter,System.String)`

#### Summary

Set the description for an existing family parameter.
The description will be used as tooltip in the Revit UI including in the properties palette.

#### Parameter `familyParameter`

The family parameter.

#### Parameter `description`

The description of the family parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"familyParameter"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-"familyParameter"-is an invalid parameter or a builtIn parameter.

#### Since

2015

### `M:Autodesk.Revit.DB.FamilyManager.AddParameter(System.String,Autodesk.Revit.DB.BuiltInParameterGroup,Autodesk.Revit.DB.Category,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.AddParameter(System.String,Autodesk.Revit.DB.BuiltInParameterGroup,Autodesk.Revit.DB.Category,System.Boolean)`

#### Summary

Add a new family type parameter to control the type of a nested family within another family.

#### Parameter `parameterName`

The name of the new family parameter.

#### Parameter `parameterGroup`

The group to which the family parameter belongs.

#### Parameter `familyCategory`

The category to which the new family parameter binds.

#### Parameter `isInstance`

Indicates if the new family parameter is instance or type.

#### Returns

If creation was successful the new parameter is returned,
otherwise an exception with failure information will be thrown.

#### Remarks

This method can work even without any family type, but it cannot be assigned the value via
FamilyManager.Set methods when there is no current type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"parameterName"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-"parameterName"-is already in use,
or the input parameter group cannot be assigned to the new parameter,
or the input argument-"familyCategory"-is illegal to bind with parameter.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the required family of familyCategory is not existing in current document,
, or when the creation failed.
Or trying to add an instance parameter of image type.

### `M:Autodesk.Revit.DB.FamilyManager.AddParameter(System.String,Autodesk.Revit.DB.ForgeTypeId,Autodesk.Revit.DB.Category,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.AddParameter(System.String,Autodesk.Revit.DB.ForgeTypeId,Autodesk.Revit.DB.Category,System.Boolean)`

#### Summary

Add a new family type parameter to control the type of a nested family within another family.

#### Parameter `parameterName`

The name of the new family parameter.

#### Parameter `groupTypeId`

The identifier of the group to which the family parameter belongs.

#### Parameter `familyCategory`

The category to which the new family parameter binds.

#### Parameter `isInstance`

Indicates if the new family parameter is instance or type.

#### Returns

If creation was successful the new parameter is returned,
otherwise an exception with failure information will be thrown.

#### Remarks

This method can work even without any family type, but it cannot be assigned the value via
FamilyManager.Set methods when there is no current type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"parameterName"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-"parameterName"-is already in use,
or the input parameter group cannot be assigned to the new parameter,
or the input argument-"familyCategory"-is illegal to bind with parameter.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the required family of familyCategory is not existing in current document,
, or when the creation failed.
Or trying to add an instance parameter of image type.

### `M:Autodesk.Revit.DB.FamilyManager.AddParameter(System.String,Autodesk.Revit.DB.ForgeTypeId,Autodesk.Revit.DB.ForgeTypeId,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.AddParameter(System.String,Autodesk.Revit.DB.ForgeTypeId,Autodesk.Revit.DB.ForgeTypeId,System.Boolean)`

#### Summary

Add a new family parameter with a given name.

#### Parameter `parameterName`

The name of the new family parameter.

#### Parameter `groupTypeId`

The identifier of the new family parameter's parameter group.

#### Parameter `specTypeId`

The type of new family parameter.

#### Parameter `isInstance`

Indicates if the new family parameter is instance or type.

#### Returns

If creation was successful the new parameter is returned,
otherwise an exception with failure information will be thrown.

#### Remarks

This method can work even without any family type, but it cannot be assigned the value via
FamilyManager.Set methods when there is no current type.
To add a parameter of family type use the AddParameter overload that accepts a category instead.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"parameterName"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-"parameterName"-is already in use,
or when the input argument -"specTypeId" is an invalid type,
or the input parameter group cannot be assigned to the new parameter.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the family parameter creation failed.
Or trying to add an instance parameter of image type.

### `M:Autodesk.Revit.DB.FamilyManager.AddParameter(Autodesk.Revit.DB.ExternalDefinition,Autodesk.Revit.DB.BuiltInParameterGroup,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.AddParameter(Autodesk.Revit.DB.ExternalDefinition,Autodesk.Revit.DB.BuiltInParameterGroup,System.Boolean)`

#### Overloads

Add a new parameter to the family.

#### Summary

Add a new shared parameter to the family.

#### Parameter `familyDefinition`

The definition of the loaded shared parameter.

#### Parameter `isInstance`

Indicates if the new parameter is instance or type.

#### Parameter `parameterGroup`

The group to which the family parameter belongs.

#### Returns

If creation was successful the new shared parameter is returned,
otherwise an exception with failure information will be thrown.

#### Remarks

This method can work even without any family type, but it cannot be assigned the value via
FamilyManager.Set methods when there is no current type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input parameter group cannot be assigned to the new parameter.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the shared family parameter creation is not supported.
Or trying to add an instance parameter of image type.

### `M:Autodesk.Revit.DB.FamilyManager.AddParameter(Autodesk.Revit.DB.ExternalDefinition,Autodesk.Revit.DB.ForgeTypeId,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.AddParameter(Autodesk.Revit.DB.ExternalDefinition,Autodesk.Revit.DB.ForgeTypeId,System.Boolean)`

#### Overloads

Add a new parameter to the family.

#### Summary

Add a new shared parameter to the family.

#### Parameter `familyDefinition`

The definition of the loaded shared parameter.

#### Parameter `isInstance`

Indicates if the new parameter is instance or type.

#### Parameter `groupTypeId`

The identifier of the parameter group to which the family parameter belongs.

#### Returns

If creation was successful the new shared parameter is returned,
otherwise an exception with failure information will be thrown.

#### Remarks

This method can work even without any family type, but it cannot be assigned the value via
FamilyManager.Set methods when there is no current type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input parameter group cannot be assigned to the new parameter.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the shared family parameter creation is not supported.
Or trying to add an instance parameter of image type.

### `M:Autodesk.Revit.DB.FamilyManager.SetValueString(Autodesk.Revit.DB.FamilyParameter,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.SetValueString(Autodesk.Revit.DB.FamilyParameter,System.String)`

#### Summary

Set the string value of a family parameter of the current family type.

#### Parameter `familyParameter`

The family parameter of current type.

#### Parameter `value`

The new value string for family parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-"familyParameter" or "value"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-"familyParameter"-is an invalid family parameter.
or the input argument-"value"-is an illegal string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the input argument-"familyParameter"-is out of range.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the family parameter is determined by formula, or it is not a value type,
or the current family type is invalid.

### `M:Autodesk.Revit.DB.FamilyManager.Set(Autodesk.Revit.DB.FamilyParameter,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.Set(Autodesk.Revit.DB.FamilyParameter,Autodesk.Revit.DB.ElementId)`

#### Summary

Set the ElementId value of a family parameter of the current family type.

#### Parameter `familyParameter`

A family parameter of the current type.

#### Parameter `value`

The new value for family parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the storage type of family parameter is not ElementId --or-- The input ElementId does not represent either a valid element in the document or InvalidElementId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the input ElementId is not valid as a value for this FamilyParameter.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the family parameter is determined by formula,
or the current family type is invalid.

### `M:Autodesk.Revit.DB.FamilyManager.Set(Autodesk.Revit.DB.FamilyParameter,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.Set(Autodesk.Revit.DB.FamilyParameter,System.Double)`

#### Summary

Set the double value of a family parameter of the current family type.

#### Parameter `familyParameter`

A family parameter of the current type.

#### Parameter `value`

The new value for family parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-"familyParameter"-is an invalid family parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the input argument-"familyParameter"-is out of range.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the family parameter is determined by formula,
or the current family type is invalid.

### `M:Autodesk.Revit.DB.FamilyManager.Set(Autodesk.Revit.DB.FamilyParameter,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.Set(Autodesk.Revit.DB.FamilyParameter,System.String)`

#### Summary

Set the string value of a family parameter of the current family type.

#### Parameter `familyParameter`

A family parameter of the current type.

#### Parameter `value`

The new value for family parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"familyParameter"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-"familyParameter"-is an invalid family parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the input argument-"familyParameter"-is out of range.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the family parameter is determined by formula,
or the current family type is invalid.

### `M:Autodesk.Revit.DB.FamilyManager.Set(Autodesk.Revit.DB.FamilyParameter,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.Set(Autodesk.Revit.DB.FamilyParameter,System.Int32)`

#### Overloads

Set the value of a family parameter of the current family type.

#### Summary

Set the integer value of a family parameter of the current family type.

#### Parameter `familyParameter`

A family parameter of the current type.

#### Parameter `value`

The new value for family parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-"familyParameter"-is an invalid family parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the input argument-"familyParameter"-is out of range.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the family parameter is determined by formula,
or the current family type is invalid.

### `P:Autodesk.Revit.DB.FamilyManager.Parameter(System.Guid)`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyManager.Parameter(System.Guid)`

#### Summary

Obtains the parameter of this type with a given GUID for a shared parameter.

#### Remarks

Returns `null` if the parameter is not found. This method is used to retrieve a family parameter
for a known shared parameter. When a shared parameter is created it is assigned a Guid
which will not change. This guid can be used to retrieve the piece of data from the
element at a later time.

### `P:Autodesk.Revit.DB.FamilyManager.Parameter(Autodesk.Revit.DB.Definition)`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyManager.Parameter(Autodesk.Revit.DB.Definition)`

#### Summary

Obtains the parameter of this type with a given definition.

#### Remarks

Returns `null` if the parameter is not found.

### `P:Autodesk.Revit.DB.FamilyManager.Parameter(Autodesk.Revit.DB.BuiltInParameter)`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyManager.Parameter(Autodesk.Revit.DB.BuiltInParameter)`

#### Summary

Obtains the parameter of this type with a given parameter id.

#### Remarks

Returns `null` if the parameter is not found.

### `M:Autodesk.Revit.DB.FamilyManager.GetParameter(Autodesk.Revit.DB.ForgeTypeId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.GetParameter(Autodesk.Revit.DB.ForgeTypeId)`

#### Summary

Obtains the family parameter with the given built-in parameter identifier.

#### Remarks

Returns `null` if the parameter is not found.

#### Parameter `parameterTypeId`

Identifier of the built-in parameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

parameterTypeId does not identify a built-in parameter. See Parameter.IsBuiltInParameter(ForgeTypeId) and Parameter.GetParameterTypeId(BuiltInParameter).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Since

2022

### `P:Autodesk.Revit.DB.FamilyManager.Parameter(System.String)`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyManager.Parameter(System.String)`

#### Overloads

Obtains a parameter based on an identifier.

#### Summary

Obtains the parameter of this type with a given name.

#### Remarks

Returns `null` if the parameter is not found.

### `P:Autodesk.Revit.DB.FamilyManager.Parameters`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyManager.Parameters`

#### Summary

All family parameters in this family.

#### Remarks

These parameters will include the 'family parameter', 'shared parameter' and
'builtIn parameter' binding to the family types.
Some parameters might be created as placeholders without a currently assigned value.

### `M:Autodesk.Revit.DB.FamilyManager.RenameCurrentType(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.RenameCurrentType(System.String)`

#### Summary

Rename the current family type.

#### Parameter `typeName`

The new name of the current family type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"typeName"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-"typeName"-is already in use.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the family type rename failed.

### `M:Autodesk.Revit.DB.FamilyManager.DeleteCurrentType`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.DeleteCurrentType`

#### Summary

Remove the current family type.

#### Remarks

If successfully removed, the first available type will become the current type,
otherwise an exception with failure information will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when there is only one family type in current document.

### `M:Autodesk.Revit.DB.FamilyManager.NewType(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyManager.NewType(System.String)`

#### Summary

Add a new family type with a given name and makes it be the current type.

#### Parameter `typeName`

The name of new family type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument-"typeName"-is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the input argument-"typeName"-is already in use.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the family type creation failed.

### `P:Autodesk.Revit.DB.FamilyManager.Types`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyManager.Types`

#### Summary

All family types in the family.

### `P:Autodesk.Revit.DB.FamilyManager.CurrentType`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyManager.CurrentType`

#### Summary

The current family type.

#### Remarks

Only the current family type is editable using the methods
in `T:Autodesk.Revit.DB.FamilyManager` . If you want to modify the properties of
any family type, it must be set to be the current type first.
This value will be `null` if there is no type in the family. In order
to modify parameter values, you will need to create one using
`M:Autodesk.Revit.DB.FamilyManager.NewType(System.String)` .

### `T:Autodesk.Revit.DB.FamilyManager`

Member kind: type
Symbol: `Autodesk.Revit.DB.FamilyManager`

#### Summary

The family manager object to manage the family types and parameters in family document.

### `T:DataStorageServerManager`

Member kind: type
Symbol: `DataStorageServerManager`

#### Summary

Class to manage server available for collaboration (work sharing).

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.SubVersionNumber`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.SubVersionNumber`

#### Summary

The minor version number of Revit.

#### Remarks

SubVersionNumber of Revit may have additional APIs and functionality not available in the standard customer releases.
Add-ins written to support standard Revit releases should be compatible with SubVersionNumber releases,
but add-ins written specifically targeting new features in SubVersionNumber releases would not be compatible with the standard releases.

#### Since

2018.1

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.CurrentUsersAddinsDataFolderPath`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.CurrentUsersAddinsDataFolderPath`

#### Summary

Path to AddinsData folder for the current user.

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.CurrentUsersDataFolderPath`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.CurrentUsersDataFolderPath`

#### Summary

Path to data folder for the current user.

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.AllUsersAddinsLocation`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.AllUsersAddinsLocation`

#### Summary

Add-ins location for all users.

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.CurrentUserAddinsLocation`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.CurrentUserAddinsLocation`

#### Summary

Add-ins location for current user.

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.ProjectBrowserDataChanged`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ProjectBrowserDataChanged`

#### Summary

# Subscribe to the ProjectBrowserDataChanged event to be notified when the ProjectBrowser data is changed.

#### Since

2024

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.ExternalDataTypeServerFailureResolutionExecuting`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ExternalDataTypeServerFailureResolutionExecuting`

#### Summary

# Subscribe to the ExternalDataTypeServerFailureResolutionExecuting event to be notified when the ExternalDataTypeServerFailureResolution is executing in Revit Document.

#### Since

2023

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.ExternalDataInstanceRemovedFromDocument`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ExternalDataInstanceRemovedFromDocument`

#### Summary

# Subscribe to the ExternalDataInstanceRemovedFromDocument event to be notified when an ExternalDataInstance has been removed from Revit Document.

#### Since

2023

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.ExternalDataInstanceRemovingFromDocument`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ExternalDataInstanceRemovingFromDocument`

#### Summary

# Subscribe to the ExternalDataInstanceRemovingFromDocument event to be notified when an ExternalDataInstance is being removed from Revit Document.

#### Since

2023

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.ExternalDataInstanceAddedIntoDocument`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ExternalDataInstanceAddedIntoDocument`

#### Summary

# Subscribe to the ExternalDataInstanceAddedIntoDocument event to be notified when a new ExternalDataInstance has been added to Revit Document.

#### Since

2023

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.ExternalDataInstanceAddingIntoDocument`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ExternalDataInstanceAddingIntoDocument`

#### Summary

# Subscribe to the ExternalDataInstanceAddingIntoDocument event to be notified when a new ExternalDataInstance is being added to Revit Document.

#### Since

2023

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentReloadedLatest`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentReloadedLatest`

#### Summary

Subscribe to the DocumentReloadedLatestEventArgs event to be notified immediately after Revit has finished reloading a document with central model.

#### Remarks

This event is raised immediately after Revit has finished reloading latest changes from a central model.
It is raised even when document reloading latest changes from a central model failed or was cancelled(during DocumentReloadingLatest event)

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Check the 'Status' field in the event's argument to see whether the action itself was successful or not.

This event is not cancellable, for the process of synchronizing a document with central model has already been finished.

If the action was not successful, the document may not be modified and new transactions may not be started.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2021

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentReloadingLatest`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentReloadingLatest`

#### Summary

Subscribe to the DocumentReloadingLatestEventArgs event to be notified when Revit is just about to reload latest changes from a central model.

#### Remarks

This event is raised when Revit is just about to reload latest changes from a central model.

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read - only mode.

Event is cancellable. To cancel it, call the 'Cancel()' method in event's argument to True.
Your application is responsible for providing feedback to the user about the reason for the cancellation.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` .`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

Another `E:Autodesk.Revit.ApplicationServices.Application.DocumentReloadingLatest` event will be raised immediately after document synchronizing with central model
is finished.

#### Since

2021

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.ElementTypeDuplicated`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ElementTypeDuplicated`

#### Summary

Subscribe to the ElementTypeDuplicated event to be notified immediately after Revit has finished duplicating an element type.

#### Remarks

This event is raised immediately after Revit has finished duplicating an element type.
It is raised even when duplicating an element type failed or was cancelled (during ElementTypeDuplicating event).

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Check the 'Status' field in event's argument to see whether the action itself was successful or not.

This event is not cancellable, for the process of importing has already been finished.

If the action was not successful, the document may not be modified and new transactions may not be started.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2015

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.ElementTypeDuplicating`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ElementTypeDuplicating`

#### Summary

Subscribe to the ElementTypeDuplicating event to be notified when Revit is just about to duplicate an element type.

#### Remarks

This event is raised when Revit is just about to duplicate an element type.

Event is cancellable. To cancel it, call the 'Cancel()' method in event's argument to True.
Your application is responsible for providing feedback to the user about the reason for the cancellation.

The following API functions are not available for the current document during this event:
All overloads of Autodesk.Revit.DB.Document.Import()`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` .`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

Another `E:Autodesk.Revit.ApplicationServices.Application.ElementTypeDuplicated` event will be raised immediately after duplicating an element type is finished.

#### Since

2015

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.FamilyLoadedIntoDocument`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.FamilyLoadedIntoDocument`

#### Summary

Subscribe to the FamilyLoadedInto event to be notified after Revit loaded a family into a document.

#### Remarks

This event is raised immediately after Revit has finished loading a family into a document.
It is raised even when family loading failed or was cancelled (during FamilyLoadingIntoDocument event).

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Check the 'Status' field in event's argument to see whether the action itself was successful or not.

This event is not cancellable, for the process of importing has already been finished.

If the action was not successful, the document may not be modified and new transactions may not be started.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2015

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.FamilyLoadingIntoDocument`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.FamilyLoadingIntoDocument`

#### Summary

Subscribe to the FamilyLoadingInto event to be notified when Revit is just about to load a family into a document.

#### Remarks

This event is raised when Revit is just about to load a family into a document.

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Event is cancellable. To cancel it, call the 'Cancel()' method in event's argument to True.
Your application is responsible for providing feedback to the user about the reason for the cancellation.

The following API functions are not available for the current document during this event:
All overloads of Autodesk.Revit.DB.Document.Import()`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` .`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

Another `E:Autodesk.Revit.ApplicationServices.Application.FamilyLoadedIntoDocument` event will be raised immediately after family loading
is finished.

#### Since

2015

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.ApplicationInitialized`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ApplicationInitialized`

#### Summary

Subscribe to this event to get notified after the Revit application has been initialized.

#### Remarks

The event is raised after Revit was launched as fully initialized, including initialization of external applications.

The event is not cancellable; the 'Cancellable' property of the event's argument is always False.

#### Since

2013

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.ProgressChanged`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ProgressChanged`

#### Summary

Subscribe to the ProgressChanged event to be notified when an operation in Revit has progress bar data available.

#### Remarks

Handlers of this event may use the `M:Autodesk.Revit.DB.Events.ProgressChangedEventArgs.Cancel` method to cancel the operation tracked by the progress bar.
Users may not change the document in the handler for this event.
Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException` will be thrown if any document-modifying method is called during this event's handler.

#### Since

2013

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentSynchronizedWithCentral`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentSynchronizedWithCentral`

#### Summary

Subscribe to the DocumentSynchronizedWithCentral event to be notified immediately after Revit has finished synchronizing a document with central model.

#### Remarks

This event is raised immediately after Revit has finished synchronizing a document with central model.
It is raised even when document synchronizing with central model failed or was cancelled (during DocumentSynchronizingWithCentral event).

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Check the 'Status' field in the event's argument to see whether the action itself was successful or not.

This event is not cancellable, for the process of synchronizing a document with central model has already been finished.

If the action was not successful, the document may not be modified and new transactions may not be started.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2010

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentSynchronizingWithCentral`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentSynchronizingWithCentral`

#### Summary

Subscribe to the DocumentSynchronizingWithCentral event to be notified when Revit is just about to synchronize a document with central model.

#### Remarks

This event is raised when Revit is just about to synchronize a document with central model.

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Event is cancellable. To cancel it, call the 'Cancel()' method in event's argument to True.
Your application is responsible for providing feedback to the user about the reason for the cancellation.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` .`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

Another `E:Autodesk.Revit.ApplicationServices.Application.DocumentSynchronizedWithCentral` event will be raised immediately after document synchronizing with central model
is finished.

#### Since

2010

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentOpened`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentOpened`

#### Summary

Subscribe to the DocumentOpened event to be notified immediately after Revit has finished opening a document.

#### Remarks

This event is raised immediately after Revit has finished opening a document.
It is raised even when document opening failed or was cancelled (during DocumentOpening event).

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Check the 'Status' field in event's argument to see whether the action itself was successful or not.

This event is not cancellable, for the process of opening document has already been finished.

If the action was not successful, the document may not be modified and new transactions may not be started.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2010

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentOpening`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentOpening`

#### Summary

Subscribe to the DocumentOpening event to be notified when Revit is just about to open a document.

#### Remarks

This event is raised when Revit is just about to open a document.

Event is cancellable. To cancel it, call the 'Cancel()' method in event's argument to True.
Your application is responsible for providing feedback to the user about the reason for the cancellation.

The document cannot be modified, for it is not opened yet at the time of the event.

Another `E:Autodesk.Revit.ApplicationServices.Application.DocumentOpened` event will be raised immediately after document
is opened.

#### Since

2010

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.FileExported`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.FileExported`

#### Summary

Subscribe to the FileExported event to be notified immediately after Revit has finished exporting files of formats supported by the API.

#### Remarks

This event is raised immediately after Revit has finished exporting files of formats supported by the API.
It is raised even when file exporting failed or was cancelled (during FileExporting event).

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Check the 'Status' field in event's argument to see whether the action itself was successful or not.
If export is a part of ‘Publish to Buzzsaw' command which consists of two parts – export of a document followed by publishing it to a BuzzSaw server, the event status only reflects the result of the Export action. The publishing part of the command could still be cancelled or could fail after FileExported event is raised.

This event is not cancellable, for the process of exporting file has already been finished.

If the action was not successful, the document may not be modified and new transactions may not be started.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2010

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.FileExporting`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.FileExporting`

#### Summary

Subscribe to the FileExporting event to be notified when Revit is just about to export files of formats supported by the API.

#### Remarks

This event is raised when Revit is just about to export files of formats supported by the API.

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Event is cancellable. To cancel it, call the 'Cancel()' method in event's argument to True.
Your application is responsible for providing feedback to the user about the reason for the cancellation.

The following API functions are not available for the current document during this event:
All overloads of Autodesk.Revit.DB.Document.Export()Autodesk.Revit.Document.Print()`M:Autodesk.Revit.DB.View.Print` and similar overloads.`M:Autodesk.Revit.DB.PrintManager.SubmitPrint` and similar overloads.`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` .`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

Another `E:Autodesk.Revit.ApplicationServices.Application.FileExported` event will be raised immediately after file exporting
is finished.

#### Since

2010

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.FileImported`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.FileImported`

#### Summary

Subscribe to the FileImported event to be notified immediately after Revit has finished importing a file of format supported by the API.

#### Remarks

This event is raised immediately after Revit has finished importing a file of format supported by the API.
It is raised even when file importing failed or was cancelled (during FileImporting event).

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Check the 'Status' field in event's argument to see whether the action itself was successful or not.

This event is not cancellable, for the process of importing has already been finished.

If the action was not successful, the document may not be modified and new transactions may not be started.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2010

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.FileImporting`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.FileImporting`

#### Summary

Subscribe to the FileImporting event to be notified when Revit is just about to import a file of format supported by the API.

#### Remarks

This event is raised when Revit is just about to import a file of format supported by the API.

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Event is cancellable. To cancel it, call the 'Cancel()' method in event's argument to True.
Your application is responsible for providing feedback to the user about the reason for the cancellation.

The following API functions are not available for the current document during this event:
All overloads of Autodesk.Revit.DB.Document.Import()`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` .`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

Another `E:Autodesk.Revit.ApplicationServices.Application.FileImported` event will be raised immediately after file importing
is finished.

#### Since

2010

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentCreated`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentCreated`

#### Summary

Subscribe to the DocumentCreated event to be notified immediately after Revit has finished creating a new document.

#### Remarks

This event is raised immediately after Revit has finished creating a new document.
It is raised even when document creation failed or was cancelled (during DocumentCreating event).

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Check the 'Status' field in event's argument to see whether the action itself was successful or not.
This event is not cancellable, for the process of document creation has already been finished.

If the action was not successful, the document may not be modified and new transactions may not be started.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

#### Since

2010

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentCreating`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentCreating`

#### Summary

Subscribe to the DocumentCreating event to be notified when Revit is just about to create a new document.

#### Remarks

This event is raised when Revit is just about to create a new document.

Event is cancellable. To cancel it, call the 'Cancel()' method of event's argument to True.
Your application is responsible for providing feedback to the user about the reason for the cancellation.

The document cannot be modified, for it is not created yet at the time of the event.

The following API functions are not available for the current document during this event:
`!:Autodesk::Revit::ApplicationServices::Application::NewProjectDocument()``M:Autodesk.Revit.ApplicationServices.Application.NewFamilyDocument(System.String)``M:Autodesk.Revit.ApplicationServices.Application.NewProjectTemplateDocument(System.String)``M:Autodesk.Revit.ApplicationServices.Application.OpenDocumentFile(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

Another `E:Autodesk.Revit.ApplicationServices.Application.DocumentCreated` event will be raised immediately after document
creation is finished.

#### Since

2010

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentClosed`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentClosed`

#### Summary

Subscribe to the DocumentClosing event to be notified when Revit is just about to close a document.

#### Remarks

This event is raised immediately after Revit has finished closing a document.
It is raised even when document closing failed or was cancelled (during DocumentClosing event).

This event is not cancellable, for the process of closing document has already been finished.

The document cannot be modified because the corresponding object does not exist anymore.

#### Since

2010

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentClosing`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentClosing`

#### Summary

Subscribe to the DocumentClosing event to be notified when Revit is just about to close a document.

#### Remarks

This event is raised when Revit is just about to close a document.

This event is cancellable, except when it is raised during close of the application.
Check the 'Cancellable' property of event's argument to see whether it is cancellable or not.
When it is cancellable, set the 'Cancel' property in event's argument to True to cancel it.
Your application is responsible for providing feedback to the user about the reason for the cancellation.

The document may not be modified during this event.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

Another `E:Autodesk.Revit.ApplicationServices.Application.DocumentClosed` event will be raised immediately after document is closed.

#### Since

2012

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.ViewPrinted`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ViewPrinted`

#### Summary

Subscribe to the ViewPrinted event to be notified immediately after Revit has finished printing a view of the document.

#### Remarks

This event is raised immediately after Revit has finished printing a view of the document.
If multiple views are combined to a single file, this event will be raised only once.
It is raised even when view printing failed.

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Check the 'Status' field in event's argument to see whether the action was successful or not.

This event is not cancellable, for the process of view printing has already been finished.

If the action was not successful, the document may not be modified and new transactions may not be started.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.ViewPrinting`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.ViewPrinting`

#### Summary

Subscribe to the ViewPrinting event to be notified when Revit is just about to print a view of the document.

#### Remarks

This event is raised when Revit is just about to print a view of the document.
If multiple views are combined to a single file, this event will be raised only once.

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Event is not cancellable. The 'Cancellable' property of event's argument is always False.

The following API functions are not available for the current document during this event:
All overloads of Autodesk.Revit.DB.Document.Export()Autodesk.Revit.DB.Document.Print()`M:Autodesk.Revit.DB.View.Print` and similar overloads.`M:Autodesk.Revit.DB.PrintManager.SubmitPrint` and similar overloads.`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` .`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

Another event `E:Autodesk.Revit.ApplicationServices.Application.ViewPrinted` will be raised immediately after view printing
is finished.

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentPrinted`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentPrinted`

#### Summary

Subscribe to the DocumentPrinted event to be notified immediately after Revit has finished printing a view or ViewSet of the document.

#### Remarks

This event is raised immediately after Revit has finished printing a view or ViewSet of the document.
It is raised even when document printing failed or was cancelled (during DocumentPriting event).

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Check the 'Status' field in event's argument to see whether the action itself was successful or not.

This event is not cancellable, for the process of printing has already been finished.

If the action was not successful, the document may not be modified and new transactions may not be started.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentPrinting`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentPrinting`

#### Summary

Subscribe to the DocumentPrinting event to be notified when Revit is just about to print a view or ViewSet of the document.

#### Remarks

This event is raised when Revit is just about to print a view or ViewSet of the document.
This document-level event precedes the application-level event of the same name.

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Event is cancellable. To cancel it, call the 'Cancel()' method of event's argument to True.
Your application is responsible for providing feedback to the user about the reason for the cancellation.

The following API functions are not available for current document during this event:
All overloads of Autodesk.Revit.DB.Document.Export()Autodesk::Revit::DB::Document::Print`M:Autodesk.Revit.DB.View.Print` and similar overloads.`M:Autodesk.Revit.DB.PrintManager.SubmitPrint` and similar overloads.`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` .`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

After this event, for each view being printed, Autodesk::Revit::ApplicationServices::Application::ViewPrinting and Autodesk::Revit::ApplicationServices::Application::ViewPrinted events will be raised.
Another event `E:Autodesk.Revit.DB.Document.DocumentPrinted` will be raised immediately after document printing
is finished.

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentSavedAs`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentSavedAs`

#### Summary

Subscribe to the DocumentSavedAs event to be notified immediately after Revit has finished saving document with a new file name.

#### Remarks

This event is raised immediately after Revit has finished saving document with a new file name.
Note that the first save of a newly created document will raise DocumentSavedAs rather than `E:Autodesk.Revit.ApplicationServices.Application.DocumentSaved` event.
It is raised even when document saving failed or was cancelled (during DocumentSavingAs event).

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Check the 'Status' property in event's argument to see whether the action itself was successful or not.

This event is not cancellable, for the process of saving document has already been finished.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentSavingAs`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentSavingAs`

#### Summary

Subscribe to the DocumentSavingAs event to be notified when Revit is just about to save the document with a new file name.

This event is raised when Revit is just about to save the document with a new file name.
Note that the first save of a newly created document will raise DocumentSavingAs rather than `E:Autodesk.Revit.ApplicationServices.Application.DocumentSaving` event.

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

This event is cancellable, except when it is raised during close of the application.
Check the 'Cancellable' property of event's argument to see whether it is cancellable or not.
When it is cancellable, call the 'Cancel()' method of event's argument to cancel it.
Your application is responsible for providing feedback to the user about the reason for the cancellation.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` .`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

Another event `E:Autodesk.Revit.ApplicationServices.Application.DocumentSavedAs` will be raised immediately after the document has been saved with a new file name.

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentSaved`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentSaved`

#### Summary

Subscribe to the DocumentSaved event to be notified immediately after Revit has finished saving a document.

#### Remarks

This event is raised immediately after Revit has finished saving a document.
Note that the first save of a newly created document will raise `E:Autodesk.Revit.ApplicationServices.Application.DocumentSavedAs`
rather than the DocumentSaved event.
It is raised even when document saving failed or was cancelled (during DocumentSaving event).

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

Check the 'Status' property in event's argument to see whether the action itself was successful or not.

This event is not cancellable, for the process of saving document has already been finished.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentSaving`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentSaving`

#### Summary

Subscribe to the DocumentSaving event to be notified when Revit is just about to save a document.

#### Remarks

This event is raised when Revit is just about to save the document.
Note that the first save of a newly created document will raise `E:Autodesk.Revit.ApplicationServices.Application.DocumentSavingAs`
rather than the DocumentSaving event.

Handlers of this event are permitted to make modifications to any document (including the active document),
except for documents that are currently in read-only mode.

This event is cancellable, except when it is raised during close of the application.
Check the 'Cancellable' property of event's argument to see whether it is cancellable or not.
When it is cancellable, call the 'Cancel()' method of event's argument to cancel it.
Your application is responsible for providing feedback to the user about the reason for the cancellation.

The following API functions are not available for the current document during this event:
`M:Autodesk.Revit.DB.Document.Close` and similar overloads.`M:Autodesk.Revit.DB.Document.Save` .`M:Autodesk.Revit.DB.Document.SaveAs(System.String)` and similar overloads.

Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException` will be thrown if any of the above methods is called during this event.

Another event `E:Autodesk.Revit.ApplicationServices.Application.DocumentSaved` will be raised immediately after the document has been saved.

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.FailuresProcessing`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.FailuresProcessing`

#### Summary

Subscribe to the FailuresProcessing event to be notified when failures are being processed at the end of transaction.

#### Remarks

This event is raised when failures are being processed during transaction commit or rollback operations.
Handlers of this event have a limited ability to modify the document and/or failures in it, using provided
restricted failures accessor interface.

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.WorksharedOperationProgressChanged`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.WorksharedOperationProgressChanged`

#### Summary

# Subscribe to the WorksharedOperationProgressChanged to be notified when progress has changed during Collaboration for Revit's workshared operations: open model and synchronize with central.

#### Remarks

This event is only supported for Collaboration for Revit and will not be raised for those operations occurring in local-worksharing and Revit Server workflow.
Users may not change the document in the handler for this event.
If you do not need detailed progress information for synchronizing with central, see `!:Autodesk::Revit::DB::Events::DocumentSynchronizingWithCentral` or `!:Autodesk::Revit::DB::Events::DocumentSynchronizedWithCentral` .
It is NOT recommended to do any time-consuming work when handling DocumentSynchronizingWithCentralProgessChanged event. This can increase workshared operation time."
Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException` will be thrown if any document-modifying method is called during this event's handler.

#### Since

2017 Subscription Update

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.LinkedResourceOpened`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.LinkedResourceOpened`

#### Summary

Subscribe to the LinkedResourceOpened event to be notified immediately after Revit has finished opening a linked resource.

#### Remarks

This event is raised immediately after Revit has finished opening a linked resource.
Only supports linked resources for following types : Revit; IFC; CAD(dwg, dxf, dgn, sat); Topography;
It is raised even when a linked resource opening failed.
The LinkedResourceOpened events would not raised if there are no update on linked CAD, IFC resources.

Check the 'Status' field in event's argument to see whether the action itself was successful or not.

Another `E:Autodesk.Revit.ApplicationServices.Application.LinkedResourceOpening` event will be raised when Revit is just about to
open a linked resource.

#### Since

2018

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.LinkedResourceOpening`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.LinkedResourceOpening`

#### Summary

Subscribe to the LinkedResourceOpening event to be notified when Revit is just about to open a linked resource.

#### Remarks

This event is raised when Revit is just about to open a linked resource.
Only supports linked resources for following types : Revit; IFC; CAD(dwg, dxf, dgn, sat);
This event would not be raised if there are no update on linked CAD, IFC resources.

Event is not cancellable.

The linked resource cannot be modified, for it is not opened yet at the time of the event.

Another `E:Autodesk.Revit.ApplicationServices.Application.LinkedResourceOpened` event will be raised immediately after
linked resource is opened.

#### Since

2018

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.GetFolderContentsRequested`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.GetFolderContentsRequested`

#### Summary

# Subscribe to the GetFolderContentsRequested event to be notified when Revit requests for a list of cloud folder contents, containing subfolders and cloud models.

#### Remarks

This event is only supported for listing ForgeDM folder contents via Collaboration for Revit and will not be raised for those operations occurring in local-worksharing and Revit Server workflow.

#### Since

2019

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.GetProjectsRequested`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.GetProjectsRequested`

#### Summary

# Subscribe to the GetProjectsRequested event to be notified when Revit requests for a list of cloud projects.

#### Remarks

This event is only supported for listing ForgeDM projects via Collaboration for Revit and will not be raised for those operations occurring in local-worksharing and Revit Server workflow.

#### Since

2019

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.GetHubsRequested`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.GetHubsRequested`

#### Summary

# Subscribe to the GetHubsRequested event to be notified when Revit requests for a list of cloud hubs.

#### Remarks

This event is only supported for listing ForgeDM hubs via Collaboration for Revit and will not be raised for those operations occurring in local-worksharing and Revit Server workflow.

#### Since

2019

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.PositionsSaved`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.PositionsSaved`

#### Summary

Subscribe to the PositionsSaved event to be notified when linked symbols Positions (Shared Coordinates) saved during PositionsSaved operations.

#### Remarks

This event is only supported for PositionsSaved operation for linked symbols.
Users may not change the document in the handler for this event.
It is NOT recommended to do any time-consuming work when handling PositionsSaved event."
Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException` will be thrown if any document-modifying method is called during this event's handler.

#### Since

2018

### `E:Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentChanged`

Member kind: event
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.DocumentChanged`

#### Summary

Subscribe to the FailuresProcessingEvent event to be notified when Revit document has changed.

#### Remarks

This event is raised whenever a Revit transaction is either committed, or undone or redone.
This is a read-only event, designed to allow you to keep external data in sync with the state of the Revit database.
To update the Revit database in response to changes in elements, use the IUpdater framework.

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.SetLibraryPaths(System.Collections.Generic.IDictionary{System.String,System.String})`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.SetLibraryPaths(System.Collections.Generic.IDictionary{System.String,System.String})`

#### Summary

Sets path information identifying where Revit searches for content.

#### Remarks

The map that
is returned should contain a key that is purpose of the path, such as Material Libraries and the value
in the map is the fully qualified path to be used for that search path.

#### Parameter `paths`

The map of library paths.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Since

2012

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.GetLibraryPaths`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.GetLibraryPaths`

#### Summary

Returns path information identifying where Revit searches for content.

#### Remarks

The map that
is returned contains a key that is purpose of the path, such as Material Libraries and the value
in the map is the fully qualified path that is used for that search path.

#### Returns

The map of library paths.

#### Since

2012

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.SendAdpData(Autodesk.Revit.DB.AddInId,Autodesk.Revit.DB.Document,Autodesk.ADPDesktopSDK.Facets.Core)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.SendAdpData(Autodesk.Revit.DB.AddInId,Autodesk.Revit.DB.Document,Autodesk.ADPDesktopSDK.Facets.Core)`

#### Summary

Sends ADP Core facet with analytics data, DB::AddInId and DB::Document to the Revit for processing and sending to the ADP data lake.

#### Parameter `addInId`

DB::AddInId addInId with data for collection

#### Parameter `document`

DB::Document document with data for collection

#### Parameter `coreFacet`

Container for analytics data

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Since

2022

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.SendAdpData(Autodesk.Revit.DB.Document,Autodesk.ADPDesktopSDK.Facets.Core)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.SendAdpData(Autodesk.Revit.DB.Document,Autodesk.ADPDesktopSDK.Facets.Core)`

#### Summary

Sends ADP Core facet with analytics data, and DB::Document to the Revit for processing and sending to the ADP data lake.

#### Parameter `document`

DB::Document addInId with data for collection

#### Parameter `coreFacet`

Container for analytics data

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Since

2022

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.SendAdpData(Autodesk.Revit.DB.AddInId,Autodesk.ADPDesktopSDK.Facets.Core)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.SendAdpData(Autodesk.Revit.DB.AddInId,Autodesk.ADPDesktopSDK.Facets.Core)`

#### Summary

Sends ADP Core facet with analytics data, and DB::AddInId to the Revit for processing and sending to the ADP data lake.

#### Parameter `addInId`

DB::AddInId addInId with data for collection

#### Parameter `coreFacet`

Container for analytics data

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Since

2022

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.SendAdpData(Autodesk.ADPDesktopSDK.Facets.Core)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.SendAdpData(Autodesk.ADPDesktopSDK.Facets.Core)`

#### Summary

Sends ADP Core facet with analytics data to the Revit for processing and sending to the ADP data lake.

#### Parameter `coreFacet`

Container for analytics data

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Since

2022

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.IsJournalPlaying`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.IsJournalPlaying`

#### Summary

Determines if the application is currently in journal playback mode.

#### Remarks

Determines if Revit is in the process of playing back a journal. It can be
used to help prevent any user interaction that may cause issues during playback.
For more information on Revit's journaling features contact the Autodesk Developer Network.

#### Returns

true if a journal is currently playing back, false otherwise.

#### Since

2020

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.WriteJournalComment(System.String,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.WriteJournalComment(System.String,System.Boolean)`

#### Summary

Writes a comment to the Revit journal file

#### Parameter `comment`

Text for journal comment

#### Parameter `timeStamp`

If a time stamp should be included in the journal comment

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.RecordingJournalFilename`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.RecordingJournalFilename`

#### Summary

Retrieve the name of the journal file that Revit is currently recording to.

#### Remarks

As Revit operates it keeps a log of operations that the user performs
within a file, known as a journal file. These files are useful for providing information
about the actions performed in a session and the state of Revit when a problem occurs.
These files are included during error reporting to Autodesk.

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.RegisterFailuresProcessor(Autodesk.Revit.DB.IFailuresProcessor)`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.RegisterFailuresProcessor(Autodesk.Revit.DB.IFailuresProcessor)`

#### Summary

Registers Revit application-wide instance of Failures Processor.

#### Remarks

If there is previously registered Failures Processor, it gets discarded.
If you opt to register a FailuresProcessor for Revit, your processor will become the default error handler
for all Revit errors for the session. The standard Revit error dialog will not appear.
If you want to handle only specific failures but not all types of failures in your application,
subscribe to the FailuresProcessing event instead, or use FailuresPreprocessor interface
for the specific transaction.

#### Parameter `processor`

Instance of Failures Processor to be used by the Revit Application.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

### `M:Autodesk.Revit.ApplicationServices.ControlledApplication.GetFailureDefinitionRegistry`

Member kind: method
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.GetFailureDefinitionRegistry`

#### Summary

Returns the instance of FailureDefinitionRegistry.

#### Returns

The instance of FailureDefinitionRegistry.

#### Since

2011

### `P:Autodesk.Revit.ApplicationServices.ControlledApplication.IsLateAddinLoading`

Member kind: property
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication.IsLateAddinLoading`

#### Summary

Indicates whether this add-in is loaded on the fly or not. If it is loaded when is Revit starting up, it
is false, otherwise it should be true.

### `T:Autodesk.Revit.ApplicationServices.ControlledApplication`

Member kind: type
Symbol: `Autodesk.Revit.ApplicationServices.ControlledApplication`

#### Summary

Represents the Autodesk Revit Application with no access to documents. It provides options
and other application wide data and settings for external applications OnStartup/OnShutdown.

### `M:DocumentLoadStoreOptions.determineStreamsShouldOpenForWrite(System.Boolean(*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)[N13],System.Boolean)`

Member kind: method
Symbol: `DocumentLoadStoreOptions.determineStreamsShouldOpenForWrite(System.Boolean(*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)[N13],System.Boolean)`

#### Summary

determines which streams should be opened from write, according the the store options.
streamShouldOpenForWrites returns the result.

#### Remark

Callers are responsible for cleanup or set the initial state of streamShouldOpenForWrite

### `P:Autodesk.Revit.DB.City.TimeZone`

Member kind: property
Symbol: `Autodesk.Revit.DB.City.TimeZone`

#### Summary

Time-zone in which the city resides

#### Remarks

A read only property that returns the time zone in which the city resides.
The value is in hours, ranging from +12 hours to -12 hours with 0 being GMT.

### `P:Autodesk.Revit.DB.City.Longitude`

Member kind: property
Symbol: `Autodesk.Revit.DB.City.Longitude`

#### Summary

Longitude of the city

#### Remarks

A read only property that contains the longitude of the city.
The value returned is in radians, ranging from -PI to +PI.

### `P:Autodesk.Revit.DB.City.Latitude`

Member kind: property
Symbol: `Autodesk.Revit.DB.City.Latitude`

#### Summary

Latitude of the city

#### Remarks

A read only property that contains the latitude of the city.
The value returned is in radians, ranging from -PI to +PI.

### `P:Autodesk.Revit.DB.City.WeatherStation`

Member kind: property
Symbol: `Autodesk.Revit.DB.City.WeatherStation`

#### Summary

An identifier for the nearest weather station

#### Remarks

A read only string property that contains an identifier of the nearest weather station.

#### Since

2011

### `P:Autodesk.Revit.DB.City.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.City.Name`

#### Summary

The name of the city

#### Remarks

A read only string property that contains the name of the city, such as Boston.

### `T:Autodesk.Revit.DB.City`

Member kind: type
Symbol: `Autodesk.Revit.DB.City`

#### Summary

An object that contains geographical location information for a known city.

#### Remarks

This object contains longitude, latitude, time zone information for a city already known by Revit.
Currently Revit does not the ability to add cities to the existing list. The list of known cities can be
retrieved using the Cities property on the application object.

### `P:Autodesk.Revit.Creation.AreaCreationData.TagPoint`

Member kind: property
Symbol: `Autodesk.Revit.Creation.AreaCreationData.TagPoint`

#### Summary

Specify the location of the area tag.

### `M:Autodesk.Revit.Creation.AreaCreationData.#ctor(Autodesk.Revit.DB.ViewPlan,Autodesk.Revit.DB.UV)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.AreaCreationData.#ctor(Autodesk.Revit.DB.ViewPlan,Autodesk.Revit.DB.UV)`

#### Summary

The data needed to create a new area

#### Parameter `areaView`

The view of area element.

#### Parameter `point`

The point which lies in the enclosed region of AreaBoundaryLines to put the new created Area

### `T:Autodesk.Revit.Creation.AreaCreationData`

Member kind: type
Symbol: `Autodesk.Revit.Creation.AreaCreationData`

#### Summary

A class which wraps the arguments of Area for batch creation

### `P:Autodesk.Revit.Creation.FamilyInstanceCreationData.RotateAngle`

Member kind: property
Symbol: `Autodesk.Revit.Creation.FamilyInstanceCreationData.RotateAngle`

#### Summary

Get or set the rotate angle of the FamilyInstance

#### Remarks

The FamilyInstance will rotate this angle when the instance is created.

### `P:Autodesk.Revit.Creation.FamilyInstanceCreationData.Axis`

Member kind: property
Symbol: `Autodesk.Revit.Creation.FamilyInstanceCreationData.Axis`

#### Summary

Get or set the axis of the FamilyInstance

#### Remarks

The element property will be the axis while performing the rotation.

### `M:Autodesk.Revit.Creation.FamilyInstanceCreationData.#ctor(Autodesk.Revit.DB.FamilySymbol,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyInstanceCreationData.#ctor(Autodesk.Revit.DB.FamilySymbol,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

#### Parameter `symbol`

A FamilySymbol object that represents the type of the instance that is to be inserted.

#### Parameter `adaptivePoints`

The adaptive points where the adaptive instance is to be initialized.

### `M:Autodesk.Revit.Creation.FamilyInstanceCreationData.#ctor(Autodesk.Revit.DB.Face,Autodesk.Revit.DB.Line,Autodesk.Revit.DB.FamilySymbol)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyInstanceCreationData.#ctor(Autodesk.Revit.DB.Face,Autodesk.Revit.DB.Line,Autodesk.Revit.DB.FamilySymbol)`

#### Parameter `face`

A face of a geometry object.

#### Parameter `position`

A line on the face defining where the symbol is to be placed.

#### Parameter `symbol`

A FamilySymbol object that represents the type of the instance that is to be inserted.

### `M:Autodesk.Revit.Creation.FamilyInstanceCreationData.#ctor(Autodesk.Revit.DB.Face,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyInstanceCreationData.#ctor(Autodesk.Revit.DB.Face,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol)`

#### Parameter `face`

A face of a geometry object.

#### Parameter `location`

Point on the face where the instance is to be placed.

#### Parameter `referenceDirection`

A vector that defines the direction of the family instance.

#### Parameter `symbol`

A FamilySymbol object that represents the type of the instance that is to be inserted.

### `M:Autodesk.Revit.Creation.FamilyInstanceCreationData.#ctor(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Structure.StructuralType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyInstanceCreationData.#ctor(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Structure.StructuralType)`

#### Parameter `location`

The physical location where the instance is to be placed.

#### Parameter `symbol`

A FamilySymbol object that represents the type of the instance that is to be inserted.

#### Parameter `referenceDirection`

A vector that dictates the direction of certain family instances.

#### Parameter `host`

The object into which the FamilyInstance is to be inserted, often known as the host.

#### Parameter `structuralType`

If structural then specify the type of the component.

### `M:Autodesk.Revit.Creation.FamilyInstanceCreationData.#ctor(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Level,Autodesk.Revit.DB.Structure.StructuralType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyInstanceCreationData.#ctor(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Level,Autodesk.Revit.DB.Structure.StructuralType)`

#### Parameter `location`

The physical location where the instance is to be placed.

#### Parameter `symbol`

A FamilySymbol object that represents the type of the instance that is to be inserted.

#### Parameter `host`

The object into which the FamilyInstance is to be inserted, often known as the host.

#### Parameter `level`

A Level object that is used as the base level for the object.

#### Parameter `structuralType`

If structural then specify the type of the component.

### `M:Autodesk.Revit.Creation.FamilyInstanceCreationData.#ctor(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Structure.StructuralType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyInstanceCreationData.#ctor(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Structure.StructuralType)`

#### Parameter `location`

The physical location where the instance is to be placed.

#### Parameter `symbol`

A FamilySymbol object that represents the type of the instance that is to be inserted.

#### Parameter `host`

The object into which the FamilyInstance is to be inserted, often known as the host.

#### Parameter `structuralType`

If structural then specify the type of the component.

### `M:Autodesk.Revit.Creation.FamilyInstanceCreationData.#ctor(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.Level,Autodesk.Revit.DB.Structure.StructuralType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyInstanceCreationData.#ctor(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.Level,Autodesk.Revit.DB.Structure.StructuralType)`

#### Parameter `location`

The physical location where the instance is to be placed.

#### Parameter `symbol`

A FamilySymbol object that represents the type of the instance that is to be inserted.

#### Parameter `level`

A Level object that is used as the base level for the object.

#### Parameter `structuralType`

If structural then specify the type of the component.

### `M:Autodesk.Revit.Creation.FamilyInstanceCreationData.#ctor(Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.Level,Autodesk.Revit.DB.Structure.StructuralType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyInstanceCreationData.#ctor(Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.Level,Autodesk.Revit.DB.Structure.StructuralType)`

#### Parameter `curve`

The curve where the instance is based.

#### Parameter `symbol`

A FamilySymbol object that represents the type of the instance that is to be inserted.

#### Parameter `level`

A Level object that is used as the base level for the object.

#### Parameter `structuralType`

If structural then specify the type of the component.

### `M:Autodesk.Revit.Creation.FamilyInstanceCreationData.#ctor(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.Structure.StructuralType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.FamilyInstanceCreationData.#ctor(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.Structure.StructuralType)`

#### Parameter `location`

The physical location where the instance is to be placed.

#### Parameter `symbol`

A FamilySymbol object that represents the type of the instance that is to be inserted.

#### Parameter `structuralType`

Specify if the family instance is structural.

### `T:Autodesk.Revit.Creation.FamilyInstanceCreationData`

Member kind: type
Symbol: `Autodesk.Revit.Creation.FamilyInstanceCreationData`

#### Summary

A class which wraps the arguments of FamilyInstance for batch creation.

### `M:Autodesk.Revit.Creation.Application.NewReferencePointArray`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewReferencePointArray`

#### Summary

Creates an empty array that can store ReferencePoint objects.

#### Returns

An empty array that can hold ReferencePoint objects.

#### Remarks

This method can be used to create an array that can hold ReferencePoint objects. This
array can be then passed to methods, such as NewCurveByPoints, to represent two or more PointElements.

### `M:Autodesk.Revit.Creation.Application.NewPointRelativeToPoint(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewPointRelativeToPoint(Autodesk.Revit.DB.Reference)`

#### Summary

Create a PointRelativeToPoint object, which is used to define
the placement of a ReferencePoint relative to a host point.

#### Parameter `hostPointReference`

The reference of the host point.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument hostPointReference is `null` .

#### Returns

If creation is successful then a new PointRelativeToPoint object is returned,
otherwise an exception with failure information will be thrown.

#### Since

2013

### `M:Autodesk.Revit.Creation.Application.NewPointOnEdgeFaceIntersection(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Reference,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewPointOnEdgeFaceIntersection(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Reference,System.Boolean)`

#### Summary

Construct a PointOnEdgeFaceIntersection object which is used to define the placement of a ReferencePoint given a references to edge and a reference to face.

#### Parameter `edgeReference`

The edge reference.

#### Parameter `faceReference`

The face reference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument edgeReference or faceReference is `null` .

#### Returns

A new PointOnEdgeFaceIntersection object.

### `M:Autodesk.Revit.Creation.Application.NewPointOnEdgeEdgeIntersection(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewPointOnEdgeEdgeIntersection(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Reference)`

#### Summary

Construct a PointOnEdgeEdgeIntersection object which is used to define the placement of a ReferencePoint given two references to edge.

#### Parameter `edgeReference1`

The first edge reference.

#### Parameter `edgeReference2`

The second edge reference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument edgeReference1 or edgeReference2 is `null` .

#### Returns

A new PointOnEdgeEdgeIntersection object.

### `M:Autodesk.Revit.Creation.Application.NewPointOnFace(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.UV)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewPointOnFace(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.UV)`

#### Summary

Construct a PointOnFace object which is used to define the placement of a ReferencePoint given a reference and a location on the face.

#### Parameter `faceReference`

The reference whose face the object will be created on.

#### Parameter `uv`

A 2-dimensional position.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument faceReference or uv is `null` .

#### Returns

A new PointOnFace object.

### `M:Autodesk.Revit.Creation.Application.NewPointOnPlane(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.UV,Autodesk.Revit.DB.UV,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewPointOnPlane(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.UV,Autodesk.Revit.DB.UV,System.Double)`

#### Summary

Construct a PointOnPlane object which is used to define the placement of a ReferencePoint from its property values.

#### Parameter `planeReference`

A reference to some plane
in the document. (Note: the reference must satisfy
IsValidPlaneReference(),
but this is not checked until this PointOnPlane object
is assigned to a ReferencePoint.)

#### Parameter `position`

Coordinates of the point's projection onto the plane;
see the Position property.

#### Parameter `xvec`

The direction of the point's
X-coordinate vector in the plane's coordinates; see the XVec property. Optional;
default value is (1, 0).

#### Parameter `offset`

Signed offset from the plane; see the Offset property.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument planeReference or position or xvec is `null` or offset is not a valid double value.

#### Returns

A new PointOnPlane object with 2-dimensional Position, XVec, and Offset
properties set to match the given 3-dimensional arguments.

### `M:Autodesk.Revit.Creation.Application.NewPointOnEdge(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.PointLocationOnCurve)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewPointOnEdge(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.PointLocationOnCurve)`

#### Summary

Create a PointOnEdge object which is used to define the placement of a ReferencePoint.

#### Parameter `edgeReference`

The reference whose edge the object will be created on.

#### Parameter `locationOnCurve`

The location on the edge.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument edgeReference or locationOnCurve is `null` .

#### Returns

If creation was successful then a new object is returned,
otherwise an exception with failure information will be thrown.

### `M:Autodesk.Revit.Creation.Application.NewFamilySymbolProfile(Autodesk.Revit.DB.FamilySymbol)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewFamilySymbolProfile(Autodesk.Revit.DB.FamilySymbol)`

#### Summary

Creates a new FamilySymbolProfile object.

#### Parameter `familySymbol`

The family symbol of the Profile.

#### Returns

The new FamilySymbolProfile object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the argument familySymbol is `null` .

### `M:Autodesk.Revit.Creation.Application.NewCurveLoopsProfile(Autodesk.Revit.DB.CurveArrArray)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewCurveLoopsProfile(Autodesk.Revit.DB.CurveArrArray)`

#### Summary

Creates a new CurveLoopsProfile object.

#### Parameter `curveLoops`

The curve loops of the Profile.

#### Returns

The new CurveLoopsProfile object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the argument is `null` .

### `M:Autodesk.Revit.Creation.Application.NewElementId`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewElementId`

#### Summary

Creates a new Autodesk::Revit::DB::ElementId^ object.

#### Returns

The new Autodesk::Revit::DB::ElementId^ object.

### `M:Autodesk.Revit.Creation.Application.NewAreaCreationData(Autodesk.Revit.DB.ViewPlan,Autodesk.Revit.DB.UV)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewAreaCreationData(Autodesk.Revit.DB.ViewPlan,Autodesk.Revit.DB.UV)`

#### Summary

Creates an object which wraps the arguments of Area for batch creation.

#### Parameter `areaView`

The view of area element.

#### Parameter `point`

A point which lies in an enclosed region of area boundary where the new area will reside.

#### Returns

The object containing the data needed for area creation.

### `M:Autodesk.Revit.Creation.Application.NewFamilyInstanceCreationData(Autodesk.Revit.DB.FamilySymbol,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewFamilyInstanceCreationData(Autodesk.Revit.DB.FamilySymbol,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

#### Overloads

Creates an adaptive component which wraps the arguments of NewFamilyInstance() for batch creation.

#### Summary

Creates an object which wraps the arguments of NewFamilyInstance() for batch creation.

#### Parameter `symbol`

A FamilySymbol object that represents the type of the instance that is to be inserted.

#### Parameter `adaptivePoints`

The adaptive point location where the adaptive instance is to be placed.

### `M:Autodesk.Revit.Creation.Application.NewFamilyInstanceCreationData(Autodesk.Revit.DB.Face,Autodesk.Revit.DB.Line,Autodesk.Revit.DB.FamilySymbol)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewFamilyInstanceCreationData(Autodesk.Revit.DB.Face,Autodesk.Revit.DB.Line,Autodesk.Revit.DB.FamilySymbol)`

#### Summary

Creates an object which wraps the arguments of NewFamilyInstance() for batch creation.

#### Parameter `face`

A face of a geometry object.

#### Parameter `position`

A line on the face defining where the symbol is to be placed.

#### Parameter `symbol`

A FamilySymbol object that represents the type of the instance that is to be inserted.

### `M:Autodesk.Revit.Creation.Application.NewFamilyInstanceCreationData(Autodesk.Revit.DB.Face,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewFamilyInstanceCreationData(Autodesk.Revit.DB.Face,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol)`

#### Summary

Creates an object which wraps the arguments of NewFamilyInstance() for batch creation.

#### Parameter `face`

A face of a geometry object.

#### Parameter `location`

Point on the face where the instance is to be placed.

#### Parameter `referenceDirection`

A vector that defines the direction of the family instance.

#### Parameter `symbol`

A FamilySymbol object that represents the type of the instance that is to be inserted.

### `M:Autodesk.Revit.Creation.Application.NewFamilyInstanceCreationData(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Structure.StructuralType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewFamilyInstanceCreationData(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Structure.StructuralType)`

#### Summary

Creates an object which wraps the arguments of NewFamilyInstance() for batch creation.

#### Parameter `location`

The physical location where the instance is to be placed.

#### Parameter `symbol`

A FamilySymbol object that represents the type of the instance that is to be inserted.

#### Parameter `referenceDirection`

A vector that dictates the direction of certain family instances.

#### Parameter `host`

The object into which the family instance is to be inserted, often known as the host.

#### Parameter `structuralType`

If structural then specify the type of the component.

### `M:Autodesk.Revit.Creation.Application.NewFamilyInstanceCreationData(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Level,Autodesk.Revit.DB.Structure.StructuralType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewFamilyInstanceCreationData(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Level,Autodesk.Revit.DB.Structure.StructuralType)`

#### Summary

Creates an object which wraps the arguments of NewFamilyInstance() for batch creation.

#### Parameter `location`

The physical location where the instance is to be placed.

#### Parameter `symbol`

A FamilySymbol object that represents the type of the instance that is to be inserted.

#### Parameter `host`

The object into which the family instance is to be inserted, often known as the host.

#### Parameter `level`

A Level object that is used as the base level for the object.

#### Parameter `structuralType`

If structural then specify the type of the component.

### `M:Autodesk.Revit.Creation.Application.NewFamilyInstanceCreationData(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Structure.StructuralType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewFamilyInstanceCreationData(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Structure.StructuralType)`

#### Summary

Creates an object which wraps the arguments of NewFamilyInstance() for batch creation.

#### Parameter `location`

The physical location where the instance is to be placed.

#### Parameter `symbol`

A FamilySymbol object that represents the type of the instance that is to be inserted.

#### Parameter `host`

The object into which the family instance is to be inserted, often known as the host.

#### Parameter `structuralType`

If structural then specify the type of the component.

### `M:Autodesk.Revit.Creation.Application.NewFamilyInstanceCreationData(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.Level,Autodesk.Revit.DB.Structure.StructuralType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewFamilyInstanceCreationData(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.Level,Autodesk.Revit.DB.Structure.StructuralType)`

#### Summary

Creates an object which wraps the arguments of NewFamilyInstance() for batch creation.

#### Parameter `location`

The physical location where the instance is to be placed.

#### Parameter `symbol`

A FamilySymbol object that represents the type of the instance that is to be inserted.

#### Parameter `level`

A Level object that is used as the base level for the object.

#### Parameter `structuralType`

If structural then specify the type of the component.

### `M:Autodesk.Revit.Creation.Application.NewFamilyInstanceCreationData(Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.Level,Autodesk.Revit.DB.Structure.StructuralType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewFamilyInstanceCreationData(Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.Level,Autodesk.Revit.DB.Structure.StructuralType)`

#### Summary

Creates an object which wraps the arguments of NewFamilyInstance() for batch creation.

#### Parameter `curve`

The curve where the instance is based.

#### Parameter `symbol`

A FamilySymbol object that represents the type of the instance that is to be inserted.

#### Parameter `level`

A Level object that is used as the base level for the object.

#### Parameter `structuralType`

If structural then specify the type of the component.

### `M:Autodesk.Revit.Creation.Application.NewFamilyInstanceCreationData(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.Structure.StructuralType)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewFamilyInstanceCreationData(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.FamilySymbol,Autodesk.Revit.DB.Structure.StructuralType)`

#### Overloads

Creates an object which wraps the arguments of NewFamilyInstance() for batch creation.

#### Summary

Creates an object which wraps the arguments of NewFamilyInstance() for batch creation.

#### Parameter `location`

The physical location where the instance is to be placed.

#### Parameter `symbol`

A FamilySymbol object that represents the type of the instance that is to be inserted.

#### Parameter `structuralType`

Specify if the family instance is structural.

### `M:Autodesk.Revit.Creation.Application.NewSpaceSet`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewSpaceSet`

#### Summary

Creates a new instance of a space set.

### `M:Autodesk.Revit.Creation.Application.NewViewSet`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewViewSet`

#### Summary

Creates a new instance of a View set.

### `M:Autodesk.Revit.Creation.Application.NewIntersectionResultArray`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewIntersectionResultArray`

#### Summary

Creates a new instance of an IntersectionResult array.

### `M:Autodesk.Revit.Creation.Application.NewFaceArray`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewFaceArray`

#### Summary

Creates a new instance of a face array.

### `M:Autodesk.Revit.Creation.Application.NewReferenceArray`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewReferenceArray`

#### Summary

Creates a new instance of a reference array.

### `M:Autodesk.Revit.Creation.Application.NewDoubleArray`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewDoubleArray`

#### Summary

Creates a new instance of a double array.

### `M:Autodesk.Revit.Creation.Application.NewGBXMLImportOptions`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewGBXMLImportOptions`

#### Summary

Creates Green-Building XML Import options.

### `M:Autodesk.Revit.Creation.Application.NewFBXExportOptions`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewFBXExportOptions`

#### Summary

Creates 3D-Studio Max (FBX) Export options.

### `M:Autodesk.Revit.Creation.Application.NewDWFXExportOptions`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewDWFXExportOptions`

#### Summary

Creates DWFX Export options.

### `M:Autodesk.Revit.Creation.Application.NewDWFExportOptions`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewDWFExportOptions`

#### Summary

Creates DWF Export options.

### `M:Autodesk.Revit.Creation.Application.NewUV(Autodesk.Revit.DB.UV)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewUV(Autodesk.Revit.DB.UV)`

#### Summary

Creates a UV object by copying the supplied UV object.

#### Parameter `uv`

The supplied UV object

### `M:Autodesk.Revit.Creation.Application.NewUV(System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewUV(System.Double,System.Double)`

#### Summary

Creates a UV object representing coordinates in 2-space with supplied values.

#### Parameter `u`

The first coordinate.

#### Parameter `v`

The second coordinate.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when setting an infinite number to the U or V property.

### `M:Autodesk.Revit.Creation.Application.NewUV`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewUV`

#### Overloads

Creates a UV object representing coordinates in 2-space.

#### Summary

Creates a UV object at the origin.

### `M:Autodesk.Revit.Creation.Application.NewXYZ(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewXYZ(Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a XYZ object by copying the supplied XYZ object.

#### Parameter `xyz`

The supplied XYZ object

### `M:Autodesk.Revit.Creation.Application.NewXYZ(System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewXYZ(System.Double,System.Double,System.Double)`

#### Summary

Creates a XYZ object representing coordinates in 3-space with supplied values.

#### Parameter `x`

The first coordinate.

#### Parameter `y`

The second coordinate.

#### Parameter `z`

The third coordinate.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when setting an infinite number to the X, Y or Z property.

### `M:Autodesk.Revit.Creation.Application.NewXYZ`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewXYZ`

#### Overloads

Creates a XYZ object representing coordinates in 3-space.

#### Summary

Creates a XYZ object at the origin.

### `M:Autodesk.Revit.Creation.Application.NewBoundingBoxUV(System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewBoundingBoxUV(System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a two-dimensional rectangle with supplied values.

#### Parameter `min_u`

The first coordinate of min.

#### Parameter `min_v`

The second coordinate of min.

#### Parameter `max_u`

The first coordinate of max.

#### Parameter `max_v`

The second coordinate of max.

### `M:Autodesk.Revit.Creation.Application.NewBoundingBoxUV`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewBoundingBoxUV`

#### Overloads

Creates a two-dimensional rectangle.

#### Summary

Creates an empty two-dimensional rectangle.

### `M:Autodesk.Revit.Creation.Application.NewBoundingBoxXYZ`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewBoundingBoxXYZ`

#### Summary

Creates a three-dimensional rectangular box.

### `M:Autodesk.Revit.Creation.Application.NewProjectPosition(System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewProjectPosition(System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new project position object.

#### Parameter `ew`

East to West offset in feet.

#### Parameter `ns`

North to South offset in feet.

#### Parameter `elevation`

Elevation above sea level in feet.

#### Parameter `angle`

Rotation angle away from true north in the range of -PI to +PI.

#### Remarks

This object contains offset information and is used by the project location object
for setting the project location relative to the site location. Measurements are in feet and
radians.

### `M:Autodesk.Revit.Creation.Application.NewColor`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewColor`

#### Summary

Returns a new color object.

#### Returns

The new color object.

### `M:Autodesk.Revit.Creation.Application.NewCombinableElementArray`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewCombinableElementArray`

#### Summary

Returns an array that can hold combinable element objects.

#### Returns

An empty array that can contain any CombinableElement derived objects.

### `M:Autodesk.Revit.Creation.Application.NewVertexIndexPairArray`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewVertexIndexPairArray`

#### Summary

Returns an array that can hold VertexIndexPair objects.

#### Returns

The new VertexIndexPairArray objects.

### `M:Autodesk.Revit.Creation.Application.NewVertexIndexPair(System.Int32,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewVertexIndexPair(System.Int32,System.Int32)`

#### Summary

Creates a new VertexIndexPair object.

#### Parameter `iTop`

The index of the vertex pair from the top profile of a blend.

#### Parameter `iBottom`

The index of the vertex pair from the bottom profile of a blend.

#### Returns

The new VertexIndexPair object.

### `M:Autodesk.Revit.Creation.Application.NewCurveArrArray`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewCurveArrArray`

#### Summary

Creates an empty array that can store geometric curve loops.

#### Returns

The empty array of curve loops.

### `M:Autodesk.Revit.Creation.Application.NewCurveArray`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewCurveArray`

#### Summary

Creates an empty array that can store geometric curves.

#### Returns

An empty array that can hold geometric curves.

#### Remarks

This method can be used to create an array that can hold any curve type object. This
array can be then passed to methods, such as NewAreaLoad, to represent the geometry for the
boundary of the load.

### `M:Autodesk.Revit.Creation.Application.NewGeometryOptions`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewGeometryOptions`

#### Summary

Creates an object to specify user preferences in parsing of geometry.

### `M:Autodesk.Revit.Creation.Application.NewElementSet`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewElementSet`

#### Summary

Creates a new instance of a set specifically for holding elements.

#### Returns

A new Element Set.

#### Remarks

This is a general purpose set for passing elements to and from methods.

### `M:Autodesk.Revit.Creation.Application.NewTypeBinding(Autodesk.Revit.DB.CategorySet)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewTypeBinding(Autodesk.Revit.DB.CategorySet)`

#### Summary

Creates a new type binding object containing the categories passed as a parameter.

#### Parameter `categorySet`

A set of categories that will be added to the binding.

#### Returns

A new type binding object.

#### Remarks

Type binding objects are used for attaching shared parameter definitions to a type
within a category.

### `M:Autodesk.Revit.Creation.Application.NewTypeBinding`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewTypeBinding`

#### Overloads

Creates a new type binding object.

#### Summary

Creates a new empty type binding object.

#### Returns

A new type binding object.

#### Remarks

Type binding objects are used for attaching shared parameter definitions to a type
within a category. Categories can be added to the instance binding via the Categories property of
the InstanceBinding object

### `M:Autodesk.Revit.Creation.Application.NewInstanceBinding(Autodesk.Revit.DB.CategorySet)`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewInstanceBinding(Autodesk.Revit.DB.CategorySet)`

#### Summary

Creates a new instance binding object containing the categories passed as a parameter.

#### Parameter `categorySet`

A set of categories that will be added to the binding.

#### Returns

A new instance binding object.

#### Remarks

Instance binding objects are used for attaching shared parameter definitions to all
instances of an element within a category.

### `M:Autodesk.Revit.Creation.Application.NewInstanceBinding`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewInstanceBinding`

#### Overloads

Creates a new instance binding object.

#### Summary

Creates a new empty instance binding object.

#### Returns

A new instance binding object.

#### Remarks

Instance binding objects are used for attaching shared parameter definitions to all
instances of an element within a category. Categories can be added to the instance binding via
the Categories property of the InstanceBinding object

### `M:Autodesk.Revit.Creation.Application.NewCategorySet`

Member kind: method
Symbol: `Autodesk.Revit.Creation.Application.NewCategorySet`

#### Summary

Creates a new instance of a set specifically for holding category objects.

#### Returns

A new instance of a Category Set.

#### Remarks

This type of set is used during the creation of instance and type bindings.

### `T:Autodesk.Revit.Creation.Application`

Member kind: type
Symbol: `Autodesk.Revit.Creation.Application`

#### Summary

The Application Creation object is used to create new instances of utility objects.

#### Remarks

General purpose objects can be generated by this creation object. Creating objects
via this object ensures that they will be correctly constructed and will reside in the
Autodesk Revit memory space.

### `M:Autodesk.Revit.DB.PropertySetElement.SetThermalAsset(Autodesk.Revit.DB.ThermalAsset)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PropertySetElement.SetThermalAsset(Autodesk.Revit.DB.ThermalAsset)`

#### Summary

Sets a copy of the given ThermalAsset to be used in the PropertySetElement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the name of the asset is empty, contains prohibited characters, or is not unique

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.PropertySetElement.GetThermalAsset`

Member kind: method
Symbol: `Autodesk.Revit.DB.PropertySetElement.GetThermalAsset`

#### Summary

Gets a copy of the ThermalAsset.

#### Since

2012

### `M:Autodesk.Revit.DB.PropertySetElement.SetStructuralAsset(Autodesk.Revit.DB.StructuralAsset)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PropertySetElement.SetStructuralAsset(Autodesk.Revit.DB.StructuralAsset)`

#### Summary

Sets a copy of the given StucturalAsset to be used in the PropertySetElement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the name of the asset is empty, contains prohibited characters, or is not unique

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.PropertySetElement.GetStructuralAsset`

Member kind: method
Symbol: `Autodesk.Revit.DB.PropertySetElement.GetStructuralAsset`

#### Summary

Gets a copy of the StructuralAsset.

#### Since

2012

### `M:Autodesk.Revit.DB.PropertySetElement.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ThermalAsset)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PropertySetElement.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ThermalAsset)`

#### Summary

Creates a new PropertySetElement to contain the given asset.

#### Parameter `document`

The document in which to create the PropertySetElement.

#### Parameter `thermalAsset`

The thermal asset containing the values that will be present in the PropertySetElement.

#### Returns

The new PropertySetElement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the name of the asset is empty, contains prohibited characters, or is not unique

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.PropertySetElement.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.StructuralAsset)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PropertySetElement.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.StructuralAsset)`

#### Summary

Creates a new PropertySetElement to contain the given asset.

#### Parameter `document`

The document in which to create the PropertySetElement.

#### Parameter `structuralAsset`

The structural asset containing the values that will be present in the PropertySetElement.

#### Returns

The new PropertySetElement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the name of the asset is empty, contains prohibited characters, or is not unique

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.PropertySetElement.Duplicate(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PropertySetElement.Duplicate(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Creates a duplicate of this PropertySetElement.

#### Parameter `document`

The document in which to create the PropertySetElement.

#### Parameter `name`

The name to use for the new PropertySetElement.

#### Returns

The new PropertySetElement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for name is already in use as a property set name.
-or-
name is an empty string.
-or-
name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.PropertySetElement`

Member kind: type
Symbol: `Autodesk.Revit.DB.PropertySetElement`

#### Summary

An element that groups together a set of related parameters.

#### Since

2012

### `M:Autodesk.Revit.DB.PrimarySizeCriterion.None`

Member kind: method
Symbol: `Autodesk.Revit.DB.PrimarySizeCriterion.None`

#### Summary

Creates a criterion with a range of no sizes.

#### Returns

The new criterion.

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2013

### `M:Autodesk.Revit.DB.PrimarySizeCriterion.All`

Member kind: method
Symbol: `Autodesk.Revit.DB.PrimarySizeCriterion.All`

#### Summary

Creates a criterion with a range of all sizes.

#### Returns

The new criterion.

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2013

### `P:Autodesk.Revit.DB.PrimarySizeCriterion.MaximumSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrimarySizeCriterion.MaximumSize`

#### Summary

The maximum size of this criterion.

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

When setting this property: None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2013

### `P:Autodesk.Revit.DB.PrimarySizeCriterion.MinimumSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.PrimarySizeCriterion.MinimumSize`

#### Summary

The minimum size of this criterion.

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

When setting this property: None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2013

### `M:Autodesk.Revit.DB.PrimarySizeCriterion.#ctor(System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PrimarySizeCriterion.#ctor(System.Double,System.Double)`

#### Summary

Constructs a PrimarySizeCriterion with a minimum and maximum size.

#### Since

2013

### `T:Autodesk.Revit.DB.PrimarySizeCriterion`

Member kind: type
Symbol: `Autodesk.Revit.DB.PrimarySizeCriterion`

#### Summary

This class contains a size criterion for a RoutingPreferenceRule.

#### Since

2013

### `M:Autodesk.Revit.DB.CADLinkType.LoadFrom(Autodesk.Revit.DB.ExternalResourceReference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CADLinkType.LoadFrom(Autodesk.Revit.DB.ExternalResourceReference)`

#### Summary

Loads or reloads the DWG link from the given external resource reference.

#### Remarks

If the link is currently loaded, any changes made in-memory
to the link's shared coordinates will be discarded.

Graphic overrides will be preserved on reload.

If the original view used to bring in this link has
been deleted, Revit will cancel the load.

If there is already another link, not current link itself,
using the given external resource reference, the loading will not happen.
The element id of the link using the external resource reference will be contained
in the LinkLoadResult.

This function checks the actual resource path that the IExternalResourceServer returns.
If the link type identified by the resource path doesn't match DWG, the load will not proceed.

#### Parameter `resourceReference`

An ExternalResourceReference giving the location of the
link. This method can be used to load the link from a
file on disk. See `!:Autodesk::Revit::DB::ExternalResourceReference::CreateLocalResource()` .

#### Returns

An object containing the ElementId of the link
and an enum value indicating any
errors which occurred while trying to load.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The server referenced by the ExternalResourceReference does not exist or
does not implement IExternalResourceServer.
-or-
The server referenced by the ExternalResourceReference cannot support CAD links.
-or-
The ExternalResourceReference (resourceReference) is not in a format
that is supported by its server.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This CADLinkType represents an import and cannot be used as a link.
-or-
The element "this CADLinkType" is in a read-only document.
-or-
The link does not represent a DWG.

#### Since

2018

### `M:Autodesk.Revit.DB.CADLinkType.LoadFrom(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CADLinkType.LoadFrom(System.String)`

#### Summary

Loads or reloads the DWG link from the given file path.

#### Remarks

If the link is currently loaded, any changes made in-memory
to the link's shared coordinates will be discarded.

Graphic overrides will be preserved on reload.

If the original view used to bring in this link has
been deleted, Revit will cancel the load.

If there is already another link, not current link itself,
using the given file path, the loading will not happen.
The element id of the link using the file path will be contained
in the LinkLoadResult.

If the link type identified by the given path doesn't match DWG,
the load will not proceed.

#### Parameter `path`

A path on disk giving the location of the linked file. This path
must be absolute. The link's path will remain PathType.Absolute
or PathType.Relative, whichever it was before. If the link was
previously to an external server location, the path type will be
relative.

#### Returns

An object containing the ElementId of the link
and an enum value indicating any
errors which occurred while trying to load.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

The given path does not exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This CADLinkType represents an import and cannot be used as a link.
-or-
The element "this CADLinkType" is in a read-only document.
-or-
The link does not represent a DWG.

#### Since

2018

### `M:Autodesk.Revit.DB.CADLinkType.Reload(Autodesk.Revit.DB.CADLinkOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CADLinkType.Reload(Autodesk.Revit.DB.CADLinkOptions)`

#### Summary

Loads or reloads the link from its currently-stored location. If the link is an
external resource, Revit will contact the IExternalResourceServer to get the latest version
of the link.

#### Remarks

If the link is currently loaded, any changes made in-memory
to the link's shared coordinates will be discarded.

#### Parameter `options`

Options for reloading the link. Options include
the ability to preserve graphic overrides on reload.

#### Returns

An object containing the ElementId of the link
and an enum value indicating any
errors which occurred while trying to load.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This CADLinkType represents an import and cannot be used as a link.
-or-
The element "this CADLinkType" is in a read-only document.

#### Since

2018

### `M:Autodesk.Revit.DB.CADLinkType.Reload`

Member kind: method
Symbol: `Autodesk.Revit.DB.CADLinkType.Reload`

#### Summary

Loads or reloads the link from its currently-stored location. If the link is an
external resource, Revit will contact the IExternalResourceServer to get the latest version
of the link.

#### Remarks

If the link is currently loaded, any changes made in-memory
to the link's shared coordinates will be discarded.

Graphic overrides will be preserved on reload.

If the original view used to bring in this link has
been deleted, Revit will cancel the load.

#### Returns

An object containing the ElementId of the link
and an enum value indicating any
errors which occurred while trying to load.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This CADLinkType represents an import and cannot be used as a link.
-or-
The element "this CADLinkType" is in a read-only document.

#### Since

2018

### `T:Autodesk.Revit.DB.CADLinkType`

Member kind: type
Symbol: `Autodesk.Revit.DB.CADLinkType`

#### Summary

CADLinkType represents both CAD links and CAD imports. The
function IsLink can be used to distinguish between the two.
CAD imports are not ExternalFileReferences; they are brought
completely into the document and maintain no connection to
their original file.

#### Since

2013

### `P:Autodesk.Revit.DB.Lighting.PresetInitialColor.Preset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Lighting.PresetInitialColor.Preset`

#### Summary

The preset value

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.PresetInitialColor.#ctor(Autodesk.Revit.DB.Lighting.PresetInitialColor)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.PresetInitialColor.#ctor(Autodesk.Revit.DB.Lighting.PresetInitialColor)`

#### Summary

Creates a copy of the given preset initial color

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.PresetInitialColor.#ctor(Autodesk.Revit.DB.Lighting.ColorPreset)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.PresetInitialColor.#ctor(Autodesk.Revit.DB.Lighting.ColorPreset)`

#### Summary

Creates an initial color preset object with the given preset value.

#### Parameter `presetIn`

The enum value which determines the preset value

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `T:Autodesk.Revit.DB.Lighting.PresetInitialColor`

Member kind: type
Symbol: `Autodesk.Revit.DB.Lighting.PresetInitialColor`

#### Summary

This class encapsulates a preset initial lighting color.

#### Since

2013

### `T:Autodesk.Revit.DB.Lighting.ColorPreset`

Member kind: type
Symbol: `Autodesk.Revit.DB.Lighting.ColorPreset`

#### Summary

Preset values of initial colors for specific lighting types

#### Since

2013

### `F:Autodesk.Revit.DB.Lighting.ColorPreset.PhosphorMercury`

Member kind: field
Symbol: `Autodesk.Revit.DB.Lighting.ColorPreset.PhosphorMercury`

#### Summary

Phosphor mercury.

### `F:Autodesk.Revit.DB.Lighting.ColorPreset.Mercury`

Member kind: field
Symbol: `Autodesk.Revit.DB.Lighting.ColorPreset.Mercury`

#### Summary

Mercury.

### `F:Autodesk.Revit.DB.Lighting.ColorPreset.LowPressureSodium`

Member kind: field
Symbol: `Autodesk.Revit.DB.Lighting.ColorPreset.LowPressureSodium`

#### Summary

Low pressure sodium.

### `F:Autodesk.Revit.DB.Lighting.ColorPreset.HighPressureSodium`

Member kind: field
Symbol: `Autodesk.Revit.DB.Lighting.ColorPreset.HighPressureSodium`

#### Summary

High pressure sodium.

### `F:Autodesk.Revit.DB.Lighting.ColorPreset.MetalHalide`

Member kind: field
Symbol: `Autodesk.Revit.DB.Lighting.ColorPreset.MetalHalide`

#### Summary

Metal halide.

### `F:Autodesk.Revit.DB.Lighting.ColorPreset.FluorescentLightWhite`

Member kind: field
Symbol: `Autodesk.Revit.DB.Lighting.ColorPreset.FluorescentLightWhite`

#### Summary

F4 fluorescent light white.

### `F:Autodesk.Revit.DB.Lighting.ColorPreset.FluorescentDayLight`

Member kind: field
Symbol: `Autodesk.Revit.DB.Lighting.ColorPreset.FluorescentDayLight`

#### Summary

F4 fluorescent day light.

### `F:Autodesk.Revit.DB.Lighting.ColorPreset.FluorescentWhite`

Member kind: field
Symbol: `Autodesk.Revit.DB.Lighting.ColorPreset.FluorescentWhite`

#### Summary

F4 fluorescent white.

### `F:Autodesk.Revit.DB.Lighting.ColorPreset.FluorescentCool`

Member kind: field
Symbol: `Autodesk.Revit.DB.Lighting.ColorPreset.FluorescentCool`

#### Summary

F4 fluorescent cool white.

### `F:Autodesk.Revit.DB.Lighting.ColorPreset.FluorescentWarm`

Member kind: field
Symbol: `Autodesk.Revit.DB.Lighting.ColorPreset.FluorescentWarm`

#### Summary

F4 fluorescent warm white.

### `F:Autodesk.Revit.DB.Lighting.ColorPreset.Quartz`

Member kind: field
Symbol: `Autodesk.Revit.DB.Lighting.ColorPreset.Quartz`

#### Summary

Quartz.

### `F:Autodesk.Revit.DB.Lighting.ColorPreset.Xenon`

Member kind: field
Symbol: `Autodesk.Revit.DB.Lighting.ColorPreset.Xenon`

#### Summary

Xenon.

### `F:Autodesk.Revit.DB.Lighting.ColorPreset.Incandescent`

Member kind: field
Symbol: `Autodesk.Revit.DB.Lighting.ColorPreset.Incandescent`

#### Summary

Incandescent.

### `F:Autodesk.Revit.DB.Lighting.ColorPreset.Halogen`

Member kind: field
Symbol: `Autodesk.Revit.DB.Lighting.ColorPreset.Halogen`

#### Summary

Halogen.

### `F:Autodesk.Revit.DB.Lighting.ColorPreset.D50`

Member kind: field
Symbol: `Autodesk.Revit.DB.Lighting.ColorPreset.D50`

#### Summary

D50.

### `F:Autodesk.Revit.DB.Lighting.ColorPreset.D65`

Member kind: field
Symbol: `Autodesk.Revit.DB.Lighting.ColorPreset.D65`

#### Summary

D65.

### `P:Autodesk.Revit.DB.Electrical.AnalyticalEquipmentLoadData.LoadType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalEquipmentLoadData.LoadType`

#### Summary

The load type of analytical equipment load.

#### Since

2023

### `P:Autodesk.Revit.DB.Electrical.AnalyticalEquipmentLoadData.TrueLoad`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalEquipmentLoadData.TrueLoad`

#### Summary

The electrical true load of analytical equipment load.

#### Since

2023

### `P:Autodesk.Revit.DB.Electrical.AnalyticalEquipmentLoadData.PowerFactor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalEquipmentLoadData.PowerFactor`

#### Summary

The power factor of analytical equipment load.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for power factor must be between 0 and 1.

#### Since

2023

### `P:Autodesk.Revit.DB.Electrical.AnalyticalEquipmentLoadData.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalEquipmentLoadData.Current`

#### Summary

The current of the analytical equipment load.

#### Since

2023

### `P:Autodesk.Revit.DB.Electrical.AnalyticalEquipmentLoadData.Voltage`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalEquipmentLoadData.Voltage`

#### Summary

The voltage of the analytical equipment load.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for voltage is not a number
-or-
When setting this property: The given value for voltage is not finite

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for voltage must be positive.

#### Since

2023

### `P:Autodesk.Revit.DB.Electrical.AnalyticalEquipmentLoadData.ApparentLoad`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalEquipmentLoadData.ApparentLoad`

#### Summary

The electrical apparent load of analytical equipment load.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for value is not a number
-or-
When setting this property: The given value for value is not finite

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for value must be non-negative.

#### Since

2023

### `P:Autodesk.Revit.DB.Electrical.AnalyticalEquipmentLoadData.LoadSet`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalEquipmentLoadData.LoadSet`

#### Summary

The electrical analytical load set of the analytical equipment load.

#### Remarks

invalidElementId if the analytical equipment load does not belong to any analytical load sets.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given element id loadSetId is neither a load set id nor invalidElementId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2024

### `P:Autodesk.Revit.DB.Electrical.AnalyticalEquipmentLoadData.LoadClassification`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalEquipmentLoadData.LoadClassification`

#### Summary

The load classification of analytical equipment load.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The id is not a load classification id .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2023

### `T:Autodesk.Revit.DB.Electrical.AnalyticalEquipmentLoadData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.AnalyticalEquipmentLoadData`

#### Summary

Represents the data and parameters of point load node.

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.PointLoad.IsPointInsideHostBoundaries(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.PointLoad.IsPointInsideHostBoundaries(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ)`

#### Summary

Indicates if the point is inside panel's boundaries or if the point is on the member's curve..

#### Parameter `pDoc`

The document containing both the host and the load.

#### Parameter `hostId`

The id of the analytical element that is about to host a point load.

#### Parameter `point`

The position of point load, measured in decimal feet.

#### Returns

True if a point load can be placed on the input host id

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.Structure.PointLoad.IsValidHostId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.PointLoad.IsValidHostId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Indicates if the provided host id can host point loads
The document containing both the host and the load
The id of the analytical element that is about to host a point load
True if a point load can be placed on the input host id

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.Structure.PointLoad.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Structure.PointLoadType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.PointLoad.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Structure.PointLoadType)`

#### Summary

Creates a new custom hosted point load within the project using data at point.

#### Parameter `document`

Document to which new point load will be added.

#### Parameter `hostElemId`

The AnalyticalElement host element for the point Load.

#### Parameter `point`

The position of point load, measured in decimal feet.

#### Parameter `forceVector`

The applied 3d force vector.

#### Parameter `momentVector`

The applied 3d moment vector.

#### Parameter `symbol`

The symbol of the PointLoad. Set `null` to use default type.

#### Returns

If successful, returns the newly created PointLoad, `null` otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

hostElemId is not permitted for this type of load.
-or-
Thrown when work plane is not valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Thrown when force and moment vectors are equal zero.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if type could not be set for newly created point load.

#### Since

2024

### `M:Autodesk.Revit.DB.Structure.PointLoad.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Structure.AnalyticalElementSelector,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Structure.PointLoadType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.PointLoad.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Structure.AnalyticalElementSelector,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Structure.PointLoadType)`

#### Summary

Creates a new hosted point load within the project.

#### Parameter `document`

Document to which new point load will be added.

#### Parameter `hostElemId`

The AnalyticalMember host element for the point Load.

#### Parameter `selector`

The start or end point of the Analytical Member element.

#### Parameter `forceVector`

The applied 3d force vector.

#### Parameter `momentVector`

The applied 3d moment vector.

#### Parameter `symbol`

The symbol of the PointLoad. Set `null` to use default type.

#### Returns

If successful, returns the newly created PointLoad, `null` otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element hostElemId does not exist in the document
-or-
hostElemId is not permitted for this type of load.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Thrown when force and moment vectors are equal zero.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown if type could not be set for newly created point load.

#### Since

2023

### `P:Autodesk.Revit.DB.Structure.PointLoad.MomentVector`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.PointLoad.MomentVector`

#### Summary

The moment vector applied to the point load, oriented according to OrientTo setting.

#### Remarks

The default force unit is kN-m for metric, and kip-ft for imperial.
Use UnitUtils class methods to convert value from or to internal units.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.PointLoad.ForceVector`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.PointLoad.ForceVector`

#### Summary

The force vector applied to the point load, oriented according to OrientTo setting.

#### Remarks

The default force unit is kN for metric, and kip for imperial.
Use UnitUtils class methods to convert value from or to internal units.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.PointLoad.Point`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.PointLoad.Point`

#### Summary

Returns the position of point load, measured in decimal feet.

#### Remarks

Loacation can be set only for hosted loads.
This method works for loads which are not constrained to their host.
To determine if load is hosted use `P:Autodesk.Revit.DB.Structure.LoadBase.IsHosted` property.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: This PointLoad is not a hosted load.
-or-
When setting this property: This PointLoad is a constrained load.

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.PointLoad`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.PointLoad`

#### Summary

An object that represents a force/moment applied to a single point.
Data members

### `M:Autodesk.Revit.DB.Lighting.PointLightShape.#ctor(Autodesk.Revit.DB.Lighting.PointLightShape)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.PointLightShape.#ctor(Autodesk.Revit.DB.Lighting.PointLightShape)`

#### Summary

Creates a copy of the given point light shape

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.PointLightShape.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.PointLightShape.#ctor`

#### Summary

Creates a point light shape object.

#### Since

2013

### `T:Autodesk.Revit.DB.Lighting.PointLightShape`

Member kind: type
Symbol: `Autodesk.Revit.DB.Lighting.PointLightShape`

#### Summary

This class encapsulates a point light shape.

#### Since

2013

### `M:Autodesk.Revit.DB.PointCloudInstance.GetPoints(Autodesk.Revit.DB.PointClouds.PointCloudFilter,System.Double,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointCloudInstance.GetPoints(Autodesk.Revit.DB.PointClouds.PointCloudFilter,System.Double,System.Int32)`

#### Summary

Extracts a collection of points based on a filter.

#### Remarks

If there are more points in the cloud passing the filter than the number requested in this function,
the results may not be consistent if the same call is made again.

#### Parameter `filter`

The filter to control which points are extracted. The filter should be passed in the coordinates
of the Revit model.

#### Parameter `averageDistance`

Desired average distance between "adjacent" cloud points (Revit units of length).
The smaller the averageDistance the larger number of points will be returned up to the numPoints limit.
Specifying this parameter makes actual number of points returned for a given filter independent of the
density of coverage produced by the scanner.

#### Parameter `numPoints`

The maximum number of points requested.

#### Returns

A collection object containing points that pass the filter, but no more than the maximum number requested.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The number of points read must range from 1 to 1000000.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for averageDistance must be no more than 30000 feet in absolute value.

#### Since

2014

### `M:Autodesk.Revit.DB.PointCloudInstance.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Transform)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointCloudInstance.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Transform)`

#### Summary

Creates a new instance of a point cloud based on an input point cloud type and transformation.

#### Parameter `document`

The document in which the new instance is created

#### Parameter `typeId`

The element id of the PointCloudType.

#### Parameter `transform`

The transform that defines the placement of the instance in the Revit document coordinate system.

#### Returns

The newly created point cloud instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId typeId is not a valid PointCloudType.
-or-
document is not a project document.

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

### `M:Autodesk.Revit.DB.PointCloudInstance.ContainsScan(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointCloudInstance.ContainsScan(System.String)`

#### Summary

Identifies whether the instance contains a scan.

#### Parameter `scanName`

Name of the scan.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.PointCloudInstance.SetSelectionFilter(Autodesk.Revit.DB.PointClouds.PointCloudFilter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointCloudInstance.SetSelectionFilter(Autodesk.Revit.DB.PointClouds.PointCloudFilter)`

#### Summary

Sets active selection filter by cloning of the one passed to it.

#### Remarks

The filter is provided in the coordinates of the Revit model. If the point cloud is
altered (e.g. by moving, rotating, scaling or other modifications) the point cloud
filter is not modified and the set of highlighted or isolated points will change.
The selection filter is not preserved when the Revit document is saved.

#### Parameter `pFilter`

The filter object to be made active. If `null` is supplied, the
active filter is removed.

### `M:Autodesk.Revit.DB.PointCloudInstance.GetSelectionFilter`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointCloudInstance.GetSelectionFilter`

#### Summary

Returns the currently active selection filter for this point cloud.

#### Returns

Currently active selection filter or `null` if none is active.

### `M:Autodesk.Revit.DB.PointCloudInstance.GetRegions`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointCloudInstance.GetRegions`

#### Summary

Returns array of region names.

#### Returns

Resulting array of region names.

#### Since

2017

### `M:Autodesk.Revit.DB.PointCloudInstance.GetScanOrigin(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointCloudInstance.GetScanOrigin(System.String)`

#### Summary

Returns the origin point of a scan in model coordinates.

#### Parameter `scanName`

Name of the scan.

#### Returns

Resulting origin point of the scan.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

PointCloudInstance does not contain scan scanName.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.PointCloudInstance.GetScans`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointCloudInstance.GetScans`

#### Summary

Returns array of scan names.

#### Returns

Resulting array of scan names.

#### Since

2014

### `M:Autodesk.Revit.DB.PointCloudInstance.HasColor`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointCloudInstance.HasColor`

#### Summary

Returns true if at least one scan of the element have color, false otherwise.

#### Returns

True if at least one scan of the element have color, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.PointCloudInstance.SupportsOverrides`

Member kind: property
Symbol: `Autodesk.Revit.DB.PointCloudInstance.SupportsOverrides`

#### Summary

Identifies whether the instance can have graphic overrides.

#### Since

2014

### `P:Autodesk.Revit.DB.PointCloudInstance.FilterAction`

Member kind: property
Symbol: `Autodesk.Revit.DB.PointCloudInstance.FilterAction`

#### Summary

The action taken based on the results of the selection filter applied to this point cloud.

#### Remarks

If no selection filter is applied, changing this value will have no visible effect.
The filter is provided in the coordinates of the Revit model. If the point cloud is
altered (e.g. by moving, rotating, scaling or other modifications) the point cloud
filter is not modified and the set of highlighted or isolated points will change.
The filter action is not preserved when the Revit document is saved.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

### `T:Autodesk.Revit.DB.PointCloudInstance`

Member kind: type
Symbol: `Autodesk.Revit.DB.PointCloudInstance`

#### Summary

Represents a single instance of a point cloud in the Revit document.

### `T:Autodesk.Revit.DB.SelectionFilterAction`

Member kind: type
Symbol: `Autodesk.Revit.DB.SelectionFilterAction`

#### Summary

An enumerated type containing the type of actions that may be taken with a selection filter applied to a point cloud.

#### Since

2012

### `F:Autodesk.Revit.DB.SelectionFilterAction.Isolate`

Member kind: field
Symbol: `Autodesk.Revit.DB.SelectionFilterAction.Isolate`

#### Summary

Only points that pass the filter are visible.

### `F:Autodesk.Revit.DB.SelectionFilterAction.Highlight`

Member kind: field
Symbol: `Autodesk.Revit.DB.SelectionFilterAction.Highlight`

#### Summary

Points that pass the filter are highlighted.

### `F:Autodesk.Revit.DB.SelectionFilterAction.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.SelectionFilterAction.None`

#### Summary

Selection filter is ignored.

### `M:Autodesk.Revit.DB.PointClouds.PointCloudFilterUtils.GetFilteredOutline(Autodesk.Revit.DB.PointClouds.PointCloudFilter,Autodesk.Revit.DB.Outline)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudFilterUtils.GetFilteredOutline(Autodesk.Revit.DB.PointClouds.PointCloudFilter,Autodesk.Revit.DB.Outline)`

#### Summary

Computes outline of a part of a box that satisfies given PointCloudFilter.

#### Parameter `filter`

Point cloud filter.

#### Parameter `box`

A box aligned with coordinate axes.

#### Returns

The bounding box of the set of all points within the original box that satisfy the filter.
Not every point within the resulting outline satisfies the filter, but any point that is contained
in the original box and satisfies the filter is guaranteed to be within the resulting outline.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `T:Autodesk.Revit.DB.PointClouds.PointCloudFilterUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudFilterUtils`

#### Summary

Utilities specific to point cloud filters.

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.PointCloudFilterFactory.CreateMultiPlaneFilter(System.Collections.Generic.IList{Autodesk.Revit.DB.Plane})`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudFilterFactory.CreateMultiPlaneFilter(System.Collections.Generic.IList{Autodesk.Revit.DB.Plane})`

#### Summary

Creates a new point cloud filter based upon planar boundaries.

#### Remarks

The filter will check whether a point is located on the "positive" side of each plane,
as indicated by the positive direction of the plane normal. Therefore, such filter implicitly defines a volume,
which is the intersection of the positive half-spaces corresponding to all the planes.
This volume does not have to be closed, but it will always be convex.

#### Parameter `planes`

All planes used for filtering; positive direction of the normal should point inside the volume of interest.
Only points on the "positive" side of all planes will pass the filter.

#### Returns

Filter object; can be used to get representative set of cloud points passing through the filter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.PointClouds.PointCloudFilterFactory.CreateMultiPlaneFilter(System.Collections.Generic.IList{Autodesk.Revit.DB.Plane},System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudFilterFactory.CreateMultiPlaneFilter(System.Collections.Generic.IList{Autodesk.Revit.DB.Plane},System.Int32)`

#### Summary

Creates a new point cloud filter based upon planar boundaries.

#### Remarks

The filter will check whether a point is located on the "positive" side of each plane,
as indicated by the positive direction of the plane normal. Therefore, such filter implicitly defines a volume,
which is the intersection of the positive half-spaces corresponding to all the planes.
This volume does not have to be closed, but it will always be convex.

#### Parameter `planes`

All planes used for filtering; positive direction of the normal should point inside the volume of interest.

#### Parameter `exactPlaneCount`

This value represents the number of planes (taken in order of their addition) which will be used
for exact filtering of individual points. Other planes in the filter will be used for faster,
but inexact filtering based on cells.

#### Returns

Filter object; can be used to get representative set of cloud points passing through the filter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.PointClouds.PointCloudFilterFactory`

Member kind: type
Symbol: `Autodesk.Revit.DB.PointClouds.PointCloudFilterFactory`

#### Summary

A factory class for creating point cloud filters.

#### Since

2012

### `M:Autodesk.Revit.DB.Plumbing.PlumbingUtils.BreakCurve(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PlumbingUtils.BreakCurve(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ)`

#### Summary

Breaks the pipe curve into two parts at the given position.

#### Remarks

This method is not applicable for breaking the flex pipe.

#### Parameter `document`

The document.

#### Parameter `pipeId`

The element id of the pipe curve to break.

#### Parameter `ptBreak`

The break point on the pipe curve.

#### Returns

The new pipe curve element id if successful otherwise if a failure occurred an invalidElementId is returned.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

"The element is neither a pipe nor a pipe placeholder."
-or-
"The given point is not on the pipe curve."

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Plumbing.PlumbingUtils.HasOpenConnector(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PlumbingUtils.HasOpenConnector(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Checks if there is open piping connector for the given element - object of pipe curve, pipe fitting or pipe accessory.

#### Parameter `document`

The document.

#### Parameter `elemId`

Element id to check.

#### Returns

True if given element has open piping connector, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.PlumbingUtils.PlaceCapOnOpenEnds(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PlumbingUtils.PlaceCapOnOpenEnds(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Places caps on the open connectors of the pipe curve, pipe fitting or pipe accessory.

#### Remarks

In order to place the cap, the cap type should be defined in the routing preferences that associates with the pipe type of the given element.
If the typeId is a valid element id, it will be used to override the pipe type that associates with the pipe type of the given element.

#### Parameter `document`

The document.

#### Parameter `elemId`

Element id of pipe curve, pipe fitting or pipe accessory.

#### Parameter `typeId`

Pipe type element id.
Default is invalidElementId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element elemId does not exist in the document
-or-
The element elemId is neither an object of pipe curve, pipe fitting, nor pipe accessory.
-or-
The element elemId has no opened piping connector.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

this operation failed.

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.PlumbingUtils.ConnectPipePlaceholdersAtCross(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PlumbingUtils.ConnectPipePlaceholdersAtCross(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

#### Summary

Connects placeholders that looks like Cross connection.

#### Remarks

The placeholders may or may not have physical connection. However
a) The ends of four connectors should intersect at same point;
b) the first and second placeholders should be collinear each other;
c) the third and fourth placeholders should be collinear each other and
d) the third and fourth should have intersection with first or second placeholder.
If connection fails, the placeholders cannot be physically connected.

#### Parameter `document`

The document.

#### Parameter `connector1`

The first end connector of placeholder to be connected to the second.

#### Parameter `connector2`

The second end connector of placeholder to be connected to the first.

#### Parameter `connector3`

The third end connector of placeholder to be connected to the forth.

#### Parameter `connector4`

The fourth end connector of placeholder to be connected to the third.

#### Returns

True if connection succeeds, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The owner of connector is not pipe placeholder.
-or-
The owners of connectors belong to different types of system.
-or-
The curves of connector1 and connector2 are not collinear or either the connecto1 or connector2 is not connector of curve end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Plumbing.PlumbingUtils.ConnectPipePlaceholdersAtCross(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PlumbingUtils.ConnectPipePlaceholdersAtCross(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Connects placeholders that looks like Cross connection.

#### Remarks

If connection fails, the placeholders cannot be physically connected.

#### Parameter `document`

The document.

#### Parameter `placeholder1Id`

The first element Id of pipe placeholder.

#### Parameter `placeholder2Id`

The second element Id of pipe placeholder that intersects with first one.

#### Parameter `placeholder3Id`

The third element Id of pipe placeholder that intersects with first one.

#### Returns

True if connection succeeds, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element id placeholder1Id is not pipe placeholder.
-or-
The element id placeholder2Id is not pipe placeholder.
-or-
The element id placeholder3Id is not pipe placeholder.
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

### `M:Autodesk.Revit.DB.Plumbing.PlumbingUtils.ConnectPipePlaceholdersAtCross(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PlumbingUtils.ConnectPipePlaceholdersAtCross(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Connects placeholders that looks like Cross connection.

#### Remarks

The placeholders must intersect each other. If connection succeeds, a new
placeholder is created. If connection fails, the placeholders cannot be physically connected.

#### Parameter `document`

The document.

#### Parameter `placeholder1Id`

The first element Id of pipe placeholder.

#### Parameter `placeholder2Id`

The second element Id of pipe placeholder.

#### Returns

True if connection succeeds, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element id placeholder1Id is not pipe placeholder.
-or-
The element id placeholder2Id is not pipe placeholder.
-or-
The elements belong to different types of system.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Plumbing.PlumbingUtils.ConnectPipePlaceholdersAtTee(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PlumbingUtils.ConnectPipePlaceholdersAtTee(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

#### Summary

Connects three placeholders that looks like Tee connection.

#### Remarks

The three placeholders may or may not have physically connections. However,
the first one should be collinear with the second and third one must have
intersection with first and second.
If first placeholder and second placeholder have the same size, the second one
is merged with first one and original placeholder element will be invalid.
If connection fails, the placeholders cannot be physically connected.

#### Parameter `document`

The document.

#### Parameter `connector1`

The first end connector of placeholder to be connected to the second.

#### Parameter `connector2`

The second end connector of placeholder to be connected to the first.

#### Parameter `connector3`

The third end connector of placeholder to be connected to the first or second.

#### Returns

True if connection succeeds, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The owner of connector is not pipe placeholder.
-or-
The owners of connectors belong to different types of system.
-or-
The curves of connector1 and connector2 are not collinear or either the connecto1 or connector2 is not connector of curve end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Plumbing.PlumbingUtils.ConnectPipePlaceholdersAtTee(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PlumbingUtils.ConnectPipePlaceholdersAtTee(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Connects two placeholders that looks like Tee connection.

#### Remarks

The second placeholder must have physically connection with the first one.
If connection fails, the placeholders cannot be physically connected.

#### Parameter `document`

The document.

#### Parameter `placeholder1Id`

The first element Id of pipe placeholder.

#### Parameter `placeholder2Id`

The second element Id of pipe placeholder which connects to first.

#### Returns

True if connection succeeds, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element id placeholder1Id is not pipe placeholder.
-or-
The element id placeholder2Id is not pipe placeholder.
-or-
The elements belong to different types of system.
-or-
The curve placeholder2Id does not connect on the curve placeholder1Id or vice versa.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Plumbing.PlumbingUtils.ConnectPipePlaceholdersAtElbow(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PlumbingUtils.ConnectPipePlaceholdersAtElbow(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

#### Summary

Connects placeholders that looks like elbow connection.

#### Remarks

The placeholders may have physical connection or may not connect at all.
In the latter case, the first one connects to the end of second one.
If connection fails, the placeholders cannot be physically connected.

#### Parameter `document`

The document.

#### Parameter `connector1`

The first end connector of placeholder to be connected to.

#### Parameter `connector2`

The second end connector of placeholder to be connected to.

#### Returns

True if connection succeeds, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The owner of connector is not pipe placeholder.
-or-
The owners of connectors belong to different types of system.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Plumbing.PlumbingUtils.ConnectPipePlaceholdersAtElbow(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PlumbingUtils.ConnectPipePlaceholdersAtElbow(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Connects placeholders that looks like elbow connection.

#### Remarks

There must be a physical end connection of placeholders.
If connection fails, the placeholders cannot be physically connected.

#### Parameter `document`

The document.

#### Parameter `placeholder1Id`

The element Id of pipe placeholder.

#### Parameter `placeholder2Id`

The element Id of pipe placeholder.

#### Returns

True if connection succeeds, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element id placeholder1Id is not pipe placeholder.
-or-
The element id placeholder2Id is not pipe placeholder.
-or-
The elements belong to different types of system.
-or-
The curve placeholder1Id and placeholder2Id are not physically connected.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Plumbing.PlumbingUtils.ConvertPipePlaceholders(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PlumbingUtils.ConvertPipePlaceholders(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Converts a collection of pipe placeholder elements into pipe elements.

#### Remarks

Once conversion succeeds, the pipe placeholder elements are deleted.
The new pipe and fitting elements are created and connections are established.

#### Parameter `document`

The document.

#### Parameter `placeholderIds`

A collection of element IDs of pipe placeholders.

#### Returns

A collection of element IDs of pipe and fitting.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given element id set is empty.
-or-
The given element ids (placeholderIds) are not pipe placeholders.
-or-
The elements belong to different types of system.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.Plumbing.PlumbingUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.Plumbing.PlumbingUtils`

#### Summary

General utility methods in the Autodesk Revit MEP product.

#### Since

2012

### `P:Autodesk.Revit.DB.Visual.PlasticVinyl.CommonTintColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.PlasticVinyl.CommonTintColor`

#### Summary

The property labeled "Tint Color" from the "PlasticVinyl" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.PlasticVinyl.CommonTintToggle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.PlasticVinyl.CommonTintToggle`

#### Summary

The property labeled "Tint" from the "PlasticVinyl" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.PlasticVinyl.PlasticvinylPatternAmount`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.PlasticVinyl.PlasticvinylPatternAmount`

#### Summary

The property labeled "Amount" from the "PlasticVinyl" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 2".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.PlasticVinyl.PlasticvinylPatternMap`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.PlasticVinyl.PlasticvinylPatternMap`

#### Summary

The property labeled "Image" from the "PlasticVinyl" schema.

#### Remarks

This property is of type "AssetPropertyReference" and will only contain a reference to a connected image.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.PlasticVinyl.PlasticvinylPattern`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.PlasticVinyl.PlasticvinylPattern`

#### Summary

The property labeled "Relief Pattern" from the "PlasticVinyl" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "PlasticvinylPatternType".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.PlasticVinyl.PlasticvinylBumpAmount`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.PlasticVinyl.PlasticvinylBumpAmount`

#### Summary

The property labeled "Amount" from the "PlasticVinyl" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 1".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.PlasticVinyl.PlasticvinylBumpMap`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.PlasticVinyl.PlasticvinylBumpMap`

#### Summary

The property labeled "Image" from the "PlasticVinyl" schema.

#### Remarks

This property is of type "AssetPropertyReference" and will only contain a reference to a connected image.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.PlasticVinyl.PlasticvinylBump`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.PlasticVinyl.PlasticvinylBump`

#### Summary

The property labeled "Finish Bumps" from the "PlasticVinyl" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "PlasticvinylBumpType".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.PlasticVinyl.PlasticvinylApplication`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.PlasticVinyl.PlasticvinylApplication`

#### Summary

The property labeled "Finish" from the "PlasticVinyl" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "PlasticvinylApplicationType".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.PlasticVinyl.PlasticvinylColorByObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.PlasticVinyl.PlasticvinylColorByObject`

#### Summary

The property labeled "Color By Object" from the "PlasticVinyl" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.PlasticVinyl.PlasticvinylColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.PlasticVinyl.PlasticvinylColor`

#### Summary

The property labeled "Color" from the "PlasticVinyl" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".
This property allows a connected asset.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.PlasticVinyl.PlasticvinylType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.PlasticVinyl.PlasticvinylType`

#### Summary

The property labeled "Type" from the "PlasticVinyl" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "PlasticvinylType".

#### Since

2018.1

### `T:Autodesk.Revit.DB.Visual.PlasticVinyl`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.PlasticVinyl`

#### Summary

A static class that provides access to the property names that appear in the PlasticVinyl visual asset schema.

#### Since

2018.1

### `T:Autodesk.Revit.DB.PlanViewRangeLevel`

Member kind: type
Symbol: `Autodesk.Revit.DB.PlanViewRangeLevel`

#### Summary

An enumerated type representing the options for setting the range for a plan view.

#### Since

2013

### `F:Autodesk.Revit.DB.PlanViewRangeLevel.Below`

Member kind: field
Symbol: `Autodesk.Revit.DB.PlanViewRangeLevel.Below`

#### Summary

View range is the level below

### `F:Autodesk.Revit.DB.PlanViewRangeLevel.Current`

Member kind: field
Symbol: `Autodesk.Revit.DB.PlanViewRangeLevel.Current`

#### Summary

View range is the current level

### `F:Autodesk.Revit.DB.PlanViewRangeLevel.Above`

Member kind: field
Symbol: `Autodesk.Revit.DB.PlanViewRangeLevel.Above`

#### Summary

View range is the level above

### `F:Autodesk.Revit.DB.PlanViewRangeLevel.Unlimited`

Member kind: field
Symbol: `Autodesk.Revit.DB.PlanViewRangeLevel.Unlimited`

#### Summary

View range is unlimited

### `M:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryData.GetFamilyInstanceId`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryData.GetFamilyInstanceId`

#### Summary

Gets the Id of the fiting or accessory instance

#### Returns

The element Id of the fiting or accessory instance.

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryData.GetAllConnectorData`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryData.GetAllConnectorData`

#### Summary

Gets the connector data of the pipe fitting or pipe accessory.

#### Remarks

PipeFittingAndAccessoryConnectorData contains connector data which is needed to calculate coefficient.
such as width, height, diameter and flow.

#### Returns

All connector data.

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryData.GetEntity`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryData.GetEntity`

#### Summary

Returns an Entity of the Schema of the serverGUID.

#### Remarks

The Entity that is returned is a copy of the stored data (with copy-on-write optimization).
Modifying it is allowed (even with restricted write), but to save your changes you must call SetEntity.

#### Returns

The Entity.

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryData.FluidDensity`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryData.FluidDensity`

#### Summary

The fluid density of the pipe fitting or pipe accessory, Units: (kg/ftÂ³).

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryData.FluidViscosity`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryData.FluidViscosity`

#### Summary

The fluid dynamic viscosity of the pipe fitting or pipe accessory, Units: (kg/(ftÂ·s)).

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryData.Origin`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryData.Origin`

#### Summary

The origin position of the pipe fitting or pipe accessory.

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryData.SystemClassification`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryData.SystemClassification`

#### Summary

The system classification of the pipe fitting or pipe accessory.

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryData.BehaviorType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryData.BehaviorType`

#### Summary

The behavior type of the pipe fitting or pipe accessory.

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryData.PartType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryData.PartType`

#### Summary

The part type of the pipe fitting or pipe accessory.

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryData.ServerGUID`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryData.ServerGUID`

#### Summary

The GUID of the pipe fitting or pipe accessory.

#### Since

2014

### `T:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryData`

#### Summary

The input data used by external servers for calculation of the pipe fitting and pipe accessory coefficient.

#### Remarks

A FamilyInstance is the input data for the calculation,
and the result is coefficient for each connector.

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryConnectorData.GetCoordination`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryConnectorData.GetCoordination`

#### Summary

Gets the coordination of the connector

#### Returns

The coordination of the connector

#### Since

2017

### `P:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryConnectorData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryConnectorData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryConnectorData.Profile`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryConnectorData.Profile`

#### Summary

The connector profile.

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryConnectorData.VelocityPressure`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryConnectorData.VelocityPressure`

#### Summary

The connector velocity pressure. Units: (kg/(ftÂ·sÂ²)).

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryConnectorData.Flow`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryConnectorData.Flow`

#### Summary

The connector flow, Units:(ftÂ³/s)

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryConnectorData.FlowDirection`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryConnectorData.FlowDirection`

#### Summary

The flow direction of this connector, In or Out.

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryConnectorData.LinkIndex`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryConnectorData.LinkIndex`

#### Summary

The index of the connector which is linked with this connector

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryConnectorData.Index`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryConnectorData.Index`

#### Summary

Return the index of this connector

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryConnectorData.Angle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryConnectorData.Angle`

#### Summary

The angle of the fitting, Units:(rad).

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryConnectorData.Diameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryConnectorData.Diameter`

#### Summary

The connector diameter, Units:(ft).

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryConnectorData.Height`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryConnectorData.Height`

#### Summary

The connector height, Units:(ft).

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryConnectorData.Width`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryConnectorData.Width`

#### Summary

The connector width, Units:(ft).

#### Since

2014

### `T:Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryConnectorData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Plumbing.PipeFittingAndAccessoryConnectorData`

#### Summary

The input data used by external servers for calculation of the pipe fitting and pipe accessory coefficient.

#### Remarks

width, height, diameter, flow, velocity pressure and connector index are input data for the calculation,

#### Since

2014

### `P:Autodesk.Revit.DB.Lighting.PhotometricWebLightDistribution.TiltAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Lighting.PhotometricWebLightDistribution.TiltAngle`

#### Summary

The tilt angle.

#### Value

The tilt angle as a numerical value in degrees between -180.0 and 180.0.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The angle is not valid because it is not between -180.0 and 180.0.

#### Since

2013

### `P:Autodesk.Revit.DB.Lighting.PhotometricWebLightDistribution.PhotometricWebFile`

Member kind: property
Symbol: `Autodesk.Revit.DB.Lighting.PhotometricWebLightDistribution.PhotometricWebFile`

#### Summary

The filename of an IES photometric web file.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.PhotometricWebLightDistribution.#ctor(Autodesk.Revit.DB.Lighting.PhotometricWebLightDistribution)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.PhotometricWebLightDistribution.#ctor(Autodesk.Revit.DB.Lighting.PhotometricWebLightDistribution)`

#### Summary

Creates a copy of the given photometric web light distribution

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.PhotometricWebLightDistribution.#ctor(System.String,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.PhotometricWebLightDistribution.#ctor(System.String,System.Double)`

#### Summary

Creates a photometric web light distribution object with the given filename and tilt.

#### Parameter `photometricWebFile`

The filename of the IES file to use.

#### Parameter `tiltAngle`

The tilt angle as a numerical value in degrees between -180.0 and 180.0.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The angle is not valid because it is not between -180.0 and 180.0.

#### Since

2013

### `T:Autodesk.Revit.DB.Lighting.PhotometricWebLightDistribution`

Member kind: type
Symbol: `Autodesk.Revit.DB.Lighting.PhotometricWebLightDistribution`

#### Summary

This class encapsulates a photometric web light distribution.

#### Since

2013

### `M:Autodesk.Revit.DB.PhaseFilter.Create(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PhaseFilter.Create(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Creates a new phase filter with default status presentation.

#### Remarks

The default status presentation is ShowByCategory for New status, and ShowOverriden for Existing,
Demolished and Temporary statuses.

#### Parameter `document`

The document.

#### Parameter `name`

The name.

#### Returns

The newly created phase filter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

name is already in use.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.PhaseFilter.SetPhaseStatusPresentation(Autodesk.Revit.DB.ElementOnPhaseStatus,Autodesk.Revit.DB.PhaseStatusPresentation)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PhaseFilter.SetPhaseStatusPresentation(Autodesk.Revit.DB.ElementOnPhaseStatus,Autodesk.Revit.DB.PhaseStatusPresentation)`

#### Summary

Sets the phase status presentation.

#### Parameter `status`

The element phase status.

#### Parameter `presentation`

The phase status presentation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

status is invalid for presentation query.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `M:Autodesk.Revit.DB.PhaseFilter.GetPhaseStatusPresentation(Autodesk.Revit.DB.ElementOnPhaseStatus)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PhaseFilter.GetPhaseStatusPresentation(Autodesk.Revit.DB.ElementOnPhaseStatus)`

#### Summary

Gets the phase status presentation.

#### Parameter `status`

The element phase status.

#### Returns

The phase status presentation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

status is invalid for presentation query.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.PhaseFilter.IsDefault`

Member kind: property
Symbol: `Autodesk.Revit.DB.PhaseFilter.IsDefault`

#### Summary

Indicates whether this filter is the default one.

#### Since

2013

### `T:Autodesk.Revit.DB.PhaseFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.PhaseFilter`

#### Summary

Represents an phase filter within Autodesk Revit.

#### Since

2013

### `T:Autodesk.Revit.DB.PhaseStatusPresentation`

Member kind: type
Symbol: `Autodesk.Revit.DB.PhaseStatusPresentation`

#### Summary

An enumerated type listing the options for element display in a phase filter.

#### Since

2013

### `F:Autodesk.Revit.DB.PhaseStatusPresentation.ShowOverriden`

Member kind: field
Symbol: `Autodesk.Revit.DB.PhaseStatusPresentation.ShowOverriden`

#### Summary

Show elements from the given phase status by graphics overrides.

### `F:Autodesk.Revit.DB.PhaseStatusPresentation.ShowByCategory`

Member kind: field
Symbol: `Autodesk.Revit.DB.PhaseStatusPresentation.ShowByCategory`

#### Summary

Show elements from the given phase status by category.

### `F:Autodesk.Revit.DB.PhaseStatusPresentation.DontShow`

Member kind: field
Symbol: `Autodesk.Revit.DB.PhaseStatusPresentation.DontShow`

#### Summary

Don't show elements from the given phase status.

### `T:Autodesk.Revit.DB.PerformanceAdviserRules`

Member kind: type
Symbol: `Autodesk.Revit.DB.PerformanceAdviserRules`

#### Summary

Provides a container of all Revit built-in PerformanceAdviserRuleId instances.

### `M:Autodesk.Revit.DB.PerformanceAdviserRuleId.op_Inequality(Autodesk.Revit.DB.PerformanceAdviserRuleId,Autodesk.Revit.DB.PerformanceAdviserRuleId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PerformanceAdviserRuleId.op_Inequality(Autodesk.Revit.DB.PerformanceAdviserRuleId,Autodesk.Revit.DB.PerformanceAdviserRuleId)`

#### Summary

Compares two PerformanceAdviserRuleId instances.

#### Parameter `first`

The first PerformanceAdviserRuleId.

#### Parameter `second`

The second PerformanceAdviserRuleId.

#### Returns

True if the inputs are different, false if they are identical.

### `M:Autodesk.Revit.DB.PerformanceAdviserRuleId.op_Equality(Autodesk.Revit.DB.PerformanceAdviserRuleId,Autodesk.Revit.DB.PerformanceAdviserRuleId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PerformanceAdviserRuleId.op_Equality(Autodesk.Revit.DB.PerformanceAdviserRuleId,Autodesk.Revit.DB.PerformanceAdviserRuleId)`

#### Summary

Compares two PerformanceAdviserRuleId instances.

#### Parameter `first`

The first PerformanceAdviserRuleId.

#### Parameter `second`

The second PerformanceAdviserRuleId.

#### Returns

True if the inputs are identical, false if they are different.

### `M:Autodesk.Revit.DB.PerformanceAdviserRuleId.#ctor(System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PerformanceAdviserRuleId.#ctor(System.Guid)`

#### Summary

Creates a new PerformanceAdviserRuleId instance.

#### Parameter `guid`

The identifier for the PerformanceAdviserRuleId.

### `T:Autodesk.Revit.DB.PerformanceAdviserRuleId`

Member kind: type
Symbol: `Autodesk.Revit.DB.PerformanceAdviserRuleId`

#### Summary

The unique identifier of a PerformanceAdviserRule

#### Remarks

Each performance adviser rule registered in application must be given a unique id
that can be used to identify and unregister rule later.

#### Since

2012

### `M:Autodesk.Revit.DB.IPerformanceAdviserRuleProxy.GetDescription`

Member kind: method
Symbol: `Autodesk.Revit.DB.IPerformanceAdviserRuleProxy.GetDescription`

#### Summary

Retrieves the description of the rule.

#### Remarks

Method should return a brief (one-two sentences) description of the rule. String should be localized.

#### Returns

The description of the rule.

#### Since

2012

### `M:Autodesk.Revit.DB.IPerformanceAdviserRuleProxy.GetName`

Member kind: method
Symbol: `Autodesk.Revit.DB.IPerformanceAdviserRuleProxy.GetName`

#### Summary

Retrieves the name of the rule.

#### Remarks

Method should return a short string naming the rule, typically as a one word in TitleCase. String should be localized.

#### Returns

The name of the rule.

#### Since

2012

### `M:Autodesk.Revit.DB.IPerformanceAdviserRuleProxy.GetElementFilter(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IPerformanceAdviserRuleProxy.GetElementFilter(Autodesk.Revit.DB.Document)`

#### Summary

Retrieves a filter to restrict elements to be checked.

#### Remarks

If the rule needs to be executed on individual elements,
it should return a filter that defines what elements the rule should apply to.
Otherwise, nothing (i.e. null) should be returned.
If filter is returned, it should stay valid till the end of the check.

#### Parameter `document`

Document for which performance problems are being checked.

#### Returns

The filter to restrict elements to be checked.

#### Since

2012

### `M:Autodesk.Revit.DB.IPerformanceAdviserRuleProxy.WillCheckElements`

Member kind: method
Symbol: `Autodesk.Revit.DB.IPerformanceAdviserRuleProxy.WillCheckElements`

#### Summary

Reports if rule needs to be executed on individual elements.

#### Returns

True if rule needs to be executed on individual elements.

#### Since

2012

### `M:Autodesk.Revit.DB.IPerformanceAdviserRuleProxy.ExecuteElementCheck(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IPerformanceAdviserRuleProxy.ExecuteElementCheck(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element)`

#### Summary

Invoked by performance advisor for each element to be checked.

#### Parameter `document`

Document for which performance problems are being checked.

#### Parameter `element`

The Element being checked for performance problems.

#### Since

2012

### `M:Autodesk.Revit.DB.IPerformanceAdviserRuleProxy.FinalizeCheck(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IPerformanceAdviserRuleProxy.FinalizeCheck(Autodesk.Revit.DB.Document)`

#### Summary

Invoked by performance advisor once in the end of the check.

#### Parameter `document`

Document for which performance problems are being checked.

#### Since

2012

### `M:Autodesk.Revit.DB.IPerformanceAdviserRuleProxy.InitCheck(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IPerformanceAdviserRuleProxy.InitCheck(Autodesk.Revit.DB.Document)`

#### Summary

Invoked by performance advisor once in the beginning of the check. If rule checks document as a whole,
the check can be performed in this method.

#### Parameter `document`

Document for which performance problems are being checked.

#### Since

2012

### `M:Autodesk.Revit.DB.IPerformanceAdviserRule.GetDescription`

Member kind: method
Symbol: `Autodesk.Revit.DB.IPerformanceAdviserRule.GetDescription`

#### Summary

Retrieves the description of the rule.

#### Remarks

Method should return a brief (one-two sentences) description of the rule. String should be localized.

#### Returns

The description of the rule.

#### Since

2012

### `M:Autodesk.Revit.DB.IPerformanceAdviserRule.GetName`

Member kind: method
Symbol: `Autodesk.Revit.DB.IPerformanceAdviserRule.GetName`

#### Summary

Retrieves the name of the rule.

#### Remarks

Method should return a short string naming the rule, typically as a one word in TitleCase. String should be localized.

#### Returns

The name of the rule.

#### Since

2012

### `M:Autodesk.Revit.DB.IPerformanceAdviserRule.GetElementFilter(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IPerformanceAdviserRule.GetElementFilter(Autodesk.Revit.DB.Document)`

#### Summary

Retrieves a filter to restrict elements to be checked.

#### Remarks

If the rule needs to be executed on individual elements,
it should return a filter that defines what elements the rule should apply to.
Otherwise, nothing (i.e. null) should be returned.
If filter is returned, it should stay valid till the end of the check.

#### Parameter `document`

Document for which performance problems are being checked.

#### Returns

The filter to restrict elements to be checked.

#### Since

2012

### `M:Autodesk.Revit.DB.IPerformanceAdviserRule.WillCheckElements`

Member kind: method
Symbol: `Autodesk.Revit.DB.IPerformanceAdviserRule.WillCheckElements`

#### Summary

Reports if rule needs to be executed on individual elements.

#### Returns

True if rule needs to be executed on individual elements.

#### Since

2012

### `M:Autodesk.Revit.DB.IPerformanceAdviserRule.ExecuteElementCheck(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IPerformanceAdviserRule.ExecuteElementCheck(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element)`

#### Summary

Invoked by performance advisor for each element to be checked.

#### Parameter `document`

Document for which performance problems are being checked.

#### Parameter `element`

The Element being checked for performance problems.

#### Since

2012

### `M:Autodesk.Revit.DB.IPerformanceAdviserRule.FinalizeCheck(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IPerformanceAdviserRule.FinalizeCheck(Autodesk.Revit.DB.Document)`

#### Summary

Invoked by performance advisor once in the end of the check.

#### Parameter `document`

Document for which performance problems are being checked.

#### Since

2012
