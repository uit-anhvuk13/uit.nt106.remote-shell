﻿namespace remote_shell
{
    partial class ClientInboxWindow
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
            this.btnClear = new System.Windows.Forms.Button();
            this.clientInboxInput = new System.Windows.Forms.TextBox();
            this.clientInbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(512, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 26);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // clientInboxInput
            // 
            this.clientInboxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientInboxInput.Location = new System.Drawing.Point(12, 12);
            this.clientInboxInput.Name = "clientInboxInput";
            this.clientInboxInput.Size = new System.Drawing.Size(494, 26);
            this.clientInboxInput.TabIndex = 2;
            this.clientInboxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clientInboxInput_KeyDown);
            // 
            // clientInbox
            // 
            this.clientInbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientInbox.Location = new System.Drawing.Point(12, 44);
            this.clientInbox.Name = "clientInbox";
            this.clientInbox.ReadOnly = true;
            this.clientInbox.Size = new System.Drawing.Size(560, 505);
            this.clientInbox.TabIndex = 4;
            this.clientInbox.TabStop = false;
            this.clientInbox.Text = "";
            // 
            // ClientInboxWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.clientInboxInput);
            this.Controls.Add(this.clientInbox);
            this.Name = "ClientInboxWindow";
            this.Text = "ClientInboxWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientInboxWindow_FormClosing);
            this.Shown += new System.EventHandler(this.ClientInboxWindow_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox clientInboxInput;
        private System.Windows.Forms.RichTextBox clientInbox;
    }
}