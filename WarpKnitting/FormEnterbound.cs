using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WarpKnitting
{
    public partial class FormEnterbound : Form
    {
        public Int32 n = 31;//31天
        List<string> MyList1, MyList2,MyList3;
        DateTimePicker dateTimePicker = new DateTimePicker();
        ComboBox ComboBox1 = new ComboBox();
        ComboBox ComboBox2 = new ComboBox();
        ComboBox ComboBox3 = new ComboBox();
        BindGvApply BindGvApply, BindGvApply1, BindGvApply2, BindGvApply3, BindGvApply4;
        BLL.Enterbound Enterbound = new BLL.Enterbound();


        public FormEnterbound(List<string> MyList1, List<string> MyList2, List<string> MyList3)
        {
            InitializeComponent();
            this.MyList1 = MyList1;
            this.MyList2 = MyList2;
            this.MyList3 = MyList3;
        }

        private void FormLoad(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Enterbound.DataSet1(n).Tables[0]; ;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i % 2 == 0) dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
            }
            BindGvApply = new BindGvApply(dataGridView1, dateTimePicker, 2);
            BindGvApply1 = new BindGvApply(dataGridView1, ComboBox1, MyList1, 3);
            BindGvApply2 = new BindGvApply(dataGridView1, ComboBox2, MyList2, 1);
            BindGvApply4 = new BindGvApply(dataGridView1, ComboBox3, MyList3, 8);
            BindGvApply3 = new BindGvApply(dataGridView1, 7); //自动计算
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindGvApply.gvApply_CellClick(sender, e);
            BindGvApply1.gvApply_CellClick(sender, e);
            BindGvApply2.gvApply_CellClick(sender, e);
            BindGvApply3.gvApply_CellClick1(sender, e);
            BindGvApply4.gvApply_CellClick(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            Enterbound.UpdateExecuteDataSet1(dataGridView1.DataSource as DataTable);
        }
    }
}
