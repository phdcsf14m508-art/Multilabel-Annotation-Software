namespace Multilabel_Annotation
{
    partial class frmSetLabels
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtXcoor = new System.Windows.Forms.TextBox();
            this.txtYcoor = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.x = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboVehicleType = new System.Windows.Forms.ComboBox();
            this.comboMakeModel = new System.Windows.Forms.ComboBox();
            this.comboColour = new System.Windows.Forms.ComboBox();
            this.Type = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumberPlate_Width = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNumberPlate = new System.Windows.Forms.Label();
            this.txtNumberPlate_Height = new System.Windows.Forms.TextBox();
            this.txtNumberPlate_Y = new System.Windows.Forms.TextBox();
            this.txtNumberPlate_X = new System.Windows.Forms.TextBox();
            this.btnFirstPhaseDone = new System.Windows.Forms.Button();
            this.btnSecondPhaseDone = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PlatePictureBox = new System.Windows.Forms.PictureBox();
            this.NumberPlateTextBox = new System.Windows.Forms.TextBox();
            this.VehiclePictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlatePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehiclePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtXcoor
            // 
            this.txtXcoor.Location = new System.Drawing.Point(49, 55);
            this.txtXcoor.Name = "txtXcoor";
            this.txtXcoor.Size = new System.Drawing.Size(75, 20);
            this.txtXcoor.TabIndex = 0;
            // 
            // txtYcoor
            // 
            this.txtYcoor.Location = new System.Drawing.Point(161, 55);
            this.txtYcoor.Name = "txtYcoor";
            this.txtYcoor.Size = new System.Drawing.Size(75, 20);
            this.txtYcoor.TabIndex = 1;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(284, 55);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(75, 20);
            this.txtHeight.TabIndex = 2;
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Location = new System.Drawing.Point(21, 58);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(14, 13);
            this.x.TabIndex = 3;
            this.x.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Height";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(403, 56);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(75, 20);
            this.txtWidth.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Width";
            // 
            // comboVehicleType
            // 
            this.comboVehicleType.FormattingEnabled = true;
            this.comboVehicleType.Items.AddRange(new object[] {
            "Motorcycle",
            "Rickshaw",
            "Car",
            "Bus",
            "Van",
            "Truck",
            "Ambulance",
            "Tractor",
            "Qingqi",
            "Loader_Rikshaw"});
            this.comboVehicleType.Location = new System.Drawing.Point(51, 136);
            this.comboVehicleType.Name = "comboVehicleType";
            this.comboVehicleType.Size = new System.Drawing.Size(214, 21);
            this.comboVehicleType.TabIndex = 8;
            this.comboVehicleType.SelectedIndexChanged += new System.EventHandler(this.comboVehicleType_SelectedIndexChanged);
            // 
            // comboMakeModel
            // 
            this.comboMakeModel.FormattingEnabled = true;
            this.comboMakeModel.Items.AddRange(new object[] {
            "Suzuki_WagonR",
            "Suzuki_Cultus",
            "Suzuki_Alto",
            "Suzuki_Mehran",
            "Suzuki_Bolan",
            "Suzuki_Ravi",
            "Suzuki_Every",
            "Suzuki_Swift",
            "Suzuki_Liana",
            "Suzuki_Khyber",
            "Suzuki_Vitara",
            "Suzuki_Balena",
            "Suzuki_Margala",
            "Toyota_Yaris",
            "Toyota_Corolla",
            "Toyota_Hiace",
            "Toyota_Aqua",
            "Toyota_Revo",
            "Toyota_Fortuner",
            "Toyota_Prado",
            "Toyota_Vitz",
            "Honda_City",
            "Honda_Civic",
            "Honda_BRV",
            "Honda_Vezel",
            "Daihatsu_Mira",
            "Daihatsu_Cuore",
            "Daihatsu_Move",
            "Daihatsu_Charade",
            "Kia_Picanto",
            "Kia_Sportage",
            "Hyundai_Santro",
            "Hyundai_Shehzore",
            "Hyundai_Elantra",
            "Hyundai_Tucson",
            "Changan_Alsvin",
            "Changan_Karvaan",
            "Nissan_Juke",
            "Nissan_Dayz",
            "Nissan_Clipper",
            "Others"});
            this.comboMakeModel.Location = new System.Drawing.Point(367, 136);
            this.comboMakeModel.Name = "comboMakeModel";
            this.comboMakeModel.Size = new System.Drawing.Size(233, 21);
            this.comboMakeModel.TabIndex = 9;
            // 
            // comboColour
            // 
            this.comboColour.FormattingEnabled = true;
            this.comboColour.Items.AddRange(new object[] {
            "White",
            "Black",
            "Brown",
            "Grey",
            "Blue",
            "Yellow",
            "Green",
            "Red",
            "Silver",
            "Others"});
            this.comboColour.Location = new System.Drawing.Point(682, 133);
            this.comboColour.Name = "comboColour";
            this.comboColour.Size = new System.Drawing.Size(171, 21);
            this.comboColour.TabIndex = 10;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(14, 136);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(31, 13);
            this.Type.TabIndex = 11;
            this.Type.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(625, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Colour";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Make Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Vehicle Bounding Box";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Number Plate Bounding Box";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Width";
            // 
            // txtNumberPlate_Width
            // 
            this.txtNumberPlate_Width.Location = new System.Drawing.Point(424, 48);
            this.txtNumberPlate_Width.Name = "txtNumberPlate_Width";
            this.txtNumberPlate_Width.Size = new System.Drawing.Size(82, 20);
            this.txtNumberPlate_Width.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(251, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Height";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(149, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Y";
            // 
            // txtNumberPlate
            // 
            this.txtNumberPlate.AutoSize = true;
            this.txtNumberPlate.Location = new System.Drawing.Point(42, 51);
            this.txtNumberPlate.Name = "txtNumberPlate";
            this.txtNumberPlate.Size = new System.Drawing.Size(14, 13);
            this.txtNumberPlate.TabIndex = 19;
            this.txtNumberPlate.Text = "X";
            // 
            // txtNumberPlate_Height
            // 
            this.txtNumberPlate_Height.Location = new System.Drawing.Point(295, 45);
            this.txtNumberPlate_Height.Name = "txtNumberPlate_Height";
            this.txtNumberPlate_Height.Size = new System.Drawing.Size(82, 20);
            this.txtNumberPlate_Height.TabIndex = 18;
            // 
            // txtNumberPlate_Y
            // 
            this.txtNumberPlate_Y.Location = new System.Drawing.Point(168, 48);
            this.txtNumberPlate_Y.Name = "txtNumberPlate_Y";
            this.txtNumberPlate_Y.Size = new System.Drawing.Size(82, 20);
            this.txtNumberPlate_Y.TabIndex = 17;
            // 
            // txtNumberPlate_X
            // 
            this.txtNumberPlate_X.Location = new System.Drawing.Point(61, 48);
            this.txtNumberPlate_X.Name = "txtNumberPlate_X";
            this.txtNumberPlate_X.Size = new System.Drawing.Size(81, 20);
            this.txtNumberPlate_X.TabIndex = 16;
            // 
            // btnFirstPhaseDone
            // 
            this.btnFirstPhaseDone.Location = new System.Drawing.Point(243, 133);
            this.btnFirstPhaseDone.Name = "btnFirstPhaseDone";
            this.btnFirstPhaseDone.Size = new System.Drawing.Size(236, 23);
            this.btnFirstPhaseDone.TabIndex = 25;
            this.btnFirstPhaseDone.Text = "Draw Number Plate Bounding Box";
            this.btnFirstPhaseDone.UseVisualStyleBackColor = true;
            this.btnFirstPhaseDone.Click += new System.EventHandler(this.btnFirstPhaseDone_Click);
            // 
            // btnSecondPhaseDone
            // 
            this.btnSecondPhaseDone.Location = new System.Drawing.Point(561, 234);
            this.btnSecondPhaseDone.Name = "btnSecondPhaseDone";
            this.btnSecondPhaseDone.Size = new System.Drawing.Size(236, 23);
            this.btnSecondPhaseDone.TabIndex = 26;
            this.btnSecondPhaseDone.Text = "Finish Second Phase and Save to File";
            this.btnSecondPhaseDone.UseVisualStyleBackColor = true;
            this.btnSecondPhaseDone.Click += new System.EventHandler(this.btnSecondPhaseDone_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Number Plate";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(421, 234);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 23);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PlatePictureBox);
            this.panel1.Controls.Add(this.NumberPlateTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.comboVehicleType);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.comboMakeModel);
            this.panel1.Controls.Add(this.btnSecondPhaseDone);
            this.panel1.Controls.Add(this.comboColour);
            this.panel1.Controls.Add(this.Type);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNumberPlate_Width);
            this.panel1.Controls.Add(this.txtNumberPlate_X);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtNumberPlate_Y);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtNumberPlate_Height);
            this.panel1.Controls.Add(this.txtNumberPlate);
            this.panel1.Location = new System.Drawing.Point(13, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 318);
            this.panel1.TabIndex = 29;
            // 
            // PlatePictureBox
            // 
            this.PlatePictureBox.Location = new System.Drawing.Point(650, 3);
            this.PlatePictureBox.Name = "PlatePictureBox";
            this.PlatePictureBox.Size = new System.Drawing.Size(204, 118);
            this.PlatePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlatePictureBox.TabIndex = 30;
            this.PlatePictureBox.TabStop = false;
            // 
            // NumberPlateTextBox
            // 
            this.NumberPlateTextBox.Location = new System.Drawing.Point(121, 183);
            this.NumberPlateTextBox.Name = "NumberPlateTextBox";
            this.NumberPlateTextBox.Size = new System.Drawing.Size(272, 20);
            this.NumberPlateTextBox.TabIndex = 29;
            // 
            // VehiclePictureBox
            // 
            this.VehiclePictureBox.Location = new System.Drawing.Point(595, 5);
            this.VehiclePictureBox.Name = "VehiclePictureBox";
            this.VehiclePictureBox.Size = new System.Drawing.Size(288, 171);
            this.VehiclePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VehiclePictureBox.TabIndex = 30;
            this.VehiclePictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSetLabels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 527);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.VehiclePictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFirstPhaseDone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.x);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtYcoor);
            this.Controls.Add(this.txtXcoor);
            this.Name = "frmSetLabels";
            this.Text = "frmSetLabels";
            this.Load += new System.EventHandler(this.frmSetLabels_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlatePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehiclePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtXcoor;
        private System.Windows.Forms.TextBox txtYcoor;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboVehicleType;
        private System.Windows.Forms.ComboBox comboMakeModel;
        private System.Windows.Forms.ComboBox comboColour;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumberPlate_Width;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txtNumberPlate;
        private System.Windows.Forms.TextBox txtNumberPlate_Height;
        private System.Windows.Forms.TextBox txtNumberPlate_Y;
        private System.Windows.Forms.TextBox txtNumberPlate_X;
        private System.Windows.Forms.Button btnFirstPhaseDone;
        private System.Windows.Forms.Button btnSecondPhaseDone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox NumberPlateTextBox;
        private System.Windows.Forms.PictureBox PlatePictureBox;
        private System.Windows.Forms.PictureBox VehiclePictureBox;
        private System.Windows.Forms.Button button1;
    }
}