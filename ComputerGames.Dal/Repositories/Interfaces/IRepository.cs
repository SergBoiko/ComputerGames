using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGames.Dal.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        List<T> GetAll();

        void Create(T model);

        void Update(T model);

        void Delete(int id);
    }
}
