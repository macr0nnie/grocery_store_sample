[ApiController]
[Route("api/[controller]")]
public class ProductsController: ControllerBase
{
   
   private readonly List<Product> products;
    public ProductsController(){
        //initialize products
        products = new List<Product>();
        products.Add(new Product(1, "Apple", 0.5f));
        products.Add(new Product(2, "Banana", 0.25f));
        products.Add(new Product(3, "Orange", 0.75f));
        products.Add(new Product(4, "Grapes", 1.0f));
        products.Add(new Product(5, "Mango", 1.5f));
    }
   //get all products
   [HttpGet]
   GetALLProducts(){
        //return all products
        return products;
    }
/*
   //get one product
   [HttpGet("{Id}")] 
   public ActionResult<Product> GetOneProduct(int id){
        //return one product
        foreach(Product product in products){
             if(product.ID == id){
                return product;
             }
        }
        return null; //change to 401 not found
   }
   //create a product
   [HttpPost]
   PostProduct(Product product){
        //add a product to the list
        products.Add(product);
        return product; //return the product    
   }
   //update a product


   //delete a product
*/
}