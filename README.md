Avoider (Unity Demo)

Demo
Play the game here: https://trunghhnd.itch.io/avoider

Overview
**Avoider** is a simple arcade-style game developed using Unity.  
The objective is to survive as long as possible by dodging incoming enemies and achieving the highest score.

This project was created as a portfolio demo to showcase basic Unity development skills.

---

Gameplay
- Control your ship and avoid incoming enemies
- Survive as long as possible
- The difficulty increases over time
- Collision with enemies results in Game Over

---

Controls
- **A / D** or **Left / Right Arrow Keys** → Move left/right

---

Features
- Fast-paced arcade gameplay
- Simple and responsive controls
- Endless survival mechanics
- Increasing difficulty over time
- Retro-inspired visuals

---

Technologies Used
- Unity Engine
- C#

---

Screenshots

<img width="685" height="382" alt="image" src="https://github.com/user-attachments/assets/3c7066f9-48c3-46bb-ac71-da6c076551f8" />


---

Project Structure
Assets/Scripts/`
  - `PlayerController.cs` → Handle player movement & input
  - `Enemy.cs` → Enemy behavior (falling, deactivate for pooling)
  - `Spawner.cs` → Spawns enemies using object pool

- `Assets/Prefabs/`
  - `Enemy.prefab` → Enemy object template

- `Assets/Scenes/`
  - `GamePlayScene.unity` → Main gameplay scene
  - `MenuScene.unity` → Menu game scene
---

Highlights
- Implemented enemy spawning system
- Designed player movement system
- Optimized performance using object pooling

Author
- Trung

---

Assets
- https://ravenmore.itch.io/space-shooter-assets-space-rage

---

Notes
This is a prototype/demo project created for portfolio purposes.  
It is not intended as a full commercial product.
