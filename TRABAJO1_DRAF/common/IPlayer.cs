using System;
using System.Collections.Generic;
using System.Text;

namespace TRABAJO1_DRAF.common
{
    public interface IPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BehaviorScore { get; set; }
    }
}
