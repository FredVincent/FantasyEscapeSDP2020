using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class Scrollingbackgroundversion2test
    {
        // A Test behaves as an ordinary method
        [Test]
        public void Scrollingbackgroundversion2testSimplePasses()
        {
            // Use the Assert class to test conditions
            // Arrange
            var ObjectSpeed = 0.4;
            var ObjectPosition = 2;

            // act
            var Parallax = ObjectSpeed * ObjectPosition;

            // Assert
            Assert.That(Parallax, Is.EqualTo(0.8));
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator Scrollingbackgroundversion2testWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
