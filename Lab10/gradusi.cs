using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class gradusi
    {
        int gradus;
        int minuta;
        int secunda;
        public int Gradus
        {
            get 
            {
                return gradus;
            }
            set
            {
                gradus = value;
            }
        } 
        public int Minuta
        {
            get 
            {
                return minuta;
            }
            set
            {
                Gradus+=value/60;
                minuta = value % 60;
            }
        }
        public int Secunda
        {
            get 
            {
                return secunda;
            }
            set
            {
                Minuta+=value/60;
                secunda = value % 60;
            }
        }
        public gradusi(int gradus, int minuta, int secunda)
        {
            this.Gradus = gradus;
            this.Minuta = minuta;
            this.Secunda = secunda;
        }
        public double ToRadians()
        {
            return (gradus + (minuta + secunda / 60) / 60) * Math.PI / 180;
        }
    }
}
