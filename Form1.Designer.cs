namespace CauculadoraDaT6
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonigual = new System.Windows.Forms.Button();
            this.buttonvirgula = new System.Windows.Forms.Button();
            this.buttondivisão = new System.Windows.Forms.Button();
            this.buttonmultiplicação = new System.Windows.Forms.Button();
            this.buttonsubtração = new System.Windows.Forms.Button();
            this.buttonadição = new System.Windows.Forms.Button();
            this.buttoncopiar = new System.Windows.Forms.Button();
            this.buttonapagar = new System.Windows.Forms.Button();
            this.buttonlimpar = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.MediumOrchid;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxDisplay, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(315, 435);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.BackColor = System.Drawing.Color.Plum;
            this.textBoxDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDisplay.Font = new System.Drawing.Font("Microsoft Uighur", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDisplay.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxDisplay.Location = new System.Drawing.Point(3, 3);
            this.textBoxDisplay.Multiline = true;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(309, 102);
            this.textBoxDisplay.TabIndex = 0;
            this.textBoxDisplay.Text = "0000";
            this.textBoxDisplay.TextChanged += new System.EventHandler(this.textBoxDisplay_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Plum;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.buttonigual, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonvirgula, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttondivisão, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.buttonmultiplicação, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonsubtração, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonadição, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttoncopiar, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonapagar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonlimpar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button0, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.button3, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.button6, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.button5, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.button4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button9, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.button8, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.button7, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 111);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(309, 321);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // buttonigual
            // 
            this.buttonigual.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonigual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonigual.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonigual.Location = new System.Drawing.Point(234, 259);
            this.buttonigual.Name = "buttonigual";
            this.buttonigual.Size = new System.Drawing.Size(72, 59);
            this.buttonigual.TabIndex = 28;
            this.buttonigual.Text = "=";
            this.buttonigual.UseVisualStyleBackColor = false;
            this.buttonigual.Click += new System.EventHandler(this.buttonigual_Click);
            // 
            // buttonvirgula
            // 
            this.buttonvirgula.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonvirgula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonvirgula.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonvirgula.Location = new System.Drawing.Point(157, 259);
            this.buttonvirgula.Name = "buttonvirgula";
            this.buttonvirgula.Size = new System.Drawing.Size(71, 59);
            this.buttonvirgula.TabIndex = 27;
            this.buttonvirgula.Text = ".";
            this.buttonvirgula.UseVisualStyleBackColor = false;
            this.buttonvirgula.Click += new System.EventHandler(this.buttonvirgula_Click);
            // 
            // buttondivisão
            // 
            this.buttondivisão.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttondivisão.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttondivisão.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondivisão.Location = new System.Drawing.Point(234, 195);
            this.buttondivisão.Name = "buttondivisão";
            this.buttondivisão.Size = new System.Drawing.Size(72, 58);
            this.buttondivisão.TabIndex = 25;
            this.buttondivisão.Text = "/";
            this.buttondivisão.UseVisualStyleBackColor = false;
            this.buttondivisão.Click += new System.EventHandler(this.buttondivisão_Click);
            // 
            // buttonmultiplicação
            // 
            this.buttonmultiplicação.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonmultiplicação.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonmultiplicação.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmultiplicação.Location = new System.Drawing.Point(234, 131);
            this.buttonmultiplicação.Name = "buttonmultiplicação";
            this.buttonmultiplicação.Size = new System.Drawing.Size(72, 58);
            this.buttonmultiplicação.TabIndex = 24;
            this.buttonmultiplicação.Text = "*";
            this.buttonmultiplicação.UseVisualStyleBackColor = false;
            this.buttonmultiplicação.Click += new System.EventHandler(this.buttonmultiplicação_Click);
            // 
            // buttonsubtração
            // 
            this.buttonsubtração.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonsubtração.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsubtração.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsubtração.Location = new System.Drawing.Point(234, 67);
            this.buttonsubtração.Name = "buttonsubtração";
            this.buttonsubtração.Size = new System.Drawing.Size(72, 58);
            this.buttonsubtração.TabIndex = 23;
            this.buttonsubtração.Text = "-";
            this.buttonsubtração.UseVisualStyleBackColor = false;
            this.buttonsubtração.Click += new System.EventHandler(this.buttonsubtração_Click);
            // 
            // buttonadição
            // 
            this.buttonadição.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonadição.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonadição.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonadição.Location = new System.Drawing.Point(234, 3);
            this.buttonadição.Name = "buttonadição";
            this.buttonadição.Size = new System.Drawing.Size(72, 58);
            this.buttonadição.TabIndex = 22;
            this.buttonadição.Text = "+";
            this.buttonadição.UseVisualStyleBackColor = false;
            this.buttonadição.Click += new System.EventHandler(this.buttonadição_Click);
            // 
            // buttoncopiar
            // 
            this.buttoncopiar.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttoncopiar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttoncopiar.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncopiar.Location = new System.Drawing.Point(157, 3);
            this.buttoncopiar.Name = "buttoncopiar";
            this.buttoncopiar.Size = new System.Drawing.Size(71, 58);
            this.buttoncopiar.TabIndex = 21;
            this.buttoncopiar.Text = "Copy";
            this.buttoncopiar.UseVisualStyleBackColor = false;
            this.buttoncopiar.Click += new System.EventHandler(this.buttoncopiar_Click);
            // 
            // buttonapagar
            // 
            this.buttonapagar.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonapagar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonapagar.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonapagar.Location = new System.Drawing.Point(80, 3);
            this.buttonapagar.Name = "buttonapagar";
            this.buttonapagar.Size = new System.Drawing.Size(71, 58);
            this.buttonapagar.TabIndex = 20;
            this.buttonapagar.Text = "Erase";
            this.buttonapagar.UseVisualStyleBackColor = false;
            this.buttonapagar.Click += new System.EventHandler(this.buttonapagar_Click);
            // 
            // buttonlimpar
            // 
            this.buttonlimpar.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonlimpar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonlimpar.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlimpar.Location = new System.Drawing.Point(3, 3);
            this.buttonlimpar.Name = "buttonlimpar";
            this.buttonlimpar.Size = new System.Drawing.Size(71, 58);
            this.buttonlimpar.TabIndex = 19;
            this.buttonlimpar.Text = "Clear";
            this.buttonlimpar.UseVisualStyleBackColor = false;
            this.buttonlimpar.Click += new System.EventHandler(this.buttonlimpar_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.Orchid;
            this.button0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button0.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(80, 259);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(71, 59);
            this.button0.TabIndex = 18;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Orchid;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(157, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 58);
            this.button3.TabIndex = 15;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orchid;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(80, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 58);
            this.button2.TabIndex = 14;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orchid;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 58);
            this.button1.TabIndex = 13;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Orchid;
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(157, 131);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(71, 58);
            this.button6.TabIndex = 11;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Orchid;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(80, 131);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 58);
            this.button5.TabIndex = 10;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Orchid;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(3, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 58);
            this.button4.TabIndex = 9;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Orchid;
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(157, 67);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(71, 58);
            this.button9.TabIndex = 7;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Orchid;
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(80, 67);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(71, 58);
            this.button8.TabIndex = 6;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Orchid;
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(3, 67);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(71, 58);
            this.button7.TabIndex = 5;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(315, 435);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonigual;
        private System.Windows.Forms.Button buttonvirgula;
        private System.Windows.Forms.Button buttondivisão;
        private System.Windows.Forms.Button buttonmultiplicação;
        private System.Windows.Forms.Button buttonsubtração;
        private System.Windows.Forms.Button buttonadição;
        private System.Windows.Forms.Button buttoncopiar;
        private System.Windows.Forms.Button buttonapagar;
        private System.Windows.Forms.Button buttonlimpar;
    }
}

