
namespace _7oras.Infrastructure.EF.Repos
{
    public class CategoryRepo : BaseRepo<Category>, ICategoryRepo
    {
        public CategoryRepo(AppDbContext dbContext) : base(dbContext)
        {
        }

        protected override IQueryable<Category> IncludeNavProperties(DbSet<Category> NavProperty)
        {
            return _dbset.Include(x => x.SubCategories);
        }

    }
}
