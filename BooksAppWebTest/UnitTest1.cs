using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SearchBooks_Tests
{
    [TestClass]
    public class SearchBooksTest
    {
        [TestMethod]
        [DataRow("Book1", "B")]
        [DataRow("Book1", "b")]
        [TestCategory("Contain")]
        public void CheckStringContainNorm(string string1, string string2)
        {
            bool result = SearchBooks.SearchBooksName.checkStringContain(string1, string2);
            Assert.AreEqual(true, result);

        }

        [TestMethod]
        [DataRow("Book1", "1")]
        [DataRow("Book1", "book1")]
        [DataRow("Book1", "")]
        [DataRow("", "Book1")]
        [TestCategory("Contain")]
        public void CheckStringNotContainNorm(string string1, string string2)
        {
            bool result = SearchBooks.SearchBooksName.checkStringContain(string1, string2);
            Assert.AreNotEqual(true, result);

        }

        [TestMethod]
        [TestCategory("Contain")]
        [DataRow("Book", "ook ")]
        public void CheckStringContainNorm2(string string1, string string2)
        {
            bool result = SearchBooks.SearchBooksName.checkStringContain(string1, string2);
            Assert.AreEqual(false, result);

        }

        [TestMethod]
        [DataRow("", "b")]
        [DataRow("Book1", "")]
        [TestCategory("Contain")]
        public void CheckStringContainEmpty(string string1, string string2)
        {
            bool result = SearchBooks.SearchBooksName.checkStringContain(string1, string2);
            Assert.AreEqual(false, result);

        }

        [TestMethod]
        [TestCategory("Contain")]
        [DataRow(null, "book1")]
        [DataRow("Book1", null)]
        public void CheckStringContainNull(string string1, string string2)
        {
            bool result = SearchBooks.SearchBooksName.checkStringContain(string1, string2);
            Assert.AreEqual(false, result);

        }


        [TestMethod]
        [TestCategory("Merge")]
        public void MergeListsNorm()
        {
            List<string> list1 = new List<string> { "Book1", "Book2", "Book3" };
            List<string> list2 = new List<string> { "", "book2", "book3" };

            List<string> answer = new List<string> { "Book1 ", "Book2 book2", "Book3 book3" };

            List<string> result;

            result = SearchBooks.SearchBooksName.mergeLists(list1, list2);

            Assert.AreEqual(true, answer.SequenceEqual(result));
        }

        [TestMethod]
        [TestCategory("Merge")]
        public void MergeListsNormError1()
        {
            List<string> list1 = new List<string> { "Book1", "Book2", "Book3" };
            List<string> list2 = new List<string> { "", "book3", "book3" };

            List<string> answer = new List<string> { "Book1", "Book2 book2", "Book3 book3" };

            List<string> result;

            result = SearchBooks.SearchBooksName.mergeLists(list1, list2);

            Assert.AreNotEqual(true, answer.SequenceEqual(result));
        }


        [TestMethod]
        [TestCategory("Merge")]
        public void MergeListsNormError2()
        {
            List<string> list1 = new List<string> { "Book1", "Book2", "Book3" };
            List<string> list2 = new List<string> { "", "book2", "book3" };

            List<string> answer = new List<string> { "", "", "" };

            List<string> result;

            result = SearchBooks.SearchBooksName.mergeLists(list1, list2);

            Assert.AreNotEqual(true, answer.SequenceEqual(result));
        }


        [TestMethod]
        [TestCategory("Search")]
        public void SearchStringsNorm()
        {
            List<string> list1 = new List<string> { "Book1 ", "Book2 book2", "Book3 book3" };
            string string1 = "Book1";
            List<string> answer = new List<string> { "Book1 " };

            List<string> result;

            result = SearchBooks.SearchBooksName.searchStrings(list1, string1);

            Assert.AreEqual(true, answer.SequenceEqual(result));

        }

        [TestMethod]
        [TestCategory("Search")]
        public void SearchStringsNormError1()
        {
            List<string> list1 = new List<string> { "Book1 ", "Book2 book2", "Book3 book3" };
            string string1 = "Book1";
            List<string> answer = new List<string> { "Book1" };

            List<string> result;

            result = SearchBooks.SearchBooksName.searchStrings(list1, string1);

            Assert.AreNotEqual(true, answer.SequenceEqual(result));

        }

        [TestMethod]
        [TestCategory("Search")]
        public void SearchStringsNormError2()
        {
            List<string> list1 = new List<string> { "Book1 ", "Book2 book2", "Book3 book3" };
            string string1 = "Book1";
            List<string> answer = new List<string> { "" };

            List<string> result;

            result = SearchBooks.SearchBooksName.searchStrings(list1, string1);

            Assert.AreNotEqual(true, answer.SequenceEqual(result));

        }
    }
}