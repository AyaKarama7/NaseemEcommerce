using NaseemEcommerce.Data;
using NaseemEcommerce.Models;

namespace NaseemEcommerce.Repositories
{
    public class CartItemRepository : ICartItemRepository
    {
        private readonly AppDbContext context;
        public CartItemRepository(AppDbContext context)
        {
            this.context = context;
        }
        public void Add(CartItems cartItem)
        {
            context.CartItems.Add(cartItem);
            Save();
        }

        public void Delete(Guid cartId, Guid productId)
        {
            var cartItem = context.CartItems.FirstOrDefault(ci => ci.CartId == cartId && ci.ProductId == productId);
            if (cartItem != null)
            {
                context.CartItems.Remove(cartItem);
                Save();
            }
        }

        public List<CartItems> GetItemsOfCart(Guid cartId)
        {
            return context.CartItems.Where(ci=>ci.CartId==cartId).ToList();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(CartItems cartItem)
        {
            context.CartItems.Update(cartItem);
            Save();
        }
    }
}
