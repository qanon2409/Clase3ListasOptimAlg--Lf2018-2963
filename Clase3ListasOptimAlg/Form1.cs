using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clase3ListasOptimAlg
{
    public partial class Form1 : Form
    {
        Empleados empleado = new Empleados();
        List<Empleados> listaEmpleados = new List<Empleados>();

        int b =1;

        public Form1()
        {
            InitializeComponent();
        }

        void Select(int a)
        {
            switch (a)
            {
                case 1:
                    {
                        empleado.id = b;
                        empleado.nombre = textBox1.Text;
                        empleado.cargo = textBox2.Text;
                        empleado.sueldo = Convert.ToInt32(textBox3.Text);
                        empleado.sfs = empleado.Sfs(empleado.sueldo);
                        empleado.afp = empleado.Afp(empleado.sueldo);
                        empleado.td = empleado.Td(empleado.sfs, empleado.afp);
                        empleado.ts = empleado.Ts(empleado.sueldo, empleado.td);

                        listaEmpleados.Add(new Empleados() {
                            id=empleado.id,
                            nombre = textBox1.Text,
                            cargo= textBox2.Text,
                            sueldo= Convert.ToInt32(textBox3.Text),
                            sfs= empleado.Sfs(empleado.sueldo),
                            afp = empleado.Afp(empleado.sueldo),
                            td = empleado.Td(empleado.sfs, empleado.afp),
                            ts = empleado.Ts(empleado.sueldo, empleado.td)
                    });
                        break;
                    }

                case 2:
                    {
                        
                        listBox1.Items.Add("ID: "+empleado.id);
                        listBox1.Items.Add("Nombre: " + empleado.nombre);
                        listBox1.Items.Add("Cargo: " + empleado.cargo);
                        listBox1.Items.Add("Sueldo: " + empleado.sueldo);
                        listBox1.Items.Add("Seguro Familiar de Salud: " + empleado.sfs);
                        listBox1.Items.Add("Administracion de Fondo de Pensiones: " + empleado.afp);
                        listBox1.Items.Add("Total de Descuento: " + empleado.td);
                        listBox1.Items.Add("Total de Sueldo: " + empleado.ts);
                        break;
                    }

                case 3:
                    {
                        int z = Convert.ToInt32(textBox4.Text);

                        var p = listaEmpleados.Find(x => x.id == z).id;
                        var p1 = listaEmpleados.Find(x => x.id == z).nombre;
                        var p2 = listaEmpleados.Find(x => x.id == z).cargo;
                        var p3 = listaEmpleados.Find(x => x.id == z).sueldo;
                        var p4 = listaEmpleados.Find(x => x.id == z).sfs;
                        var p5 = listaEmpleados.Find(x => x.id == z).afp;
                        var p6 = listaEmpleados.Find(x => x.id == z).td;
                        var p7 = listaEmpleados.Find(x => x.id == z).ts;

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
                        listaEmpleados.RemoveAt(z-1);
                        if(listaEmpleados.Exists(x=>x.id==z)==false)
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
                        foreach (Empleados empi in listaEmpleados)
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
