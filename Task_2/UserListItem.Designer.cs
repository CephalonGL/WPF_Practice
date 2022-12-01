namespace Task_2_WPF_View
{
    partial class UserListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.deleteFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(0, 0);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(87, 25);
            this.fileNameLabel.TabIndex = 0;
            this.fileNameLabel.Text = "File name";
            // 
            // deleteFileButton
            // 
            this.deleteFileButton.Image = global::Task_2_WPF_View.Properties.Resources.free_icon_font_cross_3917759;
            this.deleteFileButton.Location = new System.Drawing.Point(258, 0);
            this.deleteFileButton.Name = "deleteFileButton";
            this.deleteFileButton.Size = new System.Drawing.Size(30, 30);
            this.deleteFileButton.TabIndex = 1;
            this.deleteFileButton.UseVisualStyleBackColor = true;
            // 
            // UserListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteFileButton);
            this.Controls.Add(this.fileNameLabel);
            this.Name = "UserListItem";
            this.Size = new System.Drawing.Size(291, 34);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label fileNameLabel;
        private Button deleteFileButton;
    }
}
