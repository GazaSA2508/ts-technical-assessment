using TS.TechnicalTest;

namespace TS.UnitTests;

/// <summary>
/// Method naming convention: MethodUnderTest_Scenario_ExpectedResult 
/// </summary>
[TestClass]
public class LongestSentanceTests
{
    [TestMethod]
    public void Q1_BasicNominalTest()
    {
        var input = $"We test coders. Give us a try";
        var outcome = LongestSentanceAnswer.Solution(input);

        Assert.AreEqual(4, outcome);
    }

    [TestMethod]
    public void GetLongestSentance_WithExampleInput_Returns2()
    {
        var input = $"Forget CVs..Save time . x x";

        var outcome = LongestSentanceAnswer.Solution(input);

        Assert.AreEqual(2, outcome);
    }

    [TestMethod]
    public void GetLongestSentance_WithInput_Returns5()
    {
        var input = $"Test one, has 4words word. This this one has five.";

        var outcome = LongestSentanceAnswer.Solution(input);

        Assert.AreEqual(5, outcome);
    }


}
