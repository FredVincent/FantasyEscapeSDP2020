using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class Score_testing
    {
        // A Test behaves as an ordinary method
        [Test]
        public void Score_testingSimplePasses()
        {
            // Use the Assert class to test conditions
            var currentTime = 15;
            var addTime = 10;

            //ACT
            var expectedTime = currentTime + addTime;

            //ASSERT
            Assert.That(expectedTime, Is.EqualTo(25));
        }
    }
}
