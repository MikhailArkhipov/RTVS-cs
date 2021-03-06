﻿namespace ApiTest {
    partial class RHostApiTestForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.codeBox = new System.Windows.Forms.TextBox();
            this.executeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.plotButton = new System.Windows.Forms.Button();
            this.getDataframeButton = new System.Windows.Forms.Button();
            this.getListButton = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // codeBox
            // 
            this.codeBox.Location = new System.Drawing.Point(58, 14);
            this.codeBox.Multiline = true;
            this.codeBox.Name = "codeBox";
            this.codeBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.codeBox.Size = new System.Drawing.Size(611, 144);
            this.codeBox.TabIndex = 0;
            // 
            // executeButton
            // 
            this.executeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.executeButton.Location = new System.Drawing.Point(686, 15);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(95, 23);
            this.executeButton.TabIndex = 1;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "R code";
            // 
            // plotButton
            // 
            this.plotButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.plotButton.Location = new System.Drawing.Point(686, 55);
            this.plotButton.Name = "plotButton";
            this.plotButton.Size = new System.Drawing.Size(95, 23);
            this.plotButton.TabIndex = 4;
            this.plotButton.Text = "Plot";
            this.plotButton.UseVisualStyleBackColor = true;
            this.plotButton.Click += new System.EventHandler(this.plotButton_Click);
            // 
            // getDataframeButton
            // 
            this.getDataframeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getDataframeButton.Location = new System.Drawing.Point(686, 96);
            this.getDataframeButton.Name = "getDataframeButton";
            this.getDataframeButton.Size = new System.Drawing.Size(95, 23);
            this.getDataframeButton.TabIndex = 5;
            this.getDataframeButton.Text = "Get Dataframe";
            this.getDataframeButton.UseVisualStyleBackColor = true;
            this.getDataframeButton.Click += new System.EventHandler(this.getDataframe_Click);
            // 
            // getListButton
            // 
            this.getListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getListButton.Location = new System.Drawing.Point(686, 135);
            this.getListButton.Name = "getListButton";
            this.getListButton.Size = new System.Drawing.Size(95, 23);
            this.getListButton.TabIndex = 6;
            this.getListButton.Text = "Get List";
            this.getListButton.UseVisualStyleBackColor = true;
            this.getListButton.Click += new System.EventHandler(this.getListButton_Click);
            // 
            // resultBox
            // 
            this.resultBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultBox.Location = new System.Drawing.Point(58, 164);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(611, 365);
            this.resultBox.TabIndex = 7;
            this.resultBox.TabStop = false;
            this.resultBox.Text = "Result";
            // 
            // RHostApiTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 561);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.getListButton);
            this.Controls.Add(this.getDataframeButton);
            this.Controls.Add(this.plotButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.codeBox);
            this.Name = "RHostApiTestForm";
            this.Text = "R API Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button plotButton;
        private System.Windows.Forms.Button getDataframeButton;
        private System.Windows.Forms.Button getListButton;
        private System.Windows.Forms.GroupBox resultBox;
    }
}

