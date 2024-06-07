using Example.Models;

namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            #region book adding
            int isCountinue = 0;

            Console.WriteLine("enter book details. if you want add another book enter 1, else enter 0");
            while (true)
            {
                isCountinue = Convert.ToInt32(Console.ReadLine());
                if (isCountinue == 1)
                {
                    library.AddBook();
                }
                else
                {
                    break;
                }
            }
            #endregion

            library.FindAllBooks("TTTTostoyevski");

            Order order = new Order();

            #region order adding
            int isCountinue2 = 0;
            int id;
            Console.WriteLine("enter book id. if you want add another book enter 1, else enter 0");
            while (true)
            {
                isCountinue2 = Convert.ToInt32(Console.ReadLine());
                if (isCountinue2 == 1)
                {
                    id = Convert.ToInt32(Console.ReadLine());
                    order.Satish(id, library);
                }
                else
                {
                    break;
                }
            }

            #endregion
        }
    }
}