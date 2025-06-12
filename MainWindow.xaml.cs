using System.Windows;

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

        public void LoadData()
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
                        Test test = new Test
                        {
                            Name = txtname.Text,
                            Quantity = int.Parse(txtquantity.Text),
                            audit_user = Properties.Settings.Default.user_audit,
                        };

                        if (dgvTest.SelectedItem is Test selectedTest) // Ensure selected item matches model
                        {
                            var productToDelete = context.test.Find(selectedTest.id); // Find by ID

                            if (productToDelete != null)
                            {
                                context.test.Remove(productToDelete);
                            }
                            else
                            {
                                transaction.Rollback();
                            }
                        }
                        context.test.Add(test);
                        context.SaveChanges();

                        transaction.Commit();
                        MessageBox.Show("Successfully Inserted");
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show(ex.Message, "Transaction Canceled");
                    }
                }
            }
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void btnProducts_Click(object sender, RoutedEventArgs e)
        {
            manageDetails detail = new manageDetails();
            detail.ShowDialog();
        }
    }
}