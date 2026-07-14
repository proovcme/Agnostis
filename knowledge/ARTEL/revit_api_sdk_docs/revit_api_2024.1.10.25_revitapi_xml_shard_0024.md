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
Shard: 24
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `M:CD2DBitmap.Create(CRenderTarget*)`

Member kind: method
Symbol: `CD2DBitmap.Create(CRenderTarget*)`

#### Summary

Creates a CD2DBitmap.

#### Returns

If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

#### Parameter `pRenderTarget`

A pointer to the render target.

### `M:CD2DBitmap.CommonInit`

Member kind: method
Symbol: `CD2DBitmap.CommonInit`

#### Summary

Initializes the object

### `M:CD2DBitmap.op_Implicit~ID2D1Bitmap*`

Member kind: method
Symbol: `CD2DBitmap.op_Implicit~ID2D1Bitmap*`

#### Summary

Returns ID2D1Bitmap interface

#### Returns

Pointer to an ID2D1Bitmap interface or NULL if object is not initialized yet.

### `M:CD2DBitmap.Get`

Member kind: method
Symbol: `CD2DBitmap.Get`

#### Summary

Returns ID2D1Bitmap interface

#### Returns

Pointer to an ID2D1Bitmap interface or NULL if object is not initialized yet.

### `M:CD2DBitmap.IsValid`

Member kind: method
Symbol: `CD2DBitmap.IsValid`

#### Summary

Checks resource validity

#### Returns

TRUE if resource is valid; otherwise FALSE.

### `M:CD2DBitmap.CopyFromMemory(System.Void!System.Runtime.CompilerServices.IsConst*,System.UInt32,CD2DRectU!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `CD2DBitmap.CopyFromMemory(System.Void!System.Runtime.CompilerServices.IsConst*,System.UInt32,CD2DRectU!System.Runtime.CompilerServices.IsConst*)`

#### Summary

Copies the specified region from memory into the current bitmap

#### Returns

If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

#### Parameter `srcData`

The data to copy

#### Parameter `pitch`

The stride, or pitch, of the source bitmap stored in srcData. The stride is the byte count of a scanline (one row of pixels in memory). The stride can be computed from the following formula: pixel width * bytes per pixel + memory padding

#### Parameter `destRect`

In the current bitmap, the upper-left corner of the area to which the region specified by srcRect is copied

### `M:CD2DBitmap.CopyFromRenderTarget(CRenderTarget!System.Runtime.CompilerServices.IsConst*,CD2DPointU!System.Runtime.CompilerServices.IsConst*,CD2DRectU!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `CD2DBitmap.CopyFromRenderTarget(CRenderTarget!System.Runtime.CompilerServices.IsConst*,CD2DPointU!System.Runtime.CompilerServices.IsConst*,CD2DRectU!System.Runtime.CompilerServices.IsConst*)`

#### Summary

Copies the specified region from the specified render target into the current bitmap

#### Returns

If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

#### Parameter `pRenderTarget`

The render target that contains the region to copy

#### Parameter `destPoint`

In the current bitmap, the upper-left corner of the area to which the region specified by srcRect is copied

#### Parameter `srcRect`

The area of renderTarget to copy

### `M:CD2DBitmap.CopyFromBitmap(CD2DBitmap!System.Runtime.CompilerServices.IsConst*,CD2DPointU!System.Runtime.CompilerServices.IsConst*,CD2DRectU!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `CD2DBitmap.CopyFromBitmap(CD2DBitmap!System.Runtime.CompilerServices.IsConst*,CD2DPointU!System.Runtime.CompilerServices.IsConst*,CD2DRectU!System.Runtime.CompilerServices.IsConst*)`

#### Summary

Copies the specified region from the specified bitmap into the current bitmap

#### Returns

If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

#### Parameter `pBitmap`

The bitmap to copy from

#### Parameter `destPoint`

In the current bitmap, the upper-left corner of the area to which the region specified by srcRect is copied

#### Parameter `srcRect`

The area of bitmap to copy

### `M:CD2DBitmap.GetDPI`

Member kind: method
Symbol: `CD2DBitmap.GetDPI`

#### Summary

Return the dots per inch (DPI) of the bitmap

#### Returns

The horizontal and vertical DPI of the bitmap.

### `M:CD2DBitmap.GetPixelFormat`

Member kind: method
Symbol: `CD2DBitmap.GetPixelFormat`

#### Summary

Retrieves the pixel format and alpha mode of the bitmap

#### Returns

The pixel format and alpha mode of the bitmap.

### `M:CD2DBitmap.GetPixelSize`

Member kind: method
Symbol: `CD2DBitmap.GetPixelSize`

#### Summary

Returns the size, in device-dependent units (pixels), of the bitmap

#### Returns

The size, in pixels, of the bitmap..

### `M:CD2DBitmap.GetSize`

Member kind: method
Symbol: `CD2DBitmap.GetSize`

#### Summary

Returns the size, in device-independent pixels (DIPs), of the bitmap

#### Returns

The size, in DIPs, of the bitmap.

### `M:CD2DBitmap.Detach`

Member kind: method
Symbol: `CD2DBitmap.Detach`

#### Summary

Detaches resource interface from the object

#### Returns

Pointer to detached resource interface.

### `M:CD2DBitmap.Attach(ID2D1Bitmap*)`

Member kind: method
Symbol: `CD2DBitmap.Attach(ID2D1Bitmap*)`

#### Summary

Attaches existing resource interface to the object

#### Parameter `pResource`

Existing resource interface. Cannot be NULL

### `M:CD2DBitmap.Dispose`

Member kind: method
Symbol: `CD2DBitmap.Dispose`

#### Summary

The destructor. Called when a D2D bitmap object is being destroyed.

### `M:CD2DBitmap.#ctor(CRenderTarget*,System.Int32)`

Member kind: method
Symbol: `CD2DBitmap.#ctor(CRenderTarget*,System.Int32)`

#### Summary

Constructs a CD2DBitmap object.

#### Parameter `pParentTarget`

A pointer to the render target.

#### Parameter `bAutoDestroy`

Indicates that the object will be destroyed by owner (pParentTarget).

### `M:CD2DBitmap.#ctor(CRenderTarget*,HBITMAP__*,CD2DSizeU,System.Int32)`

Member kind: method
Symbol: `CD2DBitmap.#ctor(CRenderTarget*,HBITMAP__*,CD2DSizeU,System.Int32)`

#### Summary

Constructs a CD2DBitmap object from HBITMAP.

#### Parameter `pParentTarget`

A pointer to the render target.

#### Parameter `hbmpSrc`

Handle to the bitmap.

#### Parameter `sizeDest`

Destination size of the bitmap.

#### Parameter `bAutoDestroy`

Indicates that the object will be destroyed by owner (pParentTarget).

### `M:CD2DBitmap.#ctor(CRenderTarget*,System.Char!System.Runtime.CompilerServices.IsConst*,CD2DSizeU,System.Int32)`

Member kind: method
Symbol: `CD2DBitmap.#ctor(CRenderTarget*,System.Char!System.Runtime.CompilerServices.IsConst*,CD2DSizeU,System.Int32)`

#### Summary

Constructs a CD2DBitmap object from file.

#### Parameter `pParentTarget`

A pointer to the render target.

#### Parameter `lpszPath`

Pointer to a null-terminated string that contains the name of file.

#### Parameter `sizeDest`

Destination size of the bitmap.

#### Parameter `bAutoDestroy`

Indicates that the object will be destroyed by owner (pParentTarget).

