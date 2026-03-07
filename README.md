# EllipseFractals

Interactive fractal generator using polygon roots and branching constrained by an ellipse.

## What it is
A WinForms app that generates branching fractals from a polygon's vertices. Controls allow adjusting polygon sides, recursion depth, reduction factor and branch probability. Multiple render modes (line / bezier / organic) included.

## Requirements
- Visual Studio 2026
- .NET Framework 4.7.2
- C# 7.3

## Build & run
1. Open the solution in Visual Studio.
2. Build the solution (Build > Build Solution).
3. Run (F5).

## UI controls
- `numSides` — number of polygon sides (min 2)
- `numDepth` — recursion depth
- `numReduction` — child branch length reduction (%)  
- `trackProbability` — probability a branch spawns (0–100)
- `Generate` — animate generation depth
- render mode buttons — switch drawing style

## Troubleshooting
- If the canvas is empty or controls show `0` at runtime:
  - Ensure `numSides` ≥ 2, `numReduction` > 0 and `trackProbability` > 0. If designer defaults are zero, set sensible defaults in the Designer or in the `Form1` constructor after `InitializeComponent()`:
    - `numSides.Value = 5;`
    - `numDepth.Value = 6;`
    - `numReduction.Value = 50;`
    - `trackProbability.Value = 80;`
  - Call `panelCanvas.Invalidate()` after updating parameters to force redraw.
  - Check `FractalParameters` values printed to debug output to confirm nonzero inputs.

## Notes
- Canvas center and ellipse sizes are defined in `Form1.GenerateFractal()`; adjust `CircumscribedRadius`, `EllipseA` and `EllipseB` there to change layout.
- Randomness is seeded by `RandomProvider`; for repeatable runs add an overload to seed the generator.

