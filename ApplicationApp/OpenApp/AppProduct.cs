using ApplicationApp.Interfaces;
using Domain.Interfaces.InterfacesProduct;
using Domain.Interfaces.InterfacesServices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationApp.OpenApp
{
    public class AppProduct : InterfaceProductApp
    {
        IProduct _IProduct;
        IServicesProduct _ServiceProduct;

        public AppProduct(IProduct IProduct, IServicesProduct IServiceProduct)
        {
            _IProduct = IProduct;
            _ServiceProduct = IServiceProduct;
        }

        public async Task AddProduct(Produto produto)
        {
            await _ServiceProduct.AddProduct(produto);
        }

        public async Task UpdateProduct(Produto produto)
        {
            await _ServiceProduct.AddProduct(produto); ;
        }


        public async Task add(Produto Objeto)
        {
            await _IProduct.add(Objeto);
        }

  

        public async Task Delete(Produto Objeto)
        {
            await _IProduct.Delete(Objeto);
        }

        public async Task<Produto> GetEntityById(int Id)
        {
           return await _IProduct.GetEntityById(Id); 
          
        }

        public async Task<List<Produto>> List()
        {
           return await _IProduct.List();
        }

        public async Task Update(Produto Objeto)
        {
            await _IProduct.Update(Objeto);
        }

        
    }
}
