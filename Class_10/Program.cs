using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_10
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Введите градусы:");
            double gradus_ = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите угловые минуты:");
            double min_ = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите угловые секунды:");
            double sec_ = Convert.ToInt32(Console.ReadLine());

            Corner corner = new Corner( gradus_, min_, sec_);    // создаем экземпляр класса (это будет уже объект)

            double totalRadians = corner.ToRadians();
            Console.WriteLine(totalRadians);
            Console.ReadKey();

        }
        
    }

}
