namespace ExemploPOO
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.pnPessoa = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbProfessor = new System.Windows.Forms.RadioButton();
            this.rbAluno = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pnAluno = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnProfessor = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtRP = new System.Windows.Forms.TextBox();
            this.TxtFormacao = new System.Windows.Forms.TextBox();
            this.pnPessoa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnAluno.SuspendLayout();
            this.pnProfessor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(97, 410);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(104, 76);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(104, 124);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(100, 23);
            this.txtRG.TabIndex = 3;
            // 
            // pnPessoa
            // 
            this.pnPessoa.Controls.Add(this.groupBox1);
            this.pnPessoa.Controls.Add(this.label6);
            this.pnPessoa.Controls.Add(this.label5);
            this.pnPessoa.Controls.Add(this.label4);
            this.pnPessoa.Controls.Add(this.label3);
            this.pnPessoa.Controls.Add(this.label2);
            this.pnPessoa.Controls.Add(this.txtCPF);
            this.pnPessoa.Controls.Add(this.txtEmail);
            this.pnPessoa.Controls.Add(this.txtNome);
            this.pnPessoa.Controls.Add(this.txtRG);
            this.pnPessoa.Controls.Add(this.btnEnviar);
            this.pnPessoa.Location = new System.Drawing.Point(12, 12);
            this.pnPessoa.Name = "pnPessoa";
            this.pnPessoa.Size = new System.Drawing.Size(270, 446);
            this.pnPessoa.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbProfessor);
            this.groupBox1.Controls.Add(this.rbAluno);
            this.groupBox1.Location = new System.Drawing.Point(41, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 131);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Pessoa";
            // 
            // rbProfessor
            // 
            this.rbProfessor.AutoSize = true;
            this.rbProfessor.Location = new System.Drawing.Point(23, 47);
            this.rbProfessor.Name = "rbProfessor";
            this.rbProfessor.Size = new System.Drawing.Size(74, 19);
            this.rbProfessor.TabIndex = 1;
            this.rbProfessor.TabStop = true;
            this.rbProfessor.Text = "Professor";
            this.rbProfessor.UseVisualStyleBackColor = true;
            this.rbProfessor.CheckedChanged += new System.EventHandler(this.rbProfessor_CheckedChanged);
            // 
            // rbAluno
            // 
            this.rbAluno.AutoSize = true;
            this.rbAluno.Location = new System.Drawing.Point(23, 22);
            this.rbAluno.Name = "rbAluno";
            this.rbAluno.Size = new System.Drawing.Size(57, 19);
            this.rbAluno.TabIndex = 0;
            this.rbAluno.TabStop = true;
            this.rbAluno.Text = "Aluno";
            this.rbAluno.UseVisualStyleBackColor = true;
            this.rbAluno.CheckedChanged += new System.EventHandler(this.rbAluno_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(75, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 37);
            this.label6.TabIndex = 7;
            this.label6.Text = "Pessoa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "e-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "cpf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "rg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(104, 169);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 23);
            this.txtCPF.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(104, 217);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 23);
            this.txtEmail.TabIndex = 5;
            // 
            // pnAluno
            // 
            this.pnAluno.Controls.Add(this.label9);
            this.pnAluno.Controls.Add(this.label10);
            this.pnAluno.Controls.Add(this.txtRA);
            this.pnAluno.Controls.Add(this.txtCurso);
            this.pnAluno.Controls.Add(this.label7);
            this.pnAluno.Location = new System.Drawing.Point(288, 12);
            this.pnAluno.Name = "pnAluno";
            this.pnAluno.Size = new System.Drawing.Size(248, 393);
            this.pnAluno.TabIndex = 5;
            this.pnAluno.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Curso";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "RA";
            // 
            // txtRA
            // 
            this.txtRA.Location = new System.Drawing.Point(91, 70);
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(100, 23);
            this.txtRA.TabIndex = 9;
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(91, 118);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(100, 23);
            this.txtCurso.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(55, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 37);
            this.label7.TabIndex = 8;
            this.label7.Text = "Aluno";
            // 
            // pnProfessor
            // 
            this.pnProfessor.Controls.Add(this.label11);
            this.pnProfessor.Controls.Add(this.label8);
            this.pnProfessor.Controls.Add(this.label12);
            this.pnProfessor.Controls.Add(this.TxtRP);
            this.pnProfessor.Controls.Add(this.TxtFormacao);
            this.pnProfessor.Location = new System.Drawing.Point(542, 12);
            this.pnProfessor.Name = "pnProfessor";
            this.pnProfessor.Size = new System.Drawing.Size(246, 393);
            this.pnProfessor.TabIndex = 6;
            this.pnProfessor.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "Formação";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(67, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 37);
            this.label8.TabIndex = 8;
            this.label8.Text = "Professor";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(67, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "RP";
            // 
            // TxtRP
            // 
            this.TxtRP.Location = new System.Drawing.Point(107, 75);
            this.TxtRP.Name = "TxtRP";
            this.TxtRP.Size = new System.Drawing.Size(100, 23);
            this.TxtRP.TabIndex = 8;
            // 
            // TxtFormacao
            // 
            this.TxtFormacao.Location = new System.Drawing.Point(107, 123);
            this.TxtFormacao.Name = "TxtFormacao";
            this.TxtFormacao.Size = new System.Drawing.Size(100, 23);
            this.TxtFormacao.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 499);
            this.Controls.Add(this.pnProfessor);
            this.Controls.Add(this.pnAluno);
            this.Controls.Add(this.pnPessoa);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExemploPOO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnPessoa.ResumeLayout(false);
            this.pnPessoa.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnAluno.ResumeLayout(false);
            this.pnAluno.PerformLayout();
            this.pnProfessor.ResumeLayout(false);
            this.pnProfessor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEnviar;
        private TextBox txtNome;
        private Label label1;
        private TextBox txtRG;
        private Panel pnPessoa;
        private TextBox txtCPF;
        private TextBox txtEmail;
        private Panel pnAluno;
        private Panel pnProfessor;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox groupBox1;
        private RadioButton rbProfessor;
        private RadioButton rbAluno;
        private Label label9;
        private Label label10;
        private TextBox txtRA;
        private TextBox txtCurso;
        private Label label11;
        private Label label12;
        private TextBox TxtRP;
        private TextBox TxtFormacao;
    }
}