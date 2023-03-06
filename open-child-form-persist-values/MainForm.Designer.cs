namespace open_child_form_persist_values
{
    partial class MainForm
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
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.checkBoxRoom = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDesktopPanel.Location = new System.Drawing.Point(149, 29);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(313, 203);
            this.panelDesktopPanel.TabIndex = 1;
            // 
            // checkBoxRoom
            // 
            this.checkBoxRoom.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxRoom.Location = new System.Drawing.Point(14, 34);
            this.checkBoxRoom.Name = "checkBoxRoom";
            this.checkBoxRoom.Size = new System.Drawing.Size(119, 44);
            this.checkBoxRoom.TabIndex = 2;
            this.checkBoxRoom.Text = "Room";
            this.checkBoxRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxRoom.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 244);
            this.Controls.Add(this.checkBoxRoom);
            this.Controls.Add(this.panelDesktopPanel);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.CheckBox checkBoxRoom;
    }
}
