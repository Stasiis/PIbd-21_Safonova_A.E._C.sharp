
namespace Stormtrooper_21var_Saf
{
    partial class FormPlaneConfig
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
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.checkBoxWindow = new System.Windows.Forms.CheckBox();
            this.checkBoxRockets = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeigth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelWeigth = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.groupBoxTypeOfPlane = new System.Windows.Forms.GroupBox();
            this.labelStormtrooper = new System.Windows.Forms.Label();
            this.labelPlane = new System.Windows.Forms.Label();
            this.panelConfig = new System.Windows.Forms.Panel();
            this.pictureBoxConfig = new System.Windows.Forms.PictureBox();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelRedColor = new System.Windows.Forms.Panel();
            this.panelPinkColor = new System.Windows.Forms.Panel();
            this.panelBlueColor = new System.Windows.Forms.Panel();
            this.panelPurpleColor = new System.Windows.Forms.Panel();
            this.panelGreenColor = new System.Windows.Forms.Panel();
            this.panelBlackColor = new System.Windows.Forms.Panel();
            this.panelWhiteColor = new System.Windows.Forms.Panel();
            this.panelYellowColor = new System.Windows.Forms.Panel();
            this.groupBoxParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeigth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            this.groupBoxTypeOfPlane.SuspendLayout();
            this.panelConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfig)).BeginInit();
            this.groupBoxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Controls.Add(this.checkBoxWindow);
            this.groupBoxParameters.Controls.Add(this.checkBoxRockets);
            this.groupBoxParameters.Controls.Add(this.numericUpDownWeigth);
            this.groupBoxParameters.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxParameters.Controls.Add(this.labelWeigth);
            this.groupBoxParameters.Controls.Add(this.labelMaxSpeed);
            this.groupBoxParameters.Location = new System.Drawing.Point(12, 200);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(461, 156);
            this.groupBoxParameters.TabIndex = 0;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Параметры";
            // 
            // checkBoxWindow
            // 
            this.checkBoxWindow.AutoSize = true;
            this.checkBoxWindow.Location = new System.Drawing.Point(284, 107);
            this.checkBoxWindow.Name = "checkBoxWindow";
            this.checkBoxWindow.Size = new System.Drawing.Size(116, 21);
            this.checkBoxWindow.TabIndex = 4;
            this.checkBoxWindow.Text = "круглое окно";
            this.checkBoxWindow.UseVisualStyleBackColor = true;
            // 
            // checkBoxRockets
            // 
            this.checkBoxRockets.AutoSize = true;
            this.checkBoxRockets.Location = new System.Drawing.Point(284, 50);
            this.checkBoxRockets.Name = "checkBoxRockets";
            this.checkBoxRockets.Size = new System.Drawing.Size(78, 21);
            this.checkBoxRockets.TabIndex = 3;
            this.checkBoxRockets.Text = "ракеты";
            this.checkBoxRockets.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeigth
            // 
            this.numericUpDownWeigth.Location = new System.Drawing.Point(81, 107);
            this.numericUpDownWeigth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeigth.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeigth.Name = "numericUpDownWeigth";
            this.numericUpDownWeigth.Size = new System.Drawing.Size(97, 22);
            this.numericUpDownWeigth.TabIndex = 2;
            this.numericUpDownWeigth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(81, 50);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(97, 22);
            this.numericUpDownMaxSpeed.TabIndex = 1;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelWeigth
            // 
            this.labelWeigth.AutoSize = true;
            this.labelWeigth.Location = new System.Drawing.Point(19, 87);
            this.labelWeigth.Name = "labelWeigth";
            this.labelWeigth.Size = new System.Drawing.Size(99, 17);
            this.labelWeigth.TabIndex = 1;
            this.labelWeigth.Text = "Вес самолета";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(19, 30);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(108, 17);
            this.labelMaxSpeed.TabIndex = 0;
            this.labelMaxSpeed.Text = "Макс. скорость";
            // 
            // groupBoxTypeOfPlane
            // 
            this.groupBoxTypeOfPlane.Controls.Add(this.labelStormtrooper);
            this.groupBoxTypeOfPlane.Controls.Add(this.labelPlane);
            this.groupBoxTypeOfPlane.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTypeOfPlane.Name = "groupBoxTypeOfPlane";
            this.groupBoxTypeOfPlane.Size = new System.Drawing.Size(203, 182);
            this.groupBoxTypeOfPlane.TabIndex = 1;
            this.groupBoxTypeOfPlane.TabStop = false;
            this.groupBoxTypeOfPlane.Text = "Тип самолета";
            // 
            // labelStormtrooper
            // 
            this.labelStormtrooper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStormtrooper.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStormtrooper.Location = new System.Drawing.Point(6, 100);
            this.labelStormtrooper.Name = "labelStormtrooper";
            this.labelStormtrooper.Size = new System.Drawing.Size(191, 67);
            this.labelStormtrooper.TabIndex = 1;
            this.labelStormtrooper.Text = "Штурмовик";
            this.labelStormtrooper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStormtrooper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelStormtrooper_MouseDown);
            // 
            // labelPlane
            // 
            this.labelPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPlane.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlane.Location = new System.Drawing.Point(6, 28);
            this.labelPlane.Name = "labelPlane";
            this.labelPlane.Size = new System.Drawing.Size(191, 67);
            this.labelPlane.TabIndex = 0;
            this.labelPlane.Text = "Обычный самолет";
            this.labelPlane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPlane_MouseDown);
            // 
            // panelConfig
            // 
            this.panelConfig.AllowDrop = true;
            this.panelConfig.Controls.Add(this.pictureBoxConfig);
            this.panelConfig.Location = new System.Drawing.Point(227, 19);
            this.panelConfig.Name = "panelConfig";
            this.panelConfig.Size = new System.Drawing.Size(246, 175);
            this.panelConfig.TabIndex = 2;
            this.panelConfig.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelConfig_DragDrop);
            this.panelConfig.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelConfig_DragEnter);
            // 
            // pictureBoxConfig
            // 
            this.pictureBoxConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxConfig.Location = new System.Drawing.Point(13, 9);
            this.pictureBoxConfig.Name = "pictureBoxConfig";
            this.pictureBoxConfig.Size = new System.Drawing.Size(221, 157);
            this.pictureBoxConfig.TabIndex = 0;
            this.pictureBoxConfig.TabStop = false;
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.panelYellowColor);
            this.groupBoxColors.Controls.Add(this.panelWhiteColor);
            this.groupBoxColors.Controls.Add(this.panelBlackColor);
            this.groupBoxColors.Controls.Add(this.panelGreenColor);
            this.groupBoxColors.Controls.Add(this.panelPurpleColor);
            this.groupBoxColors.Controls.Add(this.panelPinkColor);
            this.groupBoxColors.Controls.Add(this.panelBlueColor);
            this.groupBoxColors.Controls.Add(this.panelRedColor);
            this.groupBoxColors.Controls.Add(this.labelDopColor);
            this.groupBoxColors.Controls.Add(this.labelBaseColor);
            this.groupBoxColors.Location = new System.Drawing.Point(488, 12);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(239, 235);
            this.groupBoxColors.TabIndex = 6;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDopColor.Location = new System.Drawing.Point(6, 78);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(227, 41);
            this.labelDopColor.TabIndex = 12;
            this.labelDopColor.Text = "Дополнительный цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBaseColor.Location = new System.Drawing.Point(6, 28);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(227, 41);
            this.labelBaseColor.TabIndex = 2;
            this.labelBaseColor.Text = "Основной цвет";
            this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(500, 274);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(104, 53);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(617, 274);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(104, 53);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // panelRedColor
            // 
            this.panelRedColor.BackColor = System.Drawing.Color.DarkRed;
            this.panelRedColor.Location = new System.Drawing.Point(31, 130);
            this.panelRedColor.Name = "panelRedColor";
            this.panelRedColor.Size = new System.Drawing.Size(40, 40);
            this.panelRedColor.TabIndex = 13;
            this.panelRedColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelPinkColor
            // 
            this.panelPinkColor.BackColor = System.Drawing.Color.Pink;
            this.panelPinkColor.Location = new System.Drawing.Point(78, 130);
            this.panelPinkColor.Name = "panelPinkColor";
            this.panelPinkColor.Size = new System.Drawing.Size(40, 40);
            this.panelPinkColor.TabIndex = 14;
            this.panelPinkColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlueColor
            // 
            this.panelBlueColor.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelBlueColor.Location = new System.Drawing.Point(124, 130);
            this.panelBlueColor.Name = "panelBlueColor";
            this.panelBlueColor.Size = new System.Drawing.Size(40, 40);
            this.panelBlueColor.TabIndex = 14;
            this.panelBlueColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelPurpleColor
            // 
            this.panelPurpleColor.BackColor = System.Drawing.Color.MediumPurple;
            this.panelPurpleColor.Location = new System.Drawing.Point(170, 130);
            this.panelPurpleColor.Name = "panelPurpleColor";
            this.panelPurpleColor.Size = new System.Drawing.Size(40, 40);
            this.panelPurpleColor.TabIndex = 14;
            this.panelPurpleColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGreenColor
            // 
            this.panelGreenColor.BackColor = System.Drawing.Color.SeaGreen;
            this.panelGreenColor.Location = new System.Drawing.Point(31, 176);
            this.panelGreenColor.Name = "panelGreenColor";
            this.panelGreenColor.Size = new System.Drawing.Size(40, 40);
            this.panelGreenColor.TabIndex = 14;
            this.panelGreenColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlackColor
            // 
            this.panelBlackColor.BackColor = System.Drawing.Color.Black;
            this.panelBlackColor.Location = new System.Drawing.Point(78, 176);
            this.panelBlackColor.Name = "panelBlackColor";
            this.panelBlackColor.Size = new System.Drawing.Size(40, 40);
            this.panelBlackColor.TabIndex = 14;
            this.panelBlackColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelWhiteColor
            // 
            this.panelWhiteColor.BackColor = System.Drawing.Color.White;
            this.panelWhiteColor.Location = new System.Drawing.Point(124, 176);
            this.panelWhiteColor.Name = "panelWhiteColor";
            this.panelWhiteColor.Size = new System.Drawing.Size(40, 40);
            this.panelWhiteColor.TabIndex = 14;
            this.panelWhiteColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelYellowColor
            // 
            this.panelYellowColor.BackColor = System.Drawing.Color.Gold;
            this.panelYellowColor.Location = new System.Drawing.Point(170, 176);
            this.panelYellowColor.Name = "panelYellowColor";
            this.panelYellowColor.Size = new System.Drawing.Size(40, 40);
            this.panelYellowColor.TabIndex = 14;
            this.panelYellowColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // FormPlaneConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 368);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panelConfig);
            this.Controls.Add(this.groupBoxTypeOfPlane);
            this.Controls.Add(this.groupBoxParameters);
            this.Name = "FormPlaneConfig";
            this.Text = "Выбор самолета";
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeigth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            this.groupBoxTypeOfPlane.ResumeLayout(false);
            this.panelConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfig)).EndInit();
            this.groupBoxColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.NumericUpDown numericUpDownWeigth;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.Label labelWeigth;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.CheckBox checkBoxWindow;
        private System.Windows.Forms.CheckBox checkBoxRockets;
        private System.Windows.Forms.GroupBox groupBoxTypeOfPlane;
        private System.Windows.Forms.Label labelStormtrooper;
        private System.Windows.Forms.Label labelPlane;
        private System.Windows.Forms.Panel panelConfig;
        private System.Windows.Forms.PictureBox pictureBoxConfig;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panelYellowColor;
        private System.Windows.Forms.Panel panelWhiteColor;
        private System.Windows.Forms.Panel panelBlackColor;
        private System.Windows.Forms.Panel panelGreenColor;
        private System.Windows.Forms.Panel panelPurpleColor;
        private System.Windows.Forms.Panel panelPinkColor;
        private System.Windows.Forms.Panel panelBlueColor;
        private System.Windows.Forms.Panel panelRedColor;
    }
}
