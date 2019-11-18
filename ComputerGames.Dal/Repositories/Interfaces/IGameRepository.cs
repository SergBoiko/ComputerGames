using ComputerGames.Dal.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGames.Dal.Repositories.Interfaces
{
    public interface IGameRepository: IRepository<GameEntity>
    {
    }
}
