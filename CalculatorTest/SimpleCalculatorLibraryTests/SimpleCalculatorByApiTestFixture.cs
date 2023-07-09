// Author: Chris Knowles
// Date: Jul 2023
// File: SimpleCalculatorByApiTestFixture.cs
// Version: 1.0.0

using SimpleCalculator;

namespace SimpleCalculatorLibraryTests
{
    /// <summary>
    ///  Test fixture to exercise the <see cref="SimpleCalculatorByApi"/> concrete
    ///  implementation intended to be utilised by an ASPNET Core Web RESTful API
    /// </summary>
    [TestClass]
    public class SimpleCalculatorByApiTestFixture
    {
        /// <summary>
        /// Property <c>CUT</c>: Class Under Test for this test fixture 
        /// /// </summary>
        public ISimpleCalculator CUT { get; private set; }
        
        /// <summary>
        /// Run before every test method to instantiate a new <see cref="SimpleCalculatorByApi"/>
        /// object
        /// </summary>
        [TestInitialize()]
        public void Setup()
        {
            CUT = new SimpleCalculatorByApi();
        }

        /// <summary>
        /// Test adding 0 and 0 : special case for 0
        /// </summary>
        [TestMethod]
        public void Test_Add_0_To_0()
        {
            // Arrange
            var start = 0;
            var amount = 0;
            var expected = 0;

            // Act
            var actual = CUT.Add(start, amount);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test adding 1 and 1 : positive boundary values
        /// </summary>
        [TestMethod]
        public void Test_Add_1_To_1()
        {
            // Arrange
            var start = 1;
            var amount = 1;
            var expected = 2;

            // Act
            var actual = CUT.Add(start, amount);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test adding -1 and -1 : negative boundery values
        /// </summary>
        [TestMethod]
        public void Test_Add_Minus1_To_Minus1()
        {
            // Arrange
            var start = -1;
            var amount = -1;
            var expected = -2;

            // Act
            var actual = CUT.Add(start, amount);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test adding -1 to 1 : positive and negative boundary values 
        /// </summary>
        [TestMethod]
        public void Test_Add_Minus1_To_1()
        {
            // Arrange
            var start = 1;
            var amount = -1;
            var expected = 0;

            // Act
            var actual = CUT.Add(start, amount);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test adding 1024 to 256 : arbitarily selected larger positive values 
        /// </summary>
        [TestMethod]
        public void Test_Add_1024_To_256()
        {
            // Arrange
            var start = 256;
            var amount = 1024;
            var expected = 1280;

            // Act
            var actual = CUT.Add(start, amount);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test adding -2023 to -128 : arbitarily selected larger negative values 
        /// </summary>
        [TestMethod]
        public void Test_Add_Minus2023_To_Minus128()
        {
            // Arrange
            var start = -128;
            var amount = -2023;
            var expected = -2151;

            // Act
            var actual = CUT.Add(start, amount);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test adding -2023 to 128 : arbitarily selected larger negative and positive
        /// values 
        /// </summary>
        [TestMethod]
        public void Test_Add_Minus2023_To_128()
        {
            // Arrange
            var start = 128;
            var amount = -2023;
            var expected = -1895;

            // Act
            var actual = CUT.Add(start, amount);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test subtracting 0 from 0 : special case for 0
        /// </summary>
        [TestMethod]
        public void Test_Subtract_0_From_0()
        {
            // Arrange
            var start = 0;
            var amount = 0;
            var expected = 0;

            // Act
            var actual = CUT.Subtract(start, amount);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test subtracting 1 from 1 : positive boundary values
        /// </summary>
        [TestMethod]
        public void Test_Subtract_1_From_1()
        {
            // Arrange
            var start = 1;
            var amount = 1;
            var expected = 0;

            // Act
            var actual = CUT.Subtract(start, amount);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test subtracting -1 from -1 : negative boundery values
        /// </summary>
        [TestMethod]
        public void Test_Subtract_Minus1_From_Minus1()
        {
            // Arrange
            var start = -1;
            var amount = -1;
            var expected = 0;

            // Act
            var actual = CUT.Subtract(start, amount);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test subtracting 1 from -1 : negative and positive boundary values 
        /// </summary>
        [TestMethod]
        public void Test_Subtract_1_From_Minus1()
        {
            // Arrange
            var start = -1;
            var amount = 1;
            var expected = -2;

            // Act
            var actual = CUT.Subtract(start, amount);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test subtracting 256 from 1024 : arbitarily selected larger positive values 
        /// </summary>
        [TestMethod]
        public void Test_Subtract_256_From_1024()
        {
            // Arrange
            var start = 1024;
            var amount = 256;
            var expected = 768;

            // Act
            var actual = CUT.Subtract(start, amount);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test subtracting -2023 from -128 : arbitarily selected larger negative values 
        /// </summary>
        [TestMethod]
        public void Test_Subtract_Minus2023_From_Minus128()
        {
            // Arrange
            var start = -128;
            var amount = -2023;
            var expected = 1895;

            // Act
            var actual = CUT.Subtract(start, amount);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test subtracting 1024 from -128 : arbitarily selected larger negative and positive
        /// values 
        /// </summary>
        [TestMethod]
        public void Test_Subtract_1024_From_Minus128()
        {
            // Arrange
            var start = -128;
            var amount = 1024;
            var expected = -1152;

            // Act
            var actual = CUT.Subtract(start, amount);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
