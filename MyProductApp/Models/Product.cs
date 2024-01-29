namespace MyProductApp.Models;


public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }


    // Constructor
    public Product()
    {
        // Set default value for Name
        Name = "defaultName";
    }

}