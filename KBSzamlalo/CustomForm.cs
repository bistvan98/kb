using System.Diagnostics;
using System.Xml;
using System.Xml.Linq;

namespace KBSzamlalo
{
    public partial class CustomForm : Form
    {
        private bool IsWork = false;
        private bool FinishedAdding = true;

        public CustomForm()
        {
            Settings.LineCounter = 0;
            InitializeComponent();
            LoadDefault();
            rowCounterLabel.Text = "0";
        }

        #region "Click methods"

        // Intervall checkbox, loads the required items
        private void xPictureBox_Click(object sender, EventArgs e)
        {
            if (Settings.InterVall)
            {
                xPictureBox.Image = KBSzamlalo.Properties.Resources.black;
                Settings.InterVall = false;
                LoadDefault();
            }
            else
            {
                xPictureBox.Image = KBSzamlalo.Properties.Resources.x;
                Settings.InterVall = true;
                LoadIntervall();
            }
        }

        // Loads the required items to add a new work line
        private void plusWorkButton_Click(object sender, EventArgs e)
        {
            if (FinishedAdding)
            {
                FinishedAdding = false;
                Settings.LineCounter++;
            }

            IsWork = true;
            testMinTextBox.Text = "0";
            testSecTextBox.Text = "0";
            testMinTextBox.Show();
            testSecTextBox.Show();
            addNewButton.Show();
            addNewLabel.Text = "Add new work: ";
            addNewLabel.Show();
            dotsLabel.Show();
            cancelButton.Show();
        }

        // Loads the required items to add a new rest line
        private void plusRestButton_Click(object sender, EventArgs e)
        {
            if (FinishedAdding)
            {
                FinishedAdding = false;
                Settings.LineCounter++;
            }

            IsWork = false;
            testMinTextBox.Text = "0";
            testSecTextBox.Text = "0";
            testMinTextBox.Show();
            testSecTextBox.Show();
            addNewButton.Show();
            addNewLabel.Text = "Add new rest: ";
            addNewLabel.Show();
            dotsLabel.Show();
            cancelButton.Show();
        }

        // Click on the first rows remove button
        private void remove1_Click(object sender, EventArgs e)
        {
            if (FinishedAdding)
            {
                RemoveLine(1);
                Settings.LineCounter--;
            }
            else
            {
                MessageBox.Show("Can't remove the line while you're adding a new one!");
            }
        }

        // Click on the second rows remove button
        private void remove2_Click(object sender, EventArgs e)
        {
            if (FinishedAdding)
            {
                RemoveLine(2);
                Settings.LineCounter--;
            }
            else
            {
                MessageBox.Show("Can't remove the line while you're adding a new one!");
            }
        }

        // Click on the third rows remove button
        private void remove3_Click(object sender, EventArgs e)
        {
            if (FinishedAdding)
            {
                RemoveLine(3);
                Settings.LineCounter--;
            }
            else
            {
                MessageBox.Show("Can't remove the line while you're adding a new one!");
            }
        }

        // Click on the fourth rows remove button
        private void remove4_Click(object sender, EventArgs e)
        {
            if (FinishedAdding)
            {
                RemoveLine(4);
                Settings.LineCounter--;
            }
            else
            {
                MessageBox.Show("Can't remove the line while you're adding a new one!");
            }
        }

        // Click on the top list mover arrow
        private void moveListUpPic_Click(object sender, EventArgs e)
        {
            if (Settings.LineCounter > 4)
            {
                Label lb = (Label)this.Controls["id1Label"];
                if (Convert.ToInt32(lb.Text) != 1)
                {
                    MoveList(1);

                    if (Convert.ToInt32(lb.Text) == 1)
                    {
                        bottomLineLabel.Hide();
                    }
                    else
                    {
                        bottomLineLabel.Show();
                    }
                }
            }
        }

        // Click on the bottom list mover arrow
        private void moveListDownPic_Click(object sender, EventArgs e)
        {
            if (Settings.LineCounter > 4)
            {
                Label lb = (Label)this.Controls["id4Label"];
                if (Convert.ToInt32(lb.Text) < Settings.LineCounter)
                {
                    MoveList(4);

                    if (Convert.ToInt32(lb.Text) == Settings.LineCounter)
                    {
                        bottomLineLabel.Hide();
                    }
                    else
                    {
                        bottomLineLabel.Show();
                    }
                }
            }
        }

        // Click on the first lines line mover button (down)
        private void downArrow1_Click(object sender, EventArgs e)
        {
            MoveSingleLine(false, 1);
        }

        // Click on the second lines line mover button (down)
        private void downArrow2_Click(object sender, EventArgs e)
        {
            MoveSingleLine(false, 2);
        }

        // Click on the third lines line mover button (down)
        private void downArrow3_Click(object sender, EventArgs e)
        {
            MoveSingleLine(false, 3);
        }

        // Click on the fourth lines line mover button (down)
        private void downArrow4_Click(object sender, EventArgs e)
        {
            MoveSingleLine(false, 4);
        }

        // Click on the first lines line mover button (up)
        private void upArrow1_Click(object sender, EventArgs e)
        {
            MoveSingleLine(true, 1);
        }

        // Click on the second lines line mover button (up)
        private void upArrow2_Click(object sender, EventArgs e)
        {
            MoveSingleLine(true, 2);
        }

        // Click on the third lines line mover button (up)
        private void upArrow3_Click(object sender, EventArgs e)
        {
            MoveSingleLine(true, 3);
        }

        // Click on the fourth lines line mover button (up)
        private void upArrow4_Click(object sender, EventArgs e)
        {
            MoveSingleLine(true, 4);
        }

        // Cancels the new line adding
        private void cancelButton_Click(object sender, EventArgs e)
        {
            FinishedAdding = true;
            Settings.LineCounter--;
            testMinTextBox.Hide();
            testSecTextBox.Hide();
            dotsLabel.Hide();
            cancelButton.Hide();
            addNewButton.Hide();
            addNewLabel.Hide();
        }

        // Click on the first lines duplicate button
        private void duplicate1_Click(object sender, EventArgs e)
        {
            DuplicateItem(1);
        }

        // Click on the first lines duplicate button
        private void duplicate2_Click(object sender, EventArgs e)
        {
            DuplicateItem(2);
        }

        // Click on the first lines duplicate button
        private void duplicate3_Click(object sender, EventArgs e)
        {
            DuplicateItem(3);
        }

        // Click on the first lines duplicate button
        private void duplicate4_Click(object sender, EventArgs e)
        {
            DuplicateItem(4);
        }

