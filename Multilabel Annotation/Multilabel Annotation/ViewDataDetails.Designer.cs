namespace Multilabel_Annotation
{
    partial class ViewDataDetails
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
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.lblTypeCount = new System.Windows.Forms.Label();
            this.lblMakeModelCount = new System.Windows.Forms.Label();
            this.lblColourCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTraingCount = new System.Windows.Forms.TextBox();
            this.txtValidationCount = new System.Windows.Forms.TextBox();
            this.btnColorDataFolder = new System.Windows.Forms.Button();
            this.btnMakeModelDataFolder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTestingCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Location = new System.Drawing.Point(86, 12);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(108, 23);
            this.btnOpenFileDialog.TabIndex = 1;
            this.btnOpenFileDialog.Text = "Open Folder";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // lblTypeCount
            // 
            this.lblTypeCount.AutoSize = true;
            this.lblTypeCount.Location = new System.Drawing.Point(332, 118);
            this.lblTypeCount.Name = "lblTypeCount";
            this.lblTypeCount.Size = new System.Drawing.Size(69, 13);
            this.lblTypeCount.TabIndex = 2;
            this.lblTypeCount.Text = "lblTypeCount";
            // 
            // lblMakeModelCount
            // 
            this.lblMakeModelCount.AutoSize = true;
            this.lblMakeModelCount.Location = new System.Drawing.Point(83, 118);
            this.lblMakeModelCount.Name = "lblMakeModelCount";
            this.lblMakeModelCount.Size = new System.Drawing.Size(63, 13);
            this.lblMakeModelCount.TabIndex = 3;
            this.lblMakeModelCount.Text = "MakeModel";
            // 
            // lblColourCount
            // 
            this.lblColourCount.AutoSize = true;
            this.lblColourCount.Location = new System.Drawing.Point(562, 118);
            this.lblColourCount.Name = "lblColourCount";
            this.lblColourCount.Size = new System.Drawing.Size(37, 13);
            this.lblColourCount.TabIndex = 4;
            this.lblColourCount.Text = "Colour";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Make Model ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(547, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Colour";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Location = new System.Drawing.Point(458, 22);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(62, 13);
            this.lblTotalCount.TabIndex = 8;
            this.lblTotalCount.Text = "Total Count";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(321, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Records";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(635, 673);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Convert Vehicle Types to folders";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTraingCount
            // 
            this.txtTraingCount.Location = new System.Drawing.Point(354, 615);
            this.txtTraingCount.Name = "txtTraingCount";
            this.txtTraingCount.Size = new System.Drawing.Size(100, 20);
            this.txtTraingCount.TabIndex = 11;
            this.txtTraingCount.Text = "240";
            // 
            // txtValidationCount
            // 
            this.txtValidationCount.Location = new System.Drawing.Point(491, 615);
            this.txtValidationCount.Name = "txtValidationCount";
            this.txtValidationCount.Size = new System.Drawing.Size(100, 20);
            this.txtValidationCount.TabIndex = 12;
            this.txtValidationCount.Text = "40";
            // 
            // btnColorDataFolder
            // 
            this.btnColorDataFolder.Location = new System.Drawing.Point(475, 673);
            this.btnColorDataFolder.Name = "btnColorDataFolder";
            this.btnColorDataFolder.Size = new System.Drawing.Size(154, 23);
            this.btnColorDataFolder.TabIndex = 13;
            this.btnColorDataFolder.Text = "Convert colour to folders";
            this.btnColorDataFolder.UseVisualStyleBackColor = true;
            this.btnColorDataFolder.Click += new System.EventHandler(this.btnColorDataFolder_Click);
            // 
            // btnMakeModelDataFolder
            // 
            this.btnMakeModelDataFolder.Location = new System.Drawing.Point(285, 673);
            this.btnMakeModelDataFolder.Name = "btnMakeModelDataFolder";
            this.btnMakeModelDataFolder.Size = new System.Drawing.Size(169, 23);
            this.btnMakeModelDataFolder.TabIndex = 14;
            this.btnMakeModelDataFolder.Text = "Convert make model to folders";
            this.btnMakeModelDataFolder.UseVisualStyleBackColor = true;
            this.btnMakeModelDataFolder.Click += new System.EventHandler(this.btnMakeModelDataFolder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 582);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Validation Data Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 582);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Training Data Count";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(648, 582);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Testing Data Count";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtTestingCount
            // 
            this.txtTestingCount.Location = new System.Drawing.Point(650, 615);
            this.txtTestingCount.Name = "txtTestingCount";
            this.txtTestingCount.Size = new System.Drawing.Size(100, 20);
            this.txtTestingCount.TabIndex = 17;
            this.txtTestingCount.Text = "100";
            this.txtTestingCount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ViewDataDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 717);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTestingCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMakeModelDataFolder);
            this.Controls.Add(this.btnColorDataFolder);
            this.Controls.Add(this.txtValidationCount);
            this.Controls.Add(this.txtTraingCount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblColourCount);
            this.Controls.Add(this.lblMakeModelCount);
            this.Controls.Add(this.lblTypeCount);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Name = "ViewDataDetails";
            this.Text = "ViewDataDetails";
            this.Load += new System.EventHandler(this.ViewDataDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.Label lblTypeCount;
        private System.Windows.Forms.Label lblMakeModelCount;
        private System.Windows.Forms.Label lblColourCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTraingCount;
        private System.Windows.Forms.TextBox txtValidationCount;
        private System.Windows.Forms.Button btnColorDataFolder;
        private System.Windows.Forms.Button btnMakeModelDataFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTestingCount;
    }
}