using System;
using System.Collections.Generic;
using System.Linq;
using Witcher.Beastiary.Data.Context;
using Witcher.Beastiary.Core.Models;
using Witcher.Beastiary.Data.Interface;

namespace Witcher.Beastiary.Data.Services
{
    public class SqlMonsterData : IMonsterData
    {
        private readonly MonsterDbContext _db;

        public SqlMonsterData(MonsterDbContext db)
        {
            _db = db;
        }

        public MonsterModel Create(MonsterModel newBeast)
        {
            _db.Add(newBeast);
            Save();
            return newBeast;
        }

        public IEnumerable<MonsterModel> GetAll()
        {
            return _db.Beastiary.OrderBy(b => b.Name);
        }

        public MonsterModel GetSingle(int id)
        {
            return _db.Beastiary.FirstOrDefault(b => b.Id == id);
        }

        public int Save()
        {
            return _db.SaveChanges();
        }
    }
}
