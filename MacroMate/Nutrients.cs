namespace MacroMate;

public class Nutrients
{
    public int Calories { get; }
    public float Proteins { get; }
    public float Carbohydrates { get; }
    public float Fats { get; }

    public Nutrients(int Calories, float proteins, float carbs, float fats)
    {
        if (carbs < 0 || proteins < 0 || fats < 0)
            throw new InvalidMacroValueException("Macros cannot be negative");

        Proteins = proteins;
        Carbohydrates = carbs;
        Fats = fats;
    }
}

public class InvalidMacroValueException : Exception
{
    public InvalidMacroValueException() { }
    public InvalidMacroValueException(string msg) : base(msg) { }
    public InvalidMacroValueException(string msg, Exception inner) : base(msg, inner) { }
}