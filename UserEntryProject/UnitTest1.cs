﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegularExpresion;
using System;
using static RegularExpresion.CustomException;

namespace UserEntryProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestValidationForEmailSamples()
        {
            string expected = "Valid";
            string[] input = { "abc@yahoo.com,", "abc-100@yahoo.com,", "abc.100@yahoo.com", "abc111@abc.com,", "abc-100@abc.net,", "abc.100@abc.com.au", "abc.100@abc.com.au", "abc@1.com,", "abc@gmail.com.com" };
            string pattern = @"^([a-z0-9\.\-]+)?@([a-z0-9]+)\.([a-z\,\.]+)$";
            Pattern pattern1 = new Pattern();
            foreach (string inputItem in input)
            {
                string actual = pattern1.ValidateUserDetails(inputItem, pattern);
                Assert.AreEqual(expected, actual);
            }
        }
      
        [TestMethod]
        [DataRow("Varsha", "^[A-Z]{1}[a-z]{2,}$", "Valid")]
        [DataRow(null, "^[A-Z]{1}[a-z]{2,}$", "Input is having null")]
        [DataRow("", "^[A-Z]{1}[a-z]{2,}$", "Input is having empty")]
        public void GiveInvalidUserNameShouldThrowCustomExceptions(string input, string pattern, string expected)
        {
            try
            {
                Pattern pattern1 = new Pattern();
                string actual = pattern1.ValidateUserDetails(input, pattern);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomExceptions ex)
            {
                Console.Write("\"{0}\"", ex.Message);
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]
        [DataRow("abc.xyz@bl.co.in", @"^([abc]+)(\.[a-z0-9_\+\-]+)?@([bl]+)\.([co]{2,4})(\.[a-z]{2,})?$", "Valid")]
        [DataRow(null, @"^([abc]+)(\.[a-z0-9_\+\-]+)?@([bl]+)\.([co]{2,4})(\.[a-z]{2,})?$", "Input is having null")]
        [DataRow("", @"^([abc]+)(\.[a-z0-9_\+\-]+)?@([bl]+)\.([co]{2,4})(\.[a-z]{2,})?$", "Input is having empty")]
        public void GiveInvalidUserEmailIdShouldThrowCustomExceptions(string input, string pattern, string expected)
        {
            try
            {
                //Arrange
                Pattern pattern1 = new Pattern();
                //Act
                string actual = pattern1.ValidateUserDetails(input, pattern);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (CustomExceptions ex)
            {
                Console.Write("\"{0}\"", ex.Message);
                Assert.AreEqual(expected, ex.Message);
            }
        }

        
        [TestMethod]
        [DataRow("91 8788583058", "^[1-9]{2}?([ ])[0-9]{10}$", "Valid")]
        [DataRow(null, "^[1-9]{2}?([ ])[0-9]{10}$", "Input is having null")]
        [DataRow("", "^[1-9]{2}?([ ])[0-9]{10}$", "Input is having empty")]
        public void GiveInvalidMobileNumberShouldThrowCustomExceptions(string input, string pattern, string expected)
        {
            try
            {
                //Arrange
                Pattern pattern1 = new Pattern();
                //Act
                string actual = pattern1.ValidateUserDetails(input, pattern);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (CustomExceptions ex)
            {
                Console.Write("\"{0}\"", ex.Message);
                Assert.AreEqual(expected, ex.Message);
            }
        }

   
        [TestMethod]
        [DataRow("#Vasu01SS", "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", "Valid")]
        [DataRow(null, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", "Input is having null")]
        [DataRow("", "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", "Input is having empty")]
        public void GiveInvalidUserPasswordShouldThrowCustomExceptions(string input, string pattern, string expected)
        {
            try
            {
                //Arrange
                Pattern pattern1 = new Pattern();
                //Act
                string actual = pattern1.ValidateUserDetails(input, pattern);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (CustomExceptions ex)
            {
                Console.Write("\"{0}\"", ex.Message);
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}




