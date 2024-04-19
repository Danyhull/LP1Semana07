public class Unit
{
    public Unit(int attack, int defense)
    {
        // Add validation and error handling here
    }
}

public class SettlerUnit : Unit
{
    public SettlerUnit() : base(1, 3)
    {
    }

    public float Cost { get; } = 5;
}