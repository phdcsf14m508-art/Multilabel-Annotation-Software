using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multilabel_Annotation
{
    public partial class ViewDataDetails : Form
    {
        public ViewDataDetails()
        {
            InitializeComponent();
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Select any file";
            //fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            //fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                var directory = Path.GetDirectoryName(fdlg.FileName);

                var vehiclesdatalist = new List<VehicleData>();
                List<string> vehicleTypes = new List<string>();

                var fileNames = Directory.GetFiles(directory, "*.json");

                foreach (string fileName in fileNames)
                    {
                    using (StreamReader r = new StreamReader(fileName))
                    {
                        string json = r.ReadToEnd();
                        VehicleData vehicle = JsonConvert.DeserializeObject<VehicleData>(json);

                        vehicleTypes.Add(vehicle.VehicleType);
                        vehiclesdatalist.Add(vehicle);
                    }
                    
                }

                //string.Join(",", vehiclesdatalist.Where(x => x.VehicleMakeModel == null).ToList().Select(c => c.ImageName))

                var vehicleTypesCount = vehiclesdatalist                    
                                            .GroupBy(s => s.VehicleType)
                                            .Select(g => new { VehicleType = g.Key, Count = g.Count() }).OrderByDescending(x=> x.Count);
                var totalCount = vehiclesdatalist.Count();
                lblTotalCount.Text = totalCount.ToString();
                var typeText = "";
                var makeModelText = "";
                var colourText = "";

                

                foreach (var item in vehicleTypesCount)
                {
                    typeText = typeText + Environment.NewLine + item.VehicleType?.ToString() + " : " + item.Count.ToString();
                }
                lblTypeCount.Text = typeText;


                var vehicleMakeModelCount = vehiclesdatalist               
                                                .GroupBy(s => s.VehicleMakeModel)
                                                .Select(g => new { VehicleMakeModel = g.Key, Count = g.Count() }).OrderByDescending(x => x.Count);


                foreach (var item in vehicleMakeModelCount)
                {
                    makeModelText = makeModelText + Environment.NewLine + item.VehicleMakeModel?.ToString() + " : " + item.Count.ToString();
                }
                lblMakeModelCount.Text = makeModelText;


                var vehicleColourCount = vehiclesdatalist             
                                            .GroupBy(s => s.VehicleColour)
                                            .Select(g => new { VehicleColour = g.Key, Count = g.Count() }).OrderByDescending(x => x.Count);


                foreach (var item in vehicleColourCount)
                {
                    colourText = colourText + Environment.NewLine + item.VehicleColour?.ToString() + " : " + item.Count.ToString();
                }
                lblColourCount.Text = colourText;


            }

                
        }

        private void ViewDataDetails_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var directory = Path.Combine("//shared/UET_ANPR_Project/Multilabel Annotation","");

            var copyDataToThisPath = "E:/Code/CopyDataPath/VehicleType";

            int trainingDataCount = int.Parse(txtTraingCount.Text);
            int validationDataCount = int.Parse(txtValidationCount.Text);
            int testingDataCount = int.Parse(txtTestingCount.Text);

            var fileNames = Directory.GetFiles(directory, "*.json");

            foreach (string fileName in fileNames)
            {
                using (StreamReader r = new StreamReader(fileName))
                {
                    string json = r.ReadToEnd();
                    VehicleData vehicle = JsonConvert.DeserializeObject<VehicleData>(json);

                    var trainingDestinationFolderPath = Path.Combine(copyDataToThisPath + "/train", vehicle.VehicleType);
                    var validationDestinationFolderPath = Path.Combine(copyDataToThisPath + "/val", vehicle.VehicleType);
                    var testingDestinationFolderPath = Path.Combine(copyDataToThisPath + "/testing", vehicle.VehicleType);

                    //Check if path does not exist then create the Path
                    bool exists = System.IO.Directory.Exists(trainingDestinationFolderPath);
                    if (!exists)
                        System.IO.Directory.CreateDirectory(trainingDestinationFolderPath);

                    bool val_exists = System.IO.Directory.Exists(validationDestinationFolderPath);
                    if (!val_exists)
                        System.IO.Directory.CreateDirectory(validationDestinationFolderPath);

                    bool test_exists = System.IO.Directory.Exists(testingDestinationFolderPath);
                    if (!test_exists)
                        System.IO.Directory.CreateDirectory(testingDestinationFolderPath);


                    //Create Source Image Path
                    var sourcePath = Path.Combine(directory, vehicle.ImageName);

                 
                    var trainingDataDestinationPath = Path.Combine(trainingDestinationFolderPath, vehicle.ImageName);
                    var validationDataDestinationPath = Path.Combine(validationDestinationFolderPath, vehicle.ImageName);
                    var testingDataDestinationPath = Path.Combine(testingDestinationFolderPath, vehicle.ImageName);

                    if (Directory.GetFiles(trainingDestinationFolderPath, "*.jpg").Count() < trainingDataCount)
                    {
                        if (File.Exists(sourcePath) && !File.Exists(trainingDataDestinationPath))
                        {
                            Bitmap orignalImage = new Bitmap(sourcePath);                            
                            Bitmap boundingBoxVehicleImage = orignalImage.Clone(new Rectangle(vehicle.VehicleBoundingBox[0], vehicle.VehicleBoundingBox[1], vehicle.VehicleBoundingBox[3] - 1, vehicle.VehicleBoundingBox[2] - 1), orignalImage.PixelFormat);

                            boundingBoxVehicleImage.Save(trainingDataDestinationPath);                           
                        }
                    }
                    else if (Directory.GetFiles(validationDestinationFolderPath, "*.jpg").Count() < validationDataCount)
                    {
                        if (File.Exists(sourcePath) && !File.Exists(validationDataDestinationPath))
                        {
                            Bitmap orignalImage = new Bitmap(sourcePath);                           
                            Bitmap boundingBoxVehicleImage = orignalImage.Clone(new Rectangle(vehicle.VehicleBoundingBox[0], vehicle.VehicleBoundingBox[1], vehicle.VehicleBoundingBox[3] - 1, vehicle.VehicleBoundingBox[2] - 1), orignalImage.PixelFormat);

                            boundingBoxVehicleImage.Save(validationDataDestinationPath);
                      
                        }
                    }
                    else if (Directory.GetFiles(testingDestinationFolderPath, "*.jpg").Count() < testingDataCount)
                    {
                        if (File.Exists(sourcePath) && !File.Exists(testingDataDestinationPath))
                        {
                            Bitmap orignalImage = new Bitmap(sourcePath);
                            Bitmap boundingBoxVehicleImage = orignalImage.Clone(new Rectangle(vehicle.VehicleBoundingBox[0], vehicle.VehicleBoundingBox[1], vehicle.VehicleBoundingBox[3] - 1, vehicle.VehicleBoundingBox[2] - 1), orignalImage.PixelFormat);

                            boundingBoxVehicleImage.Save(testingDataDestinationPath);

                        }
                    }

                }

            }

        }

        private void btnColorDataFolder_Click(object sender, EventArgs e)
        {
            var directory = Path.Combine("//shared/UET_ANPR_Project/Multilabel Annotation", "");

            var copyDataToThisPath = "E:/Code/CopyDataPath/Colour";

            int trainingDataCount = int.Parse(txtTraingCount.Text);
            int validationDataCount = int.Parse(txtValidationCount.Text);
            int testingDataCount = int.Parse(txtTestingCount.Text);

            var fileNames = Directory.GetFiles(directory, "*.json");

            foreach (string fileName in fileNames)
            {
                using (StreamReader r = new StreamReader(fileName))
                {
                    string json = r.ReadToEnd();
                    VehicleData vehicle = JsonConvert.DeserializeObject<VehicleData>(json);

                    var trainingDestinationFolderPath = Path.Combine(copyDataToThisPath + "/train", vehicle.VehicleColour);
                    var validationDestinationFolderPath = Path.Combine(copyDataToThisPath + "/val", vehicle.VehicleColour);
                    var testingDestinationFolderPath = Path.Combine(copyDataToThisPath + "/testing", vehicle.VehicleColour);


                    //Check if path does not exist then create the Path
                    bool exists = System.IO.Directory.Exists(trainingDestinationFolderPath);
                    if (!exists)
                        System.IO.Directory.CreateDirectory(trainingDestinationFolderPath);

                    bool val_exists = System.IO.Directory.Exists(validationDestinationFolderPath);
                    if (!val_exists)
                        System.IO.Directory.CreateDirectory(validationDestinationFolderPath);

                    bool test_exists = System.IO.Directory.Exists(testingDestinationFolderPath);
                    if (!test_exists)
                        System.IO.Directory.CreateDirectory(testingDestinationFolderPath);

                    //Create Source Image Path
                    var sourcePath = Path.Combine(directory, vehicle.ImageName);


                    var trainingDataDestinationPath = Path.Combine(trainingDestinationFolderPath, vehicle.ImageName);
                    var validationDataDestinationPath = Path.Combine(validationDestinationFolderPath, vehicle.ImageName);
                    var testingDataDestinationPath = Path.Combine(testingDestinationFolderPath, vehicle.ImageName);

                    if (Directory.GetFiles(trainingDestinationFolderPath, "*.jpg").Count() < trainingDataCount)
                    {
                        if (File.Exists(sourcePath) && !File.Exists(trainingDataDestinationPath))
                        {
                            Bitmap orignalImage = new Bitmap(sourcePath);
                            Bitmap boundingBoxVehicleImage = orignalImage.Clone(new Rectangle(vehicle.VehicleBoundingBox[0], vehicle.VehicleBoundingBox[1], vehicle.VehicleBoundingBox[3] - 1, vehicle.VehicleBoundingBox[2] - 1), orignalImage.PixelFormat);

                            boundingBoxVehicleImage.Save(trainingDataDestinationPath);
                        }
                    }
                    else if (Directory.GetFiles(validationDestinationFolderPath, "*.jpg").Count() < validationDataCount)
                    {
                        if (File.Exists(sourcePath) && !File.Exists(validationDataDestinationPath))
                        {
                            Bitmap orignalImage = new Bitmap(sourcePath);
                            Bitmap boundingBoxVehicleImage = orignalImage.Clone(new Rectangle(vehicle.VehicleBoundingBox[0], vehicle.VehicleBoundingBox[1], vehicle.VehicleBoundingBox[3] - 1, vehicle.VehicleBoundingBox[2] - 1), orignalImage.PixelFormat);

                            boundingBoxVehicleImage.Save(validationDataDestinationPath);

                        }
                    }
                    else if (Directory.GetFiles(testingDestinationFolderPath, "*.jpg").Count() < testingDataCount)
                    {
                        if (File.Exists(sourcePath) && !File.Exists(testingDataDestinationPath))
                        {
                            Bitmap orignalImage = new Bitmap(sourcePath);
                            Bitmap boundingBoxVehicleImage = orignalImage.Clone(new Rectangle(vehicle.VehicleBoundingBox[0], vehicle.VehicleBoundingBox[1], vehicle.VehicleBoundingBox[3] - 1, vehicle.VehicleBoundingBox[2] - 1), orignalImage.PixelFormat);

                            boundingBoxVehicleImage.Save(testingDataDestinationPath);

                        }
                    }

                }

            }
        }

        private void btnMakeModelDataFolder_Click(object sender, EventArgs e)
        {

            var directory = Path.Combine("//shared/UET_ANPR_Project/Multilabel Annotation", "");

            var copyDataToThisPath = "E:/Code/CopyDataPath/MakeModel";

            int trainingDataCount = int.Parse(txtTraingCount.Text);
            int validationDataCount = int.Parse(txtValidationCount.Text);
            int testingDataCount = int.Parse(txtTestingCount.Text);

            var fileNames = Directory.GetFiles(directory, "*.json");

            foreach (string fileName in fileNames)
            {
                using (StreamReader r = new StreamReader(fileName))
                {
                    string json = r.ReadToEnd();
                    VehicleData vehicle = JsonConvert.DeserializeObject<VehicleData>(json);

                    var trainingDestinationFolderPath = Path.Combine(copyDataToThisPath + "/train", vehicle.VehicleMakeModel);
                    var validationDestinationFolderPath = Path.Combine(copyDataToThisPath + "/val", vehicle.VehicleMakeModel);
                    var testingDestinationFolderPath = Path.Combine(copyDataToThisPath + "/testing", vehicle.VehicleMakeModel);


                    //Check if path does not exist then create the Path
                    bool exists = System.IO.Directory.Exists(trainingDestinationFolderPath);
                    if (!exists)
                        System.IO.Directory.CreateDirectory(trainingDestinationFolderPath);

                    bool val_exists = System.IO.Directory.Exists(validationDestinationFolderPath);
                    if (!val_exists)
                        System.IO.Directory.CreateDirectory(validationDestinationFolderPath);

                    bool test_exists = System.IO.Directory.Exists(testingDestinationFolderPath);
                    if (!test_exists)
                        System.IO.Directory.CreateDirectory(testingDestinationFolderPath);

                    //Create Source Image Path
                    var sourcePath = Path.Combine(directory, vehicle.ImageName);


                    var trainingDataDestinationPath = Path.Combine(trainingDestinationFolderPath, vehicle.ImageName);
                    var validationDataDestinationPath = Path.Combine(validationDestinationFolderPath, vehicle.ImageName);
                    var testingDataDestinationPath = Path.Combine(testingDestinationFolderPath, vehicle.ImageName);

                    if (Directory.GetFiles(trainingDestinationFolderPath, "*.jpg").Count() < trainingDataCount)
                    {
                        if (File.Exists(sourcePath) && !File.Exists(trainingDataDestinationPath))
                        {
                            Bitmap orignalImage = new Bitmap(sourcePath);
                            Bitmap boundingBoxVehicleImage = orignalImage.Clone(new Rectangle(vehicle.VehicleBoundingBox[0], vehicle.VehicleBoundingBox[1], vehicle.VehicleBoundingBox[3] - 1, vehicle.VehicleBoundingBox[2] - 1), orignalImage.PixelFormat);

                            boundingBoxVehicleImage.Save(trainingDataDestinationPath);
                        }
                    }
                    else if (Directory.GetFiles(validationDestinationFolderPath, "*.jpg").Count() < validationDataCount)
                    {
                        if (File.Exists(sourcePath) && !File.Exists(validationDataDestinationPath))
                        {
                            Bitmap orignalImage = new Bitmap(sourcePath);
                            Bitmap boundingBoxVehicleImage = orignalImage.Clone(new Rectangle(vehicle.VehicleBoundingBox[0], vehicle.VehicleBoundingBox[1], vehicle.VehicleBoundingBox[3] - 1, vehicle.VehicleBoundingBox[2] - 1), orignalImage.PixelFormat);

                            boundingBoxVehicleImage.Save(validationDataDestinationPath);

                        }
                    }
                    else if (Directory.GetFiles(testingDestinationFolderPath, "*.jpg").Count() < testingDataCount)
                    {
                        if (File.Exists(sourcePath) && !File.Exists(testingDataDestinationPath))
                        {
                            Bitmap orignalImage = new Bitmap(sourcePath);
                            Bitmap boundingBoxVehicleImage = orignalImage.Clone(new Rectangle(vehicle.VehicleBoundingBox[0], vehicle.VehicleBoundingBox[1], vehicle.VehicleBoundingBox[3] - 1, vehicle.VehicleBoundingBox[2] - 1), orignalImage.PixelFormat);

                            boundingBoxVehicleImage.Save(testingDataDestinationPath);

                        }
                    }

                }

            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
