using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Witcher.Beastiary.Core.Models;
using Witcher.Beastiary.Data.Interface;

namespace Witcher.Beastiary.Web.Controllers
{
    public class BeastController : Controller
    {
        private readonly IMonsterData _monsterData;

        public BeastController(IMonsterData monsterData)
        {
            _monsterData = monsterData;
        }

        public IActionResult Index(int id)
        {
            var model = _monsterData.GetSingle(id);
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var newBeast = new MonsterModel();
            return View(newBeast);
        }

        [HttpPost]
        public IActionResult Create(MonsterModel newMonster)
        {
            _monsterData.Create(newMonster);
            return RedirectToAction("Index", new { newMonster.Id });
        }

        [HttpGet]
        public IActionResult Edit(int id) 
        {
            var model = _monsterData.GetSingle(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(MonsterModel updateMonster)
        {
            _monsterData.Update(updateMonster);
            return RedirectToAction("Index", new { updateMonster.Id });
        }

        public IActionResult Delete(int id)
        {
            _monsterData.Delete(id);
            return RedirectToAction("Index", "Beastiary");
        }
    }
}
