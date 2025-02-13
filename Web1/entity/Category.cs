using System.ComponentModel.DataAnnotations;

namespace Web1.entity
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }


    }
}
