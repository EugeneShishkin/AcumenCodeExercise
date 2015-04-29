using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcumenCodeExercise.Models
{
    interface IProductsProvider
    {
        IEnumerable<Product> GetProducts();

        void Add(Product p);

    }
}
