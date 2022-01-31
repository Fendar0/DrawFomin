using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawNikonov
{
    class Figure
    {
        public float pos_x, pos_y;
        public bool selected;
        public string id;

        public Figure()
        {
            selected = false;
        }

        virtual public bool test(float x, float y)
        {
            return false;
        }

        virtual public void draw(Graphics g)
        {
           
        }



    }
}
