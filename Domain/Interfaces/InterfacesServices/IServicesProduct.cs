using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.InterfacesServices
{
    public interface IServicesProduct
    {
        Task AddProduct(Produto produto);
        Task UpdateProduct(Produto produto);

    }
}
