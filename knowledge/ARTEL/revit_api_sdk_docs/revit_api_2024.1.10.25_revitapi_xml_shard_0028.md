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
Shard: 28
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `M:Autodesk.Revit.DB.ElementArrayIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementArrayIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.ElementArrayIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementArrayIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the array.

#### Remarks

The Reset method will return the iterator back to the start of the array in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.ElementArrayIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementArrayIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.ElementArray.Insert(Autodesk.Revit.DB.Element,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementArray.Insert(Autodesk.Revit.DB.Element,System.Int32)`

#### Returntype

System.Int32

#### Summary

Insert the specified element into the array.

#### Parameter `item`

The element to be inserted into the array.

#### Parameter `index`

The element will be inserted before this index.

#### Returns

Returns whether the element was inserted into the array.

### `M:Autodesk.Revit.DB.ElementArray.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementArray.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.ElementArray.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementArray.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.ElementArrayIterator

#### Summary

Retrieve a backward moving iterator to the array.

#### Returns

Returns a backward moving iterator to the array.

### `M:Autodesk.Revit.DB.ElementArray.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementArray.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.ElementArrayIterator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.ElementArray.Append(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementArray.Append(Autodesk.Revit.DB.Element)`

#### Returntype

void

#### Summary

Add the element to the end of the array.

#### Parameter `item`

The element to be added.

### `M:Autodesk.Revit.DB.ElementArray.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementArray.Clear`

#### Returntype

void

#### Summary

Removes every element from the array, rendering it empty.

### `P:Autodesk.Revit.DB.ElementArray.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementArray.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of elements that are in the array.

### `P:Autodesk.Revit.DB.ElementArray.Item(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementArray.Item(System.Int32)`

#### Returntype

Autodesk.Revit.DB.Element

#### Summary

Gets or sets an element at a specified index within the array.

#### Parameter `index`

The index of the element to be set or retrieved.

#### Returns

Returns the element at the specified index.

### `P:Autodesk.Revit.DB.ElementArray.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementArray.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the array is empty.

#### Remarks

