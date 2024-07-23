namespace Trabalho
{
    partial class Cadastro
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
            this.dataNasc = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnConsulta1 = new System.Windows.Forms.Button();
            this.combEstado = new System.Windows.Forms.ComboBox();
            this.lbestado = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.GroupBox();
            this.radiobOutro = new System.Windows.Forms.RadioButton();
            this.radiobFeminino = new System.Windows.Forms.RadioButton();
            this.radiobMasculino = new System.Windows.Forms.RadioButton();
            this.labelData = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelRU = new System.Windows.Forms.Label();
            this.txtRU = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.labelGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataNasc
            // 
            this.dataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNasc.Location = new System.Drawing.Point(261, 101);
            this.dataNasc.Name = "dataNasc";
            this.dataNasc.Size = new System.Drawing.Size(121, 22);
            this.dataNasc.TabIndex = 33;
            this.dataNasc.ValueChanged += new System.EventHandler(this.dataNasc_ValueChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.MintCream;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(136, 222);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(84, 45);
            this.btnSalvar.TabIndex = 32;
            this.btnSalvar.Text = "Gravar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.LightGreen;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(239, 222);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(84, 45);
            this.btnLimpar.TabIndex = 31;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnConsulta1
            // 
            this.btnConsulta1.BackColor = System.Drawing.Color.AliceBlue;
            this.btnConsulta1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta1.Location = new System.Drawing.Point(28, 222);
            this.btnConsulta1.Name = "btnConsulta1";
            this.btnConsulta1.Size = new System.Drawing.Size(97, 45);
            this.btnConsulta1.TabIndex = 30;
            this.btnConsulta1.Text = "Consultar";
            this.btnConsulta1.UseVisualStyleBackColor = false;
            this.btnConsulta1.Click += new System.EventHandler(this.btnConsulta1_Click);
            // 
            // combEstado
            // 
            this.combEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combEstado.FormattingEnabled = true;
            this.combEstado.Location = new System.Drawing.Point(253, 160);
            this.combEstado.Name = "combEstado";
            this.combEstado.Size = new System.Drawing.Size(145, 24);
            this.combEstado.TabIndex = 29;
            this.combEstado.Tag = "";
            this.combEstado.SelectedIndexChanged += new System.EventHandler(this.combEstado_SelectedIndexChanged);
            // 
            // lbestado
            // 
            this.lbestado.AutoSize = true;
            this.lbestado.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbestado.Location = new System.Drawing.Point(291, 142);
            this.lbestado.Name = "lbestado";
            this.lbestado.Size = new System.Drawing.Size(56, 18);
            this.lbestado.TabIndex = 28;
            this.lbestado.Text = "Estado";
            this.lbestado.Click += new System.EventHandler(this.labelEstado_Click);
            // 
            // labelGenero
            // 
            this.labelGenero.Controls.Add(this.radiobOutro);
            this.labelGenero.Controls.Add(this.radiobFeminino);
            this.labelGenero.Controls.Add(this.radiobMasculino);
            this.labelGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenero.Location = new System.Drawing.Point(48, 84);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(132, 121);
            this.labelGenero.TabIndex = 27;
            this.labelGenero.TabStop = false;
            this.labelGenero.Text = "Gênero";
            this.labelGenero.Enter += new System.EventHandler(this.labelGenero_Enter);
            // 
            // radiobOutro
            // 
            this.radiobOutro.AutoSize = true;
            this.radiobOutro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobOutro.Location = new System.Drawing.Point(20, 82);
            this.radiobOutro.Name = "radiobOutro";
            this.radiobOutro.Size = new System.Drawing.Size(57, 20);
            this.radiobOutro.TabIndex = 6;
            this.radiobOutro.TabStop = true;
            this.radiobOutro.Text = "Outro";
            this.radiobOutro.UseVisualStyleBackColor = true;
            // 
            // radiobFeminino
            // 
            this.radiobFeminino.AutoSize = true;
            this.radiobFeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobFeminino.Location = new System.Drawing.Point(20, 56);
            this.radiobFeminino.Name = "radiobFeminino";
            this.radiobFeminino.Size = new System.Drawing.Size(80, 20);
            this.radiobFeminino.TabIndex = 5;
            this.radiobFeminino.TabStop = true;
            this.radiobFeminino.Text = "Feminino";
            this.radiobFeminino.UseVisualStyleBackColor = true;
            // 
            // radiobMasculino
            // 
            this.radiobMasculino.AutoSize = true;
            this.radiobMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobMasculino.Location = new System.Drawing.Point(20, 30);
            this.radiobMasculino.Name = "radiobMasculino";
            this.radiobMasculino.Size = new System.Drawing.Size(86, 20);
            this.radiobMasculino.TabIndex = 4;
            this.radiobMasculino.TabStop = true;
            this.radiobMasculino.Text = "Masculino";
            this.radiobMasculino.UseVisualStyleBackColor = true;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(250, 82);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(152, 18);
            this.labelData.TabIndex = 26;
            this.labelData.Text = "Data de Nascimento";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(110, 26);
            this.txtNome.MaxLength = 30;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(272, 20);
            this.txtNome.TabIndex = 25;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(45, 26);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 18);
            this.labelNome.TabIndex = 24;
            this.labelNome.Text = "Nome";
            this.labelNome.Click += new System.EventHandler(this.labelNome_Click);
            // 
            // labelRU
            // 
            this.labelRU.AutoSize = true;
            this.labelRU.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRU.Location = new System.Drawing.Point(55, 55);
            this.labelRU.Name = "labelRU";
            this.labelRU.Size = new System.Drawing.Size(24, 18);
            this.labelRU.TabIndex = 35;
            this.labelRU.Text = "RU";
            // 
            // txtRU
            // 
            this.txtRU.Location = new System.Drawing.Point(110, 55);
            this.txtRU.Name = "txtRU";
            this.txtRU.Size = new System.Drawing.Size(70, 20);
            this.txtRU.TabIndex = 36;
            this.txtRU.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(338, 222);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(88, 46);
            this.btnSair.TabIndex = 37;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(438, 279);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtRU);
            this.Controls.Add(this.labelRU);
            this.Controls.Add(this.dataNasc);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConsulta1);
            this.Controls.Add(this.combEstado);
            this.Controls.Add(this.lbestado);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.labelNome);
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.labelGenero.ResumeLayout(false);
            this.labelGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dataNasc;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnConsulta1;
        private System.Windows.Forms.ComboBox combEstado;
        private System.Windows.Forms.Label lbestado;
        public System.Windows.Forms.GroupBox labelGenero;
        private System.Windows.Forms.RadioButton radiobOutro;
        private System.Windows.Forms.RadioButton radiobFeminino;
        private System.Windows.Forms.RadioButton radiobMasculino;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelRU;
        private System.Windows.Forms.TextBox txtRU;
        private System.Windows.Forms.Button btnSair;
    }
}