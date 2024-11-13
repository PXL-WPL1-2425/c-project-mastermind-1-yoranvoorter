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

namespace MasterMindWPL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Color[] _availableColors = { Colors.Red, Colors.Yellow, Colors.White, Colors.Green, Colors.Blue };
        public MainWindow()
        {
            InitializeComponent();
            
        }

        public void AddColorsToComboBoxes()
        {
            foreach (Color color in _availableColors)
            {
                cboColors1.Items.Add(color);
                cboColors2.Items.Add(color);
                cboColors3.Items.Add(color);
                cboColors4.Items.Add(color);
            }
        }
    }
}
