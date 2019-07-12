# AventureTime
## ToDo
1. Create basic scene (No Change Scene) class to store values requird (e.G ID, text target scene Id)
2. Create other basic scenes (Choices, Skill check, item check and gold check)
3. Turn above into an inheritence structure
## Summary
A take on the Fighting Fantasy Gamebooks (Specifically Armies of Death)
## Requirements
### Player Character Stats / Inv
Player has 3 differant 'stats'
* Skill
* Stamina
* Luck

Player has a stack of gold pieces, plus a bag full of treasures.

### Player Army
Players have an army of troops. They are made of the following races:
* Warriors
* Dwarfs
* Elves
* Knights
* Other (Just a collection of random troop types?)

### Scenes from a hat
Types:

No change - Onto next scene
Choose Y/N - One scene if pass one if fail
Skill check (potentially multiple skills either/or + and) - One scene if pass one if fail
Item check (+cost guess?!?)- One scene if pass one if fail
Gold check - Once scene if pass (and update gold) one if fail
Skill change - Onto next scene
Army change - Onto next scene
Ded (RIP)

## Player Creation
(Note these initial values should be marked as 'max' values. Very rare to go back over your max except on special occasions)

### Skill
Roll 1 die
Add 6
Fin.

### Stamina
Roll 2 dice
Add 12
Fin.

### Luck
Roll 1 die
Add 6
Fin.

## Single Combat
1 v 1 battles happen often, this is how they work:

Take the creates skill and stamina

Roll 2 dice for the creature, add it's skill score. This is their *attack strength*

Roll 2 dice for player, add players skill score. This is the players *attack strength*

If players attack strength is higher than the creature, it is wounded. 

Vice versa for the enemy creature

If a draw, no wounds. Both player and creature must reroll.

Whoever got wounded, subtract 2 from their stamina.

Rince and repeat until someone has run out of stamina.

## Luck
Some scenes allow for the player to attempt to use their luck to influence the scenario

Roll 2 dice. If the number is equal to or less than the players luck score you hve been lucky

Anything else and you have been unlucky.

This is how you 'test' you luck. When you test your luck, you must subtract 1 from the players luck score

### Luck in single combat

If you have wounded an enemy, you can attempt to make it a serious wound by testing the players luck.

If the player is successful, they do 2 extra damage. If unsuccessful, deal 1 less damage to the enemy

If hte player is wounded and get lucky. Take 1 less damage else take 1 extra damage.

## Restoring Skill, Stamina and Luck
### Skill
This does not change much. Only really changes if you equp a weapon

### Stamina
Changes all the time.

You rest on some scenes, but can't go over max unless specifically stated

### Luck
Awarded at random times during scenes