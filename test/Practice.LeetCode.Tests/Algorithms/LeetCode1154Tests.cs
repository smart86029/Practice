namespace Practice.LeetCode.Tests.Algorithms;

[TestClass]
public class LeetCode1154Tests
{
    [DataTestMethod]
    [DataRow("2019-01-09", 9)]
    [DataRow("2019-02-10", 41)]
    [DataRow("2003-03-01", 60)]
    [DataRow("2004-03-01", 61)]
    public void DayOfYearTest(string date, int expected)
    {
        var leetCode = new LeetCode1154();
        var output = leetCode.DayOfYear(date);
        Assert.AreEqual(expected, output);
    }
}
