using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamogoji.Classes
{
    public class petImages
    {
        public string name;

        public Image active;

        public Image calmness;

        public petImages(string name, Image active, Image calmness)
        {
            this.name = name;
            this.active = active;
            this.calmness = calmness;
        }
    }
    
}
