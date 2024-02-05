<h1>IGDO Item Drop Character Controller Walkthrough</h1>
<h3>Creating Project</h3>
<p>In this workshop we will learn how to create characters and have them move left and right using player input.</p>

<p>First, we will open Unity Hub and create a new project and select 2D Core</p>
<p>I will name mine Item_Drop_CharacterController, but I recommend naming yours Item_Drop</p></br>

![image](https://github.com/Migs/Item_Drop_CharacterController/assets/59187230/717260ea-fb4a-4bba-8797-0ab582bb59c8)

<p>After you have selected 2D core and named the project, Select Create Project and wait for Unity to initialize the game.</p>

![image](https://github.com/Migs/Item_Drop_CharacterController/assets/59187230/6aea0e54-9ba0-4269-b55f-ca98653b0ab1)

<h>Downloading Unity Input System</h>
<p>First we need to install the new input system from unity.</p>

<p>To do this:</p>
<p>Window -> Package Manager -> Packages: Unity Registry -> Search Input System -> Install and Restart the Project</p>

![Install_Input](https://github.com/Migs/Item_Drop_CharacterController/assets/59187230/eb1e4ba5-296c-4b15-892d-ac07d1b2e987)

<h3>Creating Character</h3>
<p>To create the character you want to right click in the hierarchy -> 2D Object -> Sprites -> Capsule</p></br>
<p>Rename the capsule to "Player"</p>

![create_player](https://github.com/Migs/Item_Drop_CharacterController/assets/59187230/8378de59-ddde-4f61-ad38-48895ecf46a1)

<p>Move the character to the bottom of the screen by selecting the Move Tool and draging you character to the bottom.</p>

![move_character](https://github.com/Migs/Item_Drop_CharacterController/assets/59187230/c1e04af7-1a89-4684-9176-ad4b9341b8a2)

<h3>Adding Movement</h3>
<p>Next we want to add a RigidBody2D to the character and remove the gravity impacting it, limit the movement in the y direction, and limit the rotation in the z direction</p></br>

<p>To add a RigidBody2D:</p>
<p>Click Player -> Add Component -> Search RigidBody2D </p>

<p>To removed gravity, freeze rotation, and y movement:</p>
<p>Change Gravity Scale to 0 -> Open Constraints -> Click Freezer Rotation z -> Click Freeze Position y</p>

![add_rigid_body](https://github.com/Migs/Item_Drop_CharacterController/assets/59187230/a2489c9d-0ad1-4ac6-a212-f7e3d0c33589)

<h3>Creating Character Inputs</h3>
<p>Our next step is to create a player input schema. We can do this by adding the Player Input component to the player</p>
<p>We want to delete everything that is not associated with ad and left arrow right arrow. The player is locked to moving along the x axis.</p>

<p>To do this:</p>
<p>Click on player -> Add Player Input Component -> Create Actions -> Save as PlayerInputs</p>

![PlayerInput](https://github.com/Migs/Item_Drop_CharacterController/assets/59187230/5054d5f5-159c-4abb-9551-6aa21676a4d2)

<p>You will get a pop-up, you want to delete everything that isnt a, d, right arrow, left arrow.</p>

![DeleteInputs](https://github.com/Migs/Item_Drop_CharacterController/assets/59187230/93c6c166-3633-422b-898b-d9057ca4a57f)

<p>At this point you should have the input system fully integrated and can copy the scripts from this link:</p>
https://github.com/Migs/Item_Drop_CharacterController/tree/main/Assets/Scripts

<p>You want to add the script as a component to the character.</p>
