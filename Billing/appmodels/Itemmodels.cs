using System;
using System.Collections.Generic;

namespace appmodels
{
   public class Itemmodels
    {
        public IDictionary<string, int> items = new Dictionary<string, int>(){
            { "mouse",10},
            { "keyboard", 20},
            { "speakers", 10},
            { "monitor",25 },
            { "headset",5 },
            { "chair",100 }
        };

    }
}
