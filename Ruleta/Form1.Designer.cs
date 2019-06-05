namespace Ruleta
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
            this.label2 = new System.Windows.Forms.Label();
            this.Valorlabel = new System.Windows.Forms.Label();
            this.Jugarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Jugada1numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.apostearnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Jugada3numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Jugada2numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Jugada1numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apostearnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jugada3numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jugada2numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jugador ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(625, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor de la ruleta:";
            // 
            // Valorlabel
            // 
            this.Valorlabel.AutoSize = true;
            this.Valorlabel.Location = new System.Drawing.Point(670, 138);
            this.Valorlabel.Name = "Valorlabel";
            this.Valorlabel.Size = new System.Drawing.Size(16, 17);
            this.Valorlabel.TabIndex = 2;
            this.Valorlabel.Text = "0";
            // 
            // Jugarbutton
            // 
            this.Jugarbutton.Location = new System.Drawing.Point(651, 231);
            this.Jugarbutton.Name = "Jugarbutton";
            this.Jugarbutton.Size = new System.Drawing.Size(75, 23);
            this.Jugarbutton.TabIndex = 4;
            this.Jugarbutton.Text = "Jugar";
            this.Jugarbutton.UseVisualStyleBackColor = true;
            this.Jugarbutton.Click += new System.EventHandler(this.Jugarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(651, 273);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 5;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Jugada1numericUpDown
            // 
            this.Jugada1numericUpDown.Location = new System.Drawing.Point(43, 184);
            this.Jugada1numericUpDown.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.Jugada1numericUpDown.Name = "Jugada1numericUpDown";
            this.Jugada1numericUpDown.Size = new System.Drawing.Size(52, 22);
            this.Jugada1numericUpDown.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Numeros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dinero:";
            // 
            // apostearnumericUpDown
            // 
            this.apostearnumericUpDown.Location = new System.Drawing.Point(61, 280);
            this.apostearnumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.apostearnumericUpDown.Name = "apostearnumericUpDown";
            this.apostearnumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.apostearnumericUpDown.TabIndex = 11;
            // 
            // Jugada3numericUpDown
            // 
            this.Jugada3numericUpDown.Location = new System.Drawing.Point(187, 184);
            this.Jugada3numericUpDown.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.Jugada3numericUpDown.Name = "Jugada3numericUpDown";
            this.Jugada3numericUpDown.Size = new System.Drawing.Size(40, 22);
            this.Jugada3numericUpDown.TabIndex = 12;
            // 
            // Jugada2numericUpDown
            // 
            this.Jugada2numericUpDown.Location = new System.Drawing.Point(115, 184);
            this.Jugada2numericUpDown.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.Jugada2numericUpDown.Name = "Jugada2numericUpDown";
            this.Jugada2numericUpDown.Size = new System.Drawing.Size(49, 22);
            this.Jugada2numericUpDown.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Jugada2numericUpDown);
            this.Controls.Add(this.Jugada3numericUpDown);
            this.Controls.Add(this.apostearnumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Jugada1numericUpDown);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Jugarbutton);
            this.Controls.Add(this.Valorlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Jugada1numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apostearnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jugada3numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jugada2numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Valorlabel;
        private System.Windows.Forms.Button Jugarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.NumericUpDown Jugada1numericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown apostearnumericUpDown;
        private System.Windows.Forms.NumericUpDown Jugada3numericUpDown;
        private System.Windows.Forms.NumericUpDown Jugada2numericUpDown;
    }
}

