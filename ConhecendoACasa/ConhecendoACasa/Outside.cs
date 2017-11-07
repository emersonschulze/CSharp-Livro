﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConhecendoACasa
{
    class Outside : Location
    {
        private bool hot;
        public bool Hot { get { return hot; } }

        public Outside(string name, bool hot) : base (name)
        {
            this.hot = hot;
        }

        public override string Description()
        {
            string newDescription = base.Description();
            if (hot)
                newDescription += " É muito quente!";
            return newDescription;
        }
    }
}