        // Adds the new line to the list
        private void addNewButton_Click(object sender, EventArgs e)
        {
            // If the time isn't correct the user can't add it to the list
            if (Convert.ToInt32(testMinTextBox.Text) < 0 || (Convert.ToInt32(testSecTextBox.Text) > 59 || Convert.ToInt32(testSecTextBox.Text) < 0))
            {
                MessageBox.Show("Wrong time data! Minutes can't have a negative value, seconds can't be bigger than 59!");
            }
            // If both time datas are 0 the user can't add it to the list
            else if (Convert.ToInt32(testMinTextBox.Text) == 0 && Convert.ToInt32(testSecTextBox.Text) == 0)
            {
                MessageBox.Show("Can't add it with 0 length!");
            }
            else
            {
                // Removes the not needed zeros
                if (testMinTextBox.Text != "0" && testMinTextBox.Text.StartsWith("0"))
                {
                    testMinTextBox.Text = testMinTextBox.Text.TrimStart(new Char[] { '0' });
                }

                if (testSecTextBox.Text != "0" && testSecTextBox.Text.StartsWith("0"))
                {
                    testSecTextBox.Text = testSecTextBox.Text.TrimStart(new Char[] { '0' });
                }

                FinishedAdding = true;

                // Adds the new line to the shown list if it can. If it can't, then it just adds it to the list
                switch (Settings.LineCounter)
                {
                    // First slot
                    case 1:
                        id1Label.Text = Settings.LineCounter.ToString();
                        time1Label.Text = testMinTextBox.Text + ":" + testSecTextBox.Text;

                        if (IsWork)
                        {
                            typeLabel1.ForeColor = Color.White;
                            typeLabel1.Text = "work";
                        }
                        else
                        {
                            typeLabel1.ForeColor = Color.Red;
                            typeLabel1.Text = "rest";
                        }

                        id1Label.Show();
                        typeLabel1.Show();
                        time1Label.Show();
                        downArrow1.Show();
                        upArrow1.Show();
                        duplicate1.Show();
                        remove1.Show();

                        Settings.Lines.Add(id1Label.Text);
                        Settings.Lines.Add(typeLabel1.Text);
                        Settings.Lines.Add(time1Label.Text);

                        break;
                    // Second slot
                    case 2:
                        id2Label.Text = Settings.LineCounter.ToString();
                        time2Label.Text = testMinTextBox.Text + ":" + testSecTextBox.Text;

                        if (IsWork)
                        {
                            typeLabel2.ForeColor = Color.White;
                            typeLabel2.Text = "work";
                        }
                        else
                        {
                            typeLabel2.ForeColor = Color.Red;
                            typeLabel2.Text = "rest";
                        }

                        id2Label.Show();
                        typeLabel2.Show();
                        time2Label.Show();
                        downArrow2.Show();
                        upArrow2.Show();
                        duplicate2.Show();
                        remove2.Show();

                        Settings.Lines.Add(id2Label.Text);
                        Settings.Lines.Add(typeLabel2.Text);
                        Settings.Lines.Add(time2Label.Text);

                        break;
                    // Third slot
                    case 3:
                        id3Label.Text = Settings.LineCounter.ToString();
                        time3Label.Text = testMinTextBox.Text + ":" + testSecTextBox.Text;

                        if (IsWork)
                        {
                            typeLabel3.ForeColor = Color.White;
                            typeLabel3.Text = "work";
                        }
                        else
                        {
                            typeLabel3.ForeColor = Color.Red;
                            typeLabel3.Text = "rest";
                        }

                        id3Label.Show();
                        typeLabel3.Show();
                        time3Label.Show();
                        downArrow3.Show();
                        upArrow3.Show();
                        duplicate3.Show();
                        remove3.Show();

                        Settings.Lines.Add(id3Label.Text);
                        Settings.Lines.Add(typeLabel3.Text);
                        Settings.Lines.Add(time3Label.Text);

                        break;
                    // Fourth slot
                    case 4:
                        id4Label.Text = Settings.LineCounter.ToString();
                        time4Label.Text = testMinTextBox.Text + ":" + testSecTextBox.Text;

                        if (IsWork)
                        {
                            typeLabel4.ForeColor = Color.White;
                            typeLabel4.Text = "work";
                        }
                        else
                        {
                            typeLabel4.ForeColor = Color.Red;
                            typeLabel4.Text = "rest";
                        }

                        id4Label.Show();
                        typeLabel4.Show();
                        time4Label.Show();
                        downArrow4.Show();
                        upArrow4.Show();
                        duplicate4.Show();
                        remove4.Show();

                        Settings.Lines.Add(id4Label.Text);
                        Settings.Lines.Add(typeLabel4.Text);
                        Settings.Lines.Add(time4Label.Text);

                        break;
                    // No free slot
                    default:

                        Label lb = (Label)this.Controls["id4Label"];
                        if (Convert.ToInt32(lb.Text) == Settings.LineCounter - 1)
                        {
                            SortLines();

                            id4Label.Text = Settings.LineCounter.ToString();
                            time4Label.Text = testMinTextBox.Text + ":" + testSecTextBox.Text;

                            if (IsWork)
                            {
                                typeLabel4.ForeColor = Color.White;
                                typeLabel4.Text = "work";
                            }
                            else
                            {
                                typeLabel4.ForeColor = Color.Red;
                                typeLabel4.Text = "rest";
                            }

                            Settings.Lines.Add(id4Label.Text);
                            Settings.Lines.Add(typeLabel4.Text);
                            Settings.Lines.Add(time4Label.Text);
                        }
                        else
                        {
                            Settings.Lines.Add(Settings.LineCounter.ToString());

                            if (IsWork)
                            {
                                Settings.Lines.Add("work");
                            }
                            else
                            {
                                Settings.Lines.Add("rest");
                            }

                            Settings.Lines.Add(testMinTextBox.Text + ":" + testSecTextBox.Text);
                        }

                        break;
                }

                // Hids the add items

                testMinTextBox.Hide();
                testSecTextBox.Hide();
                addNewLabel.Hide();
                addNewButton.Hide();
                dotsLabel.Hide();
                cancelButton.Hide();
                rowCounterLabel.Text = "Rows: " + Settings.LineCounter.ToString();
            }
        }

        #endregion

        #region "Keypress methods"

        // The minutes textbox can only accept numbers (add new line)
        private void testMinTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // The seconds textbox can only accept numbers (add new line)
        private void testSecTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // The minutes textbox can only accept numbers
        private void customHourTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // The seconds textbox can only accept numbers
        private void customMinutesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // // The rounds textbox can only accept numbers
        private void roundsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region "Remove line methods"

