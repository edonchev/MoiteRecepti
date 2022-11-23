namespace MoiteRecepti.Data.Models
{
    using System.Collections.Generic;

    using MoiteRecepti.Data.Common.Models;

    public class Ingredient : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public virtual ICollection<RecipeIngredient> Recipes =>
            new HashSet<RecipeIngredient>();
    }
}
