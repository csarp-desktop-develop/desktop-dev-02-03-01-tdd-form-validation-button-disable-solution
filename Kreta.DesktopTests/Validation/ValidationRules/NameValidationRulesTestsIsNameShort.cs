using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kreta.Desktop.Validation.ValidationRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Desktop.Validation.ValidationRules.Tests
{
    [TestClass()]
    public class NameValidationRulesTestsIsNameShort
    {
        [TestMethod()]
        public void NameValidationRulesTestEmptyName()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("");
            // act
            bool actual = nvr.IsNameShort;
            // assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void NameValidationRulesTestOneLetter()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("F");
            // act
            bool actual = nvr.IsNameShort;
            // assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void NameValidationRulesTestValidShortName()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("Fa");
            // act
            bool actual = nvr.IsNameShort;
            // assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void NameValidationRulesTestValidLongName()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("Farkas");
            // act
            bool actual = nvr.IsNameShort;
            // assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void NameValidationRulesTestSpecialCharacter()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("F8rkas");
            // act
            bool actual = nvr.IsNameShort;
            // assert
            Assert.IsFalse(actual);
        }
    }
}