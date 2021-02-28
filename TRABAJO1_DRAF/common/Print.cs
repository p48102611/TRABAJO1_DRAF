using System;
using System.Collections.Generic;
using System.Text;

namespace TRABAJO1_DRAF.common
{
    class Print : IExcute
    {
        public void ShowInfo(IPrint p)
        {
            p.ShowInfo();
        }
    }
}
