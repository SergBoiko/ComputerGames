using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGames.Core.Services.Interfaces
{
    public interface IModelService<T>
    {
        List<T> GetAll();

        void Create(T model);

        void Update(T model);

        void Delete(int id);
    }
}
