using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Poznamkovnik
{
    public partial class MainForm : Form
    {
        private Data data; // instance třídy Data pro ukládání a načítání poznámek

        public MainForm()
        {
            InitializeComponent();
            data = new Data(); // inicializace instance třídy Data
            LoadNotes(); // načtení poznámek ze souboru při startu aplikace
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // zafixování velikosti okna
        }

        private void LoadNotes()
        {
            // načtení seznamu poznámek ze souboru a zobrazení v ListBoxu
            List<string> notes = data.LoadNotes();
            notesListBox.Items.Clear();
            notesListBox.Items.AddRange(notes.ToArray());
        }

        public void EditNote()
        {
            // otevření okna pro úpravu vybrané poznámky
            if (notesListBox.SelectedIndex != -1)
            {
                string selectedNote = notesListBox.SelectedItem.ToString();
                using (var form = new NoteForm(selectedNote, data))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        LoadNotes();
                    }
                }
            }
        }

        private void NewNoteButton_Click(object sender, EventArgs e)
        {
            // vytvoření nové poznámky a přidání do seznamu
            string newNote = "Nová poznámka";
            data.AddNote(newNote);
            notesListBox.Items.Add(newNote);
        }

        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            // otevření okna pro úpravu vybrané poznámky
            if (notesListBox.SelectedIndex != -1)
            {
                string selectedNote = notesListBox.SelectedItem.ToString();
                using (var form = new NoteForm(selectedNote, data))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        LoadNotes();
                    }
                }
            }
        }

        private void RemoveNoteButton_Click(object sender, EventArgs e)
        {
            // odstranění vybrané poznámky ze seznamu a ze souboru
            if (notesListBox.SelectedIndex != -1)
            {
                string selectedNote = notesListBox.SelectedItem.ToString();
                data.RemoveNote(selectedNote);
                notesListBox.Items.Remove(selectedNote);
            }
        }
    }
}