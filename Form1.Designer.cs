namespace WeatherApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CitySearchTextBox = new System.Windows.Forms.TextBox();
            this.lblCityName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWeatherDesc = new System.Windows.Forms.Label();
            this.lblClouds = new System.Windows.Forms.Label();
            this.lblWind = new System.Windows.Forms.Label();
            this.lblPressure = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblVisibility = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblTempHighLow = new System.Windows.Forms.Label();
            this.lblTempFeelsLike = new System.Windows.Forms.Label();
            this.lblSunrise = new System.Windows.Forms.Label();
            this.lblSunset = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblForecastTemp6 = new System.Windows.Forms.Label();
            this.lblForecastTemp5 = new System.Windows.Forms.Label();
            this.lblForecastTemp4 = new System.Windows.Forms.Label();
            this.lblForecastTemp3 = new System.Windows.Forms.Label();
            this.lblForecastTemp2 = new System.Windows.Forms.Label();
            this.imgForecastIcon6 = new System.Windows.Forms.PictureBox();
            this.imgForecastIcon5 = new System.Windows.Forms.PictureBox();
            this.imgForecastIcon4 = new System.Windows.Forms.PictureBox();
            this.imgForecastIcon3 = new System.Windows.Forms.PictureBox();
            this.imgForecastIcon2 = new System.Windows.Forms.PictureBox();
            this.lblForecastDay6 = new System.Windows.Forms.Label();
            this.lblForecastDay5 = new System.Windows.Forms.Label();
            this.lblForecastDay4 = new System.Windows.Forms.Label();
            this.lblForecastDay3 = new System.Windows.Forms.Label();
            this.lblForecastDay2 = new System.Windows.Forms.Label();
            this.imgForecastIcon1 = new System.Windows.Forms.PictureBox();
            this.lblForecastDay1 = new System.Windows.Forms.Label();
            this.lblForecastDesc1 = new System.Windows.Forms.Label();
            this.lblForecastDesc2 = new System.Windows.Forms.Label();
            this.lblForecastDesc3 = new System.Windows.Forms.Label();
            this.lblForecastDesc4 = new System.Windows.Forms.Label();
            this.lblForecastDesc5 = new System.Windows.Forms.Label();
            this.lblForecastDesc6 = new System.Windows.Forms.Label();
            this.lblForecastTemp1 = new System.Windows.Forms.Label();
            this.btnCitySearch = new System.Windows.Forms.Button();
            this.btnCurrentLocation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgForecastIcon6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgForecastIcon5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgForecastIcon4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgForecastIcon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgForecastIcon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgForecastIcon1)).BeginInit();
            this.SuspendLayout();
            // 
            // CitySearchTextBox
            // 
            this.CitySearchTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.CitySearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CitySearchTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CitySearchTextBox.Location = new System.Drawing.Point(851, 25);
            this.CitySearchTextBox.Name = "CitySearchTextBox";
            this.CitySearchTextBox.PlaceholderText = "City Search";
            this.CitySearchTextBox.Size = new System.Drawing.Size(240, 39);
            this.CitySearchTextBox.TabIndex = 0;
            this.CitySearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // lblCityName
            // 
            this.lblCityName.AutoSize = true;
            this.lblCityName.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCityName.ForeColor = System.Drawing.Color.Yellow;
            this.lblCityName.Location = new System.Drawing.Point(12, 18);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(377, 67);
            this.lblCityName.TabIndex = 2;
            this.lblCityName.Text = "City Name Here";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WeatherApp.Properties.Resources.Snow;
            this.pictureBox1.Location = new System.Drawing.Point(392, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblWeatherDesc
            // 
            this.lblWeatherDesc.AutoSize = true;
            this.lblWeatherDesc.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWeatherDesc.Location = new System.Drawing.Point(47, 85);
            this.lblWeatherDesc.Name = "lblWeatherDesc";
            this.lblWeatherDesc.Size = new System.Drawing.Size(276, 48);
            this.lblWeatherDesc.TabIndex = 4;
            this.lblWeatherDesc.Text = "Overcast Clouds";
            // 
            // lblClouds
            // 
            this.lblClouds.AutoSize = true;
            this.lblClouds.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClouds.Location = new System.Drawing.Point(236, 141);
            this.lblClouds.Name = "lblClouds";
            this.lblClouds.Size = new System.Drawing.Size(119, 28);
            this.lblClouds.TabIndex = 5;
            this.lblClouds.Text = "Clouds: 42%";
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWind.Location = new System.Drawing.Point(67, 200);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(256, 32);
            this.lblWind.TabIndex = 6;
            this.lblWind.Text = "Wind: Placeholder Text";
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPressure.Location = new System.Drawing.Point(261, 248);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(154, 32);
            this.lblPressure.TabIndex = 7;
            this.lblPressure.Text = "Pressure: 436";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHumidity.Location = new System.Drawing.Point(492, 248);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(170, 32);
            this.lblHumidity.TabIndex = 8;
            this.lblHumidity.Text = "Humidity: 12%";
            // 
            // lblVisibility
            // 
            this.lblVisibility.AutoSize = true;
            this.lblVisibility.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVisibility.Location = new System.Drawing.Point(692, 248);
            this.lblVisibility.Name = "lblVisibility";
            this.lblVisibility.Size = new System.Drawing.Size(148, 32);
            this.lblVisibility.TabIndex = 9;
            this.lblVisibility.Text = "Visibility: 2%";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Segoe UI", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTemp.Location = new System.Drawing.Point(792, 67);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(182, 120);
            this.lblTemp.TabIndex = 10;
            this.lblTemp.Text = "72°";
            // 
            // lblTempHighLow
            // 
            this.lblTempHighLow.AutoSize = true;
            this.lblTempHighLow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTempHighLow.Location = new System.Drawing.Point(995, 85);
            this.lblTempHighLow.Name = "lblTempHighLow";
            this.lblTempHighLow.Size = new System.Drawing.Size(109, 32);
            this.lblTempHighLow.TabIndex = 11;
            this.lblTempHighLow.Text = "42* / 80*";
            // 
            // lblTempFeelsLike
            // 
            this.lblTempFeelsLike.AutoSize = true;
            this.lblTempFeelsLike.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTempFeelsLike.Location = new System.Drawing.Point(995, 130);
            this.lblTempFeelsLike.Name = "lblTempFeelsLike";
            this.lblTempFeelsLike.Size = new System.Drawing.Size(133, 28);
            this.lblTempFeelsLike.TabIndex = 12;
            this.lblTempFeelsLike.Text = "Feels Like: 50*";
            // 
            // lblSunrise
            // 
            this.lblSunrise.AutoSize = true;
            this.lblSunrise.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSunrise.Location = new System.Drawing.Point(771, 200);
            this.lblSunrise.Name = "lblSunrise";
            this.lblSunrise.Size = new System.Drawing.Size(192, 32);
            this.lblSunrise.TabIndex = 13;
            this.lblSunrise.Text = "Sunrise: 6:00 AM";
            // 
            // lblSunset
            // 
            this.lblSunset.AutoSize = true;
            this.lblSunset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSunset.Location = new System.Drawing.Point(995, 200);
            this.lblSunset.Name = "lblSunset";
            this.lblSunset.Size = new System.Drawing.Size(184, 32);
            this.lblSunset.TabIndex = 14;
            this.lblSunset.Text = "Sunset: 7:00 PM";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.Controls.Add(this.lblForecastTemp6, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblForecastTemp5, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblForecastTemp4, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblForecastTemp3, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblForecastTemp2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.imgForecastIcon6, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.imgForecastIcon5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.imgForecastIcon4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.imgForecastIcon3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.imgForecastIcon2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblForecastDay6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblForecastDay5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblForecastDay4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblForecastDay3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblForecastDay2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.imgForecastIcon1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblForecastDay1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblForecastDesc1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblForecastDesc2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblForecastDesc3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblForecastDesc4, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblForecastDesc5, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblForecastDesc6, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblForecastTemp1, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 295);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1180, 575);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // lblForecastTemp6
            // 
            this.lblForecastTemp6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblForecastTemp6.AutoSize = true;
            this.lblForecastTemp6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblForecastTemp6.Location = new System.Drawing.Point(740, 504);
            this.lblForecastTemp6.Name = "lblForecastTemp6";
            this.lblForecastTemp6.Size = new System.Drawing.Size(290, 41);
            this.lblForecastTemp6.TabIndex = 44;
            this.lblForecastTemp6.Text = "Temp: 62* (42* | 71*)";
            // 
            // lblForecastTemp5
            // 
            this.lblForecastTemp5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblForecastTemp5.AutoSize = true;
            this.lblForecastTemp5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblForecastTemp5.Location = new System.Drawing.Point(740, 407);
            this.lblForecastTemp5.Name = "lblForecastTemp5";
            this.lblForecastTemp5.Size = new System.Drawing.Size(290, 41);
            this.lblForecastTemp5.TabIndex = 43;
            this.lblForecastTemp5.Text = "Temp: 62* (42* | 71*)";
            // 
            // lblForecastTemp4
            // 
            this.lblForecastTemp4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblForecastTemp4.AutoSize = true;
            this.lblForecastTemp4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblForecastTemp4.Location = new System.Drawing.Point(740, 312);
            this.lblForecastTemp4.Name = "lblForecastTemp4";
            this.lblForecastTemp4.Size = new System.Drawing.Size(290, 41);
            this.lblForecastTemp4.TabIndex = 42;
            this.lblForecastTemp4.Text = "Temp: 62* (42* | 71*)";
            // 
            // lblForecastTemp3
            // 
            this.lblForecastTemp3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblForecastTemp3.AutoSize = true;
            this.lblForecastTemp3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblForecastTemp3.Location = new System.Drawing.Point(740, 217);
            this.lblForecastTemp3.Name = "lblForecastTemp3";
            this.lblForecastTemp3.Size = new System.Drawing.Size(290, 41);
            this.lblForecastTemp3.TabIndex = 41;
            this.lblForecastTemp3.Text = "Temp: 62* (42* | 71*)";
            // 
            // lblForecastTemp2
            // 
            this.lblForecastTemp2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblForecastTemp2.AutoSize = true;
            this.lblForecastTemp2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblForecastTemp2.Location = new System.Drawing.Point(740, 122);
            this.lblForecastTemp2.Name = "lblForecastTemp2";
            this.lblForecastTemp2.Size = new System.Drawing.Size(290, 41);
            this.lblForecastTemp2.TabIndex = 40;
            this.lblForecastTemp2.Text = "Temp: 62* (42* | 71*)";
            // 
            // imgForecastIcon6
            // 
            this.imgForecastIcon6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.imgForecastIcon6.Image = global::WeatherApp.Properties.Resources.BrokenClouds;
            this.imgForecastIcon6.Location = new System.Drawing.Point(121, 480);
            this.imgForecastIcon6.Name = "imgForecastIcon6";
            this.imgForecastIcon6.Size = new System.Drawing.Size(171, 89);
            this.imgForecastIcon6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgForecastIcon6.TabIndex = 32;
            this.imgForecastIcon6.TabStop = false;
            // 
            // imgForecastIcon5
            // 
            this.imgForecastIcon5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.imgForecastIcon5.Image = global::WeatherApp.Properties.Resources.FewCloudsNight;
            this.imgForecastIcon5.Location = new System.Drawing.Point(121, 383);
            this.imgForecastIcon5.Name = "imgForecastIcon5";
            this.imgForecastIcon5.Size = new System.Drawing.Size(171, 89);
            this.imgForecastIcon5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgForecastIcon5.TabIndex = 31;
            this.imgForecastIcon5.TabStop = false;
            // 
            // imgForecastIcon4
            // 
            this.imgForecastIcon4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.imgForecastIcon4.Image = global::WeatherApp.Properties.Resources.FewCloudsDay;
            this.imgForecastIcon4.Location = new System.Drawing.Point(121, 288);
            this.imgForecastIcon4.Name = "imgForecastIcon4";
            this.imgForecastIcon4.Size = new System.Drawing.Size(171, 89);
            this.imgForecastIcon4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgForecastIcon4.TabIndex = 30;
            this.imgForecastIcon4.TabStop = false;
            // 
            // imgForecastIcon3
            // 
            this.imgForecastIcon3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.imgForecastIcon3.Image = global::WeatherApp.Properties.Resources.ClearSkiesNight;
            this.imgForecastIcon3.Location = new System.Drawing.Point(121, 193);
            this.imgForecastIcon3.Name = "imgForecastIcon3";
            this.imgForecastIcon3.Size = new System.Drawing.Size(171, 89);
            this.imgForecastIcon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgForecastIcon3.TabIndex = 29;
            this.imgForecastIcon3.TabStop = false;
            // 
            // imgForecastIcon2
            // 
            this.imgForecastIcon2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.imgForecastIcon2.Image = global::WeatherApp.Properties.Resources.ClearSkiesDay;
            this.imgForecastIcon2.Location = new System.Drawing.Point(121, 98);
            this.imgForecastIcon2.Name = "imgForecastIcon2";
            this.imgForecastIcon2.Size = new System.Drawing.Size(171, 89);
            this.imgForecastIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgForecastIcon2.TabIndex = 28;
            this.imgForecastIcon2.TabStop = false;
            // 
            // lblForecastDay6
            // 
            this.lblForecastDay6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblForecastDay6.AutoSize = true;
            this.lblForecastDay6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblForecastDay6.Location = new System.Drawing.Point(35, 504);
            this.lblForecastDay6.Margin = new System.Windows.Forms.Padding(35, 0, 3, 0);
            this.lblForecastDay6.Name = "lblForecastDay6";
            this.lblForecastDay6.Size = new System.Drawing.Size(68, 41);
            this.lblForecastDay6.TabIndex = 27;
            this.lblForecastDay6.Text = "Sun";
            // 
            // lblForecastDay5
            // 
            this.lblForecastDay5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblForecastDay5.AutoSize = true;
            this.lblForecastDay5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblForecastDay5.Location = new System.Drawing.Point(35, 407);
            this.lblForecastDay5.Margin = new System.Windows.Forms.Padding(35, 0, 3, 0);
            this.lblForecastDay5.Name = "lblForecastDay5";
            this.lblForecastDay5.Size = new System.Drawing.Size(59, 41);
            this.lblForecastDay5.TabIndex = 26;
            this.lblForecastDay5.Text = "Sat";
            // 
            // lblForecastDay4
            // 
            this.lblForecastDay4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblForecastDay4.AutoSize = true;
            this.lblForecastDay4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblForecastDay4.Location = new System.Drawing.Point(35, 312);
            this.lblForecastDay4.Margin = new System.Windows.Forms.Padding(35, 0, 3, 0);
            this.lblForecastDay4.Name = "lblForecastDay4";
            this.lblForecastDay4.Size = new System.Drawing.Size(50, 41);
            this.lblForecastDay4.TabIndex = 25;
            this.lblForecastDay4.Text = "Fri";
            // 
            // lblForecastDay3
            // 
            this.lblForecastDay3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblForecastDay3.AutoSize = true;
            this.lblForecastDay3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblForecastDay3.Location = new System.Drawing.Point(35, 217);
            this.lblForecastDay3.Margin = new System.Windows.Forms.Padding(35, 0, 3, 0);
            this.lblForecastDay3.Name = "lblForecastDay3";
            this.lblForecastDay3.Size = new System.Drawing.Size(68, 41);
            this.lblForecastDay3.TabIndex = 24;
            this.lblForecastDay3.Text = "Thu";
            // 
            // lblForecastDay2
            // 
            this.lblForecastDay2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblForecastDay2.AutoSize = true;
            this.lblForecastDay2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblForecastDay2.Location = new System.Drawing.Point(35, 122);
            this.lblForecastDay2.Margin = new System.Windows.Forms.Padding(35, 0, 3, 0);
            this.lblForecastDay2.Name = "lblForecastDay2";
            this.lblForecastDay2.Size = new System.Drawing.Size(79, 41);
            this.lblForecastDay2.TabIndex = 23;
            this.lblForecastDay2.Text = "Wed";
            // 
            // imgForecastIcon1
            // 
            this.imgForecastIcon1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.imgForecastIcon1.Image = global::WeatherApp.Properties.Resources.BrokenClouds;
            this.imgForecastIcon1.Location = new System.Drawing.Point(121, 3);
            this.imgForecastIcon1.Name = "imgForecastIcon1";
            this.imgForecastIcon1.Size = new System.Drawing.Size(171, 89);
            this.imgForecastIcon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgForecastIcon1.TabIndex = 19;
            this.imgForecastIcon1.TabStop = false;
            // 
            // lblForecastDay1
            // 
            this.lblForecastDay1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblForecastDay1.AutoSize = true;
            this.lblForecastDay1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblForecastDay1.Location = new System.Drawing.Point(35, 27);
            this.lblForecastDay1.Margin = new System.Windows.Forms.Padding(35, 0, 3, 0);
            this.lblForecastDay1.Name = "lblForecastDay1";
            this.lblForecastDay1.Size = new System.Drawing.Size(67, 41);
            this.lblForecastDay1.TabIndex = 0;
            this.lblForecastDay1.Text = "Tue";
            // 
            // lblForecastDesc1
            // 
            this.lblForecastDesc1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblForecastDesc1.AutoSize = true;
            this.lblForecastDesc1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblForecastDesc1.Location = new System.Drawing.Point(298, 27);
            this.lblForecastDesc1.Name = "lblForecastDesc1";
            this.lblForecastDesc1.Size = new System.Drawing.Size(233, 41);
            this.lblForecastDesc1.TabIndex = 33;
            this.lblForecastDesc1.Text = "Overcast Clouds";
            // 
            // lblForecastDesc2
            // 
            this.lblForecastDesc2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblForecastDesc2.AutoSize = true;
            this.lblForecastDesc2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblForecastDesc2.Location = new System.Drawing.Point(298, 122);
            this.lblForecastDesc2.Name = "lblForecastDesc2";
            this.lblForecastDesc2.Size = new System.Drawing.Size(233, 41);
            this.lblForecastDesc2.TabIndex = 34;
            this.lblForecastDesc2.Text = "Overcast Clouds";
            // 
            // lblForecastDesc3
            // 
            this.lblForecastDesc3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblForecastDesc3.AutoSize = true;
            this.lblForecastDesc3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblForecastDesc3.Location = new System.Drawing.Point(298, 217);
            this.lblForecastDesc3.Name = "lblForecastDesc3";
            this.lblForecastDesc3.Size = new System.Drawing.Size(233, 41);
            this.lblForecastDesc3.TabIndex = 35;
            this.lblForecastDesc3.Text = "Overcast Clouds";
            // 
            // lblForecastDesc4
            // 
            this.lblForecastDesc4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblForecastDesc4.AutoSize = true;
            this.lblForecastDesc4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblForecastDesc4.Location = new System.Drawing.Point(298, 312);
            this.lblForecastDesc4.Name = "lblForecastDesc4";
            this.lblForecastDesc4.Size = new System.Drawing.Size(233, 41);
            this.lblForecastDesc4.TabIndex = 36;
            this.lblForecastDesc4.Text = "Overcast Clouds";
            // 
            // lblForecastDesc5
            // 
            this.lblForecastDesc5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblForecastDesc5.AutoSize = true;
            this.lblForecastDesc5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblForecastDesc5.Location = new System.Drawing.Point(298, 407);
            this.lblForecastDesc5.Name = "lblForecastDesc5";
            this.lblForecastDesc5.Size = new System.Drawing.Size(233, 41);
            this.lblForecastDesc5.TabIndex = 37;
            this.lblForecastDesc5.Text = "Overcast Clouds";
            // 
            // lblForecastDesc6
            // 
            this.lblForecastDesc6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblForecastDesc6.AutoSize = true;
            this.lblForecastDesc6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblForecastDesc6.Location = new System.Drawing.Point(298, 504);
            this.lblForecastDesc6.Name = "lblForecastDesc6";
            this.lblForecastDesc6.Size = new System.Drawing.Size(233, 41);
            this.lblForecastDesc6.TabIndex = 38;
            this.lblForecastDesc6.Text = "Overcast Clouds";
            // 
            // lblForecastTemp1
            // 
            this.lblForecastTemp1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblForecastTemp1.AutoSize = true;
            this.lblForecastTemp1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblForecastTemp1.Location = new System.Drawing.Point(740, 27);
            this.lblForecastTemp1.Name = "lblForecastTemp1";
            this.lblForecastTemp1.Size = new System.Drawing.Size(290, 41);
            this.lblForecastTemp1.TabIndex = 39;
            this.lblForecastTemp1.Text = "Temp: 62* (42* | 71*)";
            // 
            // btnCitySearch
            // 
            this.btnCitySearch.Location = new System.Drawing.Point(1095, 25);
            this.btnCitySearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnCitySearch.Name = "btnCitySearch";
            this.btnCitySearch.Size = new System.Drawing.Size(89, 37);
            this.btnCitySearch.TabIndex = 19;
            this.btnCitySearch.Text = "Search";
            this.btnCitySearch.UseVisualStyleBackColor = true;
            this.btnCitySearch.Click += new System.EventHandler(this.btnCitySearch_Click);
            // 
            // btnCurrentLocation
            // 
            this.btnCurrentLocation.Location = new System.Drawing.Point(792, 25);
            this.btnCurrentLocation.Margin = new System.Windows.Forms.Padding(2);
            this.btnCurrentLocation.Name = "btnCurrentLocation";
            this.btnCurrentLocation.Size = new System.Drawing.Size(38, 37);
            this.btnCurrentLocation.TabIndex = 20;
            this.btnCurrentLocation.Text = "CL";
            this.btnCurrentLocation.UseVisualStyleBackColor = true;
            this.btnCurrentLocation.Click += new System.EventHandler(this.btnCurrentLocation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1204, 882);
            this.Controls.Add(this.btnCurrentLocation);
            this.Controls.Add(this.btnCitySearch);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblSunset);
            this.Controls.Add(this.lblSunrise);
            this.Controls.Add(this.lblTempFeelsLike);
            this.Controls.Add(this.lblTempHighLow);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblVisibility);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.lblPressure);
            this.Controls.Add(this.lblWind);
            this.Controls.Add(this.lblClouds);
            this.Controls.Add(this.lblWeatherDesc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCityName);
            this.Controls.Add(this.CitySearchTextBox);
            this.Name = "Form1";
            this.Text = "Weather Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgForecastIcon6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgForecastIcon5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgForecastIcon4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgForecastIcon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgForecastIcon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgForecastIcon1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox CitySearchTextBox;
        private Label lblCityName;
        private PictureBox pictureBox1;
        private Label lblWeatherDesc;
        private Label lblClouds;
        private Label lblWind;
        private Label lblPressure;
        private Label lblHumidity;
        private Label lblVisibility;
        private Label lblTemp;
        private Label lblTempHighLow;
        private Label lblTempFeelsLike;
        private Label lblSunrise;
        private Label lblSunset;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox imgForecastIcon6;
        private PictureBox imgForecastIcon5;
        private PictureBox imgForecastIcon4;
        private PictureBox imgForecastIcon3;
        private PictureBox imgForecastIcon2;
        private Label lblForecastDay6;
        private Label lblForecastDay5;
        private Label lblForecastDay4;
        private Label lblForecastDay3;
        private Label lblForecastDay2;
        private PictureBox imgForecastIcon1;
        private Label lblForecastDay1;
        private Label lblForecastDesc1;
        private Label lblForecastTemp6;
        private Label lblForecastTemp5;
        private Label lblForecastTemp4;
        private Label lblForecastTemp3;
        private Label lblForecastTemp2;
        private Label lblForecastDesc2;
        private Label lblForecastDesc3;
        private Label lblForecastDesc4;
        private Label lblForecastDesc5;
        private Label lblForecastDesc6;
        private Label lblForecastTemp1;
        private Button btnCitySearch;
        private Button btnCurrentLocation;
    }
}