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

namespace Prototype.Views
{
    public partial class TimePeriodView : Form
    {
        public TimePeriodView(TimePeriod timePeriod)
        {
            InitializeComponent();
            CreateView(timePeriod);
        }

        private void CreateView(TimePeriod timePeriod)
        {
            //Creates a view of the current timeperiod

            foreach (Objects.Day day in timePeriod.Days)
            {
                int row = dataGridView.Rows.Add();

                dataGridView.Rows[row].Cells[0].Value = "Day " + (row + 1).ToString();
                dataGridView.Rows[row].Cells[1].Value = day.Shifts[0].PersonnelRequirement.ToString();
                dataGridView.Rows[row].Cells[2].Value = day.Shifts[1].PersonnelRequirement.ToString();
                dataGridView.Rows[row].Cells[3].Value = day.Shifts[2].PersonnelRequirement.ToString();
            }
        }
    }
}
