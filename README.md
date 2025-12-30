<a id="readme-top"></a>

[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![Unlicense License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]

<div>
   <h1>Flappy Bird (Unity Mini Project)</h1>
   <p align="center"> 
    <img src="Assets/Assets/flappy-bird.png" alt="flappy-bird" width="800"/>
   </p><br>
    <a href="#about-the-project"><strong>Explore the docs »</strong></a>
  </p>
</div>
<details>
   <summary>Table of Contents</summary>
   <ol>
      <li><a href="#about-the-project">About The Project</a></li>
      <li><a href="#file-structure">File Structure</a></li>
      <li><a href="#getting-started">Getting Started</a></li>
      <li><a href="#usage">Usage & Testing</a></li>
      <li><a href="#roadmap">Roadmap</a></li>
      <li><a href="#challenges">Challenges</a></li>
      <li><a href="#contact">Contact</a></li>
   </ol>
</details>
<h2 id="about-the-project">About The Project</h2>
<p>
    This project is a <strong>Flappy Bird–inspired 2D game</strong> built with <strong>Unity</strong> as a mini learning project.
    The goal was to understand core Unity fundamentals such as <strong>player physics, collision detection, obstacle spawning, scoring, and basic game state management</strong> using C#.
</p>
<p>
    The project was developed while following and learning from <strong>Game Maker’s Toolkit</strong>'s <em>"The Unity Tutorial For Complete Beginners"</em>, with additional experimentation and customization.
</p>
<div align="right"><a href="#readme-top">↑ Back to Top</a></div>

<h2 id="built-with">Built With</h2>
<ul>
   <li><strong>Unity (2D)</strong></li>
   <li><strong>C#</strong></li>
   <li>Unity Physics (Rigidbody2D, Colliders)</li>
   <li>Unity UI System</li>
</ul>
<div align="right"><a href="#readme-top">↑ Back to Top</a></div>

<h2 id="file-structure">File Structure</h2>
<pre>
    flappy-bird/                        # Root Project Directory 
    ├── .git/                           # Git version control metadata 
    ├── .vs/                            # Visual Studio configuration files 
    ├── .vscode/                        # VS Code workspace settings 
    ├── Assets/                         # Primary Game Content 
    │   ├── Audio/                      # Sound effects (flap, score, hit) 
    │   ├── Materials/                  # Sprite and object shaders 
    │   ├── Prefabs/                    # Reusable templates (Pipe, Bird) 
    │   ├── Scenes/                     # Game levels (MainMenu, GameScene) 
    │   ├── Scripts/                    # C# Logic 
    │   │   ├── BirdScript.cs           # Bird physics and input 
    │   │   ├── PipeMove.cs             # Leftward movement logic 
    │   │   ├── PipeSpawner.cs          # Dynamic pipe instantiation 
    │   │   ├── LogicScript.cs          # Scoring and Game Over system 
    │   │   └── PipeMiddleScript.cs     # Score trigger detection 
    │   └── Settings/                   # Project-specific internal settings 
    ├── Library/                        # Unity's local cache (do not track in Git) 
    ├── Logs/                           # Editor and build log files 
    ├── Packages/                       # Unity Registry dependencies 
    ├── ProjectSettings/                # Input, Tag, and Physics configurations 
    ├── Flappy Bird.sln                 # Visual Studio Solution file 
    ├── README.md                       # Project documentation 
    └── Flappy Bird Tutorial.pdf        # Project documentation/guide 
</pre>
<div align="right"><a href="#readme-top">↑ Back to Top</a></div>

<h2 id="getting-started">Getting Started</h2>
<h3>Prerequisites</h3>
<ul>
   <li><strong>Unity Hub</strong></li>
   <li>Unity Editor (recommended LTS version)</li>
</ul>
<h3>Installation & Deployment</h3>
<ol>
   <li>Clone the repository.</li>
   <li>Open <strong>Unity Hub</strong></li>
   <li>Click <strong>Open Project</strong></li>
   <li>Select the cloned project folder</li>
   <li>Open the main scene and press ▶ Play</li>
</ol>
<div align="right"><a href="#readme-top">↑ Back to Top</a></div>

<h2 id="usage">Usage & Testing</h2>
<ul>
    <li>Press <strong>Spacebar</strong> to flap</li>
    <li>Avoid pipes and obstacles</li>
    <li>Score increases as you pass pipes</li>
    <li>Game resets on collision</li>
</ul>
<p>Testing focused on:</p>
<ul>
    <li>Collision accuracy</li>
    <li>Pipe spawning intervals</li>
    <li>Player physics balance</li>
    <li>Score consistency</li>
</ul>
<div align="right"><a href="#readme-top">↑ Back to Top</a></div>

<h2 id="roadmap">Project Roadmap</h2>
<ul>
   <li>[x] Add start & game-over screens</li>
   <li>[x] Add sound effects & background music</li>
   <li>[x] High score persistence</li>
   <li>[ ] Mobile touch support</li>
   <li>[ ] Difficulty scaling over time</li>
</ul>
<div align="right"><a href="#readme-top">↑ Back to Top</a></div>

<h2 id="challenges-faced">Challenges</h2>
<table>
   <thead>
      <tr>
         <th>Challenge</th>
         <th>Solution</th>
      </tr>
   </thead>
   <tbody>
      <tr>
         <td><strong>Unstable player movement & gravity balance</strong></td>
         <td>Adjusted <code>Rigidbody2D</code> gravity scale and flap force values to achieve responsive yet fair controls.</code></td>
      </tr>
      <tr>
         <td><strong>Inconsistent pipe spawning</strong></td>
         <td>Implemented timed spawning with randomized Y-axis positions while keeping a fixed X-axis offset to maintain consistent difficulty.</td>
      </tr>
      <tr>
         <td><strong>Collision detection triggering unexpectedly</strong></td>
         <td>Refined collider sizes and positions to better match sprites and prevent false collisions.</td>
      </tr>
      <tr>
         <td><strong>Score incrementing multiple times per pipe</strong></td>
         <td>Added a dedicated scoring trigger and logic to ensure each pipe is counted only once.</td>
      </tr>
      <tr>
         <td><strong>Game state reset issues after game over</strong></td>
         <td>Centralized game state handling to properly reset player position, score, and obstacles on restart.</td>
      </tr>
   </tbody>
</table>
<div align="right"><a href="#readme-top">↑ Back to Top</a></div>

<h2 id="contact">Contact</h2>
<p>Tan Si Kai - <a href="https://linkedin.com/in/si-kai-tan">LinkedIn</a></p>
<p>Project Link: <a href="https://github.com/ShenLoong99/Flappy-Bird">Flappy Bird Repo</a></p>
<div align="right"><a href="#readme-top">↑ Back to Top</a></div>

<h2 id="contact">Acknowledgements</h2>
<p>
    Special thanks to <strong>Game Maker's Toolkit</strong> for the excellent tutorial:<br>
    <a href="https://www.youtube.com/watch?v=XtQMytORBmM"><em>The Unity Tutorial For Complete Beginners</em></a><br>
    This project was built as a hands-on learning exercise inspired by that video
</p>
<div align="right"><a href="#readme-top">↑ Back to Top</a></div>

[contributors-shield]: https://img.shields.io/github/contributors/ShenLoong99/Flappy-Bird.svg?style=for-the-badge
[contributors-url]: https://github.com/ShenLoong99/Flappy-Bird/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/ShenLoong99/Flappy-Bird.svg?style=for-the-badge
[forks-url]: https://github.com/ShenLoong99/Flappy-Bird/network/members
[stars-shield]: https://img.shields.io/github/stars/ShenLoong99/Flappy-Bird.svg?style=for-the-badge
[stars-url]: https://github.com/ShenLoong99/Flappy-Bird/stargazers
[issues-shield]: https://img.shields.io/github/issues/ShenLoong99/Flappy-Bird.svg?style=for-the-badge
[issues-url]: https://github.com/ShenLoong99/Flappy-Bird/issues
[license-shield]: https://img.shields.io/github/license/ShenLoong99/Flappy-Bird.svg?style=for-the-badge
[license-url]: https://github.com/ShenLoong99/Flappy-Bird/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/https://linkedin.com/in/si-kai-tan
