﻿using Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Group : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public byte MaxSize { get; set; }
    }

       
}
