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
            String filepath = GetFilePath();
            filesToImport.PathBaza = filepath;
            SetSenderUid(filepath, sender);
        }

        private void BoxWartaEagentWznowienia_Checked(object sender, RoutedEventArgs e)
        {
            String filepath = GetFilePath();
            filesToImport.PathWartaEagentWznowienia = filepath;
            SetSenderUid(filepath, sender);
        }

        private void BoxWartaEagentPolisy_Checked(object sender, RoutedEventArgs e)
        {
            String filepath = GetFilePath();
            filesToImport.PathWartaEagentPolisy = filepath;
            SetSenderUid(filepath, sender);
        }
        private void BoxWartaXXI_Checked(object sender, RoutedEventArgs e)
        {
            String filepath = GetFilePath();
            filesToImport.PathWartaXXI = filepath;
            SetSenderUid(filepath, sender);
        }

        private void BoxWartaManager_Checked(object sender, RoutedEventArgs e)
        {
            String filepath = GetFilePath();
            filesToImport.PathWartaManager = filepath;
            SetSenderUid(filepath, sender);
        }

        private void BoxPZU_Checked(object sender, RoutedEventArgs e)
        {
            String filepath = GetFilePath();
            filesToImport.PathPZU = filepath;
            SetSenderUid(filepath, sender);
            //var password = 
        }

        private void BoxHestiaZadania_Checked(object sender, RoutedEventArgs e)
        {
            String filepath = GetFilePath();
            filesToImport.PathHestiaZadania = filepath;
            SetSenderUid(filepath, sender);
        }

        private void BoxHestiaPolisy_Checked(object sender, RoutedEventArgs e)
        {
            String filepath = GetFilePath();
            filesToImport.PathHestiaPolisy = filepath;
            SetSenderUid(filepath, sender);
        }

        private void BoxMTUPolisy_Checked(object sender, RoutedEventArgs e)
        {
            String filepath = GetFilePath();
            filesToImport.PathMTUPolisy = filepath;
            SetSenderUid(filepath, sender);
        }

        private void BoxCompensa_Checked(object sender, RoutedEventArgs e)
        {
            String filepath = GetFilePath();
            filesToImport.PathCompensa = filepath;
            SetSenderUid(filepath, sender);
        }

        private void BoxUniqa_checked(object sender, RoutedEventArgs e)
        {
            String filepath = GetFilePath();
            filesToImport.PathUniqa = filepath;
            SetSenderUid(filepath, sender);
        }

        private void ButtonImport_Click(object sender, RoutedEventArgs e)
        {
            // ImportPolicies(filesToImport)
        }

        private void BoxPZUPassword_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
            //TODO: GETTING PASSWORD FROM HERE
                MessageBox.Show("Hasło zostało ustawione.");
            }
        }

        private void BoxUniqaPassword_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                MessageBox.Show("Hasło zostało ustawione.");
            }
        }

        private void Box_CheckCapslock(object sender, RoutedEventArgs e)
        {
            if (Console.CapsLock)
            {
                MessageBox.Show("Caps Lock jest wciśnięty.");
            }
        }
        private void MouseOverBox(object sender, System.Windows.Input.MouseEventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            if ((bool)checkbox.IsChecked)
            {
                ToolTip tooltip = new ToolTip();
                tooltip.Content = "dupa";
                tooltip.Content = checkbox.Uid;
                checkbox.ToolTip = tooltip;
            }
        }
        private static String GetFilePath()
        {
            Nullable<bool> result = fileDialog.ShowDialog();
            String filepath = "";
            if (result == true)
            {
                filepath = fileDialog.FileName;
            }
            return filepath;
        }
        private static void SetSenderUid(String path, object sender)
        {
            CheckBox checkbox = (CheckBox)sender;
            checkbox.Uid = path;
        }
    }
}