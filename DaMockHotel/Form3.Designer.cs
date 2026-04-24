namespace DaMockHotel
{
    partial class Form3
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
            this.lbl_Find = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Enteremail = new System.Windows.Forms.Label();
            this.txt_Enternumber = new System.Windows.Forms.TextBox();
            this.btn_Continue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Find
            // 
            this.lbl_Find.AutoSize = true;
            this.lbl_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Find.Location = new System.Drawing.Point(395, 116);
            this.lbl_Find.Name = "lbl_Find";
            this.lbl_Find.Size = new System.Drawing.Size(247, 31);
            this.lbl_Find.TabIndex = 0;
            this.lbl_Find.Text = "Find your account";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // lbl_Enteremail
            // 
            this.lbl_Enteremail.AutoSize = true;
            this.lbl_Enteremail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Enteremail.Location = new System.Drawing.Point(413, 158);
            this.lbl_Enteremail.Name = "lbl_Enteremail";
            this.lbl_Enteremail.Size = new System.Drawing.Size(253, 20);
            this.lbl_Enteremail.TabIndex = 5;
            this.lbl_Enteremail.Text = "Enter your mobile number or email.";
            // 
            // txt_Enternumber
            // 
            this.txt_Enternumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Enternumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Enternumber.Location = new System.Drawing.Point(430, 192);
            this.txt_Enternumber.Name = "txt_Enternumber";
            this.txt_Enternumber.Size = new System.Drawing.Size(296, 22);
            this.txt_Enternumber.TabIndex = 6;
            this.txt_Enternumber.Text = "Mobile number or Email";
            this.txt_Enternumber.Visible = false;
            // 
            // btn_Continue
            // 
            this.btn_Continue.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Continue.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Continue.FlatAppearance.BorderSize = 0;
            this.btn_Continue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_Continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Continue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Continue.Location = new System.Drawing.Point(490, 239);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.Size = new System.Drawing.Size(176, 23);
            this.btn_Continue.TabIndex = 7;
            this.btn_Continue.Text = "Continue";
            this.btn_Continue.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 543);
            this.Controls.Add(this.btn_Continue);
            this.Controls.Add(this.txt_Enternumber);
            this.Controls.Add(this.lbl_Enteremail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Find);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Find;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Enteremail;
        private System.Windows.Forms.TextBox txt_Enternumber;
        private System.Windows.Forms.Button btn_Continue;
    }
}