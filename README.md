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
  
(4)Reference


Chueca, J., Verón, J., Font, J., Pérez, F., & Cetina, C. (2023). The consolidation of game software engineering: A systematic literature review of software engineering for industry-scale computer games. Information and Software Technology, 165, 107330. https://doi.org/10.1016/j.infsof.2023.107330

Dias, D. M. P. L., Sousa, J. P. P., Barroso, B. C. V. B., & Magalhaes, I. M. B. (2022). A novel procedural content generation algorithm for tower defense games. In Proceedings of the 6th International Conference on Algorithms, Computing and Systems (ICACS ’22) (Article 9, pp. 1–7). Association for Computing Machinery. https://doi.org/10.1145/3564982.3564993

Öhman, J. (2020). Procedural generation of tower defense levels [Master’s thesis, Blekinge Institute of Technology]. DiVA portal. https://www.diva-portal.org/smash/record.jsf?pid=diva2%3A1442180
Sutoyo, R., Winata, D., Oliviani, K., & Supriyadi, D. M. (2015). Dynamic difficulty adjustment in tower defence. Procedia Computer Science, 59, 435–444. https://doi.org/10.1016/j.procs.2015.07.563

Beau, P., & Bakkes, S. (2016). Automated game balancing of asymmetric video games. In 2016 IEEE Conference on Computational Intelligence and Games (CIG) (pp. 1–8). IEEE. https://doi.org/10.1109/CIG.2016.7860432

Barbosa, M. B., Rêgo, A. B., De Medeiros, I., & Federal Institute of Education, Science and Technology of Rio Grande do Norte, Brazil. (2015). Developing games with object composition: A case study using the Unity3D platform. In Abstract [Journal-article]. https://sbgames.org/sbgames2015/anaispdf/computacao-short/147644.pdf?utm_source=chatgpt.com

Bergdahl, J., Sestini, A., & Gisslén, L. (2024). Reinforcement learning for high-level strategic control in tower defense games. In 2024 IEEE Conference on Games (CoG) (pp. 1–8). IEEE. https://doi.org/10.1109/CoG60054.2024.10645621

Hind, D., & Harvey, C. (2022). A NEAT approach to wave generation in tower defense games. In 2022 International Conference on Interactive Media, Smart Systems and Emerging Technologies (IMET) (pp. 1–8). IEEE. https://doi.org/10.1109/IMET54801.2022.9929595

Tan, T. G., Yong, Y. N., Chin, K. O., Teo, J., & Alfred, R. (2013). Automated evaluation for AI controllers in tower defense game using genetic algorithm. In Communications in Computer and Information Science (Vol. 381, pp. 135–146). Springer. https://doi.org/10.1007/978-3-642-40567-9_12

Huo, P., Shiu, S. C. K., Wang, H., & Niu, B. (2009). Application and comparison of particle swarm optimization and genetic algorithm in strategy defense game. In 2009 Fifth International Conference on Natural Computation (ICNC) (pp. 387–392). IEEE. https://doi.org/10.1109/ICNC.2009.552
Avery, P., Togelius, J., Alistar, E., & van Leeuwen, R. P. (2011). Computational intelligence and tower defence games. In 2011 IEEE Congress on Evolutionary Computation (CEC) (pp. 1084–1091). IEEE. https://doi.org/10.1109/CEC.2011.5949738

Carette, J. (2017). Implementing a family of tower defense games [Master’s thesis, McMaster University]. MacSphere. https://macsphere.mcmaster.ca/handle/11375/19763

Kumala, G. T., & Istiono, W. (2022). Comparison of Flow Field and A-Star algorithm for pathfinding in tower defense game. International Journal of Multidisciplinary Research and Analysis, 5(9), 2445–2453. https://doi.org/10.47191/ijmra/v5-i9-20

Goldstein, R., Walmsley, K., Bibliowicz, J., Tessier, A., Breslav, S., & Khan, A. (2022). Path counting for grid-based navigation. Journal of Artificial Intelligence Research, 74, 917–955. https://doi.org/10.1613/jair.1.13544

Hu, Y., Li, J., Felner, A., Cohen, L., Ma, H., Kumar, T. K. S., Koenig, S., & Sharon, G. (2022). Multi-agent path finding with Temporal Jump Point Search. arXiv. https://arxiv.org/abs/2204.09235

Shacklett, B., Rosenzweig, L. G., Xie, Z., Sarkar, B., Szot, A., Wijmans, E., Koltun, V., Batra, D., & Fatahalian, K. (2023). An extensible, data-oriented architecture for high-performance, many-world simulation. ACM Transactions on Graphics, 42(4), Article 100, 1–13. https://doi.org/10.1145/3592427
