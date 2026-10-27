# Mirror City

This repository is a Unity-ready starter project for a grounded urban life sim / syndicate-driven city prototype.

## What is included

The repo already contains a starter codebase for:

- 3D player controller
- interaction system
- Faction and district managers
- economy and debt system
- day/night cycle
- job loop
- world event scaffolding
- mission scaffolding
- relationship data model
- save system
- prototype HUD

## What I can and cannot do here

I can prepare the project foundation and starter scripts in this repo, but I cannot launch Unity or run the editor from this environment.

To actually run the project, you must open it in Unity on your local machine.

## How to run it locally

1. Install Unity 2022 LTS (recommended) or Unity 2023 LTS.
2. Create a new 3D Unity project using URP.
3. Clone or pull this repo into the project folder structure.
4. In Unity, open the project and import the repo contents into the `Assets` folder.
5. In the Unity menu, go to `Mirror City > Create Prototype`.
6. The editor script will create a basic prototype scene with the player, world manager, lighting, HUD, and placeholder systems.

## Recommended folder layout

- `Assets/Scripts/Core`
- `Assets/Scripts/Managers`
- `Assets/Scripts/ScriptableObjects`
- `Assets/Scripts/UI`
- `Assets/Editor`

## Prototype loop

The current prototype is deliberately focused on a single-district gameplay loop:

- player moves through a district
- player interacts with a job marker or contact
- player gains money
- player returns home
- player pays rent
- district danger and heat rise over time
- the loop repeats

This is intentionally compact and designed to validate the core city-life + underworld dynamic.

## Built systems in this repo

- `PlayerController`
- `PlayerInteraction`
- `DistrictManager`
- `FactionManager`
- `EconomyManager`
- `TimeOfDayManager`
- `CitySimulationManager`
- `JobManager`
- `WorldEventManager`
- `SaveSystem`
- `StoryManager`
- `HUDController`
- `PrototypeBootstrapper`

## Next step after setup

Once the project opens in Unity, the next phase is to create the first playable scene and test the flow:

1. Create a simple ground plane and district block.
2. Add the player and NPC markers.
3. Add a home interaction object.
4. Add the faction contact object.
5. Add a job pickup object.
6. Play the scene and test the loop.
7. Expand the game by adding more districts, hidden routes, heat, and deeper social simulation.

## Notes

This repo is a development foundation, not a full commercial game. It is intentionally designed to be expanded and iterated as production grows.