        // Removes the first line from the list, changes the datas, then it sorts the list
        private void RemoveFirst()
        {
            int ElementID;

            if (Settings.LineCounter == 1)
            {
                ClearRow(1);
                SortList(0, 1);
            }
            else
            {
                int MaxLine;
                if (Settings.LineCounter <= 4)
                {
                    MaxLine = Settings.LineCounter;
                }
                else
                {
                    MaxLine = 4;
                }

                Label lb1 = (Label)this.Controls["id1Label"];
                int RowsFront = Settings.LineCounter - Convert.ToInt32(lb1.Text);
                ElementID = Convert.ToInt32(lb1.Text);

                string name1, name2;
                for (int i = 1; i < MaxLine; i++)
                {
                    name1 = "typeLabel" + i;
                    name2 = "typeLabel" + (i + 1);
                    lb1 = (Label)this.Controls[name1];
                    Label lb2 = (Label)this.Controls[name2];
                    lb1.Text = lb2.Text;
                    lb1.ForeColor = lb2.ForeColor;

                    name1 = "time" + i + "Label";
                    name2 = "time" + (i + 1) + "Label";
                    lb1 = (Label)this.Controls[name1];
                    lb2 = (Label)this.Controls[name2];
                    lb1.Text = lb2.Text;
                }

                if (Settings.LineCounter <= 4)
                {
                    ClearRow(Settings.LineCounter);
                }
                else
                {
                    if (Settings.LineCounter - ElementID >= 4)
                    {
                        int ListIndex = (ElementID + 1) * 3;

                        lb1 = (Label)this.Controls["typeLabel4"];
                        lb1.Text = Settings.Lines[ListIndex + 1];

                        if (lb1.Text == "work")
                        {
                            lb1.ForeColor = Color.White;
                        }
                        else
                        {
                            lb1.ForeColor = Color.Red;
                        }

                        lb1 = (Label)this.Controls["time4Label"];
                        lb1.Text = Settings.Lines[ListIndex + 2];
                    }
                    else
                    {
                        Label lb = (Label)this.Controls["id1Label"];
                        if (Convert.ToInt32(lb.Text) != 1)
                        {
                            MoveList(1);
                        }
                    }
                }

                SortList(Settings.LineCounter - ElementID, 1);
            }
        }

        // Removes the second or third line, updates the data then sorts the list
        private void RemoveMidLines(int LineId)
        {
            if (Settings.LineCounter == LineId)
            {
                ClearRow(LineId);
                SortList(0, LineId);
            }
            else
            {
                string name1 = "id" + LineId + "Label";
                Label lb1 = (Label)this.Controls[name1];
                int ItemId = Convert.ToInt32(lb1.Text);

                string name2;

                if (Settings.LineCounter > 4)
                {
                    if (Settings.LineCounter - LineId >= 5 - LineId)
                    {
                        for (int i = LineId; i < 4; i++)
                        {
                            name1 = "typeLabel" + i;
                            name2 = "typeLabel" + (i + 1);
                            lb1 = (Label)this.Controls[name1];
                            Label lb2 = (Label)this.Controls[name2];
                            lb1.Text = lb2.Text;
                            lb1.ForeColor = lb2.ForeColor;

                            name1 = "time" + i + "Label";
                            name2 = "time" + (i + 1) + "Label";
                            lb1 = (Label)this.Controls[name1];
                            lb2 = (Label)this.Controls[name2];
                            lb1.Text = lb2.Text;
                        }

                        int ListID = 0;

                        switch (LineId)
                        {
                            case 2:
                                lb1 = (Label)this.Controls["id2Label"];
                                if (Convert.ToInt32(lb1.Text) == Settings.LineCounter - 2)
                                {
                                    ListID = (ItemId * 3) - 3;
                                }
                                else
                                {
                                    ListID = ((ItemId + 3) * 3) - 3;
                                }
                                break;

                            case 3:
                                lb1 = (Label)this.Controls["id3Label"];
                                if (Convert.ToInt32(lb1.Text) == Settings.LineCounter - 1)
                                {
                                    ListID = ItemId * 3;
                                }
                                else
                                {
                                    ListID = (ItemId * 3) + 3;
                                }
                                break;
                        }

                        lb1 = (Label)this.Controls["id4Label"];
                        lb1.Text = Convert.ToString(Convert.ToInt32(Settings.Lines[ListID]) - 1);

                        lb1 = (Label)this.Controls["typeLabel4"];
                        lb1.Text = Settings.Lines[ListID + 1];

                        if (lb1.Text == "work")
                        {
                            lb1.ForeColor = Color.White;
                        }
                        else
                        {
                            lb1.ForeColor = Color.Red;
                        }

                        lb1 = (Label)this.Controls["time4Label"];
                        lb1.Text = Settings.Lines[ListID + 2];

                        lb1 = (Label)this.Controls["id1Label"];

                        if (lb1.Text != "1")
                        {
                            MoveList(1);
                        }

                        int counter = 0;
                        int ListId = ItemId * 3;
                        while (counter < 3)
                        {
                            Settings.Lines.RemoveAt(ListId - 3);
                            counter++;
                        }

                        int RowsFront = Settings.LineCounter - ItemId;

                        for (int i = 0; i < RowsFront; i++)
                        {
                            Settings.Lines[ListId - 3 + (i * 3)] = Convert.ToString(Convert.ToInt32(Settings.Lines[ListId - 3 + (i * 3)]) - 1);
                        }
                    }
                    else
                    {
                        for (int i = LineId; i < 4; i++)
                        {

                            switch (LineId)
                            {
                                case 2:
                                    name1 = "typeLabel" + i;
                                    name2 = "typeLabel" + (i + 1);
                                    lb1 = (Label)this.Controls[name1];
                                    Label lb2 = (Label)this.Controls[name2];
                                    lb1.Text = lb2.Text;
                                    lb1.ForeColor = lb2.ForeColor;

                                    name1 = "time" + i + "Label";
                                    name2 = "time" + (i + 1) + "Label";
                                    lb1 = (Label)this.Controls[name1];
                                    lb2 = (Label)this.Controls[name2];
                                    lb1.Text = lb2.Text;
                                    break;

                                case 3:
                                    name1 = "typeLabel" + i;
                                    name2 = "typeLabel" + (i - 1);
                                    lb1 = (Label)this.Controls[name1];
                                    lb2 = (Label)this.Controls[name2];
                                    lb2.Text = lb1.Text;
                                    lb2.ForeColor = lb1.ForeColor;

                                    name1 = "time" + i + "Label";
                                    name2 = "time" + (i - 1) + "Label";
                                    lb1 = (Label)this.Controls[name1];
                                    lb2 = (Label)this.Controls[name2];
                                    lb2.Text = lb1.Text;
                                    break;
                            }
                        }

                        Label lb = (Label)this.Controls["id1Label"];

                        if (Convert.ToInt32(lb.Text) != 1)
                        {
                            MoveList(1);
                        }

                        SortList(Settings.LineCounter - ItemId, LineId);
                    }
                }
                else
                {
                    for (int i = ItemId; i < ItemId + (Settings.LineCounter - ItemId); i++)
                    {
                        name1 = "typeLabel" + i;
                        name2 = "typeLabel" + (i + 1);
                        lb1 = (Label)this.Controls[name1];
                        Label lb2 = (Label)this.Controls[name2];
                        lb1.Text = lb2.Text;
                        lb1.ForeColor = lb2.ForeColor;

                        name1 = "time" + i + "Label";
                        name2 = "time" + (i + 1) + "Label";
                        lb1 = (Label)this.Controls[name1];
                        lb2 = (Label)this.Controls[name2];
                        lb1.Text = lb2.Text;
                    }

                    if (Settings.LineCounter <= 4)
                    {
                        ClearRow(Settings.LineCounter);
                    }
                    else
                    {
                        if (Settings.LineCounter - ItemId >= 5 - LineId)
                        {
                            int ListIndex = 0;

                            switch (LineId)
                            {
                                case 2:
                                    ListIndex = ((ItemId + 1) * 3) + 3;
                                    break;

                                case 3:
                                    ListIndex = (ItemId * 3) + 3;
                                    break;
                            }


                            lb1 = (Label)this.Controls["typeLabel4"];
                            lb1.Text = Settings.Lines[ListIndex + 1];

                            if (lb1.Text == "work")
                            {
                                lb1.ForeColor = Color.White;
                            }
                            else
                            {
                                lb1.ForeColor = Color.Red;
                            }

                            lb1 = (Label)this.Controls["time4Label"];
                            lb1.Text = Settings.Lines[ListIndex + 2];
                        }
                        else
                        {
                            Label lb = (Label)this.Controls["id1Label"];
                            if (Convert.ToInt32(lb.Text) != 1)
                            {
                                MoveList(1);
                            }
                        }
                    }

                    SortList(Settings.LineCounter - ItemId, LineId);
                }
            }
        }

