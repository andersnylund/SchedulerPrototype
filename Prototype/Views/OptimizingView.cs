using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype.Optimization
{
    /// <summary>
    /// A windows form for showing the optimization progress
    /// </summary>
    public partial class OptimizingView : Form
    {
        public OptimizingView()
        {
            InitializeComponent();
        }

        public TextBox ShiftCost { get { return shiftCost; } set { shiftCost = value; } }
        public TextBox PersonCost { get { return personCost; } set { personCost = value; } }
        public TextBox ObjectiveCost { get { return objectiveCost; } set { objectiveCost = value; } }
        public TextBox Generation { get { return generation; } set { generation = value; } }
    }
}
