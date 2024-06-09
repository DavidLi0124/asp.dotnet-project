namespace LanguageFeatures.Controllers;

public class HomeController : Controller {

    // public async Task<ViewResult> Index() {
    //     long? length = await MyAsyncMethods.GetPageLength();
    //     return View(new string[] { $"Length: {length}" });
    // }

    // public async Task<ViewResult> Index() {
    //     List<string> output= new List<string>();
    //     await foreach (long? len in MyAsyncMethods.GetPageLengths(output, "apress.com", "microsoft.com", "amazon.com")){
    //         output.Add($"Page length: {len}");
    //     }
    //     return View(output);
    // }

    // public ViewResult Index()
    // {
        // Dictionary<string, Product> products = new Dictionary<string, Product> {
        //     {"Kayak", new Product { Name = "Kayak", Price= 275M}},
        //     {"Lifejacket", new Product { Name = "Lifejacket", Price = 48.95M} }
        // };
        // Dictionary<string, Product> products = new Dictionary<string, Product>
        // {
        //     ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
        //     ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M }
        // };

        // object[] data = new object[]  { 275M, 29.95M, "apple", "orange", 100, 10 };
        // decimal total = 0;
        // // for(int i  = 0; i < data.Length;  i++){
        // //     if(data[i] is decimal d) total += d;
        // // }
        // for (int i = 0;  i < data.Length; i++) {
        //     switch (data[i]) {
        //         case decimal dValue:
        //             total += dValue;
        //             break;
        //         case int iValue when iValue > 50:
        //             total += iValue;
        //             break;
        //     }
        // }
        // ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };
        // decimal cartTotal = cart.TotalPrices();

        // Product[] productArray = {
        //     new Product { Name="Kayak" , Price=275M},
        //     new Product { Name="Lifejacket" , Price=48.95M}
        // };
        // decimal arrayTotal = productArray.Filter(p => (p?.Price??0)>20).TotalPrices();

        // return View("Index", new string[] { $"Cart Total: {cartTotal:c2}",$"Array Total: {arrayTotal:c2}" });

        // IProductSelection cart = new ShoppingCart(
        //     new Product {Name = "Kayak", Price = 275M},
        //     new Product {Name = "Lifejacket", Price=48.95M},
        //     new Product {Name = "Soccer ball", Price=19.50M},
        //     new Product { Name = "Corner flag", Price=34.95M}
        // );
        // return View(cart.Products?.Select(p => p.Name));
    // }
}