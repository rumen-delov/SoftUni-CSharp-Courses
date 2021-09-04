using NUnit.Framework;

[TestFixture]
public class AxeTests
{
    private Axe axe;
    private Dummy dummy;

    [SetUp]
    public void InitializeTest()
    {
        axe = new Axe(10, 2);
        dummy = new Dummy(40, 5);
    }
    
    [Test]
    public void AxeLoosesOneDurabilityPointAfterAttack()
    {
        axe.Attack(dummy);

        //Assert.That(axe.DurabilityPoints, Is.EqualTo(1), "Axe Durability doesn't change after attack.");

        // or

        Assert.AreEqual(1, axe.DurabilityPoints, "Axe doesn't loose 1 durability point after attack.");
    }

    [Test]
    public void AttackWithBrokenAxe()
    {
        axe.Attack(dummy);
        axe.Attack(dummy);
        
        Assert.That(() => axe.Attack(dummy), 
            Throws.InvalidOperationException
            .With.Message.EqualTo("Axe is broken."));
    }
}