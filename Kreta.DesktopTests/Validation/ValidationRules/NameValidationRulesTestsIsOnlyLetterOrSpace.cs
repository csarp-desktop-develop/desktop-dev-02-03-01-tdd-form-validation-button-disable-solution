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
    public class NameValidationRulesTestsIsOnlyLetterOrSpace
    {
        [TestMethod()]
        public void NameValidationRulesTestNameIsEmpty()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("");
            // act
            bool actual = nvr.IsOnlyLetterOrSpace;
            // assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void NameValidationRulesTestNameHasDigit()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("F8rkas");
            // act
            bool actual = nvr.IsOnlyLetterOrSpace;
            // assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void NameValidationRulesTestNameHasSpecialCharacter()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("Fark*s");
            // act
            bool actual = nvr.IsOnlyLetterOrSpace;
            // assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void NameValidationRulesTestOneValidName()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("Farkas");
            // act
            bool actual = nvr.IsOnlyLetterOrSpace;
            // assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void NameValidationRulesTestNameWithSpace()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("Farkané Szabó");
            // act
            bool actual = nvr.IsOnlyLetterOrSpace;
            // assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void NameValidationRulesTestNameWithDash()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("Ács-Sánta");
            // act
            bool actual = nvr.IsOnlyLetterOrSpace;
            // assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void NameValidationRulesTestDigitInSecondPart()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("Farkasné Sz8bó");
            // act
            bool actual = nvr.IsOnlyLetterOrSpace;
            // assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void NameValidationRulesTestSpecialCharacterIsSecondPart()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("Acs-Sánt*");
            // act
            bool actual = nvr.IsOnlyLetterOrSpace;
            // assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void NameValidationRulesTestSpaceAtStart()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules(" Farkas");
            // act
            bool actual = nvr.IsOnlyLetterOrSpace;
            // assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void NameValidationRulesTestDashAtStart()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("-Farkas");
            // act
            bool actual = nvr.IsOnlyLetterOrSpace;
            // assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void NameValidationRulesSpaceAtEnd()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("Farkas ");
            // act
            bool actual = nvr.IsOnlyLetterOrSpace;
            // assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void NameValidationRulesDashAtEnd()
        {
            // arrange
            NameValidationRules nvr = new NameValidationRules("Farkas-");
            // act
            bool actual = nvr.IsOnlyLetterOrSpace;
            // assert
            Assert.IsFalse(actual);
        }
    }
}