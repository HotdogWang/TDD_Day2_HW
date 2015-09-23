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
    }
}
