namespace FToCTemperatureConversionTest
{
    partial class FToCTemperatureConversionForm
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.temperatureInput = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.fahrenheitOutput = new System.Windows.Forms.Label();
            this.celsiusOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(13, 13);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(159, 13);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Enter Temperature in Fahrenheit";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // temperatureInput
            // 
            this.temperatureInput.Location = new System.Drawing.Point(16, 44);
            this.temperatureInput.Name = "temperatureInput";
            this.temperatureInput.Size = new System.Drawing.Size(100, 20);
            this.temperatureInput.TabIndex = 1;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(143, 42);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "Convert ";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // fahrenheitOutput
            // 
            this.fahrenheitOutput.AutoSize = true;
            this.fahrenheitOutput.Location = new System.Drawing.Point(13, 87);
            this.fahrenheitOutput.Name = "fahrenheitOutput";
            this.fahrenheitOutput.Size = new System.Drawing.Size(0, 13);
            this.fahrenheitOutput.TabIndex = 4;
            this.fahrenheitOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // celsiusOutput
            // 
            this.celsiusOutput.AutoSize = true;
            this.celsiusOutput.Location = new System.Drawing.Point(16, 117);
            this.celsiusOutput.Name = "celsiusOutput";
            this.celsiusOutput.Size = new System.Drawing.Size(0, 13);
            this.celsiusOutput.TabIndex = 6;
            // 
            // FToCTemperatureConversionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.celsiusOutput);
            this.Controls.Add(this.fahrenheitOutput);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.temperatureInput);
            this.Controls.Add(this.instructionLabel);
            this.Name = "FToCTemperatureConversionForm";
            this.Text = "FToCTemperatureConversionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.TextBox temperatureInput;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label fahrenheitOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label celsiusOutput;
    }
}

