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
            var foundList = await _categoryService.GetAllAsyncInclude();
            if (foundList == null)
                return NotFound();
            var mapped = _mapper.Map<IList<CategoryResVM>>(foundList);

            return View(mapped);
        }

        // GET: CategoryController/Details/5
        public async Task<ActionResult> Details(Guid id)
        {
            var found = await _categoryService.GetAsyncInclude(id);
            if (found == null)
                return NotFound();

            var mapped = _mapper.Map<CategoryResVM>(found);
            return View(mapped);
        }

        // GET: CategoryController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CategoryCreateVM model)
        {
            if (ModelState.IsValid)
            {
                var mappedGo = _mapper.Map<CategoryAppCreateDto>(model);
                var created = await _categoryService.CreateAsync(mappedGo);
                var mappedCome = _mapper.Map<CategoryResVM>(created);

                return RedirectToAction(nameof(Index));
            }

            else
            {
                ModelState.AddModelError(string.Empty, "Failed Creating Cateory");
                return View(model);
            }
        }

        // GET: CategoryController/Edit/5
        public async Task<ActionResult> Edit(Guid id)
        {
            var found = await _categoryService.GetAsyncInclude(id);
            if (found == null)
                return NotFound();

            var mapped_update = _mapper.Map<CategoryUpdateVM>(found);

            return View(mapped_update);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(CategoryUpdateVM model)
        {

            if (ModelState.IsValid)
            {
                var mappedGo = _mapper.Map<CategoryAppUpdateDto>(model);
                var updated = await _categoryService.UpdateAsyncInclude(mappedGo);
                var mappedCome = _mapper.Map<CategoryResVM>(updated);

                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError(string.Empty, $"Failed Update {model.Name}");
                return View(model);
            }
        }

        // GET: CategoryController/Delete/5
        public async Task<ActionResult> Delete(Guid id)
        {
            var found = await _categoryService.GetAsyncInclude(id);
            if (found == null)
                return NotFound();

            var mapped = _mapper.Map<CategoryResVM>(found);
            return View(mapped);
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
