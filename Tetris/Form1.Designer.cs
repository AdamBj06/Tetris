namespace Tetris
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxWb = new System.Windows.Forms.PictureBox();
            this.pictureBoxWr = new System.Windows.Forms.PictureBox();
            this.pictureBoxWl = new System.Windows.Forms.PictureBox();
            this.pictureBoxWt = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWt)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBoxWb
            // 
            this.pictureBoxWb.BackColor = System.Drawing.Color.Gray;
            this.pictureBoxWb.Location = new System.Drawing.Point(175, 660);
            this.pictureBoxWb.Name = "pictureBoxWb";
            this.pictureBoxWb.Size = new System.Drawing.Size(300, 10);
            this.pictureBoxWb.TabIndex = 0;
            this.pictureBoxWb.TabStop = false;
            // 
            // pictureBoxWr
            // 
            this.pictureBoxWr.BackColor = System.Drawing.Color.Gray;
            this.pictureBoxWr.Location = new System.Drawing.Point(475, 50);
            this.pictureBoxWr.Name = "pictureBoxWr";
            this.pictureBoxWr.Size = new System.Drawing.Size(10, 620);
            this.pictureBoxWr.TabIndex = 1;
            this.pictureBoxWr.TabStop = false;
            // 
            // pictureBoxWl
            // 
            this.pictureBoxWl.BackColor = System.Drawing.Color.Gray;
            this.pictureBoxWl.Location = new System.Drawing.Point(165, 50);
            this.pictureBoxWl.Name = "pictureBoxWl";
            this.pictureBoxWl.Size = new System.Drawing.Size(10, 620);
            this.pictureBoxWl.TabIndex = 2;
            this.pictureBoxWl.TabStop = false;
            // 
            // pictureBoxWt
            // 
            this.pictureBoxWt.BackColor = System.Drawing.Color.Gray;
            this.pictureBoxWt.Location = new System.Drawing.Point(175, 50);
            this.pictureBoxWt.Name = "pictureBoxWt";
            this.pictureBoxWt.Size = new System.Drawing.Size(300, 10);
            this.pictureBoxWt.TabIndex = 3;
            this.pictureBoxWt.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Next Block";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(506, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Score: ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(506, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lines: ";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(506, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(506, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(665, 730);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxWt);
            this.Controls.Add(this.pictureBoxWl);
            this.Controls.Add(this.pictureBoxWr);
            this.Controls.Add(this.pictureBoxWb);
            this.Name = "Form1";
            this.Text = "Tetris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxWb;
        private System.Windows.Forms.PictureBox pictureBoxWr;
        private System.Windows.Forms.PictureBox pictureBoxWl;
        private System.Windows.Forms.PictureBox pictureBoxWt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

