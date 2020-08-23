using VendingMachine.Core.Models;
using VendingMachine.Core.Models.Queries;

namespace VendingMachine.Core.DomainService
{
    public class 商品Service
    {
        private readonly I商品Query _商品query;

        public 商品Service(I商品Query query)
        {
            _商品query = query;
        }

        internal bool Exists(商品 商品)
        {
            var found = _商品query.Find(商品.商品名);
            return found != null;
        }
    }
}
