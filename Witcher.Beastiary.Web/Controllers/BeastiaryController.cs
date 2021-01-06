using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Witcher.Beastiary.Data.Interface;

namespace Witcher.Beastiary.Web.Controllers
{
    public class BeastiaryController : Controller
    {
        private readonly IMonsterData _monsterData;

        public BeastiaryController(IMonsterData monsterData)
        {
            _monsterData = monsterData;
        }

        public IActionResult Index()
        {
            var model = _monsterData.GetAll();
            return View(model);
        }
    }
}
