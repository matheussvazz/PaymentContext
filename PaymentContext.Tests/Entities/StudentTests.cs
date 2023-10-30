using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
    [TestClass]

    public class StudentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var subscription = new Subscription();
            var student = new Student("Matheus", "Vaz", "19034987", "hello@vaz.ex");
            student.AddSubscription(subscription);
        }
    }
}