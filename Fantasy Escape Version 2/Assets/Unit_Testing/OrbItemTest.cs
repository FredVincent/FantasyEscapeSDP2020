using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class OrbItemTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void OrbItemTestSimplePasses()
        {
            // Use the Assert class to test conditions
            // Arrange
            var OrbSpeed = 1;
            var OrbDamage = 55;

            // act
            var OrbStat = OrbDamage * OrbSpeed;
            // Assert
            Assert.That(OrbStat, Is.EqualTo(55));
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator OrbItemTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
