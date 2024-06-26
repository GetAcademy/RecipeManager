namespace RecipeManager
{
    internal class RecipeService
    {
        private List<Recipe> _recipes;

        public RecipeService()
        {
            _recipes = new List<Recipe>();
            AddApplePieRecipe();
            AddPepperoniPizzaRecipe();
            AddDumplingsRecipe();
        }

        private void AddDumplingsRecipe()
        {
            var recipe = new Recipe("Dumplings Dough", "Subrecipes", "kdsjhfdkjh", 20);
            recipe.AddIngridient(2, "cups", "all-purpose flour");
            recipe.AddIngridient(0.5f, "cups", "warm water", "(more if needed)");
            recipe.AddIngridient(1, "pinch", "salt");
            //"-Dough-",
            //"2 cups all-purpose flour",
            //"1/2 cup warm water (more if needed)",
            //"Pinch of salt\n",

            //"-Filling-",
            //"1/2 pound ground pork (or chicken, beef, or shrimp)",
            //"1 cup finely chopped cabbage",
            //"1/4 cup finely chopped scallions (green onions)",
            //"2 cloves garlic, minced",
            //"1 tablespoon soy sauce",
            //"1 tablespoon sesame oil",
            //"1 tablespoon grated ginger",
            //"1/2 teaspoon salt",
            //"1/4 teaspoon ground white pepper\n",

            //"-Dipping Sauce-",
            //"2 tablespoons soy sauce",
            //"1 tablespoon rice vinegar",
            //"1 teaspoon sesame oil",
            //"1/2 teaspoon sugar (optional)",
            //"1 teaspoon finely chopped scallions (optional)",
            //"1 teaspoon chili flakes or chili oil (optional)"
        }

        private void AddPepperoniPizzaRecipe()
        {
            //if (title == "Pepperoni Pizza")
            //{
            //    _ingredients = new List<string>
            //    {
            //        "\n*Pepperoni Pizza*\n",
            //        "1 package (2 1/4 teaspoons) active dry yeast",
            //        "1 1/2 cups warm water (110°F)",
            //        "3 1/2 to 4 cups all-purpose flour",
            //        "2 tablespoons olive oil",
            //        "1 teaspoon sugar",
            //        "1 teaspoon salt",
            //        "1 cup tomato sauce",
            //        "1 teaspoon dried oregano",
            //        "1 teaspoon dried basil",
            //        "1/2 teaspoon garlic powder",
            //        "1/2 teaspoon onion powder",
            //        "1/2 teaspoon sugar (optional, to taste)",
            //        "Salt and pepper to taste",
            //        "2 cups shredded mozzarella cheese",
            //        "1 cup sliced pepperoni",
            //        "Fresh basil leaves (optional, for garnish)",
            //        "Olive oil (for brushing the crust)"
            //    };
            //}

        }

        private void AddApplePieRecipe()
        {
            //if (title == "Apple Pie")
            //{
            //    _ingredients = new List<string>
            //    {
            //        "*Apple Pie*\n",
            //        "2 1/2 cups all-purpose flour",
            //        "1 cup unsalted butter, chilled and diced",
            //        "1/2 teaspoon salt",
            //        "1/2 cup ice water",
            //        "7 cups thinly sliced, peeled apples",
            //        "1 cup granulated sugar",
            //        "1/2 cup packed brown sugar",
            //        "2 tablespoons all-purpose flour",
            //        "1 teaspoon ground cinnamon",
            //        "1/4 teaspoon ground nutmeg",
            //        "1 tablespoon lemon juice"
            //    };
            //}
        }
    }
}
