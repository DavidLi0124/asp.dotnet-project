using SimpleApp.Models;
using Xunit;

namespace SimpleApp.Tests; 

public class ProductTests {
    [Fact]
    public void CanChangeProductName() {
        var p = new Product { Name = "Test", Price=100M };
    p.Name = "New Name";

    Assert.Equal("New Name" , p.Name);
    }

    [Fact]
    public void CanChangeProductPrice() {
        var p = new Product { Name ="Test", Price=100M };
        p.Price = 200M;
        Assert.Equal(200M, p.Price);
    }
}