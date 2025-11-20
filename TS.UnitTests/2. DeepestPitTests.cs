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


    /// <summary>
    /// Additional test method - array length to small (ie: N = 0)
    /// </summary>
    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void GetPitDepth_WithInput_ArrayLengthTooSmall()
    {
        int[] points = [];

        DeepestPitAnswer.Solution(points);
    }

    /// <summary>
    /// Additional test method - array length to large (ie: N = 1,000,001)
    /// </summary>
    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void GetPitDepth_WithInput_ArrayLengthTooLarge()
    {
        int[] points = new int[1000001];

        DeepestPitAnswer.Solution(points);
    }

    /// <summary>
    /// Additional test method - element value cannot be less than 0 (ie: -1 < 0)
    /// </summary>
    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void GetPitDepth_WithInput_ElementValueTooSmall()
    {
        var points = new[] { 1, -1, 3 };

        DeepestPitAnswer.Solution(points);
    }

    /// <summary>
    /// Additional test method - element value cannot be greater than 1,000,000 (ie: 1,000,001 > 1,000,000)
    /// </summary>
    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void GetPitDepth_WithInput_ElementValueTooLarge()
    {
        var points = new[] { 0, 500000, 1000001 };

        DeepestPitAnswer.Solution(points);
    }

    /// <summary>
    /// Additional test method - input value is null
    /// </summary>
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void GetPitDepth_WithInput_InputValueOfNull()
    {
        DeepestPitAnswer.Solution(null);
    }

}
