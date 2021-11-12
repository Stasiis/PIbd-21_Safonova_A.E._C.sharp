
namespace Stormtrooper_21var_Saf
{
    partial class FormParking
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.buttonParkingPlane = new System.Windows.Forms.Button();
            this.buttonParkingST = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonTakePlane = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxParking = new System.Windows.Forms.ListBox();
            this.buttonAddParking = new System.Windows.Forms.Button();
            this.buttonDelParking = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(1, 0);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(780, 499);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonParkingPlane
            // 
            this.buttonParkingPlane.Location = new System.Drawing.Point(787, 12);
            this.buttonParkingPlane.Name = "buttonParkingPlane";
            this.buttonParkingPlane.Size = new System.Drawing.Size(131, 77);
            this.buttonParkingPlane.TabIndex = 1;
            this.buttonParkingPlane.Text = "Припарковать самолет";
            this.buttonParkingPlane.UseVisualStyleBackColor = true;
            this.buttonParkingPlane.Click += new System.EventHandler(this.buttonParkingPlane_Click);
            // 
            // buttonParkingST
            // 
            this.buttonParkingST.Location = new System.Drawing.Point(787, 95);
            this.buttonParkingST.Name = "buttonParkingST";
            this.buttonParkingST.Size = new System.Drawing.Size(131, 77);
            this.buttonParkingST.TabIndex = 2;
            this.buttonParkingST.Text = "Припарковать штурмовик";
            this.buttonParkingST.UseVisualStyleBackColor = true;
            this.buttonParkingST.Click += new System.EventHandler(this.buttonParkingST_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonTakePlane);
            this.groupBox.Controls.Add(this.maskedTextBox);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Location = new System.Drawing.Point(788, 186);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(130, 110);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Забрать транспорт";
            // 
            // buttonTakePlane
            // 
            this.buttonTakePlane.Location = new System.Drawing.Point(6, 62);
            this.buttonTakePlane.Name = "buttonTakePlane";
            this.buttonTakePlane.Size = new System.Drawing.Size(115, 42);
            this.buttonTakePlane.TabIndex = 6;
            this.buttonTakePlane.Text = "Забрать";
            this.buttonTakePlane.UseVisualStyleBackColor = true;
            this.buttonTakePlane.Click += new System.EventHandler(this.buttonTakePlane_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(75, 34);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(40, 22);
            this.maskedTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Место:";
            // 
            // listBoxParking
            // 
            this.listBoxParking.FormattingEnabled = true;
            this.listBoxParking.ItemHeight = 16;
            this.listBoxParking.Location = new System.Drawing.Point(783, 82);
            this.listBoxParking.Name = "listBoxParking";
            this.listBoxParking.Size = new System.Drawing.Size(153, 84);
            this.listBoxParking.TabIndex = 4;
            this.listBoxParking.SelectedIndexChanged += new System.EventHandler(this.listBoxParking_SelectedIndexChanged);
            // 
            // buttonAddParking
            // 
            this.buttonAddParking.Location = new System.Drawing.Point(783, 48);
            this.buttonAddParking.Name = "buttonAddParking";
            this.buttonAddParking.Size = new System.Drawing.Size(153, 28);
            this.buttonAddParking.TabIndex = 5;
            this.buttonAddParking.Text = "Добавить парковку";
            this.buttonAddParking.UseVisualStyleBackColor = true;
            this.buttonAddParking.Click += new System.EventHandler(this.buttonAddParking_Click);
            // 
            // buttonDelParking
            // 
            this.buttonDelParking.Location = new System.Drawing.Point(783, 172);
            this.buttonDelParking.Name = "buttonDelParking";
            this.buttonDelParking.Size = new System.Drawing.Size(153, 28);
            this.buttonDelParking.TabIndex = 6;
            this.buttonDelParking.Text = "Удалить парковку";
            this.buttonDelParking.UseVisualStyleBackColor = true;
            this.buttonDelParking.Click += new System.EventHandler(this.buttonDelParking_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(823, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Парковки:";
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(783, 20);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(153, 22);
            this.textBoxNewLevelName.TabIndex = 8;
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 500);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDelParking);
            this.Controls.Add(this.buttonAddParking);
            this.Controls.Add(this.listBoxParking);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonParkingST);
            this.Controls.Add(this.buttonParkingPlane);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "Angar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonParkingPlane;
        private System.Windows.Forms.Button buttonParkingST;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTakePlane;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.ListBox listBoxParking;
        private System.Windows.Forms.Button buttonAddParking;
        private System.Windows.Forms.Button buttonDelParking;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
    }
}

