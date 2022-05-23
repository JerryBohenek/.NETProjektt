using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace Projekt
{
    public partial class Form1 : Form
    {
        ProjektEntities pe = new ProjektEntities(); //ENTITY
        public Form1()
        {
            InitializeComponent();
            Reload();
        }

        //Przyciski
        private void AddRecordButton_Click(object sender, EventArgs e) { AddRecord(textBoxName.Text, textBoxSurname.Text, dateTimePicker.Value.ToShortDateString(), textBoxEmail.Text, textBoxPhone.Text); }
        private void AddRecordTool_Click(object sender, EventArgs e) { AddRecord(textBoxName.Text, textBoxSurname.Text, dateTimePicker.Value.ToShortDateString(), textBoxEmail.Text, textBoxPhone.Text); }
        private void DeleteRecordButton_Click(object sender, EventArgs e) { DeleteRecord(); }
        private void DeleteRekordTool_Click(object sender, EventArgs e) { DeleteRecord(); }
        private void DeleteAllTool_Click(object sender, EventArgs e) { DeleteAll(); }
        private void RefreshListButton_Click(object sender, EventArgs e) { Reload(); }
        private void RefreshListTool_Click(object sender, EventArgs e) { Reload(); }
        private void SaveAsXMLButton_Click(object sender, EventArgs e) { SaveAsXML(); }
        private void SaveAsXMLTool_Click(object sender, EventArgs e) { SaveAsXML(); }
        private void ExitButton_Click(object sender, System.EventArgs e) { Exit(); }
        private void ExitTool_Click(object sender, EventArgs e) { Exit(); }

        //Pola tekstowe
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            Reload();
            SearchToolTextBox.Text = "Wpisz tutaj...";
            if (SearchTextBox.Text == "")
            {
                Reload();
            }
            else
            {
                List<ProjektData> list = pe.ProjektDatas.Where(t => t.Name.Contains(SearchTextBox.Text) ||
                                      t.Surname.Contains(SearchTextBox.Text) ||
                                      t.PhoneNumber.Contains(SearchTextBox.Text)).ToList();
                Refresh(list);
            }
        }
        private void SearchToolTextBox_TextChanged(object sender, EventArgs e)
        {
            Reload();
            SearchTextBox.Clear();
            if (SearchToolTextBox.Text == "")
            {
                Reload();
            }
            else
            {
                List<ProjektData> list = pe.ProjektDatas.Where(t => t.Name.Contains(SearchToolTextBox.Text) ||
                                      t.Surname.Contains(SearchToolTextBox.Text) ||
                                      t.PhoneNumber.Contains(SearchToolTextBox.Text)).ToList();
                Refresh(list);
            }
        }
        private void SearchToolTextBox_Click(object sender, EventArgs e)
        {
            if (SearchToolTextBox.Text == "Wpisz tutaj...")
            {
                SearchToolTextBox.Clear();
            }
        }
        private void wyszukajToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            if (SearchToolTextBox.Text == "")
            {
                SearchToolTextBox.Text = "Wpisz tutaj...";
            }
        }

        //Dodawanie rekordu
        private void AddRecord(string name, string surname, string birthDate, string email, string phone)
        {
            ProjektData data = new ProjektData();
            if(textBoxName.Text == "" || textBoxSurname.Text == "")
            {
                MessageBox.Show("Uzupelnij imie oraz nazwisko!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                data.Name = name;
                data.Surname = surname;
                data.BirthDate = birthDate;
                data.PhoneNumber = email;
                data.EmailAdress = phone;
                pe.ProjektDatas.Add(data);
                pe.SaveChanges();
            }
            textBoxName.Text = "";
            textBoxSurname.Text = "";
            textBoxEmail.Text = "";
            textBoxPhone.Text = "";
            Reload();
        }

        //Usuwanie rekordu
        private void DeleteRecord()
        {     
            if (personalDataList.SelectedItems.Count != 0)
            {
                string name = personalDataList.SelectedItems[0].SubItems[1].Text;
                string surname = personalDataList.SelectedItems[0].SubItems[2].Text;
                string birthDate = personalDataList.SelectedItems[0].SubItems[3].Text;
                string email = personalDataList.SelectedItems[0].SubItems[4].Text;
                string phone = personalDataList.SelectedItems[0].SubItems[5].Text;
                try
                {
                    pe.Database.ExecuteSqlCommand("DELETE FROM ProjektData WHERE Name = '" + name 
                                                                     + "' AND Surname = '" + surname 
                                                                     + "' AND BirthDate = '" + birthDate 
                                                                     + "' AND EmailAdress = '" + email 
                                                                     + "' AND PhoneNumber = '" + phone 
                                                                     + "'");
                    pe.SaveChanges();
                    personalDataList.Items.Remove(personalDataList.SelectedItems[0]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                for (int i = 0; i < personalDataList.Items.Count; i++)
                {
                    personalDataList.Items[i].Text = (i+1).ToString();
                }
                MessageBox.Show("Usunales wybrany element.", "Usun rekord", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nie znaznaczyles zadnej opcji!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        //Czyszczenie bazy danych
        private void DeleteAll()
        {
            if (MessageBox.Show("Aby kontynuowac nalezy zrestartowac aplikacje. Czy kontynuowac?", "Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pe.Database.ExecuteSqlCommand("DELETE FROM ProjektData");
                pe.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('ProjektData', RESEED, 0)");
                Application.Restart();
            }
        }

        //Przeladowanie
        private void Reload()
        {
            int i = 1;
            personalDataList.Items.Clear();
            List<ProjektData> list = pe.ProjektDatas.ToList(); //LinQ
            foreach (ProjektData data in list)
            {
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(data.Name);
                item.SubItems.Add(data.Surname);
                item.SubItems.Add(data.BirthDate);
                item.SubItems.Add(data.EmailAdress);
                item.SubItems.Add(data.PhoneNumber);
                personalDataList.Items.Add(item);
                i++;
            }
        }

        //Odswiezanie
        private void Refresh(List<ProjektData> list)
        {
            int i = 1;
            personalDataList.Items.Clear();
            foreach (ProjektData data in list)
            {
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(data.Name);
                item.SubItems.Add(data.Surname);
                item.SubItems.Add(data.BirthDate);
                item.SubItems.Add(data.EmailAdress);
                item.SubItems.Add(data.PhoneNumber);
                personalDataList.Items.Add(item);
                i++;
            }
        }

        //Zapisz jako XML
        private void SaveAsXML()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Projekt;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM ProjektData";

            DataTable table = new DataTable("PersonalData");

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);

            table.WriteXml("PersonalData.xml");
            table.WriteXmlSchema("PersonalDataSchema.xsd");

            MessageBox.Show("Zapisano dane do pliku XML.", "Zapisz jako XML", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Wyjscie
        private void Exit()
        {
            if (MessageBox.Show("Czy na pewno chcesz wyjsc?", "Wyjscie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
