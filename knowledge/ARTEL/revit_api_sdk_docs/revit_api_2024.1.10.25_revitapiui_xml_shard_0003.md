# ARTEL Revit API 2024 XML Documentation

Product: ARTEL
Document type: REVIT_API_SDK_DOC
Source kind: Revit SDK XML documentation
Revit API version: 2024.1.10.25
Assembly: RevitAPIUI
Source file: RevitAPIUI.xml
Source XML SHA-256: 6ad274f5fb15a6f8b1d145fd485ff977695b72b99039fa1ff55779bcb47a91f1
Package URL: https://api.nuget.org/v3-flatcontainer/autodesk.revit.sdk/2024.1.10.25/autodesk.revit.sdk.2024.1.10.25.nupkg
Package SHA-256: 72e2be30d84f438e6d9d9eeb92ff99a7674dfbcbe906c2dcaf9229b75c5cff43
Shard: 3
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPIUI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `T:CSinusoidalTransitionFromRange`

Member kind: type
Symbol: `CSinusoidalTransitionFromRange`

#### Summary

Encapsulates a sinusoidal-range transition, with a given range of oscillation.

#### Remarks

The value of the animation variable fluctuates between the specified minimum and maximum values over the entire
duration of a sinusoidal-range transition. The slope parameter is used to disambiguate between the two possible
sine waves specified by the other parameters.
Because all transitions are cleared automatically, it's recommended to allocated them using operator new.
The encapsulated IUIAnimationTransition COM object is created by CAnimationController::AnimateGroup, until then
it's NULL. Changing member variables after creation of this COM object has no effect.

### `M:CReversalTransition.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

Member kind: method
Symbol: `CReversalTransition.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

#### Summary

Calls the transition library to create encapsulated transition COM object.

#### Returns

TRUE if transition is created successfully; otherwise FALSE.

#### Parameter `pLibrary`

A pointer to transition library, which is responsible for creation of standard transitions.

#### Parameter `pFactory`

A pointer to transition factory, which is responsible for creation of custom transitions.

### `F:CReversalTransition.m_duration`

Member kind: field
Symbol: `CReversalTransition.m_duration`

#### Summary

The duration of the transition.

### `M:CReversalTransition.#ctor(System.Double)`

Member kind: method
Symbol: `CReversalTransition.#ctor(System.Double)`

#### Summary

Constructs a reversal transition object and initializes its duration.

#### Parameter `duration`

The duration of the transition.

### `T:CReversalTransition`

Member kind: type
Symbol: `CReversalTransition`

#### Summary

Encapsulates a reversal transition.

#### Remarks

A reversal transition smoothly changes direction over a given duration.
The final value will be the same as the initial value and the final velocity will be the negative of the initial velocity.
Because all transitions are cleared automatically, it's recommended to allocated them using operator new.
The encapsulated IUIAnimationTransition COM object is created by CAnimationController::AnimateGroup, until then
it's NULL. Changing member variables after creation of this COM object has no effect.

### `M:CParabolicTransitionFromAcceleration.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

Member kind: method
Symbol: `CParabolicTransitionFromAcceleration.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

#### Summary

Calls the transition library to create encapsulated transition COM object.

#### Returns

TRUE if transition is created successfully; otherwise FALSE.

#### Parameter `pLibrary`

A pointer to transition library, which is responsible for creation of standard transitions.

#### Parameter `pFactory`

A pointer to transition factory, which is responsible for creation of custom transitions.

### `F:CParabolicTransitionFromAcceleration.m_dblAcceleration`

Member kind: field
Symbol: `CParabolicTransitionFromAcceleration.m_dblAcceleration`

#### Summary

The acceleration of the animation variable during the transition.

### `F:CParabolicTransitionFromAcceleration.m_dblFinalVelocity`

Member kind: field
Symbol: `CParabolicTransitionFromAcceleration.m_dblFinalVelocity`

#### Summary

The velocity of the animation variable at the end of the transition.

### `F:CParabolicTransitionFromAcceleration.m_dblFinalValue`

Member kind: field
Symbol: `CParabolicTransitionFromAcceleration.m_dblFinalValue`

#### Summary

The value of the animation variable at the end of the transition.

### `M:CParabolicTransitionFromAcceleration.#ctor(System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `CParabolicTransitionFromAcceleration.#ctor(System.Double,System.Double,System.Double)`

#### Summary

Constructs a parabolic-acceleration transition and initializes it with specified parameters.

#### Parameter `dblFinalValue`

The value of the animation variable at the end of the transition.

#### Parameter `dblFinalVelocity`

The velocity of the animation variable at the end of the transition.

#### Parameter `dblAcceleration`

The acceleration of the animation variable during the transition.

### `T:CParabolicTransitionFromAcceleration`

Member kind: type
Symbol: `CParabolicTransitionFromAcceleration`

#### Summary

Encapsulates a parabolic-acceleration transition.

#### Remarks

During a parabolic-acceleration transition, the value of the animation variable changes from the initial value
to the final value ending at a specified velocity. You can control how quickly the variable reaches the final
value by specifying the rate of acceleration.
Because all transitions are cleared automatically, it's recommended to allocated them using operator new.
The encapsulated IUIAnimationTransition COM object is created by CAnimationController::AnimateGroup, until then
it's NULL. Changing member variables after creation of this COM object has no effect.

### `M:CSmoothStopTransition.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

Member kind: method
Symbol: `CSmoothStopTransition.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

#### Summary

Calls the transition library to create encapsulated transition COM object.

#### Returns

TRUE if transition is created successfully; otherwise FALSE.

#### Parameter `pLibrary`

A pointer to transition library, which is responsible for creation of standard transitions.

#### Parameter `pFactory`

A pointer to transition factory, which is responsible for creation of custom transitions.

### `F:CSmoothStopTransition.m_dblFinalValue`

Member kind: field
Symbol: `CSmoothStopTransition.m_dblFinalValue`

#### Summary

The value of the animation variable at the end of the transition.

### `F:CSmoothStopTransition.m_maximumDuration`

Member kind: field
Symbol: `CSmoothStopTransition.m_maximumDuration`

#### Summary

The maximum duration of the transition.

### `M:CSmoothStopTransition.#ctor(System.Double,System.Double)`

Member kind: method
Symbol: `CSmoothStopTransition.#ctor(System.Double,System.Double)`

#### Summary

Constructs a smooth-stop transition and initializes its maximum duration and final value.

#### Parameter `maximumDuration`

The maximum duration of the transition.

#### Parameter `dblFinalValue`

The value of the animation variable at the end of the transition.

### `T:CSmoothStopTransition`

Member kind: type
Symbol: `CSmoothStopTransition`

#### Summary

Encapsulates a smooth-stop transition.

#### Remarks

A smooth-stop transition slows down as it approaches a given final value, and reaches it with a velocity of zero.
The duration of the transition is determined by the initial velocity, the difference between the initial and final values,
and the specified maximum duration. If there is no solution consisting of a single parabolic arc,
this method creates a cubic transition.
Because all transitions are cleared automatically, it's recommended to allocated them using operator new.
The encapsulated IUIAnimationTransition COM object is created by CAnimationController::AnimateGroup, until then
it's NULL. Changing member variables after creation of this COM object has no effect.

### `M:CLinearTransitionFromSpeed.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

Member kind: method
Symbol: `CLinearTransitionFromSpeed.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

#### Summary

Calls the transition library to create encapsulated transition COM object.

#### Returns

TRUE if transition is created successfully; otherwise FALSE.

#### Parameter `pLibrary`

A pointer to transition library, which is responsible for creation of standard transitions.

#### Parameter `pFactory`

A pointer to transition factory, which is responsible for creation of custom transitions.

### `F:CLinearTransitionFromSpeed.m_dblFinalValue`

Member kind: field
Symbol: `CLinearTransitionFromSpeed.m_dblFinalValue`

#### Summary

The value of the animation variable at the end of the transition.

### `F:CLinearTransitionFromSpeed.m_dblSpeed`

Member kind: field
Symbol: `CLinearTransitionFromSpeed.m_dblSpeed`

#### Summary

The absolute value of the variable's velocity.

### `M:CLinearTransitionFromSpeed.#ctor(System.Double,System.Double)`

Member kind: method
Symbol: `CLinearTransitionFromSpeed.#ctor(System.Double,System.Double)`

#### Summary

Constructs a linear-speed transition object and initializes it with speed and final value.

#### Parameter `dblSpeed`

The absolute value of the variable's velocity.

#### Parameter `dblFinalValue`

The value of the animation variable at the end of the transition.

### `T:CLinearTransitionFromSpeed`

Member kind: type
Symbol: `CLinearTransitionFromSpeed`

#### Summary

Encapsulates a linear-speed transition.

#### Remarks

During a linear-speed transition, the value of the animation variable changes at a specified rate.
The duration of the transition is determined by the difference between the initial value and the specified final value.
Because all transitions are cleared automatically, it's recommended to allocated them using operator new.
The encapsulated IUIAnimationTransition COM object is created by CAnimationController::AnimateGroup, until then
it's NULL. Changing member variables after creation of this COM object has no effect.

### `M:CLinearTransition.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

Member kind: method
Symbol: `CLinearTransition.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

#### Summary

Calls the transition library to create encapsulated transition COM object.

#### Returns

TRUE if transition is created successfully; otherwise FALSE.

#### Parameter `pLibrary`

A pointer to transition library, which is responsible for creation of standard transitions.

#### Parameter `pFactory`

A pointer to transition factory, which is responsible for creation of custom transitions.

### `F:CLinearTransition.m_dblFinalValue`

Member kind: field
Symbol: `CLinearTransition.m_dblFinalValue`

#### Summary

The value of the animation variable at the end of the transition.

### `F:CLinearTransition.m_duration`

Member kind: field
Symbol: `CLinearTransition.m_duration`

#### Summary

The duration of the transition.

### `M:CLinearTransition.#ctor(System.Double,System.Double)`

Member kind: method
Symbol: `CLinearTransition.#ctor(System.Double,System.Double)`

#### Summary

Constructs a linear transition object and initializes it with duration and final value.

#### Parameter `duration`

The duration of the transition.

#### Parameter `dblFinalValue`

The value of the animation variable at the end of the transition.

### `T:CLinearTransition`

Member kind: type
Symbol: `CLinearTransition`

#### Summary

Encapsulates a linear transition.

#### Remarks

During a linear transition, the value of the animation variable transitions linearly from its initial value to a specified final value.
Because all transitions are cleared automatically, it's recommended to allocated them using operator new.
The encapsulated IUIAnimationTransition COM object is created by CAnimationController::AnimateGroup, until then
it's NULL. Changing member variables after creation of this COM object has no effect.

### `M:CInstantaneousTransition.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

Member kind: method
Symbol: `CInstantaneousTransition.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

#### Summary

Calls the transition library to create encapsulated transition COM object.

#### Returns

TRUE if transition is created successfully; otherwise FALSE.

#### Parameter `pLibrary`

A pointer to transition library, which is responsible for creation of standard transitions.

#### Parameter `pFactory`

A pointer to transition factory, which is responsible for creation of custom transitions.

### `F:CInstantaneousTransition.m_dblFinalValue`

Member kind: field
Symbol: `CInstantaneousTransition.m_dblFinalValue`

#### Summary

The value of the animation variable at the end of the transition.

### `M:CInstantaneousTransition.#ctor(System.Double)`

Member kind: method
Symbol: `CInstantaneousTransition.#ctor(System.Double)`

#### Summary

Constructs a transition object and initializes its final value.

#### Parameter `dblFinalValue`

The value of the animation variable at the end of the transition.

### `T:CInstantaneousTransition`

Member kind: type
Symbol: `CInstantaneousTransition`

#### Summary

Encapsulates an instantaneous transition.

#### Remarks

During an instantaneous transition, the value of the animation variable changes instantly from its current
value to a specified final value. The duration of this transition is always zero.
Because all transitions are cleared automatically, it's recommended to allocated them using operator new.
The encapsulated IUIAnimationTransition COM object is created by CAnimationController::AnimateGroup, until then
it's NULL. Changing member variables after creation of this COM object has no effect.

### `M:CDiscreteTransition.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

Member kind: method
Symbol: `CDiscreteTransition.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

#### Summary

Calls the transition library to create encapsulated transition COM object.

#### Returns

TRUE if transition is created successfully; otherwise FALSE.

#### Parameter `pLibrary`

A pointer to transition library, which is responsible for creation of standard transitions.

#### Parameter `pFactory`

A pointer to transition factory, which is responsible for creation of custom transitions.

### `F:CDiscreteTransition.m_hold`

Member kind: field
Symbol: `CDiscreteTransition.m_hold`

#### Summary

The amount of time by which to hold the variable at its final value.

### `F:CDiscreteTransition.m_dblFinalValue`

Member kind: field
Symbol: `CDiscreteTransition.m_dblFinalValue`

#### Summary

The value of the animation variable at the end of the transition.

### `F:CDiscreteTransition.m_delay`

Member kind: field
Symbol: `CDiscreteTransition.m_delay`

#### Summary

The amount of time by which to delay the instantaneous switch to the final value.

### `M:CDiscreteTransition.#ctor(System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `CDiscreteTransition.#ctor(System.Double,System.Double,System.Double)`

#### Summary

Constructs a discrete transition object and initializes its parameters.

#### Parameter `delay`

The amount of time by which to delay the instantaneous switch to the final value.

#### Parameter `dblFinalValue`

The value of the animation variable at the end of the transition.

#### Parameter `hold`

The amount of time by which to hold the variable at its final value.

### `T:CDiscreteTransition`

Member kind: type
Symbol: `CDiscreteTransition`

#### Summary

Encapsulates a discrete transition.

#### Remarks

During a discrete transition, the animation variable remains at the initial value for a specified delay time,
then switches instantaneously to a specified final value and remains at that value for a given hold time.
Because all transitions are cleared automatically, it's recommended to allocated them using operator new.
The encapsulated IUIAnimationTransition COM object is created by CAnimationController::AnimateGroup, until then
it's NULL. Changing member variables after creation of this COM object has no effect.

### `M:CCubicTransition.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

Member kind: method
Symbol: `CCubicTransition.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

#### Summary

Calls the transition library to create encapsulated transition COM object.

#### Returns

TRUE if transition is created successfully; otherwise FALSE.

#### Parameter `pLibrary`

A pointer to transition library, which is responsible for creation of standard transitions.

#### Parameter `pFactory`

A pointer to transition factory, which is responsible for creation of custom transitions.

### `F:CCubicTransition.m_dblFinalVelocity`

Member kind: field
Symbol: `CCubicTransition.m_dblFinalVelocity`

#### Summary

The velocity of the variable at the end of the transition.

### `F:CCubicTransition.m_dblFinalValue`

Member kind: field
Symbol: `CCubicTransition.m_dblFinalValue`

#### Summary

The value of the animation variable at the end of the transition.

### `F:CCubicTransition.m_duration`

Member kind: field
Symbol: `CCubicTransition.m_duration`

#### Summary

The duration of the transition.

### `M:CCubicTransition.#ctor(System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `CCubicTransition.#ctor(System.Double,System.Double,System.Double)`

#### Summary

Constructs a transition object and initializes its parameters.

#### Parameter `duration`

The duration of the transition.

#### Parameter `finalValue`

The value of the animation variable at the end of the transition.

#### Parameter `finalVelocity`

The velocity of the variable at the end of the transition.

### `T:CCubicTransition`

Member kind: type
Symbol: `CCubicTransition`

#### Summary

Encapsulates a cubic transition.

#### Remarks

During a cubic transition, the value of the animation variable changes from its initial value to a specified
final value over the duration of the transition, ending at a specified velocity.
Because all transitions are cleared automatically, it's recommended to allocated them using operator new.
The encapsulated IUIAnimationTransition COM object is created by CAnimationController::AnimateGroup, until then
it's NULL. Changing member variables after creation of this COM object has no effect.

### `M:CConstantTransition.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

Member kind: method
Symbol: `CConstantTransition.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

#### Summary

Calls the transition library to create encapsulated transition COM object.

#### Returns

TRUE if transition is created successfully; otherwise FALSE.

#### Parameter `pLibrary`

A pointer to transition library, which is responsible for creation of standard transitions.

#### Parameter `pFactory`

A pointer to transition factory, which is responsible for creation of custom transitions.

### `F:CConstantTransition.m_duration`

Member kind: field
Symbol: `CConstantTransition.m_duration`

#### Summary

The duration of the transition.

### `M:CConstantTransition.#ctor(System.Double)`

Member kind: method
Symbol: `CConstantTransition.#ctor(System.Double)`

#### Summary

Constructs a transition object and initializes its duration.

#### Parameter `duration`

The duration of the transition.

### `T:CConstantTransition`

Member kind: type
Symbol: `CConstantTransition`

#### Summary

Encapsulates a constant transition.

#### Remarks

During a constant transition, the value of an animation variable remains at the initial value over the duration
of the transition.
Because all transitions are cleared automatically, it's recommended to allocated them using operator new.
The encapsulated IUIAnimationTransition COM object is created by CAnimationController::AnimateGroup, until then
it's NULL. Changing member variables after creation of this COM object has no effect.

### `M:CAccelerateDecelerateTransition.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

Member kind: method
Symbol: `CAccelerateDecelerateTransition.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

#### Summary

Calls the transition library to create encapsulated transition COM object.

#### Returns

TRUE if transition is created successfully; otherwise FALSE.

#### Parameter `pLibrary`

A pointer to transition library, which is responsible for creation of standard transitions.

#### Parameter `pFactory`

A pointer to transition factory, which is responsible for creation of custom transitions.

### `F:CAccelerateDecelerateTransition.m_decelerationRatio`

Member kind: field
Symbol: `CAccelerateDecelerateTransition.m_decelerationRatio`

#### Summary

The ratio of the time spent decelerating to the duration.

### `F:CAccelerateDecelerateTransition.m_accelerationRatio`

Member kind: field
Symbol: `CAccelerateDecelerateTransition.m_accelerationRatio`

#### Summary

The ratio of the time spent accelerating to the duration.

### `F:CAccelerateDecelerateTransition.m_finalValue`

Member kind: field
Symbol: `CAccelerateDecelerateTransition.m_finalValue`

#### Summary

The value of the animation variable at the end of the transition.

### `F:CAccelerateDecelerateTransition.m_duration`

Member kind: field
Symbol: `CAccelerateDecelerateTransition.m_duration`

#### Summary

The duration of the transition.

### `M:CAccelerateDecelerateTransition.#ctor(System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `CAccelerateDecelerateTransition.#ctor(System.Double,System.Double,System.Double,System.Double)`

#### Summary

Constructs a transition object.

#### Parameter `duration`

The duration of the transition.

#### Parameter `finalValue`

The value of the animation variable at the end of the transition.

#### Parameter `accelerationRatio`

The ratio of the time spent accelerating to the duration.

#### Parameter `decelerationRatio`

The ratio of the time spent decelerating to the duration.

### `T:CAccelerateDecelerateTransition`

Member kind: type
Symbol: `CAccelerateDecelerateTransition`

#### Summary

Implements an accelerate-decelerate transition.

#### Remarks

During an accelerate-decelerate transition, the animation variable speeds up and then slows down over the
duration of the transition, ending at a specified value. You can control how quickly the variable accelerates and
decelerates independently, by specifying different acceleration and deceleration ratios.
When the initial velocity is zero, the acceleration ratio is the fraction of the duration that the variable will
spend accelerating; likewise with the deceleration ratio. If the initial velocity is non-zero, it is the
fraction of the time between the velocity reaching zero and the end of transition. The acceleration ratio and
the deceleration ratio should sum to a maximum of 1.0.
Because all transitions are cleared automatically, it's recommended to allocated them using operator new.
The encapsulated IUIAnimationTransition COM object is created by CAnimationController::AnimateGroup, until then
it's NULL. Changing member variables after creation of this COM object has no effect.

### `M:CAnimationTimerEventHandler.OnRenderingTooSlow(System.UInt32)`

Member kind: method
Symbol: `CAnimationTimerEventHandler.OnRenderingTooSlow(System.UInt32)`

#### Summary

Handles events that occur when the rendering frame rate for an animation falls below the minimum desirable frame rate.

#### Returns

S_OK if the method succeeds; otherwise E_FAIL.

### `M:CAnimationTimerEventHandler.OnPostUpdate`

Member kind: method
Symbol: `CAnimationTimerEventHandler.OnPostUpdate`

#### Summary

Handles events that occur after an animation update is finished.

#### Returns

S_OK if the method succeeds; otherwise E_FAIL.

### `M:CAnimationTimerEventHandler.OnPreUpdate`

Member kind: method
Symbol: `CAnimationTimerEventHandler.OnPreUpdate`

#### Summary

Handles events that occur before an animation update begins.

#### Returns

S_OK if the method succeeds; otherwise E_FAIL.

### `M:CAnimationTimerEventHandler.SetAnimationController(CAnimationController*)`

Member kind: method
Symbol: `CAnimationTimerEventHandler.SetAnimationController(CAnimationController*)`

#### Summary

Stores a pointer to animation controller to route events.

#### Parameter `pAnimationController`

A pointer to animation controller, which will receive events.

### `M:CAnimationTimerEventHandler.CreateInstance(CAnimationController*,IUIAnimationTimerEventHandler**)`

Member kind: method
Symbol: `CAnimationTimerEventHandler.CreateInstance(CAnimationController*,IUIAnimationTimerEventHandler**)`

#### Summary

Creates an instance of CAnimationTimerEventHandler callback.

#### Returns

If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

#### Parameter `pAnimationController`

A pointer to animation controller, which will receive events.

#### Parameter `ppTimerEventHandler`

Output. If the method succeeds it contains a pointer to COM object that will handle
animation timer events.

### `T:CAnimationTimerEventHandler`

Member kind: type
Symbol: `CAnimationTimerEventHandler`

#### Summary

Implements a call back, which is called by Animation API when timing events occur.

#### Remarks

This event handler is created and passed to IUIAnimationTimer::SetTimerEventHandler when you call
CAnimationController::EnableAnimationTimerEventHandler.

### `M:CAnimationStoryboardEventHandler.OnStoryboardUpdated(IUIAnimationStoryboard*)`

Member kind: method
Symbol: `CAnimationStoryboardEventHandler.OnStoryboardUpdated(IUIAnimationStoryboard*)`

#### Summary

Handles OnStoryboardUpdated events, which occur when a storyboard is updated

#### Returns

S_OK if the method succeeds; otherwise E_FAIL.

#### Parameter `storyboard`

A pointer to storyboard, which was updated.

### `M:CAnimationStoryboardEventHandler.OnStoryboardStatusChanged(IUIAnimationStoryboard*,__MIDL___MIDL_itf_UIAnimation_0000_0002_0001,__MIDL___MIDL_itf_UIAnimation_0000_0002_0001)`

Member kind: method
Symbol: `CAnimationStoryboardEventHandler.OnStoryboardStatusChanged(IUIAnimationStoryboard*,__MIDL___MIDL_itf_UIAnimation_0000_0002_0001,__MIDL___MIDL_itf_UIAnimation_0000_0002_0001)`

