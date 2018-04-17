namespace FinalProject
{
    partial class frmEmployeeInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeInfo));
            this.dataGridEmployeeInfo = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFire = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAllEmp = new System.Windows.Forms.Button();
            this.btnPreviousEmp = new System.Windows.Forms.Button();
            this.btnCurrentEmp = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployeeInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridEmployeeInfo
            // 
            this.dataGridEmployeeInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmployeeInfo.Location = new System.Drawing.Point(12, 12);
            this.dataGridEmployeeInfo.Name = "dataGridEmployeeInfo";
            this.dataGridEmployeeInfo.RowTemplate.Height = 24;
            this.dataGridEmployeeInfo.Size = new System.Drawing.Size(427, 322);
            this.dataGridEmployeeInfo.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(462, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFire
            // 
            this.btnFire.BackColor = System.Drawing.SystemColors.Control;
            this.btnFire.Location = new System.Drawing.Point(462, 99);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(75, 23);
            this.btnFire.TabIndex = 2;
            this.btnFire.Text = "Fire";
            this.btnFire.UseVisualStyleBackColor = false;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.SystemColors.Control;
            this.btnModify.Location = new System.Drawing.Point(462, 140);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(462, 59);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAllEmp
            // 
            this.btnAllEmp.BackColor = System.Drawing.SystemColors.Control;
            this.btnAllEmp.Location = new System.Drawing.Point(194, 352);
            this.btnAllEmp.Name = "btnAllEmp";
            this.btnAllEmp.Size = new System.Drawing.Size(75, 23);
            this.btnAllEmp.TabIndex = 6;
            this.btnAllEmp.Text = "All";
            this.btnAllEmp.UseVisualStyleBackColor = false;
            this.btnAllEmp.Click += new System.EventHandler(this.btnAllEmp_Click);
            // 
            // btnPreviousEmp
            // 
            this.btnPreviousEmp.BackColor = System.Drawing.SystemColors.Control;
            this.btnPreviousEmp.Location = new System.Drawing.Point(102, 352);
            this.btnPreviousEmp.Name = "btnPreviousEmp";
            this.btnPreviousEmp.Size = new System.Drawing.Size(75, 23);
            this.btnPreviousEmp.TabIndex = 7;
            this.btnPreviousEmp.Text = "Previous";
            this.btnPreviousEmp.UseVisualStyleBackColor = false;
            this.btnPreviousEmp.Click += new System.EventHandler(this.btnPreviousEmp_Click);
            // 
            // btnCurrentEmp
            // 
            this.btnCurrentEmp.BackColor = System.Drawing.SystemColors.Control;
            this.btnCurrentEmp.Location = new System.Drawing.Point(12, 352);
            this.btnCurrentEmp.Name = "btnCurrentEmp";
            this.btnCurrentEmp.Size = new System.Drawing.Size(75, 23);
            this.btnCurrentEmp.TabIndex = 8;
            this.btnCurrentEmp.Text = "Current";
            this.btnCurrentEmp.UseVisualStyleBackColor = false;
            this.btnCurrentEmp.Click += new System.EventHandler(this.btnCurrentEmp_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(462, 311);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 9;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(462, 352);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmEmployeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(549, 386);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnCurrentEmp);
            this.Controls.Add(this.btnPreviousEmp);
            this.Controls.Add(this.btnAllEmp);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridEmployeeInfo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEmployeeInfo";
            this.Text = "Employee Information";
            this.Load += new System.EventHandler(this.frmEmployeeInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployeeInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridEmployeeInfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAllEmp;
        private System.Windows.Forms.Button btnPreviousEmp;
        private System.Windows.Forms.Button btnCurrentEmp;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnExit;
    }
}