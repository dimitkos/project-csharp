﻿namespace CostaNavarino
{
    partial class GolfForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GolfForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.exportbutton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(442, 118);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(308, 230);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // exportbutton
            // 
            this.exportbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exportbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.exportbutton.Location = new System.Drawing.Point(524, 391);
            this.exportbutton.Name = "exportbutton";
            this.exportbutton.Size = new System.Drawing.Size(87, 23);
            this.exportbutton.TabIndex = 2;
            this.exportbutton.Text = "Αποθήκευση";
            this.exportbutton.UseVisualStyleBackColor = true;
            this.exportbutton.Click += new System.EventHandler(this.exportbutton_Click);
            this.exportbutton.MouseHover += new System.EventHandler(this.exportbutton_MouseHover);
            // 
            // GolfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exportbutton);
            this.Controls.Add(this.richTextBox1);
            this.Name = "GolfForm";
            this.Text = "GolfForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GolfForm_FormClosing);
            this.Load += new System.EventHandler(this.GolfForm_Load);
            this.Controls.SetChildIndex(this.richTextBox1, 0);
            this.Controls.SetChildIndex(this.exportbutton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button exportbutton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}