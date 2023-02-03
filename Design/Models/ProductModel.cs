using static System.Console;

namespace Models.ProductModel
{
  public class Product
  {
    public int PId { get; init; }
    public string PName { get; set; }
    public string PCategory { get; set; }
    public int PPrice { get; set; }
    public string PDescritption { get; set; }
    public string[] PImages { get; set; }
    public int PQuantity { get; set; } //no. of quantities available in db

    public Product(int pid, string pname, string pcategory, int pprice, string pdescription, string[] pimages, int pquantity)
    {
      PId = pid;
      PName = pname;
      PCategory = pcategory;
      PPrice = pprice;
      PDescritption = pdescription;
      PImages = pimages;
      PQuantity = pquantity;
    }
    public Product(){}

    public static void GetAllProducts()
    {
        var products = new List<Product>{
            new Product{PId = 1, PName = "ABC ",PCategory = "Shoe", PPrice = 100, 
            PDescritption = "ABC in Shoe Category", PImages = new string[] {"https://ibb.co/dJs620K","https://ibb.co/dJs620K","https://ibb.co/dJs620K"}, 
            PQuantity = 100},
            new Product{PId = 2, PName = "DEF ", PCategory = "Clothes", PPrice = 200, 
            PDescritption = "DEF in Clothes Category ", PImages = new string[] {"https://ibb.co/dJs620K","https://ibb.co/dJs620K","https://ibb.co/dJs620K"}, 
            PQuantity = 150},
            new Product{PId = 3, PName = "GHI ", PCategory = "Electronics", PPrice = 300, 
            PDescritption = "GHI in Electronics category", PImages = new string[] {"https://ibb.co/dJs620K","https://ibb.co/dJs620K","https://ibb.co/dJs620K"}, 
            PQuantity = 50},
            };
		
		foreach(var product in products)
			Console.WriteLine(product.PId + ", " +product.PName+","+ product.PCategory +","+ product.PPrice + "," +
            product.PDescritption+ ","+ product.PImages[0]+ ","+ product.PQuantity);
    }
    public static void GetProductById(int pid)
    {
      WriteLine("Return product details found by id");
    }
    public static void GetProductByName(string pname)
    {
      WriteLine("Return single product details found by product name");
    }
    public static void SortPoductsByPrice()
    {
      WriteLine("Return sorted products(asc or desc)");
    }
    public static void IsProductAvailable(int pid)
    {
        WriteLine("Either returns searched quantity or returns empty");
    }
    public static void CreateProduct(Product data)
    {
        WriteLine("Creates Product");
    }
     public static void UpdateProduct(int id)
    {
        WriteLine("Updates product details");
    }
     public static void DeleteProduct(int id)
    {
        WriteLine("Deletes Product");
    }
    public override string ToString()
    {
      return "Product ID:"  + PId + " " + "Name" + PName + " " + "Category" + PCategory + " " + "Price" + PPrice + "Description" + PDescritption + " " +
      " " + "Image" + PImages[0] + " " ;
    }
  }


}