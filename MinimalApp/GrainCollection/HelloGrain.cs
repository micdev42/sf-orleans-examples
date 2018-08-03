using System;
using System.Threading.Tasks;
using GrainInterfaces;
using Orleans;

namespace GrainCollection
{
    public class HelloGrain : Grain, IHello
    {
        public Task<string> SayHello(string msg)
        {
            return Task.FromResult($"you said {msg}, I say hello!");
        }
    }
}
