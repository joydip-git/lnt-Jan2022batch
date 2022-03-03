namespace ProductManagementSystem.BusinessEntities
{
    public class Category
    {
        public Category()
        {

        }
        public Category(int categoryId, string categoryName)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
        }

        //private int _categoryIdField;
        //private int _categoryNameField;
        //automatic or auto-implemented properties
        public int CategoryId { set; get; }
        public string CategoryName { get; set; }
    }
}
