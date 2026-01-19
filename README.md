[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/7qg5CCgx)
# HW2
## Devlog

The plan I wrote for the MG2 break-down activity connects to the code I wrote because I drew out the coin prefab (which becomes a GameObject) and the penguin/player, UI, ground, and GameController GameObjects that appear in my Unity Scene. 

In my drawing, the subsection of the penguin/player details the needed actions of jumping and coin collection using collision detection with both the coins and ground GameObjects. I implemented this in the Player class and script using both the OnTriggerEnter2D (for coin collection) and OnCollisionEnter2D (for ground/jumping) methods. This informed the _isGrounded bool that was utilized in the Update() if statement that allowed the player to jump.

My plan was not really refined with the role that the GameController played, so I differed from it's note to keep track of the score in it's class and instead kept it within the Player class. I made this decision because I thought it would be more efficient to place it in the OnTriggerEnter2D method when the player collided with coins and the GameController could be more so the middle man of accessing and managing the relationship between both the UI's text and the player script (containing the amount of points) to update it.

Also, I made 1 new class that was not included in my drawing. The coin class simply held the KillSelf() method that was called by the player after colliding with coins and position detection for despawning uncollected ones that both utilized the Destroy(gameObject) method in Update(). I did this because in my drawing, there was no mention of despawning.


## Open-Source Assets
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites