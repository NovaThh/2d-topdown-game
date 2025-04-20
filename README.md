# 2d-topdown-game

# Introduction

This is my very first game project using Unity. It serves as a playground and to learn coding logic using C#; therefore, it has many flaws regarding code cleanliness and project structure. The concept revolves around a challenging underground world inhabited by relentless monsters, drawing inspiration from renowned games such as Binding of Isaac and Rogue Legacy. 

# Game Manual

## Game Control

Moving: WASD. The character can only move horizontally and vertically.

Shooting: Arrows. The character can only shoot horizontally and vertically (unlimited ammunition, 1 second of cooldown).

Placing bombs: Spacebar (unlimited ammunition, 5 seconds of cooldown). Bombs don’t deal damage to the player.

## Game mechanics

Teleporters: Each room has one teleporter that takes the player to the next room. Clearing all monsters is not mandatory; the player can proceed as soon as they find the teleporter. 

Storeroom: Appears every 5th and 9th room. This is a place where the player can get a random power-up to enhance their abilities.

Power-up item list: color-coded in order: brown-silver-blue diamond-gold-red sapphire, ranging from least effective to most effective. When the player touches an item, the item will appear in the player’s inventory slot on the screen. Use the mouse to click on it to use it.

Boss room: appears every 14th room, it is advised to keep track of the room counter in the top right corner of the player.

All rooms in the game are randomly generated, keeping the element of surprise as players cannot predict the next room's monster types, except for boss rooms and storerooms. Repetition may occur due to the nature of random generation.

# Showcase

Some short videos to showcase my game with 3 main bosses fights: https://drive.google.com/drive/folders/1PZbQnJv5AN2pBLI7WCBwdG986dB3iaTJ?usp=sharing
