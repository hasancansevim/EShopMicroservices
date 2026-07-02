namespace Catalog.API.Exceptions;

public class ProductNotFoundException : NotFoundException
{
    public ProductNotFoundException() : base("Product Not Found!")
    {
        
    }
    public ProductNotFoundException(Guid id) : base("Product",id)
    {
        
    }
}
