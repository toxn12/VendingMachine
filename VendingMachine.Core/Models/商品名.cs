using System;

namespace VendingMachine.Core.Models
{
    public class 商品名
    {
        public 商品名(string value)
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 1 || 30 < value.Length)
            {
                throw new ArgumentException("商品名は1文字以上、30文字以内です。", nameof(value));
            }

            this.Value = value;
        }

        public string Value { get; }
    }
}
