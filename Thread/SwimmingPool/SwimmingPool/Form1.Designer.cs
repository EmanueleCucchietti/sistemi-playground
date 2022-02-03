namespace SwimmingPool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAtleti = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblStato = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEsito = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEliminati = new System.Windows.Forms.Label();
            this.btnAvvia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(215, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(565, 15);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(390, 15);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(125, 27);
            this.textBox4.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(701, 701);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblAtleti
            // 
            this.lblAtleti.AutoSize = true;
            this.lblAtleti.Location = new System.Drawing.Point(736, 15);
            this.lblAtleti.Name = "lblAtleti";
            this.lblAtleti.Size = new System.Drawing.Size(50, 20);
            this.lblAtleti.TabIndex = 5;
            this.lblAtleti.Text = "label1";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(725, 401);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(68, 20);
            this.lblTurno.TabIndex = 6;
            this.lblTurno.Text = "[TURNO]";
            // 
            // lblStato
            // 
            this.lblStato.AutoSize = true;
            this.lblStato.Location = new System.Drawing.Point(725, 436);
            this.lblStato.Name = "lblStato";
            this.lblStato.Size = new System.Drawing.Size(69, 20);
            this.lblStato.TabIndex = 7;
            this.lblStato.Text = "[STATUS]";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEsito);
            this.groupBox1.Location = new System.Drawing.Point(719, 473);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 273);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BATTERIA FINALISTI";
            // 
            // lblEsito
            // 
            this.lblEsito.AutoSize = true;
            this.lblEsito.Location = new System.Drawing.Point(17, 35);
            this.lblEsito.Name = "lblEsito";
            this.lblEsito.Size = new System.Drawing.Size(50, 20);
            this.lblEsito.TabIndex = 0;
            this.lblEsito.Text = "label3";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEliminati);
            this.groupBox2.Location = new System.Drawing.Point(899, 473);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 273);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ELIMINATI";
            // 
            // lblEliminati
            // 
            this.lblEliminati.AutoSize = true;
            this.lblEliminati.Location = new System.Drawing.Point(17, 35);
            this.lblEliminati.Name = "lblEliminati";
            this.lblEliminati.Size = new System.Drawing.Size(50, 20);
            this.lblEliminati.TabIndex = 0;
            this.lblEliminati.Text = "label3";
            // 
            // btnAvvia
            // 
            this.btnAvvia.Location = new System.Drawing.Point(970, 15);
            this.btnAvvia.Name = "btnAvvia";
            this.btnAvvia.Size = new System.Drawing.Size(94, 29);
            this.btnAvvia.TabIndex = 10;
            this.btnAvvia.Text = "Avvia";
            this.btnAvvia.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 817);
            this.Controls.Add(this.btnAvvia);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblStato);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblAtleti);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private PictureBox pictureBox1;
        private Label lblAtleti;
        private Label lblTurno;
        private Label lblStato;
        private GroupBox groupBox1;
        private Label lblEsito;
        private GroupBox groupBox2;
        private Label lblEliminati;
        private Button btnAvvia;
    }
}