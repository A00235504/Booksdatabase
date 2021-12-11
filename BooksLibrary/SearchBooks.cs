using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchBooks
{
    public class SearchBooksName
    {
        public static bool checkStringContain(string Booksname, string searchValue)
        {
            if (!String.IsNullOrEmpty(Booksname) && !String.IsNullOrEmpty(searchValue) && Booksname.ToLower().Contains(searchValue.ToLower()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<string> searchStrings(List<String> stringList, string searchValue)
        {

            List<string> resultList = new List<string>();

            foreach (var element in stringList)
            {
                if (checkStringContain(element, searchValue))
                {
                    resultList.Add(element);
                }
            }

            return resultList;
        }

        public static List<string> mergeLists(List<string> stringList1, List<string> stringList2)
        {
            List<string> mergedList = new List<string>();

            mergedList = stringList1.Zip(stringList2, (string1, string2) => $"{string1} {string2}").ToList();

            return mergedList;
        }




    }
}