using System;
using VendingMachine.Core.DomainService;
using VendingMachine.Core.Models;
using VendingMachine.Core.Models.Repositories;

namespace VendingMachine.Core.UseCases.ベンダー業者
{
    public class 商品を登録するUseCase
    {
        private readonly 商品Service 商品Service;
        private readonly I商品Repository 商品Repos;

        public 商品を登録するUseCase(商品Service 商品Service, I商品Repository 商品Repos)
        {
            this.商品Service = 商品Service;
            this.商品Repos = 商品Repos;
        }

        public void 商品登録(商品 商品)
        {
            if (商品Service.Exists(商品))
            {
                throw new ArgumentException("すでに同じ商品が登録されています。", nameof(商品));
            }

            商品Repos.Save(商品);
        }
    }
}
