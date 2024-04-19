```mermaid 

    classDiagram

    class Character{
        + Weapons[] : Weapon[]
        + Name : String
        + Fight() : void
    }
    class Player{
        
    }
    class Enemy{
        
    }
    class Weapon{
        + Power : float
    }
    class Gun{
        + Ammo : int
        + FireGun() : void
    }
    class Sword{
        + BladeLength : float
        + AttackWithSword() : void
    }
    Character <|-- Player
    Character <|-- Enemy
    Character <|-- Weapon
    Weapon <|-- Gun
    Weapon <|-- Sword
    Weapon -- Player 
    Weapon -- Enemy
<<<<<<< HEAD
```
=======
```
>>>>>>> c10b03bfb8a32d7f1f629f2aa0e17b86c42199c0
