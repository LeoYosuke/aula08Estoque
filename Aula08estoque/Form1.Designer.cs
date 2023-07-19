namespace Aula08estoque
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblquantidade = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblcadastrados = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnultimo = new System.Windows.Forms.Button();
            this.btndeletar = new System.Windows.Forms.Button();
            this.btn1produto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnsalvar);
            this.panel1.Controls.Add(this.txtquantidade);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtnome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(42, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 181);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(20, 147);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(65, 23);
            this.btnsalvar.TabIndex = 4;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // txtquantidade
            // 
            this.txtquantidade.Location = new System.Drawing.Point(20, 105);
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(163, 23);
            this.txtquantidade.TabIndex = 3;
            this.txtquantidade.TextChanged += new System.EventHandler(this.txtquantidade_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade em estoque";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(22, 38);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(162, 23);
            this.txtnome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome do produto";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblquantidade);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblcadastrados);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(286, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 181);
            this.panel2.TabIndex = 2;
            // 
            // lblquantidade
            // 
            this.lblquantidade.AutoSize = true;
            this.lblquantidade.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblquantidade.Location = new System.Drawing.Point(91, 130);
            this.lblquantidade.Name = "lblquantidade";
            this.lblquantidade.Size = new System.Drawing.Size(18, 20);
            this.lblquantidade.TabIndex = 3;
            this.lblquantidade.Text = "0";
            this.lblquantidade.Click += new System.EventHandler(this.lblquantidade_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Quantidade do estoque :";
            // 
            // lblcadastrados
            // 
            this.lblcadastrados.AutoSize = true;
            this.lblcadastrados.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcadastrados.Location = new System.Drawing.Point(91, 59);
            this.lblcadastrados.Name = "lblcadastrados";
            this.lblcadastrados.Size = new System.Drawing.Size(18, 20);
            this.lblcadastrados.TabIndex = 1;
            this.lblcadastrados.Text = "0";
            this.lblcadastrados.Click += new System.EventHandler(this.lblcadastrados_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Produtos cadastrados :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Informações";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnultimo);
            this.panel3.Controls.Add(this.btndeletar);
            this.panel3.Controls.Add(this.btn1produto);
            this.panel3.Location = new System.Drawing.Point(42, 266);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(462, 104);
            this.panel3.TabIndex = 3;
            // 
            // btnultimo
            // 
            this.btnultimo.Location = new System.Drawing.Point(31, 54);
            this.btnultimo.Name = "btnultimo";
            this.btnultimo.Size = new System.Drawing.Size(200, 29);
            this.btnultimo.TabIndex = 2;
            this.btnultimo.Text = "Ver ULTIMO produto";
            this.btnultimo.UseVisualStyleBackColor = true;
            this.btnultimo.Click += new System.EventHandler(this.btnultimo_Click);
            // 
            // btndeletar
            // 
            this.btndeletar.Location = new System.Drawing.Point(244, 19);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(200, 29);
            this.btndeletar.TabIndex = 1;
            this.btndeletar.Text = "Deletar PRIMEIRO produto";
            this.btndeletar.UseVisualStyleBackColor = true;
            this.btndeletar.Click += new System.EventHandler(this.btndeletar_Click);
            // 
            // btn1produto
            // 
            this.btn1produto.Location = new System.Drawing.Point(30, 19);
            this.btn1produto.Name = "btn1produto";
            this.btn1produto.Size = new System.Drawing.Size(200, 29);
            this.btn1produto.TabIndex = 0;
            this.btn1produto.Text = "Ver PRIMEIRO produto";
            this.btn1produto.UseVisualStyleBackColor = true;
            this.btn1produto.Click += new System.EventHandler(this.btn1produto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Operações";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnsalvar;
        private TextBox txtquantidade;
        private Label label3;
        private TextBox txtnome;
        private Label label2;
        private Panel panel2;
        private Label label4;
        private Label lblquantidade;
        private Label label7;
        private Label lblcadastrados;
        private Label label5;
        private Panel panel3;
        private Button btnultimo;
        private Button btndeletar;
        private Button btn1produto;
        private Label label6;
        private Button button1;
    }
}