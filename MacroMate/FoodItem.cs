namespace MacroMate;

public class FoodItem
{
    public string Name { get; private set; }
    public float Carbs { get; private set; }
    public float Proteins { get; private set; }
    public float Fats { get; private set; }
    public DateTime Date { get; private set; }
    public FoodItem(string name, float carbs, float proteins, float fats, DateTime date)
    {

    }
}
