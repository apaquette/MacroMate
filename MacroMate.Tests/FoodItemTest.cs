namespace MacroMate.Tests;
public class FoodItemTests
{
    [TestCase("Dubious", 0, 0, 0, "2025, 1, 1")]
    public void FoodItemConstructor_valid(string name, float carbs, float proteins, float fats, DateTime date)
    {
        FoodItem test = new(name, carbs, proteins, fats, date);
        Assert.That(test.GetType(), Is.EqualTo(typeof(FoodItem)));
        Assert.That(test.Name, Is.EqualTo(name));
        Assert.That(test.Carbs, Is.EqualTo(carbs));
        Assert.That(test.Fats, Is.EqualTo(fats));
        Assert.That(test.Proteins, Is.EqualTo(proteins));
        Assert.That(test.Date, Is.EqualTo(date));
    }
}