

using System.Globalization;

namespace Exercicio_herança_e_polimorfismo_2.Entities
{
    class ImportedProduct : Product
    {
        public double CustonFee { get; set; }

       public ImportedProduct()
       {
       }

        public ImportedProduct(string name, double price, double custonFee)
        : base(name, price)
        {
            CustonFee = custonFee;
        }

        public double TotalPrice()
        {
            return Price + CustonFee;
        }

        public override string Princetag()
        {
            return Name
                + " $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (customs fee: $ "
                + CustonFee.ToString("f2", CultureInfo.InvariantCulture)
                + ")";
        }
    }
}
