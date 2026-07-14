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
Shard: 31
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `P:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.StirrupTieAttachmentType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.StirrupTieAttachmentType`

#### Summary

Identifies the StirrupTieAttachmentType of the current Rebar element.
The RebarStyle of the Rebar element must be StirrupTie.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2022

### `P:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.RebarStyle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.RebarStyle`

#### Summary

Identifies the RebarStyle of the current Rebar element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2022

### `P:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.WorkshopInstructions`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor.WorkshopInstructions`

#### Summary

Identifies the workshop instructions of the current Rebar element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2019

### `T:Autodesk.Revit.DB.Structure.RebarFreeFormAccessor`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormAccessor`

#### Summary

A class that is used to access the properties and capabilities of free-form Rebar.

#### Remarks

Obtain an instance of this class from `M:Autodesk.Revit.DB.Structure.Rebar.GetFreeFormAccessor` .
The accessor includes a reference to the Rebar element.
If the referenced Rebar element is deleted, using the methods form this class will throw exception.

#### Since

2018

### `T:Autodesk.Revit.DB.Structure.StirrupTieAttachmentType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StirrupTieAttachmentType`

#### Summary

An enumerated tye that represents how the Stirrup/Tie rebar is attached to the cover reference.

#### Since

2012

### `F:Autodesk.Revit.DB.Structure.StirrupTieAttachmentType.ExteriorFace`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StirrupTieAttachmentType.ExteriorFace`

#### Summary

Designate Stirrup/Tie rebar to attach to exterior face of cover reference.

### `F:Autodesk.Revit.DB.Structure.StirrupTieAttachmentType.InteriorFace`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StirrupTieAttachmentType.InteriorFace`

#### Summary

Designate Stirrup/Tie rebar to attach to interior face of cover reference.

### `M:Autodesk.Revit.DB.Structure.RebarConstraintsManager.HasValidRebar`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraintsManager.HasValidRebar`

#### Summary

Checks whether the Manager's Rebar is still valid.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarConstraintsManager.ApplyRebarConstraints(System.Collections.Generic.IList{Autodesk.Revit.DB.Structure.RebarConstraint},System.Collections.Generic.IList{Autodesk.Revit.DB.Reference},System.Collections.Generic.IList{Autodesk.Revit.DB.Reference})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraintsManager.ApplyRebarConstraints(System.Collections.Generic.IList{Autodesk.Revit.DB.Structure.RebarConstraint},System.Collections.Generic.IList{Autodesk.Revit.DB.Reference},System.Collections.Generic.IList{Autodesk.Revit.DB.Reference})`

#### Summary

Returns true if constraints were applied to rebar with success.

#### Remarks

ShapeDriven : The input constraints belong to other rebar in a (different) similar host. Only constraints of type ToHostFace or ToCover are considered.
The method modifies the constraints' target references with their correspondants in current host(s).
The modified constraints are set in current rebar.
The method will fail : if there exists at least one ToOtherRebar constraint; if corresponding target references in current host(s) are not supplied or found.

FreeForm : The constraints will not be applied and the method will return false.

The two arrays go hand in hand : they must have the same size; the correspondant of oldReference at index x is found in the other array at the same index x.

#### Parameter `constraintsToApply`

Represent the new constraints to be applied to rebar.

#### Parameter `oldTargets`

Represent the old target references.

#### Parameter `newTargets`

Represent the new target references.

#### Returns

Returns true if the constraints were applied succesfully, false otherwise

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The RebarConstraintsManager does not manage a valid Rebar element.

#### Since

2019

### `M:Autodesk.Revit.DB.Structure.RebarConstraintsManager.AllowConstraintTargets(Autodesk.Revit.DB.Structure.RebarConstrainedHandle,System.Collections.Generic.IList{Autodesk.Revit.DB.Reference})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraintsManager.AllowConstraintTargets(Autodesk.Revit.DB.Structure.RebarConstrainedHandle,System.Collections.Generic.IList{Autodesk.Revit.DB.Reference})`

#### Summary

Returns true if references are valid targets for handle, false otherwise.

#### Remarks

For a free form rebar valid targets are one or more references to faces of elements that can host rebar.

For a shape driven rebar this function will always return false. RebarConstraintsManager.GetConstraintCandidatesForHandle() can be used to obtain possible constraints.

#### Parameter `handle`

Represents the constrainable rebar handle.

#### Parameter `targetsToConstrain`

Represent the refernces to be checked as valid targets for handle.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The RebarConstraintsManager does not manage a valid Rebar element.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarConstraintsManager.ClearHandleConstraintPairHighlighting(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraintsManager.ClearHandleConstraintPairHighlighting(Autodesk.Revit.DB.Document)`

#### Summary

Clears all highlighting in all views.

#### Remarks

If highlightHandleConstraintPairInAllViews has been called, then this method can
be used to remove all highlighting.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarConstraintsManager.HighlightHandleConstraintPairInAllViews(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.RebarConstrainedHandle,Autodesk.Revit.DB.Structure.RebarConstraint)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraintsManager.HighlightHandleConstraintPairInAllViews(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.RebarConstrainedHandle,Autodesk.Revit.DB.Structure.RebarConstraint)`

#### Summary

Highlights the specified RebarConstrainedHandle and RebarConstraint in all views.

#### Remarks

This method is provided as a way to help end users visualize more easily the effect
that selecting new RebarConstraints for the Rebar element's RebarConstrainedHandle
will have on the Rebar. It is purely for graphical output, and does not assume any
relationship between the RebarConstrainedHandle and the RebarConstraint. The caller
is responsible for updating (or clearing) the highlighting in response to changes
in the Rebar's constraints.
Repeated calls to this method are not cumulative; highlighting from previous calls
will be cleared before new highlighting is applied.

#### Parameter `handle`

The RebarConstrainedHandle to be highlighted in all views.

#### Parameter `constraint`

The RebarConstraint to be highlighted in all views.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

constraint is no longer valid.
-or-
handle is no longer valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The RebarConstraintsManager does not manage a valid Rebar element.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarConstraintsManager.GetPreferredConstraintOnHandle(Autodesk.Revit.DB.Structure.RebarConstrainedHandle)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraintsManager.GetPreferredConstraintOnHandle(Autodesk.Revit.DB.Structure.RebarConstrainedHandle)`

#### Summary

For ShapeDriven: Returns the RebarConstraint that has been set as preferred for the specified RebarConstrainedHandle.

For FreeForm: Returns the RebarConstraint that acts on the specified RebarConstraintHandle.

#### Parameter `handle`

The RebarConstrainedHandle for which the RebarConstraint is to be returned.

#### Returns

The user preferred RebarConstraint applied to the RebarConstrainedHandle.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

handle is no longer valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The RebarConstraintsManager does not manage a valid Rebar element.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarConstraintsManager.GetAllHandles`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraintsManager.GetAllHandles`

#### Summary

Gets all RebarConstrainedHandles of this bar.

#### Returns

All RebarConstrainedHandle objects will be returned, regardless of whether there are constraints associated to them.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The RebarConstraintsManager does not manage a valid Rebar element.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.RebarConstraintsManager.RemovePreferredConstraintFromHandle(Autodesk.Revit.DB.Structure.RebarConstrainedHandle)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraintsManager.RemovePreferredConstraintFromHandle(Autodesk.Revit.DB.Structure.RebarConstrainedHandle)`

#### Summary

For ShapeDriven: Clears the user-preferred RebarConstraint from the specified RebarConstrainedHandle.

For FreeForm: Removes the RebarConstraint that is associated to the specified RebarConstrainedHandle.

#### Remarks

ShapeDriven:

After the preferred constraint is removed, the rebar will search for an appropriate
default constraint for the handle in its current position. In some cases, this will
cause the handle to snap a small distance to a new target. However, in many situations,
the handle will simply remain in its current position, and either continue to use the
same constraint target (while no longer treating that target as preferred), or acquire
a FixedDistancetoHostFace constraint to the nearest host element surface.
The handle will not, in general, be restored to the position it originally occupied
before the preferred constraint was applied.

FreeForm:

After the Constraint is removed, the handle remains unconstrained, and the shape calculation
tries to resolve a shape without this information. Depending on the calculation method,
the bar may not have all the necessary information, so the responsibility to constrain
this handle is in the hands of the caller of this function.

#### Parameter `handle`

The RebarConstrainedHandle for which the user RebarConstraint is to be deleted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

handle is no longer valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The RebarConstraintsManager does not manage a valid Rebar element.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarConstraintsManager.SetPreferredConstraintForHandle(Autodesk.Revit.DB.Structure.RebarConstrainedHandle,Autodesk.Revit.DB.Structure.RebarConstraint)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraintsManager.SetPreferredConstraintForHandle(Autodesk.Revit.DB.Structure.RebarConstrainedHandle,Autodesk.Revit.DB.Structure.RebarConstraint)`

#### Summary

For ShapeDriven Rebar: Sets the RebarConstraint as preferred constraint target for the specified RebarConstrainedHandle.

For FreeForm Rebar: Sets the RebarConstraint as the target for the specified RebarConstraintHandle.

#### Remarks

ShapeDriven:

The RebarConstraint should be one of the candidate RebarConstraints returned by
getConstraintCandidatesForHandle.

In general, the caller should assume that the 'set' operation can fail, as some
of the candidates may be legal targets for the handle, but may cause the rebar
to flex into an insoluble shape.

Once a preferred constraint has been successfully assigned to a handle, the
user can still drag the handle, and the Rebar can generally be flexed in much
the same way as it could before (preferred constraints do not have the same
effect as Revit locked dimensions). However, the rebar's behavior will change
in subtle ways.

A handle with a FixedDistanceToHostFace preferred constraint will allow the
constraint's offset distance to change as the user moves the handle. However,
in subsequent model updates, the handle will continue to follow the preferred
constraint target, even if other legitimate constraint targets are closer to
the handle. One can think of this behavior as equivalent to unlocking a
locked dimension, moving one of dimension references, and then re-locking the
dimension - all in one step.

When a handle with a ToCover or ToOtherRebar preferred constraint is dragged by
the user, it will snap back to its constraint target, unless it is dragged
beyond tolerance distance. In that case, it will select a new constraint using
default logic, but will continue to treat the "broken" constraint as preferred,
and will snap back to the preferred target again, if it is dragged to within
tolerance distance.

If, during a model update, the rebar determines that a preferred constraint
target no longer exists, or has been modified so that it is no longer a legal
candidate for the handle, then the rebar will remove the preferred status of
that target and will assign a new constraint to the handle using the default
logic.

FreeForm:

Sets the RebarConstraint to be active for the specified RebarConstrainedHandle.
The RebarConstrainedHandle needs to be a valid handle for this rebar element.

#### Parameter `handle`

The RebarConstrainedHandle to which the new RebarConstraint is to be applied.

#### Parameter `constraint`

The new RebarConstraint to be applied to the RebarConstrainedHandle.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

constraint is no longer valid.
-or-
handle is no longer valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The RebarConstraintsManager does not manage a valid Rebar element.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarConstraintsManager.GetConstraintCandidatesForHandle(Autodesk.Revit.DB.Structure.RebarConstrainedHandle,Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraintsManager.GetConstraintCandidatesForHandle(Autodesk.Revit.DB.Structure.RebarConstrainedHandle,Autodesk.Revit.DB.Reference)`

#### Summary

For shape driven rebar returns all possible RebarConstraints that will constrain RebarConstrainedHandle to the provided reference.

For free form rebar will return an empty lists.

#### Remarks

Will throw exception if the provided reference cannot be used to constrain the provided rebar handle.

#### Parameter `handle`

The RebarConstrainedHandle for which constraint candidates are sought.

#### Parameter `reference`

The reference you want to constrain to.

#### Returns

A collection of RebarConstraints

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

reference is not from a valid RebarConstraint target element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The RebarConstraintsManager does not manage a valid Rebar element.

#### Since

2020.1

### `M:Autodesk.Revit.DB.Structure.RebarConstraintsManager.GetConstraintCandidatesForHandle(Autodesk.Revit.DB.Structure.RebarConstrainedHandle,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraintsManager.GetConstraintCandidatesForHandle(Autodesk.Revit.DB.Structure.RebarConstrainedHandle,Autodesk.Revit.DB.ElementId)`

#### Summary

For shape driven rebar returns all possible RebarConstraints belonging to references from the provided element that could be used for a specified RebarConstrainedHandle.

For free form rebar will return an empty list.

#### Remarks

Will throw exception if the provided elementId is not a valid constraint target.

#### Parameter `handle`

The RebarConstrainedHandle for which constraint candidates are sought.

#### Parameter `elementId`

The elementId ( host or rebar ) of the element in which the candidates are searched for.

#### Returns

A collection of RebarConstraints

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

elementId is not a valid RebarConstraint target element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The RebarConstraintsManager does not manage a valid Rebar element.

#### Since

2020.1

### `M:Autodesk.Revit.DB.Structure.RebarConstraintsManager.GetConstraintCandidatesForHandle(Autodesk.Revit.DB.Structure.RebarConstrainedHandle)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraintsManager.GetConstraintCandidatesForHandle(Autodesk.Revit.DB.Structure.RebarConstrainedHandle)`

#### Summary

For shape driven rebar returns all possible RebarConstraints that could be used for a specified RebarConstrainedHandle.

For free form rebar will return an empty list.

#### Parameter `handle`

The RebarConstrainedHandle for which constraint candidates are sought.

#### Returns

A collection of RebarConstraints

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The RebarConstraintsManager does not manage a valid Rebar element.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarConstraintsManager.GetCurrentConstraintOnHandle(Autodesk.Revit.DB.Structure.RebarConstrainedHandle)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraintsManager.GetCurrentConstraintOnHandle(Autodesk.Revit.DB.Structure.RebarConstrainedHandle)`

#### Summary

Retrieves the RebarConstraint that acts on the specified RebarConstraintHandle.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

handle is no longer valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The RebarConstraintsManager does not manage a valid Rebar element.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarConstraintsManager.GetAllConstrainedHandles`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraintsManager.GetAllConstrainedHandles`

#### Summary

Retrieves all handles on the Rebar that are constrained to external references.

#### Returns

A collection of RebarConstrainedHandles

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The RebarConstraintsManager does not manage a valid Rebar element.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.RebarConstraintsManager.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraintsManager.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.RebarConstraintsManager.IsRebarConstrainedPlacementEnabled`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraintsManager.IsRebarConstrainedPlacementEnabled`

#### Summary

A static property defining if the 'Rebar Constrained Placement' setting is on or off in current Revit Application Session.

#### Remarks

If user started multiple Revit sessions, and the 'Rebar Constrained Placement' setting might be different in each session.
Revit.ini file stores the latest setting no matter what the Revit session is. The setting will be written to Revit.ini if user set the value.
This property enables/disables constraints between standard style rebars.
This constraint is similar to the standard-to-stirrup constraint in the following way :
Distance to target cannot be edited.
The constraint "snaps" the rebars together in a touching position.
Rebars can be constrained under the following conditions :
Rebars have standard style. (not stirrups)

The segments must be touching. (partially overlapped)

If the segments are perfectly overlapped (i.e segments have the same center line) then the constraint will not take place.

Only one segment per rebar can be constrained.

If one of the segments touches (intersects) more than one segment (or arc), then the constraint will not happen.

The segments being constrained are parallel and the bending and segment planes are parallel.

#### Since

2014

### `T:Autodesk.Revit.DB.Structure.RebarConstraintsManager`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarConstraintsManager`

#### Summary

A class used to obtain information about the constraints (RebarConstraints) acting
on the shape handles (RebarConstrainedHandles) of a Rebar element, and modify the constraints.

#### Remarks

A RebarConstraintsManager is created by calling Rebar.GetRebarConstraintsManager(),
and can only be used to query or change constraints on the rebar element that
created it.

There are two types of constraint manager, depending on the type of Rebar that created it:
Shape Driven constraints and FreeForm constraints

-----ShapeDriven-----

If the Rebar is Shape Driven, Revit uses the following logic to choose constraints for each handle
on a rebar element. First, a search is performed to find all suitable target
planes, including surfaces of the rebar's host, as well as surfaces on other
concrete host elements that are attached to the rebar's host. In the case of
standard style rebar, any host surface occupied by a stirrup will be ignored,
and instead, the handles on the stirrup itself will be treated as candidates
to form a constraint.

Once all the constraint target candidates have been determined, the following
sequence is used to select a constraint target:
If the rebar is a straight standard bar, it will search the list of candidates
for stirrup bends to lock its RebarPlane and Edge handles. If a bend is found within
tolerance distance, then the bar will be snapped and constrained to that bend.

The bar will snap and constrain its handle to any host cover or stirrup handle
that lies within tolerance distance.

If no candidate is found within tolerance, then the bar will choose nearest
host surface target, with or without cover, and create a constant distance constraint
to that surface.

Snapping tolerances are 0.5 * bar diameter for host surface cover constraints and
0.5 * (bar diameter + stirrup bar diameter) for stirrup handle constraints.

The RebarConstraintsManager allows the API developer to obtain the constraint
candidates for each constrained handle on a rebar, and to override the default
target selection logic by setting a particular constraint as preferred. This
can be useful in a number of ways. First, it can be used to snap a handle to a
particular host surface or stirrup rebar handle, or to position a handle at a
precise distance from a host surface. Second, it can force a rebar handle to
constrain itself to a particular target surface, even if other targets are closer
(or will become closer in subsequent updates of the Revit model). For example,
a bar can be constrained to maintain a constant offset distance from a face of
an opening in a slab, even if the opening is placed close to the edge of the slab
and the bar would normally constrain itself to the slab edge. Lastly, the override
can be used to cancel the default standard bar preference for stirrup bar handle
planes, and to allow standard bars to be constrained to host cover surfaces, even
when a stirrup is present.

----- FreeForm -----

If the rebar is FreeForm, then it requires input constraints that will be consumed to
obtain the actual shape of the bar. The calculation method of the constraints passed
to the rebar is custom made by an API application - `T:Autodesk.Revit.DB.Structure.IRebarUpdateServer` .

The RebarConstraintsManager can return all the possible "shape" handles
and can set constraints created only with one of those handles.
There are only active constraints on a FreeForm bar, the current and preferred notions
represent the same thing.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.RebarBendData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.RebarBendData.HookBendRadius`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendData.HookBendRadius`

#### Summary

The radius of the hook fillets in the Rebar shape.

#### Remarks

Inner radius, not centerline

#### Since

2012

### `P:Autodesk.Revit.DB.Structure.RebarBendData.HookOrient1`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendData.HookOrient1`

#### Summary

The orientation of the hook at the end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `P:Autodesk.Revit.DB.Structure.RebarBendData.HookOrient0`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendData.HookOrient0`

#### Summary

The orientation of the hook at the start.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `P:Autodesk.Revit.DB.Structure.RebarBendData.HookAngle1`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendData.HookAngle1`

#### Summary

The angle of the hook at the end.

#### Since

2012

### `P:Autodesk.Revit.DB.Structure.RebarBendData.HookAngle0`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendData.HookAngle0`

#### Summary

The angle of the hook at the start.

#### Since

2012

### `P:Autodesk.Revit.DB.Structure.RebarBendData.HookLength1`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendData.HookLength1`

#### Summary

The extension length of the hook at the end.

#### Since

2012

### `P:Autodesk.Revit.DB.Structure.RebarBendData.HookLength0`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendData.HookLength0`

#### Summary

The extension length of the hook at the start.

#### Since

2012

### `P:Autodesk.Revit.DB.Structure.RebarBendData.BarNominalDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendData.BarNominalDiameter`

#### Summary

Defines the nominal diameter of the bar.

#### Since

2012

### `P:Autodesk.Revit.DB.Structure.RebarBendData.BarModelDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendData.BarModelDiameter`

#### Summary

Defines the model diameter of the bar.

#### Since

2012

### `P:Autodesk.Revit.DB.Structure.RebarBendData.BendRadius`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBendData.BendRadius`

#### Summary

The radius of all fillets, except hook fillets, in the Rebar shape.

#### Remarks

Inner radius, not centerline

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarBendData.#ctor(Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Structure.RebarStyle,Autodesk.Revit.DB.Structure.RebarHookOrientation,Autodesk.Revit.DB.Structure.RebarHookOrientation)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarBendData.#ctor(Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Structure.RebarStyle,Autodesk.Revit.DB.Structure.RebarHookOrientation,Autodesk.Revit.DB.Structure.RebarHookOrientation)`

#### Summary

Constructs a new RebarBendData using the bar type, hook types, style and orientation values.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarBendData.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarBendData.#ctor`

#### Summary

Constructs a new RebarBendData with default settings.

#### Since

2012

### `T:Autodesk.Revit.DB.Structure.RebarBendData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarBendData`

#### Summary

The values in this class provide a summary of information taken from the RebarBarType, RebarHookType, and RebarStyle.

#### Remarks

The purpose of collecting the values in this class is to allow you to
create and analyze an accurate representation of a RebarShape, without creating a Rebar
instance, and without referring to RebarBarType, RebarHookType, and RebarStyle.
If you do have a Rebar instance, its GetBendData() method will produce a RebarBendData
object.

#### Since

2012

### `M:Autodesk.Revit.DB.Structure.RebarBarType.CreateDefaultRebarBarType(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarBarType.CreateDefaultRebarBarType(Autodesk.Revit.DB.Document)`

#### Summary

Creates a new RebarBarType object with a default name.

#### Parameter `ADoc`

The document.

#### Returns

The newly created type id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.RebarBarType.GetReinforcementRoundingManager`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarBarType.GetReinforcementRoundingManager`

#### Summary

Returns an object for managing reinforcement rounding override settings.

#### Returns

The rounding manager.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarBarType.Create(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarBarType.Create(Autodesk.Revit.DB.Document)`

#### Summary

Creates a new RebarBarType object

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Structure.RebarBarType.SetHookOffsetLength(Autodesk.Revit.DB.ElementId,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarBarType.SetHookOffsetLength(Autodesk.Revit.DB.ElementId,System.Double)`

#### Summary

Identifies the hook offset length for a hook type

#### Remarks

AutoCalcHookLengths is ignored when this property is set

#### Parameter `hookId`

id of the hook type

#### Parameter `newLength`

The hook offset length for a hook type

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

the rebar hook type id hookId is not valid
-or-
the hook specified by id hookId doesn't have valid offset length

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Structure.RebarBarType.GetHookOffsetLength(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarBarType.GetHookOffsetLength(Autodesk.Revit.DB.ElementId)`

#### Summary

Identifies the hook offset length for a hook type

#### Remarks

If the AutoCalcHookLengths property is turned off, the default hook offset length will be returned

#### Parameter `hookId`

id of the hook type

#### Returns

The hook offset length for a hook type

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

the rebar hook type id hookId is not valid
-or-
the hook specified by id hookId doesn't have valid offset length
-or-
The element hookId does not exist in the document containing this RebarBarType
-or-
the hook specified by id hookId doesn't have valid default offset length

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The document containing this RebarBarType is in failure mode: an operation has failed,
and Revit requires the user to either cancel the operation
or fix the problem (usually by deleting certain elements).
-or-
The element is a member of a loaded family.
-or-
The element is a member of a group type that is
not being edited.
-or-
hookId is a member of a loaded family.
-or-
hookId is a member of a group type that is
not being edited.

### `M:Autodesk.Revit.DB.Structure.RebarBarType.SetHookTangentLength(Autodesk.Revit.DB.ElementId,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarBarType.SetHookTangentLength(Autodesk.Revit.DB.ElementId,System.Double)`

#### Summary

Identifies the hook tangent length for a hook type

#### Remarks

AutoCalcHookLengths is ignored when this property is set

#### Parameter `hookId`

id of the hook type

#### Parameter `newLength`

The hook tangent length for a hook type

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

the rebar hook type id hookId is not valid

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.RebarBarType.GetHookTangentLength(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarBarType.GetHookTangentLength(Autodesk.Revit.DB.ElementId)`

#### Summary

Identifies the hook tangent length for a hook type

#### Parameter `hookId`

id of the hook type

#### Returns

The hook tangent length for a hook type

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

the rebar hook type id hookId is not valid

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Structure.RebarBarType.SetHookLength(Autodesk.Revit.DB.ElementId,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarBarType.SetHookLength(Autodesk.Revit.DB.ElementId,System.Double)`

#### Summary

Identifies the hook length for a hook type

#### Parameter `hookId`

id of the hook type

#### Parameter `hookLength`

The hook length for a hook type

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

the rebar hook type id hookId is not valid

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Structure.RebarBarType.GetHookLength(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarBarType.GetHookLength(Autodesk.Revit.DB.ElementId)`

#### Summary

Identifies the hook length for a hook type

#### Remarks

If the AutoCalcHookLengths property is turned off, the default hook length will be returned

#### Parameter `hookId`

id of the hook type

#### Returns

The hook length for a hook type

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

the rebar hook type id hookId is not valid

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Structure.RebarBarType.SetAutoCalcHookLengths(Autodesk.Revit.DB.ElementId,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarBarType.SetAutoCalcHookLengths(Autodesk.Revit.DB.ElementId,System.Boolean)`

#### Summary

Identifies if the hook lengths of a hook type are automatically calculated for this bar type

#### Parameter `hookId`

id of the hook type

#### Parameter `autoCalculated`

True if the hook lengths should be automatically calculated, otherwise false
When it is false, default hook length and default hook offset length will be reported

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Structure.RebarBarType.GetAutoCalcHookLengths(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarBarType.GetAutoCalcHookLengths(Autodesk.Revit.DB.ElementId)`

#### Summary

Identifies if the hook lengths of a hook type are automatically calculated for this bar type

#### Parameter `hookId`

id of the hook type

#### Returns

True if the hook lengths are automatically calculated, otherwise false

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Structure.RebarBarType.SetHookPermission(Autodesk.Revit.DB.ElementId,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarBarType.SetHookPermission(Autodesk.Revit.DB.ElementId,System.Boolean)`

#### Summary

Identifies if a hook type is permitted for this bar type

#### Parameter `hookId`

id of the hook type

#### Parameter `permission`

True if the hook type should be permitted for this bar type, otherwise false

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

the rebar hook type id hookId is not valid

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Structure.RebarBarType.GetHookPermission(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarBarType.GetHookPermission(Autodesk.Revit.DB.ElementId)`

#### Summary

Identifies if a hook type is permitted for this bar type

#### Parameter `hookId`

id of the hook type

#### Returns

True if the hook type is permitted for this bar type, otherwise false

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

the rebar hook type id hookId is not valid

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Structure.RebarBarType.SetBarTypeDiameters(Autodesk.Revit.DB.BarTypeDiameterOptions)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarBarType.SetBarTypeDiameters(Autodesk.Revit.DB.BarTypeDiameterOptions)`

#### Summary

Sets all input diameters from diametersOptions in current RebarBarType.

#### Parameter `diametersOptions`

The input diameters are validated as follows :
barModelDiameter and barNominalDiameter are both positive and no more than the smallest value of 1.0 and the input bend diameters.
Each bend diameter is smaller than 99.0 and bigger than barDiameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

the diameters ranges in diametersOptions are not acceptable.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Structure.RebarBarType.BarNominalDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBarType.BarNominalDiameter`

#### Summary

Defines bar nominal diameter of rebar

#### Value

The bar nominal diameter of rebar

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: the bar diameter barNominalDiam is not positive or bigger than the smallest value of 1.0, and current internal values of standard bend diameter,
standard hook bend diameter and stirrup/tie bend diameter

#### Since

2022

### `P:Autodesk.Revit.DB.Structure.RebarBarType.BarModelDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBarType.BarModelDiameter`

#### Summary

Defines bar model diameter of rebar

#### Value

The bar model diameter of rebar

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: the bar diameter barModelDiam is not positive or bigger than the smallest value of 1.0, and current internal values of standard bend diameter,
standard hook bend diameter and stirrup/tie bend diameter

#### Since

2022

### `P:Autodesk.Revit.DB.Structure.RebarBarType.StirrupTieBendDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBarType.StirrupTieBendDiameter`

#### Summary

Defines bar and hook bend diameter for rebar whose style is stirrup/tie

#### Value

The bar and hook bend diameter for rebar whose style is stirrup/tie

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: the bend diameter stirrupTieBendDiam isn't between bar diameter and 99.0

### `P:Autodesk.Revit.DB.Structure.RebarBarType.StandardHookBendDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBarType.StandardHookBendDiameter`

#### Summary

Defines hook bend diameter for rebar whose style is standard

#### Value

The hook bend diameter for rebar whose style is standard

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: the bend diameter standardHookBendDiam isn't between bar diameter and 99.0

### `P:Autodesk.Revit.DB.Structure.RebarBarType.StandardBendDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBarType.StandardBendDiameter`

#### Summary

Defines bar bend diameter for rebar whose style is standard

#### Value

The bar bend diameter for rebar whose style is standard

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: the bend diameter standardBendDiam isn't between bar diameter and 99.0

### `P:Autodesk.Revit.DB.Structure.RebarBarType.DeformationType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBarType.DeformationType`

#### Summary

Defines bar deformation type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

### `P:Autodesk.Revit.DB.Structure.RebarBarType.MaximumBendRadius`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarBarType.MaximumBendRadius`

#### Summary

Defines maximum bend radius of rebar

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for maximumBendRadius is not a number

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: maximumBendRadius must be greater than 0 and no more than 30000.

### `T:Autodesk.Revit.DB.Structure.RebarBarType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarBarType`

#### Summary

A Rebar type object that is used in the generation of Rebar

### `P:Autodesk.Revit.DB.BarTypeDiameterOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.BarTypeDiameterOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.BarTypeDiameterOptions.StirrupTieBendDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.BarTypeDiameterOptions.StirrupTieBendDiameter`

#### Summary

Represents the stirrup/tie bar and hook bend diameter of the RebarBarType.

#### Since

2018.1

### `P:Autodesk.Revit.DB.BarTypeDiameterOptions.StandardHookBendDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.BarTypeDiameterOptions.StandardHookBendDiameter`

#### Summary

Represents the standard hook bend diameter of the RebarBarType.

#### Since

2018.1

### `P:Autodesk.Revit.DB.BarTypeDiameterOptions.StandardBendDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.BarTypeDiameterOptions.StandardBendDiameter`

#### Summary

Represents the standard bar bend diameter of the RebarBarType.

#### Since

2018.1

### `P:Autodesk.Revit.DB.BarTypeDiameterOptions.BarNominalDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.BarTypeDiameterOptions.BarNominalDiameter`

#### Summary

Represents the bar nominal diameter of the RebarBarType.

#### Since

2018.1

### `P:Autodesk.Revit.DB.BarTypeDiameterOptions.BarModelDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.BarTypeDiameterOptions.BarModelDiameter`

#### Summary

Represents the bar model diameter of the RebarBarType.

#### Since

2018.1

### `M:Autodesk.Revit.DB.BarTypeDiameterOptions.#ctor(Autodesk.Revit.DB.Structure.RebarBarType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.BarTypeDiameterOptions.#ctor(Autodesk.Revit.DB.Structure.RebarBarType)`

#### Summary

Constructs a new BarTypeDiameterOptions copying the diameter information from the bar type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018.1

### `M:Autodesk.Revit.DB.BarTypeDiameterOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.BarTypeDiameterOptions.#ctor`

#### Summary

Constructs a new BarTypeDiameterOptions with default settings.

#### Since

2018.1

### `T:Autodesk.Revit.DB.BarTypeDiameterOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.BarTypeDiameterOptions`

#### Summary

This class stores the diameter information from the RebarBarType.

#### Remarks

This class can be used to create a whole new set of diameter values for a RebarBarType.
It can be used when copying the diameter information as a bulk of data from a RebarBarType to another.
The new diameters can be set in the RebarBarType in the following way:
1. Create a BarTypeDiameterOptions object with the new diameters.
2. Set the new diameters in RebarBarType using `!:Autodesk::Revit::DB::Structure::RebarBarType::SetBarTypeDiameters(Autodesk::Revit::DB::BarTypeDiameterOptions ^diametersOpt)` .
The method `!:Autodesk::Revit::DB::Structure::RebarBarType::SetBarTypeDiameters(Autodesk::Revit::DB::BarTypeDiameterOptions ^diametersOpt)`
is responsible for diameters validation.

#### Since

2018.1

### `M:Autodesk.Revit.DB.Structure.Rebar.ResetMovedBarTransform(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.ResetMovedBarTransform(System.Int32)`

#### Summary

Reset the transformation representing the movement of the bar relative to its default position along the distribution path.
The moved bar transform will be set to Identity.

#### Parameter `barPositionIndex`

The bar index.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].

#### Since

2022

### `M:Autodesk.Revit.DB.Structure.Rebar.GetMovedBarTransform(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.GetMovedBarTransform(System.Int32)`

#### Summary

Returns a transform representing the movement of the bar relative to its default position along the distribution path.

#### Parameter `barPositionIndex`

The bar index.

#### Returns

The transform representing the movement of the bar relative to its default position along the distribution path.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].

#### Since

2022

### `M:Autodesk.Revit.DB.Structure.Rebar.GetBarIndexFromReference(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.GetBarIndexFromReference(Autodesk.Revit.DB.Reference)`

#### Summary

Given a reference that represents a part of a bar, this method will return the bar index.

#### Remarks

The method returns an index between 0 and NumberOfBarPositions - 1 if it the given reference represents a part of a bar.
Otherwise will return -1.

#### Parameter `barReference`

The Reference of the Rebar element.

#### Returns

The bar index the reference refers to.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.Structure.Rebar.MoveBarInSet(System.Int32,Autodesk.Revit.DB.Transform)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.MoveBarInSet(System.Int32,Autodesk.Revit.DB.Transform)`

#### Summary

This method applies the transformation matrix to the rebar bar at the desired position in the rebar set.
If the bar was already moved, the method will concatenate the transformation matrix with the existing movement.

#### Parameter `barPositionIndex`

The bar index of the rebar to apply the transformation.

#### Parameter `moveTransform`

The transformation matrix to apply to the specified rebar bar.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].

#### Since

2022

### `M:Autodesk.Revit.DB.Structure.Rebar.GetFreeFormAccessor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.GetFreeFormAccessor`

#### Summary

Returns an interface providing access to free-form properties and methods for this Rebar element.

#### Returns

The interface providing access to free-form properties and methods for this Rebar element.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This method applies only to free form rebar.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.Rebar.GetShapeDrivenAccessor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.GetShapeDrivenAccessor`

#### Summary

Returns an interface providing access to shape-driven properties and methods for this Rebar element.

#### Returns

The interface providing access to shape-driven properties and methods for this Rebar element.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This method applies only to shape driven rebar.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.Rebar.IsRebarShapeDriven`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.IsRebarShapeDriven`

#### Summary

Returns true if the rebar is shape driven and false if free form.

#### Returns

Returns true if the rebar is shape driven and false if free form.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.Rebar.IsRebarFreeForm`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.IsRebarFreeForm`

#### Summary

Returns true if the rebar is free form and false if shape driven.

#### Returns

Returns true if the rebar is free form and false if shape driven.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.Rebar.GetCouplerId(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.GetCouplerId(System.Int32)`

#### Summary

Get the id of the Rebar Coupler that is applied to the rebar at the specified end.

#### Parameter `end`

0 for the start Rebar Coupler, 1 for the end Rebar Coupler.

#### Returns

The id of a Rebar Coupler, or invalidElementId if the rebar has
no Rebar Coupler at the specified end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

end must be 0 or 1.

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.Rebar.CanBeMatchedWithMultipleShapes`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.CanBeMatchedWithMultipleShapes`

#### Summary

Checks if this Rebar can be matched with multiple Rebar Shapes.

#### Remarks

A Free Form Rebar that has Workshop Instructions set to Bent is considered that can be matched with multiple shapes.

A Free Form Rebar that has Workshop Instructions set to Straight or a Shape Driven Rebar is considered that can be matched with only one shape.

#### Returns

Returns true if this Rebar can be matched with multiple Rebar Shapes, false otherwise.

#### Since

2019

### `M:Autodesk.Revit.DB.Structure.Rebar.GetAllRebarShapeIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.GetAllRebarShapeIds`

#### Summary

Gets the ids of the RebarShapes elements that defines the shapes of the rebar.

#### Remarks

If multiple bars in the set has the same shape id, this id will be reported only one in the resulted array.

#### Returns

Returns the ids of the RebarShapes elements that defines the shapes of the rebar.

#### Since

2019

### `M:Autodesk.Revit.DB.Structure.Rebar.GetOverridableHookParameters(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId}@,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId}@,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId}@,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId}@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.GetOverridableHookParameters(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId}@,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId}@,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId}@,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId}@)`

#### Summary

Outputs the formula parameter ids defined in the RebarShape family which are associated with hook length and hook tangent length parameters.

#### Remarks

Will throw an exception if the hook length override is not enabled.

#### Parameter `startHookLengthPrameters`

The formula parameter ids defined in the RebarShape family which are associated with start hook length parameters.

#### Parameter `startHookTangentLengthParameters`

The formula parameter ids defined in the RebarShape family which are associated with start hook tangent length parameters.

#### Parameter `endHookLengthParameters`

The formula parameter ids defined in the RebarShape family which are associated with end hook length parameters.

#### Parameter `endHookTangentLengthParameters`

The formula parameter ids defined in the RebarShape family which are associated with end hook tangent length parameters.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The ability to override hook lengths is not enabled for this rebar instance. Use enableHookLengthOverride(true) to enable it.

#### Since

2021

### `M:Autodesk.Revit.DB.Structure.Rebar.IsHookLengthOverrideEnabled`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.IsHookLengthOverrideEnabled`

