namespace iSpeed
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbtn_Brief = new System.Windows.Forms.RadioButton();
            this.lbl_Sendungsart = new System.Windows.Forms.Label();
            this.cbox_Sendungsart = new System.Windows.Forms.ComboBox();
            this.btn_Portorechnen = new System.Windows.Forms.Button();
            this.rbtn_Packet = new System.Windows.Forms.RadioButton();
            this.lbl_Gewicht = new System.Windows.Forms.Label();
            this.lbl_Entfernung = new System.Windows.Forms.Label();
            this.nud_Entfernung = new System.Windows.Forms.NumericUpDown();
            this.nud_Gewicht = new System.Windows.Forms.NumericUpDown();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lbl_Porto = new System.Windows.Forms.Label();
            this.tbox_Porto = new System.Windows.Forms.TextBox();
            this.lbl_km = new System.Windows.Forms.Label();
            this.lbl_kg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Entfernung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Gewicht)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtn_Brief
            // 
            this.rbtn_Brief.AutoSize = true;
            this.rbtn_Brief.Location = new System.Drawing.Point(125, 36);
            this.rbtn_Brief.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_Brief.Name = "rbtn_Brief";
            this.rbtn_Brief.Size = new System.Drawing.Size(55, 20);
            this.rbtn_Brief.TabIndex = 0;
            this.rbtn_Brief.TabStop = true;
            this.rbtn_Brief.Text = "Brief";
            this.rbtn_Brief.UseVisualStyleBackColor = true;
            // 
            // lbl_Sendungsart
            // 
            this.lbl_Sendungsart.AutoSize = true;
            this.lbl_Sendungsart.Location = new System.Drawing.Point(12, 80);
            this.lbl_Sendungsart.Name = "lbl_Sendungsart";
            this.lbl_Sendungsart.Size = new System.Drawing.Size(83, 16);
            this.lbl_Sendungsart.TabIndex = 1;
            this.lbl_Sendungsart.Text = "Sendungsart";
            // 
            // cbox_Sendungsart
            // 
            this.cbox_Sendungsart.FormattingEnabled = true;
            this.cbox_Sendungsart.Location = new System.Drawing.Point(125, 78);
            this.cbox_Sendungsart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbox_Sendungsart.Name = "cbox_Sendungsart";
            this.cbox_Sendungsart.Size = new System.Drawing.Size(167, 24);
            this.cbox_Sendungsart.TabIndex = 2;
            // 
            // btn_Portorechnen
            // 
            this.btn_Portorechnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Portorechnen.Location = new System.Drawing.Point(619, 126);
            this.btn_Portorechnen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Portorechnen.Name = "btn_Portorechnen";
            this.btn_Portorechnen.Size = new System.Drawing.Size(169, 65);
            this.btn_Portorechnen.TabIndex = 3;
            this.btn_Portorechnen.Text = "Porto Berechnen";
            this.btn_Portorechnen.UseVisualStyleBackColor = true;
            this.btn_Portorechnen.Click += new System.EventHandler(this.btn_Portorechnen_Click);
            // 
            // rbtn_Packet
            // 
            this.rbtn_Packet.AutoSize = true;
            this.rbtn_Packet.Location = new System.Drawing.Point(223, 36);
            this.rbtn_Packet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_Packet.Name = "rbtn_Packet";
            this.rbtn_Packet.Size = new System.Drawing.Size(70, 20);
            this.rbtn_Packet.TabIndex = 4;
            this.rbtn_Packet.TabStop = true;
            this.rbtn_Packet.Text = "Packet";
            this.rbtn_Packet.UseVisualStyleBackColor = true;
            // 
            // lbl_Gewicht
            // 
            this.lbl_Gewicht.AutoSize = true;
            this.lbl_Gewicht.Location = new System.Drawing.Point(12, 176);
            this.lbl_Gewicht.Name = "lbl_Gewicht";
            this.lbl_Gewicht.Size = new System.Drawing.Size(54, 16);
            this.lbl_Gewicht.TabIndex = 5;
            this.lbl_Gewicht.Text = "Gewicht";
            // 
            // lbl_Entfernung
            // 
            this.lbl_Entfernung.AutoSize = true;
            this.lbl_Entfernung.Location = new System.Drawing.Point(12, 127);
            this.lbl_Entfernung.Name = "lbl_Entfernung";
            this.lbl_Entfernung.Size = new System.Drawing.Size(70, 16);
            this.lbl_Entfernung.TabIndex = 6;
            this.lbl_Entfernung.Text = "Entfernung";
            // 
            // nud_Entfernung
            // 
            this.nud_Entfernung.Location = new System.Drawing.Point(125, 126);
            this.nud_Entfernung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud_Entfernung.Name = "nud_Entfernung";
            this.nud_Entfernung.Size = new System.Drawing.Size(148, 22);
            this.nud_Entfernung.TabIndex = 7;
            // 
            // nud_Gewicht
            // 
            this.nud_Gewicht.Location = new System.Drawing.Point(125, 174);
            this.nud_Gewicht.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud_Gewicht.Name = "nud_Gewicht";
            this.nud_Gewicht.ReadOnly = true;
            this.nud_Gewicht.Size = new System.Drawing.Size(148, 22);
            this.nud_Gewicht.TabIndex = 8;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(619, 207);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(169, 65);
            this.btn_Clear.TabIndex = 9;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 365);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 358);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_Porto
            // 
            this.lbl_Porto.AutoSize = true;
            this.lbl_Porto.Location = new System.Drawing.Point(12, 287);
            this.lbl_Porto.Name = "lbl_Porto";
            this.lbl_Porto.Size = new System.Drawing.Size(39, 16);
            this.lbl_Porto.TabIndex = 11;
            this.lbl_Porto.Text = "Porto";
            // 
            // tbox_Porto
            // 
            this.tbox_Porto.Location = new System.Drawing.Point(125, 287);
            this.tbox_Porto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbox_Porto.Name = "tbox_Porto";
            this.tbox_Porto.ReadOnly = true;
            this.tbox_Porto.Size = new System.Drawing.Size(167, 22);
            this.tbox_Porto.TabIndex = 12;
            // 
            // lbl_km
            // 
            this.lbl_km.AutoSize = true;
            this.lbl_km.Location = new System.Drawing.Point(279, 132);
            this.lbl_km.Name = "lbl_km";
            this.lbl_km.Size = new System.Drawing.Size(25, 16);
            this.lbl_km.TabIndex = 13;
            this.lbl_km.Text = "km";
            // 
            // lbl_kg
            // 
            this.lbl_kg.AutoSize = true;
            this.lbl_kg.Location = new System.Drawing.Point(279, 180);
            this.lbl_kg.Name = "lbl_kg";
            this.lbl_kg.Size = new System.Drawing.Size(22, 16);
            this.lbl_kg.TabIndex = 14;
            this.lbl_kg.Text = "kg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 734);
            this.Controls.Add(this.lbl_kg);
            this.Controls.Add(this.lbl_km);
            this.Controls.Add(this.tbox_Porto);
            this.Controls.Add(this.lbl_Porto);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.nud_Gewicht);
            this.Controls.Add(this.nud_Entfernung);
            this.Controls.Add(this.lbl_Entfernung);
            this.Controls.Add(this.lbl_Gewicht);
            this.Controls.Add(this.rbtn_Packet);
            this.Controls.Add(this.btn_Portorechnen);
            this.Controls.Add(this.cbox_Sendungsart);
            this.Controls.Add(this.lbl_Sendungsart);
            this.Controls.Add(this.rbtn_Brief);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Packetstelle";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Entfernung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Gewicht)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtn_Brief;
        private System.Windows.Forms.Label lbl_Sendungsart;
        private System.Windows.Forms.ComboBox cbox_Sendungsart;
        private System.Windows.Forms.Button btn_Portorechnen;
        private System.Windows.Forms.RadioButton rbtn_Packet;
        private System.Windows.Forms.Label lbl_Gewicht;
        private System.Windows.Forms.Label lbl_Entfernung;
        private System.Windows.Forms.NumericUpDown nud_Entfernung;
        private System.Windows.Forms.NumericUpDown nud_Gewicht;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lbl_Porto;
        private System.Windows.Forms.TextBox tbox_Porto;
        private System.Windows.Forms.Label lbl_km;
        private System.Windows.Forms.Label lbl_kg;
    }
}

