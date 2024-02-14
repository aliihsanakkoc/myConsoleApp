using System.Collections.Generic;
public class NhProductDal:IProductDal{
    List<Product> products;
    public NhProductDal()
    {
        Book geometri = new Book(){Id=6, Name="Geometri", Price=150, Rate=20, Isbn= "1234567890106", Writer="Atatürk", Publisher="YKY" };
        Clothes tshirt = new Clothes(){Id=7, Name="Tshirt", Price=500, Rate=10, Color="Mavi", Size="Medium" };
        Clothes eveningDress = new Clothes(){Id=8, Name="Abiye", Price=3000, Rate=10, Color="SaksMavisi", Size="Xlarge" };
        Food waffle = new Food(){Id=9, Name="Waffle", Price=200, Rate=10, IsItPackaged=false, Producer="" };
        Phone phone = new Phone(){Id=10, Name="RedmiNote7", Price=6000,Rate=20, Brand="Xaomi", Memory="64GB" };
        products = new(){geometri, tshirt, eveningDress, waffle, phone}; 
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