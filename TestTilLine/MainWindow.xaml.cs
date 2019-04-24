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

namespace TestTilLine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

     

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = comboBox1.Text;
            textBox2.Text = comboBox2.Text;
            textBox3.Text = comboBox3.Text;
            textBox4.Text = comboBox4.Text;
            textBox5.Text = comboBox5.Text;
            textBox6.Text = comboBox6.Text;
            textBox7.Text = comboBox7.Text;

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "Mandag 08.01.2019";
            textBox10.Text = "Tirsdag 09.01.2019";
            textBox11.Text = "Onsdag 10.01.2019";
            textBox12.Text = "Torsdag 11.01.2019";
            textBox13.Text = "Fredag 12.01.2019";
            textBox14.Text = "lørdag 13.01.2019";
            textBox15.Text = "Søndag 14.01.2019";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            comboBox1.SelectedValue = 0;
            comboBox2.SelectedValue = 0;
            comboBox3.SelectedValue = 0;
            comboBox4.SelectedValue = 0;
            comboBox5.SelectedValue = 0;
            comboBox6.SelectedValue = 0;
            comboBox7.SelectedValue = 0;



        }
    }
}
