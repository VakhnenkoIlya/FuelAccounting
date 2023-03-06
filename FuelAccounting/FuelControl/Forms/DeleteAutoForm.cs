using FuelAccounting.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FuelControl
{
    public partial class DeleteAutoForm : Form
    {
        public Car car;
        public DeleteAutoForm(DataGridView autoTable)
        {
            InitializeComponent();
            AutoCmb.DataSource = autoTable.DataSource;
            AutoCmb.DisplayMember = "Model";
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            car = (Car)AutoCmb.SelectedItem;
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