### `M:CD2DBitmap.#ctor(CRenderTarget*,System.UInt32,System.Char!System.Runtime.CompilerServices.IsConst*,CD2DSizeU,System.Int32)`

Member kind: method
Symbol: `CD2DBitmap.#ctor(CRenderTarget*,System.UInt32,System.Char!System.Runtime.CompilerServices.IsConst*,CD2DSizeU,System.Int32)`

#### Summary

Constructs a CD2DBitmap object from resource.

#### Parameter `pParentTarget`

A pointer to the render target.

#### Parameter `uiResID`

The resource ID number of the resource.

#### Parameter `lpszType`

Pointer to a null-terminated string that contains the resource type.

#### Parameter `sizeDest`

Destination size of the bitmap.

#### Parameter `bAutoDestroy`

Indicates that the object will be destroyed by owner (pParentTarget).

### `T:CD2DBitmap`

Member kind: type
Symbol: `CD2DBitmap`

#### Summary

ID2D1Bitmap wrapper.

### `F:CD2DLayer.m_pLayer`

Member kind: field
Symbol: `CD2DLayer.m_pLayer`

#### Summary

Stores a pointer to an ID2D1Layer object.

### `M:CD2DLayer.Destroy`

Member kind: method
Symbol: `CD2DLayer.Destroy`

#### Summary

Destroys a CD2DLayer object.

### `M:CD2DLayer.Create(CRenderTarget*)`

Member kind: method
Symbol: `CD2DLayer.Create(CRenderTarget*)`

#### Summary

Creates a CD2DLayer.

#### Returns

If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

#### Parameter `pRenderTarget`

A pointer to the render target.

### `M:CD2DLayer.Detach`

Member kind: method
Symbol: `CD2DLayer.Detach`

#### Summary

Detaches resource interface from the object

#### Returns

Pointer to detached resource interface.

### `M:CD2DLayer.Attach(ID2D1Layer*)`

Member kind: method
Symbol: `CD2DLayer.Attach(ID2D1Layer*)`

#### Summary

Attaches existing resource interface to the object

#### Parameter `pResource`

Existing resource interface. Cannot be NULL

### `M:CD2DLayer.op_Implicit~ID2D1Layer*`

Member kind: method
Symbol: `CD2DLayer.op_Implicit~ID2D1Layer*`

#### Summary

Returns ID2D1Layer interface

#### Returns

Pointer to an ID2D1Layer interface or NULL if object is not initialized yet.

### `M:CD2DLayer.Get`

Member kind: method
Symbol: `CD2DLayer.Get`

#### Summary

Returns ID2D1Layer interface

#### Returns

Pointer to an ID2D1Layer interface or NULL if object is not initialized yet.

### `M:CD2DLayer.IsValid`

Member kind: method
Symbol: `CD2DLayer.IsValid`

#### Summary

Checks resource validity

#### Returns

TRUE if resource is valid; otherwise FALSE.

### `M:CD2DLayer.GetSize`

Member kind: method
Symbol: `CD2DLayer.GetSize`

#### Summary

Returns the size of the render target in device-independent pixels

#### Returns

The current size of the render target in device-independent pixels

### `M:CD2DLayer.Dispose`

Member kind: method
Symbol: `CD2DLayer.Dispose`

#### Summary

The destructor. Called when a D2D layer object is being destroyed.

### `M:CD2DLayer.#ctor(CRenderTarget*,System.Int32)`

Member kind: method
Symbol: `CD2DLayer.#ctor(CRenderTarget*,System.Int32)`

#### Summary

Constructs a CD2DLayer object.

#### Parameter `pParentTarget`

A pointer to the render target.

#### Parameter `bAutoDestroy`

Indicates that the object will be destroyed by owner (pParentTarget).

### `T:CD2DLayer`

Member kind: type
Symbol: `CD2DLayer`

#### Summary

ID2D1Layer wrapper.

### `F:CD2DResource.m_pParentTarget`

Member kind: field
Symbol: `CD2DResource.m_pParentTarget`

#### Summary

Pointer to the parent CRenderTarget)

### `F:CD2DResource.m_bIsAutoDestroy`

Member kind: field
Symbol: `CD2DResource.m_bIsAutoDestroy`

#### Summary

Resource will be destoyed by owner (CRenderTarget)

### `M:CD2DResource.IsValid`

Member kind: method
Symbol: `CD2DResource.IsValid`

#### Summary

Checks resource validity

#### Returns

TRUE if resource is valid; otherwise FALSE.

### `M:CD2DResource.Destroy`

Member kind: method
Symbol: `CD2DResource.Destroy`

#### Summary

Destroys a CD2DResource object.

### `M:CD2DResource.Create(CRenderTarget*)`

Member kind: method
Symbol: `CD2DResource.Create(CRenderTarget*)`

#### Summary

Creates a CD2DResource.

#### Returns

If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

#### Parameter `pRenderTarget`

A pointer to the render target.

### `M:CD2DResource.ReCreate(CRenderTarget*)`

Member kind: method
Symbol: `CD2DResource.ReCreate(CRenderTarget*)`

#### Summary

Re-creates a CD2DResource.

#### Returns

If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.

#### Parameter `pRenderTarget`

A pointer to the render target.

### `M:CD2DResource.IsAutoDestroy`

Member kind: method
Symbol: `CD2DResource.IsAutoDestroy`

#### Summary

Check auto destroy flag.

#### Returns

TRUE if the object will be destroyed by its owner; otherwise FALSE.

### `M:CD2DResource.Dispose`

Member kind: method
Symbol: `CD2DResource.Dispose`

#### Summary

The destructor. Called when a D2D resource object is being destroyed.

### `M:CD2DResource.#ctor(CRenderTarget*,System.Int32)`

Member kind: method
Symbol: `CD2DResource.#ctor(CRenderTarget*,System.Int32)`

#### Summary

Constructs a CD2DResource object.

#### Parameter `pParentTarget`

A pointer to the render target.

#### Parameter `bAutoDestroy`

Indicates that the object will be destroyed by owner (pParentTarget).

### `T:CD2DResource`

Member kind: type
Symbol: `CD2DResource`

#### Summary

An abstract class, which provides a interface for creating and managing D2D resources such as brushes, layers and texts.

### `M:CD2DEllipse.#ctor(CD2DPointF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DSizeF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DEllipse.#ctor(CD2DPointF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DSizeF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DEllipse from CD2DPointF and CD2DSizeF objects.

#### Parameter `ptCenter`

The center point of the ellipse.

#### Parameter `sizeRadius`

The X-radius and Y-radius of the ellipse.

### `M:CD2DEllipse.#ctor(D2D1_ELLIPSE!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `CD2DEllipse.#ctor(D2D1_ELLIPSE!System.Runtime.CompilerServices.IsConst*)`

#### Summary

Constructs a CD2DEllipse object from D2D1_ELLIPSE object.

#### Parameter `ellipse`

source ellipse

### `M:CD2DEllipse.#ctor(D2D1_ELLIPSE!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DEllipse.#ctor(D2D1_ELLIPSE!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DEllipse object from D2D1_ELLIPSE object.

#### Parameter `ellipse`

source ellipse

### `M:CD2DEllipse.#ctor(CD2DRectF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DEllipse.#ctor(CD2DRectF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DEllipse object from CD2DRectF object.

#### Parameter `rect`

source rectangle

### `T:CD2DEllipse`

Member kind: type
Symbol: `CD2DEllipse`

#### Summary

D2D1_ELLIPSE wrapper

