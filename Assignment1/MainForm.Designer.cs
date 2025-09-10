
namespace Assignment1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblHours = new Label();
            txtHours = new TextBox();
            btnSummarize = new Button();
            btnClear = new Button();
            lblSummary = new Label();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(67, 50);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(97, 25);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "&First Name";
            lblFirstName.Click += lblFirstName_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(67, 78);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 31);
            txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(307, 52);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(95, 25);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "&Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(307, 78);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 31);
            txtLastName.TabIndex = 3;
            // 
            // lblHours
            // 
            lblHours.AutoSize = true;
            lblHours.Location = new Point(573, 49);
            lblHours.Name = "lblHours";
            lblHours.Size = new Size(127, 25);
            lblHours.TabIndex = 4;
            lblHours.Text = "&Hours Worked";
            // 
            // txtHours
            // 
            txtHours.Location = new Point(573, 77);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(150, 31);
            txtHours.TabIndex = 5;
            // 
            // btnSummarize
            // 
            btnSummarize.Location = new Point(76, 186);
            btnSummarize.Name = "btnSummarize";
            btnSummarize.Size = new Size(112, 34);
            btnSummarize.TabIndex = 6;
            btnSummarize.Text = "&Summarize";
            btnSummarize.UseVisualStyleBackColor = true;
            btnSummarize.Click += btnSummarize_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(219, 186);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 7;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblSummary
            // 
            lblSummary.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSummary.Location = new Point(76, 283);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(647, 132);
            lblSummary.TextAlign = ContentAlignment.MiddleCenter;
            lblSummary.TabIndex = 8;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSummary);
            Controls.Add(btnClear);
            Controls.Add(btnSummarize);
            Controls.Add(txtHours);
            Controls.Add(lblHours);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Name = "MainForm";
            Text = "Assignment1";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblHours;
        private TextBox txtHours;
        private Button btnSummarize;
        private Button btnClear;
        private Label lblSummary;
    }
}
