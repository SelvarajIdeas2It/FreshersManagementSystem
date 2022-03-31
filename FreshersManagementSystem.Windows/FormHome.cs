namespace FreshersManagementSystem.Windows
{
    public partial class FormHome : Form
    {
        /// <summary>
        /// Its initialize the application home form
        /// </summary>
        public FormHome()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Its initialize the freshers add form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "FormAdd")
                {
                    IsOpen = true;
                    form.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                FormAdd addForm = new FormAdd
                {
                    MdiParent = this,
                    Dock = DockStyle.Fill
                };
                addForm.Show();
            }
        }

        /// <summary>
        /// Its initialize the freshers view form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "FormView")
                {
                    IsOpen = true;
                    form.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                FormView viewForm = new FormView
                {
                    MdiParent = this,
                    Dock = DockStyle.Fill
                };
                viewForm.Show();
            }
        }

        /// <summary>
        /// Its close an application completely when all the operations done
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}