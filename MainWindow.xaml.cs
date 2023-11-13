using System;
using System.Windows;

namespace WpfDpiTest
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        protected override void OnDpiChanged(DpiScale oldDpi, DpiScale newDpi)
        {
            MessageBox.Show($"dpi changed from {oldDpi.DpiScaleX} to {newDpi.DpiScaleX}");
            base.OnDpiChanged(oldDpi, newDpi);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
