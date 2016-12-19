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
using Prototype.Views;
using Prototype.Optimization;

namespace Prototype
{
    /// <summary>
    /// The main view of the program
    /// </summary>
    public partial class StartView : Form
    {
        private TimePeriod timePeriod;
        private FittestChromosome fittest;
        private OptimizingView optimizingView;

        public StartView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets or sets the timeperiod of this instance of the program
        /// </summary>
        public TimePeriod TimePeriod { get { return timePeriod; } set { timePeriod = value; } }

        /// <summary>
        /// Counter for getting the progress data from the backgroundworker in the right order
        /// </summary>
        private int progressCounter = 0;

        #region private listeners

        private void buttonGenerateNewTimePeriod_Click(object sender, EventArgs e)
        {
            // Opens the NewTimePeriodView that allows the user to create a new timeperiod and assigns the timeperiod to this views timeperiod
            NewTimePeriodView newTimePeriod = new NewTimePeriodView(this);
            newTimePeriod.Show();
        }

        private void buttonOpenTimePeriod_Click(object sender, EventArgs e)
        {
            //Opens a timeperiod from a file

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Timeperiod file|*.tp";
            dialog.Title = "Open project from a .tp file";

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    timePeriod = Extensions.Extensions.OpenObjectFromFile(dialog.FileName);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.StackTrace, ex.Message);
                }
            }
        }

        private void buttonSaveTimePeriod_Click(object sender, EventArgs e)
        {
            //Saves a timeperiod to a file

            if(timePeriod == null)
            {
                MessageBox.Show("There is not a current timeperiod");
                return;
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Timeperiod file|*.tp";
            dialog.Title = "Save current project to a .tp file";
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                Extensions.Extensions.SaveObjectToFile(timePeriod, dialog.FileName);
            }
        }

        private void StartView_Paint(object sender, PaintEventArgs e)
        {
            // Adds the information of the current timeperiod to the information panel
            if (timePeriod != null)
            {
                textBoxCurrentTimePeriodLength.Text = timePeriod.LengthInDays.ToString();
                textBoxCurrentMaxPersonsPerShift.Text = timePeriod.PersonsPerShiftMax.ToString();
                textBoxAvailablePersons.Text = timePeriod.AvailablePersons.Count.ToString();
            }
            else
            {
                textBoxCurrentTimePeriodLength.Text = "";
                textBoxCurrentMaxPersonsPerShift.Text = "";
                textBoxAvailablePersons.Text = "";
            }
        }

        private void buttonShowCurrentTimePeriod_Click(object sender, EventArgs e)
        {
            //Displays the current timeperiod

            if (timePeriod == null)
            {
                MessageBox.Show("No current timeperiod");
            }
            else
            {
                TimePeriodView view = new TimePeriodView(timePeriod);
                view.Show();
            }
        }

        private void buttonFindBestSolution_Click(object sender, EventArgs e)
        {
            //Find optimal of the current timeperiod
            if (timePeriod == null)
            {
                MessageBox.Show("No current timeperiod");
            }

            else if(backgroundWorker.IsBusy)
            {
                MessageBox.Show("Already running");
            }
            else
            {
                // Open the optimizing window for updating the view
                optimizingView = new OptimizingView();
                optimizingView.Show();

                // Start a background worker so UI remains responsive
                backgroundWorker.RunWorkerAsync();

                // Show running label
                labelRunning.Visible = true;
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Start the search
            fittest = Optimize.FindOptimal(timePeriod, (int)timeLimit.Value, (int)generationLimit.Value, e, sender as BackgroundWorker);
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if(optimizingView != null)
            {   
                // The data is being sent in this order from the optimize thread.
                switch (progressCounter)
                {
                    case 0:
                        {
                            optimizingView.ShiftCost.Text = e.ProgressPercentage.ToString();
                            progressCounter++;
                            break;
                        }
                    case 1:
                        {
                            optimizingView.PersonCost.Text = e.ProgressPercentage.ToString();
                            progressCounter++;
                            break;
                        }
                    case 2:
                        {
                            optimizingView.ObjectiveCost.Text = e.ProgressPercentage.ToString();
                            progressCounter++;
                            break;
                        }
                    case 3:
                        {
                            optimizingView.Generation.Text = e.ProgressPercentage.ToString();
                            progressCounter = 0;
                            break;
                        }
                }
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Hide running label
            labelRunning.Visible = false;

            if(fittest != null)
            {
                // Close optimizing view
                optimizingView.Close();

                // Show the best found solution
                FittestChromosomeView view = new FittestChromosomeView(fittest);
                view.Show();
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            // Cancels the backgroundWorker
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.CancelAsync();
        }

        #endregion
    }
}