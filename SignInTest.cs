using SignInLib;

namespace TestProject1
{
    [TestClass]
 
        public class SignInTest
        {
            [TestMethod]
            public void SuccessMethod()
            {
                string expResult = "valid user";
                Assert.AreEqual(expResult, SignIn.Authenicate("sam", "sam@1256"));
            }
            [TestMethod]
            public void FailMethod()
            {
                string expResult = "invalid user credential";
                Assert.AreEqual(expResult, SignIn.Authenicate("ravi", "raj@124"));
            }
            [TestMethod]
            public void AnonymousMethod()
            {
                string expResult = "You must provide username and password";
                Assert.AreEqual(expResult, SignIn.Authenicate(null, null));
            }

        }
    }