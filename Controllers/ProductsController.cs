using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASPNET_Site_1.Data;
using ASPNET_Site_1.Models.Helpers;
using ASPNET_Site_1.Models.Product;

public class ProductsController(AppDbContext context, 
    IMapper mapper) : Controller
{
    [HttpGet]
    public async Task<IActionResult> Index(ProductSearchViewModel searchModel)
    {
        ViewBag.Title = "Продукти";

        searchModel.Categories = await mapper.ProjectTo<SelectItemViewModel>(context.Categories)
            .ToListAsync();

        searchModel.Categories.Insert(0, new SelectItemViewModel
        {
            Id = 0,
            Name = "Оберіть категорію"
        });

        var query = context.Products.AsQueryable();

        if(!string.IsNullOrEmpty(searchModel.Name))
        {
            string textSearch = searchModel.Name.Trim();
            query = query.Where(p => p.Name.ToLower().Contains(textSearch.ToLower()));
        }

        if (searchModel.CategoryId != 0)
            query = query.Where(p => p.CategoryId==searchModel.CategoryId);

        if (!string.IsNullOrEmpty(searchModel.Description))
        {
            string textSearch = searchModel.Description.Trim();
            query = query.Where(p => p.Description.ToLower().Contains(textSearch.ToLower()));
        }

        var model = new ProductListViewModel();

        model.Count = query.Count();

        model.Products = mapper.ProjectTo<ProductItemViewModel>(query).ToList();
        model.Search = searchModel;

        return View(model);
    }
}
