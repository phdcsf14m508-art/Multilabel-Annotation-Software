using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Multilabel_Annotation
{
    public partial class frmSetLabels : Form
    {
        public frmSetLabels()
        {
            InitializeComponent();
        }
        public static bool FirstPhaseAnnotationDone = false;
        public static bool SecondPhaseAnnotationDone = false;
        public static string selectedType = "";
        public static string selectedMakeModel = "";
        public static string selectedColour = "";
        public static string NumberPlate = "";

        private void frmSetLabels_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            txtXcoor.Text = Form1.x.ToString();
            txtYcoor.Text = Form1.y.ToString();
            txtHeight.Text = Form1.height.ToString();
            txtWidth.Text = Form1.width.ToString();


            if (FirstPhaseAnnotationDone == true)
                panel1.Visible = true;

            txtNumberPlate_X .Text = Form1.NumberPlate_x.ToString();
            txtNumberPlate_Y.Text = Form1.NumberPlate_y.ToString();
            txtNumberPlate_Height.Text = Form1.NumberPlate_height.ToString();
            txtNumberPlate_Width.Text = Form1.NumberPlate_width.ToString();


            Bitmap orignalImage = new Bitmap(Form1.FileName);
            Bitmap vehicleImage = orignalImage.Clone(new Rectangle(Form1.x, Form1.y, Form1.width+1, Form1.height+1),  orignalImage.PixelFormat);
            Bitmap numberPlateImage  = orignalImage.Clone(new Rectangle(Form1.NumberPlate_x, Form1.NumberPlate_y, Form1.NumberPlate_width + 1, Form1.NumberPlate_height + 1), orignalImage.PixelFormat);

            PlatePictureBox.Image = numberPlateImage;
            VehiclePictureBox.Image = vehicleImage; 
         
        }

        private void comboVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFirstPhaseDone_Click(object sender, EventArgs e)
        {
            FirstPhaseAnnotationDone = true;

            this.Hide();
            
        }

        private void btnSecondPhaseDone_Click(object sender, EventArgs e)
        {
            VehicleData vehicle = new VehicleData();
            vehicle.ImageName = Path.GetFileName(Form1.FileName);
           

            var txtVehicleX = Form1.x;
            var txtVehicleYcoor = Form1.y;
            var txtVehicleHeight = Form1.height;
            var txtVehicleWidth = Form1.width;


            vehicle.VehicleBoundingBox = new int[] { txtVehicleX, txtVehicleYcoor, txtVehicleHeight, txtVehicleWidth };
            vehicle.NumberPlateBoundingBox = new int[] { Form1.NumberPlate_x, Form1.NumberPlate_y, Form1.NumberPlate_height, Form1.NumberPlate_width };
            vehicle.VehicleType = (string)comboVehicleType.SelectedItem;
            vehicle.VehicleMakeModel = (string)comboMakeModel.SelectedItem;
            vehicle.VehicleColour = (string)comboColour.SelectedItem;
            vehicle.NumberPlate = NumberPlateTextBox.Text;


            var json = new JavaScriptSerializer().Serialize(vehicle);
            string JsonFilePath = Path.ChangeExtension(Form1.FileName, ".json");

            System.IO.File.WriteAllText(JsonFilePath, json);

            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtNumberPlatet_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
