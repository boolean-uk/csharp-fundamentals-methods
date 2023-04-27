using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_fundamentals_methods.Main;

namespace csharp_fundamentals_methods.Test
{
    public class ExtensionTests
    {
        private Extension _extension;

        public ExtensionTests()
        {
            _extension = new Extension();
        }
        [Test]
        public void one()
            {
            Assert.AreEqual("The cake is ready!", this._extension.timerStatus(0));
            Assert.AreEqual("The cake is still baking!", this._extension.timerStatus(1));
            Assert.AreEqual("The cake is still baking!", this._extension.timerStatus(23));
            Assert.AreEqual("The timer finished ages ago!", this._extension.timerStatus(-1));
            Assert.AreEqual("The timer finished ages ago!", this._extension.timerStatus(-25));
        }

        [Test]
        public void two()
        {
            Assert.AreEqual(5, this._extension.estimatePrepTime(new String[] { "milk", "sugar", "eggs", "flour", "chocolate" }, 1));
            Assert.AreEqual(10, this._extension.estimatePrepTime(new String[] { "milk", "sugar", "eggs", "flour", "chocolate" }, 2));
            Assert.AreEqual(10, this._extension.estimatePrepTime(new String[] { "milk", "sugar", "eggs", "flour", "chocolate" }, 0));
            Assert.AreEqual(20, this._extension.estimatePrepTime(new String[] { "milk", "sugar" }, 10));
        }

        [Test]
        public void three()
        {
            Assert.AreEqual(0, this._extension.calculateGramsOfSugar(new String[] { "milk", "flour", "eggs" }, 3));
            Assert.AreEqual(100, this._extension.calculateGramsOfSugar(new String[] { "milk", "flour", "sugar" }, 1));
            Assert.AreEqual(200, this._extension.calculateGramsOfSugar(new String[] { "milk", "sugar", "eggs" }, 2));
            Assert.AreEqual(300, this._extension.calculateGramsOfSugar(new String[] { "sugar", "flour", "eggs" }, 3));
            Assert.AreEqual(400, this._extension.calculateGramsOfSugar(new String[] { "sugar", "milk", "eggs" }, 4));
        }
    }
}
