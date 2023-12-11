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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Metrics;


namespace WinFormsApp1
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Form2 : Form
    {

        DB database = new DB();
        int selectedRow;
        public Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }
        private void CreateColumns()
        {
            dg.Columns.Add("ProductArticleNumber", "Артикл");
            dg.Columns.Add("ProductName", "Название");
            dg.Columns.Add("Quantity", "Кол-во");
            dg.Columns.Add("ProductCost", "Цена");
            dg.Columns.Add("ProductDiscountAmount", "Скидка");
            dg.Columns.Add("ProductManufacturer", "Производитель");
            dg.Columns.Add("ProductProvider", "Поставщик");
            dg.Columns.Add("ProductCategory", "Категория");
            dg.Columns.Add("ProductEffectiveDiscount", "Эффективная скидка");
            dg.Columns.Add("ProductQuantityInStock", "Кол-во на складе");
            dg.Columns.Add("ProductDescription", "Описание");
            dg.Columns.Add("IsNew", String.Empty);
        }
        void TableFilter()
        {

        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add
               (record.GetString(0),
               record.GetString(1),
               record.GetString(2),
               record.GetInt32(3),
               record.GetInt32(4),
               record.GetString(5),
               record.GetString(6),
               record.GetString(7),
               record.GetInt32(8),
               record.GetInt32(9),
               record.GetString(10),
               RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string querystring = $"SELECT * FROM [Products]";
            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (sort.SelectedIndex == 0)
                    dg.Sort(dg.Columns[9], ListSortDirection.Ascending);
                else
                    dg.Sort(dg.Columns[9], ListSortDirection.Descending);
            }
            catch
            {
                MessageBox.Show("Для начала выберите диапозон по размеру скидок!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dg);
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dg.RowCount; i++)
            {
                dg.Rows[i].Selected = false;
                for (int j = 0; j < dg.ColumnCount; j++)
                    if (dg.Rows[i].Cells[j].Value != null)
                        if (dg.Rows[i].Cells[j].Value.ToString().Contains(search.Text))
                        {
                            dg.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            TableFilter();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderWork ow = new OrderWork();
            ow.ShowDialog();
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            o.ShowDialog();
            this.Close();
        }
    }
}