        // Calls the right remove method depending on the line
        private void RemoveLine(int LineID)
        {
            switch (LineID)
            {
                case 1:
                    RemoveFirst();
                    break;

                case 2:
                    RemoveMidLines(2);
                    break;

                case 3:
                    RemoveMidLines(3);
                    break;

                case 4:
                    RemoveLast();
                    break;
            }

            rowCounterLabel.Text = "Rows: " + (Settings.LineCounter - 1);
        }

        // Removes the last line from the lists, updates the data then sorts the list
        private void RemoveLast()
        {
            Label lb = (Label)this.Controls["id4Label"];
            if (Convert.ToInt32(lb.Text) == Settings.LineCounter)
            {
                if (Settings.LineCounter != 4)
                {
                    MoveList(1);
                }
                else
                {
                    ClearRow(4);
                }

                int ListIndex = (Settings.LineCounter - 1) * 3;
                int counter = 0;

                while (counter < 3)
                {
                    Settings.Lines.RemoveAt(ListIndex);
                    counter++;
                }
            }
            else
            {
                int ItemId = Convert.ToInt32(lb.Text);
                int ListId = ItemId * 3;

                lb = (Label)this.Controls["typeLabel4"];
                lb.Text = Settings.Lines[ListId + 1];
                if (lb.Text == "work")
                {
                    lb.ForeColor = Color.White;
                }
                else
                {
                    lb.ForeColor = Color.Red;
                }

                lb = (Label)this.Controls["time4Label"];
                lb.Text = Settings.Lines[ListId + 2];

                int counter = 0;
                while (counter < 3)
                {
                    Settings.Lines.RemoveAt(ListId - 3);
                    counter++;
                }

                int RowsFront = Settings.LineCounter - ItemId;

                for (int i = 0; i < RowsFront; i++)
                {
                    Settings.Lines[ListId - 3 + (i * 3)] = Convert.ToString(Convert.ToInt32(Settings.Lines[ListId - 3 + (i * 3)]) - 1);
                }
            }
        }

        #endregion

        #region "Sort lines methods"

        // Sorts the lines
        private void SortLines()
        {
            string Name1, Name2;

            for (int i = 1; i < 4; i++)
            {
                Name1 = "id" + i + "Label";
                Name2 = "id" + (i + 1) + "Label";
                Label lb1 = (Label)this.Controls[Name1];
                Label lb2 = (Label)this.Controls[Name2];
                lb1.Text = lb2.Text;

                Name1 = "typeLabel" + i;
                Name2 = "typeLabel" + (i + 1);
                lb1 = (Label)this.Controls[Name1];
                lb2 = (Label)this.Controls[Name2];
                lb1.Text = lb2.Text;
                lb1.ForeColor = lb2.ForeColor;

                Name1 = "time" + i + "Label";
                Name2 = "time" + (i + 1) + "Label";
                lb1 = (Label)this.Controls[Name1];
                lb2 = (Label)this.Controls[Name2];
                lb1.Text = lb2.Text;
            }

            bottomLineLabel.Hide();
            topLineLabel.Show();
        }

        // Clears a row
        private void ClearRow(int LineID)
        {
            string name = "id" + LineID + "Label";
            Label lb = (Label)this.Controls[name];
            lb.Text = LineID.ToString();
            lb.Hide();

            name = "typeLabel" + LineID;
            lb = (Label)this.Controls[name];
            lb.Hide();

            name = "time" + LineID + "Label";
            lb = (Label)this.Controls[name];
            lb.Hide();

            name = "upArrow" + LineID;
            PictureBox pb = (PictureBox)this.Controls[name];
            pb.Hide();

            name = "downArrow" + LineID;
            pb = (PictureBox)this.Controls[name];
            pb.Hide();

            name = "duplicate" + LineID;
            pb = (PictureBox)this.Controls[name];
            pb.Hide();

            name = "remove" + LineID;
            pb = (PictureBox)this.Controls[name];
            pb.Hide();

        }

        // Sorts the list data
        private void SortList(int RowsFront, int LineID)
        {
            if (RowsFront == 0)
            {
                if (LineID == 1)
                {
                    Settings.Lines.Clear();
                }
                else
                {
                    int ListIndex = (LineID - 1) * 3;

                    int counter = 0;
                    while (counter != 3)
                    {
                        Settings.Lines.RemoveAt(ListIndex);
                        counter++;
                    }
                }
            }
            else
            {
                string Name = "id" + LineID + "Label";
                Label lb1 = (Label)this.Controls[Name];

                int listId = Convert.ToInt32(lb1.Text);
                listId = (listId - 1) * 3;

                int size = Settings.Lines.Count;
                int change = ((size - listId) / 3) - 1;
                int[] changeIds = new int[change];

                for (int i = 0; i < change; i++)
                {
                    changeIds[i] = listId + ((i + 1) * 3);
                    Settings.Lines[changeIds[i]] = Convert.ToString(Convert.ToInt32(Settings.Lines[changeIds[i]]) - 1);
                }

                int counter = 0;
                while (counter != 3)
                {
                    Settings.Lines.RemoveAt(listId);
                    counter++;
                }
            }
        }

