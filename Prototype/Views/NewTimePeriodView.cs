 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prototype.Objects;
using System.Text.RegularExpressions;

namespace Prototype.Views
{
    /// <summary>
    /// A view that allows the user to create a new timeperiod
    /// </summary>
    public partial class NewTimePeriodView : Form
    {
        private StartView startView;

        public NewTimePeriodView(StartView start)
        {
            startView = start;
            InitializeComponent();

            createTimePerioddataGridView.Rows[0].Cells[0].Value = "Day 1";
        }

        private void buttonGenerateRandom_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(timePeriodLength.Value) < 1 || Convert.ToInt32(personsPerShiftMax.Value) < 1)
            {
                MessageBox.Show("Both values must be larger than 0");
                return;
            }

            //Generates the new timeperiod with the selected length and max amount of persons per shift
            startView.TimePeriod = new TimePeriod(Convert.ToInt32(timePeriodLength.Value), Convert.ToInt32(personsPerShiftMax.Value));

            Close();
        }

        private void createRandomCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Shows the datagrid if user wants to create timeperiod by himself

            if((sender as CheckBox).Checked == true)
            {
                labelLengthInDays.Enabled = true;
                labelMaxAmount.Enabled = true;
                timePeriodLength.Enabled = true;
                personsPerShiftMax.Enabled = true;
                buttonGenerateRandom.Enabled = true;
                createTimePerioddataGridView.Visible = false;
                buttonCreateByUser.Visible = false;
            }
            else
            {
                labelLengthInDays.Enabled = false;
                labelMaxAmount.Enabled = false;
                timePeriodLength.Enabled = false;
                personsPerShiftMax.Enabled = false;
                buttonGenerateRandom.Enabled = false;
                createTimePerioddataGridView.Visible = true;
                buttonCreateByUser.Visible = true;
            }
        }

        private void createTimePerioddataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // Adds the number of the day to datagrids first column

            createTimePerioddataGridView.Rows[createTimePerioddataGridView.Rows.Count - 1].Cells[0].Value = "Day " + createTimePerioddataGridView.Rows.Count.ToString();
        }

        private void createTimePerioddataGridView_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            // Checking if the user inputs are correct

            if (createTimePerioddataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString() == ""
                || e.ColumnIndex == 0)
            {
                createTimePerioddataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                return;
            }

            var patternNumeric = @"([0-9])+";
            var regex = new Regex(patternNumeric);
            Match match = regex.Match(createTimePerioddataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString());
            if (!match.Success)
            {
                createTimePerioddataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
            }
            else if(match.Success)
            {
                int value = Convert.ToInt32(createTimePerioddataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString());

                if(value < 0)
                    createTimePerioddataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                else
                    createTimePerioddataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
            }
        }

        private void buttonCreateByUser_Click(object sender, EventArgs e)
        {
            // Creates the timeperiod

            if(CheckDataGrid() == true)
            {
                startView.TimePeriod = new TimePeriod(createTimePerioddataGridView);
                Close();
            }
            else
            {
                MessageBox.Show("One or more cell values are invalid");
            }
        }

        /// <summary>
        /// Checks if the user has made correct inputs
        /// </summary>
        /// <returns>True if correct, else false</returns>
        private bool CheckDataGrid()
        {
            foreach(DataGridViewRow row in createTimePerioddataGridView.Rows)
            {
                foreach(DataGridViewCell cell in row.Cells)
                {
                    if (cell.Style.BackColor == Color.Red)
                        return false;
                }
            }

            return true;
        }
    }
}