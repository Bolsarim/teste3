namespace teste2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_senha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_telefone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_endereco = new System.Windows.Forms.TextBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(99, 49);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(245, 26);
            this.textBox_nome.TabIndex = 0;
            this.textBox_nome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-mail:";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(99, 81);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(245, 26);
            this.textBox_email.TabIndex = 3;
            this.textBox_email.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha:";
            // 
            // textBox_senha
            // 
            this.textBox_senha.Location = new System.Drawing.Point(99, 114);
            this.textBox_senha.Name = "textBox_senha";
            this.textBox_senha.Size = new System.Drawing.Size(245, 26);
            this.textBox_senha.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefone:";
            // 
            // textBox_telefone
            // 
            this.textBox_telefone.Location = new System.Drawing.Point(99, 146);
            this.textBox_telefone.Name = "textBox_telefone";
            this.textBox_telefone.Size = new System.Drawing.Size(245, 26);
            this.textBox_telefone.TabIndex = 7;
            this.textBox_telefone.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Endereço:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox_endereco
            // 
            this.textBox_endereco.Location = new System.Drawing.Point(99, 178);
            this.textBox_endereco.Name = "textBox_endereco";
            this.textBox_endereco.Size = new System.Drawing.Size(245, 26);
            this.textBox_endereco.TabIndex = 9;
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_enviar.Location = new System.Drawing.Point(99, 210);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(85, 32);
            this.btn_enviar.TabIndex = 10;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.textBox_endereco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_telefone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_senha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_senha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_telefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_endereco;
        private System.Windows.Forms.Button btn_enviar;
    }
}