### `M:CD2DRoundedRect.#ctor(D2D1_ROUNDED_RECT!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `CD2DRoundedRect.#ctor(D2D1_ROUNDED_RECT!System.Runtime.CompilerServices.IsConst*)`

#### Summary

Constructs a CD2DRoundedRect object from D2D1_ROUNDED_RECT object.

#### Parameter `rectIn`

source rectangle

### `M:CD2DRoundedRect.#ctor(D2D1_ROUNDED_RECT!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DRoundedRect.#ctor(D2D1_ROUNDED_RECT!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DRoundedRect object from D2D1_ROUNDED_RECT object.

#### Parameter `rectIn`

source rectangle

### `M:CD2DRoundedRect.#ctor(CD2DRectF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DSizeF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DRoundedRect.#ctor(CD2DRectF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced,CD2DSizeF!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DRoundedRect object from CD2DRectF object.

#### Parameter `rectIn`

source rectangle

#### Parameter `sizeRadius`

radius size

### `T:CD2DRoundedRect`

Member kind: type
Symbol: `CD2DRoundedRect`

#### Summary

D2D1_ROUNDED_RECT wrapper

### `M:CD2DRectU.op_Implicit~CRect`

Member kind: method
Symbol: `CD2DRectU.op_Implicit~CRect`

#### Summary

Converts CD2DRectU to CRect object.

#### Returns

Current value of D2D rectangle.

### `M:CD2DRectU.IsNull`

Member kind: method
Symbol: `CD2DRectU.IsNull`

#### Summary

Returns a Boolean value that indicates whether an expression contains no valid data (Null).

#### Returns

TRUE if rectangle's top, left, bottom, and right values are all equal to 0; otherwise FALSE.

### `M:CD2DRectU.#ctor(System.UInt32,System.UInt32,System.UInt32,System.UInt32)`

Member kind: method
Symbol: `CD2DRectU.#ctor(System.UInt32,System.UInt32,System.UInt32,System.UInt32)`

#### Summary

Constructs a CD2DRectU object from four UINT32 values.

#### Parameter `uLeft`

source left coordinate

#### Parameter `uTop`

source top coordinate

#### Parameter `uRight`

source right coordinate

#### Parameter `uBottom`

source bottom coordinate

### `M:CD2DRectU.#ctor(D2D_RECT_U!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `CD2DRectU.#ctor(D2D_RECT_U!System.Runtime.CompilerServices.IsConst*)`

#### Summary

Constructs a CD2DRectU object from D2D1_RECT_U object.

#### Parameter `rect`

source rectangle

### `M:CD2DRectU.#ctor(D2D_RECT_U!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DRectU.#ctor(D2D_RECT_U!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DRectU object from D2D1_RECT_U object.

#### Parameter `rect`

source rectangle

### `M:CD2DRectU.#ctor(CRect!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DRectU.#ctor(CRect!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DRectU object from CRect object.

#### Parameter `rect`

source rectangle

### `T:CD2DRectU`

Member kind: type
Symbol: `CD2DRectU`

#### Summary

D2D1_RECT_U wrapper

### `M:CD2DRectF.op_Implicit~CRect`

Member kind: method
Symbol: `CD2DRectF.op_Implicit~CRect`

#### Summary

Converts CD2DRectF to CRect object.

#### Returns

Current value of D2D rectangle.

### `M:CD2DRectF.IsNull`

Member kind: method
Symbol: `CD2DRectF.IsNull`

#### Summary

Returns a Boolean value that indicates whether an expression contains no valid data (Null).

#### Returns

TRUE if rectangle's top, left, bottom, and right values are all equal to 0; otherwise FALSE.

### `M:CD2DRectF.#ctor(System.Single,System.Single,System.Single,System.Single)`

Member kind: method
Symbol: `CD2DRectF.#ctor(System.Single,System.Single,System.Single,System.Single)`

#### Summary

Constructs a CD2DRectF object from four FLOAT values.

#### Parameter `fLeft`

source left coordinate

#### Parameter `fTop`

source top coordinate

#### Parameter `fRight`

source right coordinate

#### Parameter `fBottom`

source bottom coordinate

### `M:CD2DRectF.#ctor(D2D_RECT_F!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `CD2DRectF.#ctor(D2D_RECT_F!System.Runtime.CompilerServices.IsConst*)`

#### Summary

Constructs a CD2DRectF object from D2D1_RECT_F object.

#### Parameter `rect`

source rectangle

### `M:CD2DRectF.#ctor(D2D_RECT_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DRectF.#ctor(D2D_RECT_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DRectF object from D2D1_RECT_F object.

#### Parameter `rect`

source rectangle

### `M:CD2DRectF.#ctor(CRect!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DRectF.#ctor(CRect!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DRectF object from CRect object.

#### Parameter `rect`

source rectangle

### `T:CD2DRectF`

Member kind: type
Symbol: `CD2DRectF`

#### Summary

D2D1_RECT_F wrapper

### `M:CD2DSizeU.op_Implicit~CSize`

Member kind: method
Symbol: `CD2DSizeU.op_Implicit~CSize`

#### Summary

Converts CD2DSizeU to CSize object.

#### Returns

Current value of D2D size.

### `M:CD2DSizeU.IsNull`

Member kind: method
Symbol: `CD2DSizeU.IsNull`

#### Summary

Returns a Boolean value that indicates whether an expression contains no valid data (Null).

#### Returns

TRUE if width and height are empty; otherwise FALSE.

### `M:CD2DSizeU.#ctor(System.UInt32,System.UInt32)`

Member kind: method
Symbol: `CD2DSizeU.#ctor(System.UInt32,System.UInt32)`

#### Summary

Constructs a CD2DSizeU object from two UINT32 values.

#### Parameter `cx`

source width

#### Parameter `cy`

source height

### `M:CD2DSizeU.#ctor(D2D_SIZE_U!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `CD2DSizeU.#ctor(D2D_SIZE_U!System.Runtime.CompilerServices.IsConst*)`

#### Summary

Constructs a CD2DSizeU object from D2D1_SIZE_U object.

#### Parameter `size`

source size

### `M:CD2DSizeU.#ctor(D2D_SIZE_U!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DSizeU.#ctor(D2D_SIZE_U!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DSizeU object from D2D1_SIZE_U object.

#### Parameter `size`

source size

### `M:CD2DSizeU.#ctor(CSize!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DSizeU.#ctor(CSize!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DSizeU object from CSize object.

#### Parameter `size`

source size

### `T:CD2DSizeU`

Member kind: type
Symbol: `CD2DSizeU`

#### Summary

D2D1_SIZE_U wrapper

### `M:CD2DSizeF.op_Implicit~CSize`

Member kind: method
Symbol: `CD2DSizeF.op_Implicit~CSize`

#### Summary

Converts CD2DSizeF to CSize object.

#### Returns

Current value of D2D size.

### `M:CD2DSizeF.IsNull`

Member kind: method
Symbol: `CD2DSizeF.IsNull`

#### Summary

Returns a Boolean value that indicates whether an expression contains no valid data (Null).

#### Returns

TRUE if width and height are empty; otherwise FALSE.

### `M:CD2DSizeF.#ctor(System.Single,System.Single)`

Member kind: method
Symbol: `CD2DSizeF.#ctor(System.Single,System.Single)`

#### Summary

Constructs a CD2DSizeF object from two FLOAT values.

#### Parameter `cx`

source width

#### Parameter `cy`

source height

### `M:CD2DSizeF.#ctor(D2D_SIZE_F!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `CD2DSizeF.#ctor(D2D_SIZE_F!System.Runtime.CompilerServices.IsConst*)`

#### Summary

