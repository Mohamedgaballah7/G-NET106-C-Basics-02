namespace C_basics02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ans.Q1
            #region printclassdata
            //Book book1 = new Book();
            //book1.title = "The Great Gatsby";
            //book1.pages = 180;
            //Console.WriteLine($"Book: {book1.title}, Pages: {book1.pages}"); 
            #endregion

            //ans.q2
            #region tostring()equals()hashcode()gettype()
            //Book book1 = new Book();
            //book1.title = "the great gatsby";
            //book1.pages = 180;
            //Console.WriteLine(book1.ToString());
            //Console.WriteLine(book1.Equals(book1));
            //Console.WriteLine(book1.GetHashCode());
            //Console.WriteLine(book1.GetType()); 
            #endregion

            //ans.q3
            /*
             Compile-time error — you can't put text (string) into an int variable.
             int pages = 464;
            */

            //ans.q4
            #region trydividebyzero()
            //try
            //{
            //    int x=10;
            //    int y=0;
            //    double result = x / y;

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //Console.WriteLine("Done"); 
            #endregion

            //ans.q5
            #region inttodouble
            //int pages = 300;
            //double doublePages = pages;
            //Console.WriteLine(doublePages); 
            #endregion

            //ans.q6
            #region doubletoint
            //double price = 49.99;
            //int intPrice = (int)price;
            //Console.WriteLine(intPrice); 
            #endregion

            //ans.q7
            #region stringtointconvert()
            //    string pagesText = "464";
            //    Console.WriteLine(Convert.ToInt32(pagesText));

            #endregion

            //ans.q8
            #region parse()&tryParse()
            //string yearText = "2023";
            //string badText = "abc";
            //int year=int.Parse(yearText);
            //Console.WriteLine(year);   // year text
            //bool bad = int.TryParse(badText, out int badValue);  // bad text
            //if (bad) {
            //    Console.WriteLine(badValue);
            //}else { Console.WriteLine("Invalid number"); } 
            #endregion

            //ans.q9
            #region intTostring
            //int pages = 464;
            //string pagesText = pages.ToString();
            //Console.WriteLine(pagesText.GetType()); 
            #endregion
        }
    }
}
