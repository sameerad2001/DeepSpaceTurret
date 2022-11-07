### Deep space turret

> This is my first attempt at building a game.

- This game uses **object pooling** to optimize both enemy and projectile spawning
    - When the game begins both enemies and projectiles are spawned
    - They are then de-activated so that they do not show up in the game unless required
    - These objects can then be activated if and when required 
- The rest of the project is fairly straight forward :
    - Both the projectiles and the enemies have a script which moves them forward and destroys them when they leave the game boundary
    - If a projectiles collide with an enemy both of the game objects are de-activated
    - The game over state is triggered when the player collides with an enemy


![Demo](https://github.com/sameerad2001/DeepSpaceTurret/blob/master/Demo/DeepSpaceTurretDemo1.gif)
