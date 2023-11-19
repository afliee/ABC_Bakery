using Color = System.Drawing.Color;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SizeF = System.Drawing.SizeF;

namespace ABC_Bakery.Helpers.UI
{
    partial class FormMessageBox
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
            panelTitleBar = new Panel();
            labelCaption = new Label();
            btnClose = new Button();
            panelButtons = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelBody = new Panel();
            labelMessage = new Label();
            pictureBoxIcon = new PictureBox();
            panelTitleBar.SuspendLayout();
            panelButtons.SuspendLayout();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            SuspendLayout();
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.CornflowerBlue;
            panelTitleBar.Controls.Add(labelCaption);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(2, 2);
            panelTitleBar.Margin = new Padding(4, 3, 4, 3);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(404, 40);
            panelTitleBar.TabIndex = 0;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // labelCaption
            // 
            labelCaption.AutoSize = true;
            labelCaption.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelCaption.ForeColor = Color.White;
            labelCaption.Location = new Point(10, 9);
            labelCaption.Margin = new Padding(4, 0, 4, 0);
            labelCaption.Name = "labelCaption";
            labelCaption.Size = new Size(86, 17);
            labelCaption.TabIndex = 4;
            labelCaption.Text = "labelCaption";
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 79, 95);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(357, 0);
            btnClose.Margin = new Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(47, 40);
            btnClose.TabIndex = 3;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(235, 235, 235);
            panelButtons.Controls.Add(button3);
            panelButtons.Controls.Add(button2);
            panelButtons.Controls.Add(button1);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(2, 102);
            panelButtons.Margin = new Padding(4, 3, 4, 3);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(404, 69);
            panelButtons.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.SeaGreen;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.WhiteSmoke;
            button3.Location = new Point(270, 14);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(117, 40);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.SeaGreen;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(146, 14);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(117, 40);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(22, 14);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(117, 40);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // panelBody
            // 
            panelBody.BackColor = Color.WhiteSmoke;
            panelBody.Controls.Add(labelMessage);
            panelBody.Controls.Add(pictureBoxIcon);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(2, 42);
            panelBody.Margin = new Padding(4, 3, 4, 3);
            panelBody.Name = "panelBody";
            panelBody.Padding = new Padding(12, 12, 0, 0);
            panelBody.Size = new Size(404, 60);
            panelBody.TabIndex = 2;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Dock = DockStyle.Fill;
            labelMessage.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelMessage.ForeColor = Color.FromArgb(85, 85, 85);
            labelMessage.Location = new Point(59, 12);
            labelMessage.Margin = new Padding(4, 0, 4, 0);
            labelMessage.MaximumSize = new Size(700, 0);
            labelMessage.Name = "labelMessage";
            labelMessage.Padding = new Padding(6, 6, 12, 17);
            labelMessage.Size = new Size(113, 40);
            labelMessage.TabIndex = 1;
            labelMessage.Text = "labelMessage";
            labelMessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Dock = DockStyle.Left;
            pictureBoxIcon.Image = Properties.Resources.chat;
            pictureBoxIcon.Location = new Point(12, 12);
            pictureBoxIcon.Margin = new Padding(4, 3, 4, 3);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(47, 48);
            pictureBoxIcon.TabIndex = 0;
            pictureBoxIcon.TabStop = false;
            // 
            // FormMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(408, 173);
            Controls.Add(panelBody);
            Controls.Add(panelButtons);
            Controls.Add(panelTitleBar);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(406, 167);
            Name = "FormMessageBox";
            Padding = new Padding(2);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelButtons.ResumeLayout(false);
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitleBar;
        private Panel panelButtons;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button btnClose;
        private Panel panelBody;
        private Label labelMessage;
        private PictureBox pictureBoxIcon;
        private Label labelCaption;
    }
}