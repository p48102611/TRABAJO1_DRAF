﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TRABAJO1_DRAF.common
{
    class Banned : IBanned, IExecute
    {
        public void BanHero(List<Hero> list, int id)
        {
            var h = list.SingleOrDefault(e => e.Id == id);
            h.ChangeState();
        }
    }
}
