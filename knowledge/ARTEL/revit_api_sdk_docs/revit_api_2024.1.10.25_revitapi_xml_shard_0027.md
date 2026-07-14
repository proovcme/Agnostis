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
Shard: 27
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `P:Autodesk.Revit.DB.SlabShapeCreaseArray.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.SlabShapeCreaseArray.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the array is empty.

#### Remarks

If the array is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.ProjectLocationSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.ProjectLocationSetIterator`

#### Summary

An iterator to a project location set.

### `T:Autodesk.Revit.DB.ProjectLocationSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.ProjectLocationSet`

#### Summary

An set that contains project locations.

### `P:Autodesk.Revit.DB.ProjectLocationSetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.ProjectLocationSetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.ProjectLocationSetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.ProjectLocationSetIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.ProjectLocationSetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.ProjectLocationSetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.ProjectLocationSetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ProjectLocationSetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.ProjectLocationSet.Insert(Autodesk.Revit.DB.ProjectLocation)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ProjectLocationSet.Insert(Autodesk.Revit.DB.ProjectLocation)`

#### Returntype

System.Int32

#### Summary

Insert the specified project location into the set.

#### Parameter `item`

The project location to be inserted into the set.

#### Returns

Returns whether the project location was inserted into the set.

### `M:Autodesk.Revit.DB.ProjectLocationSet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ProjectLocationSet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.ProjectLocationSet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ProjectLocationSet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.ProjectLocationSetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.ProjectLocationSet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ProjectLocationSet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.ProjectLocationSetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.ProjectLocationSet.Erase(Autodesk.Revit.DB.ProjectLocation)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ProjectLocationSet.Erase(Autodesk.Revit.DB.ProjectLocation)`

#### Returntype

System.Int32

#### Summary

Removes a specified project location from the set.

#### Parameter `item`

The project location to be erased.

#### Returns

The number of project locations that were erased from the set.

### `M:Autodesk.Revit.DB.ProjectLocationSet.Contains(Autodesk.Revit.DB.ProjectLocation)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ProjectLocationSet.Contains(Autodesk.Revit.DB.ProjectLocation)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of a project location within the set.

#### Parameter `item`

The project location to be searched for.

#### Returns

The Contains method returns True if the project location is within the set, otherwise False.

### `M:Autodesk.Revit.DB.ProjectLocationSet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.ProjectLocationSet.Clear`

#### Returntype

void

#### Summary

Removes every project location from the set, rendering it empty.

### `P:Autodesk.Revit.DB.ProjectLocationSet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.ProjectLocationSet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of project locations that are in the set.

### `P:Autodesk.Revit.DB.ProjectLocationSet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.ProjectLocationSet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.CitySetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.CitySetIterator`

#### Summary

An iterator to a city set.

### `T:Autodesk.Revit.DB.CitySet`

Member kind: type
Symbol: `Autodesk.Revit.DB.CitySet`

#### Summary

An set that contains cities.

### `P:Autodesk.Revit.DB.CitySetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.CitySetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.CitySetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.CitySetIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.CitySetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.CitySetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.CitySetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.CitySetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.CitySet.Insert(Autodesk.Revit.DB.City)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CitySet.Insert(Autodesk.Revit.DB.City)`

#### Returntype

System.Int32

#### Summary

Insert the specified city into the set.

#### Parameter `item`

The city to be inserted into the set.

#### Returns

Returns whether the city was inserted into the set.

### `M:Autodesk.Revit.DB.CitySet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.CitySet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.CitySet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.CitySet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.CitySetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.CitySet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.CitySet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.CitySetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.CitySet.Erase(Autodesk.Revit.DB.City)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CitySet.Erase(Autodesk.Revit.DB.City)`

#### Returntype

System.Int32

#### Summary

Removes a specified city from the set.

#### Parameter `item`

The city to be erased.

#### Returns

The number of cities that were erased from the set.

### `M:Autodesk.Revit.DB.CitySet.Contains(Autodesk.Revit.DB.City)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CitySet.Contains(Autodesk.Revit.DB.City)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of a city within the set.

#### Parameter `item`

The city to be searched for.

#### Returns

The Contains method returns True if the city is within the set, otherwise False.

### `M:Autodesk.Revit.DB.CitySet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.CitySet.Clear`

#### Returntype

void

#### Summary

Removes every city from the set, rendering it empty.

### `P:Autodesk.Revit.DB.CitySet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.CitySet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of cities that are in the set.

### `P:Autodesk.Revit.DB.CitySet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.CitySet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.PlanTopologySetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.PlanTopologySetIterator`

#### Summary

An iterator to a set of plan topology objects.

### `T:Autodesk.Revit.DB.PlanTopologySet`

Member kind: type
Symbol: `Autodesk.Revit.DB.PlanTopologySet`

#### Summary

A set that can contain any number of plan topology objects.

### `P:Autodesk.Revit.DB.PlanTopologySetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.PlanTopologySetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.PlanTopologySetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.PlanTopologySetIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.PlanTopologySetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.PlanTopologySetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.PlanTopologySetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.PlanTopologySetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.PlanTopologySet.Insert(Autodesk.Revit.DB.PlanTopology)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PlanTopologySet.Insert(Autodesk.Revit.DB.PlanTopology)`

#### Returntype

System.Int32

#### Summary

Insert the specified item into the set.

#### Parameter `item`

The item to be inserted into the set.

#### Returns

Returns whether the item was inserted into the set.

### `M:Autodesk.Revit.DB.PlanTopologySet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.PlanTopologySet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.PlanTopologySet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.PlanTopologySet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.PlanTopologySetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.PlanTopologySet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.PlanTopologySet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.PlanTopologySetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.PlanTopologySet.Erase(Autodesk.Revit.DB.PlanTopology)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PlanTopologySet.Erase(Autodesk.Revit.DB.PlanTopology)`

#### Returntype

System.Int32

#### Summary

Removes a specified object from the set.

#### Parameter `item`

The item to be erased.

#### Returns

The number of items that were erased from the set.

### `M:Autodesk.Revit.DB.PlanTopologySet.Contains(Autodesk.Revit.DB.PlanTopology)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PlanTopologySet.Contains(Autodesk.Revit.DB.PlanTopology)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of an item within the set.

#### Parameter `item`

The item to be searched for.

#### Returns

The Contains method returns True if the item is within the set, otherwise False.

### `M:Autodesk.Revit.DB.PlanTopologySet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.PlanTopologySet.Clear`

#### Returntype

void

#### Summary

Removes every item from the set, rendering it empty.

### `P:Autodesk.Revit.DB.PlanTopologySet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.PlanTopologySet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of objects that are in the set.

### `P:Autodesk.Revit.DB.PlanTopologySet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.PlanTopologySet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.PlanCircuitSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.PlanCircuitSetIterator`

#### Summary

An iterator to a set of plan circuit objects.

### `T:Autodesk.Revit.DB.PlanCircuitSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.PlanCircuitSet`

#### Summary

A set that can contain any number of plan circuit objects.

### `P:Autodesk.Revit.DB.PlanCircuitSetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.PlanCircuitSetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.PlanCircuitSetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.PlanCircuitSetIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.PlanCircuitSetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.PlanCircuitSetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.PlanCircuitSetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.PlanCircuitSetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.PlanCircuitSet.Insert(Autodesk.Revit.DB.PlanCircuit)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PlanCircuitSet.Insert(Autodesk.Revit.DB.PlanCircuit)`

#### Returntype

System.Int32

#### Summary

Insert the specified item into the set.

#### Parameter `item`

The item to be inserted into the set.

#### Returns

Returns whether the item was inserted into the set.

### `M:Autodesk.Revit.DB.PlanCircuitSet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.PlanCircuitSet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.PlanCircuitSet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.PlanCircuitSet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.PlanCircuitSetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.PlanCircuitSet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.PlanCircuitSet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.PlanCircuitSetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.PlanCircuitSet.Erase(Autodesk.Revit.DB.PlanCircuit)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PlanCircuitSet.Erase(Autodesk.Revit.DB.PlanCircuit)`

#### Returntype

System.Int32

#### Summary

Removes a specified object from the set.

#### Parameter `item`

The item to be erased.

#### Returns

The number of items that were erased from the set.

### `M:Autodesk.Revit.DB.PlanCircuitSet.Contains(Autodesk.Revit.DB.PlanCircuit)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PlanCircuitSet.Contains(Autodesk.Revit.DB.PlanCircuit)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of an item within the set.

#### Parameter `item`

The item to be searched for.

#### Returns

The Contains method returns True if the item is within the set, otherwise False.

### `M:Autodesk.Revit.DB.PlanCircuitSet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.PlanCircuitSet.Clear`

#### Returntype

void

#### Summary

Removes every item from the set, rendering it empty.

### `P:Autodesk.Revit.DB.PlanCircuitSet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.PlanCircuitSet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of objects that are in the set.

### `P:Autodesk.Revit.DB.PlanCircuitSet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.PlanCircuitSet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.PhaseArrayIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.PhaseArrayIterator`

#### Summary

An iterator to a phase array.

### `T:Autodesk.Revit.DB.PhaseArray`

Member kind: type
Symbol: `Autodesk.Revit.DB.PhaseArray`

#### Summary

An array that contains phase objects.

### `P:Autodesk.Revit.DB.PhaseArrayIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.PhaseArrayIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.PhaseArrayIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.PhaseArrayIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.PhaseArrayIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.PhaseArrayIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the array.

#### Remarks

