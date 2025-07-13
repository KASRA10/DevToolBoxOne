// Ignore Spelling: Shamsi FRM

using System;
using System.Windows.Forms;

namespace DevToolBoxOne.Forms.Converter
{
    public partial class ShamsiDate_FRM : Form
    {
        public ShamsiDate_FRM()
        {
            InitializeComponent();
        }

        private void InsertDate_BTN_Click(object sender, EventArgs e)
        {
            int _year = 0;
            int _CorrentYear = DateTime.Now.Year;
            int _month = 0;
            int _day = 0;

            if (string.IsNullOrWhiteSpace(Year_TB.Text))
            {
                DialogResult result = MessageBox.Show("Year Is Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {

                    _year = int.Parse(Year_TB.Text);
                    if (_year < 1900 || _year > _CorrentYear)
                    {
                        DialogResult result = MessageBox.Show($"Year should be Between 1900 and {_CorrentYear}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Year_TB.Clear();
                        return;
                    }
                }
                catch (Exception ex)
                {

                    DialogResult result = MessageBox.Show($"Please Enter Correct Number Of Year\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(Month_TB.Text))
            {
                DialogResult result = MessageBox.Show("Month Is Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    _month = int.Parse(Month_TB.Text);
                    if (_month < 1 || _month > 12)
                    {
                        DialogResult result = MessageBox.Show("Month should be Between 1 and 12", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Month_TB.Clear();
                        return;
                    }
                }
                catch (Exception ex)
                {

                    DialogResult result = MessageBox.Show($"Please Enter Correct Number Of Month\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(Day_TB.Text))
            {
                DialogResult result = MessageBox.Show("Day Is Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    _day = int.Parse(Day_TB.Text);
                    if (_day < 1 || _day > 31)
                    {
                        DialogResult result = MessageBox.Show("Day should be Between 1 and 31", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Day_TB.Clear();
                        return;
                    }
                }
                catch (Exception ex)
                {

                    DialogResult result = MessageBox.Show($"Please Enter Correct Number Of Day\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

            if (_year != 0 && _month != 0 && _day != 0)
            {
                UserDate_LBL.Text = $"{_day}/{_month}/{_year}";
                UserDate_LBL.Refresh();
            }
        }
    }
}