using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void addToBasketTest()
    {
        Basket basket = new Basket();
        bool result = basket.Add("jam");
        Assert.That(result == true);
    }

    [Test]
    public void removeBasketTest()
    {
        Basket basket = new Basket();
        bool result = basket.Delete("jam");
        Assert.That(result == false);
    }
    [Test]
    public void removeBasktTest()
    {
        Basket basket = new Basket();
        bool result1 = basket.Add("jam");
        bool result2 = basket.Delete("jam");
        Assert.That(result2 == true);
    }

}