#### Summary

Handles OnStoryboardStatusChanged events, which occur when a storyboard's status changes

#### Returns

S_OK if the method succeeds; otherwise E_FAIL.

#### Parameter `storyboard`

A pointer to storyboard whose status has changed.

#### Parameter `newStatus`

Specifies new storyboard status.

#### Parameter `previousStatus`

Specifies previous storyboard status.

### `M:CAnimationStoryboardEventHandler.SetAnimationController(CAnimationController*)`

Member kind: method
Symbol: `CAnimationStoryboardEventHandler.SetAnimationController(CAnimationController*)`

#### Summary

Stores a pointer to animation controller to route events.

#### Parameter `pAnimationController`

A pointer to animation controller, which will receive events.

### `M:CAnimationStoryboardEventHandler.CreateInstance(CAnimationController*,IUIAnimationStoryboardEventHandler**)`

Member kind: method
Symbol: `CAnimationStoryboardEventHandler.CreateInstance(CAnimationController*,IUIAnimationStoryboardEventHandler**)`

#### Summary

Creates an instance of CAnimationStoryboardEventHandler callback.

#### Returns

If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

#### Parameter `pAnimationController`

A pointer to animation controller, which will receive events.

#### Parameter `ppHandler`

Output. If the method succeeds it contains a pointer to COM object that will handle
storyboard events.

### `M:CAnimationStoryboardEventHandler.#ctor`

Member kind: method
Symbol: `CAnimationStoryboardEventHandler.#ctor`

#### Summary

Constructs a CAnimationStoryboardEventHandler object.

### `T:CAnimationStoryboardEventHandler`

Member kind: type
Symbol: `CAnimationStoryboardEventHandler`

#### Summary

Implements a callback, which is called by Animation API when storyboard's status is changed or storyboard is updated.

#### Remarks

This event handler is created and passed to IUIAnimationStoryboard::SetStoryboardEventHandler method,
when you call CAnimationController::EnableStoryboardEventHandler.

### `M:CAnimationVariableIntegerChangeHandler.OnIntegerValueChanged(IUIAnimationStoryboard*,IUIAnimationVariable*,System.Int32,System.Int32)`

Member kind: method
Symbol: `CAnimationVariableIntegerChangeHandler.OnIntegerValueChanged(IUIAnimationStoryboard*,IUIAnimationVariable*,System.Int32,System.Int32)`

#### Summary

Called when a value of an animation variable has changed.

#### Returns

S_OK if the method succeeds; otherwise E_FAIL.

#### Parameter `storyboard`

The storyboard that is animating the variable.

#### Parameter `variable`

The animation variable that was updated.

#### Parameter `newValue`

The new rounded value.

#### Parameter `previousValue`

The previous rounded value.

### `M:CAnimationVariableIntegerChangeHandler.SetAnimationController(CAnimationController*)`

Member kind: method
Symbol: `CAnimationVariableIntegerChangeHandler.SetAnimationController(CAnimationController*)`

#### Summary

Stores a pointer to animation controller to route events.

#### Parameter `pAnimationController`

A pointer to animation controller, which will receive events.

### `M:CAnimationVariableIntegerChangeHandler.CreateInstance(CAnimationController*,IUIAnimationVariableIntegerChangeHandler**)`

Member kind: method
Symbol: `CAnimationVariableIntegerChangeHandler.CreateInstance(CAnimationController*,IUIAnimationVariableIntegerChangeHandler**)`

#### Summary

Creates an instance of CAnimationVariableIntegerChangeHandler callback.

#### Returns

If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

#### Parameter `pAnimationController`

A pointer to animation controller, which will receive events.

#### Parameter `ppHandler`

Output. If the method succeeds it contains a pointer to COM object that will handle
variable integer change events.

### `M:CAnimationVariableIntegerChangeHandler.#ctor`

Member kind: method
Symbol: `CAnimationVariableIntegerChangeHandler.#ctor`

#### Summary

Constructs a CAnimationVariableIntegerChangeHandler object.

### `T:CAnimationVariableIntegerChangeHandler`

Member kind: type
Symbol: `CAnimationVariableIntegerChangeHandler`

#### Summary

Implements a call back, which is called by Animation API when the value of an animation variable changes.

#### Remarks

This event handler is created and passed to IUIAnimationVariable::SetVariableIntegerChangeHandler method,
when you call CAnimationVariable::EnableIntegerValueChangedEvent or CAnimationBaseObject::EnableIntegerValueChangedEvent
(which enables this event for all animation variables encapsulated in an animation object).

### `M:CAnimationVariableChangeHandler.OnValueChanged(IUIAnimationStoryboard*,IUIAnimationVariable*,System.Double,System.Double)`

Member kind: method
Symbol: `CAnimationVariableChangeHandler.OnValueChanged(IUIAnimationStoryboard*,IUIAnimationVariable*,System.Double,System.Double)`

#### Summary

Called when a value of an animation variable has changed.

#### Returns

If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

#### Parameter `storyboard`

The storyboard that is animating the variable.

#### Parameter `variable`

The animation variable that was updated.

#### Parameter `newValue`

The new value.

#### Parameter `previousValue`

The previous value.

### `M:CAnimationVariableChangeHandler.SetAnimationController(CAnimationController*)`

Member kind: method
Symbol: `CAnimationVariableChangeHandler.SetAnimationController(CAnimationController*)`

#### Summary

Stores a pointer to animation controller to route events.

#### Parameter `pAnimationController`

A pointer to animation controller, which will receive events.

### `M:CAnimationVariableChangeHandler.CreateInstance(CAnimationController*,IUIAnimationVariableChangeHandler**)`

Member kind: method
Symbol: `CAnimationVariableChangeHandler.CreateInstance(CAnimationController*,IUIAnimationVariableChangeHandler**)`

#### Summary

Creates an instance of CAnimationVariableChangeHandler object.

#### Returns

If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

#### Parameter `pAnimationController`

A pointer to animation controller, which will receive events.

#### Parameter `ppHandler`

Output. If the method succeeds it contains a pointer to COM object that will handle
variable change events.

### `M:CAnimationVariableChangeHandler.#ctor`

Member kind: method
Symbol: `CAnimationVariableChangeHandler.#ctor`

#### Summary

Constructs a CAnimationVariableChangeHandler object.

### `T:CAnimationVariableChangeHandler`

Member kind: type
Symbol: `CAnimationVariableChangeHandler`

#### Summary

Implements a call back, which is called by Animation API when the value of an animation variable changes.

#### Remarks

This event handler is created and passed to IUIAnimationVariable::SetVariableChangeHandler method,
when you call CAnimationVariable::EnableValueChangedEvent or CAnimationBaseObject::EnableValueChangedEvent
(which enables this event for all animation variables encapsulated in an animation object).

### `M:CAnimationManagerEventHandler.OnManagerStatusChanged(__MIDL___MIDL_itf_UIAnimation_0000_0000_0002,__MIDL___MIDL_itf_UIAnimation_0000_0000_0002)`

Member kind: method
Symbol: `CAnimationManagerEventHandler.OnManagerStatusChanged(__MIDL___MIDL_itf_UIAnimation_0000_0000_0002,__MIDL___MIDL_itf_UIAnimation_0000_0000_0002)`

#### Summary

Called when a status of animation manager has changed.

#### Returns

Current implementation always returns S_OK;

#### Parameter `newStatus`

New status.

#### Parameter `previousStatus`

Previous status.

### `M:CAnimationManagerEventHandler.SetAnimationController(CAnimationController*)`

Member kind: method
Symbol: `CAnimationManagerEventHandler.SetAnimationController(CAnimationController*)`

#### Summary

Stores a pointer to animation controller to route events.

#### Parameter `pAnimationController`

A pointer to animation controller, which will receive events.

### `M:CAnimationManagerEventHandler.CreateInstance(CAnimationController*,IUIAnimationManagerEventHandler**)`

Member kind: method
Symbol: `CAnimationManagerEventHandler.CreateInstance(CAnimationController*,IUIAnimationManagerEventHandler**)`

#### Summary

Creates an instance of CAnimationManagerEventHandler object.

#### Returns

If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

#### Parameter `pAnimationController`

A pointer to animation controller, which will receive events.

#### Parameter `ppManagerEventHandler`

Output. If the method succeeds it contains a pointer to COM object that will handle
status updates to an animation manager.

### `M:CAnimationManagerEventHandler.#ctor`

Member kind: method
Symbol: `CAnimationManagerEventHandler.#ctor`

#### Summary

Constructs a CAnimationManagerEventHandler object.

### `T:CAnimationManagerEventHandler`

Member kind: type
Symbol: `CAnimationManagerEventHandler`

#### Summary

Implements a callback, which is called by Animation API when a status of animation manager changed.

#### Remarks

This event handler is created and passed to IUIAnimationManager::SetManagerEventHandler method,
when you call CAnimationController::EnableAnimationManagerEvent.

### `M:CAnimationController.CleanUpGroup(CAnimationGroup*)`

Member kind: method
Symbol: `CAnimationController.CleanUpGroup(CAnimationGroup*)`

#### Summary

A helper that cleans up the group.

#### Remarks

This method removes all transitions and keyframes from the specified group.

#### Parameter `pGroup`

A pointer to animation group to clean.

### `M:CAnimationController.OnAfterSchedule(CAnimationGroup*)`

Member kind: method
Symbol: `CAnimationController.OnAfterSchedule(CAnimationGroup*)`

#### Summary

Called by the framework when an animation for the specified group has just been scheduled.

#### Remarks

The default implementation removes keyframes from the specified group and transitions from animation variables that
belong to the specified group. Can be overridden in a derived class to take any additional actions upon animation schedule.

#### Parameter `pGroup`

A pointer to an animation group, which has been scheduled.

### `M:CAnimationController.OnAnimationTimerRenderingTooSlow(System.UInt32)`

Member kind: method
Symbol: `CAnimationController.OnAnimationTimerRenderingTooSlow(System.UInt32)`

#### Summary

Called by the framework when the rendering frame rate for an animation falls below a minimum desirable frame rate.

#### Remarks

This method is called if you enable timer event handlers using EnableAnimationTimerEventHandler.
It can be overridden in a derived class to take application-specific actions.
The minimum desirable frame rate is specified by calling IUIAnimationTimer::SetFrameRateThreshold.

#### Parameter `fps`

The current frame rate in frames per second.

### `M:CAnimationController.OnAnimationTimerPostUpdate`

Member kind: method
Symbol: `CAnimationController.OnAnimationTimerPostUpdate`

#### Summary

Called by the framework after an animation update is finished.

#### Remarks

This method is called if you enable timer event handlers using EnableAnimationTimerEventHandler.
It can be overridden in a derived class to take application-specific actions.

### `M:CAnimationController.OnAnimationTimerPreUpdate`

Member kind: method
Symbol: `CAnimationController.OnAnimationTimerPreUpdate`

#### Summary

Called by the framework before an animation update begins.

#### Remarks

This method is called if you enable timer event handlers using EnableAnimationTimerEventHandler.
It can be overridden in a derived class to take application-specific actions.

### `M:CAnimationController.OnHasPriorityCompress(CAnimationGroup*,CAnimationGroup*,__MIDL___MIDL_itf_UIAnimation_0000_0008_0001)`

Member kind: method
Symbol: `CAnimationController.OnHasPriorityCompress(CAnimationGroup*,CAnimationGroup*,__MIDL___MIDL_itf_UIAnimation_0000_0008_0001)`

#### Summary

Called by the framework to resolve scheduling conflicts.

#### Returns

Should return TRUE if storyboard owned by pGroupNew has priority. Should return FALSE if storyboard owned by
pGroupScheduled has priority.

#### Remarks

