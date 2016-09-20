using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoginExcersize
{
    [TestClass]
    public class LoginExcersiseTests
    {
        IHasher hash;
        INameValidator vali;
        IUser currentuser;

        [TestInitialize]
        public void SetupForTest()
        {
            hash = new Hasher(); ;
            vali = new NameValidator();
            currentuser = new User(hash, vali);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception), "Invalid Email address")]
        public void AssertNameValidatorException()
        {
            string expectedexception = "kittens";
            vali.ValidateAsMail(expectedexception);
        }
       
        [TestMethod]
        public void AssertUserName()
        {
            currentuser.UserName = "kitten@kitty.kitten";
            Assert.AreEqual("kitten@kitty.kitten", currentuser.UserName);
        }
    }
}
