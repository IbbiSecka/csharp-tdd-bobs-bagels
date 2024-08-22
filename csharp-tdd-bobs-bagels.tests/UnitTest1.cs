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
    public void removeBasktTest() //Tests for User story 2 and 5
    {
        Basket basket = new Basket();
        bool result1 = basket.Add("jam");
        bool result2 = basket.Delete("jam");
        Assert.That(result2 == true);
    }
    [Test]
    public void fullBasket()
    {
        Basket basket = new Basket();
        List<string> list = new List<string>(); 
        list.Add("Butter");
        list.Add("Cheese");

        bool actual = basket.maxCapacity(list);

        Assert.That(actual == false);
    }
    [Test]
    public void changeCapacity()
    {
        Basket bagelist = new Basket();

        bagelist.Add("1");
        bagelist.Add("2");
        bagelist.Add("3");
        int originalCapacity = bagelist.totalItems;
       

        int changedCapacity = bagelist.changeCapacity(originalCapacity);


        Assert.That(changedCapacity == 1);

    }


}