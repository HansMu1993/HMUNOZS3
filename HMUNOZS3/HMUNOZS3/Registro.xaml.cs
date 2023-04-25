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
            lblDatoUno.Text = datoUno;
            txtDatoDos.Text = datoDos;
        }
    }
}