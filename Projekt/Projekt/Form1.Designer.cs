namespace Projekt
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.personalDataList = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PersonName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.PlikTool = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRecordTool = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshListTool = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteRekordTool = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsXMLTool = new System.Windows.Forms.ToolStripMenuItem();
            this.wyszukajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchToolTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.ExitTool = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddRecordButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RefreshListButton = new System.Windows.Forms.Button();
            this.DeleteRecordButton = new System.Windows.Forms.Button();
            this.SaveAsXMLButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.userControl11 = new Zegar.UserControl1();
            this.label8 = new System.Windows.Forms.Label();
            this.DeleteAllTool = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // personalDataList
            // 
            this.personalDataList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.PersonName,
            this.Surname,
            this.BirthDate,
            this.Email,
            this.PhoneNumber});
            this.personalDataList.HideSelection = false;
            this.personalDataList.Location = new System.Drawing.Point(235, 38);
            this.personalDataList.Name = "personalDataList";
            this.personalDataList.Size = new System.Drawing.Size(635, 459);
            this.personalDataList.TabIndex = 0;
            this.personalDataList.UseCompatibleStateImageBehavior = false;
            this.personalDataList.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 30;
            // 
            // PersonName
            // 
            this.PersonName.Text = "Name";
            this.PersonName.Width = 140;
            // 
            // Surname
            // 
            this.Surname.Text = "Surname";
            this.Surname.Width = 140;
            // 
            // BirthDate
            // 
            this.BirthDate.Text = "Birth Date";
            this.BirthDate.Width = 80;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 120;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Text = "PhoneNumber";
            this.PhoneNumber.Width = 120;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlikTool,
            this.wyszukajToolStripMenuItem,
            this.ExitTool});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // PlikTool
            // 
            this.PlikTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddRecordTool,
            this.RefreshListTool,
            this.DeleteRekordTool,
            this.DeleteAllTool,
            this.SaveAsXMLTool});
            this.PlikTool.Name = "PlikTool";
            this.PlikTool.Size = new System.Drawing.Size(38, 20);
            this.PlikTool.Text = "Plik";
            // 
            // AddRecordTool
            // 
            this.AddRecordTool.Name = "AddRecordTool";
            this.AddRecordTool.Size = new System.Drawing.Size(185, 22);
            this.AddRecordTool.Text = "Dodaj rekord";
            this.AddRecordTool.Click += new System.EventHandler(this.AddRecordTool_Click);
            // 
            // RefreshListTool
            // 
            this.RefreshListTool.Name = "RefreshListTool";
            this.RefreshListTool.Size = new System.Drawing.Size(185, 22);
            this.RefreshListTool.Text = "Odśwież listę";
            this.RefreshListTool.Click += new System.EventHandler(this.RefreshListTool_Click);
            // 
            // DeleteRekordTool
            // 
            this.DeleteRekordTool.Name = "DeleteRekordTool";
            this.DeleteRekordTool.Size = new System.Drawing.Size(185, 22);
            this.DeleteRekordTool.Text = "Usuń rekordy";
            this.DeleteRekordTool.Click += new System.EventHandler(this.DeleteRekordTool_Click);
            // 
            // SaveAsXMLTool
            // 
            this.SaveAsXMLTool.Name = "SaveAsXMLTool";
            this.SaveAsXMLTool.Size = new System.Drawing.Size(185, 22);
            this.SaveAsXMLTool.Text = "Zapisz jako XML";
            this.SaveAsXMLTool.Click += new System.EventHandler(this.SaveAsXMLTool_Click);
            // 
            // wyszukajToolStripMenuItem
            // 
            this.wyszukajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchToolTextBox});
            this.wyszukajToolStripMenuItem.Name = "wyszukajToolStripMenuItem";
            this.wyszukajToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.wyszukajToolStripMenuItem.Text = "Wyszukaj";
            this.wyszukajToolStripMenuItem.DropDownClosed += new System.EventHandler(this.wyszukajToolStripMenuItem_DropDownClosed);
            // 
            // SearchToolTextBox
            // 
            this.SearchToolTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchToolTextBox.Name = "SearchToolTextBox";
            this.SearchToolTextBox.Size = new System.Drawing.Size(100, 23);
            this.SearchToolTextBox.Text = "Wpisz tutaj...";
            this.SearchToolTextBox.Click += new System.EventHandler(this.SearchToolTextBox_Click);
            this.SearchToolTextBox.TextChanged += new System.EventHandler(this.SearchToolTextBox_TextChanged);
            // 
            // ExitTool
            // 
            this.ExitTool.Name = "ExitTool";
            this.ExitTool.Size = new System.Drawing.Size(59, 20);
            this.ExitTool.Text = "Wyjście";
            this.ExitTool.Click += new System.EventHandler(this.ExitTool_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Imię";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(15, 58);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(214, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(15, 101);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(214, 20);
            this.textBoxSurname.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Urodziny";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(15, 144);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(214, 20);
            this.dateTimePicker.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(15, 187);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(214, 20);
            this.textBoxEmail.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Adres email";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(15, 230);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(214, 20);
            this.textBoxPhone.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Numer telefonu";
            // 
            // AddRecordButton
            // 
            this.AddRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddRecordButton.Location = new System.Drawing.Point(15, 256);
            this.AddRecordButton.Name = "AddRecordButton";
            this.AddRecordButton.Size = new System.Drawing.Size(214, 40);
            this.AddRecordButton.TabIndex = 13;
            this.AddRecordButton.Text = "Dodaj rekord";
            this.AddRecordButton.UseVisualStyleBackColor = true;
            this.AddRecordButton.Click += new System.EventHandler(this.AddRecordButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(15, 319);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(214, 20);
            this.SearchTextBox.TabIndex = 15;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Wyszukaj rekord";
            // 
            // RefreshListButton
            // 
            this.RefreshListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RefreshListButton.Location = new System.Drawing.Point(15, 345);
            this.RefreshListButton.Name = "RefreshListButton";
            this.RefreshListButton.Size = new System.Drawing.Size(214, 40);
            this.RefreshListButton.TabIndex = 16;
            this.RefreshListButton.Text = "Odśwież listę";
            this.RefreshListButton.UseVisualStyleBackColor = true;
            this.RefreshListButton.Click += new System.EventHandler(this.RefreshListButton_Click);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteRecordButton.Location = new System.Drawing.Point(15, 391);
            this.DeleteRecordButton.Name = "DeleteRecordButton";
            this.DeleteRecordButton.Size = new System.Drawing.Size(214, 40);
            this.DeleteRecordButton.TabIndex = 17;
            this.DeleteRecordButton.Text = "Usuń rekord";
            this.DeleteRecordButton.UseVisualStyleBackColor = true;
            this.DeleteRecordButton.Click += new System.EventHandler(this.DeleteRecordButton_Click);
            // 
            // SaveAsXMLButton
            // 
            this.SaveAsXMLButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveAsXMLButton.Location = new System.Drawing.Point(15, 437);
            this.SaveAsXMLButton.Name = "SaveAsXMLButton";
            this.SaveAsXMLButton.Size = new System.Drawing.Size(214, 40);
            this.SaveAsXMLButton.TabIndex = 18;
            this.SaveAsXMLButton.Text = "Zapisz jako XML";
            this.SaveAsXMLButton.UseVisualStyleBackColor = true;
            this.SaveAsXMLButton.Click += new System.EventHandler(this.SaveAsXMLButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExitButton.Location = new System.Drawing.Point(15, 510);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(214, 50);
            this.ExitButton.TabIndex = 19;
            this.ExitButton.Text = "Wyjście";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(523, 500);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(589, 500);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(457, 500);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(391, 500);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(655, 510);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 39);
            this.label7.TabIndex = 24;
            this.label7.Text = "Tele-Książka";
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(255, 510);
            this.userControl11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(109, 50);
            this.userControl11.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 484);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 26;
            // 
            // DeleteAllTool
            // 
            this.DeleteAllTool.Name = "DeleteAllTool";
            this.DeleteAllTool.Size = new System.Drawing.Size(185, 22);
            this.DeleteAllTool.Text = "Wyzeruj bazę danych";
            this.DeleteAllTool.Click += new System.EventHandler(this.DeleteAllTool_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 572);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SaveAsXMLButton);
            this.Controls.Add(this.DeleteRecordButton);
            this.Controls.Add(this.RefreshListButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddRecordButton);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.personalDataList);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ksiazka teleadresowa";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView personalDataList;
        private System.Windows.Forms.ColumnHeader PersonName;
        private System.Windows.Forms.ColumnHeader Surname;
        private System.Windows.Forms.ColumnHeader BirthDate;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader PhoneNumber;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem PlikTool;
        private System.Windows.Forms.ToolStripMenuItem AddRecordTool;
        private System.Windows.Forms.ToolStripMenuItem DeleteRekordTool;
        private System.Windows.Forms.ToolStripMenuItem SaveAsXMLTool;
        private System.Windows.Forms.ToolStripMenuItem RefreshListTool;
        private System.Windows.Forms.ToolStripMenuItem wyszukajToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox SearchToolTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddRecordButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button RefreshListButton;
        private System.Windows.Forms.Button DeleteRecordButton;
        private System.Windows.Forms.Button SaveAsXMLButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ToolStripMenuItem ExitTool;
        private System.Windows.Forms.Label label7;
        private Zegar.UserControl1 userControl11;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem DeleteAllTool;
    }
}

