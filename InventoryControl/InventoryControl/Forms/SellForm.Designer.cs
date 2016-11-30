namespace InventoryControl.Forms
{
    partial class SellForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellForm));
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_produto = new System.Windows.Forms.Label();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.lbl_valorProduto = new System.Windows.Forms.Label();
            this.txt_produto = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.lbl_addItem = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(12, 9);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "ID";
            // 
            // lbl_produto
            // 
            this.lbl_produto.AutoSize = true;
            this.lbl_produto.Location = new System.Drawing.Point(57, 8);
            this.lbl_produto.Name = "lbl_produto";
            this.lbl_produto.Size = new System.Drawing.Size(134, 13);
            this.lbl_produto.TabIndex = 1;
            this.lbl_produto.Text = "Código / Nome do Produto";
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Location = new System.Drawing.Point(411, 8);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(30, 13);
            this.lbl_quantidade.TabIndex = 2;
            this.lbl_quantidade.Text = "Qtde";
            // 
            // lbl_valorProduto
            // 
            this.lbl_valorProduto.AutoSize = true;
            this.lbl_valorProduto.Location = new System.Drawing.Point(483, 9);
            this.lbl_valorProduto.Name = "lbl_valorProduto";
            this.lbl_valorProduto.Size = new System.Drawing.Size(31, 13);
            this.lbl_valorProduto.TabIndex = 3;
            this.lbl_valorProduto.Text = "Valor";
            // 
            // txt_produto
            // 
            this.txt_produto.Location = new System.Drawing.Point(60, 25);
            this.txt_produto.Name = "txt_produto";
            this.txt_produto.Size = new System.Drawing.Size(348, 20);
            this.txt_produto.TabIndex = 4;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(13, 24);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(41, 20);
            this.txt_id.TabIndex = 5;
            // 
            // txt_valor
            // 
            this.txt_valor.Enabled = false;
            this.txt_valor.Location = new System.Drawing.Point(486, 24);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_valor.TabIndex = 6;
            // 
            // lbl_addItem
            // 
            this.lbl_addItem.Location = new System.Drawing.Point(593, 21);
            this.lbl_addItem.Name = "lbl_addItem";
            this.lbl_addItem.Size = new System.Drawing.Size(79, 23);
            this.lbl_addItem.TabIndex = 8;
            this.lbl_addItem.Text = "Adicionar";
            this.lbl_addItem.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(414, 24);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown1.TabIndex = 9;
            // 
            // SellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lbl_addItem);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_produto);
            this.Controls.Add(this.lbl_valorProduto);
            this.Controls.Add(this.lbl_quantidade);
            this.Controls.Add(this.lbl_produto);
            this.Controls.Add(this.lbl_id);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SellForm";
            this.Text = "Venda";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_produto;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.Label lbl_valorProduto;
        private System.Windows.Forms.TextBox txt_produto;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Button lbl_addItem;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}