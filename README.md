# Jagat Wars

Jagat Wars is a 2D top-down shooter that takes players into intense battles on the sky. You pilot a combat spaceship, tasked with taking down waves of enemy ships. With fast-paced shooting mechanics, agile maneuvers, and increasingly challenging enemies, the game tests your reflexes, precision, and strategy as you fight for survival and dominance in sky.

## Play Game
The game was built using Unity Engine. Play the game -. 
<br>

## Developer
Ngakan Nyoman Arya Vedantha (Game Programmer)
<br>

## Built Time
This project was built for 6 days.
<br>

---

## Features & Scripts 

<table>
  <tr>
    <th>Feature</th>
    <th>Description</th>
    <th>Main Scripts</th>
  </tr>
  <tr>
    <td><b>Battle System</b></td>
    <td>Handling autoshoot for player and enemy, enemy spawner, explosive when die, player weapon, movement.</td>
    <td><code>Autoshoot.cs</code>, <code>ExplosionEffect.cs</code>, <code>Moveable.cs</code>, <code>PlayerController.cs</code>, <code>UpgradeWeapon</code></td>
  </tr>
  <tr>
    <td><b>UI</b></td>
    <td>Handling backgorund for game by autoscrollling, UI for coin and health.</td>
    <td><code>ScrollBackground.cs</code>, <code>LifeUI.cs</code>, <code>CoinUI.cs</code></td>
  </tr>
  <tr>
    <td><b>Health and coin System</b></td>
    <td>Manage health and coin for player, when player get hit and destroy enemy.</td>
    <td><code>ContainItems.cs</code></td>
  </tr>
  <tr>
    <td><b>Enemy</b></td>
    <td>Manage enemy such as spawner, making enemy always facing player also moving toward player.</td>
    <td><code>EnemySpawner.cs</code>, <code>LookAtPlayer.cs</code>, <code>MoveTowardPlayer.cs</code></td>
  </tr>
</table>

---

## Files description

```
├── JagatWars                         # Contain everything needed for JagatWars to works.
   ├── Assets                         # Contains every assets that have been worked with unity to create the game like the scripts and the art.
      ├── Sprites                     # Contains all the game art like the sprites, background, even the character.
      ├── Prefabs                     # Contains every reusable object that have been used in the game.
      ├── Sounds                      # Contains every sound used for the game like music and sound effects.
      ├── Scripts                     # Contains all scripts needed to make the gane get goings like PlayerMovement scripts.
      ├── Scenes                      # Contains all scenes that exist in the game for it to interconnected with each other like MainMenu, Gameplay.
```
<br>

## Game controls

The following controls are bound in-game, for gameplay and testing.

| Key Binding       | Function          |
| ----------------- | ----------------- |
| W,A,S,D           | Standard movement |

<br>


## Project Goal

This game was created as a **learning project** to experiment with Unity.

---