        // Moves the list items (multiple)
        private void MoveList(int ListID)
        {
            string name = "id" + ListID + "Label";
            Label lb = (Label)this.Controls[name];
            if (Settings.LineCounter >= 5)
            {
                if (ListID == 1)
                {
                    for (int i = 3; i > 0; i--)
                    {
                        name = "id" + i + "Label";
                        lb = (Label)this.Controls[name];
                        name = "id" + (i + 1) + "Label";
                        Label lb2 = (Label)this.Controls[name];
                        lb2.Text = lb.Text;

                        name = "typeLabel" + i;
                        lb = (Label)this.Controls[name];
                        name = "typeLabel" + (i + 1);
                        lb2 = (Label)this.Controls[name];
                        lb2.Text = lb.Text;
                        lb2.ForeColor = lb.ForeColor;

                        name = "time" + i + "Label";
                        lb = (Label)this.Controls[name];
                        name = "time" + (i + 1) + "Label";
                        lb2 = (Label)this.Controls[name];
                        lb2.Text = lb.Text;
                    }
                }
                else
                {
                    for (int i = 1; i < 4; i++)
                    {
                        name = "id" + i + "Label";
                        lb = (Label)this.Controls[name];
                        name = "id" + (i + 1) + "Label";
                        Label lb2 = (Label)this.Controls[name];
                        lb.Text = lb2.Text;

                        name = "typeLabel" + i;
                        lb = (Label)this.Controls[name];
                        name = "typeLabel" + (i + 1);
                        lb2 = (Label)this.Controls[name];
                        lb.Text = lb2.Text;
                        lb.ForeColor = lb2.ForeColor;

                        name = "time" + i + "Label";
                        lb = (Label)this.Controls[name];
                        name = "time" + (i + 1) + "Label";
                        lb2 = (Label)this.Controls[name];
                        lb.Text = lb2.Text;
                    }
                }

                name = "id" + ListID + "Label";
                lb = (Label)this.Controls[name];

                int ListIndex;

                if (ListID == 1)
                {
                    ListIndex = (Convert.ToInt32(lb.Text) - 2) * 3;
                }
                else
                {
                    ListIndex = ((Convert.ToInt32(lb.Text) - 1) * 3) + 3;
                }

                lb.Text = Settings.Lines[ListIndex];

                name = "typeLabel" + ListID;
                lb = (Label)this.Controls[name];
                lb.Text = Settings.Lines[ListIndex + 1];

                if (lb.Text == "work")
                {
                    lb.ForeColor = Color.White;
                }
                else
                {
                    lb.ForeColor = Color.Red;
                }

                name = "time" + ListID + "Label";
                lb = (Label)this.Controls[name];
                lb.Text = Settings.Lines[ListIndex + 2];
            }
        }

        // Moves one list item
        private void MoveSingleLine(bool Up, int LineId)
        {
            if (Up)
            {
                switch (LineId)
                {
                    case 1:
                        if (id1Label.Text == "1")
                        {
                            MessageBox.Show("This is the first item!");
                        }
                        else if (Convert.ToInt32(id1Label.Text) == Settings.LineCounter)
                        {
                            MessageBox.Show("This is the last item!");
                        }
                        else
                        {
                            string Help;
                            int ListHelp = ((Convert.ToInt32(id1Label.Text) - 1) * 3) + 1;

                            Help = Settings.Lines[ListHelp];
                            Settings.Lines[ListHelp] = Settings.Lines[ListHelp - 3];
                            Settings.Lines[ListHelp - 3] = Help;

                            Help = Settings.Lines[ListHelp + 1];
                            Settings.Lines[ListHelp + 1] = Settings.Lines[(ListHelp + 1) - 3];
                            Settings.Lines[(ListHelp + 1) - 3] = Help;

                            typeLabel1.Text = Settings.Lines[ListHelp];

                            if (typeLabel1.Text == "work")
                            {
                                typeLabel1.ForeColor = Color.White;
                            }
                            else
                            {
                                typeLabel1.ForeColor = Color.Red;
                            }

                            time1Label.Text = Settings.Lines[ListHelp + 1];
                        }

                        break;

                    default:
                        string HelpString, name1;
                        int ListId;

                        name1 = "typeLabel" + LineId;
                        Label lb2 = (Label)this.Controls[name1];

                        name1 = "typeLabel" + (LineId - 1);
                        Label lb1 = (Label)this.Controls[name1];

                        HelpString = lb2.Text;
                        lb2.Text = lb1.Text;
                        lb1.Text = HelpString;

                        if (lb1.ForeColor != lb2.ForeColor)
                        {
                            if (lb1.ForeColor == Color.Red)
                            {
                                lb1.ForeColor = Color.White;
                                lb2.ForeColor = Color.Red;
                            }
                            else
                            {
                                lb2.ForeColor = Color.White;
                                lb1.ForeColor = Color.Red;
                            }
                        }

                        name1 = "time" + LineId + "Label";
                        lb1 = (Label)this.Controls[name1];

                        name1 = "time" + (LineId - 1) + "Label";
                        lb2 = (Label)this.Controls[name1];

                        HelpString = lb2.Text;
                        lb2.Text = lb1.Text;
                        lb1.Text = HelpString;

                        name1 = "id" + LineId + "Label";
                        lb1 = (Label)this.Controls[name1];
                        ListId = ((Convert.ToInt32(lb1.Text) - 1) * 3) + 1;

                        HelpString = Settings.Lines[ListId];
                        Settings.Lines[ListId] = Settings.Lines[ListId - 3];
                        Settings.Lines[ListId - 3] = HelpString;

                        HelpString = Settings.Lines[ListId + 1];
                        Settings.Lines[ListId + 1] = Settings.Lines[(ListId + 1) - 3];
                        Settings.Lines[(ListId + 1) - 3] = HelpString;

                        break;
                }
            }
            else
            {
                switch (LineId)
                {
                    case 4:
                        if (Convert.ToInt32(id4Label.Text) == Settings.LineCounter)
                        {
                            MessageBox.Show("This is the last item!");
                        }
                        else
                        {
                            string Help;
                            int ListHelp = ((Convert.ToInt32(id4Label.Text) - 1) * 3) + 1;

                            Help = Settings.Lines[ListHelp];
                            Settings.Lines[ListHelp] = Settings.Lines[ListHelp + 3];
                            Settings.Lines[ListHelp + 3] = Help;

                            Help = Settings.Lines[ListHelp + 1];
                            Settings.Lines[ListHelp + 1] = Settings.Lines[(ListHelp + 1) + 3];
                            Settings.Lines[(ListHelp + 1) + 3] = Help;

                            typeLabel4.Text = Settings.Lines[ListHelp];

                            if (typeLabel4.Text == "work")
                            {
                                typeLabel4.ForeColor = Color.White;
                            }
                            else
                            {
                                typeLabel4.ForeColor = Color.Red;
                            }

                            time4Label.Text = Settings.Lines[ListHelp + 1];
                        }

                        break;

                    default:
                        string HelpString, name1;
                        int ListId;

                        name1 = "id" + LineId + "Label";
                        Label lb1 = (Label)this.Controls[name1];
                        if (Settings.LineCounter == Convert.ToInt32(lb1.Text))
                        {
                            MessageBox.Show("This is the last item!");
                        }
                        else
                        {
                            name1 = "typeLabel" + LineId;
                            Label lb2 = (Label)this.Controls[name1];

                            name1 = "typeLabel" + (LineId + 1);
                            lb1 = (Label)this.Controls[name1];

                            HelpString = lb2.Text;
                            lb2.Text = lb1.Text;
                            lb1.Text = HelpString;

                            if (lb1.ForeColor != lb2.ForeColor)
                            {
                                if (lb1.ForeColor == Color.Red)
                                {
                                    lb1.ForeColor = Color.White;
                                    lb2.ForeColor = Color.Red;
                                }
                                else
                                {
                                    lb2.ForeColor = Color.White;
                                    lb1.ForeColor = Color.Red;
                                }
                            }

                            name1 = "time" + LineId + "Label";
                            lb1 = (Label)this.Controls[name1];

                            name1 = "time" + (LineId + 1) + "Label";
                            lb2 = (Label)this.Controls[name1];

                            HelpString = lb2.Text;
                            lb2.Text = lb1.Text;
                            lb1.Text = HelpString;

                            name1 = "id" + LineId + "Label";
                            lb1 = (Label)this.Controls[name1];

                            ListId = ((Convert.ToInt32(lb1.Text) - 1) * 3) + 1;

                            HelpString = Settings.Lines[ListId];
                            Settings.Lines[ListId] = Settings.Lines[ListId + 3];
                            Settings.Lines[ListId + 3] = HelpString;

                            HelpString = Settings.Lines[ListId + 1];
                            Settings.Lines[ListId + 1] = Settings.Lines[(ListId + 1) + 3];
                            Settings.Lines[(ListId + 1) + 3] = HelpString;
                        }
                        break;
                }
            }
        }

