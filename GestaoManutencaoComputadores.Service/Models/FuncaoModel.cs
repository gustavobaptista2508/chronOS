﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronos.Service.Models
{
    public class FuncaoModel
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _funcao;

        public string Funcao
        {
            get { return _funcao; }
            set { _funcao = value; }
        }
    }
}
