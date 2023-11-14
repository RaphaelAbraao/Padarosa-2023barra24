namespace Padarosa_2023barra24.Views
{
    partial class dgvGerenciamentoUsuarios
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
            this.dGVUsuarios = new System.Windows.Forms.DataGridView();
            this.Cadastro = new System.Windows.Forms.GroupBox();
            this.gBEditar = new System.Windows.Forms.GroupBox();
            this.lblCadNomeCompleto = new System.Windows.Forms.Label();
            this.lblCadEmail = new System.Windows.Forms.Label();
            this.lblCadSenha = new System.Windows.Forms.Label();
            this.lblEdiSenha = new System.Windows.Forms.Label();
            this.lblEdiEmail = new System.Windows.Forms.Label();
            this.lblEdiNomeCompleto = new System.Windows.Forms.Label();
            this.gBApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbCadNome = new System.Windows.Forms.TextBox();
            this.txbCadEmail = new System.Windows.Forms.TextBox();
            this.txbCadSenha = new System.Windows.Forms.TextBox();
            this.txbEdiNome = new System.Windows.Forms.TextBox();
            this.txbEdiEmail = new System.Windows.Forms.TextBox();
            this.txbEdiSenha = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUsuarios)).BeginInit();
            this.Cadastro.SuspendLayout();
            this.gBEditar.SuspendLayout();
            this.gBApagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVUsuarios
            // 
            this.dGVUsuarios.AllowUserToAddRows = false;
            this.dGVUsuarios.AllowUserToDeleteRows = false;
            this.dGVUsuarios.AllowUserToResizeColumns = false;
            this.dGVUsuarios.AllowUserToResizeRows = false;
            this.dGVUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVUsuarios.Location = new System.Drawing.Point(12, 12);
            this.dGVUsuarios.Name = "dGVUsuarios";
            this.dGVUsuarios.ReadOnly = true;
            this.dGVUsuarios.Size = new System.Drawing.Size(462, 304);
            this.dGVUsuarios.TabIndex = 0;
            // 
            // Cadastro
            // 
            this.Cadastro.Controls.Add(this.btnEditar);
            this.Cadastro.Controls.Add(this.txbEdiSenha);
            this.Cadastro.Controls.Add(this.txbEdiEmail);
            this.Cadastro.Controls.Add(this.txbEdiNome);
            this.Cadastro.Controls.Add(this.lblCadSenha);
            this.Cadastro.Controls.Add(this.lblCadEmail);
            this.Cadastro.Controls.Add(this.lblCadNomeCompleto);
            this.Cadastro.Enabled = false;
            this.Cadastro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cadastro.Location = new System.Drawing.Point(480, 235);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(200, 203);
            this.Cadastro.TabIndex = 1;
            this.Cadastro.TabStop = false;
            this.Cadastro.Text = "Editar";
            this.Cadastro.Enter += new System.EventHandler(this.Cadastro_Enter);
            // 
            // gBEditar
            // 
            this.gBEditar.Controls.Add(this.btnCadastrar);
            this.gBEditar.Controls.Add(this.txbCadSenha);
            this.gBEditar.Controls.Add(this.txbCadEmail);
            this.gBEditar.Controls.Add(this.txbCadNome);
            this.gBEditar.Controls.Add(this.lblEdiSenha);
            this.gBEditar.Controls.Add(this.lblEdiEmail);
            this.gBEditar.Controls.Add(this.lblEdiNomeCompleto);
            this.gBEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gBEditar.Location = new System.Drawing.Point(480, 12);
            this.gBEditar.Name = "gBEditar";
            this.gBEditar.Size = new System.Drawing.Size(200, 203);
            this.gBEditar.TabIndex = 2;
            this.gBEditar.TabStop = false;
            this.gBEditar.Text = "Cadastrar";
            // 
            // lblCadNomeCompleto
            // 
            this.lblCadNomeCompleto.AutoSize = true;
            this.lblCadNomeCompleto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCadNomeCompleto.Location = new System.Drawing.Point(-2, 36);
            this.lblCadNomeCompleto.Name = "lblCadNomeCompleto";
            this.lblCadNomeCompleto.Size = new System.Drawing.Size(85, 13);
            this.lblCadNomeCompleto.TabIndex = 0;
            this.lblCadNomeCompleto.Text = "Nome Completo:";
            this.lblCadNomeCompleto.Click += new System.EventHandler(this.lblCadNomeCompleto_Click);
            // 
            // lblCadEmail
            // 
            this.lblCadEmail.AutoSize = true;
            this.lblCadEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCadEmail.Location = new System.Drawing.Point(23, 79);
            this.lblCadEmail.Name = "lblCadEmail";
            this.lblCadEmail.Size = new System.Drawing.Size(35, 13);
            this.lblCadEmail.TabIndex = 1;
            this.lblCadEmail.Text = "Email:";
            // 
            // lblCadSenha
            // 
            this.lblCadSenha.AutoSize = true;
            this.lblCadSenha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCadSenha.Location = new System.Drawing.Point(5, 125);
            this.lblCadSenha.Name = "lblCadSenha";
            this.lblCadSenha.Size = new System.Drawing.Size(68, 13);
            this.lblCadSenha.TabIndex = 2;
            this.lblCadSenha.Text = "Nova senha:";
            // 
            // lblEdiSenha
            // 
            this.lblEdiSenha.AutoSize = true;
            this.lblEdiSenha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEdiSenha.Location = new System.Drawing.Point(23, 112);
            this.lblEdiSenha.Name = "lblEdiSenha";
            this.lblEdiSenha.Size = new System.Drawing.Size(41, 13);
            this.lblEdiSenha.TabIndex = 5;
            this.lblEdiSenha.Text = "Senha:";
            this.lblEdiSenha.Click += new System.EventHandler(this.lblEdiSenha_Click);
            // 
            // lblEdiEmail
            // 
            this.lblEdiEmail.AutoSize = true;
            this.lblEdiEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEdiEmail.Location = new System.Drawing.Point(23, 71);
            this.lblEdiEmail.Name = "lblEdiEmail";
            this.lblEdiEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEdiEmail.TabIndex = 4;
            this.lblEdiEmail.Text = "Email:";
            // 
            // lblEdiNomeCompleto
            // 
            this.lblEdiNomeCompleto.AutoSize = true;
            this.lblEdiNomeCompleto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEdiNomeCompleto.Location = new System.Drawing.Point(1, 31);
            this.lblEdiNomeCompleto.Name = "lblEdiNomeCompleto";
            this.lblEdiNomeCompleto.Size = new System.Drawing.Size(85, 13);
            this.lblEdiNomeCompleto.TabIndex = 3;
            this.lblEdiNomeCompleto.Text = "Nome Completo:";
            // 
            // gBApagar
            // 
            this.gBApagar.Controls.Add(this.label1);
            this.gBApagar.Controls.Add(this.btnApagar);
            this.gBApagar.Enabled = false;
            this.gBApagar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gBApagar.Location = new System.Drawing.Point(12, 338);
            this.gBApagar.Name = "gBApagar";
            this.gBApagar.Size = new System.Drawing.Size(462, 100);
            this.gBApagar.TabIndex = 3;
            this.gBApagar.TabStop = false;
            this.gBApagar.Text = "Apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagar.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.Color.Red;
            this.btnApagar.Location = new System.Drawing.Point(6, 65);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(450, 29);
            this.btnApagar.TabIndex = 0;
            this.btnApagar.Text = "APAGAR";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione um usuário para apagar:";
            // 
            // txbCadNome
            // 
            this.txbCadNome.Location = new System.Drawing.Point(89, 28);
            this.txbCadNome.Name = "txbCadNome";
            this.txbCadNome.Size = new System.Drawing.Size(100, 20);
            this.txbCadNome.TabIndex = 6;
            // 
            // txbCadEmail
            // 
            this.txbCadEmail.Location = new System.Drawing.Point(89, 71);
            this.txbCadEmail.Name = "txbCadEmail";
            this.txbCadEmail.Size = new System.Drawing.Size(100, 20);
            this.txbCadEmail.TabIndex = 7;
            // 
            // txbCadSenha
            // 
            this.txbCadSenha.Location = new System.Drawing.Point(89, 109);
            this.txbCadSenha.Name = "txbCadSenha";
            this.txbCadSenha.Size = new System.Drawing.Size(100, 20);
            this.txbCadSenha.TabIndex = 8;
            // 
            // txbEdiNome
            // 
            this.txbEdiNome.Location = new System.Drawing.Point(89, 33);
            this.txbEdiNome.Name = "txbEdiNome";
            this.txbEdiNome.Size = new System.Drawing.Size(100, 20);
            this.txbEdiNome.TabIndex = 9;
            // 
            // txbEdiEmail
            // 
            this.txbEdiEmail.Location = new System.Drawing.Point(89, 76);
            this.txbEdiEmail.Name = "txbEdiEmail";
            this.txbEdiEmail.Size = new System.Drawing.Size(100, 20);
            this.txbEdiEmail.TabIndex = 10;
            // 
            // txbEdiSenha
            // 
            this.txbEdiSenha.Location = new System.Drawing.Point(88, 122);
            this.txbEdiSenha.Name = "txbEdiSenha";
            this.txbEdiSenha.Size = new System.Drawing.Size(100, 20);
            this.txbEdiSenha.TabIndex = 11;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.Lime;
            this.btnCadastrar.Location = new System.Drawing.Point(9, 154);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(179, 43);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditar.Location = new System.Drawing.Point(9, 154);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(179, 43);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // dgvGerenciamentoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.gBApagar);
            this.Controls.Add(this.gBEditar);
            this.Controls.Add(this.Cadastro);
            this.Controls.Add(this.dGVUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "dgvGerenciamentoUsuarios";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Usuários";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dGVUsuarios)).EndInit();
            this.Cadastro.ResumeLayout(false);
            this.Cadastro.PerformLayout();
            this.gBEditar.ResumeLayout(false);
            this.gBEditar.PerformLayout();
            this.gBApagar.ResumeLayout(false);
            this.gBApagar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVUsuarios;
        private System.Windows.Forms.GroupBox Cadastro;
        private System.Windows.Forms.Label lblCadSenha;
        private System.Windows.Forms.Label lblCadEmail;
        private System.Windows.Forms.Label lblCadNomeCompleto;
        private System.Windows.Forms.GroupBox gBEditar;
        private System.Windows.Forms.Label lblEdiSenha;
        private System.Windows.Forms.Label lblEdiEmail;
        private System.Windows.Forms.Label lblEdiNomeCompleto;
        private System.Windows.Forms.TextBox txbEdiSenha;
        private System.Windows.Forms.TextBox txbEdiEmail;
        private System.Windows.Forms.TextBox txbEdiNome;
        private System.Windows.Forms.TextBox txbCadSenha;
        private System.Windows.Forms.TextBox txbCadEmail;
        private System.Windows.Forms.TextBox txbCadNome;
        private System.Windows.Forms.GroupBox gBApagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
    }
}