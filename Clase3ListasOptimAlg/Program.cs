using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Clase3ListasOptimAlg
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            /*Empleados e = new Empleados();
            List<Empleados> emp = new List<Empleados>();
            string sn = " ";
            int b=1;
            bool t=true;

            while(t)
            {
                e.id = b;
                Console.WriteLine("Escriba su nombre");
                e.nombre = Console.ReadLine();
                Console.WriteLine("Escriba su Cargo");
                e.cargo = Console.ReadLine();
                Console.WriteLine("Escriba su Sueldo");
                e.sueldo = Convert.ToDouble(Console.ReadLine());
                e.sfs = e.Sfs(e.sueldo);
                e.afp = e.Afp(e.sueldo);
                e.td = e.Td(e.sfs, e.afp);
                e.ts = e.Ts(e.sueldo, e.td);

                emp.Add(e);


                Console.WriteLine(" Desea continuar?");
                sn = Console.ReadLine();

                if (sn == "s" || sn == "S")
                {
                    b++;

                }   
                else if (sn == "n" || sn == "N")
                    t=false;



            }

            
            

            foreach (var a in emp)
            {
                Console.WriteLine(a.id);
                Console.WriteLine(a.nombre);
                Console.WriteLine(a.cargo);
                Console.WriteLine(a.sueldo);
                Console.WriteLine(a.sfs);
                Console.WriteLine(a.afp);
                Console.WriteLine(a.td);
                Console.WriteLine(a.ts);
            }

            Console.ReadKey();*/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
             //Agregar funcion de eliminar y buscar



        }







    }
   
}
