using System.Collections.Generic;
public class EfProductDal : IProductDal
{
    List<Product> products;
    public EfProductDal()
    {
        Book nutuk = new Book(){Id=1, Name="Nutuk", Price=200, Rate=20, Isbn= "1234567890106", Writer="Atatürk", Publisher="YKY" };
        Clothes sweat = new Clothes(){Id=2, Name="Sweatshirt", Price=900, Rate=10, Color="Lacivert", Size="Large" };
        Clothes dress = new Clothes(){Id=3, Name="Elbise", Price=3000, Rate=10, Color="Kirmizi", Size="Small" };
        Food wafer = new Food(){Id=4, Name="Gofret", Price=10, Rate=10, IsItPackaged=true, Producer="Eti" };
        Phone phone = new Phone(){Id=5, Name="RedmiNote7", Price=6000,Rate=20, Brand="Xaomi", Memory="64GB" };
        products = new(){nutuk, sweat, dress, wafer, phone};
    }
    public void Add(Product product)
    {
        products.Add(product);
    }
    public List<Product> GetAll()
    {
        return products;
    }
}