Constructs a CD2DSizeF object from D2D1_SIZE_F object.

#### Parameter `size`

source size

### `M:CD2DSizeF.#ctor(D2D_SIZE_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DSizeF.#ctor(D2D_SIZE_F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DSizeF object from D2D1_SIZE_F object.

#### Parameter `size`

source size

### `M:CD2DSizeF.#ctor(CSize!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DSizeF.#ctor(CSize!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DSizeF object from CSize object.

#### Parameter `size`

source size

### `T:CD2DSizeF`

Member kind: type
Symbol: `CD2DSizeF`

#### Summary

D2D1_SIZE_F wrapper

### `M:CD2DPointU.op_Implicit~CPoint`

Member kind: method
Symbol: `CD2DPointU.op_Implicit~CPoint`

#### Summary

Converts CD2DPointU to CPoint object.

#### Returns

Current value of D2D point.

### `M:CD2DPointU.#ctor(System.UInt32,System.UInt32)`

Member kind: method
Symbol: `CD2DPointU.#ctor(System.UInt32,System.UInt32)`

#### Summary

Constructs a CD2DPointU object from two UINT32 values.

#### Parameter `uX`

source X

#### Parameter `uY`

source Y

### `M:CD2DPointU.#ctor(D2D_POINT_2U!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `CD2DPointU.#ctor(D2D_POINT_2U!System.Runtime.CompilerServices.IsConst*)`

#### Summary

Constructs a CD2DPointU from object D2D1_POINT_2U object.

#### Parameter `pt`

source point

### `M:CD2DPointU.#ctor(D2D_POINT_2U!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DPointU.#ctor(D2D_POINT_2U!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DPointU from object D2D1_POINT_2U object.

#### Parameter `pt`

source point

### `M:CD2DPointU.#ctor(CPoint!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DPointU.#ctor(CPoint!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DPointU object from CPoint object.

#### Parameter `pt`

source point

### `T:CD2DPointU`

Member kind: type
Symbol: `CD2DPointU`

#### Summary

D2D1_POINT_2U wrapper

### `M:CD2DPointF.op_Implicit~CPoint`

Member kind: method
Symbol: `CD2DPointF.op_Implicit~CPoint`

#### Summary

Converts CD2DPointF to CPoint object.

#### Returns

Current value of D2D point.

### `M:CD2DPointF.#ctor(System.Single,System.Single)`

Member kind: method
Symbol: `CD2DPointF.#ctor(System.Single,System.Single)`

#### Summary

Constructs a CD2DPointF object from two FLOAT values.

#### Parameter `fX`

source X

#### Parameter `fY`

source Y

### `M:CD2DPointF.#ctor(D2D_POINT_2F!System.Runtime.CompilerServices.IsConst*)`

Member kind: method
Symbol: `CD2DPointF.#ctor(D2D_POINT_2F!System.Runtime.CompilerServices.IsConst*)`

#### Summary

Constructs a CD2DPointF object from D2D1_POINT_2F object.

#### Parameter `pt`

source point

### `M:CD2DPointF.#ctor(D2D_POINT_2F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DPointF.#ctor(D2D_POINT_2F!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DPointF object from D2D1_POINT_2F object.

#### Parameter `pt`

source point

### `M:CD2DPointF.#ctor(CPoint!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

Member kind: method
Symbol: `CD2DPointF.#ctor(CPoint!System.Runtime.CompilerServices.IsConst*!System.Runtime.CompilerServices.IsImplicitlyDereferenced)`

#### Summary

Constructs a CD2DPointF object from CPoint object.

#### Parameter `pt`

source point

### `T:CD2DPointF`

Member kind: type
Symbol: `CD2DPointF`

#### Summary

D2D1_POINT_2F wrapper

### `M:CCustomTransition.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

Member kind: method
Symbol: `CCustomTransition.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

#### Summary

Calls the transition library to create encapsulated transition COM object.

#### Remarks

This method also can set initial value and initial velocity to be applied to an animation variable, which is
associated with this transition. For this purpose you have to call SetInitialValue and SetInitialVelocity before
the framework creates the encapsulated transition COM object (it happens when you call CAnimationController::AnimateGroup).

#### Parameter `pLibrary`

A pointer to transition library, which is responsible for creation of standard transitions.

#### Parameter `pFactory`

A pointer to transition factory, which is responsible for creation of custom transitions.

### `M:CCustomTransition.SetInitialVelocity(System.Double)`

Member kind: method
Symbol: `CCustomTransition.SetInitialVelocity(System.Double)`

#### Summary

Sets an initial velocity, which will be applied to an animation variable associated with this transition.

### `M:CCustomTransition.SetInitialValue(System.Double)`

Member kind: method
Symbol: `CCustomTransition.SetInitialValue(System.Double)`

#### Summary

Sets an initial value, which will be applied to an animation variable associated with this transition.

### `M:CCustomTransition.#ctor(CCustomInterpolator*)`

Member kind: method
Symbol: `CCustomTransition.#ctor(CCustomInterpolator*)`

#### Summary

Constructs a custom transition object.

#### Parameter `pInterpolator`

A pointer to custom interpolator.

### `F:CCustomTransition.m_initialVelocity`

Member kind: field
Symbol: `CCustomTransition.m_initialVelocity`

#### Summary

Stores the initial velocity.

### `F:CCustomTransition.m_initialValue`

Member kind: field
Symbol: `CCustomTransition.m_initialValue`

#### Summary

Stores the initial value.

### `F:CCustomTransition.m_bInitialVelocitySpecified`

Member kind: field
Symbol: `CCustomTransition.m_bInitialVelocitySpecified`

#### Summary

Specifies whether the initial velocity was specified with SetInitialVelocity.

### `F:CCustomTransition.m_bInitialValueSpecified`

Member kind: field
Symbol: `CCustomTransition.m_bInitialValueSpecified`

#### Summary

Specifies whether the initial value was specified with SetInitialValue.

### `F:CCustomTransition.m_pInterpolator`

Member kind: field
Symbol: `CCustomTransition.m_pInterpolator`

#### Summary

Stores a pointer to a custom interpolator.

### `T:CCustomTransition`

Member kind: type
Symbol: `CCustomTransition`

#### Summary

Implements custom transition.

#### Remarks

The CCustomTransitions class allows developers to implement custom transitions. It's created and used
as a standard transition, but its constructor accepts as parameter a pointer to a custom interpolator.
Perform the following steps to use custom transitions:
1. Derive a class from CCustomInterpolator and implement at least InterpolateValue method.
2. Ensure that the lifetime of custom interpolator object must be longer than duration of animation where it's used.
3. Instantiate (using operator new) a CCustomTransition object and pass a pointer to custom interpolator in the constructor.
4. Call CCustomTransition::SetInitialValue and CCustomTransition::SetInitialVelocity if these parameters are required for custom interpolation.
5. Pass the pointer to custom transition to AddTransition method of animation object, whose value should be animated with the custom algorithm.
6. When the value of animation object should change Windows Animation API will call InterpolateValue (and other relevant methods) in CCustomInterpolator.

### `M:CInterpolatorBase.GetDependencies(__MIDL___MIDL_itf_UIAnimation_0000_0010_0001*,__MIDL___MIDL_itf_UIAnimation_0000_0010_0001*,__MIDL___MIDL_itf_UIAnimation_0000_0010_0001*)`

Member kind: method
Symbol: `CInterpolatorBase.GetDependencies(__MIDL___MIDL_itf_UIAnimation_0000_0010_0001*,__MIDL___MIDL_itf_UIAnimation_0000_0010_0001*,__MIDL___MIDL_itf_UIAnimation_0000_0010_0001*)`

