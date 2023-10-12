using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Linq;

namespace KBSzamlalo
{
    public partial class CustomForm : Form
    {
        private int Rows = 0;
        private bool IsWork = false;
        private bool FinishedAdding = true;

        Point pos1 = new Point(50, 325);
        Point pos2 = new Point(75, 325);
        Point pos3 = new Point(135, 325);
        Point pos4 = new Point(175, 325);

        public CustomForm()
        {
            Settings.LineCounter = 0;
            InitializeComponent();
            LoadDefault();
        }

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

        private void plusWorkButton_Click(object sender, EventArgs e)
        {
            if (FinishedAdding)
            {
                Settings.LineCounter++;
                FinishedAdding = false;
            }

            IsWork = true;
            testMinTextBox.Text = "0";
            testSecTextBox.Text = "0";
            testMinTextBox.Show();
            testSecTextBox.Show();
            testOkPic.Show();
        }

        private void SortRows(int id)
        {
            int MultipleCounter = 0;

            for (int i = id; i < id + 4; i++)
            {
                Label lb = (Label)this.Controls["IDLabel" + i];
                lb.Location = new Point(pos1.X, pos1.Y + (MultipleCounter * 50));

                lb = (Label)this.Controls["TypeLabel" + i];
                lb.Location = new Point(pos2.X, pos2.Y + (MultipleCounter * 50));

                Button btn = (Button)this.Controls["UpArrow" + i];
                btn.Location = new Point(pos3.X, pos3.Y + (MultipleCounter * 50));

                btn = (Button)this.Controls["DownArrow" + i];
                btn.Location = new Point(pos4.X, pos4.Y + (MultipleCounter * 50));

                MultipleCounter++;
            }
        }

        private void DownArrow_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            for (int i = 1; i <= Rows; i++)
            {
                if (btn.Name == "DownArrow" + i)
                {
                    MessageBox.Show(i.ToString());
                    break;
                }
            }
        }

        private void plusRestButton_Click(object sender, EventArgs e)
        {
            if (FinishedAdding)
            {
                Settings.LineCounter++;
                FinishedAdding = false;
            }

            IsWork = false;
            testMinTextBox.Text = "0";
            testSecTextBox.Text = "0";
            testMinTextBox.Show();
            testSecTextBox.Show();
            testOkPic.Show();
        }

        private void testOkPic_Click(object sender, EventArgs e)
        {
            //OkButtonClicked = true;
            if ((Convert.ToInt32(testMinTextBox.Text) > 60 || Convert.ToInt32(testMinTextBox.Text) < 0) ||
                (Convert.ToInt32(testSecTextBox.Text) > 59 || Convert.ToInt32(testSecTextBox.Text) < 0))
            {
                MessageBox.Show("Wrong time data! Minutes can't have a negative value, seconds can't be bigger than 59!");
            }
            else
            {
                FinishedAdding = true;
                switch (Settings.LineCounter)
                {
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
                        edit1.Show();
                        remove1.Show();

                        Settings.Lines.Add(id1Label.Text);
                        Settings.Lines.Add(typeLabel1.Text);
                        Settings.Lines.Add(time1Label.Text);

                        break;

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
                        edit2.Show();
                        remove2.Show();

                        Settings.Lines.Add(id2Label.Text);
                        Settings.Lines.Add(typeLabel2.Text);
                        Settings.Lines.Add(time2Label.Text);

                        break;

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
                        edit3.Show();
                        remove3.Show();

                        Settings.Lines.Add(id3Label.Text);
                        Settings.Lines.Add(typeLabel3.Text);
                        Settings.Lines.Add(time3Label.Text);

                        break;

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
                        edit4.Show();
                        remove4.Show();

                        Settings.Lines.Add(id4Label.Text);
                        Settings.Lines.Add(typeLabel4.Text);
                        Settings.Lines.Add(time4Label.Text);

                        break;

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

                testMinTextBox.Hide();
                testSecTextBox.Hide();
                testOkPic.Hide();
            }
        }

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

        private void remove1_Click(object sender, EventArgs e)
        {
            RemoveLine(1);
            Settings.LineCounter--;
        }

        private void remove2_Click(object sender, EventArgs e)
        {
            RemoveLine(2);
            Settings.LineCounter--;
        }

        private void remove3_Click(object sender, EventArgs e)
        {
            RemoveLine(3);
            Settings.LineCounter--;
        }

        private void remove4_Click(object sender, EventArgs e)
        {
            RemoveLine(4);
            Settings.LineCounter--;
        }

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

            name = "edit" + LineID;
            pb = (PictureBox)this.Controls[name];
            pb.Hide();

            name = "remove" + LineID;
            pb = (PictureBox)this.Controls[name];
            pb.Hide();

        }

        // Works fine
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

