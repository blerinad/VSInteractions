public class ProductContext : DbContext
{
    public DbSet<Product> Products { get; set; }
}
