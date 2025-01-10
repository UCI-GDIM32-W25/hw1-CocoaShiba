[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Put your notes from the W1L2 (Thurs, Jan 9) in-class activity here.

## Devlog
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.


Write your Devlog here!

Objects:
	UI:
		Seeds planted shows how many seeds the player has planted
		Seeds remaining shows how many seeds the player has available
	Player:
		Movement with the WASD keys
		Player can plant plants with space bar
		Planting seeds effects the UI; seeds planted increments while seeds remaining decrements
		The player cannot plant seeds after they have used all of them
		Has a bunny sprite to represent player
		Player can still move even if no seeds remain
	Plants:
		Has a plant sprite to represent plant
		The plant appears in the front of player layer when planted 
		The plant has no physics or movement, unlike the player

All player controls, such as movement with the WASD keys and planting seeds with the space key, can be created within the Update function of the Player.cs script. The Update function constantly checks for an input, and depending on what keys are pressed, the player object either places a plant prefab (using the PlantSeed function) or is moved in a certain direction. The PlantCountUI.cs script can also be hooked up to the Player.cs script, which allows the player's controls to directly influence the UI shown on screen using the UpdateSeeds function. For now, this is only used to display the number of seeds the player has as well as the number of seeds planted; planting seeds decrements the number of seeds remaining and increments the number of seeds planted. As for the plant prefab, the object is quite simple, only requiring a sprite to show the picture of a plant. The plant has no other functionality, so it does not require a script. 

Just for fun, I added y-sorting to the project, so that the player either appears "in front of" or "behind" the plants depending on the y-value of the player's transform. Y-sorting will definitely be useful for any top-down games I want to implement in the future.



## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
