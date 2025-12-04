# CamSnap

CamSnap is a simple Windows application built with C# that opens your connected webcam, displays the video feed, and lets you capture still frames to disk. The app auto-detects external webcams, making it easy to switch between available devices.

## Features
- Detects internal and external webcams connected to the machine.
- Opens a live camera preview window.
- Captures and saves frames from the active webcam feed.
- Built using AForge.NET libraries for video capture.

## Getting Started
1. Open the solution file `Aforge/Aforge.sln` in Visual Studio.
2. Restore NuGet packages if prompted.
3. Build and run the solution to launch the webcam preview window.

## Usage
- Select your preferred webcam from the available list when the app starts.
- Use the capture control to save the current frame to disk.
- Captured images are stored on your local machine for later use.

## Folder Structure
- `Aforge/`: Contains the Visual Studio solution and C# project files for the application.
- `README.md`: Overview and usage information for CamSnap.

## Requirements
- Windows with a compatible webcam (internal or external).
- Visual Studio with .NET desktop development tools.
- AForge.NET video libraries (referenced in the solution).

## License
This project uses the license included with the repository.
