using System;
using System.Collections.Generic;
using System.Text;

namespace TRABAJO1_DRAF.common
{
    public class Hero : IHero
    {

        private int id;
        private string name;
        private string characters;
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return Name; } set { Name = value; } }
        public string Characters { get { return Characters; } set { Characters = value; } }
    }
}
