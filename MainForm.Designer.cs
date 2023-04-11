namespace Poznamkovnik
{
    partial class MainForm
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
            this.notesListBox = new System.Windows.Forms.ListBox();
            this.newNoteButton = new System.Windows.Forms.Button();
            this.EditNoteButton = new System.Windows.Forms.Button();
            this.RemoveNoteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notesListBox
            // 
            this.notesListBox.FormattingEnabled = true;
            this.notesListBox.Location = new System.Drawing.Point(12, 12);
            this.notesListBox.Name = "notesListBox";
            this.notesListBox.Size = new System.Drawing.Size(474, 303);
            this.notesListBox.TabIndex = 0;
            // 
            // newNoteButton
            // 
            this.newNoteButton.Location = new System.Drawing.Point(12, 333);
            this.newNoteButton.Name = "newNoteButton";
            this.newNoteButton.Size = new System.Drawing.Size(130, 38);
            this.newNoteButton.TabIndex = 1;
            this.newNoteButton.Text = "Přidat poznámku";
            this.newNoteButton.UseVisualStyleBackColor = true;
            this.newNoteButton.Click += new System.EventHandler(this.NewNoteButton_Click);
            // 
            // EditNoteButton
            // 
            this.EditNoteButton.Location = new System.Drawing.Point(186, 333);
            this.EditNoteButton.Name = "EditNoteButton";
            this.EditNoteButton.Size = new System.Drawing.Size(130, 38);
            this.EditNoteButton.TabIndex = 2;
            this.EditNoteButton.Text = "Upravit poznámku";
            this.EditNoteButton.UseVisualStyleBackColor = true;
            this.EditNoteButton.Click += new System.EventHandler(this.EditNoteButton_Click);
            // 
            // RemoveNoteButton
            // 
            this.RemoveNoteButton.Location = new System.Drawing.Point(356, 333);
            this.RemoveNoteButton.Name = "RemoveNoteButton";
            this.RemoveNoteButton.Size = new System.Drawing.Size(130, 38);
            this.RemoveNoteButton.TabIndex = 3;
            this.RemoveNoteButton.Text = "Odstranit poznámku";
            this.RemoveNoteButton.UseVisualStyleBackColor = true;
            this.RemoveNoteButton.Click += new System.EventHandler(this.RemoveNoteButton_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(500, 383);
            this.Controls.Add(this.RemoveNoteButton);
            this.Controls.Add(this.EditNoteButton);
            this.Controls.Add(this.newNoteButton);
            this.Controls.Add(this.notesListBox);
            this.Name = "MainForm";
            this.Text = "Poznámkovník";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox notesListBox;
        private System.Windows.Forms.Button newNoteButton;
        private System.Windows.Forms.Button EditNoteButton;
        private System.Windows.Forms.Button RemoveNoteButton;
    }
}

