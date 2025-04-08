namespace CrudApp.Tests;

public class ProductTests
{
    [Fact]
    public void Product_Has_Name()
    {
        var product = new Product { Name = "Test", Price = 9.99M };
        Assert.Equal("Test", product.Name);
    }
}

