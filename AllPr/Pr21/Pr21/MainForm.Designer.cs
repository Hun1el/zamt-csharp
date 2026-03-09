namespace Pr21
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически создаваемый конструктором форм

        private System.Windows.Forms.Label lblFourDigitNumber;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblString;
        private System.Windows.Forms.TextBox txtFourDigitNumber;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblResult;

        private void InitializeComponent()
        {
            this.lblFourDigitNumber = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblString = new System.Windows.Forms.Label();
            this.txtFourDigitNumber = new System.Windows.Forms.TextBox();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.txtString = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFourDigitNumber
            // 
            this.lblFourDigitNumber.AutoSize = true;
            this.lblFourDigitNumber.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblFourDigitNumber.Location = new System.Drawing.Point(12, 23);
            this.lblFourDigitNumber.Name = "lblFourDigitNumber";
            this.lblFourDigitNumber.Size = new System.Drawing.Size(395, 23);
            this.lblFourDigitNumber.TabIndex = 0;
            this.lblFourDigitNumber.Text = "Задание 1:  Введите четырехзначное число:";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblDistance.Location = new System.Drawing.Point(12, 84);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(419, 23);
            this.lblDistance.TabIndex = 2;
            this.lblDistance.Text = "Задание 2: Введите расстояние в сантиметрах:";
            // 
            // lblString
            // 
            this.lblString.AutoSize = true;
            this.lblString.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblString.Location = new System.Drawing.Point(12, 145);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(244, 23);
            this.lblString.TabIndex = 4;
            this.lblString.Text = "Задание 6: Введите строку:";
            // 
            // txtFourDigitNumber
            // 
            this.txtFourDigitNumber.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.txtFourDigitNumber.Location = new System.Drawing.Point(12, 49);
            this.txtFourDigitNumber.MaxLength = 4;
            this.txtFourDigitNumber.Name = "txtFourDigitNumber";
            this.txtFourDigitNumber.Size = new System.Drawing.Size(204, 32);
            this.txtFourDigitNumber.TabIndex = 1;
            // 
            // txtDistance
            // 
            this.txtDistance.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.txtDistance.Location = new System.Drawing.Point(12, 110);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(204, 32);
            this.txtDistance.TabIndex = 3;
            // 
            // txtString
            // 
            this.txtString.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.txtString.Location = new System.Drawing.Point(12, 171);
            this.txtString.Multiline = true; // Позволяет вводить многострочный текст
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(410, 60);
            this.txtString.TabIndex = 5;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.btnGenerate.Location = new System.Drawing.Point(69, 241);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(301, 31);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Создать документ Word";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.Task);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 280);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 324); // Увеличил высоту для лучшего отображения
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.lblString);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.txtFourDigitNumber);
            this.Controls.Add(this.lblFourDigitNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вариант 17";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