#### Summary

Returns True if the ability to override hook lengths is enabled for this rebar instance, False otherwise.

#### Since

2021

### `M:Autodesk.Revit.DB.Structure.Rebar.EnableHookLengthOverride(System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.EnableHookLengthOverride(System.Boolean)`

#### Summary

Enables or disables the ability to override hook lengths for this rebar instance.

#### Parameter `enable`

True to enable, False to disable.

#### Since

2021

### `M:Autodesk.Revit.DB.Structure.Rebar.SetHookRotationAngle(System.Double,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.SetHookRotationAngle(System.Double,System.Int32)`

#### Summary

Sets the out of plane hook rotation angle at the specified end.

#### Parameter `hookRotationAngle`

The out of plane hook rotation angle at the specified end.

#### Parameter `iEnd`

0 for the start , 1 for the end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

iEnd must be 0 or 1.

#### Since

2021

### `M:Autodesk.Revit.DB.Structure.Rebar.GetHookRotationAngle(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.GetHookRotationAngle(System.Int32)`

#### Summary

Gets the out of plane hook rotation angle at the specified end.

#### Parameter `iEnd`

0 for the start , 1 for the end.

#### Returns

Returns the out of plane hook rotation angle at the specified end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

iEnd must be 0 or 1.

#### Since

2021

### `M:Autodesk.Revit.DB.Structure.Rebar.SetHookOrientation(System.Int32,Autodesk.Revit.DB.Structure.RebarHookOrientation)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.SetHookOrientation(System.Int32,Autodesk.Revit.DB.Structure.RebarHookOrientation)`

#### Summary

Defines the orientation of the hook plane at the start or at the end of the rebar with respect to the orientation of the first or the last curve and the plane normal.

#### Remarks

If RebarShapeDefinesHooks property of ReinforcementSettings is true (non-European shapes), setHookOrientation method does nothing.

#### Parameter `iEnd`

0 for the start hook, 1 for the end hook.

#### Parameter `hookOrientation`

Only two values are permitted:
Value = Right: The hook is on your right as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."
Value = Left: The hook is on your left as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

