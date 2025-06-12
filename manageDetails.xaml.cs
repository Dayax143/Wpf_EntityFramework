using System.Windows;

namespace WpfEntityFramework
{
    /// <summary>
    /// Interaction logic for manageDetails.xaml
    /// </summary>
    public partial class manageDetails : Window
    {
        public manageDetails()
        {
            InitializeComponent();
        }

        private void SaveNew_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new MyContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        Test testadd = new Test
                        {
                            Name = txtName.Text,
                            Quantity = int.Parse(txtQuantity.Text),
                        };
                        context.Add(testadd);
                        context.SaveChanges();
                        clearData();
                        MessageBox.Show("Sucessfully Inserted");

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show(ex.Message, "Not updated, transaction rolled back");
                    }
                }
            }
        }

        private void UpdateNext_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new MyContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var testUpdate = context.test
                                   .Where(t => t.id == int.Parse(txtSearch.Text))
                                   .FirstOrDefault();

                        if (testUpdate != null)
                        {
                            testUpdate.Name = txtName.Text;
                            testUpdate.Quantity = int.Parse(txtQuantity.Text);
                            context.Update(testUpdate);
                            context.SaveChanges();
                            MessageBox.Show("Updated successfully");
                            findNext();
                        }
                        else
                        {
                            MessageBox.Show("There is no data found by this id");
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show(ex.Message, "Not updated, transaction rolled back");
                    }
                }
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new MyContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var deleteTest = context.test
                                                           .Where(t => t.id == int.Parse(txtSearch.Text))
                                                           .FirstOrDefault();
                        if (deleteTest == null)
                        {
                            MessageBox.Show("There is no data found by this id");
                        }
                        else
                        {
                            context.test.Remove(deleteTest);
                            context.SaveChanges();
                            clearData();
                            MessageBox.Show("Successfully deleted");
                        }
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show(ex.Message, "Not updated, transaction rolled back");
                    }
                }
            }
        }

        public void clearData()
        {
            try
            {
                txtSearch.Text = "";
                txtName.Text = "";
                txtQuantity.Text = "";
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            clearData();
        }

        public void searchFunction()
        {
            using (var context = new MyContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var searchTest = context.test
                                   .Where(t => t.id == int.Parse(txtSearch.Text))
                                   .OrderBy(t => t.id)
                                   .FirstOrDefault();
                        if (searchTest != null)
                        {
                            txtSearch.Text = searchTest.id.ToString();
                            txtName.Text = searchTest.Name;
                            txtQuantity.Text = searchTest.Quantity.ToString();
                            lblAuditUser.Text = searchTest.audit_user;
                        }
                        else if (searchTest == null)
                        {
                            MessageBox.Show("There is no data found by this id");
                        }
                        else
                        {
                            MessageBox.Show("Correct the input");
                        }

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                    }
                }
            }
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
          searchFunction();
        }

        public void findNext()
        {

            using (var context = new MyContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var searchTest = context.test
                                                           .Where(t => t.id > int.Parse(txtSearch.Text))
                                                           .OrderBy(t => t.id)
                                                           .FirstOrDefault();
                        if (searchTest != null)
                        {
                            txtSearch.Text = searchTest.id.ToString();
                            txtName.Text = searchTest.Name;
                            txtQuantity.Text = searchTest.Quantity.ToString();
                            lblAuditUser.Text = searchTest.audit_user;
                        }
                        else if (searchTest == null)
                        {
                            MessageBox.Show("There is no data found by this id");
                        }
                        else
                        {
                            MessageBox.Show("Correct the input");
                        }

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                    }
                }
            }
        }

        private void FindNext_Click(object sender, RoutedEventArgs e)
        {
            findNext();
        }

        public void findPrevious()
        {

            using (var context = new MyContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var searchTest = context.test
              .Where(t => t.id < int.Parse(txtSearch.Text))
              .OrderByDescending(t => t.id)
              .FirstOrDefault();

                        if (searchTest != null)
                        {
                            txtSearch.Text = searchTest.id.ToString();
                            txtName.Text = searchTest.Name;
                            txtQuantity.Text = searchTest.Quantity.ToString();
                            lblAuditUser.Text = searchTest.audit_user;
                        }
                        else if (searchTest == null)
                        {
                            MessageBox.Show("There is no data found by this id");
                        }
                        else
                        {
                            MessageBox.Show("Correct the input");
                        }

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                    }
                }
            }
        }

        private void FindPrevious_Click(object sender, RoutedEventArgs e)
        {
            findPrevious();
        }

        private void UploadImage_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
