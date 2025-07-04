using _7oras.Application.Shared.ISevices;
using _7oras.Domain.Shared;
using _7oras.UI.MVC.ViewModels;
using _7oras.UI.MVC.ViewModels.Response.Category;

namespace _7oras.UI.MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryAppService _categoryService;
        private readonly IMapper _mapper;
        public CategoryController(ICategoryAppService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        // GET: CategoryController
        public async Task<ActionResult> Index()
        {
            var response = new BaseMVCResponse<CategoryResVM>();
            try
            {
                var allCategories = await _categoryService.GetAllAsync();
                var mapped = _mapper.Map<IList<CategoryResVM>>(allCategories);

                response.Result = ResponseStatusEnum.succeed;
                return View(mapped);
            }
            catch (Exception ex)
            {
                response.Result = ResponseStatusEnum.faild;
                BaseErrorResponse error = new()
                {
                    FriendlyMessage = $"error when getting all Cargeories"
                };
                error.TechMessage.Add(ex?.Message ?? "");
                response.ErrorDetails = error;

            }

            return View(response);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
