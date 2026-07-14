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
Shard: 17
Member count: 500

## Retrieval Hints

Revit API 2024.1.10.25 exact XML member documentation RevitAPI Autodesk.Revit.DB Autodesk.Revit.UI
class method property field event signature parameter returns remarks exceptions since.

## SDK Members

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralH`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralH`

#### Summary

Defines parameters for Rectangular Pipe structural section.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralW.TopWebFillet`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralW.TopWebFillet`

#### Summary

Top Web Fillet - fillet radius at the top of web.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralW.FlangeFillet`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralW.FlangeFillet`

#### Summary

Flange Fillet - fillet radius at the flange end.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralW.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralW.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams)`

#### Summary

Creates a new instance of Angle shape.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `flangeThickness`

Flange Thickness.

#### Parameter `webThickness`

Web Thickness.

#### Parameter `webFillet`

Web Fillet - fillet radius between web and flange.

#### Parameter `flangeFillet`

Flange Fillet - fillet radius at the flange end.

#### Parameter `topWebFillet`

Top Web Fillet - fillet radius at the top of web.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `analysisParams`

Common set of parameters for structural analysis.

#### Since

2018

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralW`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralW`

#### Summary

Defines parameters for Angle structural section.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralLA.LipLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralLA.LipLength`

#### Summary

Lip segment length.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralLA.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralLA.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams)`

#### Summary

Creates a new instance of Angle Cold Formed shape.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `wallNominalThickness`

Represents wall nominal thickness of rectangle.

#### Parameter `wallDesignThickness`

Represents wall design thickness of rectangle.

#### Parameter `innerFillet`

Inner Fillet - Corner fillet inner radius.

#### Parameter `lipLength`

Lip segment length.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `analysisParams`

Common set of parameters for structural analysis.

#### Since

2018

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralLA`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralLA`

#### Summary

Defines parameters for Angle Cold Formed structural section.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralT.GetWebThicknessInHeightCenter`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralT.GetWebThicknessInHeightCenter`

#### Summary

Returns thickness of web measured in the 0.5 * height,

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralT.GetFlangeThicknessInFlangeCenter`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralT.GetFlangeThicknessInFlangeCenter`

#### Summary

Returns thickness of flange measured in the 0.25 * (width - webThickess),
sometimes used for sections with width > 300 mm.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralT.GetFlangeThicknessInQuarterWidth`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralT.GetFlangeThicknessInQuarterWidth`

#### Summary

Returns thickness of flange measured in the 0.25 * width,
sometimes used for sections with width <= 300 mm.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralT.SlopedWebAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralT.SlopedWebAngle`

#### Summary

Sloped web angle. (rad)

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralT.WebToeOfFillet`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralT.WebToeOfFillet`

#### Summary

Detailing distance from outer face of flange to web toe of fillet, in. (mm)

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralT.TopWebFillet`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralT.TopWebFillet`

#### Summary

Top Web Fillet - fillet radius at the top of web.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralT.SlopedFlangeAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralT.SlopedFlangeAngle`

#### Summary

Sloped flange angle. (rad)

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralT.FlangeToeOfFillet`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralT.FlangeToeOfFillet`

#### Summary

Detailing distance from center of web to flange toe of fillet, in. (mm)

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralT.FlangeFillet`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralT.FlangeFillet`

#### Summary

Flange Fillet - fillet radius at the flange end.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralT.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralT.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams)`

#### Summary

Creates a new instance of Tees shape.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `flangeThickness`

Flange Thickness.

#### Parameter `flangeThicknessLocation`

Flange Thickness Location.

#### Parameter `flangeFillet`

Flange Fillet - fillet radius at the flange end.

#### Parameter `flangeToeOfFillet`

Detailing distance from center of web to flange toe of fillet, in. (mm)

#### Parameter `slopedFlangeAngle`

Sloped flange angle. (rad)

#### Parameter `webThickness`

Web Thickness.

#### Parameter `webThicknessLocation`

Web Thickness Location.

#### Parameter `webFillet`

Web Fillet - fillet radius between web and flange.

#### Parameter `topWebFillet`

Top Web Fillet - fillet radius at the top of web.

#### Parameter `webToeOfFillet`

Detailing distance from outer face of flange to web toe of fillet, in. (mm)

#### Parameter `slopedWebAngle`

Sloped web angle. (rad)

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `analysisParams`

Common set of parameters for structural analysis.

#### Since

2018

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralT`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralT`

#### Summary

Defines parameters for Tees shape.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralLZ.LipLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralLZ.LipLength`

#### Summary

Lip segment length.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralLZ.BottomFlangeLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralLZ.BottomFlangeLength`

#### Summary

Bottom Flange segment length.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralLZ.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralLZ.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams)`

#### Summary

Creates a new instance of Z Cold Formed shape.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `wallNominalThickness`

Represents wall nominal thickness of rectangle.

#### Parameter `wallDesignThickness`

Represents wall design thickness of rectangle.

#### Parameter `innerFillet`

Inner Fillet - Corner fillet inner radius.

#### Parameter `bottomFlangeLength`

Bottom Flange segment length.

#### Parameter `lipLength`

Lip segment length.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `analysisParams`

Common set of parameters for structural analysis.

#### Since

2018

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralLZ`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralLZ`

#### Summary

Defines parameters for Z Cold Formed shape.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralCEx.FoldLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralCEx.FoldLength`

#### Summary

Fold segment length.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralCEx.LipLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralCEx.LipLength`

#### Summary

Lip segment length.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralCEx.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralCEx.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams)`

#### Summary

Creates a new instance of general Channel Cold Formed shape.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `wallNominalThickness`

Represents wall nominal thickness of rectangle.

#### Parameter `wallDesignThickness`

Represents wall design thickness of rectangle.

#### Parameter `innerFillet`

Inner Fillet - Corner fillet inner radius.

#### Parameter `lipLength`

Lip segment length.

#### Parameter `foldLength`

Fold segment length.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `analysisParams`

Common set of parameters for structural analysis.

#### Since

2018

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralCEx`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralCEx`

#### Summary

Defines parameters for Channel With Fold Cold Formed shape.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralC.LipLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralC.LipLength`

#### Summary

Lip segment length.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralC.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralC.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams)`

#### Summary

Creates a new instance of general Channel Cold Formed shape.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `wallNominalThickness`

Represents wall nominal thickness of rectangle.

#### Parameter `wallDesignThickness`

Represents wall design thickness of rectangle.

#### Parameter `innerFillet`

Inner Fillet - Corner fillet inner radius.

#### Parameter `lipLength`

Lip segment length.

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `analysisParams`

Common set of parameters for structural analysis.

#### Since

2018

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralC`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralC`

#### Summary

Defines parameters for Channel Cold Formed shape.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralU.GetFlangeThicknessInFlangeCenter`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralU.GetFlangeThicknessInFlangeCenter`

#### Summary

Returns thickness of flange measured in the 0.5 * (width - webThickess),
sometimes used for sections with width > 300 mm.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralU.GetFlangeThicknessInWidthCenter`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralU.GetFlangeThicknessInWidthCenter`

#### Summary

Returns thickness of flange measured in the 0.5 * width,
sometimes used for sections with width <= 300 mm.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralU.WebToeOfFillet`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralU.WebToeOfFillet`

#### Summary

Detailing distance from outer face of flange to web toe of fillet, in. (mm)

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralU.SlopedFlangeAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralU.SlopedFlangeAngle`

#### Summary

Sloped flange angle. (rad)

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralU.FlangeToeOfFillet`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralU.FlangeToeOfFillet`

#### Summary

Detailing distance from center of web to flange toe of fillet, in. (mm)

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralU.FlangeFillet`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralU.FlangeFillet`

#### Summary

Flange Fillet - fillet radius at the flange end.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralU.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralU.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams)`

#### Summary

Creates a new instance of general Channel shape.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `flangeThickness`

Flange Thickness.

#### Parameter `flangeThicknessLocation`

Flange Thickness Location.

#### Parameter `flangeFillet`

Flange Fillet - fillet radius at the flange end.

#### Parameter `flangeToeOfFillet`

Detailing distance from center of web to flange toe of fillet, in. (mm)

#### Parameter `slopedFlangeAngle`

Sloped flange angle. (rad)

#### Parameter `webThickness`

Web Thickness.

#### Parameter `webFillet`

Web Fillet - fillet radius between web and flange.

#### Parameter `webToeOfFillet`

Detailing distance from outer face of flange to web toe of fillet, in. (mm)

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `analysisParams`

Common set of parameters for structural analysis.

#### Since

2018

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralU`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralU`

#### Summary

Defines parameters for general Channel shape.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralI.GetFlangeThicknessInFlangeCenter`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralI.GetFlangeThicknessInFlangeCenter`

#### Summary

Returns thickness of flange measured in the 0.25 * (width - webThickess),
sometimes used for sections with width > 300 mm.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralI.GetFlangeThicknessInQuarterWidth`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralI.GetFlangeThicknessInQuarterWidth`

#### Summary

Returns thickness of flange measured in the 0.25 * width,
sometimes used for sections with width <= 300 mm.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralI.SlopedFlangeAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralI.SlopedFlangeAngle`

#### Summary

Sloped flange angle. (rad)

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralI.WebToeOfFillet`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralI.WebToeOfFillet`

#### Summary

Detailing distance from outer face of flange to web toe of fillet, in. (mm)

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralI.FlangeToeOfFillet`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralI.FlangeToeOfFillet`

#### Summary

Detailing distance from center of web to flange toe of fillet, in. (mm)

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralI.FlangeFillet`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralI.FlangeFillet`

#### Summary

Flange Fillet - fillet radius at the flange end.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralI.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralI.#ctor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionAnalysisParams)`

#### Summary

Creates a new instance of Structural Section I Sloped Flange shape with the associated set of parameters,
used to attach to structural element.

#### Parameter `width`

Section width.

#### Parameter `height`

Section height, depth.

#### Parameter `flangeThickness`

Flange Thickness.

#### Parameter `flangeThicknessLocation`

Flange Thickness Location.

#### Parameter `flangeFillet`

Flange Fillet - fillet radius at the flange end.

#### Parameter `flangeToeOfFillet`

Detailing distance from center of web to flange toe of fillet, in. (mm).

#### Parameter `slopedFlangeAngle`

Sloped flange angle. (rad)

#### Parameter `webThickness`

Web Thickness.

#### Parameter `webFillet`

Web Fillet - fillet radius between web and flange.

#### Parameter `webToeOfFillet`

Detailing distance from outer face of flange to web toe of fillet, in. (mm)

#### Parameter `centroidHorizontal`

Distance from centroid to the left extremites along horizontal axis.

#### Parameter `centroidVertical`

Distance from centroid to the upper extremites along vertical axis.

#### Parameter `analysisParams`

Common set of parameters for structural analysis.

#### Since

2018

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralI`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionGeneralI`

#### Summary

Defines parameters for general Double T shape.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionColdFormed.InnerFillet`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionColdFormed.InnerFillet`

#### Summary

Inner Fillet - Corner fillet inner radius.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionColdFormed.WallDesignThickness`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionColdFormed.WallDesignThickness`

#### Summary

Represents wall design thickness of rectangle.

#### Remarks

Design thickness of pipe wall is value should be thinner value than measured real value (nominal).

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionColdFormed.WallNominalThickness`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionColdFormed.WallNominalThickness`

#### Summary

Represents wall nominal thickness of rectangle.

#### Remarks

Nominal is measured real value of profile, should be thicker than designed.

#### Since

2016

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionColdFormed`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionColdFormed`

#### Summary

Defines parameters for Hot Formed structural section.

#### Since

2016

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionHotRolled.WebFillet`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionHotRolled.WebFillet`

#### Summary

Web Fillet - fillet radius between web and flange.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionHotRolled.WebThicknessLocation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionHotRolled.WebThicknessLocation`

#### Summary

Web Thickness Location.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionHotRolled.WebThickness`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionHotRolled.WebThickness`

#### Summary

Web Thickness.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionHotRolled.FlangeThicknessLocation`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionHotRolled.FlangeThicknessLocation`

#### Summary

Flange Thickness Location.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionHotRolled.FlangeThickness`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionHotRolled.FlangeThickness`

#### Summary

Flange Thickness.

#### Since

2015

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionHotRolled`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionHotRolled`

#### Summary

Defines parameters for hot rolled structural sections.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRectangular.NameKey`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRectangular.NameKey`

#### Summary

Name Key

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRectangular.CentroidVertical`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRectangular.CentroidVertical`

#### Summary

Distance from centroid to the upper extremites along vertical axis.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRectangular.CentroidHorizontal`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRectangular.CentroidHorizontal`

#### Summary

Distance from centroid to the left extremites along horizontal axis.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRectangular.Height`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRectangular.Height`

#### Summary

Section height, depth.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRectangular.Width`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRectangular.Width`

#### Summary

Section width.

#### Since

2015

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRectangular`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRectangular`

#### Summary

Defines common set of parameters for structural section rectangular contour.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRound.NameKey`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRound.NameKey`

#### Summary

Name Key

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRound.CentroidVertical`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRound.CentroidVertical`

#### Summary

Distance from centroid to the upper extremites along vertical axis.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRound.CentroidHorizontal`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRound.CentroidHorizontal`

#### Summary

Distance from centroid to the left extremites along horizontal axis.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRound.Diameter`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRound.Diameter`

#### Summary

Pipe Diameter.

#### Since

2015

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRound`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionRound`

#### Summary

Defines common set of parameters for structural section round contour.

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.StructuralSectionsServiceData.GetCurrentElements`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSectionsServiceData.GetCurrentElements`

#### Summary

Returns the list of Ids of the current elements.

#### Returns

Ids of the current elements. Contains the family base element to which the section shape type parameter belongs.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSectionsServiceData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSectionsServiceData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.StructuralSectionsServiceData.Document`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSectionsServiceData.Document`

#### Summary

The current document.

#### Since

2015

### `T:Autodesk.Revit.DB.Structure.StructuralSectionsServiceData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSectionsServiceData`

#### Summary

The data needed by section type server to perform type definition.

#### Since

2015

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralElementDefinitionData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralElementDefinitionData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralElementDefinitionData.IsMirrored`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralElementDefinitionData.IsMirrored`

#### Summary

States if the structural section of the element is mirrored.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralElementDefinitionData.Section`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralElementDefinitionData.Section`

#### Summary

Structural section of the element.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralElementDefinitionData.Normal`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralElementDefinitionData.Normal`

#### Summary

The local Z direction of the element section in the start point of the curve.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralElementDefinitionData.EndShortening`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralElementDefinitionData.EndShortening`

#### Summary

Cutback or extension at element curve end.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralElementDefinitionData.StartShortening`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralElementDefinitionData.StartShortening`

#### Summary

Cutback or extension at element curve start.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralElementDefinitionData.ZOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralElementDefinitionData.ZOffset`

#### Summary

Z offset.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralElementDefinitionData.YOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralElementDefinitionData.YOffset`

#### Summary

Y offset.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralElementDefinitionData.ZJust`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralElementDefinitionData.ZJust`

#### Summary

Z justification (ref axis).

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralElementDefinitionData.YJust`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralElementDefinitionData.YJust`

#### Summary

Y justification (ref axis).

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralElementDefinitionData.CenterCurve`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralElementDefinitionData.CenterCurve`

#### Summary

The curve lying in the geometrical center of the element.

#### Since

2018

### `P:Autodesk.Revit.DB.Structure.StructuralSections.StructuralElementDefinitionData.Curve`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralElementDefinitionData.Curve`

#### Summary

The definition curve of the element.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralElementDefinitionData.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralElementDefinitionData.#ctor`

#### Summary

Creates empty StructuralElementDefinitionData object.

#### Since

2018

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralElementDefinitionData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralElementDefinitionData`

#### Summary

Class containing information about section and position of the structural element.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionUtils.HasCertifiedStructuralSection(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionUtils.HasCertifiedStructuralSection(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Checks if element has defined structural section parameters inside its family.

#### Parameter `document`

The document that owns the family for beam, brace or structural column.

#### Parameter `elementId`

ID of family symbol or family instance for beam, brace or structural column.

#### Returns

Returns true if element has defined structural section parameters inside its family.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionUtils.GetStructuralElementDefinitionData(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Structure.StructuralSections.StructuralElementDefinitionData@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionUtils.GetStructuralElementDefinitionData(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Structure.StructuralSections.StructuralElementDefinitionData@)`

#### Summary

Return structural element definition data.

#### Remarks

This information is provided only for beams, braces and structural columns.

#### Parameter `document`

The document that owns the beam, brace or structural column.

#### Parameter `elementId`

ID of family instance for beam, brace or structural column.

#### Parameter `data`

Structural element definition data.

#### Returns

