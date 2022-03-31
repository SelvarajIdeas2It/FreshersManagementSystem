using FreshersManagementSystem.DataAccessManager;
using FreshersManagementSystem.Model;
using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;

namespace FreshersManagementSystem.Windows
{
    public partial class FormAdd : Form
    {
        private string name;
        private string emailId;
        private string mobilNumber;
        private string address;
        private DateTime dateOfBirth;
        private string qualification;

        private BindingList<Fresher> freshers = new();
        private readonly FormView freshersView = new();
        IFFreshersManagementSystemService freshersControl = null;


        /// <summary>
        /// Its initialize an application form for create an new fresher
        /// </summary>
        public FormAdd()
        {
            InitializeComponent();
            labelHeader.Text = "Add Fresher";
        }

        /// <summary>
        /// Parameterized constructor for initialize an add form with fresher details for update
        /// </summary>
        /// <param name="fresherToUpdate">The fresher who want to update from here</param>
        public FormAdd(Fresher fresherToUpdate)
        {
            InitializeComponent();
            labelHeader.Text = "Update Fresher";
            lalbleId.Text = fresherToUpdate.id.ToString();
            labelName.Text = fresherToUpdate.name;
            fillForm(fresherToUpdate);

        }

        /// <summary>
        /// Gets and validate fresher name and the name contains only characters 
        /// and only single space allowed between first name and lastname or middle name also three name allowed here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxName_Validating(object sender, CancelEventArgs e)
        {
            StringBuilder errorMessage = new();
            errorMessage.Append("Name Cannot Be Null Or Empty only single space allowed between first ")
                .Append("name and last name or middle name!\nEnter Only Valid Name");
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || !Regex.IsMatch(textBoxName.Text, @"^([a-zA-Z]{2,20})+([ ]?[A-Za-z]*){0,2}$"))
            {
                e.Cancel = true;
                textBoxName.Focus();
                MessageBox.Show(errorMessage.ToString());
            }
            else
            {
                e.Cancel = false;
            }
        }

        /// <summary>
        /// Gets And Validate Mobile Number And Mobile Number Contains Only Integers And May Be Containe Country Code 0 or +91 
        /// And An Number Start With 6 to 9 And Containe Only 10 Numbers! Enter Only Valid Mobile Number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxMobileNumber_Validating(object sender, CancelEventArgs e)
        {
            StringBuilder errorMessage = new();
            errorMessage.Append("Mobile Number Contains Only Integers And May Be Containe Country Code 0 or +91 ")
                .Append("And An Number Start With 6 to 9 And Containe Only 10 Numbers! \nEnter Only Valid Mobile Number");
            if (!string.IsNullOrWhiteSpace(textBoxMobileNumber.Text) && !Regex.IsMatch(textBoxMobileNumber.Text, @"^(0|91)?[6-9][0-9]{9}$"))
            {
                e.Cancel = true;
                textBoxMobileNumber.Focus();
                MessageBox.Show(errorMessage.ToString());
            }
            else
            {
                e.Cancel = false;
            }
        }

        /// <summary>
        /// Gets And Validate Email Id And Email Id Should Be In Valid Email Id  Formate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxEmailId_Validating(object sender, CancelEventArgs e)
        {
            StringBuilder rejex = new();
            rejex.Append("^([a-zA-z])+([.]?[a-zA-Z0-9])+@([a-zA-Z0-9]{4,10})+([.][a-zA-Z]{2,3})?[.][a-zA-Z]{2,3}");
            if (!string.IsNullOrWhiteSpace(textBoxEmailId.Text)
                    && !Regex.IsMatch(textBoxEmailId.Text,
                    @rejex.ToString(),
                    RegexOptions.IgnoreCase))
            {
                e.Cancel = true;
                textBoxEmailId.Focus();
                MessageBox.Show("Email Id Should Be In Valid Formate!\nEnter Valid Email id");
            }
            else
            {
                e.Cancel = false;
            }
        }

