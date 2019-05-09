using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MVCTestEntities entities = new MVCTestEntities();
            T_Customer t_Customer = new T_Customer { Address = "东方红", Age = 26, UserName = "亮" };
            entities.T_Customer.Add(t_Customer);
            entities.SaveChanges();
        }
    }
}
