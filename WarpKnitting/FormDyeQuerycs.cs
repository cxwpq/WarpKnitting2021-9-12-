using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace WarpKnitting
{
    public partial class FormDyeQuerycs : Form
    {
        Model.DyeFactoryQuery model = new Model.DyeFactoryQuery();
        BLL.DyeOutbound DyeOutbound = new BLL.DyeOutbound();
        BLL.Outbound Outbound = new BLL.Outbound();
        BLL.Customer Customer = new BLL.Customer();
        private DataTable table1;

        #region
        public FormDyeQuerycs()
        {
            dataGridView1 = new DataGridView();
            InitializeComponent();
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void FormLoad1()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i % 2 == 0)
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }

        private void FormLoad2()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 40;
            dataGridView1.Columns[2].Width = 90;
            dataGridView1.Columns[3].Width = 90;
            dataGridView1.Columns[4].Width = 60;
            dataGridView1.Columns[5].Width = 60;
            dataGridView1.Columns[6].Width = 60;
            dataGridView1.Columns[7].Width = 80;
            dataGridView1.Columns[8].Width = 70;
            dataGridView1.Columns[9].Width = 90;
            dataGridView1.Columns[10].Width = 90;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i % 2 == 0)
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }

        private void FormLoad3()
        {
            this.Size = new Size(1335, 600);
            this.dataGridView1.Size = new Size(1335, 500);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 40;
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[3].Width = 90;
            dataGridView1.Columns[4].Width = 60;
            dataGridView1.Columns[5].Width = 60;
            dataGridView1.Columns[6].Width = 60;
            dataGridView1.Columns[7].Width = 60;
            dataGridView1.Columns[8].Width = 60;
            dataGridView1.Columns[9].Width = 20;
            dataGridView1.Columns[10].Width = 40;
            dataGridView1.Columns[11].Width = 80;
            dataGridView1.Columns[12].Width = 80;
            dataGridView1.Columns[13].Width = 90;
            dataGridView1.Columns[14].Width = 60;
            dataGridView1.Columns[15].Width = 60;
            dataGridView1.Columns[16].Width = 60;
            dataGridView1.Columns[17].Width = 80;
            dataGridView1.Columns[18].Width = 60;
            dataGridView1.Columns[19].Width = 80;
            dataGridView1.Columns[20].Width = 80;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[17].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[18].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[19].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells["柜号"].Value.ToString() == "合计")
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }

        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            model.EnterFactoryDate1 = dateTimePicker1.Value;
            model.EnterFactoryDate2 = dateTimePicker2.Value;
            model.DyeFactoryName = comboBox2.Text;
            model.Customer = comboBox3.Text;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    table1 = BLL.DataTableAddSum.AddSum(DyeOutbound.Query1(model).Tables[0], "重量", "金额" ,"匹数");
                    dataGridView1.DataSource = table1;
                    FormLoad1();
                    this.Text = "染厂入库查询";
                    break;
                case 1:
                    table1 = BLL.DataTableAddSum.AddSum(DyeOutbound.Query2(model).Tables[0], "染后重量", "金额", "匹数");
                    dataGridView1.DataSource = table1;
                    FormLoad2();
                    this.Text = "染厂出库查询";
                    break;
                case 2:
                    if (IsNumberic(model.DyeFactoryName) && IsNumberic(model.Customer))
                    {
                        table1 = DyeOutbound.Query3(model);
                        dataGridView1.DataSource = table1;
                        FormLoad3();
                        this.Text = "按柜号查询";
                    }
                    break;
                default:
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    comboBox2.DataSource = Customer.MyList("名称", "染厂");
                    dateTimePicker1.Visible = true;
                    dateTimePicker2.Visible = true;
                    comboBox2.Visible = true;
                    comboBox3.Visible = false;
                    break;
                case 1:
                    comboBox2.DataSource = Customer.MyList("名称", "染厂");
                    comboBox3.DataSource = Customer.MyList("名称", "买方");
                    dateTimePicker1.Visible = true;
                    dateTimePicker2.Visible = true;
                    comboBox2.Visible = true;
                    comboBox3.Visible = true;
                    break;
                case 2:
                    comboBox2.SelectedIndex = -1;
                    comboBox3.SelectedIndex = -1;
                    dateTimePicker1.Visible = false;
                    dateTimePicker2.Visible = false;
                    comboBox2.Visible = true;
                    comboBox3.Visible = true;
                    break;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            BLL.ExcelOperate excelOperate = new BLL.ExcelOperate();
            excelOperate.DataSetToExcel_A(table1, true);
        }

        /// <summary>
        /// 判断字符串是否可以转化为数字
        /// </summary>
        /// <param name="str">要检查的字符串</param>
        /// <returns>true:可以转换为数字；false：不是数字</returns>
        public static bool IsNumberic(string str)
        {
            double vsNum;
            bool isNum;
            isNum = double.TryParse(str, System.Globalization.NumberStyles.Float,
                System.Globalization.NumberFormatInfo.InvariantInfo, out vsNum);
            return isNum;
        }
    }
}
