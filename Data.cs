using System;
using System.Collections.Generic;
using System.IO;

namespace Poznamkovnik
{
    public class Data
    {
        private string fileName = "notes.txt"; // název souboru pro ukládání poznámek

        public List<string> LoadNotes()
        {
            // načtení seznamu poznámek ze souboru a nahrazení řádkových zlomů mezerou
            List<string> notes = new List<string>();
            if (File.Exists(fileName))
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        notes.Add(line.Replace(Environment.NewLine, " "));
                    }
                }
            }
            return notes;
        }

        public void AddNote(string note)
        {
            // přidání nové poznámky do souboru
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine(note);
            }
        }

        public void UpdateNote(string oldNote, string newNote)
        {
            // nahrazení staré poznámky novou poznámkou v souboru
            List<string> notes = LoadNotes();
            notes[notes.IndexOf(oldNote)] = newNote;
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (string note in notes)
                {
                    writer.WriteLine(note);
                }
            }
        }

        public void RemoveNote(string note)
        {
            // odstranění poznámky ze souboru
            List<string> notes = LoadNotes();
            notes.Remove(note);
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (string n in notes)
                {
                    writer.WriteLine(n);
                }
            }
        }
    }
}