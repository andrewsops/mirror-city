# Mirror City

Mirror City is a Unity 3D prototype for a grounded urban life sim and syndicate-driven city game.

## Core concept

A visible city and a hidden criminal underworld sit on top of each other. The player lives in the city, survives in it, and decides whether to work with the syndicates, manipulate them, or escape the system entirely.

## Features in this prototype

- 3D player controller
- simple day/night cycle
- district and faction data model
- dynamic world event system
- save system
- HUD scaffolding
- mission scaffolding
- relationship model
- prototype bootstrap tooling

## Project structure

- `Assets/Scripts/Core` - player and core gameplay scripts
- `Assets/Scripts/Managers` - district, faction, economy, mission, event, save systems
- `Assets/Scripts/ScriptableObjects` - district, faction, and mission data
- `Assets/Scripts/UI` - HUD and UI stubs
- `Assets/Editor` - prototype bootstrap helpers

## Recommended Unity setup

- Unity 2022 LTS or 2023 LTS
- Render Pipeline: URP
- Input System package
- UI package (Unity UI)

## How to start

1. Open the project in Unity.
2. Create a new empty scene.
3. In the menu bar, run: `Mirror City > Create Prototype`
4. This creates a starter scene with:
   - a player controller
   - a day/night cycle
   - a game manager
   - a basic HUD
   - a placeholder district and faction state
5. From there, expand the design by editing the scriptable objects and city state logic.

## Prototype goals

- validate the city loop
- validate district risk and faction pressure
- create a single-district sandbox for early design
- set up a foundation for life systems, relationships, and mission structure

## Roadmap

- vertical slice: one district, one syndicate, one home, one loop
- expand with additional districts and factions
- add side jobs and dynamic city events
- add deeper reputation, heat, and relationship systems
- expand into a full social survival sandbox

## Notes

This repository is a starter codebase; it is intentionally structured to be expanded as the game grows.
