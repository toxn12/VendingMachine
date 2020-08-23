using System.Collections.Generic;
using VendingMachine.Core.Models;

namespace VendingMachine.Infrastructure.OnMemory
{
    internal class OnMemoryDB
    {
        private static OnMemoryDB instance = new OnMemoryDB();

        private Dictionary<商品名, 商品> 商品一覧;

        private OnMemoryDB()
        {
            商品一覧 = new Dictionary<商品名, 商品>();
        }

        internal static OnMemoryDB GetInstance()
        {
            return instance;
        }

        internal void Add(商品 商品)
        {
            商品一覧.Add(商品.商品名, 商品);
        }

        internal 商品 Find(商品名 商品名)
        {
            return 商品一覧[商品名];
        }
    }
}
