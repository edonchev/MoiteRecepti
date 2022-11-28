namespace MoiteRecepti.Data.Models
{
    using System.Collections.Generic;

    using MoiteRecepti.Data.Common.Models;

    public class Category : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public ICollection<Recipe> Recipes =>
            new HashSet<Recipe>();
    }
}
