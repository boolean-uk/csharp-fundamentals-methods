using csharp_fundamentals_methods.Main;
using NUnit.Framework;

namespace csharp_fundamentals_methods.Test
{
    public class CoreTests
    {
        Core exercise;

        public CoreTests()
        {
            this.exercise = new Core();
        }

        [Test]
    public void shouldGreetName()
        {
            Assert.AreEqual("Hello Nathan!", this.exercise.greet("Nathan"));
        }

        [Test]
        public void shouldIncrementNumber()
        {
            Assert.AreEqual(1, this.exercise.increment(0));
            Assert.AreEqual(6, this.exercise.increment(5));
        }

        [Test]
        public void shouldFriendlyGreet()
        {
            Assert.AreEqual("Hi, Nathan :)", this.exercise.happilyGreet("Nathan"));
            Assert.AreEqual("Hi, Edward :)", this.exercise.happilyGreet("Edward"));
            Assert.AreEqual("Hi, Lewis :)", this.exercise.happilyGreet("Lewis"));
        }

        [Test]
        public void shouldConstructNumberArray()
        {
            int[] nums = Core.constructNumberArray(10, 13);
            Assert.AreEqual(4, nums.Length);
            Assert.AreEqual(10, nums[0]);
            Assert.AreEqual(11, nums[1]);
            Assert.AreEqual(12, nums[2]);
            Assert.AreEqual(13, nums[3]);
        }

        [Test]
        public void shouldShout()
        {
            Assert.AreEqual("DISASTER!!!!!", this.exercise.shout("disaster", 5));
            Assert.AreEqual("ERROR!!!!!!!!!!", this.exercise.shout("error", 10));
        }

        
    }
}