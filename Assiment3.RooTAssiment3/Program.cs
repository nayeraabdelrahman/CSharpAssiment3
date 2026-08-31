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


        }
    }
}
