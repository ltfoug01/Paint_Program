namespace Program1
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
            this.enterSqFeetPromptLabel = new System.Windows.Forms.Label();
            this.enterCoatsOfPaintPromptLabel = new System.Windows.Forms.Label();
            this.paintPricePerGalPromptLabel = new System.Windows.Forms.Label();
            this.paintPricePerGalTextBox = new System.Windows.Forms.TextBox();
            this.coatsOfPaintTextBox = new System.Windows.Forms.TextBox();
            this.sqFeetTextBox = new System.Windows.Forms.TextBox();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.inputInstructionsLabel = new System.Windows.Forms.Label();
            this.outputPanel = new System.Windows.Forms.Panel();
            this.totalSqFeetLabel = new System.Windows.Forms.Label();
            this.gallonsReqLabel = new System.Windows.Forms.Label();
            this.laborHrsReqLabel = new System.Windows.Forms.Label();
            this.paintCostLabel = new System.Windows.Forms.Label();
            this.laborCostLabel = new System.Windows.Forms.Label();
            this.paintCostPromptLabel = new System.Windows.Forms.Label();
            this.laborCostPromptLabel = new System.Windows.Forms.Label();
            this.laborHrsReqPromptLabel = new System.Windows.Forms.Label();
            this.gallonsReqPromptLabel = new System.Windows.Forms.Label();
            this.totalSqFeetPromptLabel = new System.Windows.Forms.Label();
            this.calcOrderButton = new System.Windows.Forms.Button();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.totalCostPromptLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.inputPanel.SuspendLayout();
            this.outputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // enterSqFeetPromptLabel
            // 
            this.enterSqFeetPromptLabel.AutoSize = true;
            this.enterSqFeetPromptLabel.Location = new System.Drawing.Point(9, 43);
            this.enterSqFeetPromptLabel.Name = "enterSqFeetPromptLabel";
            this.enterSqFeetPromptLabel.Size = new System.Drawing.Size(144, 13);
            this.enterSqFeetPromptLabel.TabIndex = 0;
            this.enterSqFeetPromptLabel.Text = "Enter Sq. Feet to be Painted:";
            // 
            // enterCoatsOfPaintPromptLabel
            // 
            this.enterCoatsOfPaintPromptLabel.AutoSize = true;
            this.enterCoatsOfPaintPromptLabel.Location = new System.Drawing.Point(17, 75);
            this.enterCoatsOfPaintPromptLabel.Name = "enterCoatsOfPaintPromptLabel";
            this.enterCoatsOfPaintPromptLabel.Size = new System.Drawing.Size(136, 13);
            this.enterCoatsOfPaintPromptLabel.TabIndex = 1;
            this.enterCoatsOfPaintPromptLabel.Text = "Enter No. of Coats of Paint:";
            // 
            // paintPricePerGalPromptLabel
            // 
            this.paintPricePerGalPromptLabel.AutoSize = true;
            this.paintPricePerGalPromptLabel.Location = new System.Drawing.Point(3, 105);
            this.paintPricePerGalPromptLabel.Name = "paintPricePerGalPromptLabel";
            this.paintPricePerGalPromptLabel.Size = new System.Drawing.Size(150, 13);
            this.paintPricePerGalPromptLabel.TabIndex = 2;
            this.paintPricePerGalPromptLabel.Text = "Enter Price of Paint per gallon:";
            // 
            // paintPricePerGalTextBox
            // 
            this.paintPricePerGalTextBox.Location = new System.Drawing.Point(159, 102);
            this.paintPricePerGalTextBox.Name = "paintPricePerGalTextBox";
            this.paintPricePerGalTextBox.Size = new System.Drawing.Size(100, 20);
            this.paintPricePerGalTextBox.TabIndex = 2;
            // 
            // coatsOfPaintTextBox
            // 
            this.coatsOfPaintTextBox.Location = new System.Drawing.Point(159, 72);
            this.coatsOfPaintTextBox.Name = "coatsOfPaintTextBox";
            this.coatsOfPaintTextBox.Size = new System.Drawing.Size(100, 20);
            this.coatsOfPaintTextBox.TabIndex = 1;
            // 
            // sqFeetTextBox
            // 
            this.sqFeetTextBox.Location = new System.Drawing.Point(159, 40);
            this.sqFeetTextBox.Name = "sqFeetTextBox";
            this.sqFeetTextBox.Size = new System.Drawing.Size(100, 20);
            this.sqFeetTextBox.TabIndex = 0;
            // 
            // inputPanel
            // 
            this.inputPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.inputPanel.Controls.Add(this.inputInstructionsLabel);
            this.inputPanel.Controls.Add(this.paintPricePerGalTextBox);
            this.inputPanel.Controls.Add(this.enterSqFeetPromptLabel);
            this.inputPanel.Controls.Add(this.coatsOfPaintTextBox);
            this.inputPanel.Controls.Add(this.sqFeetTextBox);
            this.inputPanel.Controls.Add(this.paintPricePerGalPromptLabel);
            this.inputPanel.Controls.Add(this.enterCoatsOfPaintPromptLabel);
            this.inputPanel.Location = new System.Drawing.Point(58, 30);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(275, 136);
            this.inputPanel.TabIndex = 6;
            // 
            // inputInstructionsLabel
            // 
            this.inputInstructionsLabel.AutoSize = true;
            this.inputInstructionsLabel.Location = new System.Drawing.Point(92, 13);
            this.inputInstructionsLabel.Name = "inputInstructionsLabel";
            this.inputInstructionsLabel.Size = new System.Drawing.Size(87, 13);
            this.inputInstructionsLabel.TabIndex = 7;
            this.inputInstructionsLabel.Text = "Enter Information";
            // 
            // outputPanel
            // 
            this.outputPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputPanel.Controls.Add(this.totalCostLabel);
            this.outputPanel.Controls.Add(this.totalCostPromptLabel);
            this.outputPanel.Controls.Add(this.totalSqFeetLabel);
            this.outputPanel.Controls.Add(this.gallonsReqLabel);
            this.outputPanel.Controls.Add(this.laborHrsReqLabel);
            this.outputPanel.Controls.Add(this.paintCostLabel);
            this.outputPanel.Controls.Add(this.laborCostLabel);
            this.outputPanel.Controls.Add(this.paintCostPromptLabel);
            this.outputPanel.Controls.Add(this.laborCostPromptLabel);
            this.outputPanel.Controls.Add(this.laborHrsReqPromptLabel);
            this.outputPanel.Controls.Add(this.gallonsReqPromptLabel);
            this.outputPanel.Controls.Add(this.totalSqFeetPromptLabel);
            this.outputPanel.Location = new System.Drawing.Point(58, 191);
            this.outputPanel.Name = "outputPanel";
            this.outputPanel.Size = new System.Drawing.Size(275, 218);
            this.outputPanel.TabIndex = 7;
            // 
            // totalSqFeetLabel
            // 
            this.totalSqFeetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalSqFeetLabel.Location = new System.Drawing.Point(151, 8);
            this.totalSqFeetLabel.Name = "totalSqFeetLabel";
            this.totalSqFeetLabel.Size = new System.Drawing.Size(100, 23);
            this.totalSqFeetLabel.TabIndex = 9;
            this.totalSqFeetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gallonsReqLabel
            // 
            this.gallonsReqLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gallonsReqLabel.Location = new System.Drawing.Point(151, 40);
            this.gallonsReqLabel.Name = "gallonsReqLabel";
            this.gallonsReqLabel.Size = new System.Drawing.Size(100, 23);
            this.gallonsReqLabel.TabIndex = 8;
            this.gallonsReqLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laborHrsReqLabel
            // 
            this.laborHrsReqLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborHrsReqLabel.Location = new System.Drawing.Point(151, 73);
            this.laborHrsReqLabel.Name = "laborHrsReqLabel";
            this.laborHrsReqLabel.Size = new System.Drawing.Size(100, 23);
            this.laborHrsReqLabel.TabIndex = 7;
            this.laborHrsReqLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paintCostLabel
            // 
            this.paintCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paintCostLabel.Location = new System.Drawing.Point(151, 106);
            this.paintCostLabel.Name = "paintCostLabel";
            this.paintCostLabel.Size = new System.Drawing.Size(100, 23);
            this.paintCostLabel.TabIndex = 6;
            this.paintCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laborCostLabel
            // 
            this.laborCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborCostLabel.Location = new System.Drawing.Point(151, 141);
            this.laborCostLabel.Name = "laborCostLabel";
            this.laborCostLabel.Size = new System.Drawing.Size(100, 23);
            this.laborCostLabel.TabIndex = 5;
            this.laborCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paintCostPromptLabel
            // 
            this.paintCostPromptLabel.AutoSize = true;
            this.paintCostPromptLabel.Location = new System.Drawing.Point(75, 111);
            this.paintCostPromptLabel.Name = "paintCostPromptLabel";
            this.paintCostPromptLabel.Size = new System.Drawing.Size(70, 13);
            this.paintCostPromptLabel.TabIndex = 4;
            this.paintCostPromptLabel.Text = "Cost of Paint:";
            // 
            // laborCostPromptLabel
            // 
            this.laborCostPromptLabel.AutoSize = true;
            this.laborCostPromptLabel.Location = new System.Drawing.Point(72, 146);
            this.laborCostPromptLabel.Name = "laborCostPromptLabel";
            this.laborCostPromptLabel.Size = new System.Drawing.Size(73, 13);
            this.laborCostPromptLabel.TabIndex = 3;
            this.laborCostPromptLabel.Text = "Cost of Labor:";
            // 
            // laborHrsReqPromptLabel
            // 
            this.laborHrsReqPromptLabel.AutoSize = true;
            this.laborHrsReqPromptLabel.Location = new System.Drawing.Point(31, 78);
            this.laborHrsReqPromptLabel.Name = "laborHrsReqPromptLabel";
            this.laborHrsReqPromptLabel.Size = new System.Drawing.Size(114, 13);
            this.laborHrsReqPromptLabel.TabIndex = 2;
            this.laborHrsReqPromptLabel.Text = "Labor Hours Required:";
            // 
            // gallonsReqPromptLabel
            // 
            this.gallonsReqPromptLabel.AutoSize = true;
            this.gallonsReqPromptLabel.Location = new System.Drawing.Point(15, 45);
            this.gallonsReqPromptLabel.Name = "gallonsReqPromptLabel";
            this.gallonsReqPromptLabel.Size = new System.Drawing.Size(130, 13);
            this.gallonsReqPromptLabel.TabIndex = 1;
            this.gallonsReqPromptLabel.Text = "Gallons of Paint Required:";
            // 
            // totalSqFeetPromptLabel
            // 
            this.totalSqFeetPromptLabel.AutoSize = true;
            this.totalSqFeetPromptLabel.Location = new System.Drawing.Point(3, 13);
            this.totalSqFeetPromptLabel.Name = "totalSqFeetPromptLabel";
            this.totalSqFeetPromptLabel.Size = new System.Drawing.Size(142, 13);
            this.totalSqFeetPromptLabel.TabIndex = 0;
            this.totalSqFeetPromptLabel.Text = "Total Sq. Feet to be painted:";
            // 
            // calcOrderButton
            // 
            this.calcOrderButton.Location = new System.Drawing.Point(113, 427);
            this.calcOrderButton.Name = "calcOrderButton";
            this.calcOrderButton.Size = new System.Drawing.Size(75, 41);
            this.calcOrderButton.TabIndex = 0;
            this.calcOrderButton.Text = "Calculate Order";
            this.calcOrderButton.UseVisualStyleBackColor = true;
            this.calcOrderButton.Click += new System.EventHandler(this.calcOrderButton_Click);
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostLabel.Location = new System.Drawing.Point(151, 181);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(100, 23);
            this.totalCostLabel.TabIndex = 8;
            this.totalCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalCostPromptLabel
            // 
            this.totalCostPromptLabel.AutoSize = true;
            this.totalCostPromptLabel.Location = new System.Drawing.Point(87, 182);
            this.totalCostPromptLabel.Name = "totalCostPromptLabel";
            this.totalCostPromptLabel.Size = new System.Drawing.Size(58, 13);
            this.totalCostPromptLabel.TabIndex = 9;
            this.totalCostPromptLabel.Text = "Total Cost:";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(211, 427);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 41);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.calcOrderButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 493);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcOrderButton);
            this.Controls.Add(this.outputPanel);
            this.Controls.Add(this.inputPanel);
            this.Name = "Form1";
            this.Text = "Program 1";
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.outputPanel.ResumeLayout(false);
            this.outputPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label enterSqFeetPromptLabel;
        private System.Windows.Forms.Label enterCoatsOfPaintPromptLabel;
        private System.Windows.Forms.Label paintPricePerGalPromptLabel;
        private System.Windows.Forms.TextBox paintPricePerGalTextBox;
        private System.Windows.Forms.TextBox coatsOfPaintTextBox;
        private System.Windows.Forms.TextBox sqFeetTextBox;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Label inputInstructionsLabel;
        private System.Windows.Forms.Panel outputPanel;
        private System.Windows.Forms.Label gallonsReqPromptLabel;
        private System.Windows.Forms.Label totalSqFeetPromptLabel;
        private System.Windows.Forms.Label paintCostPromptLabel;
        private System.Windows.Forms.Label laborCostPromptLabel;
        private System.Windows.Forms.Label laborHrsReqPromptLabel;
        private System.Windows.Forms.Label totalSqFeetLabel;
        private System.Windows.Forms.Label gallonsReqLabel;
        private System.Windows.Forms.Label laborHrsReqLabel;
        private System.Windows.Forms.Label paintCostLabel;
        private System.Windows.Forms.Label laborCostLabel;
        private System.Windows.Forms.Button calcOrderButton;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label totalCostPromptLabel;
        private System.Windows.Forms.Button clearButton;
    }
}

