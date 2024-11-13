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
        Dictionary<Color, string> _availableColors = new Dictionary<Color, string>();
        List<string> _code = new List<string>();
        List<ComboBox> _comboBoxes = new List<ComboBox>();
        public MainWindow()
        {
            InitializeComponent();
            AddColorsToDictionary();

            _comboBoxes.Add(cboColors1);
            _comboBoxes.Add(cboColors2);
            _comboBoxes.Add(cboColors3);
            _comboBoxes.Add(cboColors4);

            GenerateRandomCode();
            foreach (string color in _code)
            {
                this.Title = this.Title + " " + color;
            }
        }

        public void AddColorsToDictionary()
        {
            _availableColors.Clear();
            _availableColors.Add(Colors.Red, "Red");
            _availableColors.Add(Colors.Blue, "Blue");
            _availableColors.Add(Colors.Green, "Green");
            _availableColors.Add(Colors.Yellow, "Yellow");
            _availableColors.Add(Colors.Orange, "Orange");
            _availableColors.Add(Colors.White, "White");
        }

        public void GenerateRandomCode()
        {
            Random rand = new Random();
            for (int i = 0; i < 4; i++)
            {
                int j = rand.Next(0,4);
                _code.Add(_availableColors.ElementAt(j).Value);
            }
        }
    }
}
