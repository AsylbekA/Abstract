using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    class Rectangle : Figure
    {
 
        public float Weigth { get; set; }
        public float Hight { get; set; }

        public override float Perimetr()
        {
            return Weigth*2+Hight*2;
        }

        
        public override float Square()
        {
            return Weigth*Hight;
        }

        public Rectangle(float weight,float hight)
        {
            Hight = hight;
            Weigth = weight;
        }

    }

}