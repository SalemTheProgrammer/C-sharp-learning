﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Plane
    {
        public int Capacity {  get; set; }

        public DateTime Manufacture {  get; set; }

        public int PlaneId { get; set; }

        public PlaneType PlaneType { get; set; }

        

      //  public  int MyProp { get; set;} 
    }
}
