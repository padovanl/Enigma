namespace Simulatore_di_Enigma
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelRotoreS = new System.Windows.Forms.Label();
            this.button1Down = new System.Windows.Forms.Button();
            this.labelRotoreR = new System.Windows.Forms.Label();
            this.labelRotoreM = new System.Windows.Forms.Label();
            this.button1Up = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2Down = new System.Windows.Forms.Button();
            this.button3Down = new System.Windows.Forms.Button();
            this.button3Up = new System.Windows.Forms.Button();
            this.button2Up = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.buttonElabora = new System.Windows.Forms.Button();
            this.buttonImpostazioni = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonCancella = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelRotoreS);
            this.groupBox1.Controls.Add(this.button1Down);
            this.groupBox1.Controls.Add(this.labelRotoreR);
            this.groupBox1.Controls.Add(this.labelRotoreM);
            this.groupBox1.Controls.Add(this.button1Up);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2Down);
            this.groupBox1.Controls.Add(this.button3Down);
            this.groupBox1.Controls.Add(this.button3Up);
            this.groupBox1.Controls.Add(this.button2Up);
            this.groupBox1.Location = new System.Drawing.Point(441, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 279);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selezione della chiave di cifratura";
            // 
            // labelRotoreS
            // 
            this.labelRotoreS.AutoSize = true;
            this.labelRotoreS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRotoreS.Location = new System.Drawing.Point(31, 29);
            this.labelRotoreS.Name = "labelRotoreS";
            this.labelRotoreS.Size = new System.Drawing.Size(25, 24);
            this.labelRotoreS.TabIndex = 14;
            this.labelRotoreS.Text = "III";
            this.labelRotoreS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1Down
            // 
            this.button1Down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1Down.BackgroundImage")));
            this.button1Down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1Down.Location = new System.Drawing.Point(156, 166);
            this.button1Down.Name = "button1Down";
            this.button1Down.Size = new System.Drawing.Size(55, 53);
            this.button1Down.TabIndex = 7;
            this.button1Down.UseVisualStyleBackColor = true;
            this.button1Down.Click += new System.EventHandler(this.button1Down_Click);
            // 
            // labelRotoreR
            // 
            this.labelRotoreR.AutoSize = true;
            this.labelRotoreR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRotoreR.Location = new System.Drawing.Point(175, 29);
            this.labelRotoreR.Name = "labelRotoreR";
            this.labelRotoreR.Size = new System.Drawing.Size(15, 24);
            this.labelRotoreR.TabIndex = 12;
            this.labelRotoreR.Text = "I";
            this.labelRotoreR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRotoreM
            // 
            this.labelRotoreM.AutoSize = true;
            this.labelRotoreM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRotoreM.Location = new System.Drawing.Point(104, 29);
            this.labelRotoreM.Name = "labelRotoreM";
            this.labelRotoreM.Size = new System.Drawing.Size(20, 24);
            this.labelRotoreM.TabIndex = 13;
            this.labelRotoreM.Text = "II";
            this.labelRotoreM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1Up
            // 
            this.button1Up.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1Up.BackgroundImage")));
            this.button1Up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1Up.Location = new System.Drawing.Point(158, 63);
            this.button1Up.Name = "button1Up";
            this.button1Up.Size = new System.Drawing.Size(53, 53);
            this.button1Up.TabIndex = 3;
            this.button1Up.UseVisualStyleBackColor = true;
            this.button1Up.Click += new System.EventHandler(this.button1Up_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "A";
            // 
            // button2Down
            // 
            this.button2Down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2Down.BackgroundImage")));
            this.button2Down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2Down.Location = new System.Drawing.Point(88, 166);
            this.button2Down.Name = "button2Down";
            this.button2Down.Size = new System.Drawing.Size(53, 53);
            this.button2Down.TabIndex = 8;
            this.button2Down.UseVisualStyleBackColor = true;
            this.button2Down.Click += new System.EventHandler(this.button2Down_Click);
            // 
            // button3Down
            // 
            this.button3Down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3Down.BackgroundImage")));
            this.button3Down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3Down.Location = new System.Drawing.Point(18, 166);
            this.button3Down.Name = "button3Down";
            this.button3Down.Size = new System.Drawing.Size(53, 53);
            this.button3Down.TabIndex = 6;
            this.button3Down.UseVisualStyleBackColor = true;
            this.button3Down.Click += new System.EventHandler(this.button3Down_Click);
            // 
            // button3Up
            // 
            this.button3Up.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3Up.BackgroundImage")));
            this.button3Up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3Up.Location = new System.Drawing.Point(18, 63);
            this.button3Up.Name = "button3Up";
            this.button3Up.Size = new System.Drawing.Size(53, 53);
            this.button3Up.TabIndex = 5;
            this.button3Up.UseVisualStyleBackColor = true;
            this.button3Up.Click += new System.EventHandler(this.button3Up_Click);
            // 
            // button2Up
            // 
            this.button2Up.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2Up.BackgroundImage")));
            this.button2Up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2Up.Location = new System.Drawing.Point(88, 63);
            this.button2Up.Name = "button2Up";
            this.button2Up.Size = new System.Drawing.Size(53, 53);
            this.button2Up.TabIndex = 4;
            this.button2Up.UseVisualStyleBackColor = true;
            this.button2Up.Click += new System.EventHandler(this.button2Up_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBoxInput);
            this.groupBox2.Location = new System.Drawing.Point(15, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 111);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input dati";
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Location = new System.Drawing.Point(12, 21);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(390, 76);
            this.richTextBoxInput.TabIndex = 0;
            this.richTextBoxInput.Text = "";
            this.richTextBoxInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richTextBoxInput_KeyUp);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBoxOutput);
            this.groupBox3.Location = new System.Drawing.Point(15, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(415, 111);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output dati";
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(12, 19);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.ReadOnly = true;
            this.richTextBoxOutput.Size = new System.Drawing.Size(390, 76);
            this.richTextBoxOutput.TabIndex = 1;
            this.richTextBoxOutput.Text = "";
            // 
            // buttonElabora
            // 
            this.buttonElabora.Image = ((System.Drawing.Image)(resources.GetObject("buttonElabora.Image")));
            this.buttonElabora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonElabora.Location = new System.Drawing.Point(236, 133);
            this.buttonElabora.Name = "buttonElabora";
            this.buttonElabora.Size = new System.Drawing.Size(193, 33);
            this.buttonElabora.TabIndex = 4;
            this.buttonElabora.Text = "Cifra / Decifra";
            this.buttonElabora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonElabora.UseVisualStyleBackColor = true;
            this.buttonElabora.Click += new System.EventHandler(this.buttonElabora_Click);
            // 
            // buttonImpostazioni
            // 
            this.buttonImpostazioni.Image = ((System.Drawing.Image)(resources.GetObject("buttonImpostazioni.Image")));
            this.buttonImpostazioni.Location = new System.Drawing.Point(174, 128);
            this.buttonImpostazioni.Name = "buttonImpostazioni";
            this.buttonImpostazioni.Size = new System.Drawing.Size(56, 43);
            this.buttonImpostazioni.TabIndex = 5;
            this.buttonImpostazioni.UseVisualStyleBackColor = true;
            this.buttonImpostazioni.Click += new System.EventHandler(this.buttonImpostazioni_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo.Image")));
            this.buttonInfo.Location = new System.Drawing.Point(112, 128);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(56, 43);
            this.buttonInfo.TabIndex = 6;
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonCancella
            // 
            this.buttonCancella.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCancella.BackgroundImage")));
            this.buttonCancella.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCancella.Location = new System.Drawing.Point(50, 128);
            this.buttonCancella.Name = "buttonCancella";
            this.buttonCancella.Size = new System.Drawing.Size(56, 43);
            this.buttonCancella.TabIndex = 7;
            this.buttonCancella.UseVisualStyleBackColor = true;
            this.buttonCancella.Click += new System.EventHandler(this.buttonCancella_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 299);
            this.Controls.Add(this.buttonCancella);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonImpostazioni);
            this.Controls.Add(this.buttonElabora);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Simulatore di Enigma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1Up;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.Button button2Down;
        private System.Windows.Forms.Button button1Down;
        private System.Windows.Forms.Button button3Down;
        private System.Windows.Forms.Button button3Up;
        private System.Windows.Forms.Button button2Up;
        private System.Windows.Forms.Button buttonElabora;
        private System.Windows.Forms.Button buttonImpostazioni;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRotoreS;
        private System.Windows.Forms.Label labelRotoreM;
        private System.Windows.Forms.Label labelRotoreR;
        private System.Windows.Forms.Button buttonCancella;
    }
}

