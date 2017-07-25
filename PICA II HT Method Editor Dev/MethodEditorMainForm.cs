using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PICA_II_HT_Method_Editor_Dev
{


    public partial class MethodEditorMainForm : Form
    {
        Method myMethod;
        Step tempStep;
        Step[] CurrentStepBuffer;
        ImageConfig tempImageConfig;
        Action[] AvailibleActions;
        Action tempAction;
        System.IO.StreamWriter Writer;
        System.IO.StreamReader Reader;
        DataTable MethodData;
        int StepId;
        long Counter;

        public static Step PassStep;
        public static long passback;
        
        public MethodEditorMainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myMethod = new Method();
            tempStep = new Step();
            tempImageConfig = new ImageConfig();
            MethodData = new DataTable();
            MethodData.Columns.Add("StepName", typeof(PICA_II_HT_Method_Editor_Dev.Step.StepType));
            MethodData.Columns.Add("Comment", typeof(string));
            PopulateStepTypes();           
            dataGridView1.DataSource = MethodData;
            Counter = 0;
        }

        public void PopulateStepTypes()
        {
            //this is not working correctly. I dont know why but something is fishy.
            foreach (PICA_II_HT_Method_Editor_Dev.Step.StepType x in Enum.GetValues(typeof(PICA_II_HT_Method_Editor_Dev.Step.StepType)))
            {
                Step tmp = new Step();
                string description = tmp.GetStepTypeDescription(x);
                MethodData.Rows.Add(new Object[] { x, description });
            }
        }

        public void AddNewStepPanel(Step InStep)
        {
            long PanelID = InStep.StepUID;
            Panel steppanel = new Panel();
            steppanel.Name = PanelID.ToString();
            steppanel.BackColor = System.Drawing.Color.DarkGray;
            steppanel.Size = new System.Drawing.Size(360, 150);
            Step tempstep = new Step();

            DataTable StepVars = new DataTable();
            StepVars.Columns.Add("Variable");
            StepVars.Columns.Add("Value");

            //Add Data to Data Table
            #region Add Data to Data Table

            //StepVars.Rows.Add(new Object[] { "Step Type:", InStep.Type.ToString() });
            StepVars.Rows.Add(new Object[] { "Equilibrium Time:", InStep.EquilibriumTime.ToString() });
            StepVars.Rows.Add(new Object[] { "Num of Measurements", InStep.NumberOfMeasurements.ToString() });
            StepVars.Rows.Add(new Object[] { "Wait Time Between Measurements", InStep.WaitTimeBetweenMeasurements.ToString() });
            StepVars.Rows.Add(new Object[] { "Measurement Temp Res", InStep.MeasurementTemperatureResolution.ToString() });
            StepVars.Rows.Add(new Object[] { "Temp Set Point", InStep.TemperatureSetPoint.ToString() });
            StepVars.Rows.Add(new Object[] { "Pressure Set Point", InStep.PressureSetPoint.ToString() });
            StepVars.Rows.Add(new Object[] { "Mixing Speed", InStep.MixingSpeed.ToString() });
            StepVars.Rows.Add(new Object[] { "Pressure Mode", InStep.Mode.ToString() });
            StepVars.Rows.Add(new Object[] { "Step UID", InStep.StepUID.ToString() });

            

            #endregion

            //DataGridView
            #region Data Grid View
            DataGridView StepDataGridView = new DataGridView();
            StepDataGridView.AllowUserToAddRows = false;
            StepDataGridView.AllowUserToDeleteRows = false;
            StepDataGridView.ColumnHeadersVisible = false;
            StepDataGridView.RowHeadersVisible = false;
            
            //I will change this later to allow for users to edit stpes from the main screen
            StepDataGridView.ReadOnly = true;

            StepDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
            StepDataGridView.DefaultCellStyle.SelectionForeColor = Color.DarkGray;
            StepDataGridView.DefaultCellStyle.BackColor = Color.DarkGray;
            StepDataGridView.DefaultCellStyle.ForeColor = Color.White;

            //StepDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Blue;
            //StepDataGridView.RowHeadersDefaultCellStyle.ForeColor = Color.Red;
            //StepDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Red;
            //StepDataGridView.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Blue;

            //StepDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            //StepDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;
            //StepDataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Red;
            //StepDataGridView.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Blue;

            //StepDataGridView.ForeColor = System.Drawing.Color.DarkGray;
            //StepDataGridView.BackgroundColor = System.Drawing.Color.DarkGray;

            StepDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            StepDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            //StepDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StepDataGridView.Location = new System.Drawing.Point(8, 33);
            StepDataGridView.Size = new System.Drawing.Size(282, 112);
            StepDataGridView.TabIndex = 44;
            StepDataGridView.DataSource = StepVars;
            
            #endregion

            //typelabel Label
            #region Type Label
            Label typelabel = new Label();
            typelabel.AutoSize = true;
            typelabel.BackColor = System.Drawing.Color.Transparent;
            typelabel.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            typelabel.Location = new System.Drawing.Point(62, 2);
            typelabel.Name = "label41";
            typelabel.Size = new System.Drawing.Size(108, 28);
            typelabel.TabIndex = 40;
            typelabel.Text = InStep.Type.ToString();
            #endregion

            //Static Step Label Label
            #region "Step Label" Label
            Label StaticStepLabel = new Label();
            StaticStepLabel.AutoSize = true;
            StaticStepLabel.BackColor = System.Drawing.Color.Transparent;
            StaticStepLabel.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            StaticStepLabel.Location = new System.Drawing.Point(3, 2);
            StaticStepLabel.Size = new System.Drawing.Size(53, 28);
            StaticStepLabel.TabIndex = 31;
            StaticStepLabel.Text = "Step:";
            #endregion

            //Edit Button
            #region Edit Button
            Button editbutton = new Button();
            editbutton.BackColor = System.Drawing.Color.DimGray;
            editbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            editbutton.FlatAppearance.BorderSize = 0;
            editbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            editbutton.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            editbutton.ForeColor = System.Drawing.Color.White;
            editbutton.Location = new System.Drawing.Point(296, 39);
            editbutton.Size = new System.Drawing.Size(61, 33);
            editbutton.TabIndex = 41;
            editbutton.Text = "Edit";
            editbutton.UseVisualStyleBackColor = false;
            editbutton.Name = "editbutton" + PanelID;
            editbutton.Click += new EventHandler(editbutton_Click);
            #endregion

            //Delete Button
            #region Delete Button
            Button deletebutton = new Button();
            deletebutton.BackColor = System.Drawing.Color.DimGray;
            deletebutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            deletebutton.FlatAppearance.BorderSize = 0;
            deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            deletebutton.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            deletebutton.ForeColor = System.Drawing.Color.White;
            deletebutton.Location = new System.Drawing.Point(296, 75);
            deletebutton.Size = new System.Drawing.Size(61, 33);
            deletebutton.TabIndex = 42;
            deletebutton.Text = "Delete";
            deletebutton.UseVisualStyleBackColor = false;
            deletebutton.Name = "deletebutton" + PanelID;
            deletebutton.Click += new EventHandler(deletebutton_Click);
            #endregion

            //Up Button
            #region Up Button
            Button upbutton = new Button();
            upbutton.BackColor = System.Drawing.Color.Gray;
            upbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            upbutton.FlatAppearance.BorderSize = 0;
            upbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            upbutton.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            upbutton.ForeColor = System.Drawing.Color.White;
            upbutton.Location = new System.Drawing.Point(296, 3);
            upbutton.Size = new System.Drawing.Size(61, 33);
            upbutton.TabIndex = 35;
            upbutton.Text = "Up";
            upbutton.UseVisualStyleBackColor = false;
            upbutton.Name = "upbutton" + PanelID;
            upbutton.Click += upbutton_Click;
            #endregion

            //Down Button
            #region Down Button
            Button downbutton = new Button();
            downbutton.BackColor = System.Drawing.Color.Gray;
            downbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            downbutton.FlatAppearance.BorderSize = 0;
            downbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            downbutton.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            downbutton.ForeColor = System.Drawing.Color.White;
            downbutton.Location = new System.Drawing.Point(296, 114);
            downbutton.Size = new System.Drawing.Size(61, 33);
            downbutton.TabIndex = 43;
            downbutton.Text = "Down";
            downbutton.UseVisualStyleBackColor = false;
            downbutton.Name = "downbutton" + PanelID;
            downbutton.Click += downbutton_Click;
            #endregion

            //Adding to Pannel
            #region Adding to Pannel
            steppanel.Controls.Add(editbutton);
            steppanel.Controls.Add(deletebutton);
            steppanel.Controls.Add(upbutton);
            steppanel.Controls.Add(downbutton);
            steppanel.Controls.Add(StaticStepLabel);
            steppanel.Controls.Add(typelabel);
            steppanel.Controls.Add(StepDataGridView);
            #endregion

            //Adding Pannel to Flow Layout
            StepFlowLayoutPanel.Controls.Add(steppanel);
            StepDataGridView.Columns["Variable"].Width = 160;
            StepDataGridView.Columns["Value"].Width = 80;
            
        }

        public void AddStepToBuffer(Step InStep)
        {
            if (CurrentStepBuffer == null)
            {
                CurrentStepBuffer = new Step[1];
                CurrentStepBuffer[0] = InStep;
            }
            else
            {
                Array.Resize<Step>(ref CurrentStepBuffer, CurrentStepBuffer.Length + 1);
                CurrentStepBuffer[CurrentStepBuffer.Length - 1] = InStep;
            }


        }

        public void RemoveStepFromBuffer(long InStepUID)
        {
            if (CurrentStepBuffer != null)
            {
                Step[] tmparr = new Step[CurrentStepBuffer.Length - 1];

                int n = 0;
                for (int i = 0; i < CurrentStepBuffer.Length; i++)
                {
                    if (InStepUID != CurrentStepBuffer[i].StepUID)
                    {
                        tmparr[n] = CurrentStepBuffer[i];
                        n++;
                    }

                }

                Array.Resize<Step>(ref CurrentStepBuffer, CurrentStepBuffer.Length - 1);
                CurrentStepBuffer = tmparr;
            }
            else
            {
                MessageBox.Show("Error, Current Step Buffer is Empty");
            }
        }

        public void AddStep(Step InStep)
        {
            AddStepToBuffer(InStep);
            AddNewStepPanel(InStep);
        }

        public void UpdateStep(long InStepUID, Step InStep)
        {
            //will search through the buffer of steps and replace the one with the selected UID
            bool found = false;

            for (int i = 0; i < CurrentStepBuffer.Length; i++)
            {
                if (CurrentStepBuffer[i].StepUID == InStepUID)
                {
                    CurrentStepBuffer[i] = InStep;
                    found = true;
                }
            }

            if (!found)
            {
                MessageBox.Show("error finding step in buffer");
            }
            
        }

        public Step RetreiveStepFromBuffer(long StepUID)
        {
            bool found = false;
            Step tmpstp = new Step();
            foreach (Step x in CurrentStepBuffer)
            {
                if (x.StepUID == StepUID)
                {
                    tmpstp = x;
                    found = true;
                }
            }

            if (!found)
            {
                MessageBox.Show("error retrieving step from buffer");
            }

            return tmpstp;
        }

        public void UpdatePanel(long StepUID)
        {
            var panel = StepFlowLayoutPanel.Controls[StepUID.ToString()];
            int pannelindex = StepFlowLayoutPanel.Controls.GetChildIndex(StepFlowLayoutPanel.Controls[StepUID.ToString()]);
            panel.Dispose();

            Step WorkingStep = RetreiveStepFromBuffer(StepUID);

            AddNewStepPanel(WorkingStep);
            var newpanel = StepFlowLayoutPanel.Controls[StepUID.ToString()];
            StepFlowLayoutPanel.Controls.SetChildIndex(StepFlowLayoutPanel.Controls[StepUID.ToString()], pannelindex);
            Console.WriteLine(StepFlowLayoutPanel.Controls.GetChildIndex(StepFlowLayoutPanel.Controls[StepUID.ToString()]));
        }

        public bool PopulateMethodSteps()
        {
            long CurrentStepUID;
            if (StepFlowLayoutPanel.Controls != null)
            {
                try
                {
                    for (int i = 0; i < StepFlowLayoutPanel.Controls.Count; i++)
                    {
                        CurrentStepUID = Convert.ToInt64(StepFlowLayoutPanel.Controls[i].Name);
                        myMethod.AddStep(RetreiveStepFromBuffer(CurrentStepUID));
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("here");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("No Steps in Working Panel Layout");
                return false;
            }
            
        }

        public bool PopulateMethodInfo()
        {
            bool Name = false;
            bool Author = false;
            bool LibID = false;
            bool desc = false;
            


            if (NameTextBox.Text != "")
            {
                Name = true;
                myMethod.Name = NameTextBox.Text;
            }
            else
            {
                MessageBox.Show("Name is Blank");
            }

            if (AuthorTextBox.Text != "")
            {
                Author = true;
                myMethod.Author = AuthorTextBox.Text;
            }
            else
            {
                MessageBox.Show("Author is Blank");
            }

            if (LEALibIDTextBox.Text != "")
            {
                LibID = true;
                myMethod.LEALibID = Convert.ToInt32(LEALibIDTextBox.Text);
            }
            else
            {
                MessageBox.Show("LEA Library ID is Blank");
            }

            if (DescriptionTextBox.Text != "")
            {
                desc = true;
                myMethod.Description = DescriptionTextBox.Text;
            }
            else
            {
                MessageBox.Show("Description is Blank");
            }
            

            if (Name && Author && LibID && desc)
            {
                return true;
            }
            
            return false;
        }

        public void LoadMethodFromFile(System.IO.StreamReader ReadFile)
        {
            //parse file into mymethod object
            myMethod.ParseFromFile(ReadFile);

            //make sure they want to clear any data open
            if (CurrentStepBuffer != null)
            {
                DialogResult dialogresult = MessageBox.Show("the current method will be romoved from memory if you continue", "", MessageBoxButtons.OKCancel);
                if (dialogresult != DialogResult.OK)
                {
                    return;
                }
            }

            //clear current step buffer
            CurrentStepBuffer = null;

            //populate step buffer
            int c = myMethod.Steps.Length;
            for (int i = 0; i < c; i++)
            {
                AddStepToBuffer(myMethod.Steps[i]);
            }


            //clear all panels
            int n = StepFlowLayoutPanel.Controls.Count;
            for (int i = 0; i < n; i++)
            {
                var panel = StepFlowLayoutPanel.Controls[0];
                panel.Dispose();
            }

            //loop through buffer and populate gui
            for (int i = 0; i < CurrentStepBuffer.Length; i++)
            {
                AddNewStepPanel(CurrentStepBuffer[i]);
            }

            //populate method info
            NameTextBox.Text = myMethod.Name;
            AuthorTextBox.Text = myMethod.Author;
            DescriptionTextBox.Text = myMethod.Description;
            LEALibIDTextBox.Text = myMethod.LEALibID.ToString();

            //clear loaded method
            myMethod = null;
            myMethod = new Method();
        }


        #region Events

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StepId = e.RowIndex;
        }

        void deletebutton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string tempstring = btn.Name;
            long id = Convert.ToInt64(tempstring.Substring(12));
            Console.WriteLine(id);
            var panel = StepFlowLayoutPanel.Controls[id.ToString()];
            panel.Dispose();
            RemoveStepFromBuffer(id);
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string tempstring = btn.Name;
            long id = Convert.ToInt64(tempstring.Substring(10));
            tempStep = new Step();
            tempStep = RetreiveStepFromBuffer(id);
            StepEditorForm newstepform = new StepEditorForm();
            newstepform.FormClosing += newstepform_FormClosing;
            newstepform.LoadStep(tempStep, false);
            newstepform.Show();
        }

        void upbutton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string tempstring = btn.Name;
            long id = Convert.ToInt64(tempstring.Substring(8));
            var panel = StepFlowLayoutPanel.Controls[id.ToString()];
            int pannelindex = StepFlowLayoutPanel.Controls.GetChildIndex(StepFlowLayoutPanel.Controls[id.ToString()]);

            if (pannelindex != 0)
            {
                StepFlowLayoutPanel.Controls.SetChildIndex(StepFlowLayoutPanel.Controls[id.ToString()], pannelindex-1);
            }
        }

        void downbutton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string tempstring = btn.Name;
            long id = Convert.ToInt64(tempstring.Substring(10));
            var panel = StepFlowLayoutPanel.Controls[id.ToString()];
            int pannelindex = StepFlowLayoutPanel.Controls.GetChildIndex(StepFlowLayoutPanel.Controls[id.ToString()]);

            if (pannelindex != StepFlowLayoutPanel.Controls.Count)
            {
                StepFlowLayoutPanel.Controls.SetChildIndex(StepFlowLayoutPanel.Controls[id.ToString()], pannelindex + 1);
            }
        }

        private void AddStepButton_Click(object sender, EventArgs e)
        {
            tempStep = new Step();
            tempStep.StepUID = DateTime.Now.Ticks;
            StepEditorForm newstepform = new StepEditorForm();
            newstepform.FormClosing += newstepform_FormClosing;
            newstepform.LoadStep(tempStep, true);
            newstepform.Show();

        }

        void newstepform_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (passback == -1)
            {
                AddStep(PassStep);
            }
            else if (passback == -2)
            {
                //this happens when the user cancells the "add step operation" on a new step. therefor we do nothing
            }
            else
            {
                UpdateStep(passback, PassStep);
                UpdatePanel(passback);
            }
        }

        private void RampWizard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Construction");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Check all Method Values to Make sure that they are filled in
            bool popinfo = PopulateMethodInfo();

            //Add steps from step buffer into the method step array
            bool popsteps = PopulateMethodSteps();
            

            if (myMethod.Steps != null && popinfo  && popsteps)
            {
                try
                {
                    //open file dailog to save file
                    SaveFileDialog save = new SaveFileDialog();
                    save.Filter = "PICA HT Method Files (*.PICAHT.method)|*.PICAHT.method|All Files (*.*)|*.*";
                    save.ShowDialog();
                    if (save.FileName == null)
                    {
                        myMethod = null;
                        myMethod = new Method();
                        return;
                    }
                    PathTextBox.Text = save.FileName;
                    Writer = new System.IO.StreamWriter(save.FileName);
                    myMethod.PrintToFile(Writer);
                    Writer.Close();
                    Writer.Dispose();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No Method to save");
            }
            
            
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            //OpenFile Dialog and parse in method
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "PICA HT Method Files (*.PICAHT.method)|*.PICAHT.method|All Files (*.*)|*.*";
            open.ShowDialog();
            
            if (open.FileName == "")
            {
                return;
            }

            PathTextBox.Text = open.FileName;
            Reader = new System.IO.StreamReader(open.FileName);
            LoadMethodFromFile(Reader);
            Reader.Close();
            Reader.Dispose();
        }

        #endregion

    }
}
