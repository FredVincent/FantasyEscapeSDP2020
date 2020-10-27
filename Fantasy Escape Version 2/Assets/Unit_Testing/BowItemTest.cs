using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class BowItemTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void BowItemTestSimplePasses()
        {
            // Use the Assert class to test conditions
            //Arrange
            var ArrowSpeed = 2;
            var ArrowDamage = 25;
            var Enemyhp = 100;
            // Act
            var arrowstats = ArrowSpeed * ArrowDamage;
            var correctenemyhp = Enemyhp - arrowstats;
            // Assert
            Assert.That(correctenemyhp, Is.EqualTo(50));
        }
    }
}
