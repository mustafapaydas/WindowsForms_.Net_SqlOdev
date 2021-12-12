
namespace HospitalReg
{
    partial class Delete
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
            this.lblDeletePageTwo = new System.Windows.Forms.Label();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpDelete = new System.Windows.Forms.GroupBox();
            this.grpDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeletePageTwo
            // 
            this.lblDeletePageTwo.AutoSize = true;
            this.lblDeletePageTwo.Location = new System.Drawing.Point(24, 41);
            this.lblDeletePageTwo.Name = "lblDeletePageTwo";
            this.lblDeletePageTwo.Size = new System.Drawing.Size(41, 17);
            this.lblDeletePageTwo.TabIndex = 0;
            this.lblDeletePageTwo.Text = "Id No";
            // 
            // txtDelete
            // 
            this.txtDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtDelete.Location = new System.Drawing.Point(80, 39);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(130, 21);
            this.txtDelete.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(89, 87);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grpDelete
            // 
            this.grpDelete.Controls.Add(this.txtDelete);
            this.grpDelete.Controls.Add(this.btnDelete);
            this.grpDelete.Controls.Add(this.lblDeletePageTwo);
            this.grpDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.grpDelete.Location = new System.Drawing.Point(21, 12);
            this.grpDelete.Name = "grpDelete";
            this.grpDelete.Size = new System.Drawing.Size(255, 130);
            this.grpDelete.TabIndex = 3;
            this.grpDelete.TabStop = false;
            this.grpDelete.Text = "Silme İşlemi";
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 145);
            this.Controls.Add(this.grpDelete);
            this.Name = "Delete";
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.Delete_Load);
            this.grpDelete.ResumeLayout(false);
            this.grpDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDeletePageTwo;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grpDelete;
    }
}