using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace PICA_II_HT_Method_Editor_Dev
{

    public class Method
    {
        public string Name;
        public string Description;
        public string Author;
        public int LEALibID;
        public Step[] Steps;
        //public Action[] MethodActions;

        public void AddStep(Step InStep)
        {
            if (Steps == null)
            {
                Steps = new Step[1];
                Steps[0] = InStep;
            }
            else
            {
                Array.Resize<Step>(ref Steps, Steps.Length + 1);
                Steps[Steps.Length - 1] = InStep;
            }


        }
        public void AddStep(Step InStep, int InsertBefore)
        {
            Step[] tmparr = new Step[Steps.Length + 1];

            int n = 0;
            for (int i = 0; 0 < Steps.Length; i++)
            {
                if (i == InsertBefore)
                {
                    tmparr[n] = InStep;
                    n++;
                }
                tmparr[n] = Steps[i];
                n++;
            }

            Array.Resize<Step>(ref Steps, Steps.Length + 1);
            Steps = tmparr;

        }
        public void RemoveStep(int StepNumber)
        {
            if (Steps != null)
            {
                Step[] tmparr = new Step[Steps.Length - 1];

                int n = 0;
                for (int i = 0; i < Steps.Length; i++)
                {
                    if (i != StepNumber)
                    {
                        tmparr[n] = Steps[i];
                        n++;
                    }

                }

                Array.Resize<Step>(ref Steps, Steps.Length - 1);
                Steps = tmparr;
            }
        }


        public void PublishActionsToDatabase()
        {
            //Needs to be Written to convert Steps into actions and publish them to the database
        }

        public void PrintToFile(System.IO.StreamWriter filestream)
        {
            XmlSerializer x = new XmlSerializer(this.GetType());
            x.Serialize(filestream, this);
        }

        public void ParseFromFile(System.IO.StreamReader filestream)
        {
            XmlSerializer x = new XmlSerializer(this.GetType());
            Method tempmethod;
            tempmethod = (Method)x.Deserialize(filestream);

            Name = tempmethod.Name;
            Description = tempmethod.Description;
            Author = tempmethod.Author;
            LEALibID = tempmethod.LEALibID;
            Steps = tempmethod.Steps;
        }
    }


    public class Step
    {
        public PressureMode Mode;
        public StepType Type;
        public double EquilibriumTime;
        public int NumberOfMeasurements;
        public double WaitTimeBetweenMeasurements;
        public double MeasurementTemperatureResolution;
        public double TemperatureSetPoint;
        public double PressureSetPoint;
        public double MixingSpeed;
        public ImageConfig[] ImageConfigs;
        //public Action[] StepActions;
        public long StepUID;


        public enum PressureMode
        {
            Monitor,
            SetPoint
        }

        public enum StepType
        {
            Hold,
            Ramp
        }


        public void AddImageConfig(ImageConfig InImageConfig)
        {
            if (ImageConfigs == null)
            {
                ImageConfigs = new ImageConfig[1];
                ImageConfigs[0] = InImageConfig;
            }
            else
            {
                Array.Resize<ImageConfig>(ref ImageConfigs, ImageConfigs.Length + 1);
                ImageConfigs[ImageConfigs.Length - 1] = InImageConfig;
            }


        }
        public void AddImageConfig(ImageConfig InImageConfig, int InsertBefore)
        {
            ImageConfig[] tmparr = new ImageConfig[ImageConfigs.Length + 1];

            int n = 0;
            for (int i = 0; 0 < ImageConfigs.Length; i++)
            {
                if (i == InsertBefore)
                {
                    tmparr[n] = InImageConfig;
                    n++;
                }
                tmparr[n] = ImageConfigs[i];
                n++;
            }

            Array.Resize<ImageConfig>(ref ImageConfigs, ImageConfigs.Length + 1);
            ImageConfigs = tmparr;

        }
        public void RemoveImageConfig(int ImageConfigNumber)
        {
            if (ImageConfigs != null)
            {
                ImageConfig[] tmparr = new ImageConfig[ImageConfigs.Length - 1];

                int n = 0;
                for (int i = 0; i < ImageConfigs.Length; i++)
                {
                    if (i != ImageConfigNumber)
                    {
                        tmparr[n] = ImageConfigs[i];
                        n++;
                    }

                }

                Array.Resize<ImageConfig>(ref ImageConfigs, ImageConfigs.Length - 1);
                ImageConfigs = tmparr;
            }
        }
    }


    public class ImageConfig
    {
        public double ExposureTime;
        public double fNumber;
        public int FrontLightPower;
        public int BackLightPower;
        public bool Backlights;
        public bool PolarizingFilter;
        public bool NeutralDensityFilter;
        public bool WhitePannel;
        public int LEAExperimentID;
        public bool[] Cameras = new bool[8];
        //public Action[] ImageConfigActions;
    }

    public class Action
    {
        public string Name;
        public string[,] Inputs;
        public string[,] Outputs;

        //the First column of the "Inputs" and "Outputs" Contains the Name of the Variable
        //the second column contaisn the type (i.e. bool, int, double, etc.)
        //the third column contains the value
    }
}