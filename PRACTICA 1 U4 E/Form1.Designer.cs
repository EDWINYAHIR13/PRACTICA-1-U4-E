namespace PRACTICA_1_U4_E
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            groupBox3 = new GroupBox();
            button4 = new Button();
            textBox3 = new TextBox();
            label5 = new Label();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            label4 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 148);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese los datos";
            // 
            // button1
            // 
            button1.Location = new Point(468, 55);
            button1.Name = "button1";
            button1.Size = new Size(164, 45);
            button1.TabIndex = 4;
            button1.Text = "Abrir Cuenta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(158, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(259, 30);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 30);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 99);
            label2.Name = "label2";
            label2.Size = new Size(70, 24);
            label2.TabIndex = 1;
            label2.Text = "Monto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 40);
            label1.Name = "label1";
            label1.Size = new Size(75, 24);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 168);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 97);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Transacciones";
            // 
            // button3
            // 
            button3.Location = new Point(448, 35);
            button3.Name = "button3";
            button3.Size = new Size(220, 53);
            button3.TabIndex = 1;
            button3.Text = "Retiro";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(104, 35);
            button2.Name = "button2";
            button2.Size = new Size(220, 53);
            button2.TabIndex = 0;
            button2.Text = "Deposito";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(listBox2);
            groupBox3.Controls.Add(listBox1);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(12, 271);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(776, 270);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Historial";
            // 
            // button4
            // 
            button4.Location = new Point(592, 174);
            button4.Name = "button4";
            button4.Size = new Size(119, 39);
            button4.TabIndex = 6;
            button4.Text = "Nuevo";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(592, 116);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(156, 30);
            textBox3.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(592, 81);
            label5.Name = "label5";
            label5.Size = new Size(63, 24);
            label5.TabIndex = 4;
            label5.Text = "Saldo";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 24;
            listBox2.Location = new Point(345, 57);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(150, 196);
            listBox2.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 24;
            listBox1.Location = new Point(78, 57);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 196);
            listBox1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(377, 26);
            label4.Name = "label4";
            label4.Size = new Size(78, 24);
            label4.TabIndex = 1;
            label4.Text = "Retiros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 26);
            label3.Name = "label3";
            label3.Size = new Size(105, 24);
            label3.TabIndex = 0;
            label3.Text = "Depositos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 553);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button button2;
        private Label label3;
        private Button button4;
        private TextBox textBox3;
        private Label label5;
        private ListBox listBox2;
        private ListBox listBox1;
        private Label label4;
    }
}