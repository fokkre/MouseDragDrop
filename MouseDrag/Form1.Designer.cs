namespace MouseDrag
{
    partial class Form1
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
            this.dragHeightText = new System.Windows.Forms.Label();
            this.dragWidthText = new System.Windows.Forms.Label();
            this.dragHeightCurrent = new System.Windows.Forms.Label();
            this.dragWidthCurrent = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.newDragNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.newDragNum)).BeginInit();
            this.SuspendLayout();
            // 
            // dragHeightText
            // 
            this.dragHeightText.AutoSize = true;
            this.dragHeightText.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dragHeightText.Location = new System.Drawing.Point(13, 29);
            this.dragHeightText.Name = "dragHeightText";
            this.dragHeightText.Size = new System.Drawing.Size(202, 22);
            this.dragHeightText.TabIndex = 0;
            this.dragHeightText.Text = "Current Drag Height:";
            // 
            // dragWidthText
            // 
            this.dragWidthText.AutoSize = true;
            this.dragWidthText.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.dragWidthText.Location = new System.Drawing.Point(13, 68);
            this.dragWidthText.Name = "dragWidthText";
            this.dragWidthText.Size = new System.Drawing.Size(195, 22);
            this.dragWidthText.TabIndex = 1;
            this.dragWidthText.Text = "Current Drag Width:";
            // 
            // dragHeightCurrent
            // 
            this.dragHeightCurrent.AutoSize = true;
            this.dragHeightCurrent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dragHeightCurrent.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.dragHeightCurrent.Location = new System.Drawing.Point(221, 29);
            this.dragHeightCurrent.Name = "dragHeightCurrent";
            this.dragHeightCurrent.Size = new System.Drawing.Size(23, 26);
            this.dragHeightCurrent.TabIndex = 2;
            this.dragHeightCurrent.Text = "4";
            // 
            // dragWidthCurrent
            // 
            this.dragWidthCurrent.AutoSize = true;
            this.dragWidthCurrent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dragWidthCurrent.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.dragWidthCurrent.Location = new System.Drawing.Point(221, 64);
            this.dragWidthCurrent.Name = "dragWidthCurrent";
            this.dragWidthCurrent.Size = new System.Drawing.Size(23, 26);
            this.dragWidthCurrent.TabIndex = 3;
            this.dragWidthCurrent.Text = "4";
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.updateButton.Location = new System.Drawing.Point(60, 170);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(132, 47);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.closeButton.Location = new System.Drawing.Point(230, 170);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(132, 47);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.resetButton.Location = new System.Drawing.Point(262, 29);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(100, 67);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset Values";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "New Drag Value:";
            // 
            // newDragNum
            // 
            this.newDragNum.BackColor = System.Drawing.SystemColors.Window;
            this.newDragNum.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newDragNum.Location = new System.Drawing.Point(181, 105);
            this.newDragNum.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.newDragNum.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.newDragNum.Name = "newDragNum";
            this.newDragNum.Size = new System.Drawing.Size(41, 30);
            this.newDragNum.TabIndex = 8;
            this.newDragNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newDragNum.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 250);
            this.Controls.Add(this.newDragNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.dragWidthCurrent);
            this.Controls.Add(this.dragHeightCurrent);
            this.Controls.Add(this.dragWidthText);
            this.Controls.Add(this.dragHeightText);
            this.Name = "Form1";
            this.Text = "Mouse Drag";
            ((System.ComponentModel.ISupportInitialize)(this.newDragNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dragHeightText;
        private System.Windows.Forms.Label dragWidthText;
        private System.Windows.Forms.Label dragHeightCurrent;
        private System.Windows.Forms.Label dragWidthCurrent;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown newDragNum;
    }
}