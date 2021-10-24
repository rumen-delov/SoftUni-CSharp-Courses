namespace Robots.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class RobotsTests
    {
        private Robot robot;
        private RobotManager robotManager;

        [SetUp]
        public void Setup()
        {
            robot = new Robot("Wall-E", 100);
            robotManager = new RobotManager(4);
        }

        [Test]
        public void CheckIfRobotsNameIsRight()
        {
            Assert.That(robot.Name, Is.EqualTo("Wall-E"));
        }

        [Test]
        public void SetRobotsName()
        {
            robot.Name = "R2D2";
            Assert.That(robot.Name, Is.EqualTo("R2D2"));
        }

        [Test]
        public void CheckRobotsInitialBatteryStatus()
        {
            Assert.That(robot.Battery, Is.EqualTo(100));
        }

        [Test]
        public void SetRobotsBatteryStatus()
        {
            robot.Battery = 83;
            Assert.That(robot.Battery, Is.EqualTo(83));
        }

        [Test]
        public void CheckIfRobotsMaxBatteryWithAllowedValue()
        {
            Assert.That(robot.MaximumBattery, Is.EqualTo(100));
        }

        [Test]
        public void InitializeRobotManagerWithNegativeValue()
        {
            RobotManager robotManager2;

            Assert.Throws<ArgumentException>(() => robotManager2 = new RobotManager(-2));
        }

        [Test]
        public void CheckIfRobotManagerCapacityIsSetRight()
        {
            RobotManager robotManager3 = new RobotManager(3);

            Assert.That(robotManager3.Capacity, Is.EqualTo(3));
        }


        [Test]
        public void AddValidNumberOfRobotsToRobotManager()
        {
            Robot robot2 = new Robot("R2", 90);
            Robot robot3 = new Robot("R3", 60);
            Robot robot4 = new Robot("R4", 60);

            robotManager.Add(robot);
            robotManager.Add(robot2);
            robotManager.Add(robot3);
            robotManager.Add(robot4);
            
            Assert.That(robotManager.Count, Is.EqualTo(4));
        }

        [Test]
        public void AddMoreRobotsThanRobotManagerCapacity()
        {
            Robot robot2 = new Robot("R2", 90);
            Robot robot3 = new Robot("R3", 60);
            Robot robot4 = new Robot("R4", 60);
            Robot robot5 = new Robot("R5", 50);

            robotManager.Add(robot);
            robotManager.Add(robot2);
            robotManager.Add(robot3);
            robotManager.Add(robot4);
            

            Assert.Throws<InvalidOperationException>(() => robotManager.Add(robot5));
        }

        [Test]
        public void AddAnotherRobotWithExistingNameToRobotManagerList()
        {
            robotManager.Add(robot);
            Robot robot2 = new Robot("Wall-E", 90);
            Assert.Throws<InvalidOperationException>(() => robotManager.Add(robot2));
        }


        [Test]
        public void RemoveRobotWithValidNameFromRobotManagerList()
        {           
            Robot robot2 = new Robot("EEE", 40);

            robotManager.Add(robot);
            robotManager.Add(robot2);

            robotManager.Remove("EEE");

            Assert.That(robotManager.Count, Is.EqualTo(1));
        }

        [Test]
        public void RemoveRobotWithInvalidNameFromRobotManagerList()
        {
            Robot robot2 = new Robot("EEE", 40);

            robotManager.Add(robot);
            robotManager.Add(robot2);

            Assert.That(() => robotManager.Remove("ER2"), Throws.InvalidOperationException.With.Message.EqualTo($"Robot with the name ER2 doesn't exist!"));
        }
    }
}
