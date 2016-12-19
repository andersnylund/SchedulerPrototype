using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype.Objects;

namespace Prototype.Optimization
{
    /// <summary>
    /// A population of 10 chromosomes
    /// </summary>
    public class Population
    {
        private List<Chromosome> chromosomes;
        private TimePeriod timePeriod;

        /// <summary>
        /// Creates a new population of random chromosomes from the timeperiod
        /// </summary>
        /// <param name="timePeriod">The timeperiod that the population is created to</param>
        public Population(TimePeriod timePeriod)
        {
            chromosomes = new List<Chromosome>();
            this.timePeriod = timePeriod;
            CreateChromosomes(timePeriod);
        }

        /// <summary>
        /// Creates a new generation based on the old passed generation
        /// </summary>
        /// <param name="oldGeneration">The old generation from where the new generation will be created</param>
        public Population(Population oldGeneration)
        {
            chromosomes = new List<Chromosome>();

            foreach(Chromosome oldChromosome in oldGeneration.Chromosomes)
            {
                chromosomes.Add(new Chromosome(oldChromosome));
            }
        }

        /// <summary>
        /// Returns the list of chromosomes of this Population
        /// </summary>
        public List<Chromosome> Chromosomes { get { return chromosomes; } }

        /// <summary>
        /// Returns the initial unmodified timeperiod
        /// </summary>
        public TimePeriod TimePeriod { get { return timePeriod; } }

        /// <summary>
        /// Creates 10 chromosomes to this population from the passed timeperiod
        /// </summary>
        /// <param name="timePeriod">The timeperiod from which the chromosomes are created</param>
        private void CreateChromosomes(TimePeriod timePeriod)
        {
            for(int i = 0; i < 10; i++)
            {
                //DeepCloning the timeperiod each time
                chromosomes.Add(new Chromosome(timePeriod));
            }
        }

        /// <summary>
        /// Replaces a chromosome in this population
        /// </summary>
        /// <param name="oldChromosome">The old chromosome to remove</param>
        /// <param name="newChromosome">The new chromosome to add</param>
        public void ReplaceChromosome(Chromosome oldChromosome, Chromosome newChromosome)
        {
            // Add the new chromosome at the old chromosome's index
            int index = chromosomes.IndexOf(oldChromosome);
            chromosomes.Remove(oldChromosome);

            chromosomes.Insert(index, newChromosome);
        }
    }
}
