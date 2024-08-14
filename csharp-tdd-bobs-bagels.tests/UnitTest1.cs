using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class Tests
{

    [Test]
    public void AddItemTest()
    {
        BagelBasket b = new BagelBasket( );

        b.add("poppy seed");

        Assert.AreEqual(b.bagles.Count, 1);
    }

    [Test]
    public void RemoveItemTest()
    {
        BagelBasket b = new BagelBasket();

        b.add("poppy seed");

        b.remove("poppy seed");

        Assert.AreEqual(b.bagles.Count, 0);
    }


}