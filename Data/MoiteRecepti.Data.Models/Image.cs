namespace MoiteRecepti.Data.Models
{
    using System;

    using MoiteRecepti.Data.Common.Models;

    public class Image : BaseModel<string>
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string AddedByUserId { get; set; }

        public ApplicationUser AddedByUser { get; set; }

        public string Extension { get; set; }

        public int RecipeId { get; set; }

        public virtual Recipe Recipe { get; set; }
    }
}
