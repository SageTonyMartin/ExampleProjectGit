using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExampleProject;

namespace ExerciseUI
{
    public partial class Main : Form
    {
        private Vehicle vehicle;
        private Utility VehicleUtils;

        public Main()
        {
            VehicleUtils = new Utility();
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (VehicleUtils.Equals(null))
            {
                VehicleUtils = new Utility();
            }
            VehicleTypeCombo.DataSource = VehicleUtils.VehicleTypes;
        }

        private void VehicleTypeCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (VehicleTypeCombo.SelectedValue.ToString().ToUpper())
            {
                case "AIRCRAFT":
                    break;
                case "AUTOMOBILE":
                    break;
                case "BOAT":
                    break;
                case "LOCOMOTIVE":
                    break;
                case "VEHICLE":
                    break;
                default:
                    MessageBox.Show("Sorry - that is not a supported vehicle type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