The Reset method will return the iterator back to the start of the array in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.PhaseArrayIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.PhaseArrayIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.PhaseArray.Insert(Autodesk.Revit.DB.Phase,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PhaseArray.Insert(Autodesk.Revit.DB.Phase,System.Int32)`

#### Returntype

System.Int32

#### Summary

Insert the specified phase into the array.

#### Parameter `item`

The phase to be inserted into the array.

#### Parameter `index`

The phase will be inserted before this index.

#### Returns

Returns whether the phase was inserted into the array.

### `M:Autodesk.Revit.DB.PhaseArray.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.PhaseArray.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.PhaseArray.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.PhaseArray.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.ElementArrayIterator

#### Summary

Retrieve a backward moving iterator to the array.

#### Returns

Returns a backward moving iterator to the array.

### `M:Autodesk.Revit.DB.PhaseArray.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.PhaseArray.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.ElementArrayIterator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.PhaseArray.Append(Autodesk.Revit.DB.Phase)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PhaseArray.Append(Autodesk.Revit.DB.Phase)`

#### Returntype

void

#### Summary

Add the phase to the end of the array.

#### Parameter `item`

The phase to be added.

### `M:Autodesk.Revit.DB.PhaseArray.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.PhaseArray.Clear`

#### Returntype

void

#### Summary

Removes every phase from the array, rendering it empty.

### `P:Autodesk.Revit.DB.PhaseArray.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.PhaseArray.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of phases that are in the array.

### `P:Autodesk.Revit.DB.PhaseArray.Item(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.PhaseArray.Item(System.Int32)`

#### Returntype

Autodesk.Revit.DB.Phase

#### Summary

Gets or sets a phase at a specified index within the array.

#### Parameter `index`

The index of the phase to be set or retrieved.

#### Returns

Returns the phase at the specified index.

### `P:Autodesk.Revit.DB.PhaseArray.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.PhaseArray.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the array is empty.

#### Remarks

If the array is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.ParameterSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.ParameterSetIterator`

#### Summary

An iterator to a parameter set.

### `T:Autodesk.Revit.DB.ParameterSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.ParameterSet`

#### Summary

A set that contains parameters.

### `P:Autodesk.Revit.DB.ParameterSetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterSetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.ParameterSetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterSetIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.ParameterSetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterSetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.ParameterSetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterSetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.ParameterSet.Insert(Autodesk.Revit.DB.Parameter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterSet.Insert(Autodesk.Revit.DB.Parameter)`

#### Returntype

System.Int32

#### Summary

Insert the specified parameter into the set.

#### Parameter `item`

The parameter to be inserted into the set.

#### Returns

Returns whether the parameter was inserted into the set.

### `M:Autodesk.Revit.DB.ParameterSet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterSet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.ParameterSet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterSet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.ParameterSetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.ParameterSet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterSet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.ParameterSetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.ParameterSet.Erase(Autodesk.Revit.DB.Parameter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterSet.Erase(Autodesk.Revit.DB.Parameter)`

#### Returntype

System.Int32

#### Summary

Removes a specified parameter from the set.

#### Parameter `item`

The parameter to be erased.

#### Returns

The number of parameters that were erased from the set.

### `M:Autodesk.Revit.DB.ParameterSet.Contains(Autodesk.Revit.DB.Parameter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterSet.Contains(Autodesk.Revit.DB.Parameter)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of a parameter within the set.

#### Parameter `item`

The parameter to be searched for.

#### Returns

The Contains method returns True if the parameter is within the set, otherwise False.

### `M:Autodesk.Revit.DB.ParameterSet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterSet.Clear`

#### Returntype

void

#### Summary

Removes every parameter from the set, rendering it empty.

### `P:Autodesk.Revit.DB.ParameterSet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterSet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of parameters that are in the set.

### `P:Autodesk.Revit.DB.ParameterSet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterSet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.ParameterMapIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.ParameterMapIterator`

#### Summary

An iterator to a map relating a parameter name (the key, a String) to a parameter.

### `T:Autodesk.Revit.DB.ParameterMap`

Member kind: type
Symbol: `Autodesk.Revit.DB.ParameterMap`

#### Summary

A map that can contain a mapping of a parameter name (a String) to a parameter.

### `P:Autodesk.Revit.DB.ParameterMapIterator.Key`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterMapIterator.Key`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the key that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
key as per expected behavior of IEnumerator.

### `P:Autodesk.Revit.DB.ParameterMapIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterMapIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.ParameterMapIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterMapIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.ParameterMapIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterMapIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the map.

#### Remarks

The Reset method will return the iterator back to the start of the map in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.ParameterMapIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterMapIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.ParameterMap.Insert(System.String,Autodesk.Revit.DB.Parameter)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterMap.Insert(System.String,Autodesk.Revit.DB.Parameter)`

#### Returntype

System.Int32

#### Summary

Insert the specified item with the specified key into the map.

#### Parameter `key`

The key to be used for inserting the item into the map.

#### Parameter `item`

The item to be inserted into the map.

#### Returns

Returns whether the item was inserted into the map.

### `M:Autodesk.Revit.DB.ParameterMap.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterMap.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the map.

#### Returns

Returns a forward moving iterator to the map.

### `M:Autodesk.Revit.DB.ParameterMap.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterMap.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.ParameterMapIterator

#### Summary

Retrieve a backward moving iterator to the map.

#### Returns

Returns a backward moving iterator to the map.

### `M:Autodesk.Revit.DB.ParameterMap.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterMap.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.ParameterMapIterator

#### Summary

Retrieve a forward moving iterator to the map.

#### Returns

Returns a forward moving iterator to the map.

### `M:Autodesk.Revit.DB.ParameterMap.Erase(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterMap.Erase(System.String)`

#### Returntype

System.Int32

#### Summary

Removes a object with the specified key from the map.

#### Parameter `key`

The key of the item to be erased.

#### Returns

The number of items that were erased from the map.

### `M:Autodesk.Revit.DB.ParameterMap.Contains(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterMap.Contains(System.String)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of a key within the map.

#### Parameter `key`

The key to be searched for.

#### Returns

The Contains method returns True if the key is within the map, otherwise False.

### `M:Autodesk.Revit.DB.ParameterMap.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.ParameterMap.Clear`

#### Returntype

void

#### Summary

Removes every item from the map, rendering it empty.

### `P:Autodesk.Revit.DB.ParameterMap.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterMap.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of objects that are in the map.

### `P:Autodesk.Revit.DB.ParameterMap.Item(System.String)`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterMap.Item(System.String)`

#### Returntype

System.Object

#### Summary

Gets or sets an item at a specified key within the map.

#### Parameter `key`

The key of the item to be set or retrieved.

#### Returns

Returns the object at the specified key.

### `P:Autodesk.Revit.DB.ParameterMap.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.ParameterMap.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the map is empty.

#### Remarks

If the map is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.PaperSourceSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.PaperSourceSetIterator`

#### Summary

An iterator to a set of paper source objects.

### `T:Autodesk.Revit.DB.PaperSourceSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.PaperSourceSet`

#### Summary

A set that can contain any number of paper source objects.

### `P:Autodesk.Revit.DB.PaperSourceSetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.PaperSourceSetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.PaperSourceSetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.PaperSourceSetIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.PaperSourceSetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.PaperSourceSetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.PaperSourceSetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.PaperSourceSetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.PaperSourceSet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.PaperSourceSet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.PaperSourceSet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.PaperSourceSet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.PaperSourceSetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.PaperSourceSet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.PaperSourceSet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.PaperSourceSetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.PaperSourceSet.Erase(Autodesk.Revit.DB.PaperSource)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PaperSourceSet.Erase(Autodesk.Revit.DB.PaperSource)`

#### Returntype

System.Int32

#### Summary

Removes a specified object from the set.

#### Parameter `item`

The item to be erased.

#### Returns

The number of items that were erased from the set.

### `M:Autodesk.Revit.DB.PaperSourceSet.Contains(Autodesk.Revit.DB.PaperSource)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PaperSourceSet.Contains(Autodesk.Revit.DB.PaperSource)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of an item within the set.

#### Parameter `item`

The item to be searched for.

#### Returns

The Contains method returns True if the item is within the set, otherwise False.

### `M:Autodesk.Revit.DB.PaperSourceSet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.PaperSourceSet.Clear`

#### Returntype

void

#### Summary

Removes every item from the set, rendering it empty.

### `P:Autodesk.Revit.DB.PaperSourceSet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.PaperSourceSet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of objects that are in the set.

### `P:Autodesk.Revit.DB.PaperSourceSet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.PaperSourceSet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.PaperSizeSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.PaperSizeSetIterator`

#### Summary

An iterator to a set of paper size objects.

### `T:Autodesk.Revit.DB.PaperSizeSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.PaperSizeSet`

#### Summary

A set that can contain any number of paper size objects.

### `P:Autodesk.Revit.DB.PaperSizeSetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.PaperSizeSetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.PaperSizeSetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.PaperSizeSetIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.PaperSizeSetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.PaperSizeSetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.PaperSizeSetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.PaperSizeSetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.PaperSizeSet.Insert(Autodesk.Revit.DB.PaperSize)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PaperSizeSet.Insert(Autodesk.Revit.DB.PaperSize)`

#### Returntype

System.Int32

#### Summary

Insert the specified item into the set.

#### Parameter `item`

The item to be inserted into the set.

#### Returns

Returns whether the item was inserted into the set.

### `M:Autodesk.Revit.DB.PaperSizeSet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.PaperSizeSet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.PaperSizeSet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.PaperSizeSet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.PaperSizeSetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.PaperSizeSet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.PaperSizeSet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.PaperSizeSetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.PaperSizeSet.Erase(Autodesk.Revit.DB.PaperSize)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PaperSizeSet.Erase(Autodesk.Revit.DB.PaperSize)`

#### Returntype

System.Int32

#### Summary

Removes a specified object from the set.

#### Parameter `item`

The item to be erased.

#### Returns

The number of items that were erased from the set.

### `M:Autodesk.Revit.DB.PaperSizeSet.Contains(Autodesk.Revit.DB.PaperSize)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PaperSizeSet.Contains(Autodesk.Revit.DB.PaperSize)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of an item within the set.

#### Parameter `item`

The item to be searched for.

#### Returns

The Contains method returns True if the item is within the set, otherwise False.

### `M:Autodesk.Revit.DB.PaperSizeSet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.PaperSizeSet.Clear`

#### Returntype

void

#### Summary

Removes every item from the set, rendering it empty.

### `P:Autodesk.Revit.DB.PaperSizeSet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.PaperSizeSet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of objects that are in the set.

### `P:Autodesk.Revit.DB.PaperSizeSet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.PaperSizeSet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.PanelTypeSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.PanelTypeSetIterator`

#### Summary

An iterator to a panel type set.

### `T:Autodesk.Revit.DB.PanelTypeSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.PanelTypeSet`

#### Summary

A set that contains panel types.

### `P:Autodesk.Revit.DB.PanelTypeSetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.PanelTypeSetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.PanelTypeSetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.PanelTypeSetIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.PanelTypeSetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.PanelTypeSetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.PanelTypeSetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.PanelTypeSetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.PanelTypeSet.Insert(Autodesk.Revit.DB.PanelType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PanelTypeSet.Insert(Autodesk.Revit.DB.PanelType)`

#### Returntype

System.Int32

#### Summary

Insert the specified panel type into the set.

#### Parameter `item`

The panel type to be inserted into the set.

#### Returns

Returns whether the panel type was inserted into the set.

### `M:Autodesk.Revit.DB.PanelTypeSet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.PanelTypeSet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.PanelTypeSet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.PanelTypeSet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.PanelTypeSetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.PanelTypeSet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.PanelTypeSet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.PanelTypeSetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.PanelTypeSet.Erase(Autodesk.Revit.DB.PanelType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PanelTypeSet.Erase(Autodesk.Revit.DB.PanelType)`

#### Returntype

System.Int32

#### Summary

Removes a specified panel type from the set.

#### Parameter `item`

The panel type to be erased.

#### Returns

The number of panel types that were erased from the set.

### `M:Autodesk.Revit.DB.PanelTypeSet.Contains(Autodesk.Revit.DB.PanelType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.PanelTypeSet.Contains(Autodesk.Revit.DB.PanelType)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of a panel type within the set.

#### Parameter `item`

The panel type to be searched for.

#### Returns

The Contains method returns True if the panel type is within the set, otherwise False.

### `M:Autodesk.Revit.DB.PanelTypeSet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.PanelTypeSet.Clear`

#### Returntype

void

#### Summary

Removes every panel type from the set, rendering it empty.

### `P:Autodesk.Revit.DB.PanelTypeSet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.PanelTypeSet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of panel types that are in the set.

### `P:Autodesk.Revit.DB.PanelTypeSet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.PanelTypeSet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.MullionTypeSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.MullionTypeSetIterator`

#### Summary

An iterator to a mullion type set.

### `T:Autodesk.Revit.DB.MullionTypeSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.MullionTypeSet`

#### Summary

A set that contains mullion types.

### `P:Autodesk.Revit.DB.MullionTypeSetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.MullionTypeSetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.MullionTypeSetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.MullionTypeSetIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.MullionTypeSetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.MullionTypeSetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.MullionTypeSetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.MullionTypeSetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.MullionTypeSet.Insert(Autodesk.Revit.DB.MullionType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MullionTypeSet.Insert(Autodesk.Revit.DB.MullionType)`

#### Returntype

System.Int32

#### Summary

Insert the specified mullion type into the set.

#### Parameter `item`

The mullion type to be inserted into the set.

#### Returns

Returns whether the mullion type was inserted into the set.

### `M:Autodesk.Revit.DB.MullionTypeSet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.MullionTypeSet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.MullionTypeSet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.MullionTypeSet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.MullionTypeSetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.MullionTypeSet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.MullionTypeSet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.MullionTypeSetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.MullionTypeSet.Erase(Autodesk.Revit.DB.MullionType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MullionTypeSet.Erase(Autodesk.Revit.DB.MullionType)`

#### Returntype

System.Int32

#### Summary

Removes a specified mullion type from the set.

#### Parameter `item`

The mullion type to be erased.

#### Returns

The number of mullion types that were erased from the set.

### `M:Autodesk.Revit.DB.MullionTypeSet.Contains(Autodesk.Revit.DB.MullionType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MullionTypeSet.Contains(Autodesk.Revit.DB.MullionType)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of a mullion type within the set.

#### Parameter `item`

The mullion type to be searched for.

#### Returns

The Contains method returns True if the mullion type is within the set, otherwise False.

### `M:Autodesk.Revit.DB.MullionTypeSet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.MullionTypeSet.Clear`

#### Returntype

void

#### Summary

Removes every mullion type from the set, rendering it empty.

### `P:Autodesk.Revit.DB.MullionTypeSet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.MullionTypeSet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of mullion types that are in the set.

### `P:Autodesk.Revit.DB.MullionTypeSet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.MullionTypeSet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.ModelCurveArrayIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.ModelCurveArrayIterator`

#### Summary

An iterator to a model curve array.

### `T:Autodesk.Revit.DB.ModelCurveArray`

Member kind: type
Symbol: `Autodesk.Revit.DB.ModelCurveArray`

#### Summary

An array that contains model curves.

### `P:Autodesk.Revit.DB.ModelCurveArrayIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.ModelCurveArrayIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.ModelCurveArrayIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelCurveArrayIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.ModelCurveArrayIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelCurveArrayIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the array.

#### Remarks

The Reset method will return the iterator back to the start of the array in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.ModelCurveArrayIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelCurveArrayIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.ModelCurveArray.Insert(Autodesk.Revit.DB.ModelCurve,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelCurveArray.Insert(Autodesk.Revit.DB.ModelCurve,System.Int32)`

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

### `M:Autodesk.Revit.DB.ModelCurveArray.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelCurveArray.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.ModelCurveArray.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelCurveArray.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.ModelCurveArrayIterator

#### Summary

Retrieve a backward moving iterator to the array.

#### Returns

Returns a backward moving iterator to the array.

### `M:Autodesk.Revit.DB.ModelCurveArray.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelCurveArray.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.ModelCurveArrayIterator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.ModelCurveArray.Append(Autodesk.Revit.DB.ModelCurve)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelCurveArray.Append(Autodesk.Revit.DB.ModelCurve)`

#### Returntype

void

#### Summary

Add the model curve to the end of the array.

#### Parameter `item`

The model curve to be added.

### `M:Autodesk.Revit.DB.ModelCurveArray.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelCurveArray.Clear`

#### Returntype

void

#### Summary

Removes every model curve from the array, rendering it empty.

### `P:Autodesk.Revit.DB.ModelCurveArray.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.ModelCurveArray.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of model curves that are in the array.

### `P:Autodesk.Revit.DB.ModelCurveArray.Item(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.ModelCurveArray.Item(System.Int32)`

#### Returntype

System.Object

#### Summary

Gets or sets a model curve at a specified index within the array.

#### Parameter `index`

The index of the model curve to be set or retrieved.

#### Returns

Returns the model curve at the specified index.

### `P:Autodesk.Revit.DB.ModelCurveArray.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.ModelCurveArray.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the array is empty.

#### Remarks

If the array is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.ModelCurveArrArrayIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.ModelCurveArrArrayIterator`

#### Summary

An iterator to a array.

### `T:Autodesk.Revit.DB.ModelCurveArrArray`

Member kind: type
Symbol: `Autodesk.Revit.DB.ModelCurveArrArray`

#### Summary

An array that can contain any type of object.

### `P:Autodesk.Revit.DB.ModelCurveArrArrayIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.ModelCurveArrArrayIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.ModelCurveArrArrayIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelCurveArrArrayIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.ModelCurveArrArrayIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelCurveArrArrayIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the array.

#### Remarks

The Reset method will return the iterator back to the start of the array in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.ModelCurveArrArrayIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelCurveArrArrayIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.ModelCurveArrArray.Insert(System.Object,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelCurveArrArray.Insert(System.Object,System.Int32)`

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

### `M:Autodesk.Revit.DB.ModelCurveArrArray.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelCurveArrArray.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.ModelCurveArrArray.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelCurveArrArray.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.ModelCurveArrArrayIterator

#### Summary

Retrieve a backward moving iterator to the array.

#### Returns

Returns a backward moving iterator to the array.

### `M:Autodesk.Revit.DB.ModelCurveArrArray.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelCurveArrArray.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.ModelCurveArrArrayIterator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.ModelCurveArrArray.Append(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelCurveArrArray.Append(System.Object)`

#### Returntype

void

#### Summary

Add the item to the end of the array.

#### Parameter `item`

The item to be added.

### `M:Autodesk.Revit.DB.ModelCurveArrArray.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.ModelCurveArrArray.Clear`

#### Returntype

void

#### Summary

Removes every item from the array, rendering it empty.

### `P:Autodesk.Revit.DB.ModelCurveArrArray.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.ModelCurveArrArray.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of objects that are in the array.

### `P:Autodesk.Revit.DB.ModelCurveArrArray.Item(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.ModelCurveArrArray.Item(System.Int32)`

#### Returntype

System.Object

#### Summary

Gets or sets an item at a specified index within the array.

#### Parameter `index`

The index of the item to be set or retrieved.

#### Returns

Returns the object at the specified index.

### `P:Autodesk.Revit.DB.ModelCurveArrArray.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.ModelCurveArrArray.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the array is empty.

#### Remarks

If the array is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSetIterator`

#### Summary

An iterator to a MEPBuildingConstruction set.

### `T:Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSet`

#### Summary

A set that contains MEPBuildingConstructions.

### `P:Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSetIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSet.Insert(Autodesk.Revit.DB.Mechanical.MEPBuildingConstruction)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSet.Insert(Autodesk.Revit.DB.Mechanical.MEPBuildingConstruction)`

#### Returntype

System.Int32

#### Summary

Insert the specified MEPBuildingConstruction into the set.

#### Parameter `item`

The MEPBuildingConstruction to be inserted into the set.

#### Returns

Returns whether the MEPBuildingConstruction was inserted into the set.

### `M:Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSet.Erase(Autodesk.Revit.DB.Mechanical.MEPBuildingConstruction)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSet.Erase(Autodesk.Revit.DB.Mechanical.MEPBuildingConstruction)`

#### Returntype

System.Int32

#### Summary

Removes a specified MEPBuildingConstruction from the set.

#### Parameter `item`

The MEPBuildingConstruction to be erased.

#### Returns

The number of MEPBuildingConstructions that were erased from the set.

### `M:Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSet.Contains(Autodesk.Revit.DB.Mechanical.MEPBuildingConstruction)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSet.Contains(Autodesk.Revit.DB.Mechanical.MEPBuildingConstruction)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of a MEPBuildingConstruction within the set.

#### Parameter `item`

The MEPBuildingConstruction to be searched for.

#### Returns

The Contains method returns True if the MEPBuildingConstruction is within the set, otherwise False.

### `M:Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSet.Clear`

#### Returntype

void

#### Summary

Removes every MEPBuildingConstruction from the set, rendering it empty.

### `P:Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of MEPBuildingConstructions that are in the set.

### `P:Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.MEPBuildingConstructionSet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.MaterialSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.MaterialSetIterator`

#### Summary

An iterator to a material set.

### `T:Autodesk.Revit.DB.MaterialSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.MaterialSet`

#### Summary

An set that contains materials.

### `P:Autodesk.Revit.DB.MaterialSetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.MaterialSetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.MaterialSetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.MaterialSetIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.MaterialSetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.MaterialSetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.MaterialSetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.MaterialSetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.MaterialSet.Insert(Autodesk.Revit.DB.Material)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MaterialSet.Insert(Autodesk.Revit.DB.Material)`

#### Returntype

System.Int32

#### Summary

Insert the specified material into the set.

#### Parameter `item`

The material to be inserted into the set.

#### Returns

Returns whether the material was inserted into the set.

### `M:Autodesk.Revit.DB.MaterialSet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.MaterialSet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.MaterialSet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.MaterialSet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.MaterialSetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.MaterialSet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.MaterialSet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.MaterialSetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.MaterialSet.Erase(Autodesk.Revit.DB.Material)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MaterialSet.Erase(Autodesk.Revit.DB.Material)`

#### Returntype

System.Int32

#### Summary

Removes a specified material from the set.

#### Parameter `item`

The material to be erased.

#### Returns

The number of materials that were erased from the set.

### `M:Autodesk.Revit.DB.MaterialSet.Contains(Autodesk.Revit.DB.Material)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MaterialSet.Contains(Autodesk.Revit.DB.Material)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of a material within the set.

#### Parameter `item`

The material to be searched for.

#### Returns

The Contains method returns True if the material is within the set, otherwise False.

### `M:Autodesk.Revit.DB.MaterialSet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.MaterialSet.Clear`

#### Returntype

void

#### Summary

Removes every material from the set, rendering it empty.

### `P:Autodesk.Revit.DB.MaterialSet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.MaterialSet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of materials that are in the set.

### `P:Autodesk.Revit.DB.MaterialSet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.MaterialSet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.LeaderArrayIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.LeaderArrayIterator`

#### Summary

An iterator to an array of leaders.

### `T:Autodesk.Revit.DB.LeaderArray`

Member kind: type
Symbol: `Autodesk.Revit.DB.LeaderArray`

#### Summary

An array that can contain any number of leaders.

### `P:Autodesk.Revit.DB.LeaderArrayIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.LeaderArrayIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.LeaderArrayIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.LeaderArrayIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.LeaderArrayIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.LeaderArrayIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the array.

#### Remarks

The Reset method will return the iterator back to the start of the array in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.LeaderArrayIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.LeaderArrayIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.LeaderArray.Insert(Autodesk.Revit.DB.Leader,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LeaderArray.Insert(Autodesk.Revit.DB.Leader,System.Int32)`

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

### `M:Autodesk.Revit.DB.LeaderArray.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.LeaderArray.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.LeaderArray.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.LeaderArray.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.LeaderArrayIterator

#### Summary

Retrieve a backward moving iterator to the array.

#### Returns

Returns a backward moving iterator to the array.

### `M:Autodesk.Revit.DB.LeaderArray.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.LeaderArray.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.LeaderArrayIterator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.LeaderArray.Append(Autodesk.Revit.DB.Leader)`

Member kind: method
Symbol: `Autodesk.Revit.DB.LeaderArray.Append(Autodesk.Revit.DB.Leader)`

#### Returntype

void

#### Summary

Add the item to the end of the array.

#### Parameter `item`

The item to be added.

### `M:Autodesk.Revit.DB.LeaderArray.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.LeaderArray.Clear`

#### Returntype

void

#### Summary

Removes every item from the array, rendering it empty.

### `P:Autodesk.Revit.DB.LeaderArray.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.LeaderArray.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of objects that are in the array.

### `P:Autodesk.Revit.DB.LeaderArray.Item(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.LeaderArray.Item(System.Int32)`

#### Returntype

System.Object

#### Summary

Gets or sets an item at a specified index within the array.

#### Parameter `index`

The index of the item to be set or retrieved.

#### Returns

Returns the object at the specified index.

### `P:Autodesk.Revit.DB.LeaderArray.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.LeaderArray.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the array is empty.

#### Remarks

If the array is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.IntersectionResultArrayIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.IntersectionResultArrayIterator`

#### Summary

An iterator to a array.

### `T:Autodesk.Revit.DB.IntersectionResultArray`

Member kind: type
Symbol: `Autodesk.Revit.DB.IntersectionResultArray`

#### Summary

An array that can contain any type of object.

### `P:Autodesk.Revit.DB.IntersectionResultArrayIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.IntersectionResultArrayIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.IntersectionResultArrayIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.IntersectionResultArrayIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.IntersectionResultArrayIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.IntersectionResultArrayIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the array.

#### Remarks

The Reset method will return the iterator back to the start of the array in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.IntersectionResultArrayIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.IntersectionResultArrayIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.IntersectionResultArray.Insert(System.Object,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IntersectionResultArray.Insert(System.Object,System.Int32)`

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

### `M:Autodesk.Revit.DB.IntersectionResultArray.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.IntersectionResultArray.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.IntersectionResultArray.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.IntersectionResultArray.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.IntersectionResultArrayIterator

#### Summary

Retrieve a backward moving iterator to the array.

#### Returns

Returns a backward moving iterator to the array.

### `M:Autodesk.Revit.DB.IntersectionResultArray.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.IntersectionResultArray.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.IntersectionResultArrayIterator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.IntersectionResultArray.Append(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.DB.IntersectionResultArray.Append(System.Object)`

#### Returntype

void

#### Summary

Add the item to the end of the array.

#### Parameter `item`

The item to be added.

### `M:Autodesk.Revit.DB.IntersectionResultArray.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.IntersectionResultArray.Clear`

#### Returntype

void

#### Summary

Removes every item from the array, rendering it empty.

### `P:Autodesk.Revit.DB.IntersectionResultArray.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.IntersectionResultArray.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of objects that are in the array.

### `P:Autodesk.Revit.DB.IntersectionResultArray.Item(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.IntersectionResultArray.Item(System.Int32)`

#### Returntype

System.Object

#### Summary

Gets or sets an item at a specified index within the array.

#### Parameter `index`

The index of the item to be set or retrieved.

#### Returns

Returns the object at the specified index.

### `P:Autodesk.Revit.DB.IntersectionResultArray.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.IntersectionResultArray.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the array is empty.

#### Remarks

If the array is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.Architecture.GutterTypeSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.GutterTypeSetIterator`

#### Summary

An iterator to a gutter type set.

### `T:Autodesk.Revit.DB.Architecture.GutterTypeSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.GutterTypeSet`

#### Summary

A set that contains gutter types.

### `P:Autodesk.Revit.DB.Architecture.GutterTypeSetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.GutterTypeSetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.Architecture.GutterTypeSetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.GutterTypeSetIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.Architecture.GutterTypeSetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.GutterTypeSetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.Architecture.GutterTypeSetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.GutterTypeSetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.Architecture.GutterTypeSet.Insert(Autodesk.Revit.DB.Architecture.GutterType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.GutterTypeSet.Insert(Autodesk.Revit.DB.Architecture.GutterType)`

#### Returntype

System.Int32

#### Summary

Insert the specified gutter type into the set.

#### Parameter `item`

The gutter type to be inserted into the set.

#### Returns

Returns whether the gutter type was inserted into the set.

### `M:Autodesk.Revit.DB.Architecture.GutterTypeSet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.GutterTypeSet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.Architecture.GutterTypeSet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.GutterTypeSet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.Architecture.GutterTypeSetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.Architecture.GutterTypeSet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.GutterTypeSet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.Architecture.GutterTypeSetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.Architecture.GutterTypeSet.Erase(Autodesk.Revit.DB.Architecture.GutterType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.GutterTypeSet.Erase(Autodesk.Revit.DB.Architecture.GutterType)`

#### Returntype

System.Int32

#### Summary

Removes a specified gutter type from the set.

#### Parameter `item`

The gutter type to be erased.

#### Returns

The number of gutter types that were erased from the set.

### `M:Autodesk.Revit.DB.Architecture.GutterTypeSet.Contains(Autodesk.Revit.DB.Architecture.GutterType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.GutterTypeSet.Contains(Autodesk.Revit.DB.Architecture.GutterType)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of a gutter type within the set.

#### Parameter `item`

The gutter type to be searched for.

#### Returns

The Contains method returns True if the gutter type is within the set, otherwise False.

### `M:Autodesk.Revit.DB.Architecture.GutterTypeSet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.GutterTypeSet.Clear`

#### Returntype

void

#### Summary

Removes every gutter type from the set, rendering it empty.

### `P:Autodesk.Revit.DB.Architecture.GutterTypeSet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.GutterTypeSet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of gutter types that are in the set.

### `P:Autodesk.Revit.DB.Architecture.GutterTypeSet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.GutterTypeSet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.GroupSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.GroupSetIterator`

#### Summary

An iterator to a group set.

### `T:Autodesk.Revit.DB.GroupSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.GroupSet`

#### Summary

An set that contains groups.

### `P:Autodesk.Revit.DB.GroupSetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupSetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.GroupSetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.GroupSetIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.GroupSetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.GroupSetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.GroupSetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.GroupSetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.GroupSet.Insert(Autodesk.Revit.DB.Group)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GroupSet.Insert(Autodesk.Revit.DB.Group)`

#### Returntype

System.Int32

#### Summary

Insert the specified group into the set.

#### Parameter `item`

The group to be inserted into the set.

#### Returns

Returns whether the group was inserted into the set.

### `M:Autodesk.Revit.DB.GroupSet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.GroupSet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.GroupSet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.GroupSet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.GroupSetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.GroupSet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.GroupSet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.GroupSetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.GroupSet.Erase(Autodesk.Revit.DB.Group)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GroupSet.Erase(Autodesk.Revit.DB.Group)`

#### Returntype

System.Int32

#### Summary

Removes a specified group from the set.

#### Parameter `item`

The group to be erased.

#### Returns

The number of groups that were erased from the set.

### `M:Autodesk.Revit.DB.GroupSet.Contains(Autodesk.Revit.DB.Group)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GroupSet.Contains(Autodesk.Revit.DB.Group)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of a group within the set.

#### Parameter `item`

The group to be searched for.

#### Returns

The Contains method returns True if the group is within the set, otherwise False.

### `M:Autodesk.Revit.DB.GroupSet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.GroupSet.Clear`

#### Returntype

void

#### Summary

Removes every group from the set, rendering it empty.

### `P:Autodesk.Revit.DB.GroupSet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupSet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of groups that are in the set.

### `P:Autodesk.Revit.DB.GroupSet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.GroupSet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.ReferencePointArrayIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.ReferencePointArrayIterator`

#### Summary

An iterator to a reference array.

### `T:Autodesk.Revit.DB.ReferencePointArray`

Member kind: type
Symbol: `Autodesk.Revit.DB.ReferencePointArray`

#### Summary

An array that contains reference objects.

### `P:Autodesk.Revit.DB.ReferencePointArrayIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.ReferencePointArrayIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.ReferencePointArrayIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferencePointArrayIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.ReferencePointArrayIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferencePointArrayIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the array.

#### Remarks

The Reset method will return the iterator back to the start of the array in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.ReferencePointArrayIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferencePointArrayIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.ReferencePointArray.Insert(Autodesk.Revit.DB.Reference,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferencePointArray.Insert(Autodesk.Revit.DB.Reference,System.Int32)`

#### Returntype

System.Int32

#### Summary

Insert the specified reference into the array.

#### Parameter `item`

The reference to be inserted into the array.

#### Parameter `index`

The reference will be inserted before this index.

#### Returns

Returns whether the reference was inserted into the array.

### `M:Autodesk.Revit.DB.ReferencePointArray.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferencePointArray.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.ReferencePointArray.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferencePointArray.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.ReferencePointArrayIterator

#### Summary

Retrieve a backward moving iterator to the array.

#### Returns

Returns a backward moving iterator to the array.

### `M:Autodesk.Revit.DB.ReferencePointArray.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferencePointArray.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.ReferencePointArrayIterator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.ReferencePointArray.Append(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferencePointArray.Append(Autodesk.Revit.DB.Reference)`

#### Returntype

void

#### Summary

Add the reference to the end of the array.

#### Parameter `item`

The reference to be added.

### `M:Autodesk.Revit.DB.ReferencePointArray.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferencePointArray.Clear`

#### Returntype

void

#### Summary

Removes every reference from the array, rendering it empty.

### `P:Autodesk.Revit.DB.ReferencePointArray.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.ReferencePointArray.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of references that are in the array.

### `P:Autodesk.Revit.DB.ReferencePointArray.Item(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.ReferencePointArray.Item(System.Int32)`

#### Returntype

Autodesk.Revit.DB.Reference

#### Summary

Gets or sets a reference at a specified index within the array.

#### Parameter `index`

The index of the reference to be set or retrieved.

#### Returns

Returns the reference at the specified index.

### `P:Autodesk.Revit.DB.ReferencePointArray.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.ReferencePointArray.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the array is empty.

#### Remarks

If the array is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.ReferenceArrayIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.ReferenceArrayIterator`

#### Summary

An iterator to a reference array.

### `T:Autodesk.Revit.DB.ReferenceArray`

Member kind: type
Symbol: `Autodesk.Revit.DB.ReferenceArray`

#### Summary

An array that contains reference objects.

### `P:Autodesk.Revit.DB.ReferenceArrayIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.ReferenceArrayIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.ReferenceArrayIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferenceArrayIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.ReferenceArrayIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferenceArrayIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the array.

#### Remarks

The Reset method will return the iterator back to the start of the array in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.ReferenceArrayIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferenceArrayIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.ReferenceArray.Insert(Autodesk.Revit.DB.Reference,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferenceArray.Insert(Autodesk.Revit.DB.Reference,System.Int32)`

#### Returntype

System.Int32

#### Summary

Insert the specified reference into the array.

#### Parameter `item`

The reference to be inserted into the array.

#### Parameter `index`

The reference will be inserted before this index.

#### Returns

Returns whether the reference was inserted into the array.

### `M:Autodesk.Revit.DB.ReferenceArray.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferenceArray.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.ReferenceArray.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferenceArray.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.ReferenceArrayIterator

#### Summary

Retrieve a backward moving iterator to the array.

#### Returns

Returns a backward moving iterator to the array.

### `M:Autodesk.Revit.DB.ReferenceArray.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferenceArray.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.ReferenceArrayIterator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.ReferenceArray.Append(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferenceArray.Append(Autodesk.Revit.DB.Reference)`

#### Returntype

void

#### Summary

Add the reference to the end of the array.

#### Parameter `item`

The reference to be added.

### `M:Autodesk.Revit.DB.ReferenceArray.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferenceArray.Clear`

#### Returntype

void

#### Summary

Removes every reference from the array, rendering it empty.

### `P:Autodesk.Revit.DB.ReferenceArray.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.ReferenceArray.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of references that are in the array.

### `P:Autodesk.Revit.DB.ReferenceArray.Item(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.ReferenceArray.Item(System.Int32)`

#### Returntype

Autodesk.Revit.DB.Reference

#### Summary

Gets or sets a reference at a specified index within the array.

#### Parameter `index`

The index of the reference to be set or retrieved.

#### Returns

Returns the reference at the specified index.

### `P:Autodesk.Revit.DB.ReferenceArray.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.ReferenceArray.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the array is empty.

#### Remarks

If the array is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.ReferenceArrayArrayIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.ReferenceArrayArrayIterator`

#### Summary

An iterator to a ReferenceArray array.

### `T:Autodesk.Revit.DB.ReferenceArrayArray`

Member kind: type
Symbol: `Autodesk.Revit.DB.ReferenceArrayArray`

#### Summary

An array that contains ReferenceArray objects.

### `P:Autodesk.Revit.DB.ReferenceArrayArrayIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.ReferenceArrayArrayIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.ReferenceArrayArrayIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferenceArrayArrayIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.ReferenceArrayArrayIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferenceArrayArrayIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the array.

#### Remarks

The Reset method will return the iterator back to the start of the array in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.ReferenceArrayArrayIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferenceArrayArrayIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.ReferenceArrayArray.Insert(Autodesk.Revit.Element,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferenceArrayArray.Insert(Autodesk.Revit.Element,System.Int32)`

#### Returntype

System.Int32

#### Summary

Insert the specified ReferenceArray into the array.

#### Parameter `item`

The ReferenceArray to be inserted into the array.

#### Parameter `index`

The ReferenceArray will be inserted before this index.

#### Returns

Returns whether the ReferenceArray was inserted into the array.

### `M:Autodesk.Revit.DB.ReferenceArrayArray.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferenceArrayArray.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.ReferenceArrayArray.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferenceArrayArray.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.ReferenceArrayArrayIterator

#### Summary

Retrieve a backward moving iterator to the array.

#### Returns

Returns a backward moving iterator to the array.

### `M:Autodesk.Revit.DB.ReferenceArrayArray.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferenceArrayArray.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.ReferenceArrayArrayIterator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.ReferenceArrayArray.Append(Autodesk.Revit.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferenceArrayArray.Append(Autodesk.Revit.Element)`

#### Returntype

void

#### Summary

Add the ReferenceArray to the end of the array.

#### Parameter `item`

The ReferenceArray to be added.

### `M:Autodesk.Revit.DB.ReferenceArrayArray.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.ReferenceArrayArray.Clear`

#### Returntype

void

#### Summary

Removes every ReferenceArray from the array, rendering it empty.

### `P:Autodesk.Revit.DB.ReferenceArrayArray.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.ReferenceArrayArray.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of ReferenceArrays that are in the array.

### `P:Autodesk.Revit.DB.ReferenceArrayArray.Item(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.ReferenceArrayArray.Item(System.Int32)`

#### Returntype

Autodesk.Revit.Element

#### Summary

Gets or sets a ReferenceArray at a specified index within the array.

#### Parameter `index`

The index of the ReferenceArray to be set or retrieved.

#### Returns

Returns the ReferenceArray at the specified index.

### `P:Autodesk.Revit.DB.ReferenceArrayArray.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.ReferenceArrayArray.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the array is empty.

#### Remarks

If the array is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.FaceArrayIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.FaceArrayIterator`

#### Summary

An iterator to a face array.

### `T:Autodesk.Revit.DB.FaceArray`

Member kind: type
Symbol: `Autodesk.Revit.DB.FaceArray`

#### Summary

An array that contains faces.

### `P:Autodesk.Revit.DB.FaceArrayIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.FaceArrayIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.FaceArrayIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.FaceArrayIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.FaceArrayIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.FaceArrayIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the array.

#### Remarks

The Reset method will return the iterator back to the start of the array in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.FaceArrayIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.FaceArrayIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.FaceArray.Insert(Autodesk.Revit.DB.Face,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FaceArray.Insert(Autodesk.Revit.DB.Face,System.Int32)`

#### Returntype

System.Int32

#### Summary

Insert the specified face into the array.

#### Parameter `item`

The face to be inserted into the array.

#### Parameter `index`

The face will be inserted before this index.

#### Returns

Returns whether the face was inserted into the array.

### `M:Autodesk.Revit.DB.FaceArray.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.FaceArray.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.FaceArray.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.FaceArray.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.FaceArrayIterator

#### Summary

Retrieve a backward moving iterator to the array.

#### Returns

Returns a backward moving iterator to the array.

### `M:Autodesk.Revit.DB.FaceArray.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.FaceArray.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.FaceArrayIterator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.FaceArray.Append(Autodesk.Revit.DB.Face)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FaceArray.Append(Autodesk.Revit.DB.Face)`

#### Returntype

void

#### Summary

Add the face to the end of the array.

#### Parameter `item`

The face to be added.

### `M:Autodesk.Revit.DB.FaceArray.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.FaceArray.Clear`

#### Returntype

void

#### Summary

Removes every face from the array, rendering it empty.

### `P:Autodesk.Revit.DB.FaceArray.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.FaceArray.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of faces that are in the array.

### `P:Autodesk.Revit.DB.FaceArray.Item(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.FaceArray.Item(System.Int32)`

#### Returntype

System.Object

#### Summary

Gets or sets a face at a specified index within the array.

#### Parameter `index`

The index of the face to be set or retrieved.

#### Returns

Returns the face at the specified index.

### `P:Autodesk.Revit.DB.FaceArray.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.FaceArray.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the array is empty.

#### Remarks

If the array is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.EdgeArrayIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.EdgeArrayIterator`

#### Summary

An iterator to an edge array.

### `T:Autodesk.Revit.DB.EdgeArray`

Member kind: type
Symbol: `Autodesk.Revit.DB.EdgeArray`

#### Summary

An array that contains edges.

### `P:Autodesk.Revit.DB.EdgeArrayIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.EdgeArrayIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.EdgeArrayIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.EdgeArrayIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.EdgeArrayIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.EdgeArrayIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the array.

#### Remarks

The Reset method will return the iterator back to the start of the array in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.EdgeArrayIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.EdgeArrayIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.EdgeArray.Insert(Autodesk.Revit.DB.Edge,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.EdgeArray.Insert(Autodesk.Revit.DB.Edge,System.Int32)`

#### Returntype

System.Int32

#### Summary

Insert the specified edge into the array.

#### Parameter `item`

The edge to be inserted into the array.

#### Parameter `index`

The edge will be inserted before this index.

#### Returns

Returns whether the edge was inserted into the array.

### `M:Autodesk.Revit.DB.EdgeArray.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.EdgeArray.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.EdgeArray.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.EdgeArray.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.EdgeArrayIterator

#### Summary

Retrieve a backward moving iterator to the array.

#### Returns

Returns a backward moving iterator to the array.

### `M:Autodesk.Revit.DB.EdgeArray.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.EdgeArray.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.EdgeArrayIterator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.EdgeArray.Append(Autodesk.Revit.DB.Edge)`

Member kind: method
Symbol: `Autodesk.Revit.DB.EdgeArray.Append(Autodesk.Revit.DB.Edge)`

#### Returntype

void

#### Summary

Add the edge to the end of the array.

#### Parameter `item`

The edge to be added.

### `M:Autodesk.Revit.DB.EdgeArray.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.EdgeArray.Clear`

#### Returntype

void

#### Summary

Removes every edge from the array, rendering it empty.

### `P:Autodesk.Revit.DB.EdgeArray.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.EdgeArray.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of edges that are in the array.

### `P:Autodesk.Revit.DB.EdgeArray.Item(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.EdgeArray.Item(System.Int32)`

#### Returntype

System.Object

#### Summary

Gets or sets an edge at a specified index within the array.

#### Parameter `index`

The index of the edge to be set or retrieved.

#### Returns

Returns the edge at the specified index.

### `P:Autodesk.Revit.DB.EdgeArray.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.EdgeArray.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the array is empty.

#### Remarks

If the array is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.EdgeArrayArrayIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.EdgeArrayArrayIterator`

#### Summary

An iterator to an array or edge arrays.

### `T:Autodesk.Revit.DB.EdgeArrayArray`

Member kind: type
Symbol: `Autodesk.Revit.DB.EdgeArrayArray`

#### Summary

An array of edge arrays.

### `P:Autodesk.Revit.DB.EdgeArrayArrayIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.EdgeArrayArrayIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.EdgeArrayArrayIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.EdgeArrayArrayIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.EdgeArrayArrayIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.EdgeArrayArrayIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the array.

#### Remarks

The Reset method will return the iterator back to the start of the array in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.EdgeArrayArrayIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.EdgeArrayArrayIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.EdgeArrayArray.Insert(Autodesk.Revit.DB.EdgeArray,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.EdgeArrayArray.Insert(Autodesk.Revit.DB.EdgeArray,System.Int32)`

#### Returntype

System.Int32

#### Summary

Insert the specified edge array into the array.

#### Parameter `item`

The edge array to be inserted into the array.

#### Parameter `index`

The edge array will be inserted before this index.

#### Returns

Returns whether the edge array was inserted into the array.

### `M:Autodesk.Revit.DB.EdgeArrayArray.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.EdgeArrayArray.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.EdgeArrayArray.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.EdgeArrayArray.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.EdgeArrayArrayIterator

#### Summary

Retrieve a backward moving iterator to the array.

#### Returns

Returns a backward moving iterator to the array.

### `M:Autodesk.Revit.DB.EdgeArrayArray.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.EdgeArrayArray.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.EdgeArrayArrayIterator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.EdgeArrayArray.Append(Autodesk.Revit.DB.EdgeArray)`

Member kind: method
Symbol: `Autodesk.Revit.DB.EdgeArrayArray.Append(Autodesk.Revit.DB.EdgeArray)`

#### Returntype

void

#### Summary

Add the edge array to the end of the array.

#### Parameter `item`

The edge array to be added.

### `M:Autodesk.Revit.DB.EdgeArrayArray.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.EdgeArrayArray.Clear`

#### Returntype

void

#### Summary

Removes every edge array from the array, rendering it empty.

### `P:Autodesk.Revit.DB.EdgeArrayArray.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.EdgeArrayArray.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of edge arrays that are in the array.

### `P:Autodesk.Revit.DB.EdgeArrayArray.Item(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.EdgeArrayArray.Item(System.Int32)`

#### Returntype

System.Object

#### Summary

Gets or sets an edge array at a specified index within the array.

#### Parameter `index`

The index of the edge array to be set or retrieved.

#### Returns

Returns the edge array at the specified index.

### `P:Autodesk.Revit.DB.EdgeArrayArray.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.EdgeArrayArray.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the array is empty.

#### Remarks

If the array is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.DoubleArrayIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.DoubleArrayIterator`

#### Summary

An iterator to an array of doubles.

### `T:Autodesk.Revit.DB.DoubleArray`

Member kind: type
Symbol: `Autodesk.Revit.DB.DoubleArray`

#### Summary

An array that contains doubles.

### `P:Autodesk.Revit.DB.DoubleArrayIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.DoubleArrayIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.DoubleArrayIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.DoubleArrayIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.DoubleArrayIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.DoubleArrayIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the array.

#### Remarks

The Reset method will return the iterator back to the start of the array in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.DoubleArrayIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.DoubleArrayIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.DoubleArray.Insert(Autodesk.Revit.DB.Double@,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DoubleArray.Insert(Autodesk.Revit.DB.Double@,System.Int32)`

#### Returntype

System.Int32

#### Summary

Insert the specified double into the array.

#### Parameter `item`

The double to be inserted into the array.

#### Parameter `index`

The double will be inserted before this index.

#### Returns

Returns whether the double was inserted into the array.

### `M:Autodesk.Revit.DB.DoubleArray.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.DoubleArray.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.DoubleArray.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.DoubleArray.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.DoubleArrayIterator

#### Summary

Retrieve a backward moving iterator to the array.

#### Returns

Returns a backward moving iterator to the array.

### `M:Autodesk.Revit.DB.DoubleArray.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.DoubleArray.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.DoubleArrayIterator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.DoubleArray.Append(Autodesk.Revit.DB.Double@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.DoubleArray.Append(Autodesk.Revit.DB.Double@)`

#### Returntype

void

#### Summary

Add the double to the end of the array.

#### Parameter `item`

The double to be added.

### `M:Autodesk.Revit.DB.DoubleArray.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.DoubleArray.Clear`

#### Returntype

void

#### Summary

Removes every double from the array, rendering it empty.

### `P:Autodesk.Revit.DB.DoubleArray.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.DoubleArray.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of doubles that are in the array.

### `P:Autodesk.Revit.DB.DoubleArray.Item(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.DoubleArray.Item(System.Int32)`

#### Returntype

System.Object

#### Summary

Gets or sets a double at a specified index within the array.

#### Parameter `index`

The index of the double to be set or retrieved.

#### Returns

Returns the double at the specified index.

### `P:Autodesk.Revit.DB.DoubleArray.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.DoubleArray.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the array is empty.

#### Remarks

If the array is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.CurveArrArrayIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.CurveArrArrayIterator`

#### Summary

An iterator to a array.

### `T:Autodesk.Revit.DB.CurveArrArray`

Member kind: type
Symbol: `Autodesk.Revit.DB.CurveArrArray`

#### Summary

An array that can contain any type of object.

### `P:Autodesk.Revit.DB.CurveArrArrayIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurveArrArrayIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.CurveArrArrayIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveArrArrayIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.CurveArrArrayIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveArrArrayIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the array.

#### Remarks

The Reset method will return the iterator back to the start of the array in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.CurveArrArrayIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveArrArrayIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.CurveArrArray.Insert(System.Object,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveArrArray.Insert(System.Object,System.Int32)`

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

### `M:Autodesk.Revit.DB.CurveArrArray.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveArrArray.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.CurveArrArray.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveArrArray.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.CurveArrArrayIterator

#### Summary

Retrieve a backward moving iterator to the array.

#### Returns

Returns a backward moving iterator to the array.

### `M:Autodesk.Revit.DB.CurveArrArray.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveArrArray.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.CurveArrArrayIterator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.CurveArrArray.Append(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveArrArray.Append(System.Object)`

#### Returntype

void

#### Summary

Add the item to the end of the array.

#### Parameter `item`

The item to be added.

### `M:Autodesk.Revit.DB.CurveArrArray.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.CurveArrArray.Clear`

#### Returntype

void

#### Summary

Removes every item from the array, rendering it empty.

### `P:Autodesk.Revit.DB.CurveArrArray.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurveArrArray.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of objects that are in the array.

### `P:Autodesk.Revit.DB.CurveArrArray.Item(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurveArrArray.Item(System.Int32)`

#### Returntype

System.Object

#### Summary

Gets or sets an item at a specified index within the array.

#### Parameter `index`

The index of the item to be set or retrieved.

#### Returns

Returns the object at the specified index.

### `P:Autodesk.Revit.DB.CurveArrArray.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.CurveArrArray.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the array is empty.

#### Remarks

If the array is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.GeomCombinationSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.GeomCombinationSetIterator`

#### Summary

An iterator to a GeomCombination set.

### `T:Autodesk.Revit.DB.GeomCombinationSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.GeomCombinationSet`

#### Summary

A set that contains GeomCombination objects.

### `P:Autodesk.Revit.DB.GeomCombinationSetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.GeomCombinationSetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.GeomCombinationSetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeomCombinationSetIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.GeomCombinationSetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeomCombinationSetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.GeomCombinationSetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeomCombinationSetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.GeomCombinationSet.Insert(Autodesk.Revit.DB.GeomCombination)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeomCombinationSet.Insert(Autodesk.Revit.DB.GeomCombination)`

#### Returntype

System.Int32

#### Summary

Insert the specified element into the set.

#### Parameter `item`

The GeomCombination to be inserted into the set.

#### Returns

Returns whether the GeomCombination was inserted into the set.

### `M:Autodesk.Revit.DB.GeomCombinationSet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeomCombinationSet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.GeomCombinationSet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeomCombinationSet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.GeomCombinationSetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.GeomCombinationSet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeomCombinationSet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.GeomCombinationSetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.GeomCombinationSet.Erase(Autodesk.Revit.DB.GeomCombination)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeomCombinationSet.Erase(Autodesk.Revit.DB.GeomCombination)`

#### Returntype

System.Int32

#### Summary

Removes a specified GeomCombination from the set.

#### Parameter `item`

The GeomCombination to be erased.

#### Returns

The number of GeomCombinations that were erased from the set.

### `M:Autodesk.Revit.DB.GeomCombinationSet.Contains(Autodesk.Revit.DB.GeomCombination)`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeomCombinationSet.Contains(Autodesk.Revit.DB.GeomCombination)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of an GeomCombination within the set.

#### Parameter `item`

The element to be searched for.

#### Returns

The Contains method returns True if the GeomCombination is within the set, otherwise False.

### `M:Autodesk.Revit.DB.GeomCombinationSet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.GeomCombinationSet.Clear`

#### Returntype

void

#### Summary

Removes every item GeomCombination the set, rendering it empty.

### `P:Autodesk.Revit.DB.GeomCombinationSet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.GeomCombinationSet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of GeomCombinations that are in the set.

### `P:Autodesk.Revit.DB.GeomCombinationSet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.GeomCombinationSet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.FormArrayIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.FormArrayIterator`

#### Summary

An iterator to a form array.

### `T:Autodesk.Revit.DB.FormArray`

Member kind: type
Symbol: `Autodesk.Revit.DB.FormArray`

#### Summary

An array that contains form objects.

### `P:Autodesk.Revit.DB.FormArrayIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.FormArrayIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.FormArrayIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormArrayIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.FormArrayIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormArrayIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the array.

#### Remarks

The Reset method will return the iterator back to the start of the array in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.FormArrayIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormArrayIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.FormArray.Insert(Autodesk.Revit.DB.Element,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormArray.Insert(Autodesk.Revit.DB.Element,System.Int32)`

#### Returntype

System.Int32

#### Summary

Insert the specified form into the array.

#### Parameter `item`

The form to be inserted into the array.

#### Parameter `index`

The form will be inserted before this index.

#### Returns

Returns whether the form was inserted into the array.

### `M:Autodesk.Revit.DB.FormArray.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormArray.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.FormArray.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormArray.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.FormArrayIterator

#### Summary

Retrieve a backward moving iterator to the array.

#### Returns

Returns a backward moving iterator to the array.

### `M:Autodesk.Revit.DB.FormArray.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormArray.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.FormArrayIterator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.DB.FormArray.Append(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormArray.Append(Autodesk.Revit.DB.Element)`

#### Returntype

void

#### Summary

Add the form to the end of the array.

#### Parameter `item`

The form to be added.

### `M:Autodesk.Revit.DB.FormArray.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.FormArray.Clear`

#### Returntype

void

#### Summary

Removes every form from the array, rendering it empty.

### `P:Autodesk.Revit.DB.FormArray.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.FormArray.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of forms that are in the array.

### `P:Autodesk.Revit.DB.FormArray.Item(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.DB.FormArray.Item(System.Int32)`

#### Returntype

Autodesk.Revit.DB.Element

#### Summary

Gets or sets a form at a specified index within the array.

#### Parameter `index`

The index of the form to be set or retrieved.

#### Returns

Returns the form at the specified index.

### `P:Autodesk.Revit.DB.FormArray.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.FormArray.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the array is empty.

#### Remarks

If the array is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.FamilyTypeSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.FamilyTypeSetIterator`

#### Summary

An iterator to a FamilyType set.

### `T:Autodesk.Revit.DB.FamilyTypeSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.FamilyTypeSet`

#### Summary

A set that contains FamilyType objects.

### `P:Autodesk.Revit.DB.FamilyTypeSetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyTypeSetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.FamilyTypeSetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyTypeSetIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.FamilyTypeSetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyTypeSetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.FamilyTypeSetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyTypeSetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.FamilyTypeSet.Insert(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyTypeSet.Insert(System.Object)`

#### Returntype

System.Int32

#### Summary

Insert the specified item into the set.

#### Parameter `item`

The item to be inserted into the set.

#### Returns

Returns whether the item was inserted into the set.

### `M:Autodesk.Revit.DB.FamilyTypeSet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyTypeSet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.FamilyTypeSet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyTypeSet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.FamilyTypeSetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.FamilyTypeSet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyTypeSet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.FamilyTypeSetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.FamilyTypeSet.Erase(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyTypeSet.Erase(System.Object)`

#### Returntype

System.Int32

#### Summary

Removes a specified object from the set.

#### Parameter `item`

The item to be erased.

#### Returns

The number of items that were erased from the set.

### `M:Autodesk.Revit.DB.FamilyTypeSet.Contains(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyTypeSet.Contains(System.Object)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of an item within the set.

#### Parameter `item`

The item to be searched for.

#### Returns

The Contains method returns True if the item is within the set, otherwise False.

### `M:Autodesk.Revit.DB.FamilyTypeSet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyTypeSet.Clear`

#### Returntype

void

#### Summary

Removes every item from the set, rendering it empty.

### `P:Autodesk.Revit.DB.FamilyTypeSet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyTypeSet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of objects that are in the set.

### `P:Autodesk.Revit.DB.FamilyTypeSet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyTypeSet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.FamilyParameterSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.FamilyParameterSetIterator`

#### Summary

An iterator to a FamilyParameter set.

### `T:Autodesk.Revit.DB.FamilyParameterSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.FamilyParameterSet`

#### Summary

A set that contains FamilyParameter objects.

### `P:Autodesk.Revit.DB.FamilyParameterSetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyParameterSetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.FamilyParameterSetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyParameterSetIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.FamilyParameterSetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyParameterSetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.FamilyParameterSetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyParameterSetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.FamilyParameterSet.Insert(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyParameterSet.Insert(System.Object)`

#### Returntype

System.Int32

#### Summary

Insert the specified item into the set.

#### Parameter `item`

The item to be inserted into the set.

#### Returns

Returns whether the item was inserted into the set.

### `M:Autodesk.Revit.DB.FamilyParameterSet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyParameterSet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.FamilyParameterSet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyParameterSet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.FamilyParameterSetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.FamilyParameterSet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyParameterSet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.FamilyParameterSetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.FamilyParameterSet.Erase(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyParameterSet.Erase(System.Object)`

#### Returntype

System.Int32

#### Summary

Removes a specified object from the set.

#### Parameter `item`

The item to be erased.

#### Returns

The number of items that were erased from the set.

### `M:Autodesk.Revit.DB.FamilyParameterSet.Contains(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyParameterSet.Contains(System.Object)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of an item within the set.

#### Parameter `item`

The item to be searched for.

#### Returns

The Contains method returns True if the item is within the set, otherwise False.

### `M:Autodesk.Revit.DB.FamilyParameterSet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.FamilyParameterSet.Clear`

#### Returntype

void

#### Summary

Removes every item from the set, rendering it empty.

### `P:Autodesk.Revit.DB.FamilyParameterSet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyParameterSet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of objects that are in the set.

### `P:Autodesk.Revit.DB.FamilyParameterSet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.FamilyParameterSet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.UI.ExternalApplicationArrayIterator`

Member kind: type
Symbol: `Autodesk.Revit.UI.ExternalApplicationArrayIterator`

#### Summary

An iterator to an array of IExternalApplication objects..

### `T:Autodesk.Revit.UI.ExternalApplicationArray`

Member kind: type
Symbol: `Autodesk.Revit.UI.ExternalApplicationArray`

#### Summary

An array that can contain any number of IExternalApplication objects.

### `P:Autodesk.Revit.UI.ExternalApplicationArrayIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.UI.ExternalApplicationArrayIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.UI.ExternalApplicationArrayIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.UI.ExternalApplicationArrayIterator.MoveNext`

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

### `M:Autodesk.Revit.UI.ExternalApplicationArrayIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.UI.ExternalApplicationArrayIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the array.

#### Remarks

The Reset method will return the iterator back to the start of the array in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.UI.ExternalApplicationArrayIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.UI.ExternalApplicationArrayIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.UI.ExternalApplicationArray.Insert(Autodesk.Revit.UI.IExternalApplication,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ExternalApplicationArray.Insert(Autodesk.Revit.UI.IExternalApplication,System.Int32)`

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

### `M:Autodesk.Revit.UI.ExternalApplicationArray.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.UI.ExternalApplicationArray.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.UI.ExternalApplicationArray.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.UI.ExternalApplicationArray.ReverseIterator`

#### Returntype

Autodesk.Revit.UI.ExternalApplicationArrayIterator

#### Summary

Retrieve a backward moving iterator to the array.

#### Returns

Returns a backward moving iterator to the array.

### `M:Autodesk.Revit.UI.ExternalApplicationArray.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.UI.ExternalApplicationArray.ForwardIterator`

#### Returntype

Autodesk.Revit.UI.ExternalApplicationArrayIterator

#### Summary

Retrieve a forward moving iterator to the array.

#### Returns

Returns a forward moving iterator to the array.

### `M:Autodesk.Revit.UI.ExternalApplicationArray.Append(Autodesk.Revit.UI.IExternalApplication)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ExternalApplicationArray.Append(Autodesk.Revit.UI.IExternalApplication)`

#### Returntype

void

#### Summary

Add the item to the end of the array.

#### Parameter `item`

The item to be added.

### `M:Autodesk.Revit.UI.ExternalApplicationArray.Clear`

Member kind: method
Symbol: `Autodesk.Revit.UI.ExternalApplicationArray.Clear`

#### Returntype

void

#### Summary

Removes every item from the array, rendering it empty.

### `P:Autodesk.Revit.UI.ExternalApplicationArray.Size`

Member kind: property
Symbol: `Autodesk.Revit.UI.ExternalApplicationArray.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of objects that are in the array.

### `P:Autodesk.Revit.UI.ExternalApplicationArray.Item(System.Int32)`

Member kind: property
Symbol: `Autodesk.Revit.UI.ExternalApplicationArray.Item(System.Int32)`

#### Returntype

System.Object

#### Summary

Gets or sets an item at a specified index within the array.

#### Parameter `index`

The index of the item to be set or retrieved.

#### Returns

Returns the object at the specified index.

### `P:Autodesk.Revit.UI.ExternalApplicationArray.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.UI.ExternalApplicationArray.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the array is empty.

#### Remarks

If the array is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.ElementSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementSetIterator`

#### Summary

An iterator to an element set.

### `T:Autodesk.Revit.DB.ElementSet`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementSet`

#### Summary

A set that contains element objects.

### `P:Autodesk.Revit.DB.ElementSetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementSetIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.

### `M:Autodesk.Revit.DB.ElementSetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementSetIterator.MoveNext`

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

### `M:Autodesk.Revit.DB.ElementSetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementSetIterator.Reset`

#### Returntype

void

#### Summary

Bring the iterator back to the start of the set.

#### Remarks

The Reset method will return the iterator back to the start of the set in line with the definition of IEnumerator. Note that you must call MoveNext before the first item can be accessed via the Current property.

### `M:Autodesk.Revit.DB.ElementSetIterator.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementSetIterator.#ctor`

#### Returntype

void

#### Summary

For Internal Use Only.

#### Remarks

This constructor is exposed to enable support for COM interop only. This object should never be created by the developer.

### `M:Autodesk.Revit.DB.ElementSet.Insert(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementSet.Insert(Autodesk.Revit.DB.Element)`

#### Returntype

System.Int32

#### Summary

Insert the specified element into the set.

#### Parameter `item`

The element to be inserted into the set.

#### Returns

Returns whether the element was inserted into the set.

### `M:Autodesk.Revit.DB.ElementSet.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementSet.GetEnumerator`

#### Returntype

System.Collections.IEnumerator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.ElementSet.ReverseIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementSet.ReverseIterator`

#### Returntype

Autodesk.Revit.DB.ElementSetIterator

#### Summary

Retrieve a backward moving iterator to the set.

#### Returns

Returns a backward moving iterator to the set.

### `M:Autodesk.Revit.DB.ElementSet.ForwardIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementSet.ForwardIterator`

#### Returntype

Autodesk.Revit.DB.ElementSetIterator

#### Summary

Retrieve a forward moving iterator to the set.

#### Returns

Returns a forward moving iterator to the set.

### `M:Autodesk.Revit.DB.ElementSet.Erase(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementSet.Erase(Autodesk.Revit.DB.Element)`

#### Returntype

System.Int32

#### Summary

Removes a specified element from the set.

#### Parameter `item`

The element to be erased.

#### Returns

The number of elements that were erased from the set.

### `M:Autodesk.Revit.DB.ElementSet.Contains(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementSet.Contains(Autodesk.Revit.DB.Element)`

#### Returntype

System.Boolean

#### Summary

Tests for the existence of an element within the set.

#### Parameter `item`

The element to be searched for.

#### Returns

The Contains method returns True if the element is within the set, otherwise False.

### `M:Autodesk.Revit.DB.ElementSet.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.ElementSet.Clear`

#### Returntype

void

#### Summary

Removes every item element the set, rendering it empty.

### `P:Autodesk.Revit.DB.ElementSet.Size`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementSet.Size`

#### Returntype

System.Int32

#### Proptype

get

#### Summary

Returns the number of elements that are in the set.

### `P:Autodesk.Revit.DB.ElementSet.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementSet.IsEmpty`

#### Returntype

System.Boolean

#### Proptype

get

#### Summary

Test to see if the set is empty.

#### Remarks

If the set is empty then True will be returned, otherwise False.

### `T:Autodesk.Revit.DB.ElementArrayIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementArrayIterator`

#### Summary

An iterator to an element array.

### `T:Autodesk.Revit.DB.ElementArray`

Member kind: type
Symbol: `Autodesk.Revit.DB.ElementArray`

#### Summary

An array that contains element objects.

### `P:Autodesk.Revit.DB.ElementArrayIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.ElementArrayIterator.Current`

#### Returntype

System.Object

#### Proptype

get

#### Summary

Retrieves the item that is the current focus of the iterator.

#### Remarks

A new or Reset iterator must have MoveNext called on it before Current will return a valid
item as per expected behavior of IEnumerator.
