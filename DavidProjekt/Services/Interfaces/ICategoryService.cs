using DavidProjekt.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DavidProjekt.Services.Interfaces
{
    public interface ICategoryService:IReadService<Category>,IWriteService<Category>
    {

    }
}
