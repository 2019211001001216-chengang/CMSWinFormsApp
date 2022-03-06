using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSWinFormsApp
{
    public partial class WorkerForm : Form
    {
        public WorkerForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“cMSDBDataSet.tbWoker”中。您可以根据需要移动或移除它。
            this.tbWokerTableAdapter.Fill(this.cMSDBDataSet.tbWoker);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.cMSDBDataSet.tbWoker.Clear();
            sqlDataAdapter1.Fill(this.cMSDBDataSet.tbWoker);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(this.cMSDBDataSet.tbWoker);
            MessageBox.Show("The Worker Table is updated");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.cMSDBDataSet.tbWoker.Clear();
            sqlDataAdapter1.Fill(this.cMSDBDataSet.tbWoker);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
