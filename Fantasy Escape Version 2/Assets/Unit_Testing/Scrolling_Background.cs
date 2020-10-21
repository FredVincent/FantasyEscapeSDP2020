using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class Scrolling_Background
    {
        // A Test behaves as an ordinary method
        [Test]
        public void Scrolling_BackgroundSimplePasses()
        {
            // Use the Assert class to test conditions
            // Arrange
            var bgSpeed = 0.02;
            var bgRend = 4;

            // ACT
            var CorrectScrolling = bgRend + bgSpeed;

            // Assert
            Assert.That(CorrectScrolling, Is.EqualTo(4.02));
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator Scrolling_BackgroundWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
