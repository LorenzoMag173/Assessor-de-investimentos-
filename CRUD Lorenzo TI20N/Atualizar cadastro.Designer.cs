namespace CRUD_Lorenzo_TI20N
{
    partial class Atualizar_cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Atualizar_cadastro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCPF1 = new System.Windows.Forms.TextBox();
            this.textLogin2 = new System.Windows.Forms.TextBox();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSenha3 = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Atualizar dados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Login";
            // 
            // textBoxCPF1
            // 
            this.textBoxCPF1.Location = new System.Drawing.Point(346, 187);
            this.textBoxCPF1.Name = "textBoxCPF1";
            this.textBoxCPF1.Size = new System.Drawing.Size(100, 20);
            this.textBoxCPF1.TabIndex = 3;
            this.textBoxCPF1.TextChanged += new System.EventHandler(this.textBoxCPF1_TextChanged);
            // 
            // textLogin2
            // 
            this.textLogin2.Location = new System.Drawing.Point(346, 213);
            this.textLogin2.Name = "textLogin2";
            this.textLogin2.Size = new System.Drawing.Size(100, 20);
            this.textLogin2.TabIndex = 4;
            this.textLogin2.TextChanged += new System.EventHandler(this.textLogin2_TextChanged);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(322, 279);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonAtualizar.TabIndex = 5;
            this.buttonAtualizar.Text = "Atualizar ";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Senha";
            // 
            // textBoxSenha3
            // 
            this.textBoxSenha3.Location = new System.Drawing.Point(346, 239);
            this.textBoxSenha3.Name = "textBoxSenha3";
            this.textBoxSenha3.Size = new System.Drawing.Size(100, 20);
            this.textBoxSenha3.TabIndex = 7;
            this.textBoxSenha3.TextChanged += new System.EventHandler(this.textBoxSenha3_TextChanged);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(403, 279);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // Atualizar_cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CRUD_Lorenzo_TI20N.Properties.Resources.ed82529805250b004815da6debb668511;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.textBoxSenha3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.textLogin2);
            this.Controls.Add(this.textBoxCPF1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Atualizar_cadastro";
            this.Text = "Atualizar Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCPF1;
        private System.Windows.Forms.TextBox textLogin2;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSenha3;
        private System.Windows.Forms.Button buttonCancelar;
    }
}