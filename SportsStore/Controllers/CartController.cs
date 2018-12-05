using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Infrastructure;
using SportsStore.Models;
using SportsStore.Models.ViewModels;

namespace SportsStore.Controllers
{
    public class CartController : Controller
    {
        private IProductRepository _repository;
        private Cart cart;

        public CartController(IProductRepository repository, Cart cartService)
        {
            _repository = repository;
             cart = cartService;
        }

        public ViewResult Index(string returnUrl) => View(new CartIndexViewModel
        {
            Cart = cart,
            ReturnUrl = returnUrl
        });

        public RedirectToActionResult AddToCart(int productId, string returnUrl)
        {
            Product product = _repository.Products.FirstOrDefault(p => p.ProductId == productId);

            if (product != null)
            {
                cart.AddItem(product, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToActionResult RemoveFromCart(int productId, string returnUrl)
        {
            Product product = _repository.Products.FirstOrDefault(p => p.ProductId == productId);

            if (product != null)
            {
                cart.RemoveLine(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
       
    }
}