#### Summary

Gets the interpolator's dependencies.

#### Returns

If the method succeeds, it returns S_OK. It returns E_FAIL if CCustomInterpolator is not
set, or custom implementation returns FALSE from the GetDependencies method.

#### Parameter `initialValueDependencies`

Output. Aspects of the interpolator that depend on the initial value passed to SetInitialValueAndVelocity.

#### Parameter `initialVelocityDependencies`

Output. Aspects of the interpolator that depend on the initial velocity passed to SetInitialValueAndVelocity.

#### Parameter `durationDependencies`

Output. Aspects of the interpolator that depend on the duration passed to SetDuration.

### `M:CInterpolatorBase.InterpolateVelocity(System.Double,System.Double*)`

Member kind: method
Symbol: `CInterpolatorBase.InterpolateVelocity(System.Double,System.Double*)`

#### Summary

Interpolates the velocity at a given offset

#### Returns

If the method succeeds, it returns S_OK. It returns E_FAIL if CCustomInterpolator is not
set, or custom implementation returns FALSE from the InterpolateVelocity method.

#### Parameter `offset`

The offset from the start of the transition.
The offset is always greater than or equal to zero and less than or equal to the duration of the transition.
This method is not called if the duration of the transition is zero.

#### Parameter `velocity`

Output. The velocity of the variable at the offset.

### `M:CInterpolatorBase.InterpolateValue(System.Double,System.Double*)`

Member kind: method
Symbol: `CInterpolatorBase.InterpolateValue(System.Double,System.Double*)`

#### Summary

Interpolates the value at a given offset

#### Returns

If the method succeeds, it returns S_OK. It returns E_FAIL if CCustomInterpolator is not
set, or custom implementation returns FALSE from the InterpolateValue method.

#### Parameter `offset`

The offset from the start of the transition.
The offset is always greater than or equal to zero and less than the duration of the transition.
This method is not called if the duration of the transition is zero.

#### Parameter `value`

Output. The interpolated value.

### `M:CInterpolatorBase.GetFinalValue(System.Double*)`

Member kind: method
Symbol: `CInterpolatorBase.GetFinalValue(System.Double*)`

#### Summary

Gets the final value to which the interpolator leads.

#### Returns

If the method succeeds, it returns S_OK. It returns E_FAIL if CCustomInterpolator is not
set, or custom implementation returns FALSE from the GetFinalValue method.

#### Parameter `value`

Output. The final value of a variable at the end of the transition.

### `M:CInterpolatorBase.GetDuration(System.Double*)`

Member kind: method
Symbol: `CInterpolatorBase.GetDuration(System.Double*)`

#### Summary

Gets the interpolator's duration.

#### Returns

If the method succeeds, it returns S_OK. It returns E_FAIL if CCustomInterpolator is not
set, or custom implementation returns FALSE from the GetDuration method.

#### Parameter `duration`

Output. The duration of the transition, in seconds.

### `M:CInterpolatorBase.SetDuration(System.Double)`

Member kind: method
Symbol: `CInterpolatorBase.SetDuration(System.Double)`

#### Summary

Sets the interpolator's duration

#### Returns

If the method succeeds, it returns S_OK. It returns E_FAIL if CCustomInterpolator is not
set, or custom implementation returns FALSE from the SetDuration method.

#### Parameter `duration`

The duration of the transition.

### `M:CInterpolatorBase.SetInitialValueAndVelocity(System.Double,System.Double)`

Member kind: method
Symbol: `CInterpolatorBase.SetInitialValueAndVelocity(System.Double,System.Double)`

#### Summary

Sets the interpolator's initial value and velocity.

#### Returns

If the method succeeds, it returns S_OK. It returns E_FAIL if CCustomInterpolator is not
set, or custom implementation returns FALSE from the SetInitialValueAndVelocity method.

#### Parameter `initialValue`

The value of the variable at the start of the transition.

#### Parameter `initialVelocity`

The velocity of the variable at the start of the transition.

### `M:CInterpolatorBase.CreateInstance(CCustomInterpolator*,IUIAnimationInterpolator**)`

Member kind: method
Symbol: `CInterpolatorBase.CreateInstance(CCustomInterpolator*,IUIAnimationInterpolator**)`

#### Summary

Creates an instance of CInterpolatorBase and stores a pointer to custom interpolator, which will be handling events.

#### Parameter `pInterpolator`

A pointer to custom interpolator.

#### Parameter `ppHandler`

Output. Contains a pointer to instance of CInterpolatorBase when the function returns.

### `M:CInterpolatorBase.SetCustomInterpolator(CCustomInterpolator*)`

Member kind: method
Symbol: `CInterpolatorBase.SetCustomInterpolator(CCustomInterpolator*)`

#### Summary

Stores a pointer to custom interpolator, which will be handling events.

#### Parameter `pInterpolator`

A pointer to custom interpolator.

### `M:CInterpolatorBase.#ctor`

Member kind: method
Symbol: `CInterpolatorBase.#ctor`

#### Summary

Constructs the CInterpolatorBase object.

### `T:CInterpolatorBase`

Member kind: type
Symbol: `CInterpolatorBase`

#### Summary

Implements a callback, which is called by Animation API when it needs to calculate a new value of animation variable.

#### Remarks

This handler is created and passed to IUIAnimationTransitionFactory::CreateTransition when a CCustomTransition
object is being created as a part of animation initialization process (started by CAnimationController::AnimateGroup).
Usually you don't need to use this class directly, it just routs all events to a CCustomInterpolator-derived class, whose
pointer is passed to constructor of CCustomTransition.

### `M:CCustomInterpolator.GetDependencies(__MIDL___MIDL_itf_UIAnimation_0000_0010_0001*,__MIDL___MIDL_itf_UIAnimation_0000_0010_0001*,__MIDL___MIDL_itf_UIAnimation_0000_0010_0001*)`

Member kind: method
Symbol: `CCustomInterpolator.GetDependencies(__MIDL___MIDL_itf_UIAnimation_0000_0010_0001*,__MIDL___MIDL_itf_UIAnimation_0000_0010_0001*,__MIDL___MIDL_itf_UIAnimation_0000_0010_0001*)`

#### Summary

Gets the interpolator's dependencies.

#### Returns

Basic implementation always returns TRUE. Return FALSE from overridden implementation if you wish to fail the event.

#### Parameter `initialValueDependencies`

Output. Aspects of the interpolator that depend on the initial value passed to SetInitialValueAndVelocity.

#### Parameter `initialVelocityDependencies`

Output. Aspects of the interpolator that depend on the initial velocity passed to SetInitialValueAndVelocity.

#### Parameter `durationDependencies`

Output. Aspects of the interpolator that depend on the duration passed to SetDuration.

### `M:CCustomInterpolator.InterpolateVelocity(System.Double,System.Double*)`

Member kind: method
Symbol: `CCustomInterpolator.InterpolateVelocity(System.Double,System.Double*)`

#### Summary

Interpolates the velocity at a given offset

#### Returns

Basic implementation always returns TRUE. Return FALSE from overridden implementation if you wish to fail the event.

#### Parameter `offset`

The offset from the start of the transition.
The offset is always greater than or equal to zero and less than or equal to the duration of the transition.
This method is not called if the duration of the transition is zero.

#### Parameter `velocity`

Output. The velocity of the variable at the offset.

### `M:CCustomInterpolator.InterpolateValue(System.Double,System.Double*)`

Member kind: method
Symbol: `CCustomInterpolator.InterpolateValue(System.Double,System.Double*)`

