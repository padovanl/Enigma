namespace Simulatore_di_Enigma
{
    partial class Impostazioni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Impostazioni));
            this.listBoxRotoriDisponibili = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxRotoriSelezionati = new System.Windows.Forms.ListBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDeselect = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStrutturaRotore = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonAnnulla = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxRotoriDisponibili
            // 
            this.listBoxRotoriDisponibili.FormattingEnabled = true;
            this.listBoxRotoriDisponibili.Items.AddRange(new object[] {
            "Rotore I",
            "Rotore II",
            "Rotore III",
            "Rorote IV",
            "Rotore V"});
            this.listBoxRotoriDisponibili.Location = new System.Drawing.Point(6, 19);
            this.listBoxRotoriDisponibili.Name = "listBoxRotoriDisponibili";
            this.listBoxRotoriDisponibili.Size = new System.Drawing.Size(106, 147);
            this.listBoxRotoriDisponibili.TabIndex = 0;
            this.listBoxRotoriDisponibili.SelectedIndexChanged += new System.EventHandler(this.listBoxRotoriDisponibili_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxRotoriDisponibili);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 173);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rotori disponibili";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxRotoriSelezionati);
            this.groupBox2.Location = new System.Drawing.Point(215, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(119, 173);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rotori selezionati";
            // 
            // listBoxRotoriSelezionati
            // 
            this.listBoxRotoriSelezionati.FormattingEnabled = true;
            this.listBoxRotoriSelezionati.Location = new System.Drawing.Point(6, 19);
            this.listBoxRotoriSelezionati.Name = "listBoxRotoriSelezionati";
            this.listBoxRotoriSelezionati.Size = new System.Drawing.Size(106, 147);
            this.listBoxRotoriSelezionati.TabIndex = 0;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Image = ((System.Drawing.Image)(resources.GetObject("buttonSelect.Image")));
            this.buttonSelect.Location = new System.Drawing.Point(154, 25);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(38, 34);
            this.buttonSelect.TabIndex = 3;
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Image = ((System.Drawing.Image)(resources.GetObject("buttonDown.Image")));
            this.buttonDown.Location = new System.Drawing.Point(154, 145);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(38, 34);
            this.buttonDown.TabIndex = 4;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Image = ((System.Drawing.Image)(resources.GetObject("buttonUp.Image")));
            this.buttonUp.Location = new System.Drawing.Point(154, 105);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(38, 34);
            this.buttonUp.TabIndex = 5;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDeselect
            // 
            this.buttonDeselect.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeselect.Image")));
            this.buttonDeselect.Location = new System.Drawing.Point(154, 65);
            this.buttonDeselect.Name = "buttonDeselect";
            this.buttonDeselect.Size = new System.Drawing.Size(38, 34);
            this.buttonDeselect.TabIndex = 6;
            this.buttonDeselect.UseVisualStyleBackColor = true;
            this.buttonDeselect.Click += new System.EventHandler(this.buttonDeselect_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelStrutturaRotore);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(16, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 74);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Layout dei rotori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            // 
            // labelStrutturaRotore
            // 
            this.labelStrutturaRotore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStrutturaRotore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStrutturaRotore.Location = new System.Drawing.Point(10, 45);
            this.labelStrutturaRotore.Name = "labelStrutturaRotore";
            this.labelStrutturaRotore.Size = new System.Drawing.Size(299, 20);
            this.labelStrutturaRotore.TabIndex = 1;
            // 
            // buttonOk
            // 
            this.buttonOk.Image = ((System.Drawing.Image)(resources.GetObject("buttonOk.Image")));
            this.buttonOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOk.Location = new System.Drawing.Point(157, 284);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(85, 31);
            this.buttonOk.TabIndex = 9;
            this.buttonOk.Text = "Ok";
            this.buttonOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonAnnulla
            // 
            this.buttonAnnulla.Image = ((System.Drawing.Image)(resources.GetObject("buttonAnnulla.Image")));
            this.buttonAnnulla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnnulla.Location = new System.Drawing.Point(248, 284);
            this.buttonAnnulla.Name = "buttonAnnulla";
            this.buttonAnnulla.Size = new System.Drawing.Size(85, 31);
            this.buttonAnnulla.TabIndex = 10;
            this.buttonAnnulla.Text = "Annulla";
            this.buttonAnnulla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAnnulla.UseVisualStyleBackColor = true;
            this.buttonAnnulla.Click += new System.EventHandler(this.buttonAnnulla_Click);
            // 
            // Impostazioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 323);
            this.Controls.Add(this.buttonAnnulla);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonDeselect);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Impostazioni";
            this.Text = "Impostazioni";
            this.Load += new System.EventHandler(this.Impostazioni_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRotoriDisponibili;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxRotoriSelezionati;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDeselect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelStrutturaRotore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonAnnulla;
    }
}