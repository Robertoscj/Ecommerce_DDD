using Domain.Interfaces.InterfacesProduct;
using Entities.Entities;
using Infrastructure.Repository.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Repositories
{
    internal class RepositoryProduct : RepositoryGenerics<Produto>,IProduct
    {
    }
}
