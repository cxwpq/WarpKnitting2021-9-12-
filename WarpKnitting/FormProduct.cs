using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WarpKnitting
{
    public partial class FormProduct : Form
    {
        BLL.Product Xinghao = new BLL.Product();
        List<string> MyList1;
        ComboBox ComboBox = new ComboBox();
        BindGvApply BindGvApply1;

        public FormProduct(List<string> MyList1)
        {
            InitializeComponent();
            this.MyList1 = MyList1;
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Xinghao.DataSet1().Tables[0];
            dataGridView1.Columns[0].Visible = false;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i % 2 == 0)
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
            }
            //第2列为“名称”选择
            BindGvApply1 = new BindGvApply(dataGridView1, ComboBox, MyList1, 2);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindGvApply1.gvApply_CellClick(sender, e);
        }
               
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            Xinghao.UpdateExecuteDataSet1(dataGridView1.DataSource as DataTable);
        }
    }
}
