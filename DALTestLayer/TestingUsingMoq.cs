//using DataAccessLayer;
//using Moq;
//using NUnit.Framework;

//namespace DALTestLayer
//{
//    [TestFixture]  
//    public class TestingUsingMoq
//    {
//        [Test]
//        public void checkEmployeeExistWithMoq()
//        {

//            var fakeObject = new Mock<EmpInfoRepository>();
//            fakeObject.Setup(x => x.GetEmpInfo(It.IsAny<string>()));
//            var res = fakeObject.Object.GetEmpInfo("test@gmail.com");
//            Assert.That(res,Is.Not.Null);
//        }
//    }
//}


using DataAccessLayer;
using Moq;
using NUnit.Framework;

namespace DALTestLayer
{
    [TestFixture]
    public class TestingUsingMoq
    {
        [Test]
        public void checkEmployeeExistWithMoq()
        {
            // Arrange
            var email = "demo@gmail.com";
            var expectedEmpInfo = new EmpInfo(); // Creating a sample EmpInfo object for testing

            var fakeObject = new Mock<EmpInfoRepository>();
            fakeObject.Setup(x => x.GetEmpInfo(email)).Returns(expectedEmpInfo);

            // Act
            var res = fakeObject.Object.GetEmpInfo(email);

            // Assert
            Assert.That(res, Is.Not.Null);
        }
    }
}
