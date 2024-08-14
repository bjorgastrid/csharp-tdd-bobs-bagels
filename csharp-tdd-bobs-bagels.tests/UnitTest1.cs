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


}