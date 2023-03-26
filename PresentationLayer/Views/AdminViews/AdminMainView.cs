using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PresentationLayer.Views.AdminViews
{
    public partial class AdminMainView : Form, IAdminMainView
    {
        public DataGridView Table
        {
            get { return dataGridViewTable; }
            set { dataGridViewTable = value; }
        }
        public string CurrentTableName { get; set; }
        public int RowIndex { get; set; }
        public ComboBox Report { get { return comboBoxReport; } set { comboBoxReport = value; } }

        public event Action ClientButtonClick;
        public event Action ProductButtonClick;
        public event Action WarehouseButtonClick;
        public event Action ProductAtStockButtonClick;
        public event Action ProductOrderButtonClick;
        public event Action ProviderButtonClick;
        public event Action DiscountButtonClick;
        public event Action AddRow;
        public event Action UpdateRow;
        public event Action DeleteRow;
        public event Action SelectReport;

        public AdminMainView()
        {
            InitializeComponent();

            contextMenuStripOptions.Enabled = false;
            InitComboBoxReports();
            //dataGridViewTable.Enabled = false;
        }

        private void InitComboBoxReports()
        {
            List<string> reports = new List<string>();
            reports.Add("Заказы дороже среднего");
            reports.Add("Заказы за указанный период времени");
            reports.Add("Самый дорогой заказ для каждого клиента");
            Report.DataSource = reports;
        }

        private void InitClientTable()
        {
            dataGridViewTable.Columns.Add("cliendId", "ID");
            dataGridViewTable.Columns.Add("cliendUsername", "Логин");
            dataGridViewTable.Columns[1].Visible = false;
            dataGridViewTable.Columns.Add("cliendPassword", "Пароль");
            dataGridViewTable.Columns[2].Visible = false;
            dataGridViewTable.Columns.Add("fullName", "ФИО клиента");
            dataGridViewTable.Columns.Add("phoneNumber", "Телефон");
            dataGridViewTable.Columns.Add("address", "Адрес");
            dataGridViewTable.Columns.Add("email", "Почта");
        }

        private void InitProductTable()
        {
            dataGridViewTable.Columns.Add("productId", "ID");
            dataGridViewTable.Columns.Add("productName", "Название товара");
            dataGridViewTable.Columns.Add("provider", "Поставщик");
            dataGridViewTable.Columns.Add("sellingPrice", "Цена за кг");
        }

        private void InitProviderTable()
        {
            dataGridViewTable.Columns.Add("providerId", "ID");
            dataGridViewTable.Columns.Add("providerName", "Название фирмы");
            dataGridViewTable.Columns.Add("phoneNumber", "Телефон");
            dataGridViewTable.Columns.Add("address", "Адрес");
            dataGridViewTable.Columns.Add("email", "Почта");
        }

        private void InitWarehouseTable()
        {
            dataGridViewTable.Columns.Add("warehouseId", "ID");
            dataGridViewTable.Columns.Add("warehouseName", "Название склада");
            dataGridViewTable.Columns.Add("fullName", "ФИО кладовщика");
        }

        private void InitProductAtStockTable()
        {
            dataGridViewTable.Columns.Add("productAtStockId", "ID");
            dataGridViewTable.Columns.Add("productName", "Название товара");
            dataGridViewTable.Columns.Add("warehouseName", "Название склада");
            dataGridViewTable.Columns.Add("productQuantity", "Кол-во товара на складе");
            dataGridViewTable.Columns.Add("date", "Дата");
        }

        private void InitProductOrderTable()
        {
            dataGridViewTable.Columns.Add("productOrderID", "ID");
            dataGridViewTable.Columns.Add("productName", "Название товара");
            dataGridViewTable.Columns.Add("fullName", "ФИО клиента");
            dataGridViewTable.Columns.Add("productQuantity", "Кол-во товара");
            dataGridViewTable.Columns.Add("paymentType", "Тип оплаты");
            dataGridViewTable.Columns.Add("orderState", "Состояние заказа");
            dataGridViewTable.Columns.Add("discount", "Скидка");
            dataGridViewTable.Columns.Add("date", "Дата");
            dataGridViewTable.Columns.Add("orderPrice", "Сумма");
        }

        private void InitDiscountTable()
        {
            dataGridViewTable.Columns.Add("discountId", "ID");
            dataGridViewTable.Columns.Add("discountName", "Название скидки");
            dataGridViewTable.Columns.Add("percent", "Процент скидки");
        }

        public void InitializeDataGridView()
        {
            //dataGridViewTable.Enabled = true;
            Table.Columns.Clear();
            contextMenuStripOptions.Enabled = true;
            switch (CurrentTableName)
            {
                case "Client":
                    InitClientTable();
                    break;
                case "Product":
                    InitProductTable();
                    break;
                case "Provider":
                    InitProviderTable();
                    break;
                case "Warehouse":
                    InitWarehouseTable();
                    break;
                case "ProductAtStock":
                    InitProductAtStockTable();
                    break;
                case "ProductOrder":
                    InitProductOrderTable();
                    break;
                case "Discount":
                    InitDiscountTable();
                    break;
            }
            dataGridViewTable.Columns.Add(new DataGridViewImageColumn()//new DataGridViewButtonColumn()
            {
                //Name = "options",
                //HeaderText = "Действия",
                Image = Properties.Resources._3dots_24x24,
                ContextMenuStrip = contextMenuStripOptions
            });
            dataGridViewTable.Columns[0].Visible = false; //скрыть столбец с ID
            dataGridViewTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            int columsCount = dataGridViewTable.Columns.Count;
            dataGridViewTable.Columns[columsCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            for (int i = 1; i < columsCount - 1; i++)
            {
                dataGridViewTable.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGridViewTable.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //dataGridViewTable.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dataGridViewTable.AllowUserToAddRows = false;
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            CurrentTableName = "Client";
            ClientButtonClick?.Invoke();
        }
        private void ProductButton_Click(object sender, EventArgs e)
        {
            CurrentTableName = "Product";
            ProductButtonClick?.Invoke();
        }

        private void WarehouseButton_Click(object sender, EventArgs e)
        {
            CurrentTableName = "Warehouse";
            WarehouseButtonClick?.Invoke();
        }

        private void ProductAtStockButton_Click(object sender, EventArgs e)
        {
            CurrentTableName = "ProductAtStock";
            ProductAtStockButtonClick?.Invoke();
        }

        private void ProductOrderButton_Click(object sender, EventArgs e)
        {
            CurrentTableName = "ProductOrder";
            ProductOrderButtonClick?.Invoke();
        }
        private void ProviderButton_Click(object sender, EventArgs e)
        {
            CurrentTableName = "Provider";
            ProviderButtonClick?.Invoke();
        }

        private void DiscountButton_Click(object sender, EventArgs e)
        {
            CurrentTableName = "Discount";
            DiscountButtonClick?.Invoke();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRow?.Invoke();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRow?.Invoke();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteRow?.Invoke();
        }

        private void DataGridViewTableCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex + 1 == dataGridViewTable.ColumnCount)
            {
                RowIndex = e.RowIndex;
                contextMenuStripOptions.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void DataGridViewTableCellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                if (dataGridViewTable.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText.Equals("Изображение") || dataGridViewTable.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText.Equals("Изменить"))
                {
                    dataGridViewTable.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = string.Empty;
                }
            }
        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            SelectReport?.Invoke();
        }

        public void ShowView()
        {
            this.ShowDialog();
        }

        private void системаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}