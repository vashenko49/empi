namespace WindowsFormsApp2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_find_folder = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label_LOC = new System.Windows.Forms.Label();
            this.label_NOM = new System.Windows.Forms.Label();
            this.label_NOC = new System.Windows.Forms.Label();
            this.label_NOP = new System.Windows.Forms.Label();
            this.label_NDD = new System.Windows.Forms.Label();
            this.label_CALL = new System.Windows.Forms.Label();
            this.label_WMC = new System.Windows.Forms.Label();
            this.label_TCC = new System.Windows.Forms.Label();
            this.label_PNAS = new System.Windows.Forms.Label();
            this.textBox_address_folder = new System.Windows.Forms.TextBox();
            this.button_START = new System.Windows.Forms.Button();
            this.label_12 = new System.Windows.Forms.Label();
            this.label_count_files = new System.Windows.Forms.Label();
            this.progressBar_count = new System.Windows.Forms.ProgressBar();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "LOC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "NOC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "NOP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "NDD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "CALL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "WMC";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "ТСС";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button_find_folder
            // 
            this.button_find_folder.Location = new System.Drawing.Point(12, 12);
            this.button_find_folder.Name = "button_find_folder";
            this.button_find_folder.Size = new System.Drawing.Size(75, 23);
            this.button_find_folder.TabIndex = 9;
            this.button_find_folder.Text = "find folder";
            this.button_find_folder.UseVisualStyleBackColor = true;
            this.button_find_folder.Click += new System.EventHandler(this.button_find_folder_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "PNAS";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label_LOC
            // 
            this.label_LOC.AutoSize = true;
            this.label_LOC.Location = new System.Drawing.Point(115, 115);
            this.label_LOC.Name = "label_LOC";
            this.label_LOC.Size = new System.Drawing.Size(28, 13);
            this.label_LOC.TabIndex = 11;
            this.label_LOC.Text = "data";
            // 
            // label_NOM
            // 
            this.label_NOM.AutoSize = true;
            this.label_NOM.Location = new System.Drawing.Point(115, 138);
            this.label_NOM.Name = "label_NOM";
            this.label_NOM.Size = new System.Drawing.Size(28, 13);
            this.label_NOM.TabIndex = 12;
            this.label_NOM.Text = "data";
            // 
            // label_NOC
            // 
            this.label_NOC.AutoSize = true;
            this.label_NOC.Location = new System.Drawing.Point(117, 161);
            this.label_NOC.Name = "label_NOC";
            this.label_NOC.Size = new System.Drawing.Size(28, 13);
            this.label_NOC.TabIndex = 13;
            this.label_NOC.Text = "date";
            // 
            // label_NOP
            // 
            this.label_NOP.AutoSize = true;
            this.label_NOP.Location = new System.Drawing.Point(115, 183);
            this.label_NOP.Name = "label_NOP";
            this.label_NOP.Size = new System.Drawing.Size(28, 13);
            this.label_NOP.TabIndex = 14;
            this.label_NOP.Text = "date";
            // 
            // label_NDD
            // 
            this.label_NDD.AutoSize = true;
            this.label_NDD.Location = new System.Drawing.Point(115, 205);
            this.label_NDD.Name = "label_NDD";
            this.label_NDD.Size = new System.Drawing.Size(28, 13);
            this.label_NDD.TabIndex = 15;
            this.label_NDD.Text = "date";
            // 
            // label_CALL
            // 
            this.label_CALL.AutoSize = true;
            this.label_CALL.Location = new System.Drawing.Point(115, 228);
            this.label_CALL.Name = "label_CALL";
            this.label_CALL.Size = new System.Drawing.Size(28, 13);
            this.label_CALL.TabIndex = 17;
            this.label_CALL.Text = "date";
            // 
            // label_WMC
            // 
            this.label_WMC.AutoSize = true;
            this.label_WMC.Location = new System.Drawing.Point(115, 250);
            this.label_WMC.Name = "label_WMC";
            this.label_WMC.Size = new System.Drawing.Size(28, 13);
            this.label_WMC.TabIndex = 18;
            this.label_WMC.Text = "date";
            // 
            // label_TCC
            // 
            this.label_TCC.AutoSize = true;
            this.label_TCC.Location = new System.Drawing.Point(115, 274);
            this.label_TCC.Name = "label_TCC";
            this.label_TCC.Size = new System.Drawing.Size(28, 13);
            this.label_TCC.TabIndex = 19;
            this.label_TCC.Text = "date";
            // 
            // label_PNAS
            // 
            this.label_PNAS.AutoSize = true;
            this.label_PNAS.Location = new System.Drawing.Point(117, 297);
            this.label_PNAS.Name = "label_PNAS";
            this.label_PNAS.Size = new System.Drawing.Size(28, 13);
            this.label_PNAS.TabIndex = 21;
            this.label_PNAS.Text = "date";
            // 
            // textBox_address_folder
            // 
            this.textBox_address_folder.Location = new System.Drawing.Point(93, 12);
            this.textBox_address_folder.Name = "textBox_address_folder";
            this.textBox_address_folder.Size = new System.Drawing.Size(100, 20);
            this.textBox_address_folder.TabIndex = 22;
            // 
            // button_START
            // 
            this.button_START.Location = new System.Drawing.Point(12, 41);
            this.button_START.Name = "button_START";
            this.button_START.Size = new System.Drawing.Size(181, 23);
            this.button_START.TabIndex = 23;
            this.button_START.Text = "START";
            this.button_START.UseVisualStyleBackColor = true;
            this.button_START.Click += new System.EventHandler(this.button_START_Click);
            // 
            // label_12
            // 
            this.label_12.AutoSize = true;
            this.label_12.Location = new System.Drawing.Point(59, 88);
            this.label_12.Name = "label_12";
            this.label_12.Size = new System.Drawing.Size(25, 13);
            this.label_12.TabIndex = 24;
            this.label_12.Text = "files";
            // 
            // label_count_files
            // 
            this.label_count_files.AutoSize = true;
            this.label_count_files.Location = new System.Drawing.Point(115, 88);
            this.label_count_files.Name = "label_count_files";
            this.label_count_files.Size = new System.Drawing.Size(28, 13);
            this.label_count_files.TabIndex = 25;
            this.label_count_files.Text = "data";
            // 
            // progressBar_count
            // 
            this.progressBar_count.Location = new System.Drawing.Point(12, 329);
            this.progressBar_count.Name = "progressBar_count";
            this.progressBar_count.Size = new System.Drawing.Size(181, 23);
            this.progressBar_count.TabIndex = 26;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(206, 364);
            this.Controls.Add(this.progressBar_count);
            this.Controls.Add(this.label_count_files);
            this.Controls.Add(this.label_12);
            this.Controls.Add(this.button_START);
            this.Controls.Add(this.textBox_address_folder);
            this.Controls.Add(this.label_PNAS);
            this.Controls.Add(this.label_TCC);
            this.Controls.Add(this.label_WMC);
            this.Controls.Add(this.label_CALL);
            this.Controls.Add(this.label_NDD);
            this.Controls.Add(this.label_NOP);
            this.Controls.Add(this.label_NOC);
            this.Controls.Add(this.label_NOM);
            this.Controls.Add(this.label_LOC);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button_find_folder);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Metrics";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_find_folder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_LOC;
        private System.Windows.Forms.Label label_NOM;
        private System.Windows.Forms.Label label_NOC;
        private System.Windows.Forms.Label label_NOP;
        private System.Windows.Forms.Label label_NDD;
        private System.Windows.Forms.Label label_CALL;
        private System.Windows.Forms.Label label_WMC;
        private System.Windows.Forms.Label label_TCC;
        private System.Windows.Forms.Label label_PNAS;
        private System.Windows.Forms.TextBox textBox_address_folder;
        private System.Windows.Forms.Button button_START;
        private System.Windows.Forms.Label label_12;
        private System.Windows.Forms.Label label_count_files;
        private System.Windows.Forms.ProgressBar progressBar_count;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

