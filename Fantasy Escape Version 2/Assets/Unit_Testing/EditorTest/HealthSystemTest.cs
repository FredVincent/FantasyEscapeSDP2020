using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using NUnit.Framework;

public class HealthSystemTest
{
    [Test]
    public void CalculateHealthStock_test()
    {
        var healthStocks = 2;
        var healthAdd = 1;

        var expectedHealth = healthStocks + healthAdd;

        Assert.That(expectedHealth, Is.EqualTo(3));
    }
}