        // Works fine
        public void RemoveSecond()
        {
            if (Settings.LineCounter == 2)
            {
                ClearRow(2);
                SortList(0, 2);
            }
            else
            {
                Label lb1 = (Label)this.Controls["id2Label"];
                int ItemID = Convert.ToInt32(lb1.Text);

                string name1, name2;

                if (Settings.LineCounter > 4)
                {
                    if (Settings.LineCounter - ItemID >= 3)
                    {
                        for (int i = 2; i < 4; i++)
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

                        int ListID = ((ItemID + 3) * 3) - 3;

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

                        SortList(Settings.LineCounter - ItemID, 2);
                    }
                    else
                    {
                        for (int i = 2; i < 4; i++)
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

                        Label lb = (Label)this.Controls["id1Label"];
                        if (Convert.ToInt32(lb.Text) != 1)
                        {
                            MoveList(1);
                        }

                        SortList(Settings.LineCounter - ItemID, 2);
                    }
                }
                else
                {
                    for (int i = ItemID; i < ItemID + (Settings.LineCounter - ItemID); i++)
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
                        if (Settings.LineCounter - ItemID >= 3)
                        {
                            int ListIndex = ((ItemID + 1) * 3) + 3;

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

                    SortList(Settings.LineCounter - ItemID, 2);
                }
            }
        }

        private void RemoveThird()
        {
            if (Settings.LineCounter == 3)
            {
                ClearRow(3);
                SortList(0, 3);
            }
            else
            {
                Label lb1 = (Label)this.Controls["id2Label"];
                int ItemID = Convert.ToInt32(lb1.Text);

                string name1, name2;

                if (Settings.LineCounter > 4)
                {
                    if (Settings.LineCounter - ItemID >= 2)
                    {
                        for (int i = ItemID; i < ItemID + 2; i++)
                        {
                            name1 = "id" + i + "Label";
                            name2 = "id" + (i + 1) + "Label";
                            lb1 = (Label)this.Controls[name1];
                            Label lb2 = (Label)this.Controls[name2];
                            lb1.Text = lb2.Text;

                            name1 = "typeLabel" + i;
                            name2 = "typeLabel" + (i + 1);
                            lb1 = (Label)this.Controls[name1];
                            lb2 = (Label)this.Controls[name2];
                            lb1.Text = lb2.Text;
                            lb1.ForeColor = lb2.ForeColor;

                            name1 = "time" + i + "Label";
                            name2 = "time" + (i + 1) + "Label";
                            lb1 = (Label)this.Controls[name1];
                            lb2 = (Label)this.Controls[name2];
                            lb1.Text = lb2.Text;
                        }

                        int ListID = ((ItemID + 3) * 3) - 3;

                        lb1 = (Label)this.Controls["id4Label"];
                        lb1.Text = Settings.Lines[ListID];

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

                        SortList(Settings.LineCounter - ItemID, 3);
                    }
                    else
                    {
                        for (int i = 3; i > 1; i--)
                        {
                            name1 = "id" + i + "Label";
                            name2 = "id" + (i - 1) + "Label";
                            lb1 = (Label)this.Controls[name1];
                            Label lb2 = (Label)this.Controls[name2];
                            lb2.Text = lb1.Text;

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
                        }

                        int ListID = ((ItemID - 3) * 3) - 3;

                        lb1 = (Label)this.Controls["id1Label"];
                        lb1.Text = Settings.Lines[ListID];

                        lb1 = (Label)this.Controls["typeLabel1"];
                        lb1.Text = Settings.Lines[ListID + 1];

                        if (lb1.Text == "work")
                        {
                            lb1.ForeColor = Color.White;
                        }
                        else
                        {
                            lb1.ForeColor = Color.Red;
                        }

                        lb1 = (Label)this.Controls["time1Label"];
                        lb1.Text = Settings.Lines[ListID + 2];

                        SortList(Settings.LineCounter - ItemID, 3);
                    }
                }
                else
                {
                    for (int i = ItemID; i < ItemID + (Settings.LineCounter - ItemID); i++)
                    {
                        name1 = "id" + i + "Label";
                        name2 = "id" + (i + 1) + "Label";
                        lb1 = (Label)this.Controls[name1];
                        Label lb2 = (Label)this.Controls[name2];
                        lb1.Text = lb2.Text;

                        name1 = "typeLabel" + i;
                        name2 = "typeLabel" + (i + 1);
                        lb1 = (Label)this.Controls[name1];
                        lb2 = (Label)this.Controls[name2];
                        lb1.Text = lb2.Text;
                        lb1.ForeColor = lb2.ForeColor;

                        name1 = "time" + i + "Label";
                        name2 = "time" + (i + 1) + "Label";
                        lb1 = (Label)this.Controls[name1];
                        lb2 = (Label)this.Controls[name2];
                        lb1.Text = lb2.Text;
                    }

                    ClearRow(Settings.LineCounter);
                    SortList(Settings.LineCounter - ItemID, 2);
                }
            }
        }

        private void RemoveLine(int LineID)
        {
            Debugger.Launch();
            switch (LineID)
            {
                case 1:
                    RemoveFirst();
                    break;

                case 2:
                    RemoveSecond();
                    break;

                case 3:
                    RemoveThird();
                    break;

                case 4:
                    RemoveLast();
                    break;
            }
        }

        private void RemoveLast()
        {
            Debugger.Launch();
            string name;

            for (int i = 3; i > 0; i--)
            {
                name = "id" + i + "Label";
                Label lb1 = (Label)this.Controls[name];

                name = name = "id" + (i + 1) + "Label";
                Label lb2 = (Label)this.Controls[name];

                lb2.Text = lb1.Text;

                name = "typeLabel" + i;
                lb1 = (Label)this.Controls[name];

                name = name = "typeLabel" + (i + 1);
                lb2 = (Label)this.Controls[name];

                lb2.Text = lb1.Text;
                lb2.ForeColor = lb1.ForeColor;

                name = "time" + i + "Label";
                lb1 = (Label)this.Controls[name];

                name = name = "time" + (i + 1) + "Label";
                lb2 = (Label)this.Controls[name];

                lb2.Text = lb1.Text;
            }

            name = "id1Label";
            Debugger.Launch();
            Label lb3 = (Label)this.Controls[name];
            int ListId = (Convert.ToInt32(lb3.Text) - 2) * 3;

            lb3 = (Label)this.Controls["id1Label"];
            lb3.Text = Settings.Lines[ListId];

            lb3 = (Label)this.Controls["typeLabel1"];
            lb3.Text = Settings.Lines[ListId + 1];

            if (lb3.Text == "work")
            {
                lb3.ForeColor = Color.White;
            }
            else
            {
                lb3.ForeColor = Color.Red;
            }

            lb3 = (Label)this.Controls["time1Label"];
            lb3.Text = Settings.Lines[ListId + 2];

            for (int i = 0; i < 3; i++)
            {
                Settings.Lines.RemoveAt(Settings.Lines.Count() - 1);
            }
        }

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

        private void moveListUpPic_Click(object sender, EventArgs e)
        {
            Label lb = (Label)this.Controls["id1Label"];
            if (Convert.ToInt32(lb.Text) != 1)
            {
                MoveList(1);
            }
        }

        private void moveListDownPic_Click(object sender, EventArgs e)
        {
            Label lb = (Label)this.Controls["id4Label"];
            if (Convert.ToInt32(lb.Text) < Settings.LineCounter)
            {
                MoveList(4);
            }
        }

        private void MoveList(int ListID)
        {
            Debugger.Launch();
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
                    Debugger.Launch();
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

        private void LoadIntervall()
        {
            roundsLabel.Show();
            roundsTextBox.Show();
            plusRestButton.Show();
            plusWorkButton.Show();
            rowCounterLabel.Show();
            moveListDownPic.Show();
            moveListUpPic.Show();

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

                    Name = "edit" + (i + 1);
                    pb = (PictureBox)this.Controls[Name];
                    pb.Show();

                    Name = "remove" + (i + 1);
                    pb = (PictureBox)this.Controls[Name];
                    pb.Show();
                }
            }
        }

