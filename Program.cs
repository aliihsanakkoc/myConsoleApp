using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new NhProductDal());
            Console.WriteLine("****************GetAllProducts*******************");
            foreach (var item in productManager.GetAllProducts()){
                Console.WriteLine($"{item.Name} isimli ürün {item.Price} TL");
            }
            Console.WriteLine("****************RateFilteredProducts*******************");
            foreach (var item in productManager.RateFilteredProducts()){
                Console.WriteLine($"{item.Name} isimli ürün {item.Price} TL");
            }
            Console.WriteLine("****************OnlyClothesFilteredProducts*******************");
            foreach (var item in productManager.OnlyClothesFilteredProducts()){
                Console.WriteLine($"{item.Name} isimli ürün {item.Price} TL, ürün tipi {item.GetType()}");
            }
        }
    }
}