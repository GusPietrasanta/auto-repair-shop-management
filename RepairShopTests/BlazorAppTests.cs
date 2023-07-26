
using static BlazorApp.Utils.InputUtils;

namespace RepairShopTests;

public class BlazorAppTests
{
    [Test]
    [TestCase("Testing", "testing")]
    [TestCase("Testing", "  testing  ")]
    [TestCase("Testing Testing", "  testing  testing  ")]
    [TestCase("Hello World", " hElLo    wOrLd   ")]
    [TestCase("All Upper", "ALL UPPER")]
    [TestCase("Al Pacino", "   al pacino     ")]
    [TestCase("Al-Nassr", "al-nassr")]
    [TestCase("Al-Ittihad Nasri", "al  -  ittihad   nasri")]
    public void RemoveWhiteSpaceAndTitleCase_Test(string expected, string input)
    {
        string actual = input.RemoveWhiteSpaceAndTitleCase();

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    [TestCase("S123TST", "s 123 tst")]
    [TestCase("S123TST", "s-123-tst")]
    [TestCase("S37UD", " s 37 ud  ")]
    [TestCase("RAMPANT", "RAMPANT")]
    [TestCase("XX111A", "xx111a")]
    [TestCase("TESTME", "testme")]
    [TestCase("XX000A", "xx-000   a  ")]
    public void RemoveWhiteSpaceAndUpperNumberPlate_Test(string expected, string input)
    {
        string actual = input.TrimAndUpperCaseNumberPlate();
        
        Assert.That(actual, Is.EqualTo(expected));
    }
}