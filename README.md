# DXFTemplateWinForms
Source code (C# VS 2022) of the template for DXFReader.NET WinForms Component .NET 8.0

Download DXFReader.NET WinForms Component from https://www.dxfreader.net/

Full documentation on https://www.dxfreader.net/DXFReaderNET_Help

---

## Overview

This is a **C# Windows Forms starter template** for integrating the **DXFReader.NET WinForms Component** — a commercial third-party library for reading and displaying DXF (AutoCAD Drawing Exchange Format) files. It is intended to be used as a boilerplate that developers can build on top of.

---

## Key Technologies

| Technology | Details |
|---|---|
| **Language** | C# |
| **Framework** | .NET 8.0 (Windows) |
| **UI Framework** | Windows Forms (WinForms) |
| **IDE** | Visual Studio 2022 |
| **External Library** | `DXFReaderNETWinForms.dll` — a commercial component from [dxfreader.net](https://www.dxfreader.net/) referenced via a local path |

---

## File Structure

```
DXFTemplateWinForms/
├── DXFTemplateWinForms.sln       # Visual Studio solution file
├── DXFTemplateWinForms.csproj    # Project file (targets net8.0-windows)
├── Program.cs                    # Entry point – launches Form1
├── Form1.cs                      # Main form logic (event handlers, registry)
├── Form1.Designer.cs             # Auto-generated UI layout code
├── Form1.resx                    # Resource file (icons, etc.)
├── favicon.ico                   # Application icon
└── README.md                     # Brief description with links
```

---

## How the Code is Organized

### `Program.cs`
The standard WinForms entry point. Calls `ApplicationConfiguration.Initialize()` then runs `Form1`.

### `Form1.Designer.cs` (auto-generated)
Sets up the entire UI layout programmatically via `InitializeComponent()`:
- **Menu bar** with *File*, *View*, and *?* (Help) menus
- **`DXFReaderNETControl`** — the main DXF viewer/editor control (fills the window)
- **Status bar** (bottom `ToolStrip`) showing contextual prompts
- File open/save dialogs

### `Form1.cs` (main logic)
Contains all the event handler logic:

| Feature | Implementation |
|---|---|
| **Load/Save DXF** | Uses `openFileDialog`/`saveFileDialog` → calls `dxfReaderNETControl1.ReadDXF()` / `.WriteDXF()` |
| **New drawing** | Calls `dxfReaderNETControl1.NewDrawing()` |
| **Zoom Extents** | Calls `.ZoomExtents()` |
| **Zoom Window** | Two-click interaction using a state machine (`FunctionsEnum`) → calls `.ZoomWindow(p1, p2)` |
| **Pan** | Middle-mouse-button drag → calls `.Pan()` |
| **Settings persistence** | `LoadRegistry()` / `SaveRegistry()` — reads and writes dozens of control settings (colors, display flags, plot settings, etc.) to `HKEY_CURRENT_USER\Software\DXFTemplateWinForms` |

---

## Key Design Notes

1. **External DLL dependency**: `DXFReaderNETWinForms.dll` is referenced from a relative path (`../../../DXFReaderNETWinFormsSetup/`), meaning you must install the commercial component separately before building.

2. **Settings via Windows Registry**: All user preferences (window size/position, colors, zoom, grid, OSNAP modes, print settings) are persisted to the registry — no config file or database.

3. **State machine for interaction**: Mouse interactions use a simple `FunctionsEnum` enum (`None`, `ZoomWindow1`, `ZoomWindow2`) to track multi-step operations.

4. **WCS coordinates**: Mouse events use `dxfReaderNETControl1.CurrentWCSpoint` (World Coordinate System) rather than raw screen pixels, which the DXF control handles internally.
