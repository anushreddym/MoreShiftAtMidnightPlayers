# More Shift At Midnight Players

A BepInEx mod for **Shift At Midnight** that raises the lobby player limit above the vanilla cap of 3.

Only the **host** needs this mod installed, friends can join without downloading anything.

## Features

- Raises the max players allowed in a lobby (configurable, default 8)
- Extends the in-game "Max Players" dropdown so higher numbers can actually be selected
- Patches both the Steam lobby limit and the Photon Fusion networking session limit, so the setting is respected end-to-end

## Requirements

- [Shift At Midnight](https://store.steampowered.com/app/3722330/Shift_At_Midnight/) on Steam
- [BepInEx 6 (IL2CPP, x64, Bleeding Edge build)](https://builds.bepinex.dev/projects/bepinex_be)

## Installation

1. **Install BepInEx**
   - Download the BepInEx IL2CPP x64 build linked above.
   - Extract its contents directly into your game's install folder (the same folder as the game's `.exe`, find it via Steam: right-click the game → **Manage** → **Browse local files**).
   - Launch the game once through Steam to let BepInEx generate its folders, then close the game.

2. **Install this mod**
   - Download `MoreShiftAtMidnightPlayers.dll` from the [Releases](../../releases) page (or build it yourself)
   - You can also get the mod from nexusmods at: https://www.nexusmods.com/shiftatmidnight/mods/6?tab=description
   - Copy the `.dll` into `BepInEx/plugins/` inside your game folder.

3. **Launch the game**
   - just play the game 
  
## Disclaimers
   - This only changes the vanilla lobby cap, any issues with the gameplay itself are not addressed with this mod.
   - Playing with a lot of people may or may not break the game.
  
     
## Credits

Made by me for fun. I'm likely not going to update this, but if something breaks make an issue on the repository and I might fix it ¯\_(ツ)_/¯
