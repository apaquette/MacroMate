namespace MacroMate;

public class FoodItem(string name, float carbs, float proteins, float fats, DateTime date)
{
    public string Name { get; } = name;
    public float Carbs { get; } = carbs;
    public float Proteins { get; } = proteins;
    public float Fats { get; } = fats;
    public DateTime Date { get; } = date;
}
