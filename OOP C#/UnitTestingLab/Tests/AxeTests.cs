using System;
using NUnit.Framework;

[TestFixture]
public class AxeTests
{

    [Test]
    public void When_AxeAttackAndDurabilityProvided_ShouldBeSetCorrectly()
    {
        int AxeAttack = 5;
        int AxeDurability = 6;

        Axe axe = new Axe(AxeAttack, AxeDurability);

        Assert.AreEqual(axe.AttackPoints, AxeAttack);
        Assert.AreEqual(axe.DurabilityPoints, AxeDurability);
    }
}