#### Summary

Interpolates the value at a given offset.

#### Returns

Basic implementation always returns TRUE. Return FALSE from overridden implementation if you wish to fail the event.

#### Parameter `offset`

The offset from the start of the transition.
The offset is always greater than or equal to zero and less than the duration of the transition.
This method is not called if the duration of the transition is zero.

#### Parameter `value`

Output. The interpolated value.

### `M:CCustomInterpolator.GetFinalValue(System.Double*)`

Member kind: method
Symbol: `CCustomInterpolator.GetFinalValue(System.Double*)`

#### Summary

Gets the final value to which the interpolator leads.

#### Returns

Basic implementation always returns TRUE. Return FALSE from overridden implementation if you wish to fail the event.

#### Parameter `value`

Output. The final value of a variable at the end of the transition.

### `M:CCustomInterpolator.GetDuration(System.Double*)`

Member kind: method
Symbol: `CCustomInterpolator.GetDuration(System.Double*)`

#### Summary

Gets the interpolator's duration.

#### Returns

Basic implementation always returns TRUE. Return FALSE from overridden implementation if you wish to fail the event.

#### Parameter `duration`

Output. The duration of the transition, in seconds.

### `M:CCustomInterpolator.SetDuration(System.Double)`

Member kind: method
Symbol: `CCustomInterpolator.SetDuration(System.Double)`

#### Summary

Sets the interpolator's duration.

#### Returns

Basic implementation always returns TRUE. Return FALSE from overridden implementation if you wish to fail the event.

#### Parameter `duration`

The duration of the transition.

### `M:CCustomInterpolator.SetInitialValueAndVelocity(System.Double,System.Double)`

Member kind: method
Symbol: `CCustomInterpolator.SetInitialValueAndVelocity(System.Double,System.Double)`

#### Summary

Sets the interpolator's initial value and velocity.

#### Returns

The basic implementation always returns TRUE. Return FALSE from overridden implementation if you wish to fail the event.

#### Parameter `initialValue`

The value of the variable at the start of the transition.

#### Parameter `initialVelocity`

The velocity of the variable at the start of the transition.

### `M:CCustomInterpolator.Init(System.Double,System.Double)`

Member kind: method
Symbol: `CCustomInterpolator.Init(System.Double,System.Double)`

#### Summary

Initializes duration and final value.

#### Parameter `duration`

The duration of the transition.

#### Parameter `finalValue`

The final value of a variable at the end of the transition.

### `M:CCustomInterpolator.#ctor(System.Double,System.Double)`

Member kind: method
Symbol: `CCustomInterpolator.#ctor(System.Double,System.Double)`

#### Summary

Constructs a custom interpolator object and initializes duration and velocity to specified values.

#### Parameter `duration`

The duration of the transition.

### `M:CCustomInterpolator.#ctor`

Member kind: method
Symbol: `CCustomInterpolator.#ctor`

#### Summary

Constructs a custom interpolator object and sets all values to default 0.

#### Remarks

Use CCustomInterpolator::Init to initialize duration and final value later in the code.

### `F:CCustomInterpolator.m_currentVelocity`

Member kind: field
Symbol: `CCustomInterpolator.m_currentVelocity`

#### Summary

The interpolated velocity.

### `F:CCustomInterpolator.m_currentValue`

Member kind: field
Symbol: `CCustomInterpolator.m_currentValue`

#### Summary

The interpolated value.

### `F:CCustomInterpolator.m_initialVelocity`

Member kind: field
Symbol: `CCustomInterpolator.m_initialVelocity`

#### Summary

The velocity of the variable at the start of the transition.

### `F:CCustomInterpolator.m_initialValue`

Member kind: field
Symbol: `CCustomInterpolator.m_initialValue`

#### Summary

The value of the variable at the start of the transition.

### `F:CCustomInterpolator.m_finalValue`

Member kind: field
Symbol: `CCustomInterpolator.m_finalValue`

#### Summary

The final value of a variable at the end of the transition.

### `F:CCustomInterpolator.m_duration`

Member kind: field
Symbol: `CCustomInterpolator.m_duration`

#### Summary

The duration of the transition.

### `T:CCustomInterpolator`

Member kind: type
Symbol: `CCustomInterpolator`

#### Summary

Implements a basic interpolator.

#### Remarks

Derive a class from CCustomInterpolator and override all necessary methods in order to implement a custom
interpolation algorithm. A pointer to this class should be passed as a parameter to CCustomTransition.

### `M:CSinusoidalTransitionFromVelocity.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

Member kind: method
Symbol: `CSinusoidalTransitionFromVelocity.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

#### Summary

Calls the transition library to create encapsulated transition COM object.

#### Returns

TRUE if transition is created successfully; otherwise FALSE.

#### Parameter `pLibrary`

A pointer to transition library, which is responsible for creation of standard transitions.

#### Parameter `pFactory`

A pointer to transition factory, which is responsible for creation of custom transitions.

### `F:CSinusoidalTransitionFromVelocity.m_period`

Member kind: field
Symbol: `CSinusoidalTransitionFromVelocity.m_period`

#### Summary

The period of oscillation of the sinusoidal wave in seconds.

### `F:CSinusoidalTransitionFromVelocity.m_duration`

Member kind: field
Symbol: `CSinusoidalTransitionFromVelocity.m_duration`

#### Summary

The duration of the transition.

### `M:CSinusoidalTransitionFromVelocity.#ctor(System.Double,System.Double)`

Member kind: method
Symbol: `CSinusoidalTransitionFromVelocity.#ctor(System.Double,System.Double)`

#### Summary

Constructs a transition object.

#### Parameter `duration`

The duration of the transition.

#### Parameter `period`

The period of oscillation of the sinusoidal wave in seconds.

### `T:CSinusoidalTransitionFromVelocity`

Member kind: type
Symbol: `CSinusoidalTransitionFromVelocity`

#### Summary

Encapsulates a sinusoidal-velocity transition, with an amplitude determined by the animation variable's initial velocity..

#### Remarks

The value of the animation variable oscillates around the initial value over the entire duration of a
sinusoidal-range transition. The amplitude of the oscillation is determined by the animation variable's velocity
when the transition begins.
Because all transitions are cleared automatically, it's recommended to allocated them using operator new.
The encapsulated IUIAnimationTransition COM object is created by CAnimationController::AnimateGroup, until then
it's NULL. Changing member variables after creation of this COM object has no effect.

### `M:CSinusoidalTransitionFromRange.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

Member kind: method
Symbol: `CSinusoidalTransitionFromRange.Create(IUIAnimationTransitionLibrary*,IUIAnimationTransitionFactory*)`

#### Summary

Calls the transition library to create encapsulated transition COM object.

#### Returns

TRUE if transition is created successfully; otherwise FALSE.

#### Parameter `pLibrary`

A pointer to transition library, which is responsible for creation of standard transitions.

#### Parameter `pFactory`

A pointer to transition factory, which is responsible for creation of custom transitions.

### `F:CSinusoidalTransitionFromRange.m_slope`

Member kind: field
Symbol: `CSinusoidalTransitionFromRange.m_slope`

#### Summary

The slope at the start of the transition.

### `F:CSinusoidalTransitionFromRange.m_period`

Member kind: field
Symbol: `CSinusoidalTransitionFromRange.m_period`

#### Summary

The period of oscillation of the sinusoidal wave in seconds.

### `F:CSinusoidalTransitionFromRange.m_dblMaximumValue`

Member kind: field
Symbol: `CSinusoidalTransitionFromRange.m_dblMaximumValue`

