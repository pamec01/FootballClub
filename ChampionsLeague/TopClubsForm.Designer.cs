﻿namespace ChampionsLeague
{
    partial class TopClubsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbPocetGolu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbKluby = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Počet gólů:";
            // 
            // tbPocetGolu
            // 
            this.tbPocetGolu.Location = new System.Drawing.Point(89, 6);
            this.tbPocetGolu.Name = "tbPocetGolu";
            this.tbPocetGolu.Size = new System.Drawing.Size(100, 23);
            this.tbPocetGolu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nejlepší kluby:";
            // 
            // lbKluby
            // 
            this.lbKluby.FormattingEnabled = true;
            this.lbKluby.ItemHeight = 15;
            this.lbKluby.Location = new System.Drawing.Point(12, 51);
            this.lbKluby.Name = "lbKluby";
            this.lbKluby.Size = new System.Drawing.Size(177, 94);
            this.lbKluby.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnOkAction);
            // 
            // TopClubsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 234);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbKluby);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPocetGolu);
            this.Controls.Add(this.label1);
            this.Name = "TopClubsForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbPocetGolu;
        private Label label2;
        private ListBox lbKluby;
        private Button button1;
    }
}