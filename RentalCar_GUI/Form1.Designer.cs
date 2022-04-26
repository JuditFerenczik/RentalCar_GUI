
namespace RentalCar_GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAuto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericNapi = new System.Windows.Forms.NumericUpDown();
            this.numericFizet = new System.Windows.Forms.NumericUpDown();
            this.dateTimeTol = new System.Windows.Forms.DateTimePicker();
            this.dateTimeIg = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericNapi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFizet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autó";
            // 
            // comboBoxAuto
            // 
            this.comboBoxAuto.FormattingEnabled = true;
            this.comboBoxAuto.Location = new System.Drawing.Point(132, 76);
            this.comboBoxAuto.Name = "comboBoxAuto";
            this.comboBoxAuto.Size = new System.Drawing.Size(237, 21);
            this.comboBoxAuto.TabIndex = 1;
            this.comboBoxAuto.SelectedIndexChanged += new System.EventHandler(this.comboBoxAuto_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Napidíj";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mikortól";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Meddig";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fizetendő";
            // 
            // numericNapi
            // 
            this.numericNapi.Enabled = false;
            this.numericNapi.Location = new System.Drawing.Point(132, 121);
            this.numericNapi.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericNapi.Name = "numericNapi";
            this.numericNapi.Size = new System.Drawing.Size(198, 20);
            this.numericNapi.TabIndex = 6;
            // 
            // numericFizet
            // 
            this.numericFizet.Enabled = false;
            this.numericFizet.Location = new System.Drawing.Point(132, 238);
            this.numericFizet.Maximum = new decimal(new int[] {
            -159383552,
            46653770,
            5421,
            0});
            this.numericFizet.Name = "numericFizet";
            this.numericFizet.Size = new System.Drawing.Size(198, 20);
            this.numericFizet.TabIndex = 7;
            // 
            // dateTimeTol
            // 
            this.dateTimeTol.Location = new System.Drawing.Point(132, 162);
            this.dateTimeTol.Name = "dateTimeTol";
            this.dateTimeTol.Size = new System.Drawing.Size(198, 20);
            this.dateTimeTol.TabIndex = 8;
            this.dateTimeTol.ValueChanged += new System.EventHandler(this.dateTimeTol_ValueChanged);
            // 
            // dateTimeIg
            // 
            this.dateTimeIg.Location = new System.Drawing.Point(132, 203);
            this.dateTimeIg.Name = "dateTimeIg";
            this.dateTimeIg.Size = new System.Drawing.Size(198, 20);
            this.dateTimeIg.TabIndex = 9;
            this.dateTimeIg.ValueChanged += new System.EventHandler(this.dateTimeIg_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Rögzít";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 395);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimeIg);
            this.Controls.Add(this.dateTimeTol);
            this.Controls.Add(this.numericFizet);
            this.Controls.Add(this.numericNapi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxAuto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Autó kölcsönzés";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericNapi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFizet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAuto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericNapi;
        private System.Windows.Forms.NumericUpDown numericFizet;
        private System.Windows.Forms.DateTimePicker dateTimeTol;
        private System.Windows.Forms.DateTimePicker dateTimeIg;
        private System.Windows.Forms.Button button1;
    }
}

