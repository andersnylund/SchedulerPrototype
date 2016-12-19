using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype.Objects;
using Prototype.Views;

namespace Prototype.Optimization
{
    /// <summary>
    /// A chromosome
    /// </summary>
    public class Chromosome
    {
        private TimePeriod timePeriod;
        private int shiftAssignmentConstraintCost;
        private int personAssignmentConstraintCost;
        private int objectiveCost;
        

        /// <summary>
        /// Creates a new random chromosome from the passed timeperiod
        /// </summary>
        /// <param name="timePeriod">The timeperiod from which the chromosome will be created</param>
        public Chromosome(TimePeriod timePeriod)
        {
            this.timePeriod = Extensions.Extensions.DeepClone(timePeriod);
            AssignPersonsToShiftsRandomly();
            // Calculate all costs at he creation of a chromosome
            CalculateAllCosts();
        }

        /// <summary>
        /// Creates a new chromosome based on an old chromosome
        /// </summary>
        /// <param name="oldChromosome">The old chromosome</param>
        public Chromosome(Chromosome oldChromosome)
        {
            timePeriod = Extensions.Extensions.DeepClone(oldChromosome.timePeriod);

            // This decides what kind of "mutation" happens
            if (oldChromosome.TotalConstraintCost != 0)
            {
                Mutate();
                // Dont calculate objective cost if totalConstraintCost != 0
                CalculatePersonAssignmentConstraintCost();
                CalculateShiftAssignmentConstraintCost();
                objectiveCost = int.MaxValue;
            }
            else
            {
                // Calculate all costs if totalConstraintCost is 0
                SwapShifts();
                CalculateAllCosts();
            }
        }

        /// <summary>
        /// Returns this chromosomes version of the timeperiod
        /// </summary>
        public TimePeriod TimePeriod { get { return timePeriod; } }

        /// <summary>
        /// Returns the constraint-cost of shift assignments of this chromosome
        /// </summary>
        public int ShiftAssignmentConstraintCost { get { return shiftAssignmentConstraintCost; } }

        /// <summary>
        /// Returns the constraint-cost of person assignments of this chromosome
        /// </summary>
        public int PersonAssignmentConstraintCost { get { return personAssignmentConstraintCost; } }

        /// <summary>
        /// Returns the total constraint-cost of this chromosome
        /// </summary>
        public int TotalConstraintCost { get { return PersonAssignmentConstraintCost + ShiftAssignmentConstraintCost; } }

        /// <summary>
        /// Returns the objective-cost of this chromosome
        /// </summary>
        public int ObjectiveCost { get { return objectiveCost; } }

        /// <summary>
        /// Calculates all the costs
        /// </summary>
        private void CalculateAllCosts()
        {
            // This is the only method that should be used
            CalculatePersonAssignmentConstraintCost();
            CalculateShiftAssignmentConstraintCost();
            CalculateObjectiveCost();
        }

        /// <summary>
        /// Calculates the shiftAssignmentConstraintCost
        /// </summary>
        private void CalculateShiftAssignmentConstraintCost()
        {
            //Calculating the shift assignment constraint-cost
            shiftAssignmentConstraintCost = 0;
            foreach (Day day in timePeriod.Days)
            {
                foreach (Shift shift in day.Shifts)
                {
                    shiftAssignmentConstraintCost = shiftAssignmentConstraintCost + shift.ConstraintCost;
                }
            }
        }

        /// <summary>
        /// Calculates the personAssigmentConstraintCost
        /// </summary>
        private void CalculatePersonAssignmentConstraintCost()
        {
            // Calculating the person assignment constraint-cost
            personAssignmentConstraintCost = 0;
            foreach (Person person in timePeriod.AvailablePersons)
            {
                person.CalculateConstraintCost();
                personAssignmentConstraintCost = personAssignmentConstraintCost + person.ConstraintCost;
            }
        }

        /// <summary>
        /// Calcualtes the objective cost
        /// </summary>
        private void CalculateObjectiveCost()
        {
            // Calculating objective-cost
            objectiveCost = 0;
            foreach (Person person in timePeriod.AvailablePersons)
            {
                person.CalculateObjectiveCost();
                objectiveCost = objectiveCost + person.ObjectiveCost;
            }
        }

