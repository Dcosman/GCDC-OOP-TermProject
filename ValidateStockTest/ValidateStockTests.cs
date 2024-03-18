using GCDC___OOP___TermProject;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;

namespace ValidateStockTest
{
    [TestClass]
    public class ValidateStockTests
    {
        [TestMethod]
        public void ValidateStock_ValidInput_BelowRange()
        {
            // Arrange
            Hamsters newHamster1 = new Hamsters("ABC123", "Newest hamster in town.", 199.99m, -3, "New Hamster", "Female");

            // Act / Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => newHamster1.ValidateStock());
        }
        [TestMethod]
        public void ValidateStock_ValidInput_AboveRange()
        {
            // Arrange
            Hamsters newHamster2 = new Hamsters("ABC123", "Newest hamster in town.", 199.99m, 1200, "New Hamster", "Female");

            // Act / Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => newHamster2.ValidateStock());
        }
        [TestMethod]
        public void ValidateStock_ValidInput_WithinRange()
        {
            // Arrange
            int expected = 203;
            Hamsters newHamster3 = new Hamsters("ABC123", "Newest hamster in town.", 199.99m, 203, "New Hamster", "Female");

            // Act
            newHamster3.ValidateStock();

            // Assert
            int actual = newHamster3.InStock;
            Assert.AreEqual(expected, actual);
        }
    }
}