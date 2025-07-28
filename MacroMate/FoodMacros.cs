namespace MacroMate;

public class FoodMacros(float carbs, float proteins, float fats)
{
    public float Carbs { get; } = carbs;
    public float Proteins { get; } = proteins;
    public float Fats { get; } = fats;

    public int Calories()
    {
        return 0;
    }
}