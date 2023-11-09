namespace PızzaApp
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
            label1 = new Label();
            checkZeytin = new CheckBox();
            checkMısır = new CheckBox();
            checkJanbon = new CheckBox();
            checkSosis = new CheckBox();
            Malzemeler = new GroupBox();
            radioNormalHamur = new RadioButton();
            radioKalınHamur = new RadioButton();
            radioİnceHamur = new RadioButton();
            groupBox2 = new GroupBox();
            button1 = new Button();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            radioAcıSos = new RadioButton();
            radioSarımsakSos = new RadioButton();
            radioBarbekuSos = new RadioButton();
            Malzemeler.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Lavender;
            label1.Location = new Point(9, 30);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(787, 32);
            label1.TabIndex = 0;
            label1.Text = "Onlarca farklı seçenel arasında damak tadına uygun pizzayı yarat !";
            label1.Click += label1_Click;
            // 
            // checkZeytin
            // 
            checkZeytin.AutoSize = true;
            checkZeytin.Location = new Point(6, 40);
            checkZeytin.Name = "checkZeytin";
            checkZeytin.Size = new Size(110, 24);
            checkZeytin.TabIndex = 1;
            checkZeytin.Text = "Zeytin ( 15 )";
            checkZeytin.UseVisualStyleBackColor = true;
            // 
            // checkMısır
            // 
            checkMısır.AutoSize = true;
            checkMısır.Location = new Point(6, 70);
            checkMısır.Name = "checkMısır";
            checkMısır.Size = new Size(101, 24);
            checkMısır.TabIndex = 2;
            checkMısır.Text = "Mısır ( 10 )";
            checkMısır.UseVisualStyleBackColor = true;
            // 
            // checkJanbon
            // 
            checkJanbon.AutoSize = true;
            checkJanbon.Location = new Point(6, 130);
            checkJanbon.Name = "checkJanbon";
            checkJanbon.Size = new Size(121, 24);
            checkJanbon.TabIndex = 3;
            checkJanbon.Text = "Jambon ( 18 )";
            checkJanbon.UseVisualStyleBackColor = true;
            // 
            // checkSosis
            // 
            checkSosis.AutoSize = true;
            checkSosis.Location = new Point(6, 100);
            checkSosis.Name = "checkSosis";
            checkSosis.Size = new Size(102, 24);
            checkSosis.TabIndex = 4;
            checkSosis.Text = "Sosis ( 25 )";
            checkSosis.UseVisualStyleBackColor = true;
            // 
            // Malzemeler
            // 
            Malzemeler.Controls.Add(checkZeytin);
            Malzemeler.Controls.Add(checkJanbon);
            Malzemeler.Controls.Add(checkSosis);
            Malzemeler.Controls.Add(checkMısır);
            Malzemeler.Location = new Point(41, 112);
            Malzemeler.Name = "Malzemeler";
            Malzemeler.Size = new Size(250, 168);
            Malzemeler.TabIndex = 5;
            Malzemeler.TabStop = false;
            Malzemeler.Text = "Malzemeler";
            // 
            // radioNormalHamur
            // 
            radioNormalHamur.AutoSize = true;
            radioNormalHamur.Location = new Point(6, 40);
            radioNormalHamur.Name = "radioNormalHamur";
            radioNormalHamur.Size = new Size(129, 24);
            radioNormalHamur.TabIndex = 6;
            radioNormalHamur.TabStop = true;
            radioNormalHamur.Text = "Normal Hamur";
            radioNormalHamur.UseVisualStyleBackColor = true;
            radioNormalHamur.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioKalınHamur
            // 
            radioKalınHamur.AutoSize = true;
            radioKalınHamur.Location = new Point(6, 100);
            radioKalınHamur.Name = "radioKalınHamur";
            radioKalınHamur.Size = new Size(150, 24);
            radioKalınHamur.TabIndex = 7;
            radioKalınHamur.TabStop = true;
            radioKalınHamur.Text = "Kalın Hamur ( 10 )";
            radioKalınHamur.UseVisualStyleBackColor = true;
            // 
            // radioİnceHamur
            // 
            radioİnceHamur.AutoSize = true;
            radioİnceHamur.Location = new Point(6, 70);
            radioİnceHamur.Name = "radioİnceHamur";
            radioİnceHamur.Size = new Size(107, 24);
            radioİnceHamur.TabIndex = 8;
            radioİnceHamur.TabStop = true;
            radioİnceHamur.Text = "İnce hamur ";
            radioİnceHamur.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioNormalHamur);
            groupBox2.Controls.Add(radioKalınHamur);
            groupBox2.Controls.Add(radioİnceHamur);
            groupBox2.Location = new Point(313, 123);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 129);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hamur Çeşitleri";
            // 
            // button1
            // 
            button1.Location = new Point(92, 322);
            button1.Name = "button1";
            button1.Size = new Size(119, 29);
            button1.TabIndex = 10;
            button1.Text = "Fiyat Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(287, 322);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioAcıSos);
            groupBox1.Controls.Add(radioSarımsakSos);
            groupBox1.Controls.Add(radioBarbekuSos);
            groupBox1.Location = new Point(593, 123);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 129);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sos Çeşitleri";
            // 
            // radioAcıSos
            // 
            radioAcıSos.AutoSize = true;
            radioAcıSos.Location = new Point(6, 40);
            radioAcıSos.Name = "radioAcıSos";
            radioAcıSos.Size = new Size(78, 24);
            radioAcıSos.TabIndex = 6;
            radioAcıSos.TabStop = true;
            radioAcıSos.Text = "Acı Sos";
            radioAcıSos.UseVisualStyleBackColor = true;
            // 
            // radioSarımsakSos
            // 
            radioSarımsakSos.AutoSize = true;
            radioSarımsakSos.Location = new Point(6, 100);
            radioSarımsakSos.Name = "radioSarımsakSos";
            radioSarımsakSos.Size = new Size(152, 24);
            radioSarımsakSos.TabIndex = 7;
            radioSarımsakSos.TabStop = true;
            radioSarımsakSos.Text = "Sarımsaklı sos (15)";
            radioSarımsakSos.UseVisualStyleBackColor = true;
            // 
            // radioBarbekuSos
            // 
            radioBarbekuSos.AutoSize = true;
            radioBarbekuSos.Location = new Point(6, 70);
            radioBarbekuSos.Name = "radioBarbekuSos";
            radioBarbekuSos.Size = new Size(146, 24);
            radioBarbekuSos.TabIndex = 8;
            radioBarbekuSos.TabStop = true;
            radioBarbekuSos.Text = "Barberkü Sos (25)";
            radioBarbekuSos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(877, 506);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(Malzemeler);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Pizza Restorant";
            Malzemeler.ResumeLayout(false);
            Malzemeler.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox checkZeytin;
        private CheckBox checkMısır;
        private CheckBox checkJanbon;
        private CheckBox checkSosis;
        private GroupBox Malzemeler;
        private RadioButton radioNormalHamur;
        private RadioButton radioKalınHamur;
        private RadioButton radioİnceHamur;
        private GroupBox groupBox2;
        private Button button1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private RadioButton radioAcıSos;
        private RadioButton radioSarımsakSos;
        private RadioButton radioBarbekuSos;
    }
}