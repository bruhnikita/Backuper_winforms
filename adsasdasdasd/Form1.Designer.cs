using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BackupUtil_Winfoms
{
    partial class BackupForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            RollBackButton = new Button();
            CreateBackupButton = new Button();
            sourcePathTextBox = new TextBox();
            destinationPathTextBox = new TextBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(destinationPathTextBox);
            panel1.Controls.Add(sourcePathTextBox);
            panel1.Controls.Add(CreateBackupButton);
            panel1.Controls.Add(RollBackButton);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(777, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 605);
            panel1.TabIndex = 0;
            // 
            // RollBackButton
            // 
            RollBackButton.Dock = DockStyle.Bottom;
            RollBackButton.Location = new Point(0, 544);
            RollBackButton.Name = "RollBackButton";
            RollBackButton.Size = new Size(292, 61);
            RollBackButton.TabIndex = 0;
            RollBackButton.Text = "Откатиться до резервной копии";
            RollBackButton.UseVisualStyleBackColor = true;
            RollBackButton.Click += RollBackButton_Click;
            // 
            // CreateBackupButton
            // 
            CreateBackupButton.Dock = DockStyle.Bottom;
            CreateBackupButton.Location = new Point(0, 483);
            CreateBackupButton.Name = "CreateBackupButton";
            CreateBackupButton.Size = new Size(292, 61);
            CreateBackupButton.TabIndex = 2;
            CreateBackupButton.Text = "Создать резервную копию";
            CreateBackupButton.UseVisualStyleBackColor = true;
            CreateBackupButton.Click += CreateBackupButton_Click;
            // 
            // sourcePathTextBox
            // 
            sourcePathTextBox.Dock = DockStyle.Top;
            sourcePathTextBox.Location = new Point(0, 0);
            sourcePathTextBox.Name = "sourcePathTextBox";
            sourcePathTextBox.PlaceholderText = "Путь к файлу для резервного копирования";
            sourcePathTextBox.Size = new Size(292, 23);
            sourcePathTextBox.TabIndex = 3;
            // 
            // destinationPathTextBox
            // 
            destinationPathTextBox.Dock = DockStyle.Top;
            destinationPathTextBox.Location = new Point(0, 23);
            destinationPathTextBox.Name = "destinationPathTextBox";
            destinationPathTextBox.PlaceholderText = "Путь для сохранения копии";
            destinationPathTextBox.Size = new Size(292, 23);
            destinationPathTextBox.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(777, 605);
            textBox1.TabIndex = 1;
            // 
            // BackupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 605);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Name = "BackupForm";
            Text = "Резервное копирование";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button CreateBackupButton;
        private Button RollBackButton;
        private TextBox destinationPathTextBox;
        private TextBox sourcePathTextBox;
        private TextBox textBox1;
    }
}
