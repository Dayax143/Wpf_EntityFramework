using Microsoft.Data.SqlClient;
using System.Text;
using System.Text.Encodings.Web;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfEntityFramework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }
        private void AdjustColumnWidth()
        {
            foreach (var column in dgvTest.Columns)
            {
                column.Width = new DataGridLength(0, DataGridLengthUnitType.Star);
            }
        }

        private void LoadData()
        {
            using (var context = new MyContext())
            {
                var products = context.test.ToList();
                dgvTest.ItemsSource = products;
                //AdjustColumnWidth();
            }
        }

        private void btnsubmit_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new MyContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        test test = new test
                        {
                            Name = txtname.Text,
                            Quantity = int.Parse(txtquantity.Text),
                            audit_user = Properties.Settings.Default.user_audit,
                        };

                        context.test.Add(test);
                        context.SaveChanges();
                        MessageBox.Show("Successfully Inserted");

                        transaction.Commit();
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        transaction.Rollback();
                    }
                }
            }
        }
    }
}