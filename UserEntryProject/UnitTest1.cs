using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegularExpresion;
using System;

namespace UserEntryProject
{
    [TestClass]
    public class UnitTest1
    {
            [TestMethod]
            [DataRow("Varsha", "^[A-Z]{1}[a-z]{2,}$", "Valid")]
            public void CheckValidationForFirstName(string input, string pattern, string expected)
            {
                //Arrange
                Pattern pattern1 = new Pattern();
                //Act
                string actual = pattern1.ValidateUserEntry(input, pattern);
                //Assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            [DataRow("Gunjal", "^[A-Z]{1}[a-z]{2,}$", "Valid")]
            public void CheckValidationForLastName(string input, string pattern, string expected)
            {
                //Arrange
                Pattern pattern1 = new Pattern();
                //Act
                string actual = pattern1.ValidateUserEntry(input, pattern);
                //Assert
                Assert.AreEqual(expected, actual);
            }

            /// <summary>
            /// TC3-Email has 3 mandatory parts (abc, bl & co) and 2 optional(xyz & in) with precise @ and.positions
            /// </summary>
            [TestMethod]
            [DataRow("abc.xyz@bl.co.in", @"^([abc]+)(\.[a-z0-9_\+\-]+)?@([bl]+)\.([co]{2,4})(\.[a-z]{2,})?$", "Valid")]
            public void CheckValidationForEmailId(string input, string pattern, string expected)
            {
                //Arrange
                Pattern pattern1 = new Pattern();
                //Act
                string actual = pattern1.ValidateUserEntry(input, pattern);
                //Assert
                Assert.AreEqual(expected, actual);
            }

            /// <summary>
            /// TC4-Country code follow by space and 10 digit number.
            /// </summary>
     
            [TestMethod]
            [DataRow("91 8788583058", "^[1-9]{2}?([ ])[0-9]{10}$", "Valid")]
            public void CheckValidationForMobileNumber(string input, string pattern, string expected)
            {
                //Arrange
                Pattern pattern1 = new Pattern();
                //Act
                string actual = pattern1.ValidateUserEntry(input, pattern);
                //Assert
                Assert.AreEqual(expected, actual);
            }

            /// <summary>
            /// TC5-Password Validation.
            /// </summary>
       
            [TestMethod]
            [DataRow("Vasusss88#", "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", "Valid")]
            public void CheckValidationForPassword(string input, string pattern, string expected)
            {
                //Arrange
                Pattern pattern1 = new Pattern();
                //Act
                string actual = pattern1.ValidateUserEntry(input, pattern);
                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
    }


