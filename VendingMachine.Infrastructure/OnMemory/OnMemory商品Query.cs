using VendingMachine.Core.Models;

namespace VendingMachine.Infrastructure.OnMemory
{
    public class OnMemory商品Query
    {
        private OnMemoryDB onMemoryDB;

        public OnMemory商品Query()
        {
            onMemoryDB = OnMemoryDB.GetInstance();
        }
        
        internal 商品 Find(商品名 商品名)
        {
            return onMemoryDB.Find(商品名);
        }
    }
}
