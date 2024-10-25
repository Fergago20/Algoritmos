using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos
{
    public partial class Form1 : Form
    {
        MergeSort mer = new MergeSort();
        Quick quick = new Quick();
        Binaria bin = new Binaria();
        Numero num = new Numero();
        public List<int> numeros { get; set; }
        public Form1()
        {
            InitializeComponent();
            numeros = new List<int>();

        }

       

        private void Agregar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(tbNumero.Text);
            numeros.Add(numero);
            Mostrar();
        }

        private void btmMerge_Click(object sender, EventArgs e)
        {
            mer.fMergeSort(numeros, 0, numeros.Count - 1);
            Mostrar();
        }

        private void btmQuick_Click(object sender, EventArgs e)
        {
            quick.QuickSort(numeros, 0, numeros.Count - 1);
            Mostrar();
        }

        private void btmBuscar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(tbNumero.Text);
            int posicion = bin.BusquedaBinaria(numeros, numero);
            if ( posicion!= -1)
            {
                MessageBox.Show($"Numero encontrado en la posicion {posicion} de valor {numeros[posicion]}");
            }
            else { MessageBox.Show("Numero no encontrado"); }
            Mostrar();
        }

        private void Mostrar()
        {
            lbSalida.Items.Clear();
            string num="";
            for(int i=0; i< numeros.Count; i++)
            {
                num = "";
                num = numeros[i].ToString();
                lbSalida.Items.Add(num);
            }
        }
    }
}
