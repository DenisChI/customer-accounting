using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PresentationLayer.Views.UserViews
{
    public partial class UserMainView : Form, IUserMainView
    {
        public ComboBox Report { get { return comboBoxReports; } set { comboBoxReports = value; } }
        public DataGridView Table { get { return dataGridViewReport; } set { dataGridViewReport = value; } }

        public event Action ShowReport;
        public UserMainView(string clientUsername)
        {
            InitializeComponent();
            //
            this.Text += ":" + clientUsername;
            InitComboBoxReports();
        }

        private void InitComboBoxReports()
        {
            List<string> reports = new List<string>();
            reports.Add("Мои заказы");
            reports.Add("Все товары");
            reports.Add("Все поставщики");
            reports.Add("Все скидки");
            reports.Add("Все товары в наличии");
            Report.DataSource = reports;
        }


        private void InitProductTable()
        {
            dataGridViewReport.Columns.Add("productId", "ID");
            dataGridViewReport.Columns.Add("productName", "Название товара");
            dataGridViewReport.Columns.Add("provider", "Поставщик");
            dataGridViewReport.Columns.Add("sellingPrice", "Цена продажи");
        }

        private void InitProviderTable()
        {
            dataGridViewReport.Columns.Add("providerId", "ID");
            dataGridViewReport.Columns.Add("providerName", "Название фирмы");
            dataGridViewReport.Columns.Add("phoneNumber", "Телефон");
            dataGridViewReport.Columns.Add("address", "Адрес");
            dataGridViewReport.Columns.Add("email", "Почта");
        }

        private void InitProductAtStockTable()
        {
            dataGridViewReport.Columns.Add("productAtStockId", "ID");
            dataGridViewReport.Columns.Add("productName", "Название товара");
            dataGridViewReport.Columns.Add("warehouseName", "Название склада");
            dataGridViewReport.Columns.Add("productQuantity", "Количество товара на складе");
            dataGridViewReport.Columns.Add("date", "Дата");
        }

        private void InitProductOrderTable()
        {
            dataGridViewReport.Columns.Add("productOrderID", "ID");
            dataGridViewReport.Columns.Add("productName", "Название товара");
            dataGridViewReport.Columns.Add("productQuantity", "Количество товара");
            dataGridViewReport.Columns.Add("paymentType", "Тип оплаты");
            dataGridViewReport.Columns.Add("orderState", "Состояние заказа");
            dataGridViewReport.Columns.Add("discount", "Скидка");
            dataGridViewReport.Columns.Add("date", "Дата");
            dataGridViewReport.Columns.Add("orderPrice", "Сумма");
        }

        private void InitDiscountTable()
        {
            dataGridViewReport.Columns.Add("discountId", "ID");
            dataGridViewReport.Columns.Add("discountName", "Название скидки");
            dataGridViewReport.Columns.Add("percent", "Процент скидки");
        }

        public void InitializeDataGridView(string tableName)
        {
            Table.Columns.Clear();
            switch (tableName)
            {
                case "Product":
                    InitProductTable();
                    break;
                case "Provider":
                    InitProviderTable();
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

            dataGridViewReport.Columns[0].Visible = false; //скрыть столбец с ID
            int columsCount = dataGridViewReport.Columns.Count;
            for (int i = 1; i < columsCount; i++)
            {
                dataGridViewReport.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            dataGridViewReport.AllowUserToAddRows = false;
        }

        private void ButtonShowReport_Click(object sender, EventArgs e)
        {
            ShowReport?.Invoke();
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