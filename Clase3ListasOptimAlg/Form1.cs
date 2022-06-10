using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase3ListasOptimAlg
{
    public partial class Form1 : Form
    {
        Empleados e = new Empleados();
        List<Empleados> emp = new List<Empleados>();
        

        /*public static List<Empleados> GetEmpleados() {
            
            return emp;
        } */
        int b =1;

        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void Select(int a)
        {

            switch (a)
            {
                case 1:
                    {
                        e.id = b;
                        e.nombre = textBox1.Text;
                        e.cargo = textBox2.Text;
                        e.sueldo = Convert.ToInt32(textBox3.Text);
                        e.sfs = e.Sfs(e.sueldo);
                        e.afp = e.Afp(e.sueldo);
                        e.td = e.Td(e.sfs, e.afp);
                        e.ts = e.Ts(e.sueldo, e.td);

                        emp.Add(new Empleados() {
                            id=e.id,
                            nombre = textBox1.Text,
                            cargo= textBox2.Text,
                            sueldo= Convert.ToInt32(textBox3.Text),
                            sfs= e.Sfs(e.sueldo),
                            afp = e.Afp(e.sueldo),
                            td = e.Td(e.sfs, e.afp),
                            ts = e.Ts(e.sueldo, e.td)

                    });


                        
                        break;
                    }

                case 2:
                    {
                        
                        listBox1.Items.Add("ID: "+e.id);
                        listBox1.Items.Add("Nombre: " + e.nombre);
                        listBox1.Items.Add("Cargo: " + e.cargo);
                        listBox1.Items.Add("Sueldo: " + e.sueldo);
                        listBox1.Items.Add("Seguro Familiar de Salud: " + e.sfs);
                        listBox1.Items.Add("Administracion de Fondo de Pensiones: " + e.afp);
                        listBox1.Items.Add("Total de Descuento: " + e.td);
                        listBox1.Items.Add("Total de Sueldo: " + e.ts);

                        break;
                    }

                case 3:
                    {
                        int z = Convert.ToInt32(textBox4.Text);

                        var p = emp.Find(x => x.id == z).id;
                        var p1 = emp.Find(x => x.id == z).nombre;
                        var p2 = emp.Find(x => x.id == z).cargo;
                        var p3 = emp.Find(x => x.id == z).sueldo;
                        var p4 = emp.Find(x => x.id == z).sfs;
                        var p5 = emp.Find(x => x.id == z).afp;
                        var p6 = emp.Find(x => x.id == z).td;
                        var p7 = emp.Find(x => x.id == z).ts;

                        listBox1.Items.Add(p);
                        listBox1.Items.Add(p1);
                        listBox1.Items.Add(p2);
                        listBox1.Items.Add(p3);
                        listBox1.Items.Add(p4);
                        listBox1.Items.Add(p5);
                        listBox1.Items.Add(p6);
                        listBox1.Items.Add(p7);


                        break;
                    }

                case 4:
                    {
                        int z = Convert.ToInt32(textBox5.Text);
                        emp.RemoveAt(z-1);
                        if(emp.Exists(x=>x.id==z)==false)
                        {
                            DialogResult res = MessageBox.Show("Esta seguro de eliminar su registro", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            if (res == DialogResult.OK)
                            {
                                MessageBox.Show("Registro eliminado");
                                this.Close();
                            }
                            if (res == DialogResult.Cancel)
                            {
                                this.Close();
                            }

                        }

                        break;
                        
                    }

                case 5:
                    {
                        foreach (Empleados empi in emp)
                        {
                            listBox1.Items.Add(" ");
                            listBox1.Items.Add("ID: " + empi.id);
                            listBox1.Items.Add("Nombre: " + empi.nombre);
                            listBox1.Items.Add("Cargo: " + empi.cargo);
                            listBox1.Items.Add("Sueldo: " + empi.sueldo);
                            listBox1.Items.Add("Seguro Familiar de Salud: " + empi.sfs);
                            listBox1.Items.Add("Administracion de Fondo de Pensiones: " + empi.afp);
                            listBox1.Items.Add("Total de Descuento: " + empi.td);
                            listBox1.Items.Add("Total de Sueldo: " + empi.ts);
                        }
                        break;
                    }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Select(1);
            Select(2);
            DialogResult dialogResult = MessageBox.Show("Desea continuar?","Continuar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
            
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                listBox1.Items.Clear();

                b++;

            }
            else if (dialogResult == DialogResult.No)
            {
                Application.Exit();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Select(3);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Select(4);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Select(5);
        }
    }
}
