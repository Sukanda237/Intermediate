using System.Collections.Generic;

namespace Fields
{
    public class Customer
    {
        public int Id;
        public string Nama;
        public readonly List<Order> Orders = new List<Order>();

        //public Customer()
        //{
        //    Orders = new List<Order>();
        //}

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string nama) : this(id)
        {
            this.Nama = nama;
        }

        public void Promote()
        {
            //Orders = new List<Order>();
        }
    }
}
