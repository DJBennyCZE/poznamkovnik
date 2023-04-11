using System;
using System.Windows.Forms;

namespace Poznamkovnik
{
    public partial class NoteForm : Form
    {
        private string note; // text poznámky
        private TextBox noteTextBox;
        private Button SaveButton;
        private Data data; // instance třídy Data pro ukládání a načítání poznámek

        public NoteForm(string note, Data data)
        {
            InitializeComponent();
            this.note = note;
            this.data = data;
            noteTextBox.Text = note;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // uložení úpravené poznámky a zavření okna
            data.UpdateNote(note, noteTextBox.Text);
            DialogResult = DialogResult.OK;
        }

        private void InitializeComponent()
        {
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(12, 12);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(306, 237);
            this.noteTextBox.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(92, 266);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(130, 38);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Uložit poznámku";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NoteForm
            // 
            this.ClientSize = new System.Drawing.Size(330, 315);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.noteTextBox);
            this.Name = "NoteForm";
            this.Text = "Detail poznámky";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}