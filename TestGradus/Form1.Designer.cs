namespace TestGradus
{
    partial class FormDegree
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxCelFirst = new System.Windows.Forms.TextBox();
            this.textBoxFarFirst = new System.Windows.Forms.TextBox();
            this.btnCInF = new System.Windows.Forms.Button();
            this.textBoxFarSecond = new System.Windows.Forms.TextBox();
            this.textBoxCelSecond = new System.Windows.Forms.TextBox();
            this.btnFInC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCelFirst
            // 
            this.textBoxCelFirst.Location = new System.Drawing.Point(54, 73);
            this.textBoxCelFirst.Name = "textBoxCelFirst";
            this.textBoxCelFirst.Size = new System.Drawing.Size(169, 22);
            this.textBoxCelFirst.TabIndex = 0;
            // 
            // textBoxFarFirst
            // 
            this.textBoxFarFirst.Location = new System.Drawing.Point(295, 73);
            this.textBoxFarFirst.Name = "textBoxFarFirst";
            this.textBoxFarFirst.ReadOnly = true;
            this.textBoxFarFirst.Size = new System.Drawing.Size(169, 22);
            this.textBoxFarFirst.TabIndex = 1;
            // 
            // btnCInF
            // 
            this.btnCInF.Location = new System.Drawing.Point(158, 100);
            this.btnCInF.Name = "btnCInF";
            this.btnCInF.Size = new System.Drawing.Size(167, 23);
            this.btnCInF.TabIndex = 2;
            this.btnCInF.Text = "Перевод из Ц в Ф";
            this.btnCInF.UseVisualStyleBackColor = true;
            this.btnCInF.Click += new System.EventHandler(this.btnCInF_Click);
            // 
            // textBoxFarSecond
            // 
            this.textBoxFarSecond.Location = new System.Drawing.Point(54, 185);
            this.textBoxFarSecond.Name = "textBoxFarSecond";
            this.textBoxFarSecond.Size = new System.Drawing.Size(169, 22);
            this.textBoxFarSecond.TabIndex = 3;
            // 
            // textBoxCelSecond
            // 
            this.textBoxCelSecond.Location = new System.Drawing.Point(295, 185);
            this.textBoxCelSecond.Name = "textBoxCelSecond";
            this.textBoxCelSecond.ReadOnly = true;
            this.textBoxCelSecond.Size = new System.Drawing.Size(169, 22);
            this.textBoxCelSecond.TabIndex = 4;
            // 
            // btnFInC
            // 
            this.btnFInC.Location = new System.Drawing.Point(158, 212);
            this.btnFInC.Name = "btnFInC";
            this.btnFInC.Size = new System.Drawing.Size(167, 23);
            this.btnFInC.TabIndex = 5;
            this.btnFInC.Text = "Перевод из Ф в Ц";
            this.btnFInC.UseVisualStyleBackColor = true;
            this.btnFInC.Click += new System.EventHandler(this.btnFInC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Перевод из градусов Цельсия в градусы Фаренгейта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Перевод из градусов Фаренгейта в градусы Цельсия";
            // 
            // FormDegree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 313);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFInC);
            this.Controls.Add(this.textBoxCelSecond);
            this.Controls.Add(this.textBoxFarSecond);
            this.Controls.Add(this.btnCInF);
            this.Controls.Add(this.textBoxFarFirst);
            this.Controls.Add(this.textBoxCelFirst);
            this.Name = "FormDegree";
            this.Text = "Градусы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCelFirst;
        private System.Windows.Forms.TextBox textBoxFarFirst;
        private System.Windows.Forms.Button btnCInF;
        private System.Windows.Forms.TextBox textBoxFarSecond;
        private System.Windows.Forms.TextBox textBoxCelSecond;
        private System.Windows.Forms.Button btnFInC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

