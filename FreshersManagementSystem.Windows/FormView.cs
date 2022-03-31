using FreshersManagementSystem.DataAccessManager;
using FreshersManagementSystem.Model;
using System.Data;

namespace FreshersManagementSystem.Windows
{
    public partial class FormView : Form
    {
        private readonly FreshersManagementSystemControl control = new FreshersManagementSystemControl();
        
        /// <summary>
        /// Its initialize application view form for view all freshers details
        /// </summary>
        public FormView()
        {
            InitializeComponent();
            DisplayAllFreshers();
        }

        /// <summary>
        /// Get and displays all the frehsers details in data grid
        /// </summary>
        private void DisplayAllFreshers()
        {
            DataTable freshers = control.FetchAllFreshers();
            dataGridView1.DataSource = freshers;
        }

        /// <summary>
        /// Gets freshers name and search the fresher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            DataTable freshersrecords = control.SearchFresherByName(textBoxSearch.Text);
            if ((freshersrecords).Rows.Count == 0)
            {
                if (MessageBox.Show("No matching records found for your input!\n Do you want to show full records?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DisplayAllFreshers();
                }
                else
                {
                    dataGridView1.DataSource = freshersrecords;
                }
            }
            else
            {
                dataGridView1.DataSource = freshersrecords;
            }
        }
        /// <summary>
        /// Its perfom fresher update or delete based on user click action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show(control.DeleteFresher(id));
                    DisplayAllFreshers();
                }
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Update")
            {
                UpdateFresher(sender, e);
            }
        }

        /// <summary>
        /// Its gets an existing details of frehser from form and update the frehser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateFresher(object sender, DataGridViewCellEventArgs e)
        {
            Fresher fresherToUpdate = new Fresher();
            fresherToUpdate.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            fresherToUpdate.name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            fresherToUpdate.emailId = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            fresherToUpdate.mobileNumber = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            fresherToUpdate.qualification = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            fresherToUpdate.dateOfBirth = (DateTime)dataGridView1.CurrentRow.Cells[5].Value;
            fresherToUpdate.address = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            FormAdd addForm = new FormAdd(fresherToUpdate)
            {
                MdiParent = MdiParent,
                Dock = DockStyle.Fill
            };
            addForm.Show();
            this.Close();
        }
    }
}

