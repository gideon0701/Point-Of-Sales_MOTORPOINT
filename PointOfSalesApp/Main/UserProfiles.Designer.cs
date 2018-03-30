namespace PointOfSalesApp.Main
{
    partial class UserProfiles
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
            this.lblEmpMngt = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnBackUsrPr = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmpMngt
            // 
            this.lblEmpMngt.AutoSize = true;
            this.lblEmpMngt.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpMngt.Location = new System.Drawing.Point(326, 77);
            this.lblEmpMngt.Name = "lblEmpMngt";
            this.lblEmpMngt.Size = new System.Drawing.Size(285, 37);
            this.lblEmpMngt.TabIndex = 1;
            this.lblEmpMngt.Text = "Employee Management";
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Location = new System.Drawing.Point(887, 32);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(33, 31);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.UseVisualStyleBackColor = false;
            // 
            // btnBackUsrPr
            // 
            this.btnBackUsrPr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBackUsrPr.FlatAppearance.BorderSize = 0;
            this.btnBackUsrPr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackUsrPr.Location = new System.Drawing.Point(853, 32);
            this.btnBackUsrPr.Name = "btnBackUsrPr";
            this.btnBackUsrPr.Size = new System.Drawing.Size(28, 31);
            this.btnBackUsrPr.TabIndex = 8;
            this.btnBackUsrPr.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(217, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 75);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROMAINE CABILDO";
            // 
            // UserProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 477);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnBackUsrPr);
            this.Controls.Add(this.lblEmpMngt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserProfiles";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "User Profiles";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEmpMngt;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnBackUsrPr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}