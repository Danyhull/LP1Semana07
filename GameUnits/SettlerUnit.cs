public class Unit
{
    public Unit(int attack, int defense)
    {
    
    }
}

public class SettlerUnit : Unit
{
    public SettlerUnit() : base(1, 3)
    {
    }

    public float Cost { get; } = 5;
}