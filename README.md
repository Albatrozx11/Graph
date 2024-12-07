# Graph

This Unity project implements concepts from Catlike Coding's tutorial on [Mathematical Surfaces](https://catlikecoding.com/unity/tutorials/basics/mathematical-surfaces/). It visualizes mathematical functions dynamically in 3D space, helping explore their behavior interactively.

[Watch the Demo](https://github.com/user-attachments/assets/350b868e-e357-4400-b813-9c82d83c7956)

---

## Table of Contents

1. [Introduction](#introduction)
2. [Features](#features)
3. [Getting Started](#getting-started)
4. [Usage](#usage)
5. [Functions Implemented](#functions-implemented)
6. [Project Structure](#project-structure)
7. [Credits](#credits)
8. [License](#license)

---

## Introduction

The **Graph** project visualizes mathematical functions in Unity by creating a grid of points and transforming them using mathematical equations. This project is based on the tutorials provided by [Catlike Coding](https://catlikecoding.com/), which aim to teach Unity's scripting and math fundamentals.

This repository can be found at [Albatrozx11/Graph](https://github.com/Albatrozx11/Graph).

---

## Features

- Real-time rendering of mathematical functions.
- Animation support to visualize dynamic changes.
- Easily extensible with additional mathematical functions.
- Beginner-friendly Unity and C# code.

---

## Getting Started

### Prerequisites

- Unity Editor (2021.3 LTS or newer is recommended)
- Basic understanding of Unity and C# scripting.

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/Albatrozx11/Graph.git
2. Open the project in Unity.
3. Load the **Graph** scene to start exploring.

---

## Usage

1. **Play the Scene**: Open the Graph scene and press Play to see mathematical functions rendered dynamically.
2. **Switch Functions**: Use the drop-down menu in the Inspector to select different mathematical functions.
3. **Customize Parameters**: Modify settings like grid resolution, animation speed, or function parameters to see their effects in real-time.

---

## Functions Implemented

This project includes the following mathematical functions:

1. **Sine Wave**: Creates a classic sine wave.
2. **Multi-Sine Wave**: Combines multiple sine waves for intricate patterns.
3. **Ripple**: Generates a circular wave effect.
4. **Sphere**: Transforms points to form a sphere.
5. **Torus**: Creates a toroidal shape.

Feel free to extend this library by adding your own functions in the `FunctionsLibrary` script.

---

## Project Structure

```plaintext
Graph/
├── Assets/
│   ├── Scripts/
│   │   ├── Graph.cs             # Main script for graph generation.
│   │   ├── GraphFunction.cs     # Interface for defining functions.
│   │   ├── FunctionsLibrary.cs  # Predefined mathematical functions.
│   ├── Scenes/
│   │   ├── Graph.unity          # Main scene for visualization.
│   ├── Materials/
│   │   ├── GraphMaterial.mat    # Material used for graph points.
│   └── Prefabs/
│       ├── Point.prefab         # Prefab for a single graph point.
└── README.md                    # Project documentation.
