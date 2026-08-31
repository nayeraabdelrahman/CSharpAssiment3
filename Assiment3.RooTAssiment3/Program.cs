namespace Assiment2.SolutionForFirstFiveQuetions
{
    class Book
    {
        public string Title = "";
        public int Pages;
    }

    class Program
    {
        static void Main()
        {

            #region Question 6
            {
                double price = 49.99;

                int newPrice = (int)price;

                Console.WriteLine(newPrice);
            }
            #endregion


            #region Question 7
            {
                string pagesText = "464";

                int pages = Convert.ToInt32(pagesText);

                Console.WriteLine(pages);
            }
            #endregion
            #region Question 8
            {
                string yearText = "2023";

                int year = int.Parse(yearText);

                Console.WriteLine(year);


                string badText = "abc";

                int number;

                bool result = int.TryParse(badText, out number);

                if (result == false)
                {
                    Console.WriteLine("Invalid number");
                }
            }
            #endregion
            #region Question 9
            {
                int pages = 464;

                string pagesString = pages.ToString();

                Console.WriteLine(pagesString);
                Console.WriteLine(pagesString.GetType());
            }
            #endregion
            #region Question 10
            {
                int copies = 100;

                object obj = copies;

                int newCopies = (int)obj;

                Console.WriteLine(obj);
                Console.WriteLine(newCopies);
            }
            #endregion
            #region Question 11
            {
                int? year = null;

                Console.WriteLine(year.HasValue);

                year = 2023;

                Console.WriteLine(year.Value);
            }
            #endregion







        }
    }
}
