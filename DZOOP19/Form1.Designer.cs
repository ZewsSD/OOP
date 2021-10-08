namespace DZOOP19
{
    partial class Form1
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
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.buttonSendMessage = new System.Windows.Forms.Button();
            this.buttonCreareForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.Location = new System.Drawing.Point(13, 13);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.Size = new System.Drawing.Size(174, 134);
            this.listBoxHistory.TabIndex = 0;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(12, 153);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(175, 29);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.Location = new System.Drawing.Point(12, 188);
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.Size = new System.Drawing.Size(85, 40);
            this.buttonSendMessage.TabIndex = 2;
            this.buttonSendMessage.Text = "Отправить сообщение";
            this.buttonSendMessage.UseVisualStyleBackColor = true;
            this.buttonSendMessage.Click += new System.EventHandler(this.buttonSendMessage_Click);
            // 
            // buttonCreareForm
            // 
            this.buttonCreareForm.Location = new System.Drawing.Point(103, 188);
            this.buttonCreareForm.Name = "buttonCreareForm";
            this.buttonCreareForm.Size = new System.Drawing.Size(85, 40);
            this.buttonCreareForm.TabIndex = 3;
            this.buttonCreareForm.Text = "Добавить форму";
            this.buttonCreareForm.UseVisualStyleBackColor = true;
            this.buttonCreareForm.Click += new System.EventHandler(this.buttonCreareForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 238);
            this.Controls.Add(this.buttonCreareForm);
            this.Controls.Add(this.buttonSendMessage);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.listBoxHistory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxHistory;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button buttonSendMessage;
        private System.Windows.Forms.Button buttonCreareForm;
    }
}

