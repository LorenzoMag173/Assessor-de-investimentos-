namespace CRUD_Lorenzo_TI20N
{
    partial class Excluir1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Excluir1));
            this.label1 = new System.Windows.Forms.Label();
            this.textboxExcluir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.botaoExcluir = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Excluir dado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textboxExcluir
            // 
            this.textboxExcluir.Location = new System.Drawing.Point(347, 211);
            this.textboxExcluir.Name = "textboxExcluir";
            this.textboxExcluir.Size = new System.Drawing.Size(100, 20);
            this.textboxExcluir.TabIndex = 1;
            this.textboxExcluir.TextChanged += new System.EventHandler(this.textboxExcluir_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF";
            // 
            // botaoExcluir
            // 
            this.botaoExcluir.Location = new System.Drawing.Point(309, 249);
            this.botaoExcluir.Name = "botaoExcluir";
            this.botaoExcluir.Size = new System.Drawing.Size(75, 23);
            this.botaoExcluir.TabIndex = 3;
            this.botaoExcluir.Text = "Excluir";
            this.botaoExcluir.UseVisualStyleBackColor = true;
            this.botaoExcluir.Click += new System.EventHandler(this.botaoExcluir_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(390, 249);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Excluir1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CRUD_Lorenzo_TI20N.Properties.Resources._3d_rendering_abstract_wall_wave_architecture_blue_luxury_background_41204_15851;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.botaoExcluir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxExcluir);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Excluir1";
            this.Text = "Excluir Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxExcluir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botaoExcluir;
        private System.Windows.Forms.Button buttonCancelar;
    }
}