namespace Trabalho
{
    partial class Alterar
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.ComboBox combEstado;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.RadioButton radiobFeminino;
        private System.Windows.Forms.RadioButton radiobMasculino;
        private System.Windows.Forms.RadioButton radiobOutro;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.DateTimePicker dataNasc;
        private System.Windows.Forms.Button btnAlterar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelMatricula = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.combEstado = new System.Windows.Forms.ComboBox();
            this.labelGenero = new System.Windows.Forms.Label();
            this.radiobFeminino = new System.Windows.Forms.RadioButton();
            this.radiobMasculino = new System.Windows.Forms.RadioButton();
            this.radiobOutro = new System.Windows.Forms.RadioButton();
            this.labelData = new System.Windows.Forms.Label();
            this.dataNasc = new System.Windows.Forms.DateTimePicker();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatricula.Location = new System.Drawing.Point(20, 20);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(77, 15);
            this.labelMatricula.TabIndex = 0;
            this.labelMatricula.Text = "Matrícula:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(100, 20);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(200, 20);
            this.txtMatricula.TabIndex = 1;
            this.txtMatricula.TextChanged += new System.EventHandler(this.txtMatricula_TextChanged);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(20, 60);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(42, 15);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(100, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 20);
            this.txtNome.TabIndex = 3;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(20, 100);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(56, 15);
            this.labelEstado.TabIndex = 4;
            this.labelEstado.Text = "Estado:";
            // 
            // combEstado
            // 
            this.combEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combEstado.FormattingEnabled = true;
            this.combEstado.Location = new System.Drawing.Point(100, 100);
            this.combEstado.Name = "combEstado";
            this.combEstado.Size = new System.Drawing.Size(200, 21);
            this.combEstado.TabIndex = 5;
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenero.Location = new System.Drawing.Point(20, 140);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(56, 15);
            this.labelGenero.TabIndex = 6;
            this.labelGenero.Text = "Gênero:";
            // 
            // radiobFeminino
            // 
            this.radiobFeminino.AutoSize = true;
            this.radiobFeminino.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobFeminino.Location = new System.Drawing.Point(83, 140);
            this.radiobFeminino.Name = "radiobFeminino";
            this.radiobFeminino.Size = new System.Drawing.Size(81, 19);
            this.radiobFeminino.TabIndex = 7;
            this.radiobFeminino.TabStop = true;
            this.radiobFeminino.Text = "Feminino";
            this.radiobFeminino.UseVisualStyleBackColor = true;
            // 
            // radiobMasculino
            // 
            this.radiobMasculino.AutoSize = true;
            this.radiobMasculino.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobMasculino.Location = new System.Drawing.Point(170, 140);
            this.radiobMasculino.Name = "radiobMasculino";
            this.radiobMasculino.Size = new System.Drawing.Size(88, 19);
            this.radiobMasculino.TabIndex = 8;
            this.radiobMasculino.TabStop = true;
            this.radiobMasculino.Text = "Masculino";
            this.radiobMasculino.UseVisualStyleBackColor = true;
            // 
            // radiobOutro
            // 
            this.radiobOutro.AutoSize = true;
            this.radiobOutro.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobOutro.Location = new System.Drawing.Point(264, 140);
            this.radiobOutro.Name = "radiobOutro";
            this.radiobOutro.Size = new System.Drawing.Size(60, 19);
            this.radiobOutro.TabIndex = 9;
            this.radiobOutro.TabStop = true;
            this.radiobOutro.Text = "Outro";
            this.radiobOutro.UseVisualStyleBackColor = true;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(12, 180);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(140, 15);
            this.labelData.TabIndex = 10;
            this.labelData.Text = "Data de Nascimento:";
            // 
            // dataNasc
            // 
            this.dataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNasc.Location = new System.Drawing.Point(158, 180);
            this.dataNasc.Name = "dataNasc";
            this.dataNasc.Size = new System.Drawing.Size(160, 20);
            this.dataNasc.TabIndex = 11;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Consolas", 9.25F);
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAlterar.Location = new System.Drawing.Point(114, 228);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 30);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // Alterar
            // 
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(338, 270);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dataNasc);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.radiobOutro);
            this.Controls.Add(this.radiobMasculino);
            this.Controls.Add(this.radiobFeminino);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.combEstado);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.labelMatricula);
            this.Name = "Alterar";
            this.Text = "Alterar Aluno";
            this.Load += new System.EventHandler(this.Alterar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
