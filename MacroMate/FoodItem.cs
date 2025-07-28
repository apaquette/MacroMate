namespace MacroMate;

public class FoodItem(string name, DateTime date) : ILogItem
{
    public string Name { get; } = name;
    public FoodMacros Macros { get; }
    public DateTime Date { get; } = date;

    public void Display()
    {
        throw new NotImplementedException();
    }
}
