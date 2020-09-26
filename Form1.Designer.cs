namespace FractionCalc {
    partial class Form1 {
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
            this.MainFormTxtbxNumerator1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MainFormTxtbxDenumerator1 = new System.Windows.Forms.TextBox();
            this.MainFormTxtbxNumerator2 = new System.Windows.Forms.TextBox();
            this.MainFormTxtbxDenumerator2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MainFromTxtbxNumerator3 = new System.Windows.Forms.TextBox();
            this.MainFormTxtbxDenumerator3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MainFormCmbbxOperation = new System.Windows.Forms.ComboBox();
            this.MainFormBttnEquality = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainFormTxtbxNumerator1
            // 
            this.MainFormTxtbxNumerator1.Location = new System.Drawing.Point(13, 12);
            this.MainFormTxtbxNumerator1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MainFormTxtbxNumerator1.Name = "MainFormTxtbxNumerator1";
            this.MainFormTxtbxNumerator1.Size = new System.Drawing.Size(50, 23);
            this.MainFormTxtbxNumerator1.TabIndex = 1;
            this.MainFormTxtbxNumerator1.TextChanged += new System.EventHandler(this.TextInput_Changed);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 2);
            this.label1.TabIndex = 2;
            // 
            // MainFormTxtbxDenumerator1
            // 
            this.MainFormTxtbxDenumerator1.Location = new System.Drawing.Point(12, 51);
            this.MainFormTxtbxDenumerator1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MainFormTxtbxDenumerator1.Name = "MainFormTxtbxDenumerator1";
            this.MainFormTxtbxDenumerator1.Size = new System.Drawing.Size(50, 23);
            this.MainFormTxtbxDenumerator1.TabIndex = 2;
            this.MainFormTxtbxDenumerator1.TextChanged += new System.EventHandler(this.TextInput_Changed);
            // 
            // MainFormTxtbxNumerator2
            // 
            this.MainFormTxtbxNumerator2.Location = new System.Drawing.Point(107, 12);
            this.MainFormTxtbxNumerator2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MainFormTxtbxNumerator2.Name = "MainFormTxtbxNumerator2";
            this.MainFormTxtbxNumerator2.Size = new System.Drawing.Size(50, 23);
            this.MainFormTxtbxNumerator2.TabIndex = 4;
            this.MainFormTxtbxNumerator2.TextChanged += new System.EventHandler(this.TextInput_Changed);
            // 
            // MainFormTxtbxDenumerator2
            // 
            this.MainFormTxtbxDenumerator2.Location = new System.Drawing.Point(107, 51);
            this.MainFormTxtbxDenumerator2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MainFormTxtbxDenumerator2.Name = "MainFormTxtbxDenumerator2";
            this.MainFormTxtbxDenumerator2.Size = new System.Drawing.Size(50, 23);
            this.MainFormTxtbxDenumerator2.TabIndex = 5;
            this.MainFormTxtbxDenumerator2.TextChanged += new System.EventHandler(this.TextInput_Changed);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(107, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 2);
            this.label2.TabIndex = 2;
            // 
            // MainFromTxtbxNumerator3
            // 
            this.MainFromTxtbxNumerator3.Location = new System.Drawing.Point(201, 12);
            this.MainFromTxtbxNumerator3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MainFromTxtbxNumerator3.Name = "MainFromTxtbxNumerator3";
            this.MainFromTxtbxNumerator3.ReadOnly = true;
            this.MainFromTxtbxNumerator3.Size = new System.Drawing.Size(50, 23);
            this.MainFromTxtbxNumerator3.TabIndex = 1;
            this.MainFromTxtbxNumerator3.TabStop = false;
            // 
            // MainFormTxtbxDenumerator3
            // 
            this.MainFormTxtbxDenumerator3.Location = new System.Drawing.Point(201, 51);
            this.MainFormTxtbxDenumerator3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MainFormTxtbxDenumerator3.Name = "MainFormTxtbxDenumerator3";
            this.MainFormTxtbxDenumerator3.ReadOnly = true;
            this.MainFormTxtbxDenumerator3.Size = new System.Drawing.Size(50, 23);
            this.MainFormTxtbxDenumerator3.TabIndex = 1;
            this.MainFormTxtbxDenumerator3.TabStop = false;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(201, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 2);
            this.label3.TabIndex = 2;
            // 
            // MainFormCmbbxOperation
            // 
            this.MainFormCmbbxOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MainFormCmbbxOperation.FormattingEnabled = true;
            this.MainFormCmbbxOperation.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.MainFormCmbbxOperation.Location = new System.Drawing.Point(70, 31);
            this.MainFormCmbbxOperation.Name = "MainFormCmbbxOperation";
            this.MainFormCmbbxOperation.Size = new System.Drawing.Size(30, 23);
            this.MainFormCmbbxOperation.TabIndex = 3;
            // 
            // MainFormBttnEquality
            // 
            this.MainFormBttnEquality.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainFormBttnEquality.Location = new System.Drawing.Point(164, 31);
            this.MainFormBttnEquality.Name = "MainFormBttnEquality";
            this.MainFormBttnEquality.Size = new System.Drawing.Size(30, 23);
            this.MainFormBttnEquality.TabIndex = 6;
            this.MainFormBttnEquality.Text = "=";
            this.MainFormBttnEquality.UseVisualStyleBackColor = true;
            this.MainFormBttnEquality.Click += new System.EventHandler(this.MainFormBttnEquality_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.MainFormBttnEquality;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 103);
            this.Controls.Add(this.MainFormBttnEquality);
            this.Controls.Add(this.MainFormCmbbxOperation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainFormTxtbxDenumerator3);
            this.Controls.Add(this.MainFormTxtbxDenumerator2);
            this.Controls.Add(this.MainFormTxtbxDenumerator1);
            this.Controls.Add(this.MainFromTxtbxNumerator3);
            this.Controls.Add(this.MainFormTxtbxNumerator2);
            this.Controls.Add(this.MainFormTxtbxNumerator1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Дробный калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox MainFormTxtbxNumerator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MainFormTxtbxDenumerator1;
        private System.Windows.Forms.TextBox MainFormTxtbxNumerator2;
        private System.Windows.Forms.TextBox MainFormTxtbxDenumerator2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MainFromTxtbxNumerator3;
        private System.Windows.Forms.TextBox MainFormTxtbxDenumerator3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MainFormCmbbxOperation;
        private System.Windows.Forms.Button MainFormBttnEquality;
    }
}

