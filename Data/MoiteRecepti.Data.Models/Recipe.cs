namespace MoiteRecepti.Data.Models
{
    using System;
    using System.Collections.Generic;

    using MoiteRecepti.Data.Common.Models;

    public class Recipe : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public TimeSpan PreparationTime { get; set; }

        public TimeSpan CookingTime { get; set; }

        public int PortionsCount { get; set; }

        // TODO: Original URL

        public string AddedByUserId { get; set; }

        public virtual ApplicationUser AddedByUser { get; set; }

        public virtual ICollection<RecipeIngredient> Ingredients =>
            new HashSet<RecipeIngredient>();

        public virtual ICollection<Image> Images =>
            new HashSet<Image>();

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