        /// <summary>
        /// Assigns a person randomly to a shift, and at the same time adds the shift to the persons personal shifts
        /// </summary>
        private void AssignPersonsToShiftsRandomly()
        {
            //The shift is assigned a random number personnel between 0 and the timeperiods max amount of personnel per shift
            //So the shift can have less, equal or too many assignments

            foreach (Day day in timePeriod.Days)
            {
                foreach (Shift shift in day.Shifts)
                {
                    //Create a random number [0, personspershift] of assignments to one shift
                    int assignments = Extensions.Extensions.Rand.Next(0, timePeriod.PersonsPerShiftMax + 1);

                    for (int i = 0; i < assignments; i++)
                    {
                        //Get a random person from list of persons
                        Person randomlySelectedPerson = timePeriod.AvailablePersons[Extensions.Extensions.Rand.Next(0, timePeriod.AvailablePersons.Count)];

                        //Assign to shift
                        randomlySelectedPerson.AssignToShift(shift);
                    }
                }
            }
        }

        /// <summary>
        /// Mutates the chromosome with 3 different options
        /// </summary>
        private void Mutate()
        {
            // With help of a random decision we can vary the mutation

            // If decision = 1, only do an unassigment
            // if decision = 2, only do an assignment
            // if decision = 3, do both

            // This can, and should be, optimized

            int decision = Extensions.Extensions.Rand.Next(1, 4);

            if(decision == 1 || decision == 3)
            {
                // Select a random person
                Person randomPersonToUnAssign = timePeriod.AvailablePersons[Extensions.Extensions.Rand.Next(0, timePeriod.AvailablePersons.Count)];

                // and select one of its assigned shifts
                Shift randomShiftToUnAssign = null;
                if (randomPersonToUnAssign.AssignedShifts.Count > 0)
                    randomShiftToUnAssign = randomPersonToUnAssign.AssignedShifts[Extensions.Extensions.Rand.Next(0, randomPersonToUnAssign.AssignedShifts.Count)];
                else
                    return;

                // and unassign person from shift
                if (randomPersonToUnAssign != null)
                    randomPersonToUnAssign.UnAssignFromShift(randomShiftToUnAssign);
            }

            if(decision == 2 || decision == 3)
            {
                // Select a random person from available persons
                Person randomPersonToAssign = timePeriod.AvailablePersons[Extensions.Extensions.Rand.Next(0, timePeriod.AvailablePersons.Count)];

                // and select a random shift on a random day
                Day randomDay = timePeriod.Days[Extensions.Extensions.Rand.Next(0, timePeriod.Days.Count)];
                Shift randomShift = randomDay.Shifts[Extensions.Extensions.Rand.Next(0, randomDay.Shifts.Count)];

                // and assign the person to the shift
                randomPersonToAssign.AssignToShift(randomShift);
            }
        }

        /// <summary>
        /// Swaps persons shifts with eachother
        /// </summary>
        private void SwapShifts()
        {
            // No need to swap shifts if persons count <= 1
            if (timePeriod.AvailablePersons.Count <= 1)
                return;

            // This may not be convenient and is timeconsuming...

            // Find the person with highest objective cost
            int maxObjectiveCost = timePeriod.AvailablePersons.Max(x => x.ObjectiveCost);
            Person first = timePeriod.AvailablePersons.OrderByDescending(obj => obj.ObjectiveCost).First();

            // Select a random second person
            Person second = timePeriod.AvailablePersons[Extensions.Extensions.Rand.Next(0, timePeriod.AvailablePersons.Count)];

            // Prevent selecting same person
            while (first == second)
                second = timePeriod.AvailablePersons[Extensions.Extensions.Rand.Next(0, timePeriod.AvailablePersons.Count)];

            // Select one random shift from first's assigned shifts
            Shift shiftToSwap1 = null;
            if (first.AssignedShifts.Count > 0)
                shiftToSwap1 = first.AssignedShifts[Extensions.Extensions.Rand.Next(0, first.AssignedShifts.Count)];
            else
                return;

            // Select one random shift from second's assigned shifts
            Shift shiftToSwap2 = null;
            if (second.AssignedShifts.Count > 0)
            {
                shiftToSwap2 = second.AssignedShifts[Extensions.Extensions.Rand.Next(0, second.AssignedShifts.Count)];
            }
            else
                return;

            // Perform the swap
            first.UnAssignFromShift(shiftToSwap1);
            first.AssignToShift(shiftToSwap2);

            second.UnAssignFromShift(shiftToSwap2);
            second.AssignToShift(shiftToSwap1);

            // Calculate the ConstraintCost again
            CalculatePersonAssignmentConstraintCost();
            CalculateShiftAssignmentConstraintCost();

            // Swap back if the total constraint cost is violated
            // Because if the totalConstraintCost is allowed to be violated, the random mutation starts again, which slows the optimization significantly
            if(TotalConstraintCost != 0)
            {
                first.UnAssignFromShift(shiftToSwap2);
                first.AssignToShift(shiftToSwap1);

                second.UnAssignFromShift(shiftToSwap1);
                second.AssignToShift(shiftToSwap2);
            }
        }
    }
}