Success code is returned if StructuralElementDefinitionData was provided successfully, error code otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionUtils.SetStructuralSection(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionUtils.SetStructuralSection(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Structure.StructuralSections.StructuralSection)`

#### Summary

Set structural section in element.

#### Remarks

Only beams, braces and structural columns can have structural section associated with it.

#### Parameter `document`

The document that owns the family for beam, brace or structural column.

#### Parameter `familySymbolId`

ID of family symbol for beam, brace or structural column.

#### Parameter `structuralSection`

Structural section with values that will be set.

#### Returns

True is returned when requested shape with values was properly set. Return false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `M:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionUtils.GetStructuralSection(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionUtils.GetStructuralSection(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Return structural section from element.

#### Remarks

Only beams, braces and structural columns can have structural section associated with it.

#### Parameter `document`

The document that owns the family for beam, brace or structural column.

#### Parameter `elementId`

ID of family symbol or family instance for beam, brace or structural column.

#### Returns

Structural section returned if element have one.
For elements that do not have structural section or can not have structural section `null` will be returned.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2015

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionUtils`

#### Summary

This class provides utilities related to Structural Section Properties.

#### Since

2015

### `T:Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionErrorCode`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralSections.StructuralSectionErrorCode`

#### Summary

Error codes for StructuralSection related operations.

#### Since

2018

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionType.ValidFamilySymbolId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.StructuralConnectionApplyTo,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionType.ValidFamilySymbolId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.StructuralConnectionApplyTo,Autodesk.Revit.DB.ElementId)`

#### Summary

Checks whether the family symbol id is allowed for
StructuralConnectionTypes with the given value for the applyTo
property.

#### Returns

True if %familySymbolId% is invalidElementId; or if it is
the id of a FamilySymbol of category "Connection
Symbols" (OST_StructConnectionSymbols) with its "Apply
To" parameter set to match the applyTo property.
Returns false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionType.SetFamilySymbolId(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionType.SetFamilySymbolId(Autodesk.Revit.DB.ElementId)`

#### Summary

FamilySymbol of the annotation to use for this connection type.

#### Remarks

The FamilySymbol must be of category "Connection Symbols"
(OST_StructConnectionSymbols) and have its "Apply
To" parameter set to match the applyTo property.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when familySymbolId is the id of some element that is not a
FamilySymbol, is not of the category "Connection
Symbols" (OST_StructConnectionSymbols), or has its "Apply
To" parameter not equal to this type's applyTo property.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionType.GetFamilySymbolId`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionType.GetFamilySymbolId`

#### Summary

FamilySymbol of the annotation to use for this connection type.

#### Since

2011

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionType.GetAllStructuralConnectionTypeIds(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId}@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionType.GetAllStructuralConnectionTypeIds(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId}@)`

#### Summary

Collects the ids of all StructuralConnectionTypes in the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionType.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.StructuralConnectionApplyTo,System.String,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionType.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Structure.StructuralConnectionApplyTo,System.String,Autodesk.Revit.DB.ElementId)`

#### Summary

Create a new StructuralConnectionType, allowing the specified
annotation FamilySymbol to be applied to structural members.

#### Parameter `applyTo`

Specify which type of member this connection type can be applied to.

#### Parameter `name`

A name for the connection type. It must be unique within the document.

#### Parameter `familySymbolId`

The id of an annotation FamilySymbol. InvalidElementId is
allowed. Otherwise, the FamilySymbol must
be in the category "Connection Symbols"
(OST_StructConnectionSymbols) and have its "Apply
To" parameter set to match the applyTo argument.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

familySymbolId is the id of some element that is not a
FamilySymbol, is not of the category "Connection
Symbols" (OST_StructConnectionSymbols), or has its "Apply
To" parameter not equal to applyTo.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `P:Autodesk.Revit.DB.Structure.StructuralConnectionType.ApplyTo`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionType.ApplyTo`

#### Summary

Choose whether this connection type applies to beams and
braces, to tops of columns, or to bases of columns.

#### Remarks

The property cannot be changed. Create a new
StructuralConnectionType if a different value is needed.

#### Since

2011

### `T:Autodesk.Revit.DB.Structure.StructuralConnectionType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionType`

#### Summary

A type element that represents a connection symbol applied to structural members.

#### Since

2011

### `M:Autodesk.Revit.DB.StructuralConnectionTestUtil.SameFamilyAndFabricationShape(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Boolean@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.StructuralConnectionTestUtil.SameFamilyAndFabricationShape(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Boolean@)`

#### Summary

Compares family geometry and fabrication geometry of family instance
by cutting in the center with a plane and comparing edge curves.
Only cut boundary is analysed and compared.
Returns ERR_SUCCESS if comparison was successful or ERR_NOT_APPLICABLE if no fabrication shape.

#### Parameter `document`

The document.

#### Parameter `elemId`

The elementId of element.

#### Parameter `sameShape`

Indicates whether family and fabrication shape are the same.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

this operation failed.

#### Since

2018

### `M:Autodesk.Revit.DB.StructuralConnectionTestUtil.HasFabricationShape(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.StructuralConnectionTestUtil.HasFabricationShape(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Returns true if element has fabrication geometry for fine detail level

#### Parameter `document`

The document.

#### Parameter `elemId`

The elementId of element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `T:Autodesk.Revit.DB.StructuralConnectionTestUtil`

Member kind: type
Symbol: `Autodesk.Revit.DB.StructuralConnectionTestUtil`

#### Summary

This class provides test utilities for structural connection.

#### Since

2018

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionSettings.GetStructuralConnectionSettings(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionSettings.GetStructuralConnectionSettings(Autodesk.Revit.DB.Document)`

#### Summary

Obtains the StructuralConnectionSettings object for the specified project document.

#### Parameter `document`

A project document.

#### Returns

The StructuralConnectionSettings object.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a project document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.StructuralConnectionSettings.IncludeWarningControls`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionSettings.IncludeWarningControls`

#### Summary

This property controls how Structural Connection Element is generated.
If set to true and warnings are reported for given Element, additional yellow triangle is displayed.

#### Since

2017

### `T:Autodesk.Revit.DB.Structure.StructuralConnectionSettings`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionSettings`

#### Summary

Provides access to project-wide structural connections settings.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandler.GetFailed`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandler.GetFailed`

#### Summary

queries the connection status

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandler.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.ElementId,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandler.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.ElementId,System.String)`

#### Summary

Creates a new instance of a Structural Connection Handler, which defines the connection between given elements.

#### Remarks

Elements should be of the following structural categories: framings (OST_StructuralFraming), columns (OST_StructuralColumns), walls (OST_Walls), floors (OST_Floors) or foundations (OST_StructuralFoundations).
The first of given elements is set as primary one.
This constructor skips informing the addin about type change. SteelElement creation is done before the constructor call

#### Parameter `document`

The Revit document.

#### Parameter `idsToConnect`

List of element ids of connected elements.

#### Parameter `typeId`

The type of Structural Connection Handler.

#### Parameter `extEntId`

The id of the asociated ext entity

#### Returns

The newly created connection.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

It verifies that we have at least one element id in the list.
-or-
The type typeId is not a valid StructuralConnectionHandlerType.
-or-
Missing detailed structural connection service implementation.

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

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandler.GetInputPoint(System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandler.GetInputPoint(System.Guid)`

#### Summary

Returns point with specified id. Returns null if specified point does not exist

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandler.GetInputPoints`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandler.GetInputPoints`

#### Summary

Returns a list of additional points defining certain connections.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandler.GetInputReferences`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandler.GetInputReferences`

#### Summary

Gets references of input elements.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandler.SetDefaultElementOrder`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandler.SetDefaultElementOrder`

#### Summary

Sorts the connected elements connection according to structural categories, element materials and geometries.
The steel element is set rather than an element of other material.
The priorities of the elements are set according structural categories in following order: columns, framings, walls, foundations, floors.
In case of several Structural Framing elements order is determined by cutting - the cutting element is set as the primary one rather than element being cut.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandler.IsCustom`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandler.IsCustom`

#### Summary

Checks if Structural Connection Handler has the custom connection style.

#### Returns

True if Structural Connection Handler has the custom connection style.

#### Since

2019

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandler.IsDetailed`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandler.IsDetailed`

#### Summary

Checks if Structural Connection Handler has the detailed connection style.

#### Returns

True if Structural Connection Handler has the detailed connection style.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandler.GetOrigin`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandler.GetOrigin`

#### Summary

Retrieves origin point of Structural Connection Handler element.

#### Returns

The origin point of element.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandler.RemoveReferences(System.Collections.Generic.IList{Autodesk.Revit.DB.Reference})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandler.RemoveReferences(System.Collections.Generic.IList{Autodesk.Revit.DB.Reference})`

#### Summary

Removes references from the connection.
All references in an array should belong to the connection.

#### Parameter `picks`

The array containing picks to be removed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One or more picks was not permitted to be removed from the connection.
Picks should be members of the connection.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandler.RemoveElementIds(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandler.RemoveElementIds(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

#### Summary

Removes element ids from the connection.
All element ids in an array should belong to the connection.

#### Parameter `elemIds`

The ElementIdArr containing ids of elements to be removed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One or more element ids was not permitted to be removed from the connection.
Elements should be members of the connection.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandler.AddReferences(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.Reference})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandler.AddReferences(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.Reference})`

#### Summary

Adds references to the connection.
All references should be of applicable category.

#### Parameter `document`

The document.

#### Parameter `picks`

The array containing picks of input elements to be added.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One or more picks was not permitted to be add to the connection.
-or-
One or more picks was not permitted to be added to the connection.
Picks should not be duplicated.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandler.AddElementIds(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandler.AddElementIds(System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

#### Summary

Adds element ids to the connection.
All element ids in an array should be of applicable category.

#### Parameter `elemIds`

The ElementIdArr containing ids of elements to be added.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

One or more element ids was not permitted to be add to the connection.
Elements should be of applicable category.
-or-
One or more element ids was not permitted to be added to the connection.
Elements should not be duplicated.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandler.GetConnectedElementIds`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandler.GetConnectedElementIds`

#### Summary

Retrieves list of element ids of connected elements.

#### Returns

Returns connected element ids.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandler.CreateGenericConnection(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandler.CreateGenericConnection(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

#### Summary

Creates a new instance of a Structural Connection Handler with a generic type, which defines the connection between given elements.

#### Remarks

Elements should be of the following structural categories: framings (OST_StructuralFraming), columns (OST_StructuralColumns), walls (OST_Walls), floors (OST_Floors) or foundations (OST_StructuralFoundations).
The first of given elements is set as the primary one.
A generic connection type will be created by default, if there is none present in the model.

#### Parameter `document`

The Revit document.

#### Parameter `idsToConnect`

The list of element ids of connected elements.

#### Returns

The newly created generic connection.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

It verifies that we have at least one element id in the list.

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

2021

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandler.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.Structure.ConnectionInputPoint})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandler.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.Structure.ConnectionInputPoint})`

#### Summary

Creates a new instance of a Structural Connection Handler, which is defined by the elements to connect and the additional points.

#### Remarks

Elements should be of the following structural categories: framings (OST_StructuralFraming), columns (OST_StructuralColumns), walls (OST_Walls), floors (OST_Floors) or foundations (OST_StructuralFoundations).
The first of given elements is set as primary one.
The placement of the connection takes into account the additional definition points.

#### Parameter `document`

The Revit document.

#### Parameter `idsToConnect`

List of element ids of connected elements.

#### Parameter `typeId`

The type of Structural Connection Handler.

#### Parameter `additionalInputPoints`

The array of points that help define the connection.

#### Returns

The newly created connection.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

It verifies that we have at least one element id in the list.
-or-
The type typeId is not a valid StructuralConnectionHandlerType.
-or-
Missing detailed structural connection service implementation.

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

2021

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandler.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId},System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandler.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId},System.String)`

#### Summary

Creates custom StructuralConnectionHandlerType and StructuralConnectionHandler.

#### Remarks

Input Elements are deleted. All the input elements should be of the following structural categories:
FamilyInstance (structural beams and columns).

StructuralConnectionHandler elements associated to the connection.

Specific steel connection elements (bolts, anchors, plates, etc). These connection elements will be of type element but with categories related to structural connections, for example:
OST_StructConnectionWelds

OST_StructConnectionHoles

OST_StructConnectionModifiers

OST_StructConnectionShearStuds

OST_StructConnectionBolts

OST_StructConnectionAnchors

OST_StructConnectionPlates

#### Parameter `document`

The Document.

#### Parameter `elementIds`

Elements which are to be used to create custom StructuralConnectionHandlerType.

#### Parameter `typeName`

The StructuralConnectionHandlerType name.

#### Returns

The created StructuralConnectionHandler which is of just created custom StructuralConnectionHandlerType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

All the input Elements should be of the following structural categories: framings, columns, profiles, plates, bolts, anchors, shear studs, welds or structural connections.
-or-
There must be at least one StructuralConnectionHandler among the input Elements.
Total number of different input elements of input StructuralConnectionHandlers must be lower or equal to 3.
-or-
Name must be unique among other existing StructuralConnectionHandlerTypes and cannot contain invalid characters.

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

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandler.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandler.Create(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new instance of a Structural Connection Handler, which defines the connection between given elements.

#### Remarks

Elements should be of the following structural categories: framings (OST_StructuralFraming), columns (OST_StructuralColumns), walls (OST_Walls), floors (OST_Floors) or foundations (OST_StructuralFoundations).
The first of given elements is set as primary one.

#### Parameter `document`

The Revit document.

#### Parameter `idsToConnect`

List of element ids of connected elements.

#### Parameter `typeId`

The type of Structural Connection Handler.

#### Returns

The newly created connection.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

It verifies that we have at least one element id in the list.
-or-
The type typeId is not a valid StructuralConnectionHandlerType.
-or-
Missing detailed structural connection service implementation.

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

2017

### `P:Autodesk.Revit.DB.Structure.StructuralConnectionHandler.OverrideTypeParams`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandler.OverrideTypeParams`

#### Summary

Allow or disallow connection's type parameters to be overridden.

#### Remarks

When set to true, a set of instance parameters is created for this connection by copying the type parameter set and the user can change this instance parameters in order to make this connection different from the others of the same type.
Any further modification on type parameters will not affect this instance (until the "override" is turned back off).
When set to false the connection instance parameters are discarded and the type parameters are used again.
The default value of this parameter is false.

#### Since

2020

### `P:Autodesk.Revit.DB.Structure.StructuralConnectionHandler.ApprovalTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandler.ApprovalTypeId`

#### Summary

Retrieves or changes approval type of the Structural Connection Handler.

#### Value

Name of connection.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.StructuralConnectionHandler.CodeCheckingStatus`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandler.CodeCheckingStatus`

#### Summary

Code checking status of the structural connection.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.StructuralConnectionHandler.SingleElementEndIndex`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandler.SingleElementEndIndex`

#### Summary

Element end index for single element connections (0: start, 1: end).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: singleElementEndIndex is not a valid end index.

#### Since

2017

### `T:Autodesk.Revit.DB.Structure.StructuralConnectionHandler`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandler`

#### Summary

An object of Structural Connection Handler.

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.ConnectionInputPoint.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.ConnectionInputPoint.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.ConnectionInputPoint.Id`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.ConnectionInputPoint.Id`

#### Summary

Unique id of this input point.

#### Since

2021

### `P:Autodesk.Revit.DB.Structure.ConnectionInputPoint.Point`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.ConnectionInputPoint.Point`

#### Summary

3d position of this input point.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.DB.Structure.ConnectionInputPoint.#ctor(Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ConnectionInputPoint.#ctor(Autodesk.Revit.DB.XYZ)`

#### Summary

Construct an input point from 3d point. A new valid id will be auto-generated.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.DB.Structure.ConnectionInputPoint.#ctor(Autodesk.Revit.DB.XYZ,System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ConnectionInputPoint.#ctor(Autodesk.Revit.DB.XYZ,System.Guid)`

#### Summary

Construct an input point from 3d point and id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.DB.Structure.ConnectionInputPoint.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ConnectionInputPoint.#ctor`

#### Summary

Construct a default input point.

#### Since

2021

### `T:Autodesk.Revit.DB.Structure.ConnectionInputPoint`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.ConnectionInputPoint`

#### Summary

An object that holds information about a connection input point

#### Since

2021

### `T:Autodesk.Revit.DB.Structure.StructuralConnectionCodeCheckingStatus`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionCodeCheckingStatus`

#### Summary

An enumerated type listing all code checking status of the structural connection element.

#### Since

2017

#### Since

2017

### `F:Autodesk.Revit.DB.Structure.StructuralConnectionCodeCheckingStatus.CheckingFailed`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionCodeCheckingStatus.CheckingFailed`

#### Summary

Status checking failed.

### `F:Autodesk.Revit.DB.Structure.StructuralConnectionCodeCheckingStatus.OkChecked`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionCodeCheckingStatus.OkChecked`

#### Summary

Status OK checked.

### `F:Autodesk.Revit.DB.Structure.StructuralConnectionCodeCheckingStatus.NotCalculated`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionCodeCheckingStatus.NotCalculated`

#### Summary

Status not calculated.

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionApprovalType.IsValidApprovalTypeName(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionApprovalType.IsValidApprovalTypeName(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Verifies if the provided approval name is unique in the document.

#### Returns

True if approval type name is unique.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionApprovalType.GetAllStructuralConnectionApprovalTypes(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId}@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionApprovalType.GetAllStructuralConnectionApprovalTypes(Autodesk.Revit.DB.Document,System.Collections.Generic.ICollection{Autodesk.Revit.DB.ElementId}@)`

#### Summary

Collects the ids of all StructuralConnectionApprovalTypes in the document.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionApprovalType.Create(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionApprovalType.Create(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Creates a new StructuralConnectionApprovalType.

#### Parameter `name`

A name for the new approval type. It must be unique within the document.

#### Returns

Created connection approval type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

The input name for approval type is not unique in the document.

#### Since

2017

### `T:Autodesk.Revit.DB.Structure.StructuralConnectionApprovalType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionApprovalType`

#### Summary

A type element that represents a connection approval type.

#### Since

2017

### `T:Autodesk.Revit.DB.Structure.StructuralConnectionApplyTo`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionApplyTo`

#### Summary

An enumerated type that represents the type of structural locations to which a connection annotation may be applied.

#### Since

2011

### `F:Autodesk.Revit.DB.Structure.StructuralConnectionApplyTo.Connection`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionApplyTo.Connection`

#### Summary

Designate a StructuralConnectionType to apply to the Connection Handler.

### `F:Autodesk.Revit.DB.Structure.StructuralConnectionApplyTo.ColumnBase`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionApplyTo.ColumnBase`

#### Summary

Designate a StructuralConnectionType to apply to the base of a column.

### `F:Autodesk.Revit.DB.Structure.StructuralConnectionApplyTo.ColumnTop`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionApplyTo.ColumnTop`

#### Summary

Designate a StructuralConnectionType to apply to the top of a column.

### `F:Autodesk.Revit.DB.Structure.StructuralConnectionApplyTo.BeamsAndBraces`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionApplyTo.BeamsAndBraces`

#### Summary

Designate a StructuralConnectionType to apply to beams and braces.

### `M:Autodesk.Revit.DB.StructuralAsset.SetThermalExpansionCoefficient(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.StructuralAsset.SetThermalExpansionCoefficient(System.Double)`

#### Summary

Sets the thermal expansion coefficient of the asset.

#### Remarks

The thermal expansion coefficient is one-dimensional for wood-based and isotropic materials.
This method sets the x, y, and z components to the same value.
The value is in inverse Kelvin (1/K).

#### Since

2013

### `M:Autodesk.Revit.DB.StructuralAsset.SetShearModulus(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.StructuralAsset.SetShearModulus(System.Double)`

#### Summary

Sets the shear modulus of the asset.

#### Remarks

The shear modulus is one-dimensional for wood-based and isotropic materials.
This method sets the x, y, and z components to the same value.
The value is in Newtons per foot meter (N/(ft Â· m)).

#### Since

2013

### `M:Autodesk.Revit.DB.StructuralAsset.SetPoissonRatio(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.StructuralAsset.SetPoissonRatio(System.Double)`

#### Summary

Sets the Poisson ratio of the asset.

#### Remarks

The Poisson ratio is one-dimensional for wood-based and isotropic materials.
This method sets the x, y, and z components to the same value.

#### Since

2013

### `M:Autodesk.Revit.DB.StructuralAsset.SetYoungModulus(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.StructuralAsset.SetYoungModulus(System.Double)`

#### Summary

Sets the Young's modulus of the asset.

#### Remarks

The Young's modulus is one-dimensional for wood-based and isotropic materials.
This method sets the x, y, and z components to the same value.
The value is in Newtons per foot meter (N/(ft Â· m)).

#### Since

2013

### `M:Autodesk.Revit.DB.StructuralAsset.Equals(Autodesk.Revit.DB.StructuralAsset)`

Member kind: method
Symbol: `Autodesk.Revit.DB.StructuralAsset.Equals(Autodesk.Revit.DB.StructuralAsset)`

#### Summary

Determines whether this structural asset is equal to another.

#### Parameter `other`

The structural asset with which to compare this structural asset.

#### Returns

True if the given structural asset is equal to this one, otherwise false.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.StructuralAsset.Copy`

Member kind: method
Symbol: `Autodesk.Revit.DB.StructuralAsset.Copy`

#### Summary

Produces a copy of the asset.

#### Returns

A copy of the asset.

#### Since

2013

### `P:Autodesk.Revit.DB.StructuralAsset.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.StructuralAsset.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.StructuralAsset.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.StructuralAsset.Name`

#### Summary

The name of the structural asset.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.StructuralAsset.Density`

Member kind: property
Symbol: `Autodesk.Revit.DB.StructuralAsset.Density`

#### Summary

The density of the asset.

#### Remarks

Values are in kilograms per cubed feet (kg/ftÂ³) and must be non-negative.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for density must be non-negative.

#### Since

2013

### `P:Autodesk.Revit.DB.StructuralAsset.SubClass`

Member kind: property
Symbol: `Autodesk.Revit.DB.StructuralAsset.SubClass`

#### Summary

The sub-class of the asset.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.StructuralAsset.WoodGrade`

Member kind: property
Symbol: `Autodesk.Revit.DB.StructuralAsset.WoodGrade`

#### Summary

The grade of wood used in a wood-based asset.

#### Remarks

Applies to wood-based structural assets.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

When setting this property: the material type must be wood to set this property.

#### Since

2013

### `P:Autodesk.Revit.DB.StructuralAsset.WoodSpecies`

Member kind: property
Symbol: `Autodesk.Revit.DB.StructuralAsset.WoodSpecies`

#### Summary

The species of wood used in a wood-based asset.

#### Remarks

Applies to wood-based structural assets.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

When setting this property: the material type must be wood to set this property.

#### Since

2013

### `P:Autodesk.Revit.DB.StructuralAsset.WoodPerpendicularShearStrength`

Member kind: property
Symbol: `Autodesk.Revit.DB.StructuralAsset.WoodPerpendicularShearStrength`

#### Summary

The perpendicular shear strength of the asset.

#### Remarks

Applies to wood-based structural assets.
The value is in Newtons per foot meter (N/(ft Â· m)).

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

When setting this property: the material type must be wood to set this property.

#### Since

2013

### `P:Autodesk.Revit.DB.StructuralAsset.WoodParallelShearStrength`

Member kind: property
Symbol: `Autodesk.Revit.DB.StructuralAsset.WoodParallelShearStrength`

#### Summary

The parallel shear strength of the asset.

#### Remarks

Applies to wood-based structural assets.
The value is in Newtons per foot meter (N/(ft Â· m)).

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

When setting this property: the material type must be wood to set this property.

#### Since

2013

### `P:Autodesk.Revit.DB.StructuralAsset.WoodPerpendicularCompressionStrength`

Member kind: property
Symbol: `Autodesk.Revit.DB.StructuralAsset.WoodPerpendicularCompressionStrength`

#### Summary

The perpendicular compression strength of the asset.

#### Remarks

Applies to wood-based structural assets.
The value is in Newtons per foot meter (N/(ft Â· m)).

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

When setting this property: the material type must be wood to set this property.

#### Since

2013

### `P:Autodesk.Revit.DB.StructuralAsset.WoodParallelCompressionStrength`

Member kind: property
Symbol: `Autodesk.Revit.DB.StructuralAsset.WoodParallelCompressionStrength`

#### Summary

The parallel compression strength of the asset.

#### Remarks

Applies to wood-based structural assets.
The value is in Newtons per foot meter (N/(ft Â· m)).

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

When setting this property: the material type must be wood to set this property.

#### Since

2013

### `P:Autodesk.Revit.DB.StructuralAsset.WoodBendingStrength`

Member kind: property
Symbol: `Autodesk.Revit.DB.StructuralAsset.WoodBendingStrength`

#### Summary

The bending strength of the asset.

#### Remarks

Applies to wood-based structural assets.
The value is in Newtons per foot meter (N/(ft Â· m)).

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

When setting this property: the material type must be wood to set this property.

#### Since

2013

### `P:Autodesk.Revit.DB.StructuralAsset.MetalResistanceCalculationStrength`

Member kind: property
Symbol: `Autodesk.Revit.DB.StructuralAsset.MetalResistanceCalculationStrength`

#### Summary

The resistance calculation strength of the asset.

#### Remarks

Applies to metal-based structural assets.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

When setting this property: the material type must be Metal to set this property.

#### Since

2013

### `P:Autodesk.Revit.DB.StructuralAsset.MetalReductionFactor`

Member kind: property
Symbol: `Autodesk.Revit.DB.StructuralAsset.MetalReductionFactor`

#### Summary

The reduction factor of the asset.

#### Remarks

Applies to Metal-based structural assets.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

When setting this property: the material type must be Metal to set this property.

#### Since

2013

### `P:Autodesk.Revit.DB.StructuralAsset.MetalThermallyTreated`

Member kind: property
Symbol: `Autodesk.Revit.DB.StructuralAsset.MetalThermallyTreated`

#### Summary

Flag indicating whether the asset describes a material that is thermally treated or not.

#### Remarks

Applies to Metal-based structural assets.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

When setting this property: the material type must be Metal to set this property.

#### Since

2021

### `P:Autodesk.Revit.DB.StructuralAsset.MinimumTensileStrength`

Member kind: property
Symbol: `Autodesk.Revit.DB.StructuralAsset.MinimumTensileStrength`

#### Summary

The minimum tensile strength of the asset.

#### Remarks

Applies to Metal-based and generic structural assets.
The value is in Newtons per foot meter (N/(ft Â· m)).

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

When setting this property: the material type must be Metal or generic to set this property.

#### Since

2013

### `P:Autodesk.Revit.DB.StructuralAsset.MinimumYieldStress`

Member kind: property
Symbol: `Autodesk.Revit.DB.StructuralAsset.MinimumYieldStress`

#### Summary

The minimum yield stress of the asset.

#### Remarks

Applies to Metal-based and generic structural assets.
The value is in Newtons per foot meter (N/(ft Â· m)).

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

When setting this property: the material type must be Metal or generic to set this property.

#### Since

2013

### `P:Autodesk.Revit.DB.StructuralAsset.ConcreteShearStrengthReduction`

Member kind: property
Symbol: `Autodesk.Revit.DB.StructuralAsset.ConcreteShearStrengthReduction`

#### Summary

The shear strength reduction of the asset.

#### Remarks

Applies to concrete-based structural assets.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

When setting this property: the material type must be concrete to set this property.

#### Since

2013

### `P:Autodesk.Revit.DB.StructuralAsset.ConcreteShearReinforcement`

Member kind: property
Symbol: `Autodesk.Revit.DB.StructuralAsset.ConcreteShearReinforcement`

#### Summary

The shear reinforcement of the asset.

#### Remarks

Applies to concrete-based structural assets.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

When setting this property: the material type must be concrete to set this property.

#### Since

2013

### `P:Autodesk.Revit.DB.StructuralAsset.ConcreteBendingReinforcement`

Member kind: property
Symbol: `Autodesk.Revit.DB.StructuralAsset.ConcreteBendingReinforcement`

#### Summary

The bending reinforcement of the asset.

#### Remarks

Applies to concrete-based structural assets.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

When setting this property: the material type must be concrete to set this property.

#### Since

2013

### `P:Autodesk.Revit.DB.StructuralAsset.ConcreteCompression`

Member kind: property
Symbol: `Autodesk.Revit.DB.StructuralAsset.ConcreteCompression`

#### Summary

The compression strength of concrete-based assets.

#### Remarks

Applies to concrete-based structural assets.
The value is in Newtons per foot meter (N/(ft Â· m)).

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

When setting this property: the material type must be concrete to set this property.

#### Since

2013

### `P:Autodesk.Revit.DB.StructuralAsset.Behavior`

Member kind: property
Symbol: `Autodesk.Revit.DB.StructuralAsset.Behavior`

#### Summary

Flag indicating whether elements of this material behave isotropically or orthotropically.

#### Remarks

Applies to concrete, Metal, and generic structural assets.
If the behavior is set to Isotropic, then the y and z components of Young modulus,
Poisson modulus, shear modulus and thermal expansion coefficient will be changed to
the value the same as their x components.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `P:Autodesk.Revit.DB.StructuralAsset.Lightweight`

Member kind: property
Symbol: `Autodesk.Revit.DB.StructuralAsset.Lightweight`

#### Summary

Flag indicating whether the asset describes a material that is light-weight or not.

#### Since

2013

### `P:Autodesk.Revit.DB.StructuralAsset.ThermalExpansionCoefficient`

Member kind: property
Symbol: `Autodesk.Revit.DB.StructuralAsset.ThermalExpansionCoefficient`

#### Summary

The thermal expansion coefficient of the asset.

#### Remarks

This property cannot be used to set the thermal expansion coefficient for wood-based and isotropic materials.
For such assets, use setThermalExpansionCoefficient instead.
The value is in inverse Kelvin (1/K).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

When setting this property: the material type is wood.
-or-
When setting this property: the behavior is isotropic.

#### Since

2013

### `P:Autodesk.Revit.DB.StructuralAsset.ShearModulus`

Member kind: property
Symbol: `Autodesk.Revit.DB.StructuralAsset.ShearModulus`

#### Summary

The shear modulus of the asset.

#### Remarks

This property cannot be used to set the shear modulus for wood-based and isotropic materials.
For such assets, use setShearModulus instead.
The value is in Newtons per foot meter (N/(ft Â· m)).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

When setting this property: the material type is wood.
-or-
When setting this property: the behavior is isotropic.

#### Since

2013

### `P:Autodesk.Revit.DB.StructuralAsset.PoissonRatio`

Member kind: property
Symbol: `Autodesk.Revit.DB.StructuralAsset.PoissonRatio`

#### Summary

The Poisson ratio of the asset.

#### Remarks

This property cannot be used to set the Poisson ratio for wood-based and isotropic materials.
For such assets, use setPoissonRatio instead.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

When setting this property: the material type is wood.
-or-
When setting this property: the behavior is isotropic.

#### Since

2013

### `P:Autodesk.Revit.DB.StructuralAsset.YoungModulus`

Member kind: property
Symbol: `Autodesk.Revit.DB.StructuralAsset.YoungModulus`

#### Summary

The Young's modulus of the asset.

#### Remarks

This property cannot be used to set the Young's modulus for wood-based and isotropic materials.
For such assets, use setYoungModulus instead.
The value is in Newtons per foot meter (N/(ft Â· m)).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

When setting this property: the material type is wood.
-or-
When setting this property: the behavior is isotropic.

#### Since

2013

### `P:Autodesk.Revit.DB.StructuralAsset.StructuralAssetClass`

Member kind: property
Symbol: `Autodesk.Revit.DB.StructuralAsset.StructuralAssetClass`

#### Summary

The type of material that this structural asset describes (e.g. wood, concrete, metal.)

#### Since

2013

### `M:Autodesk.Revit.DB.StructuralAsset.#ctor(System.String,Autodesk.Revit.DB.StructuralAssetClass)`

Member kind: method
Symbol: `Autodesk.Revit.DB.StructuralAsset.#ctor(System.String,Autodesk.Revit.DB.StructuralAssetClass)`

#### Summary

Constructs an instance of StructuralAsset.

#### Parameter `name`

The name of the asset.

#### Parameter `structuralAssetClass`

The type of structural material that this asset will describe.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `T:Autodesk.Revit.DB.StructuralAsset`

Member kind: type
Symbol: `Autodesk.Revit.DB.StructuralAsset`

#### Summary

Represents the properties of a material pertinent to structural analysis.

#### Since

2013

### `T:Autodesk.Revit.DB.StructuralBehavior`

Member kind: type
Symbol: `Autodesk.Revit.DB.StructuralBehavior`

#### Summary

Specifies whether structural elements behave orthotropically, isotropically, or transverse-isotropically.

#### Since

2012

#### Since

2012

### `F:Autodesk.Revit.DB.StructuralBehavior.TransverseIsotropic`

Member kind: field
Symbol: `Autodesk.Revit.DB.StructuralBehavior.TransverseIsotropic`

#### Summary

The structural element behaves transverse-isotropically.

### `F:Autodesk.Revit.DB.StructuralBehavior.Orthotropic`

Member kind: field
Symbol: `Autodesk.Revit.DB.StructuralBehavior.Orthotropic`

#### Summary

The structural element behaves orthotropically.

### `F:Autodesk.Revit.DB.StructuralBehavior.Isotropic`

Member kind: field
Symbol: `Autodesk.Revit.DB.StructuralBehavior.Isotropic`

#### Summary

The structural element behaves isotropically.

### `T:Autodesk.Revit.DB.StructuralAssetClass`

Member kind: type
Symbol: `Autodesk.Revit.DB.StructuralAssetClass`

#### Since

2013

#### Summary

Represents the type of material described by a structural asset. This enum value is returned by Autodesk::Revit::DB::StructuralAsset::StructuralAssetClass.

#### Since

2013

### `F:Autodesk.Revit.DB.StructuralAssetClass.Plastic`

Member kind: field
Symbol: `Autodesk.Revit.DB.StructuralAssetClass.Plastic`

#### Summary

Structural asset class is plastic.

### `F:Autodesk.Revit.DB.StructuralAssetClass.Gas`

Member kind: field
Symbol: `Autodesk.Revit.DB.StructuralAssetClass.Gas`

#### Summary

Structural asset class is gas.

### `F:Autodesk.Revit.DB.StructuralAssetClass.Liquid`

Member kind: field
Symbol: `Autodesk.Revit.DB.StructuralAssetClass.Liquid`

#### Summary

Structural asset class is liquid.

### `F:Autodesk.Revit.DB.StructuralAssetClass.Wood`

Member kind: field
Symbol: `Autodesk.Revit.DB.StructuralAssetClass.Wood`

#### Summary

Structural asset class is wood.

### `F:Autodesk.Revit.DB.StructuralAssetClass.Concrete`

Member kind: field
Symbol: `Autodesk.Revit.DB.StructuralAssetClass.Concrete`

#### Summary

Structural asset class is concrete.

### `F:Autodesk.Revit.DB.StructuralAssetClass.Metal`

Member kind: field
Symbol: `Autodesk.Revit.DB.StructuralAssetClass.Metal`

#### Summary

Structural asset class is metal.

### `F:Autodesk.Revit.DB.StructuralAssetClass.Generic`

Member kind: field
Symbol: `Autodesk.Revit.DB.StructuralAssetClass.Generic`

#### Summary

Structural asset class is generic.

### `F:Autodesk.Revit.DB.StructuralAssetClass.Basic`

Member kind: field
Symbol: `Autodesk.Revit.DB.StructuralAssetClass.Basic`

#### Summary

Structural asset class is basic.

### `F:Autodesk.Revit.DB.StructuralAssetClass.Undefined`

Member kind: field
Symbol: `Autodesk.Revit.DB.StructuralAssetClass.Undefined`

#### Summary

Structural asset class is undefined.

### `M:Autodesk.Revit.DB.Structure.IStructuralConnectionsProviderProxy.GetConnectionTypeVisibility(Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.IStructuralConnectionsProviderProxy.GetConnectionTypeVisibility(Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData)`

#### Summary

The method that will be called to check visibility settings for the given connection type.

#### Remarks

The Connections Provider provides information about visibility settings for the given connection type.

#### Parameter `data`

The Structural Connections Type Info data.

#### Returns

Indicates whether the Structural Connections Provider is executed successfully.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.IStructuralConnectionsProviderProxy.GetTypeCodeCheckingStatus(Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.IStructuralConnectionsProviderProxy.GetTypeCodeCheckingStatus(Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData)`

#### Summary

The method that will be called to check if given connection type has code checking support

#### Remarks

The Connections Provider provides information about code checking support status for given connection type.

#### Parameter `data`

The Structural Connections Type Info data.

#### Returns

Indicates whether the Structural Connections Provider is executed successfully.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.IStructuralConnectionsProviderProxy.GetTypeInfo(Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.IStructuralConnectionsProviderProxy.GetTypeInfo(Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData)`

#### Summary

The method that will be called to get detailed information for given connection type.

#### Remarks

The Connections Provider provides detailed information about given connection type.

#### Parameter `data`

The Structural Connections Type Info data.

#### Returns

Indicates whether the Structural Connections Provider is executed successfully.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.IStructuralConnectionsProviderProxy.GetAvailableConnectionTypes(Autodesk.Revit.DB.Structure.StructuralConnectionsProviderData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.IStructuralConnectionsProviderProxy.GetAvailableConnectionTypes(Autodesk.Revit.DB.Structure.StructuralConnectionsProviderData)`

#### Summary

The method that will be called to get list of available connection types for given connection.

#### Remarks

The method allows to obtain a list of available connection types from the Connections Provider.
If the passed data contains id of valid Connection Handler the method provides a list of GUIDs of available connections
types which are applicable for this element. Otherwise it provides list of GUIDs of all available connection types.
Provided list of available types is returned via data parameter.

#### Parameter `data`

The Structural Connections Provider data.

#### Returns

Indicates whether the Structural Connections Provider is executed successfully.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.IStructuralConnectionsProvider.GetConnectionTypeVisibility(Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.IStructuralConnectionsProvider.GetConnectionTypeVisibility(Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData)`

#### Summary

The method that will be called to check visibility settings for the given connection type.

#### Remarks

The Connections Provider provides information about visibility settings for the given connection type.

#### Parameter `data`

The Structural Connections Type Info data.

#### Returns

Indicates whether the Structural Connections Provider is executed successfully.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.IStructuralConnectionsProvider.GetTypeCodeCheckingStatus(Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.IStructuralConnectionsProvider.GetTypeCodeCheckingStatus(Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData)`

#### Summary

The method that will be called to check if given connection type has code checking support

#### Remarks

The Connections Provider provides information about code checking support status for given connection type.

#### Parameter `data`

The Structural Connections Type Info data.

#### Returns

Indicates whether the Structural Connections Provider is executed successfully.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.IStructuralConnectionsProvider.GetTypeInfo(Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.IStructuralConnectionsProvider.GetTypeInfo(Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData)`

#### Summary

The method that will be called to get detailed information for given connection type.

#### Remarks

The Connections Provider provides detailed information about given connection type.

#### Parameter `data`

The Structural Connections Type Info data.

#### Returns

Indicates whether the Structural Connections Provider is executed successfully.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.IStructuralConnectionsProvider.GetAvailableConnectionTypes(Autodesk.Revit.DB.Structure.StructuralConnectionsProviderData)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.IStructuralConnectionsProvider.GetAvailableConnectionTypes(Autodesk.Revit.DB.Structure.StructuralConnectionsProviderData)`

#### Summary

The method that will be called to get list of available connection types for given connection.

#### Remarks

The method allows to obtain a list of available connection types from the Connections Provider.
If the passed data contains id of valid Connection Handler the method provides a list of GUIDs of available connections
types which are applicable for this element. Otherwise it provides list of GUIDs of all available connection types.
Provided list of available types is returned via data parameter.

#### Parameter `data`

The Structural Connections Provider data.

#### Returns

Indicates whether the Structural Connections Provider is executed successfully.

#### Since

2017

### `T:Autodesk.Revit.DB.Structure.IStructuralConnectionsProvider`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.IStructuralConnectionsProvider`

#### Summary

Interface for the Structural Connection Provider to implement.

#### Remarks

It's exposed in internal API.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionsProviderRegistry.UnregisterConnectionsProvider`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionsProviderRegistry.UnregisterConnectionsProvider`

#### Summary

Unregisters Connections Provider.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is no valid Connections Provider registered.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionsProviderRegistry.RegisterConnectionsProvider(Autodesk.Revit.DB.Structure.IStructuralConnectionsProvider)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionsProviderRegistry.RegisterConnectionsProvider(Autodesk.Revit.DB.Structure.IStructuralConnectionsProvider)`

#### Summary

Registers a connections provider.

#### Parameter `provider`

Structural Connections Provider to be registered.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The provider object is not valid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

There is already registered Connections Provider.

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.StructuralConnectionsProviderRegistry.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionsProviderRegistry.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Structure.StructuralConnectionsProviderRegistry`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionsProviderRegistry`

#### Summary

An object that stores Structural Connections Provider.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionsProviderData.AddConnectionTypeGuid(System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionsProviderData.AddConnectionTypeGuid(System.Guid)`

#### Summary

Adds GUID of the type available for the Connection.
It does not check whether the array already contains given guid,
it is up to the caller to make sure there are no duplicates in the array.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionsProviderData.GetConnectionTypeGuids`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionsProviderData.GetConnectionTypeGuids`

#### Summary

Returns the list of guids of available Connection types.

#### Returns

Strings representing guids of available connection types.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionsProviderData.AddConnectionMatchType(Autodesk.Revit.DB.Structure.StructuralConnectionMatchType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionsProviderData.AddConnectionMatchType(Autodesk.Revit.DB.Structure.StructuralConnectionMatchType)`

#### Summary

Adds the information about the type available for the Connection.
It does not check whether the array already contains given guid,
it is up to the caller to make sure there are no duplicates in the array.

#### Parameter `matchType`

The object containing information about the type available for the Connection.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionsProviderData.GetConnectionMatchTypes`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionsProviderData.GetConnectionMatchTypes`

#### Summary

Returns the list of items with information about types available for the Connection.

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.StructuralConnectionsProviderData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionsProviderData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.StructuralConnectionsProviderData.ConnectionId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionsProviderData.ConnectionId`

#### Summary

Id of Connection Handler element.

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.StructuralConnectionsProviderData.Document`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionsProviderData.Document`

#### Summary

The document.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionsProviderData.#ctor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionsProviderData.#ctor(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Constructs a new instance of StructuralConnectionsProviderData.

#### Parameter `document`

The document.

#### Parameter `connectionId`

The Id of Connection Handler element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionsProviderData.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionsProviderData.#ctor`

#### Summary

Constructs a new instance of StructuralConnectionsProviderData.

#### Since

2017

### `T:Autodesk.Revit.DB.Structure.StructuralConnectionsProviderData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionsProviderData`

#### Summary

The data needed by Structural Connections Provider server to return a list of available connection types.

#### Remarks

It's exposed in internal API.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionMatchType.GetSortOrders`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionMatchType.GetSortOrders`

#### Summary

Get arrays of indexes of connected elements describing their order required by the type.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionMatchType.AddSortOrder(System.Collections.Generic.IList{System.Int32})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionMatchType.AddSortOrder(System.Collections.Generic.IList{System.Int32})`

#### Summary

Add array of indexes of connected elements describing their order required by the type.
It may contain 1 to N items (where N is the number of connected elements).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.StructuralConnectionMatchType.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionMatchType.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.StructuralConnectionMatchType.GUID`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionMatchType.GUID`

#### Summary

GUID identifying the type.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionMatchType.#ctor(System.Guid,System.Collections.Generic.IList{System.Collections.Generic.IList{System.Int32}})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionMatchType.#ctor(System.Guid,System.Collections.Generic.IList{System.Collections.Generic.IList{System.Int32}})`

#### Summary

Constructs a StructuralConnectionMatchType.

#### Parameter `guid`

GUID identifying the type.

#### Parameter `sortOrders`

Array of indexes of connected elements describing their order required by the type.
Each array may contain 1 to N items (where N is the number of connected elements).

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionMatchType.#ctor(System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionMatchType.#ctor(System.Guid)`

#### Summary

Constructs a StructuralConnectionMatchType with minimum required information (GUID).

#### Parameter `guid`

GUID identifying the type.

#### Since

2017

### `T:Autodesk.Revit.DB.Structure.StructuralConnectionMatchType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionMatchType`

#### Summary

Class containing the information about the type available for the Connection.

#### Remarks

It's exposed in internal API.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.SetInputPointsInfo(System.Collections.Generic.IList{Autodesk.Revit.DB.Structure.ConnectionInputPointInfo})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.SetInputPointsInfo(System.Collections.Generic.IList{Autodesk.Revit.DB.Structure.ConnectionInputPointInfo})`

#### Summary

Sets the list of descption information used to select input points by some connections.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.GetInputPointsInfo`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.GetInputPointsInfo`

#### Summary

Returns a list of desciption information used to select input points by some connections.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.GetRangesOfApplicabilityBufferSize`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.GetRangesOfApplicabilityBufferSize`

#### Summary

Get the size of the ranges of applicability buffer.

#### Returns

Returns the size of the ranges of applicability buffer.
Returns a value greater than 0 if there any ranges. Otherwise, returns 0.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.GetRangesOfApplicabilityBuffer(System.IntPtr,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.GetRangesOfApplicabilityBuffer(System.IntPtr,System.Int32)`

#### Summary

Gets the ranges of applicability buffer from connection type.

#### Parameter `rangesBuffer`

Ranges of applicability buffer.

#### Parameter `rangesBufferSize`

The allocated size of the buffer. getRangesOfApplicabilityBufferSize() can be used to correctly instantiate this.

#### Returns

Returns the size of ranges of applicability buffer.
Returns a value greater than 0 if there are any ranges and if it successfully copied the data. Otherwise, returns 0.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.SetRangesOfApplicabilityBuffer(System.IntPtr,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.SetRangesOfApplicabilityBuffer(System.IntPtr,System.Int32)`

#### Summary

Sets the ranges of applicability buffer to the connection type.

#### Parameter `rangesBuffer`

Ranges of applicability buffer.

#### Parameter `rangesBufferSize`

Ranges of applicability buffer size.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.GetDetailedParametersBufferSize`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.GetDetailedParametersBufferSize`

#### Summary

Get the size of the detailed parameters buffer.

#### Returns

Returns the size of the detailed parameters data buffer.
Returns a value greater than 0, if there is any detailed parameters data. Otherwise, returns 0.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.GetDetailedParameters(System.IntPtr,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.GetDetailedParameters(System.IntPtr,System.Int32)`

#### Summary

Gets the detailed parameters from connection type.

#### Parameter `params`

Detailed parameters buffer.

#### Parameter `paramsBufferSize`

The allocated size of the buffer. getDetailedParametersBufferSize() can be used to correctly instantiate this.

#### Returns

Returns the size of detailed parameters data buffer.
Returns a value greater than 0, if there is any detailed parameters data and it is succesfully allocated to provided buffer. Otherwise, returns 0.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.SetDetailedParameters(System.IntPtr,System.Int32,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.SetDetailedParameters(System.IntPtr,System.Int32,System.Boolean)`

#### Summary

Sets the detailed parameters to the connection type.

#### Parameter `params`

Detailed parameters buffer.

#### Parameter `paramsBufferSize`

Detailed parameters buffer size.

#### Parameter `updateConnections`

Specify if we have to update connections; for example when we check override params.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.GetCustomConnectionTemplateUniqueId(System.Guid@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.GetCustomConnectionTemplateUniqueId(System.Guid@)`

#### Summary

Gets template connection unique id.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.GetCustomConnectionTemplateDataHash(System.Guid@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.GetCustomConnectionTemplateDataHash(System.Guid@)`

#### Summary

Gets binary custom connection template data hash.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.GetCustomConnectionTemplateData(System.IntPtr,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.GetCustomConnectionTemplateData(System.IntPtr,System.Int32)`

#### Summary

Gets binary custom connection template data.

#### Parameter `data`

Buffer to receive custom connection template data.

#### Parameter `nDataSize`

Available data size.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.GetCustomConnectionTemplateDataSize`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.GetCustomConnectionTemplateDataSize`

#### Summary

Gets binary custom connection template data size.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.SetCustomConnectionTemplateData(System.IntPtr,System.Int32,System.Guid,System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.SetCustomConnectionTemplateData(System.IntPtr,System.Int32,System.Guid,System.Guid)`

#### Summary

Sets binary data related to custom connection template.

#### Parameter `data`

Custom connection template data.

#### Parameter `nDataSize`

Data size.

#### Parameter `hash`

Custom connection template data hash.

#### Parameter `id`

Unique id of the template.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.FindGenericConnectionType(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.FindGenericConnectionType(Autodesk.Revit.DB.Document)`

#### Summary

Finds StructuralConnectionHandlerType which is Generic Connection type.

#### Returns

Returns id of StructuralConnectionHandlerType which is Generic Connection type of invalidElementId if not found.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.IsTypeNameValidForCustomConnection(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.IsTypeNameValidForCustomConnection(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Validates if the input name matches the criteria of StructuralConnectionHandlerType name.
Name must be unique among other existing StructuralConnectionHandlerTypes and cannot contain any of the following characters: new line, {}[];`~\\/:*?";<>| or any of the non-printable characters.

#### Parameter `document`

The Document.

#### Parameter `typeName`

The StructuralConnectionHandlerType name to validate.

#### Returns

True if the input name matches the criteria of StructuralConnectionHandlerType name.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.RemoveMainSubelementsFromCustomConnection(Autodesk.Revit.DB.Structure.StructuralConnectionHandler,System.Collections.Generic.IList{Autodesk.Revit.DB.Subelement})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.RemoveMainSubelementsFromCustomConnection(Autodesk.Revit.DB.Structure.StructuralConnectionHandler,System.Collections.Generic.IList{Autodesk.Revit.DB.Subelement})`

#### Summary

Removes one or more subelements from a StructuralConnectionHandlerType. The subelements will be erased.

#### Parameter `structuralConnectionHandler`

The existing StructuralConnectionHandler having custom StructuralConnectionHandlerType which is about to be modified.

#### Parameter `subelements`

The main Subelements of input StructuralConnectionHandler which are to be used to modify custom StructuralConnectionHandlerType.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Input StructuralConnectionHandler must have custom type.
-or-
All the input Subelements must belong to input StructuralConnectionHandler.
After modification of StructuralConnectionHandlerType there must remain at least one subelement of structural connections category in StructuralConnectionHandler.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.AddElementsToCustomConnection(Autodesk.Revit.DB.Structure.StructuralConnectionHandler,System.Collections.Generic.IList{Autodesk.Revit.DB.Reference})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.AddElementsToCustomConnection(Autodesk.Revit.DB.Structure.StructuralConnectionHandler,System.Collections.Generic.IList{Autodesk.Revit.DB.Reference})`

#### Summary

Modifies StructuralConnectionHandlerType of input StructuralConnectionHandler by adding representors of input elements or subelements.

#### Remarks

Elements or subelements added to a custom connection are deleted and transformed in subelements of the connection. They could be:
FamilyInstance (structural beams and columns).

StructuralConnectionHandler elements associated to the connection.

Specific steel connection elements (bolts, anchors, plates, etc). These connection elements will be of type element but with categories related to structural connections, for example:
OST_StructConnectionWelds

OST_StructConnectionHoles

OST_StructConnectionModifiers

OST_StructConnectionShearStuds

OST_StructConnectionBolts

OST_StructConnectionAnchors

OST_StructConnectionPlates
You cannot add: elements connected by any connection handler, generic connections, holes and modifiers that are not on the connected elements.

#### Parameter `structuralConnectionHandler`

The existing StructuralConnectionHandler having custom StructuralConnectionHandlerType which is about to be modified.

#### Parameter `references`

References to elements or subelements which are to be used to modify custom StructuralConnectionHandlerType by adding their representors.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Input StructuralConnectionHandler must have custom type.
-or-
All the input Elements should be of the following structural categories: framings, columns, profiles, plates, bolts, anchors, shear studs, welds or structural connections.
-or-
Total number of different input elements of input StructuralConnectionHandlers must be lower or equal to 3.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.Create(Autodesk.Revit.DB.Document,System.String,System.Guid,System.String,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.Structure.ConnectionInputPointInfo})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.Create(Autodesk.Revit.DB.Document,System.String,System.Guid,System.String,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.Structure.ConnectionInputPointInfo})`

#### Summary

Creates a new StructuralConnectionHandlerType object.

#### Parameter `pADoc`

The document.

#### Parameter `name`

The type name.

#### Parameter `guid`

Connection GUID.

#### Parameter `familyName`

Name of system family which created type will belong to.

#### Parameter `categoryId`

Category identity of connection type.

#### Parameter `inputPointsInfo`

List of description information used for the selection of input points.

#### Returns

The newly created instance.

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

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.Create(Autodesk.Revit.DB.Document,System.String,System.Guid,System.String,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.Create(Autodesk.Revit.DB.Document,System.String,System.Guid,System.String,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new StructuralConnectionHandlerType object.

#### Parameter `pADoc`

The document.

#### Parameter `name`

The type name.

#### Parameter `guid`

Connection GUID.

#### Parameter `familyName`

Name of system family which created type will belong to.

#### Parameter `categoryId`

Category identity of connection type.

#### Returns

The newly created instance.

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

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.Create(Autodesk.Revit.DB.Document,System.String,System.Guid,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.Create(Autodesk.Revit.DB.Document,System.String,System.Guid,System.String)`

#### Summary

Creates a new StructuralConnectionHandlerType object.

#### Parameter `pADoc`

The document.

#### Parameter `name`

The type name.

#### Parameter `guid`

Connection GUID.

#### Parameter `familyName`

Name of system family which created type will belong to.

#### Returns

The newly created instance.

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

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.GetDefaultConnectionHandlerType(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.GetDefaultConnectionHandlerType(Autodesk.Revit.DB.Document)`

#### Summary

Gets a default type id for Structural Connection.

#### Parameter `pADoc`

The document.

#### Returns

The type id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.CreateDefaultStructuralConnectionHandlerType(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.CreateDefaultStructuralConnectionHandlerType(Autodesk.Revit.DB.Document)`

#### Summary

Creates a new StructuralConnectionHandlerType object with a default name.

#### Parameter `pADoc`

The document.

#### Returns

The newly created type id.

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

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.IsDetailed`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.IsDetailed`

#### Summary

Checks if StructuralConnectionHandlerType is detailed.

#### Returns

True if StructuralConnectionHandlerType is detailed.

#### Since

2019

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.IsGeneric`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.IsGeneric`

#### Summary

Checks if StructuralConnectionHandlerType is generic.

#### Returns

True if StructuralConnectionHandlerType is generic.

#### Since

2019

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.IsCustom`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.IsCustom`

#### Summary

Checks if StructuralConnectionHandlerType is custom.

#### Returns

True if StructuralConnectionHandlerType is custom.

#### Since

2019

### `P:Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.ConnectionGuid`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType.ConnectionGuid`

#### Summary

The GUID to use for identifying connection geometry generation algorithm.

#### Since

2017

### `T:Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionHandlerType`

#### Summary

A StructuralConnectionHandlerType is used in StructuralConnectionHandler element generation.

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.ConnectionInputPointInfo.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.ConnectionInputPointInfo.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.ConnectionInputPointInfo.RestrictionType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.ConnectionInputPointInfo.RestrictionType`

#### Summary

A type of input point restriction.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2021

### `P:Autodesk.Revit.DB.Structure.ConnectionInputPointInfo.InputMemberIndex`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.ConnectionInputPointInfo.InputMemberIndex`

#### Summary

A index of the input member to which the restriction applies.

#### Since

2021

### `P:Autodesk.Revit.DB.Structure.ConnectionInputPointInfo.PointSelectionText`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.ConnectionInputPointInfo.PointSelectionText`

#### Summary

A string used to select input point by some connections.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.DB.Structure.ConnectionInputPointInfo.#ctor(System.String,System.Int32,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ConnectionInputPointInfo.#ctor(System.String,System.Int32,System.String)`

#### Summary

Construct an input point info.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2021

### `M:Autodesk.Revit.DB.Structure.ConnectionInputPointInfo.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.ConnectionInputPointInfo.#ctor`

#### Summary

Construct a default input point.

#### Since

2021

### `T:Autodesk.Revit.DB.Structure.ConnectionInputPointInfo`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.ConnectionInputPointInfo`

#### Summary

An object that holds description information about a connection input point

#### Since

2021

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData.SetInputPointsInfo(System.Collections.Generic.IList{Autodesk.Revit.DB.Structure.ConnectionInputPointInfo})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData.SetInputPointsInfo(System.Collections.Generic.IList{Autodesk.Revit.DB.Structure.ConnectionInputPointInfo})`

#### Summary

Sets the list of description information used to select additional points by some connections.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData.GetInputPointsInfo`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData.GetInputPointsInfo`

#### Summary

Returns a list of description information used to select additional points by some connections.

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData.HasMediumRepr`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData.HasMediumRepr`

#### Summary

States if connection type should display any graphics in Coarse view.

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData.HasCoarseRepr`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData.HasCoarseRepr`

#### Summary

States if connection type should display any graphics in Coarse view.

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData.Order`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData.Order`

#### Summary

Order of connected elements.

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData.CodeChecking`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData.CodeChecking`

#### Summary

States if connection type has the automatic code checking implemented.

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData.CategoryId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData.CategoryId`

#### Summary

Category of connection elements which use that connection type (most common OST_StructConnections).

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData.Description`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData.Description`

#### Summary

Description of connection type.

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData.ConnectionGroup`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData.ConnectionGroup`

#### Summary

Connection Group name

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData.Name`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData.Name`

#### Summary

Name of connection type.

#### Since

2017

### `P:Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData.ConnectionTypeGuid`

Member kind: property
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData.ConnectionTypeGuid`

#### Summary

Unique identifier representing connection type.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData.SetDetailedPreviewImage(System.Windows.Media.Imaging.BitmapImage)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData.SetDetailedPreviewImage(System.Windows.Media.Imaging.BitmapImage)`

#### Summary

Sets the detailed preview image.

#### Parameter `image`

System::Windows::Media::Imaging::BitmapImage image to be set.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData.SetPreviewImage(System.Windows.Media.Imaging.BitmapImage)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData.SetPreviewImage(System.Windows.Media.Imaging.BitmapImage)`

#### Summary

Sets the preview image.

#### Parameter `image`

System::Windows::Media::Imaging::BitmapImage image to be set.

#### Since

2017

### `M:Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData.#ctor(System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData.#ctor(System.Guid)`

#### Summary

Constructs a new instance of StructuralConnectionTypeInfoData.

#### Parameter `guid`

The unique identifier of connection type.

#### Since

2017

### `T:Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.StructuralConnectionTypeInfoData`

#### Summary

The data describing given connection type, needed by Structural Connections Provider server.

#### Remarks

It's exposed in internal API.

#### Since

2017

### `T:Autodesk.Revit.DB.Structure.ConnectedElementOrder`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.ConnectedElementOrder`

#### Remarks

It's exposed in internal API.

#### Summary

Enumerated type describing order of connected elements required by connection type.

#### Since

2017

### `F:Autodesk.Revit.DB.Structure.ConnectedElementOrder.FullOrder`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ConnectedElementOrder.FullOrder`

#### Summary

Elements are ordered, starting from primary element.

### `F:Autodesk.Revit.DB.Structure.ConnectedElementOrder.PrimaryElement`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ConnectedElementOrder.PrimaryElement`

#### Summary

There is one primary element.

### `F:Autodesk.Revit.DB.Structure.ConnectedElementOrder.None`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.ConnectedElementOrder.None`

#### Summary

All connected elements are equivalent, no special element.

### `P:Autodesk.Revit.DB.Visual.Stone.CommonTintColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Stone.CommonTintColor`

#### Summary

The property labeled "Tint Color" from the "Stone" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Stone.CommonTintToggle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Stone.CommonTintToggle`

#### Summary

The property labeled "Tint" from the "Stone" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Stone.StonePatternAmount`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Stone.StonePatternAmount`

#### Summary

The property labeled "Amount" from the "Stone" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 2".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Stone.StonePatternMap`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Stone.StonePatternMap`

#### Summary

The property labeled "Image" from the "Stone" schema.

#### Remarks

This property is of type "AssetPropertyReference" and will only contain a reference to a connected image.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Stone.StonePattern`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Stone.StonePattern`

#### Summary

The property labeled "Relief Pattern" from the "Stone" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "StonePatternType".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Stone.StoneBumpAmount`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Stone.StoneBumpAmount`

#### Summary

The property labeled "Amount" from the "Stone" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 1".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Stone.StoneBumpMap`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Stone.StoneBumpMap`

#### Summary

The property labeled "Image" from the "Stone" schema.

#### Remarks

This property is of type "AssetPropertyReference" and will only contain a reference to a connected image.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Stone.StoneBump`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Stone.StoneBump`

#### Summary

The property labeled "Type" from the "Stone" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "StoneBumpType".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Stone.StoneApplication`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Stone.StoneApplication`

#### Summary

The property labeled "Finish" from the "Stone" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "StoneApplicationType".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Stone.StoneColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Stone.StoneColor`

#### Summary

The property labeled "Image" from the "Stone" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".
This property allows a connected asset.

#### Since

2018.1

### `T:Autodesk.Revit.DB.Visual.Stone`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.Stone`

#### Summary

A static class that provides access to the property names that appear in the Stone visual asset schema.

#### Since

2018.1

### `M:Autodesk.Revit.DB.Steel.SteelElementProperties.CountOfAsyncWarnings(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Steel.SteelElementProperties.CountOfAsyncWarnings(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

returns the count of async warnings for this element

#### Parameter `aDoc`

Revit document.

#### Parameter `elemId`

The element for which we update warnings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Steel.SteelElementProperties.ClearWarnings(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Steel.SteelElementProperties.ClearWarnings(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Clears the async warnings for the element

#### Parameter `aDoc`

Revit document.

#### Parameter `elemId`

The element for which we update warnings.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Steel.SteelElementProperties.FlushWarnings(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Steel.SteelElementProperties.FlushWarnings(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Boolean)`

#### Summary

Updates the async warnings for the element

#### Parameter `aDoc`

Revit document.

#### Parameter `elemId`

The element for which we update warnings.

#### Parameter `forceRebuildCache`

Force rebuild cache

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Steel.SteelElementProperties.FlushWarnings(Autodesk.Revit.DB.Document,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Steel.SteelElementProperties.FlushWarnings(Autodesk.Revit.DB.Document,System.Boolean)`

#### Summary

Updates the async warnings for all the elements in the document

#### Parameter `aDoc`

Revit document.

#### Parameter `forceRebuildCache`

Force rebuild cache

#### Returns

Returns a set with element ids that had their warnings flushed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Steel.SteelElementProperties.GetCurrWarnings(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.FailureDefinitionId}@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Steel.SteelElementProperties.GetCurrWarnings(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Collections.Generic.IList{Autodesk.Revit.DB.FailureDefinitionId}@)`

#### Parameter `aDoc`

The document.

#### Parameter `elemId`

The element for which we query warnings.

#### Parameter `warnings`

The warnings currently associated to this element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Steel.SteelElementProperties.RemoveWarning(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.FailureDefinitionId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Steel.SteelElementProperties.RemoveWarning(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.FailureDefinitionId)`

#### Parameter `aDoc`

Revit document.

#### Parameter `elemId`

The element for which we remove a warning.

#### Parameter `warn`

The warning to be removed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Steel.SteelElementProperties.PostWarning(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.FailureDefinitionId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Steel.SteelElementProperties.PostWarning(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.FailureDefinitionId)`

#### Parameter `aDoc`

Revit document.

#### Parameter `elemId`

The element for which we add a warning.

#### Parameter `warn`

The warning to be added.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Steel.SteelElementProperties.RegisterMaterial(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Steel.SteelElementProperties.RegisterMaterial(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.String)`

#### Summary

Registers entry in maps

#### Parameter `aDoc`

Current document.

#### Parameter `revitMaterialId`

Id of the Revit material.

#### Parameter `extMaterial`

External material

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Steel.SteelElementProperties.RemoveLink(Autodesk.Revit.DB.Document,System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Steel.SteelElementProperties.RemoveLink(Autodesk.Revit.DB.Document,System.Guid)`

#### Summary

Removes an entry from the maps.

#### Parameter `aDoc`

Current document.

#### Parameter `guid`

GUID of the element to be removed from the maps.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Steel.SteelElementProperties.RemoveLink(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Steel.SteelElementProperties.RemoveLink(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Removes an entry from the maps.

#### Parameter `aDoc`

Current document.

#### Parameter `elemId`

Revit Id of the element to be removed from the maps.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Steel.SteelElementProperties.GetAllExternalIds(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Steel.SteelElementProperties.GetAllExternalIds(Autodesk.Revit.DB.Document)`

#### Summary

Returns all the guids of the external elements linked to Revit elements.

#### Parameter `aDoc`

Current document.

#### Returns

guids of the external elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Steel.SteelElementProperties.GetAllRevitMaterialsIds(Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Steel.SteelElementProperties.GetAllRevitMaterialsIds(Autodesk.Revit.DB.Document)`

#### Summary

Returns all the ids of the Revit materials of external elements.

#### Parameter `aDoc`

Current document.

#### Returns

Element ids of the Revit materials.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Steel.SteelElementProperties.GetRevitBuiltInCategory(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Steel.SteelElementProperties.GetRevitBuiltInCategory(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,System.Int32)`

#### Summary

Returns id of the Revit material taking as input external material name.

#### Parameter `aDoc`

Current document.

#### Parameter `elementId`

Element id of the Revit element.

#### Parameter `subelementKey`

Subelement key of the element's subelement

#### Returns

Element id of the Revit builtin category.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Steel.SteelElementProperties.GetRevitMaterialId(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Steel.SteelElementProperties.GetRevitMaterialId(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Returns id of the Revit material taking as input external material name.

#### Parameter `aDoc`

Current document.

#### Parameter `mat`

name of the external material.

#### Returns

Element id of the Revit material.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Steel.SteelElementProperties.GetExternalMaterial(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Steel.SteelElementProperties.GetExternalMaterial(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Returns name of the external material taking as input Revit material id.

#### Parameter `aDoc`

Current document.

#### Parameter `id`

Element id of the Revit material.

#### Returns

name of the external material.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Steel.SteelElementProperties.GetExternalId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Steel.SteelElementProperties.GetExternalId(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Returns guid of the external element taking as input Revit element id.

#### Parameter `aDoc`

Current document.

#### Parameter `id`

Element id of the Revit element.

#### Returns

guid of the external element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Steel.SteelElementProperties.GetRevitId(Autodesk.Revit.DB.Document,System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Steel.SteelElementProperties.GetRevitId(Autodesk.Revit.DB.Document,System.Guid)`

#### Summary

Returns Revit element id taking as input an external guid.

#### Parameter `aDoc`

Current document.

#### Parameter `guid`

guid of the external element.

#### Returns

Element id of the Revit element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Steel.SteelElementProperties.RemoveFromElement(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Steel.SteelElementProperties.RemoveFromElement(Autodesk.Revit.DB.Element)`

#### Summary

Removes the element's SteelElementCell.

#### Returns

returns true if succeeded

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Steel.SteelElementProperties.AddToElement(Autodesk.Revit.DB.Element,System.Guid,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Steel.SteelElementProperties.AddToElement(Autodesk.Revit.DB.Element,System.Guid,System.Boolean)`

#### Summary

Create a SteelElementCell on element and adds the ext object id to it.

#### Returns

Returns true if succeeded.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Steel.SteelElementProperties.CanHaveCell(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Steel.SteelElementProperties.CanHaveCell(Autodesk.Revit.DB.Element)`

#### Summary

Validates that pElement is a beam or column that has a usable profile, a StructuraConnectionHandler or an SteelElement.

#### Returns

True if pElement is a valid FamilyInstance representing framing element, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Steel.SteelElementProperties.UpdateExternalUniqueIdsAfterPaste(System.Collections.Generic.IDictionary{System.Guid,System.Guid})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Steel.SteelElementProperties.UpdateExternalUniqueIdsAfterPaste(System.Collections.Generic.IDictionary{System.Guid,System.Guid})`

#### Summary

Updates members external unique ids according to the copy paste map

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Steel.SteelElementProperties.SetChanged(Autodesk.Revit.DB.Structure.SteelElementRegenChangeType)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Steel.SteelElementProperties.SetChanged(Autodesk.Revit.DB.Structure.SteelElementRegenChangeType)`

#### Summary

Mark object as changed - ask Revit to regen it.

#### Parameter `changeType`

how big is the change

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2019

### `M:Autodesk.Revit.DB.Steel.SteelElementProperties.AddFabricationInformationForRevitElements(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Steel.SteelElementProperties.AddFabricationInformationForRevitElements(Autodesk.Revit.DB.Document,System.Collections.Generic.IList{Autodesk.Revit.DB.ElementId})`

#### Summary

This method adds fabrication information to the given elements.

#### Remarks

You can add fabrication information to connections, beams, columns, braces, walls, floors and foundations.

#### Parameter `aDoc`

Document containing the given elements ids.

#### Parameter `elementIds`

Ids of the elements to which we want to add fabrication information.

#### Returns

Ids of the elements for which we couldn't add fabrication information.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Steel.SteelElementProperties.GetReference(Autodesk.Revit.DB.Document,System.Guid)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Steel.SteelElementProperties.GetReference(Autodesk.Revit.DB.Document,System.Guid)`

#### Summary

This method will return the reference for the given fabrication id.

#### Parameter `aDoc`

Document in which to search for the reference.

#### Parameter `guid`

The fabrication id for which a reference is required.

#### Returns

The reference to the element or subelement corresponding to the given id.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Steel.SteelElementProperties.GetFabricationUniqueID(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Steel.SteelElementProperties.GetFabricationUniqueID(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Reference)`

#### Summary

This method will return the fabrication id for the given reference.

#### Parameter `aDoc`

Document to which the reference belongs.

#### Parameter `reference`

The reference to the element or subelement for which fabrication id is required.

#### Returns

The fabrication id of the element or subelement for this reference, if it has fabrication information attached, or an Guid.Empty otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.Steel.SteelElementProperties.GetSteelElementProperties(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Steel.SteelElementProperties.GetSteelElementProperties(Autodesk.Revit.DB.Element)`

#### Summary

Get SteelElementProperties for the input element if they exist.

#### Remarks

If the input element doesn't have steel informations than it retuns `null` .

#### Parameter `pElement`

The element from which we try to obtain SteelElementProperties.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `P:Autodesk.Revit.DB.Steel.SteelElementProperties.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Steel.SteelElementProperties.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.Steel.SteelElementProperties.HasGraphics`

Member kind: property
Symbol: `Autodesk.Revit.DB.Steel.SteelElementProperties.HasGraphics`

#### Summary

Decides if graphics is provided by Revit, or external application.
Also, checks if the cell has full control of the graphics of the element.

#### Since

2019

### `P:Autodesk.Revit.DB.Steel.SteelElementProperties.UniqueID`

Member kind: property
Symbol: `Autodesk.Revit.DB.Steel.SteelElementProperties.UniqueID`

#### Summary

This method will return the fabrication id. This represents the link between the Revit and the Steel Core element.

#### Remarks

This id should not be confused with the guid returned by ExportUtils.GetExportId().

#### Since

2019

### `P:Autodesk.Revit.DB.Steel.SteelElementProperties.IsDetachedFromFamily`

Member kind: property
Symbol: `Autodesk.Revit.DB.Steel.SteelElementProperties.IsDetachedFromFamily`

#### Summary

Is this cell attached to dummy family.

#### Since

2019

### `T:Autodesk.Revit.DB.Steel.SteelElementProperties`

Member kind: type
Symbol: `Autodesk.Revit.DB.Steel.SteelElementProperties`

#### Summary

This class is used to attach steel fabrication information to various Revit elements.

#### Remarks

Revit elements which can have fabrication information are:
FamilyInstance (structural beams and columns).

StructuralConnectionHandler elements associated to the connection.

Specific steel connection elements (bolts, anchors, plates, etc). These connection elements will be of type element but with categories related to structural connections, for example:
OST_StructConnectionWelds

OST_StructConnectionHoles

OST_StructConnectionModifiers

OST_StructConnectionShearStuds

OST_StructConnectionBolts

OST_StructConnectionAnchors

OST_StructConnectionPlates

Some concrete elements (walls, floors, concrete beams, ...) when they are input elements to detailed steel connections.
The class also holds the link to the Steel Core elements.

#### Since

2019

### `T:Autodesk.Revit.DB.Structure.SteelElementRegenChangeType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Structure.SteelElementRegenChangeType`

#### Remarks

type of the cell change

#### Summary

type of the object

#### Since

2019

### `F:Autodesk.Revit.DB.Structure.SteelElementRegenChangeType.Hard`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.SteelElementRegenChangeType.Hard`

#### Summary

means big change that may affect other elements as well, for example move

### `F:Autodesk.Revit.DB.Structure.SteelElementRegenChangeType.Graphics`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.SteelElementRegenChangeType.Graphics`

#### Summary

Means small change affecting only this element, for example a new feature was added
From Revit point of view element should be redrawn

### `F:Autodesk.Revit.DB.Structure.SteelElementRegenChangeType.Touch`

Member kind: field
Symbol: `Autodesk.Revit.DB.Structure.SteelElementRegenChangeType.Touch`

#### Summary

Means undefined change in this element's outside data.
From Revit point of view element should be marked as changed and checked-out if appropriate

### `M:Autodesk.Revit.DB.StdPostedWarning.GetElements`

Member kind: method
Symbol: `Autodesk.Revit.DB.StdPostedWarning.GetElements`

#### Summary

Get ElementIds related to warning.

#### Since

2019

### `M:Autodesk.Revit.DB.StdPostedWarning.UpdateWarning(Autodesk.Revit.DB.Document,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.StdPostedWarning.UpdateWarning(Autodesk.Revit.DB.Document,System.Boolean)`

#### Summary

Updates warning state.

#### Parameter `doc`

document

#### Parameter `state`

state

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `P:Autodesk.Revit.DB.StdPostedWarning.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.StdPostedWarning.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `P:Autodesk.Revit.DB.StdPostedWarning.FailureDefinitionId`

Member kind: property
Symbol: `Autodesk.Revit.DB.StdPostedWarning.FailureDefinitionId`

#### Summary

Identity of failure reported for element.

#### Since

2019

### `M:Autodesk.Revit.DB.StdPostedWarning.#ctor(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.FailureDefinitionId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.StdPostedWarning.#ctor(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.FailureDefinitionId)`

#### Summary

Construct structure containing failure identity and element id.

#### Parameter `elementId`

The identity of element.

#### Parameter `failureDefinitionId`

The identity of failure.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `M:Autodesk.Revit.DB.StdPostedWarning.#ctor(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.FailureDefinitionId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.StdPostedWarning.#ctor(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId},Autodesk.Revit.DB.FailureDefinitionId)`

#### Summary

Construct structure containing failure identity and element id.

#### Parameter `elemIds`

The identities of elements.

#### Parameter `failureDefinitionId`

The identity of failure.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2019

### `T:Autodesk.Revit.DB.StdPostedWarning`

Member kind: type
Symbol: `Autodesk.Revit.DB.StdPostedWarning`

#### Summary

Support for Reviewable Warnings sent from AddOn.

#### Remarks

Used to create and send Reviewable Warning from AddOn.

#### Since

2019

### `M:Autodesk.Revit.DB.Architecture.NonContinuousRailStructure.IsValidNonContinuousRailProfile(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.NonContinuousRailStructure.IsValidNonContinuousRailProfile(Autodesk.Revit.DB.ElementId)`

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

### `M:Autodesk.Revit.DB.Architecture.NonContinuousRailStructure.RemoveNonContinuousRail(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.NonContinuousRailStructure.RemoveNonContinuousRail(System.Int32)`

#### Summary

Removes Non-Continuous Rail from the Rail Structure.

#### Parameter `index`

Non-Continuous Rail index.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The index index is out of range.

#### Since

2019

### `M:Autodesk.Revit.DB.Architecture.NonContinuousRailStructure.GetNonContinuousRail(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.NonContinuousRailStructure.GetNonContinuousRail(System.Int32)`

#### Summary

Gets the Non-Continuous Rail object of specified index from the Rail Structure.

#### Parameter `index`

Non-Continuous Rail index.

#### Returns

The requested object handle.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The index index is out of range.

#### Since

2019

### `M:Autodesk.Revit.DB.Architecture.NonContinuousRailStructure.AddNonContinuousRail(System.String,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.NonContinuousRailStructure.AddNonContinuousRail(System.String,System.Double,System.Double)`

#### Summary

Creates and appends a new Non-Continuous Rail to the Rail Structure.
The new Non-Continuous Rail will have the given name, height and offset.
It will have default profile and material ElementIds.

#### Parameter `name`

The name of the non-continuous rail.

#### Parameter `height`

The height on which the non-continuous rail will be placed.

#### Parameter `offset`

The offset of the non-continuous rail from a `T:Autodesk.Revit.DB.Architecture.Railing` center.

#### Returns

Handle to the new Non-Continuous Rail.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

name is an empty string or contains only whitespace.
-or-
name cannot include prohibited characters, such as "{, }, [, ], |, ;, less-than sign, greater-than sign, ?, `, ~".
-or-
The name is a duplicate of an existing non-continuous rail.
-or-
The height height is not valid for the non-continuous rail because
it is greater than the height of the RailingType to which it belongs.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The given value for height must be no more than 30000 feet in absolute value.
-or-
The given value for offset must be no more than 30000 feet in absolute value.

#### Since

2019

### `M:Autodesk.Revit.DB.Architecture.NonContinuousRailStructure.GetNonContinuousRailCount`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.NonContinuousRailStructure.GetNonContinuousRailCount`

#### Summary

Gets number of Non-Continuous Rails.

#### Returns

Count of Non-Continuous Rails.

#### Since

2019

### `P:Autodesk.Revit.DB.Architecture.NonContinuousRailStructure.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.NonContinuousRailStructure.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

If the corresponding Revit native object is destroyed, or creation of the corresponding object is undone,
a managed API object containing it is no longer valid. API methods cannot be called on invalidated wrapper objects.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

#### Since

2014

### `T:Autodesk.Revit.DB.Architecture.NonContinuousRailStructure`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.NonContinuousRailStructure`

#### Summary

A class that represents a collection of Non-Continuous Rails being a part of Railing Type.

#### Since

2019

### `P:Autodesk.Revit.DB.Architecture.RailingType.SecondaryHandrailHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.RailingType.SecondaryHandrailHeight`

#### Summary

The height of the secondary handrail.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The rail has no secondary hand rail.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.RailingType.PrimaryHandrailHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.RailingType.PrimaryHandrailHeight`

#### Summary

The height of the primary handrail.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The rail has no primary hand rail.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.RailingType.SecondaryHandrailLateralOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.RailingType.SecondaryHandrailLateralOffset`

#### Summary

The lateral offset of the secondary handrail.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The rail has no secondary hand rail.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.RailingType.PrimaryHandrailLateralOffset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.RailingType.PrimaryHandrailLateralOffset`

#### Summary

The lateral offset of the primary handrail.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The rail has no primary hand rail.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.RailingType.SecondaryHandrailType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.RailingType.SecondaryHandrailType`

#### Summary

The type of the secondary handrail.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The handRailTypeId is not a valid hand rail type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.RailingType.PrimaryHandrailType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.RailingType.PrimaryHandrailType`

#### Summary

The type of the primary handrail.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The handRailTypeId is not a valid hand rail type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.RailingType.TopRailType`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.RailingType.TopRailType`

#### Summary

The type of the top rail in the railing system.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The topRailType is not a valid top rail type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.RailingType.TopRailHeight`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.RailingType.TopRailHeight`

#### Summary

The height of the top rail in the railing system.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The given value for height must be between 0 and 30000 feet.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.RailingType.SecondaryHandRailPosition`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.RailingType.SecondaryHandRailPosition`

#### Summary

The position of the secondary handrail.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The rail has no secondary hand rail.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.RailingType.PrimaryHandRailPosition`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.RailingType.PrimaryHandRailPosition`

#### Summary

The position of the primary handrail.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

When setting this property: The rail has no primary hand rail.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.RailingType.RailStructure`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.RailingType.RailStructure`

#### Summary

The NonContinuousRailStructure.

#### Since

2019

### `P:Autodesk.Revit.DB.Architecture.RailingType.BalusterPlacement`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.RailingType.BalusterPlacement`

#### Summary

Accesses the object containing properties related to the baluster placement.

#### Since

2019

### `T:Autodesk.Revit.DB.Architecture.RailingType`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.RailingType`

#### Summary

An object supporting management of baluster and post placement within the railing type.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.Railing.IsValidPathForRailing(Autodesk.Revit.DB.CurveLoop)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.Railing.IsValidPathForRailing(Autodesk.Revit.DB.CurveLoop)`

#### Summary

Checks whether a railing can be created along a railing path.

#### Remarks

The railing path should be located on the same horizontal plane and it should contain lines or arcs only.
It also has to be continuous and its three or more curves cannot meet in one end point.

#### Parameter `curveLoop`

The railing path along which the new railing will be created.

#### Returns

True if the new railing path can be used in a railing definition, False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2018

### `M:Autodesk.Revit.DB.Architecture.Railing.IsValidHostForNewRailing(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.Railing.IsValidHostForNewRailing(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId)`

#### Summary

Checks whether new railing can be created and placed on the specified host.

#### Remarks

This function will return true for stairs or ramps which can host new railings.
Stairs or ramps can host new railings only when they have no associated railing and they are not in editing mode.

#### Parameter `document`

The document.

#### Parameter `elementId`

The element to check.

#### Returns

True if new railing can be created and placed on the host, False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.Railing.ResetSupportPosition`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.Railing.ResetSupportPosition`

#### Summary

Resets the continuous rails support subelements position data.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.Railing.GetSubelementOnLevel(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.Railing.GetSubelementOnLevel(Autodesk.Revit.DB.ElementId)`

#### Summary

Gets the subelement on given level.

#### Remarks

The method is valid only for railings hosted by stairs in `T:Autodesk.Revit.DB.Architecture.MultistoryStairs` .
Input level should be a level of the railing stairs.
See getStairsPlacementLevels method of `T:Autodesk.Revit.DB.Architecture.MultistoryStairs` .

#### Parameter `levelId`

The id of the level the railing subelement is placed on.

#### Returns

The subelement in given level.
`null` will be returned if railing has no subelements on given level.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The railing is not hosted by stairs in `T:Autodesk.Revit.DB.Architecture.MultistoryStairs` .

#### Since

2018

### `M:Autodesk.Revit.DB.Architecture.Railing.SetMultistoryStairsPlacementLevels(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.Railing.SetMultistoryStairsPlacementLevels(System.Collections.Generic.ISet{Autodesk.Revit.DB.ElementId})`

#### Summary

Sets the ids of the base levels of the stairs upon which this railing is placed.

#### Remarks

The method is valid only for railings hosted by stairs in `T:Autodesk.Revit.DB.Architecture.MultistoryStairs` .
The input level ids have to be a subset of level ids of the railing stairs.
See `T:Autodesk.Revit.DB.Architecture.MultistoryStairs` for information about the placement levels that may be passed as input.

#### Parameter `levelIds`

The ids of levels the railing is placed on.
If input level id set is empty, railings will placed on all levels of the hosting stairs.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

All of the level ids in levelIds must be placement levels of stairs.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The railing is not hosted by stairs in `T:Autodesk.Revit.DB.Architecture.MultistoryStairs` .

#### Since

2018

### `M:Autodesk.Revit.DB.Architecture.Railing.GetMultistoryStairsPlacementLevels`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.Railing.GetMultistoryStairsPlacementLevels`

#### Summary

Gets the ids of the base levels of the stairs upon which this railing is placed.

#### Remarks

The method is valid only for railings hosted by stairs in `T:Autodesk.Revit.DB.Architecture.MultistoryStairs` .

#### Returns

The ids of levels the railing is placed on.
The returned set consists of a subset of the base level ids of the corresponding stairs in the `T:Autodesk.Revit.DB.Architecture.MultistoryStairs` .

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The railing is not hosted by stairs in `T:Autodesk.Revit.DB.Architecture.MultistoryStairs` .

#### Since

2018

### `M:Autodesk.Revit.DB.Architecture.Railing.RemoveHost`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.Railing.RemoveHost`

#### Summary

Removes the association between the railing and its host.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.Railing.Flip`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.Railing.Flip`

#### Summary

Flips the railing.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

The railing has incorrect internal data.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.Railing.Reset`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.Railing.Reset`

#### Summary

Resets the railing to the default one that the system generates.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Cannot reset the railing.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.Railing.GetHandRails`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.Railing.GetHandRails`

#### Summary

Get all the handrails of the railing.

#### Returns

All handrails of the railing.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.Railing.RailingCanBeHostedByElement(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.Railing.RailingCanBeHostedByElement(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks whether the specified element can be used as a host for the railing.
The host can be:
stairs

stairs component

ramp

floor

slab edge

wall

roof

#### Parameter `hostId`

Element id to check.

#### Returns

True if the element can be used as host for the railing.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2017

### `M:Autodesk.Revit.DB.Architecture.Railing.SetPath(Autodesk.Revit.DB.CurveLoop)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.Railing.SetPath(Autodesk.Revit.DB.CurveLoop)`

#### Summary

Sets the railing path.

#### Parameter `curveLoop`

The railing path along which the new railing will be created.
The curveLoop should be continuous with curves which are only bounded lines and arcs on the same horizontal plane.
It also has to have maximum two curves meet in one end point.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The curveLoop must be a single connected path, located on the same horizontal plane and defined using lines or arcs only.
It also has to have maximum two curves meet in one end point.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

The railing has incorrect internal data.

#### Since

2017

### `M:Autodesk.Revit.DB.Architecture.Railing.GetPath`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.Railing.GetPath`

#### Summary

Gets the railing path.

#### Returns

The curve array of the railing path.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

The railing has incorrect internal data.

#### Since

2013

### `M:Autodesk.Revit.DB.Architecture.Railing.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Architecture.RailingPlacementPosition)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.Railing.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Architecture.RailingPlacementPosition)`

#### Summary

Creates new railings with the specified railing type on all sides of a stairs instance in a `T:Autodesk.Revit.DB.Architecture.MultistoryStairs` element.

#### Parameter `document`

The document.

#### Parameter `multistoryStairsId`

The id of the `T:Autodesk.Revit.DB.Architecture.MultistoryStairs` that contains the stairs which will be the host of this railing.
The stairs should have no associated railings yet.

#### Parameter `levelId`

The level of stairs on which the new railing will be created.
The level should be one of levels defining the `T:Autodesk.Revit.DB.Architecture.MultistoryStairs` element.

#### Parameter `railingTypeId`

The railing type of the new railing to be created.

#### Parameter `placePosition`

The placement position of the new railing.

#### Returns

The new railing instances successfully created on the stairs.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The railingTypeId is not a railing type.
-or-
The ElementId levelId is not a Level.
-or-
The levelId is not a level of `T:Autodesk.Revit.DB.Architecture.MultistoryStairs` stairs element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The multistoryStairsId already has associated railings or is in editing mode so association of railings is not permitted.

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

### `M:Autodesk.Revit.DB.Architecture.Railing.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.CurveLoop,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.Railing.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.CurveLoop,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new railing by specifying the railing path in the project document.

#### Parameter `document`

The document.

#### Parameter `curveLoop`

The railing path along which the new railing will be created.
The curveLoop should be continuous with curves which are only bounded lines and arcs on the same horizontal plane.
It also has to have maximum two curves meet in one end point.

#### Parameter `railingTypeId`

The railing type of the new railing to be created.

#### Parameter `baseLevelId`

The base level on which the new railing will be created.

#### Returns

The new railing instance if creation was successful, otherwise `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The curveLoop must be a single connected path, located on the same horizontal plane and defined using lines or arcs only.
It also has to have maximum two curves meet in one end point.
-or-
The railingTypeId is not a railing type.
-or-
The ElementId baseLevelId is not a Level.

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

2017

### `M:Autodesk.Revit.DB.Architecture.Railing.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Architecture.RailingPlacementPosition)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Architecture.Railing.Create(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Architecture.RailingPlacementPosition)`

#### Summary

Automatically creates new railings with the specified railing type on all sides of a stairs or ramp element.

#### Parameter `document`

The document.

#### Parameter `stairsOrRampId`

The stairs or ramp to which the new railing will host.
The stairs or ramp should have no associated railings yet.
If the stairs are a part of `T:Autodesk.Revit.DB.Architecture.MultistoryStairs` element railings will be populated on all levels.

#### Parameter `railingTypeId`

The railing type of the new railing to be created.

#### Parameter `placePosition`

The placement position of the new railing.

#### Returns

The new railing instances successfully created on the stairs.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The stairsOrRampId is not a stairs or ramp element.
-or-
The railingTypeId is not a railing type.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

The stairsOrRampId already has associated railings or is in editing mode so association of railings is not permitted.

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

### `P:Autodesk.Revit.DB.Architecture.Railing.CanReset`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.Railing.CanReset`

#### Summary

True if the railing can be reset, False otherwise.

#### Remarks

A Railing can be reset only if the railing was created in Revit later than version 9.1.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.Railing.IsDefault`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.Railing.IsDefault`

#### Summary

Indicates if the railing is the default one that system generates.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.Railing.TopRail`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.Railing.TopRail`

#### Summary

The top rail of the railing.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.Railing.Flipped`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.Railing.Flipped`

#### Summary

Indicates if the railing is flipped.

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

The railing has incorrect internal data.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.Railing.HasHost`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.Railing.HasHost`

#### Summary

Indicates if the railing has a host.

#### Since

2013

### `P:Autodesk.Revit.DB.Architecture.Railing.HostId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Architecture.Railing.HostId`

#### Summary

The host of the railing.

#### Remarks

If the host will be a Stairs in `T:Autodesk.Revit.DB.Architecture.MultistoryStairs` element, use `M:Autodesk.Revit.DB.Architecture.Railing.SetMultistoryStairsPlacementLevels(System.Collections.Generic.ISet`1{Autodesk.Revit.DB.ElementId})` to set the base levels of the stairs where the railing should be placed.

If %hostId% is the id of a Stairs Component (Run or Landing), it means that the Railing will be hosted by the Stairs element but railing adjustment to the stairs will start from the Component.
If a stairs id is set as a host, the lowest stairs component below or above the railing sketch will be chosen as the host instead.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

When setting this property: The hostId is not a valid railing host.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2013

### `T:Autodesk.Revit.DB.Architecture.Railing`

Member kind: type
Symbol: `Autodesk.Revit.DB.Architecture.Railing`

#### Summary

Represents a railing element in Autodesk Revit.

#### Since

2013

### `M:Autodesk.Revit.DB.StairsEditScope.Start(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.StairsEditScope.Start(Autodesk.Revit.DB.ElementId)`

#### Summary

Starts an stairs edit mode for an existing Stairs element

#### Remarks

User will need to start a transaction to actually make changes to the stairs element.
StairsEditScope can only be started when there is no transaction active
Thus it does not work for commands running in automatic transaction mode.

#### Parameter `stairsId`

The stairs element to be edited.

#### Returns

ElementId of the editing stairs. It should be the same as the input stairsId

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

It is not a Stair's id.
-or-
Stairs is not permitted to edit at this moment for the following reason:
The Stairs is in an ElementGroup and it is not in Edit Group Mode.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This StairsEditScope is not permitted to start at this moment for one of the following possible reasons:
The document is in read-only state, or the document is currently modifiable,
or there already is another edit mode active in the document.

#### Since

2013

### `M:Autodesk.Revit.DB.StairsEditScope.Start(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.StairsEditScope.Start(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.ElementId)`

#### Summary

Creates a new empty stairs element with a default stairs type in the specified levels
and then starts stairs edit mode and editing the new stairs.

#### Remarks

A new stairs will be created after this operation.
User will need to start a transaction to actually make changes to the stairs element.
StairsEditScope can only be started when there is no transaction active
Thus it does not work for commands running in automatic transaction mode.

#### Parameter `baseLevelId`

The base level on which the stairs is to be placed.

#### Parameter `topLevelId`

The top level where the stairs is to reach.

#### Returns

ElementId of the new stairs.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

It is not a Level's id.
-or-
Top level should be higher than base level.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This StairsEditScope is not permitted to start at this moment for one of the following possible reasons:
The document is in read-only state, or the document is currently modifiable,
or there already is another edit mode active in the document.

#### Since

2013

### `M:Autodesk.Revit.DB.StairsEditScope.#ctor(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.StairsEditScope.#ctor(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Instantiates a StairsEditScope object.

#### Parameter `document`

The document for which this StairsEditScope is going to be used.

#### Parameter `transactionName`

The name that will appear in the Undo menu in Revit after the StairsEditScope is successfully committed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a primary document, it is a linked document.
-or-
document is not a project document.
-or-
transactionName is an empty string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `T:Autodesk.Revit.DB.StairsEditScope`

Member kind: type
Symbol: `Autodesk.Revit.DB.StairsEditScope`

#### Summary

StairsEditScope allows user to maintain a stairs-editing session.

#### Remarks

Start/end of a StairsEditScope will start/end a transaction group. After a StairsEditScope is started, user can start transactions and edit the stairs.
Individual transactions the user creates inside StairsEditScope will not appear in the undo menu.
All transactions committed during the edit mode will be merged into a single one which will bear the given name passed into StairsEditScope constructor.

#### Since

2013

### `P:Autodesk.Revit.DB.Lighting.SpotLightDistribution.TiltAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Lighting.SpotLightDistribution.TiltAngle`

#### Summary

The tilt angle.

#### Value

The tilt angle as a numerical value in radians between -PI and PI.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The angle is not valid because it is not between -180.0 and 180.0.

#### Since

2013

### `P:Autodesk.Revit.DB.Lighting.SpotLightDistribution.SpotFieldAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Lighting.SpotLightDistribution.SpotFieldAngle`

#### Summary

The spot field angle.

#### Value

The spot beam angle as a numerical value in radians between 0 and (8/9)*PI.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The angle is not valid because it is not between 1.0e-2 and 160.0.

#### Since

2013

### `P:Autodesk.Revit.DB.Lighting.SpotLightDistribution.SpotBeamAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Lighting.SpotLightDistribution.SpotBeamAngle`

#### Summary

The spot beam angle.

#### Value

The spot beam angle as a numerical value in radians between 0 and (8/9)*PI.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: The angle is not valid because it is not between 1.0e-2 and 160.0.

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.SpotLightDistribution.#ctor(Autodesk.Revit.DB.Lighting.SpotLightDistribution)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.SpotLightDistribution.#ctor(Autodesk.Revit.DB.Lighting.SpotLightDistribution)`

#### Summary

Creates a copy of the given spotlight distribution

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.SpotLightDistribution.#ctor(System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.SpotLightDistribution.#ctor(System.Double,System.Double,System.Double)`

#### Summary

Creates a spot light distribution object with the given values.

#### Parameter `spotBeamAngle`

The spot beam angle as a numerical value in radians between 0 and (8/9)*PI.

#### Parameter `spotFieldAngle`

The spot field angle as a numerical value in radians between 0 and (8/9)*PI.

#### Parameter `tiltAngle`

The tilt angle as a numerical value in radians between -PI and PI.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

The angle is not valid because it is not between 1.0e-2 and 160.0.
-or-
The angle is not valid because it is not between -180.0 and 180.0.

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.SpotLightDistribution.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.SpotLightDistribution.#ctor`

#### Summary

Creates a spot light distribution object with the following values;
PI/6 radians spot beam anglePI/2 radians spot field anglePI/6 radians tilt angle

#### Since

2013

### `T:Autodesk.Revit.DB.Lighting.SpotLightDistribution`

Member kind: type
Symbol: `Autodesk.Revit.DB.Lighting.SpotLightDistribution`

#### Summary

This class encapsulates a spot light distribution.

#### Since

2013

### `M:addLinAngDimStyle(ADocument*)`

Member kind: method
Symbol: `addLinAngDimStyle(ADocument*)`

### `T:Autodesk.Revit.DB.SpotDimensionType`

Member kind: type
Symbol: `Autodesk.Revit.DB.SpotDimensionType`

#### Summary

A type element containing the properties of a spot elevation.

### `M:Autodesk.Revit.DB.SpotDimension.CreateAlignmentStationLabelSet(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId,System.Double,System.Double,System.Double,System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SpotDimension.CreateAlignmentStationLabelSet(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.View,Autodesk.Revit.DB.ElementId,System.Double,System.Double,System.Double,System.Double)`

#### Summary

Creates a new instance of an AlignmentStationLabel element in the document.

#### Parameter `host`

The host alignment element to which the new AlignmentStationLabelSet is attached.

#### Parameter `dbView`

The view in which the AlignmentStationLabelSet will appear.

#### Parameter `typeId`

The type ID of the labels in the set.

#### Returns

The array of elements of newly created AlignmentStationLabel instances.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.SpotDimension.CreateAlignmentStationLabel(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.View,Autodesk.Revit.DB.XYZ,System.Boolean,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SpotDimension.CreateAlignmentStationLabel(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.View,Autodesk.Revit.DB.XYZ,System.Boolean,Autodesk.Revit.DB.XYZ,Autodesk.Revit.DB.XYZ)`

#### Summary

Creates a new instance of an AlignmentStationLabel element in the document.

#### Parameter `host`

The host alignment element to which the new AlignmentStationLabel is attached.

#### Parameter `dbView`

The view in which the AlignmentStationLabel will appear.

#### Returns

The newly created AlignmentStationLabel instance, or `null` if the operation fails.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

### `M:Autodesk.Revit.DB.SpotDimension.Flip`

Member kind: method
Symbol: `Autodesk.Revit.DB.SpotDimension.Flip`

#### Summary

Flips dimension to the other side of the host.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

SpotDimension cannot be flipped.

#### Since

2021.2

### `M:Autodesk.Revit.DB.SpotDimension.CanFlip`

Member kind: method
Symbol: `Autodesk.Revit.DB.SpotDimension.CanFlip`

#### Summary

Verifies that the direction of the dimension can be flipped.

#### Remarks

Currently, flipping only allowed for non-pinned AlignmentStationLabels.

#### Returns

True if the element can be flipped, false otherwise.

#### Since

2021.2

### `P:Autodesk.Revit.DB.SpotDimension.LeaderShoulderPosition`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpotDimension.LeaderShoulderPosition`

#### Summary

Position of spot dimension's leader shoulder point.

#### Remarks

Setting of this property also affects LeaderEndPosition and TextPosition.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Dimension must have leader.
-or-
Dimension's leader must have shoulder.
-or-
Thrown when:
SpotDimension style type is SpotSlope.Using equality formula.Dimension style is ordinate.
-or-
The dimension is a SpotSlope or has no leader or leader has no shoulder.

#### Since

2021.1

### `P:Autodesk.Revit.DB.SpotDimension.LeaderHasShoulder`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpotDimension.LeaderHasShoulder`

#### Summary

True is dimension has leader with shoulder, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Dimension must have leader.
-or-
Thrown when:
SpotDimension style type is SpotSlope.Using equality formula.Dimension style is ordinate.
-or-
The dimension is a SpotSlope or has no leader.

#### Since

2021.1

### `P:Autodesk.Revit.DB.SpotDimension.SpotDimensionType`

Member kind: property
Symbol: `Autodesk.Revit.DB.SpotDimension.SpotDimensionType`

#### Summary

The dimension style of this dimension.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

### `T:Autodesk.Revit.DB.SpotDimension`

Member kind: type
Symbol: `Autodesk.Revit.DB.SpotDimension`

#### Summary

Object representing various types of SpotDimension

### `M:Autodesk.Revit.DB.Lighting.SphericalLightDistribution.#ctor(Autodesk.Revit.DB.Lighting.SphericalLightDistribution)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.SphericalLightDistribution.#ctor(Autodesk.Revit.DB.Lighting.SphericalLightDistribution)`

#### Summary

Creates a copy of the given spherical light distribution

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2013

### `M:Autodesk.Revit.DB.Lighting.SphericalLightDistribution.#ctor`

Member kind: method
Symbol: `Autodesk.Revit.DB.Lighting.SphericalLightDistribution.#ctor`

#### Summary

Creates a spherical light distribution object.

#### Since

2013

### `T:Autodesk.Revit.DB.Lighting.SphericalLightDistribution`

Member kind: type
Symbol: `Autodesk.Revit.DB.Lighting.SphericalLightDistribution`

#### Summary

This class encapsulates a spherical light distribution.

#### Since

2013

### `P:Autodesk.Revit.DB.Visual.Speckle.TextureAngle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Speckle.TextureAngle`

#### Summary

The property labeled "Angle" from the "Speckle" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray3d".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Speckle.TextureRealWorldOffsetZ`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Speckle.TextureRealWorldOffsetZ`

#### Summary

The property labeled "Offset Z" from the "Speckle" schema.

#### Remarks

This property is of type "AssetPropertyDistance".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Speckle.TextureRealWorldOffsetY`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Speckle.TextureRealWorldOffsetY`

#### Summary

The property labeled "Offset Y" from the "Speckle" schema.

#### Remarks

This property is of type "AssetPropertyDistance".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Speckle.TextureRealWorldOffsetX`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Speckle.TextureRealWorldOffsetX`

#### Summary

The property labeled "Offset X" from the "Speckle" schema.

#### Remarks

This property is of type "AssetPropertyDistance".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Speckle.TextureLinkTextureTransforms`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Speckle.TextureLinkTextureTransforms`

#### Summary

The property labeled "Link Transforms" from the "Speckle" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Speckle.SpeckleSize`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Speckle.SpeckleSize`

#### Summary

The property labeled "Size" from the "Speckle" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 100".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Speckle.SpeckleColor2`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Speckle.SpeckleColor2`

#### Summary

The property labeled "Color 2" from the "Speckle" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".
This property allows a connected asset.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.Speckle.SpeckleColor1`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.Speckle.SpeckleColor1`

#### Summary

The property labeled "Color 1" from the "Speckle" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".
This property allows a connected asset.

#### Since

2018.1

### `T:Autodesk.Revit.DB.Visual.Speckle`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.Speckle`

#### Summary

A static class that provides access to the property names that appear in the Speckle visual asset schema.

#### Since

2018.1

### `M:Autodesk.Revit.DB.Analysis.SpatialFieldManager.IsTextTypeIdValid(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Document)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldManager.IsTextTypeIdValid(Autodesk.Revit.DB.ElementId,Autodesk.Revit.DB.Document)`

#### Summary

Verify if text type id is valid.

#### Parameter `textTypeId`

Text type id to be validated.

#### Parameter `doc`

Document for which %textTypeId% is validated.

#### Returns

True if text type id is valid, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.SpatialFieldManager.GetRegisteredResults`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldManager.GetRegisteredResults`

#### Summary

Returns an array of indices of all registered results

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.SpatialFieldManager.SetResultSchema(System.Int32,Autodesk.Revit.DB.Analysis.AnalysisResultSchema)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldManager.SetResultSchema(System.Int32,Autodesk.Revit.DB.Analysis.AnalysisResultSchema)`

#### Summary

Sets a new value for an existing result schema in the result registry

#### Parameter `idx`

Index of registered result schema

#### Parameter `resultSchema`

Result schema replacing the existent one

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

idx refers to non-existent result schema
-or-
name of resultSchema is not unique in view

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.SpatialFieldManager.GetResultSchema(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldManager.GetResultSchema(System.Int32)`

#### Summary

Returns result schema by index

#### Parameter `idx`

Index of registered result schema

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

idx refers to non-existent result schema

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.SpatialFieldManager.RegisterResult(Autodesk.Revit.DB.Analysis.AnalysisResultSchema)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldManager.RegisterResult(Autodesk.Revit.DB.Analysis.AnalysisResultSchema)`

#### Summary

Registers result and assigns it a unique result index

#### Parameter `resultSchema`

Result schema to be registered

#### Returns

Unique index assigned to the result

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

name of resultSchema is not unique in view

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.SpatialFieldManager.IsResultSchemaNameUnique(System.String,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldManager.IsResultSchemaNameUnique(System.String,System.Int32)`

#### Summary

Verify the uniqueness of the name among all registered result schemas.

#### Parameter `name`

Name to verify uniqueness of.

#### Parameter `resultIndexToSkip`

Index of result (e.g. to be replaced) which names should not count for uniqueness; negative number means nothing is excluded from comparison.

#### Returns

True if name is unique, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.SpatialFieldManager.SetMeasurementDescriptions(System.Collections.Generic.IList{System.String})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldManager.SetMeasurementDescriptions(System.Collections.Generic.IList{System.String})`

#### Summary

Sets Descriptions for all measurements

#### Parameter `measurementDescriptions`

Array of measurement descriptions.
The lengths of the array must be equal to the number of measurements set during creation of SpatialFieldManager.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

measurementDescriptions lengths is not equal to the number of measurements set during creation of SpatialFieldManager

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.SpatialFieldManager.SetMeasurementNames(System.Collections.Generic.IList{System.String})`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldManager.SetMeasurementNames(System.Collections.Generic.IList{System.String})`

#### Summary

Sets Names for all measurements

#### Parameter `measurementNames`

Array of measurement names. All names in the array must be unique.
The lengths of the array must be equal to the number of measurements set during creation of SpatialFieldManager.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

measurementNames contains duplicate names or its lengths is not equal to the number of measurements set during creation of SpatialFieldManager

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.SpatialFieldManager.GetMaximum(System.Int32,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldManager.GetMaximum(System.Int32,System.Boolean)`

#### Summary

Calculates the maximum value for all primitives

#### Parameter `resultIndex`

Index of result schema

#### Parameter `rawValue`

If true returned value is NOT multiplied by the current result's units multiplier, otherwise it IS

#### Returns

Resulting maximum value

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

Thrown when current measurement is >= the number of measurements for at least one primitive

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.SpatialFieldManager.GetMinimum(System.Int32,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldManager.GetMinimum(System.Int32,System.Boolean)`

#### Summary

Calculates the minimum value for all primitives

#### Parameter `resultIndex`

Index of result schema

#### Parameter `rawValue`

If true returned value is NOT multiplied by the current result's units multiplier, otherwise it IS

#### Returns

Resulting minimum value

#### Exception `T:Autodesk.Revit.Exceptions.InapplicableDataException`

Thrown when current measurement is >= the number of measurements for at least one primitive

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.SpatialFieldManager.GetLegend`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldManager.GetLegend`

#### Summary

Returns legend element or NULL

#### Returns

The legend element or NULL

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.SpatialFieldManager.Clear`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldManager.Clear`

#### Summary

Clear all analysis results managed by this manager object

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.SpatialFieldManager.UpdateSpatialFieldPrimitive(System.Int32,Autodesk.Revit.DB.Analysis.FieldDomainPoints,Autodesk.Revit.DB.Analysis.FieldValues,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldManager.UpdateSpatialFieldPrimitive(System.Int32,Autodesk.Revit.DB.Analysis.FieldDomainPoints,Autodesk.Revit.DB.Analysis.FieldValues,System.Int32)`

#### Summary

Populates analysis results data (or replaces the existing data) in the existing primitive identified by the unique index

#### Parameter `idx`

Unique index identifying the primitive

#### Parameter `fieldDomainPoints`

Set of domain points.
If the new set of domain points is supplied, all previously supplied domain points and field values for all results are removed from the primitive.
If %fieldDomainPoints% is `null` only fieldValues are updated

#### Parameter `fieldValues`

Set of data values.
Number of values in fieldValues must coincide with the number of points in fieldDomainPoints

#### Parameter `resultIndex`

Unique index identifying the result schema

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

idx refers to non-existent primitive
-or-
fieldValues has incorrect number of measurements in ValueAtPoint objects
-or-
fieldDomainPoints has inconsistent type
-or-
resultIndex refers to non-existent result schema

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentsInconsistentException`

fieldDomainPoints and fieldValues have inconsistent number of points

#### Since

2012

### `M:Autodesk.Revit.DB.Analysis.SpatialFieldManager.RemoveSpatialFieldPrimitive(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldManager.RemoveSpatialFieldPrimitive(System.Int32)`

#### Summary

Removes analysis results primitive identified by the unique index

#### Parameter `idx`

Unique index identifying the primitive

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

idx refers to non-existent primitive

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.SpatialFieldManager.AddSpatialFieldPrimitive(Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.Transform)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldManager.AddSpatialFieldPrimitive(Autodesk.Revit.DB.Curve,Autodesk.Revit.DB.Transform)`

#### Summary

Creates empty analysis results primitive associated with a curve and a transform.

#### Parameter `curve`

Curve to be associated with the primitive.
%curve% does NOT correspond to actual Revit geometry, i.e. it cannot be associated with reference;
otherwise the other overload of the method must be used (taking "reference" as the input)

#### Parameter `trf`

Conformal Transform to be applied to %curve%.

#### Returns

Unique index of primitive for future references

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The input curve points to a helical curve and is not supported for this operation.
-or-
Argument trf is not a conformal transform (see property Revit::DB::Transform::IsConformal)

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.SpatialFieldManager.AddSpatialFieldPrimitive(Autodesk.Revit.DB.Face,Autodesk.Revit.DB.Transform)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldManager.AddSpatialFieldPrimitive(Autodesk.Revit.DB.Face,Autodesk.Revit.DB.Transform)`

#### Summary

Creates empty analysis results primitive associated with a face and a transform.

#### Remarks

This method accepts a reference to a model face, and a transform to be applied to
that face, allowing the display of analytical results on faces which are not
strictly a part of the Revit model.

This method should not be used if the transform is the identity transform,
i.e. the intent is to display results on a face which is part of the Revit model.
In that case, use the overload of this method which accepts
a reference.

If the input face is from the geometry of a symbol, the face will be considered to be
in the location specified by its symbol geometry. If your intention is to transform the face
relative to its location in the instance, your input transform must consist of the instance's
transform left multiplied by the extra transform to get the results you expect.

#### Parameter `face`

Face to be associated with the primitive

#### Parameter `trf`

Conformal Transform to be applied to %face%

#### Returns

Unique index of primitive for future references

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

trf is not conformal.

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.SpatialFieldManager.AddSpatialFieldPrimitive(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Analysis.SpatialFieldPrimitiveHideMode)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldManager.AddSpatialFieldPrimitive(Autodesk.Revit.DB.Reference,Autodesk.Revit.DB.Analysis.SpatialFieldPrimitiveHideMode)`

#### Summary

Creates an empty analysis results primitive associated with a reference, with the option to control how the reference element is hidden.

#### Remarks

There can be multiple primitives associated with one reference, normally they would be shown with different results.
However this is justified only if they have different sets of domain points.
Otherwise one primitive can be used to display values for different results.

#### Parameter `reference`

Reference pointing to the curve or face to be associated with the primitive

#### Parameter `hidingMode`

The mode used to hide the original model element

#### Returns

Unique index of primitive for future references

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

reference points to neither face nor curve

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2013

### `M:Autodesk.Revit.DB.Analysis.SpatialFieldManager.AddSpatialFieldPrimitive(Autodesk.Revit.DB.Reference)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldManager.AddSpatialFieldPrimitive(Autodesk.Revit.DB.Reference)`

#### Summary

Creates an empty analysis results primitive associated with a reference.

#### Remarks

There can be multiple primitives associated with one reference, normally they would be shown with different results.
However this is justified only if they have different sets of domain points.
Otherwise one primitive can be used to display values for different results.

#### Parameter `reference`

Reference pointing to the curve or face to be associated with the primitive

#### Returns

Unique index of primitive for future references

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

reference points to neither face nor curve

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.SpatialFieldManager.AddSpatialFieldPrimitive`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldManager.AddSpatialFieldPrimitive`

#### Summary

Creates empty analysis results primitive not associated with any geometry element

#### Returns

Unique index of primitive for future references

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.SpatialFieldManager.GetSpatialFieldManager(Autodesk.Revit.DB.View)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldManager.GetSpatialFieldManager(Autodesk.Revit.DB.View)`

#### Summary

Retrieves manager object for the given view or returns NULL

#### Parameter `view`

View for which manager object is retrieved

#### Returns

Manager object for the view passed in the argument

#### Since

2011

### `M:Autodesk.Revit.DB.Analysis.SpatialFieldManager.CreateSpatialFieldManager(Autodesk.Revit.DB.View,System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldManager.CreateSpatialFieldManager(Autodesk.Revit.DB.View,System.Int32)`

#### Summary

Factory method - creates manager object for the given view

#### Parameter `view`

View for which manager object is created or retrieved

#### Parameter `numberOfMeasurements`

Total number of measurements in the calculated results.
This number defines the length of value arrays in ValueAtPoint objects

#### Returns

Manager object for the view passed in the argument

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

numberOfMeasurements is less than one

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

View is not allowed to display analysis results or a manager object for this view already exists

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.SpatialFieldManager.LegendShowDescription`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldManager.LegendShowDescription`

#### Summary

If true legend contains analysis description.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.SpatialFieldManager.LegendShowConfigurationName`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldManager.LegendShowConfigurationName`

#### Summary

If true legend contains analysis configuration name.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.SpatialFieldManager.LegendTextTypeId`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldManager.LegendTextTypeId`

#### Summary

Stores element id of text associated with common (result-independent) part of legend in view.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.SpatialFieldManager.ResultsVisibleInView`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldManager.ResultsVisibleInView`

#### Summary

Enables analysis results visibility in the view.

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.SpatialFieldManager.UseRangeForAllMeasurements`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldManager.UseRangeForAllMeasurements`

#### Summary

Governs how minimum and maximum values (the data range) are calculated.

#### Remarks

If true the data range is calculated from all measurements.
Otherwise the data range is calculated from the current measurement only.

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.SpatialFieldManager.CurrentMeasurement`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldManager.CurrentMeasurement`

#### Summary

Stores the currently displayed measurement

#### Remarks

Must be in the range from 0 to (numberOfMeasurements - 1)

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

When setting this property: measurement is not in the range from 0 to (number of measurements - 1)

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.SpatialFieldManager.LegendPosition`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldManager.LegendPosition`

#### Summary

Stores current position of analysis results legend element in view

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

When setting this property: A non-optional argument was null

#### Since

2012

### `P:Autodesk.Revit.DB.Analysis.SpatialFieldManager.NumberOfMeasurements`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldManager.NumberOfMeasurements`

#### Summary

Stores the total number of measurements

#### Remarks

This number defines the length of value arrays in ValueAtPoint objects

#### Since

2011

### `P:Autodesk.Revit.DB.Analysis.SpatialFieldManager.AllowInteractiveSettings`

Member kind: property
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldManager.AllowInteractiveSettings`

#### Summary

If true interactive settings dialog and pick deletion are allowed.

#### Remarks

Note that SpatialFieldManager cannot be deleted if this property is set to false.

#### Since

2021

### `T:Autodesk.Revit.DB.Analysis.SpatialFieldManager`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldManager`

#### Summary

Exposes all API for an external analysis application.
Its primary role is creation, deletion and modification of SpatialFieldElement elements.

#### Since

2011

### `T:Autodesk.Revit.DB.Analysis.SpatialFieldPrimitiveHideMode`

Member kind: type
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldPrimitiveHideMode`

#### Summary

Defines modes which can be used by a SpatialFieldPrimitive to hide the original referenced element.

#### Since

2013

#### Since

2013

### `F:Autodesk.Revit.DB.Analysis.SpatialFieldPrimitiveHideMode.HideWholeElement`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldPrimitiveHideMode.HideWholeElement`

#### Summary

Hide the whole referenced element.

### `F:Autodesk.Revit.DB.Analysis.SpatialFieldPrimitiveHideMode.HideOnlyReference`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldPrimitiveHideMode.HideOnlyReference`

#### Summary

Hide only the referenced face or curve.

### `F:Autodesk.Revit.DB.Analysis.SpatialFieldPrimitiveHideMode.HideNone`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldPrimitiveHideMode.HideNone`

#### Summary

Do not hide any piece of the original model element.

### `F:Autodesk.Revit.DB.Analysis.SpatialFieldPrimitiveHideMode.Default`

Member kind: field
Symbol: `Autodesk.Revit.DB.Analysis.SpatialFieldPrimitiveHideMode.Default`

#### Summary

For ColoredSurface display style, hide only the referenced face passed at the primitive creation time.
For DeformedShape display style, hide only the referenced face or curve passed at the primitive creation time.

### `M:Autodesk.Revit.DB.Edge.ComputeDerivatives(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Edge.ComputeDerivatives(System.Double)`

#### Summary

Returns the vectors describing the edge at the specified parameter.

#### Parameter `parameter`

The parameter to be evaluated.

#### Returns

The transformation containing a tangent vector, derivative of tangent vector, and bi-normal vector.

#### Remarks

The following is the meaning of the transformation members:
Origin is the point on the edge (equivalent to Evaluate);BasisX is the tangent vector (the first derivative);BasisY is the second derivative;BasisZ is the bi-normal vector (tangent x normal).Normal and bi-normal are zero if the edge is straight at the point.
None of the vectors are normalized.

### `P:Autodesk.Revit.DB.Edge.ApproximateLength`

Member kind: property
Symbol: `Autodesk.Revit.DB.Edge.ApproximateLength`

#### Summary

Returns the approximate length of the edge.

#### Remarks

Estimates the length of the edge by adding together tessellated segments,
Will underestimate when the surface is curved.

### `M:Autodesk.Revit.DB.Edge.GetEndPointReference(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Edge.GetEndPointReference(System.Int32)`

#### Summary

Returns a stable reference to the start or the end point of the edge.

#### Parameter `index`

Use 0 for the start point; 1 for the end point.

#### Returns

Reference to the point or `null` if reference cannot be obtained.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the specified index is not 0 or 1.

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Thrown when the object is internally marked as read-only in the setter.

### `P:Autodesk.Revit.DB.Edge.Reference`

Member kind: property
Symbol: `Autodesk.Revit.DB.Edge.Reference`

#### Summary

Returns a stable reference to the edge.

#### Remarks

This value is if the corresponding geometry object does not permit referencing.

### `M:Autodesk.Revit.DB.Edge.GetCurveUV(System.Int32,Autodesk.Revit.DB.Transform2D)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Edge.GetCurveUV(System.Int32,Autodesk.Revit.DB.Transform2D)`

#### Summary

Calculate and transform a 2D curve that represents the edge in the uv-parameter plane of one of the edge's faces.
The output curve's direction will follow the parametric direction of the edge, not the topological
direction of the edge on the given face.

#### Remarks

Use of this function is preferred over using GetCurveUV(int index) and then transforming the curve, as the latter approach may yield a less accurate result.

#### Parameter `index`

The index of the face (0 or 1).

#### Parameter `transform`

Transformation to apply to the curve.

#### Returns

If successful, returns the calculated and transformed CurveUV, `null` otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the specified index is not 0 or 1.

#### Since

2021

### `M:Autodesk.Revit.DB.Edge.GetCurveUV(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Edge.GetCurveUV(System.Int32)`

#### Summary

Calculate a 2D curve that represents the edge in the uv-parameter plane of one of the edge's faces.
The output curve's direction will follow the parametric direction of the edge, not the topological
direction of the edge on the given face.

#### Parameter `index`

The index of the face (0 or 1).

#### Returns

If successful, returns the calculated CurveUV, `null` otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the specified index is not 0 or 1.

#### Since

2021

### `M:Autodesk.Revit.DB.Edge.IsFlippedOnFace(Autodesk.Revit.DB.Face)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Edge.IsFlippedOnFace(Autodesk.Revit.DB.Face)`

#### Summary

Determines if this edge's topological direction on the Face is opposite to its parametric direction.

#### Parameter `face`

The face with respect to which the direction is considered. Must belong to the edge.

#### Remarks

Outer edge loops on a Face are oriented counter-clockwise with respect to the Face's orientation,
and inner loops are oriented clockwise. The topological direction of an edge on a face means the direction
in which the edge's loop is being traversed.

#### Returns

true if this edge's topological direction on the Face is opposite to its parametric direction, false if the topological direction agrees with the parametric direction.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the specified face is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the specified face is not one of the faces for this edge.

#### Since

2021

### `M:Autodesk.Revit.DB.Edge.IsFlippedOnFace(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Edge.IsFlippedOnFace(System.Int32)`

#### Summary

Determines if this edge's topological direction on the Face is opposite to its parametric direction.

#### Parameter `index`

The index of the face (0 or 1).

#### Remarks

Outer edge loops on a Face are oriented counter-clockwise with respect to the Face's orientation,
and inner loops are oriented clockwise. The topological direction of an edge on a face means the direction
in which the edge's loop is being traversed.

#### Returns

true if this edge's topological direction on the Face is opposite to its parametric direction, false if the topological direction agrees with the parametric direction.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

Thrown when the specified index is not 0 or 1.

#### Since

2021

### `M:Autodesk.Revit.DB.Edge.AsCurveFollowingFace(Autodesk.Revit.DB.Face)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Edge.AsCurveFollowingFace(Autodesk.Revit.DB.Face)`

#### Summary

Returns a curve that corresponds to this edge as oriented in its topological direction on the specified face.

#### Parameter `faceForDir`

Specifies the face, on which the curve will follow the topological direction of the edge.

#### Remarks

Evaluating the edge using EvaluateOnFace gives the same result as evaluating the curve returned by AsCurveFollowingFace with a normalized
curve parameter. When a Hermite spline is returned, the two evaluated points will be approximately equal.

#### Returns

It can be an Arc, Line, or HermiteSpline.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

Thrown when the specified faceForDir is `null` .

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

Thrown when the specified faceForDir is not one of the faces for this edge.

### `M:Autodesk.Revit.DB.Edge.AsCurve`

Member kind: method
Symbol: `Autodesk.Revit.DB.Edge.AsCurve`

#### Summary

Returns a curve that corresponds to the edge's parametric orientation.

#### Returns

It can be an Arc, Line, or HermiteSpline.

### `M:Autodesk.Revit.DB.Edge.EvaluateOnFace(System.Double,Autodesk.Revit.DB.Face)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Edge.EvaluateOnFace(System.Double,Autodesk.Revit.DB.Face)`

#### Summary

Evaluates a parameter on the edge to produce UV coordinates on the face.

#### Parameter `param`

The parameter to be evaluated, in [0,1].

#### Parameter `face`

The face on which to perform the evaluation. Must belong to the edge.

### `M:Autodesk.Revit.DB.Edge.Evaluate(System.Double)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Edge.Evaluate(System.Double)`

#### Summary

Evaluates a parameter on the edge.

#### Parameter `param`

The parameter to be evaluated, in [0,1].

### `M:Autodesk.Revit.DB.Edge.TessellateOnFace(Autodesk.Revit.DB.Face)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Edge.TessellateOnFace(Autodesk.Revit.DB.Face)`

#### Summary

Returns a polyline approximation to the edge in UV parameters of the face.

#### Parameter `face`

The face on which to perform the tessellation. Must belong to the edge.

#### Remarks

Tolerance of approximation is defined internally by Revit to be adequate for
display purposes.

### `M:Autodesk.Revit.DB.Edge.Tessellate`

Member kind: method
Symbol: `Autodesk.Revit.DB.Edge.Tessellate`

#### Summary

Returns a polyline approximation to the edge.

#### Remarks

Tolerance of approximation is defined internally by Revit to be adequate for
display purposes.

### `M:Autodesk.Revit.DB.Edge.GetFace(System.Int32)`

Member kind: method
Symbol: `Autodesk.Revit.DB.Edge.GetFace(System.Int32)`

#### Summary

Returns one of the two faces that meet at the edge.

#### Parameter `index`

The index of the face (0 or 1).

#### Since

2014

### `T:Autodesk.Revit.DB.Edge`

Member kind: type
Symbol: `Autodesk.Revit.DB.Edge`

#### Summary

An edge of a 3d solid.

#### Remarks

Edges are defined by intersections of surfaces that form faces of the solid.
They have arbitrary parameterization that is normalized to [0,1].

### `M:Autodesk.Revit.DB.SolidSolidCutUtils.SplitFacesOfCuttingSolid(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SolidSolidCutUtils.SplitFacesOfCuttingSolid(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element,System.Boolean)`

#### Summary

Causes the faces of the cutting element where it intersects the element it is cutting to be split or unsplit.

#### Remarks

There must be a cut between the input elements.

#### Parameter `first`

The solid being cut or the cutting solid

#### Parameter `second`

The solid being cut or the cutting solid

#### Parameter `split`

True to split the faces of intersection, false to unsplit them.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

There is no solid-solid cut between the input elements.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Unable to split or unsplit faces of cutting solid

#### Since

2011

### `M:Autodesk.Revit.DB.SolidSolidCutUtils.CutExistsBetweenElements(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element,System.Boolean@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SolidSolidCutUtils.CutExistsBetweenElements(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element,System.Boolean@)`

#### Summary

Checks that if there is a solid-solid cut between two elements.

#### Parameter `first`

The solid being cut or the cutting solid.

#### Parameter `second`

The solid being cut or the cutting solid.

#### Parameter `firstCutsSecond`

If the return value of this function is true, this indicates which element is the cutting element from the pair.
True if the first solid cuts the second one, false if the second solid cuts the first one.

#### Returns

True if there is a solid-solid cut between the input elements, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.SolidSolidCutUtils.IsElementFromAppropriateContext(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SolidSolidCutUtils.IsElementFromAppropriateContext(Autodesk.Revit.DB.Element)`

#### Summary

Validates that the element is from an appropriate document.

#### Remarks

Currently an element from either a project document, conceptual model, pattern based curtain panel, or adaptive component family
may participate in solid-solid cuts.

#### Parameter `element`

The solid to be cut or the cutting solid.

#### Returns

True if the element is from an appropriate document for solid-solid cuts, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.SolidSolidCutUtils.GetSolidsBeingCut(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SolidSolidCutUtils.GetSolidsBeingCut(Autodesk.Revit.DB.Element)`

#### Summary

Get all the solids which are cut by the input element.

#### Parameter `element`

The input element.

#### Returns

The ids of the solids which are cut by the input element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.SolidSolidCutUtils.GetCuttingSolids(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SolidSolidCutUtils.GetCuttingSolids(Autodesk.Revit.DB.Element)`

#### Summary

Gets all the solids which cut the input element.

#### Parameter `element`

The input element.

#### Returns

The ids of the solids which cut the input element.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.SolidSolidCutUtils.CanElementCutElement(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.CutFailureReason@)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SolidSolidCutUtils.CanElementCutElement(Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.CutFailureReason@)`

#### Summary

Verifies if the cutting element can add a solid cut to the target element.

#### Parameter `cuttingElement`

The cutting element.

#### Parameter `cutElement`

The element to be cut.

#### Parameter `reason`

The reason that the cutting element cannot add a solid cut to the cut element.

#### Returns

True if the cutting element can add a solid cut to the target element, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentOutOfRangeException`

A value passed for an enumeration argument is not a member of that enumeration

#### Since

2011

### `M:Autodesk.Revit.DB.SolidSolidCutUtils.IsAllowedForSolidCut(Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SolidSolidCutUtils.IsAllowedForSolidCut(Autodesk.Revit.DB.Element)`

#### Summary

Validates that the element is eligible for a solid-solid cut.

#### Remarks

The element must be solid and must be a GenericForm, GeomCombination, or a FamilyInstance.

#### Parameter `element`

The solid to be cut or the cutting solid.

#### Returns

True if the input element can participate in a solid-solid cut. False otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.SolidSolidCutUtils.RemoveCutBetweenSolids(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SolidSolidCutUtils.RemoveCutBetweenSolids(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element)`

#### Summary

Removes the solid-solid cut between the two elements if it exists.

#### Parameter `document`

The document containing the two elements

#### Parameter `first`

The solid being cut or the cutting solid.

#### Parameter `second`

The solid being cut or the cutting solid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2011

### `M:Autodesk.Revit.DB.SolidSolidCutUtils.AddCutBetweenSolids(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element,System.Boolean)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SolidSolidCutUtils.AddCutBetweenSolids(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element,System.Boolean)`

#### Summary

Adds a solid-solid cut for the two elements with the option to control splitting of faces of the cutting solid.

#### Parameter `document`

The document containing the two elements.

#### Parameter `solidToBeCut`

The solid to be cut.

#### Parameter `cuttingSolid`

The cutting solid.

#### Parameter `splitFacesOfCuttingSolid`

True to split faces of cutting solid where it intersects the solid to be cut, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element must be in a project document or in a conceptual model, pattern based curtain panel, or adaptive component family.
-or-
The element does not meet the condition that it must be solid and must be a GenericForm, GeomCombination, or a FamilyInstance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to add solid-solid cut for the two elements.

#### Since

2011

### `M:Autodesk.Revit.DB.SolidSolidCutUtils.AddCutBetweenSolids(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SolidSolidCutUtils.AddCutBetweenSolids(Autodesk.Revit.DB.Document,Autodesk.Revit.DB.Element,Autodesk.Revit.DB.Element)`

#### Summary

Adds a solid-solid cut for the two elements.

#### Remarks

This utility will split faces of cutting solid by default.

#### Parameter `document`

The document containing the two elements.

#### Parameter `solidToBeCut`

The solid to be cut.

#### Parameter `cuttingSolid`

The cutting solid.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The element must be in a project document or in a conceptual model, pattern based curtain panel, or adaptive component family.
-or-
The element does not meet the condition that it must be solid and must be a GenericForm, GeomCombination, or a FamilyInstance.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

Failed to add solid-solid cut for the two elements.

#### Since

2011

### `T:Autodesk.Revit.DB.SolidSolidCutUtils`

Member kind: type
Symbol: `Autodesk.Revit.DB.SolidSolidCutUtils`

#### Summary

Exposes utilities which can cause one solid to cut another.

#### Remarks

These utilities are applicable for the generic forms, geometry combinations and family instances in conceptual model,
pattern based curtain panel, or adaptive component families, and family instances which are permitted to participate in
joining in projects. Thus, for example, a beam cannot cut a wall (as the wall is not a family instance) in projects. Nor
can a steel beam participate in cutting another family (because steel beams do not participate in joining).

#### Since

2011

### `T:Autodesk.Revit.DB.CutFailureReason`

Member kind: type
Symbol: `Autodesk.Revit.DB.CutFailureReason`

#### Summary

The reason why a solid-solid cut cannot be created.

#### Since

2012

#### Since

2012

### `F:Autodesk.Revit.DB.CutFailureReason.CutNotAppropriateForElements`

Member kind: field
Symbol: `Autodesk.Revit.DB.CutFailureReason.CutNotAppropriateForElements`

#### Summary

The cut is not appropriate for the two elements.

### `F:Autodesk.Revit.DB.CutFailureReason.OppositeCutExists`

Member kind: field
Symbol: `Autodesk.Revit.DB.CutFailureReason.OppositeCutExists`

#### Summary

The target element has already cut the cutting element.

### `F:Autodesk.Revit.DB.CutFailureReason.CutAlreadyExists`

Member kind: field
Symbol: `Autodesk.Revit.DB.CutFailureReason.CutAlreadyExists`

#### Summary

The cutting element has already cut the target element.

### `F:Autodesk.Revit.DB.CutFailureReason.CutAllowed`

Member kind: field
Symbol: `Autodesk.Revit.DB.CutFailureReason.CutAllowed`

#### Summary

Yes, the cutting element can add a cut to the target element.

### `P:Autodesk.Revit.DB.Visual.SolidGlass.CommonTintColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.SolidGlass.CommonTintColor`

#### Summary

The property labeled "Tint Color" from the "SolidGlass" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.SolidGlass.CommonTintToggle`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.SolidGlass.CommonTintToggle`

#### Summary

The property labeled "Tint" from the "SolidGlass" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.SolidGlass.SolidglassBumpAmount`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.SolidGlass.SolidglassBumpAmount`

#### Summary

The property labeled "Amount" from the "SolidGlass" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 2".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.SolidGlass.SolidglassBumpMap`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.SolidGlass.SolidglassBumpMap`

#### Summary

The property labeled "Image" from the "SolidGlass" schema.

#### Remarks

This property is of type "AssetPropertyReference" and will only contain a reference to a connected image.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.SolidGlass.SolidglassBumpEnable`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.SolidGlass.SolidglassBumpEnable`

#### Summary

The property labeled "Type" from the "SolidGlass" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "SolidglassBumpEnableType".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.SolidGlass.SolidglassGlossiness`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.SolidGlass.SolidglassGlossiness`

#### Summary

The property labeled "Roughness" from the "SolidGlass" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 1".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.SolidGlass.SolidglassRefractionIor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.SolidGlass.SolidglassRefractionIor`

#### Summary

The property labeled "Refraction" from the "SolidGlass" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0.01, 5".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.SolidGlass.SolidglassReflectance`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.SolidGlass.SolidglassReflectance`

#### Summary

The property labeled "Reflectance" from the "SolidGlass" schema.

#### Remarks

This property is of type "AssetPropertyDouble" within the range of "0, 1".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.SolidGlass.SolidglassColorByObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.SolidGlass.SolidglassColorByObject`

#### Summary

The property labeled "Custom Color" from the "SolidGlass" schema.

#### Remarks

This property is of type "AssetPropertyBoolean".

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.SolidGlass.SolidglassTransmittanceCustomColor`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.SolidGlass.SolidglassTransmittanceCustomColor`

#### Summary

The property labeled "Custom Color" from the "SolidGlass" schema.

#### Remarks

This property is of type "AssetPropertyDoubleArray4d".
This property allows a connected asset.

#### Since

2018.1

### `P:Autodesk.Revit.DB.Visual.SolidGlass.SolidglassTransmittance`

Member kind: property
Symbol: `Autodesk.Revit.DB.Visual.SolidGlass.SolidglassTransmittance`

#### Summary

The property labeled "Color" from the "SolidGlass" schema.

#### Remarks

This property is of type "AssetPropertyInteger" with accepted values in the enumerated type "SolidglassTransmittanceType".

#### Since

2018.1

### `T:Autodesk.Revit.DB.Visual.SolidGlass`

Member kind: type
Symbol: `Autodesk.Revit.DB.Visual.SolidGlass`

#### Summary

A static class that provides access to the property names that appear in the SolidGlass visual asset schema.

#### Since

2018.1

### `M:Autodesk.Revit.DB.SketchEditScope.IsSketchEditingSupportedForSketchBasedElement(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SketchEditScope.IsSketchEditingSupportedForSketchBasedElement(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks whether the element supports sketch editing.

#### Remarks

This method checks if the element supports edit to all its sketches.
If you want to check if this element supports edit to a particular sketch please use `M:Autodesk.Revit.DB.SketchEditScope.IsSketchEditingSupported(Autodesk.Revit.DB.ElementId)` .

#### Parameter `elemId`

The element id to be checked.

#### Returns

True if element supports sketch editing, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.SketchEditScope.IsElementWithoutSketch(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SketchEditScope.IsElementWithoutSketch(Autodesk.Revit.DB.ElementId)`

#### Summary

Validates if an element can have a sketch but currently does not.

#### Parameter `elementId`

The element id to be checked.

#### Returns

True if the element doesn't have a sketch, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2023

### `M:Autodesk.Revit.DB.SketchEditScope.IsSketchEditingSupported(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SketchEditScope.IsSketchEditingSupported(Autodesk.Revit.DB.ElementId)`

#### Summary

Checks whether sketch can be edited.

#### Remarks

This method checks if this particular sketch can be edited.
If you want to check if all sketches of an element can be edited please use `M:Autodesk.Revit.DB.SketchEditScope.IsSketchEditingSupportedForSketchBasedElement(Autodesk.Revit.DB.ElementId)`

#### Parameter `sketchId`

The element id of sketch.

#### Returns

True if sketch can be edited, false otherwise.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `M:Autodesk.Revit.DB.SketchEditScope.StartWithNewSketch(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SketchEditScope.StartWithNewSketch(Autodesk.Revit.DB.ElementId)`

#### Summary

Starts a sketch edit mode for an element which, at this moment, doesn't have a sketch.

#### Remarks

Some surface Revit elements (like some Walls or some Analytical Elements) does not have a valid sketch all the time so in order to edit them, we have to create a valid sketch first.
The application will need to start a transaction to actually make changes to the element.
SketchEditScope can only be started when there is no transaction active, thus it does not
work for commands running in automatic transaction mode.

#### Parameter `elementId`

The Element without sketch to be edited.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId elementId already has a sketch defined.
-or-
Element does not support sketch editing.
-or-
Failed to start the sketch edit mode.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This SketchEditScope is not permitted to start at this moment for one of the following possible reasons:
The document is in read-only state, or the document is currently modifiable,
or there already is another edit mode active in the document.
-or-
Cannot create sketch.

#### Since

2023

### `M:Autodesk.Revit.DB.SketchEditScope.Start(Autodesk.Revit.DB.ElementId)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SketchEditScope.Start(Autodesk.Revit.DB.ElementId)`

#### Summary

Starts a sketch edit mode.

#### Remarks

The application will need to start a transaction to actually make changes to the Sketch element.
SketchEditScope can only be started when there is no transaction active, thus it does not
work for commands running in automatic transaction mode.

#### Parameter `sketchId`

The Sketch element to be edited.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

The ElementId sketchId does not represent a Sketch.
-or-
Sketch does not support editing.
-or-
Failed to start the sketch edit mode.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Exception `T:Autodesk.Revit.Exceptions.InvalidOperationException`

This SketchEditScope is not permitted to start at this moment for one of the following possible reasons:
The document is in read-only state, or the document is currently modifiable,
or there already is another edit mode active in the document.

#### Since

2022

### `M:Autodesk.Revit.DB.SketchEditScope.#ctor(Autodesk.Revit.DB.Document,System.String)`

Member kind: method
Symbol: `Autodesk.Revit.DB.SketchEditScope.#ctor(Autodesk.Revit.DB.Document,System.String)`

#### Summary

Instantiates a SketchEditScope object.

#### Parameter `document`

The document for which this SketchEditScope is going to be used.

#### Parameter `transactionName`

The name that will appear in the Undo menu in Revit after the SketchEditScope is successfully committed.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentException`

document is not a primary document, it is a linked document.
-or-
document is not a project document.
-or-
transactionName is an empty string.

#### Exception `T:Autodesk.Revit.Exceptions.ArgumentNullException`

A non-optional argument was null

#### Since

2022

### `T:Autodesk.Revit.DB.SketchEditScope`

Member kind: type
Symbol: `Autodesk.Revit.DB.SketchEditScope`

#### Summary

A SketchEditScope allows an application to create and maintain an editing session for a Sketch.

#### Remarks

Start/end of a SketchEditScope will start/end a transaction group. After a SketchEditScope is started, an application can start transactions and edit the sketch.
Individual transactions the application creates inside SketchEditScope will not appear in the undo menu.
All transactions committed during the edit mode will be merged into a single one which will bear the given name passed into SketchEditScope constructor.

#### Since

2022

### `M:Autodesk.Revit.DB.PolymeshFacet.ToString`

Member kind: method
Symbol: `Autodesk.Revit.DB.PolymeshFacet.ToString`

#### Summary

Returns formatted string showing (V1, V2, V3) with values formatted as regular integers

### `P:Autodesk.Revit.DB.PolymeshFacet.IsValidObject`

Member kind: property
Symbol: `Autodesk.Revit.DB.PolymeshFacet.IsValidObject`

#### Summary

Specifies whether the .NET object represents a valid Revit entity.

#### Remarks

This property is always True for a polymesh facet.

#### Returns

True if the API object holds a valid Revit native object, false otherwise.

### `M:Autodesk.Revit.DB.PolymeshFacet.GetVertices`

Member kind: method
Symbol: `Autodesk.Revit.DB.PolymeshFacet.GetVertices`

#### Summary

Returns the three vertices that define this facet

#### Remarks

A container with three integers (indices of the vertices) is returned.

### `P:Autodesk.Revit.DB.PolymeshFacet.V3`

Member kind: property
Symbol: `Autodesk.Revit.DB.PolymeshFacet.V3`

#### Summary

The third vertex of the facet

#### Value

An index of a vertex of a polymesh.
