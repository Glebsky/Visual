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

namespace FbPoster
{
    /// <summary>
    /// Interaction logic for Options.xaml
    /// </summary>
    public partial class Options : Window
    {
        public int seconds;
        public bool isTimerWork;
        public bool isTopMost;
        public Options()
        {
            InitializeComponent();
        }

        public Options(int seconds, bool isTimerWork, bool isTopMost)
        {
            InitializeComponent();
            SecondsBox.Text = (seconds / 60).ToString();
            if (isTimerWork)
                IsTimerWorkCHK.IsChecked = true;
            this.seconds = seconds;
            this.isTimerWork = isTimerWork;
            if (isTopMost)
                OverWindowBox.IsChecked = true;

        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            seconds = Convert.ToInt32(SecondsBox.Text) * 60;
            if (IsTimerWorkCHK.IsChecked == true)
                isTimerWork = true;
            else
                isTimerWork = false;
            if (OverWindowBox.IsChecked == true)
                isTopMost = true;
            else
                isTopMost = false;
        }
    }
}
