using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace WarpKnitting
{
    public partial class FormQuerycs : Form
    {
        Model.boundQuery model = new Model.boundQuery();
        BLL.Enterbound Enterbound = new BLL.Enterbound();
        BLL.Outbound Outbound = new BLL.Outbound();
        BLL.Customer Customer = new BLL.Customer();
        BLL.Product Xinghao = new BLL.Product();
        private DataTable table1;

        #region

        public FormQuerycs()
        {
            dataGridView1 = new DataGridView();
            InitializeComponent();
        }

        private void FormQuerycs_Load(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    comboBox2.DataSource = Customer.MyList("名称", "丝厂");
                    comboBox3.DataSource = Xinghao.MyList("型号", "原丝"); 
                    break;
                case 1:
                    comboBox2.DataSource = Customer.MyList("名称", "买方");
                    comboBox3.DataSource = Xinghao.MyList("型号", "白坯布");
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        private void FormLoad1()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i % 2 == 0)
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }

        private void FormLoad2()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i % 2 == 0)
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            model.EnterFactoryDate1 = dateTimePicker1.Value;
            model.EnterFactoryDate2 = dateTimePicker2.Value;
            model.Producer = comboBox2.Text;
            model.Type = comboBox3.Text;
        
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    table1 = BLL.DataTableAddSum.AddSum(Enterbound.Query(model).Tables[0], "包数", "重量", "金额");
                    dataGridView1.DataSource = table1;
                    FormLoad1();
                    break;
                case 1:
                    table1 = BLL.DataTableAddSum.AddSum(Outbound.Query(model).Tables[0], "匹数", "重量", "金额");
                    dataGridView1.DataSource = table1;
                    FormLoad2();
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            BLL.ExcelOperate excelOperate = new BLL.ExcelOperate();
            excelOperate.DataSetToExcel_A(table1, true);
        }
    }
}
