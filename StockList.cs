using System;

namespace Help_the_bookseller
{
    public class StockList
    {

        public static string StockSummary(String[] lstOfArt, String[] lstOf1StLetter)
        {

            if (lstOfArt.Length == 0) return "";

            string result = "";
            foreach (var c in lstOf1StLetter)
            {
                int tot = 0;
                foreach (var d in lstOfArt)
                {
                    if (c[0] == d[0])
                    {
                        tot += int.Parse(d.Split(' ')[1]);
                    }
                }

                if (!String.IsNullOrEmpty(result)) result += " - ";
                result += "(" + c + " : " + tot + ")";
            }
            return result;
        }


    }
}