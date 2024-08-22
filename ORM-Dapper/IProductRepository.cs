namespace ORM_Dapper;

public interface IProductRepository
{
    IEnumerable<Product> GetAllProducts();
}