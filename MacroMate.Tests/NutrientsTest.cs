namespace MacroMate.Tests;

public class NutrientsTest
{
    [TestCase(100, 0, 0, 0, 0)]
    [TestCase(100, 100, 0, 0, 0)]
    [TestCase(100, 0, 100, 0, 0)]
    [TestCase(100, 0, 0, 100, 0)]
    [TestCase(100, 0, 0, 0, 100)]
    [TestCase(100, 100, 100, 0, 0)]
    [TestCase(100, 100, 0, 100, 0)]
    [TestCase(100, 100, 0, 0, 100)]
    [TestCase(100, 0, 100, 0, 100)]
    [TestCase(100, 0, 0, 100, 100)]
    [TestCase(100, 0, 100, 100, 100)]
    [TestCase(100, 100, 0, 100, 100)]
    [TestCase(100, 100, 100, 0, 100)]
    [TestCase(100, 100, 100, 100, 0)]
    [TestCase(100, 100, 100, 100, 100)]
    public void NutrientsConstructor_valid(float portion, int cals, float proteins, float carbs, float fats)
    {
        Nutrients test = new(portion, cals, proteins, carbs, fats);
        Assert.That(test.GetType(), Is.EqualTo(typeof(Nutrients)));
        Assert.That(test.Calories, Is.EqualTo(cals));
        Assert.That(test.Proteins, Is.EqualTo(proteins));
        Assert.That(test.Carbohydrates, Is.EqualTo(carbs));
        Assert.That(test.Fats, Is.EqualTo(fats));
    }

    [TestCase(100, -10, 0, 0, 0)]
    [TestCase(100, 0, -10, 0, 0)]
    [TestCase(100, 0, 0, -10, 0)]
    [TestCase(100, 0, 0, 0, -10)]
    [TestCase(100, -10, -10, 0, 0)]
    [TestCase(100, -10, 0, -10, 0)]
    [TestCase(100, -10, 0, 0, -10)]
    [TestCase(100, 0, -10, 0, -10)]
    [TestCase(100, 0, 0, -10, -10)]
    [TestCase(100, 0, -10, -10, -10)]
    [TestCase(100, -10, 0, -10, -10)]
    [TestCase(100, -10, -10, 0, -10)]
    [TestCase(100, 0, -10, -10, 0)]
    [TestCase(100, -10, -10, -10, -10)]
    public void NutrientsConstructor_invalid(float portion, int cals, float proteins, float carbs, float fats)
    {
        Assert.Throws<InvalidNutrientValueException>(() => new Nutrients(portion, cals, proteins, carbs, fats));
    }
}