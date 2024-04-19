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
```