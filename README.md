
# 🎮 3D Character Controller

<p align="center">
  <strong>A simple 3D character controller project developed in Unity.</strong>
</p>

---

## 🌟 Project Overview

This project is a **3D character controller developed using Unity and C#**.

The player can move around a 3D environment, walk, run, jump, and control the camera using the mouse.

The project demonstrates basic concepts of **3D game development, character movement, physics, camera control, and animation**.

---

## ✨ Features

| Feature                | Description                                   |
| ---------------------- | --------------------------------------------- |
| 🚶 Movement            | Move using **W, A, S, D**                     |
| 🏃 Running             | Hold **Left Shift** to run                    |
| 🦘 Jumping             | Press **Space** to jump                       |
| 🖱️ Camera             | Control the camera using the mouse            |
| 🎥 Third-Person Camera | Camera follows the player                     |
| 🎭 Animation           | Idle, walking, running and jumping animations |
| 🌄 3D Environment      | Character can move across the terrain         |
| ⚙️ Physics             | Rigidbody-based character movement            |

---

## 🎮 Controls

| Key            | Action              |
| -------------- | ------------------- |
| **W**          | Move Forward        |
| **S**          | Move Backward       |
| **A**          | Move Left           |
| **D**          | Move Right          |
| **Left Shift** | Run                 |
| **Space**      | Jump                |
| **Mouse**      | Rotate Camera       |
| **Esc**        | Unlock Mouse Cursor |

---

## 🛠️ Technologies Used

<p align="center">

🎮 **Unity 6** <br>
💻 **C#** <br>
🎭 **Unity Animator** <br>
⚙️ **Rigidbody Physics** <br>
🌍 **Unity Terrain**

</p>

---

## 📂 Project Structure

```text
3D-Character-Controller/
│
├── 📁 Assets/
│   ├── 📁 Scenes/
│   ├── 📁 Scripts/
│   ├── 📁 Models/
│   ├── 📁 Materials/
│   └── 📁 Animations/
│
├── 📁 Packages/
│
├── 📁 ProjectSettings/
│
└── 📄 README.md
```

---

## 🧩 Main Scripts

### 🎮 PlayerController.cs

The `PlayerController` script handles:

* Player movement
* Walking
* Running
* Jumping
* Character rotation
* Animation control
* Rigidbody movement

### 🎥 CameraFollow.cs

The `CameraFollow` script handles:

* Third-person camera
* Mouse-controlled camera rotation
* Camera following
* Camera distance and height

---

## 🎭 Animation System

The Animator uses a `Speed` parameter to control movement animations:

```text
Speed = 0     → Idle
Speed = 0.5   → Walk
Speed = 1     → Run
```

A `Jump` trigger is used to play the jumping animation.

---

## 🌄 Environment

The project includes a 3D environment where the character can:

* Walk across flat ground
* Move over slopes
* Run around the environment
* Jump while exploring

---

## 🚀 How to Run

### 1. Clone the Repository

```bash
git clone YOUR_REPOSITORY_LINK
```

### 2. Open Unity Hub

Select:

```text
Add → Add project from disk
```

Then select the project folder.

### 3. Open the Project

Make sure you are using the appropriate **Unity 6** version.

### 4. Open the Scene

```text
Assets/Scenes/SampleScene.unity
```

### 5. Press ▶ Play

Use the keyboard and mouse to control the character.

---


## 👨‍💻 Project

**3D Character Controller**

Developed using **Unity 6 and C#** as a 3D game development project.

---

<p align="center">
  🎮 <strong>Move • Run • Jump • Explore</strong>
</p>
