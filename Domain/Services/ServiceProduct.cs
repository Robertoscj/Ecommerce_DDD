using Domain.Interfaces.InterfacesProduct;
using Domain.Interfaces.InterfacesServices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Domain.Services
{
    public class ServiceProduct : IServicesProduct
    {
        private readonly IProduct _IProduct;

        public ServiceProduct(IProduct IProduct)
        {
            _IProduct = IProduct;
        }

        public async Task AddProduct(Produto produto)
        {
            var validarNome = produto.ValidarPropriedadeString(produto.Nome, "Nome");
            var validarValor = produto.ValidarPropriedadeDecimal(produto.Valor, "Valor");

            if(validarNome && validarValor)
            {
                produto.Estado = true;
                await _IProduct.add(produto);
            }
        }

        public async Task UpdateProduct(Produto produto)
        {
            var validarNome = produto.ValidarPropriedadeString(produto.Nome, "Nome");
            var validarValor = produto.ValidarPropriedadeDecimal(produto.Valor, "Valor");

            if (validarNome && validarValor)
            {
               
                await _IProduct.Update(produto);
            }
        }
    }
}
 