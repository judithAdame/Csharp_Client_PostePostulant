using Client_PosteCandidate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_PostePostulant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonGetAll.Enabled = true;
            buttonLangages.Enabled = false;
            buttonChercherPostes.Enabled = false;
        }
         
        private void ButtonGetAll_Click(object sender, EventArgs e)
        {
            int i = 0;
            comboBoxGetAll.Items.Clear();
            CheckedListBoxLangages.Items.Clear();
            dataGridViewMatches.Rows.Clear();
            List<Candidate>.Enumerator liste = ClientCandidate.CallGetAll().GetEnumerator();
            ComboBoxItem item = null;
            while(liste.MoveNext())
            {
                item = new ComboBoxItem
                {
                    Text = liste.Current.ToString(),
                    Value = liste.Current.Id,
                    Langage = liste.Current.Langages
                };
                comboBoxGetAll.Items.Add(item);
                i++;
            }
            if (i >= 1) { 
                buttonLangages.Enabled = true;
                buttonChercherPostes.Enabled = false;
            }
            comboBoxGetAll.SelectedIndex = 0;
        }

        private void ButtonLangages_Click(object sender, EventArgs e)
        {
            CheckedListBoxLangages.Items.Clear();
            dataGridViewMatches.Rows.Clear();
            List<string> liste = ((comboBoxGetAll.SelectedItem as ComboBoxItem).Langage).Split(',').ToList();
            foreach (string item in liste)
            {
                CheckedListBoxLangages.Items.Add(item);
            }
            if (liste.First().Equals(""))
            {
                buttonLangages.Enabled = false;
                buttonChercherPostes.Enabled = false;
            }
            else{
                buttonLangages.Enabled = true;
                buttonChercherPostes.Enabled = true;

            }
        }

        private void ButtonChercherPostes_Click(object sender, EventArgs e)
        {
            dataGridViewMatches.Rows.Clear();
            string lPostulant = "";
            int i=1;
            int nbMatch = 0;
           foreach (object itemChecked in CheckedListBoxLangages.CheckedItems)
            {
                lPostulant += itemChecked.ToString().Trim();
                nbMatch = CheckedListBoxLangages.CheckedItems.Count;
                if (i!= nbMatch)
                    lPostulant += ",";
                i++;
            }
            dataGridViewMatches.ColumnCount = 4;
            dataGridViewMatches.Columns[0].Name = "Id";
            dataGridViewMatches.Columns[1].Name = "Poste";
            dataGridViewMatches.Columns[2].Name = "Langages";
            dataGridViewMatches.Columns[3].Name = "Courriel";
            List<Job>.Enumerator liste = ClientJob.CallGetJobByLangages(nbMatch, lPostulant).GetEnumerator();
            while (liste.MoveNext())
            {
                dataGridViewMatches.Rows.Add(liste.Current.Id, liste.Current.Nom, liste.Current.Langages);
            }
        }

        private void CheckedListBoxLangages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
