using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype.Objects;
using System.ComponentModel;

/// <summary>
/// Tries to find the optimal solution to the timeperiod
/// </summary>
/// <param name="timePeriod">Timeperiod to find a solution to</param>
/// <returns>The best chromosome found</returns>

namespace Prototype.Optimization
{
    /// <summary>
    /// Methods for optimization
    /// </summary>
    public static class Optimize
    {
        /// <summary>
        /// Tries to find the optimal solution to the timeperiod
        /// </summary>
        /// <param name="timePeriod">Timepriod to find a solution to</param>
        /// <param name="timeLimit">Time limit for the optimization</param>
        /// <param name="generationLimit">Generation limit for the optimization</param>
        /// <returns>The fittest chromosome found</returns>
        public static FittestChromosome FindOptimal(TimePeriod timePeriod, int timeLimit, int generationLimit, DoWorkEventArgs args, BackgroundWorker worker)
        {
            // For stopping in the middle of while-loop
            DoWorkEventArgs e = args;
            BackgroundWorker backgroundWorker = worker;

            // Ignore timelimit and generationlimit if they are 0
            if (timeLimit == 0)
                timeLimit = int.MaxValue;
            if (generationLimit == 0)
                generationLimit = int.MaxValue;

            // Create initial population
            Population oldGeneration = new Population(timePeriod);

            // Set default best chromosome found
            Chromosome bestFound = oldGeneration.Chromosomes[0];

            // Start timer
            var watch = System.Diagnostics.Stopwatch.StartNew();

            // For checking the timeLimit
            int minutesPassed = 0;

            // Counter of iterations
            int generation = 0;
            // Flag for optimal
            bool optimalFound = false;

            while(!optimalFound && generation < generationLimit && minutesPassed < timeLimit)
            {
                // Create a new generation of chromosomes based on the previous generations winners
                // This will either mutate or swap shifts (see constructor of chromosome)
                Population newGeneration = new Population(oldGeneration);

                // Evaluate the old and new generations chromosomes
                for (int i = 0; i < 10; i++)
                {
                    // Evaluate total constraint cost only if it is non-zero
                    if (oldGeneration.Chromosomes[i].TotalConstraintCost != 0)
                    {
                        // Duel between oldGeneration and newGeneration
                        if (newGeneration.Chromosomes[i].TotalConstraintCost <= oldGeneration.Chromosomes[i].TotalConstraintCost)
                        {
                            // Chose the winner chromosome to next generation (this is old generation in next generation)
                            oldGeneration.ReplaceChromosome(oldGeneration.Chromosomes[i], newGeneration.Chromosomes[i]);

                            if (newGeneration.Chromosomes[i].TotalConstraintCost <= bestFound.TotalConstraintCost)
                                bestFound = oldGeneration.Chromosomes[i];
                        }
                    }

                    // Else evaluate objective cost
                    else
                    {
                        // Evaluate the objective cost
                        if (newGeneration.Chromosomes[i].ObjectiveCost <= oldGeneration.Chromosomes[i].ObjectiveCost)
                        {
                            // Chose the winner chromosome to next generation (this is old generation in next generation)
                            oldGeneration.ReplaceChromosome(oldGeneration.Chromosomes[i], newGeneration.Chromosomes[i]);

                            // Select new best found
                            if (newGeneration.Chromosomes[i].ObjectiveCost <= bestFound.ObjectiveCost && oldGeneration.Chromosomes[i].TotalConstraintCost == 0)
                                bestFound = oldGeneration.Chromosomes[i];
                        }
                    }
                }

                // Check if optimal found
                if (bestFound.PersonAssignmentConstraintCost == 0 && bestFound.ShiftAssignmentConstraintCost == 0 && bestFound.ObjectiveCost == 0)
                        optimalFound = true;
                
                // Update generation and minutesPassed
                generation = generation + 1;
                minutesPassed = (int)watch.Elapsed.TotalMinutes;

                // Report the costs and the generations to the optimizing view for every 10 generation
                if(generation % 10 == 0)
                {
                    backgroundWorker.ReportProgress(bestFound.ShiftAssignmentConstraintCost);
                    backgroundWorker.ReportProgress(bestFound.PersonAssignmentConstraintCost);
                    backgroundWorker.ReportProgress(bestFound.ObjectiveCost);
                    backgroundWorker.ReportProgress(generation);
                }

                // Checks if the backgroundworker is told to stop
                if (backgroundWorker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
            }

            // Stop timer
            watch.Stop();
            TimeSpan elapsedTime = watch.Elapsed;

            // Create a new fittestChromosome
             FittestChromosome fittest = new FittestChromosome(bestFound, elapsedTime, generation);

            return fittest;
        }
    }
}
