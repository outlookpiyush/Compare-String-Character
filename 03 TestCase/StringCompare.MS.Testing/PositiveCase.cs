using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCompare.Logic;

namespace StringCompare.MS.Testing
{
    [TestClass]
    public class PositiveCase
    {
        #region Declaraction

        string firstInputString = string.Empty;
        string secondInputString = string.Empty;
        int? expected;

        #endregion Declaraction

        #region Test Initialization
        /// <summary>
        /// Initialization Test Value
        /// </summary>
        [TestInitialize]
        public void TestInit()
        {
            firstInputString = "010101";
            secondInputString = "101101";
            expected = 3;
        }
        #endregion Test Initialization

        #region Testing
        /// <summary>
        /// Execuate Testing Here
        /// </summary>
        [TestMethod]
        public void PositiveTesting()
        {
            //Assert 
            var charCompareFromString = new CharCompareFromString();
            int result = charCompareFromString.GetCharacterCount(firstInputString, secondInputString);

            //Act
            Assert.IsTrue(expected.Equals(result));
        }

        #endregion Testing

        #region Test Clean Up
        /// <summary>
        /// Clear Variable and Object
        /// </summary>
        [TestCleanup]
        public void TestClear()
        {
            firstInputString = string.Empty;
            secondInputString = string.Empty;
            expected = null;
        }
        #endregion Test Clean Up
    }
}
