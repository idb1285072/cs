class Structure
{
    static void Main()
    {
        // Create an instance of the Category struct
        Category category = new Category();
        Category category2 = new Category(2, "Books");

        // Set the properties of the Category struct
        category.CategoryId = 1;
        category.CategoryName = "Electronics";

        // Access the properties and method of the Category struct
        System.Console.WriteLine(category.CategoryId); 
        System.Console.WriteLine(category.CategoryName); 
        System.Console.WriteLine(category.GetCategoryNameLength());
        
        System.Console.ReadLine();
    }
}