        #endregion

        #region "Load methods"

        // Loads the intervall items
        private void LoadIntervall()
        {
            roundsLabel.Show();
            roundsTextBox.Show();
            plusRestButton.Show();
            plusWorkButton.Show();
            rowCounterLabel.Show();
            moveListDownPic.Show();
            moveListUpPic.Show();
            rowCounterLabel.Show();

            for (int i = 0; i < 4; i++)
            {
                if (Settings.LineCounter >= i + 1)
                {
                    string Name = "id" + (i + 1) + "Label";
                    Label lb = (Label)this.Controls[Name];
                    lb.Show();

                    Name = "typeLabel" + (i + 1);
                    lb = (Label)this.Controls[Name];
                    lb.Show();

                    Name = "time" + (i + 1) + "Label";
                    lb = (Label)this.Controls[Name];
                    lb.Show();

                    Name = "downArrow" + (i + 1);
                    PictureBox pb = (PictureBox)this.Controls[Name];
                    pb.Show();

                    Name = "upArrow" + (i + 1);
                    pb = (PictureBox)this.Controls[Name];
                    pb.Show();

                    Name = "duplicate" + (i + 1);
                    pb = (PictureBox)this.Controls[Name];
                    pb.Show();

                    Name = "remove" + (i + 1);
                    pb = (PictureBox)this.Controls[Name];
                    pb.Show();
                }
            }
        }

        // Loads the default items
        private void LoadDefault()
        {
            Settings.InterVall = false;

            roundsLabel.Hide();
            roundsTextBox.Hide();
            plusRestButton.Hide();
            plusWorkButton.Hide();
            rowCounterLabel.Hide();
            addNewButton.Hide();
            addNewLabel.Hide();
            testMinTextBox.Hide();
            testSecTextBox.Hide();
            topLineLabel.Hide();
            bottomLineLabel.Hide();
            moveListDownPic.Hide();
            moveListUpPic.Hide();
            dotsLabel.Hide();
            cancelButton.Hide();
            xPictureBox.Image = KBSzamlalo.Properties.Resources.black;


            id1Label.Hide(); id2Label.Hide(); id3Label.Hide(); id4Label.Hide();

            typeLabel1.Hide(); typeLabel2.Hide(); typeLabel3.Hide(); typeLabel4.Hide();

            time1Label.Hide(); time2Label.Hide(); time3Label.Hide(); time4Label.Hide();

            downArrow1.Hide(); downArrow2.Hide(); downArrow3.Hide(); downArrow4.Hide();

            upArrow1.Hide(); upArrow2.Hide(); upArrow3.Hide(); upArrow4.Hide();

            duplicate1.Hide(); duplicate2.Hide(); duplicate3.Hide(); duplicate4.Hide();

            remove1.Hide(); remove2.Hide(); remove3.Hide(); remove4.Hide();
        }

        #endregion

        #region "Duplicate method"

        // Duplicates a line and puts it to the end of the list
        private void DuplicateItem(int LineId)
        {
            Settings.Lines.Add(Convert.ToString(Settings.LineCounter + 1));

            string name = "typeLabel" + LineId;
            Label lb = (Label)this.Controls[name];
            Settings.Lines.Add(lb.Text);

            name = "time" + LineId + "Label";
            lb = (Label)this.Controls[name];
            Settings.Lines.Add(lb.Text);

            if (Settings.LineCounter < 4)
            {
                switch (Settings.LineCounter)
                {
                    case 1:
                        id2Label.Text = Convert.ToString(Settings.LineCounter + 1); ;
                        typeLabel2.Text = Settings.Lines[Settings.Lines.Count - 5];
                        if (typeLabel2.Text == "work")
                        {
                            typeLabel2.ForeColor = Color.White;
                        }
                        else
                        {
                            typeLabel2.ForeColor = Color.Red;
                        }

                        time2Label.Text = Settings.Lines[Settings.Lines.Count - 4];

                        id2Label.Show();
                        typeLabel2.Show();
                        time2Label.Show();
                        downArrow2.Show();
                        upArrow2.Show();
                        duplicate2.Show();
                        remove2.Show();

                        Settings.LineCounter++;
                        rowCounterLabel.Text = "Rows: " + Settings.LineCounter;
                        break;

                    case 2:
                        id3Label.Text = Convert.ToString(Settings.LineCounter + 1);
                        typeLabel3.Text = Settings.Lines[Settings.Lines.Count - 2];
                        if (typeLabel3.Text == "work")
                        {
                            typeLabel3.ForeColor = Color.White;
                        }
                        else
                        {
                            typeLabel3.ForeColor = Color.Red;
                        }

                        time3Label.Text = Settings.Lines[Settings.Lines.Count - 1];

                        id3Label.Show();
                        typeLabel3.Show();
                        time3Label.Show();
                        downArrow3.Show();
                        upArrow3.Show();
                        duplicate3.Show();
                        remove3.Show();

                        Settings.LineCounter++;
                        rowCounterLabel.Text = "Rows: " + Settings.LineCounter;
                        break;

                    case 3:
                        id4Label.Text = Convert.ToString(Settings.LineCounter + 1);
                        typeLabel4.Text = Settings.Lines[Settings.Lines.Count - 2];
                        if (typeLabel4.Text == "work")
                        {
                            typeLabel4.ForeColor = Color.White;
                        }
                        else
                        {
                            typeLabel4.ForeColor = Color.Red;
                        }

                        time4Label.Text = Settings.Lines[Settings.Lines.Count - 1];

                        id4Label.Show();
                        typeLabel4.Show();
                        time4Label.Show();
                        downArrow4.Show();
                        upArrow4.Show();
                        duplicate4.Show();
                        remove4.Show();

                        Settings.LineCounter++;
                        rowCounterLabel.Text = "Rows: " + Settings.LineCounter;
                        break;
                }
            }
            else
            {
                Settings.LineCounter++;
                rowCounterLabel.Text = "Rows: " + Settings.LineCounter;
                MessageBox.Show("Duplicated line copied to the end of the list!");
            }
        }

