using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using System.Runtime.CompilerServices;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace EFCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            Query();

            Console.ReadLine();
        }

        /// <summary>
        /// c# 内置委托用法
        /// </summary>
        static void delegatee()
        {
            //Action a = new Action(() => Console.WriteLine("djdkfjlsdjf"));
            //a();

            //Action<Customers> aa = x => Console.WriteLine(x.ContactName);
            //aa(new Customers{ContactName = "dfsdlkjsdlkfj"});

            //Action<int, Customers> aaa = (i, customers) => Console.WriteLine(i + customers.ContactName);
            //aaa(5, new Customers{ContactName = "hahah"});

            Func<Customers> f = () => new Customers { ContactName = "guigui" };
            Console.WriteLine(f().ContactName);

            Func<string, Customers> ff = s => new Customers { ContactName = "这是前缀" + s };
            Console.WriteLine(ff("这是屁股").ContactName);

            Func<string, string, Customers> fff = (s1, s2) => new Customers { ContactName = s1 + "这是中间" + s2 };
            Console.WriteLine(fff("这是头,", ",这是屁股").ContactName);

            Func<Customers, bool> fb = x => x.ContactName.Equals("1");
            Console.WriteLine(fb(new Customers { ContactName = "1" }));

        }
        static int Add()
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                Customers _Customers = new Customers
                {
                    CustomerID = "zouq1",
                    Address = "南山区",
                    City = "深圳",
                    Phone = "15000000000",
                    CompanyName = "泰格软件",
                    ContactName = "张永亮"
                };
                //方法一
                //db.Customers.Add(_Customers);

                //方法二
                DbEntityEntry<Customers> entry = db.Entry<Customers>(_Customers);
                entry.State = System.Data.Entity.EntityState.Added;

                return db.SaveChanges();
            }
        }

        static void Query()
        {
            using (NorthwindEntities query = new NorthwindEntities())
            {
                //DbQuery<Customers> dbQuery =
                //    query.Customers.Where(n => n.ContactName == "张永亮").OrderBy(m => m.ContactName).Take(1) as
                //        DbQuery<Customers>;

                //Customers customers = dbQuery.FirstOrDefault(); //or dbQuery.SingleOrDefault();
                //Console.WriteLine(customers.ContactName);

                //foreach (var queryCustomer in query.Customers)
                //{
                //    Console.WriteLine(queryCustomer.ContactName);
                //}


                List<Customers> list = GetListBy(x => x.ContactName == "1", y => y.CompanyName);
                foreach (var queryCustomer in list)
                {
                    Console.WriteLine(queryCustomer.ContactName + ", " + queryCustomer.CompanyName);
                }

                //Linq
                var result = 
                    from c in query.Customers
                    select c;
                //分页写法
                IQueryable<Customers> cust10 = (from c in query.Customers
                    orderby c.ContactName
                    select c).Skip(0).Take(10);
                foreach (var s in cust10)
                {
                    Console.WriteLine(s.ContactName);
                }
                //连接写法
                var joinhahah = (from a in query.Order_Details
                    join b in query.Orders
                        on a.OrderID equals b.OrderID
                    orderby b.OrderID
                    select new
                    {
                        OrderId = b.OrderID,
                        ProductId = a.ProductID,
                        UnitPrice = a.UnitPrice
                    }).Skip(0).Take(10);
                foreach (var jj in joinhahah)
                {
                    Console.WriteLine($"orderid:{jj.OrderId}, productid:{jj.ProductId}, unitprice:{jj.UnitPrice}");
                }
            }
        }

        /// <summary>
        /// 动态where条件和orderby条件进行集合筛选
        /// </summary>
        /// <typeparam name="TKey">指定排序字段名</typeparam>
        /// <param name="whereLambda">条件子句表达式，例：x => x.ContactName == "1"</param>
        /// <param name="orderLambda">排序子句表达式，例：y => y.CompanyName</param>
        /// <returns></returns>
        public static List<Customers> GetListBy<TKey>(Expression<Func<Customers, bool>> whereLambda,
            Expression<Func<Customers, TKey>> orderLambda)
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                return db.Customers.Where(whereLambda).OrderBy(orderLambda).ToList();
            }
        }
 
    }
}
