﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Model
{
    public class Account
    {
        private string _name;

        /*public string getName()
        {
            return _name;

        }
        public void setName(string name)
        {
            _name = name;
        }*/

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }


        public Account()
        {

        }

        public Account(string name)
        {
            Name = name;
        }
    }
}