This method is called if you enable priority comparison events using CAnimationController::EnablePriorityComparisonHandler
and specify UI_ANIMATION_PHT_COMPRESS.
It can be overridden in a derived class to take application-specific actions.
Read Windows Animation API documentation for more information about Conflict Management (http://msdn.microsoft.com/en-us/library/dd371759(VS.85).aspx).

#### Parameter `pGroupScheduled`

The group that owns the currently scheduled storyboard.

#### Parameter `pGroupNew`

The group that owns the new storyboard that is in scheduling conflict with the scheduled storyboard owned by pGroupScheduled.

#### Parameter `priorityEffect`

The potential effect on pGroupNew if pGroupScheduled has a higher priority.

### `M:CAnimationController.OnHasPriorityTrim(CAnimationGroup*,CAnimationGroup*,__MIDL___MIDL_itf_UIAnimation_0000_0008_0001)`

Member kind: method
Symbol: `CAnimationController.OnHasPriorityTrim(CAnimationGroup*,CAnimationGroup*,__MIDL___MIDL_itf_UIAnimation_0000_0008_0001)`

#### Summary

Called by the framework to resolve scheduling conflicts.

#### Returns

Should return TRUE if storyboard owned by pGroupNew has priority. Should return FALSE if storyboard owned by
pGroupScheduled has priority.

#### Remarks

This method is called if you enable priority comparison events using CAnimationController::EnablePriorityComparisonHandler
and specify UI_ANIMATION_PHT_TRIM.
It can be overridden in a derived class to take application-specific actions.
Read Windows Animation API documentation for more information about Conflict Management (http://msdn.microsoft.com/en-us/library/dd371759(VS.85).aspx).

#### Parameter `pGroupScheduled`

The group that owns the currently scheduled storyboard.

#### Parameter `pGroupNew`

The group that owns the new storyboard that is in scheduling conflict with the scheduled storyboard owned by pGroupScheduled.

#### Parameter `priorityEffect`

The potential effect on pGroupNew if pGroupScheduled has a higher priority.

### `M:CAnimationController.OnHasPriorityConclude(CAnimationGroup*,CAnimationGroup*,__MIDL___MIDL_itf_UIAnimation_0000_0008_0001)`

Member kind: method
Symbol: `CAnimationController.OnHasPriorityConclude(CAnimationGroup*,CAnimationGroup*,__MIDL___MIDL_itf_UIAnimation_0000_0008_0001)`

#### Summary

Called by the framework to resolve scheduling conflicts.

#### Returns

Should return TRUE if storyboard owned by pGroupNew has priority. Should return FALSE if storyboard owned by
pGroupScheduled has priority.

#### Remarks

This method is called if you enable priority comparison events using CAnimationController::EnablePriorityComparisonHandler
and specify UI_ANIMATION_PHT_CONCLUDE.
It can be overridden in a derived class to take application-specific actions.
Read Windows Animation API documentation for more information about Conflict Management (http://msdn.microsoft.com/en-us/library/dd371759(VS.85).aspx).

#### Parameter `pGroupScheduled`

The group that owns the currently scheduled storyboard.

#### Parameter `pGroupNew`

The group that owns the new storyboard that is in scheduling conflict with the scheduled storyboard owned by pGroupScheduled.

#### Parameter `priorityEffect`

The potential effect on pGroupNew if pGroupScheduled has a higher priority.

### `M:CAnimationController.OnHasPriorityCancel(CAnimationGroup*,CAnimationGroup*,__MIDL___MIDL_itf_UIAnimation_0000_0008_0001)`

Member kind: method
Symbol: `CAnimationController.OnHasPriorityCancel(CAnimationGroup*,CAnimationGroup*,__MIDL___MIDL_itf_UIAnimation_0000_0008_0001)`

#### Summary

Called by the framework to resolve scheduling conflicts.

#### Returns

Should return TRUE if storyboard owned by pGroupNew has priority. Should return FALSE if storyboard owned by
pGroupScheduled has priority.

#### Remarks

This method is called if you enable priority comparison events using CAnimationController::EnablePriorityComparisonHandler
and specify UI_ANIMATION_PHT_CANCEL.
It can be overridden in a derived class to take application-specific actions.
Read Windows Animation API documentation for more information about Conflict Management (http://msdn.microsoft.com/en-us/library/dd371759(VS.85).aspx).

#### Parameter `pGroupScheduled`

The group that owns the currently scheduled storyboard.

#### Parameter `pGroupNew`

The group that owns the new storyboard that is in scheduling conflict with the scheduled storyboard owned by pGroupScheduled.

#### Parameter `priorityEffect`

The potential effect on pGroupNew if pGroupScheduled has a higher priority.

### `M:CAnimationController.OnStoryboardUpdated(CAnimationGroup*)`

Member kind: method
Symbol: `CAnimationController.OnStoryboardUpdated(CAnimationGroup*)`

#### Summary

Called by the framework when storyboard has been updated.

#### Remarks

This method is called if you enable storyboard events using CAnimationController::EnableStoryboardEventHandler.
It can be overridden in a derived class to take application-specific actions.

#### Parameter `pGroup`

A pointer to a group that owns the storyboard.

### `M:CAnimationController.OnStoryboardStatusChanged(CAnimationGroup*,__MIDL___MIDL_itf_UIAnimation_0000_0002_0001,__MIDL___MIDL_itf_UIAnimation_0000_0002_0001)`

Member kind: method
Symbol: `CAnimationController.OnStoryboardStatusChanged(CAnimationGroup*,__MIDL___MIDL_itf_UIAnimation_0000_0002_0001,__MIDL___MIDL_itf_UIAnimation_0000_0002_0001)`

#### Summary

Called by the framework when storyboard status has changed.

#### Remarks

This method is called if you enable storyboard events using CAnimationController::EnableStoryboardEventHandler.
It can be overridden in a derived class to take application-specific actions.

#### Parameter `pGroup`

A pointer to an animation group that owns the storyboard whose status has changed.

#### Parameter `newStatus`

Specifies the new status.

#### Parameter `previousStatus`

Specifies the previous status.

### `M:CAnimationController.OnAnimationIntegerValueChanged(CAnimationGroup*,CAnimationBaseObject*,IUIAnimationVariable*,System.Int32,System.Int32)`

Member kind: method
Symbol: `CAnimationController.OnAnimationIntegerValueChanged(CAnimationGroup*,CAnimationBaseObject*,IUIAnimationVariable*,System.Int32,System.Int32)`

#### Summary

Called by the framework when integer value of animation variable has changed.

#### Remarks

This method is called if you enable animation variable events with EnableIntegerValueChangedEvent called for a specific
animation variable or animation object.
It can be overridden in a derived class to take application-specific actions.

#### Parameter `pGroup`

A pointer to an animation group that holds an animation object whose value has changed.

#### Parameter `pObject`

A pointer to an animation object that contains an animation variable whose value has changed.

#### Parameter `variable`

A pointer to an animation variable.

#### Parameter `newValue`

Specifies new value.

#### Parameter `prevValue`

Specifies previous value.

### `M:CAnimationController.OnAnimationValueChanged(CAnimationGroup*,CAnimationBaseObject*,IUIAnimationVariable*,System.Double,System.Double)`

Member kind: method
Symbol: `CAnimationController.OnAnimationValueChanged(CAnimationGroup*,CAnimationBaseObject*,IUIAnimationVariable*,System.Double,System.Double)`

#### Summary

Called by the framework when value of animation variable has changed.

#### Remarks

This method is called if you enable animation variable events with EnableValueChangedEvent called for a specific
animation variable or animation object.
It can be overridden in a derived class to take application-specific actions.

#### Parameter `pGroup`

A pointer to an animation group that holds an animation object whose value has changed.

#### Parameter `pObject`

A pointer to an animation object that contains an animation variable whose value has changed.

#### Parameter `variable`

A pointer to an animation variable.

#### Parameter `newValue`

Specifies new value.

#### Parameter `prevValue`

Specifies previous value.

### `M:CAnimationController.OnAnimationManagerStatusChanged(__MIDL___MIDL_itf_UIAnimation_0000_0000_0002,__MIDL___MIDL_itf_UIAnimation_0000_0000_0002)`

Member kind: method
Symbol: `CAnimationController.OnAnimationManagerStatusChanged(__MIDL___MIDL_itf_UIAnimation_0000_0000_0002,__MIDL___MIDL_itf_UIAnimation_0000_0000_0002)`

#### Summary

Called by the framework in response to StatusChanged event from animation manager.

#### Remarks

This method is called if you enable animation manager events with EnableAnimationManagerEvent.
It can be overridden in a derived class to take application-specific actions. The default implementation
updates a related window if it has been set with SetRelatedWnd.

#### Parameter `newStatus`

New animation manager status.

#### Parameter `previousStatus`

Previous animation manager status.

### `M:CAnimationController.OnBeforeAnimationStart(CAnimationGroup*)`

Member kind: method
Symbol: `CAnimationController.OnBeforeAnimationStart(CAnimationGroup*)`

#### Summary

Called by the framework right before the animation is scheduled.

#### Remarks

This call is routed to related CWnd and can be overridden in a derived class to perform any
additional actions before the animation starts for the specified group.

#### Parameter `pGroup`

A pointer to an animation group whose animation is about to start.

### `M:CAnimationController.CleanUpGroup(System.UInt32)`

Member kind: method
Symbol: `CAnimationController.CleanUpGroup(System.UInt32)`

#### Summary

Called by the framework to clean up the group when animation has been scheduled.

#### Remarks

This method removes all transitions and keyframes from the specified group, because they are not relevant
after an animation has been scheduled.

#### Parameter `nGroupID`

Specifies GroupID.

### `M:CAnimationController.ScheduleGroup(System.UInt32,System.Double)`

Member kind: method
Symbol: `CAnimationController.ScheduleGroup(System.UInt32,System.Double)`

#### Summary

Schedules an animation.

#### Returns

TRUE if animation was scheduled successfully. FALSE if storyboard has not been created, or other error occurs.

#### Remarks

You must call AnimateGroup with parameter bScheduleNow set to FALSE prior ScheduleGroup. You can specify the
desired animation time obtained from IUIAnimationTimer::GetTime. If the time parameter is 0.0, the animation is scheduled for the
current time.

#### Parameter `nGroupID`

Specifies animation Group ID to schedule.

#### Parameter `time`

Specifies time to schedule.

### `M:CAnimationController.AnimateGroup(System.UInt32,System.Int32)`

Member kind: method
Symbol: `CAnimationController.AnimateGroup(System.UInt32,System.Int32)`

#### Summary

Prepares a group to run animation and optionally schedules it.

#### Returns

TRUE if animation was successfully scheduled and run.

#### Remarks

This method does the actual work creating storyboard, adding animation variables, applying transitions and setting keyframes.
It's possible to delay scheduling if you set bScheduleNow to FALSE. In this case the specified group
will hold a storyboard that has been set up for animation. At that point you can setup events for the storyboard and
animation variables. When you actually need to run the animation call CAnimationController::ScheduleGroup.

#### Parameter `nGroupID`

Specifies GroupID.

#### Parameter `bScheduleNow`

Specifies whether to run animation right away.

### `M:CAnimationController.FindAnimationObject(IUIAnimationVariable*,CAnimationBaseObject**,CAnimationGroup**)`

Member kind: method
Symbol: `CAnimationController.FindAnimationObject(IUIAnimationVariable*,CAnimationBaseObject**,CAnimationGroup**)`

#### Summary

Finds animation object containing a specified animation variable.

#### Returns

TRUE if object was found; otherwise FALSE.

#### Remarks

Called from event handlers when it's required to find an animation object from incoming animation variable.

#### Parameter `pVariable`

A pointer to animation variable.

#### Parameter `ppObject`

Output. Contains a pointer to animation object or NULL.

#### Parameter `ppGroup`

Output. Contains a pointer to animation group that holds the animation object, or NULL.

### `M:CAnimationController.FindAnimationGroup(IUIAnimationStoryboard*)`

Member kind: method
Symbol: `CAnimationController.FindAnimationGroup(IUIAnimationStoryboard*)`

#### Summary

Finds an animation group by its storyboard.

#### Returns

A pointer to animation group if succeeds, or NULL if no group plays the specified storyboard.

#### Remarks

This method is usually called from event handlers to find a group by pointer to storyboard that comes as a parameter to an event handler.

#### Parameter `pStoryboard`

A pointer to a storyboard.

### `M:CAnimationController.FindAnimationGroup(System.UInt32)`

Member kind: method
Symbol: `CAnimationController.FindAnimationGroup(System.UInt32)`

#### Summary

Finds an animation group by its Group ID.

#### Returns

A pointer to animation group or NULL if the group with specified ID is not found.

#### Remarks

Use this method to find an animation group at runtime. A group is created and added to the internal list of animation groups
when a first animation object with particular GroupID is being added to animation controller.

#### Parameter `nGroupID`

Specifies a GroupID.

### `M:CAnimationController.AddKeyframeToGroup(System.UInt32,CBaseKeyFrame*)`

Member kind: method
Symbol: `CAnimationController.AddKeyframeToGroup(System.UInt32,CBaseKeyFrame*)`

#### Summary

Adds a keyframe to group.

#### Returns

TRUE if the function succeeds; otherwise FALSE.

#### Remarks

Usually you don't need to call this method, use CAnimationController::CreateKeyframe instead, which creates
and adds the created keyframe to a group automatically.

#### Parameter `nGroupID`

Specifies Group ID.

#### Parameter `pKeyframe`

A pointer to a keyframe.

### `M:CAnimationController.CreateKeyframe(System.UInt32,CBaseKeyFrame*,System.Double)`

Member kind: method
Symbol: `CAnimationController.CreateKeyframe(System.UInt32,CBaseKeyFrame*,System.Double)`

#### Summary

Creates a keyframe that depends on other keyframe with optional offset in seconds and adds it to the specified group.

#### Returns

A pointer to newly created keyframe if the function succeeds.

#### Remarks

You can store the returned pointer and base other keyframes on the newly created keyframe (see the second overload).
It's possible to begin transitions at keyframes - see CBaseTransition::SetKeyframes.
You don't need to delete keyframes created in this way, because they are deleted automatically by animation groups.
Be careful when creating keyframes based on other keyframes and transitions and avoid circular references.

#### Parameter `nGroupID`

Specifies Group ID for which keyframe is created.

#### Parameter `pKeyframe`

A pointer to base keyframe for this keyframe.

#### Parameter `offset`

Offset in seconds from the base keyframe specified by pKeyframe.

### `M:CAnimationController.CreateKeyframe(System.UInt32,CBaseTransition*)`

Member kind: method
Symbol: `CAnimationController.CreateKeyframe(System.UInt32,CBaseTransition*)`

#### Summary

Creates a keyframe that depends on transition and adds it to the specified group.

#### Returns

A pointer to newly created keyframe if the function succeeds.

#### Remarks

You can store the returned pointer and base other keyframes on the newly created keyframe (see the second overload).
It's possible to begin transitions at keyframes - see CBaseTransition::SetKeyframes.
You don't need to delete keyframes created in this way, because they are deleted automatically by animation groups.
Be careful when creating keyframes based on other keyframes and transitions and avoid circular references.

#### Parameter `nGroupID`

Specifies Group ID for which keyframe is created.

#### Parameter `pTransition`

A pointer to transition. Keyframe will be inserted to storyboard after this transition.

### `M:CAnimationController.RemoveTransitions(System.UInt32)`

Member kind: method
Symbol: `CAnimationController.RemoveTransitions(System.UInt32)`

#### Summary

Removes transitions from animation objects that belong to the specified group.

#### Remarks

The group loops over its animation objects and calls ClearTransitions(FALSE) for each animation object.
This method is called by the framework after animation has been scheduled.

#### Parameter `nGroupID`

Specifies Group ID.

### `M:CAnimationController.RemoveAllAnimationGroups`

Member kind: method
Symbol: `CAnimationController.RemoveAllAnimationGroups`

#### Summary

Removes all animation groups from animation controller.

#### Remarks

All groups will be deleted, their pointer, if stored at the application level, must be invalidated.
If CAnimationGroup::m_bAutodestroyAnimationObjects for a group being deleted is TRUE,
all animation objects that belong to that group will be deleted; otherwise their references to parent animation
controller will be set to NULL and they can be added to another controller.

### `M:CAnimationController.RemoveAnimationGroup(System.UInt32)`

Member kind: method
Symbol: `CAnimationController.RemoveAnimationGroup(System.UInt32)`

#### Summary

Removes an animation group with specified ID from animation controller.

#### Remarks

This method removes an animation group from the internal list of groups and deletes it, therefore if you stored
a pointer to that animation group, it must be invalidated. If CAnimationGroup::m_bAutodestroyAnimationObjects is TRUE,
all animation objects that belong to that group will be deleted; otherwise their references to parent animation
controller will be set to NULL and they can be added to another controller.

#### Parameter `nGroupID`

Specifies animation group ID.

### `M:CAnimationController.RemoveAnimationObject(CAnimationBaseObject*,System.Int32)`

Member kind: method
Symbol: `CAnimationController.RemoveAnimationObject(CAnimationBaseObject*,System.Int32)`

#### Summary

Remove an animation object from animation controller.

#### Remarks

Removes an animation object from animation controller and animation group. Call this function if
a particular object should not be animated anymore, or if you need to move the object to another animation controller.
In the last case bNoDelete must be TRUE.

#### Parameter `pObject`

A pointer to an animation object.

#### Parameter `bNoDelete`

If this parameter is TRUE the object will not be deleted upon remove.

### `M:CAnimationController.AddAnimationObject(CAnimationBaseObject*)`

Member kind: method
Symbol: `CAnimationController.AddAnimationObject(CAnimationBaseObject*)`

#### Summary

Adds an animation object to a group that belongs to the animation controller.

#### Returns

A pointer to existing or new animation group where pObject has been added if function succeeds; NULL if
pObject has already been added to a group that belongs to another animation controller.

#### Remarks

Call this method to add an animation object to the animation controller. An object will be added to a group
according to object's GroupID (see CAnimationBaseObject::SetID). The animation controller will create a new
group if it's the first object being added with the specified GroupID. An animation object can be added to
one animation controller only. If you need to add an object to another controller, call RemoveAnimationObject first.
If you call SetID with new GroupID for an object that has been already added to a group, the object will be removed
from the old group and added to another group with specified ID.

#### Parameter `pObject`

A pointer to an animation object.

### `M:CAnimationController.SetRelatedWnd(CWnd*)`

Member kind: method
Symbol: `CAnimationController.SetRelatedWnd(CWnd*)`

#### Summary

Establishes a relationship between animation controller and a window.

#### Remarks

If a related CWnd object is set, the animation controller can automatically update it (send WM_PAINT message) when
the status of animation manager has changed or timer post update event has occurred.

#### Parameter `pWnd`

A pointer to window object to set.

### `M:CAnimationController.IsAnimationInProgress`

Member kind: method
Symbol: `CAnimationController.IsAnimationInProgress`

#### Summary

Tells whether at least one group is playing animation.

#### Returns

TRUE if there is an animation in progress for this animation controller; otherwise FALSE.

#### Remarks

Checks status of animation manager and returns TRUE if the status is UI_ANIMATION_MANAGER_BUSY.

### `M:CAnimationController.UpdateAnimationManager`

Member kind: method
Symbol: `CAnimationController.UpdateAnimationManager`

#### Summary

Directs the animation manager to update the values of all animation variables.

#### Remarks

Calling this method advances the animation manager to current time, changing statuses of storyboards as necessary
and updating any animation variables to appropriate interpolated values. Internally this method calls
IUIAnimationTimer::GetTime(timeNow) and IUIAnimationManager::Update(timeNow). Override this method in a derived
class to customize this behavior.

### `M:CAnimationController.EnableAnimationTimerEventHandler(System.Int32,__MIDL___MIDL_itf_UIAnimation_0000_0012_0001)`

Member kind: method
Symbol: `CAnimationController.EnableAnimationTimerEventHandler(System.Int32,__MIDL___MIDL_itf_UIAnimation_0000_0012_0001)`

#### Summary

Sets or releases a handler for timing events and handler for timing updates.

#### Returns

TRUE if handlers were successfully set or released; FALSE if this method is called for a second time without
releasing the handlers first, or if any other error occurs.

#### Remarks

When the handlers are set (enabled) Windows Animation API calls OnAnimationTimerPreUpdate, OnAnimationTimerPostUpdate,
OnRenderingTooSlow methods.
You need to enable animation timers to allow Windows Animation API update storyboards. Otherwise you'll need to
call CAnimationController::UpdateAnimationManager in order to direct the animation manager to update the values
of all animation variables.

#### Parameter `bEnable`

Specifies whether to set or release the handlers.

#### Parameter `idleBehavior`

Specifies idle behavior for timer update handler.

### `M:CAnimationController.EnableStoryboardEventHandler(System.UInt32,System.Int32)`

Member kind: method
Symbol: `CAnimationController.EnableStoryboardEventHandler(System.UInt32,System.Int32)`

#### Summary

Sets or releases a handler for storyboard status and update events.

#### Returns

TRUE if the handler was successfully set or released; FALSE if the specified animation group is now found or
animation for the specified group has not been initiated and its internal storyboard is NULL.

#### Remarks

When a handler is set (enabled) Windows Animation API calls OnStoryboardStatusChanges and OnStoryboardUpdated virtual methods.
A handler must be set after CAnimationController::Animate has been called for the specified animation group, because
it creates encapsulated IUIAnimationStoryboard object.

#### Parameter `nGroupID`

Specifies Group ID.

#### Parameter `bEnable`

Specifies whether to set or release a handler.

### `M:CAnimationController.EnablePriorityComparisonHandler(System.UInt64)`

Member kind: method
Symbol: `CAnimationController.EnablePriorityComparisonHandler(System.UInt64)`

#### Summary

Sets or releases the priority comparison handler to call to determine whether a scheduled storyboard can be cancelled,
concluded, trimmed or compressed.

#### Returns

TRUE if the handler was successfully set or released.

#### Remarks

When a handler is set (enabled) Windows Animation calls the following virtual methods depending on dwHandlerType:
OnHasPriorityCancel, OnHasPriorityConclude, OnHasPriorityTrim, OnHasPriorityCompress.
dwHandler can be a combination of the following flags:
UI_ANIMATION_PHT_NONE - release all handlers
UI_ANIMATION_PHT_CANCEL - set Cancel comparison handler
UI_ANIMATION_PHT_CONCLUDE - set Conclude comparison handler
UI_ANIMATION_PHT_COMPRESS - set Compress comparison handler
UI_ANIMATION_PHT_TRIM - set Trim comparison handler
UI_ANIMATION_PHT_CANCEL_REMOVE - remove Cancel comparison handler
UI_ANIMATION_PHT_CONCLUDE_REMOVE - remove Conclude comparison handler
UI_ANIMATION_PHT_COMPRESS_REMOVE - remove Compress comparison handler
UI_ANIMATION_PHT_TRIM_REMOVE - remove Trim comparison handler

#### Parameter `dwHandlerType`

A combination of UI_ANIMATION_PHT_ flags (see remarks), which specifies what handlers to set or release.

### `M:CAnimationController.EnableAnimationManagerEvent(System.Int32)`

Member kind: method
Symbol: `CAnimationController.EnableAnimationManagerEvent(System.Int32)`

#### Summary

Sets or releases a handler to call when animation manager's status changes.

#### Returns

TRUE if the handler was successfully set or released.

#### Remarks

When a handler is set (enabled) Windows Animation calls OnAnimationManagerStatusChanged when animation manager's status changes.

#### Parameter `bEnable`

Specifies whether to set or release a handler.

### `M:CAnimationController.GetKeyframeStoryboardStart`

Member kind: method
Symbol: `CAnimationController.GetKeyframeStoryboardStart`

#### Summary

Returns a keyframe that identifies start of storyboard.

#### Returns

A pointer to base keyframe, which identifies start of storyboard.

#### Remarks

Obtain this keyframe to base any other keyframes or transitions on the moment in time when a storyboard starts.

### `M:CAnimationController.IsValid`

Member kind: method
Symbol: `CAnimationController.IsValid`

#### Summary

Tells whether animation controller is valid.

#### Returns

TRUE if animation controller is valid; otherwise FALSE.

#### Remarks

This method returns FALSE only if Windows Animation API is not supported on the current OS and creation of
animation manager failed because it's not registered. You need to call GetUIAnimationManager at least once after initialization of
COM libraries to cause setting of this flag.

### `M:CAnimationController.GetUITransitionFactory`

Member kind: method
Symbol: `CAnimationController.GetUITransitionFactory`

#### Summary

A pointer to IUIAnimationTransitionFactory interface or NULL, if creation of transition library failed.

#### Returns

A pointer to IUIAnimationTransitionFactory or NULL, if creation of transition factory failed.

#### Remarks

If current OS does not support Windows Animation API, this method returns NULL and after that all subsequent calls
on CAnimationController::IsValid return FALSE.

### `M:CAnimationController.GetUIAnimationTimer`

Member kind: method
Symbol: `CAnimationController.GetUIAnimationTimer`

#### Summary

Provides access to encapsulated IUIAnimationTimer object.

#### Returns

A pointer to IUIAnimationTimer interface or NULL, if creation of animation timer failed.

#### Remarks

If current OS does not support Windows Animation API, this method returns NULL and after that all subsequent calls
on CAnimationController::IsValid return FALSE.

### `M:CAnimationController.GetUITransitionLibrary`

Member kind: method
Symbol: `CAnimationController.GetUITransitionLibrary`

#### Summary

Provides access to encapsulated IUIAnimationTransitionLibrary object.

#### Returns

A pointer to IUIAnimationTransitionLibrary interface or NULL, if creation of transition library failed.

#### Remarks

If current OS does not support Windows Animation API, this method returns NULL and after that all subsequent calls
on CAnimationController::IsValid return FALSE.

### `M:CAnimationController.GetUIAnimationManager`

Member kind: method
Symbol: `CAnimationController.GetUIAnimationManager`

#### Summary

Provides access to encapsulated IUIAnimationManager object.

#### Returns

A pointer to IUIAnimationManager interface or NULL, if creation of animation manager failed.

#### Remarks

If current OS does not support Windows Animation API, this method returns NULL and after that all subsequent calls
on CAnimationController::IsValid return FALSE.
You may need to access IUIAnimationManager in order to call its interface methods, which are not wrapped by
animation controller.

### `M:CAnimationController.Dispose`

Member kind: method
Symbol: `CAnimationController.Dispose`

#### Summary

The destructor. Called when animation controller object is being destroyed.

### `M:CAnimationController.#ctor`

Member kind: method
Symbol: `CAnimationController.#ctor`

#### Summary

Constructs an animation controller.

### `F:CAnimationController.g_KeyframeStoryboardStart`

Member kind: field
Symbol: `CAnimationController.g_KeyframeStoryboardStart`

#### Summary

A keyframe that represents start of storyboard.

### `F:CAnimationController.m_lstAnimationGroups`

Member kind: field
Symbol: `CAnimationController.m_lstAnimationGroups`

#### Summary

A list of animation groups that belong to this animation controller.

### `F:CAnimationController.m_pRelatedWnd`

Member kind: field
Symbol: `CAnimationController.m_pRelatedWnd`

#### Summary

A pointer to a related CWnd object, which can be automatically redrawn when
the status of animation manager has changed, or post update event has occurred. Can be NULL.

### `F:CAnimationController.m_pTransitionFactory`

Member kind: field
Symbol: `CAnimationController.m_pTransitionFactory`

#### Summary

Stores a pointer to Transition Factory COM object.

### `F:CAnimationController.m_pAnimationTimer`

Member kind: field
Symbol: `CAnimationController.m_pAnimationTimer`

#### Summary

Stores a pointer to Animation Timer COM object.

### `F:CAnimationController.m_pTransitionLibrary`

Member kind: field
Symbol: `CAnimationController.m_pTransitionLibrary`

#### Summary

Stores a pointer to Transition Library COM object.

### `F:CAnimationController.m_pAnimationManager`

Member kind: field
Symbol: `CAnimationController.m_pAnimationManager`

#### Summary

Stores a pointer to Animation Manager COM object.

### `F:CAnimationController.m_bIsValid`

Member kind: field
Symbol: `CAnimationController.m_bIsValid`

#### Summary

Specifies whether an animation controller is valid or not.
This member is set to FALSE if current OS does not support Windows Animation API.

### `T:CAnimationController`

Member kind: type
Symbol: `CAnimationController`

#### Summary

Implements the animation controller, which provides a central interface for creating and managing UI animations.

#### Remarks

The CAnimationController class is the key class that manages animations.
You may create one or more instances of animation controller in an application and, optionally, connect an instance of
animation controller to a CWnd object using CAnimationController::SetRelatedWnd. This connection is required to send WM_PAINT messages
to the related window automatically when animation manager status has changed or animation timer has been updated.
If you do not enable this relation, you must redraw a window that displays an animation manually. For this purpose you can derive a class
from CAnimationController and override OnAnimationManagerStatusChanged and/or OnAnimationTimerPostUpdate and invalidate one or
more windows when necessary.

### `F:CAnimationGroup.m_bAutodestroyAnimationObjects`

Member kind: field
Symbol: `CAnimationGroup.m_bAutodestroyAnimationObjects`

#### Summary

Specifies how to destroy animation objects. If this parameter is TRUE, animation objects will be destroyed automatically
when the group is destroyed. Otherwise animation objects must be destroyed manually. The default value is FALSE.
Set this value to TRUE only if all animation objects that belong to group are allocated dynamically with operator new.

### `F:CAnimationGroup.m_bAutoclearTransitions`

Member kind: field
Symbol: `CAnimationGroup.m_bAutoclearTransitions`

#### Summary

Specifies how to clear transitions from animation objects that belong to group. If this member is TRUE,
transitions are removed automatically when an animation has been scheduled. Otherwise you need to remove
transitions manually.

### `F:CAnimationGroup.m_bAutodestroyKeyframes`

Member kind: field
Symbol: `CAnimationGroup.m_bAutodestroyKeyframes`

#### Summary

Specifies how to destroy keyframes. If this value is TRUE, all keyframes are removed and destroyed;
otherwise they are removed from the list only. The default value is TRUE.

### `F:CAnimationGroup.m_pStoryboard`

Member kind: field
Symbol: `CAnimationGroup.m_pStoryboard`

#### Summary

Points to animation storyboard. This pointer is valid only after call on Animate.

### `F:CAnimationGroup.m_lstKeyFrames`

Member kind: field
Symbol: `CAnimationGroup.m_lstKeyFrames`

#### Summary

Contains a list of keyframes.

### `F:CAnimationGroup.m_lstAnimationObjects`

Member kind: field
Symbol: `CAnimationGroup.m_lstAnimationObjects`

#### Summary

Contains a list of animation objects.

### `M:CAnimationGroup.SetAutodestroyTransitions(System.Int32)`

Member kind: method
Symbol: `CAnimationGroup.SetAutodestroyTransitions(System.Int32)`

#### Summary

Directs all animation objects that belong to group automatically destroy transitions.

#### Remarks

Set this value to FALSE only if you allocate transitions on the stack. The default value is TRUE, therefore
it's highly recommended to allocate transition objects using operator new.

#### Parameter `bAutoDestroy`

Specifies how to destroy transitions.

### `M:CAnimationGroup.Schedule(IUIAnimationTimer*,System.Double)`

Member kind: method
Symbol: `CAnimationGroup.Schedule(IUIAnimationTimer*,System.Double)`

#### Summary

Schedules an animation at the specified time.

#### Returns

TRUE if the method succeeds; FALSE if the method fails or if Animate has not been called with bScheduleNow set to FALSE.

#### Remarks

Call this function to schedule an animation at the specified time. You must call Animate with bScheduleNow set to FALSE first.

#### Parameter `pTimer`

A pointer to animation timer.

#### Parameter `time`

Specifies time to schedule the animation.

### `M:CAnimationGroup.Animate(IUIAnimationManager*,IUIAnimationTimer*,System.Int32)`

Member kind: method
Symbol: `CAnimationGroup.Animate(IUIAnimationManager*,IUIAnimationTimer*,System.Int32)`

#### Summary

Animates a group.

#### Returns

TRUE if the method succeeds; otherwise FALSE.

#### Remarks

This method creates an internal storyboard, creates and applies transitions and schedules an animation
if bScheduleNow is TRUE. If bScheduleNow is FALSE, you need to call Schedule to start animation at the
specified time.

### `M:CAnimationGroup.FindAnimationObject(IUIAnimationVariable*)`

Member kind: method
Symbol: `CAnimationGroup.FindAnimationObject(IUIAnimationVariable*)`

#### Summary

Finds an animation object that contains the specified animation variable.

#### Returns

A pointer to animation object, or NULL if animation object is not found.

#### Parameter `pVariable`

A pointer to animation variable.

### `M:CAnimationGroup.RemoveKeyframes`

Member kind: method
Symbol: `CAnimationGroup.RemoveKeyframes`

#### Summary

Removes and optionally destroys all keyframes that belong to an animation group.

#### Remarks

If m_bAutodestroyKeyframes member is TRUE then keyframes are removed and destroyed, otherwise keyframes are
just removed from the internal list of keyframes.

### `M:CAnimationGroup.RemoveTransitions`

Member kind: method
Symbol: `CAnimationGroup.RemoveTransitions`

#### Summary

Removes transitions from animation objects that belong to an animation group.

#### Remarks

If m_bAutoclearTransitions flag is set to TRUE, this method loops over all animation objects that belong to the group
and calls CAnimationObject::ClearTransitions(FALSE).

### `M:CAnimationGroup.ApplyTransitions`

Member kind: method
Symbol: `CAnimationGroup.ApplyTransitions`

#### Summary

Applies transitions to animation objects.

#### Remarks

This method ASSERTS in debug mode if storyboard has not been created.
It creates all transitions first, then adds "static" keyframes (keyframes that depend on offsets),
adds transitions that do not depend on keyframes, adds keyframes depending on transitions and other keyframes,
and at last adds transitions that depend on keyframes.

### `M:CAnimationGroup.GetGroupID`

Member kind: method
Symbol: `CAnimationGroup.GetGroupID`

#### Summary

Returns GroupID.

#### Returns

A group identifier.

### `M:CAnimationGroup.Dispose`

Member kind: method
Symbol: `CAnimationGroup.Dispose`

#### Summary

The destructor. Called when an animation group is being destroyed.

### `M:CAnimationGroup.#ctor(CAnimationController*,System.UInt32)`

Member kind: method
Symbol: `CAnimationGroup.#ctor(CAnimationController*,System.UInt32)`

#### Summary

Constructs an animation group.

#### Parameter `pParentController`

A pointer to animation controller that creates a group.

#### Parameter `nGroupID`

Specifies GroupID.

### `M:CAnimationGroup.CreateTransitions`

Member kind: method
Symbol: `CAnimationGroup.CreateTransitions`

#### Summary

A helper that creates COM transition objects.

#### Returns

TRUE is the method succeeds, otherwise FALSE.

### `M:CAnimationGroup.AddTransitions(IUIAnimationStoryboard*,System.Int32)`

Member kind: method
Symbol: `CAnimationGroup.AddTransitions(IUIAnimationStoryboard*,System.Int32)`

#### Summary

A helper that adds transitions to a storyboard.

#### Parameter `pStoryboard`

A pointer to a storyboard COM object.

#### Parameter `bDependOnKeyframes`

Specifies whether this method should add to the storyboard transitions that depend on other keyframes.

### `M:CAnimationGroup.AddKeyframes(IUIAnimationStoryboard*,System.Int32)`

Member kind: method
Symbol: `CAnimationGroup.AddKeyframes(IUIAnimationStoryboard*,System.Int32)`

#### Summary

A helper that adds keyframes to a storyboard.

#### Parameter `pStoryboard`

A pointer to a storyboard COM object.

#### Parameter `bAddDeep`

Specifies whether this method should add to the storyboard keyframes that depend on other keyframes.

### `F:CAnimationGroup.m_pParentController`

Member kind: field
Symbol: `CAnimationGroup.m_pParentController`

#### Summary

A pointer to animation controller this group belongs to.

### `F:CAnimationGroup.m_nGroupID`

Member kind: field
Symbol: `CAnimationGroup.m_nGroupID`

#### Summary

A unique identifier of animation group.

### `T:CAnimationGroup`

Member kind: type
Symbol: `CAnimationGroup`

#### Summary

Implements an animation group, which combines an animation storyboard, animation objects and transitions
to define an animation.

#### Remarks

Animation groups are created automatically by animation controller (CAnimationController) when you add animation
objects using CAnimationController::AddAnimationObject.
An animation group is identified by GroupID, which is usually taken as a parameter to manipulate animation groups.
The GroupID is taken from the first animation object being added to a new animation group.
An encapsulated animation storyboard is created after you call CAnimationController::AnimateGroup and can be
accessed via public member m_pStoryboard.

### `M:CAnimationRect.GetAnimationVariableList(CList<CAnimationVariable**,CAnimationVariable**>*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CAnimationRect.GetAnimationVariableList(CList<CAnimationVariable**,CAnimationVariable**>*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Puts the encapsulated animation variables into a list.

#### Parameter `lst`

When the function returns, it contains pointers to four CAnimationVariable objects
representing coordinates of rectangle.

### `F:CAnimationRect.m_bFixedSize`

Member kind: field
Symbol: `CAnimationRect.m_bFixedSize`

#### Summary

Specifies whether the rectangle has fixed size.

#### Remarks

If this member is true, then the size of rectangle is fixed and right and bottom values
are recalculated each time the top-left corner is moved according to the fixed size.
Set this value to TRUE to easily move the rectangle around the screen. In this case transitions applied to
right and bottom coordinates are ignored. The size is stored internally when you construct the object and/or
call SetDefaultValue. By default this member is set to FALSE.

### `M:CAnimationRect.AddTransition(CBaseTransition*,CBaseTransition*,CBaseTransition*,CBaseTransition*)`

Member kind: method
Symbol: `CAnimationRect.AddTransition(CBaseTransition*,CBaseTransition*,CBaseTransition*,CBaseTransition*)`

#### Summary

Adds transitions for left, top, right and bottom coordinates.

#### Remarks

Call this function to add the specified transitions to the internal list of transitions to be applied to animation variables for each rectangle sides.
When you add transitions, they are not applied immediately and stored in an internal list. Transitions are applied
(added to a storyboard for a particular value) when you call CAnimationController::AnimateGroup.
If you don't need to apply a transition to one of the rectangle sides, you can pass NULL.

#### Parameter `pLeftTransition`

Specifies transition for the left side.

#### Parameter `pTopTransition`

Specifies transition for the top side.

#### Parameter `pRightTransition`

Specifies transition for the right side.

#### Parameter `pBottomTransition`

Specifies transition for the bottom side.

### `M:CAnimationRect.op_Implicit~tagRECT`

Member kind: method
Symbol: `CAnimationRect.op_Implicit~tagRECT`

#### Summary

Converts a CAnimationRect to RECT.

#### Returns

Current value of animation rectangle as RECT.

#### Remarks

This function internally calls GetValue. If GetValue for some reason fails, the returned RECT will contain default values for all rectangle coordinates.

### `M:CAnimationRect.op_Assign(tagRECT!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CAnimationRect.op_Assign(tagRECT!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Assigns rect to CAnimationRect.

#### Remarks

It's recommended to do that before animation start, because this operator calls
SetDefaultValue, which recreates the underlying COM objects for color components if they have been created. If you
subscribed this animation object to events (ValueChanged or IntegerValueChanged), you need to re-enable these events.

#### Parameter `rect`

The new value of animation rectangle.

### `M:CAnimationRect.GetBottom`

Member kind: method
Symbol: `CAnimationRect.GetBottom`

#### Summary

Provides access to CAnimationVariable representing bottom coordinate.

#### Returns

A reference to encapsulated CAnimationVariable representing bottom coordinate.

#### Remarks

You can call this method to get direct access to underlying CAnimationVariable representing the bottom coordinate.

### `M:CAnimationRect.GetRight`

Member kind: method
Symbol: `CAnimationRect.GetRight`

#### Summary

Provides access to CAnimationVariable representing right coordinate.

#### Returns

A reference to encapsulated CAnimationVariable representing right coordinate.

#### Remarks

You can call this method to get direct access to underlying CAnimationVariable representing the right coordinate.

### `M:CAnimationRect.GetTop`

Member kind: method
Symbol: `CAnimationRect.GetTop`

#### Summary

Provides access to CAnimationVariable representing top coordinate.

#### Returns

A reference to encapsulated CAnimationVariable representing top coordinate.

#### Remarks

You can call this method to get direct access to underlying CAnimationVariable representing the top coordinate.

### `M:CAnimationRect.GetLeft`

Member kind: method
Symbol: `CAnimationRect.GetLeft`

#### Summary

Provides access to CAnimationVariable representing left coordinate.

#### Returns

A reference to encapsulated CAnimationVariable representing left coordinate.

#### Remarks

You can call this method to get direct access to underlying CAnimationVariable representing the left coordinate.

### `M:CAnimationRect.GetValue(CRect*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CAnimationRect.GetValue(CRect*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Returns current value.

#### Returns

TRUE, if the current value was successfully retrieved; otherwise FALSE.

#### Remarks

Call this function to retrieve the current value of animation rectangle. If this method fails or underlying COM objects for
left, top, right and bottom have not been initialized, rect contains default value, which was previously set in constructor or by SetDefaultValue.

#### Parameter `rect`

Output. Contains the current value when this method returns.

### `M:CAnimationRect.GetDefaultValue`

Member kind: method
Symbol: `CAnimationRect.GetDefaultValue`

#### Summary

Returns the default values for rectangle's bounds.

#### Returns

A CRect value containing defaults for left, right, top and bottom.

#### Remarks

Call this function to retrieve default value, which was previously set by constructor or SetDefaultValue.

### `M:CAnimationRect.SetDefaultValue(CRect!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CAnimationRect.SetDefaultValue(CRect!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Sets default value.

#### Remarks

Use this function to set a default value to animation object. This methods assigns default values to rectangle's bounds.
It also recreates underlying COM objects if they have been created. If you
subscribed this animation object to events (ValueChanged or IntegerValueChanged), you need to re-enable these events.

#### Parameter `rect`

Specifies new default values for left, top, right and bottom.

### `M:CAnimationRect.#ctor(System.Int32,System.Int32,System.Int32,System.Int32,System.UInt32,System.UInt32,System.UInt64)`

Member kind: method
Symbol: `CAnimationRect.#ctor(System.Int32,System.Int32,System.Int32,System.Int32,System.UInt32,System.UInt32,System.UInt64)`

#### Summary

Constructs an animation rect object.

#### Remarks

The object is constructed with specified coordinates of each side, Object ID and Group ID. They can be changed
later at runtime using SetDefaultValue and SetID.

#### Parameter `nLeft`

Specifies coordinate of left bound.

#### Parameter `nTop`

Specifies coordinate of top bound.

#### Parameter `nRight`

Specifies coordinate of right bound.

#### Parameter `nBottom`

Specifies coordinate of bottom bound.

#### Parameter `nGroupID`

Specifies Group ID.

#### Parameter `nObjectID`

Specifies Object ID.

#### Parameter `dwUserData`

Specifies user-defined data.

### `M:CAnimationRect.#ctor(CPoint!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CSize!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.UInt32,System.UInt32,System.UInt64)`

Member kind: method
Symbol: `CAnimationRect.#ctor(CPoint!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CSize!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.UInt32,System.UInt32,System.UInt64)`

#### Summary

Constructs an animation rect object.

#### Remarks

The object is constructed with specified top-left corner coordinates and size of rectangle, Object ID and Group ID. They can be changed
later at runtime using SetDefaultValue and SetID.

#### Parameter `pt`

Coordinate of top-left corner.

#### Parameter `sz`

Size of rectangle.

#### Parameter `nGroupID`

Specifies Group ID.

#### Parameter `nObjectID`

Specifies Object ID.

#### Parameter `dwUserData`

Specifies user-defined data.

### `M:CAnimationRect.#ctor(CRect!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.UInt32,System.UInt32,System.UInt64)`

Member kind: method
Symbol: `CAnimationRect.#ctor(CRect!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.UInt32,System.UInt32,System.UInt64)`

#### Summary

Constructs an animation rect object.

#### Remarks

The object is constructed with specified rect coordinates, Object ID and Group ID. They can be changed
later at runtime using SetDefaultValue and SetID.

#### Parameter `rect`

Specifies default rectangle.

#### Parameter `nGroupID`

Specifies Group ID.

#### Parameter `nObjectID`

Specifies Object ID.

#### Parameter `dwUserData`

Specifies user-defined data.

### `M:CAnimationRect.#ctor`

Member kind: method
Symbol: `CAnimationRect.#ctor`

#### Summary

Constructs a CAnimationRect object.

#### Remarks

The object is constructed with default values for left, top, right and bottom, Object ID and Group ID, which will be set to 0. They can be changed
later at runtime using SetDefaultValue and SetID.

### `F:CAnimationRect.m_szInitial`

Member kind: field
Symbol: `CAnimationRect.m_szInitial`

#### Summary

Specifies initial size of animation rectangle.

### `F:CAnimationRect.m_bottomValue`

Member kind: field
Symbol: `CAnimationRect.m_bottomValue`

#### Summary

The encapsulated animation variable that represents Bottom bound of animation rectangle.

### `F:CAnimationRect.m_rightValue`

Member kind: field
Symbol: `CAnimationRect.m_rightValue`

#### Summary

The encapsulated animation variable that represents Right bound of animation rectangle.

### `F:CAnimationRect.m_topValue`

Member kind: field
Symbol: `CAnimationRect.m_topValue`

#### Summary

The encapsulated animation variable that represents Top bound of animation rectangle.

### `F:CAnimationRect.m_leftValue`

Member kind: field
Symbol: `CAnimationRect.m_leftValue`

#### Summary

The encapsulated animation variable that represents Left bound of animation rectangle.

### `T:CAnimationRect`

Member kind: type
Symbol: `CAnimationRect`

#### Summary

Implements the functionality of a rectangle whose top, left, right and bottom sides can be animated.

#### Remarks

The CAnimationRect class encapsulates four CAnimationVariable objects and can represent in applications
a rectangle.
To use this class in application, just instantiate an object of this class, add it to animation controller using
CAnimationController::AddAnimationObject and call AddTransition for each transition to be applied to left, right top and bottom coordinates.

### `M:CAnimationColor.GetAnimationVariableList(CList<CAnimationVariable**,CAnimationVariable**>*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CAnimationColor.GetAnimationVariableList(CList<CAnimationVariable**,CAnimationVariable**>*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Puts the encapsulated animation variables into a list.

#### Parameter `lst`

When the function returns, it contains pointers to three CAnimationVariable objects
representing red, green and blue components.

### `M:CAnimationColor.AddTransition(CBaseTransition*,CBaseTransition*,CBaseTransition*)`

Member kind: method
Symbol: `CAnimationColor.AddTransition(CBaseTransition*,CBaseTransition*,CBaseTransition*)`

#### Summary

Adds transitions for Red, Green and Blue components.

#### Remarks

Call this function to add the specified transitions to the internal list of transitions to be applied to animation variables representing color components.
When you add transitions, they are not applied immediately and stored in an internal list. Transitions are applied
(added to a storyboard for a particular value) when you call CAnimationController::AnimateGroup.
If you don't need to apply a transition to one of the color components, you can pass NULL.

#### Parameter `pRTransition`

Transition for Red component.

#### Parameter `pGTransition`

Transition for Green component.

#### Parameter `pBTransition`

Transition for Blue component.

### `M:CAnimationColor.op_Implicit~System.UInt32!System.Runtime.CompilerServices.IsLong`

Member kind: method
Symbol: `CAnimationColor.op_Implicit~System.UInt32!System.Runtime.CompilerServices.IsLong`

#### Summary

Converts a CAnimationColor to COLORREF.

#### Returns

Current value of animation color object as COLORREF.

#### Remarks

This function internally calls GetValue. If GetValue for some reason fails, the returned COLORREF will contain default values for all color components.

### `M:CAnimationColor.op_Assign(System.UInt32!System.Runtime.CompilerServices.IsLong)`

Member kind: method
Symbol: `CAnimationColor.op_Assign(System.UInt32!System.Runtime.CompilerServices.IsLong)`

#### Summary

Assigns color to CAnimationColor.

#### Remarks

It's recommended to do that before animation start, because this operator calls
SetDefaultValue, which recreates the underlying COM objects for color components if they have been created. If you
subscribed this animation object to events (ValueChanged or IntegerValueChanged), you need to re-enable these events.

#### Parameter `color`

Specifies new value Animation Color.

### `M:CAnimationColor.GetB`

Member kind: method
Symbol: `CAnimationColor.GetB`

#### Summary

Provides access to CAnimationVariable representing Blue component.

#### Returns

A reference to encapsulated CAnimationVariable representing Blue component.

#### Remarks

You can call this method to get direct access to underlying CAnimationVariable representing Blue component.

### `M:CAnimationColor.GetG`

Member kind: method
Symbol: `CAnimationColor.GetG`

#### Summary

Provides access to CAnimationVariable representing Green component.

#### Returns

A reference to encapsulated CAnimationVariable representing Green component.

#### Remarks

You can call this method to get direct access to underlying CAnimationVariable representing Green component.

### `M:CAnimationColor.GetR`

Member kind: method
Symbol: `CAnimationColor.GetR`

#### Summary

Provides access to CAnimationVariable representing Red component.

#### Returns

A reference to encapsulated CAnimationVariable representing Red component.

#### Remarks

You can call this method to get direct access to underlying CAnimationVariable representing Red component.

### `M:CAnimationColor.GetValue(System.UInt32!System.Runtime.CompilerServices.IsLong*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CAnimationColor.GetValue(System.UInt32!System.Runtime.CompilerServices.IsLong*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Returns current value.

#### Returns

TRUE, if the current value was successfully retrieved; otherwise FALSE.

#### Remarks

Call this function to retrieve the current value of animation color. If this method fails or underlying COM objects for
color components have not been initialized, color contains default value, which was previously set in constructor or by SetDefaultValue.

#### Parameter `color`

Output. Contains the current value when this method returns.

### `M:CAnimationColor.GetDefaultValue`

Member kind: method
Symbol: `CAnimationColor.GetDefaultValue`

#### Summary

Returns the default values for color components.

#### Returns

A COLORREF value containing defaults for RGB components.

#### Remarks

Call this function to retrieve default value, which was previously set by constructor or SetDefaultValue.

### `M:CAnimationColor.SetDefaultValue(System.UInt32!System.Runtime.CompilerServices.IsLong)`

Member kind: method
Symbol: `CAnimationColor.SetDefaultValue(System.UInt32!System.Runtime.CompilerServices.IsLong)`

#### Summary

Sets default value.

#### Remarks

Use this function to set a default value to animation object. This methods assigns default values to color components
of animation color. It also recreates underlying COM objects if they have been created. If you
subscribed this animation object to events (ValueChanged or IntegerValueChanged), you need to re-enable these events.

#### Parameter `color`

Specifies new default values for red, green and blue components.

### `M:CAnimationColor.#ctor(System.UInt32!System.Runtime.CompilerServices.IsLong,System.UInt32,System.UInt32,System.UInt64)`

Member kind: method
Symbol: `CAnimationColor.#ctor(System.UInt32!System.Runtime.CompilerServices.IsLong,System.UInt32,System.UInt32,System.UInt64)`

#### Summary

Constructs an animation color object.

#### Remarks

The object is constructed with specified values for RGB components, Object ID and Group ID. They can be changed
later at runtime using SetDefaultValue and SetID.

#### Parameter `color`

Specifies default color.

#### Parameter `nGroupID`

Specifies Group ID.

#### Parameter `nObjectID`

Specifies Object ID.

#### Parameter `dwUserData`

Specifies user-defined data.

### `M:CAnimationColor.#ctor`

Member kind: method
Symbol: `CAnimationColor.#ctor`

#### Summary

Constructs a CAnimationColor object.

#### Remarks

The object is constructed with default values for red, green, blue, Object ID and Group ID, which will be set to 0. They can be changed
later at runtime using SetDefaultValue and SetID.

### `F:CAnimationColor.m_bValue`

Member kind: field
Symbol: `CAnimationColor.m_bValue`

#### Summary

The encapsulated animation variable that represents Blue component of animation color.

### `F:CAnimationColor.m_gValue`

Member kind: field
Symbol: `CAnimationColor.m_gValue`

#### Summary

The encapsulated animation variable that represents Green component of animation color.

### `F:CAnimationColor.m_rValue`

Member kind: field
Symbol: `CAnimationColor.m_rValue`

#### Summary

The encapsulated animation variable that represents Red component of animation color.

### `T:CAnimationColor`

Member kind: type
Symbol: `CAnimationColor`

#### Summary

Implements the functionality of a color whose red, green and blue components can be animated.

#### Remarks

The CAnimationColor class encapsulates three CAnimationVariable objects and can represent in applications
a color. For example, you can use this class to animate colors of any object on the screen (like text color, background color etc).
To use this class in application, just instantiate an object of this class, add it to animation controller using
CAnimationController::AddAnimationObject and call AddTransition for each transition to be applied to Red, Green and Blue components.

### `M:CAnimationSize.GetAnimationVariableList(CList<CAnimationVariable**,CAnimationVariable**>*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CAnimationSize.GetAnimationVariableList(CList<CAnimationVariable**,CAnimationVariable**>*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Puts the encapsulated animation variables into a list.

#### Parameter `lst`

When the function returns, it contains pointers to two CAnimationVariable objects
representing the width and height.

### `M:CAnimationSize.AddTransition(CBaseTransition*,CBaseTransition*)`

Member kind: method
Symbol: `CAnimationSize.AddTransition(CBaseTransition*,CBaseTransition*)`

#### Summary

Adds transitions for Width and Height.

#### Remarks

Call this function to add the specified transitions to the internal list of transitions to be applied to animation variables for Width and Height.
When you add transitions, they are not applied immediately and stored in an internal list. Transitions are applied
(added to a storyboard for a particular value) when you call CAnimationController::AnimateGroup.
If you don't need to apply a transition to one of dimensions, you can pass NULL.

#### Parameter `pCXTransition`

A pointer to transition for Width.

#### Parameter `pCYTransition`

A pointer to transition for Height.

### `M:CAnimationSize.op_Implicit~CSize`

Member kind: method
Symbol: `CAnimationSize.op_Implicit~CSize`

#### Summary

Converts a CAnimationSize to a CSize.

#### Returns

Current value of animation size as CSize.

#### Remarks

This function internally calls GetValue. If GetValue for some reason fails, the returned size will contain default values for Width and Height.

### `M:CAnimationSize.op_Assign(CSize!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CAnimationSize.op_Assign(CSize!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Assigns szSrc to CAnimationSize.

#### Remarks

Assigns szSrc to CAnimationSize. It's recommended to do that before animation start, because this operator calls
SetDefaultValue, which recreates the underlying COM objects for Width and Height if they have been created. If you
subscribed this animation object to events (ValueChanged or IntegerValueChanged), you need to re-enable these events.

#### Parameter `szSrc`

Refers to CSize or SIZE.

### `M:CAnimationSize.GetCY`

Member kind: method
Symbol: `CAnimationSize.GetCY`

#### Summary

Provides access to CAnimationVariable representing Height.

#### Returns

A reference to encapsulated CAnimationVariable representing Height.

#### Remarks

You can call this method to get direct access to underlying CAnimationVariable representing Height.

### `M:CAnimationSize.GetCX`

Member kind: method
Symbol: `CAnimationSize.GetCX`

#### Summary

Provides access to CAnimationVariable representing Width.

#### Returns

A reference to encapsulated CAnimationVariable representing Width.

#### Remarks

You can call this method to get direct access to underlying CAnimationVariable representing Width.

### `M:CAnimationSize.GetValue(CSize*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CAnimationSize.GetValue(CSize*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Returns current value.

#### Returns

TRUE, if the current value was successfully retrieved; otherwise FALSE.

#### Remarks

Call this function to retrieve the current value of animation size. If this method fails or underlying COM objects for
Width and Size have not been initialized, szValue contains default value, which was previously set in constructor or by SetDefaultValue.

#### Parameter `szValue`

Output. Contains the current value when this method returns.

### `M:CAnimationSize.GetDefaultValue`

Member kind: method
Symbol: `CAnimationSize.GetDefaultValue`

#### Summary

Returns the default values for Width and Height.

#### Returns

A CSize object containing default values.

#### Remarks

Call this function to retrieve default value, which was previously set by constructor or SetDefaultValue.

### `M:CAnimationSize.SetDefaultValue(CSize!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CAnimationSize.SetDefaultValue(CSize!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Sets default value.

#### Remarks

Use this function to set a default value to animation object. This methods assigns default values to Width and Height
of animation size. It also recreates underlying COM objects if they have been created. If you
subscribed this animation object to events (ValueChanged or IntegerValueChanged), you need to re-enable these events.

#### Parameter `szDefault`

Specifies new default size.

### `M:CAnimationSize.#ctor(CSize!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.UInt32,System.UInt32,System.UInt64)`

Member kind: method
Symbol: `CAnimationSize.#ctor(CSize!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.UInt32,System.UInt32,System.UInt64)`

#### Summary

Constructs an animation size object.

#### Remarks

The object is constructed with specified values for width, height, Object ID and Group ID. They can be changed
later at runtime using SetDefaultValue and SetID.

#### Parameter `szDefault`

Specifies default size.

#### Parameter `nGroupID`

Specifies Group ID.

#### Parameter `nObjectID`

Specifies Object ID.

#### Parameter `dwUserData`

Specifies user-defined data.

### `M:CAnimationSize.#ctor`

Member kind: method
Symbol: `CAnimationSize.#ctor`

#### Summary

Constructs an animation size object.

#### Remarks

The object is constructed with default values for width, height, Object ID and Group ID, which will be set to 0. They can be changed
later at runtime using SetDefaultValue and SetID.

### `F:CAnimationSize.m_cyValue`

Member kind: field
Symbol: `CAnimationSize.m_cyValue`

#### Summary

The encapsulated animation variable that represents height of animation size.

### `F:CAnimationSize.m_cxValue`

Member kind: field
Symbol: `CAnimationSize.m_cxValue`

#### Summary

The encapsulated animation variable that represents width of animation size.

### `T:CAnimationSize`

Member kind: type
Symbol: `CAnimationSize`

#### Summary

Implements the functionality of a size object whose dimensions can be animated.

#### Remarks

The CAnimationSize class encapsulates two CAnimationVariable objects and can represent in applications
a size. For example, you can use this class to animate a size of any two dimensional object on the screen (like rectangle, control etc).
To use this class in application, just instantiate an object of this class, add it to animation controller using
CAnimationController::AddAnimationObject and call AddTransition for each transition to be applied to Width and/or Height.

### `M:CAnimationPoint.GetAnimationVariableList(CList<CAnimationVariable**,CAnimationVariable**>*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CAnimationPoint.GetAnimationVariableList(CList<CAnimationVariable**,CAnimationVariable**>*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Puts the encapsulated animation variables into a list.

#### Parameter `lst`

When the function returns, it contains pointers to two CAnimationVariable objects
representing the X and Y coordinates.

### `M:CAnimationPoint.AddTransition(CBaseTransition*,CBaseTransition*)`

Member kind: method
Symbol: `CAnimationPoint.AddTransition(CBaseTransition*,CBaseTransition*)`

#### Summary

Adds transitions for X and Y coordinates.

#### Remarks

Call this function to add the specified transitions to the internal list of transitions to be applied to animation variables for X and Y coordinates.
When you add transitions, they are not applied immediately and stored in an internal list. Transitions are applied
(added to a storyboard for a particular value) when you call CAnimationController::AnimateGroup.
If you don't need to apply a transition to one of coordinates, you can pass NULL.

#### Parameter `pXTransition`

A pointer to transition for X coordinates.

#### Parameter `pYTransition`

A pointer to transition for Y coordinate.

### `M:CAnimationPoint.GetY`

Member kind: method
Symbol: `CAnimationPoint.GetY`

#### Summary

Provides access to CAnimationVariable for Y coordinate.

#### Returns

A reference to encapsulated CAnimationVariable representing Y coordinate.

#### Remarks

You can call this method to get direct access to underlying CAnimationVariable representing Y coordinate.

### `M:CAnimationPoint.GetX`

Member kind: method
Symbol: `CAnimationPoint.GetX`

#### Summary

Provides access to CAnimationVariable for X coordinate.

#### Returns

A reference to encapsulated CAnimationVariable representing X coordinate.

#### Remarks

You can call this method to get direct access to underlying CAnimationVariable representing X coordinate.

### `M:CAnimationPoint.op_Implicit~CPoint`

Member kind: method
Symbol: `CAnimationPoint.op_Implicit~CPoint`

#### Summary

Converts a CAnimationPoint to a CPoint.

#### Returns

Current value of CAnimationPoint as CPoint.

#### Remarks

This function internally calls GetValue. If GetValue for some reason fails, the returned point will contain default values for X and Y coordinates.

### `M:CAnimationPoint.op_Assign(CPoint!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CAnimationPoint.op_Assign(CPoint!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Assigns ptSrc to CAnimationPoint.

#### Remarks

Assigns ptSrc to CAnimationPoint. It's recommended to do that before animation start, because this operator calls
SetDefaultValue, which recreates the underlying COM objects for X and Y coordinates if they have been created. If you
subscribed this animation object to events (ValueChanged or IntegerValueChanged), you need to re-enable these events.

#### Parameter `ptSrc`

Refers to CPoint or POINT.

### `M:CAnimationPoint.GetValue(CPoint*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CAnimationPoint.GetValue(CPoint*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Returns current value.

#### Returns

TRUE, if the current value was successfully retrieved; otherwise FALSE.

#### Remarks

Call this function to retrieve the current value of animation point. If this method fails or underlying COM objects for
X and Y coordinates have not been initialized, ptValue contains default
value, which was previously set in constructor or by SetDefaultValue.

#### Parameter `ptValue`

Output. Contains the current value when this method returns.

### `M:CAnimationPoint.GetDefaultValue`

Member kind: method
Symbol: `CAnimationPoint.GetDefaultValue`

#### Summary

Returns the default values for X and Y coordinates.

#### Returns

A point containing default value.

#### Remarks

Call this function to retrieve default value, which was previously set by constructor or SetDefaultValue.

### `M:CAnimationPoint.SetDefaultValue(tagPOINT!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CAnimationPoint.SetDefaultValue(tagPOINT!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Sets default value.

#### Remarks

Use this function to set a default value to animation object. This methods assigns default values to X and Y
coordinates of animation point. It also recreates underlying COM objects if they have been created. If you
subscribed this animation object to events (ValueChanged or IntegerValueChanged), you need to re-enable these events.

#### Parameter `ptDefault`

Specifies the default point value.

### `M:CAnimationPoint.#ctor(CPoint!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.UInt32,System.UInt32,System.UInt64)`

Member kind: method
Symbol: `CAnimationPoint.#ctor(CPoint!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,System.UInt32,System.UInt32,System.UInt64)`

#### Summary

Constructs CAnimationPoint object.

#### Remarks

Constructs CAnimationPoint object with specified properties.

#### Parameter `ptDefault`

Specifies default point coordinates.

#### Parameter `nGroupID`

Specifies Group ID.

#### Parameter `nObjectID`

Specifies Object ID.

#### Parameter `dwUserData`

Specifies user-defined data.

### `M:CAnimationPoint.#ctor`

Member kind: method
Symbol: `CAnimationPoint.#ctor`

#### Summary

Constructs CAnimationPoint object.

#### Remarks

Constructs CAnimationPoint object with default properties: default point coordinates, Group ID and Object ID are set to 0.

### `F:CAnimationPoint.m_yValue`

Member kind: field
Symbol: `CAnimationPoint.m_yValue`

#### Summary

The encapsulated animation variable that represents Y coordinate of animation point.

### `F:CAnimationPoint.m_xValue`

Member kind: field
Symbol: `CAnimationPoint.m_xValue`

#### Summary

The encapsulated animation variable that represents X coordinate of animation point.

### `T:CAnimationPoint`

Member kind: type
Symbol: `CAnimationPoint`

#### Summary

Implements the functionality of a point whose coordinates can be animated.

#### Remarks

The CAnimationPoint class encapsulates two CAnimationVariable objects and can represent in applications
a point. For example, you can use this class to animate a position of any object on the screen (like text string, circle, point etc).
To use this class in application, just instantiate an object of this class, add it to animation controller using
CAnimationController::AddAnimationObject and call AddTransition for each transition to be applied to X and/or Y coordinates.

### `M:CAnimationValue.GetAnimationVariableList(CList<CAnimationVariable**,CAnimationVariable**>*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CAnimationValue.GetAnimationVariableList(CList<CAnimationVariable**,CAnimationVariable**>*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Puts the encapsulated animation variable into a list.

#### Parameter `lst`

When the function returns, it contains a pointer to CAnimationVariable representing the animated value.

### `M:CAnimationValue.AddTransition(CBaseTransition*)`

Member kind: method
Symbol: `CAnimationValue.AddTransition(CBaseTransition*)`

#### Summary

Adds a transition to be applied to a value.

#### Remarks

Call this function to add a transition to internal list of transitions to be applied to an animation variable.
When you add transitions, they are not applied immediately and stored in an internal list. Transitions are applied
(added to a storyboard for a particular value) when you call CAnimationController::AnimateGroup.

#### Parameter `pTransition`

A pointer to transition object.

### `M:CAnimationValue.GetVariable`

Member kind: method
Symbol: `CAnimationValue.GetVariable`

#### Summary

Provides access to encapsulated animation variable.

#### Returns

A reference to encapsulated animation variable.

#### Remarks

Use this method to access the encapsulated animation variable. From CAnimationVariable you get access
to underlying IUIAnimationVariable object, whose pointer can be NULL if animation variable has not been created.

### `M:CAnimationValue.op_Assign(System.Int32)`

Member kind: method
Symbol: `CAnimationValue.op_Assign(System.Int32)`

#### Summary

Assigns an INT32 value to CAnimationValue.

#### Remarks

Assigns an INT32 value to CAnimationValue. This value is set as a default value for encapsulated animation variable.
If you subscribed this animation object to events (ValueChanged or IntegerValueChanged), you need to re-enable these events.

#### Parameter `nVal`

Specifies the value to be assigned to Animation Value.

### `M:CAnimationValue.op_Assign(System.Double)`

Member kind: method
Symbol: `CAnimationValue.op_Assign(System.Double)`

#### Summary

Assigns a DOUBLE value to CAnimationValue.

#### Remarks

Assigns a DOUBLE value to CAnimationValue. This value is set as a default value for encapsulated animation variable.
If you subscribed this animation object to events (ValueChanged or IntegerValueChanged), you need to re-enable these events.

#### Parameter `dblVal`

Specifies the value to be assigned to Animation Value.

### `M:CAnimationValue.op_Implicit~System.Int32`

Member kind: method
Symbol: `CAnimationValue.op_Implicit~System.Int32`

#### Summary

Provides conversion between CAnimationValue and INT32.

#### Returns

Current value of Animation Value as integer.

#### Remarks

Provides conversion between CAnimationValue and INT32. This method internally calls GetValue and doesn't check for
errors. If GetValue fails, the returned value will contain a default value previously set in constructor or with SetDefaultValue.

### `M:CAnimationValue.op_Implicit~System.Double`

Member kind: method
Symbol: `CAnimationValue.op_Implicit~System.Double`

#### Summary

Provides conversion between CAnimationValue and DOUBLE.

#### Returns

Current value of Animation Value.

#### Remarks

Provides conversion between CAnimationValue and DOUBLE. This method internally calls GetValue and doesn't check for
errors. If GetValue fails, the returned value will contain a default value previously set in constructor or with SetDefaultValue.

### `M:CAnimationValue.GetValue(System.Int32*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CAnimationValue.GetValue(System.Int32*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Retrieves the current value.

#### Returns

TRUE if the current value was retrieved successfully; otherwise FALSE.

#### Remarks

Call this function to retrieve the current value. This implementation calls the encapsulated COM object, and if
the call fails, this method returns the default value that was previously set in constructor or with SetDefaultValue.

#### Parameter `nValue`

Output. When the function returns it contains a current value of animation variable.

### `M:CAnimationValue.GetValue(System.Double*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CAnimationValue.GetValue(System.Double*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Retrieves the current value.

#### Returns

TRUE if the current value was retrieved successfully; otherwise FALSE.

#### Remarks

Call this function to retrieve the current value. This implementation calls the encapsulated COM object, and if
the call fails, this method returns the default value that was previously set in constructor or with SetDefaultValue.

#### Parameter `dblValue`

Output. When the function returns it contains a current value of animation variable.

### `M:CAnimationValue.SetDefaultValue(System.Double)`

Member kind: method
Symbol: `CAnimationValue.SetDefaultValue(System.Double)`

#### Summary

Sets default value.

#### Remarks

Use this method to set a default value. A default value is returned to application when animation has not been started
and/or underlying COM object has not been created. If the underlying COM object encapsulated in CAnimationVarible
was already created, this method recreates it, therefore you might need to call EnableValueChanged/EnableIntegerValueChanged
methods again.

#### Parameter `dblDefaultValue`

Specifies the default value.

### `M:CAnimationValue.#ctor(System.Double,System.UInt32,System.UInt32,System.UInt64)`

Member kind: method
Symbol: `CAnimationValue.#ctor(System.Double,System.UInt32,System.UInt32,System.UInt64)`

#### Summary

Constructs a CAnimationValue object.

#### Remarks

Constructs CAnimationValue object with specified properties.

#### Parameter `dblDefaultValue`

Specifies default value.

#### Parameter `nGroupID`

Specifies Group ID.

#### Parameter `nObjectID`

Specifies Object ID.

#### Parameter `dwUserData`

specifies user-defined data.

### `M:CAnimationValue.#ctor`

Member kind: method
Symbol: `CAnimationValue.#ctor`

#### Summary

Constructs a CAnimationValue object.

#### Remarks

Constructs CAnimationValue object with default properties: default value, Group ID and Object ID are set to 0.

### `F:CAnimationValue.m_value`

Member kind: field
Symbol: `CAnimationValue.m_value`

#### Summary

The encapsulated animation variable that represents animation value.

### `T:CAnimationValue`

Member kind: type
Symbol: `CAnimationValue`

#### Summary

Implements the functionality of animation object with one value.

#### Remarks

The CAnimationValue class encapsulates a single CAnimationVariable object and can represent in applications
a single animated value. For example, you can use this class for animated transparency (fade effect), angle (to rotate objects),
or for any other case when you need to create an animation depending on a single animated value.
To use this class in application, just instantiate an object of this class, add it to animation controller using
CAnimationController::AddAnimationObject and call AddTransition for each transition to be applied to the value.

### `M:CAnimationBaseObject.SetParentAnimationObjects`

Member kind: method
Symbol: `CAnimationBaseObject.SetParentAnimationObjects`

#### Summary

Establishes relationship between animation variables, contained in an animation object, and their container.

#### Remarks

This is a helper that can be used to establish relationship between animation variables, contained in an animation object,
and their container. It loops over animation variables and sets a back pointer to a parent animation object
to each animation variable.
In the current implementation the actual relationship is established in CAnimationBaseObject::ApplyTransitions, therefore
back pointers are not set until you call CAnimationGroup::Animate.
Knowing the relationship may be helpful when you processing events and need to get a parent animation object
from CAnimationVariable (use CAnimationVariable::GetParentAnimationObject).

### `M:CAnimationBaseObject.GetAnimationVariableList(CList<CAnimationVariable**,CAnimationVariable**>*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CAnimationBaseObject.GetAnimationVariableList(CList<CAnimationVariable**,CAnimationVariable**>*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Collects pointers to contained animation variables.

#### Remarks

This is a pure virtual method that must be overridden in a derived class.
An animation object, depending on its type, contains one or more animation variables. For example, CAnimationPoint
contains two variables, for X and Y coordinates respectively. The base class CAnimationBaseObject implements
some generic methods, which act on a list of animation variables: ApplyTransitions, ClearTransitions,
EnableValueChangedEvent, EnableIntegerValueChangedEvent. These methods call GetAnimationVariableList, which is filled
in a derived class with actual animation variables contained in a particular animation object, then loop over the
list and perform necessary actions.
If you create a custom animation object, you must add to lst all animation variables contained in that object.

#### Parameter `lst`

A list that must be filled with animation variables contained in an animation object.

### `M:CAnimationBaseObject.ContainsVariable(IUIAnimationVariable*)`

Member kind: method
Symbol: `CAnimationBaseObject.ContainsVariable(IUIAnimationVariable*)`

#### Summary

Determines whether an animation object contains a particular animation variable.

#### Returns

TRUE if the animation variable is contained in the animation object; otherwise FALSE.

#### Remarks

This method can be used to determine whether an animation variable specified by pVariable is contained
within an animation object. An animation object, depending on its type, may contain several animation variables.
For example, CAnimationColor contains three variables, one for each color component (red, green and blue). When a
value of animation variable has changed, Windows Animation API sends ValueChanged or IntegerValueChanged events (if enabled),
and the parameter of this event is a pointer to interface IUIAnimationVariable of animation variable.
This method helps to obtain a pointer to animation from a pointer to contained COM object.

#### Parameter `pVariable`

A pointer to animation variable.

### `M:CAnimationBaseObject.EnableIntegerValueChangedEvent(CAnimationController*,System.Int32)`

Member kind: method
Symbol: `CAnimationBaseObject.EnableIntegerValueChangedEvent(CAnimationController*,System.Int32)`

#### Summary

Sets up Integer Value Changed event handler.

#### Remarks

If the Integer Value Changed event handler is enabled, you can handle this event in CAnimationController::OnAnimationIntegerValueChanged method,
which should be overridden in a CAnimationController-derived class. This method is called every time the animation integer value has changed.

#### Parameter `pController`

A pointer to a parent controller.

#### Parameter `bEnable`

Specifies whether to enable, or disable Integer Value Changed event.

### `M:CAnimationBaseObject.EnableValueChangedEvent(CAnimationController*,System.Int32)`

Member kind: method
Symbol: `CAnimationBaseObject.EnableValueChangedEvent(CAnimationController*,System.Int32)`

#### Summary

Sets up Value Changed event handler.

#### Remarks

If the Value Changed event handler is enabled, you can handle this event in CAnimationController::OnAnimationValueChanged method,
which should be overridden in a CAnimationController-derived class. This method is called every time the animation value has changed.

#### Parameter `pController`

A pointer to a parent controller.

#### Parameter `bEnable`

Specifies whether to enable, or disable Value Changed event.

### `M:CAnimationBaseObject.ClearTransitions(System.Int32)`

Member kind: method
Symbol: `CAnimationBaseObject.ClearTransitions(System.Int32)`

#### Summary

Removes all related transitions.

#### Remarks

Removes all related transitions and destroys them if bAutodestroy or m_bAutodestroyTransitions flag is TRUE.
Transitions should be destroyed automatically only if they are not allocated on the stack.
If the above flags are FALSE, transitions are just removed from the internal list of related transitions.

#### Parameter `bAutodestroy`

Specifies whether to destroy transition objects automatically, or just remove them from the related list.

### `M:CAnimationBaseObject.ApplyTransitions(IUIAnimationStoryboard*,System.Int32)`

Member kind: method
Symbol: `CAnimationBaseObject.ApplyTransitions(IUIAnimationStoryboard*,System.Int32)`

#### Summary

Adds transitions to storyboard with encapsulated animation variable.

#### Returns

TRUE if transitions were added successfully.

#### Remarks

Adds related transitions, that have been added with AddTransition (overloaded methods in derived classes), to storyboard.

#### Parameter `pStoryboard`

A pointer to a storyboard.

#### Parameter `bDependOnKeyframes`

With FALSE this method adds only those transitions that do not depend on keyframes.

### `M:CAnimationBaseObject.GetAutodestroyTransitions`

Member kind: method
Symbol: `CAnimationBaseObject.GetAutodestroyTransitions`

#### Summary

Tells whether related transition are destroyed automatically.

#### Returns

If TRUE, related transitions are destroyed automatically; if FALSE, transition objects should be deallocated by calling application.

#### Remarks

By default this flag is TRUE. Set this flag only if you allocated transition on the stack and/or transitions should be deallocated by
the calling application.

### `M:CAnimationBaseObject.SetAutodestroyTransitions(System.Int32)`

Member kind: method
Symbol: `CAnimationBaseObject.SetAutodestroyTransitions(System.Int32)`

#### Summary

Sets a flag that orders to automatically destroy transitions.

#### Remarks

Set this flag only if you allocated transition objects using operator new. If for some reason transition
objects are allocated on the stack, the auto destroy flag should be FALSE. By default this flag is TRUE.

#### Parameter `bValue`

Specifies the auto destroy flag.

### `M:CAnimationBaseObject.GetUserData`

Member kind: method
Symbol: `CAnimationBaseObject.GetUserData`

#### Summary

Returns user defined data.

#### Returns

A value of custom data.

#### Remarks

Call this method to retrieve the custom data at runtime. The returned value will be 0 if it was not explicitly initialized in constructor or with SetUserData.

### `M:CAnimationBaseObject.GetGroupID`

Member kind: method
Symbol: `CAnimationBaseObject.GetGroupID`

#### Summary

Returns current Group ID.

#### Returns

Current Group ID.

#### Remarks

Use this method to retrieve Group ID. It's 0 if Group ID has not been set explicitly in constructor or with SetID.

### `M:CAnimationBaseObject.GetObjectID`

Member kind: method
Symbol: `CAnimationBaseObject.GetObjectID`

#### Summary

Returns current Object ID.

#### Returns

Current Object ID.

#### Remarks

Use this method to retrieve Object ID. It's 0 if Object ID has not been set explicitly in constructor or with SetID.

### `M:CAnimationBaseObject.DetachFromController`

Member kind: method
Symbol: `CAnimationBaseObject.DetachFromController`

#### Summary

Detaches an animation object from parent animation controller.

#### Remarks

This method is used internally.

### `M:CAnimationBaseObject.SetUserData(System.UInt64)`

Member kind: method
Symbol: `CAnimationBaseObject.SetUserData(System.UInt64)`

#### Summary

Sets user-defined data.

#### Remarks

Use this method to associate a custom data with an animation object. This data may be retrieved later at runtime by GetUserData.

#### Parameter `dwUserData`

Specifies the custom data.

### `M:CAnimationBaseObject.SetID(System.UInt32,System.UInt32)`

Member kind: method
Symbol: `CAnimationBaseObject.SetID(System.UInt32,System.UInt32)`

#### Summary

Sets new IDs.

#### Remarks

Allows to change Object ID and Group ID. If the new Group ID differs from the current ID, an animation object
is moved to another group (a new group will be created, if necessary).

#### Parameter `nObjectID`

Specifies new Object ID.

#### Parameter `nGroupID`

Specifies new Group ID.

### `M:CAnimationBaseObject.CreateTransitions`

Member kind: method
Symbol: `CAnimationBaseObject.CreateTransitions`

#### Summary

Creates transitions associated with an animation object.

#### Returns

TRUE if transitions were created successfully; otherwise FALSE.

#### Remarks

Loops over list of animation variables encapsulated in a derived animation object and creates transitions
associated with each animation variable.

### `M:CAnimationBaseObject.Dispose`

Member kind: method
Symbol: `CAnimationBaseObject.Dispose`

#### Summary

The destructor. Called when an animation object is being destroyed.

### `M:CAnimationBaseObject.#ctor(System.UInt32,System.UInt32,System.UInt64)`

Member kind: method
Symbol: `CAnimationBaseObject.#ctor(System.UInt32,System.UInt32,System.UInt64)`

#### Summary

Constructs an animation object.

#### Remarks

Constructs an animation object with specified Object ID and Group ID.

#### Parameter `nGroupID`

Specifies Group ID.

#### Parameter `nObjectID`

Specifies Object ID.

#### Parameter `dwUserData`

User-defined data, which can be associated with animation object and retrieved later at runtime.

### `M:CAnimationBaseObject.#ctor`

Member kind: method
Symbol: `CAnimationBaseObject.#ctor`

#### Summary

Constructs an animation object.

#### Remarks

Constructs an animation objects and assigns default Object ID (0) and Group ID (0).

### `F:CAnimationBaseObject.m_pParentController`

Member kind: field
Symbol: `CAnimationBaseObject.m_pParentController`

#### Summary

A pointer to the parent animation controller.

### `F:CAnimationBaseObject.m_bAutodestroyTransitions`

Member kind: field
Symbol: `CAnimationBaseObject.m_bAutodestroyTransitions`

#### Summary

Specifies whether related transitions should be automatically destroyed.

### `F:CAnimationBaseObject.m_dwUserData`

Member kind: field
Symbol: `CAnimationBaseObject.m_dwUserData`

#### Summary

Stores user-defined data.

### `F:CAnimationBaseObject.m_nObjectID`

Member kind: field
Symbol: `CAnimationBaseObject.m_nObjectID`

#### Summary

Specifes the Object ID of the animation object.

### `F:CAnimationBaseObject.m_nGroupID`

Member kind: field
Symbol: `CAnimationBaseObject.m_nGroupID`

#### Summary

Specifies the Group ID of the animation object.

### `T:CAnimationBaseObject`

Member kind: type
Symbol: `CAnimationBaseObject`

#### Summary

The base class for all animation objects.

#### Remarks

This class implements basic methods for all animation objects. An animation object can represent a value, point,
size, rectangle or color in an application, as well as any custom entity. Animation objects are stored in animation groups
(see CAnimationGroup). Each group can be animated separately and can be treated as an analogue of storyboard.
An animation object encapsulates one or more animation variables (see CAnimationVariable), depending on its logical
representation. For example, CAnimationRect contains four animation variables - one variable for each side of rectangle.
Each animation object class exposes overloaded AddTransition method, which should be used to apply transitions to
encapsulated animation variables.
An animation object can be identified by Object ID (optionally) and by Group ID. A Group ID is necessary in order
to place an animation object to correct group, but if a Group ID is not specified, an object is placed in the default group with ID 0.
If you call SetID with different GroupID, an animation object will be moved to another group (a new group is created if necessary).

### `F:CAnimationVariable.m_bAutodestroyTransitions`

Member kind: field
Symbol: `CAnimationVariable.m_bAutodestroyTransitions`

#### Summary

Specifies whether related transition objects should be deleted.

#### Remarks

Set this value to TRUE to force deletion of transition objects when they are being removed from the internal list
of transitions. If this value is FALSE the transitions should be deleted by calling application.
The list of transitions is always cleared after an animation has been scheduled. The default value is FALSE.

### `M:CAnimationVariable.GetDefaultValue`

Member kind: method
Symbol: `CAnimationVariable.GetDefaultValue`

#### Summary

Returns default value.

#### Returns

The default value.

#### Remarks

Use this function to obtain default value of animation variable. The default value can be set in constructor or by
SetDefaultValue method.

### `M:CAnimationVariable.EnableIntegerValueChangedEvent(CAnimationController*,System.Int32)`

Member kind: method
Symbol: `CAnimationVariable.EnableIntegerValueChangedEvent(CAnimationController*,System.Int32)`

#### Summary

Enables or disables the IntegerValueChanged event.

#### Remarks

When ValueChanged event is enabled, the framework calls virtual method CAnimationController::OnAnimationIntegerValueChanged.
You need to override it in a class derived from CAnimationController in order to process this event. This method is called every time
the integer value of animation variable is changed.

#### Parameter `pController`

A pointer to parent controller.

#### Parameter `bEnable`

TRUE - enable event, FALSE - disable event.

### `M:CAnimationVariable.EnableValueChangedEvent(CAnimationController*,System.Int32)`

Member kind: method
Symbol: `CAnimationVariable.EnableValueChangedEvent(CAnimationController*,System.Int32)`

#### Summary

Enables or disables the ValueChanged event.

#### Remarks

When ValueChanged event is enabled, the framework calls virtual method CAnimationController::OnAnimationValueChanged.
You need to override it in a class derived from CAnimationController in order to process this event. This method is called every time
the value of animation variable is changed.

#### Parameter `pController`

A pointer to parent controller.

#### Parameter `bEnable`

TRUE - enable event, FALSE - disable event.

### `M:CAnimationVariable.ApplyTransitions(CAnimationController*,IUIAnimationStoryboard*,System.Int32)`

Member kind: method
Symbol: `CAnimationVariable.ApplyTransitions(CAnimationController*,IUIAnimationStoryboard*,System.Int32)`

#### Summary

Adds transitions from the internal list to storyboard.

#### Remarks

This method adds transitions from the internal list to storyboard. It's called from the
top level code several times to add transitions that do not depend on keyframes and add
transitions that depend on keyframes. If the underlying animation variable
COM object has not been created, this method creates it at this stage.

#### Parameter `pController`

A pointer to parent animation controller.

#### Parameter `pStoryboard`

A pointer to storyboard.

#### Parameter `bDependOnKeyframes`

TRUE, if this method should add transitions that depend on keyframes.

### `M:CAnimationVariable.ClearTransitions(System.Int32)`

Member kind: method
Symbol: `CAnimationVariable.ClearTransitions(System.Int32)`

#### Summary

Clears transitions.

#### Remarks

This method removes all transitions from the internal list of transitions. If bAutodestroy is TRUE, or
m_bAutodestroyTransitions is TRUE, then transitions are deleted. Otherwise the caller should deallocate
the transition objects.

#### Parameter `bAutodestroy`

Specifies whether this method should delete transition objects.

### `M:CAnimationVariable.AddTransition(CBaseTransition*)`

Member kind: method
Symbol: `CAnimationVariable.AddTransition(CBaseTransition*)`

#### Summary

Adds a transition.

#### Remarks

This method is called to add a transition to the internal list of transitions to be applied to the animation variable.
This list should be cleared when an animation has been scheduled.

#### Parameter `pTransition`

A pointer to a transition to add.

### `M:CAnimationVariable.GetValue(System.Int32*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CAnimationVariable.GetValue(System.Int32*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Returns the current value of animation variable.

#### Returns

S_OK if the value was obtained successfully, or underlying animation variable has not been created. Otherwise
HRESULT error code.

#### Remarks

This method can be called to retrieve the current value of animation variable. If the underlying COM object
has not been created, dblValue will contain a default value, when the function returns.

#### Parameter `nValue`

The current value of the animation variable.

### `M:CAnimationVariable.GetValue(System.Double*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CAnimationVariable.GetValue(System.Double*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Returns the current value of animation variable.

#### Returns

S_OK if the value was obtained successfully, or underlying animation variable has not been created. Otherwise
HRESULT error code.

#### Remarks

This method can be called to retrieve the current value of animation variable. If the underlying COM object
has not been created, dblValue will contain a default value, when the function returns.

#### Parameter `dblValue`

The current value of the animation variable.

### `M:CAnimationVariable.CreateTransitions(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

Member kind: method
Symbol: `CAnimationVariable.CreateTransitions(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

#### Summary

Creates all transitions to be applied to this animation variable.

#### Returns

TRUE if transitions were created successfully; otherwise FALSE.

#### Remarks

This method is called by the framework when it needs to create transitions that have been added
to the variable's internal list of transitions.

#### Parameter `pLibrary`

A pointer to transition library.

#### Parameter `pFactory`

A pointer to transition factory.

### `M:CAnimationVariable.Create(IUIAnimationManager*)`

Member kind: method
Symbol: `CAnimationVariable.Create(IUIAnimationManager*)`

#### Summary

Creates the underlying animation variable COM object.

#### Returns

TRUE if the animation variable was successfully created; otherwise FALSE.

#### Remarks

This method creates the underlying animation variable COM object and sets its default value.

#### Parameter `pManager`

A pointer to animation manager.

### `M:CAnimationVariable.SetDefaultValue(System.Double)`

Member kind: method
Symbol: `CAnimationVariable.SetDefaultValue(System.Double)`

#### Summary

Sets default value and releases IUIAnimationVariable COM object.

#### Remarks

Use this method to reset the default value. This method releases the internal IUIAnimationVariable COM object,
therefore when animation variable is recreated, the underlying COM object gets the new default value.
The default value is returned by GetValue if the COM object representing the animation variable is not created,
or if the variable has not been animated.

#### Parameter `dblDefaultValue`

Specifies the new default value.

### `M:CAnimationVariable.GetVariable`

Member kind: method
Symbol: `CAnimationVariable.GetVariable`

#### Summary

Returns a pointer to IUIAnimationVariable COM object.

#### Returns

A valid pointer to IUIAnimationVariable COM object, or NULL if animation variable was not created, or can't be created.

#### Remarks

Use this function to access the underlying IUIAnimationVariable COM object and call its methods directly if needed.

### `M:CAnimationVariable.GetParentAnimationObject`

Member kind: method
Symbol: `CAnimationVariable.GetParentAnimationObject`

#### Summary

Returns the parent animation object.

#### Returns

A pointer to parent animation object, if relationship was established, otherwise NULL.

#### Remarks

This method can be called to retrieve a pointer to a parent animation object (a container).

### `M:CAnimationVariable.Dispose`

Member kind: method
Symbol: `CAnimationVariable.Dispose`

#### Summary

The destructor. Called when a CAnimationVariable object is being destroyed.

### `M:CAnimationVariable.#ctor(System.Double)`

Member kind: method
Symbol: `CAnimationVariable.#ctor(System.Double)`

#### Summary

Constructs an animation variable object.

#### Remarks

Constructs an animation variable object and sets its default value. A default value is used when
a variable is not animated, or can't be animated.

#### Parameter `dblDefaultValue`

Specifies the default value.

### `M:CAnimationVariable.SetParentAnimationObject(CAnimationBaseObject*)`

Member kind: method
Symbol: `CAnimationVariable.SetParentAnimationObject(CAnimationBaseObject*)`

#### Summary

Sets the relationship between an animation variable and an animation object.

#### Remarks

This method is called internally to establish one-to-one relationship between an animation variable and an animation object that encapsulates it.

#### Parameter `pParentObject`

A pointer to an animation object that contains this variable.

### `F:CAnimationVariable.m_pParentObject`

Member kind: field
Symbol: `CAnimationVariable.m_pParentObject`

#### Summary

A pointer to an animation object that encapsulates this animation variable.

### `F:CAnimationVariable.m_lstTransitions`

Member kind: field
Symbol: `CAnimationVariable.m_lstTransitions`

#### Summary

Contains a list of transitions that animate this animation variable.

### `F:CAnimationVariable.m_dblDefaultValue`

Member kind: field
Symbol: `CAnimationVariable.m_dblDefaultValue`

#### Summary

Specifies the default value, which is propagated to IUIAnimationVariable.

### `F:CAnimationVariable.m_variable`

Member kind: field
Symbol: `CAnimationVariable.m_variable`

#### Summary

Stores a pointer to IUIAnimationVariable COM object. NULL if the COM object has not been created yet, or if creation failed.

### `T:CAnimationVariable`

Member kind: type
Symbol: `CAnimationVariable`

#### Summary

Represents an animation variable.

#### Remarks

The CAnimationVariable class encapsulates IUIAnimationVariable COM object. It also holds a list of transitions
to be applied to the animation variable in a storyboard. CAnimationVariable objects are embedded to
animation objects, which can represent in an application an animated value, point, size, color and rectangle.

### `M:CKeyFrame.AddToStoryboardAtOffset(IUIAnimationStoryboard*,System.Int32)`

Member kind: method
Symbol: `CKeyFrame.AddToStoryboardAtOffset(IUIAnimationStoryboard*,System.Int32)`

#### Summary

Adds a keyframe to storyboard at offset.

#### Returns

TRUE, if keyframe was added successfully.

#### Remarks

This function is called by the framework to add a keyframe to storyboard at offset.

#### Parameter `pStoryboard`

A pointer to a storyboard.

#### Parameter `bDeepAdd`

Specifies whether to add a keyframe this keyframe depend on recursively.

### `M:CKeyFrame.AddToStoryboardAfterTransition(IUIAnimationStoryboard*,System.Int32)`

Member kind: method
Symbol: `CKeyFrame.AddToStoryboardAfterTransition(IUIAnimationStoryboard*,System.Int32)`

#### Summary

Adds a keyframe to storyboard after transition.

#### Returns

TRUE, if keyframe was added successfully.

#### Remarks

This function is called by the framework to add a keyframe to storyboard after transition.

#### Parameter `pStoryboard`

A pointer to a storyboard.

#### Parameter `bDeepAdd`

Specifies whether to add a transition recursively.

### `M:CKeyFrame.AddToStoryboard(IUIAnimationStoryboard*,System.Int32)`

Member kind: method
Symbol: `CKeyFrame.AddToStoryboard(IUIAnimationStoryboard*,System.Int32)`

#### Summary

Adds a keyframe to a storyboard.

#### Returns

TRUE, if keyframe was added successfully.

#### Remarks

This method adds a keyframe to storyboard. If it depends on other keyframe or transition and bDeepAdd is TRUE,
this method tries to add them recursively.

#### Parameter `pStoryboard`

A pointer to a storyboard.

#### Parameter `bDeepAdd`

Specifies whether to add keyframe or transition recursively.

### `M:CKeyFrame.GetOffset`

Member kind: method
Symbol: `CKeyFrame.GetOffset`

#### Summary

Returns an offset from other keyframe.

#### Returns

An offset in seconds from other keyframe.

#### Remarks

This method should be called to determine an offset in seconds from other keyframe.

### `M:CKeyFrame.GetExistingKeyframe`

Member kind: method
Symbol: `CKeyFrame.GetExistingKeyframe`

#### Summary

Returns a pointer to a keyframe this keyframe depends on.

#### Returns

A valid pointer to keyframe, or NULL if this keyframe does not depend on other keyframe.

#### Remarks

This is an accessor to a keyframe this keyframe depends on.

### `M:CKeyFrame.GetTransition`

Member kind: method
Symbol: `CKeyFrame.GetTransition`

#### Summary

Returns a pointer to a transition this keyframe depends on.

#### Returns

A valid pointer to transition, or NULL if this keyframe does not depend on transition.

#### Remarks

This is an accessor to a transition this keyframe depends on.

### `M:CKeyFrame.#ctor(CBaseKeyFrame*,System.Double)`

Member kind: method
Symbol: `CKeyFrame.#ctor(CBaseKeyFrame*,System.Double)`

#### Summary

Constructs a keyframe that depends on other keyframe.

#### Remarks

The constructed keyframe will represent a moment in time within a storyboard, which has a specified offset from pKeyframe.

#### Parameter `pKeyframe`

A pointer to keyframe.

#### Parameter `offset`

Offset, in seconds, from keyframe specified by pKeyframe.

### `M:CKeyFrame.#ctor(CBaseTransition*)`

Member kind: method
Symbol: `CKeyFrame.#ctor(CBaseTransition*)`

#### Summary

Constructs a keyframe that depends on a transition.

#### Remarks

The constructed keyframe will represent a moment in time within a storyboard when the specified transition ends.

#### Parameter `pTransition`

A pointer to a transition.

### `F:CKeyFrame.m_pExistingKeyFrame`

Member kind: field
Symbol: `CKeyFrame.m_pExistingKeyFrame`

#### Summary

Stores a pointer to an existing keframe. This keyframe is added to storyboard with m_offset to the existing keyframe.

### `F:CKeyFrame.m_offset`

Member kind: field
Symbol: `CKeyFrame.m_offset`

#### Summary

Specifies offset of this keyframe from a keyframe stored in m_pExistingKeyFrame.

### `F:CKeyFrame.m_pTransition`

Member kind: field
Symbol: `CKeyFrame.m_pTransition`

#### Summary

Stores a pointer to transtion that begins at this keyframe.

### `T:CKeyFrame`

Member kind: type
Symbol: `CKeyFrame`

#### Summary

Represents an animation keyframe.

#### Remarks

This class implements an animation keyframe. A keyframe represents a moment in time within a
storyboard and can be used to specify the start and end times of transitions.
A keyframe may be based on other keyframe and have an offset (in seconds) from it, or may be based on a transition and
represent a moment in time when this transition ends.

### `M:CBaseKeyFrame.AddToStoryboard(IUIAnimationStoryboard*,System.Int32)`

Member kind: method
Symbol: `CBaseKeyFrame.AddToStoryboard(IUIAnimationStoryboard*,System.Int32)`

#### Summary

Adds a keyframe to storyboard.

#### Returns

TRUE if keyframe was added to storyboard successfully; otherwise FALSE.

#### Remarks

This method is called to add a keyframe to storyboard.

#### Parameter `pStoryboard`

A pointer to a storyboard.

#### Parameter `bDeepAdd`

If this parameter is TRUE and the keyframe being added depends on some other keyframe or transition, this method tries
to add this keyframe or transition to storyboard first.

### `M:CBaseKeyFrame.IsKeyframeAtOffset`

Member kind: method
Symbol: `CBaseKeyFrame.IsKeyframeAtOffset`

#### Summary

Specifies whether the keyframe should be added to storyboard at offset, or after transition.

#### Returns

TRUE if the keyframe should be added to storyboard at some specified offset.
FALSE if the keyframe should be added to storyboard after some transition.

#### Remarks

Specifies whether the keyframe should be added to storyboard at offset.
The offset or transition must be specified in a derived class.

### `M:CBaseKeyFrame.IsAdded`

Member kind: method
Symbol: `CBaseKeyFrame.IsAdded`

#### Summary

Tells whether a keyframe has been added to storyboard.

#### Returns

TRUE if a keyframe is added to a storyboard; otehrwise FALSE.

#### Remarks

In the base class IsAdded always returns TRUE, but it's overridden in derived classes.

### `M:CBaseKeyFrame.GetAnimationKeyframe`

Member kind: method
Symbol: `CBaseKeyFrame.GetAnimationKeyframe`

#### Summary

Returns the underlying keyframe value.

#### Returns

A current keyframe. The default value is UI_ANIMATION_KEYFRAME_STORYBOARD_START.

#### Remarks

This is an accessor to the underlying keyframe value.

### `M:CBaseKeyFrame.#ctor`

Member kind: method
Symbol: `CBaseKeyFrame.#ctor`

#### Summary

Constructs a keyframe object.

### `F:CBaseKeyFrame.m_bIsKeyframeAtOffset`

Member kind: field
Symbol: `CBaseKeyFrame.m_bIsKeyframeAtOffset`

#### Summary

Specifies whether this keyframe should be added to storyboard at an offset from
another existing keyframe, or at the end of some transition.

### `F:CBaseKeyFrame.m_bAdded`

Member kind: field
Symbol: `CBaseKeyFrame.m_bAdded`

#### Summary

Specifies whether this keyframe has been added to a storyboard.

### `F:CBaseKeyFrame.m_keyframe`

Member kind: field
Symbol: `CBaseKeyFrame.m_keyframe`

#### Summary

Represents a Windows Animation API keyframe. When a keyframe is not initialized
it is set to the predefined value UI_ANIMATION_KEYFRAME_STORYBOARD_START.

### `T:CBaseKeyFrame`

Member kind: type
Symbol: `CBaseKeyFrame`

#### Summary

Implements basic functionality of keyframe.

#### Remarks

Encapsulates UI_ANIMATION_KEYFRAME variable. Serves as a base class for any keyframe implementation.
A keyframe represents a moment in time within a storyboard and can be used to specify the start and end times of transitions.
There are two types of keyframes - keyframes added to storyboard at the specified offset (in time), or keyframes added
after specified transition. Because durations of some transitions can't be known before animation starts, the actual values
of some keyframes are determined at runtime only.
Because keyframes may depend on transitions, which in their turn depend on keyframes, it's important to prevent
infinite recursions when building keyframe chains.

### `F:CBaseTransition.m_bAdded`

Member kind: field
Symbol: `CBaseTransition.m_bAdded`

#### Summary

Specifies whether a transition has been added to a storyboard.

### `F:CBaseTransition.m_pRelatedVariable`

Member kind: field
Symbol: `CBaseTransition.m_pRelatedVariable`

#### Summary

A pointer to an animation variable, which is animated with the transition stored in m_transition.

### `F:CBaseTransition.m_pEndKeyframe`

Member kind: field
Symbol: `CBaseTransition.m_pEndKeyframe`

#### Summary

Stores a pointer to the keyframe that specifies the end of the transition.

### `F:CBaseTransition.m_pStartKeyframe`

Member kind: field
Symbol: `CBaseTransition.m_pStartKeyframe`

#### Summary

Stores a pointer to the keyframe that specifies the beginning of the transition.

### `F:CBaseTransition.m_transition`

Member kind: field
Symbol: `CBaseTransition.m_transition`

#### Summary

Stores a pointer to IUIAnimationTransition. NULL if a COM transition object has not been created.

### `F:CBaseTransition.m_type`

Member kind: field
Symbol: `CBaseTransition.m_type`

#### Summary

Stores the transition type.

### `M:CBaseTransition.AddToStoryboardAtKeyframes(IUIAnimationStoryboard*)`

Member kind: method
Symbol: `CBaseTransition.AddToStoryboardAtKeyframes(IUIAnimationStoryboard*)`

#### Summary

Adds a transition to a storyboard.

#### Returns

TRUE, if transition was successfully added to a storyboard.

#### Remarks

Applies the transition to the related variable in the storyboard. If the start keyframe was specified, the transition
begins at that keyframe. If the end keyframe was specified, the transition begins at the start keyframe and
and stops at the end keyframe. If the transition was created with a duration parameter specified, that duration is
overwritten with the duration of time between the start and end keyframes.
If no keyframe was specified, the transition is appended to the transition added most recently to the variable.

#### Parameter `pStoryboard`

A pointer to storyboard, which will animate the related variable.

### `M:CBaseTransition.AddToStoryboard(IUIAnimationStoryboard*)`

Member kind: method
Symbol: `CBaseTransition.AddToStoryboard(IUIAnimationStoryboard*)`

#### Summary

Adds a transition to a storyboard.

#### Returns

TRUE, if transition was successfully added to a storyboard.

#### Remarks

Applies the transition to the related variable in the storyboard. If this is the first transition
applied to this variable in this storyboard, the transition begins at the start of the storyboard.
Otherwise, the transition is appended to the transition added most recently to the variable.

#### Parameter `pStoryboard`

A pointer to storyboard, which will animate the related variable.

### `M:CBaseTransition.GetRelatedVariable`

Member kind: method
Symbol: `CBaseTransition.GetRelatedVariable`

#### Summary

Returns a pointer to related variable.

#### Returns

A valid pointer to animation variable, or NULL if an animation variable has not been set by SetRelatedVariable.

#### Remarks

This is an accessor to related animation variable.

### `M:CBaseTransition.SetRelatedVariable(CAnimationVariable*)`

Member kind: method
Symbol: `CBaseTransition.SetRelatedVariable(CAnimationVariable*)`

#### Summary

Establishes a relationship between animation variable and transition.

#### Remarks

Establishes a relationship between animation variable and transition. A transition can be applied only to one variable.

#### Parameter `pVariable`

A pointer to related animation variable.

### `M:CBaseTransition.GetEndKeyframe`

Member kind: method
Symbol: `CBaseTransition.GetEndKeyframe`

#### Summary

Returns start keyframe.

#### Returns

A valid pointer to a keyframe, or NULL if a transition should not be inserted between keyframes.

#### Remarks

This method can be used to access a keyframe object that was previously set by SetKeyframes.
It's called by top level code when transitions are being added to storyboard.

### `M:CBaseTransition.GetStartKeyframe`

Member kind: method
Symbol: `CBaseTransition.GetStartKeyframe`

#### Summary

Returns start keyframe.

#### Returns

A valid pointer to a keyframe, or NULL if a transition should not start after a keyframe.

#### Remarks

This method can be used to access a keyframe object that was previously set by SetKeyframes.
It's called by top level code when transitions are being added to storyboard.

### `M:CBaseTransition.IsAdded`

Member kind: method
Symbol: `CBaseTransition.IsAdded`

#### Summary

Tells whether a transition has been added to a storyboard.

#### Returns

Returns TRUE if a transition has been added to a storyboard, otherwise FALSE.

#### Remarks

This flag is set internally when the top level code adds transitions to storyboard.

### `M:CBaseTransition.SetKeyframes(CBaseKeyFrame*,CBaseKeyFrame*)`

Member kind: method
Symbol: `CBaseTransition.SetKeyframes(CBaseKeyFrame*,CBaseKeyFrame*)`

#### Summary

Sets keyframes for a transition.

#### Remarks

This method tells the transition to start after specified keyframe and, optionally, if pEnd is not NULL, end
before the specified keyframe.
If the transition was created with a duration parameter specified, that duration is overwritten with the duration of time between the start and end keyframes.

#### Parameter `pStart`

A keyframe that specifies the beginning of the transition.

#### Parameter `pEnd`

A keyframe that specifies the end of the transition.

### `M:CBaseTransition.GetTransition`

Member kind: method
Symbol: `CBaseTransition.GetTransition`

#### Summary

Returns a pointer to underlying COM transition object.

#### Returns

A valid pointer to IUIAnimationTransition or NULL if underlying transition can't be created.

#### Remarks

It's an accessor method to underlying COM transition object. It doesn't instantiates the underlying IUIAnimationTransition COM
object if it wasn't created.

### `M:CBaseTransition.GetTransition(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

Member kind: method
Symbol: `CBaseTransition.GetTransition(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

#### Summary

Returns a pointer to underlying COM transition object.

#### Returns

A valid pointer to IUIAnimationTransition or NULL if underlying transition can't be created.

#### Remarks

This method returns a pointer to underlying COM transition object and creates it if necessary.

#### Parameter `pLibrary`

A pointer to transition library, which creates standard transitions. It can be NULL for custom transitions.

#### Parameter `pFactory`

A pointer to transition factory, which creates custom transitions. It can be NULL for standard transitions.

### `M:CBaseTransition.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

Member kind: method
Symbol: `CBaseTransition.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

#### Summary

Creates a COM transition.

#### Returns

TRUE if a transition COM object was created successfully; otherwise FALSE.

#### Remarks

This is a pure virtual function that must be overridden in a derived class.
It's called by the framework to instantiate the underlying COM transition object.

#### Parameter `pLibrary`

A pointer to transition library, which creates standard transitions. It can be NULL for custom transitions.

#### Parameter `pFactory`

A pointer to transition factory, which creates custom transitions. It can be NULL for standard transitions.

### `M:CBaseTransition.GetType`

Member kind: method
Symbol: `CBaseTransition.GetType`

#### Summary

Returns transition type.

#### Returns

One of TRANSITION_TYPE enumerated values.

#### Remarks

This method can be used to identify a transition object by its type.
The type is set in a constructor in a derived class.

### `M:CBaseTransition.Clear`

Member kind: method
Symbol: `CBaseTransition.Clear`

#### Summary

Releases encapsulated IUIAnimationTransition COM object.

#### Remarks

This method should be called from a derived class's Create method in order to prevent
IUITransition interface leak.

### `M:CBaseTransition.Dispose`

Member kind: method
Symbol: `CBaseTransition.Dispose`

#### Summary

The destructor. Called when a transition object is being destroyed.

### `M:CBaseTransition.#ctor`

Member kind: method
Symbol: `CBaseTransition.#ctor`

#### Summary

Constructs a base transtion object.

### `T:CBaseTransition.TRANSITION_TYPE`

Member kind: type
Symbol: `CBaseTransition.TRANSITION_TYPE`

#### Summary

Defines the transition types currently supported by the MFC implementation of Windows Animation API.

#### Remarks

A transition type is set in the constructor of specific transition.
For example, CSinusoidalTransitionFromRange sets its type to SINUSOIDAL_FROM_RANGE.

### `T:CBaseTransition`

Member kind: type
Symbol: `CBaseTransition`

#### Summary

Represents a basic transition.

#### Remarks

This class encapsulates IUIAnimationTransition interface and serves as a base class for all transitions.

### `M:Autodesk.Revit.UI.UIView.GetZoomCorners`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIView.GetZoomCorners`

#### Summary

Gets the corners of the view's rectangle.
The two points that define the corners of the view's rectangle in model coordinates.

#### Since

2013

### `M:Autodesk.Revit.UI.UIView.ZoomAndCenterRectangle(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIView.ZoomAndCenterRectangle(Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Zoom and center the view to a specified rectangle.

#### Parameter `viewCorner1`

A corner of the desired view rectangle in model coordinates.

#### Parameter `viewCorner2`

The opposite corner of the desired view rectangle in model coordinates.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.UI.UIView.ZoomSheetSize`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIView.ZoomSheetSize`

#### Summary

Zoom to the sheet size.

#### Since

2013

### `M:Autodesk.Revit.UI.UIView.Zoom(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIView.Zoom(System.Double)`

#### Summary

Zoom the view.

#### Parameter `zoomFactor`

Factor by which to zoom in or out. Values greater than 1 zooms in, less than 1 zooms out.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

zoomFactor is not positive.

#### Since

2013

### `M:Autodesk.Revit.UI.UIView.ZoomToFit`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIView.ZoomToFit`

#### Summary

Zoom the view to fit its contents.

#### Since

2013

### `M:Autodesk.Revit.UI.UIView.Close`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIView.Close`

#### Summary

Closes the view.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Cannot close a project's only open view.

#### Since

2013

### `M:Autodesk.Revit.UI.UIView.GetWindowRectangle`

Member kind: method
Symbol: `Autodesk.Revit.UI.UIView.GetWindowRectangle`

#### Summary

Gets the rectangle containing the coordinates of the view's drawing area.

#### Returns

The rectangle of the view window.

#### Since

2013

### `P:Autodesk.Revit.UI.UIView.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIView.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.UI.UIView.ViewId`

Member kind: property
Symbol: `Autodesk.Revit.UI.UIView.ViewId`

#### Summary

The id of the View associated with a UIView.

#### Since

2013

### `T:Autodesk.Revit.UI.UIView`

Member kind: type
Symbol: `Autodesk.Revit.UI.UIView`

#### Summary

A class containing data about view windows in the Revit user interface.

#### Since

2013

### `P:Autodesk.Revit.UI.PromptForFamilyInstancePlacementOptions.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.PromptForFamilyInstancePlacementOptions.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.UI.PromptForFamilyInstancePlacementOptions.FaceBasedPlacementType`

Member kind: property
Symbol: `Autodesk.Revit.UI.PromptForFamilyInstancePlacementOptions.FaceBasedPlacementType`

#### Summary

The placement type to be used if prompting to place an instance of a face-based family.
This option is ignored if placing a non-face-based family. If placing a face-based family, Default is an acceptable value, but will correspond to the first available selection in the user interface.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2017

### `P:Autodesk.Revit.UI.PromptForFamilyInstancePlacementOptions.SketchGalleryOptions`

Member kind: property
Symbol: `Autodesk.Revit.UI.PromptForFamilyInstancePlacementOptions.SketchGalleryOptions`

#### Summary

The sketch option provided when promt to place a family instance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2017

### `P:Autodesk.Revit.UI.PromptForFamilyInstancePlacementOptions.PlaceAirTerminalOnDuct`

Member kind: property
Symbol: `Autodesk.Revit.UI.PromptForFamilyInstancePlacementOptions.PlaceAirTerminalOnDuct`

#### Summary

If true, when placing an air terminal, the terminal will be placed directly on the duct without fittings.
If fase, the terminal will be placed with generated fittings.

#### Since

2015

### `M:Autodesk.Revit.UI.PromptForFamilyInstancePlacementOptions.#ctor(Autodesk.Revit.UI.PromptForFamilyInstancePlacementOptions)`

Member kind: method
Symbol: `Autodesk.Revit.UI.PromptForFamilyInstancePlacementOptions.#ctor(Autodesk.Revit.UI.PromptForFamilyInstancePlacementOptions)`

#### Summary

Creates a copy of an existing options object.

#### Parameter `other`

The options object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.UI.PromptForFamilyInstancePlacementOptions.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.UI.PromptForFamilyInstancePlacementOptions.#ctor`

#### Summary

Creates a new PromptForFamilyInstancePlacementOptions using default options.

#### Since

2015

### `T:Autodesk.Revit.UI.PromptForFamilyInstancePlacementOptions`

Member kind: type
Symbol: `Autodesk.Revit.UI.PromptForFamilyInstancePlacementOptions`

#### Summary

This class contains options to control the behavior of interactive placement of family instances.

#### Since

2015

### `M:Autodesk.Revit.UI.IControllableDropHandler.CanExecute(Autodesk.Revit.UI.UIDocument,System.Object,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.IControllableDropHandler.CanExecute(Autodesk.Revit.UI.UIDocument,System.Object,Autodesk.Revit.DB.ElementId)`

#### Summary

Implement this method to inform Revit whether the drop event can be executed onto the given view.

#### Remarks

Document modifications are not permitted from this callback.

#### Parameter `document`

The document on which the data was dropped.

#### Parameter `data`

The data.

#### Parameter `dropViewId`

The view upon which the user will drop.

#### Returns

Return true to activate the target view and execute the drop.
Return false to cancel the activation and the drop execution.

### `T:Autodesk.Revit.UI.IControllableDropHandler`

Member kind: type
Symbol: `Autodesk.Revit.UI.IControllableDropHandler`

#### Summary

An interface to be executed when custom data is dragged and dropped onto the Revit user interface.
This interface is different from IDropHandler in that it allows the handler to verify whether the drop event can be executed on the given view.

#### Remarks

Custom data is supported for drag and drop only during an invocation of the DoDragDrop method on Application.

#### Since

2015

### `M:Autodesk.Revit.UI.IDropHandler.Execute(Autodesk.Revit.UI.UIDocument,System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.UI.IDropHandler.Execute(Autodesk.Revit.UI.UIDocument,System.Object)`

#### Summary

Implement this method to handle the drop event for your data.

#### Parameter `document`

The document on which the data was dropped.

#### Parameter `data`

The data.

#### Since

2013

### `T:Autodesk.Revit.UI.IDropHandler`

Member kind: type
Symbol: `Autodesk.Revit.UI.IDropHandler`

#### Summary

An interface to be executed when custom data is dragged and dropped onto the Revit user interface.

#### Remarks

Custom data is supported for drag and drop only during an invocation of the DoDragDrop method on Application.

#### Since

2013

### `M:Autodesk.Revit.UI.TabbedDialogExtension.SetContextualHelp(Autodesk.Revit.UI.ContextualHelp)`

Member kind: method
Symbol: `Autodesk.Revit.UI.TabbedDialogExtension.SetContextualHelp(Autodesk.Revit.UI.ContextualHelp)`

#### Summary

Sets the contextual help.

#### Parameter `contextualHelp`

The contextual help.

#### Since

2013

### `M:Autodesk.Revit.UI.TabbedDialogExtension.GetContextualHelp`

Member kind: method
Symbol: `Autodesk.Revit.UI.TabbedDialogExtension.GetContextualHelp`

#### Summary

Gets the contextual help.

#### Returns

The contextual help assigned to the help button of the Revit options dialog, or `null` if there is no binding assigned.

#### Since

2013

### `P:Autodesk.Revit.UI.TabbedDialogExtension.OnRestoreDefaultsAction`

Member kind: property
Symbol: `Autodesk.Revit.UI.TabbedDialogExtension.OnRestoreDefaultsAction`

#### Summary

The restore defaults handler.

#### Remarks

This handler will be invoked when the "Restore Defaults" button in Revit options dialog is clicked
and the handler should apply only to options set on this page.
There is no "Restore Defaults" button in Revit options dialog if this property was set to `null` .

#### Since

2013

### `P:Autodesk.Revit.UI.TabbedDialogExtension.OnCancelAction`

Member kind: property
Symbol: `Autodesk.Revit.UI.TabbedDialogExtension.OnCancelAction`

#### Summary

The cancel handler.

#### Remarks

This handler will be invoked when the "Cancel" button in Revit options dialog is clicked.
The Revit options dialog will be closed directly if this property was set to `null` .

#### Since

2013

### `P:Autodesk.Revit.UI.TabbedDialogExtension.OnOKAction`

Member kind: property
Symbol: `Autodesk.Revit.UI.TabbedDialogExtension.OnOKAction`

#### Summary

The ok handler.

#### Remarks

This handler will be invoked when the "Ok" button in Revit options dialog is clicked.

#### Since

2013

### `P:Autodesk.Revit.UI.TabbedDialogExtension.Control`

Member kind: property
Symbol: `Autodesk.Revit.UI.TabbedDialogExtension.Control`

#### Summary

The control.

#### Since

2013

### `M:Autodesk.Revit.UI.TabbedDialogExtension.#ctor(System.Windows.Controls.UserControl,Autodesk.Revit.UI.TabbedDialogAction)`

Member kind: method
Symbol: `Autodesk.Revit.UI.TabbedDialogExtension.#ctor(System.Windows.Controls.UserControl,Autodesk.Revit.UI.TabbedDialogAction)`

#### Summary

Constructs a extension instance with a control and ok action handler.

#### Parameter `userControl`

The control.

#### Parameter `onOK`

The ok action handler.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when userControl or onOK
is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when userControl is already
bound to another tabbed dialog.

#### Since

2013

### `T:Autodesk.Revit.UI.TabbedDialogExtension`

Member kind: type
Symbol: `Autodesk.Revit.UI.TabbedDialogExtension`

#### Summary

Contains the information required to create and implement the behavior for the new tab inside
the Revit options dialog.

#### Remarks

Each page has an associated user interface control and the handlers of buttons Cancel, Restore Defaults
and help can optionally be set. The size of the control is limited to 305 (height) x 288 (width) in physical pixels.

#### Since

2013

### `T:Autodesk.Revit.UI.TabbedDialogAction`

Member kind: type
Symbol: `Autodesk.Revit.UI.TabbedDialogAction`

#### Summary

Delegate for tabbed dialog actions, such as OnOK, OnCancel and RestoreDefaults.

#### Since

2013

### `F:ViewCubeOptionsPage.m_bEnableShowCompass`

Member kind: field
Symbol: `ViewCubeOptionsPage.m_bEnableShowCompass`

### `F:ViewCubeOptionsPage.m_bShowCompass`

Member kind: field
Symbol: `ViewCubeOptionsPage.m_bShowCompass`

### `F:ViewCubeOptionsPage.m_bShowInActiveViewOnly`

Member kind: field
Symbol: `ViewCubeOptionsPage.m_bShowInActiveViewOnly`

### `F:ViewCubeOptionsPage.m_bKeepSceneRightSideUp`

Member kind: field
Symbol: `ViewCubeOptionsPage.m_bKeepSceneRightSideUp`

### `F:ViewCubeOptionsPage.m_bAnimatedTransitions`

Member kind: field
Symbol: `ViewCubeOptionsPage.m_bAnimatedTransitions`

### `F:ViewCubeOptionsPage.m_bFitToViewOnViewChange`

Member kind: field
Symbol: `ViewCubeOptionsPage.m_bFitToViewOnViewChange`

### `F:ViewCubeOptionsPage.m_bSnapToClosestView`

Member kind: field
Symbol: `ViewCubeOptionsPage.m_bSnapToClosestView`

### `F:ViewCubeOptionsPage.m_nScreenSize`

Member kind: field
Symbol: `ViewCubeOptionsPage.m_nScreenSize`

### `F:ViewCubeOptionsPage.m_nInactiveOpacity`

Member kind: field
Symbol: `ViewCubeOptionsPage.m_nInactiveOpacity`

### `F:ViewCubeOptionsPage.m_nScreenPosition`

Member kind: field
Symbol: `ViewCubeOptionsPage.m_nScreenPosition`

### `F:ViewCubeOptionsPage.m_bShowViewCube`

Member kind: field
Symbol: `ViewCubeOptionsPage.m_bShowViewCube`

### `M:OptionsPage.#ctor`

Member kind: method
Symbol: `OptionsPage.#ctor`

### `F:CMFCBaseTabCtrl.m_bReadyToDetach`

Member kind: field
Symbol: `CMFCBaseTabCtrl.m_bReadyToDetach`

### `F:CDockablePane.m_sizeDragSensitivity`

Member kind: field
Symbol: `CDockablePane.m_sizeDragSensitivity`

### `E:Autodesk.Revit.UI.AddInCommandBinding.CanExecute`

Member kind: event
Symbol: `Autodesk.Revit.UI.AddInCommandBinding.CanExecute`

#### Summary

Occurs when the command associated with this AddInCommandBinding initiates a check to determine whether
the command can be executed on the command target.

#### Remarks

This callback will be called by Revit's user interface any time there is a contextual change. Therefore, the callback
must be fast and is not permitted to be blocking in any way.

#### Since

2013

### `E:Autodesk.Revit.UI.AddInCommandBinding.Executed`

Member kind: event
Symbol: `Autodesk.Revit.UI.AddInCommandBinding.Executed`

#### Summary

Occurs when the command associated with this AddInCommandBinding executes.

#### Since

2013

### `E:Autodesk.Revit.UI.AddInCommandBinding.BeforeExecuted`

Member kind: event
Symbol: `Autodesk.Revit.UI.AddInCommandBinding.BeforeExecuted`

#### Summary

Occurs before the command associated with this AddInCommandBinding executes.

#### Since

2014

### `P:Autodesk.Revit.UI.AddInCommandBinding.RevitCommandId`

Member kind: property
Symbol: `Autodesk.Revit.UI.AddInCommandBinding.RevitCommandId`

#### Summary

The Revit command Id.

#### Since

2013

### `M:Autodesk.Revit.UI.AddInCommandBinding.#ctor(Autodesk.Revit.UI.UIApplication,Autodesk.Revit.UI.RevitCommandId)`

Member kind: method
Symbol: `Autodesk.Revit.UI.AddInCommandBinding.#ctor(Autodesk.Revit.UI.UIApplication,Autodesk.Revit.UI.RevitCommandId)`

#### Summary

Constructs a new AddInCommandBinding.

#### Parameter `uiApplication`

The UI application.

#### Parameter `revitCommandId`

The Revit command id to identify the command handler you want to replace.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when uiApplication or revitCommandId
is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the given command already has been bound.

#### Since

2013

### `T:Autodesk.Revit.UI.AddInCommandBinding`

Member kind: type
Symbol: `Autodesk.Revit.UI.AddInCommandBinding`

#### Summary

This object represents a binding between a Revit command and one or more handlers which
override the behavior of the command in Revit.

#### Since

2013

### `P:Autodesk.Revit.UI.ComboBoxData.Image`

Member kind: property
Symbol: `Autodesk.Revit.UI.ComboBoxData.Image`

#### Summary

The image shown on the ComboBox.

#### Remarks

The image will be shown on the left side of the item.
The best size is 16 x 16 pixels.

#### Since

2011

### `M:Autodesk.Revit.UI.ComboBoxData.#ctor(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ComboBoxData.#ctor(System.String)`

#### Summary

Constructs a new instance of ComboBoxData.

#### Parameter `name`

The internal name of the ComboBoxMember.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when `null` is passed for name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when an empty string is passed for name.

#### Since

2011

### `T:Autodesk.Revit.UI.ComboBoxData`

Member kind: type
Symbol: `Autodesk.Revit.UI.ComboBoxData`

#### Summary

This class contains information necessary to construct a combo box in the Ribbon.

#### Since

2011

### `E:Autodesk.Revit.UI.ComboBox.CurrentChanged`

Member kind: event
Symbol: `Autodesk.Revit.UI.ComboBox.CurrentChanged`

#### Summary

Subscribe to this event to be notified when the current item of the ComboBox is changed.

### `E:Autodesk.Revit.UI.ComboBox.DropDownClosed`

Member kind: event
Symbol: `Autodesk.Revit.UI.ComboBox.DropDownClosed`

#### Summary

Subscribe to this event to be notified when the drop-down of the ComboBox is closed.

### `E:Autodesk.Revit.UI.ComboBox.DropDownOpened`

Member kind: event
Symbol: `Autodesk.Revit.UI.ComboBox.DropDownOpened`

#### Summary

Subscribe to this event to be notified when the drop-down of the ComboBox is opened.

### `M:Autodesk.Revit.UI.ComboBox.GetItems`

Member kind: method
Symbol: `Autodesk.Revit.UI.ComboBox.GetItems`

#### Summary

Gets the copy of a collection of the ComboBoxMembers assigned to the ComboBox.

#### Since

2011

### `M:Autodesk.Revit.UI.ComboBox.AddSeparator`

Member kind: method
Symbol: `Autodesk.Revit.UI.ComboBox.AddSeparator`

#### Summary

Adds a separator to the drop-down list.

#### Remarks

The separator will be added below the last added member.

#### Since

2011

### `M:Autodesk.Revit.UI.ComboBox.AddItems(System.Collections.Generic.IList{Autodesk.Revit.UI.ComboBoxMemberData})`

Member kind: method
Symbol: `Autodesk.Revit.UI.ComboBox.AddItems(System.Collections.Generic.IList{Autodesk.Revit.UI.ComboBoxMemberData})`

#### Summary

Adds a new items to the ComboBox.

#### Parameter `memberData`

An object list containing the data needed to construct the ComboBoxMember.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when memberData is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when button with memberData.Name already exists in the drop-down list.

#### Returns

The newly added ComboBoxMembers.

#### Since

2011

### `M:Autodesk.Revit.UI.ComboBox.AddItem(Autodesk.Revit.UI.ComboBoxMemberData)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ComboBox.AddItem(Autodesk.Revit.UI.ComboBoxMemberData)`

#### Summary

Adds a new item to the ComboBox.

#### Parameter `memberData`

An object containing the data needed to construct the ComboBoxMember.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when memberData is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when button with memberData.Name already exists in the drop-down list.

#### Returns

The newly added ComboBoxMember.

#### Since

2011

### `P:Autodesk.Revit.UI.ComboBox.Image`

Member kind: property
Symbol: `Autodesk.Revit.UI.ComboBox.Image`

#### Summary

The image shown on the ComboBox.

#### Remarks

The image will be shown on the left side of the item.
The best size is 16 x 16 pixels.

#### Since

2011

### `P:Autodesk.Revit.UI.ComboBox.Current`

Member kind: property
Symbol: `Autodesk.Revit.UI.ComboBox.Current`

#### Summary

Gets or sets the current checked ComboBox member of the ComboBox.

#### Remarks

The default value is the first ComboBox member added to the ComboBox.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when trying to set this property to `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when trying to set this property to a button not in this ComboBox.

#### Since

2011

### `T:Autodesk.Revit.UI.ComboBox`

Member kind: type
Symbol: `Autodesk.Revit.UI.ComboBox`

#### Summary

This class represents a selection control with a drop-down list that can be shown or hidden by clicking the arrow.

#### Remarks

The order of items shown in the ComboBox depends upon the order which they were added, unless the ComboBoxMembers have been assigned to groups.
If the members have been assigned groups, they will be sorted to fall under their groups regardless of the order in which they were added.
Use of this class is not supported in Revit Macros.

#### Since

2011

### `P:Autodesk.Revit.UI.ComboBoxMemberData.GroupName`

Member kind: property
Symbol: `Autodesk.Revit.UI.ComboBoxMemberData.GroupName`

#### Summary

Gets or sets a group name for the ComboBoxMember.

#### Remarks

The GroupName is used to group the items and also appears in the group header.
All ComboBoxMembers assigned to the same group will be grouped in the ComboBox. There will be a header that shows the name.
The default value is `null` .

#### Since

2011

### `P:Autodesk.Revit.UI.ComboBoxMemberData.Image`

Member kind: property
Symbol: `Autodesk.Revit.UI.ComboBoxMemberData.Image`

#### Summary

The image shown on the ComboBoxMember.

#### Remarks

The image will be shown on the left side of the item when the item is added to a ComboBox.
The best size is 16 x 16 pixels.

#### Since

2011

### `P:Autodesk.Revit.UI.ComboBoxMemberData.Text`

Member kind: property
Symbol: `Autodesk.Revit.UI.ComboBoxMemberData.Text`

#### Summary

The user-visible text of the ComboBoxMember.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when setting the value to `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when setting the value to an empty string,
or when the value contains invalid characters.

#### Since

2011

### `M:Autodesk.Revit.UI.ComboBoxMemberData.#ctor(System.String,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.ComboBoxMemberData.#ctor(System.String,System.String)`

#### Summary

Constructs a new instance of ComboBoxMemberData.

#### Parameter `name`

The internal name of the ComboBoxMember.

#### Parameter `text`

The user visible text seen on the item.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when `null` is passed for one or more arguments.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when an empty string is passed for one or more arguments.

#### Since

2011

### `T:Autodesk.Revit.UI.ComboBoxMemberData`

Member kind: type
Symbol: `Autodesk.Revit.UI.ComboBoxMemberData`

#### Summary

This class contains information necessary to construct a ComboBoxMember.

#### Since

2011

### `P:Autodesk.Revit.UI.ComboBoxMember.GroupName`

Member kind: property
Symbol: `Autodesk.Revit.UI.ComboBoxMember.GroupName`

#### Summary

The group to which the ComboBoxMember is assigned.

#### Remarks

If set, the ComboBoxMember appears under a group header in the ComboBox. If `null` , the ComboBoxMember is not a member of any group.
The default value is `null` .

#### Since

2011

### `P:Autodesk.Revit.UI.ComboBoxMember.Image`

Member kind: property
Symbol: `Autodesk.Revit.UI.ComboBoxMember.Image`

#### Summary

The image shown on the ComboBoxMember.

#### Remarks

The image will be shown on the left side of the item.
The best size is 16 x 16 pixels.

#### Since

2011

### `T:Autodesk.Revit.UI.ComboBoxMember`

Member kind: type
Symbol: `Autodesk.Revit.UI.ComboBoxMember`

#### Summary

This class represents an item in the drop-down list of a ComboBox.

#### Remarks

Note that a ComboBoxMember will not show an individual tool tip.
Use of this class is not supported in Revit Macros.

#### Since

2011

### `M:Autodesk.Revit.UI.RevitCommandId.GetInternalCommandName`

Member kind: method
Symbol: `Autodesk.Revit.UI.RevitCommandId.GetInternalCommandName`

#### Returns

The name of the command we set internally.

#### Since

2013

### `M:Autodesk.Revit.UI.RevitCommandId.LookupCommandId(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.UI.RevitCommandId.LookupCommandId(System.String)`

#### Summary

Looks up and retrieves the Revit command id with the given id string.

#### Parameter `name`

he Revit command name. Refer to the entries in the Revit journal to find the string to use for a particular command.

#### Returns

The Revit command id. Returning "null" if a command with the given name was not found.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.UI.RevitCommandId.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.UI.RevitCommandId.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.UI.RevitCommandId.HasBinding`

Member kind: property
Symbol: `Autodesk.Revit.UI.RevitCommandId.HasBinding`

#### Summary

Indicates whether a replacement of either the Execute or CanExecute events (or both) have been applied to this command.

#### Remarks

This will not indicate if one or more applications have subscribed to the BeforeExecuted event,
as this event is not limited to a single subscriber.

#### Since

2013

### `P:Autodesk.Revit.UI.RevitCommandId.CanHaveBinding`

Member kind: property
Symbol: `Autodesk.Revit.UI.RevitCommandId.CanHaveBinding`

#### Summary

Indicates whether the command can be assigned a binding to an external add-in.

#### Since

2013

### `P:Autodesk.Revit.UI.RevitCommandId.Id`

Member kind: property
Symbol: `Autodesk.Revit.UI.RevitCommandId.Id`

#### Summary

The command id.

#### Since

2013

### `P:Autodesk.Revit.UI.RevitCommandId.Name`

Member kind: property
Symbol: `Autodesk.Revit.UI.RevitCommandId.Name`

#### Summary

The command name.

#### Since

2013

### `M:Autodesk.Revit.UI.RevitCommandId.LookupPostableCommandId(Autodesk.Revit.UI.PostableCommand)`

Member kind: method
Symbol: `Autodesk.Revit.UI.RevitCommandId.LookupPostableCommandId(Autodesk.Revit.UI.PostableCommand)`

#### Summary

Looks up and retrieves the Revit command id with the given id string.

#### Parameter `postableCommand`

The postable command.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when name is `null` .

#### Returns

The Revit command id. Returning `null` if a command with the given name was not found.

#### Since

2014

### `M:Autodesk.Revit.UI.RevitCommandId.#ctor(System.String,System.UInt32)`

Member kind: method
Symbol: `Autodesk.Revit.UI.RevitCommandId.#ctor(System.String,System.UInt32)`

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `T:Autodesk.Revit.UI.RevitCommandId`

Member kind: type
Symbol: `Autodesk.Revit.UI.RevitCommandId`

#### Summary

Represents a command id in Autodesk Revit.

#### Remarks

Each Revit command is assigned a command id and non-localized name.
This class allows you to look up a command by its name, and represents any Revit command in the use of an AddInCommandBinding.

#### Since

2013

### `T:Autodesk.Revit.UI.PostableCommand`

Member kind: type
Symbol: `Autodesk.Revit.UI.PostableCommand`

#### Summary

Enumerates all of the built-in commands which can be posted by an API application.

#### Since

2014

### `F:Autodesk.Revit.UI.PostableCommand.StatusBar`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.StatusBar`

#### Summary

Displays the status bar at the bottom of the Revit window.

### `F:Autodesk.Revit.UI.PostableCommand.ExitRevit`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.ExitRevit`

#### Summary

Exit Revit.

### `F:Autodesk.Revit.UI.PostableCommand.CanvasTheme`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.CanvasTheme`

#### Summary

Sets the color theme of the canvas to dark or light.

### `F:Autodesk.Revit.UI.PostableCommand.TileViews`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.TileViews`

#### Summary

Arranges all open views within the application window, tiled so you can see each one in the drawing area.

### `F:Autodesk.Revit.UI.PostableCommand.TabViews`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.TabViews`

#### Summary

Arranges all open views in the drawing area as tabs in a single window.

### `F:Autodesk.Revit.UI.PostableCommand.PasteFromClipboard`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.PasteFromClipboard`

#### Summary

Pastes elements from the clipboard into the current view.

### `F:Autodesk.Revit.UI.PostableCommand.CutToClipboard`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.CutToClipboard`

#### Summary

Removes selected elements, and places them on the clipboard.

### `F:Autodesk.Revit.UI.PostableCommand.CopyToClipboard`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.CopyToClipboard`

#### Summary

Copies selected elements to the clipboard.

### `F:Autodesk.Revit.UI.PostableCommand.PrintPreview`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.PrintPreview`

#### Summary

Displays a preview version of the current view or sheet to print.

### `F:Autodesk.Revit.UI.PostableCommand.Print`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.Print`

#### Summary

Sends the current drawing area or selected views and sheets to a printer or a printable file.

### `F:Autodesk.Revit.UI.PostableCommand.PrintSetup`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.PrintSetup`

#### Summary

Specifies print options.

### `F:Autodesk.Revit.UI.PostableCommand.SaveAsProject`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.SaveAsProject`

#### Summary

Saves the current Revit project file.

### `F:Autodesk.Revit.UI.PostableCommand.Save`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.Save`

#### Summary

Saves the currently open project file.

### `F:Autodesk.Revit.UI.PostableCommand.Close`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.Close`

#### Summary

Close Revit.

### `F:Autodesk.Revit.UI.PostableCommand.OpenRevitFile`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.OpenRevitFile`

#### Summary

Opens any Revit file type.

### `F:Autodesk.Revit.UI.PostableCommand.Optimize`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.Optimize`

#### Summary

Access energy and environmental performance data in Insight.

### `F:Autodesk.Revit.UI.PostableCommand.LinkTopography`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.LinkTopography`

#### Summary

Links existing topography to the current Revit model.

### `F:Autodesk.Revit.UI.PostableCommand.RepairCentralModel`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.RepairCentralModel`

#### Summary

Repairs a corrupt central model.

### `F:Autodesk.Revit.UI.PostableCommand.DynamoPlayer`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.DynamoPlayer`

#### Summary

Preview, select, and run your Dynamo graphs from a single dialog.

### `F:Autodesk.Revit.UI.PostableCommand.SpaceNaming`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.SpaceNaming`

#### Summary

Assigns the names and numbers from architectural rooms to MEP spaces used for building performance analysis.

### `F:Autodesk.Revit.UI.PostableCommand.PDF`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.PDF`

#### Summary

Creates PDF files.

### `F:Autodesk.Revit.UI.PostableCommand.PropertyLineData`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.PropertyLineData`

#### Summary

Define the angle display and units used when creating and labeling property lines.

### `F:Autodesk.Revit.UI.PostableCommand.Loads`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.Loads`

#### Summary

Defines point, line, and area loads in an analytical model.

### `F:Autodesk.Revit.UI.PostableCommand.CoordinationModelAutodeskDocs`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.CoordinationModelAutodeskDocs`

#### Summary

Links a coordination model view from Autodesk Docs into the current project.

### `F:Autodesk.Revit.UI.PostableCommand.CoordinationModelLocal`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.CoordinationModelLocal`

#### Summary

Links a NWD or NWC file to provide context for the Revit model.

### `F:Autodesk.Revit.UI.PostableCommand.PanelByExtrusion`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.PanelByExtrusion`

#### Summary

Creates an analytical panel perpendicular to the current work plane after a sketch of the path.

### `F:Autodesk.Revit.UI.PostableCommand.RebarBendingDetail`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.RebarBendingDetail`

#### Summary

Creates bar bending details for the selected individual rebar or sets.

### `F:Autodesk.Revit.UI.PostableCommand.AnalyticalAutomation`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.AnalyticalAutomation`

#### Summary

Automates the creation, element connection, and update of the analytical model, using the physical representation as context.

### `F:Autodesk.Revit.UI.PostableCommand.CreateFromImport`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.CreateFromImport`

#### Summary

Creates a solid topographical element.

### `F:Autodesk.Revit.UI.PostableCommand.Toposolid`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.Toposolid`

#### Summary

Creates a solid topographical element.

### `F:Autodesk.Revit.UI.PostableCommand.PanelByBoundary`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.PanelByBoundary`

#### Summary

Creates a planar analytical panel for the current work plane after a sketch of the contour.

### `F:Autodesk.Revit.UI.PostableCommand.DynamoPlayerForSteel`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.DynamoPlayerForSteel`

#### Summary

Places steel connections on selected elements using pre-defined rules.

### `F:Autodesk.Revit.UI.PostableCommand.OpenCloudModel`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.OpenCloudModel`

#### Summary

Opens a Revit cloud model.

### `F:Autodesk.Revit.UI.PostableCommand.ViewAnalysis`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.ViewAnalysis`

#### Summary

Access energy and environmental performance data in the cloud.

### `F:Autodesk.Revit.UI.PostableCommand.GenerateAnalysis`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.GenerateAnalysis`

#### Summary

Creates the energy analytical model and generates design options and potential performance outcomes.

### `F:Autodesk.Revit.UI.PostableCommand.ElectricalAnalyticalLoadTypeSettings`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.ElectricalAnalyticalLoadTypeSettings`

#### Summary

Opens the Electrical Analytical Load Type Settings dialog to define the power requirement for area-based loads.

### `F:Autodesk.Revit.UI.PostableCommand.ResetSharedCoordinates`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.ResetSharedCoordinates`

#### Summary

Eliminate shared coordinates in the host model.

### `F:Autodesk.Revit.UI.PostableCommand.SharedViews`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.SharedViews`

#### Summary

Opens and closes the Shared Views palette.

### `F:Autodesk.Revit.UI.PostableCommand.WorksharingMonitor`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.WorksharingMonitor`

#### Summary

Launches Worksharing Monitor to manage a file-based workshared model.

### `F:Autodesk.Revit.UI.PostableCommand.BatchPrint`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.BatchPrint`

#### Summary

Print a large number of drawings with a batch job.

### `F:Autodesk.Revit.UI.PostableCommand.AnalyticalMember`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.AnalyticalMember`

#### Summary

Places an analytical member in the project.

### `F:Autodesk.Revit.UI.PostableCommand.LinkImage`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.LinkImage`

#### Summary

Inserts a link to an image into a model view.

### `F:Autodesk.Revit.UI.PostableCommand.LinkPDF`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.LinkPDF`

#### Summary

Inserts a link to a PDF into a model view.

### `F:Autodesk.Revit.UI.PostableCommand.SystemsAnalysis`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.SystemsAnalysis`

#### Summary

Performs a systems analysis and generates a report for whole building energy simulation and analysis.

### `F:Autodesk.Revit.UI.PostableCommand.SaveAsCloudModel`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.SaveAsCloudModel`

#### Summary

Saves the current Revit model to the cloud.

### `F:Autodesk.Revit.UI.PostableCommand.ToggleHome`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.ToggleHome`

#### Summary

Toggle Revit Home.

### `F:Autodesk.Revit.UI.PostableCommand.CutBy`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.CutBy`

#### Summary

Creates a cut on a model element along the shape of another intersecting model element and a cut through the intersecting element. The connection between the two elements is also created.

### `F:Autodesk.Revit.UI.PostableCommand.CutThrough`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.CutThrough`

#### Summary

Creates a cut through a model element around the contour of another intersecting model element. The weld between the two elements is also created.

### `F:Autodesk.Revit.UI.PostableCommand.SawCutWeb`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.SawCutWeb`

#### Summary

Creates a cut on a beam adjusted according to the web of another intersecting beam and the related connection between the beams.

### `F:Autodesk.Revit.UI.PostableCommand.SawCutFlange`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.SawCutFlange`

#### Summary

Creates a cut on a beam adjusted according to the flange of another intersecting beam and the related connection between the beams.

### `F:Autodesk.Revit.UI.PostableCommand.Miter`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.Miter`

#### Summary

Creates a miter cut vertically or at the bisecting line of two beams and the related connection between the beams.

### `F:Autodesk.Revit.UI.PostableCommand.Cope`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.Cope`

#### Summary

Creates a parametric cope on intersecting beams and the related connection between the beams.

### `F:Autodesk.Revit.UI.PostableCommand.ContourCut`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.ContourCut`

#### Summary

Creates a contour cut on the selected faces of a beam or a plate.

### `F:Autodesk.Revit.UI.PostableCommand.ShearStuds`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.ShearStuds`

#### Summary

Creates shear studs and the related welds on the selected face of model elements.

### `F:Autodesk.Revit.UI.PostableCommand.Anchors`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.Anchors`

#### Summary

Inserts anchors and the related holes in the selected model elements.

### `F:Autodesk.Revit.UI.PostableCommand.Holes`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.Holes`

#### Summary

Inserts holes on the selected face of model elements.

### `F:Autodesk.Revit.UI.PostableCommand.Bolts`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.Bolts`

#### Summary

Inserts bolts and the related holes in the selected model elements.

### `F:Autodesk.Revit.UI.PostableCommand.Plate`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.Plate`

#### Summary

Creates a structural plate in the building model.

### `F:Autodesk.Revit.UI.PostableCommand.Welds`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.Welds`

#### Summary

Inserts a weld on one of the available edges of the model elements to be connected.

### `F:Autodesk.Revit.UI.PostableCommand.CornerCut`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.CornerCut`

#### Summary

Creates a cut on the corner of a selected plate.

### `F:Autodesk.Revit.UI.PostableCommand.CopeSkewed`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.CopeSkewed`

#### Summary

Creates a skewed cope at the selected beam end, either at the top or at the bottom.

### `F:Autodesk.Revit.UI.PostableCommand.Shorten`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.Shorten`

#### Summary

Creates a shorten object on the selected beam that can trim or extend the beam.

### `F:Autodesk.Revit.UI.PostableCommand.DeleteEnergyModel`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.DeleteEnergyModel`

#### Summary

Removes the energy analytical model from the Revit project.

### `F:Autodesk.Revit.UI.PostableCommand.Dynamo`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.Dynamo`

#### Summary

Provides access to Dynamo, an open source visual programming platform for designers.

### `F:Autodesk.Revit.UI.PostableCommand.LoadRebarShapeIntoProjectAndClose`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.LoadRebarShapeIntoProjectAndClose`

#### Summary

Loads the rebar shape into open projects or family files and closes the family after it loads.

### `F:Autodesk.Revit.UI.PostableCommand.FabricationPart`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.FabricationPart`

#### Summary

Displays the MEP Fabrication Parts palette.

### `F:Autodesk.Revit.UI.PostableCommand.LoadFamilyIntoProjectAndClose`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.LoadFamilyIntoProjectAndClose`

#### Summary

Loads the family into open projects or family files and closes the family after it loads.

### `F:Autodesk.Revit.UI.PostableCommand.SpatialGrid`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.SpatialGrid`

#### Summary

Place a square or hexagonal grid in a room element.

### `F:Autodesk.Revit.UI.PostableCommand.PeopleContent`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.PeopleContent`

#### Summary

Place a family to indicate a person and a physical distance radius into the view.

### `F:Autodesk.Revit.UI.PostableCommand.OneWayIndicator`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.OneWayIndicator`

#### Summary

Place a one-way annotation family into the view.

### `F:Autodesk.Revit.UI.PostableCommand.MultiplePaths`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.MultiplePaths`

#### Summary

Places multiple paths of travel between two selected points using a specified minimum path separation for each path.

### `F:Autodesk.Revit.UI.PostableCommand.MultipleValuesIndication`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.MultipleValuesIndication`

#### Summary

Specifies the value indicated for a parameter when multiple elements with different parameter values are selected.

### `F:Autodesk.Revit.UI.PostableCommand.PathOfTravel`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.PathOfTravel`

#### Summary

Creates a path of travel along the shortest distance between 2 selected points.

### `F:Autodesk.Revit.UI.PostableCommand.RevealObstacles`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.RevealObstacles`

#### Summary

Highlights categories that are considered obstacles in the view.

### `F:Autodesk.Revit.UI.PostableCommand.AssemblyCode`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.AssemblyCode`

#### Summary

Specifies the location of the assembly code file or reloads the assembly code table from the current file.

### `F:Autodesk.Revit.UI.PostableCommand.PublishSettings`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.PublishSettings`

#### Summary

Selects the views and sheets to publish to the cloud.

### `F:Autodesk.Revit.UI.PostableCommand.CollaborateInCloud`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.CollaborateInCloud`

#### Summary

Enables collaboration in the cloud, which allows team members to work on a model simultaneously.

### `F:Autodesk.Revit.UI.PostableCommand.Collaborate`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.Collaborate`

#### Summary

Enables collaboration so team members can work on a model simultaneously.

### `F:Autodesk.Revit.UI.PostableCommand.GlobalParameters`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.GlobalParameters`

#### Summary

Specifies parameters that can be added to a project, and used to define values of other parameters.

### `F:Autodesk.Revit.UI.PostableCommand.DisplaceElements`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.DisplaceElements`

#### Summary

Creates a view-specific representation of model elements that can be displaced in the view.

### `F:Autodesk.Revit.UI.PostableCommand.CreateEnergyModel`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.CreateEnergyModel`

#### Summary

Creates the energy analytical model.

### `F:Autodesk.Revit.UI.PostableCommand.RenderGallery`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.RenderGallery`

#### Summary

Opens your online gallery of completed and in-progress renderings in a web browser.

### `F:Autodesk.Revit.UI.PostableCommand.RenderInCloud`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.RenderInCloud`

#### Summary

Renders 3D views online to create still images or interactive panoramas.

### `F:Autodesk.Revit.UI.PostableCommand.ManageConnectionToARevitServerAccelerator`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.ManageConnectionToARevitServerAccelerator`

#### Summary

Specifies the Revit Server Accelerator to use for worksharing, or changes the accelerator to which you are connected.

### `F:Autodesk.Revit.UI.PostableCommand.StairTreadOrRiserNumber`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.StairTreadOrRiserNumber`

#### Summary

Creates a sequence of tread or riser numbers for a run in plan, elevation, or section views.

### `F:Autodesk.Revit.UI.PostableCommand.CreateAssembly`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.CreateAssembly`

#### Summary

Creates an assembly from elements you select in the drawing area.

### `F:Autodesk.Revit.UI.PostableCommand.GuideGrid`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.GuideGrid`

#### Summary

Creates a new guide element in the active sheet to help align elements within and between sheets.

### `F:Autodesk.Revit.UI.PostableCommand.ExportGBXML`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.ExportGBXML`

#### Summary

Saves the model as a gbXML file.

### `F:Autodesk.Revit.UI.PostableCommand.Generate`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.Generate`

#### Summary

Creates the energy analytical model and generates design options and potential performance outcomes with Insight.

### `F:Autodesk.Revit.UI.PostableCommand.EnergySettings`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.EnergySettings`

#### Summary

Specifies parameters used to create the energy analytical model.

### `F:Autodesk.Revit.UI.PostableCommand.FindOrReplace`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.FindOrReplace`

#### Summary

Finds and replaces text in an open project file.

### `F:Autodesk.Revit.UI.PostableCommand.LoadsScalingDisplay`

Member kind: field
Symbol: `Autodesk.Revit.UI.PostableCommand.LoadsScalingDisplay`

#### Summary

Overrides the load type graphics scale using the project scale.
