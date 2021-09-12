using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WarpKnitting
{
    public class BindGvApply
    {
        DataGridView dataGridView1;
        DateTimePicker DateTimePicker;
        ComboBox ComboBox;
        Int32 i, j, k;
        #region
        public BindGvApply(DataGridView dataGridView1, Int32 k)
        {
            this.dataGridView1 = dataGridView1;
            this.k = k;
        }

        public BindGvApply(DataGridView dataGridView1, DateTimePicker DateTimePicker, Int32 i)
        {
            this.dataGridView1 = dataGridView1;
            this.DateTimePicker = DateTimePicker;
            this.i = i;
            this.dataGridView1.Controls.Add(DateTimePicker);
            DateTimePicker.Visible = false;
            DateTimePicker.Format = DateTimePickerFormat.Custom;  //设置日期格式为2010-08-05
            DateTimePicker.TextChanged += new EventHandler(cotrol_TextChange);
        }

        private void cotrol_TextChange(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Value = DateTimePicker.Text.ToString();
           // dataGridView1.CurrentCell.Value = Convert.ToDateTime(DateTimePicker.Value);
        }

        public BindGvApply(DataGridView dataGridView1, ComboBox ComboBox, List<string> MyList, Int32 j)
        {
            this.dataGridView1 = dataGridView1;
            this.ComboBox = ComboBox;
            this.j = j;
            ComboBox.DataSource = MyList;
            dataGridView1.Controls.Add(ComboBox);
            ComboBox.Visible = false;
            ComboBox.TextChanged += new EventHandler(ComboBox_TextChange);
        }

        private void ComboBox_TextChange(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Value = ComboBox.Text.ToString();
        }

        public void gvApply_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Rectangle _Rectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
            if (e.ColumnIndex == j)
            {
                ComboBox.Size = new Size(_Rectangle.Width, _Rectangle.Height);
                ComboBox.Location = new Point(_Rectangle.X, _Rectangle.Y);
                dataGridView1.CurrentCell.Value = ComboBox.Text.ToString();
                ComboBox.Visible = true;
            }
            else
            {
                if (ComboBox != null) ComboBox.Visible = false;
            }

            if (e.ColumnIndex == i)
            {
                DateTimePicker.Size = new Size(_Rectangle.Width, _Rectangle.Height);
                DateTimePicker.Location = new Point(_Rectangle.X, _Rectangle.Y);
                dataGridView1.CurrentCell.Value = DateTimePicker.Text.ToString(); 
                DateTimePicker.Visible = true;
            }
            else
            {
                if (DateTimePicker != null) DateTimePicker.Visible = false;
            }
        }

        public void gvApply_CellClick1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == k)
            {
                if (dataGridView1[e.ColumnIndex - 1, e.RowIndex].Value != DBNull.Value && dataGridView1[e.ColumnIndex - 2, e.RowIndex].Value != DBNull.Value)
                {
                    Double m = Convert.ToDouble(dataGridView1[e.ColumnIndex - 1, e.RowIndex].Value);
                    Double n = Convert.ToDouble(dataGridView1[e.ColumnIndex - 2, e.RowIndex].Value);
                    dataGridView1.CurrentCell.Value = m * n;
                }
            }
        }

        #endregion
    }
}
