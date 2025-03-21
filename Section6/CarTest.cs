﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section6
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void Class_Car_Color_Set()
        {
            //arrange
            Car myCar = new Car("Red", 2, true);

            //act

            //assert
            Assert.AreEqual(myCar.Color, "Red");
        }

        [TestMethod]
        public void Call_Acceleration_Method()
        {
            Car myCar = new Car("Red", 2, true);
            
            myCar.Accelerate();
        }

        [TestMethod]
        public void Call_FamilyCar_Method()
        {
            Car myCar = new Car("Red", 2, true);
            bool carType = myCar.FamilyCar();
            Assert.IsTrue(carType);
        }
    }
}