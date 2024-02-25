using System;
using Xunit;

public class MyModelTests
{
    [Fact]
    public void TestGetProductInRange()
    {
        // Arrange
        int expectedProduct = 24;

        // Act
        int actualProduct = MyModel.GetProductInRange(1, 4);

        // Assert
        Assert.Equal(expectedProduct, actualProduct);
    }

    [Theory]
    [InlineData(5, true)]
    [InlineData(6, false)]
    [InlineData(13, true)]
    [InlineData(15, false)]
    public void TestIsFibonacci(int number, bool expected)
    {
        // Act
        bool actual = MyModel.IsFibonacci(number);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestSortArray()
    {
        // Arrange
        int[] array = { 3, 1, 4, 1, 5, 9, 2, 6 };
        int[] expectedArrayAsc = { 1, 1, 2, 3, 4, 5, 6, 9 };
        int[] expectedArrayDesc = { 9, 6, 5, 4, 3, 2, 1, 1 };

        // Act
        MyModel.SortArray(array, "asc");

        // Assert
        Assert.Equal(expectedArrayAsc, array);

        // Act
        MyModel.SortArray(array, "desc");

        // Assert
        Assert.Equal(expectedArrayDesc, array);
    }
}
