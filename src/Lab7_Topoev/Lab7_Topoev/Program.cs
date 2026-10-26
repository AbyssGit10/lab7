using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Topoev
{
     /// <summary> 
    /// Класс для расчёта скидок в системе заказов компании «Продукты-24».
    /// </summary> 
    public class DiscountCalculator
    {
        /// <summary> 
        /// Рассчитывает цену со скидкой 5%, если по товару не было заказов в прошлом месяце. 
        /// </summary> 
        /// <param name="basePrice">Базовая цена товара.</param> 
        /// <param name="hasOrdersLastMonth">Были ли заказы в прошлом 
        //месяце.</param> 
        /// <returns>Цена со скидкой или базовая цена.</returns> 
        public decimal GetDiscountedPrice(decimal basePrice, bool hasOrdersLastMonth)
        {
            if (hasOrdersLastMonth)
                return basePrice;
            return basePrice * 0.75m;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new DiscountCalculator();
            decimal price = 1000m;
            decimal discounted = calculator.GetDiscountedPrice(price, false);
            Console.WriteLine($"Базовая цена: {price}");
            Console.WriteLine($"Цена со скидкой: {discounted}");
            Console.WriteLine("Топоев И-43");
            Console.ReadKey();
        }
    }
}
