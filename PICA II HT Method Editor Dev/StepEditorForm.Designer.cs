namespace PICA_II_HT_Method_Editor_Dev
{
    partial class StepEditorForm
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
            this.StepUIDLabel = new System.Windows.Forms.Label();
            this.DoneButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PressureModeComboBox = new System.Windows.Forms.ComboBox();
            this.MixSpeedTextBox = new System.Windows.Forms.TextBox();
            this.PressureSetPointTextBox = new System.Windows.Forms.TextBox();
            this.TempSetPointTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MeasurementTempResTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WaitTimeTextBox = new System.Windows.Forms.TextBox();
            this.NumberMeasTextBox = new System.Windows.Forms.TextBox();
            this.EqTimeTextBox = new System.Windows.Forms.TextBox();
            this.StepTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StepUIDLabel
            // 
            this.StepUIDLabel.AutoSize = true;
            this.StepUIDLabel.Location = new System.Drawing.Point(209, 0);
            this.StepUIDLabel.Name = "StepUIDLabel";
            this.StepUIDLabel.Size = new System.Drawing.Size(36, 13);
            this.StepUIDLabel.TabIndex = 0;
            this.StepUIDLabel.Text = "label1";
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.Gray;
            this.DoneButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DoneButton.FlatAppearance.BorderSize = 0;
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneButton.ForeColor = System.Drawing.Color.White;
            this.DoneButton.Location = new System.Drawing.Point(421, 592);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(77, 33);
            this.DoneButton.TabIndex = 9;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.PressureModeComboBox, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.MixSpeedTextBox, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.PressureSetPointTextBox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.TempSetPointTextBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.MeasurementTempResTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.StepUIDLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.WaitTimeTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.NumberMeasTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.EqTimeTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.StepTypeComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(486, 303);
            this.tableLayoutPanel1.TabIndex = 47;
            // 
            // PressureModeComboBox
            // 
            this.PressureModeComboBox.FormattingEnabled = true;
            this.PressureModeComboBox.Location = new System.Drawing.Point(209, 273);
            this.PressureModeComboBox.Name = "PressureModeComboBox";
            this.PressureModeComboBox.Size = new System.Drawing.Size(277, 21);
            this.PressureModeComboBox.TabIndex = 8;
            this.PressureModeComboBox.TextUpdate += new System.EventHandler(this.PressureModeComboBox_TextUpdate);
            // 
            // MixSpeedTextBox
            // 
            this.MixSpeedTextBox.Location = new System.Drawing.Point(209, 243);
            this.MixSpeedTextBox.Name = "MixSpeedTextBox";
            this.MixSpeedTextBox.Size = new System.Drawing.Size(277, 22);
            this.MixSpeedTextBox.TabIndex = 7;
            // 
            // PressureSetPointTextBox
            // 
            this.PressureSetPointTextBox.Location = new System.Drawing.Point(209, 213);
            this.PressureSetPointTextBox.Name = "PressureSetPointTextBox";
            this.PressureSetPointTextBox.Size = new System.Drawing.Size(277, 22);
            this.PressureSetPointTextBox.TabIndex = 6;
            // 
            // TempSetPointTextBox
            // 
            this.TempSetPointTextBox.Location = new System.Drawing.Point(209, 183);
            this.TempSetPointTextBox.Name = "TempSetPointTextBox";
            this.TempSetPointTextBox.Size = new System.Drawing.Size(277, 22);
            this.TempSetPointTextBox.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Temperature Set Point";
            // 
            // MeasurementTempResTextBox
            // 
            this.MeasurementTempResTextBox.Location = new System.Drawing.Point(209, 153);
            this.MeasurementTempResTextBox.Name = "MeasurementTempResTextBox";
            this.MeasurementTempResTextBox.Size = new System.Drawing.Size(277, 22);
            this.MeasurementTempResTextBox.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Step UID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Step Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Measurement Temperature Resolution";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(185, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Wait Time Between Measurements:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Measurements:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Equilibrium Time:";
            // 
            // WaitTimeTextBox
            // 
            this.WaitTimeTextBox.Location = new System.Drawing.Point(209, 123);
            this.WaitTimeTextBox.Name = "WaitTimeTextBox";
            this.WaitTimeTextBox.Size = new System.Drawing.Size(277, 22);
            this.WaitTimeTextBox.TabIndex = 3;
            // 
            // NumberMeasTextBox
            // 
            this.NumberMeasTextBox.Location = new System.Drawing.Point(209, 93);
            this.NumberMeasTextBox.Name = "NumberMeasTextBox";
            this.NumberMeasTextBox.Size = new System.Drawing.Size(277, 22);
            this.NumberMeasTextBox.TabIndex = 2;
            // 
            // EqTimeTextBox
            // 
            this.EqTimeTextBox.Location = new System.Drawing.Point(209, 63);
            this.EqTimeTextBox.Name = "EqTimeTextBox";
            this.EqTimeTextBox.Size = new System.Drawing.Size(277, 22);
            this.EqTimeTextBox.TabIndex = 1;
            // 
            // StepTypeComboBox
            // 
            this.StepTypeComboBox.FormattingEnabled = true;
            this.StepTypeComboBox.Location = new System.Drawing.Point(209, 33);
            this.StepTypeComboBox.Name = "StepTypeComboBox";
            this.StepTypeComboBox.Size = new System.Drawing.Size(277, 21);
            this.StepTypeComboBox.TabIndex = 0;
            this.StepTypeComboBox.TextUpdate += new System.EventHandler(this.StepTypeComboBox_TextUpdate);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "Pressure Set Point";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Mixing Speed";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 55;
            this.label11.Text = "Pressure Mode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 32);
            this.label6.TabIndex = 48;
            this.label6.Text = "Step Editor";
            // 
            // StepEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(508, 637);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.DoneButton);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "StepEditorForm";
            this.Text = "Step Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StepEditorForm_FormClosing);
            this.Load += new System.EventHandler(this.StepEditorForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StepUIDLabel;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox WaitTimeTextBox;
        private System.Windows.Forms.TextBox NumberMeasTextBox;
        private System.Windows.Forms.TextBox EqTimeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MixSpeedTextBox;
        private System.Windows.Forms.TextBox PressureSetPointTextBox;
        private System.Windows.Forms.TextBox TempSetPointTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MeasurementTempResTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox PressureModeComboBox;
        private System.Windows.Forms.ComboBox StepTypeComboBox;
    }
}