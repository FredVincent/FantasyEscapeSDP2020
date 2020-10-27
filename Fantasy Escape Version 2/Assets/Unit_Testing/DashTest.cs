using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class DashTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void DashTestSimplePasses()
        {
            // Use the Assert class to test conditions
            // Arrange
            var DashCooldown = .1;
            var DashTime = 2;
            // Act
            var DashDuration = DashCooldown + DashTime;
            // Assert

            Assert.That(DashDuration, Is.EqualTo(2.1));
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator DashTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
