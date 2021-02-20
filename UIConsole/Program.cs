using Business.Concrete;
using DataAccess.Abstract.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace UIConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //IdMethotTest();
            //CarMethotTest();
            //BrandMethotTest();
            //ColorMethotTest();
            //CustomerMethotTest();
        }


        private static void CustomerMethotTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomeDal());
            //customerManager.Add(new Customer { UserId = 150, CompanyName = "kdv" });
            customerManager.Add(new Customer { UserId = 10, CompanyName = "kdv" });
        }

        private static void ColorMethotTest()
        {
            ColorManager colorManager1 = new ColorManager(new EfColorDal());
            Color color = new Color { ColorId = 1, ColorName = "Metalik" };
            colorManager1.Update(color);
            foreach (var item in colorManager1.GetAll())
            {
                Console.WriteLine(item.ColorName + item.ColorId);
            }

        }

        public static void BrandMethotTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(brand.BrandId);
            }
        }

        public static void CarMethotTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                { Console.WriteLine(car.Description + "/" + car.BrandName); }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            }
            
        }




        /*public static void IdMethotTest()
        {
            IdManager idManager = new IdManager(new InMemoryIdDal());
            Console.WriteLine("ID'ler\n");
            foreach (var id in idManager.GetById())
            {
                Console.WriteLine(id.CarId + id.BrandName);

            }
        } */
    
}
