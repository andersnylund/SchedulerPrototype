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
using Prototype.Optimization;

namespace Prototype.Views
{
    /// <summary>
    /// A window that can display one chromosome at a time
    /// </summary>
    public partial class FittestChromosomeView : Form
    {
        public FittestChromosomeView(FittestChromosome fittest)
        {
            InitializeComponent();

            // THIS CAN CAUSE PROBLEMS! Order every persons shift assignments
            OrderPersonsShifts(fittest.Chromosome.TimePeriod);

            // Add information to the datagrids
            CreateResultsDataGrid(fittest);
        }

        /// <summary>
        /// Creates a new resultview with the generated timeperiod
        /// </summary>
        /// <param name="fittest"></param>
        private void CreateResultsDataGrid(FittestChromosome fittest)
        {
            //Creating shift assignment datagrid
            foreach (Objects.Day day in fittest.Chromosome.TimePeriod.Days)
            {
                int row = shiftGridView.Rows.Add();

                shiftGridView.Rows[row].Cells[0].Value = "Day " + (row + 1).ToString();
                shiftGridView.Rows[row].Cells[1].Value = day.Shifts[0].PersonnelRequirement.ToString();
                shiftGridView.Rows[row].Cells[2].Value = day.Shifts[1].PersonnelRequirement.ToString();
                shiftGridView.Rows[row].Cells[3].Value = day.Shifts[2].PersonnelRequirement.ToString();

                shiftGridView.Rows[row].Cells[4].Value = day.Shifts[0].AssignedPersons.Count.ToString();
                shiftGridView.Rows[row].Cells[5].Value = day.Shifts[1].AssignedPersons.Count.ToString();
                shiftGridView.Rows[row].Cells[6].Value = day.Shifts[2].AssignedPersons.Count.ToString();
            }

            CheckShiftAssignments();

            //Creating person assignment datagrid
            foreach (Person person in fittest.Chromosome.TimePeriod.AvailablePersons)
            {
                int row = personGridView.Rows.Add();

                personGridView.Rows[row].Cells[0].Value = "Person " + person.ID.ToString();
                personGridView.Rows[row].Cells[1].Value = person.AssignedShifts.Count.ToString();

                foreach(Shift assignedShift in person.AssignedShifts)
                {
                    personGridView.Rows[row].Cells[2].Value = personGridView.Rows[row].Cells[2].Value + "Day " + assignedShift.Day.ID.ToString() + " Shift " + assignedShift.ID.ToString() + "    ";
                }
            }

            CheckPersonAssignments(fittest.Chromosome.TimePeriod);

            //Adding the costs and other information of this solution to the resultview
            shiftAssignmentCostTextBox.Text = fittest.Chromosome.ShiftAssignmentConstraintCost.ToString();
            personAssignmentCostTextBox.Text = fittest.Chromosome.PersonAssignmentConstraintCost.ToString();
            generationTextBox.Text = fittest.Generation.ToString();
            timeTextBox.Text = fittest.TimeToFind.ToString();
            objectiveCostTextBox.Text = fittest.Chromosome.ObjectiveCost.ToString();
            calculationSpeedTextBox.Text = ((double)fittest.Generation / (double)fittest.TimeToFind.TotalSeconds).ToString();
        }

        //Closes the resultview
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Checks if the assignments of shifts are correct and colours them
        /// </summary>
        private void CheckShiftAssignments()
        {
            foreach(DataGridViewRow row in shiftGridView.Rows)
            {
                if (Convert.ToInt32(row.Cells[1].Value) != Convert.ToInt32(row.Cells[4].Value))
                    row.Cells[4].Style.BackColor = Color.Red;
                else
                    row.Cells[4].Style.BackColor = Color.Green;

                if (Convert.ToInt32(row.Cells[2].Value) != Convert.ToInt32(row.Cells[5].Value))
                    row.Cells[5].Style.BackColor = Color.Red;
                else
                    row.Cells[5].Style.BackColor = Color.Green;

                if (Convert.ToInt32(row.Cells[3].Value) != Convert.ToInt32(row.Cells[6].Value))
                    row.Cells[6].Style.BackColor = Color.Red;
                else
                    row.Cells[6].Style.BackColor = Color.Green;
            }
        }

        /// <summary>
        /// Checks if the assignments of shifts to persons satisfies the objective-function
        /// </summary>
        /// <param name="timePeriod">TimePeriod of the chromosome</param>
        private void CheckPersonAssignments(TimePeriod timePeriod)
        {
            foreach(Person person in timePeriod.AvailablePersons)
            {
                if(person.ObjectiveCost != 0)
                {
                    personGridView.Rows[person.ID - 1].Cells[2].Style.BackColor = Color.Red;
                }

                else
                {
                    personGridView.Rows[person.ID - 1].Cells[2].Style.BackColor = Color.Green;
                }
            }
        }

        /// <summary>
        /// Orders the persons shifts so it becomes more readable
        /// </summary>
        /// <param name="timePeriod">The timeperiod of the chromosome</param>
        private void OrderPersonsShifts(TimePeriod timePeriod)
        {
            foreach(Person person in timePeriod.AvailablePersons)
            {
                person.AssignedShifts.Sort((x, y) => x.Day.ID.CompareTo(y.Day.ID));
            }
        }
    }
}