#### Summary

The value of the animation variable at a peak of the sinusoidal wave.

### `F:CSinusoidalTransitionFromRange.m_dblMinimumValue`

Member kind: field
Symbol: `CSinusoidalTransitionFromRange.m_dblMinimumValue`

#### Summary

The value of the animation variable at a trough of the sinusoidal wave.

### `F:CSinusoidalTransitionFromRange.m_duration`

Member kind: field
Symbol: `CSinusoidalTransitionFromRange.m_duration`

#### Summary

The duration of the transition.

### `M:CSinusoidalTransitionFromRange.#ctor(System.Double,System.Double,System.Double,System.Double,__MIDL___MIDL_itf_UIAnimation_0000_0009_0001)`

Member kind: method
Symbol: `CSinusoidalTransitionFromRange.#ctor(System.Double,System.Double,System.Double,System.Double,__MIDL___MIDL_itf_UIAnimation_0000_0009_0001)`

#### Summary

Constructs a transition object.

#### Parameter `duration`

The duration of the transition.

#### Parameter `dblMinimumValue`

The value of the animation variable at a trough of the sinusoidal wave.

#### Parameter `dblMaximumValue`

The value of the animation variable at a peak of the sinusoidal wave.

#### Parameter `period`

The period of oscillation of the sinusoidal wave in seconds.

#### Parameter `slope`

The slope at the start of the transition.

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

### `P:Autodesk.Revit.Attributes.JournalingAttribute.Mode`

Member kind: property
Symbol: `Autodesk.Revit.Attributes.JournalingAttribute.Mode`

#### Summary

Journaling mode.

#### Since

2011

### `M:Autodesk.Revit.Attributes.JournalingAttribute.#ctor(Autodesk.Revit.Attributes.JournalingMode)`

Member kind: method
Symbol: `Autodesk.Revit.Attributes.JournalingAttribute.#ctor(Autodesk.Revit.Attributes.JournalingMode)`

#### Summary

Constructs a new JournalingAttribute.

#### Since

2011

### `T:Autodesk.Revit.Attributes.JournalingAttribute`

Member kind: type
Symbol: `Autodesk.Revit.Attributes.JournalingAttribute`

#### Summary

The custom journaling attribute to control the journaling behavior of the external command.

#### Since

2011

### `T:Autodesk.Revit.Attributes.JournalingMode`

Member kind: type
Symbol: `Autodesk.Revit.Attributes.JournalingMode`

#### Summary

All journaling modes supported by Revit external commands.

#### Since

2011

### `F:Autodesk.Revit.Attributes.JournalingMode.NoCommandData`

Member kind: field
Symbol: `Autodesk.Revit.Attributes.JournalingMode.NoCommandData`

#### Summary

Does not write contents of the ExternalCommandData.Data map to the Revit journal.
But does allow Revit API calls to write to the journal as needed. This option should allow commands
which invoke the Revit UI for selection or for responses to task dialogs to replay correctly.

### `F:Autodesk.Revit.Attributes.JournalingMode.UsingCommandData`

Member kind: field
Symbol: `Autodesk.Revit.Attributes.JournalingMode.UsingCommandData`

#### Summary

Uses the "StringStringMap" supplied in the command data. Hides all Revit journal entries
in between the external command invocation and the StringStringMap entry. Commands which invoke the
Revit UI for selection or for responses to task dialogs may not replay correctly.

### `P:Autodesk.Revit.DB.ScheduleFieldId.InvalidScheduleFieldId`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleFieldId.InvalidScheduleFieldId`

#### Summary

Get the invalid ScheduleFieldId whose IntegerValue is -1.

### `M:Autodesk.Revit.DB.ScheduleFieldId.op_Inequality(Autodesk.Revit.DB.ScheduleFieldId,Autodesk.Revit.DB.ScheduleFieldId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleFieldId.op_Inequality(Autodesk.Revit.DB.ScheduleFieldId,Autodesk.Revit.DB.ScheduleFieldId)`

#### Summary

Determines whether two ScheduleFieldId are different.

#### Parameter `first`

The first ScheduleFieldId.

#### Parameter `second`

The second ScheduleFieldId.

#### Returns

True if the ScheduleFieldId are different, otherwise false.

### `M:Autodesk.Revit.DB.ScheduleFieldId.op_Equality(Autodesk.Revit.DB.ScheduleFieldId,Autodesk.Revit.DB.ScheduleFieldId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleFieldId.op_Equality(Autodesk.Revit.DB.ScheduleFieldId,Autodesk.Revit.DB.ScheduleFieldId)`

#### Summary

Determines whether two ScheduleFieldIds are the same.

#### Parameter `first`

The first ScheduleFieldId.

#### Parameter `second`

The second ScheduleFieldId.

#### Returns

True if the ScheduleFieldIds are the same, otherwise false.

### `M:Autodesk.Revit.DB.ScheduleFieldId.ToString`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleFieldId.ToString`

#### Summary

Gets a String representation of the integer value of the id.

### `M:Autodesk.Revit.DB.ScheduleFieldId.GetHashCode`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleFieldId.GetHashCode`

#### Summary

Gets the integer value of the id as hash code

### `M:Autodesk.Revit.DB.ScheduleFieldId.Equals(System.Object)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleFieldId.Equals(System.Object)`

#### Summary

Determines whether the specified `T:System.Object` is equal to the current `T:System.Object` .

#### Parameter `obj`

The other object to evaluate.

### `P:Autodesk.Revit.DB.ScheduleFieldId.IntegerValue`

Member kind: property
Symbol: `Autodesk.Revit.DB.ScheduleFieldId.IntegerValue`

#### Summary

Provides the value of the ScheduleFieldId as an integer.

#### Since

2013

### `M:Autodesk.Revit.DB.ScheduleFieldId.#ctor(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.ScheduleFieldId.#ctor(System.Int32)`

#### Since

2013

### `T:Autodesk.Revit.DB.ScheduleFieldId`

Member kind: type
Symbol: `Autodesk.Revit.DB.ScheduleFieldId`

#### Summary

The ScheduleFieldId object is used as a unique identification for a field in a schedule.

### `M:Autodesk.Revit.DB.WorksharingDisplaySettings.SetGraphicOverrides(Autodesk.Revit.DB.WorksetId,Autodesk.Revit.DB.WorksharingDisplayGraphicSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksharingDisplaySettings.SetGraphicOverrides(Autodesk.Revit.DB.WorksetId,Autodesk.Revit.DB.WorksharingDisplayGraphicSettings)`

#### Summary

Sets the graphic overrides assigned to elements in a particular user workset.

#### Parameter `worksetId`

The workset of interest, which must be a user workset.

#### Parameter `overrides`

The desired graphic overrides for this workset.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

