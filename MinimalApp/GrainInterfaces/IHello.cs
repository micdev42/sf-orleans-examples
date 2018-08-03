using System;
using System.Threading.Tasks;
using Orleans;

namespace GrainInterfaces
{
    public interface IHello : IGrainWithIntegerKey
    {
        Task<string> SayHello(string msg);
    }
}
