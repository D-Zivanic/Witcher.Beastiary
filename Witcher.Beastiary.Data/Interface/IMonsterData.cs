using System;
using System.Collections.Generic;
using System.Text;
using Witcher.Beastiary.Core.Models;

namespace Witcher.Beastiary.Data.Interface
{
    public interface IMonsterData
    {
        IEnumerable<MonsterModel> GetAll();
        MonsterModel GetSingle(int id);
        MonsterModel Create(MonsterModel newMonster);
        MonsterModel Update(MonsterModel updateMonster);
        int Save();
    }
}
