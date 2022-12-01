namespace MoiteRecepti.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using MoiteRecepti.Services.Data;
    using MoiteRecepti.Web.ViewModels.Recipes;

    public class RecipesController : BaseController
    {
        private readonly ICategoriesService categoriesService;

        public RecipesController(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
        }

        public IActionResult Create()
        {
            var viewModel = new CreateRecipeInputModel();
            viewModel.CategoryItems = this.categoriesService.GetAllAsKeyValuePairs();
            return this.View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(CreateRecipeInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.CategoryItems = this.categoriesService.GetAllAsKeyValuePairs();
                return this.View(input);
            }

            return this.Redirect("/");
        }
    }
}
