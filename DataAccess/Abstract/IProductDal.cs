using System.Collections.Generic;

public interface IProductDal{
    public List<Product> GetAll();
    public void Add(Product product);
}