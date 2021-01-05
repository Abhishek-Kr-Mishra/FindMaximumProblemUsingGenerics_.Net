using FindMaximumNumber_Generics;
using NUnit.Framework;

namespace FindMaximumTest
{
    public class FindMaximumTestClass
    {
        [SetUp]
        public void Setup()
        {
        }

        //T.C1.1
        [Test]
        public void GivenMaxNumberAtFirstPosition_ShouldValidate_AndReturnMaximumNumber()
        {
            MaximumNumberCheck maximumNumberCheck = new MaximumNumberCheck();
            int output = maximumNumberCheck.MaxIntegerNumber(34, 18, 6);
            Assert.AreEqual(34,output);
        }
        //T.C1.2
        [Test]
        public void GivenMaxNumberAtSecondPosition_ShouldValidate_AndReturnMaximumNumber()
        {
            MaximumNumberCheck maximumNumberCheck = new MaximumNumberCheck();
            int output = maximumNumberCheck.MaxIntegerNumber(18, 34, 6);
            Assert.AreEqual(34, output);
        }
        //T.C1.2
        [Test]
        public void GivenMaxNumberAtThirdPosition_ShouldValidate_AndReturnMaximumNumber()
        {
            MaximumNumberCheck maximumNumberCheck = new MaximumNumberCheck();
            int output = maximumNumberCheck.MaxIntegerNumber(18, 6, 34);
            Assert.AreEqual(34, output);
        }
        //T.C2.1
        [Test]
        public void GivenMaxFloatNumberAtFirstPosition_ShouldValidate_AndReturnMaximumFloatNumber()
        {
            MaximumNumberCheck maximumNumberCheck = new MaximumNumberCheck();
            float output = maximumNumberCheck.MaxFloatNumber(34.56f, 25.89f, 5.55f);
            Assert.AreEqual(34.56f, output);
        }
        //T.C2.2
        [Test]
        public void GivenMaxFloatNumberAtSecondPosition_ShouldValidate_AndReturnMaximumFloatNumber()
        {
            MaximumNumberCheck maximumNumberCheck = new MaximumNumberCheck();
            float output = maximumNumberCheck.MaxFloatNumber(25.89f, 34.56f, 5.55f);
            Assert.AreEqual(34.56f, output);
        }
        //T.C2.3
        [Test]
        public void GivenMaxFloatNumberAtThirdPosition_ShouldValidate_AndReturnMaximumFloatNumber()
        {
            MaximumNumberCheck maximumNumberCheck = new MaximumNumberCheck();
            float output = maximumNumberCheck.MaxFloatNumber(25.89f, 5.55f, 34.56f);
            Assert.AreEqual(34.56f, output);
        }
    }
}