using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBSzamlalo
{
    public partial class CustomForm : Form
    {
        private List<string> RowDatas = new List<string>();
        private bool IsIntervall = false;
        private int Rows = 0;
        private int CurrentListCount = 0;

        Point pos1 = new Point(50, 325);
        Point pos2 = new Point(75, 325);
        Point pos3 = new Point(135, 325);
        Point pos4 = new Point(175, 325);

        public CustomForm()
        {
            InitializeComponent();
        }

        private void customHourTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void doublePointLabel_Click(object sender, EventArgs e)
        {
        }

        private void customMinutesTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void xPictureBox_Click(object sender, EventArgs e)
        {
            if (!IsIntervall)
            {
                xPictureBox.Image = KBSzamlalo.Properties.Resources.x;
                IsIntervall = true;
            }
            else
            {
                xPictureBox.Image = KBSzamlalo.Properties.Resources.black;
                IsIntervall = false;
            }

            roundsLabel.Show();
            roundsTextBox.Show();
            plusRestButton.Show();
            plusWorkButton.Show();
        }

        private void plusWorkButton_Click(object sender, EventArgs e)
        {
            Rows++;

            CurrentListCount++;

            string Names;

            Point point = new Point();
            point = roundsLabel.Location;

            Names = "IDLabel" + Rows;
            Label mylabNumber = new Label();
            mylabNumber.Name = Names;
            mylabNumber.Text = Rows.ToString();
            mylabNumber.Location = new Point(point.X, point.Y + CurrentListCount * 50);
            mylabNumber.AutoSize = true;
            mylabNumber.Font = new Font("Calibri", 14);
            mylabNumber.ForeColor = Color.White;
            this.Controls.Add(mylabNumber);

            Names = "TypeLabel" + Rows;
            Label mylabType = new Label();
            mylabType.Name = Names;
            mylabType.Text = "work";
            mylabType.Location = new Point(point.X + 25, point.Y + CurrentListCount * 50);
            mylabType.AutoSize = true;
            mylabType.Font = new Font("Calibri", 14);
            mylabType.ForeColor = Color.White;
            this.Controls.Add(mylabType);

            Names = "UpArrow" + Rows;
            Button UpArrow = new Button();
            UpArrow.Name = Names;
            UpArrow.Image = KBSzamlalo.Properties.Resources.upArrow;
            UpArrow.Location = new Point(point.X + 85, point.Y + CurrentListCount * 50);
            UpArrow.Size = new Size(25, 25);
            this.Controls.Add(UpArrow);

            Names = "DownArrow" + Rows;
            Button DownArrow = new Button();
            DownArrow.Name = Names;
            DownArrow.Image = KBSzamlalo.Properties.Resources.downArrow;
            DownArrow.Location = new Point(point.X + 125, point.Y + CurrentListCount * 50);
            DownArrow.Size = new Size(25, 25);
            DownArrow.Click += new EventHandler(DownArrow_Click);
            this.Controls.Add(DownArrow);

            RowDatas.Add(mylabNumber.Name);
            RowDatas.Add(mylabType.Text);

            rowCounterLabel.Text = "Rows: " + Rows;

            if (CurrentListCount > 4)
            {
                HideFirst(Rows - 4);
                SortRows(Rows - 3);
                CurrentListCount--;
            }
        }

        private void SortRows(int id)
        {
            int MultipleCounter = 0;

            for(int i = id; i < id + 4; i++)
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

        private void HideFirst(int id)
        {
            string Name;

            Name = "IDLabel" + id;
            Label lb = (Label)this.Controls[Name];
            lb.Hide();

            Name = "TypeLabel" + id;
            lb = (Label)this.Controls[Name];
            lb.Hide();

            Name = "UpArrow" + id;
            Button btn = (Button)this.Controls[Name];
            btn.Hide();

            Name = "DownArrow" + id;
            btn = (Button)this.Controls[Name];
            btn.Hide();
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
            Rows++;
            string Names;

            Point point = new Point();
            point = roundsLabel.Location;

            Names = "IDLabel" + Rows;
            Label mylabNumber = new Label();
            mylabNumber.Name = Names + Rows;
            mylabNumber.Text = Rows.ToString();
            mylabNumber.Location = new Point(point.X, point.Y + Rows * 50);
            mylabNumber.AutoSize = true;
            mylabNumber.Font = new Font("Calibri", 14);
            mylabNumber.ForeColor = Color.White;
            this.Controls.Add(mylabNumber);

            Names = "IDLabel" + Rows;
            Label mylabType = new Label();
            mylabType.Name = Names;
            mylabType.Text = "rest";
            mylabType.Location = new Point(point.X + 25, point.Y + Rows * 50);
            mylabType.AutoSize = true;
            mylabType.Font = new Font("Calibri", 14);
            mylabType.ForeColor = Color.Red;
            this.Controls.Add(mylabType);

            Names = "UpArrow" + Rows;
            Button UpArrow = new Button();
            UpArrow.Name = Names;
            UpArrow.Image = KBSzamlalo.Properties.Resources.upArrow;
            UpArrow.Location = new Point(point.X + 85, point.Y + Rows * 50);
            UpArrow.Size = new Size(25, 25);
            this.Controls.Add(UpArrow);

            Names = "DownArrow" + Rows;
            Button DownArrow = new Button();
            DownArrow.Name = Names;
            DownArrow.Image = KBSzamlalo.Properties.Resources.downArrow;
            DownArrow.Location = new Point(point.X + 125, point.Y + Rows * 50);
            DownArrow.Size = new Size(25, 25);
            DownArrow.Click += new EventHandler(DownArrow_Click);
            this.Controls.Add(DownArrow);

            RowDatas.Add(mylabNumber.Name);
            RowDatas.Add(mylabType.Text);
        }
    }
}
