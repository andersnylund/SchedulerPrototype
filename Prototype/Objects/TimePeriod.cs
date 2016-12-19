using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype.Objects
{
    /// <summary>
    /// A timeperiod object
    /// </summary>
    [Serializable]
    public class TimePeriod
    {
        private int lengthInDays;
        private int personnelPerShiftMax;
        private List<Day> days;
        private List<Person> availablePersons;

        /// <summary>
        /// Creates a new random timeperiod
        /// </summary>
        /// <param name="length">Length of this timeperiod in days</param>
        /// <param name="maxAmount">The maximum amount of persons per shift for this timeperiod</param>
        public TimePeriod(int length, int maxAmount)
        {
            lengthInDays = length;
            personnelPerShiftMax = maxAmount;
            days = new List<Day>();
            availablePersons = new List<Person>();
            CreateDays();
            CreatePersons();
        }

        /// <summary>
        /// Creates a new timeperiod from a dataGrid
        /// </summary>
        /// <param name="dataGrid">DataGrid to create from</param>
        public TimePeriod(DataGridView dataGrid)
        {
            days = new List<Day>();
            availablePersons = new List<Person>();
            CreateTimePeriodFromDataGrid(dataGrid);
            lengthInDays = days.Count;
            CreatePersons();
        }

        /// <summary>
        /// Returns the total length of this timeperiod in days
        /// </summary>
        public int LengthInDays { get { return lengthInDays; } }

        /// <summary>
        /// Returns the list of the days in this timeperiod
        /// </summary>
        public List<Day> Days { get { return days; } }

        /// <summary>
        /// Returns the list of persons that are available for shifts in this timeperiod
        /// </summary>
        public List<Person> AvailablePersons { get { return availablePersons; } }

        /// <summary>
        /// Returns the maximum amount of persons a shift can have in this timeperiod
        /// </summary>
        public int PersonsPerShiftMax { get { return personnelPerShiftMax; } }

        /// <summary>
        /// Adds the days to the list of days
        /// </summary>
        private void CreateDays()
        {
            for(int i = 0; i < lengthInDays; i++)
            {
                days.Add(new Day(personnelPerShiftMax, i+1));
            }
        }

        /// <summary>
        /// Creates the required amount of persons to this timeperiod.
        /// </summary>
        private void CreatePersons()
        {
            // The prosess of creating the available persons searches for the day with largest total (all 3 shifts of that day) amount of required personnel
            // This is, because a person can only be assigned to one shift per day

            int maxPersonnelRequirement = 0;
            foreach (Day day in days)
            {
                if (day.PersonnelRequirement > maxPersonnelRequirement)
                    maxPersonnelRequirement = day.PersonnelRequirement;
            }

            for (int i = 0; i < maxPersonnelRequirement; i++)
            {
                availablePersons.Add(new Person(i + 1));
            }
        }

        /// <summary>
        /// Creates a user defined timeperiod from a datagrid
        /// </summary>
        /// <param name="dataGrid">DataGrid to create from</param>
        private void CreateTimePeriodFromDataGrid(DataGridView dataGrid)
        {
            // For setting the maximum amount of persons per shift to the start view
            int maxPersonsPerShift = 0;

            // Iterate trough every row (day) in datagrid 
            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                int firstShift;
                int secondShift;
                int thirdShift;

                // First shift
                if (dataGrid.Rows[i].Cells[1].Value == null)
                    firstShift = 0;
                else
                {
                    firstShift = Convert.ToInt32(dataGrid.Rows[i].Cells[1].Value.ToString());
                    if (firstShift > maxPersonsPerShift)
                        maxPersonsPerShift = firstShift;
                }

                // Second shift
                if (dataGrid.Rows[i].Cells[2].Value == null)
                    secondShift = 0;
                else
                {
                    secondShift = Convert.ToInt32(dataGrid.Rows[i].Cells[2].Value.ToString());
                    if (secondShift > maxPersonsPerShift)
                        maxPersonsPerShift = secondShift;
                }

                // Third shift
                if (dataGrid.Rows[i].Cells[3].Value == null)
                    thirdShift = 0;
                else
                {
                    thirdShift = Convert.ToInt32(dataGrid.Rows[i].Cells[3].Value.ToString());
                    if (thirdShift > maxPersonsPerShift)
                        maxPersonsPerShift = thirdShift;
                }

                // Check if this is the last row
                if (firstShift == 0 && secondShift == 0 && thirdShift == 0 && i == dataGrid.Rows.Count - 1)
                    continue;

                // Add a new day to the timeperiod
                days.Add(new Day(firstShift, secondShift, thirdShift, i + 1));
            }

            // Set the biggest found count of persons on a shift
            personnelPerShiftMax = maxPersonsPerShift;
        }
    }
}
