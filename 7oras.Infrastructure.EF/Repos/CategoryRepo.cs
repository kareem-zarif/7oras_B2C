namespace _7oras.Infrastructure.EF.Repos
{
    public class CategoryRepo : BaseRepo<Category>, ICategoryRepo
    {
        protected override IQueryable<Category> IncludeNavProperties(DbSet<Category> NavProperty)
        {
            return _dbset.Include(x => x.SubCategories);
        }

    }
}
