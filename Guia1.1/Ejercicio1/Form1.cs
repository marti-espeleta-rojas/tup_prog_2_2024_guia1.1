using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string marca;
        public int modelo, vidaUtil;
        public int añoAcalcular;
        public double valorFabricacion, tasaDepreciacion;
        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {
            marca = tbMarca.Text;
            modelo = Convert.ToInt32(cbModelo.Text);
            añoAcalcular = Convert.ToInt32(cbAño.Text);
            valorFabricacion = Convert.ToDouble(tbValorFabricacion.Text);
            vidaUtil = Convert.ToInt32(tbVidaUtil.Text);
            tasaDepreciacion = Convert.ToDouble(tbTasaDepreciacion.Text);
            Moto moto = new Moto(marca, modelo, valorFabricacion);
            VerResultados ver = new VerResultados();
            ver.lbxResultados.Items.Add($"Marca: {moto.Marca}, Modelo: {moto.Modelo}, Valor Fabricación: {moto.ValorFabricacion:C}");
            ver.lbxResultados.Items.Add($"Depreciación Lineal: {moto.CalcularDepreciacionLineal(añoAcalcular, vidaUtil):C}, Depreciación Anual: {moto.CalcularDepreciacionAnual(añoAcalcular, tasaDepreciacion):C}");
            ver.ShowDialog();
        }
    }
}
