namespace Proj10FileStreams102
{
    partial class frmLst
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBxLastName = new System.Windows.Forms.TextBox();
            this.txtBxFirstName = new System.Windows.Forms.TextBox();
            this.txtBxId = new System.Windows.Forms.TextBox();
            this.txtBxClass = new System.Windows.Forms.TextBox();
            this.txtBxGrade = new System.Windows.Forms.TextBox();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lstBxGrades = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Id Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Class";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Grade";
            // 
            // txtBxLastName
            // 
            this.txtBxLastName.Location = new System.Drawing.Point(155, 58);
            this.txtBxLastName.Name = "txtBxLastName";
            this.txtBxLastName.Size = new System.Drawing.Size(244, 30);
            this.txtBxLastName.TabIndex = 0;
            // 
            // txtBxFirstName
            // 
            this.txtBxFirstName.Location = new System.Drawing.Point(155, 102);
            this.txtBxFirstName.Name = "txtBxFirstName";
            this.txtBxFirstName.Size = new System.Drawing.Size(244, 30);
            this.txtBxFirstName.TabIndex = 1;
            // 
            // txtBxId
            // 
            this.txtBxId.Location = new System.Drawing.Point(155, 144);
            this.txtBxId.Name = "txtBxId";
            this.txtBxId.Size = new System.Drawing.Size(244, 30);
            this.txtBxId.TabIndex = 2;
            // 
            // txtBxClass
            // 
            this.txtBxClass.Location = new System.Drawing.Point(155, 186);
            this.txtBxClass.Name = "txtBxClass";
            this.txtBxClass.Size = new System.Drawing.Size(244, 30);
            this.txtBxClass.TabIndex = 3;
            // 
            // txtBxGrade
            // 
            this.txtBxGrade.Location = new System.Drawing.Point(155, 228);
            this.txtBxGrade.Name = "txtBxGrade";
            this.txtBxGrade.Size = new System.Drawing.Size(244, 30);
            this.txtBxGrade.TabIndex = 4;
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveAs.Location = new System.Drawing.Point(364, 305);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(103, 45);
            this.btnSaveAs.TabIndex = 5;
            this.btnSaveAs.Text = "Save As";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoad.Location = new System.Drawing.Point(486, 305);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(103, 45);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEnter.Location = new System.Drawing.Point(608, 305);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(103, 45);
            this.btnEnter.TabIndex = 7;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lstBxGrades
            // 
            this.lstBxGrades.FormattingEnabled = true;
            this.lstBxGrades.ItemHeight = 25;
            this.lstBxGrades.Location = new System.Drawing.Point(489, 70);
            this.lstBxGrades.Name = "lstBxGrades";
            this.lstBxGrades.Size = new System.Drawing.Size(592, 204);
            this.lstBxGrades.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Grades";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(9, 404);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(272, 25);
            this.lblMessage.TabIndex = 10;
            this.lblMessage.Text = "Welcome To Student Grades!";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Txt files (*.txt)|*.txt|All files|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Txt files (*.txt)|*.txt|All files|*.*";
            // 
            // frmLst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1106, 441);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstBxGrades);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.txtBxGrade);
            this.Controls.Add(this.txtBxClass);
            this.Controls.Add(this.txtBxId);
            this.Controls.Add(this.txtBxFirstName);
            this.Controls.Add(this.txtBxLastName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLst";
            this.Text = "Student Grade App";
            this.Load += new System.EventHandler(this.frmLst_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBxLastName;
        private System.Windows.Forms.TextBox txtBxFirstName;
        private System.Windows.Forms.TextBox txtBxId;
        private System.Windows.Forms.TextBox txtBxClass;
        private System.Windows.Forms.TextBox txtBxGrade;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ListBox lstBxGrades;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

