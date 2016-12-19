using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Optimization
{
    public class FittestChromosome
    {
        private Chromosome chromosome;
        private TimeSpan timeToFind;
        private int generation;

        public FittestChromosome(Chromosome chromosome, TimeSpan timeToFind, int generation)
        {
            this.chromosome = chromosome;
            this.timeToFind = timeToFind;
            this.generation = generation;
        }

        /// <summary>
        /// Gets the chromosome
        /// </summary>
        public Chromosome Chromosome { get { return chromosome; } }

        /// <summary>
        /// Gets the timespan that this chromosome was found in
        /// </summary>
        public TimeSpan TimeToFind { get { return timeToFind; } }

        /// <summary>
        /// Gets the generation that this chromosome was found in
        /// </summary>
        public int Generation { get { return generation; } }
    }
}
