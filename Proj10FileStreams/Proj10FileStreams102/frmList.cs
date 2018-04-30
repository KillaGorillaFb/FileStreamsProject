using System;
using System.IO;
using System.Windows.Forms;

namespace Proj10FileStreams102
{
    /// <summary>
    /// Developer:      Frankie Barrios
    /// Date:           04/30/2018
    /// Purpose:        File Stream Assignment
    /// </summary>
    
    public partial class frmLst : Form
    {
        string filName;

        public frmLst()
        {
            InitializeComponent();
        }

        private void frmLst_Load(object sender, EventArgs e)
        {
            btnSaveAs.Enabled = false;
        }

        #region Enter Button Click
        private void btnEnter_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            lblMessage.Text = "";
            int id = 0;

            if (txtBxLastName.Text == "")
            {
                lblMessage.Text += "Last name is required!";
                isValid = false;
            }//Verifies last name is entered

            if (txtBxFirstName.Text == "")
            {
                lblMessage.Text += " First name is required!";
                isValid = false;
            }//Verifies first name is entered

            if (txtBxId.Text == "")
            {
                lblMessage.Text += " ID is required!";
                isValid = false;
            }//Verifies ID is entered
            else if (int.TryParse(txtBxId.Text, out id) == false)
            {
                lblMessage.Text += "ID must be numeric! ";
                isValid = false;
            }//Verified ID is numeric

            if (txtBxClass.Text == "")
            {
                lblMessage.Text += " Class is required!";
                isValid = false;
            }//Verifies class is entered

            if (txtBxGrade.Text == "")
            {
                lblMessage.Text += " Grade is required!";
                isValid = false;
            }//Verifies grade is entered

            if (isValid)
            {
                StudentClass aStudent = new StudentClass(txtBxLastName.Text,
                                                         txtBxFirstName.Text,
                                                         id,
                                                         txtBxClass.Text,
                                                         txtBxGrade.Text);
                lstBxGrades.Items.Add(aStudent);
                lblMessage.Text = "Student added successfully!";
                ClearBox();
                btnSaveAs.Enabled = true;
            } //end of isValid          
        }
        #endregion

        #region Clear Box Method        
        /// <summary>
        /// Clears boxes after clicking enter
        /// </summary>
        void ClearBox()
        {
            txtBxLastName.Clear();
            txtBxFirstName.Clear();
            txtBxGrade.Clear();
            txtBxId.Clear();
            txtBxClass.Clear();
            txtBxLastName.Focus();
        }//End of clearbox
        #endregion

        #region Save As Button
        /// <summary>
        /// Save as button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.FileName = filName;
                saveFileDialog1.ShowDialog();
                filName = saveFileDialog1.FileName;
                StreamWriter outFile = new StreamWriter(filName);
                foreach (StudentClass item in lstBxGrades.Items)
                {
                    outFile.WriteLine(item.ToFileString());
                }
                outFile.Close();
                lblMessage.Text = "File Saved";              
            }//end of try
            catch(Exception exc)
            {
                lblMessage.Text = exc.Message;
            }//end of catch
        }
        #endregion

        #region Load Button
        /// <summary>
        /// Load button click event. 
        /// Reads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            string inputRecord;
            string[] fields;

            try
            {
                openFileDialog1.FileName = filName;
                openFileDialog1.ShowDialog();
                filName = openFileDialog1.FileName;
                StreamReader inFile = new StreamReader(filName);
                inputRecord = inFile.ReadLine();
                while (inputRecord != null)
                {
                    fields = inputRecord.Split(',');
                    StudentClass aStudent = new StudentClass();
                    aStudent.LastName = fields[0];
                    aStudent.FirstName = fields[1];
                    aStudent.IdNumber = Convert.ToInt32(fields[2]);
                    aStudent.ClassName = fields[3];
                    aStudent.Grade = fields[4];
                    lstBxGrades.Items.Add(aStudent);
                    inputRecord = inFile.ReadLine();
                }//end of while
                inFile.Close();
                lblMessage.Text = "File Loaded";
                btnSaveAs.Enabled = true;
            }//end of try
            catch (Exception exc)
            {
                lblMessage.Text = exc.Message;
            }//end of catch
            #endregion
        }//end of form
    }//end of class
}//end of solution
