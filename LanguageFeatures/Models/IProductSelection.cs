namespace LanguageFeatures.Models;

public interface IProductSelection {
    IEnumerable<Product>? Products { get; }
    IEnumerable<string>? Names { get => Products.Select(p => p.Name); }
}