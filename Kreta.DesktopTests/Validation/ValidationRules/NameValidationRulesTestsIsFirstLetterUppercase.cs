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
    public class NameValidationRulesTestsIsFirstLetterUppercase
    {
        [TestMethod()]
        public void NameValidationRulesTestNameIsEmpty()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("");
            // act
            bool actual = nvr.IsFirstLetterUppercase;
            // assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void NameValidationRulesTestFirstLetterIsUppercase()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("Farkas Nagy");
            // act
            bool actual = nvr.IsFirstLetterUppercase;
            // assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void NameValidationRulesTestFirstLetterIsNotUppercase()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("farkas Nagy");
            // act
            bool actual = nvr.IsFirstLetterUppercase;
            // assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void NameValidationRulesTestFirstCharIsSpecialCharacter()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("8arkas Nagy");
            // act
            bool actual = nvr.IsFirstLetterUppercase;
            // assert
            Assert.IsFalse(actual);
        }
    }
}