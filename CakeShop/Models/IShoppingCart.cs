﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace CakeShop.Models
{
    public interface IShoppingCart
    {
        string Id { get; set; }
        IEnumerable<ShoppingCartItem> ShoppingCartItems { get; set; }

        Task<int> AddToCartAsync(Cake cake, int qty = 1);
        Task ClearCartAsync();
        Task<IEnumerable<ShoppingCartItem>> GetShoppingCartItemsAsync();
        Task<int> RemoveFromCartAsync(Cake cake);
        Task<decimal> GetShoppingCartTotalAsync();
    }
}