        /// <summary>
        /// Its get And Validate Date Of Birth And Age Should Be In Above 18 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateTimePickerDOB_Validating(object sender, CancelEventArgs e)
        {
            int age = DateTime.Now.Year - dateTimePickerDOB.Value.Year;
            if (DateTime.Now.DayOfYear < dateTimePickerDOB.Value.DayOfYear)
                age--;
            if (age < 18)
            {
                e.Cancel = true;
                dateTimePickerDOB.Focus();
                MessageBox.Show("Your Not Eligible. Age Should Be In Above 18! \nEnter Valid Date Of Birth");
            }
        }

        /// <summary>
        /// Gets And Validate The Qualification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxQualification_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxQualification.Text))
            {
                e.Cancel = true;
                comboBoxQualification.Focus();
                MessageBox.Show("You should select any one degree from the list!");
            }
            else
            {
                e.Cancel = false;
            }
        }

        /// <summary>
        /// Its validate the address and the address should be not null and empty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RichTextBoxAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(richTextBoxAddress.Text))
            {
                e.Cancel = true;
                richTextBoxAddress.Focus();
                MessageBox.Show("Address Cannot Be Empty!\nEnter Valid Address");
            }
            else
            {
                e.Cancel = false;
            }
        }

        /// <summary>
        /// Its gets fresers details and perform add or update besed on user selection from the design form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Submit_Click(object sender, EventArgs e)
        {
            freshersControl = new FreshersManagementSystemService();
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (labelHeader.Text == "Add Fresher")
                {
                    AddFresher(sender, e);
                    
                }
                else if (labelHeader.Text == "Update Fresher")
                {
                    UpdaetFresher(sender, e);
                    this.Close();
                }
            }
        }

        /// <summary>
        /// Gets updated details of fresher and update updated frehsers details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdaetFresher(object sender, EventArgs e)
        {
            name = textBoxName.Text;
            mobilNumber = textBoxMobileNumber.Text;
            emailId = textBoxEmailId.Text;
            dateOfBirth = DateTime.Parse(dateTimePickerDOB.Text);
            address = richTextBoxAddress.Text;
            qualification = comboBoxQualification.Text;
            Fresher fresher = new(name, emailId, mobilNumber, address, dateOfBirth, qualification);
            fresher.id = Convert.ToInt32(lalbleId.Text);
            int result = freshersControl.UpdateFresher(fresher);
            MessageBox.Show((1 == result) ? "Fresher "+fresher.name  +" updated successfully"
                :"Error While Update Fresher "+fresher.name+" !");
        }

        /// <summary>
        /// Gets new freshers details and add an new fresher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddFresher(object sender, EventArgs e)
        {
            name = textBoxName.Text;
            mobilNumber = textBoxMobileNumber.Text;
            emailId = textBoxEmailId.Text;
            dateOfBirth = DateTime.Parse(dateTimePickerDOB.Text);
            address = richTextBoxAddress.Text;
            qualification = comboBoxQualification.Text;
            Fresher fresher = new(name, emailId, mobilNumber, address, dateOfBirth, qualification);
            int result = freshersControl.InsertFresher(fresher);
            if (1 == result)
            {
                MessageBox.Show("Fresher Created successfully");
                Empty(); 
                if (MessageBox.Show("You Want To Add Another Fresher Details Now?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    this.Close();
                }
            } else
            {
                MessageBox.Show("Error While Creating New Fresher ! Email id | Mobile Number Already Exists!");
            }        
        }

        /// <summary>
        /// Its clear the all existing value for getting new value of an freshers
        /// </summary>
        public void Empty()
        {
            textBoxName.Clear();
            textBoxEmailId.Clear();
            textBoxMobileNumber.Clear();
            richTextBoxAddress.Clear();
            dateTimePickerDOB.Text = null;
            comboBoxQualification.Text = "";
        }

        /// <summary>
        /// Gets and fill the freshers details in the add form to update the details of an frehsers
        /// </summary>
        /// <param name="fresherToUpdate">The fresher which want to be update</param>
        private void fillForm(Fresher fresherToUpdate)
        {
            textBoxName.Text = fresherToUpdate.name;
            textBoxEmailId.Text = fresherToUpdate.emailId;
            textBoxMobileNumber.Text = fresherToUpdate.mobileNumber;
            dateTimePickerDOB.Value = fresherToUpdate.dateOfBirth;
            comboBoxQualification.Text = fresherToUpdate.qualification;
            richTextBoxAddress.Text = fresherToUpdate.address;
        }
    }
}
