using Microsoft.Data.SqlClient;
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

namespace WpfEntityFramework
{
    /// <summary>
    /// Interaction logic for testManage.xaml
    /// </summary>
    public partial class testManage : UserControl
    {
        public testManage()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
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

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new MyContext())
            {
                using(var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var testUpdate = context.test.Where(tes => tes.id == int.Parse(txtSearch.Text)).FirstOrDefault();

                        if (testUpdate != null)
                        {
                            testUpdate.Name = txtName.Text;
                            testUpdate.Quantity = int.Parse(txtQuantity.Text);

                            context.Update(testUpdate);
                            context.SaveChanges();
                            MessageBox.Show("Updated successfully");
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
                        var deleteTest = context.test.Where(id => id.id == int.Parse(txtSearch.Text)).FirstOrDefault();

                        if (deleteTest == null)
                        {
                            MessageBox.Show("There is no data found by this id");
                        }
                        else
                        {
                            context.test.Remove(deleteTest);
                            context.SaveChanges();
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

        private void Clear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new MyContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var searchTest = context.test.Where(id => id.id == int.Parse(txtSearch.Text)).FirstOrDefault();

                        if (searchTest != null)
                        {
                            txtName.Text = searchTest.Name;
                            txtQuantity.Text = searchTest.Quantity.ToString();
                            lblAuditUser.Text = searchTest.audit_user;
                        }
                        else if(searchTest == null)
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
    }
}
