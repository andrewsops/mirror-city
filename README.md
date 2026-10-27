# Mirror City

Mirror City is a Unity prototype for a grounded urban life sim and syndicate-driven city game.

## Overview

The project is intentionally structured around a single-district prototype. The core design focuses on the relationship between daily city life and the hidden criminal underworld beneath it.

## Current prototype systems

- player movement and interaction
- rough day/night cycle
- district and faction manager
- economy manager
- relationship manager
- mission scaffolding
- save system
- prototype HUD

## Prototype goals

- validate the city-life loop
- validate risk and faction pressure
- support a single-district sandbox for early development
- establish a foundation for deeper systems later

## Recommended Unity setup

- Unity 2022 LTS or 2023 LTS
- URP
- Input System
- UI Toolkit or UGUI

## Quick start

1. Open the project in Unity.
2. In the menu bar, run `Mirror City > Create Prototype`.
3. The bootstrap script creates a scene with a player, a light source, a basic HUD, and core managers.
4. Expand the world by editing the ScriptableObjects under `Assets/Scripts/ScriptableObjects` or adding new systems in the managers folder.

## Prototype structure

- `Assets/Scripts/Core` - core player logic and interaction
- `Assets/Scripts/Managers` - economy, factions, districts, time, world events, missions, save system
- `Assets/Scripts/ScriptableObjects` - data-driven design objects
- `Assets/Scripts/UI` - HUD and interface scripts
- `Assets/Editor` - bootstrap tooling

## Planned next systems

- relationship dialogues
- district-specific events
- hidden route map
- faction mission generation
- dynamic market and risk simulation
- save-game normalization
- tension and heat system for police/faction pressure

## Notes

This repository is a starter codebase for the prototype and should be extended as production continues.
