using System;

namespace AccessModifiers2
{
    public class Customer
    {
        public int Id { get; set; }
        public string Nama { get; set; }

        public void Promote()
        {
            var rating = CalculateRating(excludeOrders:true);
            if(rating == 0)
            {
                Console.WriteLine("Promoted Level 1");
            }
            else
            {
                Console.WriteLine("Promoted Level 2");
            }
        }

        public int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }
}
