using TS.TechnicalTest;

namespace TS.UnitTests;

/// <summary>
/// Method naming convention: MethodUnderTest_Scenario_ExpectedResult 
/// </summary>
[TestClass]
public class DeepestPitTests
{
    [TestMethod]
    public void Q2_BasicNominalTest()
    {
        var points = new[] {0, 1, 3, -2, 0, 1, -3, 2, 3};
        var result = DeepestPitAnswer.Solution(points);

        Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void GetPitDepth_WithInput_Returns2()
    {
        var points = new[] { 1, 2, 3, 1, 2, 3, 1, 2, 3 };
        var result = DeepestPitAnswer.Solution(points);

        Assert.AreEqual(2, result);
    }


}
