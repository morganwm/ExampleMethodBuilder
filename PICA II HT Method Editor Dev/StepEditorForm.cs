using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PICA_II_HT_Method_Editor_Dev
{
    
    
    public partial class StepEditorForm : Form
    {

        Step CurrentStep;
        bool NewStep;
        bool publishstep;

        public StepEditorForm()
        {
            InitializeComponent();
        }

        internal void LoadStep(Step InStep, bool newstep)
        {
            StepUIDLabel.Text = InStep.StepUID.ToString();
            CurrentStep = InStep;
            NewStep = newstep;
            publishstep = false;

            StepTypeComboBox.DataSource = Enum.GetValues(typeof(PICA_II_HT_Method_Editor_Dev.Step.StepType));
            PressureModeComboBox.DataSource = Enum.GetValues(typeof(PICA_II_HT_Method_Editor_Dev.Step.PressureMode));

            //populate text box values
            if (!NewStep)
            {
                //May need to be worked on to see if this will even work
                //StepTypeComboBox.SelectedItem = Enum.ToObject(typeof(PICA_II_HT_Method_Editor_Dev.Step.StepType), CurrentStep.Type);
                //StepTypeComboBox.SelectedValue = CurrentStep.Type.ToString();
                StepTypeComboBox.SelectedItem = CurrentStep.Type;
                PressureModeComboBox.SelectedItem = CurrentStep.Mode;

                EqTimeTextBox.Text = CurrentStep.EquilibriumTime.ToString();
                NumberMeasTextBox.Text = CurrentStep.NumberOfMeasurements.ToString();
                WaitTimeTextBox.Text = CurrentStep.WaitTimeBetweenMeasurements.ToString();
                MeasurementTempResTextBox.Text = CurrentStep.MeasurementTemperatureResolution.ToString();
                TempSetPointTextBox.Text = CurrentStep.TemperatureSetPoint.ToString();
                PressureSetPointTextBox.Text = CurrentStep.PressureSetPoint.ToString();
                MixSpeedTextBox.Text = CurrentStep.MixingSpeed.ToString();
            }

        }

        public bool UpdateStep()
        {
            //add update for values in CurrentStep
            try
            {
                CurrentStep.Type = (Step.StepType)Enum.Parse(typeof(PICA_II_HT_Method_Editor_Dev.Step.StepType), StepTypeComboBox.Text.ToString());
                CurrentStep.Mode = (Step.PressureMode)Enum.Parse(typeof(PICA_II_HT_Method_Editor_Dev.Step.PressureMode), PressureModeComboBox.Text.ToString());
                CurrentStep.EquilibriumTime = Convert.ToDouble(EqTimeTextBox.Text);
                CurrentStep.NumberOfMeasurements = Convert.ToInt32(NumberMeasTextBox.Text);
                CurrentStep.WaitTimeBetweenMeasurements = Convert.ToDouble(WaitTimeTextBox.Text);
                CurrentStep.MeasurementTemperatureResolution = Convert.ToDouble(MeasurementTempResTextBox.Text);
                CurrentStep.TemperatureSetPoint = Convert.ToDouble(TempSetPointTextBox.Text);
                CurrentStep.PressureSetPoint = Convert.ToDouble(PressureSetPointTextBox.Text);
                CurrentStep.MixingSpeed = Convert.ToDouble(MixSpeedTextBox.Text);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void PunblishStep(bool save)
        {
            if (NewStep && save)
            {
                MethodEditorMainForm.passback = -1;
            }
            else if (NewStep && !save)
            {
                MethodEditorMainForm.passback = -2;
            }
            else
            {
                MethodEditorMainForm.passback = CurrentStep.StepUID;
            }

            Console.WriteLine("Passback:" + MethodEditorMainForm.passback);
            MethodEditorMainForm.PassStep = CurrentStep;
        }

        #region Events

        private void StepEditorForm_Load(object sender, EventArgs e)
        {

        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (UpdateStep())
            {
                publishstep = true;
                this.Close();
                this.Dispose();
            }
            else
            {
                //MessageBox.Show("incorrect input");
            }
        }

        private void StepEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            PunblishStep(publishstep);
        }

        private void StepTypeComboBox_TextUpdate(object sender, EventArgs e)
        {
            ////Validate Input
            //bool check = false;
            //foreach (string x in StepTypeComboBox.Items)
            //{
            //    if (x == StepTypeComboBox.Text)
            //    {
            //        check = true;
            //    }
            //}

            //if (!check)
            //{
            //    Console.WriteLine("nope");
            //    StepTypeComboBox.Text = StepTypeComboBox.Items[0].ToString();
            //}
        }

        private void PressureModeComboBox_TextUpdate(object sender, EventArgs e)
        {
            ////Validate Input
            //bool check = false;
            //foreach (string x in PressureModeComboBox.Items)
            //{
            //    if (x == PressureModeComboBox.Text)
            //    {
            //        check = true;
            //    }
            //}

            //if (!check)
            //{
            //    Console.WriteLine("nope");
            //    PressureModeComboBox.Text = PressureModeComboBox.Items[0].ToString();
            //}
        }

        #endregion

    }
}
