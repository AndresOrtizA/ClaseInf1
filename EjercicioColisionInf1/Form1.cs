using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace EjercicioColisionInf1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            EnDiagonal();            
        }

        private void Aleatorio()
        {
            int maximo = 100;

            int[,] matriz = new int[maximo, maximo];

            int fila1 = 0;
            int fila2 = 0;

            int columna1 = 0;
            int columna2 = 0;

            int nintentos = 0;

            bool colisiono = false;

            Random rnd1 = new Random();
            Random rnd2 = new Random();

            while (!colisiono)
            {

                System.Threading.Thread.Sleep(100);
                fila1 = rnd1.Next(0, maximo);
                System.Threading.Thread.Sleep(100);
                columna1 = rnd2.Next(0, maximo);

                //matriz[fila1, columna1] = 1;2<5

                System.Threading.Thread.Sleep(100);
                fila2 = new Random().Next(0, maximo);
                System.Threading.Thread.Sleep(100);
                columna2 = new Random().Next(0, maximo);

                if (fila1 == fila2)
                    if (columna1 == columna2)
                        colisiono = true;

                Debug.WriteLine(string.Format("Fila1: {0} Columna1: {1} Fila2: {2} Columna2 {3} ", fila1, columna1, fila2, columna2));

                nintentos++;

                Objeto1.Location = new Point(fila1, columna1);
                Objeto2.Location = new Point(fila2, columna2);


            }

            MessageBox.Show(string.Format("Colisiono en {0} Intentos! Fila1: {1}  Columna1: {2} Fila2: {3}  Columna2: {4}", nintentos, fila1, columna1, fila2, columna2));
        }

        private void EnDiagonal()
        {
            //int maximo = this.Size.Height;

            int maximo = 300;

            int fila1 = 0;
            int fila2 = maximo;

            int columna1 = 0;
            int columna2 = maximo;

            int nintentos = 0;

            bool colisiono = false;

            Objeto1.Location = new Point(0, 0);
            Objeto2.Location = new Point(maximo, maximo);           

            while (!colisiono)
            {
                System.Threading.Thread.Sleep(100);
                fila1++;
                columna1++;

                fila2--;
                columna2--;

                Objeto1.Location = new Point(fila1, columna1);
                Objeto2.Location = new Point(fila2, columna2);


                if (Objeto1.Location.X == Objeto2.Location.X && Objeto1.Location.Y == Objeto2.Location.Y)
                    colisiono = true;

                Debug.WriteLine(string.Format("Fila1: {0} Columna1: {1} Fila2: {2} Columna2 {3} ", fila1, columna1, fila2, columna2));

                nintentos++;             


            }

            MessageBox.Show(string.Format("Colisiono en {0} Intentos! Fila1: {1}  Columna1: {2} Fila2: {3}  Columna2: {4}", nintentos, fila1, columna1, fila2, columna2));

        }
    }
}
