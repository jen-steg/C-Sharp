﻿namespace ToolTipExample
{
    partial class ToolTipExampleTestForm
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
            this.components = new System.ComponentModel.Container();
            this.firstLabel = new System.Windows.Forms.Label();
            this.secondLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // firstLabel
            // 
            this.firstLabel.AutoSize = true;
            this.firstLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstLabel.Location = new System.Drawing.Point(86, 24);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(76, 15);
            this.firstLabel.TabIndex = 0;
            this.firstLabel.Text = "This is a label.";
            this.toolTip1.SetToolTip(this.firstLabel, "First Label");
            // 
            // secondLabel
            // 
            this.secondLabel.AutoSize = true;
            this.secondLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondLabel.Location = new System.Drawing.Point(86, 73);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(106, 15);
            this.secondLabel.TabIndex = 1;
            this.secondLabel.Text = "This is another label.";
            this.toolTip1.SetToolTip(this.secondLabel, "Second Label");
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "";
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // ToolTipExampleTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.firstLabel);
            this.Name = "ToolTipExampleTestForm";
            this.Text = "ToolTipExampleTestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label secondLabel;
    }
}

