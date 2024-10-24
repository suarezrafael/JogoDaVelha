namespace JogoDaVelha
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
            btnIniciar = new Button();
            btnO = new Button();
            btnX = new Button();
            lblJogadorO = new Label();
            lblJogadorX = new Label();
            groupBox2 = new GroupBox();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnIniciar);
            groupBox1.Controls.Add(btnO);
            groupBox1.Controls.Add(btnX);
            groupBox1.Controls.Add(lblJogadorO);
            groupBox1.Controls.Add(lblJogadorX);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(0, 192, 192);
            btnIniciar.Enabled = false;
            btnIniciar.Font = new Font("Rockwell Extra Bold", 48F);
            btnIniciar.Location = new Point(6, 213);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(336, 118);
            btnIniciar.TabIndex = 12;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnO
            // 
            btnO.BackColor = Color.FromArgb(255, 128, 128);
            btnO.Font = new Font("Rockwell Extra Bold", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnO.Location = new Point(177, 22);
            btnO.Name = "btnO";
            btnO.Size = new Size(165, 136);
            btnO.TabIndex = 11;
            btnO.Text = "O";
            btnO.UseVisualStyleBackColor = false;
            btnO.Click += btnO_Click;
            // 
            // btnX
            // 
            btnX.BackColor = Color.Lime;
            btnX.Font = new Font("Rockwell Extra Bold", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnX.Location = new Point(6, 22);
            btnX.Name = "btnX";
            btnX.Size = new Size(165, 136);
            btnX.TabIndex = 10;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = false;
            btnX.Click += btnX_Click;
            // 
            // lblJogadorO
            // 
            lblJogadorO.AutoSize = true;
            lblJogadorO.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblJogadorO.Location = new Point(216, 161);
            lblJogadorO.Name = "lblJogadorO";
            lblJogadorO.Size = new Size(51, 25);
            lblJogadorO.TabIndex = 3;
            lblJogadorO.Text = ">>>";
            // 
            // lblJogadorX
            // 
            lblJogadorX.AutoSize = true;
            lblJogadorX.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblJogadorX.Location = new Point(60, 161);
            lblJogadorX.Name = "lblJogadorX";
            lblJogadorX.Size = new Size(51, 25);
            lblJogadorX.TabIndex = 2;
            lblJogadorX.Text = "<<<";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn9);
            groupBox2.Controls.Add(btn8);
            groupBox2.Controls.Add(btn7);
            groupBox2.Controls.Add(btn6);
            groupBox2.Controls.Add(btn5);
            groupBox2.Controls.Add(btn4);
            groupBox2.Controls.Add(btn3);
            groupBox2.Controls.Add(btn2);
            groupBox2.Controls.Add(btn1);
            groupBox2.Location = new Point(396, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(556, 475);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // btn9
            // 
            btn9.Font = new Font("Rockwell Extra Bold", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.Location = new Point(378, 317);
            btn9.Name = "btn9";
            btn9.Size = new Size(165, 136);
            btn9.TabIndex = 9;
            btn9.Text = "X";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Rockwell Extra Bold", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.Location = new Point(197, 317);
            btn8.Name = "btn8";
            btn8.Size = new Size(165, 136);
            btn8.TabIndex = 8;
            btn8.Text = "O";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Rockwell Extra Bold", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.Location = new Point(18, 317);
            btn7.Name = "btn7";
            btn7.Size = new Size(165, 136);
            btn7.TabIndex = 7;
            btn7.Text = "X";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Rockwell Extra Bold", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.Location = new Point(376, 169);
            btn6.Name = "btn6";
            btn6.Size = new Size(165, 136);
            btn6.TabIndex = 6;
            btn6.Text = "O";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Rockwell Extra Bold", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.Location = new Point(195, 169);
            btn5.Name = "btn5";
            btn5.Size = new Size(165, 136);
            btn5.TabIndex = 5;
            btn5.Text = "X";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Rockwell Extra Bold", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.Location = new Point(16, 169);
            btn4.Name = "btn4";
            btn4.Size = new Size(165, 136);
            btn4.TabIndex = 4;
            btn4.Text = "O";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Rockwell Extra Bold", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.Location = new Point(378, 22);
            btn3.Name = "btn3";
            btn3.Size = new Size(165, 136);
            btn3.TabIndex = 3;
            btn3.Text = "X";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.White;
            btn2.Font = new Font("Rockwell Extra Bold", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.Location = new Point(197, 22);
            btn2.Name = "btn2";
            btn2.Size = new Size(165, 136);
            btn2.TabIndex = 2;
            btn2.Text = "O";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Rockwell Extra Bold", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(18, 22);
            btn1.Name = "btn1";
            btn1.Size = new Size(165, 136);
            btn1.TabIndex = 1;
            btn1.Text = "X";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(975, 502);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblJogadorO;
        private Label lblJogadorX;
        private GroupBox groupBox2;
        private Button btn1;
        private Button btn3;
        private Button btn2;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnIniciar;
        private Button btnO;
        private Button btnX;
    }
}
