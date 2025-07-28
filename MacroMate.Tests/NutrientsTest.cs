namespace MacroMate.Tests;

public class NutrientsTest
{
    [TestCase(100, 0, 0, 0, 0)]
    [TestCase(100, 100, 0, 0, 0)]
    [TestCase(100, 0, 100, 0, 0)]
    [TestCase(100, 0, 0, 100, 0)]
    [TestCase(100, 0, 0, 0, 100)]
    [TestCase(100, 100, 100, 100, 100)]
    public void NutrientsConstructor_valid(float portion, float cals, float proteins, float carbs, float fats)
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
    public void NutrientsConstructor_invalid(float portion, float cals, float proteins, float carbs, float fats)
    {
        Assert.Throws<InvalidNutrientValueException>(() => new Nutrients(portion, cals, proteins, carbs, fats));
    }
    [TestCase(50)]
    [TestCase(100)]
    public void NutrientsScale_valid(float portion)
    {
        Nutrients test = new(100, 45, 10, 1, 2);
        Nutrients result = test.Scale(portion);
        float factor = portion / 100f;

        Assert.That(result.Portion, Is.EqualTo(portion));
        Assert.That(result.Calories, Is.EqualTo(45 * factor));
        Assert.That(result.Proteins, Is.EqualTo(10 * factor));
        Assert.That(result.Carbohydrates, Is.EqualTo(1 * factor));
        Assert.That(result.Fats, Is.EqualTo(2 * factor));
    }
}