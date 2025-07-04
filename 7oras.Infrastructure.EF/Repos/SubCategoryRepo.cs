

namespace _7oras.Infrastructure.EF.Repos
{
    public class SubCategoryRepo : BaseRepo<SubCategory>, ISubCategoryRepo
    {
        public SubCategoryRepo(AppDbContext dbContext) : base(dbContext)
        {
        }
        protected override IQueryable<SubCategory> IncludeNavProperties(DbSet<SubCategory> NavProperty)
        {
            return _dbset.Include(x => x.Products);
        }
    }
}