        #endregion

        #region "Save and Load methods"

        // Saves the current plan to an xml file
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveNameTextBox.Text == "" || saveNameTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Forget to add a name!");
            }
            else if ((roundsTextBox.Text == "" || roundsTextBox.Text.TrimStart(new Char[] { '0' }) == "") && Settings.InterVall)
            {
                MessageBox.Show("Fill the Rounds text box!");
            }
            else if (((customHourTextBox.Text == "" || customMinutesTextBox.Text == "") && !Settings.InterVall) ||
                ((customHourTextBox.Text.TrimStart(new Char[] { '0' }) == "" && customMinutesTextBox.Text.TrimStart(new Char[] { '0' }) == "") && !Settings.InterVall))
            {
                MessageBox.Show("Fill the time text box!");
            }
            else if(FinishedAdding == false)
            {
                MessageBox.Show("Finish the adding of a new line, or cancel it before saving!");
            }
            else
            {
                if (customHourTextBox.Text != "0" && customHourTextBox.Text.StartsWith("0"))
                {
                    customHourTextBox.Text = customHourTextBox.Text.TrimStart(new Char[] { '0' });
                }

                if (customMinutesTextBox.Text != "0" && customMinutesTextBox.Text.StartsWith("0"))
                {
                    customMinutesTextBox.Text = customMinutesTextBox.Text.TrimStart(new Char[] { '0' });
                }

                if (roundsTextBox.Text.StartsWith("0"))
                {
                    roundsTextBox.Text = roundsTextBox.Text.TrimStart(new Char[] { '0' });
                }

                if(Settings.InterVall && customHourTextBox.Text == "")
                {
                    customHourTextBox.Text = "1";
                }

                if (Settings.InterVall && customMinutesTextBox.Text == "")
                {
                    customMinutesTextBox.Text = "1";
                }

                if(!Settings.InterVall)
                {
                    Settings.Lines.Clear();
                }

                Settings.Lines.Add(roundsTextBox.Text);
                Settings.Lines.Add(customHourTextBox.Text);
                Settings.Lines.Add(customMinutesTextBox.Text);
                Settings.Lines.Add(saveNameTextBox.Text);

                XDocument myDoc = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XElement("CustomRound"));

                int ListStep = 0;

                if (Settings.InterVall)
                {
                    if (Settings.LineCounter != 0)
                    {
                        for (int i = 0; i < Settings.LineCounter; i++)
                        {
                            myDoc.Root.Add(new XElement("Round",
                                new XElement("id", Settings.Lines[ListStep]),
                                new XElement("type", Settings.Lines[ListStep + 1]),
                                new XElement("length", Settings.Lines[ListStep + 2])
                                ));

                            ListStep = ListStep + 3;
                        }
                    }
                    else
                    {
                        MessageBox.Show("You need to add atleast one element to the list to save it or uncheck the intervall option!");
                    }
                }

                myDoc.Root.Add(new XElement("OtherData",
                                new XElement("RoundsNumber", Settings.Lines[ListStep]),
                                new XElement("Min", Settings.Lines[ListStep + 1]),
                                new XElement("Sec", Settings.Lines[ListStep + 2]),
                                new XElement("Name", Settings.Lines[ListStep + 3])
                                ));

                myDoc.Save(saveNameTextBox.Text.Trim() + ".xml");

                LoadDefault();
                Settings.InterVall = false;
                Settings.Lines.Clear();
                Settings.LineCounter = 0;
                rowCounterLabel.Text = "Rows: " + Settings.LineCounter;
                customHourTextBox.Text = "";
                customMinutesTextBox.Text = "";
                roundsTextBox.Text = "1";
                saveNameTextBox.Text = "";

