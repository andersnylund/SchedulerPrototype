using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Objects
{
    /// <summary>
    /// A person object
    /// </summary>
    [Serializable]
    public class Person
    {
        private int id;
        private List<Shift> assignedShifts;
        private int constraintCost;
        private int objectiveCost;

        /// <summary>
        /// Creates a new person
        /// </summary>
        /// <param name="id">Unique ID of this person</param>
        public Person(int id)
        {
            assignedShifts = new List<Shift>();
            this.id = id;
        }

        /// <summary>
        /// Returns the ID of this person
        /// </summary>
        public int ID { get { return id; } }

        /// <summary>
        /// Returns the shifts that are assigned to this person
        /// </summary>
        public List<Shift> AssignedShifts { get { return assignedShifts; } }

        /// <summary>
        /// Returns the constraint-cost of this person
        /// </summary>
        public int ConstraintCost { get { return constraintCost; } }

        /// <summary>
        /// Returns the objective-cost of this person
        /// </summary>
        public int ObjectiveCost { get { return objectiveCost; } }

        /// <summary>
        /// Calculates the constraint cost of this person
        /// </summary>
        public void CalculateConstraintCost()
        {
            // A HashSet can't contain more than 1 instance of the same object
            // Therefore adding all this person's assigned days to the HashSet "checkedDays" will result in only unique days in the collection
            HashSet<Day> checkedDays = new HashSet<Day>();

            foreach (Shift shift in assignedShifts)
            {
                checkedDays.Add(shift.Day);
            }

            // Return the difference of the count of assigned shifts and the count of checked days
            constraintCost = Math.Abs(assignedShifts.Count - checkedDays.Count);
        }

        /// <summary>
        /// Calculates the objective cost of this person
        /// </summary>
        public void CalculateObjectiveCost()
        {
            int cost = 0;

            // No need to calculate if shift count <= 1
            if (assignedShifts.Count <= 1)
            {
                objectiveCost = 0;
                return;
            }

            if (assignedShifts.Count <= 5)
            {
                // A list of every shift's day's IDs
                List<int> dayIDs = new List<int>();
                // A list of every shift's IDs
                List<int> shiftIDs = new List<int>();

                // Add the IDs
                foreach (Shift shift in assignedShifts)
                {
                    shiftIDs.Add(shift.ID);
                    dayIDs.Add(shift.Day.ID);
                }

                // Find the most occuring shift ID
                // http://stackoverflow.com/questions/355945/find-the-most-occurring-number-in-a-listint
                int mostOccuring = shiftIDs.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();

                // Iterate the list and add one cost if the ID differs from the mostOccuring
                foreach (int shiftID in shiftIDs)
                {
                    if (shiftID != mostOccuring)
                        cost = cost + 1;
                }

                dayIDs.Sort();
                int firstDaysID = assignedShifts.First().Day.ID;

                // Check for missing number sequence: http://stackoverflow.com/questions/2475795/check-for-missing-number-in-sequence
                cost = cost + Enumerable.Range(firstDaysID, assignedShifts.Count).Except(dayIDs).Count();
            }

            else
            {
                // Sort assigned shifts based on the shift's day's ID
                assignedShifts.Sort((x, y) => x.Day.ID.CompareTo(y.Day.ID));

                // Create a new list of weeks
                List<Week> weeks = new List<Week>();

                // Get the required minimum amount of weeks the shifts can be placed on
                int numberOfWeeks = (int)Math.Ceiling((double)assignedShifts.Count / 5);
                if ((double)assignedShifts.Count / 7 >= numberOfWeeks && (double)assignedShifts.Count / 5 <= numberOfWeeks)
                    numberOfWeeks = numberOfWeeks - 1;

                // The number of shifts to the week that has not the full amount of 5 shifts
                int remainder = assignedShifts.Count % 5;

                if(remainder != 0)
                {
                    // Distribute the shift-count to the weeks
                    for (int i = 0; i < numberOfWeeks - 1; i++)
                    {
                        weeks.Add(new Week(5));
                    }

                    // Add the last odd week
                    weeks.Add(new Week(remainder));
                }

                else
                {
                    // Distribute the shift-count to the weeks
                    for (int i = 0; i < numberOfWeeks; i++)
                    {
                        weeks.Add(new Week(5));
                    }
                }

                // Shuffle the list
                weeks = Extensions.Extensions.Shuffle(weeks);

                // A pointer for going trough all assigned shifts
                int pointer = 0;

                foreach (Week week in weeks)
                {
                    week.Shifts = assignedShifts.GetRange(pointer, week.shiftCount);
                    pointer = pointer + week.shiftCount;
                }

                // Last week for checking length between weeks in days
                Week lastWeek = weeks.First();

                // Calculate the cost for each week
                foreach (Week week in weeks)
                {
                    // Calculate only if there is shifts in week
                    if (week.Shifts.Count > 0)
                    {
                        if (week != lastWeek && week.Shifts.Count > 0 && lastWeek.Shifts.Count > 0)
                        {
                            // Add cost if last week's last day is less or more than 2 days from this weeks first day
                            cost = cost + Math.Abs(3 - (week.Shifts.First().Day.ID - lastWeek.Shifts.Last().Day.ID));
                            // BUG: Created a random timeperiod with 20 days and 4 people. 
                            // After ~3500 generations an InvalidOperationException occured here.
                        }

                        // A list of this weeks shift's day's IDs
                        List<int> dayIDs = new List<int>();
                        // A list of this weeks shift's IDs
                        List<int> shiftIDs = new List<int>();

                        // Add the IDs
                        foreach (Shift shift in week.Shifts)
                        {
                            shiftIDs.Add(shift.ID);
                            dayIDs.Add(shift.Day.ID);
                        }

                        // Find the most occuring shift ID
                        // http://stackoverflow.com/questions/355945/find-the-most-occurring-number-in-a-listint

                    
                        int mostOccuring = shiftIDs.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();

                        // Iterate the list and add one cost if the ID differs from the mostOccuring
                        foreach (int shiftID in shiftIDs)
                        {
                            if (shiftID != mostOccuring)
                                cost = cost + 1;
                        }

                        dayIDs.Sort();
                        int firstDayID = week.Shifts.First().Day.ID;

                        // Check for missing number sequence: http://stackoverflow.com/questions/2475795/check-for-missing-number-in-sequence
                        cost = cost + Enumerable.Range(firstDayID, week.Shifts.Count).Except(dayIDs).Count();
                    }
                }
            }

            objectiveCost = cost;
        }

        /// <summary>
        /// Help class for calculating objective cost
        /// </summary>
        private class Week
        {
            public List<Shift> Shifts;
            public int shiftCount;

            public Week(int shiftCount)
            {
                this.shiftCount = shiftCount;
                Shifts = new List<Shift>();
            }
        }

        /// <summary>
        /// Assigns this person to a shift
        /// </summary>
        /// <param name="shift">The shift to assign the person to</param>
        public void AssignToShift(Shift shift)
        {
            //Add shift to persons personal shifts
            assignedShifts.Add(shift);

            //Add this person to shift
            shift.AssignedPersons.Add(this);
        }

        /// <summary>
        /// Unassigns this person from a shift
        /// </summary>
        /// <param name="shift">Shift to unassign from</param>
        public void UnAssignFromShift(Shift shift)
        {
            assignedShifts.Remove(shift);

            shift.AssignedPersons.Remove(this);
        }
    }
}

//*******************************************************
// Old variant of dividing shift to weeks. Saving if it will be considered better than the new version



//for (int i = 0; i < numberOfWeeks; i++)
//{
//    // Amount of shifts to be placed to week
//    int nextWeeksShifts = 0;

//    // Check if 5 or more shifts are left and if true, remove the amount (5) that was used
//    if (shiftsLeft >= 5)
//    {
//        nextWeeksShifts = 5;
//        shiftsLeft = shiftsLeft - 5;
//    }
//    // If less than 5 left, place the remaining to the last week
//    else
//        nextWeeksShifts = shiftsLeft;

//    // Create a week by getting a range from assigned shifts
//    // Start week from where pointer is and end based on how many shifts are left
//    Week week = new Week(assignedShifts.GetRange(pointer, nextWeeksShifts));
//    weeks.Add(week);

//    // Increase the pointer with 5
//    pointer = pointer + 5;
//}

////Old constructor
//public Week(List<Shift> shifts)
//{
//    Shifts = shifts;
//}

// Amount of shifts that has not been placed in a week
// int shiftsLeft = assignedShifts.Count;


//*************************************************


