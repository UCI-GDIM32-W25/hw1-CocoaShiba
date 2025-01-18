[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity
Objects:
- UI:
	- Seeds planted shows how many seeds the player has planted
	- Seeds remaining shows how many seeds the player has available
- Player:
	- Movement with the WASD keys
	- Player can plant plants with space bar
	- Planting seeds effects the UI; seeds planted increments while seeds remaining decrements
	- The player cannot plant seeds after they have used all of them
	- Has a bunny sprite to represent player
	- Player can still move even if no seeds remain
- Plants:
	- Has a plant sprite to represent plant
	- The plant appears in the front of player layer when planted 
	- The plant has no physics or movement, unlike the player

## Devlog
All player controls, such as movement with the WASD keys and planting seeds with the space key, can be created within the Update function of the Player.cs script. The Update function constantly checks for an input, and depending on what keys are pressed, the player object either places a plant prefab (using the PlantSeed function) or is moved in a certain direction. The PlantCountUI.cs script can also be hooked up to the Player.cs script, which allows the player's controls to directly influence the UI shown on screen using the UpdateSeeds function. For now, this is only used to display the number of seeds the player has as well as the number of seeds planted; planting seeds decrements the number of seeds remaining and increments the number of seeds planted. As for the plant prefab, the object is quite simple, only requiring a sprite to show the picture of a plant. The plant has no other functionality, so it does not require a script. 

Just for fun, I added y-sorting to the project, so that the player either appears "in front of" or "behind" the plants depending on the y-value of the player's transform. Y-sorting will definitely be useful for any top-down games I want to implement in the future.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites


## Prof comments
Good job clearly linking the plans from your break-down to the code you wrote. :)

> Just for fun, I added y-sorting to the project

This looks great!

Please consider formatting your break-down activities with the hyphen '-' symbol as suggested above. Also, make sure your activity and Devlog are under the correct header, and remove the prompt text. This will make it a lot easier for me to read. See the [README formatting guide here](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax).
