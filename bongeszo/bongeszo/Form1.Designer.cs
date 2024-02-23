namespace bongeszo
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
            this.bongeszo = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.keres_g = new System.Windows.Forms.Button();
            this.frissit_b = new System.Windows.Forms.Button();
            this.elore_b = new System.Windows.Forms.Button();
            this.vissza_b = new System.Windows.Forms.Button();
            this.url_tb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bongeszo
            // 
            this.bongeszo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bongeszo.Location = new System.Drawing.Point(0, 29);
            this.bongeszo.MinimumSize = new System.Drawing.Size(20, 20);
            this.bongeszo.Name = "bongeszo";
            this.bongeszo.ScriptErrorsSuppressed = true;
            this.bongeszo.Size = new System.Drawing.Size(958, 483);
            this.bongeszo.TabIndex = 0;
            this.bongeszo.Url = new System.Uri("http://google.com", System.UriKind.Absolute);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.keres_g);
            this.panel1.Controls.Add(this.frissit_b);
            this.panel1.Controls.Add(this.elore_b);
            this.panel1.Controls.Add(this.vissza_b);
            this.panel1.Controls.Add(this.url_tb);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 32);
            this.panel1.TabIndex = 1;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // keres_g
            // 
            this.keres_g.Location = new System.Drawing.Point(893, 3);
            this.keres_g.Name = "keres_g";
            this.keres_g.Size = new System.Drawing.Size(53, 23);
            this.keres_g.TabIndex = 4;
            this.keres_g.Text = "Keresés";
            this.keres_g.UseVisualStyleBackColor = true;
            this.keres_g.Click += new System.EventHandler(this.keres_g_Click);
            // 
            // frissit_b
            // 
            this.frissit_b.Location = new System.Drawing.Point(82, 3);
            this.frissit_b.Name = "frissit_b";
            this.frissit_b.Size = new System.Drawing.Size(46, 23);
            this.frissit_b.TabIndex = 3;
            this.frissit_b.Text = "Frissít";
            this.frissit_b.UseVisualStyleBackColor = true;
            this.frissit_b.Click += new System.EventHandler(this.frissit_b_Click);
            // 
            // elore_b
            // 
            this.elore_b.Location = new System.Drawing.Point(43, 3);
            this.elore_b.Name = "elore_b";
            this.elore_b.Size = new System.Drawing.Size(33, 23);
            this.elore_b.TabIndex = 2;
            this.elore_b.Text = "->";
            this.elore_b.UseVisualStyleBackColor = true;
            this.elore_b.Click += new System.EventHandler(this.elore_b_Click);
            // 
            // vissza_b
            // 
            this.vissza_b.Location = new System.Drawing.Point(4, 3);
            this.vissza_b.Name = "vissza_b";
            this.vissza_b.Size = new System.Drawing.Size(33, 23);
            this.vissza_b.TabIndex = 1;
            this.vissza_b.Text = "<-";
            this.vissza_b.UseVisualStyleBackColor = true;
            this.vissza_b.Click += new System.EventHandler(this.vissza_b_Click);
            // 
            // url_tb
            // 
            this.url_tb.Location = new System.Drawing.Point(156, 5);
            this.url_tb.Name = "url_tb";
            this.url_tb.Size = new System.Drawing.Size(731, 20);
            this.url_tb.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bongeszo);
            this.Name = "Form1";
            this.Text = "Böngésző";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser bongeszo;
        private System.Windows.Forms.Button frissit_b;
        private System.Windows.Forms.Button elore_b;
        private System.Windows.Forms.Button vissza_b;
        private System.Windows.Forms.TextBox url_tb;
        private System.Windows.Forms.Button keres_g;
        private System.Windows.Forms.Panel panel1;
    }
}