                MessageBox.Show("Save File created!");
            }
        }

        // Loads an xml file
        private void customLoadButton_Click(object sender, EventArgs e)
        {
            string xmlPath;

            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*\"";
                if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    xmlPath = fileDialog.FileName;
                    Settings.Lines.Clear();
                    Settings.LineCounter = 0;

                    XmlTextReader xmlReader = new XmlTextReader(xmlPath);

                    while (xmlReader.Read())
                    {
                        switch (xmlReader.Name)
                        {
                            case "id":
                                Settings.Lines.Add(xmlReader.ReadString());
                                break;
                            case "type":
                                Settings.Lines.Add(xmlReader.ReadString());
                                break;
                            case "length":
                                Settings.Lines.Add(xmlReader.ReadString());
                                break;
                            case "RoundsNumber":
                                Settings.Lines.Add(xmlReader.ReadString());
                                break;
                            case "Min":
                                Settings.Lines.Add(xmlReader.ReadString());
                                break;
                            case "Sec":
                                Settings.Lines.Add(xmlReader.ReadString());
                                break;
                            case "Name":
                                Settings.Lines.Add(xmlReader.ReadString());
                                break;
                        }
                    }

                    if (Settings.Lines.Count > 4)
                    {
                        LoadXmlData(true);
                    }
                    else
                    {
                        LoadXmlData(false);
                    }
                }
            }
        }

        // Loads the xml data and stores it in the Lines list (static list)
        private void LoadXmlData(bool WithList)
        {
            int ListCounter = 0;

            switch (WithList)
            {
                case true:
                    LoadIntervall();
                    Settings.InterVall = true;
                    xPictureBox.Image = KBSzamlalo.Properties.Resources.x;
                    Settings.LineCounter = (Settings.Lines.Count - 4) / 3;

                    int MaxNumber;

                    if (Settings.LineCounter > 4)
                    {
                        MaxNumber = 4;
                    }
                    else
                    {
                        MaxNumber = Settings.LineCounter;
                    }

                    for (int i = 0; i < MaxNumber; i++)
                    {
                        string name = "id" + (i + 1) + "Label";
                        Label lb = (Label)this.Controls[name];
                        lb.Text = Settings.Lines[ListCounter];
                        lb.Show();
                        ListCounter++;

                        name = "typeLabel" + (i + 1);
                        lb = (Label)this.Controls[name];
                        lb.Text = Settings.Lines[ListCounter];

                        if (lb.Text == "work")
                        {
                            lb.ForeColor = Color.White;
                        }
                        else
                        {
                            lb.ForeColor = Color.Red;
                        }

                        lb.Show();

                        ListCounter++;

                        name = "time" + (i + 1) + "Label";
                        lb = (Label)this.Controls[name];
                        lb.Text = Settings.Lines[ListCounter];
                        lb.Show();
                        ListCounter++;

                        name = "downArrow" + (i + 1);
                        PictureBox pb = (PictureBox)this.Controls[name];
                        pb.Show();

                        name = "upArrow" + (i + 1);
                        pb = (PictureBox)this.Controls[name];
                        pb.Show();

                        name = "duplicate" + (i + 1);
                        pb = (PictureBox)this.Controls[name];
                        pb.Show();

                        name = "remove" + (i + 1);
                        pb = (PictureBox)this.Controls[name];
                        pb.Show();
                    }

                    ListCounter = Settings.Lines.Count - 4;

                    roundsTextBox.Text = Settings.Lines[ListCounter];
                    ListCounter++;
                    customHourTextBox.Text = Settings.Lines[ListCounter];
                    ListCounter++;
                    customMinutesTextBox.Text = Settings.Lines[ListCounter];
                    ListCounter++;
                    saveNameTextBox.Text = Settings.Lines[ListCounter];

                    rowCounterLabel.Text = "Rows: " + Settings.LineCounter;
                    break;

                case false:
                    ListCounter = Settings.Lines.Count - 4;

                    roundsTextBox.Text = Settings.Lines[ListCounter];
                    ListCounter++;
                    customHourTextBox.Text = Settings.Lines[ListCounter];
                    ListCounter++;
                    customMinutesTextBox.Text = Settings.Lines[ListCounter];
                    ListCounter++;
                    saveNameTextBox.Text = Settings.Lines[ListCounter];

                    rowCounterLabel.Text = "Rows: " + Settings.LineCounter;
                    break;
            }
        }

        #endregion

        // Opens the default form when this form closes
        private void CustomForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();

            this.Hide();
        }

        // Prepears the data for the plan run and loads the run form
        private void sprintPictureBox_Click(object sender, EventArgs e)
        {
            // If there are no loaded files and there are no added intervall lines
            if (/*(Settings.Lines.Count == 0 && Settings.LineCounter == 0)*/!Settings.InterVall)
            {
                Settings.Lines.Clear();
                //customHourTextBox.Text.TrimStart(new Char[] { '0' }) == "" || customMinutesTextBox.Text.TrimStart(new Char[] { '0' }) == ""
                if (String.IsNullOrEmpty(customHourTextBox.Text) && String.IsNullOrEmpty(customMinutesTextBox.Text))
                {
                    MessageBox.Show("Wrong time data!");
                }
                else if (customHourTextBox.Text.TrimStart(new Char[] { '0' }) == "" && customMinutesTextBox.Text.TrimStart(new Char[] { '0' }) == "")
                {
                    MessageBox.Show("Wrong time data!");
                }
                else
                {
                    Settings.Lines.Add("1");

                    if (customHourTextBox.Text.TrimStart(new Char[] { '0' }) == "")
                    {
                        Settings.Lines.Add("0");
                    }
                    else
                    {
                        Settings.Lines.Add(customHourTextBox.Text);
                    }

                    if (customMinutesTextBox.Text.TrimStart(new Char[] { '0' }) == "")
                    {
                        Settings.Lines.Add("0");
                    }
                    else
                    {
                        Settings.Lines.Add(customMinutesTextBox.Text);
                    }

                    if (saveNameTextBox.Text != "" || saveNameTextBox.Text.Trim() != "")
                    {
                        Settings.Lines.Add(saveNameTextBox.Text);
                    }
                    else
                    {
                        Settings.Lines.Add("Unnamed Custom:");
                    }

                    CustomRunForm crf = new CustomRunForm();
                    crf.Show();
                    this.Hide();
                }
            }
            // If there are no loaded files but there are added intervall lines
            else if ((Settings.Lines.Count - (Settings.LineCounter * 3)) == 0)
            {
                if (roundsTextBox.Text == "" || roundsTextBox.Text.TrimStart(new Char[] { '0' }) == "")
                {
                    MessageBox.Show("Missing round data!");
                }
                else
                {
                    Settings.Lines.Add(roundsTextBox.Text);
                    Settings.Lines.Add("1");
                    Settings.Lines.Add("1");

                    if (saveNameTextBox.Text != "" || saveNameTextBox.Text.Trim() != "")
                    {
                        Settings.Lines.Add(saveNameTextBox.Text);
                    }
                    else
                    {
                        Settings.Lines.Add("Unnamed Custom:");
                    }

                    CustomRunForm crf = new CustomRunForm();
                    crf.Show();
                    this.Hide();
                }
            }
            // Loading a file intervall file
            else if (Settings.LineCounter != 0)
            {
                if (((Settings.Lines.Count - 4) / Settings.LineCounter) == 3)
                {
                    if (Settings.Lines[Settings.Lines.Count - 4] != roundsTextBox.Text)
                    {
                        if (roundsTextBox.Text == "" || roundsTextBox.Text.TrimStart(new Char[] { '0' }) == "")
                        {
                            MessageBox.Show("Round value has changed and it's no correct!");
                        }
                        else
                        {
                            Settings.Lines[Settings.Lines.Count - 4] = roundsTextBox.Text;
                        }
                    }

                    CustomRunForm crf = new CustomRunForm();
                    crf.Show();
                    this.Hide();
                }
            }
            // Loading a non intervall file
            else if (Settings.Lines.Count == 4 && Settings.LineCounter == 0)
            {
                if (Settings.Lines[Settings.Lines.Count - 4] != roundsTextBox.Text)
                {
                    if (roundsTextBox.Text == "" || roundsTextBox.Text.TrimStart(new Char[] { '0' }) == "")
                    {
                        MessageBox.Show("Round value has changed and it's no correct!");
                    }
                    else
                    {
                        Settings.Lines[Settings.Lines.Count - 4] = roundsTextBox.Text;
                    }
                }

                CustomRunForm crf = new CustomRunForm();
                crf.Show();
                this.Hide();
            }
        }
    }
}
