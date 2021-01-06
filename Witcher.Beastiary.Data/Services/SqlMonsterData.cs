using System;
using System.Collections.Generic;
using System.Text;
using Witcher.Beastiary.Core.Context;
using Witcher.Beastiary.Core.Models;
using Witcher.Beastiary.Data.Interface;

namespace Witcher.Beastiary.Core.Services
{
    class SqlMonsterData : IMonsterData
    {
        private readonly MonsterDbContext _db;

        public SqlMonsterData(MonsterDbContext db)
        {
            _db = db;
        }
        public IEnumerable<MonsterModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public MonsterModel GetSingle(int id)
        {
            throw new NotImplementedException();
        }
    }
}
