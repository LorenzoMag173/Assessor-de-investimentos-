namespace CRUD_Lorenzo_TI20N
{
    partial class CBJ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CBJ));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Entrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(209, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "CBJ Asset Managment";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(309, 187);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(100, 20);
            this.Login.TabIndex = 2;
            this.Login.TextChanged += new System.EventHandler(this.Login_TextChanged);
            // 
            // Senha
            // 
            this.Senha.Location = new System.Drawing.Point(309, 213);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(100, 20);
            this.Senha.TabIndex = 3;
            this.Senha.TextChanged += new System.EventHandler(this.Senha_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(251, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(251, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Senha";
            // 
            // Entrar
            // 
            this.Entrar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Entrar.Location = new System.Drawing.Point(319, 253);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(75, 23);
            this.Entrar.TabIndex = 6;
            this.Entrar.Text = "Entrar";
            this.Entrar.UseVisualStyleBackColor = false;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // CBJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CRUD_Lorenzo_TI20N.Properties.Resources.pngtree_business_finance_abstract_dollar_symbol_stock_market_symbol_background_image_906537;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CBJ";
            this.Text = "CBJ Investimentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Entrar;
    }
}

