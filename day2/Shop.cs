using System.Collections.Generic;
using System.Linq;

namespace day2
{
    public class Shop
    {
        private List<Book> _Order = new List<Book>();
        private Dictionary<int, int> _PriceDictionary = new Dictionary<int, int>
        {
            {1, 100},
            {2, 190},
            {3, 270},
            {4, 320},
            {5, 375},
        }; 

        public void AddOrders(List<Book> orders)
        {
            _Order = orders;
        }

        public int GetTotal()
        {
            var bookCounts =
                _Order.GroupBy(x => x.Id)
                    .Select(group => new BookCount {BookId = group.Key, Count = group.Count()}).ToList();
            return GetTotalRecursive(bookCounts);
        }

        private int GetTotalRecursive(List<BookCount> bookCounts)
        {
            var count = bookCounts.Count;
            if (count == 0)
                return 0;
            var total = _PriceDictionary[count];
            bookCounts =
                bookCounts.Where(x => x.Count > 1)
                    .Select(x => new BookCount {BookId = x.BookId, Count = x.Count - 1}).ToList();
            return total + GetTotalRecursive(bookCounts);
        }
    }
}