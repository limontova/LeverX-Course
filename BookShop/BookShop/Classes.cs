namespace BookShop
{
    public class Books
    {
        private int[] _copiesOfDifferentBooks;
        public Books(int[] bookCopies)
        {
            _copiesOfDifferentBooks = bookCopies;
        }
        public int[] CopiesOfDifferentBooks { get { return _copiesOfDifferentBooks; } set { _copiesOfDifferentBooks = value; } }
    }
    public static class OperationsWithBooks
    {
        private static double CountCost(int numberOfBooks)
        {
            double bookPrice = 8;
            if (numberOfBooks == 5)
            {
                return bookPrice * 5 * 0.75;
            }
            else if (numberOfBooks == 4)
            {
                return bookPrice * 4 * 0.8;
            }
            else if (numberOfBooks == 3)
            {
                return bookPrice * 3 * 0.9;
            }
            else if (numberOfBooks == 2)
            {
                return bookPrice * 2 * 0.95;
            }
            else if (numberOfBooks == 1)
            {
                return bookPrice;
            }
            else return 0;
        }

        public static double CountPriceOfAllBooks(Books books)
        {
            int[] array = new int[5];
            array = books.CopiesOfDifferentBooks;
            int count = 0;
            double sum = 0;
            do
            {
                count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                    {
                        count++;
                        array[i]--;
                    }
                }
                sum += CountCost(count);
            }
            while (count != 0);
            return sum;
        }
    }
}   