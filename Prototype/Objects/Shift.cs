using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Objects
{
    /// <summary>
    /// A shift
    /// </summary>
    [Serializable]
    public class Shift
    {
        private int personnelRequirement;
        private Day day;
        private List<Person> assignedPersons;
        private int id;

        /// <summary>
        /// Creates a new shift
        /// </summary>
        /// <param name="numberOfPersonnel">Number of personnel that this shift requires</param>
        public Shift(int numberOfPersonnel, Day day, int id)
        {
            this.day = day;
            personnelRequirement = numberOfPersonnel;
            assignedPersons = new List<Person>();
            this.id = id;
        }

        /// <summary>
        /// Returns the day that this shift is in
        /// </summary>
        public Day Day { get { return day; } }
        
        /// <summary>
        /// Returns the requirement of personnel of this shift
        /// </summary>
        public int PersonnelRequirement { get { return personnelRequirement; } }

        /// <summary>
        /// Returns a List of persons that are assigned to this shift
        /// </summary>
        public List<Person> AssignedPersons { get { return assignedPersons; } }

        /// <summary>
        /// Returns the id of this shift
        /// </summary>
        public int ID { get { return id; } }

        /// <summary>
        /// Returns he cost of this shift (difference between requirement of personnel and count of assigned persons)
        /// </summary>
        public int ConstraintCost { get { return Math.Abs(personnelRequirement - assignedPersons.Count); } }
    }
}
