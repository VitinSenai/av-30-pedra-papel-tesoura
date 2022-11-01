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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string escolhaComputador;
        int pontuacaoPc = 0;
        int pontuacaoVoce = 0;
        List<string> pedraPapelTesoura = new List<string>() { "Pedra", "Papel", "Tesoura" };
        public MainWindow()
        {
            InitializeComponent();
        }

        public void btnPedra_Click(object sender, RoutedEventArgs e)
        {
            EsconderFotos();
            var rnd = new Random();
            escolhaComputador = pedraPapelTesoura[rnd.Next(pedraPapelTesoura.Count)];
            if(escolhaComputador == "Pedra")
            {
                PedraComputador.Visibility = Visibility.Visible;
                Pedrayou.Visibility = Visibility.Visible;
                Vencedor.Text = "Empate";
                ptsPc.Text = $"{pontuacaoPc}";
                ptsVoce.Text = $"{pontuacaoVoce}";
            }
            if (escolhaComputador == "Papel")
            {
                PapelComputador.Visibility = Visibility.Visible;
                Pedrayou.Visibility = Visibility.Visible;
                pontuacaoPc++;
                Vencedor.Text = "Computador Venceu";
                ptsPc.Text = $"{pontuacaoPc}";
            }
            if (escolhaComputador == "Tesoura")
            {
                TesouraComputador.Visibility = Visibility.Visible;
                Pedrayou.Visibility = Visibility.Visible;
                pontuacaoVoce++;
                Vencedor.Text = "Você Venceu";
                ptsVoce.Text = $"{pontuacaoVoce}";
            }
        }

        private void btnPapel_Click(object sender, RoutedEventArgs e)
        {
            EsconderFotos();
            var rnd = new Random();
            escolhaComputador = pedraPapelTesoura[rnd.Next(pedraPapelTesoura.Count)];
            if (escolhaComputador == "Papel")
            {
                PapelComputador.Visibility = Visibility.Visible;
                Papelyou.Visibility = Visibility.Visible;
                Vencedor.Text = "Empate";
                ptsPc.Text = $"{pontuacaoPc}";
                ptsVoce.Text = $"{pontuacaoVoce}";
            }
            if (escolhaComputador == "Tesoura")
            {
                TesouraComputador.Visibility = Visibility.Visible;
                Papelyou.Visibility = Visibility.Visible;
                pontuacaoPc++;
                Vencedor.Text = "Computador Venceu";
                ptsPc.Text = $"{pontuacaoPc}";
            }
            if (escolhaComputador == "Pedra")
            {
                PedraComputador.Visibility = Visibility.Visible;
                Papelyou.Visibility = Visibility.Visible;
                pontuacaoVoce++;
                Vencedor.Text = "Você Venceu";
                ptsVoce.Text = $"{pontuacaoVoce}";
            }
        }

        private void btnTesoura_Click(object sender, RoutedEventArgs e)
        {
            EsconderFotos();
            var rnd = new Random();
            escolhaComputador = pedraPapelTesoura[rnd.Next(pedraPapelTesoura.Count)];
            if (escolhaComputador == "Tesoura")
            {
                TesouraComputador.Visibility = Visibility.Visible;
                Tesourayou.Visibility = Visibility.Visible;
                Vencedor.Text = "Empate";
                ptsPc.Text = $"{pontuacaoPc}";
                ptsVoce.Text = $"{pontuacaoVoce}";
            }
            if (escolhaComputador == "Pedra")
            {
                PedraComputador.Visibility = Visibility.Visible;
                Tesourayou.Visibility = Visibility.Visible;
                pontuacaoPc++;
                Vencedor.Text = "Computador Venceu";
                ptsPc.Text = $"{pontuacaoPc}";
            }
            if (escolhaComputador == "Papel")
            {
                PapelComputador.Visibility = Visibility.Visible;
                Tesourayou.Visibility = Visibility.Visible;
                pontuacaoVoce++;
                Vencedor.Text = "Você Venceu";
                ptsVoce.Text = $"{pontuacaoVoce}";
            }
        }

        private void EsconderFotos()
        {
            PapelComputador.Visibility = Visibility.Hidden;
            Papelyou.Visibility = Visibility.Hidden;
            PedraComputador.Visibility = Visibility.Hidden;
            Pedrayou.Visibility = Visibility.Hidden;
            TesouraComputador.Visibility = Visibility.Hidden;
            Tesourayou.Visibility = Visibility.Hidden;
        }
    }
}
 