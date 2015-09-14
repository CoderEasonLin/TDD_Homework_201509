using System.Collections.Generic;
using day2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace day2Tests
{
    [TestClass]
    public class ShopTests
    {
        [TestMethod]
        public void Buy_1_Book_Should_Pay_100()
        {
            // Arrange
            var shop = new Shop();

            // Act
            shop.AddOrders(new List<Book>{
                new Book{Id=1}
            });

            // Assert
            var actualTotal = shop.GetTotal();
            var expectedTotal = 100;
            Assert.AreEqual(expectedTotal, actualTotal);
        }

        [TestMethod]
        public void Buy_2_Different_Books_Should_Pay_190()
        {
            // Arrange
            var shop = new Shop();

            // Act
            shop.AddOrders(new List<Book>{
                new Book{Id=1},
                new Book{Id=2},
            });

            // Assert
            var actualTotal = shop.GetTotal();
            var expectedTotal = 190;
            Assert.AreEqual(expectedTotal, actualTotal);
        }

        [TestMethod]
        public void Buy_3_Different_Books_Should_Pay_270()
        {
            // Arrange
            var shop = new Shop();

            // Act
            shop.AddOrders(new List<Book>{
                new Book{Id=1},
                new Book{Id=2},
                new Book{Id=3},
            });


            // Assert
            var actualTotal = shop.GetTotal();
            var expectedTotal = 270;
            Assert.AreEqual(expectedTotal, actualTotal);
        }

        [TestMethod]
        public void Buy_4_Different_Books_Should_Pay_320()
        {
            // Arrange
            var shop = new Shop();

            // Act
            shop.AddOrders(new List<Book>{
                new Book{Id=1},
                new Book{Id=2},
                new Book{Id=3},
                new Book{Id=4},
            });

            // Assert
            var actualTotal = shop.GetTotal();
            var expectedTotal = 320;
            Assert.AreEqual(expectedTotal, actualTotal);
        }

        [TestMethod]
        public void Buy_5_Different_Books_Should_Pay_375()
        {
            // Arrange
            var shop = new Shop();

            // Act
            shop.AddOrders(new List<Book>{
                new Book{Id=1},
                new Book{Id=2},
                new Book{Id=3},
                new Book{Id=4},
                new Book{Id=5},
            });

            // Assert
            var actualTotal = shop.GetTotal();
            var expectedTotal = 375;
            Assert.AreEqual(expectedTotal, actualTotal);
        }

        [TestMethod]
        public void Buy_2_Same_Books_Should_Pay_200()
        {
            // Arrange
            var shop = new Shop();

            // Act
            shop.AddOrders(new List<Book>{
                new Book{Id=1},
                new Book{Id=1},
            });

            // Assert
            var actualTotal = shop.GetTotal();
            var expectedTotal = 200;
            Assert.AreEqual(expectedTotal, actualTotal);
        }

        [TestMethod]
        public void Buy_Book1_Book2_3Book3_Should_Pay_370()
        {
            // Arrange
            var shop = new Shop();

            // Act
            shop.AddOrders(new List<Book>{
                new Book{Id=1},
                new Book{Id=2},
                new Book{Id=3},
                new Book{Id=3},
            });

            // Assert
            var actualTotal = shop.GetTotal();
            var expectedTotal = 370;
            Assert.AreEqual(expectedTotal, actualTotal);            
        }

        [TestMethod]
        public void Buy_Book1_2Book2_2Book3_Should_Pay_460()
        {
            // Arrange
            var shop = new Shop();

            // Act
            shop.AddOrders(new List<Book>{
                new Book{Id=1},
                new Book{Id=2},
                new Book{Id=2},
                new Book{Id=3},
                new Book{Id=3},
            });

            // Assert
            var actualTotal = shop.GetTotal();
            var expectedTotal = 460;
            Assert.AreEqual(expectedTotal, actualTotal);             
        }
    }
}
