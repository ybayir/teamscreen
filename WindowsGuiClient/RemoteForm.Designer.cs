﻿namespace WindowsGuiClient
{
    partial class RemoteForm
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
            this.drawingArea1 = new WindowsGuiClient.Controls.DrawingArea();
            this.SuspendLayout();
            // 
            // drawingArea1
            // 
            this.drawingArea1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingArea1.Location = new System.Drawing.Point(0, 0);
            this.drawingArea1.Name = "drawingArea1";
            this.drawingArea1.Size = new System.Drawing.Size(654, 270);
            this.drawingArea1.TabIndex = 0;
            this.drawingArea1.Text = "drawingArea1";
            // 
            // RemoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 270);
            this.Controls.Add(this.drawingArea1);
            this.Name = "RemoteForm";
            this.Text = "RemoteForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.DrawingArea drawingArea1;
    }
}