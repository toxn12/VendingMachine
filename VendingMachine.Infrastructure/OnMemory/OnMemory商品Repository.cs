using System.Collections.Generic;
using VendingMachine.Core.Models;
using VendingMachine.Core.Models.Repositories;

namespace VendingMachine.Infrastructure.OnMemory
{
    public class OnMemory商品Repository : I商品Repository
    {
        private OnMemoryDB onMemoryDB;

        public OnMemory商品Repository()
        {
            onMemoryDB = OnMemoryDB.GetInstance();
        }

        public void Save(商品 商品)
        {
            onMemoryDB.Add(商品);
        }
    }
}
