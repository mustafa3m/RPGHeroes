# Heroes

RPGHeroes
Project Description
RPGHeroes is a .NET console-based role-playing game (RPG) featuring four hero classes: Mage, Ranger, Rogue, and Warrior. Each class has unique attributes, equipment compatibility, and leveling systems. The game emphasizes hero progression through leveling up, equipping weapons and armor, and calculating damage based on class-specific formulas.

This project also includes unit tests for core functionality, written using xUnit, and is version-controlled with Git. 

Features
1. Hero Classes
Mage: Specializes in magic, using staves and robes.
Ranger: Uses bows and light armor for ranged attacks.
Rogue: Focuses on stealth, using daggers and leather armor.
Warrior: Wields heavy weapons and armor for physical combat.
2. Hero Attributes
Each hero class has unique attributes:

Strength
Dexterity
Intelligence
These attributes increase as the hero levels up, with bonuses varying by class.

3. Leveling System
Heroes start at level 1 and gain experience through actions.
Leveling up increases hero attributes and overall power.

5. Equipment System
Heroes can equip weapons and armor suited to their class.
Valid equipment includes:
Weapons: Staves, bows, daggers, swords, etc.
Armor: Cloth, leather, and plate.
Equipping invalid items throws custom exceptions (InvalidWeaponException, InvalidArmorException).


6. Damage Calculation
Damage is based on the hero’s attributes and equipped weapon.
Each class has its own damage formula (e.g., Warriors rely on Strength, Mages rely on Intelligence).
Project Structure
Heroes: Class definitions for Mage, Ranger, Rogue, and Warrior.
Attributes: Manages the Strength, Dexterity, and Intelligence attributes.
Equipment: Handles weapon and armor systems for each hero.
Exceptions: Custom exceptions (InvalidWeaponException, InvalidArmorException).
Tests: Unit tests using xUnit to verify functionality.
