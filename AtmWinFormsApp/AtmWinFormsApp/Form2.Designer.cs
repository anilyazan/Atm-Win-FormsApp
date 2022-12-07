namespace AtmWinFormsApp
{
    partial class Form2
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
            this.btn_parayatir = new System.Windows.Forms.Button();
            this.btn_paracekme = new System.Windows.Forms.Button();
            this.lbl_bakiye = new System.Windows.Forms.Label();
            this.lbl_paramiz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_parayatir
            // 
            this.btn_parayatir.Location = new System.Drawing.Point(329, 253);
            this.btn_parayatir.Name = "btn_parayatir";
            this.btn_parayatir.Size = new System.Drawing.Size(152, 52);
            this.btn_parayatir.TabIndex = 0;
            this.btn_parayatir.Text = "Para yatırma";
            this.btn_parayatir.UseVisualStyleBackColor = true;
            // 
            // btn_paracekme
            // 
            this.btn_paracekme.Location = new System.Drawing.Point(329, 335);
            this.btn_paracekme.Name = "btn_paracekme";
            this.btn_paracekme.Size = new System.Drawing.Size(152, 52);
            this.btn_paracekme.TabIndex = 1;
            this.btn_paracekme.Text = "Para çekme";
            this.btn_paracekme.UseVisualStyleBackColor = true;
            // 
            // lbl_bakiye
            // 
            this.lbl_bakiye.AutoSize = true;
            this.lbl_bakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bakiye.Location = new System.Drawing.Point(326, 112);
            this.lbl_bakiye.Name = "lbl_bakiye";
            this.lbl_bakiye.Size = new System.Drawing.Size(82, 25);
            this.lbl_bakiye.TabIndex = 2;
            this.lbl_bakiye.Text = "Bakiye :";
            // 
            // lbl_paramiz
            // 
            this.lbl_paramiz.AutoSize = true;
            this.lbl_paramiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_paramiz.Location = new System.Drawing.Point(460, 112);
            this.lbl_paramiz.Name = "lbl_paramiz";
            this.lbl_paramiz.Size = new System.Drawing.Size(56, 25);
            this.lbl_paramiz.TabIndex = 3;
            this.lbl_paramiz.Text = "2000";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_paramiz);
            this.Controls.Add(this.lbl_bakiye);
            this.Controls.Add(this.btn_paracekme);
            this.Controls.Add(this.btn_parayatir);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_parayatir;
        private System.Windows.Forms.Button btn_paracekme;
        private System.Windows.Forms.Label lbl_bakiye;
        private System.Windows.Forms.Label lbl_paramiz;
    }
}