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

namespace Prova_19_04
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string nome = TextNome.Text, data = DataNasc.Text, sexo = Sexo.Text, tiposan = TipoSan.Text, fator = FatorRH.Text, nomemae = NomeMae.Text, nomepai = NomePai.Text, responsavel = Responsavel.Text, telrespon = Telrespon.Text, log = Logadouro.Text, nomerua = NomeRua.Text, number = NumeroRua.Text, bairro = Bairro.Text, cid = Cidade.Text, cep = Cep.Text ;

            MessageBox.Show("Nome: " + nome + "\nData de Nascimento: " + data + "\nSexo: " + sexo + "\nTipo Sanguineo: " + tiposan + "\nFator RH: " + fator + "\nNome da mãe: " + nomemae + "\nNome do Pai: " + nomepai + "\nResponsável: " + responsavel + "\nTelefone do Responsavel: " + telrespon + "\nLogadouro: " + log + "\nNome da Rua: " + nomerua + "\nNumero da Rua: " + number + "\nBairro: " + bairro + "\nCidade: " + cid + "\nCEP: " + cep );
        }
    }
}
