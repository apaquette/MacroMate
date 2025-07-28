namespace MacroMate.Tests;

public class FoodMacrosTests
{
    [TestCase(0, 0, 0)]
    [TestCase(100, 0, 0)]
    [TestCase(0, 100, 0)]
    [TestCase(0, 0, 100)]
    [TestCase(100, 100, 0)]
    [TestCase(100, 0, 100)]
    [TestCase(0, 100, 100)]
    [TestCase(100, 100, 100)]
    public void FoodMacrosConstructor_valid(float carbs, float proteins, float fats)
    {
        FoodMacros test = new(carbs, proteins, fats);
        Assert.That(test.GetType(), Is.EqualTo(typeof(FoodMacros)));
        Assert.That(test.Carbs, Is.EqualTo(carbs));
        Assert.That(test.Fats, Is.EqualTo(fats));
        Assert.That(test.Proteins, Is.EqualTo(proteins));
    }

    [TestCase(-10, 0, 0)]
    public void FoodMacrosConstructor_invalid(float carbs, float proteins, float fats)
    {
        Assert.Throws<InvalidMacroValueException> (() => new FoodMacros(carbs, proteins, fats));
    }
}