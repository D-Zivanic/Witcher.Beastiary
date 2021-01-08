using System;
using System.Collections.Generic;
using System.Linq;
using Witcher.Beastiary.Data.Context;
using Witcher.Beastiary.Core.Models;
using Witcher.Beastiary.Data.Interface;
using Microsoft.EntityFrameworkCore;

namespace Witcher.Beastiary.Data.Services
{
    public class SqlMonsterData : IMonsterData
    {
        private readonly MonsterDbContext _db;

        public SqlMonsterData(MonsterDbContext db)
        {
            _db = db;
        }

        public MonsterModel Create(MonsterModel newMonster)
        {
            _db.Add(newMonster);
            Save();
            return newMonster;
        }

        public MonsterModel Delete(int id)
        {
            var monster = GetSingle(id);
            _db.Remove(monster);
            Save();
            return monster;
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

        public MonsterModel Update(MonsterModel updateMonster)
        {
            var entity = _db.Beastiary.Attach(updateMonster);
            entity.State = EntityState.Modified;
            Save();
            return updateMonster;
        }
    }
}
