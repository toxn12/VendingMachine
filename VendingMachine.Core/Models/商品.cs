using System;

namespace VendingMachine.Core.Models
{
    public class 商品
    {
        public 商品(int id, 商品名 商品名, 金額 価格, 温度帯 温度帯)
        {
            if (価格.Value < 0) {
                throw new ArgumentOutOfRangeException(nameof(価格), "商品の価格は0円以上でなければいけません。"); 
            }

            this.Id = id;
            this.商品名 = 商品名;
            this.価格 = 価格;
            this.温度帯 = 温度帯;
        }

        public int Id { get; }
        public 商品名 商品名 { get; }
        public 金額 価格 { get; }
        public 温度帯 温度帯 { get; }
    }
}
