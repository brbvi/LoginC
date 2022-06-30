namespace LoginC {
    partial class FrmRegistro {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtUsernameReg = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.txtPasswordReg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnviarReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsernameReg
            // 
            this.txtUsernameReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtUsernameReg.Location = new System.Drawing.Point(101, 82);
            this.txtUsernameReg.Name = "txtUsernameReg";
            this.txtUsernameReg.Size = new System.Drawing.Size(292, 29);
            this.txtUsernameReg.TabIndex = 0;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(97, 59);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(93, 20);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "Username";
            // 
            // txtPasswordReg
            // 
            this.txtPasswordReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtPasswordReg.Location = new System.Drawing.Point(101, 166);
            this.txtPasswordReg.Name = "txtPasswordReg";
            this.txtPasswordReg.Size = new System.Drawing.Size(292, 29);
            this.txtPasswordReg.TabIndex = 0;
            this.txtPasswordReg.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnEnviarReg
            // 
            this.btnEnviarReg.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarReg.Location = new System.Drawing.Point(101, 224);
            this.btnEnviarReg.Name = "btnEnviarReg";
            this.btnEnviarReg.Size = new System.Drawing.Size(292, 36);
            this.btnEnviarReg.TabIndex = 2;
            this.btnEnviarReg.Text = "Registrar";
            this.btnEnviarReg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEnviarReg.UseVisualStyleBackColor = true;
            this.btnEnviarReg.Click += new System.EventHandler(this.btnEnviarReg_Click);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 329);
            this.Controls.Add(this.btnEnviarReg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.txtPasswordReg);
            this.Controls.Add(this.txtUsernameReg);
            this.Name = "FrmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsernameReg;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox txtPasswordReg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnviarReg;
    }
}