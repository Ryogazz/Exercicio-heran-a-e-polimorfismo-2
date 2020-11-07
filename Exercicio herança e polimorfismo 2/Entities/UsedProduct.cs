

using Microsoft.VisualBasic;
using System;
using System.Globalization;

namespace Exercicio_herança_e_polimorfismo_2.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate  { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string Princetag()
        {
            return Name
                + " (used)"
                + " $ "
                + Price.ToString("f2", CultureInfo.InvariantCulture)
                + "(Manufacture date: "
                + ManufactureDate.ToString("dd/mm/yyyy")
                + ")";
        }
    }
}
