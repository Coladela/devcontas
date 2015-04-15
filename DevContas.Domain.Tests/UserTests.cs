using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevContas.Domain.Validation;
using System.Collections.Generic;

namespace DevContas.Domain.Tests
{
    [TestClass]
    public class GivenANewUser
    {
        [TestMethod]
        [TestCategory("Given a new user - It must have a name")]
        public void ItMustHaveAName()
        {
            User user = new User("");
            UserValidator validator = new UserValidator();

            Dictionary<string, string> brokenRules;
            bool isValid = user.Validate(validator, out brokenRules);

            Assert.AreEqual(false, isValid);
        }
    }

    [TestClass]
    public class OnNameChanging
    {
        [TestMethod]
        [TestCategory("Changing user name - It must change user name")]
        public void ItMustChangeUserName()
        {
            Dictionary<string, string> errors;
            var newName = "Tony Stark";
            User user = new User("André");

            user.ChangeName(newName);
            UserValidator validator = new UserValidator();
            bool isValid = user.Validate(validator, out errors);

            Assert.AreEqual(true, isValid);
            Assert.AreEqual(newName, user.Name);
        }
    }
}