If the array is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.DocumentSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.DocumentSetIterator`

#### Summary

An iterator to a set of documents.

### `T:Autodesk.Revit.DB.DocumentSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.DocumentSet`

#### Summary

A set that can contain any documents.

### `P:Autodesk.Revit.DB.DocumentSetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.DocumentSetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.DocumentSetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.DocumentSetIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.DocumentSetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.DocumentSetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.DocumentSetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.DocumentSetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.DocumentSet.Insert(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DocumentSet.Insert(Autodesk.Revit.DB.Document)`

#### Returntype

System.Int32

#### Summary

Insert the specified item into the set.

#### Parameter `item`

The item to be inserted into the set.

#### Returns

Returns whether the item was inserted into the set.

### `M:Autodesk.Revit.DB.DocumentSet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.DocumentSet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.DocumentSet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.DocumentSet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.DocumentSetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.DocumentSet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.DocumentSet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.DocumentSetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.DocumentSet.Erase(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DocumentSet.Erase(Autodesk.Revit.DB.Document)`

#### Returntype

System.Int32

#### Summary

Removes a specified object from the set.

#### Parameter `item`

The item to be erased.

#### Returns

The number of items that were erased from the set.

### `M:Autodesk.Revit.DB.DocumentSet.Contains(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DocumentSet.Contains(Autodesk.Revit.DB.Document)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of an item within the set.

#### Parameter `item`

The item to be searched for.

#### Returns

The Contains method returns True if the item is within the set, otherwise False.

### `M:Autodesk.Revit.DB.DocumentSet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.DocumentSet.Clear`

#### Returntype

void

#### Summary

Removes every item from the set, rendering it empty.

### `P:Autodesk.Revit.DB.DocumentSet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.DocumentSet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of objects that are in the set.

### `P:Autodesk.Revit.DB.DocumentSet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.DocumentSet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.Electrical.DistributionSysTypeSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.DistributionSysTypeSetIterator`

#### Summary

An iterator to a DistributionSys type set.

### `T:Autodesk.Revit.DB.Electrical.DistributionSysTypeSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.DistributionSysTypeSet`

#### Summary

A set that contains DistributionSys types.

### `P:Autodesk.Revit.DB.Electrical.DistributionSysTypeSetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.DistributionSysTypeSetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.Electrical.DistributionSysTypeSetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.DistributionSysTypeSetIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.Electrical.DistributionSysTypeSetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.DistributionSysTypeSetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.Electrical.DistributionSysTypeSetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.DistributionSysTypeSetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.Electrical.DistributionSysTypeSet.Insert(Autodesk.Revit.DB.Electrical.DistributionSysType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.DistributionSysTypeSet.Insert(Autodesk.Revit.DB.Electrical.DistributionSysType)`

#### Returntype

System.Int32

#### Summary

Insert the specified DistributionSys type into the set.

#### Parameter `item`

The DistributionSys type to be inserted into the set.

#### Returns

Returns whether the DistributionSys type was inserted into the set.

### `M:Autodesk.Revit.DB.Electrical.DistributionSysTypeSet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.DistributionSysTypeSet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.Electrical.DistributionSysTypeSet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.DistributionSysTypeSet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.Electrical.DistributionSysTypeSetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.Electrical.DistributionSysTypeSet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.DistributionSysTypeSet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.Electrical.DistributionSysTypeSetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.Electrical.DistributionSysTypeSet.Erase(Autodesk.Revit.DB.Electrical.DistributionSysType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.DistributionSysTypeSet.Erase(Autodesk.Revit.DB.Electrical.DistributionSysType)`

#### Returntype

System.Int32

#### Summary

Removes a specified DistributionSys type from the set.

#### Parameter `item`

The DistributionSys type to be erased.

#### Returns

The number of DistributionSys types that were erased from the set.

### `M:Autodesk.Revit.DB.Electrical.DistributionSysTypeSet.Contains(Autodesk.Revit.DB.Electrical.DistributionSysType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.DistributionSysTypeSet.Contains(Autodesk.Revit.DB.Electrical.DistributionSysType)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of a DistributionSys type within the set.

#### Parameter `item`

The DistributionSys type to be searched for.

#### Returns

The Contains method returns True if the DistributionSys type is within the set, otherwise False.

### `M:Autodesk.Revit.DB.Electrical.DistributionSysTypeSet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.DistributionSysTypeSet.Clear`

#### Returntype

void

#### Summary

Removes every DistributionSys type from the set, rendering it empty.

### `P:Autodesk.Revit.DB.Electrical.DistributionSysTypeSet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.DistributionSysTypeSet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of DistributionSys types that are in the set.

### `P:Autodesk.Revit.DB.Electrical.DistributionSysTypeSet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.DistributionSysTypeSet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.DimensionSegmentArrayIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.DimensionSegmentArrayIterator`

#### Summary

An iterator to an array of DimensionSegment objects..

### `T:Autodesk.Revit.DB.DimensionSegmentArray`

Member kind: type
Symbol: `Autodesk.Revit.DB.DimensionSegmentArray`

#### Summary

An array that can contain any number of DimensionSegment objects.

### `P:Autodesk.Revit.DB.DimensionSegmentArrayIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.DimensionSegmentArrayIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.DimensionSegmentArrayIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.DimensionSegmentArrayIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.DimensionSegmentArrayIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.DimensionSegmentArrayIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the array.

#### Remarks

The Reset method will return the iterator back to the start of the array in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.DimensionSegmentArrayIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.DimensionSegmentArrayIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.DimensionSegmentArray.Insert(Autodesk.Revit.DB.DimensionSegment,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DimensionSegmentArray.Insert(Autodesk.Revit.DB.DimensionSegment,System.Int32)`

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

### `M:Autodesk.Revit.DB.DimensionSegmentArray.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.DimensionSegmentArray.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.DimensionSegmentArray.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.DimensionSegmentArray.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.DimensionSegmentArrayIterator

#### Summary

Retrieve a backward moving iterator to the array.

#### Returns

Returns a backward moving iterator to the array.

### `M:Autodesk.Revit.DB.DimensionSegmentArray.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.DimensionSegmentArray.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.DimensionSegmentArrayIterator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.DimensionSegmentArray.Append(Autodesk.Revit.DB.DimensionSegment)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DimensionSegmentArray.Append(Autodesk.Revit.DB.DimensionSegment)`

#### Returntype

void

#### Summary

Add the item to the end of the array.

#### Parameter `item`

The item to be added.

### `M:Autodesk.Revit.DB.DimensionSegmentArray.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.DimensionSegmentArray.Clear`

#### Returntype

void

#### Summary

Removes every item from the array, rendering it empty.

### `P:Autodesk.Revit.DB.DimensionSegmentArray.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.DimensionSegmentArray.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of objects that are in the array.

### `P:Autodesk.Revit.DB.DimensionSegmentArray.Item(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.DimensionSegmentArray.Item(System.Int32)`

#### Returntype

System.Object

#### Summary

Gets or sets an item at a specified index within the array.

#### Parameter `index`

The index of the item to be set or retrieved.

#### Returns

Returns the object at the specified index.

### `P:Autodesk.Revit.DB.DimensionSegmentArray.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.DimensionSegmentArray.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the array is empty.

#### Remarks

If the array is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.DetailCurveArrayIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.DetailCurveArrayIterator`

#### Summary

An iterator to a array.

### `T:Autodesk.Revit.DB.DetailCurveArray`

Member kind: type
Symbol: `Autodesk.Revit.DB.DetailCurveArray`

#### Summary

An array that can contain any type of object.

### `P:Autodesk.Revit.DB.DetailCurveArrayIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.DetailCurveArrayIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.DetailCurveArrayIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.DetailCurveArrayIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.DetailCurveArrayIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.DetailCurveArrayIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the array.

#### Remarks

The Reset method will return the iterator back to the start of the array in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.DetailCurveArrayIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.DetailCurveArrayIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.DetailCurveArray.Insert(System.Object,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DetailCurveArray.Insert(System.Object,System.Int32)`

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

### `M:Autodesk.Revit.DB.DetailCurveArray.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.DetailCurveArray.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.DetailCurveArray.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.DetailCurveArray.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.DetailCurveArrayIterator

#### Summary

Retrieve a backward moving iterator to the array.

#### Returns

Returns a backward moving iterator to the array.

### `M:Autodesk.Revit.DB.DetailCurveArray.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.DetailCurveArray.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.DetailCurveArrayIterator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.DetailCurveArray.Append(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DetailCurveArray.Append(System.Object)`

#### Returntype

void

#### Summary

Add the item to the end of the array.

#### Parameter `item`

The item to be added.

### `M:Autodesk.Revit.DB.DetailCurveArray.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.DetailCurveArray.Clear`

#### Returntype

void

#### Summary

Removes every item from the array, rendering it empty.

### `P:Autodesk.Revit.DB.DetailCurveArray.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.DetailCurveArray.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of objects that are in the array.

### `P:Autodesk.Revit.DB.DetailCurveArray.Item(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.DetailCurveArray.Item(System.Int32)`

#### Returntype

System.Object

#### Summary

Gets or sets an item at a specified index within the array.

#### Parameter `index`

The index of the item to be set or retrieved.

#### Returns

Returns the object at the specified index.

### `P:Autodesk.Revit.DB.DetailCurveArray.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.DetailCurveArray.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the array is empty.

#### Remarks

If the array is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.DefinitionBindingMapIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.DefinitionBindingMapIterator`

#### Summary

An iterator to a parameter definition to parameter bindings map.

### `T:Autodesk.Revit.DB.DefinitionBindingMap`

Member kind: type
Symbol: `Autodesk.Revit.DB.DefinitionBindingMap`

#### Summary

A map that contains mappings of parameter definitions to parameter bindings.

### `P:Autodesk.Revit.DB.DefinitionBindingMapIterator.Key`

Member kind: property
Symbol: `Autodesk.Revit.DB.DefinitionBindingMapIterator.Key`

#### Returntype

Autodesk::Revit::Parameters::Definition

#### Proptype

get

#### Summary

Retrieves the definition that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
key as per expected behavior of IEnumerator.

### `P:Autodesk.Revit.DB.DefinitionBindingMapIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.DefinitionBindingMapIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the binding that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.DefinitionBindingMapIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.DefinitionBindingMapIterator.MoveNext`

#### Returntype

System.Boolean

#### Summary

Move the iterator one item forward.

#### Returns

Returns True if the iterator was successfully moved forward one item and the Current
property will return a valid item. False will be returned it the iterator has reached the end of
the map.

#### Remarks

MoveNext must be called before the Current property is valid with a new or Reset iterator
in line with the expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.DefinitionBindingMapIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.DefinitionBindingMapIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the map.

#### Remarks

The Reset method will return the iterator back to the start of the map in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.DefinitionBindingMapIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.DefinitionBindingMapIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.DefinitionBindingMap.Insert(Autodesk.Revit.Parameters.Definition,Autodesk.Revit.Parameters.Binding)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DefinitionBindingMap.Insert(Autodesk.Revit.Parameters.Definition,Autodesk.Revit.Parameters.Binding)`

#### Returntype

System.Int32

#### Summary

Insert the specified binding with the specified definition into the map.

#### Parameter `key`

The definition to be used for inserting the binding into the map.

#### Parameter `item`

The binding to be inserted into the map.

#### Returns

Returns whether the binding was inserted into the map.

### `M:Autodesk.Revit.DB.DefinitionBindingMap.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.DefinitionBindingMap.GetEnumerator`

#### Returntype

System.DB.IEnumerator

#### Summary

Retrieve a forward moving iterator to the map.

#### Returns

Returns a forward moving iterator to the map.

### `M:Autodesk.Revit.DB.DefinitionBindingMap.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.DefinitionBindingMap.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.DefinitionBindingMapIterator

#### Summary

Retrieve a backward moving iterator to the map.

#### Returns

Returns a backward moving iterator to the map.

### `M:Autodesk.Revit.DB.DefinitionBindingMap.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.DefinitionBindingMap.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.DefinitionBindingMapIterator

#### Summary

Retrieve a forward moving iterator to the map.

#### Returns

Returns a forward moving iterator to the map.

### `M:Autodesk.Revit.DB.DefinitionBindingMap.Erase(Autodesk.Revit.Parameters.Definition)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DefinitionBindingMap.Erase(Autodesk.Revit.Parameters.Definition)`

#### Returntype

System.Int32

#### Summary

Removes a binding with the specified definition from the map.

#### Parameter `key`

The definition of the binding to be erased.

#### Returns

The number of bindings that were erased from the map.

### `M:Autodesk.Revit.DB.DefinitionBindingMap.Contains(Autodesk.Revit.Parameters.Definition)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DefinitionBindingMap.Contains(Autodesk.Revit.Parameters.Definition)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of a definition within the map.

#### Parameter `key`

The definition to be searched for.

#### Returns

The Contains method returns True if the definition is within the map, otherwise False.

### `M:Autodesk.Revit.DB.DefinitionBindingMap.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.DefinitionBindingMap.Clear`

#### Returntype

void

#### Summary

Removes every binding from the map, rendering it empty.

### `P:Autodesk.Revit.DB.DefinitionBindingMap.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.DefinitionBindingMap.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of bindings that are in the map.

### `P:Autodesk.Revit.DB.DefinitionBindingMap.Item(Autodesk.Revit.Parameters.Definition)`

Member kind: property
Symbol: `Autodesk.Revit.DB.DefinitionBindingMap.Item(Autodesk.Revit.Parameters.Definition)`

#### Returntype

Autodesk.Revit.Parameters.Binding

#### Summary

Gets or sets a parameter binding for a specified parameter definition within the map.

#### Parameter `key`

The parameter definition of the binding to be set or retrieved.

#### Returns

Returns the binding for the specified definition.

### `P:Autodesk.Revit.DB.DefinitionBindingMap.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.DefinitionBindingMap.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the map is empty.

#### Remarks

If the map is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.CurveByPointsArrayIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.CurveByPointsArrayIterator`

#### Summary

An iterator to a CurveByPoints array.

### `T:Autodesk.Revit.DB.CurveByPointsArray`

Member kind: type
Symbol: `Autodesk.Revit.DB.CurveByPointsArray`

#### Summary

An array that can contain CurveByPoints elements.

### `P:Autodesk.Revit.DB.CurveByPointsArrayIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurveByPointsArrayIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.CurveByPointsArrayIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveByPointsArrayIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.CurveByPointsArrayIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveByPointsArrayIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the array.

#### Remarks

The Reset method will return the iterator back to the start of the array in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.CurveByPointsArrayIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveByPointsArrayIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.CurveByPointsArray.Insert(Autodesk.Revit.DB.Curve,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveByPointsArray.Insert(Autodesk.Revit.DB.Curve,System.Int32)`

#### Returntype

System.Int32

#### Summary

Insert the specified curve into the array.

#### Parameter `item`

The curve to be inserted into the array.

#### Parameter `index`

The curve will be inserted before this index.

#### Returns

Returns whether the curve was inserted into the array.

### `M:Autodesk.Revit.DB.CurveByPointsArray.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveByPointsArray.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.CurveByPointsArray.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveByPointsArray.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.CurveByPointsArrayIterator

#### Summary

Retrieve a backward moving iterator to the array.

#### Returns

Returns a backward moving iterator to the array.

### `M:Autodesk.Revit.DB.CurveByPointsArray.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveByPointsArray.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.CurveByPointsArrayIterator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.CurveByPointsArray.Append(Autodesk.Revit.DB.Curve)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveByPointsArray.Append(Autodesk.Revit.DB.Curve)`

#### Returntype

void

#### Summary

Add the curve to the end of the array.

#### Parameter `item`

The curve to be added.

### `M:Autodesk.Revit.DB.CurveByPointsArray.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveByPointsArray.Clear`

#### Returntype

void

#### Summary

Removes every curve from the array, rendering it empty.

### `P:Autodesk.Revit.DB.CurveByPointsArray.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurveByPointsArray.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of curves that are in the array.

### `P:Autodesk.Revit.DB.CurveByPointsArray.Item(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurveByPointsArray.Item(System.Int32)`

#### Returntype

System.Object

#### Summary

Gets or sets a curve at a specified index within the array.

#### Parameter `index`

The index of the curve to be set or retrieved.

#### Returns

Returns the curve at the specified index.

### `P:Autodesk.Revit.DB.CurveByPointsArray.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurveByPointsArray.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the array is empty.

#### Remarks

If the array is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.CurveArrayIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.CurveArrayIterator`

#### Summary

An iterator to a curve array.

### `T:Autodesk.Revit.DB.CurveArray`

Member kind: type
Symbol: `Autodesk.Revit.DB.CurveArray`

#### Summary

An array that can contain curves.

### `P:Autodesk.Revit.DB.CurveArrayIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurveArrayIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.CurveArrayIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveArrayIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.CurveArrayIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveArrayIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the array.

#### Remarks

The Reset method will return the iterator back to the start of the array in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.CurveArrayIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveArrayIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.CurveArray.Insert(Autodesk.Revit.DB.Curve,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveArray.Insert(Autodesk.Revit.DB.Curve,System.Int32)`

#### Returntype

System.Int32

#### Summary

Insert the specified curve into the array.

#### Parameter `item`

The curve to be inserted into the array.

#### Parameter `index`

The curve will be inserted before this index.

#### Returns

Returns whether the curve was inserted into the array.

### `M:Autodesk.Revit.DB.CurveArray.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveArray.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.CurveArray.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveArray.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.CurveArrayIterator

#### Summary

Retrieve a backward moving iterator to the array.

#### Returns

Returns a backward moving iterator to the array.

### `M:Autodesk.Revit.DB.CurveArray.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveArray.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.CurveArrayIterator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.CurveArray.Append(Autodesk.Revit.DB.Curve)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveArray.Append(Autodesk.Revit.DB.Curve)`

#### Returntype

void

#### Summary

Add the curve to the end of the array.

#### Parameter `item`

The curve to be added.

### `M:Autodesk.Revit.DB.CurveArray.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveArray.Clear`

#### Returntype

void

#### Summary

Removes every curve from the array, rendering it empty.

### `P:Autodesk.Revit.DB.CurveArray.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurveArray.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of curves that are in the array.

### `P:Autodesk.Revit.DB.CurveArray.Item(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurveArray.Item(System.Int32)`

#### Returntype

System.Object

#### Summary

Gets or sets a curve at a specified index within the array.

#### Parameter `index`

The index of the curve to be set or retrieved.

#### Returns

Returns the curve at the specified index.

### `P:Autodesk.Revit.DB.CurveArray.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurveArray.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the array is empty.

#### Remarks

If the array is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.CurtainGridSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.CurtainGridSetIterator`

#### Summary

An iterator to a set.

### `T:Autodesk.Revit.DB.CurtainGridSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.CurtainGridSet`

#### Summary

A set that can contain any type of object.

### `P:Autodesk.Revit.DB.CurtainGridSetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurtainGridSetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.CurtainGridSetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurtainGridSetIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.CurtainGridSetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurtainGridSetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.CurtainGridSetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurtainGridSetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.CurtainGridSet.Insert(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurtainGridSet.Insert(System.Object)`

#### Returntype

System.Int32

#### Summary

Insert the specified item into the set.

#### Parameter `item`

The item to be inserted into the set.

#### Returns

Returns whether the item was inserted into the set.

### `M:Autodesk.Revit.DB.CurtainGridSet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurtainGridSet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.CurtainGridSet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurtainGridSet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.CurtainGridSetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.CurtainGridSet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurtainGridSet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.CurtainGridSetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.CurtainGridSet.Erase(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurtainGridSet.Erase(System.Object)`

#### Returntype

System.Int32

#### Summary

Removes a specified object from the set.

#### Parameter `item`

The item to be erased.

#### Returns

The number of items that were erased from the set.

### `M:Autodesk.Revit.DB.CurtainGridSet.Contains(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurtainGridSet.Contains(System.Object)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of an item within the set.

#### Parameter `item`

The item to be searched for.

#### Returns

The Contains method returns True if the item is within the set, otherwise False.

### `M:Autodesk.Revit.DB.CurtainGridSet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurtainGridSet.Clear`

#### Returntype

void

#### Summary

Removes every item from the set, rendering it empty.

### `P:Autodesk.Revit.DB.CurtainGridSet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurtainGridSet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of objects that are in the set.

### `P:Autodesk.Revit.DB.CurtainGridSet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurtainGridSet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.ConnectorSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.ConnectorSetIterator`

#### Summary

An iterator to a set.

### `T:Autodesk.Revit.DB.ConnectorSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.ConnectorSet`

#### Summary

A set that can contain any type of object.

### `P:Autodesk.Revit.DB.ConnectorSetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConnectorSetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.ConnectorSetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectorSetIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.ConnectorSetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectorSetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.ConnectorSetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectorSetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.ConnectorSet.Insert(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectorSet.Insert(System.Object)`

#### Returntype

System.Int32

#### Summary

Insert the specified item into the set.

#### Parameter `item`

The item to be inserted into the set.

#### Returns

Returns whether the item was inserted into the set.

### `M:Autodesk.Revit.DB.ConnectorSet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectorSet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.ConnectorSet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectorSet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.ConnectorSetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.ConnectorSet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectorSet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.ConnectorSetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.ConnectorSet.Erase(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectorSet.Erase(System.Object)`

#### Returntype

System.Int32

#### Summary

Removes a specified object from the set.

#### Parameter `item`

The item to be erased.

#### Returns

The number of items that were erased from the set.

### `M:Autodesk.Revit.DB.ConnectorSet.Contains(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectorSet.Contains(System.Object)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of an item within the set.

#### Parameter `item`

The item to be searched for.

#### Returns

The Contains method returns True if the item is within the set, otherwise False.

### `M:Autodesk.Revit.DB.ConnectorSet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.ConnectorSet.Clear`

#### Returntype

void

#### Summary

Removes every item from the set, rendering it empty.

### `P:Autodesk.Revit.DB.ConnectorSet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConnectorSet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of objects that are in the set.

### `P:Autodesk.Revit.DB.ConnectorSet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.ConnectorSet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.CombinableElementArrayIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.CombinableElementArrayIterator`

#### Summary

An iterator to an CombinableElement array.

### `T:Autodesk.Revit.DB.CombinableElementArray`

Member kind: type
Symbol: `Autodesk.Revit.DB.CombinableElementArray`

#### Summary

An array that contains CombinableElement objects.

### `P:Autodesk.Revit.DB.CombinableElementArrayIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.CombinableElementArrayIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.CombinableElementArrayIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.CombinableElementArrayIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.CombinableElementArrayIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.CombinableElementArrayIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the array.

#### Remarks

The Reset method will return the iterator back to the start of the array in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.CombinableElementArrayIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.CombinableElementArrayIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.CombinableElementArray.Insert(Autodesk.Revit.DB.CombinableElement,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CombinableElementArray.Insert(Autodesk.Revit.DB.CombinableElement,System.Int32)`

#### Returntype

System.Int32

#### Summary

Insert the specified element into the array.

#### Parameter `item`

The CombinableElement to be inserted into the array.

#### Parameter `index`

The CombinableElement will be inserted before this index.

#### Returns

Returns whether the CombinableElement was inserted into the array.

### `M:Autodesk.Revit.DB.CombinableElementArray.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.CombinableElementArray.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.CombinableElementArray.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.CombinableElementArray.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.CombinableElementArrayIterator

#### Summary

Retrieve a backward moving iterator to the array.

#### Returns

Returns a backward moving iterator to the array.

### `M:Autodesk.Revit.DB.CombinableElementArray.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.CombinableElementArray.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.CombinableElementArrayIterator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.CombinableElementArray.Append(Autodesk.Revit.DB.CombinableElement)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CombinableElementArray.Append(Autodesk.Revit.DB.CombinableElement)`

#### Returntype

void

#### Summary

Add the element to the end of the array.

#### Parameter `item`

The CombinableElement to be added.

### `M:Autodesk.Revit.DB.CombinableElementArray.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.CombinableElementArray.Clear`

#### Returntype

void

#### Summary

Removes every CombinableElement from the array, rendering it empty.

### `P:Autodesk.Revit.DB.CombinableElementArray.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.CombinableElementArray.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of CombinableElements that are in the array.

### `P:Autodesk.Revit.DB.CombinableElementArray.Item(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.CombinableElementArray.Item(System.Int32)`

#### Returntype

Autodesk.Revit.DB.CombinableElement

#### Summary

Gets or sets a CombinableElement at a specified index within the array.

#### Parameter `index`

The index of the CombinableElement to be set or retrieved.

#### Returns

Returns the CombinableElement at the specified index.

### `P:Autodesk.Revit.DB.CombinableElementArray.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.CombinableElementArray.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the array is empty.

#### Remarks

If the array is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.CategorySetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.CategorySetIterator`

#### Summary

An iterator to a category set.

### `T:Autodesk.Revit.DB.CategorySet`

Member kind: type
Symbol: `Autodesk.Revit.DB.CategorySet`

#### Summary

A set that can contains Category objects.

### `P:Autodesk.Revit.DB.CategorySetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.CategorySetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.CategorySetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.CategorySetIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.CategorySetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.CategorySetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.CategorySetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.CategorySetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.CategorySet.Insert(Autodesk.Revit.DB.Category)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CategorySet.Insert(Autodesk.Revit.DB.Category)`

#### Returntype

System.Int32

#### Summary

Insert the specified category into the set.

#### Parameter `item`

The item to be inserted into the set.

#### Returns

Returns whether the item was inserted into the set.

### `M:Autodesk.Revit.DB.CategorySet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.CategorySet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.CategorySet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.CategorySet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.CategorySetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.CategorySet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.CategorySet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.CategorySetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.CategorySet.Erase(Autodesk.Revit.DB.Category)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CategorySet.Erase(Autodesk.Revit.DB.Category)`

#### Returntype

System.Int32

#### Summary

Removes a specified category from the set.

#### Parameter `item`

The category to be erased.

#### Returns

The number of items that were erased from the set.

### `M:Autodesk.Revit.DB.CategorySet.Contains(Autodesk.Revit.DB.Category)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CategorySet.Contains(Autodesk.Revit.DB.Category)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of a category within the set.

#### Parameter `item`

The category to be searched for.

#### Returns

The Contains method returns True if the category is within the set, otherwise False.

### `M:Autodesk.Revit.DB.CategorySet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.CategorySet.Clear`

#### Returntype

void

#### Summary

Removes every item from the set, rendering it empty.

### `P:Autodesk.Revit.DB.CategorySet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.CategorySet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of categories that are in the set.

### `P:Autodesk.Revit.DB.CategorySet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.CategorySet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.CategoryNameMapIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.CategoryNameMapIterator`

#### Summary

An iterator to a category name map.

### `T:Autodesk.Revit.DB.CategoryNameMap`

Member kind: type
Symbol: `Autodesk.Revit.DB.CategoryNameMap`

#### Summary

A map that contains a mapping of category name to its category object.

### `P:Autodesk.Revit.DB.CategoryNameMapIterator.Key`

Member kind: property
Symbol: `Autodesk.Revit.DB.CategoryNameMapIterator.Key`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the category name that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
key as per expected behavior of IEnumerator.

### `P:Autodesk.Revit.DB.CategoryNameMapIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.CategoryNameMapIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the category that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.CategoryNameMapIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.CategoryNameMapIterator.MoveNext`

#### Returntype

System.Boolean

#### Summary

Move the iterator one item forward.

#### Returns

Returns True if the iterator was successfully moved forward one item and the Current
property will return a valid item. False will be returned it the iterator has reached the end of
the map.

#### Remarks

MoveNext must be called before the Current property is valid with a new or Reset iterator
in line with the expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.CategoryNameMapIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.CategoryNameMapIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the map.

#### Remarks

The Reset method will return the iterator back to the start of the map in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.CategoryNameMapIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.CategoryNameMapIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.CategoryNameMap.Insert(System.String,Autodesk.Revit.DB.Category)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CategoryNameMap.Insert(System.String,Autodesk.Revit.DB.Category)`

#### Returntype

System.Int32

#### Summary

Insert the specified category with the specified name into the map.

#### Parameter `key`

The name to be used for inserting the category into the map.

#### Parameter `item`

The category to be inserted into the map.

#### Returns

Returns whether the category was inserted into the map.

### `M:Autodesk.Revit.DB.CategoryNameMap.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.CategoryNameMap.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the map.

#### Returns

Returns a forward moving iterator to the map.

### `M:Autodesk.Revit.DB.CategoryNameMap.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.CategoryNameMap.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.CategoryNameMapIterator

#### Summary

Retrieve a backward moving iterator to the map.

#### Returns

Returns a backward moving iterator to the map.

### `M:Autodesk.Revit.DB.CategoryNameMap.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.CategoryNameMap.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.CategoryNameMapIterator

#### Summary

Retrieve a forward moving iterator to the map.

#### Returns

Returns a forward moving iterator to the map.

### `M:Autodesk.Revit.DB.CategoryNameMap.Erase(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CategoryNameMap.Erase(System.String)`

#### Returntype

System.Int32

#### Summary

Removes a category with the specified name from the map.

#### Parameter `key`

The name of the category to be erased.

#### Returns

The number of categories that were erased from the map.

### `M:Autodesk.Revit.DB.CategoryNameMap.Contains(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CategoryNameMap.Contains(System.String)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of a category with that name within the map.

#### Parameter `key`

The category name to be searched for.

#### Returns

The Contains method returns True if the name is within the map, otherwise False.

### `M:Autodesk.Revit.DB.CategoryNameMap.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.CategoryNameMap.Clear`

#### Returntype

void

#### Summary

Removes every category from the map, rendering it empty.

### `P:Autodesk.Revit.DB.CategoryNameMap.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.CategoryNameMap.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of categories that are in the map.

### `P:Autodesk.Revit.DB.CategoryNameMap.Item(System.String)`

Member kind: property
Symbol: `Autodesk.Revit.DB.CategoryNameMap.Item(System.String)`

#### Returntype

Autodesk.Revit.DB.Category

#### Summary

Gets or sets a category at a specified name within the map.

#### Parameter `key`

The name of the category to be set or retrieved.

#### Returns

Returns the category at the specified name.

### `P:Autodesk.Revit.DB.CategoryNameMap.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.CategoryNameMap.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the map is empty.

#### Remarks

If the map is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.Utility.AssetSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.Utility.AssetSetIterator`

#### Summary

An iterator to a asset set.

### `T:Autodesk.Revit.Utility.AssetSet`

Member kind: type
Symbol: `Autodesk.Revit.Utility.AssetSet`

#### Summary

A set that contains assets.

### `P:Autodesk.Revit.Utility.AssetSetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.Utility.AssetSetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.Utility.AssetSetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.Utility.AssetSetIterator.MoveNext`

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

### `M:Autodesk.Revit.Utility.AssetSetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.Utility.AssetSetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.Utility.AssetSetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.Utility.AssetSetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.Utility.AssetSet.Insert(Autodesk.Revit.Utility.Asset)`

Member kind: method
Symbol: `Autodesk.Revit.Utility.AssetSet.Insert(Autodesk.Revit.Utility.Asset)`

#### Returntype

System.Int32

#### Summary

Insert the specified asset into the set.

#### Parameter `item`

The asset to be inserted into the set.

#### Returns

Returns whether the asset was inserted into the set.

### `M:Autodesk.Revit.Utility.AssetSet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.Utility.AssetSet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.Utility.AssetSet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.Utility.AssetSet.ReverseIterator`

#### Returntype

Autodesk.Revit.Utility.AssetSetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.Utility.AssetSet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.Utility.AssetSet.ForwardIterator`

#### Returntype

Autodesk.Revit.Utility.AssetSetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.Utility.AssetSet.Erase(Autodesk.Revit.Utility.Asset)`

Member kind: method
Symbol: `Autodesk.Revit.Utility.AssetSet.Erase(Autodesk.Revit.Utility.Asset)`

#### Returntype

System.Int32

#### Summary

Removes a specified asset from the set.

#### Parameter `item`

The asset to be erased.

#### Returns

The number of assets that were erased from the set.

### `M:Autodesk.Revit.Utility.AssetSet.Contains(Autodesk.Revit.Utility.Asset)`

Member kind: method
Symbol: `Autodesk.Revit.Utility.AssetSet.Contains(Autodesk.Revit.Utility.Asset)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of a asset within the set.

#### Parameter `item`

The asset to be searched for.

#### Returns

The Contains method returns True if the asset is within the set, otherwise False.

### `M:Autodesk.Revit.Utility.AssetSet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.Utility.AssetSet.Clear`

#### Returntype

void

#### Summary

Removes every asset from the set, rendering it empty.

### `P:Autodesk.Revit.Utility.AssetSet.Size`

Member kind: property
Symbol: `Autodesk.Revit.Utility.AssetSet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of assets that are in the set.

### `P:Autodesk.Revit.Utility.AssetSet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.Utility.AssetSet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `P:Autodesk.Revit.DB.ExportPatternTable.Item(Autodesk.Revit.DB.ExportPatternKey)`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportPatternTable.Item(Autodesk.Revit.DB.ExportPatternKey)`

#### Summary

A copy of the `T:Autodesk.Revit.DB.ExportPatternInfo` for the pattern's `T:Autodesk.Revit.DB.ExportPatternKey` .

#### Remarks

When getting this property, it returns a copy of the `T:Autodesk.Revit.DB.ExportPatternInfo` from the table. In order to
make changes to the `T:Autodesk.Revit.DB.ExportPatternInfo` and use those settings during export, set the modified
`T:Autodesk.Revit.DB.ExportPatternInfo` back into the table using the same key.

#### Parameter `exportPatternKey`

The key.

#### Returns

A copy of the `T:Autodesk.Revit.DB.ExportPatternInfo` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When getting this property:
An entry with the given key is not present in the table.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportLineweightTable.Item(Autodesk.Revit.DB.ExportLineweightKey)`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLineweightTable.Item(Autodesk.Revit.DB.ExportLineweightKey)`

#### Summary

A copy of the `T:Autodesk.Revit.DB.ExportLineweightInfo` for the line weight's `T:Autodesk.Revit.DB.ExportLineweightKey` .

#### Remarks

When getting this property, it returns a copy of the `T:Autodesk.Revit.DB.ExportLineweightInfo` from the table. In order to
make changes to the `T:Autodesk.Revit.DB.ExportLineweightInfo` and use those settings during export, set the modified
`T:Autodesk.Revit.DB.ExportLineweightInfo` back into the table using the same key.

#### Parameter `ExportLineweightKey`

The key.

#### Returns

A copy of the `T:Autodesk.Revit.DB.ExportLineweightInfo` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When getting this property:
An entry with the given key is not present in the table.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportLinetypeTable.Item(Autodesk.Revit.DB.ExportLinetypeKey)`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLinetypeTable.Item(Autodesk.Revit.DB.ExportLinetypeKey)`

#### Summary

A copy of the `T:Autodesk.Revit.DB.ExportLinetypeInfo` for the linetype's `T:Autodesk.Revit.DB.ExportLinetypeKey` .

#### Remarks

When getting this property, it returns a copy of the `T:Autodesk.Revit.DB.ExportLinetypeInfo` from the table. In order to
make changes to the `T:Autodesk.Revit.DB.ExportLinetypeInfo` and use those settings during export, set the modified
`T:Autodesk.Revit.DB.ExportLinetypeInfo` back into the table using the same key.

#### Parameter `exportLinetypeKey`

The key.

#### Returns

A copy of the `T:Autodesk.Revit.DB.ExportLinetypeInfo` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When getting this property:
An entry with the given key is not present in the table.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportLayerTable.Item(Autodesk.Revit.DB.ExportLayerKey)`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportLayerTable.Item(Autodesk.Revit.DB.ExportLayerKey)`

#### Summary

A copy of the `T:Autodesk.Revit.DB.ExportLayerInfo` item that corresponds to the layer's
`T:Autodesk.Revit.DB.ExportLayerKey` .

#### Remarks

When getting this property, it returns a copy of the `T:Autodesk.Revit.DB.ExportLayerInfo` from the table. In order to
make changes to the `T:Autodesk.Revit.DB.ExportLayerInfo` and use those settings during export, set the modified
`T:Autodesk.Revit.DB.ExportLayerInfo` back into the table using the same key.

#### Parameter `ExportLayerKey`

The key.

#### Returns

A copy of the `T:Autodesk.Revit.DB.ExportLayerInfo` for the layer Key.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When getting this property:
An entry with the given key is not present in the table.

#### Since

2014

### `P:Autodesk.Revit.DB.ExportFontTable.Item(Autodesk.Revit.DB.ExportFontKey)`

Member kind: property
Symbol: `Autodesk.Revit.DB.ExportFontTable.Item(Autodesk.Revit.DB.ExportFontKey)`

#### Summary

A copy of the `T:Autodesk.Revit.DB.ExportFontInfo` for the font's `T:Autodesk.Revit.DB.ExportFontKey` .

#### Remarks

When getting this property, it returns a copy of the `T:Autodesk.Revit.DB.ExportFontInfo` from the table. In order to
make changes to the `T:Autodesk.Revit.DB.ExportFontInfo` and use those settings during export, set the modified
`T:Autodesk.Revit.DB.ExportFontInfo` back into the table using the same key.

#### Parameter `exportPatternKey`

The key.

#### Returns

A copy of the `T:Autodesk.Revit.DB.ExportFontInfo` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When getting this property:
An entry with the given key is not present in the table.

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.DuctSizeSettings.Item(Autodesk.Revit.DB.Mechanical.DuctShape)`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizeSettings.Item(Autodesk.Revit.DB.Mechanical.DuctShape)`

#### Summary

Get the DuctSizes for this DuctShape.

#### Parameter `ductShape`

The duct shape.

#### Returns

The DuctSizes for this DuctShape.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

There is no DuctSizes for this DuctShape.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was NULL

#### Since

2012

### `P:Autodesk.Revit.DB.XYZ.Item(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.XYZ.Item(System.Int32)`

#### Summary

Indexed access to coordinates.

#### Parameter `idx`

Use 0 for X, 1 for Y and 2 for Z.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when an attempt is made to access the coordinate
with an index that is larger than 2.

### `M:Autodesk.Revit.DB.ViewPlan.SetUnderlayOrientation(Autodesk.Revit.DB.UnderlayOrientation)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewPlan.SetUnderlayOrientation(Autodesk.Revit.DB.UnderlayOrientation)`

#### Summary

Sets the underlay orientation for this view.

#### Parameter `uo`

The underlay orientation for this view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2017

### `M:Autodesk.Revit.DB.ViewPlan.GetUnderlayOrientation`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewPlan.GetUnderlayOrientation`

#### Summary

Returns the underlay orientation of this view.

#### Returns

The underlay orientation for this view.

#### Since

2017

### `M:Autodesk.Revit.DB.ViewPlan.SetUnderlayRange(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewPlan.SetUnderlayRange(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Sets the underlay base and underlay top to the specified levels.

#### Parameter `baseLevelId`

The element id of a level in the project or InvalidElementId. If InvalidElementId,
then the underlay base level is not set and no elements will be displayed as underlay.

#### Parameter `topLevelId`

The element id of a level in the project or InvalidElementId. If InvalidElementId,
then the underlay range is unbounded.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId baseLevelId does not correspond to a Level in the project.
-or-
The ElementId topLevelId does not correspond to a Level in the project.
-or-
The elevation of level topLevelId must be greater than the elevation of level baseLevelId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.ViewPlan.SetUnderlayBaseLevel(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewPlan.SetUnderlayBaseLevel(Autodesk.Revit.DB.ElementId)`

#### Summary

Sets the level whose elevation will determine the bottom of the underlay range.
The elevation of the next highest level will be used to determine the top of the underlay range.

#### Remarks

If the level specified is the highest level, the underlay range will be unbounded.
The underlay range will consist of everything above the specified level.

#### Parameter `levelId`

The element id of a level in the project or else InvalidElementId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId levelId does not correspond to a Level in the project.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.ViewPlan.GetUnderlayTopLevel`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewPlan.GetUnderlayTopLevel`

#### Summary

Returns the element id of the level that defines the top of the underlay range.

#### Returns

If the underlay base level is a valid level, and this method returns InvalidElementId, then the underlay range is unbounded,
and consists of everything above the underlay base level.

#### Since

2017

### `M:Autodesk.Revit.DB.ViewPlan.GetUnderlayBaseLevel`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewPlan.GetUnderlayBaseLevel`

#### Summary

Returns the element id of the level that defines the bottom of the underlay range.

#### Returns

If InvalidElementId is returned, then the underlay base level is not set and no elements will be displayed as underlay.

#### Since

2017

### `M:Autodesk.Revit.DB.ViewPlan.CheckPlanViewRangeValidity(Autodesk.Revit.DB.PlanViewRange)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewPlan.CheckPlanViewRangeValidity(Autodesk.Revit.DB.PlanViewRange)`

#### Summary

Checks if the plan view range is valid.

#### Parameter `planViewRange`

The view range to validate.

#### Returns

List of enums describing any errors in the plan view range.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ViewPlan.SetViewRange(Autodesk.Revit.DB.PlanViewRange)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewPlan.SetViewRange(Autodesk.Revit.DB.PlanViewRange)`

#### Summary

Sets the view range.

#### Parameter `planViewRange`

The view range.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Plan view range is not valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.ViewPlan.GetViewRange`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewPlan.GetViewRange`

#### Summary

Gets the view range.

#### Returns

The view range.

#### Since

2013

### `M:Autodesk.Revit.DB.ViewPlan.CreateAreaPlan(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewPlan.CreateAreaPlan(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new area plan ViewPlan.

#### Parameter `document`

The document to which the area plan will be added.

#### Parameter `areaSchemeId`

The id of the AreaScheme which will be used by the area plan.

#### Parameter `levelId`

The id of the Level to associate with the area plan.

#### Returns

The new area plan ViewPlan.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The AreaScheme id is not valid and cannot be used for area plan views.
-or-
The ElementId levelId does not correspond to a Level.
-or-
Plan view creation is not allowed in this family.

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

2013

### `M:Autodesk.Revit.DB.ViewPlan.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ViewPlan.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new ViewPlan.

#### Parameter `document`

The document to which the ViewPlan will be added.

#### Parameter `viewFamilyTypeId`

The id of the ViewFamilyType which will be used by the new ViewPlan. The type needs to be a FloorPlan, CeilingPlan, AreaPlan, or StructuralPlan ViewType.

#### Parameter `levelId`

The id of the Level to associate with the new plan view.

#### Returns

The new ViewPlan.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This view family type is not a plan view type.
-or-
The ElementId levelId does not correspond to a Level.
-or-
StructuralPlans can only be created when the structural discipline is enabled whereas FloorPlans and CeilingPlans can
only be created when architecture or MEP disciplines are enabled.
-or-
Plan view creation is not allowed in this family.

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

2013

### `P:Autodesk.Revit.DB.ViewPlan.AreaScheme`

Member kind: property
Symbol: `Autodesk.Revit.DB.ViewPlan.AreaScheme`

#### Summary

The area scheme.

#### Value

Returns `null` if this plan view is not an area plan.

### `T:Autodesk.Revit.DB.ViewPlan`

Member kind: type
Symbol: `Autodesk.Revit.DB.ViewPlan`

#### Summary

Represents floor plan, area plan, ceiling plan, and structural plan views in Revit.

#### Remarks

In a plan view, the model is viewed as if cut by the cut plane and viewed from above, looking down.
In ceiling plan views and structural plan views which look up, the model is viewed as if cut by
the cut plane, and viewed as if looking down at a mirror.

### `T:Autodesk.Revit.DB.PlanViewRangeError`

Member kind: type
Symbol: `Autodesk.Revit.DB.PlanViewRangeError`

#### Summary

Describes errors in the location of planes in a PlanViewRange object.

#### Since

2013

### `F:Autodesk.Revit.DB.PlanViewRangeError.ViewDepthBelowTopClip`

Member kind: field
Symbol: `Autodesk.Revit.DB.PlanViewRangeError.ViewDepthBelowTopClip`

#### Summary

View depth is below the top clip plane.

### `F:Autodesk.Revit.DB.PlanViewRangeError.ViewDepthAboveBottomClip`

Member kind: field
Symbol: `Autodesk.Revit.DB.PlanViewRangeError.ViewDepthAboveBottomClip`

#### Summary

View depth is above the bottom clip plane.

### `F:Autodesk.Revit.DB.PlanViewRangeError.BottomClipAboveCutPlane`

Member kind: field
Symbol: `Autodesk.Revit.DB.PlanViewRangeError.BottomClipAboveCutPlane`

#### Summary

Bottom clip plane is above the cut plane.

### `F:Autodesk.Revit.DB.PlanViewRangeError.TopClipBelowCutPlane`

Member kind: field
Symbol: `Autodesk.Revit.DB.PlanViewRangeError.TopClipBelowCutPlane`

#### Summary

Top clip plane is below the cut plane.

### `P:Autodesk.Revit.DB.AreaScheme.IsGrossBuildingArea`

Member kind: property
Symbol: `Autodesk.Revit.DB.AreaScheme.IsGrossBuildingArea`

#### Summary

Indicates if the area scheme is a Gross Building Area scheme.

### `T:Autodesk.Revit.DB.AreaScheme`

Member kind: type
Symbol: `Autodesk.Revit.DB.AreaScheme`

#### Summary

The area scheme associated with a particular area plan.

### `M:Autodesk.Revit.DB.SunAndShadowSettings.GetActiveSunAndShadowSettings(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.GetActiveSunAndShadowSettings(Autodesk.Revit.DB.Document)`

#### Summary

Returns the current SunAndShadowSettings element assigned to the active view for the
supplied document.

#### Parameter `aDocument`

The document.

#### Returns

The active SunAndShadowSettings element for the supplied document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.SunAndShadowSettings.FitToModel`

Member kind: method
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.FitToModel`

#### Summary

Adjust SunAndShadowSettings to fit around the current model geometry.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The SunAndShadowSettings is not view-specific.

#### Since

2011

### `M:Autodesk.Revit.DB.SunAndShadowSettings.CalculateTimeZone(System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.CalculateTimeZone(System.Double,System.Double)`

#### Summary

Use Revit's utilities to calculate the time zone for a given longitude and latitude.

#### Remarks

For some latitude and longitude boundary cases, the time zone calculated may not be correct.
The API offers the ability to adjust the time zone independent of Revit's calculations for situations
where this happens.

#### Parameter `latitude`

The latitude.

#### Parameter `longitude`

The longitude.

#### Returns

The time zone, in hours, ranging from +12 hours to -12 hours with 0 being GMT.

#### Since

2012

### `M:Autodesk.Revit.DB.SunAndShadowSettings.IsTimeIntervalValid(Autodesk.Revit.DB.SunStudyTimeInterval)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.IsTimeIntervalValid(Autodesk.Revit.DB.SunStudyTimeInterval)`

#### Summary

Checks whether the time interval is valid for the SunAndShadowType.

#### Parameter `interval`

Time interval value.

#### Returns

True if the time interval is valid for the current SunAndShadowType, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `M:Autodesk.Revit.DB.SunAndShadowSettings.IsGroundPlaneLevelValid(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.IsGroundPlaneLevelValid(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks whether the element represents a valid Ground Plane level.

#### Parameter `levelId`

Level element id.

#### Returns

True if the element is a valid Ground Plane Level, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.SunAndShadowSettings.IsFrameValid(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.IsFrameValid(System.Double)`

#### Summary

Checks whether the frame is valid for the supplied SunAndShadowSettings.

#### Parameter `frame`

Frame value

#### Returns

True if the frame is valid for the SunAndShadowSettings, false otherwise.

#### Since

2011

### `M:Autodesk.Revit.DB.SunAndShadowSettings.IsBeforeEndDateAndTime(System.DateTime)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.IsBeforeEndDateAndTime(System.DateTime)`

#### Summary

Checks whether the start date and time is valid.

#### Parameter `time`

Date and time value

#### Returns

True if the date and time is valid, false otherwise.

#### Since

2011

### `M:Autodesk.Revit.DB.SunAndShadowSettings.IsAfterStartDateAndTime(System.DateTime)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.IsAfterStartDateAndTime(System.DateTime)`

#### Summary

Checks whether the end date and time is valid.

#### Parameter `time`

Date and time value

#### Returns

True if the date and time is valid, false otherwise.

#### Since

2011

### `M:Autodesk.Revit.DB.SunAndShadowSettings.GetSunset(System.DateTime)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.GetSunset(System.DateTime)`

#### Summary

Identifies the sunset time for the SunAndShadowSettings element at its current location
and indicated date.

#### Remarks

The value returned is affected by the value of the `P:Autodesk.Revit.DB.SunAndShadowSettings.UsesDST`
flag set for the current location. If this value is true, the sunset value will be adjusted for
Daylight Savings Time, regardless of the value of the input date.

#### Parameter `date`

The date for which to determine sunset time.

#### Returns

The date and time. The value will be in Coordinated Universal Time (UTC).

#### Since

2011

### `M:Autodesk.Revit.DB.SunAndShadowSettings.GetSunrise(System.DateTime)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.GetSunrise(System.DateTime)`

#### Summary

Identifies the sunrise time for the SunAndShadowSettings element at its current location
and indicated date.

#### Remarks

The value returned is affected by the value of the `P:Autodesk.Revit.DB.SunAndShadowSettings.UsesDST`
flag set for the current location. If this value is true, the sunrise value will be adjusted for
Daylight Savings Time, regardless of the value of the input date.

#### Parameter `date`

The date for which to determine sunrise time.

#### Returns

The date and time. The value will be in Coordinated Universal Time (UTC).

#### Since

2011

### `M:Autodesk.Revit.DB.SunAndShadowSettings.GetFrameAzimuth(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.GetFrameAzimuth(System.Double)`

#### Summary

Identifies the azimuth of the sun (angle in radians) for a specific frame.

#### Parameter `frame`

Frame for which time is requested

#### Returns

Azimuth angle (radians). This is measured counterclockwise from the X axis (East direction). Note that this
is a different frame of reference than is used by Revit for the Lighting Study Azimuth value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

the frame value frame is not valid.

#### Since

2011

### `M:Autodesk.Revit.DB.SunAndShadowSettings.GetFrameAltitude(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.GetFrameAltitude(System.Double)`

#### Summary

Identifies the altitude of the sun (angle in radians) for a specific frame.

#### Parameter `frame`

Frame for which time is requested

#### Returns

Altitude angle (radians)

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

the frame value frame is not valid.

#### Since

2011

### `M:Autodesk.Revit.DB.SunAndShadowSettings.GetFrameTime(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.GetFrameTime(System.Double)`

#### Summary

Identifies the date and time of the SunAndShadowSettings element for a given frame.

#### Parameter `frame`

Frame for which time is requested

#### Returns

The date and time. The value will be in Coordinated Universal Time (UTC).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

the frame value frame is not valid.

#### Since

2011

### `M:Autodesk.Revit.DB.SunAndShadowSettings.GetMatchingPreset`

Member kind: method
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.GetMatchingPreset`

#### Summary

Finds the name of the 'per-document' SunAndShadowSettings that matches the properties
of this per-view element.

#### Returns

Name of the per-document SunAndShadowSettings that matches the view specific element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The SunAndShadowSettings is not view-specific.

#### Since

2011

### `P:Autodesk.Revit.DB.SunAndShadowSettings.SharesSettings`

Member kind: property
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.SharesSettings`

#### Summary

Identifies whether settings are shared globally.

#### Remarks

Identifies whether the per-view SunAndShadowSettings element shares global settings.
Global settings are a special case that allows multiple views to be associated together
in order that a change in one view affects that same change in other views. There cannot be
multiple such groups, and a SunAndShadowSettings element is either a global setting or not.

#### Since

2011

### `P:Autodesk.Revit.DB.SunAndShadowSettings.ProjectLocationId`

Member kind: property
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.ProjectLocationId`

#### Summary

Identifies the ProjectLocation element used by the SunAndShadowSettings element.

#### Since

2011

### `P:Autodesk.Revit.DB.SunAndShadowSettings.ProjectLocationName`

Member kind: property
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.ProjectLocationName`

#### Summary

Identifies the name of the project location used by the SunAndShadowSettings element.

#### Since

2011

### `P:Autodesk.Revit.DB.SunAndShadowSettings.UsesDST`

Member kind: property
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.UsesDST`

#### Summary

Identifies whether the SunAndShadowSettings element is using daylight savings time.

#### Since

2011

### `P:Autodesk.Revit.DB.SunAndShadowSettings.TimeZone`

Member kind: property
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.TimeZone`

#### Summary

Identifies the time zone.

#### Remarks

Identifies the time zone used by the SunAndShadowSettings element.
This property indicates the time zone in which the site resides.
The value is in hours, ranging from +12 hours to -12 hours with 0 being GMT.

#### Since

2011

### `P:Autodesk.Revit.DB.SunAndShadowSettings.Longitude`

Member kind: property
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.Longitude`

#### Summary

Identifies the current longitude used by the SunAndShadowSettings element.

#### Since

2011

### `P:Autodesk.Revit.DB.SunAndShadowSettings.Latitude`

Member kind: property
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.Latitude`

#### Summary

Identifies the current latitude used by the SunAndShadowSettings element.

#### Since

2011

### `P:Autodesk.Revit.DB.SunAndShadowSettings.GroundPlaneHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.GroundPlaneHeight`

#### Summary

Identifies the ground plane height.

#### Since

2011

### `P:Autodesk.Revit.DB.SunAndShadowSettings.TimeInterval`

Member kind: property
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.TimeInterval`

#### Summary

Identifies the time interval between animation frames.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: the time interval value interval is not valid for the current SunAndShadowType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `P:Autodesk.Revit.DB.SunAndShadowSettings.RelativeToView`

Member kind: property
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.RelativeToView`

#### Summary

Identifies whether the SunAndShadowSettings element is relative to the view
direction. This is only relevant for lighting mode.

#### Since

2011

### `P:Autodesk.Revit.DB.SunAndShadowSettings.UsesGroundPlane`

Member kind: property
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.UsesGroundPlane`

#### Summary

Identifies whether the SunAndShadowSettings element uses a ground plane.

#### Since

2011

### `P:Autodesk.Revit.DB.SunAndShadowSettings.SunriseToSunset`

Member kind: property
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.SunriseToSunset`

#### Summary

Identifies whether the current single day sun study is set to run from
sunrise to sunset.

#### Since

2011

### `P:Autodesk.Revit.DB.SunAndShadowSettings.GroundPlaneLevelId`

Member kind: property
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.GroundPlaneLevelId`

#### Summary

Identifies the element id of the Ground Plane level for the SunAndShadowSettings element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: the element level is not a valid Ground Plane Level element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2011

### `P:Autodesk.Revit.DB.SunAndShadowSettings.NumberOfFrames`

Member kind: property
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.NumberOfFrames`

#### Summary

Identifies the total number of animation frames for a single-day or multi-day study.

#### Since

2011

### `P:Autodesk.Revit.DB.SunAndShadowSettings.ActiveFrame`

Member kind: property
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.ActiveFrame`

#### Summary

Identifies the active animation frame for a single-day or multi-day study,
starting at 1.0 for the first frame and incrementing in intervals of 1.0.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: the frame value frame is not valid.

#### Since

2011

### `P:Autodesk.Revit.DB.SunAndShadowSettings.EndDateAndTime`

Member kind: property
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.EndDateAndTime`

#### Summary

Identifies the end date and time.

#### Remarks

This property represents the end time for a single-day or multi-day study.
The end date and time can be set for any study type, but is not always used.
Note that Revit may ignore this value if the SunriseToSunset flag is set.

#### Value

The date and time. The output value will be in Coordinated Universal Time (UTC), but input may be
in local time as well.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: Revit does not accept input DateTime objects if they are of kind DateTypeKind.Unspecified.

#### Since

2011

### `P:Autodesk.Revit.DB.SunAndShadowSettings.StartDateAndTime`

Member kind: property
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.StartDateAndTime`

#### Summary

Identifies the start or current date and time.

#### Remarks

This property represents the start time for a single-day or multi-day study, or the current time
for a still sun study. Note that Revit may ignore this value if the SunriseToSunset flag is set.

#### Value

The date and time. The output value will be in Coordinated Universal Time (UTC), but input may be
in local time as well.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: Revit does not accept input DateTime objects if they are of kind DateTypeKind.Unspecified.

#### Since

2011

### `P:Autodesk.Revit.DB.SunAndShadowSettings.ActiveFrameTime`

Member kind: property
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.ActiveFrameTime`

#### Summary

Identifies the date and time of the SunAndShadowSettings element for the active frame.

#### Since

2011

### `P:Autodesk.Revit.DB.SunAndShadowSettings.SunAndShadowType`

Member kind: property
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.SunAndShadowType`

#### Summary

Identifies the type of the SunAndShadowSettings element.

#### Remarks

There are no restrictions on setting the type, but do note that some
properties are not relevant for certain types. For example, the property
EndDateAndTime is not relevant for the type SunAndShadowType.StillImage.
In this example (and elsewhere), the previous value for the property
is remembered for when the type is reverted. If that property has not been
set yet, default values will apply.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `P:Autodesk.Revit.DB.SunAndShadowSettings.Altitude`

Member kind: property
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.Altitude`

#### Summary

Altitude setting (angle in radians). This is only relevant when dealing with a SunAndShadowSettings
element that uses lighting mode.

#### Value

Altitude angle (radians)

#### Since

2011

### `P:Autodesk.Revit.DB.SunAndShadowSettings.Azimuth`

Member kind: property
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.Azimuth`

#### Summary

Azimuth setting (angle in radians). This is only relevant when dealing with a SunAndShadowSettings
element that uses lighting mode.

#### Value

Azimuth angle (radians)

#### Since

2011

### `P:Autodesk.Revit.DB.SunAndShadowSettings.Visible`

Member kind: property
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings.Visible`

#### Summary

Visibility in current view for a per-view SunAndShadowSettings element.

#### Value

Visibility

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element is not view specific (in which case visibility
is not relevant) or if internally its view is not accessible.

#### Since

2011

### `T:Autodesk.Revit.DB.SunAndShadowSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.SunAndShadowSettings`

#### Summary

The SunAndShadowSettings class represents the sun control.

#### Remarks

The SunAndShadowSettings element represents the settings applied to a project or view regarding
the position, dates, time intervals and other options for the sun control and solar studies.
To differentiate between the project and view settings, test the ViewSpecific or OwnerViewId property.
If the element is not view-specific this element represents a project-wide setting.
If the element is associated to a view, this element represents a per view SunAndShadowSettings.
When you create a new view, a new view-specific SunAndShadowSettings element is automatically created
for it.

#### Since

2011

### `T:Autodesk.Revit.DB.SunStudyTimeInterval`

Member kind: type
Symbol: `Autodesk.Revit.DB.SunStudyTimeInterval`

#### Summary

Time interval enum for a single or multi-day sun study.

#### Since

2011

#### Summary

Enum of sun study time interval.

#### Since

2011

### `F:Autodesk.Revit.DB.SunStudyTimeInterval.Month`

Member kind: field
Symbol: `Autodesk.Revit.DB.SunStudyTimeInterval.Month`

#### Summary

Interval occurs once a month.

### `F:Autodesk.Revit.DB.SunStudyTimeInterval.Week`

Member kind: field
Symbol: `Autodesk.Revit.DB.SunStudyTimeInterval.Week`

#### Summary

Interval occurs once a week.

### `F:Autodesk.Revit.DB.SunStudyTimeInterval.Day`

Member kind: field
Symbol: `Autodesk.Revit.DB.SunStudyTimeInterval.Day`

#### Summary

Interval occurs every day.

### `F:Autodesk.Revit.DB.SunStudyTimeInterval.Hour`

Member kind: field
Symbol: `Autodesk.Revit.DB.SunStudyTimeInterval.Hour`

#### Summary

Interval occurs every hour.

### `F:Autodesk.Revit.DB.SunStudyTimeInterval.Minutes45`

Member kind: field
Symbol: `Autodesk.Revit.DB.SunStudyTimeInterval.Minutes45`

#### Summary

Interval occurs every 45 minutes.

### `F:Autodesk.Revit.DB.SunStudyTimeInterval.Minutes30`

Member kind: field
Symbol: `Autodesk.Revit.DB.SunStudyTimeInterval.Minutes30`

#### Summary

Interval occurs every 30 minutes.

### `F:Autodesk.Revit.DB.SunStudyTimeInterval.Minutes15`

Member kind: field
Symbol: `Autodesk.Revit.DB.SunStudyTimeInterval.Minutes15`

#### Summary

Interval occurs every 15 minutes.

### `F:Autodesk.Revit.DB.SunStudyTimeInterval.Minute`

Member kind: field
Symbol: `Autodesk.Revit.DB.SunStudyTimeInterval.Minute`

#### Summary

Interval occurs every minute.

### `F:Autodesk.Revit.DB.SunStudyTimeInterval.Seconds45`

Member kind: field
Symbol: `Autodesk.Revit.DB.SunStudyTimeInterval.Seconds45`

#### Summary

Interval occurs every 45 seconds.

### `F:Autodesk.Revit.DB.SunStudyTimeInterval.Seconds30`

Member kind: field
Symbol: `Autodesk.Revit.DB.SunStudyTimeInterval.Seconds30`

#### Summary

Interval occurs every 30 seconds.

### `F:Autodesk.Revit.DB.SunStudyTimeInterval.Seconds15`

Member kind: field
Symbol: `Autodesk.Revit.DB.SunStudyTimeInterval.Seconds15`

#### Summary

Interval occurs every 15 seconds.

### `T:Autodesk.Revit.DB.SunAndShadowType`

Member kind: type
Symbol: `Autodesk.Revit.DB.SunAndShadowType`

#### Summary

Sun study type enum of SunAndShadowSettings.

#### Since

2011

#### Summary

Enum of sun study type.

#### Since

2011

### `F:Autodesk.Revit.DB.SunAndShadowType.Lighting`

Member kind: field
Symbol: `Autodesk.Revit.DB.SunAndShadowType.Lighting`

#### Summary

Lighting study type (fixed sun position regardless of date and time).

### `F:Autodesk.Revit.DB.SunAndShadowType.MultiDayStudy`

Member kind: field
Symbol: `Autodesk.Revit.DB.SunAndShadowType.MultiDayStudy`

#### Summary

Multi day study type (range over date and time).

### `F:Autodesk.Revit.DB.SunAndShadowType.OneDayStudy`

Member kind: field
Symbol: `Autodesk.Revit.DB.SunAndShadowType.OneDayStudy`

#### Summary

Single day study type (time range over a specific day).

### `F:Autodesk.Revit.DB.SunAndShadowType.StillImage`

Member kind: field
Symbol: `Autodesk.Revit.DB.SunAndShadowType.StillImage`

#### Summary

Still image study type (single point in time).

### `M:Autodesk.Revit.DB.LinePatternElement.GetLinePatternElementByName(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinePatternElement.GetLinePatternElementByName(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Retrieves the LinePatternElement by its name.

#### Parameter `document`

The document in which to retrieve the LinePatternElement.

#### Parameter `name`

The name of the LinePatternElement.

#### Returns

The LinePatternElement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.LinePatternElement.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.LinePattern)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinePatternElement.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.LinePattern)`

#### Summary

Creates a new LinePatternElement.

#### Parameter `document`

The document in which to create the LinePatternElement.

#### Parameter `linePattern`

The LinePattern associated to the newly created LinePatternElement.

#### Returns

The newly created LinePatternElement.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The Line Pattern is not valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.LinePatternElement.SetLinePattern(Autodesk.Revit.DB.LinePattern)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinePatternElement.SetLinePattern(Autodesk.Revit.DB.LinePattern)`

#### Summary

Sets the LinePattern associated to this element.

#### Remarks

The data stored inside the input LinePattern will be copied into this element.
The input LinePattern itself will not be associated with the element.

#### Parameter `newLinePattern`

The new LinePattern object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The Line Pattern is not valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.LinePatternElement.GetLinePattern(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinePatternElement.GetLinePattern(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Gets the LinePattern associated to an element or from a built-in line pattern.

#### Parameter `document`

The document in which to retrieve the LinePattern.

#### Parameter `elementId`

The ElementId of the LinePatternElement or the built-in line pattern id.

#### Returns

A copy of LinePattern object. `null` if the ElementId doesn't represent a line pattern element
or built-in line pattern. `null` for Solid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.LinePatternElement.GetSolidPatternId`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinePatternElement.GetSolidPatternId`

#### Summary

Gets the solid line pattern element id.

#### Remarks

Note that Solid is special. It isn't a line pattern at all -- it is a special code that tells drawing
and export code to use solid lines rather than patterned lines. Solid is visible to the user when selecting
line patterns.

#### Returns

The element id of the solid line pattern.

#### Since

2012

### `M:Autodesk.Revit.DB.LinePatternElement.GetLinePattern`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinePatternElement.GetLinePattern`

#### Summary

Gets the LinePattern associated to this element.

#### Returns

A copy of LinePattern object.

#### Since

2012

### `T:Autodesk.Revit.DB.LinePatternElement`

Member kind: type
Symbol: `Autodesk.Revit.DB.LinePatternElement`

#### Summary

An element that represents a line pattern.

#### Remarks

The LinePatternElement represents a line pattern in a project.
It enables the user to retrieve, modify or create a line pattern in a project.

#### Since

2012

### `M:Autodesk.Revit.DB.Level.FindAssociatedPlanViewId`

Member kind: method
Symbol: `Autodesk.Revit.DB.Level.FindAssociatedPlanViewId`

#### Summary

Finds the id of the first available associated floor or structural plan view associated with this level.

#### Remarks

The view id returned is determined by the same rules associated with the Revit tool "Go to Floor Plan".
Many levels may actually have more than one associated floor plan id and this routine will only return
the first one found. If no associated view is found, InvalidElementId is returned.

#### Since

2018

### `M:Autodesk.Revit.DB.Level.GetNearestLevelId(Autodesk.Revit.DB.Document,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Level.GetNearestLevelId(Autodesk.Revit.DB.Document,System.Double)`

#### Summary

Returns id of the Level which is closest to the specified elevation.

#### Remarks

The level can be at, above or below the target elevation.
If there is more than one Level at the same distance from the elevation, the Level with the lowest Id will be returned.

#### Parameter `document`

The document.

#### Parameter `elevation`

Target Elevation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.Level.GetNearestLevelId(Autodesk.Revit.DB.Document,System.Double,System.Double@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Level.GetNearestLevelId(Autodesk.Revit.DB.Document,System.Double,System.Double@)`

#### Summary

Returns id of the Level which is closest to the specified elevation.

#### Remarks

The level can be at, above or below the target elevation.
If there is more than one Level at the same distance from the elevation, the Level with the lowest Id will be returned.

#### Parameter `document`

The document.

#### Parameter `elevation`

Target Elevation.

#### Parameter `offset`

Vertical offset from the level to the target elevation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.Level.GetPlaneReference`

Member kind: method
Symbol: `Autodesk.Revit.DB.Level.GetPlaneReference`

#### Summary

Returns a reference to this element as a plane.

#### Since

2016

### `M:Autodesk.Revit.DB.Level.Create(Autodesk.Revit.DB.Document,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Level.Create(Autodesk.Revit.DB.Document,System.Double)`

#### Summary

Creates a new instance of level based on an input elevation.

#### Parameter `document`

The document in which the new instance is created

#### Parameter `elevation`

The elevation of the level to be created.

#### Returns

The newly created level instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `P:Autodesk.Revit.DB.Level.ProjectElevation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Level.ProjectElevation`

#### Summary

Retrieves the elevation relative to project origin, no matter
what values of the Elevation Base parameter is set.

#### Remarks

This read only property returns the elevation relative to
project origin.

### `P:Autodesk.Revit.DB.Level.Elevation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Level.Elevation`

#### Summary

Retrieves or changes the elevation above or below the ground level.

#### Remarks

This property retrieves or changes the elevation above or below the ground level of the
project. If the Elevation Base parameter is set to Project, the elevation is relative to project origin.
If the Elevation Base parameter is set to Shared, the elevation is relative to shared origin which can
be changed by relocate operation. The value is given in decimal feet.

### `T:Autodesk.Revit.DB.Level`

Member kind: type
Symbol: `Autodesk.Revit.DB.Level`

#### Summary

Represents a Level within Autodesk Revit.

#### Remarks

A Level is conceptually a horizontal rectangle of finite extents. It appears as a straight line in views that intersect
the rectangle. The straight line represents the projection of the rectangle onto the view.

The Name property can be used to retrieve the user visible name of the level that appears in the level bubble.

### `T:Autodesk.Revit.DB.LevelType`

Member kind: type
Symbol: `Autodesk.Revit.DB.LevelType`

#### Summary

An object that represents a Level type.

### `P:Autodesk.Revit.DB.BoundingBoxXYZ.IsSet`

Member kind: property
Symbol: `Autodesk.Revit.DB.BoundingBoxXYZ.IsSet`

#### Summary

Indicates whether the bounding box is set.

#### Remarks

Bounding box is considered set when it contains at least one point and "Enabled" is set to "true".

### `P:Autodesk.Revit.DB.BoundingBoxXYZ.Enabled`

Member kind: property
Symbol: `Autodesk.Revit.DB.BoundingBoxXYZ.Enabled`

#### Summary

Defines whether the entire bounding box is enabled.

#### Remarks

A disabled bounding box might be used to signal that the corresponding Revit functionality
is deactivated. For example, a disabled 3D view section box represents an inactive section box.

### `P:Autodesk.Revit.DB.BoundingBoxXYZ.BoundEnabled(System.Int32,System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.BoundingBoxXYZ.BoundEnabled(System.Int32,System.Int32)`

#### Summary

Indexed access for loops.

#### Remarks

For bound, use 0 for Min and 1 for Max. For dimension, use 0 for X, 1 for
Y and 2 for Z.
The entire box must be enabled to have enabled individual bounds.

### `P:Autodesk.Revit.DB.BoundingBoxXYZ.MaxEnabled(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.BoundingBoxXYZ.MaxEnabled(System.Int32)`

#### Summary

Defines whether the maximum bound is active for given dimension.

#### Remarks

Use 0 for X, 1 for Y and 2 for Z.
The entire box must be enabled to have enabled individual bounds.

### `P:Autodesk.Revit.DB.BoundingBoxXYZ.MinEnabled(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.BoundingBoxXYZ.MinEnabled(System.Int32)`

#### Summary

Defines whether the minimum bound is active for given dimension.

#### Remarks

Use 0 for X, 1 for Y and 2 for Z.
The entire box must be enabled to have enabled individual bounds.

### `P:Autodesk.Revit.DB.BoundingBoxXYZ.Bounds(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.BoundingBoxXYZ.Bounds(System.Int32)`

#### Summary

Indexed access for loops. Use 0 for Min and 1 for Max.

#### Remarks

The bounds are defined in the coordinate space of the box.

### `P:Autodesk.Revit.DB.BoundingBoxXYZ.Max`

Member kind: property
Symbol: `Autodesk.Revit.DB.BoundingBoxXYZ.Max`

#### Summary

Maximum coordinates (upper-right-front corner of the box).

#### Remarks

The bounds are defined in the coordinate space of the box.

### `P:Autodesk.Revit.DB.BoundingBoxXYZ.Min`

Member kind: property
Symbol: `Autodesk.Revit.DB.BoundingBoxXYZ.Min`

#### Summary

Minimum coordinates (lower-left-rear corner of the box).

#### Remarks

The bounds are defined in the coordinate space of the box.

### `P:Autodesk.Revit.DB.BoundingBoxXYZ.Transform`

Member kind: property
Symbol: `Autodesk.Revit.DB.BoundingBoxXYZ.Transform`

#### Summary

The transform from the coordinate space of the box to the model coordinate space.

#### Remarks

The transform must always be right-handed and orthonormal.

### `M:Autodesk.Revit.DB.BoundingBoxXYZ.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.BoundingBoxXYZ.#ctor`

#### Summary

Constructs a new BoundingBoxXYZ with a default transform and extents of (-100, -100, -100) to (100, 100, 100).

### `T:Autodesk.Revit.DB.BoundingBoxXYZ`

Member kind: type
Symbol: `Autodesk.Revit.DB.BoundingBoxXYZ`

#### Summary

A three-dimensional rectangular box at an arbitrary location and orientation within the Revit model.

#### Remarks

BoundingBoxXYZ objects are used in Revit in several places related to views (for example, the section box of a
3D view or the definition of a section or detail view). BoundingBoxXYZ objects can also be obtained from elements representing the
boundary of the element in a given view.

The extents of the box are determined by three orthogonal planes extended through the minimum ( `P:Autodesk.Revit.DB.BoundingBoxXYZ.Min` )
and maximum ( `P:Autodesk.Revit.DB.BoundingBoxXYZ.Max` ) points, but the coordinates of these points and the orientation of the planes
in relation to the coordinates of the source model is determined by the box Transform ( `P:Autodesk.Revit.DB.BoundingBoxXYZ.Transform` ).

This class also has the ability to detect and mark certain extents as disabled. Note that in the current Revit API uses
of this class it is not expected that Revit will give objects with disabled extents, and disabled extents in objects
sent to Revit will likely be ignored.

### `M:Autodesk.Revit.DB.LinkLoadResult.IsCodeSuccess(Autodesk.Revit.DB.LinkLoadResultType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinkLoadResult.IsCodeSuccess(Autodesk.Revit.DB.LinkLoadResultType)`

#### Summary

Check if load result code signifies success.

#### Parameter `code`

Load result code to be verified.

#### Returns

True if LinkLoadResultType argument is success, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `M:Autodesk.Revit.DB.LinkLoadResult.GetExternalResourceReferencesFromFailedLoads`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinkLoadResult.GetExternalResourceReferencesFromFailedLoads`

#### Summary

Searches this and all nested LinkLoadResults, and returns a list
of ExternalResourceReferences for the links that failed to load.

#### Remarks

In cases, where a nested structure of several links were loaded, this
method is intended to be a convenient way for IExternalResourceUIServers to
determine whether a top-level link, or any sub-link, which failed to load
properly was provided by their IExternalResourceServer or another server.

If this link and all nested links loaded successfully, then an empty list is returned.

#### Returns

A collection of link ExternalResourceReferences which failed to load.

#### Since

2015

### `M:Autodesk.Revit.DB.LinkLoadResult.GetNestedLinkLoadResults`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinkLoadResult.GetNestedLinkLoadResults`

#### Summary

Gets the results for this link's nested links.

#### Remarks

This function is only relevant for LinkLoadResult object for RvtLinkSymbol.
ie. when getIsRvtLink() is true.

#### Returns

A map from nested link paths to the load results for
that nested link.

For links from external servers, the "path" will be
the display name of the link.

#### Since

2013

### `M:Autodesk.Revit.DB.LinkLoadResult.GetLinkLoadResult(Autodesk.Revit.DB.ExternalResourceReference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinkLoadResult.GetLinkLoadResult(Autodesk.Revit.DB.ExternalResourceReference)`

#### Summary

Searches this LinkLoadResult and all nested LinkLoadResults for the
load operation results of a specified ExternalResourceReference.

#### Remarks

In the case where there are multiple matches, then the LinkLoadResult closest
to the top-level link will be returned. For example, if you are searching for C,
starting with a top-level link, A, which links B and C, while B also links C directly,
then the load results for C as a direct sub-link of A will be returned. It is expected
that the LinkLoadResults for all instances of C in the nested load result tree will be
the same. However, if you need to inspect each individual result, the LinkLoadResult
class does provide methods to navigate the tree.

NULL is returned if a match for the ExternalResourceReference cannot be found.

#### Parameter `matchExtResRef`

An ExternalResourceReference whose LinkLoadResults are contained in this object.

#### Returns

A LinkLoadResult object with the load results for the specified ExternalResourceReference.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.LinkLoadResult.GetExternalResourceReference`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinkLoadResult.GetExternalResourceReference`

#### Summary

Gets a copy of the ExternalResourceReference corresponding
to the link.

#### Returns

A copy of the ExternalResourceReference corresponding
to the link.

#### Since

2015

### `M:Autodesk.Revit.DB.LinkLoadResult.GetCentralModelName`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinkLoadResult.GetCentralModelName`

#### Summary

Gets the central model's name.
If the link is not workshared, this returns an empty FilePath.
If the link is itself a central model, this returns the link's name.

#### Remarks

If the link could not be found or loaded, this name may be blank.

This function is only relevant for LinkLoadResult object for RvtLinkSymbol.
ie. when getIsRvtLink() is true.

#### Since

2013

### `M:Autodesk.Revit.DB.LinkLoadResult.GetParentModelName`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinkLoadResult.GetParentModelName`

#### Summary

Returns the name of the parent of the linked model, or an empty FilePath
if the link is a top-level link.

#### Remarks

This function is only relevant for LinkLoadResult object for RvtLinkSymbol.
ie. when getIsRvtLink() is true.

#### Since

2013

### `M:Autodesk.Revit.DB.LinkLoadResult.GetModelName`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinkLoadResult.GetModelName`

#### Summary

Gets the name of the model.

#### Since

2013

### `P:Autodesk.Revit.DB.LinkLoadResult.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.LinkLoadResult.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.LinkLoadResult.LoadResult`

Member kind: property
Symbol: `Autodesk.Revit.DB.LinkLoadResult.LoadResult`

#### Summary

Holds the results of creating or loading a link. Results can be LinkLoadResultType.LinkLoaded
for success, or a variety of errors. See LinkLoadResultType for the full list.

#### Since

2013

### `P:Autodesk.Revit.DB.LinkLoadResult.IsNested`

Member kind: property
Symbol: `Autodesk.Revit.DB.LinkLoadResult.IsNested`

#### Summary

True if these results represent a nested link; false otherwise.

#### Remarks

This property is only relevant for LinkLoadResult object for RvtLinkSymbol.
ie. when getIsRvtLink() is true.

#### Since

2013

### `P:Autodesk.Revit.DB.LinkLoadResult.IsCircularLink`

Member kind: property
Symbol: `Autodesk.Revit.DB.LinkLoadResult.IsCircularLink`

#### Summary

True if these results are part of a link cycle.

#### Remarks

A link cycle occurs when, for example, model A links model B as an attachment,
which links model C as an attachment, which links model A as an attachment.
Revit will only load one copy of model A; it will ignore the instance of A linked
under C.

Circular links do not abort the load process, so they do not appear as a result type
in LinkLoadResultType.Enum.

This property is only relevant for LinkLoadResult object for RvtLinkSymbol.
ie. when getIsRvtLink() is true.

#### Since

2013

### `P:Autodesk.Revit.DB.LinkLoadResult.ElementId`

Member kind: property
Symbol: `Autodesk.Revit.DB.LinkLoadResult.ElementId`

#### Summary

The id of the created or loaded linked model.

#### Remarks

This may be invalidElementId if there were errors
(for example, LinkLoadResultType.SameModelAsHost
causes no link to be created).

#### Since

2013

### `M:Autodesk.Revit.DB.LinkLoadResult.#ctor(Autodesk.Revit.DB.LinkLoadResult)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinkLoadResult.#ctor(Autodesk.Revit.DB.LinkLoadResult)`

#### Summary

Constructs a new copy of the input LinkLoadResult object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.LinkLoadResult.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinkLoadResult.#ctor`

#### Summary

Constructs a new uninitialized LinkLoadResult object.

#### Since

2013

### `T:Autodesk.Revit.DB.LinkLoadResult`

Member kind: type
Symbol: `Autodesk.Revit.DB.LinkLoadResult`

#### Summary

This class stores the results of trying to load a single linked model.

#### Since

2013

### `M:Autodesk.Revit.DB.ISaveSharedCoordinatesCallbackForUnloadLocallyProxy.GetSaveModifiedLinksOptionForUnloadLocally(Autodesk.Revit.DB.RevitLinkType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ISaveSharedCoordinatesCallbackForUnloadLocallyProxy.GetSaveModifiedLinksOptionForUnloadLocally(Autodesk.Revit.DB.RevitLinkType)`

#### Summary

Determines whether Revit should save the link or not prior
to unloading the link locally.

#### Parameter `link`

The Revit link which has modified shared coordinates.

#### Returns

The saving option when unloading locally a linked file which has been modified
in-memory by shared coordinates operations.

#### Since

2017

### `M:Autodesk.Revit.DB.ISaveSharedCoordinatesCallbackForUnloadLocally.GetSaveModifiedLinksOptionForUnloadLocally(Autodesk.Revit.DB.RevitLinkType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ISaveSharedCoordinatesCallbackForUnloadLocally.GetSaveModifiedLinksOptionForUnloadLocally(Autodesk.Revit.DB.RevitLinkType)`

#### Summary

Determines whether Revit should save the link or not prior
to unloading the link locally.

#### Parameter `link`

The Revit link which has modified shared coordinates.

#### Returns

The saving option when unloading locally a linked file which has been modified
in-memory by shared coordinates operations.

#### Since

2017

### `T:Autodesk.Revit.DB.ISaveSharedCoordinatesCallbackForUnloadLocally`

Member kind: type
Symbol: `Autodesk.Revit.DB.ISaveSharedCoordinatesCallbackForUnloadLocally`

#### Summary

An interface that is used to control Revit when trying to unload
locally a Revit link with changes in shared coordinates.

#### Since

2017

### `M:Autodesk.Revit.DB.ISaveSharedCoordinatesCallbackProxy.GetSaveModifiedLinksOption(Autodesk.Revit.DB.RevitLinkType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ISaveSharedCoordinatesCallbackProxy.GetSaveModifiedLinksOption(Autodesk.Revit.DB.RevitLinkType)`

#### Summary

Determines whether Revit should save the link, not save the link,
or discard shared positioning entirely.

#### Parameter `link`

The Revit link which has modified shared coordinates.

#### Returns

The options when saving a linked file which has been modified
in-memory by shared coordinates operations.

#### Since

2014

### `M:Autodesk.Revit.DB.ISaveSharedCoordinatesCallback.GetSaveModifiedLinksOption(Autodesk.Revit.DB.RevitLinkType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ISaveSharedCoordinatesCallback.GetSaveModifiedLinksOption(Autodesk.Revit.DB.RevitLinkType)`

#### Summary

Determines whether Revit should save the link, not save the link,
or discard shared positioning entirely.

#### Parameter `link`

The Revit link which has modified shared coordinates.

#### Returns

The options when saving a linked file which has been modified
in-memory by shared coordinates operations.

#### Since

2014

### `T:Autodesk.Revit.DB.ISaveSharedCoordinatesCallback`

Member kind: type
Symbol: `Autodesk.Revit.DB.ISaveSharedCoordinatesCallback`

#### Summary

An interface that may be used to control Revit when trying to unload
or reload a Revit link with changes in shared coordinates.

#### Since

2014

### `M:Autodesk.Revit.DB.RevitLinkType.GetLinks(Autodesk.Revit.DB.Document,System.Boolean,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkType.GetLinks(Autodesk.Revit.DB.Document,System.Boolean,System.Boolean)`

#### Summary

Returns the element ids of the RvtLinkSymbols corresponding to the top-level links,
i.e. those that would be listed in the Manage Links dialog.

#### Parameter `includeTopLevelRevitLinks`

When true top level Revit links are included.

#### Parameter `includeIFCLinks`

When true IFC links are included.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.RevitLinkType.LoadFrom(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.OpenOptions,Autodesk.Revit.DB.WorksetConfiguration)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkType.LoadFrom(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.OpenOptions,Autodesk.Revit.DB.WorksetConfiguration)`

#### Summary

Loads or reloads the Revit link from disk or cloud.
The link will be loaded from the input path.
Provide OpenOptions parameter

#### Remarks

The input path must be absolute. Revit will store
an absolute or relative path internally, according
to the link's settings. Revit Server paths or cloud paths are acceptable.

If the link is currently loaded, Revit must unload
the link before reloading it. Any changes made in-memory
to the link's shared coordinates will be discarded.

Revit does not try to validate that the input path
represents the "same" document. You can load a
completely different document, which may invalidate
references to linked elements.

This function regenerates the document.

The document's Undo history will be cleared by this command.
As a result, this command and others executed before it cannot be undone.
All transaction phases (e.g. transactions transaction groups and sub-transaction)
that were explicitly started must be finished prior to calling this method.

#### Parameter `path`

A ModelPath indicating where to load the link from.
This may be a path of local disk, Revit Server or Cloud.
This must be an absolute path for local path.

#### Parameter `openOptions`

Options for opening the file.

#### Parameter `config`

A WorksetConfiguration object indicating which worksets in the
link to open.

If you want to load the same set of worksets the link previously
had, leave this argument as `null` .

#### Returns

An object containing the ElementId of the link
and an enum value indicating any errors
which occurred while trying to load.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input path "path" does not represent a Revit model.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileAccessException`

The model cannot be accessed due to lack of access privileges.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

The function is not permitted during dynamic update.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RevitLinkType is not a top-level link.
-or-
The link "this RevitLinkType" is loaded into multiple documents and cannot be reloaded.
-or-
The element "this RevitLinkType" is in a closed workset.
-or-
The model is not allowed to access.
-or-
There is a transaction phase left open (such as a transaction, sub-transaction of transaction group)
at the time of invoking this method.
-or-
The document is read-only. It cannot be modified.
-or-
The document is in an edit mode or is in family mode.
Revit cannot customize worksets for this model.
Revit cannot link a cloud model to non-cloud model.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerInternalException`

Could be for any of the reasons that failed on service side.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthenticatedUserException`

User is not signed in with Autodesk id.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthorizedException`

User is not authorized to access the specified cloud model.

#### Since

2012

### `M:Autodesk.Revit.DB.RevitLinkType.UnloadLocally(Autodesk.Revit.DB.ISaveSharedCoordinatesCallbackForUnloadLocally)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkType.UnloadLocally(Autodesk.Revit.DB.ISaveSharedCoordinatesCallbackForUnloadLocally)`

#### Summary

Unloads a Revit link for the current user only.

#### Remarks

This function unloads the Revit link for the current user,
instead of all users, in the workshared files.

If you want to unload the Revit link for all users, please use `M:Autodesk.Revit.DB.RevitLinkType.Unload(Autodesk.Revit.DB.ISaveSharedCoordinatesCallback)` .

This function should not be called on a Revit link:

in a document which is in an edit mode or is in family mode.

in a document which is in dynamic update.

in a document which is read only.

in a document in which there is transaction phase left open.

in a non-workshared file.

in a central model of workshared file.

which is nested.

which is unloaded locally already.

#### Parameter `callback`

A callback indicating what to do if Revit encounters
links which have changes in shared coordinates. The saving options for
unloading locally only could be: save the link, not save the link.
If `null` , Revit will not save any shared coordinates
changes to the link before unloading.

#### Returns

Returns true if the attempt to unload the link locally was successful.

#### Exception `T:Autodesk.Revit.Exceptions.FileAccessException`

The model cannot be accessed due to lack of access privileges.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

The element "this RevitLinkType" is in a ducument which is in dynamic update.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The element "this RevitLinkType" is in a family document or a document in in-place edit mode.
-or-
The element "this RevitLinkType" is in a document which is in an edit mode or is in family mode.
-or-
The element "this RevitLinkType" is in a read-only document.
-or-
This functionality is not available in Revit LT.
-or-
The element "this RevitLinkType" is in non-workshared document.
-or-
The element "this RevitLinkType" is not in a local model: the model is not workshared or it is central.
-or-
This RevitLinkType is not a top-level link.
-or-
The link "this RevitLinkType" is locally unloaded for current user already.
-or-
There is a transaction phase left open (such as a transaction, sub-transaction of transaction group)
at the time of invoking this method.

#### Since

2016 Subscripton Update

### `M:Autodesk.Revit.DB.RevitLinkType.GetChildIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkType.GetChildIds`

#### Summary

Gets the ids of the immediate children of this link.

#### Remarks

This function only returns the ids of immediate children. Given
the link structure A -> B -> C, then calling this function on A will
only return B's id.

#### Returns

The element ids of all links which are linked directly into this one
(immediate children)

#### Since

2012

### `M:Autodesk.Revit.DB.RevitLinkType.GetRootId`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkType.GetRootId`

#### Summary

Gets the id of the top-level link which this link is linked into.

#### Remarks

This function will always return the id of a top-level link, or invalidElementId.
Given the link structure A -> B -> C, then calling this function on
C will return A's id. Call GetParentId to get B's id.

#### Returns

The id of the top-level link which this link is ultimately linked under,
or invalidElementId if this link is a top-level link.

#### Since

2012

### `M:Autodesk.Revit.DB.RevitLinkType.GetParentId`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkType.GetParentId`

#### Summary

Gets the id of this link's immediate parent.

#### Remarks

This function returns the immediate parent id. Given the link
structure A -> B -> C, then calling this function on C will return
B's id. Call GetRootId to get A's id.

#### Returns

The id of the immediate parent of this link, or invalidElementId if
this link is a top-level link.

#### Since

2012

### `M:Autodesk.Revit.DB.RevitLinkType.GetTopLevelLink(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ExternalResourceReference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkType.GetTopLevelLink(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ExternalResourceReference)`

#### Summary

Returns the ElementId of the (top-level) linked model with the given
ExternalResourceReference.

#### Remarks

This function will not return nested links.

Revit will not check the version when checking for
resource equality.

#### Parameter `document`

The document to look for the linked model in.

#### Parameter `reference`

An ExternalResourceReference indicating which linked model to return.

#### Returns

The id of the link with the given ExternalResourceReference,
or InvalidElementId if
there is no top-level link at that location.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.RevitLinkType.GetTopLevelLink(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ModelPath)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkType.GetTopLevelLink(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ModelPath)`

#### Summary

Returns the ElementId of the (top-level) linked model with the given path.

#### Remarks

This function will not return nested links.

#### Parameter `document`

The document to look for the linked model in.

#### Parameter `path`

A path indicating which linked model to return.

#### Returns

The id of the link with the given path, or InvalidElementId if
there is no top-level link at that path.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.RevitLinkType.GetLinkedFileStatus`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkType.GetLinkedFileStatus`

#### Summary

Returns the LinkedFileStatus of this link.

#### Since

2018.2

### `M:Autodesk.Revit.DB.RevitLinkType.IsFromLocalPath`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkType.IsFromLocalPath`

#### Summary

Checks whether the Revit link uses a local path, such as a hard drive.

#### Returns

Returns true if the Revit link is from a local drive.

#### Since

2015

### `M:Autodesk.Revit.DB.RevitLinkType.IsFromRevitServer`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkType.IsFromRevitServer`

#### Summary

Checks whether the Revit link is located on Revit Server.

#### Returns

Returns true if the Revit link is located on Revit Server.

#### Since

2015

### `M:Autodesk.Revit.DB.RevitLinkType.GetConversionData`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkType.GetConversionData`

#### Summary

Returns the optional data that is necessary to generate the Revit file for this link.

#### Returns

The RvtLinkConversionData containing the necessary information.

#### Since

2015

### `M:Autodesk.Revit.DB.RevitLinkType.GetPhaseMap`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkType.GetPhaseMap`

#### Summary

Returns a mapping between phases in the host document and phases in the linked document.

#### Remarks

This map is used to determine which phase in the linked document corresponds to each phase in the host document.
This map is used to correctly calculate room geometry for room-bounding links.
Multiple phases in the host document can correspond to the same phase in the linked document.
Time order must be respected - if the host document has phases 1 and 2, and the linked document
has phases A and B, it would not be proper to map 1 to B and 2 to A.
If the user has not explicitly set the map values in the UI, the map will be as follows: Revit attempts to find
a match for each host phase, moving in order from earliest to latest phase.
First Revit will look for a phase in the linked document with the same name as the host phase.
If there is no name match, the last phase in the link will be chosen as the match.
Once Revit has matched a host phase to the last link phase, all other host phases will be matched to the last link phase,
even if later host phases might have a name match.

#### Returns

A map from phases in the host document to phases in the linked document.
The first value in each pair is the ElementId of a phase in the host document.
The second value is the ElementId of the matching phase in the linked document.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The RvtLinkSymbol is not loaded.
-or-
This Revit link doesn't have a valid phase map.

#### Since

2018.3

### `M:Autodesk.Revit.DB.RevitLinkType.HasSaveablePositions`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkType.HasSaveablePositions`

#### Summary

Determines whether the link has changes to shared positioning that could
be saved.

#### Returns

True if the link has shared positioning changes which can be saved.
False if there are no changes to shared coordinates, or if the changes
cannot be saved.

#### Since

2012

### `M:Autodesk.Revit.DB.RevitLinkType.SavePositions(Autodesk.Revit.DB.ISaveSharedCoordinatesCallback)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkType.SavePositions(Autodesk.Revit.DB.ISaveSharedCoordinatesCallback)`

#### Summary

Saves shared coordinates changes back to the linked document.

#### Remarks

While this operation does not clear the document's undo history,
you will not be able to undo this specific action, since it saves
the link's shared coordinates changes to disk.

#### Parameter `callback`

A callback object to resolve situations when Revit encounters
modified links.

#### Returns

True if we saved the link or if there were no changes to save.
False if the operation failed.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Revit could not save shared coordinates changes to the link
or one of its nested links.

#### Since

2014

### `M:Autodesk.Revit.DB.RevitLinkType.Unload(Autodesk.Revit.DB.ISaveSharedCoordinatesCallback)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkType.Unload(Autodesk.Revit.DB.ISaveSharedCoordinatesCallback)`

#### Summary

Unloads the Revit link.

#### Remarks

This function regenerates the document.

The document's Undo history will be cleared by this command.
As a result, this command and others executed before it cannot be undone.
All transaction phases (e.g. transactions transaction groups and sub-transaction)
that were explicitly started must be finished prior to calling this method.

#### Parameter `callback`

A callback indicating what to do if Revit encounters
links which have changes in shared coordinates.
If `null` , Revit will not save any shared coordinates
changes to the link before unloading.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

The function is not permitted during dynamic update.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RevitLinkType is not a top-level link.
-or-
Revit could not save shared coordinates changes to the link
or one of its nested links.
-or-
There is a transaction phase left open (such as a transaction, sub-transaction of transaction group)
at the time of invoking this method.
-or-
The document is read-only. It cannot be modified.
-or-
The document is in an edit mode or is in family mode.
-or-
Revit cannot link a cloud model to non-cloud model

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerInternalException`

Could be for any of the reasons that failed on service side.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthenticatedUserException`

User is not signed in with Autodesk id.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthorizedException`

User is not authorized to access the specified cloud model.

#### Since

2014

### `M:Autodesk.Revit.DB.RevitLinkType.LoadFrom(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.WorksetConfiguration)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkType.LoadFrom(Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.WorksetConfiguration)`

#### Summary

Loads or reloads the Revit link from disk or cloud.
The link will be loaded from the input path.

#### Remarks

The input path must be absolute. Revit will store
an absolute or relative path internally, according
to the link's settings. Revit Server paths or cloud paths are acceptable.

If the link is currently loaded, Revit must unload
the link before reloading it. Any changes made in-memory
to the link's shared coordinates will be discarded.

Revit does not try to validate that the input path
represents the "same" document. You can load a
completely different document, which may invalidate
references to linked elements.

This function regenerates the document.

The document's Undo history will be cleared by this command.
As a result, this command and others executed before it cannot be undone.
All transaction phases (e.g. transactions transaction groups and sub-transaction)
that were explicitly started must be finished prior to calling this method.

#### Parameter `path`

A ModelPath indicating where to load the link from.
This may be a path of local disk, Revit Server or Cloud.
This must be an absolute path for local path.

#### Parameter `config`

A WorksetConfiguration object indicating which worksets in the
link to open.

If you want to load the same set of worksets the link previously
had, leave this argument as `null` .

#### Returns

An object containing the ElementId of the link
and an enum value indicating any errors
which occurred while trying to load.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input path "path" does not represent a Revit model.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileAccessException`

The model cannot be accessed due to lack of access privileges.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

The function is not permitted during dynamic update.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RevitLinkType is not a top-level link.
-or-
The link "this RevitLinkType" is loaded into multiple documents and cannot be reloaded.
-or-
The element "this RevitLinkType" is in a closed workset.
-or-
The model is not allowed to access.
-or-
There is a transaction phase left open (such as a transaction, sub-transaction of transaction group)
at the time of invoking this method.
-or-
The document is read-only. It cannot be modified.
-or-
The document is in an edit mode or is in family mode.
-or-
Revit cannot customize worksets for this model.
-or-
Revit cannot link a cloud model to non-cloud model.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerInternalException`

Could be for any of the reasons that failed on service side.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthenticatedUserException`

User is not signed in with Autodesk id.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthorizedException`

User is not authorized to access the specified cloud model.

#### Since

2014

### `M:Autodesk.Revit.DB.RevitLinkType.LoadFrom(Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.WorksetConfiguration)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkType.LoadFrom(Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.WorksetConfiguration)`

#### Summary

Loads or reloads the Revit link.
The link will be loaded from the location given in the
input ExternalResourceReference.

#### Remarks

If the link is currently loaded, Revit must unload
the link before reloading it. Any changes made in-memory
to the link's shared coordinates will be discarded.

Revit does not try to validate that the input
represents the "same" document. You can load a
completely different document, which may invalidate
references to linked elements.

This function regenerates the document.

The document's Undo history will be cleared by this command.
As a result, this command and others executed before it cannot be undone.
All transaction phases (e.g. transactions transaction groups and sub-transaction)
that were explicitly started must be finished prior to calling this method.

#### Parameter `resourceReference`

An external resource reference describing the source of the linked Revit document.

#### Parameter `config`

A WorksetConfiguration object indicating which worksets in the
link to open.

If you want to load the same set of worksets the link previously
had, leave this argument as `null` .

#### Returns

An object containing the ElementId of the link
and an enum value indicating any errors
which occurred while trying to load.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The server referenced by the ExternalResourceReference does not exist or
does not implement IExternalResourceServer.
-or-
The server referenced by the ExternalResourceReference cannot support Revit links.
-or-
The ExternalResourceReference (resourceReference) is not in a format
that is supported by its server.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileAccessException`

The model cannot be accessed due to lack of access privileges.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

The function is not permitted during dynamic update.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This RevitLinkType is not a top-level link.
-or-
The link "this RevitLinkType" is loaded into multiple documents and cannot be reloaded.
-or-
The element "this RevitLinkType" is in a closed workset.
-or-
There is a transaction phase left open (such as a transaction, sub-transaction of transaction group)
at the time of invoking this method.
-or-
The document is read-only. It cannot be modified.
-or-
The document is in an edit mode or is in family mode.
-or-
Revit cannot customize worksets for this model.

#### Since

2015

### `M:Autodesk.Revit.DB.RevitLinkType.IsLoaded(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkType.IsLoaded(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Checks whether the link with this id is loaded.

#### Remarks

Returns false if typeId is not the id of a RevitLinkType.

#### Parameter `document`

A document. Revit will see if typeId corresponds to a loaded link in this document.

#### Parameter `typeId`

An element id. Revit will check if typeId corresponds to a loaded link in the given document.

#### Returns

True if typeId corresponds to a loaded RevitLinkType. False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.RevitLinkType.IsNotLoadedIntoMultipleOpenDocuments`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkType.IsNotLoadedIntoMultipleOpenDocuments`

#### Summary

Checks whether the link is loaded into more than one open document
in this session of Revit. If the link is loaded into multiple open
documents, reload will be disabled.

#### Remarks

Revit can open several documents which contain the same link. If
this is the case, Revit cannot reload the link, as doing
so would make changes to a non-active document. You will need to close
one or more documents in order to modify the link.

If the link is loaded into multiple documents across multiple sessions
of Revit, this function will return true. We only check the current session
of Revit. It is safe to reload a link which is loaded into multiple
sessions, as long as it is not loaded into more than one document
in any one session.

If this function returns true, it is safe to reload the link.

#### Returns

True if the link is loaded into at most one open document. False if the link
is loaded into more than one open document.

#### Since

2014

### `M:Autodesk.Revit.DB.RevitLinkType.RevertLocalUnloadStatus`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkType.RevertLocalUnloadStatus`

#### Summary

Restores the workshared load status of a link that has been unloaded only for the current user,
in a local copy of a workshared model.

#### Remarks

This function removes the local user's override of the link's workshared load status
(see UnloadLocally method). That is, if the link is loaded in the central model for
all worksharing users (and thus has been only unloaded for the local user), then this
method will perform a full reload of the link for the local user. If the link is
unloaded in the central model, then this method will simply clear the local user's
unload override, so that the link will be reloaded in the local user's model,
if it is ever reloaded in the central model.

This function should not be called on a Revit link:

in a document which is in an edit mode or is in family mode.

in a document which is in dynamic update.

in a document which is read only.

in a document in which there is transaction phase left open.

in a non-workshared file.

in a central model of workshared file.

which is nested.

which are not locally unloaded.

If the link is an external resource, Revit will contact the IExternalResourceServer
to get the latest version of the link.

#### Returns

The link's LinkedFileStatus that has resulted from reverting the local unloaded status.

#### Exception `T:Autodesk.Revit.Exceptions.FileAccessException`

The model cannot be accessed due to lack of access privileges.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

The element "this RevitLinkType" is in a ducument which is in dynamic update.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The element "this RevitLinkType" is in a family document or a document in in-place edit mode.
-or-
The element "this RevitLinkType" is in a document which is in an edit mode or is in family mode.
-or-
The element "this RevitLinkType" is in a read-only document.
-or-
This functionality is not available in Revit LT.
-or-
The element "this RevitLinkType" is in non-workshared document.
-or-
The element "this RevitLinkType" is not in a local model: the model is not workshared or it is central.
-or-
This RevitLinkType is not a top-level link.
-or-
The link is not locally unloaded.
-or-
There is a transaction phase left open (such as a transaction, sub-transaction of transaction group)
at the time of invoking this method.

#### Since

2016 Subscription Update

### `M:Autodesk.Revit.DB.RevitLinkType.Reload`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkType.Reload`

#### Summary

Loads or reloads the Revit link from its
currently-stored location. If the link is an
external resource, Revit will contact the
IExternalResourceServer to get the latest version
of the link.

#### Remarks

If the link is currently loaded, Revit must unload
the link before reloading it. Any changes made in-memory
to the link's shared coordinates will be discarded.

This function regenerates the document.

The document's Undo history will be cleared by this command.
As a result, this command and others executed before it cannot be undone.
All transaction phases (e.g. transactions transaction groups and sub-transaction)
that were explicitly started must be finished prior to calling this method.

This function is identical to RevitLinkType.Load() and is included for
convenience.

#### Returns

An object containing the ElementId of the link
and an enum value indicating any
errors which occurred while trying to load.
LinkLoadResultType.LinkLoaded indicates
success.

#### Exception `T:Autodesk.Revit.Exceptions.FileAccessException`

The model cannot be accessed due to lack of access privileges.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

The element "this RevitLinkType" is in a ducument which is in dynamic update.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The element "this RevitLinkType" is in a family document or a document in in-place edit mode.
-or-
The element "this RevitLinkType" is in a document which is in an edit mode or is in family mode.
-or-
The element "this RevitLinkType" is in a read-only document.
-or-
This RevitLinkType is not a top-level link.
-or-
The link "this RevitLinkType" is loaded into multiple documents and cannot be reloaded.
-or-
The element "this RevitLinkType" is in a closed workset.
-or-
There is a transaction phase left open (such as a transaction, sub-transaction of transaction group)
at the time of invoking this method.

#### Since

2015

### `M:Autodesk.Revit.DB.RevitLinkType.Load`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkType.Load`

#### Summary

Loads or reloads the Revit link from its
currently-stored location. If the link is an
external resource, Revit will contact the
IExternalResourceServer to get the latest version
of the link.

#### Remarks

If the link is currently loaded, Revit must unload
the link before reloading it. Any changes made in-memory
to the link's shared coordinates will be discarded.

This function regenerates the document.

The document's Undo history will be cleared by this command.
As a result, this command and others executed before it cannot be undone.
All transaction phases (e.g. transactions transaction groups and sub-transaction)
that were explicitly started must be finished prior to calling this method.

#### Returns

An object containing the ElementId of the link
and an enum value indicating any
errors which occurred while trying to load.
LinkLoadResultType.LinkLoaded indicates
success.

#### Exception `T:Autodesk.Revit.Exceptions.FileAccessException`

The model cannot be accessed due to lack of access privileges.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

The element "this RevitLinkType" is in a ducument which is in dynamic update.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The element "this RevitLinkType" is in a family document or a document in in-place edit mode.
-or-
The element "this RevitLinkType" is in a document which is in an edit mode or is in family mode.
-or-
The element "this RevitLinkType" is in a read-only document.
-or-
This RevitLinkType is not a top-level link.
-or-
The link "this RevitLinkType" is loaded into multiple documents and cannot be reloaded.
-or-
The element "this RevitLinkType" is in a closed workset.
-or-
There is a transaction phase left open (such as a transaction, sub-transaction of transaction group)
at the time of invoking this method.

#### Since

2014

### `M:Autodesk.Revit.DB.RevitLinkType.UpdateFromIFC(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ExternalResourceReference,System.String,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkType.UpdateFromIFC(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ExternalResourceReference,System.String,System.Boolean)`

#### Summary

Updates a Revit link type from an IFC file and loads the linked document.

#### Remarks

This function regenerates the input document.

While the options argument allows specification of a path type, the
input path argument must be a full path. Relative vs. absolute determines
how Revit will store the path, but it needs a complete path to find
the linked document initially.
Note that the IFC file will not be stored directly in the document; it will
instead by stored in an intermediate Revit document, whose location is given
by revitLinkedFilePath.

#### Parameter `document`

The document that contains Revit link.

#### Parameter `resourceReference`

An external resource reference describing the source of the IFC file used in creation.

#### Parameter `revitLinkedFilePath`

The path of the Revit file to create to hold the IFC information. This must be a full path.

#### Parameter `recreateLink`

If true, the Revit file will be updated based on the information in the IFC file. If false, the existing Revit file will be used.

#### Returns

Returns true if the update succeeded, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
The server referenced by the ExternalResourceReference does not exist or
does not implement IExternalResourceServer.
-or-
The server referenced by the ExternalResourceReference cannot support IFC links.
-or-
The ExternalResourceReference (resourceReference) is not in a format
that is supported by its server.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileAccessException`

The model cannot be accessed due to lack of access privileges.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The file is not allowed to access.
-or-
Revit cannot customize worksets for this model.

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

### `M:Autodesk.Revit.DB.RevitLinkType.UpdateFromIFC(Autodesk.Revit.DB.Document,System.String,System.String,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkType.UpdateFromIFC(Autodesk.Revit.DB.Document,System.String,System.String,System.Boolean)`

#### Summary

Updates a Revit link type from an IFC file and loads the linked document.

#### Remarks

This function regenerates the input document.

While the options argument allows specification of a path type, the
input path argument must be a full path. Relative vs. absolute determines
how Revit will store the path, but it needs a complete path to find
the linked document initially.
Note that the IFC file will not be stored directly in the document; it will
instead by stored in an intermediate Revit document, whose location is given
by revitLinkedFilePath.

#### Parameter `document`

The document that contains Revit link.

#### Parameter `ifcFilePath`

The path of the IFC link to load. This must be a full path.

#### Parameter `revitLinkedFilePath`

The path of the Revit file to create to hold the IFC information. This must be a full path.

#### Parameter `recreateLink`

If true, the Revit file will be updated based on the information in the IFC file. If false, the existing Revit file will be used.

#### Returns

Returns true if the update succeeded, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
The input path "ifcFilePath" does not represent an IFC file.
-or-
The document is a cloud model.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileAccessException`

The model cannot be accessed due to lack of access privileges.

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

There is not a valid Revit file at ifcFilePath's location

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The file is not allowed to access.
-or-
Revit cannot customize worksets for this model.

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

### `M:Autodesk.Revit.DB.RevitLinkType.CreateFromIFC(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ExternalResourceReference,System.String,System.Boolean,Autodesk.Revit.DB.RevitLinkOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkType.CreateFromIFC(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ExternalResourceReference,System.String,System.Boolean,Autodesk.Revit.DB.RevitLinkOptions)`

#### Summary

Creates a new Revit link type from an existing Revit file created via import by reference
of an asscoiated IFC file.

#### Remarks

This function is one of a series of steps necessary for linking an IFC file.
To understand how it is used in context, please download the IFC open source code,
and look in the Revit.IFC.Import project at Importer.ImportIFC(ImporterIFC importer),
under the IFCImportAction.Link branch.

This function regenerates the input document.

While the options argument allows specification of a path type, the
input path argument must be a full path. Relative vs. absolute determines
how Revit will store the path, but it needs a complete path to find
the linked document initially.

#### Parameter `document`

The document in which to create the Revit link.

#### Parameter `resourceReference`

An external resource reference describing the source of the IFC file used in creation.

#### Parameter `revitLinkedFilePath`

The path of the existing Revit file that contains elements created via an import by reference operation.
This must be a full path.

#### Parameter `recreateLink`

If true, the existing Revit file created via an import by reference operation
will be updated based on the information in the IFC file. If false, the existing Revit file will be used as-is.

#### Parameter `options`

An options class for loading Revit links.

#### Returns

An object containing the results of creating and loading
the Revit link type. It contains the ElementId of the new link.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
document already contains a linked model at path revitLinkedFilePath.
-or-
The server referenced by the ExternalResourceReference does not exist or
does not implement IExternalResourceServer.
-or-
The server referenced by the ExternalResourceReference cannot support IFC links.
-or-
The ExternalResourceReference (resourceReference) is not in a format
that is supported by its server.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileAccessException`

The model cannot be accessed due to lack of access privileges.

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

There is not a valid Revit file at revitLinkedFilePath's location

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The file is not allowed to access.
-or-
Revit cannot customize worksets for this model.

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

### `M:Autodesk.Revit.DB.RevitLinkType.CreateFromIFC(Autodesk.Revit.DB.Document,System.String,System.String,System.Boolean,Autodesk.Revit.DB.RevitLinkOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkType.CreateFromIFC(Autodesk.Revit.DB.Document,System.String,System.String,System.Boolean,Autodesk.Revit.DB.RevitLinkOptions)`

#### Summary

Creates a new Revit link type from an existing Revit file created via import by reference
of an asscoiated IFC file.

#### Remarks

This function is one of a series of steps necessary for linking an IFC file.
To understand how it is used in context, please download the IFC open source code,
and look in the Revit.IFC.Import project at Importer.ImportIFC(ImporterIFC importer),
under the IFCImportAction.Link branch.

This function regenerates the input document.

While the options argument allows specification of a path type, the
input path argument must be a full path. Relative vs. absolute determines
how Revit will store the path, but it needs a complete path to find
the linked document initially.

#### Parameter `document`

The document in which to create the Revit link.

#### Parameter `ifcFilePath`

The path of the associated IFC file. This must be a full path.

#### Parameter `revitLinkedFilePath`

The path of the existing Revit file that contains elements created via an import by reference operation.
This must be a full path.

#### Parameter `recreateLink`

If true, the existing Revit file created via an import by reference operation
will be updated based on the information in the IFC file. If false, the existing Revit file will be used as-is.

#### Parameter `options`

An options class for loading Revit links.

#### Returns

An object containing the results of creating and loading
the Revit link type. It contains the ElementId of the new link.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
The input path "ifcFilePath" does not represent an IFC file.
-or-
document already contains a linked model at path revitLinkedFilePath.
-or-
The document is a cloud model.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileAccessException`

The model cannot be accessed due to lack of access privileges.

#### Exception `T:Autodesk.Revit.Exceptions.FileArgumentNotFoundException`

There is not a valid Revit file at ifcFilePath's location
-or-
There is not a valid Revit file at revitLinkedFilePath's location

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The file is not allowed to access.
-or-
Revit cannot customize worksets for this model.

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

### `M:Autodesk.Revit.DB.RevitLinkType.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.RevitLinkOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkType.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ExternalResourceReference,Autodesk.Revit.DB.RevitLinkOptions)`

#### Summary

Creates a new Revit link type from an external resource reference and loads the
linked document.

#### Remarks

This function regenerates the input document.

Only the WorksetConfiguration information in the options argument
will be used. The path type information will be ignored.

#### Parameter `document`

The document in which to create the Revit link.

#### Parameter `resourceReference`

An external resource reference describing the source of the linked Revit document.

#### Parameter `options`

An options class for loading Revit links. The path type information will be ignored.

#### Returns

An object containing the results of creating and loading
the Revit link type. It contains the ElementId of the new link.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
The server referenced by the ExternalResourceReference does not exist or
does not implement IExternalResourceServer.
-or-
The server referenced by the ExternalResourceReference cannot support Revit links.
-or-
The ExternalResourceReference (resourceReference) is not in a format
that is supported by its server.
-or-
The link type referred to by the ExternalResourceReference "resourceReference" already exists
in the document. You cannot create another copy of the link type. You can create
instances with RevitLinkInstance.Create(), or reload the link using RevitLinkType.Reload().

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Revit cannot customize worksets for this model.

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

### `M:Autodesk.Revit.DB.RevitLinkType.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.RevitLinkOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkType.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ModelPath,Autodesk.Revit.DB.RevitLinkOptions)`

#### Summary

Creates a new Revit link type and loads the linked document.

#### Remarks

This function regenerates the input document.

While the options argument allows specification of a path type, the
input path argument must be a full path. Relative vs. absolute determines
how Revit will store the path, but it needs a complete path to find
the linked document initially.

#### Parameter `document`

The document in which to create the Revit link.

#### Parameter `path`

The path of the link to load. This may be a path of local disk, Revit Server or Cloud.
This must be a full path.

#### Parameter `options`

An options class for loading Revit links.

#### Returns

An object containing the results of creating and loading
the Revit link type. It contains the ElementId of the new link.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.
-or-
Server paths cannot be relative.
-or-
document already contains a linked model at path path.
-or-
The path to be linked in is empty.
-or-
The input path "path" does not represent a Revit model.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.FileAccessException`

The model cannot be accessed due to lack of access privileges.

#### Exception `T:Autodesk.Revit.Exceptions.FileNotFoundException`

The path to be linked in doesn't exist.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The model is not allowed to access.
-or-
Revit cannot customize worksets for this model.
-or-
Revit cannot link a cloud model to non-cloud model.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationForbiddenException`

The document is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The document is being loaded, or is in the midst of another
sensitive process.

#### Exception `T:Autodesk.Revit.Exceptions.ModificationOutsideTransactionException`

The document has no open transaction.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerInternalException`

Could be for any of the reasons that failed on service side.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthenticatedUserException`

User is not signed in with Autodesk id.

#### Exception `T:Autodesk.Revit.Exceptions.RevitServerUnauthorizedException`

User is not authorized to access the specified cloud model.

#### Since

2013

### `P:Autodesk.Revit.DB.RevitLinkType.LocallyUnloaded`

Member kind: property
Symbol: `Autodesk.Revit.DB.RevitLinkType.LocallyUnloaded`

#### Summary

Checks whether a Revit link in a local model is unloaded
only for the current user.

#### Remarks

Revit links can be unloaded for both the current user
and for all users.
If a Revit link is in a non-workshared file or in central model,
this property is false.

#### Since

2012

### `P:Autodesk.Revit.DB.RevitLinkType.AttachmentType`

Member kind: property
Symbol: `Autodesk.Revit.DB.RevitLinkType.AttachmentType`

#### Summary

The attachment/overlay status of this link.

#### Remarks

"Attachment" links are considered to be part of their parent
link and will be brought along if their parent is linked into
another document. "Overlay" links are only visible when their
parent is open directly.

For example: A user has a file B which contains a link C, and
they wish to link B into another file, A. If C is an overlay, C
will not be loaded into A. If C is an attachment, then C will
be loaded into A along with B.

#### Value

AttachmentType.Overlay if this link is an overlay,
AttachmentType.Attachment if this link is an attachment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: This RevitLinkType is not a top-level link.

#### Since

2012

### `P:Autodesk.Revit.DB.RevitLinkType.IsNestedLink`

Member kind: property
Symbol: `Autodesk.Revit.DB.RevitLinkType.IsNestedLink`

#### Summary

Indicates whether this link is a nested or top-level link.

#### Since

2012

### `P:Autodesk.Revit.DB.RevitLinkType.PathType`

Member kind: property
Symbol: `Autodesk.Revit.DB.RevitLinkType.PathType`

#### Summary

The type of path the link uses.

#### Remarks

You cannot change the PathType to or from PathType.Server. The
path type will change automatically if you call RevitLinkType.LoadFrom
with a Revit Server path.

Links from external resource servers are considered to have no path
type. Attempts to access this property for an external server link
will result in an exception.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The PathType of the Revit link cannot be determined (or set), because it was
not loaded from a local disk drive or from Revit Server.
-or-
When setting this property: The PathType for the link is not valid. PathType.Content is never
valid for a Revit link. To change the type to or from PathType.Server,
use RevitLinkType.LoadFrom and pick a server or file path.

#### Since

2014

### `T:Autodesk.Revit.DB.RevitLinkType`

Member kind: type
Symbol: `Autodesk.Revit.DB.RevitLinkType`

#### Summary

This class represents another Revit Document ("link") brought into
the current one ("host").

#### Remarks

Revit links can be nested - There can exist linked files which themselves contain
links. A "top-level" link is one linked directly into the host, while a
"nested" link is linked into some parent link. This can go through
arbitrarily many layers.

Some functions give the example "A -> B -> C". This means that there is
a host file, A, which has a top-level link, B, and a nested link C which
has been linked into B as an attachment.

#### Since

2012

### `P:Autodesk.Revit.DB.RevitLinkGraphicsSettings.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.RevitLinkGraphicsSettings.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.RevitLinkGraphicsSettings.LinkVisibilityType`

Member kind: property
Symbol: `Autodesk.Revit.DB.RevitLinkGraphicsSettings.LinkVisibilityType`

#### Summary

The visibility type of RevitLinkGraphicsSettings.
If the type is set to `F:Autodesk.Revit.DB.LinkVisibility.ByHostView` or
`F:Autodesk.Revit.DB.LinkVisibility.ByLinkView` , then the dependent properties
of RevitLinkGraphicsSettings will be reset to their default state. The state of dependent properties can be changed later.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2024

### `P:Autodesk.Revit.DB.RevitLinkGraphicsSettings.LinkedViewId`

Member kind: property
Symbol: `Autodesk.Revit.DB.RevitLinkGraphicsSettings.LinkedViewId`

#### Summary

The id of the linked view associated with this RevitLinkGraphicsSettings,
or `P:Autodesk.Revit.DB.ElementId.InvalidElementId` if no view is selected.
If the `P:Autodesk.Revit.DB.RevitLinkGraphicsSettings.LinkVisibilityType` is set to
`F:Autodesk.Revit.DB.LinkVisibility.ByLinkView` , then there must be a valid LinkedViewId.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2024

### `M:Autodesk.Revit.DB.RevitLinkGraphicsSettings.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.RevitLinkGraphicsSettings.#ctor`

#### Summary

Creates a new RevitLinkGraphicsSettings instance.

#### Since

2024

### `T:Autodesk.Revit.DB.RevitLinkGraphicsSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.RevitLinkGraphicsSettings`

#### Summary

Settings to override display of Revit link in a view.

#### Since

2024

### `T:Autodesk.Revit.DB.LinkVisibility`

Member kind: type
Symbol: `Autodesk.Revit.DB.LinkVisibility`

#### Summary

Link visibility types.

#### Since

2024

### `M:Autodesk.Revit.DB.LinkConversionData.GetOptions`

Member kind: method
Symbol: `Autodesk.Revit.DB.LinkConversionData.GetOptions`

#### Summary

Extra information used during the creation of the Revit document.

#### Returns

The extra information used during the creation of the Revit document.

#### Since

2015

### `P:Autodesk.Revit.DB.LinkConversionData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.LinkConversionData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.LinkConversionData.Path`

Member kind: property
Symbol: `Autodesk.Revit.DB.LinkConversionData.Path`

#### Summary

The path to the source data used to generate the model.

#### Since

2015

### `P:Autodesk.Revit.DB.LinkConversionData.ServerId`

Member kind: property
Symbol: `Autodesk.Revit.DB.LinkConversionData.ServerId`

#### Summary

The service responsible for converting the data into a Revit file.

#### Since

2015

### `T:Autodesk.Revit.DB.LinkConversionData`

Member kind: type
Symbol: `Autodesk.Revit.DB.LinkConversionData`

#### Summary

This class contains the information necessary to re-create a Revit document
from an external source.

#### Since

2015

### `M:Autodesk.Revit.DB.RuledSurface.GetSecondProfilePoint`

Member kind: method
Symbol: `Autodesk.Revit.DB.RuledSurface.GetSecondProfilePoint`

#### Summary

If a point was used to define the second profile, returns a copy of that point.

#### Returns

The second profile point if it was set.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This surface element does not use a point to define the second profile.

#### Since

2017

### `M:Autodesk.Revit.DB.RuledSurface.HasSecondProfilePoint`

Member kind: method
Symbol: `Autodesk.Revit.DB.RuledSurface.HasSecondProfilePoint`

#### Summary

Checks if a point was used to define the second profile.

#### Returns

True if a point was used to define the second profile, false otherwise.

#### Since

2018

### `M:Autodesk.Revit.DB.RuledSurface.GetSecondProfileCurve`

Member kind: method
Symbol: `Autodesk.Revit.DB.RuledSurface.GetSecondProfileCurve`

#### Summary

Returns a copy of the second profile curve if it is set.

#### Returns

A copy of the second profile curve, if it exists. If a point was used to define the second profile, this function will return `null` .

#### Since

2017

### `M:Autodesk.Revit.DB.RuledSurface.GetFirstProfilePoint`

Member kind: method
Symbol: `Autodesk.Revit.DB.RuledSurface.GetFirstProfilePoint`

#### Summary

If a point was used to define the first profile, returns a copy of that point.

#### Returns

The first profile point if it was set.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This surface element does not use a point to define the first profile.

#### Since

2017

### `M:Autodesk.Revit.DB.RuledSurface.HasFirstProfilePoint`

Member kind: method
Symbol: `Autodesk.Revit.DB.RuledSurface.HasFirstProfilePoint`

#### Summary

Checks if a point was used to define the first profile.

#### Returns

True if a point was used to define the first profile, false otherwise.

#### Since

2018

### `M:Autodesk.Revit.DB.RuledSurface.GetFirstProfileCurve`

Member kind: method
Symbol: `Autodesk.Revit.DB.RuledSurface.GetFirstProfileCurve`

#### Summary

Returns a copy of the first profile curve if it is set.

#### Returns

A copy of the first profile curve, if it exists. If a point was used to define the first profile, this function will return `null` .

#### Since

2017

### `M:Autodesk.Revit.DB.RuledSurface.Create(Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RuledSurface.Create(Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a Surface object coincident with the ruled surface joining a bounded generating curve to a point.

#### Remarks

The returned surface may not be of type RuledSurf - this function will create a surface of the simplest possible
type (Plane, CylindricalSurface, etc.) that can be used to represent the given ruled surface.
Given that the surface may be simplified, this function does not guarantee any particular parameterization of the surface.

#### Parameter `profileCurve`

The profile curve; must be bounded and non-degenerate.

#### Parameter `point`

The point. Expected to lie within the Revit design limits `M:Autodesk.Revit.DB.XYZ.IsWithinLengthLimits(Autodesk.Revit.DB.XYZ)` .

#### Returns

The created surface. Note that this surface may not be of type RuledSurf.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input profileCurve is not bound.
-or-
The profileCurve is degenerate (its length is too close to zero).
-or-
The input point lies outside of Revit design limits.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.RuledSurface.Create(Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.Curve)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RuledSurface.Create(Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.Curve)`

#### Summary

Creates a Surface object coincident with the ruled surface joining two bounded generating curves.

#### Remarks

The returned surface may not be of type RuledSurf - this function will create a surface of the simplest possible
type (Plane, CylindricalSurface, etc.) that can be used to represent the given ruled surface.
Given that the surface may be simplified, this function does not guarantee any particular parameterization of the surface.
The curves should be such that a ruled surface whose rulings connect points on the two curves with the same
normalized coordinates has no self-intersections or interior singularities.

#### Parameter `profileCurve1`

The first profile curve; must be bounded and non-degenerate.

#### Parameter `profileCurve2`

The second profile curve; must be bounded and non-degenerate.

#### Returns

The created surface. Note that this surface may not be of type RuledSurf.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input profileCurve1 is not bound.
-or-
The profileCurve1 is degenerate (its length is too close to zero).
-or-
The input profileCurve2 is not bound.
-or-
The profileCurve2 is degenerate (its length is too close to zero).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `T:Autodesk.Revit.DB.RuledSurface`

Member kind: type
Symbol: `Autodesk.Revit.DB.RuledSurface`

#### Summary

A ruled surface is created by sweeping a line between two profile curves or between a curve and a point (a point and a curve).
Input curve(s) must be bounded or have natural bounds.

#### Remarks

Both curves are evaluated in normalized parameters [0, 1]
The parametric equations of a ruled surface are:
Curve C1 and curve C2 : S(u, v) = C1(u) + v * (C2(u) - C1(u));

Point P1 and curve C2 : S(u, v) = P1 + v * (C2(u) - P1);

Curve C1 and point P2 : S(u, v) = C1(u) + v * (P2 - C1(u));
The point/point case is not allowed as that would define a degenerate ruled surface.

#### Since

2017

### `M:Autodesk.Revit.DB.RoutingPreferenceRule.RemoveCriteron(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RoutingPreferenceRule.RemoveCriteron(System.Int32)`

#### Summary

Removes an existing criterion.

#### Parameter `index`

The index position of removed routing preference rule in the group.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

index is not a valid zero-based index.
-or-
Thrown if the index is out of bounds.

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2013

### `M:Autodesk.Revit.DB.RoutingPreferenceRule.AddCriterion(Autodesk.Revit.DB.RoutingCriterionBase)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RoutingPreferenceRule.AddCriterion(Autodesk.Revit.DB.RoutingCriterionBase)`

#### Summary

Adds a new routing criterion.

#### Parameter `myCriterion`

The criterion to add.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2013

### `M:Autodesk.Revit.DB.RoutingPreferenceRule.GetCriterion(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RoutingPreferenceRule.GetCriterion(System.Int32)`

#### Summary

Gets the specified criteria.

#### Returns

The criterion at the specified zero-based index position.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

index is not a valid zero-based index.
-or-
Thrown if the index is out of bounds.

#### Since

2013

### `P:Autodesk.Revit.DB.RoutingPreferenceRule.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.RoutingPreferenceRule.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.RoutingPreferenceRule.RoutingPreferenceManager`

Member kind: property
Symbol: `Autodesk.Revit.DB.RoutingPreferenceRule.RoutingPreferenceManager`

#### Summary

Gets the routing preference manager that owns this rule.

#### Since

2013

### `P:Autodesk.Revit.DB.RoutingPreferenceRule.NumberOfCriteria`

Member kind: property
Symbol: `Autodesk.Revit.DB.RoutingPreferenceRule.NumberOfCriteria`

#### Summary

Gets the number of routing criteria.

#### Since

2013

### `P:Autodesk.Revit.DB.RoutingPreferenceRule.MEPPartId`

Member kind: property
Symbol: `Autodesk.Revit.DB.RoutingPreferenceRule.MEPPartId`

#### Summary

The referenced MEPPart (segment or fitting) type in this rule. It may be InvalidElementId if no MEPPart will be allowed when the conditions satisfy the criteria in this rule.

#### Since

2013

### `P:Autodesk.Revit.DB.RoutingPreferenceRule.Description`

Member kind: property
Symbol: `Autodesk.Revit.DB.RoutingPreferenceRule.Description`

#### Summary

The description of the routing preference rule.

#### Since

2013

### `M:Autodesk.Revit.DB.RoutingPreferenceRule.#ctor(Autodesk.Revit.DB.ElementId,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RoutingPreferenceRule.#ctor(Autodesk.Revit.DB.ElementId,System.String)`

#### Summary

Constructs a RoutingPreferenceRule containing a segment or fitting Id (MEPPartId) and description.

#### Parameter `MEPPartId`

The Id of the segment or fitting. InvalidElementId may be specified if no MEPPart will be allowed when the conditions satisfy the criteria in this rule.

#### Parameter `description`

The description of the rule.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `T:Autodesk.Revit.DB.RoutingPreferenceRule`

Member kind: type
Symbol: `Autodesk.Revit.DB.RoutingPreferenceRule`

#### Summary

A class representing a rule set in MEP routing preferences.

#### Since

2013

### `M:Autodesk.Revit.DB.RoutingCriterionBase.IsEqual(Autodesk.Revit.DB.RoutingCriterionBase)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RoutingCriterionBase.IsEqual(Autodesk.Revit.DB.RoutingCriterionBase)`

#### Summary

Verify if two criteria are the same.

#### Returns

True if the criterion is equal to the other, false otherwise

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.RoutingCriterionBase.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.RoutingCriterionBase.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.RoutingCriterionBase`

Member kind: type
Symbol: `Autodesk.Revit.DB.RoutingCriterionBase`

#### Summary

RoutingCriteriaBase is the base class for all routing criteria.

#### Since

2013

### `M:Autodesk.Revit.DB.RoutingConditions.GetConditionAt(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RoutingConditions.GetConditionAt(System.Int32)`

#### Summary

Gets the routing condition at the specified index position.

#### Parameter `index`

The 0-based index to access the collection of available conditions. The method throws the exception ArgumentOutOfRangeException if the index is out of range.

#### Returns

The found routing condition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

index is not within the valid range of available conditions.

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2013

### `M:Autodesk.Revit.DB.RoutingConditions.AppendCondition(Autodesk.Revit.DB.RoutingCondition)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RoutingConditions.AppendCondition(Autodesk.Revit.DB.RoutingCondition)`

#### Summary

Appends a routing condition to the end of existing routing conditions. Note that the first item (indexed at 0) is the condition for the primary connector.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2013

### `M:Autodesk.Revit.DB.RoutingConditions.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.RoutingConditions.Clear`

#### Summary

Clear all existing conditions

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2013

### `M:Autodesk.Revit.DB.RoutingConditions.GetNumberOfConditions`

Member kind: method
Symbol: `Autodesk.Revit.DB.RoutingConditions.GetNumberOfConditions`

#### Summary

Gets the number of included routing conditions.

#### Since

2013

### `P:Autodesk.Revit.DB.RoutingConditions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.RoutingConditions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.RoutingConditions.PreferredJunctionType`

Member kind: property
Symbol: `Autodesk.Revit.DB.RoutingConditions.PreferredJunctionType`

#### Summary

The junction type (Tee or Tap) to select if defined fittings of both junction types meet all routing conditions.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

When setting this property: None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2013

### `P:Autodesk.Revit.DB.RoutingConditions.ErrorLevel`

Member kind: property
Symbol: `Autodesk.Revit.DB.RoutingConditions.ErrorLevel`

#### Summary

The error level that the routing preference manager should post errors if the routing conditions do not meet any routing preference rule, could be None, Warning, or Error

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

When setting this property: None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2013

### `M:Autodesk.Revit.DB.RoutingConditions.#ctor(Autodesk.Revit.DB.RoutingPreferenceErrorLevel)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RoutingConditions.#ctor(Autodesk.Revit.DB.RoutingPreferenceErrorLevel)`

#### Summary

Constructs a new instance of a RoutingConditions object with an indicated
error level for conditions that do not meet any routing preference rule.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `T:Autodesk.Revit.DB.RoutingConditions`

Member kind: type
Symbol: `Autodesk.Revit.DB.RoutingConditions`

#### Summary

RoutingConditions contain routing information that is used as input when determining if a routing criterion,
such as minimum or maximum diameter, is met.

#### Since

2013

### `T:Autodesk.Revit.DB.RoutingPreferenceErrorLevel`

Member kind: type
Symbol: `Autodesk.Revit.DB.RoutingPreferenceErrorLevel`

#### Since

2013

#### Summary

An enumerated type listing the options for posting errors or warnings when routing preferences are not satisfied.

#### Since

2013

### `F:Autodesk.Revit.DB.RoutingPreferenceErrorLevel.Error`

Member kind: field
Symbol: `Autodesk.Revit.DB.RoutingPreferenceErrorLevel.Error`

#### Summary

Post Revit errors if there is no rule in the routing preference satisfying the current condition.

### `F:Autodesk.Revit.DB.RoutingPreferenceErrorLevel.Warning`

Member kind: field
Symbol: `Autodesk.Revit.DB.RoutingPreferenceErrorLevel.Warning`

#### Summary

Post Revit warnings if there is no rule in the routing preference satisfying the current condition.

### `F:Autodesk.Revit.DB.RoutingPreferenceErrorLevel.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.RoutingPreferenceErrorLevel.None`

#### Summary

Do not post any warning or error if there is no rule in the routing preference satisfying the current condition.

### `P:Autodesk.Revit.DB.RoutingCondition.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.RoutingCondition.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.RoutingCondition.Diameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.RoutingCondition.Diameter`

#### Summary

The diameter of the segment or fitting specified for the routing condition.

#### Since

2013

### `M:Autodesk.Revit.DB.RoutingCondition.#ctor(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.RoutingCondition.#ctor(System.Double)`

#### Summary

Creates a new RoutingCondition.

#### Parameter `diameter`

The diameter of a routing segment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for diameter must be greater than 0 and no more than 30000 feet.

#### Since

2013

### `T:Autodesk.Revit.DB.RoutingCondition`

Member kind: type
Symbol: `Autodesk.Revit.DB.RoutingCondition`

#### Summary

RoutingCondition represents routing information that is used as input when determining if a routing criterion,
such as minimum or maximum diameter, is met.

#### Since

2013

### `M:Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.PathPointsAreTooClose(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Document,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.PathPointsAreTooClose(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.Document,System.Double)`

#### Summary

Returns true if the two points are too close to be adjacent start, end or waypoints in a PathOfTravel.

#### Remarks

The points are too close when the distance between them is closer than the length
specified by `P:Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.MinimumLength` plus a certain tolerance.

#### Parameter `cda`

The document for which to compare the two points.

#### Parameter `tolerance`

The tolerance to add to the minimum distance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2020

### `M:Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.IsLargeGeometryAllowed`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.IsLargeGeometryAllowed`

#### Summary

Returns if large geometry is allowed for path of travel creation or not.

#### Remarks

The return value is based off the current setting for the AllowLargeGeometry Property as follows:
If it is set to Prompt, then prompts the user to continue or not, if no ui is present, returns false.

If it is set to DisAllaow, returns false.

If it is set to Allow, returns true.

#### Since

2020

### `M:Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.SetIgnoredCategoryIds(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.SetIgnoredCategoryIds(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Sets the ElementIds for Category elements which are ignored by route calculation.

#### Parameter `categoryIds`

The ids of Categories to be ignored by route calculation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One or more ElementIds in categoryIds are not valid Category element ids.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2020

### `M:Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.GetExcludedCategoryIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.GetExcludedCategoryIds`

#### Summary

Returns ElementIds for Category elements which are excluded (not taken into account) by route calculation.
These categories are always excluded, regardless of the `P:Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.EnableIgnoredCategoryIds` value.
If an excluded category has sub-categories, then the sub-categories will be excluded as well.

#### Returns

The ids of Categories which are excluded by route calculation.

#### Since

2020

### `M:Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.GetIgnoredCategoryIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.GetIgnoredCategoryIds`

#### Summary

Returns ElementIds for Category elements which are ignored (not taken into account) route calculation.
To enable ignoring of these categories, `P:Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.EnableIgnoredCategoryIds` must be set to true.
If an ignored category has sub-categories, then the sub-categories will be ignored as well.

#### Returns

The ids of Categories which are ignored by route calculation. By default, the set contains the Doors Category.

#### Since

2020

### `M:Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.GetRouteAnalysisSettings(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.GetRouteAnalysisSettings(Autodesk.Revit.DB.Document)`

#### Summary

Returns the RouteAnalysisSettings element for a given document.

#### Remarks

Project documents have a RouteAnalysisSettings element, one per document.
Family documents do not have RouteAnalysisSettings elements.

#### Parameter `cda`

The document for which to get the RouteAnalysisSettings element.

#### Returns

Returns the RouteAnalysisSettings element in project documents
or `null` for family documents
.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2020

### `P:Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.TravelSpeed`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.TravelSpeed`

#### Summary

The average speed that people will be traveling along the created path of travel. Default value is 4.4 ft/s (3 mph)

#### Remarks

The speed value is stored in terms of Revit internal SI Units, which is feet per second.
To convert between desired and internal units `!:Autodesk::Revit::DB::UnitUtils` .

#### Since

2020

### `P:Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.MinimumLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.MinimumLength`

#### Summary

The constant storing minimum allowed length of path of travel

#### Since

2020

### `P:Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.AnalysisZoneTopOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.AnalysisZoneTopOffset`

#### Summary

The top plane offset, in ft, for the zone used in route calculation. Default value is 6'8".

#### Remarks

The zone's top plane elevation is different per plan view
and is determined by adding the top offset to the view's level elevation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for topOffset must be non-negative.

#### Since

2020

### `P:Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.AnalysisZoneBottomOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.AnalysisZoneBottomOffset`

#### Summary

The bottom plane offset, in ft, of the zone used in route calculation. Default value is 8".

#### Remarks

The zone's bottom plane elevation is different per plan view
and is determined by adding the bottom offset to the view's level elevation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for bottomOffset must be non-negative.

#### Since

2020

### `P:Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.IgnoreImports`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.IgnoreImports`

#### Summary

If true, import instances are ignored by route calculation.
For imports to be ignored, also `P:Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.EnableIgnoredCategoryIds` must be set to true.

#### Since

2020

### `P:Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.EnableIgnoredCategoryIds`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.EnableIgnoredCategoryIds`

#### Summary

When this setting is true, elements with category ids returned by
`M:Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.GetIgnoredCategoryIds` will be ignored in route calculation.
default is true as all elements with the Door Category Id are ignored by default.

#### Since

2020

### `T:Autodesk.Revit.DB.Analysis.RouteAnalysisSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.RouteAnalysisSettings`

#### Summary

RouteAnalysisSettings is an element which contains project-wide settings for route calculations.
The `!:Autodesk::Revit::DB::Analysis::PathOfTravel` element uses these settings to calculate a route between two points in a plan view.

By default, the route will go around the geometry of all visible model elements which have model geometry in the Route Analysis Zone.

The Route Analysis Zone, determined per view, is the space between these two horizontal planes:
a top plane vertically offset by `P:Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.AnalysisZoneTopOffset` above the view's level and
a bottom plane vertically offset by `P:Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.AnalysisZoneBottomOffset` ft above the view's level.

By default, the route will ignore the following elements:
elements outside of the crop region of the view;

elements without any model geometry (annotations or view-specific elements);

model lines (category OST_Lines);

demolished elements;

elements displayed in the underlay of the view.
There are a few ways to customize Route Analysis on a project-wide basis.

You can adjust the Route Analysis Zone using `P:Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.AnalysisZoneTopOffset`
and `P:Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.AnalysisZoneBottomOffset` .

You can specify a set of model categories you would like ignored during route calculation.
To enable ignoring the set of specified categories, set `P:Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.EnableIgnoredCategoryIds` to true.
To change the set of ignored categories, use `M:Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.SetIgnoredCategoryIds(System.Collections.Generic.ICollection`1{Autodesk.Revit.DB.ElementId})` method
and `P:Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.IgnoreImports` and `!:IgnorePointClouds` properties.
To query the set of ignored categories, use `M:Autodesk.Revit.DB.Analysis.RouteAnalysisSettings.GetIgnoredCategoryIds` .

#### Since

2020

### `T:Autodesk.Revit.DB.Analysis.AllowLargeGeometry`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.AllowLargeGeometry`

#### Summary

An enumerated type containing settings information related to handling of large geometries.

#### Since

2020

#### Since

2020

### `F:Autodesk.Revit.DB.Analysis.AllowLargeGeometry.Prompt`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.AllowLargeGeometry.Prompt`

#### Summary

Prompt in the UI. If no UI is present, default will be DisAllow.

### `F:Autodesk.Revit.DB.Analysis.AllowLargeGeometry.Allow`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.AllowLargeGeometry.Allow`

#### Summary

Allow export/path of travel creation on large geometries.

### `F:Autodesk.Revit.DB.Analysis.AllowLargeGeometry.DisAllow`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.AllowLargeGeometry.DisAllow`

#### Summary

Cancel the export/path of travel creation, failing with the apporiate status.

### `M:Autodesk.Revit.DB.SpatialElementGeometryCalculator.GetOptions`

Member kind: method
Symbol: `Autodesk.Revit.DB.SpatialElementGeometryCalculator.GetOptions`

#### Summary

The options that control the calculation.

#### Returns

The options.

#### Since

2012

### `M:Autodesk.Revit.DB.SpatialElementGeometryCalculator.CanCalculateGeometry(Autodesk.Revit.DB.SpatialElement)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SpatialElementGeometryCalculator.CanCalculateGeometry(Autodesk.Revit.DB.SpatialElement)`

#### Summary

This indicates whether the input spatial element is a valid one.

#### Parameter `spatialElement`

The spatial element to be checked if its geometry can be calculated.

#### Returns

It will return false if the room/space is not enclosed in 2d or has no location, or the height is too small.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.SpatialElementGeometryCalculator.IsRoomOrSpace(Autodesk.Revit.DB.SpatialElement)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SpatialElementGeometryCalculator.IsRoomOrSpace(Autodesk.Revit.DB.SpatialElement)`

#### Summary

This indicates whether the input spatial element is a room or a space.

#### Parameter `spatialElement`

The spatial element to be checked if it is a room or a space or not.

#### Returns

True if the input spatial element is a room or a space, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.SpatialElementGeometryCalculator.CalculateSpatialElementGeometry(Autodesk.Revit.DB.SpatialElement)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SpatialElementGeometryCalculator.CalculateSpatialElementGeometry(Autodesk.Revit.DB.SpatialElement)`

#### Summary

Compute the spatial element geometry and returns the boundary face information.

#### Parameter `spatialElement`

Specifies the spatial element needs to be computed, should be Room or Space.

#### Returns

Requested boundary face information.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

spatialElement is not a room or a space, and thus has no 3D geometry to calculate.
-or-
spatialElement is not enclosed in 2d or has no location, or the height is too small, and thus has no 3D geometry to calculate.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to compute the given spatial element's geometry.

#### Since

2012

### `P:Autodesk.Revit.DB.SpatialElementGeometryCalculator.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElementGeometryCalculator.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.SpatialElementGeometryCalculator.#ctor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.SpatialElementBoundaryOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SpatialElementGeometryCalculator.#ctor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.SpatialElementBoundaryOptions)`

#### Summary

Constructs a new calculator for the geometry of spatial elements.

#### Parameter `aDoc`

The document that contains the spatial elements.

#### Parameter `options`

The options to control the calculation rules.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

options is not valid. Only Finish and Center of SpatialElementBoundaryLocation are allowed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.SpatialElementGeometryCalculator.#ctor(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SpatialElementGeometryCalculator.#ctor(Autodesk.Revit.DB.Document)`

#### Summary

Constructs a new calculator with default options for the geometry of spatial elements.

#### Parameter `aDoc`

The document that contains the spatial elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.SpatialElementGeometryCalculator`

Member kind: type
Symbol: `Autodesk.Revit.DB.SpatialElementGeometryCalculator`

#### Summary

Use this class to calculate the geometry of a spatial element and obtain the relationships between the geometry and
the element's boundary elements.

#### Remarks

This class maintains an internal cache for geometry it has already processed. If you intend to calculate geometry
for several elements in the same project you should use a single instance of this class. Note that the cache will
be cleared when any change is made to the document.

#### Since

2012

### `M:Autodesk.Revit.DB.SpatialElementGeometryResults.GetBoundaryFaceInfo(Autodesk.Revit.DB.Face)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SpatialElementGeometryResults.GetBoundaryFaceInfo(Autodesk.Revit.DB.Face)`

#### Summary

Query the spatial element boundary face information with the given face.

#### Parameter `face`

The face from the spatial element's geometry.

#### Returns

Sub-faces related to the room bounding elements that define the spatial element face. Returns `null` if there is no corresponding boundary information with the given face.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.SpatialElementGeometryResults.GetGeometry`

Member kind: method
Symbol: `Autodesk.Revit.DB.SpatialElementGeometryResults.GetGeometry`

#### Summary

The solid from the spatial element.

#### Returns

Requested solid.

#### Since

2012

### `P:Autodesk.Revit.DB.SpatialElementGeometryResults.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElementGeometryResults.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.SpatialElementGeometryResults`

Member kind: type
Symbol: `Autodesk.Revit.DB.SpatialElementGeometryResults`

#### Summary

The results of spatial element geometry calculation.

#### Remarks

The subfaces of a SpatialElement at the base height and top height are not associated with floors, roofs, and ceilings at the same height.

#### Since

2012

### `M:Autodesk.Revit.DB.SpatialElementBoundarySubface.GetBoundingElementFace`

Member kind: method
Symbol: `Autodesk.Revit.DB.SpatialElementBoundarySubface.GetBoundingElementFace`

#### Summary

Returns the face of the bounding element.

#### Remarks

Applies only if the options chosen for the extraction of the element's geometry is Finish.
Faces do not contain voids in room-bounding elements (such the voids in walls created by doors and windows).

#### Returns

The face of the bounding element.

#### Since

2012

### `M:Autodesk.Revit.DB.SpatialElementBoundarySubface.GetSubface`

Member kind: method
Symbol: `Autodesk.Revit.DB.SpatialElementBoundarySubface.GetSubface`

#### Summary

Returns a face that represents the portion of the room face bounded by the boundary element.

#### Remarks

If the spatial element's face is adjacent to multiple bounding elements (such as two different walls), there will be one sub-face
for each portion of the spatial element's face where it is adjacent to one of those room-bounding elements.
This is equivalent to the return of GetRoomFace() if the entire room face is created by the boundary element.

#### Returns

The sub-face.

#### Since

2012

### `M:Autodesk.Revit.DB.SpatialElementBoundarySubface.GetSpatialElementFace`

Member kind: method
Symbol: `Autodesk.Revit.DB.SpatialElementBoundarySubface.GetSpatialElementFace`

#### Summary

Returns the face of the spatial element's 3D geometry.

#### Returns

The face of the spatial element's 3D geometry.

#### Since

2012

### `P:Autodesk.Revit.DB.SpatialElementBoundarySubface.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElementBoundarySubface.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.SpatialElementBoundarySubface.Valid`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElementBoundarySubface.Valid`

#### Summary

Indicates if the subface instance is valid and can be used.

#### Since

2012

### `P:Autodesk.Revit.DB.SpatialElementBoundarySubface.SubfaceType`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElementBoundarySubface.SubfaceType`

#### Summary

Type of the subface.

#### Since

2012

### `P:Autodesk.Revit.DB.SpatialElementBoundarySubface.SubfaceArisesFromElementFace`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElementBoundarySubface.SubfaceArisesFromElementFace`

#### Summary

Indicates if the subface is coincident with a portion of a (possibly offset) face of the element.

#### Since

2012

### `P:Autodesk.Revit.DB.SpatialElementBoundarySubface.SpatialBoundaryElement`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElementBoundarySubface.SpatialBoundaryElement`

#### Summary

Element that gave rise to this room face.

#### Since

2012

### `T:Autodesk.Revit.DB.SpatialElementBoundarySubface`

Member kind: type
Symbol: `Autodesk.Revit.DB.SpatialElementBoundarySubface`

#### Summary

SpatialElementBoundarySubface represents the geometry boundary information of spatial element.

#### Since

2012

### `T:Autodesk.Revit.DB.SubfaceType`

Member kind: type
Symbol: `Autodesk.Revit.DB.SubfaceType`

#### Since

2012

#### Summary

Meaning of a subface's type.

#### Since

2012

### `F:Autodesk.Revit.DB.SubfaceType.Side`

Member kind: field
Symbol: `Autodesk.Revit.DB.SubfaceType.Side`

#### Summary

Any face which does not meet the criteria to be Top or Bottom.

### `F:Autodesk.Revit.DB.SubfaceType.Top`

Member kind: field
Symbol: `Autodesk.Revit.DB.SubfaceType.Top`

#### Summary

A horizontal top face of the room as defined by the room's level and height, or a face of the
room that is bounded above by a room-bounding element.

### `F:Autodesk.Revit.DB.SubfaceType.Bottom`

Member kind: field
Symbol: `Autodesk.Revit.DB.SubfaceType.Bottom`

#### Summary

A horizontal face at the bottom of the room, as defined by the room's level and base offset, or
a face of the room that is bounded below by a room-bounding element.

### `M:Autodesk.Revit.DB.SpatialElementFromToCalculationPoints.IsAcceptableToPosition(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SpatialElementFromToCalculationPoints.IsAcceptableToPosition(Autodesk.Revit.DB.XYZ)`

#### Summary

Checks whether a given "to" position is valid.

#### Remarks

The "from" position and the "to" position must be on opposite sides of the family's host. Flipping the calculation
point will reverse the direction.

#### Returns

True if the input is an acceptable "to" position and False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.SpatialElementFromToCalculationPoints.IsAcceptableFromPosition(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SpatialElementFromToCalculationPoints.IsAcceptableFromPosition(Autodesk.Revit.DB.XYZ)`

#### Summary

Checks whether a given "from" position is valid.

#### Remarks

The "from" position and the "to" position must be on opposite sides of the family's host. Flipping the calculation
point will reverse the direction.

#### Returns

True if the input is an acceptable "from" position and False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.SpatialElementFromToCalculationPoints.MakeToPositionAcceptable(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SpatialElementFromToCalculationPoints.MakeToPositionAcceptable(Autodesk.Revit.DB.XYZ)`

#### Summary

This function takes a potential "to" point and converts it to be a similar point on the opposite side of the family's host from
the "from" point if necessary.

#### Remarks

If the point is already an acceptable "to" location then the original point will be returned. Otherwise, the point's
X and Y will be projected onto the centerline of the family's host.

#### Parameter `newToLocation`

The desired "to" location

#### Returns

The valid "to" location.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.SpatialElementFromToCalculationPoints.MakeFromPositionAcceptable(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SpatialElementFromToCalculationPoints.MakeFromPositionAcceptable(Autodesk.Revit.DB.XYZ)`

#### Summary

This function takes a potential "from" point and converts it to be a similar point on the opposite side of the family's host from
the "to" point if necessary.

#### Remarks

If the point is already an acceptable "from" location then the original point will be returned. Otherwise, the point's
X and Y will be projected onto the centerline of the family's host.

#### Parameter `newFromLocation`

The desired "from" location

#### Returns

The valid "from" location.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.SpatialElementFromToCalculationPoints.Flip`

Member kind: method
Symbol: `Autodesk.Revit.DB.SpatialElementFromToCalculationPoints.Flip`

#### Summary

flip the direction of the "from" and "to" points

#### Since

2014

### `P:Autodesk.Revit.DB.SpatialElementFromToCalculationPoints.ToPosition`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElementFromToCalculationPoints.ToPosition`

#### Summary

The "to" position of spatial element connecting calculation point.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: toPosition must be on the opposite side of the family's host from the "from" position.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.SpatialElementFromToCalculationPoints.FromPosition`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElementFromToCalculationPoints.FromPosition`

#### Summary

The "from" position of spatial element connecting calculation point.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: fromPosition must be on the opposite side of the family's host from the "to" position.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `T:Autodesk.Revit.DB.SpatialElementFromToCalculationPoints`

Member kind: type
Symbol: `Autodesk.Revit.DB.SpatialElementFromToCalculationPoints`

#### Summary

SpatialElementFromToCalculationPoints is used to specify the search points for a family instance which connects
two rooms or spaces, such as a door or window. The points determine which room or space is considered the "from"
and which is considered the "to".

#### Since

2014

### `P:Autodesk.Revit.DB.SpatialElementCalculationPoint.Position`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElementCalculationPoint.Position`

#### Summary

The position of the "in" spatial element calculation point.

#### Remarks

This is the search point where a family instance will be considered to be located inside a room/space.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `T:Autodesk.Revit.DB.SpatialElementCalculationPoint`

Member kind: type
Symbol: `Autodesk.Revit.DB.SpatialElementCalculationPoint`

#### Summary

SpatialElementCalculationPoint is used as the search point for family instances
placement inside rooms and spaces.

#### Remarks

The Spatial Element Calculation Point is graphically showed as a location point
marker with a "snake" line from the origin of the family. If the
Spatial Element Calculation Point is turned on, this point will be used as a
search point for room and space relations for all instances of this family.

#### Since

2013

### `P:Autodesk.Revit.DB.SpatialElementCalculationLocation.MarkerPosition`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpatialElementCalculationLocation.MarkerPosition`

#### Summary

The position of the spatial element calculation location marker.

#### Since

2014

### `T:Autodesk.Revit.DB.SpatialElementCalculationLocation`

Member kind: type
Symbol: `Autodesk.Revit.DB.SpatialElementCalculationLocation`

#### Summary

The Spatial Element Calculation Location is used to specify the room/space where an
element should be considered as placed.

#### Remarks

It currently has two types of calculation location:
SpatialElementCalculationPoint and SpatialElementFromToCalculationPoints
A user can turn on the Spatial Element Calculation Location in the family editor
by setting the family's ROOM_CALCULATION_POINT parameter.
A user can move the location of the Spatial Element Calculation Location in the family editor.
A user can visually verify the location of the Spatial Element Calculation Point by
selecting the fixture in the project.

#### Since

2014

### `M:Autodesk.Revit.DB.AreaTagFilter.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.AreaTagFilter.#ctor`

#### Summary

Constructs a filter which matches only areas.

### `T:Autodesk.Revit.DB.AreaTagFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.AreaTagFilter`

#### Summary

A filter used to match area tags.

#### Remarks

This filter is a slow filter, but it uses a quick filter to eliminate non-candidate elements
before the elements are obtained and expanded. Therefore this filter does not have to be
paired with another quick filter to minimize the number of Elements that are expanded.

### `M:Autodesk.Revit.DB.Mechanical.SpaceTagFilter.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.SpaceTagFilter.#ctor`

#### Summary

Constructs a filter which matches only spaces.

### `T:Autodesk.Revit.DB.Mechanical.SpaceTagFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.SpaceTagFilter`

#### Summary

A filter used to match space tags.

#### Remarks

This filter is a slow filter, but it uses a quick filter to eliminate non-candidate elements
before the elements are obtained and expanded. Therefore this filter does not have to be
paired with another quick filter to minimize the number of Elements that are expanded.

### `M:Autodesk.Revit.DB.Architecture.RoomTagFilter.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.RoomTagFilter.#ctor`

#### Summary

Constructs a filter which matches only rooms.

### `T:Autodesk.Revit.DB.Architecture.RoomTagFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.RoomTagFilter`

#### Summary

A filter used to match room tags.

#### Remarks

This filter is a slow filter, but it uses a quick filter to eliminate non-candidate elements
before the elements are obtained and expanded. Therefore this filter does not have to be
paired with another quick filter to minimize the number of Elements that are expanded.

### `M:Autodesk.Revit.DB.AreaFilter.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.AreaFilter.#ctor`

#### Summary

Constructs a filter which matches only areas.

### `T:Autodesk.Revit.DB.AreaFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.AreaFilter`

#### Summary

A filter used to match areas.

#### Remarks

This filter is a slow filter, but it uses a quick filter to eliminate non-candidate elements
before the elements are obtained and expanded. Therefore this filter does not have to be
paired with another quick filter to minimize the number of Elements that are expanded.

### `M:Autodesk.Revit.DB.Mechanical.SpaceFilter.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.SpaceFilter.#ctor`

#### Summary

Constructs a filter which matches only spaces.

### `T:Autodesk.Revit.DB.Mechanical.SpaceFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.SpaceFilter`

#### Summary

A filter used to match spaces.

#### Remarks

This filter is a slow filter, but it uses a quick filter to eliminate non-candidate elements
before the elements are obtained and expanded. Therefore this filter does not have to be
paired with another quick filter to minimize the number of Elements that are expanded.

### `M:Autodesk.Revit.DB.Architecture.RoomFilter.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.RoomFilter.#ctor`

#### Summary

Constructs a filter which matches only rooms.

### `T:Autodesk.Revit.DB.Architecture.RoomFilter`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.RoomFilter`

#### Summary

A filter used to match rooms.

#### Remarks

This filter is a slow filter, but it uses a quick filter to eliminate non-candidate elements
before the elements are obtained and expanded. Therefore this filter does not have to be
paired with another quick filter to minimize the number of Elements that are expanded.

### `P:Autodesk.Revit.DB.RoofType.ThermalProperties`

Member kind: property
Symbol: `Autodesk.Revit.DB.RoofType.ThermalProperties`

#### Summary

The calculated and settable thermal properties of the RoofType

#### Remarks

Returns `null` if the roof has no thermal properties.
Curtain roofs do not store thermal properties.

#### Since

2013

### `T:Autodesk.Revit.DB.RoofType`

Member kind: type
Symbol: `Autodesk.Revit.DB.RoofType`

#### Summary

Represents a specific type of roof.

#### Remarks

All roof type objects available in the project can be retrieved from the Document object
via the RoofTypes property. Every Roof object has a RoofType property that returns a
RoofType object representing the type. This same RoofType property can also be used to
change the type of the roof by setting it to a different type.

### `M:Autodesk.Revit.DB.WorksetConfiguration.Close(System.Collections.Generic.IList{Autodesk.Revit.DB.WorksetId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksetConfiguration.Close(System.Collections.Generic.IList{Autodesk.Revit.DB.WorksetId})`

#### Summary

Sets a group of user-created worksets to close.

#### Remarks

Calling this method on a configuration created with options other than WorksetConfigurationOption.CloseAllWorksets will set these
worksets to be explicitly closed. If all worksets are set to close, the configuration will be unchanged. Worksets other than the inputs are unaffected.

#### Parameter `worksetsToClose`

The group of user-created worksets to close. Non-user-created worksets and invalid workset ids will be ignored.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.WorksetConfiguration.Open(System.Collections.Generic.IList{Autodesk.Revit.DB.WorksetId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksetConfiguration.Open(System.Collections.Generic.IList{Autodesk.Revit.DB.WorksetId})`

#### Summary

Sets a group of user-created worksets to open.

#### Remarks

Calling this method on a configuration created with options other than WorksetConfigurationOption.OpenAllWorksets will set these
worksets to be explicitly opened. If all worksets are set to open, the configuration will be unchanged. Worksets other than the inputs are unaffected.

#### Parameter `worksetsToOpen`

The group of user-created worksets to open. Non-user-created worksets and invalid workset ids will be ignored.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.WorksetConfiguration.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.WorksetConfiguration.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.WorksetConfiguration.OpenEditable`

Member kind: property
Symbol: `Autodesk.Revit.DB.WorksetConfiguration.OpenEditable`

#### Since

2014

### `P:Autodesk.Revit.DB.WorksetConfiguration.IsUserSpecify`

Member kind: property
Symbol: `Autodesk.Revit.DB.WorksetConfiguration.IsUserSpecify`

#### Since

2014

### `M:Autodesk.Revit.DB.WorksetConfiguration.#ctor(Autodesk.Revit.DB.WorksetConfigurationOption)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksetConfiguration.#ctor(Autodesk.Revit.DB.WorksetConfigurationOption)`

#### Summary

Constructs a new workset configuration with an initial setting to open or close all user-created worksets, or to open last viewed worksets.

#### Parameter `option`

The option to open or close all user created worksets by default.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2015

### `M:Autodesk.Revit.DB.WorksetConfiguration.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksetConfiguration.#ctor`

#### Summary

Constructs a new workset configuration with an initial setting to open all user-created worksets.

#### Since

2014
