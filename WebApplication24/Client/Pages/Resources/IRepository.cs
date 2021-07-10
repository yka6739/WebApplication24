using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication24.Client.Pages.Resources
{
    public interface IRepository
    {
        List<Data> GetData();
    }
}
