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



        }
    }
}
