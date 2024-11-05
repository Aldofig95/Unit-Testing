namespace Unit_Testing;

public class UnitTest1
{
    [Fact]
    public void PassingTest()
    {
        Assert.Equal(4, Add(2, 2));
    }

    [Fact]
    public void FailingTest()
    {
        Assert.Equal(5, Add(2, 2));
    }

    int Add(int x, int y)
    {
        return x + y;
    }

    [Theory]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(6)]
    public void MyFirstTheory(int value)
    {
        Assert.True(IsOdd(value));
    }

    bool IsOdd(int value)
    {
        return value % 2 == 1;
    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    public void MySecondTheory(int value)
    {
        Assert.True(IsEven(value));
    }

    bool IsEven(int value)
    {
        return value % 2 == 0;
    }

    [Theory]
    [InlineData("racecar", true)]
    [InlineData("hello", false)]
    [InlineData("madam", true)]
    [InlineData("world", false)]
    public void PalindromeTest(string input, bool expected)
    {
        Assert.Equal(expected, IsPalindrome(input));
    }

    bool IsPalindrome(string input)
    {
        var reversed = new string(input.Reverse().ToArray());
        return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    }
}
