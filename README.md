# PentaSaber
A remake of PentaToggle, the old ChromaToggle game mode and old PentaMaul mode. Each saber has an alternate color activated by pressing trigger. Optional neutral blocks are inserted between transitions.

## Current version and general note
Built for 1.22.1, works up to 1.27.0<br/>
This is my build off of the work that Zingabopp had done to restore this mod. I am not normally a modder, nor do I fully understand everything here all the time, but I have always loved these game modes from the days of ChromaToggle when it was around and have been missing it ever since. After I found out about this remake I just had to make sure to get it working and not let it be left behind. Now I feel that it would be nice if others got to enjoy the mod again, and so here is me restoring what I can.

## Current known issues
-Grip and secondary button may not work. This isn't actually an issue. If you are on SteamVR you have to add those buttons with legacy settings. They just need to be added because while they aren't added Steam blocks the button input.<br/>
-Block colors might not change sometimes. This is likely do to chroma and can be fixed by setting chroma block changing to off<br/>
-For some reason the colors in game start as Penta saber colors and then after hitting the first block revert to games saber color override/base colors. Maul will stay this way so it is suggested to set the override to the same as your primary colors. Penta and Septa for some reason will fix after switching the color<br/>
-Room rotation is applied oddly. If you use beat saber's room rotation, pentamaul will have the lower sabers placed incorrectly.. Not sure how to fix and you should orient using a different method. Will attempt to make a fix in the future<br/>

## Required mods
This mod should only require that you have BSIPA 4.2.2+, BS Utils 1.12.0+, BeatSaberMarkupLanguage 1.6.6+, and SiraUtil 3.0.0+

## Suggested settings for config
I have had my settings for neutralBufferNumber set to 0. What this does is disable gray notes completely which I think actually makes the color changes easier to deal with if you're worried about messing up your flow

## Configuration
All settings are available in the multiplayer/single player mods tab. For more extensive adjustments, settings can be adjusted in `UserData\PentaSaber.json`

![20220811225911_1](https://user-images.githubusercontent.com/51224222/184283666-4898ec5e-de23-4d7d-ab5a-60c75583b3d5.jpg)
![20220811225925_1](https://user-images.githubusercontent.com/51224222/184283672-2e14a176-fcab-4a3b-adeb-ae8a568b92c7.jpg)
![20220811230004_1](https://user-images.githubusercontent.com/51224222/184283682-724207db-59ab-409f-b3a7-8666ab9b06b1.jpg)
