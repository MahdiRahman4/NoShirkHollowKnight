# NoShirkHollowKnight

A Hollow Knight mod that replaces religious language, keeping the game's lore intact while removing theological framing.

> [!WARNING]
> **Mods do not work with the latest patch of Hollow Knight (as of April 23, 2025).**
> You need to downpatch to version **1.5.78.11833**. To do this:
> 1. Right-click Hollow Knight in Steam
> 2. Click **Properties**
> 3. Go to **Betas**
> 4. Select version **1.5.78.11833**

## What it changes

| Original | Replacement |
|----------|-------------|
| God / Gods | Elder / Elders |
| Godhome | Elderhome |
| Godseeker | Seeker |
| Pantheon / Pantheons | Gauntlet / Gauntlets |
| Soul / Souls | Essence / Essences |
| Divine | Ancient |
| Sacred | Hallowed |
| Holy | Pure |
| Blessed | Gifted |
| Worship / Worshipped | Revere / Revered |
| Prayer / Prayers / Pray | Call / Calls |
| Temple / Temples | Hall / Halls |
| Altar / Altars | Pedestal / Pedestals |
| Ritual / Rituals | Ceremony / Ceremonies |

## Requirements

- Hollow Knight (Steam)
- [Lumafly Mod Manager](https://github.com/TheMulhima/Lumafly/releases)
- Hollow Knight Modding API (install via Lumafly)

## Installation

### Via Lumafly (recommended)
Search for **NoShirkHK** in Lumafly and click Install.

### Manual
1. Download `NoShirkHollowKnight.dll` from the [latest release](../../releases/latest)
2. Place it in:
   ```
   Hollow Knight\hollow_knight_Data\Managed\Mods\NoShirkHK\
   ```
   alongside a `mod.json` file (included in the release)
3. Launch the game — the mod name will appear in the top-left of the main menu

## Uninstalling

Disable or uninstall through Lumafly, or delete the `NoShirkHK` folder from your `Mods` directory.

## Compatibility

Works with the base game and Godmaster DLC. Should be compatible with most other mods since it only intercepts text rendering and does not modify game logic.

## Building from source

1. Open `NoShirkHollowKnight.sln` in Visual Studio 2022
2. Add references to `Assembly-CSharp.dll`, `UnityEngine.CoreModule.dll`, and `MMHOOK_Assembly-CSharp.dll` from your Hollow Knight `Managed` folder
3. Build → copy `bin/Debug/NoShirkHollowKnight.dll` to your `Mods\NoShirkHK\` folder
