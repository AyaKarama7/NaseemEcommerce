using NaseemEcommerce.Models;

namespace NaseemEcommerce.Repositories
{
    public interface ICartItemRepository
    {
        List<CartItems> GetItemsOfCart(Guid cartId);
        void Add(CartItems cartItem);
        void Update(CartItems cartItem);
        void Delete(Guid cartId, Guid productId);
        void Save();
    }
}
