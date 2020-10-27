using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class PauseMenuTest
{
    // Start is called before the first frame update
    [Test]
    public void CalculateTime_test()
    {
        var timeSet = 0;

        Assert.That(timeSet, Is.EqualTo(0));
    }
}
