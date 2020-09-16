using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginScreen : ContentPage
    {
        public LoginScreen()
        {
            InitializeComponent();

            Login.Completed += (object sender, EventArgs e) =>
            {
                Password.Focus();
            };
            Password.Completed += (object sender, EventArgs e) =>
            {
                LoginButton.Focus();
            };

        }

        private void EfetuarLogin(object sender, EventArgs e)
        {
            if (Login.Text == "admin" && Password.Text == "@dmin")
            {
                DisplayAlert("Sucesso", "Login realizado com sucesso", "OK");
            }
            else
            {
                DisplayAlert("Erro", "ID e senha não conferem", "OK");
            }
        }

        private void LimpaCampos(object sender, EventArgs e)
        {
            Login.Text = string.Empty;
            Password.Text = string.Empty;
            Login.Focus();
        }

        private void ExibirCreditos(object sender, EventArgs e)
        {
            DisplayAlert("Créditos do código", "Rodrigo Santos & Fabiano Dias", "OK");
        }
    }
}