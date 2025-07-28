namespace MacroMate.Tests;

public class NutrientsTest
{
    [TestCase(0,0, 0, 0)]
    [TestCase(0,100, 0, 0)]
    [TestCase(0,0, 100, 0)]
    [TestCase(0,0, 0, 100)]
    [TestCase(0,100, 100, 0)]
    [TestCase(0,100, 0, 100)]
    [TestCase(0,0, 100, 100)]
    [TestCase(0,100, 100, 100)]
    public void NutrientsConstructor_valid(int cals, float carbs, float proteins, float fats)
    {
        Nutrients test = new(cals, proteins, carbs, fats);
        Assert.That(test.GetType(), Is.EqualTo(typeof(Nutrients)));
        Assert.That(test.Calories, Is.EqualTo(cals));
        Assert.That(test.Proteins, Is.EqualTo(proteins));
        Assert.That(test.Carbohydrates, Is.EqualTo(carbs));
        Assert.That(test.Fats, Is.EqualTo(fats));
    }

    [TestCase(0, -10, 0, 0)]
    [TestCase(0, 0, -10, 0)]
    [TestCase(0, 0, 0, -10)]
    [TestCase(0, -10, -10, 0)]
    [TestCase(0, -10, 0, -10)]
    [TestCase(0, 0, -10, -10)]
    [TestCase(0, -10, -10, -10)]
    public void FoodMacrosConstructor_invalid(int cals, float carbs, float proteins, float fats)
    {
        Assert.Throws<InvalidMacroValueException>(() => new Nutrients(cals, proteins, carbs, fats));
    }
}