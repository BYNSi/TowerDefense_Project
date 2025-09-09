# TowerDefense_Project
Development Progress - June 18, 2025
Completed Tasks:
Project Setup

Created Unity project

Configured Universal Render Pipeline (URP)

Map Construction

Created and placed map cube objects for terrain and layout

Waypoint System

Implemented waypoint manager for enemy pathfinding

Added multiple waypoints for movement reference

Camera Control

Created camera controller script

Enabled WASD movement and mouse scroll zoom

Enemy Creation and Movement

Created basic enemy prefab

Implemented movement logic to follow waypoints



Development Progress - June 20, 2025
======================================

Implemented enemy path management: Enemies now follow designated waypoints and are automatically destroyed at the end of the path.

Added four enemy types with different prefabs and properties.

Developed an enemy spawner to control automatic enemy generation in waves, with customizable settings for each wave.


Development Progress– June 21, 2025
=======================================
Created Prefabs for the standard turret and its upgraded version.

Made Prefabs for the missile turret and laser turret.

Designed the turret selection UI.

Learned about Unity game development resources.

Created the data class for turrets and set up the turret data.


Development Progress – July 11, 2025
======================================

Tested turret selection

Implemented cube click and turret building

Added coin flicker animation

Created build effect animation

Development Progress – July 15, 2025
=====================================

Detected enemies entering turret range

Controlled turret shooting logic

Implemented bullet flight behavior

Handled bullet-enemy collision detection

Managed enemy destruction and explosion effects

Added turret rotation logic to face target

Development Progress – July 16-21, 2025
=========================================
Implemented selection highlight effect for cubes

Added dynamic health bars to enemies with real-time updates

Developed upgrade and construction UI with transition animations

Enabled turret upgrading and dismantling via UI controls

Created upgraded versions of all three turret types

Integrated visual effects for each turret upgrade action


Development Progress
========================================
RQ1: Under identical map and wave settings, how does Nearest versus Closest-to-Exit target selection affect leaks, completion time, win rate, and total damage?

RQ2: does an Upgrade-Focused plan (few towers, early upgrades) yield better stability and efficiency than a Spread-Focused plan (more level-1 towers, no early upgrades)?

Other parts of the paper

(1)Introduction
Background and popularity of tower defense games
Benefits of Unity in Indie Game Development
Motivation and goals of this project

(2)Project Overview

Game types and main gameplay
Introduction of function modules (map system, enemy system, turret system, UI system, etc.)
Overall development timeline(as listed above)


(3)Related Work & Comparison

List 1~2 existing tower defense games (e.g. Kingdom Rush, Plants vs Zombies)
Compare gameplay, interface design, and functional features
Describe what makes your project unique (e.g. turret upgrade UI animations, different turret types, dynamic health bars, etc.)

（4）Methodology
Controls: To isolate the variables, crucial conditions such as the map layout, enemy waves, path, starting currency, and buildable locations are held constant across all experimental runs.

For RQ1: With a fixed tower placement plan, the game was run for multiple rounds using the Nearest and Closest-to-Exit targeting algorithms, respectively.
For RQ2: With a fixed targeting algorithm, two build plans (Upgrade-Focused and Spread-Focused) were executed for multiple rounds. Both plans consumed the exact same total budget.

Data Collection:
  Win/Lose outcome
  Number of Leaks  
  Completion Time
  Total Damage and Efficiency
  
(4)Literature Review


Mizutani, W. K., Daros, V. K., & Kon, F. (2021). Software architecture for digital game mechanics: A systematic literature review. Entertainment Computing, 38, 100421. https://doi.org/10.1016/j.entcom.2021.100421

Chueca, J., Verón, J., Font, J., Pérez, F., & Cetina, C. (2023). The consolidation of game software engineering: A systematic literature review of software engineering for industry-scale computer games. Information and Software Technology, 165, 107330. https://doi.org/10.1016/j.infsof.2023.107330

Shacklett, B., Rosenzweig, L. G., Xie, Z., Sarkar, B., Szot, A., Wijmans, E., Koltun, V., Batra, D., & Fatahalian, K. (2023). An extensible, Data-Oriented architecture for High-Performance, Many-World simulation. ACM Transactions on Graphics, 42(4), 1–13. https://doi.org/10.1145/3592427

Goldstein, R., Walmsley, K., Bibliowicz, J., Tessier, A., Breslav, S., & Khan, A. (2022). Path counting for Grid-Based navigation. Journal of Artificial Intelligence Research, 74, 917–955. https://doi.org/10.1613/jair.1.13544
Hu, Y., et al. (2022). Multi-agent path finding with Temporal Jump Point Search. Proceedings of ICAPS.

Öhman, J. (2020). Procedural generation of tower defense levels. Retrieved from https://www.diva-portal.org/smash/record.jsf?pid=diva2%3A1442180&dswid=-8232

D. Hind and C. Harvey, "A NEAT Approach to Wave Generation in Tower Defense Games," 2022 International Conference on Interactive Media, Smart Systems and Emerging Technologies (IMET), Limassol, Cyprus, 2022, pp. 1-8, doi: 10.1109/IMET54801.2022.9929595.
