namespace TesterWithUI
{
    partial class frmMainForm
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
            this.lblOperandOne = new System.Windows.Forms.Label();
            this.lblOpr = new System.Windows.Forms.Label();
            this.lblOperandtTwo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.butStart = new System.Windows.Forms.Button();
            this.lblReamining = new System.Windows.Forms.Label();
            this.butAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOperandOne
            // 
            this.lblOperandOne.AutoSize = true;
            this.lblOperandOne.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOperandOne.Location = new System.Drawing.Point(13, 149);
            this.lblOperandOne.Name = "lblOperandOne";
            this.lblOperandOne.Size = new System.Drawing.Size(20, 21);
            this.lblOperandOne.TabIndex = 0;
            this.lblOperandOne.Text = "X";
            // 
            // lblOpr
            // 
            this.lblOpr.AutoSize = true;
            this.lblOpr.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOpr.Location = new System.Drawing.Point(70, 149);
            this.lblOpr.Name = "lblOpr";
            this.lblOpr.Size = new System.Drawing.Size(21, 21);
            this.lblOpr.TabIndex = 1;
            this.lblOpr.Text = "+";
            // 
            // lblOperandtTwo
            // 
            this.lblOperandtTwo.AutoSize = true;
            this.lblOperandtTwo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOperandtTwo.Location = new System.Drawing.Point(127, 149);
            this.lblOperandtTwo.Name = "lblOperandtTwo";
            this.lblOperandtTwo.Size = new System.Drawing.Size(19, 21);
            this.lblOperandtTwo.TabIndex = 2;
            this.lblOperandtTwo.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(184, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtAnswer.Location = new System.Drawing.Point(211, 146);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(100, 29);
            this.txtAnswer.TabIndex = 4;
            // 
            // butStart
            // 
            this.butStart.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.butStart.Location = new System.Drawing.Point(13, 13);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(133, 38);
            this.butStart.TabIndex = 5;
            this.butStart.Text = "Start it !";
            this.butStart.UseVisualStyleBackColor = true;
            // 
            // lblReamining
            // 
            this.lblReamining.AutoSize = true;
            this.lblReamining.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblReamining.Location = new System.Drawing.Point(162, 22);
            this.lblReamining.Name = "lblReamining";
            this.lblReamining.Size = new System.Drawing.Size(54, 21);
            this.lblReamining.TabIndex = 6;
            this.lblReamining.Text = "label2";
            // 
            // butAnswer
            // 
            this.butAnswer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.butAnswer.Location = new System.Drawing.Point(317, 140);
            this.butAnswer.Name = "butAnswer";
            this.butAnswer.Size = new System.Drawing.Size(133, 38);
            this.butAnswer.TabIndex = 7;
            this.butAnswer.Text = "Answer";
            this.butAnswer.UseVisualStyleBackColor = true;
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 193);
            this.Controls.Add(this.butAnswer);
            this.Controls.Add(this.lblReamining);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOperandtTwo);
            this.Controls.Add(this.lblOpr);
            this.Controls.Add(this.lblOperandOne);
            this.Name = "frmMainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperandOne;
        private System.Windows.Forms.Label lblOpr;
        private System.Windows.Forms.Label lblOperandtTwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Label lblReamining;
        private System.Windows.Forms.Button butAnswer;
    }
}

