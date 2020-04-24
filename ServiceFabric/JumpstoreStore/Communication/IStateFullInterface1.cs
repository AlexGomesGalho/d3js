using Microsoft.ServiceFabric.Services.Remoting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Communication
{
    public interface IStateFullInterface1:IService
    {
        Task<string> getServiceDetails();

        Task<Product> getproductById(int id);

        Task AddProduct(Product product);
    }
}
