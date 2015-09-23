using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PotterShoppingCart;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PotterShoppingCart.Tests
{
    [TestClass()]
    public class PotterShoppingCartTests
    {
        private List<Book> books;

        [TestInitialize()]
        public void TestInit()
        {
            books = new List<Book>();
        }
        [TestMethod()]
        public void 第一集買了一本_其他都沒買_價格應為100()
        {
            // Arrange
            books.Add(new Book { Name = "HarryPotter I", Price = 100 });
            double expected = 100;
            var target = new PotterShoppingCart();

            // Act
            double actual = target.Calculate_Price(books);
           
            // Assert
            Assert.AreEqual(expected, actual);
        }
        public void 第一集買了一本_第二集也買了一本_價格應為190()
        {
            // Arrange
            books.Add(new Book { Name = "HarryPotter I", Price = 100 });
            books.Add(new Book { Name = "HarryPotter II", Price = 100 });
            double expected = 190;
            var target = new PotterShoppingCart();

            // Act
            double actual = target.Calculate_Price(books);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        public void 一二三集各買了一本_價格應為270()
        {
            // Arrange
            books.Add(new Book { Name = "HarryPotter I", Price = 100 });
            books.Add(new Book { Name = "HarryPotter II", Price = 100 });
            books.Add(new Book { Name = "HarryPotter III", Price = 100 });
            double expected = 270;
            var target = new PotterShoppingCart();

            // Act
            double actual = target.Calculate_Price(books);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        public void 一二三四集各買了一本_價格應為320()
        {
            // Arrange
            books.Add(new Book { Name = "HarryPotter I", Price = 100 });
            books.Add(new Book { Name = "HarryPotter II", Price = 100 });
            books.Add(new Book { Name = "HarryPotter III", Price = 100 });
            books.Add(new Book { Name = "HarryPotter IV", Price = 100 });
            double expected = 320;
            var target = new PotterShoppingCart();

            // Act
            double actual = target.Calculate_Price(books);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        public void 一次買了整套_一二三四五集各買了一本_價格應為375()
        {
            // Arrange
            books.Add(new Book { Name = "HarryPotter I", Price = 100 });
            books.Add(new Book { Name = "HarryPotter II", Price = 100 });
            books.Add(new Book { Name = "HarryPotter III", Price = 100 });
            books.Add(new Book { Name = "HarryPotter IV", Price = 100 });
            books.Add(new Book { Name = "HarryPotter V", Price = 100 });
            double expected = 375;
            var target = new PotterShoppingCart();

            // Act
            double actual = target.Calculate_Price(books);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        // 100*3*0.9 + 100 = 370
        public void 一二集各買了一本_第三集買了兩本_價格應為370()
        {
            // Arrange
            books.Add(new Book { Name = "HarryPotter I", Price = 100 });
            books.Add(new Book { Name = "HarryPotter II", Price = 100 });
            books.Add(new Book { Name = "HarryPotter III", Price = 100 });
            books.Add(new Book { Name = "HarryPotter III", Price = 100 });
            double expected = 370;
            var target = new PotterShoppingCart();

            // Act
            double actual = target.Calculate_Price(books);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        // 100*3*0.9 + 100*2*0.95 = 460
        public void 第一集買了一本_第二三集各買了兩本_價格應為460()
        {
            // Arrange
            books.Add(new Book { Name = "HarryPotter I", Price = 100 });
            books.Add(new Book { Name = "HarryPotter II", Price = 100 });
            books.Add(new Book { Name = "HarryPotter II", Price = 100 });
            books.Add(new Book { Name = "HarryPotter III", Price = 100 });
            books.Add(new Book { Name = "HarryPotter III", Price = 100 });
            double expected = 460;
            var target = new PotterShoppingCart();

            // Act
            double actual = target.Calculate_Price(books);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
