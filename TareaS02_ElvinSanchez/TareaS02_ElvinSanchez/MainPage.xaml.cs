using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TareaS02_ElvinSanchez
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                //asignacion de valores desde xaml
                double dato1 = Convert.ToDouble(txtDato1.Text);
                double dato2 = Convert.ToDouble(txtDato2.Text);
                double dato3 = Convert.ToDouble(txtDato3.Text);
                double dato4 = Convert.ToDouble(txtDato4.Text);

                //accion para calcular
                double parcial1 = dato1 * 0.3;
                txtP1.Text = parcial1.ToString();

                double examen1 = dato2 * 0.2;
                txtEP1.Text = examen1.ToString();

                double parcial2 = dato3 * 0.3;
                txtP2.Text = parcial2.ToString();

                double examen2 = dato4 * 0.2;
                txtEP2.Text = examen2.ToString();

                double suma1 = parcial1 + examen1;
                txtTP1.Text = suma1.ToString();

                double suma2 = parcial2 + examen2;
                txtTP2.Text = suma2.ToString();

                double total = suma1 + suma2;
                txtResultado.Text = total.ToString();

                if (total >= 7)
                {
                    txtNota.Text = "APROBADO";
                }
                else
                {
                    txtNota.Text = "REPROBADO";
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de Alerta", "ERROR" + ex.Message, "Ok.");
            }
        }
    }
}
