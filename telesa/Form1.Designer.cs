namespace telesa
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
            button1 = new Button();
            rbKrychle = new RadioButton();
            listBox1 = new ListBox();
            numericUpDown1 = new NumericUpDown();
            rbKoule = new RadioButton();
            rbDvanactisten = new RadioButton();
            rbDvacetisten = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(540, 37);
            button1.Name = "button1";
            button1.Size = new Size(175, 138);
            button1.TabIndex = 0;
            button1.Text = "Generuj!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // rbKrychle
            // 
            rbKrychle.AutoSize = true;
            rbKrychle.Location = new Point(12, 81);
            rbKrychle.Name = "rbKrychle";
            rbKrychle.Size = new Size(64, 19);
            rbKrychle.TabIndex = 1;
            rbKrychle.TabStop = true;
            rbKrychle.Text = "Krychle";
            rbKrychle.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(138, 37);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(396, 139);
            listBox1.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 37);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 3;
            // 
            // rbKoule
            // 
            rbKoule.AutoSize = true;
            rbKoule.Location = new Point(12, 106);
            rbKoule.Name = "rbKoule";
            rbKoule.Size = new Size(55, 19);
            rbKoule.TabIndex = 4;
            rbKoule.TabStop = true;
            rbKoule.Text = "Koule";
            rbKoule.UseVisualStyleBackColor = true;
            // 
            // rbDvanactisten
            // 
            rbDvanactisten.AutoSize = true;
            rbDvanactisten.Location = new Point(12, 131);
            rbDvanactisten.Name = "rbDvanactisten";
            rbDvanactisten.Size = new Size(93, 19);
            rbDvanactisten.TabIndex = 5;
            rbDvanactisten.TabStop = true;
            rbDvanactisten.Text = "Dvanáctistěn";
            rbDvanactisten.UseVisualStyleBackColor = true;
            // 
            // rbDvacetisten
            // 
            rbDvacetisten.AutoSize = true;
            rbDvacetisten.Location = new Point(12, 156);
            rbDvacetisten.Name = "rbDvacetisten";
            rbDvacetisten.Size = new Size(86, 19);
            rbDvacetisten.TabIndex = 6;
            rbDvacetisten.TabStop = true;
            rbDvacetisten.Text = "Dvacetisten";
            rbDvacetisten.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 7;
            label1.Text = "Délka strany";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 8;
            label2.Text = "Tvar telesa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 19);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 9;
            label3.Text = "Výstup";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 194);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rbDvacetisten);
            Controls.Add(rbDvanactisten);
            Controls.Add(rbKoule);
            Controls.Add(numericUpDown1);
            Controls.Add(listBox1);
            Controls.Add(rbKrychle);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RadioButton rbKrychle;
        private ListBox listBox1;
        private NumericUpDown numericUpDown1;
        private RadioButton rbKoule;
        private RadioButton rbDvanactisten;
        private RadioButton rbDvacetisten;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
