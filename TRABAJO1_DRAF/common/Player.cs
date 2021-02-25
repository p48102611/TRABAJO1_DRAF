using System;
using System.Collections.Generic;
using System.Text;

namespace TRABAJO1_DRAF.common
{
    class Player : IPrint
    {
        private int id;
        private string name;
        private int behaviorScore;
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int BehaviorScore { get { return behaviorScore; } set { behaviorScore = value; } }

        public void ShowInfo()
        {
            throw new NotImplementedException();
        }
    }
}
