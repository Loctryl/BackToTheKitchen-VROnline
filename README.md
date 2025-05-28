# Back To The Kitchen

## Context
This is a student project with a team of 4 people, during 2 weeks (April 2023).
The goal was to learn about making VR game using Unity. We decided to make a multiplayer cooking game, pretty similar to what already exists.

## Gameloop
In this kitchen, you have 6 different ingredients : breads, tomatoes, cheeses, meats, onions and lettuces. There’s a stock supplies for each one. This restaurant only makes burgers. A screen displays no more than 4 orders, with the composition of each burger and the time remaining to serve it.
Each ingredient needs to be cut, or cooked for the meat, with the provided knifes. Once cut, you have to assemble the burger following the order. To cook the meat, there’re 2 pans and 4 burners. A timer displays above the meat when placed in a pan which is on a burner. 

When the burger is ready, it only needs to be placed on a dish to be served on the counter.

## Technical part
We started with the XR Interaction Toolkit as the base controller. As the motion sickness is an important subject to take care when making a VR games, we made 2 different ways of moving : teleporting or slow walking with a strong vignette effect. Also, we added the possibility to change the height of the camera.
Every setting can be change at any moment in the game with some world interactions (3D buttons and levers placed on the wall).
The game is multiplayer, so you have to connect to a room and join your partner. 
We used [Photon Unity Networking](https://www.photonengine.com/pun) to manage all the network part.

Once in game, each player is represented with 2 hands and a head with a chef’s hat. 
The orders are generated randomly, but with bread because it still needs to be a burger, with at least 2 up to 5 ingredients.

We used a lot of sockets to place properly the ingredients on each other, the meat on the pan, the pan on the burner and the dish on the counter.


Thank you yo ***Kay Lousberg*** for the asset pack : https://www.kaylousberg.com/game-assets/restaurant-bits


## Screenshots 
![image5](https://github.com/Loctryl/BackToTheKitchen-VROnline/assets/91985442/027980b5-9a60-4d1e-9562-10aa701641a1)
![image4](https://github.com/Loctryl/BackToTheKitchen-VROnline/assets/91985442/9ec09e0c-e945-4489-9cee-0357d2e04942)
![image3](https://github.com/Loctryl/BackToTheKitchen-VROnline/assets/91985442/a0888501-4db2-43fb-96a9-4f091b1784e0)
![image2](https://github.com/Loctryl/BackToTheKitchen-VROnline/assets/91985442/709a543d-2951-4c71-873c-97d3805a4652)
![image1](https://github.com/Loctryl/BackToTheKitchen-VROnline/assets/91985442/2ea50068-6dab-49d4-a85a-273564aea2fb)
![image](https://github.com/Loctryl/BackToTheKitchen-VROnline/assets/91985442/b202ab53-63cb-43e3-9406-2349aa6025fa)
