using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Commercial_automation_project1
{
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
        }

        Product_form prdfrm;
        private void Button_products_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (prdfrm == null)
            {
                prdfrm = new Product_form();
                prdfrm.MdiParent = this;
                prdfrm.Show();
            }
        }
        Customers cust;
        private void Button_customers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(cust == null)
            {
                cust = new Customers();
                cust.MdiParent = this;
                cust.Show();
            }
        }
        Companies cmp;
        private void Button_companies_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cmp==null)
            {
                cmp = new Companies();
                cmp.MdiParent = this;
                cmp.Show();
            }
        }
        Staff stf;

        private void Button_staffs_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (stf==null)
            {
                stf = new Staff();
                stf.MdiParent = this;
                stf.Show();
            }
        }

        Contacts cnt;
        private void Button_contact_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cnt==null)
            {
                cnt = new Contacts();
                cnt.MdiParent = this;
                cnt.Show();
            }
        }
        Expenses exp;
        private void Button_expenses_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (exp==null)
            {
                exp = new Expenses();
                exp.MdiParent = this;
                exp.Show();
            }
        }
        Banks bank;
        private void Button_banks_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bank==null)
            {
                bank = new Banks();
                bank.MdiParent = this;
                bank.Show();
            }
        }

        Invoices invoices;
        private void Button_invoice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (invoices==null)
            {
                invoices = new Invoices();
                invoices.MdiParent = this;
                invoices.Show();
            }
        }
        Notes note;
        private void Button_notes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (note==null)
            {
                note = new Notes();
                note.MdiParent = this;
                note.Show();
            }
        }

        Actions act;
        private void Action_Button_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (act==null)
            {
                act = new Actions();
                act.MdiParent = this;
                act.Show();


            }
        }
        
        Stock st;
        private void Button_stocks_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (st==null)
            {
                st = new Stock();
                st.MdiParent = this;
                st.Show();
            }
        }
        Settings set;
        private void Button_settings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            
                set = new Settings();
                
                set.Show();

            
        }
        Case case1;

        private void Button_case_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (case1==null)
            {
                case1 = new Case();
                case1.username = username1;
                case1.MdiParent = this;
                case1.Show();
            }
        }
        public string username1;


        Main1 main;

        private void Button_mainpage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (main==null)
            {
                main = new Main1();
                main.MdiParent = this;
                main.Show();
            }
        }
        

        private void Main_Page_Load(object sender, EventArgs e)
        {
            if (main == null)
            {
                main = new Main1();
                main.MdiParent = this;
                main.Show();
            }
        }
    }
}
