using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WarpKnitting
{
    public partial class FormCustomer : Form
    {
        BLL.Customer Customer = new BLL.Customer();
        List<string> MyList1;
        ComboBox ComboBox = new ComboBox();
        BindGvApply BindGvApply1;

        public FormCustomer(List<string> MyList1)
        {
            InitializeComponent();
            this.MyList1 = MyList1;
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Customer.DataSet1().Tables[0];
            dataGridView1.Columns[0].Visible = false;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i % 2 == 0)
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
            }
            //第4列为“类别”选择
            BindGvApply1 = new BindGvApply(dataGridView1, ComboBox, MyList1, 3);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindGvApply1.gvApply_CellClick(sender, e);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            Customer.UpdateExecuteDataSet1(dataGridView1.DataSource as DataTable);
        }
    }
}