iEnd must be 0 or 1.
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.Rebar.GetHookOrientation(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.GetHookOrientation(System.Int32)`

#### Summary

Returns the orientation of the hook plane at the start or at the end of the rebar with respect to the orientation of the first or the last curve and the plane normal.

#### Parameter `iEnd`

0 for the start hook, 1 for the end hook.

#### Returns

Value = Right: The hook is on your right as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."
Value = Left: The hook is on your left as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

iEnd must be 0 or 1.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.Rebar.CanSuppressFirstOrLastBar(Autodesk.Revit.DB.View,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.CanSuppressFirstOrLastBar(Autodesk.Revit.DB.View,System.Int32)`

#### Summary

Checks if the first or last bar in rebar set can be hidden in the given view.

#### Parameter `dBView`

The view in which presentation mode will be applied.

#### Parameter `end`

0 for the first bar in rebar set, 1 for the last bar.

#### Returns

True the first or last bar in rebar set can be hidden for this view, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.Rebar.CanApplyPresentationMode(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.CanApplyPresentationMode(Autodesk.Revit.DB.View)`

#### Summary

Checks if a presentation mode can be applied for this rebar in the given view.

#### Parameter `dBView`

The view in which presentation mode will be applied.

#### Returns

True if presentation mode can be applied for this view, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.Rebar.ConstraintsCanBeEdited`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.ConstraintsCanBeEdited`

#### Summary

For ShapeDriven Rebar:
returns true, if the Rebar element's external constraints are available for editing using the
RebarConstraintsManager class. It will return false if Rebar is in Group

For FreeForm rebar:
constraints can be edited if there is a valid external server Guid assigned to that Rebar

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.Rebar.CanUseHookType(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.CanUseHookType(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks if the specified RebarHookType id is of a valid RebarHookType for the Rebar's RebarBarType

#### Remarks

Also, checks that the Style of the Hook matches that of the Rebar's RebarShape

#### Parameter `proposedHookId`

The Id of the RebarHookType

#### Returns

Returns true if the id is of a valid RebarHookType for the Rebar element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.Rebar.HookAngleMatchesRebarShapeDefinition(System.Int32,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.HookAngleMatchesRebarShapeDefinition(System.Int32,Autodesk.Revit.DB.ElementId)`

#### Summary

Checks that the hook angle of the specified RebarHookType matches the hook angle used in the Rebar's RebarShape at the specified end of the bar.

#### Remarks

Also checks that the specified id is a valid RebarHookType.
If RebarShapeDefinesHooks property of ReinforcementSettings is false (European shapes), every valid hook angle matches RebarShape definition.
If RebarShapeDefinesHooks property of ReinforcementSettings is true (non-European shapes), hook angle matches RebarShape definition if it is null or equal RebarShape default hook angle.

#### Parameter `iEnd`

0 for the start hook, 1 for the end hook.

#### Parameter `proposedHookId`

The Id of the RebarHookType

#### Returns

Returns true if the hook angle of the RebarHookType matches the angle used in the RebarShape at the specified end of the bar.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

iEnd must be 0 or 1.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.Rebar.ContainsValidArcRadiiForStyleAndBarType(System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.Structure.RebarStyle,Autodesk.Revit.DB.Structure.RebarBarType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.ContainsValidArcRadiiForStyleAndBarType(System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.Structure.RebarStyle,Autodesk.Revit.DB.Structure.RebarBarType)`

#### Summary

Checks that all arcs in the chain of curves have radii that are not less than minimum bend radius for bar type and style

#### Parameter `curves`

An array of curves intended to define the shape of the rebar curves.
Bends and hooks should not be included in the array of curves.

#### Parameter `style`

The usage of the bar, "standard" or "stirrup/tie".

#### Parameter `barType`

A RebarBarType element that defines bar diameter, bend radius and material of the rebar.

#### Returns

Returns true if all arc bend radii are not less than minimum bend radius for bar type and style

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.Rebar.GetParameterValueAtIndex(Autodesk.Revit.DB.ElementId,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.GetParameterValueAtIndex(Autodesk.Revit.DB.ElementId,System.Int32)`

#### Summary

Get the parameter value for a bar at the specified index.
The parameter Id.
The bar index in the rebar distribution. Accepts only values between 0 and NumberOfBarPositions-1.
The ParameterValue for given parameterId and barPositionIndex.
Throws exception if barPositionIndex is outside boundaries.

#### Remarks

If the DistributionType is Uniform then the returned ParameterValue is the same no matter the index.
If the DistributionType is VaryingLength then the returned ParameterValue is evaluated at the given index.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.Rebar.SetBarIncluded(System.Boolean,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.SetBarIncluded(System.Boolean,System.Int32)`

#### Summary

Sets if the bar at the desired index is included or not.

#### Parameter `include`

True to include the bar, false to exclude the bar.

#### Parameter `barPositionIndex`

The bar index.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].

#### Since

2022

### `M:Autodesk.Revit.DB.Structure.Rebar.DoesBarExistAtPosition(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.DoesBarExistAtPosition(System.Int32)`

#### Summary

Checks whether a bar is included at the specified position.

#### Parameter `barPosition`

A bar position index between 0 and NumberOfBarPositions-1.

#### Returns

Returns true if the bar at the specified position is included, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPosition is not in the range [ 0, NumberOfBarPositions-1 ].

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.Rebar.GetShapeId`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.GetShapeId`

#### Summary

Returns the id of the RebarShape element that defines the shape of the rebar.

#### Remarks

A Free Form Rebar that has Workshop Instructions set to Bent is considered to have multiple shapes and this method will throw exception.

A Free Form Rebar that has Workshop Instructions set to Straight or a Shape Driven is considered to have only one shape and this method will return the id of that shape.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This Rebar is matched with multiple shapes.

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.Rebar.ClearPresentationMode(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.ClearPresentationMode(Autodesk.Revit.DB.View)`

#### Summary

Sets the presentation mode for this rebar set to the default (either for a single view, or for all views).

#### Parameter `dBView`

The view where the presentation mode will be cleared. NULL for all views

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This rebar element represents a single bar (the layout rule is Single).

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.Rebar.FindMatchingPredefinedPresentationMode(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.FindMatchingPredefinedPresentationMode(Autodesk.Revit.DB.View)`

#### Summary

Determines if there is a matching RebarPresentationMode for the current set of selected hidden and unhidden bars assigned to the given view.

#### Remarks

If the presentation mode is not PresentationMode.Select for the view, this function returns the current mode.

#### Parameter `dBView`

The view.

#### Returns

The presentation mode that matches the current set of selected hidden and unhidden bars.
If there is no better match, this returns RebarPresentationMode.Select.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.Rebar.GetPresentationMode(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.GetPresentationMode(Autodesk.Revit.DB.View)`

#### Summary

Gets the presentation mode for this rebar set when displayed in the given view.

#### Parameter `dBView`

The view.

#### Returns

The presentation mode.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.Rebar.SetPresentationMode(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Structure.RebarPresentationMode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.SetPresentationMode(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Structure.RebarPresentationMode)`

#### Summary

Sets the presentation mode for this rebar set when displayed in the given view.

#### Parameter `dBView`

The view.

#### Parameter `presentationMode`

The presentation mode.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This rebar cannot have a presentation mode applied for dBView, as the view is not valid for rebar presentation,
or the orientation of the view matches the normal direction of the rebar element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This rebar element represents a single bar (the layout rule is Single).

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.Rebar.IsBarHidden(Autodesk.Revit.DB.View,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.IsBarHidden(Autodesk.Revit.DB.View,System.Int32)`

#### Summary

Identifies if a given bar in this rebar set is hidden in this view.

#### Parameter `view`

The view.

#### Parameter `barIndex`

The index of the bar from this rebar set.

#### Returns

True if the bar is hidden in this view, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barIndex is not in the range [ 0, NumberOfBarPositions-1 ].

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.Rebar.SetBarHiddenStatus(Autodesk.Revit.DB.View,System.Int32,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.SetBarHiddenStatus(Autodesk.Revit.DB.View,System.Int32,System.Boolean)`

#### Summary

Sets the bar in this rebar set to be hidden or unhidden in the given view.

#### Remarks

Individual bars of a rebar set can be hidden in a view only
if the presentation mode is RebarPresentationMode.Select.
If that is not the presentation mode assigned for this set in the view,
this method will also change it.

#### Parameter `view`

The view.

#### Parameter `barIndex`

The index of the bar from this set.

#### Parameter `hide`

True to hide this bar in the view, false to unhide the bar.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This rebar cannot have a presentation mode applied for view, as the view is not valid for rebar presentation,
or the orientation of the view matches the normal direction of the rebar element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barIndex is not in the range [ 0, NumberOfBarPositions-1 ].

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This rebar element represents a single bar (the layout rule is Single).

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.Rebar.HasPresentationOverrides(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.HasPresentationOverrides(Autodesk.Revit.DB.View)`

#### Summary

Identifies if this Rebar has overridden default presentation settings for the given view.

#### Remarks

Default presentation settings can be overriden using `M:Autodesk.Revit.DB.Structure.Rebar.SetBarHiddenStatus(Autodesk.Revit.DB.View,System.Int32,System.Boolean)` , `M:Autodesk.Revit.DB.Structure.Rebar.SetPresentationMode(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Structure.RebarPresentationMode)` methods

#### Parameter `dBView`

The view.

#### Returns

True if this Rebar has overriden default presentation settings, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.Rebar.IsRebarInSection(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.IsRebarInSection(Autodesk.Revit.DB.View)`

#### Summary

Identifies if this Rebar is cut by the view plane of the given view.

#### Remarks

This method applies only for elevations and sections. For any other view types will return false.

#### Parameter `dBView`

The view.

#### Returns

True if this Rebar is cut by the view plane, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.Rebar.SetEndTreatmentTypeId(System.Int32,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.SetEndTreatmentTypeId(System.Int32,Autodesk.Revit.DB.ElementId)`

#### Summary

Sets the id of the EndTreatmentType to be applied to the rebar.
This can be done if and only if the end of the bar on which the end treatment is applied has no RebarCoupler on it, otherwise will throw an exception.
If a RebarHookType is present at the rebar end, it will automatically set to invalidElementId.

#### Parameter `end`

0 for the start end treatment, 1 for the end end treatment.

#### Parameter `endTreatmentTypeId`

The id of a EndTreatmentType element, or invalidElementId if
the rebar should have no end treatment at the specified end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

the parameter endTreatmentTypeId is not an EndTreatmentType element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

end must be 0 or 1.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

the Rebar end end has a RebarCoupler on it.

#### Since

2021

### `M:Autodesk.Revit.DB.Structure.Rebar.GetEndTreatmentTypeId(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.GetEndTreatmentTypeId(System.Int32)`

#### Summary

Get the id of the EndTreatmentType to be applied to the rebar.

#### Parameter `end`

0 for the start end treatment, 1 for the end end treatment.

#### Returns

The id of a EndTreatmentType, or invalidElementId if the rebar has
no end treatment at the specified end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

end must be 0 or 1.

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.Rebar.SetHookTypeId(System.Int32,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.SetHookTypeId(System.Int32,Autodesk.Revit.DB.ElementId)`

#### Summary

Set the id of the RebarHookType to be applied to the rebar.
If an EndTreatmentType is present at the rebar end, it will automatically set to invalidElementId.

#### Parameter `end`

0 for the start hook, 1 for the end hook.

#### Parameter `hookTypeId`

The id of a RebarHookType element, or invalidElementId if
the rebar should have no hook at the specified end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

the rebar hook type id hookTypeId is not valid

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

end must be 0 or 1.

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.Rebar.GetHookTypeId(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.GetHookTypeId(System.Int32)`

#### Summary

Get the id of the RebarHookType to be applied to the rebar.

#### Parameter `end`

0 for the start hook, 1 for the end hook.

#### Returns

The id of a RebarHookType, or invalidElementId if the rebar has
no hook at the specified end.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

end must be 0 or 1.

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.Rebar.GetBendData`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.GetBendData`

#### Summary

Gets the RebarBendData, containing bar and hook information, of the instance.

#### Remarks

Internally, the bend data is used by many RebarShape methods to generate shape geometry.

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.Rebar.SetUnobscuredInView(Autodesk.Revit.DB.View,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.SetUnobscuredInView(Autodesk.Revit.DB.View,System.Boolean)`

#### Summary

Sets this rebar element to be shown unobscured in a view.

#### Parameter `view`

The view element

#### Parameter `unobscured`

True if rebar is shown unobscured, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This rebar element doesn't have valid visibility data.

#### Since

2011

### `M:Autodesk.Revit.DB.Structure.Rebar.IsUnobscuredInView(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.IsUnobscuredInView(Autodesk.Revit.DB.View)`

#### Summary

Checks if this rebar element is shown unobscured in a view.

#### Parameter `view`

The view element

#### Returns

True if rebar is shown unobscured, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This rebar element doesn't have valid visibility data.

#### Since

2011

### `M:Autodesk.Revit.DB.Structure.Rebar.SetHostId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.SetHostId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

The element that contains the rebar.

#### Parameter `doc`

The document containing both this element and the host element.

#### Parameter `hostId`

The element that the rebar object belongs to, such as a structural
wall, floor, foundation, beam, brace or column. The rebar does not need
to be strictly inside the host, but it must be assigned to one host
element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

hostId is not a legal Rebar host (see the RebarHostData class).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.Rebar.GetHostId`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.GetHostId`

#### Summary

The element that contains the rebar.

#### Returns

The element that the rebar object belongs to, such as a structural
wall, floor, foundation, beam, brace or column.

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.Rebar.GetFullGeometryForView(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.GetFullGeometryForView(Autodesk.Revit.DB.View)`

#### Summary

Generates full geometry for the Rebar for a specific view.

#### Remarks

The result of this method differs from Element.Geometry in that Element.Geometry will return
the rebar geometry cut by the view extents (such as the section box). In this method the entire Rebar geometry
is returned for the given view, before cutting.

#### Parameter `view`

The view in which the geometry is generated.

#### Returns

The generated geometry of the Rebar before cutting is applied.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.Rebar.GetReinforcementRoundingManager`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.GetReinforcementRoundingManager`

#### Summary

Returns an object for managing reinforcement rounding override settings.

#### Returns

The rounding manager.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.Rebar.GetRebarConstraintsManager`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.GetRebarConstraintsManager`

#### Summary

Returns an object for managing the external constraints on the Rebar element

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The Rebar element does not have external constraints that can be edited.

#### Since

2014

### `M:Autodesk.Revit.DB.Structure.Rebar.GetTransformedCenterlineCurves(System.Boolean,System.Boolean,System.Boolean,Autodesk.Revit.DB.Structure.MultiplanarOption,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.GetTransformedCenterlineCurves(System.Boolean,System.Boolean,System.Boolean,Autodesk.Revit.DB.Structure.MultiplanarOption,System.Int32)`

#### Summary

A chain of curves representing the centerline of the rebar.

#### Remarks

This method will return the centerline curves for bar at barPositionIndex even if this bar isn't included.
The curves are in the final position. The BarPositionTransform (representing the relative position of any individual bar in the set - a translation along the distribution path)
and MovedBarTransform (representing the movement of the bar relative to its default position along the distribution path) will be applied to the returned curves.

#### Parameter `adjustForSelfIntersection`

If the curves overlap, as in a planar stirrup, this parameter controls
whether they should be adjusted to avoid intersection (as in fine views),
or kept in a single plane for simplicity (as in coarse views).

#### Parameter `suppressHooks`

Identifies if the chain will include hooks curves.

#### Parameter `suppressBendRadius`

Identifies if the connected chain will include unfilleted curves.

#### Parameter `multiplanarOption`

If the Rebar is a multi-planar shape, this parameter controls whether to generate only
the curves in the primary plane (IncludeOnlyPlanarCurves), or to generate all curves,
(IncludeAllMultiplanarCurves) including the out-of-plane connector segments as well as
multi-planar copies of the primary plane curves.
This argument is ignored for planar shapes.

#### Parameter `barPositionIndex`

The bar index.

#### Returns

The centerline curves or empty array if the curves cannot be computed because
the parameters values are inconsistent
with the constraints of the RebarShape definition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Since

2022

### `M:Autodesk.Revit.DB.Structure.Rebar.GetCenterlineCurves(System.Boolean,System.Boolean,System.Boolean,Autodesk.Revit.DB.Structure.MultiplanarOption,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.GetCenterlineCurves(System.Boolean,System.Boolean,System.Boolean,Autodesk.Revit.DB.Structure.MultiplanarOption,System.Int32)`

#### Summary

A chain of curves representing the centerline of the rebar.

#### Remarks

This method will return the centerline curves for bar at barPositionIndex even if this bar isn't included.

#### Parameter `adjustForSelfIntersection`

If the curves overlap, as in a planar stirrup, this parameter controls
whether they should be adjusted to avoid intersection (as in fine views),
or kept in a single plane for simplicity (as in coarse views).

#### Parameter `suppressHooks`

Identifies if the chain will include hooks curves.

#### Parameter `suppressBendRadius`

Identifies if the connected chain will include unfilleted curves.

#### Parameter `multiplanarOption`

If the Rebar is a multi-planar shape, this parameter controls whether to generate only
the curves in the primary plane (IncludeOnlyPlanarCurves), or to generate all curves,
(IncludeAllMultiplanarCurves) including the out-of-plane connector segments as well as
multi-planar copies of the primary plane curves.
This argument is ignored for planar shapes.

#### Parameter `barPositionIndex`

An index between 0 and (NumberOfBarPositions-1).
Use the barPositionIndex to obtain all the curves at a specific index in the distribution.
You can use GetNumberOfBarPositions() to verify if a specific rebar has more than one bar positions.
Use GetDistributionType() to probe if the bars in a specific rebar have a varying shape. If so, you can retrieve the centerline curve geometry of that particular bar, by passing the appropriate index.
When the distribution type of a rebar set is uniform, the form of the bars does not vary from one index to another.

#### Returns

The centerline curves or empty array if the curves cannot be computed because
the parameters values are inconsistent
with the constraints of the RebarShape definition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

barPositionIndex is not in the range [ 0, NumberOfBarPositions-1 ].
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.Rebar.CreateFromCurvesAndShape(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.RebarShape,Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.XYZ,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.Structure.RebarHookOrientation,Autodesk.Revit.DB.Structure.RebarHookOrientation,System.Double,System.Double,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.CreateFromCurvesAndShape(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.RebarShape,Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.XYZ,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.Structure.RebarHookOrientation,Autodesk.Revit.DB.Structure.RebarHookOrientation,System.Double,System.Double,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new instance of a shape driven Rebar element within the project.
The instance will have the default shape parameters from the RebarShape.
If the RebarShapeDefinesHooks flag in ReinforcementSettings has been set to true,
then curves, hook types and hook rotation angles should match the rebar shape definition.
Otherwise, the hooks can be different than the defaults specified in the RebarShape.
If the RebarShapeDefinesEndTreatment flag in ReinforcementSettings has been set to true,
then curves and end treatment types should match the rebar shape definition.
Otherwise, the end treatment types can be different than the defaults specified in the RebarShape.

#### Parameter `doc`

A document.

#### Parameter `rebarShape`

A RebarShape element that defines the shape of the rebar.
A RebarShape element that matches curves, hooks, hook rotation angles and End Treatment.
A RebarShape element that provides the RebarStyle of the rebar.

#### Parameter `barType`

A RebarBarType element that defines bar diameter, bend radius and material of the rebar.

#### Parameter `startHook`

A RebarHookType element that defines the hook for the start of the bar.
If this parameter is `null` , it means to create a rebar with no hook.

#### Parameter `endHook`

A RebarHookType element that defines the hook for the end of the bar.
If this parameter is `null` , it means to create a rebar with no hook.

#### Parameter `host`

The element to which the rebar belongs. The element must support rebar hosting;
`!:Autodesk::Revit::DB::Structure::RebarHostData` .

#### Parameter `norm`

The normal to the plane that the rebar curves lie on.

#### Parameter `curves`

An array of curves that define the shape of the rebar curves.
They must belong to the plane defined by the normal and origin.
Bends and hooks should not be included in the array of curves.

#### Parameter `startHookOrient`

Defines the orientation of the hook plane at the start of the rebar with respect to the orientation of the first curve and the plane normal.
Only two values are permitted:
Value = Right: The hook is on your right as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."
Value = Left: The hook is on your left as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."

#### Parameter `endHookOrient`

Defines the orientation of the hook plane at the end of the rebar with respect to the orientation of the last curve and the plane normal.
Only two values are permitted:
Value = Right: The hook is on your right as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."
Value = Left: The hook is on your left as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."

#### Parameter `hookRotationAngleAtStart`

The out of plane hook rotation angle at the start of the bar.

#### Parameter `hookRotationAngleAtEnd`

The out of plane hook rotation angle at the end of the bar.

#### Parameter `endTreatmentTypeIdAtStart`

The end treatment type id at the start of the bar.

#### Parameter `endTreatmentTypeIdAtEnd`

The end treatment type id at the end of the bar.

#### Returns

The newly created Rebar instance, or `null` if the operation fails.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element host was not found in the given document.
-or-
host is not a valid rebar host.
-or-
The input curves is empty.
-or-
The input curves contains at least one curve which is not a bound Line or bound Arc
and is not supported for this operation.
-or-
curves do not form a valid CurveLoop.
-or-
The input curves contains at least one helical curve and is not supported for this operation.
-or-
the parameter endTreatmentTypeIdAtStart is not an EndTreatmentType element.
-or-
the parameter endTreatmentTypeIdAtEnd is not an EndTreatmentType element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

norm has zero length.
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

curves contains non-fillet arcs with radii that are less than the
minimum bend radius for the RebarBarType and RebarShape style.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

rebarShape does not match curves.

#### Since

2021

### `M:Autodesk.Revit.DB.Structure.Rebar.CreateFromCurvesAndShape(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.RebarShape,Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.XYZ,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.Structure.RebarHookOrientation,Autodesk.Revit.DB.Structure.RebarHookOrientation)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.CreateFromCurvesAndShape(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.RebarShape,Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.XYZ,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.Structure.RebarHookOrientation,Autodesk.Revit.DB.Structure.RebarHookOrientation)`

#### Summary

Creates a new instance of a shape driven Rebar element within the project.
The instance will have the default shape parameters from the RebarShape.
If the RebarShapeDefinesHooks flag in ReinforcementSettings has been set to true,
then both the curves and hooks must match the RebarShape definition.
Otherwise, the hooks can be different than the defaults specified in the RebarShape

#### Parameter `doc`

A document.

#### Parameter `rebarShape`

A RebarShape element that defines the shape of the rebar.
A RebarShape element matches curves and hooks.
A RebarShape element provides RebarStyle of the rebar.

#### Parameter `barType`

A RebarBarType element that defines bar diameter, bend radius and material of the rebar.

#### Parameter `startHook`

A RebarHookType element that defines the hook for the start of the bar.
If this parameter is `null` , it means to create a rebar with no hook.

#### Parameter `endHook`

A RebarHookType element that defines the hook for the end of the bar.
If this parameter is `null` , it means to create a rebar with no hook.

#### Parameter `host`

The element to which the rebar belongs. The element must support rebar hosting;
`!:Autodesk::Revit::DB::Structure::RebarHostData` .

#### Parameter `norm`

The normal to the plane that the rebar curves lie on.

#### Parameter `curves`

An array of curves that define the shape of the rebar curves.
They must belong to the plane defined by the normal and origin.
Bends and hooks should not be included in the array of curves.

#### Parameter `startHookOrient`

Defines the orientation of the hook plane at the start of the rebar with respect to the orientation of the first curve and the plane normal.
Only two values are permitted:
Value = Right: The hook is on your right as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."
Value = Left: The hook is on your left as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."

#### Parameter `endHookOrient`

Defines the orientation of the hook plane at the end of the rebar with respect to the orientation of the last curve and the plane normal.
Only two values are permitted:
Value = Right: The hook is on your right as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."
Value = Left: The hook is on your left as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."

#### Returns

The newly created Rebar instance, or `null` if the operation fails.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element host was not found in the given document.
-or-
host is not a valid rebar host.
-or-
The input curves is empty.
-or-
The input curves contains at least one curve which is not a bound Line or bound Arc
and is not supported for this operation.
-or-
curves do not form a valid CurveLoop.
-or-
The input curves contains at least one helical curve and is not supported for this operation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

norm has zero length.
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

curves contains non-fillet arcs with radii that are less than the
minimum bend radius for the RebarBarType and RebarShape style.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

rebarShape does not match curves.

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.Rebar.RebarShapeMatchesCurvesHooksAndEndTreatment(Autodesk.Revit.DB.Structure.RebarShape,Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.XYZ,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Structure.RebarHookOrientation,Autodesk.Revit.DB.Structure.RebarHookOrientation,System.Double,System.Double,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.RebarShapeMatchesCurvesHooksAndEndTreatment(Autodesk.Revit.DB.Structure.RebarShape,Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.XYZ,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Structure.RebarHookOrientation,Autodesk.Revit.DB.Structure.RebarHookOrientation,System.Double,System.Double,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Checks if rebarShape matches curves, hooks and end treatment.
If the RebarShapeDefinesHooks flag in ReinforcementSettings has been set to false, then this method will ignore the hook information.
If the RebarShapeDefinesEndTreatment flag in ReinforcementSettings has been set to false, then this method will ignore the end treatment information.

#### Parameter `rebarShape`

A RebarShape element that defines the shape of the rebar.

#### Parameter `barType`

A RebarBarType element that defines bar diameter, bend radius and material of the rebar.

#### Parameter `norm`

The normal to the plane that the rebar curves lie on.

#### Parameter `curves`

An array of curves that define the shape of the rebar curves.
They must belong to the plane defined by the normal and origin.
Bends and hooks should not be included in the array of curves.

#### Parameter `startHook`

A RebarHookType element that defines the hook for the start of the bar.

#### Parameter `endHook`

A RebarHookType element that defines the hook for the end of the bar.

#### Parameter `startHookOrient`

Defines the orientation of the hook plane at the start of the rebar with respect to the orientation of the first curve and the plane normal.
Only two values are permitted:
Value = Right: The hook is on your right as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."
Value = Left: The hook is on your left as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."

#### Parameter `endHookOrient`

Defines the orientation of the hook plane at the end of the rebar with respect to the orientation of the last curve and the plane normal.
Only two values are permitted:
Value = Right: The hook is on your right as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."
Value = Left: The hook is on your left as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."

#### Parameter `hookRotationAngleAtStart`

The out of plane hook rotation angle at the start of the bar.

#### Parameter `hookRotationAngleAtEnd`

The out of plane hook rotation angle at the end of the bar.

#### Parameter `endTreatmentTypeIdAtStart`

The end treatment type id at the start of the bar.

#### Parameter `endTreatmentTypeIdAtEnd`

The end treatment type id at the end of the bar.

#### Returns

True if rebarShape matches curves and hooks.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input curves is empty.
-or-
The input curves contains at least one curve which is not a bound Line or bound Arc
and is not supported for this operation.
-or-
curves do not form a valid CurveLoop.
-or-
The input curves contains at least one helical curve and is not supported for this operation.
-or-
the parameter endTreatmentTypeIdAtStart is not an EndTreatmentType element.
-or-
the parameter endTreatmentTypeIdAtEnd is not an EndTreatmentType element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

norm has zero length.
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Since

2021

### `M:Autodesk.Revit.DB.Structure.Rebar.RebarShapeMatchesCurvesAndHooks(Autodesk.Revit.DB.Structure.RebarShape,Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.XYZ,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Structure.RebarHookOrientation,Autodesk.Revit.DB.Structure.RebarHookOrientation)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.RebarShapeMatchesCurvesAndHooks(Autodesk.Revit.DB.Structure.RebarShape,Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.XYZ,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Structure.RebarHookOrientation,Autodesk.Revit.DB.Structure.RebarHookOrientation)`

#### Summary

Checks if rebarShape matches curves and hooks.
If the RebarShapeDefinesHooks flag in ReinforcementSettings has been set to false, then this method will ignore the hook information.

#### Parameter `rebarShape`

A RebarShape element that defines the shape of the rebar.

#### Parameter `barType`

A RebarBarType element that defines bar diameter, bend radius and material of the rebar.

#### Parameter `norm`

The normal to the plane that the rebar curves lie on.

#### Parameter `curves`

An array of curves that define the shape of the rebar curves.
They must belong to the plane defined by the normal and origin.
Bends and hooks should not be included in the array of curves.

#### Parameter `startHook`

A RebarHookType element that defines the hook for the start of the bar.

#### Parameter `endHook`

A RebarHookType element that defines the hook for the end of the bar.

#### Parameter `startHookOrient`

Defines the orientation of the hook plane at the start of the rebar with respect to the orientation of the first curve and the plane normal.
Only two values are permitted:
Value = Right: The hook is on your right as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."
Value = Left: The hook is on your left as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."

#### Parameter `endHookOrient`

Defines the orientation of the hook plane at the end of the rebar with respect to the orientation of the last curve and the plane normal.
Only two values are permitted:
Value = Right: The hook is on your right as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."
Value = Left: The hook is on your left as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."

#### Returns

True if rebarShape matches curves and hooks.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input curves is empty.
-or-
The input curves contains at least one curve which is not a bound Line or bound Arc
and is not supported for this operation.
-or-
curves do not form a valid CurveLoop.
-or-
The input curves contains at least one helical curve and is not supported for this operation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

norm has zero length.
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `M:Autodesk.Revit.DB.Structure.Rebar.CreateFromRebarShape(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.RebarShape,Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.CreateFromRebarShape(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.RebarShape,Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a new shape driven Rebar, as an instance of a RebarShape.
The instance will have the default shape parameters from the RebarShape,
and its location is based on the bounding box of the shape in the shape definition.
Hooks are removed from the shape before computing its bounding box.
If appropriate hooks can be found in the document, they will be assigned arbitrarily.

#### Parameter `doc`

A document.

#### Parameter `rebarShape`

A RebarShape element that defines the shape of the rebar.

#### Parameter `barType`

A RebarBarType element that defines bar diameter, bend radius and material of the rebar.

#### Parameter `host`

The element to which the rebar belongs. The element must support rebar hosting;
`!:Autodesk::Revit::DB::Structure::RebarHostData` .

#### Parameter `origin`

The lower-left corner of the shape's bounding box will be placed at this point in the project.

#### Parameter `xVec`

The x-axis in the shape definition will be mapped to this direction in the project.

#### Parameter `yVec`

The y-axis in the shape definition will be mapped to this direction in the project.

#### Returns

The newly created Rebar instance, or `null` if the operation fails.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element host was not found in the given document.
-or-
host is not a valid rebar host.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

xVec has zero length.
-or-
yVec has zero length.

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.Rebar.CreateFromCurves(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.RebarStyle,Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.XYZ,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.Structure.RebarHookOrientation,Autodesk.Revit.DB.Structure.RebarHookOrientation,System.Double,System.Double,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Boolean,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.CreateFromCurves(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.RebarStyle,Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.XYZ,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.Structure.RebarHookOrientation,Autodesk.Revit.DB.Structure.RebarHookOrientation,System.Double,System.Double,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Boolean,System.Boolean)`

#### Summary

Creates a new instance of a shape driven Rebar element within the project.

#### Parameter `doc`

A document.

#### Parameter `style`

The usage of the bar, "standard" or "stirrup/tie".

#### Parameter `barType`

A RebarBarType element that defines bar diameter, bend radius and material of the rebar.

#### Parameter `startHook`

A RebarHookType element that defines the hook for the start of the bar.
If this parameter is `null` , it means to create a rebar with no hook.

#### Parameter `endHook`

A RebarHookType element that defines the hook for the end of the bar.
If this parameter is `null` , it means to create a rebar with no hook.

#### Parameter `host`

The element to which the rebar belongs. The element must support rebar hosting;
`!:Autodesk::Revit::DB::Structure::RebarHostData` .

#### Parameter `norm`

The normal to the plane that the rebar curves lie on.

#### Parameter `curves`

An array of curves that define the shape of the rebar curves.
They must belong to the plane defined by the normal and origin.
Bends and hooks should not be included in the array of curves.

#### Parameter `startHookOrient`

Defines the orientation of the hook plane at the start of the rebar with respect to the orientation of the first curve and the plane normal.
Only two values are permitted:
Value = Right: The hook is on your right as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."
Value = Left: The hook is on your left as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."

#### Parameter `endHookOrient`

Defines the orientation of the hook plane at the end of the rebar with respect to the orientation of the last curve and the plane normal.
Only two values are permitted:
Value = Right: The hook is on your right as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."
Value = Left: The hook is on your left as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."

#### Parameter `hookRotationAngleAtStart`

The out of plane hook rotation angle at the start of the bar.

#### Parameter `hookRotationAngleAtEnd`

The out of plane hook rotation angle at the end of the bar.

#### Parameter `endTreatmentTypeIdAtStart`

The end treatment type id at the start of the bar.

#### Parameter `endTreatmentTypeIdAtEnd`

The end treatment type id at the end of the bar.

#### Parameter `useExistingShapeIfPossible`

Attempts to assign a RebarShape from those existing in the document. If no shape matches, this function returns `null` if createNewShape is false or it will create a new shape if createNewShape is true.
When both parameters are "true", the behavior is the same as sketching rebar in the UI. At least one of these parameters must be "true".
If the RebarShapeDefinesHooks flag in ReinforcementSettings has been set to false, and a RebarShape cannot be found with both matching curves and hooks,
then this method will perform a second search, ignoring hook information.

#### Parameter `createNewShape`

Creates a shape in the document to match the curves, hooks, and style specified, and assigns it to the new rebar instance.
Shape creation will not succeed unless one or more other shapes already exist in the document, and these shapes
have enough shape parameters to define a shape for these curves.

#### Returns

The newly created Rebar instance, or `null` if the operation fails.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element host was not found in the given document.
-or-
host is not a valid rebar host.
-or-
The input curves is empty.
-or-
The input curves contains at least one curve which is not a bound Line or bound Arc
and is not supported for this operation.
-or-
curves do not form a valid CurveLoop.
-or-
The input curves contains at least one helical curve and is not supported for this operation.
-or-
the parameter endTreatmentTypeIdAtStart is not an EndTreatmentType element.
-or-
the parameter endTreatmentTypeIdAtEnd is not an EndTreatmentType element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

norm has zero length.
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Both useExistingShapeIfPossible and createNewShape are false.
-or-
curves contains non-fillet arcs with radii that are less than the
minimum bend radius for the RebarBarType and bar style.

#### Since

2021

### `M:Autodesk.Revit.DB.Structure.Rebar.CreateFromCurves(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.RebarStyle,Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.XYZ,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.Structure.RebarHookOrientation,Autodesk.Revit.DB.Structure.RebarHookOrientation,System.Boolean,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.CreateFromCurves(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.RebarStyle,Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Structure.RebarHookType,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.XYZ,System.Collections.Generic.IList{Autodesk.Revit.DB.Curve},Autodesk.Revit.DB.Structure.RebarHookOrientation,Autodesk.Revit.DB.Structure.RebarHookOrientation,System.Boolean,System.Boolean)`

#### Summary

Creates a new instance of a shape driven Rebar element within the project.

#### Parameter `doc`

A document.

#### Parameter `style`

The usage of the bar, "standard" or "stirrup/tie".

#### Parameter `barType`

A RebarBarType element that defines bar diameter, bend radius and material of the rebar.

#### Parameter `startHook`

A RebarHookType element that defines the hook for the start of the bar.
If this parameter is `null` , it means to create a rebar with no hook.

#### Parameter `endHook`

A RebarHookType element that defines the hook for the end of the bar.
If this parameter is `null` , it means to create a rebar with no hook.

#### Parameter `host`

The element to which the rebar belongs. The element must support rebar hosting;
`!:Autodesk::Revit::DB::Structure::RebarHostData` .

#### Parameter `norm`

The normal to the plane that the rebar curves lie on.

#### Parameter `curves`

An array of curves that define the shape of the rebar curves.
They must belong to the plane defined by the normal and origin.
Bends and hooks should not be included in the array of curves.

#### Parameter `startHookOrient`

Defines the orientation of the hook plane at the start of the rebar with respect to the orientation of the first curve and the plane normal.
Only two values are permitted:
Value = Right: The hook is on your right as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."
Value = Left: The hook is on your left as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."

#### Parameter `endHookOrient`

Defines the orientation of the hook plane at the end of the rebar with respect to the orientation of the last curve and the plane normal.
Only two values are permitted:
Value = Right: The hook is on your right as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."
Value = Left: The hook is on your left as you stand at the end of the bar,
with the bar behind you, taking the bar's normal as "up."

#### Parameter `useExistingShapeIfPossible`

Attempts to assign a RebarShape from those existing in the document. If no shape matches, this function returns null if createNewShape is false or it will create a new shape if createNewShape is true.
When both parameters are "true", the behavior is the same as sketching rebar in the UI. At least one of these parameters must be "true".
If the RebarShapeDefinesHooks flag in ReinforcementSettings has been set to false, and a RebarShape cannot be found with both matching curves and hooks,
then this method will perform a second search, ignoring hook information.

#### Parameter `createNewShape`

Creates a shape in the document to match the curves, hooks, and style specified, and assigns it to the new rebar instance.
Shape creation will not succeed unless one or more other shapes already exist in the document, and these shapes
have enough shape parameters to define a shape for these curves.

#### Returns

The newly created Rebar instance, or `null` if the operation fails.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element host was not found in the given document.
-or-
host is not a valid rebar host.
-or-
The input curves is empty.
-or-
The input curves contains at least one curve which is not a bound Line or bound Arc
and is not supported for this operation.
-or-
curves do not form a valid CurveLoop.
-or-
The input curves contains at least one helical curve and is not supported for this operation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

norm has zero length.
-or-
A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

Both useExistingShapeIfPossible and createNewShape are false.
-or-
curves contains non-fillet arcs with radii that are less than the
minimum bend radius for the RebarBarType and bar style.

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.Rebar.CreateFreeForm(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.Element,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},Autodesk.Revit.DB.Structure.RebarFreeFormValidationResult@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.CreateFreeForm(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.Element,System.Collections.Generic.IList{Autodesk.Revit.DB.CurveLoop},Autodesk.Revit.DB.Structure.RebarFreeFormValidationResult@)`

#### Summary

Creates a free form rebar that will be unconstrained. Constraints can't be added later to this rebar.

#### Remarks

This function can fail due to following reasons:

The array of CurveLoops is empty.

At least one CurveLoop is empty.

At least one CurveLoop contains an unbounded curve.

A rebar constructed from curves can't be bent according to the bending radius.

#### Parameter `doc`

A document.

#### Parameter `barType`

A RebarBarType element that defines bar diameter, bend radius and material of the rebar.

#### Parameter `host`

The element to which the rebar belongs. The element must support rebar hosting.

#### Parameter `curves`

Each curve loop represents a bar in the set.

#### Parameter `error`

Will be Success(0) if everything is ok, otherwise the failure reason.

#### Returns

The newly created free form Rebar Instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

host is not a valid rebar host.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.Rebar.CreateFreeForm(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.Element,System.Collections.Generic.IList{System.Collections.Generic.IList{Autodesk.Revit.DB.Curve}},Autodesk.Revit.DB.Structure.RebarFreeFormValidationResult@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.CreateFreeForm(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.Element,System.Collections.Generic.IList{System.Collections.Generic.IList{Autodesk.Revit.DB.Curve}},Autodesk.Revit.DB.Structure.RebarFreeFormValidationResult@)`

#### Summary

Creates a free form rebar that will be unconstrained. Constraints can't be added later to this rebar.

#### Remarks

This function can fail due to following reasons:

One or more of the input curves was null.

One or more of the input curves was unbounded.

Curves doesn't form a valid curve loop, it forms 0, 2 or more curve loops.

A rebar constructed from curves can't be bent according to the bending radius.

#### Parameter `doc`

A document.

#### Parameter `barType`

A RebarBarType element that defines bar diameter, bend radius and material of the rebar.

#### Parameter `host`

The element to which the rebar belongs. The element must support rebar hosting.

#### Parameter `curves`

Each array of curves represent a bar in the set.

#### Parameter `error`

Will be Success if everything is ok, otherwise the failure reason.

#### Returns

The newly created free form Rebar Instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

host is not a valid rebar host.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.Rebar.CreateFreeForm(Autodesk.Revit.DB.Document,System.Guid,Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.Rebar.CreateFreeForm(Autodesk.Revit.DB.Document,System.Guid,Autodesk.Revit.DB.Structure.RebarBarType,Autodesk.Revit.DB.Element)`

#### Summary

Creates a free form rebar that can have constraints.

#### Remarks

It requires a server GUID which will have the responsibility to define bar handles(which will be constrained) and to do the calculation of the curves.
See `T:Autodesk.Revit.DB.Structure.IRebarUpdateServer` for more details.

#### Parameter `doc`

A Document.

#### Parameter `serverGUID`

The API server GUID.
Should be the same that the function GetServerId() from class derived from `T:Autodesk.Revit.DB.Structure.IRebarUpdateServer` returns.
This server has the responsibility to calculate the bars of Rebar.

#### Parameter `barType`

A RebarBarType element that defines bar diameter, bend radius and material of the rebar.

#### Parameter `host`

The element to which the rebar belongs. The element must support rebar hosting.

#### Returns

The newly created free form Rebar Instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

host is not a valid rebar host.
-or-
The server with serverGUID was not registered for RebarUpdateService.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.Rebar.DistributionType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.Rebar.DistributionType`

#### Summary

The type of rebar distribution(also known as Rebar Set Type).

#### Remarks

The possible values of this property are:
Uniform

VaryingLength
For a uniform distribution type: all bars parameters are the same as the first bar in set.
For a varying length distribution type: bars parameters can vary(primarly in length)
taking in consideration the constraints of the first bar in set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.Rebar.NumberOfBarPositions`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.Rebar.NumberOfBarPositions`

#### Summary

The number of potential bars in the set.

#### Remarks

The number of positions is equal to the number of actual bars (the Quantity), plus the number of bars that are excluded.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: the number of bar positions numberOfBarPositions is less than 1 or more than 1002.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

When setting this property: This rebar element represents a single bar (the layout rule is Single).

#### Since

2009

### `P:Autodesk.Revit.DB.Structure.Rebar.Volume`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.Rebar.Volume`

#### Summary

The volume of an individual bar multiplied by Quantity.

#### Since

2009

### `P:Autodesk.Revit.DB.Structure.Rebar.TotalLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.Rebar.TotalLength`

#### Summary

The length of an individual bar multiplied by Quantity.

#### Since

2009

### `P:Autodesk.Revit.DB.Structure.Rebar.IncludeLastBar`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.Rebar.IncludeLastBar`

#### Summary

Identifies if the last bar in rebar set is shown.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This rebar element represents a single bar (the layout rule is Single).

#### Since

2009

### `P:Autodesk.Revit.DB.Structure.Rebar.IncludeFirstBar`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.Rebar.IncludeFirstBar`

#### Summary

Identifies if the first bar in rebar set is shown.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This rebar element represents a single bar (the layout rule is Single).

#### Since

2009

### `P:Autodesk.Revit.DB.Structure.Rebar.LayoutRule`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.Rebar.LayoutRule`

#### Summary

Identifies the layout rule of rebar set.

#### Since

2009

### `P:Autodesk.Revit.DB.Structure.Rebar.MaxSpacing`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.Rebar.MaxSpacing`

#### Summary

Identifies the maximum spacing between rebar in rebar set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The maxSpacing isn't bigger than 0.0.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

This rebar element represents a single bar (the layout rule is Single).

#### Since

2009

### `P:Autodesk.Revit.DB.Structure.Rebar.Quantity`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.Rebar.Quantity`

#### Summary

Identifies the number of bars in rebar set.

#### Remarks

Quantity is equal to NumberOfBarPositions if all the bars are included.
If any bars are excluded, they are not counted in the Quantity.

#### Since

2009

### `P:Autodesk.Revit.DB.Structure.Rebar.ReadOnlyParameters`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.Rebar.ReadOnlyParameters`

#### Summary

When set to true, Rebar will report all its parameters as read only.
For example, the method Parameter::IsReadOnly() for all Rebar Parameters will return true.
When set to false, the return value of Parameter::IsReadOnly() will not be affected.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.Rebar.ScheduleMark`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.Rebar.ScheduleMark`

#### Summary

The Schedule Mark parameter. On creation, the Schedule Mark is set
to a value that is unique to the host, but it can be set to
any value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `T:Autodesk.Revit.DB.Structure.Rebar`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.Rebar`

#### Summary

Represents a rebar element in Autodesk Revit.

#### Since

2009

### `M:Autodesk.Revit.DB.Structure.RebarHookType.CreateDefaultRebarHookType(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarHookType.CreateDefaultRebarHookType(Autodesk.Revit.DB.Document)`

#### Summary

Creates a new RebarHookType object with a default name.

#### Parameter `ADoc`

The document.

#### Returns

The newly created type id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.RebarHookType.GetHookExtensionLength(Autodesk.Revit.DB.Structure.RebarBarType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarHookType.GetHookExtensionLength(Autodesk.Revit.DB.Structure.RebarBarType)`

#### Summary

Computes the hook extension length based on current hook length

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.Structure.RebarHookType.GetDefaultHookExtension(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarHookType.GetDefaultHookExtension(System.Double)`

#### Summary

Computes the default hook length, which is equal to barDiameter * multiplier.

### `M:Autodesk.Revit.DB.Structure.RebarHookType.IsOffsetLengthRequired`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarHookType.IsOffsetLengthRequired`

#### Summary

Check whether hook offset length is required.
remarks: If hook angle is no more than 90 degree, hook offset length is not meaningful.
returns: True if hook offset length is required, otherwise false.

### `M:Autodesk.Revit.DB.Structure.RebarHookType.Create(Autodesk.Revit.DB.Document,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.RebarHookType.Create(Autodesk.Revit.DB.Document,System.Double,System.Double)`

#### Summary

Creates a new RebarHookType in a document.

#### Parameter `angle`

Determine the hook angle of new RebarHookType.

#### Parameter `multiplier`

Determine the straight line multiplier of new RebarHookType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The given value for angle is not a number
-or-
The given value for multiplier is not a number

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

angle must be greater than 0 and no more than pi.
-or-
multiplier must be greater than 0 and no more than 99.

### `P:Autodesk.Revit.DB.Structure.RebarHookType.StraightLineMultiplier`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarHookType.StraightLineMultiplier`

#### Summary

Multiplier of bar diameter. Used to compute a default hook length.
The default hook length can be overridden by the RebarBarType class.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for straightLineMultiplier is not a number

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: straightLineMultiplier must be greater than 0 and no more than 99.

### `P:Autodesk.Revit.DB.Structure.RebarHookType.HookAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarHookType.HookAngle`

#### Summary

The hook angle, measured in radians. Must be greater than 0 and no more than pi.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for hookAngle is not a number

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: hookAngle must be greater than 0 and no more than pi.

### `P:Autodesk.Revit.DB.Structure.RebarHookType.Style`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.RebarHookType.Style`

#### Summary

The hook may only be applied to shapes of the specified style.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

### `T:Autodesk.Revit.DB.Structure.RebarHookType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarHookType`

#### Summary

A Rebar Hook type object that is used in the generation of Rebar.

#### Remarks

This object contains the definition of the hooks that may be created at the ends
of the rebar. The specifics of these hooks are angle (range 0-PI) between first/last
segment of rebar and the straight segment of the hook, rebar shape style and
a multiplier used to compute the length of the straight segment of the hook.
The default length is computed as the bar diameter * the multiplier.
Length can be overridden by settings in the RebarBarType class.

### `T:Autodesk.Revit.DB.Structure.RebarHookOrientation`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarHookOrientation`

#### Summary

Orientation of a rebar hook relative to the path of the Rebar Shape.

### `F:Autodesk.Revit.DB.Structure.RebarHookOrientation.Right`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarHookOrientation.Right`

#### Summary

Hook towards the right of a segment-based shape (RebarShapeDefinitionBySegments), or to the
exterior of an arc-based shape (RebarShapeDefinitionByArc).

### `F:Autodesk.Revit.DB.Structure.RebarHookOrientation.Left`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarHookOrientation.Left`

#### Summary

Hook towards the left of a segment-based shape (RebarShapeDefinitionBySegments), or to the
interior of an arc-based shape (RebarShapeDefinitionByArc).

### `T:Autodesk.Revit.DB.Structure.AlignedFreeFormSetOrientationOptions`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.AlignedFreeFormSetOrientationOptions`

#### Summary

Orientation options for Aligned Free Form Rebar set.

#### Since

2024

#### Since

2024

### `F:Autodesk.Revit.DB.Structure.AlignedFreeFormSetOrientationOptions.PerpendicularToFace`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AlignedFreeFormSetOrientationOptions.PerpendicularToFace`

#### Summary

Cutting planes are oriented perpendicular to a selected planar face, X or Y vector being the face normal.

### `F:Autodesk.Revit.DB.Structure.AlignedFreeFormSetOrientationOptions.ParallelToFace`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AlignedFreeFormSetOrientationOptions.ParallelToFace`

#### Summary

Cutting planes are parallel to a selected planar face.

### `F:Autodesk.Revit.DB.Structure.AlignedFreeFormSetOrientationOptions.Vertical`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AlignedFreeFormSetOrientationOptions.Vertical`

#### Summary

Cutting planes are oriented vertically, X or Y vector being Z axis.

### `F:Autodesk.Revit.DB.Structure.AlignedFreeFormSetOrientationOptions.AlignedToDistributionPath`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.AlignedFreeFormSetOrientationOptions.AlignedToDistributionPath`

#### Summary

Cutting planes are perpendicular to the distribution path.

### `T:Autodesk.Revit.DB.Structure.RebarGeometryType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarGeometryType`

#### Summary

Rebar geometry type

### `F:Autodesk.Revit.DB.Structure.RebarGeometryType.FreeForm`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarGeometryType.FreeForm`

#### Summary

Free Form.

### `F:Autodesk.Revit.DB.Structure.RebarGeometryType.ShapeBased`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarGeometryType.ShapeBased`

#### Summary

Shape Driven.

### `T:Autodesk.Revit.DB.Structure.RebarFreeFormValidationResult`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormValidationResult`

#### Summary

Errors for the Free Form Rebar

### `F:Autodesk.Revit.DB.Structure.RebarFreeFormValidationResult.RebarCantBeBent`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormValidationResult.RebarCantBeBent`

#### Summary

A rebar constructed from curves can't be bent according to the bending radius.

### `F:Autodesk.Revit.DB.Structure.RebarFreeFormValidationResult.InvalidLoop`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormValidationResult.InvalidLoop`

#### Summary

Curves doesn't form a valid curve loop.

### `F:Autodesk.Revit.DB.Structure.RebarFreeFormValidationResult.UnboundCurve`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormValidationResult.UnboundCurve`

#### Summary

One or more of the input curves was unbounded.

### `F:Autodesk.Revit.DB.Structure.RebarFreeFormValidationResult.NullCurve`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormValidationResult.NullCurve`

#### Summary

One or more of the input curves was null.

### `F:Autodesk.Revit.DB.Structure.RebarFreeFormValidationResult.Undefined`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormValidationResult.Undefined`

#### Summary

An unexpected error occured.

### `F:Autodesk.Revit.DB.Structure.RebarFreeFormValidationResult.Success`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarFreeFormValidationResult.Success`

#### Summary

Operation was done with success.

### `T:Autodesk.Revit.DB.Structure.DistributionType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.DistributionType`

#### Summary

The type of the distribution

### `F:Autodesk.Revit.DB.Structure.DistributionType.VaryingLength`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.DistributionType.VaryingLength`

#### Summary

It is a varying length distribution.

### `F:Autodesk.Revit.DB.Structure.DistributionType.Uniform`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.DistributionType.Uniform`

#### Summary

It is an uniform distribution.

### `T:Autodesk.Revit.DB.Structure.ReinforcementBarOrientation`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementBarOrientation`

#### Summary

Describes the bar orientation at Path Reinforcement.

#### Since

2016

#### Since

2016

### `F:Autodesk.Revit.DB.Structure.ReinforcementBarOrientation.FarSide`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementBarOrientation.FarSide`

#### Summary

The major segment of the bar is on the side edge far from the Path Reinforcement sketch line.

### `F:Autodesk.Revit.DB.Structure.ReinforcementBarOrientation.BottomOrInterior`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementBarOrientation.BottomOrInterior`

#### Summary

The major segment of the bar is on the bottom face (of a floor/slab) or the interior face (of a wall).

### `F:Autodesk.Revit.DB.Structure.ReinforcementBarOrientation.NearSide`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementBarOrientation.NearSide`

#### Summary

The major segment of the bar is on the side edge near to the Path Reinforcement sketch line.

### `F:Autodesk.Revit.DB.Structure.ReinforcementBarOrientation.TopOrExterior`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ReinforcementBarOrientation.TopOrExterior`

#### Summary

The major segment of the bar is on the top face (of a floor/slab) or the exterior face (of a wall).

### `T:Autodesk.Revit.DB.Structure.RebarHostCategory`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarHostCategory`

#### Summary

Rebar host category

#### Since

2015

#### Since

2015

### `F:Autodesk.Revit.DB.Structure.RebarHostCategory.SlabEdge`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarHostCategory.SlabEdge`

#### Summary

Slab Edge.

### `F:Autodesk.Revit.DB.Structure.RebarHostCategory.Stairs`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarHostCategory.Stairs`

#### Summary

Stairs.

### `F:Autodesk.Revit.DB.Structure.RebarHostCategory.StructuralFoundation`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarHostCategory.StructuralFoundation`

#### Summary

Structural Foundation.

### `F:Autodesk.Revit.DB.Structure.RebarHostCategory.Floor`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarHostCategory.Floor`

#### Summary

Floor.

### `F:Autodesk.Revit.DB.Structure.RebarHostCategory.Wall`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarHostCategory.Wall`

#### Summary

Wall.

### `F:Autodesk.Revit.DB.Structure.RebarHostCategory.StructuralFraming`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarHostCategory.StructuralFraming`

#### Summary

Structural Framing.

### `F:Autodesk.Revit.DB.Structure.RebarHostCategory.StructuralColumn`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarHostCategory.StructuralColumn`

#### Summary

Structural Column.

### `F:Autodesk.Revit.DB.Structure.RebarHostCategory.Part`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarHostCategory.Part`

#### Summary

Part.

### `F:Autodesk.Revit.DB.Structure.RebarHostCategory.Other`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarHostCategory.Other`

#### Summary

Unknown or invalid host.

### `T:Autodesk.Revit.DB.Structure.RebarPresentationMode`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarPresentationMode`

#### Summary

Bar presentation mode

#### Since

2015

#### Since

2015

### `F:Autodesk.Revit.DB.Structure.RebarPresentationMode.Select`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarPresentationMode.Select`

#### Summary

Selected bars are presented.

### `F:Autodesk.Revit.DB.Structure.RebarPresentationMode.Middle`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarPresentationMode.Middle`

#### Summary

The middle bar is presented.

### `F:Autodesk.Revit.DB.Structure.RebarPresentationMode.FirstLast`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarPresentationMode.FirstLast`

#### Summary

The first and last bars are presented.

### `F:Autodesk.Revit.DB.Structure.RebarPresentationMode.All`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarPresentationMode.All`

#### Summary

All bars are presented.

### `T:Autodesk.Revit.DB.Structure.RebarDeformationType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarDeformationType`

#### Summary

Bar deformation type

#### Since

2014

#### Since

2014

### `F:Autodesk.Revit.DB.Structure.RebarDeformationType.Plain`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarDeformationType.Plain`

#### Summary

The bar is not ribbed.

### `F:Autodesk.Revit.DB.Structure.RebarDeformationType.Deformed`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarDeformationType.Deformed`

#### Summary

The bar is ribbed.

### `T:Autodesk.Revit.DB.Structure.MultiplanarOption`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.MultiplanarOption`

#### Summary

Input argument type for Rebar.GetCenterlineCurves method.
Controls whether all curves of a multi-planar Rebar element are returned by
GetCenterlineCurves, or only the curves in the primary plane.

### `F:Autodesk.Revit.DB.Structure.MultiplanarOption.IncludeOnlyPlanarCurves`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.MultiplanarOption.IncludeOnlyPlanarCurves`

#### Summary

Include only curves which lie in the Rebar's primary plane.

### `F:Autodesk.Revit.DB.Structure.MultiplanarOption.IncludeAllMultiplanarCurves`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.MultiplanarOption.IncludeAllMultiplanarCurves`

#### Summary

Include all curves.

### `T:Autodesk.Revit.DB.Structure.RebarStyle`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarStyle`

#### Summary

Describes the usage style of a RebarShape.
The style affects the bend radius and the set of allowable hooks.
It also affects Rebar instance auto-constraining behavior.

### `F:Autodesk.Revit.DB.Structure.RebarStyle.StirrupTie`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarStyle.StirrupTie`

#### Summary

A stirrup or tie bar.

### `F:Autodesk.Revit.DB.Structure.RebarStyle.Standard`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarStyle.Standard`

#### Summary

A standard or longitudinal bar.

### `T:Autodesk.Revit.DB.Structure.RebarLayoutRule`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarLayoutRule`

#### Summary

The rule for how the rebars in rebar set are laid out

### `F:Autodesk.Revit.DB.Structure.RebarLayoutRule.MinimumClearSpacing`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarLayoutRule.MinimumClearSpacing`

#### Summary

The minimum distance between rebar is specified by input,
and the number of rebar changes based on the length of rebar set.
This spacing is maintained even if the rebar size changes.

### `F:Autodesk.Revit.DB.Structure.RebarLayoutRule.NumberWithSpacing`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarLayoutRule.NumberWithSpacing`

#### Summary

Both the spacing between rebar and the number of rebar are constant based on input.

### `F:Autodesk.Revit.DB.Structure.RebarLayoutRule.MaximumSpacing`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarLayoutRule.MaximumSpacing`

#### Summary

The maximum distance between rebar is specified by input,
and the number of rebar changes based on the length of rebar set.

### `F:Autodesk.Revit.DB.Structure.RebarLayoutRule.FixedNumber`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarLayoutRule.FixedNumber`

#### Summary

The spacing between the rebar is adjustable,
but the number of bars is constant based on input.

### `F:Autodesk.Revit.DB.Structure.RebarLayoutRule.Single`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarLayoutRule.Single`

#### Summary

It is a single rebar and not a rebar set.

### `T:Autodesk.Revit.DB.Structure.RebarWorkInstructions`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.RebarWorkInstructions`

#### Summary

Describes how a Free Form Rebar will be fabricated.

#### Since

2018

#### Since

2018

### `F:Autodesk.Revit.DB.Structure.RebarWorkInstructions.Straight`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarWorkInstructions.Straight`

#### Summary

The bar will be delivered as a straight bar to the site and the shape code is one of the straight Rebar Shapes loaded into the project (e.g. 00).

### `F:Autodesk.Revit.DB.Structure.RebarWorkInstructions.Bent`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.RebarWorkInstructions.Bent`

#### Summary

The bar will be bent in the shop. It will be matched to an existing Rebar Shape. If it can't be matched to an existing one a matching one will be created if it is possible.

### `M:Autodesk.Revit.DB.Electrical.Wire.GetMEPSystems`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.Wire.GetMEPSystems`

#### Summary

Gets the systems to which the wire belongs.

#### Remarks

One wire might belong to more than one circuit.

#### Returns

The systems to which the wire belongs.

#### Since

2016 Subscription Update

### `M:Autodesk.Revit.DB.Electrical.Wire.IsVertexPointValid(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.Wire.IsVertexPointValid(Autodesk.Revit.DB.XYZ)`

#### Summary

Checks if the given vertex point can be added to this wire.

#### Remarks

Vertices are projected to the view plane for comparison.

#### Parameter `vertexPoint`

The vertex point.

#### Returns

True if the vertex point can be added, false if the point cannot be added because there is already a vertex at this position on the view plane (within tolerance).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Electrical.Wire.GetVertex(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.Wire.GetVertex(System.Int32)`

#### Summary

Gets the position of an existing vertex.

#### Parameter `index`

The index of the existing vertex. Should be between 0 and `P:Autodesk.Revit.DB.Electrical.Wire.NumberOfVertices` .

#### Returns

The position of the vertex.
It is the offset point for the start and end vertex, not the connector point.
If the wire connects to one device, it may have offset; otherwise, the start and end vertex is same as the connector point.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The index should be between 0 and the number of vertices of the wire.

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2015

### `M:Autodesk.Revit.DB.Electrical.Wire.SetVertex(System.Int32,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.Wire.SetVertex(System.Int32,Autodesk.Revit.DB.XYZ)`

#### Summary

Sets the position of a given vertex.
If the vertex is start or end point, and the wire connects to electrical device, the wire end offset will be set according to the given vertex.
If the vertex is start or end point, and the wire connects to other wire, user can't set the vertex and exception will be thrown.
If the vertex is start or end point, and the wire connects to nothing, the vertex will be set as the given vertex.

#### Parameter `index`

The index of the existing vertex. Should be between 0 and `P:Autodesk.Revit.DB.Electrical.Wire.NumberOfVertices` .

#### Parameter `vertexPoint`

The new position for the vertex.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The index should be between 0 and the number of vertices of the wire.
-or-
The vertex point cannot be added to the wire because there is already a vertex at this position on the view plane (within tolerance).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Can't set the vertex when the vertex is start or end point and the wire connects to other wire.

#### Since

2015

### `M:Autodesk.Revit.DB.Electrical.Wire.RemoveVertex(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.Wire.RemoveVertex(System.Int32)`

#### Summary

Removes the vertex corresponding to the specified index.
Can not remove the start or end vertex if it already connects to other element.

#### Parameter `index`

The index which should be in [0, NumberOfVertices).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The index should be between 0 and the number of vertices of the wire.

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The wire has only 2 vertices, so one cannot be removed.
-or-
Can't remove the vertex when the vertex is start or end point and the wire connects to one element.

#### Since

2015

### `M:Autodesk.Revit.DB.Electrical.Wire.InsertVertex(System.Int32,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.Wire.InsertVertex(System.Int32,Autodesk.Revit.DB.XYZ)`

#### Summary

Inserts a new vertex before the specified index.

#### Remarks

To add a new vertex to the end of the wire, use `M:Autodesk.Revit.DB.Electrical.Wire.AppendVertex(Autodesk.Revit.DB.XYZ)` .

#### Parameter `index`

The index of the vertex to come after this new vertex. Should be between 0 and `P:Autodesk.Revit.DB.Electrical.Wire.NumberOfVertices` .

#### Parameter `vertexPoint`

The point of the new vertex.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The index should be between 0 and the number of vertices of the wire.
-or-
The vertex point cannot be added to the wire because there is already a vertex at this position on the view plane (within tolerance).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Can't insert the vertex before the start vertex if the start point connects to one element.

#### Since

2015

### `M:Autodesk.Revit.DB.Electrical.Wire.AppendVertex(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.Wire.AppendVertex(Autodesk.Revit.DB.XYZ)`

#### Summary

Appends one vertex to the end of the wire.

#### Parameter `vertexPoint`

The vertex to be appended.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The vertex point cannot be added to the wire because there is already a vertex at this position on the view plane (within tolerance).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The end point is already connected to an element, so a new endpoint vertex cannot be appended.

#### Since

2015

### `M:Autodesk.Revit.DB.Electrical.Wire.AreVertexPointsValid(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.Wire.AreVertexPointsValid(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

#### Summary

Checks if the given vertex points are valid for the wire.

#### Remarks

X and Y values are compared of the vertices.

#### Parameter `vertexPoints`

The vertex points.

#### Parameter `startConnector`

The start connector of the wire.

#### Parameter `endConnector`

The end connector of the wire.

#### Returns

True if the given vertex points are valid, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Electrical.Wire.ConnectTo(Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.Wire.ConnectTo(Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

#### Summary

Connects the wire to other elements.

#### Parameter `startConnectorTo`

The connector that the start connector of the wire connects to.

#### Parameter `endConnectorTo`

The connector that the end connector of the wire connects to.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

startConnectorTo cannot be connected to a wire, as it is not an electrical connector.
-or-
endConnectorTo cannot be connected to a wire, as it is not an electrical connector.
-or-
startConnectorTo or/and endConnectorTo cannot be connected to a wire, as wire can't connect both connectors to same wire or same connector.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Cannot connect the wire to the start connector or the end connector.

#### Since

2015

### `M:Autodesk.Revit.DB.Electrical.Wire.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Electrical.WiringType,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.Wire.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Electrical.WiringType,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ},Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

#### Summary

Creates a new wire.

#### Parameter `document`

The document.

#### Parameter `wireTypeId`

The id of the wire type of the newly created wire.

#### Parameter `viewId`

The view in which the wire is to be visible. This must be the id of a floor plan or reflected ceiling plan view.

#### Parameter `wiringType`

Specifiies the wiring type for the newly created wire. The shape of the wire is determined by this value and the total number of points supplied via the vertexPoints and endpoint connectors. If the wiring type is WiringType.Arc:
If there are 2 total points supplied, the wire is a straight-line wire.

If there are 3 total points supplied, the wire is a circular arc wire.

If there are 4 or more points, the wire is a spline wire.
If the wiring type is WiringType.Chamfer, a polyline wire will be created connecting all the points.

#### Parameter `vertexPoints`

The vertex point of the wire.
If the startConnectorTo is `null` , the first vertex of the vertexPoints will be the start point, otherwise, the start connector origin will be the start point.
If the endConnectorTo is `null` , the last vertex of the vertexPoints will be the end point, otherwise, the end connector origin will be the end point.

#### Parameter `startConnectorTo`

The connector to which the wire start point connects. If `null` , the start point connects to no existing connector. If set with a connector, the connector's origin will be added to the wire's vertices as the start point.

#### Parameter `endConnectorTo`

The connector to which the wire end point connects. If `null` , the end point connects to no existing connector. If set with a connector, the connector's origin will be added to the wire's vertices as the end point.

#### Returns

The wire created.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

wireTypeId is not a valid WireType id.
-or-
viewId does not represent a view valid for a Wire element. Either a floor plan or reflected ceiling plan is expected.
-or-
vertexPoints is not valid, because one or more points are coincident by comparing the X and Y of the points, or there are not at least two points including the connectors.
-or-
startConnectorTo cannot be connected to a wire, as it is not an electrical connector.
-or-
endConnectorTo cannot be connected to a wire, as it is not an electrical connector.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2015

### `P:Autodesk.Revit.DB.Electrical.Wire.NumberOfVertices`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.Wire.NumberOfVertices`

#### Summary

The number of vertices of the wire, including the start and end point.

#### Since

2015

### `P:Autodesk.Revit.DB.Electrical.Wire.GroundConductorNum`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.Wire.GroundConductorNum`

#### Summary

The ground conductor number. Its default value is zero after created.

### `P:Autodesk.Revit.DB.Electrical.Wire.NeutralConductorNum`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.Wire.NeutralConductorNum`

#### Summary

The neutral conductor number. Its default value is zero after created.

### `P:Autodesk.Revit.DB.Electrical.Wire.HotConductorNum`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.Wire.HotConductorNum`

#### Summary

The hot conductor number. Its default value is zero after created.

### `P:Autodesk.Revit.DB.Electrical.Wire.WiringType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.Wire.WiringType`

#### Summary

The wiring type(arc or chamfer) for the wire.

#### Remarks

If the WiringType is arc, the shape of the wire depends on the number of points - it may be linear, a circular arc, or a spline.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

### `T:Autodesk.Revit.DB.Electrical.Wire`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.Wire`

#### Summary

Electrical wire element.

### `M:Autodesk.Revit.DB.Mechanical.MEPSection.GetElementIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MEPSection.GetElementIds`

#### Summary

Gets all element ids that are contained in the section.

#### Since

2013

### `M:Autodesk.Revit.DB.Mechanical.MEPSection.IsMain(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MEPSection.IsMain(Autodesk.Revit.DB.ElementId)`

#### Summary

Check whether the type of fitting in this section is main.

#### Parameter `fittingId`

The element id which can be duct fitting and pipe fitting.

#### Returns

True if the type of fitting in this section is main
False if the type of fitting in this section is branch

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId fittingId does not correspond to a valid section fitting member.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Mechanical.MEPSection.GetSegmentLength(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MEPSection.GetSegmentLength(Autodesk.Revit.DB.ElementId)`

#### Summary

Get the length for the specified segment id in this section.

#### Parameter `segmentId`

The element id which can be duct segment and pipe segment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId segmentId does not correspond to a valid section segment member.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Mechanical.MEPSection.GetCoefficient(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MEPSection.GetCoefficient(Autodesk.Revit.DB.ElementId)`

#### Summary

Gets the loss coefficient for the specified element id in this section.

#### Remarks

For Duct, it is loss coefficient.
For Pipe, the loss coefficient is equivalent to the friction factor.
Loss coefficient is a number.
The unit type is UT_Number.

#### Parameter `elemId`

The element id which can be duct segment, duct fitting , pipe segment and pipe fitting.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId elemId does not correspond to a valid section member.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Mechanical.MEPSection.GetPressureDrop(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MEPSection.GetPressureDrop(Autodesk.Revit.DB.ElementId)`

#### Summary

Gets the pressure drop for the specified element id in this section.

#### Parameter `elemId`

The element id which can be duct segment, duct fitting , pipe segment and pipe fitting.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId elemId does not correspond to a valid section member.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.Mechanical.MEPSection.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.MEPSection.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.MEPSection.FrictionFactor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.MEPSection.FrictionFactor`

#### Summary

The friction factor of the section.

#### Remarks

Friction Factor is a number.
The friction factor type is UT_Number.

#### Since

2013

### `P:Autodesk.Revit.DB.Mechanical.MEPSection.ReynoldsNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.MEPSection.ReynoldsNumber`

#### Summary

The Reynolds number of the section.

#### Remarks

Reynolds number is a number.
The Reynolds number type is UT_Number.

#### Since

2013

### `P:Autodesk.Revit.DB.Mechanical.MEPSection.TotalCurveLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.MEPSection.TotalCurveLength`

#### Summary

The total length of all segments in the section.

#### Remarks

Default unit is Decimal feet.
The unit type is UT_Length.

#### Since

2013

### `P:Autodesk.Revit.DB.Mechanical.MEPSection.TotalPressureLoss`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.MEPSection.TotalPressureLoss`

#### Summary

The total pressure loss of the section.

#### Remarks

It's total of all fittings and segments.
Default unit is Kgf per square feet.
For Duct, unit type is UT_HVAC_Pressure.
For Pipe, unit type is UT_Piping_Pressure.

#### Since

2013

### `P:Autodesk.Revit.DB.Mechanical.MEPSection.TotalCoefficient`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.MEPSection.TotalCoefficient`

#### Summary

The loss coefficient of the section.

#### Remarks

It's total of all fittings and segments.
Coefficient is a number.
The unit type is UT_Number.

#### Since

2013

### `P:Autodesk.Revit.DB.Mechanical.MEPSection.VelocityPressure`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.MEPSection.VelocityPressure`

#### Summary

The velocity pressure of the section.

#### Remarks

Default unit is Kgf per square feet.
For Duct, unit type is UT_HVAC_Pressure.
For Pipe, unit type is UT_Piping_Pressure

#### Since

2013

### `P:Autodesk.Revit.DB.Mechanical.MEPSection.Velocity`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.MEPSection.Velocity`

#### Summary

The velocity of the section.

#### Remarks

In one section, all section members have same velocity.
Default unit is Feet per second.
For Duct, unit type is UT_HVAC_Velocity.
For Pipe, unit type is UT_Piping_Velocity

#### Since

2013

### `P:Autodesk.Revit.DB.Mechanical.MEPSection.Friction`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.MEPSection.Friction`

#### Summary

The friction of the section.

#### Remarks

In one section, all section members have same friction.
Default unit is Feet of Water (60 Â°F) per 100 feet.
For Duct, unit type is UT_HVAC_Friction.
For Pipe, unit type is UT_Piping_Friction

#### Since

2013

### `P:Autodesk.Revit.DB.Mechanical.MEPSection.FixtureUnit`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.MEPSection.FixtureUnit`

#### Summary

The fixture unit of the section.

#### Remarks

In one section, all section members have same fixture unit.
Fixture Unit is a number.
The unit type is UT_Number.

#### Since

2013

### `P:Autodesk.Revit.DB.Mechanical.MEPSection.Flow`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.MEPSection.Flow`

#### Summary

The flow of the section.

#### Remarks

In one section, all section members have same flow.
Default unit is Cubic feet per second.
For Duct, unit type is UT_HVAC_Airflow.
For Pipe, unit type is UT_Piping_Flow

#### Since

2013

### `P:Autodesk.Revit.DB.Mechanical.MEPSection.Roughness`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.MEPSection.Roughness`

#### Summary

The roughness of the section.

#### Remarks

In one section, all section members have same roughness.
Default unit is Decimal feet.
For Duct, unit type is UT_HVAC_Roughness.
For Pipe, unit type is UT_Piping_Roughness

#### Since

2013

### `P:Autodesk.Revit.DB.Mechanical.MEPSection.Number`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.MEPSection.Number`

#### Summary

The Section number.

#### Since

2013

### `T:Autodesk.Revit.DB.Mechanical.MEPSection`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.MEPSection`

#### Summary

A section in the Autodesk Revit MEP product.

#### Remarks

This is the base class for duct and pipe section.
This class is mainly for pressure loss calculation.
It is a series of connected elements (segments - ducts or pipes, fittings, terminals and accessories).
All section members should have same flow analysis properties: Flow, Size, Velocity, Friction and Roughness.
One section member element which contains more than one connector can belongs to multiple section.
e.g.: One Tee which has 3 connectors, usually, it belongs 3 sections.
One segment which connect to a tap will be divided into 2 sections.

#### Since

2013

### `M:Autodesk.Revit.DB.Plumbing.PipingSystemType.ValidateRiseDropSymbolType(Autodesk.Revit.DB.Mechanical.RiseDropSymbol)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipingSystemType.ValidateRiseDropSymbolType(Autodesk.Revit.DB.Mechanical.RiseDropSymbol)`

#### Summary

Confirms if the parameter is a valid piping rise/drop symbol type.

#### Parameter `risedropType`

The type.

#### Returns

True if the input is a valid piping rise/drop symbol type, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `M:Autodesk.Revit.DB.Plumbing.PipingSystemType.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.MEPSystemClassification,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipingSystemType.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.MEPSystemClassification,System.String)`

#### Summary

Creates a new instance of a piping system type and adds it to the document.

#### Parameter `ADoc`

The document where the element will be created and added.

#### Parameter `systemClassification`

The classification for the piping system type to be created

#### Parameter `name`

The name of the piping system type to be created.

#### Returns

The newly created piping system type element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

The system classification is not valid for the domain of this system type.

#### Since

2012

### `P:Autodesk.Revit.DB.Plumbing.PipingSystemType.FluidType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipingSystemType.FluidType`

#### Summary

Fluid Type

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: fluidTypeId is not a fluid type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.Plumbing.PipingSystemType.FluidTemperature`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipingSystemType.FluidTemperature`

#### Summary

Fluid Temperature, in Kelvin.

#### Since

2012

### `P:Autodesk.Revit.DB.Plumbing.PipingSystemType.SingleLineJunctionDropType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipingSystemType.SingleLineJunctionDropType`

#### Summary

Symbol for a 1 line junction drop

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The input is not a valid piping rise/drop symbol type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `P:Autodesk.Revit.DB.Plumbing.PipingSystemType.SingleLineJunctionRiseType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipingSystemType.SingleLineJunctionRiseType`

#### Summary

Symbol for a 1 line junction rise

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The input is not a valid piping rise/drop symbol type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `P:Autodesk.Revit.DB.Plumbing.PipingSystemType.SingleLineBendDropType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipingSystemType.SingleLineBendDropType`

#### Summary

Symbol for a 1 line drop

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The input is not a valid piping rise/drop symbol type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `P:Autodesk.Revit.DB.Plumbing.PipingSystemType.SingleLineBendRiseType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipingSystemType.SingleLineBendRiseType`

#### Summary

Symbol for a 1 line rise

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The input is not a valid piping rise/drop symbol type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `P:Autodesk.Revit.DB.Plumbing.PipingSystemType.TwoLineDropType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipingSystemType.TwoLineDropType`

#### Summary

Symbol for a 2 line drop

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The input is not a valid piping rise/drop symbol type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `P:Autodesk.Revit.DB.Plumbing.PipingSystemType.TwoLineRiseType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipingSystemType.TwoLineRiseType`

#### Summary

Symbol for a 2 line rise

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The input is not a valid piping rise/drop symbol type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `P:Autodesk.Revit.DB.Plumbing.PipingSystemType.FlowConversionMethod`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipingSystemType.FlowConversionMethod`

#### Summary

The flow conversion method for the piping system type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `T:Autodesk.Revit.DB.Plumbing.PipingSystemType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Plumbing.PipingSystemType`

#### Summary

Base class for piping system types

#### Since

2012

### `T:Autodesk.Revit.DB.Plumbing.FlowConversionMode`

Member kind: type
Symbol: `Autodesk.Revit.DB.Plumbing.FlowConversionMode`

#### Summary

Enumerated type listing possible flow conversion modes for piping calculations.

#### Since

2012

### `F:Autodesk.Revit.DB.Plumbing.FlowConversionMode.Tanks`

Member kind: field
Symbol: `Autodesk.Revit.DB.Plumbing.FlowConversionMode.Tanks`

#### Summary

Predominantly flush tanks.

### `F:Autodesk.Revit.DB.Plumbing.FlowConversionMode.Valves`

Member kind: field
Symbol: `Autodesk.Revit.DB.Plumbing.FlowConversionMode.Valves`

#### Summary

Predominantly flush valves.

### `F:Autodesk.Revit.DB.Plumbing.FlowConversionMode.Invalid`

Member kind: field
Symbol: `Autodesk.Revit.DB.Plumbing.FlowConversionMode.Invalid`

#### Summary

A default value which should not be assigned to system types.

### `M:Autodesk.Revit.DB.Plumbing.PipingSystem.CanBeHydraulicLoopBoundary(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipingSystem.CanBeHydraulicLoopBoundary(Autodesk.Revit.DB.Element)`

#### Summary

Checks if the element can be used as a hydraulic loop boundary.

#### Parameter `element`

The element to be checked.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Plumbing.PipingSystem.IsHydraulicLoopBoundary(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipingSystem.IsHydraulicLoopBoundary(Autodesk.Revit.DB.Element)`

#### Summary

Checks if the element is a valid hydraulic loop boundary.

#### Parameter `element`

The element to be checked.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Plumbing.PipingSystem.DeleteHydraulicSeparation(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipingSystem.DeleteHydraulicSeparation(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

#### Summary

Deletes hydraulically separated systems and merges the system components into the connected system.

#### Parameter `document`

The document where the system is deleted.

#### Parameter `pipeElementIds`

The boundary pipe that separates the system. Multiple pipes are allowed to delete more than one separated systems.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One or more elements is not a pipe.
-or-
One or more elements is not a valid loop boundary.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Plumbing.PipingSystem.CreateHydraulicSeparation(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipingSystem.CreateHydraulicSeparation(Autodesk.Revit.DB.Document,System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

#### Summary

Creates new system which is hydraulically separated from the existing system.

#### Remarks

Hydraulically separated systems allow independent flow and pressure analysis for each hydraulic loop.
For example, each hydraulic loop has its own cirtical path. The calculated pressure drop on the primary
pump is consisted of all pressure drop on the primary critical path. Any pressure drop on the secondary
loop would only contribute to the calculated pressure drop of the secondary pump.

#### Parameter `document`

The document where the new system is created.

#### Parameter `pipeElementIds`

The boundary pipe that defines a new system. Multiple pipes are allowed to create more than one separated systems.

#### Returns

The newly created piping system elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One or more elements is not a pipe.
-or-
One or more elements is already the loop boundary.
-or-
One or more elements can not be used as loop boundary. Check if the element connects to any junction.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Plumbing.PipingSystem.GetPumpSets`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipingSystem.GetPumpSets`

#### Summary

Gets the set of element Id's for all pump sets in the system, if any.

#### Returns

The set of all the pump sets in the system.

#### Since

2019

### `M:Autodesk.Revit.DB.Plumbing.PipingSystem.GetFixtureUnits`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipingSystem.GetFixtureUnits`

#### Summary

Gets the fixture units of this piping system.

#### Remarks

The system fixture units is calculated in the non-blocking evaluation framework. The caller may set up callbacks that react to the asynchronous calculation results.
If no callback is set up (e.g, called from third-party applications), the calculation is automatically switched to synchronous calculation so the caller
can access the up-to-date result. Similarly, the public method get_ParameterValue(BuiltInParameter.RBS_PIPE_SYSTEM_FIXTURE_UNIT_PARAM) has the same behavior.
Due to this change, the parameter RBS_PIPE_SYSTEM_FIXTURE_UNIT_PARAM no longer supports dynamic model update.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The fixture units can not be calculated for this system.

#### Since

2017

### `M:Autodesk.Revit.DB.Plumbing.PipingSystem.GetStaticPressure`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipingSystem.GetStaticPressure`

#### Summary

Gets the static pressure of this piping system.

#### Remarks

The system static pressure is calculated in the non-blocking evaluation framework. The caller may set up callbacks that react to the asynchronous calculation results.
If no callback is set up (e.g, called from third-party applications), the calculation is automatically switched to synchronous calculation so the caller
can access the up-to-date result. Similarly, the public method get_ParameterValue(BuiltInParameter.RBS_PIPE_STATIC_PRESSURE) has the same behavior. Due to this
change, the parameter RBS_PIPE_STATIC_PRESSURE no longer supports dynamic model update.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The static pressure can not be calculated for this system.

#### Since

2017

### `M:Autodesk.Revit.DB.Plumbing.PipingSystem.GetFlow`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipingSystem.GetFlow`

#### Summary

Gets the flow of this piping system.

#### Remarks

The system flow is calculated in the non-blocking evaluation framework. The caller may set up callbacks that react to the asynchronous calculation results.
If no callback is set up (e.g, called from third-party applications), the calculation is automatically switched to synchronous calculation so the caller
can access the up-to-date result. Similarly, the public method get_ParameterValue(BuiltInParameter.RBS_PIPE_FLOW_PARAM) has the same behavior. Due to this
change, the parameter RBS_PIPE_FLOW_PARAM no longer supports dynamic model update.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The flow can not be calculated for this system.

#### Since

2017

### `M:Autodesk.Revit.DB.Plumbing.PipingSystem.GetVolume`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipingSystem.GetVolume`

#### Summary

Gets the volume of this piping system.

#### Remarks

The publicly exposed method.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The volume can not be calculated for this system.

#### Since

2017

### `M:Autodesk.Revit.DB.Plumbing.PipingSystem.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipingSystem.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.String)`

#### Summary

Creates a new instance of a piping system and adds it to the document.

#### Parameter `ADocument`

The document where the element will be created and added.

#### Parameter `typeId`

The identifier of this piping system element's type.

#### Parameter `name`

The name of the piping system to be created.

#### Returns

The newly created piping system element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The typeId is not an element id for a valid piping system type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2011

### `M:Autodesk.Revit.DB.Plumbing.PipingSystem.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipingSystem.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new instance of a piping system and adds it to the document.

#### Parameter `ADocument`

The document where the element will be created and added.

#### Parameter `typeId`

The identifier of this piping system element's type.

#### Returns

The newly created piping system element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The typeId is not an element id for a valid piping system type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2011

### `M:Autodesk.Revit.DB.Plumbing.PipingSystem.IsPressureDropServerMissing`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipingSystem.IsPressureDropServerMissing`

#### Summary

Indicates if any pressure drop server which was used in the piping system is not available.

#### Returns

True if there is any pressure drop server not available, false otherwise.

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.PipingSystem.IsFlowServerMissing`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipingSystem.IsFlowServerMissing`

#### Summary

Indicates if any flow server which was used in the piping system is not available.

#### Returns

True if there is any flow server not available, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipingSystem.IsWellConnected`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipingSystem.IsWellConnected`

#### Summary

Indicates if the system is well connected or not.

#### Remarks

If the system is not well connected, parameters which need to be calculated are invalid.

#### Since

2011

### `P:Autodesk.Revit.DB.Plumbing.PipingSystem.PipingNetwork`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipingSystem.PipingNetwork`

#### Summary

Pipes and fittings which are contained in this system.

#### Remarks

The return value doesn't include mechanical equipment elements.
The pipes and fittings are not returned in any particular order.

### `P:Autodesk.Revit.DB.Plumbing.PipingSystem.BaseEquipmentConnector`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipingSystem.BaseEquipmentConnector`

#### Summary

The connector within base equipment which is used to connect with system.

#### Remarks

Setting this property to `null` will disconnect base equipment from system.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when assigning a connector which is used in a system,
or when the connector's owner is not of type 'mechanical equipment'.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the set operation failed.

### `P:Autodesk.Revit.DB.Plumbing.PipingSystem.SystemType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipingSystem.SystemType`

#### Summary

The type of this piping system.

### `T:Autodesk.Revit.DB.Plumbing.PipingSystem`

Member kind: type
Symbol: `Autodesk.Revit.DB.Plumbing.PipingSystem`

#### Summary

A piping system element.

#### Since

2011

### `T:Autodesk.Revit.DB.Plumbing.PipeType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Plumbing.PipeType`

#### Summary

A pipe type element.

### `M:Autodesk.Revit.DB.Plumbing.PipeSettings.SetFlowConvertionServerInfo(Autodesk.Revit.DB.MEPCalculationServerInfo)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipeSettings.SetFlowConvertionServerInfo(Autodesk.Revit.DB.MEPCalculationServerInfo)`

#### Summary

Set the MEPServerInfo of the current plumbing flow convertion server.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Plumbing.PipeSettings.GetFlowConvertionServerInfo`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipeSettings.GetFlowConvertionServerInfo`

#### Summary

Get the MEPServerInfo of the current plumbing flow convertion server.

#### Returns

The MEPServerInfo of the current plumbing flow convertion server.

#### Since

2012

### `M:Autodesk.Revit.DB.Plumbing.PipeSettings.IsValidSpecificFittingAngle(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipeSettings.IsValidSpecificFittingAngle(System.Double)`

#### Summary

Checks that the given value is a valid specific fitting angle. The specific fitting angles are angles of 90, 60, 45, 30, 22.5 or 11.25 degrees.

#### Parameter `angle`

The angle value (in degree).

#### Returns

True if the given value is a valid specific fitting angle.

#### Since

2012

### `M:Autodesk.Revit.DB.Plumbing.PipeSettings.IsAnalysisForClosedLoopHydronicPipingNetworksEnabled(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipeSettings.IsAnalysisForClosedLoopHydronicPipingNetworksEnabled(Autodesk.Revit.DB.Document)`

#### Summary

Indicates whether analysis for closed loop hydronic piping networks is enabled in the specified document.

#### Parameter `ccda`

The document.

#### Returns

Returns true if analysis for closed loop hydronic piping networks is enabled, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Plumbing.PipeSettings.GetSpecificFittingAngleStatus(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipeSettings.GetSpecificFittingAngleStatus(System.Double)`

#### Summary

Gets the status of given specific angle.

#### Parameter `angle`

The specific fitting angle (in degree) that must be one of 90, 60, 45, 30, 22.5 or 11.25 degrees.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for angle must be 90, 60, 45, 30, 22.5 or 11.25 degrees.

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.PipeSettings.SetSpecificFittingAngleStatus(System.Double,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipeSettings.SetSpecificFittingAngleStatus(System.Double,System.Boolean)`

#### Summary

Sets the status of given specific angle.

#### Parameter `angle`

The specific angle (in degree) that must be one of 60, 45, 30, 22.5 or 11.25 degrees.

#### Parameter `bStatus`

Status, true - using the given angle during the pipe layout.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for angle must be 90, 60, 45, 30, 22.5 or 11.25 degrees.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Can not set an angle status for an invalid angle.

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.PipeSettings.GetSpecificFittingAngles`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipeSettings.GetSpecificFittingAngles`

#### Summary

Gets the list of specific fitting angles.

#### Remarks

Revit will only use the angles specified during the pipe layout or modifying the pipe layout.
When laying out the pipes, if the angle between two pipes is close to the allowed angle,
the specific angle is used for that pipe fitting.

#### Returns

Angles (in degrees).

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.PipeSettings.AddPipeSlope(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipeSettings.AddPipeSlope(System.Double)`

#### Summary

Add a pipe slope value.

#### Parameter `slope`

The pipe slope value. Revit stores the slope value as a percentage (0-100).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for slope must be between 0 and 100. Slope value is stored in percentage. e.g. 100 means 100%, and it is 45 degree.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Can not add a pipe slope value that was already added.

#### Since

2012

### `M:Autodesk.Revit.DB.Plumbing.PipeSettings.SetPipeSlopes(System.Collections.Generic.IList{System.Double})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipeSettings.SetPipeSlopes(System.Collections.Generic.IList{System.Double})`

#### Summary

Set pipe slope values.

#### Parameter `slopes`

Pipe slope values. Revit stores the slope value as a percentage (0-100).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Each value of the slopes must be between 0 and 100. Slope value is stored in percentage. e.g. 100 means 100%, and it is 45 degree.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This operation failed.

#### Since

2012

### `M:Autodesk.Revit.DB.Plumbing.PipeSettings.GetPipeSlopes`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipeSettings.GetPipeSlopes`

#### Summary

Get pipe slopes.

#### Returns

Pipe slope values. Revit stores the slope value as a percentage (0-100).

#### Since

2012

### `M:Autodesk.Revit.DB.Plumbing.PipeSettings.GetPipeSettings(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipeSettings.GetPipeSettings(Autodesk.Revit.DB.Document)`

#### Summary

Get the pipe settings of the project.

#### Parameter `document`

The document.

#### Returns

The pipe settings of the project.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.Plumbing.PipeSettings.AnalysisForClosedLoopHydronicPipingNetworks`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeSettings.AnalysisForClosedLoopHydronicPipingNetworks`

#### Summary

Indicates whether to enable analysis for closed loop hydronic piping networks.

#### Remarks

For closed loop hydronic piping networks, Revit can analyze flow and pressure values for supply and return loops. In the model, select a pump to see the results of the analysis in the Properties palette.

A closed loop hydronic piping network must contain:

A single pump/circulator

A single source, such as a boiler

Multiple piping segments

Multiple terminals, such as radiators.

A network may contain a direct return loop or a reverse return loop.

#### Since

2018

### `P:Autodesk.Revit.DB.Plumbing.PipeSettings.UseAnnotationScaleForSingleLineFittings`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeSettings.UseAnnotationScaleForSingleLineFittings`

#### Summary

Indicates whether use annotation scale for single line fittings or not.

#### Since

2012

### `P:Autodesk.Revit.DB.Plumbing.PipeSettings.FittingAnnotationSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeSettings.FittingAnnotationSize`

#### Summary

The value of fitting annotation size.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for dValue must be no more than 30000 feet in absolute value.

#### Since

2012

### `P:Autodesk.Revit.DB.Plumbing.PipeSettings.ConnectorTolerance`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeSettings.ConnectorTolerance`

#### Summary

The connector tolerance value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for dValue is not finite

#### Since

2012

### `P:Autodesk.Revit.DB.Plumbing.PipeSettings.ConnectorSeparator`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeSettings.ConnectorSeparator`

#### Summary

The connector separator string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.Plumbing.PipeSettings.SizePrefix`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeSettings.SizePrefix`

#### Summary

The size prefix string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.Plumbing.PipeSettings.SizeSuffix`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeSettings.SizeSuffix`

#### Summary

The size suffix string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.Plumbing.PipeSettings.FittingAngleUsage`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeSettings.FittingAngleUsage`

#### Summary

Determine how to use fitting angle during pipe layout or modifying layout.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for fittingAngleUsage doesn't support in piping.
-or-
When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.PipeSettings.Centerline`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeSettings.Centerline`

#### Summary

The abbreviation of the Centerline (=) string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.Plumbing.PipeSettings.SetDownFromBottom`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeSettings.SetDownFromBottom`

#### Summary

The abbreviation of the Set Down from bottom of fitting (SDB) string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2019

### `P:Autodesk.Revit.DB.Plumbing.PipeSettings.SetUpFromBottom`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeSettings.SetUpFromBottom`

#### Summary

The abbreviation of the Set Up from bottom of fitting(SUB) string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2019

### `P:Autodesk.Revit.DB.Plumbing.PipeSettings.SetDown`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeSettings.SetDown`

#### Summary

The abbreviation of the Set Down (SD) string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.Plumbing.PipeSettings.SetUp`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeSettings.SetUp`

#### Summary

The abbreviation of the Set Up (SU) string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.Plumbing.PipeSettings.FlatOnBottom`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeSettings.FlatOnBottom`

#### Summary

The abbreviation of the Flat On Bottom (FOB) string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.Plumbing.PipeSettings.FlatOnTop`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeSettings.FlatOnTop`

#### Summary

The abbreviation of the Flat On Top (FOT) string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `T:Autodesk.Revit.DB.Plumbing.PipeSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.Plumbing.PipeSettings`

#### Summary

The pipe setting class.

#### Since

2012

### `M:Autodesk.Revit.DB.Plumbing.PipeScheduleType.GetPipeScheduleId(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipeScheduleType.GetPipeScheduleId(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Returns an existing pipe schedule type with the same name.

#### Parameter `doc`

The document

#### Parameter `name`

The name of requested schedule type.

#### Returns

Returns the element id of request schedule type, or invalidElementId if the name is not found.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Plumbing.PipeScheduleType.Create(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipeScheduleType.Create(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Creates a new pipe schedule type with the given name.

#### Remarks

If the name is already taken by an existing schedule type, an InvalidOperationException will be thrown.

#### Parameter `doc`

The document

#### Parameter `name`

The name of requested schedule type.

#### Returns

Returns the newly created schedule type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

name is an empty string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The name is already taken by an existing pipe schedule type.

#### Since

2017

### `T:Autodesk.Revit.DB.Plumbing.PipeScheduleType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Plumbing.PipeScheduleType`

#### Summary

Represents a pipe schedule type in the Autodesk Revit MEP product.

### `T:Autodesk.Revit.DB.Plumbing.PipeInsulationType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Plumbing.PipeInsulationType`

#### Summary

This class represents a pipe insulation type in Autodesk Revit.

#### Since

2012

### `M:Autodesk.Revit.DB.Plumbing.PipeInsulation.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipeInsulation.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Double)`

#### Summary

Creates a new instance of pipe insulation.

#### Parameter `document`

The document.

#### Parameter `pipeOrContentElementId`

The pipe, fitting, accessory ElementId to which insulation will be added.

#### Parameter `pipeInsulationTypeId`

The pipe insulation type.
If the input pipe insulation type is InvalidElementId, the default insulation type from the document will be used.

#### Parameter `Thickness`

The thickness of the insulation.

#### Returns

The newly created pipe insulation.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This id does not represent a pipe, fitting, or accessory element.
-or-
This pipe insulation type is invalid.
-or-
Thickness is not valid for assignment to insulation or lining elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

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

### `T:Autodesk.Revit.DB.Plumbing.PipeInsulation`

Member kind: type
Symbol: `Autodesk.Revit.DB.Plumbing.PipeInsulation`

#### Summary

Represents insulation applied to the outside of a given pipe, fitting or content.

#### Since

2012

### `M:Autodesk.Revit.DB.Plumbing.PipeSegment.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Collections.Generic.ICollection{Autodesk.Revit.DB.MEPSize})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.PipeSegment.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Collections.Generic.ICollection{Autodesk.Revit.DB.MEPSize})`

#### Summary

Creates a new instance of a PipeSegment and adds it to the document.

#### Parameter `ADocument`

The document where the PipeSegment will be created and added.

#### Parameter `MaterialId`

The ElementId of the MaterialElem of the pipe segment.

#### Parameter `ScheduleId`

The ElementId of the PipeScheduleType of the pipe segment.

#### Parameter `sizeSet`

A set of one or more sizes.

#### Returns

The newly created pipe segment element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The size list is empty.
-or-
The MaterialId and ScheduleId was already used by another pipe segment. Please use a new Material, a new Schedule/Type, or both.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2013

### `P:Autodesk.Revit.DB.Plumbing.PipeSegment.ScheduleTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.PipeSegment.ScheduleTypeId`

#### Summary

The ElementId of the PipeScheduleType.

#### Since

2013

### `T:Autodesk.Revit.DB.Plumbing.PipeSegment`

Member kind: type
Symbol: `Autodesk.Revit.DB.Plumbing.PipeSegment`

#### Summary

The PipeSegment class represents an instance of pipe segment which has the design
data for routing preference.

#### Since

2013

### `M:Autodesk.Revit.DB.Segment.GetSizes`

Member kind: method
Symbol: `Autodesk.Revit.DB.Segment.GetSizes`

#### Summary

Gets the defined sizes of the segment.

#### Since

2013

### `M:Autodesk.Revit.DB.Segment.RemoveSize(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Segment.RemoveSize(System.Double)`

#### Summary

Remove the existing MEPSize with this nominal diameter from the segment.

#### Remarks

Does nothing if there is no existing MEPSize with this nominal diameter.

#### Parameter `nominalDiameter`

The nominal diameter of the size.

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The last size of the segment cannot be removed.

#### Since

2013

### `M:Autodesk.Revit.DB.Segment.AddSize(Autodesk.Revit.DB.MEPSize)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Segment.AddSize(Autodesk.Revit.DB.MEPSize)`

#### Summary

Adds a new MEPSize to the segment.

#### Parameter `size`

The new MEPSize to be added.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

There is already a same size in the settings.
-or-
The size already exists in the segment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2013

### `P:Autodesk.Revit.DB.Segment.SizeCount`

Member kind: property
Symbol: `Autodesk.Revit.DB.Segment.SizeCount`

#### Summary

The number of size objects in the segment.

#### Since

2013

### `P:Autodesk.Revit.DB.Segment.MaterialId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Segment.MaterialId`

#### Summary

The ElementId of the MaterialElem.

#### Since

2013

### `P:Autodesk.Revit.DB.Segment.Roughness`

Member kind: property
Symbol: `Autodesk.Revit.DB.Segment.Roughness`

#### Summary

The roughness value for given material.

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

When setting this property: None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2013

### `P:Autodesk.Revit.DB.Segment.Description`

Member kind: property
Symbol: `Autodesk.Revit.DB.Segment.Description`

#### Summary

The description of the segment.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

When setting this property: None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2013

### `T:Autodesk.Revit.DB.Segment`

Member kind: type
Symbol: `Autodesk.Revit.DB.Segment`

#### Summary

This element represents a segment of an MEP curve object.

#### Remarks

Currently, only pipe curves can be broken into separate segment elements.

#### Since

2013

### `M:Autodesk.Revit.DB.Plumbing.Pipe.IsPipingSystemTypeId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.Pipe.IsPipingSystemTypeId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Checks if given type is valid piping system type.

#### Parameter `document`

The document.

#### Parameter `systemTypeId`

ElementId of the piping system type to check.

#### Returns

True if the given systemTypeId is the piping system type, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.Pipe.IsPipingConnector(Autodesk.Revit.DB.Connector)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.Pipe.IsPipingConnector(Autodesk.Revit.DB.Connector)`

#### Summary

Checks if the given connector is a valid piping connector.

#### Remarks

A connector must be Piping domain type to be connected with other pipes.

#### Parameter `connector`

Connector to check

#### Returns

True if the connector has the Piping domain type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2016

### `M:Autodesk.Revit.DB.Plumbing.Pipe.IsPipeTypeId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.Pipe.IsPipeTypeId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Checks if given type is valid pipe type.

#### Remarks

A type is valid for pipe if it can be used to the pipe element.

#### Parameter `document`

The document.

#### Parameter `pipeTypeId`

ElementId of the pipe type to check.

#### Returns

True if pipe type can used for this pipe, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Plumbing.Pipe.SetSystemType(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.Pipe.SetSystemType(Autodesk.Revit.DB.ElementId)`

#### Summary

Updates the associated system type for the pipe.

#### Remarks

If the pipe previously did not have a system associated to it, this will create a new system.

#### Parameter `systemTypeId`

The ElementId of the piping system type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The systemTypeId is not valid piping system type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2015

### `M:Autodesk.Revit.DB.Plumbing.Pipe.CreatePlaceholder(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.Pipe.CreatePlaceholder(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a new placeholder pipe.

#### Parameter `document`

The document.

#### Parameter `systemTypeId`

The ElementId of the piping system type.

#### Parameter `pipeTypeId`

The ElementId of the pipe type.

#### Parameter `levelId`

The level id for the pipe.

#### Parameter `startPoint`

The first point of the placeholder line.

#### Parameter `endPoint`

The second point of the placeholder line.

#### Returns

The placeholder pipe.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The systemTypeId is not valid piping system type.
-or-
The pipe type pipeTypeId is not valid pipe type.
-or-
The ElementId levelId is not a Level.
-or-
The points of startPoint and endPoint are too close: for MEPCurve, the minimum length is 1/10 inch.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.Pipe.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.Pipe.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Connector)`

#### Summary

Creates a new pipe that connects to two connectors.

#### Remarks

The new pipe will have the same diameter and system type as the start connector. The creation will also connect the new pipe
to two component who owns the specified connectors. If necessary, additional fitting(s) are included to make a valid connection.
If the new pipe can not be connected to the next component (e.g., mismatched direction, no valid fitting, and etc), the new pipe
will still be created at the specified connector position, and an InvalidOperationException is thrown.

#### Parameter `document`

The document.

#### Parameter `pipeTypeId`

The ElementId of the new pipe type.

#### Parameter `levelId`

The level ElementId for the new pipe.

#### Parameter `startConnector`

The first connector where the new pipe starts.

#### Parameter `endConnector`

The second point of the new pipe.

#### Returns

The pipe.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The pipe type pipeTypeId is not valid pipe type.
-or-
The ElementId levelId is not a Level.
-or-
The connector domain is not Domain.Piping.
-or-
The points of startConnector and endConnector are too close: for MEPCurve, the minimum length is 1/10 inch.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the new pipe fails to connect with the connector.

#### Since

2015

### `M:Autodesk.Revit.DB.Plumbing.Pipe.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.Pipe.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a new pipe that connects to the connector.

#### Remarks

The new pipe will have the same diameter and system type as the specified connector. The creation will also connect the new pipe
to the component who owns the specified connector. If necessary, additional fitting(s) are included to make a valid connection.
If the new pipe can not be connected to the next component (e.g., mismatched direction, no valid fitting, and etc), the new pipe
will still be created at the specified connector position, and an InvalidOperationException is thrown.

#### Parameter `document`

The document.

#### Parameter `pipeTypeId`

The ElementId of the new pipe type.

#### Parameter `levelId`

The level id for the new pipe.

#### Parameter `startConnector`

The first connector where the new pipe starts.

#### Parameter `endPoint`

The second point of the new pipe.

#### Returns

The pipe.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The pipe type pipeTypeId is not valid pipe type.
-or-
The ElementId levelId is not a Level.
-or-
The connector domain is not Domain.Piping.
-or-
The points of startConnector and endPoint are too close: for MEPCurve, the minimum length is 1/10 inch.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the new pipe fails to connect with the connector.

#### Since

2015

### `M:Autodesk.Revit.DB.Plumbing.Pipe.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.Pipe.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a new pipe from two points.

#### Parameter `document`

The document.

#### Parameter `systemTypeId`

The ElementId of the piping system type.

#### Parameter `pipeTypeId`

The ElementId of the pipe type.

#### Parameter `levelId`

The level ElementId for the pipe.

#### Parameter `startPoint`

The start point of the pipe.

#### Parameter `endPoint`

The end point of the pipe.

#### Returns

The pipe.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The systemTypeId is not valid piping system type.
-or-
The pipe type pipeTypeId is not valid pipe type.
-or-
The ElementId levelId is not a Level.
-or-
The points of startPoint and endPoint are too close: for MEPCurve, the minimum length is 1/10 inch.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.Pipe.PipeSegment`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.Pipe.PipeSegment`

#### Summary

The pipe segment that was assigned to this pipe according to the routing preference.

#### Since

2017

### `P:Autodesk.Revit.DB.Plumbing.Pipe.IsPlaceholder`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.Pipe.IsPlaceholder`

#### Summary

Identifies if the pipe is a placeholder or not.

### `P:Autodesk.Revit.DB.Plumbing.Pipe.PipeType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.Pipe.PipeType`

#### Summary

The pipe type of this pipe.

### `P:Autodesk.Revit.DB.Plumbing.Pipe.FlowState`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.Pipe.FlowState`

#### Summary

The flow state of the pipe.

### `T:Autodesk.Revit.DB.Plumbing.Pipe`

Member kind: type
Symbol: `Autodesk.Revit.DB.Plumbing.Pipe`

#### Summary

A pipe in the Autodesk Revit MEP product.

#### Remarks

The pipe is only available in the Autodesk Revit MEP product.

### `M:Autodesk.Revit.DB.Mechanical.MechanicalSystemType.ValidateRiseDropSymbolType(Autodesk.Revit.DB.Mechanical.RiseDropSymbol)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalSystemType.ValidateRiseDropSymbolType(Autodesk.Revit.DB.Mechanical.RiseDropSymbol)`

#### Summary

Confirms if the parameter is a valid HVAC rise/drop symbol type.

#### Parameter `risedropType`

The type.

#### Returns

True if the input is a valid HVAC rise/drop symbol type, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `M:Autodesk.Revit.DB.Mechanical.MechanicalSystemType.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.MEPSystemClassification,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalSystemType.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.MEPSystemClassification,System.String)`

#### Summary

Creates a new instance of a mechanical system type and adds it to the document.

#### Parameter `ADoc`

The document where the element will be created and added.

#### Parameter `systemClassification`

The classification for the mechanical system type to be created

#### Parameter `name`

The name of the mechanical system type to be created.

#### Returns

The newly created mechanical system type element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

The system classification is not valid for the domain of this system type.

#### Since

2012

### `P:Autodesk.Revit.DB.Mechanical.MechanicalSystemType.RiseDropSettings`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalSystemType.RiseDropSettings`

#### Summary

indicates the rise/drop symbol given the system type

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The input is not a valid HVAC rise/drop symbol type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `T:Autodesk.Revit.DB.Mechanical.MechanicalSystemType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalSystemType`

#### Summary

Base class for duct system types

#### Since

2012

### `M:Autodesk.Revit.DB.Mechanical.MechanicalSystem.GetStaticPressure`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalSystem.GetStaticPressure`

#### Summary

Gets the static pressure of this mechanical system.

#### Remarks

The system static pressure is calculated in the non-blocking evaluation framework. The caller may set up callbacks that react to the asynchronous calculation results.
If no callback is set up (e.g, called from third-party applications), the calculation is automatically switched to synchronous calculation so the caller
can access the up-to-date result. Similarly, the public method get_ParameterValue(BuiltInParameter.RBS_DUCT_STATIC_PRESSURE) has the same behavior. Due to this
change, the parameter RBS_DUCT_STATIC_PRESSURE no longer supports dynamic model update.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The static pressure can not be calculated for this system.

#### Since

2017

### `M:Autodesk.Revit.DB.Mechanical.MechanicalSystem.GetFlow`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalSystem.GetFlow`

#### Summary

Gets the flow of this mechanical system.

#### Remarks

The system flow is calculated in the non-blocking evaluation framework. The caller may set up callbacks that react to the asynchronous calculation results.
If no callback is set up (e.g, called from third-party applications), the calculation is automatically switched to synchronous calculation so the caller
can access the up-to-date result. Similarly, the public method get_ParameterValue(BuiltInParameter.RBS_DUCT_FLOW_PARAM) has the same behavior. Due to this
change, the parameter RBS_DUCT_FLOW_PARAM no longer supports dynamic model update.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The flow can not be calculated for this system.

#### Since

2017

### `M:Autodesk.Revit.DB.Mechanical.MechanicalSystem.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalSystem.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.String)`

#### Summary

Creates a new instance of a mechanical system and adds it to the document.

#### Parameter `ADocument`

The document where the element will be created and added.

#### Parameter `typeId`

The identifier of this mechanical system element's type.

#### Parameter `name`

The name of the mechanical system to be created.

#### Returns

The newly created mechanical system element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The typeId is not an element id for a valid mechanical system type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2011

### `M:Autodesk.Revit.DB.Mechanical.MechanicalSystem.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalSystem.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new instance of a mechanical system and adds it to the document.

#### Parameter `ADocument`

The document where the element will be created and added.

#### Parameter `typeId`

The identifier of this mechanical system element's type.

#### Returns

The newly created mechanical system element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The typeId is not an element id for a valid mechanical system type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2011

### `M:Autodesk.Revit.DB.Mechanical.MechanicalSystem.IsPressureDropServerMissing`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalSystem.IsPressureDropServerMissing`

#### Summary

Indicates if any pressure drop server which was used in the mechanical system is not available.

#### Returns

True if there is any pressure drop server not available, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.MechanicalSystem.IsWellConnected`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalSystem.IsWellConnected`

#### Summary

Indicates if the system is well connected or not.

#### Remarks

If the system is not well connected, parameters which need to be calculated are invalid.

#### Since

2011

### `P:Autodesk.Revit.DB.Mechanical.MechanicalSystem.DuctNetwork`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalSystem.DuctNetwork`

#### Summary

The ducts and fittings contained within the system.

#### Remarks

The return value doesn't include terminals or equipments, the ducts and fittings are returned in no particular order.

### `P:Autodesk.Revit.DB.Mechanical.MechanicalSystem.BaseEquipmentConnector`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalSystem.BaseEquipmentConnector`

#### Summary

The connector within the base equipment which is used to connect with the system.

#### Remarks

Assigning `null` to the base equipment connector will disconnect the base equipment from the system.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when assigning a connector which is used in a system,
or when the connector's owner is not of type 'mechanical equipment'.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the set operation failed.

#### Remarks

Setting this property will regenerate the document even in manual regeneration mode.

### `P:Autodesk.Revit.DB.Mechanical.MechanicalSystem.SystemType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalSystem.SystemType`

#### Summary

The type of this duct system.

### `T:Autodesk.Revit.DB.Mechanical.MechanicalSystem`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.MechanicalSystem`

#### Summary

A mechanical system element.

#### Since

2011

### `M:Autodesk.Revit.DB.Plumbing.FluidType.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.FluidType.GetEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.Plumbing.FluidType.GetBasicIEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.FluidType.GetBasicIEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.Plumbing.FluidType.GetFluidTypeIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.FluidType.GetFluidTypeIterator`

#### Summary

Gets the FluidTemperatureSetIterator to the fluid type.

#### Returns

The FluidTemperatureSetIterator to the fluid type.

#### Since

2013

### `M:Autodesk.Revit.DB.Plumbing.FluidType.RemoveTemperature(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.FluidType.RemoveTemperature(System.Double)`

#### Summary

Removes a fluid temperature via the temperature value from the set.

#### Parameter `temperature`

The temperature value.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the temperature that will be removed doesn't exist in the fluid type
or the temperature that will be removed is in use.

#### Since

2013

### `M:Autodesk.Revit.DB.Plumbing.FluidType.AddTemperature(Autodesk.Revit.DB.Plumbing.FluidTemperature)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.FluidType.AddTemperature(Autodesk.Revit.DB.Plumbing.FluidTemperature)`

#### Summary

Adds a fluid temperature to the set.

#### Parameter `fluidTemperature`

The fluid temperature being inserted.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if the temperature that will be added already exists in the fluid type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Plumbing.FluidType.GetTemperature(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.FluidType.GetTemperature(System.Double)`

#### Summary

Gets a copy of the FluidTemperature object matching a given temperature value.

#### Remarks

Changes made to this object will not be applied to the FluidType object.
In order to modify the FluidTemperature settings for a given temperature,
you should remove the existing FluidTemperature (RemoveTemperature()) and then add the modified value (AddTemperature()).

#### Parameter `temperature`

The temperature value.

#### Returns

The fluid temperature. `null` if not found.

#### Since

2013

### `M:Autodesk.Revit.DB.Plumbing.FluidType.ClearAllTemperatures`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.FluidType.ClearAllTemperatures`

#### Summary

Clears all fluid temperatures in the set.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown if some temperatures in the FluidType object are in use.

#### Since

2013

### `M:Autodesk.Revit.DB.Plumbing.FluidType.IsFluidInUse(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.FluidType.IsFluidInUse(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Identifies if the fluid type is in use.

#### Remarks

If a fluid type is in use, it cannot be deleted.

#### Parameter `document`

The document.

#### Parameter `fluidId`

The id of the fluid type.

#### Returns

True if the fluid type is in use.
False if the fluid type is not in use.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Plumbing.FluidType.GetFluidType(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.FluidType.GetFluidType(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Gets a fluid type by name.

#### Parameter `document`

The document.

#### Parameter `fluidTypeName`

The name of fluid type.

#### Returns

The fluid type. `null` if the fluid type was not found.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Plumbing.FluidType.Create(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.Plumbing.FluidType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.FluidType.Create(Autodesk.Revit.DB.Document,System.String,Autodesk.Revit.DB.Plumbing.FluidType)`

#### Summary

Creates a new fluid type and adds it to the document.

#### Remarks

The new fluid type will be a duplicate of the input type.

#### Parameter `document`

The document.

#### Parameter `fluidTypeName`

The name of new created fluid type.

#### Parameter `basedOnFluidType`

The existing fluid type which is based on.

#### Returns

The newly created fluid type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Plumbing.FluidType.Create(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.FluidType.Create(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Creates a new empty fluid type and adds it to the document.

#### Parameter `document`

The document.

#### Parameter `fluidTypeName`

The name of fluid type.

#### Returns

The newly created fluid type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Plumbing.FluidType.GetFluidTemperatureSetIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.FluidType.GetFluidTemperatureSetIterator`

#### Summary

Returns a FluidTemperatureSetIterator that iterates through the collection.

#### Returns

A FluidTemperatureSetIterator object that can be used to iterate through key-value pairs in the collection.

### `T:Autodesk.Revit.DB.Plumbing.FluidType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Plumbing.FluidType`

#### Summary

Has been extended to provide read and write access to a collection of FluidTemperature objects which represent the fluid's properties at various temperatures.

#### Since

2013

### `P:Autodesk.Revit.DB.Plumbing.FluidTemperature.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.FluidTemperature.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.FluidTemperature.Density`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.FluidTemperature.Density`

#### Summary

The density value

#### Since

2013

### `P:Autodesk.Revit.DB.Plumbing.FluidTemperature.Viscosity`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.FluidTemperature.Viscosity`

#### Summary

The dynamic viscosity value

#### Since

2013

### `P:Autodesk.Revit.DB.Plumbing.FluidTemperature.Temperature`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.FluidTemperature.Temperature`

#### Summary

The temperature value

#### Since

2013

### `M:Autodesk.Revit.DB.Plumbing.FluidTemperature.#ctor(System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.FluidTemperature.#ctor(System.Double,System.Double,System.Double)`

#### Summary

Creates a new fluid temperature with given temperature, dynamic viscosity and density.

#### Parameter `temperature`

The temperature value.

#### Parameter `viscosity`

The dynamic viscosity value.

#### Parameter `density`

The density value.

#### Since

2013

### `T:Autodesk.Revit.DB.Plumbing.FluidTemperature`

Member kind: type
Symbol: `Autodesk.Revit.DB.Plumbing.FluidTemperature`

#### Summary

Represents the dynamic viscosity and density properties as defined at a certain temperature.

#### Since

2013

### `P:Autodesk.Revit.DB.Plumbing.FluidTemperatureSetIterator.CurrentObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.FluidTemperatureSetIterator.CurrentObject`

### `P:Autodesk.Revit.DB.Plumbing.FluidTemperatureSetIterator.Current`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.FluidTemperatureSetIterator.Current`

#### Summary

Gets the item at the current position of the iterator.

#### Remarks

There is no current item if the iterator has not started yet or has been done.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no current item in the iterator.

### `M:Autodesk.Revit.DB.Plumbing.FluidTemperatureSetIterator.GetCurrent`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.FluidTemperatureSetIterator.GetCurrent`

#### Summary

Returns the current FluidTemperature.

#### Returns

The current FluidTemperature.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no current item in the iterator.

#### Since

2013

### `M:Autodesk.Revit.DB.Plumbing.FluidTemperatureSetIterator.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.FluidTemperatureSetIterator.Reset`

#### Summary

Resets the iterator to the initial state.

#### Since

2013

### `M:Autodesk.Revit.DB.Plumbing.FluidTemperatureSetIterator.IsDone`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.FluidTemperatureSetIterator.IsDone`

#### Summary

Identifies if the iteration has completed.

#### Returns

True if the iteration has no more items. False if there are more items to be iterated.

#### Since

2013

### `M:Autodesk.Revit.DB.Plumbing.FluidTemperatureSetIterator.MoveNext`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.FluidTemperatureSetIterator.MoveNext`

#### Summary

Increments the iterator to the next item.

#### Returns

True if there is a next available item in this iterator.
False if the iterator has completed all available items.

#### Since

2013

### `P:Autodesk.Revit.DB.Plumbing.FluidTemperatureSetIterator.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.FluidTemperatureSetIterator.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Plumbing.FluidTemperatureSetIterator`

Member kind: type
Symbol: `Autodesk.Revit.DB.Plumbing.FluidTemperatureSetIterator`

#### Summary

An iterator to a set of FluidTemperature from FluidType.

#### Since

2013

### `M:Autodesk.Revit.DB.Plumbing.FlexPipe.IsPipingSystemTypeId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.FlexPipe.IsPipingSystemTypeId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Checks if given type is valid piping system type.

#### Parameter `document`

The document.

#### Parameter `systemTypeId`

ElementId of the piping system type to check.

#### Returns

True if the given systemTypeId is the piping system type, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.FlexPipe.IsFlexPipeTypeId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.FlexPipe.IsFlexPipeTypeId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Checks if given type is valid flexible pipe type.

#### Remarks

A type is valid for flexible pipe if it can be used to the flexible pipe element.

#### Parameter `document`

The document.

#### Parameter `pipeTypeId`

ElementId of the flexible pipe type to check.

#### Returns

True if flexible pipe type can used for this pipe, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.FlexPipe.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.FlexPipe.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

#### Summary

Creates a new flexible pipe into the document, using a point array and flex pipe type.

#### Parameter `document`

The document.

#### Parameter `systemTypeId`

The id of the piping system type.

#### Parameter `pipeTypeId`

The id of the flexible pipe.

#### Parameter `levelId`

The level id for the flexible pipe.

#### Parameter `startTangent`

The tangent vector at the start of the curve. The invalid or zero vector is ignored.

#### Parameter `endTangent`

The tangent vector at the end of the curve. The invalid or zero vector is ignored.

#### Parameter `points`

The point array indicating the path of the flexible pipe, including the end point.

#### Returns

If creation was successful then a new flexible pipe is returned, otherwise an exception with failure information will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The systemTypeId is not valid piping system type.
-or-
The type pipeTypeId is not valid flexible pipe type.
-or-
The ElementId levelId is not a Level.
-or-
The valid number of points is less than two. In order to create a flex curve, at least two points are required. Note the duplicate points don't take into account.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2014

### `M:Autodesk.Revit.DB.Plumbing.FlexPipe.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Plumbing.FlexPipe.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

#### Summary

Creates a new flexible pipe into the document, using a point array and flex pipe type.

#### Parameter `document`

The document.

#### Parameter `systemTypeId`

The id of the piping system type.

#### Parameter `pipeTypeId`

The id of the flexible pipe.

#### Parameter `levelId`

The level id for the flexible pipe.

#### Parameter `points`

The point array indicating the path of the flexible pipe, including the end point.

#### Returns

If creation was successful then a new flexible pipe is returned, otherwise an exception with failure information will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The systemTypeId is not valid piping system type.
-or-
The type pipeTypeId is not valid flexible pipe type.
-or-
The ElementId levelId is not a Level.
-or-
The valid number of points is less than two. In order to create a flex curve, at least two points are required. Note the duplicate points don't take into account.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.FlexPipe.EndTangent`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.FlexPipe.EndTangent`

#### Summary

Gets or sets the tangent vector at the end of the curve. The invalid or zero vector is ignored when setting the tangent.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.FlexPipe.StartTangent`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.FlexPipe.StartTangent`

#### Summary

Gets or sets the tangent vector at the start of the curve. The invalid or zero vector is ignored when setting the tangent.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.Plumbing.FlexPipe.Points`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.FlexPipe.Points`

#### Summary

The points of the flex pipe.

#### Remarks

This property is used to retrieve the points of flex pipe, including the end points.
If the end points are changed, the connection will be maintained by Revit automatically.
The set operation will fail if the modification makes the connection invalid.

### `P:Autodesk.Revit.DB.Plumbing.FlexPipe.FlexPipeType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.FlexPipe.FlexPipeType`

#### Summary

The flex pipe type of this flex pipe.

### `P:Autodesk.Revit.DB.Plumbing.FlexPipe.FlowState`

Member kind: property
Symbol: `Autodesk.Revit.DB.Plumbing.FlexPipe.FlowState`

#### Summary

The flow state of the pipe.

### `T:Autodesk.Revit.DB.Plumbing.FlexPipe`

Member kind: type
Symbol: `Autodesk.Revit.DB.Plumbing.FlexPipe`

#### Summary

A flex pipe in the Autodesk Revit MEP product.

#### Remarks

The flex pipe is only available in the Autodesk Revit MEP product.

### `M:Autodesk.Revit.DB.Mechanical.FlexDuct.IsHVACSystemTypeId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.FlexDuct.IsHVACSystemTypeId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Checks if given type is valid HVAC system type.

#### Parameter `document`

The document.

#### Parameter `systemTypeId`

ElementId of the HVAC system type to check.

#### Returns

True if the given systemTypeId is the HVAC system type, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.Mechanical.FlexDuct.IsFlexDuctTypeId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.FlexDuct.IsFlexDuctTypeId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Checks if given type is valid flexible duct type.

#### Remarks

A type is valid for flexible duct if it can be used to the flexible duct element.

#### Parameter `document`

The document.

#### Parameter `ductTypeId`

ElementId of the flexible duct type to check.

#### Returns

True if flexible duct type can used for this duct, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2014

### `M:Autodesk.Revit.DB.Mechanical.FlexDuct.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.FlexDuct.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

#### Summary

Creates a new flexible duct into the document, using a point array and flexible duct type.

#### Parameter `document`

The document.

#### Parameter `systemTypeId`

The id of the HVAC system type.

#### Parameter `ductTypeId`

The id of the flexible duct.

#### Parameter `levelId`

The level id for the flexible duct.

#### Parameter `startTangent`

The tangent vector at the start of the curve. The invalid or zero vector is ignored.

#### Parameter `endTangent`

The tangent vector at the end of the curve. The invalid or zero vector is ignored.

#### Parameter `points`

The point array indicating the path of the flexible duct, including the end point.

#### Returns

If creation was successful then a new flexible duct is returned, otherwise an exception with failure information will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The systemTypeId is not valid HVAC system type.
-or-
The type ductTypeId is not valid flexible duct type.
-or-
The ElementId levelId is not a Level.
-or-
The valid number of points is less than two. In order to create a flex curve, at least two points are required. Note the duplicate points don't take into account.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2014

### `M:Autodesk.Revit.DB.Mechanical.FlexDuct.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.FlexDuct.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

#### Summary

Creates a new flexible duct into the document, using a point array and flexible duct type.

#### Parameter `document`

The document.

#### Parameter `systemTypeId`

The id of the HVAC system type.

#### Parameter `ductTypeId`

The id of the flexible duct.

#### Parameter `levelId`

The level id for the flexible duct.

#### Parameter `points`

The point array indicating the path of the flexible duct, including the end point.

#### Returns

If creation was successful then a new flexible duct is returned, otherwise an exception with failure information will be thrown.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The systemTypeId is not valid HVAC system type.
-or-
The type ductTypeId is not valid flexible duct type.
-or-
The ElementId levelId is not a Level.
-or-
The valid number of points is less than two. In order to create a flex curve, at least two points are required. Note the duplicate points don't take into account.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.FlexDuct.EndTangent`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.FlexDuct.EndTangent`

#### Summary

Gets or sets the tangent vector at the end of the curve. The invalid or zero vector is ignored when setting the tangent.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.FlexDuct.StartTangent`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.FlexDuct.StartTangent`

#### Summary

Gets or sets the tangent vector at the start of the curve. The invalid or zero vector is ignored when setting the tangent.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2014

### `P:Autodesk.Revit.DB.Mechanical.FlexDuct.FlexDuctType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.FlexDuct.FlexDuctType`

#### Summary

The flex duct type of this flex duct.

### `P:Autodesk.Revit.DB.Mechanical.FlexDuct.Points`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.FlexDuct.Points`

#### Summary

The points of the flex duct.

#### Remarks

This property is used to retrieve the points of flex duct, including the end points.
If the end points are changed, the connection will be maintained by Revit automatically.
The set operation will fail if the modification makes the connection invalid.

### `T:Autodesk.Revit.DB.Mechanical.FlexDuct`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.FlexDuct`

#### Summary

A flex duct in the Autodesk Revit MEP product.

### `M:Autodesk.Revit.DB.Electrical.ElectricalSystem.IsCircuitPathValid(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.IsCircuitPathValid(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

#### Summary

Checks whether the list of the electrical system circuit path node position is valid.

#### Remarks

The length of the list should be more than one, the first node should be the position of the panel where the circuit begins at, the adjacent nodes should not be too close, and should be in the same level or on the same vertical line, to keep each segment of the circuit path always horizontal or vertical.

#### Parameter `nodes`

The list of the electrical system circuit path node position.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Electrical.ElectricalSystem.SetCircuitPath(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.SetCircuitPath(System.Collections.Generic.IList{Autodesk.Revit.DB.XYZ})`

#### Summary

Sets the electrical system circuit path by the list of node position.

#### Remarks

If succeed, it will also change the CircuitPathMode property to Custom mode implicitly.

#### Parameter `nodes`

The list of the circuit path node position.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The list of the electrical system circuit path node position is not valid. The length of the list should be more than one, the first node should be the position of the panel where the circuit begins at, the adjacent nodes should not be too close, and should be in the same level or on the same vertical line, to keep each segment of the circuit path always horizontal or vertical.
Also note that the first node position should be the position of the connector (the one connects to the circuit) of the panel, but not the origin of the panel instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2018

### `M:Autodesk.Revit.DB.Electrical.ElectricalSystem.GetCircuitPath`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.GetCircuitPath`

#### Summary

Gets the list of the electrical system circuit path node position.

#### Returns

The list of the electrical system circuit path node position.

#### Since

2018

### `M:Autodesk.Revit.DB.Electrical.ElectricalSystem.DisconnectPanel`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.DisconnectPanel`

#### Summary

Disconnect the panel for the Electrical System.

#### Remarks

If successful, the system will disconnect this panel. Otherwise the exception will be thrown.
This method will only function with the Autodesk Revit MEP application.

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the panel cannot be disconnected for the electrical system.

#### Since

2011

### `M:Autodesk.Revit.DB.Electrical.ElectricalSystem.SelectPanel(Autodesk.Revit.DB.FamilyInstance)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.SelectPanel(Autodesk.Revit.DB.FamilyInstance)`

#### Summary

Set the panel for the Electrical System.

#### Remarks

If successful, the panel will be set for the system. Otherwise the exception will be thrown.
This method will only function with the Autodesk Revit MEP application.

#### Parameter `panel`

The panel of the electrical system.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The panel does not have enough slots and Feed Through Lugs is unchecked or already in use.
-or-
Thrown when the panel cannot be set for the electrical system.

#### Since

2011

### `M:Autodesk.Revit.DB.Electrical.ElectricalSystem.Create(Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Electrical.ElectricalSystemType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.Create(Autodesk.Revit.DB.Connector,Autodesk.Revit.DB.Electrical.ElectricalSystemType)`

#### Summary

Creates a new MEP Electrical System element from an unused Connector.

#### Parameter `connector`

The Connector to create this Electrical System.

#### Parameter `elecSysType`

The System Type of electrical system.

#### Returns

If successful a new MEP Electrical System element within the project, otherwise `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2018

### `M:Autodesk.Revit.DB.Electrical.ElectricalSystem.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.Electrical.ElectricalSystemType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.Electrical.ElectricalSystemType)`

#### Summary

Creates a new MEP Electrical System element from a set of electrical components.

#### Parameter `document`

The Document.

#### Parameter `electComponents`

The electrical components in this system.

#### Parameter `elecSysType`

The System Type of electrical system.

#### Returns

If successful a new MEP Electrical System element within the project, otherwise `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

There should be at least one component that can create the specified circuit type

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2018

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.CircuitConnectionType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.CircuitConnectionType`

#### Summary

The circuit connection type of the electrical system.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

When setting this property: None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The connection type is invalid for this circuit.
You can't assign Feed Through Lugs if the panel's Feed Through Lugs option is unchecked.
If the circuit's base panel is not a data panel or transformer panel, the circuit connection type can't be set to NotApplicable.
If the circuit's base panel is a data panel or transformer pane, it must be set to NotApplicable.
If the circuit doesn't have a base panel, it must be set to NotApplicable.
-or-
When setting this property: Invalid connection type.

#### Since

2020

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.CircuitPathMode`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.CircuitPathMode`

#### Summary

The circuit path mode of the electrical system.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

When setting this property: None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The electrical system circuit path does not have customized path, so the CircuitPathMode cannot be set as Custom.

#### Since

2018

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.HasCustomCircuitPath`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.HasCustomCircuitPath`

#### Summary

Checks whether the electrical system circuit path has been customized. If not, the property CircuitPathMode cannot be set as Custom explicitly.

#### Since

2018

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.IsBasePanelFeedThroughLugsOccupied`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.IsBasePanelFeedThroughLugsOccupied`

#### Summary

Checks if the feed through lugs of the base panel is already occupied.

#### Since

2020

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.PanelName`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.PanelName`

#### Summary

The Panel name of the Electrical System.

#### Remarks

This property is used to retrieve the Panel name of the Electrical System.

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.CircuitType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.CircuitType`

#### Summary

The circuit type of the Electrical System.

#### Remarks

This read-only property is used to retrieve the circuit type of the Electrical System.

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.GroundConductorsNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.GroundConductorsNumber`

#### Summary

The GroundConductors Number of the Electrical System.

#### Remarks

This property is used to retrieve the GroundConductors Number of the Electrical System.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This property only available when System Type is Power!

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.NeutralConductorsNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.NeutralConductorsNumber`

#### Summary

The NeutralConductors Number of the Electrical System.

#### Remarks

This property is used to retrieve the NeutralConductors Number of the Electrical System.

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

When setting this property: None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This property only available when System Type is Power!

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.HotConductorsNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.HotConductorsNumber`

#### Summary

The HotConductors Number of the Electrical System.

#### Remarks

This property is used to retrieve the HotConductors Number of the Electrical System.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This property only available when System Type is Power!

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.RunsNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.RunsNumber`

#### Summary

The Runs Number of the Electrical System.

#### Remarks

This property is used to retrieve the Runs Number of the Electrical System.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This property only available when System Type is Power!

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.BalancedLoad`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.BalancedLoad`

#### Summary

Reports whether the BalancedLoad is on or off.

#### Remarks

This property is used to retrieve the BalancedLoad value of the Electrical System.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This property only available when System Type is Power!

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.PolesNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.PolesNumber`

#### Summary

The Poles Number of the Electrical System.

#### Remarks

This property is used to retrieve the Poles Number of the Electrical System.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This property only available when System Type is Power!

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.Ways`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.Ways`

#### Summary

The circuit ways used in the Electrical System.

#### Remarks

This property is used to retrieve the ways of the Electrical System on a panel.

#### Since

2021

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.PhaseLabel`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.PhaseLabel`

#### Summary

The circuit phase label used in the Electrical System.

#### Remarks

This property is used to retrieve the phase label of the Electrical System on a panel.

#### Since

2021

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.LoadClassificationAbbreviations`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.LoadClassificationAbbreviations`

#### Summary

The LoadClassification Abbreviations used in the Electrical System.

#### Remarks

This property is used to retrieve the LoadClassification Abbreviations of the Electrical System.
There may be one or more load classification in use in which case they will be semi-colon delimited.

#### Since

2021

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.LoadClassifications`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.LoadClassifications`

#### Summary

The LoadClassifications used in the Electrical System.

#### Remarks

This property is used to retrieve the LoadClassifications of the Electrical System.
There may be one or more load classification in use in which case they will be semi-colon delimited.

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.PowerFactorState`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.PowerFactorState`

#### Summary

The PowerFactorState type of the Electrical System.

#### Remarks

This property is used to retrieve the PowerFactorState type of the Electrical System.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This property only available when System Type is Power!

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.SystemType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.SystemType`

#### Summary

The Electrical System Type of the Electrical System.

#### Remarks

This property is used to retrieve the Electrical System Type of the Electrical System.

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.VoltageDrop`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.VoltageDrop`

#### Summary

The VoltageDrop value of the Electrical System.

#### Remarks

This property is used to retrieve the VoltageDrop value of the Electrical System.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This property only available when System Type is Power!
-or-
Thrown when the voltage drop cannot be computed, because it is zero, or because the circuit is not connected to a panel.

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.TrueCurrentPhaseC`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.TrueCurrentPhaseC`

#### Summary

The TrueCurrentPhaseC value of the Electrical System.

#### Remarks

This property is used to retrieve the TrueCurrentPhaseC value of the Electrical System.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This property only available when System Type is Power!

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.TrueCurrentPhaseB`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.TrueCurrentPhaseB`

#### Summary

The TrueCurrentPhaseB value of the Electrical System.

#### Remarks

This property is used to retrieve the TrueCurrentPhaseB value of the Electrical System.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This property only available when System Type is Power!

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.TrueCurrentPhaseA`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.TrueCurrentPhaseA`

#### Summary

The TrueCurrentPhaseA value of the Electrical System.

#### Remarks

This property is used to retrieve the TrueCurrentPhaseA value of the Electrical System.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This property only available when System Type is Power!

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.TrueCurrent`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.TrueCurrent`

#### Summary

The TrueCurrent value of the Electrical System.

#### Remarks

This property is used to retrieve the TrueCurrent value of the Electrical System.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This property only available when System Type is Power!

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.ApparentCurrentPhaseC`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.ApparentCurrentPhaseC`

#### Summary

The ApparentCurrentPhaseC value of the Electrical System.

#### Remarks

This property is used to retrieve the ApparentCurrentPhaseC value of the Electrical System.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This property only available when System Type is Power!

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.ApparentCurrentPhaseB`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.ApparentCurrentPhaseB`

#### Summary

The ApparentCurrentPhaseB value of the Electrical System.

#### Remarks

This property is used to retrieve the ApparentCurrentPhaseB value of the Electrical System.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This property only available when System Type is Power!

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.ApparentCurrentPhaseA`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.ApparentCurrentPhaseA`

#### Summary

The ApparentCurrentPhaseA value of the Electrical System.

#### Remarks

This property is used to retrieve the ApparentCurrentPhaseA value of the Electrical System.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This property only available when System Type is Power!

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.ApparentCurrent`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.ApparentCurrent`

#### Summary

The ApparentCurrent value of the Electrical System.

#### Remarks

This property is used to retrieve the ApparentCurrent value of the Electrical System.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This property only available when System Type is Power!

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.Length`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.Length`

#### Summary

The Length value of the Electrical System.

#### Remarks

This property is used to retrieve the Length value of the Electrical System.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the length cannot be computed, because it is zero, or because the circuit is not connected to a panel.

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.Frame`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.Frame`

#### Summary

The Frame value of the Electrical System.

#### Remarks

This property is used to retrieve the Frame value of the Electrical System.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for frame is not a number
-or-
When setting this property: The given value for frame is not finite

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for frame must be non-negative.

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

When setting this property: None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This property only available when System Type is Power and Circuit Type is NOT Space!

#### Since

2021

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.HasPathOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.HasPathOffset`

#### Summary

Whether the circuit path has a valid offset.

#### Remarks

Circuit path of AllDevices and Custom mode may not have valid offset if the horizontal segments of the path are not at the same height.

#### Since

2018

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.PathOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.PathOffset`

#### Summary

The offset of the horizontal segments of the circuit path.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for pathOffset must be no more than 30000 feet in absolute value.

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

When setting this property: None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2018

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.Rating`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.Rating`

#### Summary

The Rating value of the Electrical System.

#### Remarks

This property is used to retrieve the Rating value of the Electrical System.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The given value for rating is not a number
-or-
When setting this property: The given value for rating is not finite

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for rating must be non-negative.

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

When setting this property: None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This property only available when System Type is Power!

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.TrueLoadPhaseC`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.TrueLoadPhaseC`

#### Summary

The TrueLoadPhaseC value of the Electrical System.

#### Remarks

This property is used to retrieve the TrueLoadPhaseC value of the Electrical System.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This property only available when System Type is Power!

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.TrueLoadPhaseB`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.TrueLoadPhaseB`

#### Summary

The TrueLoadPhaseB value of the Electrical System.

#### Remarks

This property is used to retrieve the TrueLoadPhaseB value of the Electrical System.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This property only available when System Type is Power!

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.TrueLoadPhaseA`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.TrueLoadPhaseA`

#### Summary

The TrueLoadPhaseA value of the Electrical System.

#### Remarks

This property is used to retrieve the TrueLoadPhaseA value of the Electrical System.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This property only available when System Type is Power!

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.TrueLoad`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.TrueLoad`

#### Summary

The TrueLoad value of the Electrical System.

#### Remarks

This property is used to retrieve the TrueLoad value of the Electrical System.

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

When setting this property: None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This property only available when System Type is Power!

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.PowerFactor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.PowerFactor`

#### Summary

The PowerFactor value of the Electrical System.

#### Remarks

This property is used to retrieve the PowerFactor value of the Electrical System.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This property only available when System Type is Power!

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.ApparentLoadPhaseC`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.ApparentLoadPhaseC`

#### Summary

The ApparentLoadPhaseC value of the Electrical System.

#### Remarks

This property is used to retrieve the ApparentLoadPhaseC value of the Electrical System.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This property only available when System Type is Power!

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.ApparentLoadPhaseB`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.ApparentLoadPhaseB`

#### Summary

The ApparentLoadPhaseB value of the Electrical System.

#### Remarks

This property is used to retrieve the ApparentLoadPhaseB value of the Electrical System.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This property only available when System Type is Power!

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.ApparentLoadPhaseA`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.ApparentLoadPhaseA`

#### Summary

The ApparentLoadPhaseA value of the Electrical System.

#### Remarks

This property is used to retrieve the ApparentLoadPhaseA value of the Electrical System.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This property only available when System Type is Power!

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.ApparentLoad`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.ApparentLoad`

#### Summary

The ApparentLoad value of the Electrical System.

#### Remarks

This property is used to retrieve the ApparentLoad value of the Electrical System.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This property only available when System Type is Power!

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.Voltage`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.Voltage`

#### Summary

The Voltage value of the Electrical System.

#### Remarks

This property is used to retrieve the Voltage value of the Electrical System.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This property only available when System Type is Power!

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.WireSizeString`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.WireSizeString`

#### Summary

The WireSize as a String of the Electrical System

#### Remarks

This property is used to retrieve the WireSize String of the Electrical System.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This property only available when System Type is Power!

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.LoadName`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.LoadName`

#### Summary

The LoadName of the Electrical System.

#### Remarks

This property is used to retrieve the LoadName of the Electrical System.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

When setting this property: None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.WireType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.WireType`

#### Summary

The wire type of the Electrical System.

#### Remarks

This property is used to retrieve the wire type of the Electrical System.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.DisabledDisciplineException`

When setting this property: None of the following disciplines is enabled: Mechanical Electrical Piping.

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.SlotIndex`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.SlotIndex`

#### Summary

The Slots where the Electrical System is located in its panel.

#### Remarks

This property is used to retrieve the slots of the Electrical System.
There may be one or more slot in use in which case they will be comma delimited.

#### Since

2021

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.StartSlot`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.StartSlot`

#### Summary

The Start Slot where the Electrical System is located in its panel.

#### Remarks

This property is used to retrieve the Start Slot of the Electrical System.

#### Since

2011

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.CircuitNamingIndex`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.CircuitNamingIndex`

#### Summary

The Circuit Naming Index where the Electrical System is located in its panel.
The Circuit Naming Index is used to retrieve the Circuit Naming Index of the Electrical System.

#### Since

2021

### `P:Autodesk.Revit.DB.Electrical.ElectricalSystem.CircuitNumber`

Member kind: property
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.CircuitNumber`

#### Summary

The CircuitNumber of the Electrical System.

#### Remarks

This property is used to retrieve the CircuitNumber of the Electrical System.

#### Since

2011

### `M:Autodesk.Revit.DB.Electrical.ElectricalSystem.NewWires(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Electrical.WiringType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.NewWires(Autodesk.Revit.DB.View,Autodesk.Revit.DB.Electrical.WiringType)`

#### Summary

Create a bunch of wires for the electrical system.

#### Parameter `view`

The view in which the wire is to be visible.

#### Parameter `wiringType`

Specify the wiring type (Arc or Chamfer) that is to be applied to all newly created wires.

#### Returns

New created wires

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This method can only be used to create a bunch of wires according to specific pairs of elements,
so if there exists a `null` element in any pair of familyInstancePairs, the exception will be thrown.

### `M:Autodesk.Revit.DB.Electrical.ElectricalSystem.RemoveFromCircuit(Autodesk.Revit.DB.ElementSet)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.RemoveFromCircuit(Autodesk.Revit.DB.ElementSet)`

#### Summary

remove a set of exist components from the Electrical System.

#### Parameter `components`

The components removed from the electrical system.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the components parameter Value is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the components cannot be removed from the system.

#### Remarks

If successful, all the components will remove from the system. Otherwise `null` is removed.
This method will only function with the Autodesk Revit MEP application.

### `M:Autodesk.Revit.DB.Electrical.ElectricalSystem.AddToCircuit(Autodesk.Revit.DB.ElementSet)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem.AddToCircuit(Autodesk.Revit.DB.ElementSet)`

#### Summary

Add a set of exist components to the Electrical System.

#### Parameter `components`

The components added to the electrical system.

#### Returns

If successful, all the components will add to the system. Otherwise `null` is returned.

#### Remarks

This method will only function with the
Autodesk Revit MEP application.

### `T:Autodesk.Revit.DB.Electrical.ElectricalSystem`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalSystem`

#### Summary

Provides access to the Electrical System in Autodesk Revit MEP.

#### Remarks

The Electrical System object can only be queried in Autodesk Revit MEP.

#### Since

2011

### `T:Autodesk.Revit.DB.Electrical.ElectricalCircuitPathMode`

Member kind: type
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalCircuitPathMode`

#### Summary

An enumerated type indicates the circuit path mode

#### Since

2018

### `F:Autodesk.Revit.DB.Electrical.ElectricalCircuitPathMode.AllDevices`

Member kind: field
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalCircuitPathMode.AllDevices`

#### Summary

The circuit path connects to all the devices in the circuits, this mode is compatible to the legacy behavior.

### `F:Autodesk.Revit.DB.Electrical.ElectricalCircuitPathMode.FarthestDevice`

Member kind: field
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalCircuitPathMode.FarthestDevice`

#### Summary

The circuit path connects to the farthest devices.

### `F:Autodesk.Revit.DB.Electrical.ElectricalCircuitPathMode.Custom`

Member kind: field
Symbol: `Autodesk.Revit.DB.Electrical.ElectricalCircuitPathMode.Custom`

#### Summary

The circuit path is customized by user.

### `M:Autodesk.Revit.DB.MEPSystem.DivideSystem(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MEPSystem.DivideSystem(Autodesk.Revit.DB.Document)`

#### Summary

Divide the phyisical networks in the system and create a new system for each network.

#### Remarks

This function only works for Hvac and Piping system.

#### Parameter `ADoc`

The document.

#### Returns

The id of new created systems.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The system is not dividable.

#### Since

2014

### `M:Autodesk.Revit.DB.MEPSystem.GetPhysicalNetworksNumber`

Member kind: method
Symbol: `Autodesk.Revit.DB.MEPSystem.GetPhysicalNetworksNumber`

#### Summary

Get the physical networks number in the system.

#### Returns

The number of physical networks.

#### Since

2014

### `M:Autodesk.Revit.DB.MEPSystem.IsSystemDividable`

Member kind: method
Symbol: `Autodesk.Revit.DB.MEPSystem.IsSystemDividable`

#### Summary

Checks if the system is dividable. The system is dividable if there is more than one physical network in the system. Currently, only HVAC and piping systems support dividing.

#### Returns

True if the system can be divided.

#### Since

2014

### `M:Autodesk.Revit.DB.MEPSystem.GetCriticalPathSectionNumbers`

Member kind: method
Symbol: `Autodesk.Revit.DB.MEPSystem.GetCriticalPathSectionNumbers`

#### Summary

Obtains a list of the critical path section numbers.

#### Remarks

The section numbers are returned in order in the direction of flow.

#### Returns

The section numbers.

#### Since

2013

### `M:Autodesk.Revit.DB.MEPSystem.GetSectionByNumber(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MEPSystem.GetSectionByNumber(System.Int32)`

#### Summary

Get the Section from section number

#### Parameter `sectionNumber`

The Section number.

#### Returns

The section. `null` if the no section exists for the input section number.

#### Since

2013

### `M:Autodesk.Revit.DB.MEPSystem.GetSectionByIndex(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MEPSystem.GetSectionByIndex(System.Int32)`

#### Summary

Get the section from the index.

#### Parameter `index`

The index of the section in the system.

#### Returns

The section.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The section index is out of range.

#### Since

2013

### `P:Autodesk.Revit.DB.MEPSystem.HasPlaceholders`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPSystem.HasPlaceholders`

#### Summary

Indicates if the system has one or more placeholders.

#### Since

2015

### `P:Autodesk.Revit.DB.MEPSystem.HasDesignParts`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPSystem.HasDesignParts`

#### Summary

Indicates if the system has one or more design parts.

#### Since

2015

### `P:Autodesk.Revit.DB.MEPSystem.HasFabricationParts`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPSystem.HasFabricationParts`

#### Summary

Indicates if the system has one or more fabrication parts.

#### Since

2015

### `P:Autodesk.Revit.DB.MEPSystem.IsMultipleNetwork`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPSystem.IsMultipleNetwork`

#### Summary

Indicates if the system is well connected or not. The flag will enable the "Divide System" button.

#### Since

2014

### `P:Autodesk.Revit.DB.MEPSystem.PressureLossOfCriticalPath`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPSystem.PressureLossOfCriticalPath`

#### Summary

The total pressure loss of the sections in critical path.

#### Since

2013

### `P:Autodesk.Revit.DB.MEPSystem.SectionsCount`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPSystem.SectionsCount`

#### Summary

The number of sections.

#### Since

2013

### `P:Autodesk.Revit.DB.MEPSystem.IsEmpty`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPSystem.IsEmpty`

#### Summary

Indicates if the system is empty or not.

#### Remarks

returns true if the system doesn't contain any components

#### Since

2011

### `P:Autodesk.Revit.DB.MEPSystem.IsValid`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPSystem.IsValid`

#### Summary

Indicates if the system is valid or not.
atom AtomValidateSystem
default false

#### Since

2011

### `M:Autodesk.Revit.DB.MEPSystem.Remove(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.MEPSystem.Remove(System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId})`

#### Summary

Remove elements from system.

#### Remarks

It is forbidden to remove all terminal elements from system.
Terminal elements will be removed from the system automatically after removing this system from document.

#### Parameter `elementIds`

The elements to be removed from the system.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument elements is `null` , or any element in that collection is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when some of the elements can't be removed, or when trying to remove all elements from the system.
The element which connect to the base equipment can't be removed,

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the operation failed.

### `M:Autodesk.Revit.DB.MEPSystem.Remove(Autodesk.Revit.DB.ConnectorSet)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MEPSystem.Remove(Autodesk.Revit.DB.ConnectorSet)`

#### Summary

Removes connectors from system.

#### Parameter `connectors`

The connectors to be removed from the system.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument elements is `null` , or any element in that collection is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when some of the connectors can't be removed, or when trying to remove all connectors from the system.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the operation failed.

### `M:Autodesk.Revit.DB.MEPSystem.Add(Autodesk.Revit.DB.ConnectorSet)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MEPSystem.Add(Autodesk.Revit.DB.ConnectorSet)`

#### Summary

Add elements into the system and connect them with the system using given connectors.

#### Remarks

Note: this method may not be called during dynamic update.

#### Parameter `connectors`

Connectors which are used to connect with the system.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the input argument connectors is `null` , or any connector in that collection is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Throw when any of the input connectors have been already used,
or when they don't share the same domain or system type as the system.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the operation failed.

#### Exception `T:Autodesk.Revit.Exceptions.ForbiddenForDynamicUpdateException`

Thrown if this method is called during dynamic update.

### `P:Autodesk.Revit.DB.MEPSystem.BaseEquipmentConnector`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPSystem.BaseEquipmentConnector`

#### Summary

The connector within base equipment which is used to connect with system.

#### Returns

Returns the connector which connects with the system within base equipment if base equipment has been assigned to system,
otherwise returns `null` .

### `P:Autodesk.Revit.DB.MEPSystem.BaseEquipment`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPSystem.BaseEquipment`

#### Summary

The base panel or equipment of the system.

### `P:Autodesk.Revit.DB.MEPSystem.Elements`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPSystem.Elements`

#### Summary

Terminal elements in the system.

#### Remarks

The return value is a read only collection and doesn't include the base equipment or panel.

### `P:Autodesk.Revit.DB.MEPSystem.ConnectorManager`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPSystem.ConnectorManager`

#### Summary

Connector manager of the system.

#### Remarks

The connector manager includes connectors which are used to connect with terminal elements and base equipment.

### `T:Autodesk.Revit.DB.MEPSystem`

Member kind: type
Symbol: `Autodesk.Revit.DB.MEPSystem`

#### Summary

A system in the Autodesk Revit MEP product.

#### Remarks

This is the base class for electrical, mechanical and piping systems,
available only in the Autodesk Revit MEP product.

#### Since

2011

### `T:Autodesk.Revit.DB.Mechanical.DuctType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Mechanical.DuctType`

#### Summary

A duct type element.

### `P:Autodesk.Revit.DB.MEPSize.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPSize.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.MEPSize.UsedInSizing`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPSize.UsedInSizing`

#### Summary

Whether is used in sizing.

#### Since

2012

### `P:Autodesk.Revit.DB.MEPSize.UsedInSizeLists`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPSize.UsedInSizeLists`

#### Summary

Whether it is used in size lists.

#### Since

2012

### `P:Autodesk.Revit.DB.MEPSize.OuterDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPSize.OuterDiameter`

#### Summary

Outer diameter

#### Since

2012

### `P:Autodesk.Revit.DB.MEPSize.InnerDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPSize.InnerDiameter`

#### Summary

Inner diameter

#### Since

2012

### `P:Autodesk.Revit.DB.MEPSize.NominalDiameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.MEPSize.NominalDiameter`

#### Summary

Nominal diameter

#### Since

2012

### `M:Autodesk.Revit.DB.MEPSize.#ctor(System.Double,System.Double,System.Double,System.Boolean,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.MEPSize.#ctor(System.Double,System.Double,System.Double,System.Boolean,System.Boolean)`

#### Summary

Constructs an object that stores the basic size information for MEP duct, pipe, cable tray and conduit.

#### Parameter `nominalDiameter`

Nominal diameter. The value should be a valid, positive Revit length.

#### Parameter `innerDiameter`

Inner diameter. The value should be a valid, positive Revit length.

#### Parameter `outerDiameter`

Outer diameter. The value should be a valid, positive Revit length.

#### Parameter `usedInSizeLists`

Whether it is used in size lists.

#### Parameter `usedInSizing`

Whether is used in sizing.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for nominalDiameter must be greater than 0 and no more than 30000 feet.
-or-
The given value for innerDiameter must be greater than 0 and no more than 30000 feet.
-or-
The given value for outerDiameter must be greater than 0 and no more than 30000 feet.

#### Since

2012

### `T:Autodesk.Revit.DB.MEPSize`

Member kind: type
Symbol: `Autodesk.Revit.DB.MEPSize`

#### Summary

Stores the basic size information for an MEP duct, pipe, cable tray, or conduit.

#### Since

2012

### `M:Autodesk.Revit.DB.Mechanical.DuctSizeSettings.GetEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizeSettings.GetEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.Mechanical.DuctSizeSettings.GetBasicIEnumerator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizeSettings.GetBasicIEnumerator`

#### Summary

Returns an enumerator that iterates through a collection.

#### Returns

An IEnumerator object that can be used to iterate through the collection.

### `M:Autodesk.Revit.DB.Mechanical.DuctSizeSettings.GetDuctSizeSettingsIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizeSettings.GetDuctSizeSettingsIterator`

#### Summary

Returns a DuctSizeSettingIterator to the duct size settings.

#### Since

2013

### `M:Autodesk.Revit.DB.Mechanical.DuctSizeSettings.RemoveSize(Autodesk.Revit.DB.Mechanical.DuctShape,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizeSettings.RemoveSize(Autodesk.Revit.DB.Mechanical.DuctShape,System.Double)`

#### Summary

Erase the existing MEPSize with this nominal diameter. The duct shape determines the location of the size in the size table.

#### Remarks

Does nothing if there is no existing MEPSize with this nominal diameter.

#### Parameter `shape`

The shape of duct.

#### Parameter `nominalDiameter`

Nominal diameter.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Throws if the function is called during iterating the size set.

#### Since

2013

### `M:Autodesk.Revit.DB.Mechanical.DuctSizeSettings.AddSize(Autodesk.Revit.DB.Mechanical.DuctShape,Autodesk.Revit.DB.MEPSize)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizeSettings.AddSize(Autodesk.Revit.DB.Mechanical.DuctShape,Autodesk.Revit.DB.MEPSize)`

#### Summary

Inserts a new MEPSize in to the duct size settings. The duct shape determines the location of the new size in the size table.

#### Parameter `shape`

The shape of duct.

#### Parameter `sizeInfo`

The new MEPSize to be added.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Throws if there is no size set determined by the duct shape
or there is already the same size in the size set determined by the duct shape.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Throws if the function is called during iterating the size set.

#### Since

2013

### `M:Autodesk.Revit.DB.Mechanical.DuctSizeSettings.GetDuctSizeSettings(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizeSettings.GetDuctSizeSettings(Autodesk.Revit.DB.Document)`

#### Summary

Get the duct size settings of the project.

#### Parameter `aDoc`

The document.

#### Returns

The duct size settings of the project.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Mechanical.DuctSizeSettings.GetSizeCount(Autodesk.Revit.DB.Mechanical.DuctShape)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizeSettings.GetSizeCount(Autodesk.Revit.DB.Mechanical.DuctShape)`

#### Summary

Get the size count of the duct size table. The duct shape determines the location of the size in the size table.

#### Parameter `shape`

The shape of duct.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.Mechanical.DuctSizeSettings.default(Autodesk.Revit.DB.Mechanical.DuctShape)`

Member kind: property
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizeSettings.default(Autodesk.Revit.DB.Mechanical.DuctShape)`

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

### `M:Autodesk.Revit.DB.Mechanical.DuctSizeSettings.GetDuctSizeSettingIterator`

Member kind: method
Symbol: `Autodesk.Revit.DB.Mechanical.DuctSizeSettings.GetDuctSizeSettingIterator`

#### Summary

Returns a DuctSizeSettingIterator object that iterates through the collection.

#### Returns

A DuctSizeSettingIterator object that can be used to iterate through key-value pairs in the collection.
