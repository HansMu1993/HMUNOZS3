using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HMUNOZS3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string datoUno , string datoDos)
        {
            InitializeComponent();
            lblUsuario.Text = datoUno; 
        }


        //CALCULO DEL BOTON PRIMER PARCIAL
        private void btnCalcular_Clicked(object sender, EventArgs e)
        {

            if (ValidarNumeroSegmento(txtSeg1.Text) && ValidarNumeroSegmento(txtExam1.Text))
            {
                double suma = Calcular(txtSeg1.Text, txtExam1.Text);
                txtRespuesta1.Text = suma.ToString();

            }
            else
            {
                Limpiar();
                DisplayAlert("Mensaje de Error", "Ha ocurrido un Error", "Cerrar");
            }



        }



        //VALIDACION DE SEGMENTO RANGO DE NUMEROS 

        private bool ValidarNumeroSegmento(string valor)
        {

            try
            {
                double dato = Convert.ToDouble(valor);

                if (dato < 0.1 || dato > 10)
                {
                    DisplayAlert("Mensaje de Error", "El valor " + valor + "  No tiene rango de 0.1 a 10 ", "Cerrar");
                    Limpiar();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                DisplayAlert("Mensaje de Error", "El valor " + valor + "No es un numero ", "Cerrar");
                Limpiar();
                return false;
            }




        }


        //LIMPIEZA EN CASO DE ERROR 
        private void Limpiar()
        {
            txtSeg1.Text = "";
            txtExam1.Text = "";
            txtRespuesta1.Text = "";
        }
        private double Calcular(string Nota, string Exam)
        {
            double datoUno, datoUDos, sumar;

            datoUno = Convert.ToDouble(Nota);
            datoUDos = Convert.ToDouble(Exam);
            datoUno = datoUno * 0.3;
            datoUDos = datoUDos * 0.2;

            sumar = datoUno + datoUDos;
            return sumar;
        }

        //CLACULAR EL ESTADO 
        private string CalcularEstado(double Exam)
        {
            string valor = "";
            if (Exam >= 7)
                valor = "Aprobado";

            if (Exam >= 5 && Exam <= 6.9)
                valor = "Complementario";

            if (Exam < 5)
                valor = "REPROBADO";

            return valor;

        }

        //CALCULAR PARCIAL DOS Y NOTA FINAL
        private void btnCalcularParcial2_Clicked(object sender, EventArgs e)
        {
            double suma2, suma, resul;

            if (ValidarNumeroSegmento(txtSeg1.Text) && ValidarNumeroSegmento(txtExam1.Text))
            {
                suma = Calcular(txtSeg1.Text, txtExam1.Text);


                suma2 = Calcular(txtSeg2.Text, txtExam2.Text);
                txtResultado2.Text = suma2.ToString();

                resul = suma + suma2;

                txtEstado.Text = "Estado :" + CalcularEstado(resul);

                txtNotaFinal.Text = resul.ToString();


            }
            else
            {
                Limpiar();
                DisplayAlert("Mensaje de Error", "Ha ocurrido un Error", "Cerrar");
            }

        }

    }
}