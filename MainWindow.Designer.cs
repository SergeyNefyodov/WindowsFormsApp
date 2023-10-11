namespace WindowsFormsApp
{
    partial class MainWindow
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
            this.RunButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ParametersBox = new System.Windows.Forms.ComboBox();
            this.TextUserValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RunButton
            // 
            this.RunButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RunButton.Location = new System.Drawing.Point(12, 124);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(137, 33);
            this.RunButton.TabIndex = 0;
            this.RunButton.Text = "Запуск";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(155, 124);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(132, 33);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // ParametersBox
            // 
            this.ParametersBox.FormattingEnabled = true;
            this.ParametersBox.Location = new System.Drawing.Point(12, 29);
            this.ParametersBox.Name = "ParametersBox";
            this.ParametersBox.Size = new System.Drawing.Size(275, 24);
            this.ParametersBox.TabIndex = 2;
            this.ParametersBox.SelectionChangeCommitted += new System.EventHandler(this.SelectionChanged);
            // 
            // TextUserValue
            // 
            this.TextUserValue.Location = new System.Drawing.Point(12, 72);
            this.TextUserValue.Name = "TextUserValue";
            this.TextUserValue.Size = new System.Drawing.Size(275, 22);
            this.TextUserValue.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(311, 183);
            this.Controls.Add(this.TextUserValue);
            this.Controls.Add(this.ParametersBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.RunButton);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button RunButton;
        public System.Windows.Forms.Button CancelButton;
        public System.Windows.Forms.ComboBox ParametersBox;
        public System.Windows.Forms.TextBox TextUserValue;
    }
}