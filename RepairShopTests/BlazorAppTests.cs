
using static BlazorApp.Utils.InputUtils;

namespace RepairShopTests;

public class BlazorAppTests
{
    [SetUp]
    public void Setup()
    {
    }
    
    [Test]
    [TestCase("Testing", "testing")]
    [TestCase("Testing", "  testing  ")]
    [TestCase("Testing Testing", "  testing  testing  ")]
    [TestCase("Al Pacino", "   al pacino     ")]
    [TestCase("Al-Nassr", "al-nassr")]
    [TestCase("Al-Ittihad Nasri", "al  -  ittihad   nasri")]
    public void RemoveWhiteSpaceAndTitleCase_Test(string expected, string input)
    {
        string actual = input.RemoveWhiteSpaceAndTitleCase();

        Assert.That(actual, Is.EqualTo(expected));
    }
}