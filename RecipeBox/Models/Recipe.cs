using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipeBox.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string Title { get; set; }
        public string[] Ingredients { get; set; }
        public int Rating { get; set; }
        public List<RecipeTag> JoinEntities { get; }
        public ApplicationUser User { get; set; }  
    }
}