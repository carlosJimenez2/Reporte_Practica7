using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica7
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;


           /* List<List<string>> ListaNombres;
            ListaNombres = new List<List<string>>();



            List<string> NombresList;
            NombresList = new List<string>();

            List<string> ApellidoPaternoList;
            ApellidoPaternoList = new List<string>();

            List<string> ApellidoMaternoList;
            ApellidoMaternoList = new List<string>();

            List<string> NumeroCuentalist;
            NumeroCuentalist = new List<string>();


            NombresList.Add("Alejandro");
            NombresList.Add("Erick");
            NombresList.Add("Carlos");
            NombresList.Add("Luis Antonio");
            NombresList.Add("Sebastian Aldair");
            NombresList.Add("Luis Armando");
            NombresList.Add("Milton Osmar");

            //  NombresList.RemoveAt(3);

            ApellidoPaternoList.Add("Arzate");
            ApellidoPaternoList.Add("Barcenas");
            ApellidoPaternoList.Add("Jimenez");
            ApellidoPaternoList.Add("Laguna");
            ApellidoPaternoList.Add("Martinez");
            ApellidoPaternoList.Add("Sanchez");
            ApellidoPaternoList.Add("Sosa");

            // ApellidoPaternoList.RemoveAt(3);


            ApellidoMaternoList.Add("Gomez");
            ApellidoMaternoList.Add("Martinez");
            ApellidoMaternoList.Add("Arellano");
            ApellidoMaternoList.Add("Lopez");
            ApellidoMaternoList.Add("Andrade");
            ApellidoMaternoList.Add("Ruiz");
            ApellidoMaternoList.Add("Corona");

            // ApellidoMaternoList.RemoveAt(3);

            NumeroCuentalist.Add("314168126");
            NumeroCuentalist.Add("417092331");
            NumeroCuentalist.Add("314104326");
            NumeroCuentalist.Add("313067136");
            NumeroCuentalist.Add("313041578");
            NumeroCuentalist.Add("305303965");
            NumeroCuentalist.Add("314308067");

            //NumeroCuentalist.RemoveAt(3);

            ListaNombres.Add(ApellidoPaternoList);
            ListaNombres.Add(ApellidoMaternoList);
            ListaNombres.Add(NombresList);
            ListaNombres.Add(NumeroCuentalist);

            //tengo que checar este pedo, no esta saliendo como quiero
            // dataGridView3.ColumnCount = 4;
            dataGridView3.RowCount = 7;
            dataGridView3.Columns[0].Name = "Apellido paterno";
            dataGridView3.Columns[1].Name = "Apellido materno";
            dataGridView3.Columns[2].Name = "Nombres";
            dataGridView3.Columns[3].Name = "Numero de cuenta";
            

            for (i = 0; i < ListaNombres.Count; i++)
            {
                dataGridView3.Rows.Add();
                for (int j = 0; j < 4; j++)
                {
                    dataGridView3.Rows[i].Cells[j].Value = ListaNombres[i][j];
                }

            }*/



            string[,] NombreCompletoArray = new string[8, 4] { { "ARZATE", "GOMEZ", "JESUS ALEJANDRO", "314168126" }, { "BARCENAS", "MARTINEZ", "ERICK IVAN", "417092331" }, { "JIMENEZ", "ARELLANO", "CARLOS","314104326"}, { "LAGUNA", "LOPEZ", "LUIS ANTONIO", "313067136" }, { "MARTINEZ", "ANDRADE", "SEBASTIAN ALDAIR", "313041578" }, { "SANCHEZ", "RUIZ", "LUIS ARMANDO", "305303965" }, { "SOSA", "CORONA", "MILTON OSMAR", "314308067" }, { "Uribe", "Serralde", "Armando", "********" } };

            string[][] NombreCompletoJArray = new string[8][];

            NombreCompletoJArray[0] = new string[] { "ARZATE", "GOMEZ", "JESUS ALEJANDRO", "314168126" };
            NombreCompletoJArray[1] = new string[] { "BARCENAS", "MARTINEZ", "ERICK IVAN", "417092331" };
            NombreCompletoJArray[2] = new string[] { "JIMENEZ", "ARELLANO", "CARLOS", "314104326" };
            NombreCompletoJArray[3] = new string[] { "LAGUNA", "LOPEZ", "LUIS ANTONIO", "313067136" };
            NombreCompletoJArray[4] = new string[] { "MARTINEZ", "ANDRADE", "SEBASTIAN ALDAIR", "313041578" };
            NombreCompletoJArray[5] = new string[] { "SANCHEZ", "RUIZ", "LUIS ARMANDO", "305303965" };
            NombreCompletoJArray[6] = new string[] { "SOSA", "CORONA", "MILTON OSMAR", "314308067" };
            NombreCompletoJArray[7] = new string[] { "Uribe", "Serralde", "Armando", "*******" };

            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Apellido paterno";
            dataGridView1.Columns[1].Name = "Apellido materno";
            dataGridView1.Columns[2].Name = "Nombre";
            dataGridView1.Columns[3].Name = "Numero de cuenta";

            dataGridView2.ColumnCount = 4;
            dataGridView2.Columns[0].Name = "Apellido paterno";
            dataGridView2.Columns[1].Name = "Apellido materno";
            dataGridView2.Columns[2].Name = "Nombre";
            dataGridView2.Columns[3].Name = "Numero de cuenta";

            for (int a = 0; a < 8; a++)
            {
                dataGridView2.Rows.Add();
                for (int j = 0; j < 4; j++)
                {
                    dataGridView2.Rows[a].Cells[j].Value = NombreCompletoJArray[a][j];
                }
            }
            
            for (int b = 0; b < 8; b++)
            {
                dataGridView1.Rows.Add();
                for (int j = 0; j < 4; j++)
                {
                    dataGridView1.Rows[b].Cells[j].Value = NombreCompletoArray[ b , j];

                }
            }

           /* Queue<string> QueueNombre = new Queue<string>();
            Queue<string> QueueApellidos = new Queue<string>();
            Queue<string> QueueNumeroCuenta = new Queue<string>();
            Queue<Queue<string>> QueueNombreCompleto = new Queue<Queue<string>>();
            QueueNombre.Enqueue("JESUS ALEJANDRO");
            QueueNombre.Enqueue("ERICK IVAN");
            QueueNombre.Enqueue("LUIS ANTONIO");
            QueueNombre.Enqueue("SEBASTIAN ALDAIR");
            QueueNombre.Enqueue("LUIS ARMANDO");
            QueueNombre.Enqueue("MILTON OSMAR");
            QueueNombre.Enqueue("Armando");
            QueueApellidos.Enqueue("ARZATE");
            QueueApellidos.Enqueue("BARCENAS");
            QueueApellidos.Enqueue("LAGUNA2");
            QueueApellidos.Enqueue("MARTINEZ");
            QueueApellidos.Enqueue("SANCHEZ");
            QueueApellidos.Enqueue("SOSA");
            QueueApellidos.Enqueue("Uribe");
            QueueNumeroCuenta.Enqueue("1");
            QueueNumeroCuenta.Enqueue("2");
            QueueNumeroCuenta.Enqueue("3");
            QueueNumeroCuenta.Enqueue("4");
            QueueNumeroCuenta.Enqueue("5");
            QueueNumeroCuenta.Enqueue("6");
            QueueNumeroCuenta.Enqueue("7");
            QueueNombreCompleto.Enqueue(QueueNombre);
            QueueNombreCompleto.Enqueue(QueueApellidos);
            QueueNombreCompleto.Enqueue(QueueNombre);
            QueueNombreCompleto.Enqueue(QueueNumeroCuenta);
            QueueNombreCompleto.Enqueue(QueueApellidos);
            QueueNombreCompleto.Enqueue(QueueNumeroCuenta);

            dataGridView4.ColumnCount = 3;

            dataGridView4.Columns[0].Name = "Apellido Paterno";
            dataGridView4.Columns[1].Name = "Nombre";
            dataGridView4.Columns[2].Name = "Numero de cuenta";

            for (int contadorFilas = 0; contadorFilas < 7; contadorFilas++)
            {
                Boolean flag1 = true;
                Boolean flag2 = true;
                dataGridView4.Rows.Add();
                for (int contadorCol = 0; contadorCol < 2; contadorCol++)
                {
                    if (flag1)
                    {
                        dataGridView4.Rows[contadorFilas].Cells[contadorCol].Value = QueueApellidos.Peek();
                        QueueApellidos.Dequeue();
                        flag1 = false;
                    }
                    else if (flag2)
                    {
                        dataGridView4.Rows[contadorFilas].Cells[contadorCol].Value = QueueNombre.Peek();
                        QueueNombre.Dequeue();
                        flag2 = false;
                    }
                    else 
                    {
                        dataGridView4.Rows[contadorFilas].Cells[contadorCol].Value = QueueNumeroCuenta.Peek();
                        QueueNumeroCuenta.Dequeue();
                        flag2 = true;
                    }
                }
            }*/




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
