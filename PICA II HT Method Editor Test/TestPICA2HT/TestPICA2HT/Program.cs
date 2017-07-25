using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PICA_II_HT_Method_Editor_Dev;

namespace TestPICA2HT
{
    class Program
    {
        static void Main()
        {
            Method myMethod;
            Step tempStep;
            ImageConfig tempImageConfig;
            System.IO.StreamWriter writer;
            System.IO.StreamWriter writer2;
            System.IO.StreamReader reader;

            myMethod = new Method();
            tempStep = new Step();
            tempImageConfig = new ImageConfig();
            string SaveName1 = "C:\\Users\\u781920\\Desktop\\test.xml";
            string SaveName2 = "C:\\Users\\u781920\\Desktop\\test2.xml";


            myMethod.Name = "test1";
            myMethod.Author = "Test";
            myMethod.Description = "testing the XML Printing of this program";
            myMethod.LEALibID = 12;

            tempStep.Type = Step.StepType.Hold;
            tempStep.EquilibriumTime = 12.25;
            tempStep.MeasurementTemperatureResolution = 5.75;
            tempStep.MixingSpeed = 7.25;
            tempStep.Mode = Step.PressureMode.SetPoint;
            tempStep.NumberOfMeasurements = 4;
            tempStep.PressureSetPoint = 6.8;
            tempStep.TemperatureSetPoint = 484.5;
            tempStep.WaitTimeBetweenMeasurements = 0.8;

            tempImageConfig.BackLightPower = 5;
            tempImageConfig.Backlights = true;
            tempImageConfig.Cameras = new bool[] { true, false, true, true, false, true, true, false };


            //tempStep.AddImageConfig(tempImageConfig);
            //tempStep.AddImageConfig(tempImageConfig);
            //tempStep.AddImageConfig(tempImageConfig);

            myMethod.AddStep(tempStep);
            myMethod.AddStep(tempStep);

            writer = new System.IO.StreamWriter(SaveName1);
            myMethod.PrintToFile(writer);
            writer.Close();
            writer.Dispose();

            //reader = new System.IO.StreamReader(SaveName1);
            //myMethod.ParseFromFile(reader);
            //reader.Close();
            //reader.Dispose();

            //writer2 = new System.IO.StreamWriter(SaveName2);
            //myMethod.PrintToFile(writer2);
            //writer2.Close();
            //writer2.Dispose();

            

        }
    }
}
