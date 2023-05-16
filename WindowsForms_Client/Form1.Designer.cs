
namespace WindowsForms_Client
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
            this.CursorComboBox = new System.Windows.Forms.ComboBox();
            this.CursorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CursorComboBox
            // 
            this.CursorComboBox.FormattingEnabled = true;
            this.CursorComboBox.Items.AddRange(new object[] {
            "CursorType1",
            "CursorType2",
            "CursorType3"});
            this.CursorComboBox.Location = new System.Drawing.Point(68, 73);
            this.CursorComboBox.Name = "CursorComboBox";
            this.CursorComboBox.Size = new System.Drawing.Size(121, 21);
            this.CursorComboBox.TabIndex = 0;
            // 
            // CursorButton
            // 
            this.CursorButton.Location = new System.Drawing.Point(113, 165);
            this.CursorButton.Name = "CursorButton";
            this.CursorButton.Size = new System.Drawing.Size(75, 23);
            this.CursorButton.TabIndex = 1;
            this.CursorButton.Text = "button1";
            this.CursorButton.UseVisualStyleBackColor = true;
            this.CursorButton.Click += new System.EventHandler(this.CursorButton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(532, 423);
            this.Controls.Add(this.CursorButton);
            this.Controls.Add(this.CursorComboBox);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCursor1;
        private System.Windows.Forms.Button btnCursor2;
        private System.Windows.Forms.Button btnCursor3;
        private System.Windows.Forms.ComboBox CursorComboBox;
        private System.Windows.Forms.Button CursorButton;
    }
}

