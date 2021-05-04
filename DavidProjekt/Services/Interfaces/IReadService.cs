using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DavidProjekt.Services.Interfaces
{
    public interface IReadService<T>
    {
        T Get(int id);
        List<T> GetAll();
    }
}
