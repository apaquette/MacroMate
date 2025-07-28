namespace MacroMate;

public class Nutrients
{
    public int Calories { get; }
    public float Proteins { get; }
    public float Carbohydrates { get; }
    public float Fats { get; }

    public Nutrients(int cals, float proteins, float carbs, float fats)
    {
        if (cals < 0 || carbs < 0 || proteins < 0 || fats < 0)
            throw new InvalidNutrientValueException("Nutrients cannot be negative");

        Calories = cals;
        Proteins = proteins;
        Carbohydrates = carbs;
        Fats = fats;
    }
}

public class InvalidNutrientValueException : Exception
{
    //public InvalidMacroValueException() { }
    public InvalidNutrientValueException(string msg) : base(msg) { }
    //public InvalidMacroValueException(string msg, Exception inner) : base(msg, inner) { }
}