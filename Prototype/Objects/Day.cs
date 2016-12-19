using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Objects
{
    /// <summary>
    /// One day
    /// </summary>
    [Serializable]
    public class Day
    {
        private List<Shift> shifts;
        private int id;

        /// <summary>
        /// Creates a new day
        /// </summary>
        /// <param name="personnelPerShift">The max amount of personnel per shift</param>
        /// <param name="id">The ID of this day</param>
        public Day(int personnelPerShift, int id)
        {
            shifts = new List<Shift>(3);
            this.id = id;
            CreateRandomShifts(personnelPerShift);
        }

        /// <summary>
        /// Creates a new day
        /// </summary>
        /// <param name="first">Person requirement for first shift</param>
        /// <param name="second">Person requirement for second shift</param>
        /// <param name="third">Person requirement for third shift</param>
        /// <param name="id">The ID of this day</param>
        public Day(int first, int second, int third, int id)
        {
            shifts = new List<Shift>(3);
            this.id = id;
            CreateShifts(first, second, third);
        }

        /// <summary>
        /// Returns the ID of this day
        /// </summary>
        public int ID { get { return id; } }
        
        /// <summary>
        /// Returns the list of the 3 shifts of this day
        /// </summary>
        public List<Shift> Shifts { get { return shifts; } }

        /// <summary>
        /// Returns this day's total personnel requirement (sum of each shifts requirement). Recalculated every time it is called
        /// </summary>
        public int PersonnelRequirement
        {
            get
            {
                int count = 0;
                foreach(Shift shift in shifts)
                {
                    count = count + shift.PersonnelRequirement;
                }
                return count;
            }
        }

        #region private methods

        /// <summary>
        /// Creates the 3 random shifts for this day
        /// </summary>
        /// <param name="personnelPerShift">The maximum amount personnel per one shift</param>
        private void CreateRandomShifts(int personnelPerShift)
        {
            //Always 3 shifts per day
            for (int i = 0; i < 3; i++)
            {
                //Generating random number for personnelrequirement
                int number = Extensions.Extensions.Rand.Next(0, personnelPerShift + 1);

                shifts.Add(new Shift(number, this, i+1));
            }
        }

        /// <summary>
        /// Creates the 3 user defined shifts for this day
        /// </summary>
        /// <param name="first">First shift person count</param>
        /// <param name="second">Second shift person count</param>
        /// <param name="third">Third shift person count</param>
        private void CreateShifts(int first, int second, int third)
        {
            shifts.Add(new Shift(first, this, 1));
            shifts.Add(new Shift(second, this, 2));
            shifts.Add(new Shift(third, this, 3));
        }

        #endregion
    }
}