        private void LoadDefault()
        {
            Settings.InterVall = false;

            roundsLabel.Hide();
            roundsTextBox.Hide();
            plusRestButton.Hide();
            plusWorkButton.Hide();
            rowCounterLabel.Hide();
            testOkPic.Hide();
            testMinTextBox.Hide();
            testSecTextBox.Hide();
            topLineLabel.Hide();
            bottomLineLabel.Hide();
            moveListDownPic.Hide();
            moveListUpPic.Hide();

            id1Label.Hide(); id2Label.Hide(); id3Label.Hide(); id4Label.Hide();

            typeLabel1.Hide(); typeLabel2.Hide(); typeLabel3.Hide(); typeLabel4.Hide();

            time1Label.Hide(); time2Label.Hide(); time3Label.Hide(); time4Label.Hide();

            downArrow1.Hide(); downArrow2.Hide(); downArrow3.Hide(); downArrow4.Hide();

            upArrow1.Hide(); upArrow2.Hide(); upArrow3.Hide(); upArrow4.Hide();

            duplicate1.Hide(); duplicate2.Hide(); duplicate3.Hide(); duplicate4.Hide();

            edit1.Hide(); edit2.Hide(); edit3.Hide(); edit4.Hide();

            remove1.Hide(); remove2.Hide(); remove3.Hide(); remove4.Hide();
        }
    }
}
