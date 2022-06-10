using FibonacciW;
using NUnit.Framework;

namespace Tests
{
    public class FibonacciTests
    {


        [Test]
        public void Fibonacci001()
        {
            var fib = new Fibonacci();
            var result = fib.calcular(1);
            Assert.AreEqual(0, result);
        }


        [Test]
        public void Fibonacci002()
        {
            var fib = new Fibonacci();
            var result = fib.calcular(2);
            Assert.AreEqual(1, result);
        }


        [Test]
        public void Fibonacci003()
        {
            var fib = new Fibonacci();
            var result = fib.calcular(3);
            Assert.AreEqual(1, result);
        }


        [Test]
        public void Fibonacci004()
        {
            var fib = new Fibonacci();
            var result = fib.calcular(4);
            Assert.AreEqual(2, result);
        }

    }
}