using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace UIConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            Console.WriteLine("Araba Model ve Özellikleri\n" );
            foreach (var car in carManager.GetAll())
            {
                
                Console.WriteLine(car.CarId+ car.BrandId + car.ColorId + car.ModelYear+ car.DailyPrice + car.Description );
                
            }

            Console.WriteLine("\n*******************************\n");

            IdManager idManager = new IdManager(new InMemoryIdDal());
            Console.WriteLine("ID'ler\n");
            foreach (var id in idManager.GetById())
            {
                Console.WriteLine(id.CarId  + id.BrandName );
                
            }

        }
    }
}
