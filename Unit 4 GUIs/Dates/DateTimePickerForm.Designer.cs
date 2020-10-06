namespace DateTimePickerTest
{
    partial class DateTimePickerForm
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
            this.dropOffDate = new System.Windows.Forms.Label();
            this.dropOffDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.estimatedDeliveryDate = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dropOffDate
            // 
            this.dropOffDate.AutoSize = true;
            this.dropOffDate.Location = new System.Drawing.Point(13, 13);
            this.dropOffDate.Name = "dropOffDate";
            this.dropOffDate.Size = new System.Drawing.Size(76, 13);
            this.dropOffDate.TabIndex = 0;
            this.dropOffDate.Text = "Drop Off Date:";
            this.dropOffDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dropOffDateTimePicker
            // 
            this.dropOffDateTimePicker.Location = new System.Drawing.Point(16, 39);
            this.dropOffDateTimePicker.Name = "dropOffDateTimePicker";
            this.dropOffDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dropOffDateTimePicker.TabIndex = 1;
            this.dropOffDateTimePicker.ValueChanged += new System.EventHandler(this.dropOffDateTimePicker_ValueChanged);
            // 
            // estimatedDeliveryDate
            // 
            this.estimatedDeliveryDate.AutoSize = true;
            this.estimatedDeliveryDate.Location = new System.Drawing.Point(16, 87);
            this.estimatedDeliveryDate.Name = "estimatedDeliveryDate";
            this.estimatedDeliveryDate.Size = new System.Drawing.Size(123, 13);
            this.estimatedDeliveryDate.TabIndex = 2;
            this.estimatedDeliveryDate.Text = "Estimated Delivery Date:";
            this.estimatedDeliveryDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputLabel.Location = new System.Drawing.Point(19, 117);
            this.outputLabel.MinimumSize = new System.Drawing.Size(200, 20);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(200, 20);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateTimePickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.estimatedDeliveryDate);
            this.Controls.Add(this.dropOffDateTimePicker);
            this.Controls.Add(this.dropOffDate);
            this.Name = "DateTimePickerForm";
            this.Text = "DateTimePickerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dropOffDate;
        private System.Windows.Forms.DateTimePicker dropOffDateTimePicker;
        private System.Windows.Forms.Label estimatedDeliveryDate;
        private System.Windows.Forms.Label outputLabel;
    }
}

