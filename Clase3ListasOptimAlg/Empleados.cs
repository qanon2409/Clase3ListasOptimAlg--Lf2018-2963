using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3ListasOptimAlg
{
    public class Empleados
    {
        public int id;
        public string nombre;
        public string cargo;
        public double sueldo;
        public double sfs;
        public double afp;
        public double td;
        public double ts;

        public double CalcularSfs(double a)
        {
           // 0.0287
            double b = 0.8596;
            double c = b * a;
            return c;
        }

        public double CalcularAfp(double p)
        {
            double z = 0.0304;
            double y = p * z;
            return y;
        }

        public double CalcularTd(double a, double b)
        {
            double c = b + a;
            return c;
        }

        public double CalcularTs(double a, double b)
        {
            double c = a - b;
            return c;
        }


    }









}