// This is the old swapping method. Very slow ;)

//// Swapping shifts should vary too

//// Select 2 random persons from available persons
//Person person1 = timePeriod.AvailablePersons[Extensions.Extensions.Rand.Next(0, timePeriod.AvailablePersons.Count)];
//Person person2 = timePeriod.AvailablePersons[Extensions.Extensions.Rand.Next(0, timePeriod.AvailablePersons.Count)];

//// Prevent selecting same person
//while (person1 == person2)
//    person2 = timePeriod.AvailablePersons[Extensions.Extensions.Rand.Next(0, timePeriod.AvailablePersons.Count)];

//// Vary the swapping
//int decision = Extensions.Extensions.Rand.Next(1, 3);

//// If decision = 1, select 2 random persons and swap 1 shift between them
//// If decision = 2, select 2 random persons and swap 2 shifts between them

//if (decision == 1)
//{
//    // Select one random shift from person1's assigned shifts
//    Shift shiftToSwap1 = null;
//    if (person1.AssignedShifts.Count > 0)
//        shiftToSwap1 = person1.AssignedShifts[Extensions.Extensions.Rand.Next(0, person1.AssignedShifts.Count)];
//    else
//        return;

//    // Select one random shift from person2's assigned shifts
//    Shift shiftToSwap2 = null;
//    if (person2.AssignedShifts.Count > 0)
//    {
//        shiftToSwap2 = person2.AssignedShifts[Extensions.Extensions.Rand.Next(0, person2.AssignedShifts.Count)];
//    }
//    else
//        return;

//    // Perform the swap
//    person1.UnAssignFromShift(shiftToSwap1);
//    person1.AssignToShift(shiftToSwap2);

//    person2.UnAssignFromShift(shiftToSwap2);
//    person2.AssignToShift(shiftToSwap1);
//}

//else if (decision == 2)
//{
//    // Select two random shift from person1's assigned shifts
//    Shift shiftToSwap11 = null;
//    Shift shiftToSwap12 = null;
//    if (person1.AssignedShifts.Count > 1)
//    {
//        shiftToSwap11 = person1.AssignedShifts[Extensions.Extensions.Rand.Next(0, person1.AssignedShifts.Count)];
//        shiftToSwap12 = person1.AssignedShifts[Extensions.Extensions.Rand.Next(0, person1.AssignedShifts.Count)];
//        // Prevent selecting the same shift
//        while (shiftToSwap11 == shiftToSwap12)
//            shiftToSwap12 = person1.AssignedShifts[Extensions.Extensions.Rand.Next(0, person1.AssignedShifts.Count)];
//    }
//    else
//        return;

//    // Select two random shift from person2's assigned shifts
//    Shift shiftToSwap21 = null;
//    Shift shiftToSwap22 = null;
//    if (person2.AssignedShifts.Count > 1)
//    {
//        shiftToSwap21 = person2.AssignedShifts[Extensions.Extensions.Rand.Next(0, person2.AssignedShifts.Count)];
//        shiftToSwap22 = person2.AssignedShifts[Extensions.Extensions.Rand.Next(0, person2.AssignedShifts.Count)];
//        // Prevent selecting the same shift
//        while (shiftToSwap21 == shiftToSwap22)
//            shiftToSwap22 = person2.AssignedShifts[Extensions.Extensions.Rand.Next(0, person2.AssignedShifts.Count)];
//    }
//    else
//        return;

//    // Perform the swap
//    person1.UnAssignFromShift(shiftToSwap11);
//    person1.UnAssignFromShift(shiftToSwap12);
//    person2.UnAssignFromShift(shiftToSwap21);
//    person2.UnAssignFromShift(shiftToSwap22);

//    person1.AssignToShift(shiftToSwap21);
//    person1.AssignToShift(shiftToSwap22);
//    person2.AssignToShift(shiftToSwap11);
//    person2.AssignToShift(shiftToSwap12);
//}