using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace login_para_teste
{
    /// <summary>
    /// Lógica interna para FrmLoginUsuario.xaml
    /// </summary>
    public partial class FrmLoginUsuario : Window
    {
        public FrmLoginUsuario()
        {
            InitializeComponent();
        }

        private void AbrirTelaCadastroUsuario(object sender, MouseButtonEventArgs e)
        {
            FrmCadastroUsuario frmCadastro = new FrmCadastroUsuario();
            frmCadastro.Show();
            Close();
        }

        private void FecharAplicacao(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void FazerLogin(object sender, RoutedEventArgs e)
        {

        }
    }
}
