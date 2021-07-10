using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication24.Client.Pages.Resources
{
    public class RepositoryInMemory : IRepository
    {
        public List<Data> GetData()
        {
            return new List<Data>()
            {
                
        new Data() { Id=101, Name="amit", Address="Noida"},
            new Data() { Id = 101, Name = "amit", Address = "Noida" }
        };
        
        }
    }
}
