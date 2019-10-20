using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;


namespace BookTest
{
    [TestClass]
    public class BookTest
    {
        //  Book book = new Book("sdada", "dsadda", 32 , "dsada");




        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void TitleException()
        {

            Book book = new Book("xd", "xd", 55, "1125456789126");


        }
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void PageException()
        {
            Book book = new Book("pa", "la", 5, "2126456789122");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void ISBNException()
        {
            Book book = new Book("pa", "la", 35, "he");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void StringMethod()
        {
            Book book = new Book("da", "ama", 15, "ne");

            book.ToString();

        }

    }
}