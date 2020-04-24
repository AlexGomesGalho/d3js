using Microsoft.ServiceFabric.Services.Remoting;
using System;
using System.Threading.Tasks;

namespace Communication
{
    public interface IStateLessInterface:IService 
    {
        Task<string> getServiceDetails();
        
    }
}
