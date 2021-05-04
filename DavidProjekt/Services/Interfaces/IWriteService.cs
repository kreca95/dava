using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DavidProjekt.Services.Interfaces
{
    public interface IWriteService<T>
    {
        bool Insert(T data);
        bool InsertRange(List<T> data);
        bool Delete(T data);
        bool Update(T data);
        bool UpdateRange(List<T> data);
    }
}
