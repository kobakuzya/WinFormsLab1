
namespace WinFormsLab1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PrintAnswerButton = new System.Windows.Forms.Button();
            this.ClearFieldsBotton = new System.Windows.Forms.Button();
            this.FirstWordInputField = new System.Windows.Forms.TextBox();
            this.SecondWordInputField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Первое слово";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Второе слово";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 2;
            // 
            // PrintAnswerButton
            // 
            this.PrintAnswerButton.Location = new System.Drawing.Point(15, 90);
            this.PrintAnswerButton.Name = "PrintAnswerButton";
            this.PrintAnswerButton.Size = new System.Drawing.Size(85, 23);
            this.PrintAnswerButton.TabIndex = 3;
            this.PrintAnswerButton.Text = "Ответ";
            this.PrintAnswerButton.UseVisualStyleBackColor = true;
            // 
            // ClearFieldsBotton
            // 
            this.ClearFieldsBotton.Location = new System.Drawing.Point(103, 90);
            this.ClearFieldsBotton.Name = "ClearFieldsBotton";
            this.ClearFieldsBotton.Size = new System.Drawing.Size(85, 23);
            this.ClearFieldsBotton.TabIndex = 4;
            this.ClearFieldsBotton.Text = "Очистить";
            this.ClearFieldsBotton.UseVisualStyleBackColor = true;
            // 
            // FirstWordInputField
            // 
            this.FirstWordInputField.Location = new System.Drawing.Point(103, 26);
            this.FirstWordInputField.Name = "FirstWordInputField";
            this.FirstWordInputField.Size = new System.Drawing.Size(85, 23);
            this.FirstWordInputField.TabIndex = 5;
            // 
            // SecondWordInputField
            // 
            this.SecondWordInputField.Location = new System.Drawing.Point(103, 55);
            this.SecondWordInputField.Name = "SecondWordInputField";
            this.SecondWordInputField.Size = new System.Drawing.Size(85, 23);
            this.SecondWordInputField.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 183);
            this.Controls.Add(this.SecondWordInputField);
            this.Controls.Add(this.FirstWordInputField);
            this.Controls.Add(this.ClearFieldsBotton);
            this.Controls.Add(this.PrintAnswerButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Words";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PrintAnswerButton;
        private System.Windows.Forms.Button ClearFieldsBotton;
        private System.Windows.Forms.TextBox FirstWordInputField;
        private System.Windows.Forms.TextBox SecondWordInputField;
    }
}

