using ClassLibrary1;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkinCareAPP.Application
{
    public interface ISkincareService
    {
        IRepository<Product> GetProductRepository();
        Task CreateUserAsync(User user);
        Task AddPurchaseAsync(Purchase purchase);
        Task<List<Product>> GetProductRecommendationsAsync(int userId, int years);
    }

    public class SkincareService : ISkincareService
    {
        public SkincareService(IRepository<User> userRepository, IRepository<Purchase> purchaseRepository, IRepository<Product> productRepository)
        {
           
            UserRepository = userRepository;
            PurchaseRepository = purchaseRepository;
            this.productRepository = productRepository;
        }

        public IRepository<User> UserRepository { get; }
        public IRepository<Purchase> PurchaseRepository { get; }

        private readonly IRepository<Product> productRepository;

        public IRepository<Product> GetProductRepository()
        {
            return productRepository;
        }

        public Task CreateUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task AddPurchaseAsync(Purchase purchase)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetProductRecommendationsAsync(int userId, int years)
        {
            throw new NotImplementedException();
        }
    }
}
