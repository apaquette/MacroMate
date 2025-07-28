namespace MacroMate;

public class FoodMacros
{
    public float Carbs { get; }
    public float Proteins { get; }
    public float Fats { get; }

    public FoodMacros(float carbs, float proteins, float fats)
    {
        if (carbs < 0 || proteins < 0 || fats < 0)
            throw new InvalidMacroValueException("Macros cannot be negative");


        Carbs = carbs;
        Proteins = proteins;
        Fats = fats;
    }

    public int Calories()
    {
        return 0;
    }
}

public class InvalidMacroValueException : Exception
{
    public InvalidMacroValueException() { }
    public InvalidMacroValueException(string msg) : base(msg) { }
    public InvalidMacroValueException(string msg, Exception inner) : base(msg, inner) { }
}