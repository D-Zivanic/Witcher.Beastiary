using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}
