namespace MacroMate.Tests;

public class NutrientsTest
{
    [TestCase(100, 0, 0, 0, 0)]
    [TestCase(100, 100, 0, 0, 0)]
    [TestCase(100, 0, 100, 0, 0)]
    [TestCase(100, 0, 0, 100, 0)]
    [TestCase(100, 0, 0, 0, 100)]
    [TestCase(100, 100, 100, 100, 100)]
    public void NutrientsConstructor_valid(float portion, int cals, float proteins, float carbs, float fats)
    {
        Nutrients test = new(portion, cals, proteins, carbs, fats);
        Assert.That(test.GetType(), Is.EqualTo(typeof(Nutrients)));
        Assert.That(test.Portion, Is.EqualTo(portion));
        Assert.That(test.Calories, Is.EqualTo(cals));
        Assert.That(test.Proteins, Is.EqualTo(proteins));
        Assert.That(test.Carbohydrates, Is.EqualTo(carbs));
        Assert.That(test.Fats, Is.EqualTo(fats));
    }

    [TestCase(100, -10, 0, 0, 0)]
    [TestCase(100, 0, -10, 0, 0)]
    [TestCase(100, 0, 0, -10, 0)]
    [TestCase(100, 0, 0, 0, -10)]
    [TestCase(100, -10, -10, -10, -10)]
    [TestCase(0, 0, 0, 0, 0)]
    [TestCase(-10, 0, 0, 0, 0)]
    public void NutrientsConstructor_invalid(float portion, int cals, float proteins, float carbs, float fats)
    {
        Assert.Throws<InvalidNutrientValueException>(() => new Nutrients(portion, cals, proteins, carbs, fats));
    }
    [TestCase(50)]
    public void NutrientsScale_valid(float portion)
    {
        Nutrients test = new(100, 45, 10, 1, 0);
        Nutrients result = test.Scale(portion);
        float factor = portion / 100f;
        Nutrients expected = new(100 * factor, (int)(45 * factor), 10 * factor, 1 * factor, 0);
        Assert.That(result, Is.EqualTo(expected));
    }
}