worksetId does not correspond to a user workset in the document
containing this WorksharingDisplaySettings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.WorksharingDisplaySettings.SetGraphicOverrides(Autodesk.Revit.DB.CheckoutStatus,Autodesk.Revit.DB.WorksharingDisplayGraphicSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksharingDisplaySettings.SetGraphicOverrides(Autodesk.Revit.DB.CheckoutStatus,Autodesk.Revit.DB.WorksharingDisplayGraphicSettings)`

#### Summary

Sets the graphic overrides assigned to elements with a particular ownership status.

#### Parameter `status`

The ownership status of interest.

#### Parameter `overrides`

The desired graphic overrides for this ownership status.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `M:Autodesk.Revit.DB.WorksharingDisplaySettings.SetGraphicOverrides(Autodesk.Revit.DB.ModelUpdatesStatus,Autodesk.Revit.DB.WorksharingDisplayGraphicSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksharingDisplaySettings.SetGraphicOverrides(Autodesk.Revit.DB.ModelUpdatesStatus,Autodesk.Revit.DB.WorksharingDisplayGraphicSettings)`

#### Summary

Sets the graphic overrides assigned to elements with a particular status in the central model.

#### Parameter `status`

The status in the central model.

#### Parameter `overrides`

The desired graphic overrides for this status.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `M:Autodesk.Revit.DB.WorksharingDisplaySettings.SetGraphicOverrides(System.String,Autodesk.Revit.DB.WorksharingDisplayGraphicSettings)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksharingDisplaySettings.SetGraphicOverrides(System.String,Autodesk.Revit.DB.WorksharingDisplayGraphicSettings)`

#### Summary

Sets the graphic overrides assigned to elements owned by a particular user.
The username cannot be on the list of removed usernames.

#### Remarks

Note that you can specify usernames which do not yet exist in the document's user table.

#### Parameter `username`

The username of the desired user.

#### Parameter `overrides`

The desired graphic overrides for this user.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The username is on the list of removed users.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.WorksharingDisplaySettings.GetGraphicOverrides(Autodesk.Revit.DB.WorksetId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksharingDisplaySettings.GetGraphicOverrides(Autodesk.Revit.DB.WorksetId)`

#### Summary

Returns the graphic overrides assigned to elements in a particular workset.

#### Parameter `worksetId`

The workset id of interest. This must be a user workset.

#### Returns

Returns the graphic overrides assigned to the workset.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

worksetId does not correspond to a user workset in the document
containing this WorksharingDisplaySettings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.WorksharingDisplaySettings.GetGraphicOverrides(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksharingDisplaySettings.GetGraphicOverrides(System.String)`

#### Summary

Returns the graphic overrides assigned for elements owned by a particular user.

#### Parameter `username`

The username of a particular user.

#### Returns

The graphic overrides assigned to this user.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

This WorksharingDisplaySettings does not contain graphic overrides for the specified value of username.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.WorksharingDisplaySettings.GetGraphicOverrides(Autodesk.Revit.DB.ModelUpdatesStatus)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksharingDisplaySettings.GetGraphicOverrides(Autodesk.Revit.DB.ModelUpdatesStatus)`

#### Summary

Returns the graphic overrides assigned to a particular model update status.

#### Parameter `statusInCentral`

The model update status of interest.

#### Returns

Returns the graphic overrides assigned to the model update status.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `M:Autodesk.Revit.DB.WorksharingDisplaySettings.GetGraphicOverrides(Autodesk.Revit.DB.CheckoutStatus)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksharingDisplaySettings.GetGraphicOverrides(Autodesk.Revit.DB.CheckoutStatus)`

#### Summary

Returns the graphic overrides associated with a particular ownership status.

#### Parameter `ownershipStatus`

The ownership status of interest.

#### Returns

Returns the graphic overrides assigned to a particular ownership status.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2012

### `M:Autodesk.Revit.DB.WorksharingDisplaySettings.GetAllUsersWithGraphicOverrides`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksharingDisplaySettings.GetAllUsersWithGraphicOverrides`

#### Summary

Returns all usernames that have graphic overrides. This list consists of
all users included in the user table + all users who have explicitly been
assigned overrides.

#### Returns

All usernames that have been assigned graphic overrides.

#### Since

2012

### `M:Autodesk.Revit.DB.WorksharingDisplaySettings.GetRemovedUsers`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksharingDisplaySettings.GetRemovedUsers`

#### Summary

Returns the set of users who have been explicitly removed from the settings.

#### Returns

Users who have been explicitly removed from the list.

#### Since

2012

### `M:Autodesk.Revit.DB.WorksharingDisplaySettings.RestoreUsers(System.Collections.Generic.ICollection{System.String})`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksharingDisplaySettings.RestoreUsers(System.Collections.Generic.ICollection{System.String})`

#### Summary

Adds users back to the list of displayed users and permits customization of the graphics.
Any usernames that are not currently removed will be ignored.
Returns the number of users who were actually restored.

#### Remarks

This is the opposite of removing users.
Note that the user will be shown with default graphic overrides - any customizations that
existed prior to removing the user will not be restored.

#### Parameter `usersToRestore`

The usernames of the users to restore. Any usernames that are not currently removed will
be ignored.

#### Returns

The number of usernames that were actually restored.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.WorksharingDisplaySettings.CanUserHaveOverrides(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksharingDisplaySettings.CanUserHaveOverrides(System.String)`

#### Summary

Checks whether a single username can have customized graphic overrides.

#### Remarks

Only users that have not been removed can have overrides.
Once it is removed, a username must be restored before its associated graphic overrides
can be customized.

#### Parameter `username`

The username to check.

#### Returns

False if the username is on the list of removed users, True otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.WorksharingDisplaySettings.RemoveUsers(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{System.String},System.Collections.Generic.ICollection{System.String}@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksharingDisplaySettings.RemoveUsers(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{System.String},System.Collections.Generic.ICollection{System.String}@)`

#### Summary

Removes users from the list of displayed users and permanently discards any customization of the graphics.
Note that a user cannot be removed if he or she owns any elements.

#### Remarks

Note that default graphic overrides will be applied to any elements owned by these
users if they take ownership of any elements or worksets while they are removed.
Note also that the list of removed users will be shared by all users of the central model and
will remove all customizations by all users.

#### Parameter `document`

The document containing this.

#### Parameter `usersToRemove`

The usernames of the users to remove.

#### Parameter `usersActuallyRemoved`

The users that were successfully removed. Note that you cannot remove
users who currently own any elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.WorksharingDisplaySettings.UserHasGraphicOverrides(System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksharingDisplaySettings.UserHasGraphicOverrides(System.String)`

#### Summary

Checks whether there are graphic overrides that would apply to elements
owned by the given user in the "Individual Owners" display mode.

#### Remarks

There will always be graphic overrides for all users included in the user
table. In addition, there may be other users who have been explicitly assigned overrides.

#### Parameter `username`

The username to check

#### Returns

True if there are graphic overrides assigned to the username, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.WorksharingDisplaySettings.GetOrCreateWorksharingDisplaySettings(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.WorksharingDisplaySettings.GetOrCreateWorksharingDisplaySettings(Autodesk.Revit.DB.Document)`

#### Summary

Returns the worksharing display settings for the document, creating
new settings for the current user if necessary.

#### Remarks

Note that these settings are available even in models that are not
workshared. This is to allow pre-configuring the display settings
before enabling worksets so that they can be stored in template files.

#### Parameter `doc`

The document of interest.

#### Returns

The worksharing display settings for the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

doc is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `T:Autodesk.Revit.DB.WorksharingDisplaySettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.WorksharingDisplaySettings`

#### Summary

WorksharingDisplaySettings controls how elements will appear when they are
displayed in any of the worksharing display modes.

#### Remarks

The colors stored in these
settings are a common setting and are shared by all users in the model. Whether
a given color is applied or not is specific to the current user and will not
be shared by other users.

#### Since

2012

### `P:Autodesk.Revit.DB.WorksharingDisplayGraphicSettings.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.WorksharingDisplayGraphicSettings.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.WorksharingDisplayGraphicSettings.FillColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.WorksharingDisplayGraphicSettings.FillColor`

#### Summary

The fill color that will be applied to elements when these settings are
applied. Note that this is automatically set by increasing the luma of
the specified line color by 65%.

#### Since

2012
