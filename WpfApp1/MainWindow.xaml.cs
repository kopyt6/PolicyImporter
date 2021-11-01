using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Microsoft.Win32.OpenFileDialog fileDialog = new Microsoft.Win32.OpenFileDialog();
        FilesToImport filesToImport = new FilesToImport();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BoxWznowieniaBaza_Checked(object sender, RoutedEventArgs e)
        {
            filesToImport.PathBaza = GetFilePath();
        }

        private void BoxWartaEagentWznowienia_Checked(object sender, RoutedEventArgs e)
        {
            filesToImport.PathWartaEagentWznowienia = GetFilePath();
        }

        private void BoxWartaEagentPolisy_Checked(object sender, RoutedEventArgs e)
        {
            filesToImport.PathWartaEagentPolisy = GetFilePath();
        }

        private void BoxWartaXXI_Checked(object sender, RoutedEventArgs e)
        {
            filesToImport.PathWartaXXI = GetFilePath();
        }

        private void BoxWartaManager_Checked(object sender, RoutedEventArgs e)
        {
            filesToImport.PathWartaManager = GetFilePath();
        }

        private void BoxPZU_Checked(object sender, RoutedEventArgs e)
        {
            filesToImport.PathPZU = GetFilePath();
            //var password = 
        }

        private void BoxHestiaZadania_Checked(object sender, RoutedEventArgs e)
        {
            filesToImport.PathHestiaZadania = GetFilePath();
        }

        private void BoxHestiaPolisy_Checked(object sender, RoutedEventArgs e)
        {
            filesToImport.PathHestiaPolisy = GetFilePath();
        }

        private void BoxMTUPolisy_Checked(object sender, RoutedEventArgs e)
        {
            filesToImport.PathMTUPolisy = GetFilePath();
        }

        private void BoxCompensa_Checked(object sender, RoutedEventArgs e)
        {
            filesToImport.PathCompensa = GetFilePath();
        }

        private void BoxUniqa_checked(object sender, RoutedEventArgs e)
        {
            filesToImport.PathUniqa = GetFilePath();
        }

        private void ButtonImport_Click(object sender, RoutedEventArgs e)
        {
            // ImportPolicies(filesToImport)
        }
        private static String GetFilePath()
        {
            Nullable<bool> result = fileDialog.ShowDialog();
            String filename = "";
            if (result == true)
            {
                filename = fileDialog.FileName;
            }
            return filename;
        }

        private void BoxPZUPassword_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                MessageBox.Show("Hasło zostało ustawione.");
            }
        }
        
        private void BoxUniqaPassword_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                MessageBox.Show("Hasło zostało ustawione.");
                MessageBox.Show(filesToImport.ToString());
            }
        }

        private void Box_CheckCapslock(object sender, RoutedEventArgs e)
        {
            if (Console.CapsLock)
            {
                MessageBox.Show("Caps Lock jest wciśnięty.");
            }
        }
    }
}