using Microsoft.Data.SqlClient;
using RestaurantManager.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            LoadDateTimePickerBill();
            LoadListViewByDate(dtpkFromDate.Value, dtpkToDate.Value);

        }
        #region methods

        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);

        }
        void LoadListViewByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }
        #endregion

        #region events
        private void btnViewBill_Click(object sender, EventArgs e)
        {
            LoadListViewByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }
        #endregion
    }
}
