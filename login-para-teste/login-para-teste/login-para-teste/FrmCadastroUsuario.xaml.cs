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
    /// Lógica interna para FrmCadastroUsuario.xaml
    /// </summary>
    public partial class FrmCadastroUsuario : Window
    {
        public FrmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void VoltarParaTelaLogin(object sender, MouseButtonEventArgs e)
        {
            FrmLoginUsuario frmLoginUsuario = new FrmLoginUsuario();
            frmLoginUsuario.Show();
            Close();
        }

        private void CadastrarUsuario(object sender, RoutedEventArgs e)
        {

        }
    }
}
