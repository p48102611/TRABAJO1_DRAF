﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TRABAJO1_DRAF.common
{
    public class Item : IPrint, IExcute, IItem
    {
        private int id;
        private string name;
        private int price;
        private string description;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return Name; } set { name = value; } }
        public int Price { get { return price; } set { price = value; } }
        public string Description { get { return description; } set { description = value; } }

        public void ShowInfo()
        {
            throw new NotImplementedException();
        }
    }
}
