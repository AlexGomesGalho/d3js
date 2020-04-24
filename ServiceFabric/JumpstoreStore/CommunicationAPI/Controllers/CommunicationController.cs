using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Communication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.ServiceFabric.Services.Remoting.Client;

namespace CommunicationAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommunicationController : ControllerBase
    {
        [HttpGet]
        [Route("stateless")]
        public async Task<String> StatelessGet()
        {
            var StatelessProxy = ServiceProxy.Create<IStateLessInterface>(
                new Uri("fabric:/JumpstoreStore/CustomerAnalytics"
                ));
            var serviceName = await StatelessProxy.getServiceDetails();
            return serviceName;

        }

        [HttpGet]
        [Route("statefull")]
        public async Task<String> StatefullGet(
            [FromQuery] int productId)
        {
            var PartitionID = productId % 3;

            var StatefullProxy = ServiceProxy.Create<IStateFullInterface1>(
                new Uri("fabric:/JumpstoreStore/ProductCatalogue"),
                new Microsoft.ServiceFabric.Services.Client.ServicePartitionKey(PartitionID));

            var serviceName = await StatefullProxy.getServiceDetails();

            return serviceName;
        }

        [HttpPost]
        [Route("addProduct")]
        public async Task AddProduct(
            [FromQuery] Product product)
        {
            var PartitionID = product.Id % 3;

            var StatefullProxy = ServiceProxy.Create<IStateFullInterface1>(
                new Uri("fabric:/JumpstoreStore/ProductCatalogue"),
                new Microsoft.ServiceFabric.Services.Client.ServicePartitionKey(PartitionID));

            await StatefullProxy.AddProduct(product);

        }

        [HttpGet]
        [Route("getproduct")]
        public async Task<Product> GetProduct(
            [FromQuery] int productId)
        {
            var PartitionID = productId % 3;

            var StatefullProxy = ServiceProxy.Create<IStateFullInterface1>(
                new Uri("fabric:/JumpstoreStore/ProductCatalogue"),
                new Microsoft.ServiceFabric.Services.Client.ServicePartitionKey(PartitionID));

            var product = await StatefullProxy.getproductById(PartitionID);

            return product;
        }
    }
}
