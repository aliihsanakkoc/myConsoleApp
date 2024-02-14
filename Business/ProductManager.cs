using System.Collections.Generic;
using System.Linq;

public class ProductManager{
    private IProductDal _productDal;
    public ProductManager(IProductDal productDal) 
    {
        _productDal=productDal;
    }
    public List<Product> GetAllProducts(){
        return _productDal.GetAll();
    }
    public IEnumerable<Product> RateFilteredProducts() => _productDal.GetAll().Where(p=>p.Rate>10);
    public IEnumerable<Product> OnlyClothesFilteredProducts() => _productDal.GetAll().Where(p=>p.GetType().ToString()=="Clothes");
}