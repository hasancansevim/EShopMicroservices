namespace Basket.API.Exceptions;

public class BasketNotFoundException : NotFoundException
{
    public BasketNotFoundException() : base("Basket Not Found!")
    {
        
    }

    public BasketNotFoundException(string userName) : base("Basket", userName)
    {
        
    }
}
