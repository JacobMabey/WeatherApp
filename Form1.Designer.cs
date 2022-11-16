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
            this.DisplayedCityName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // CitySearchTextBox
            // 
            this.CitySearchTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CitySearchTextBox.Location = new System.Drawing.Point(851, 25);
            this.CitySearchTextBox.Name = "CitySearchTextBox";
            this.CitySearchTextBox.PlaceholderText = "City Search";
            this.CitySearchTextBox.Size = new System.Drawing.Size(240, 39);
            this.CitySearchTextBox.TabIndex = 0;
            this.CitySearchTextBox.TextChanged += new System.EventHandler(this.CitySearchTextBox_TextChanged);
            this.CitySearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CitySearchTextBox_KeyDown);
            this.CitySearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // DisplayedCityName
            // 
            this.DisplayedCityName.AutoSize = true;
            this.DisplayedCityName.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisplayedCityName.Location = new System.Drawing.Point(12, 18);
            this.DisplayedCityName.Name = "DisplayedCityName";
            this.DisplayedCityName.Size = new System.Drawing.Size(377, 67);
            this.DisplayedCityName.TabIndex = 2;
            this.DisplayedCityName.Text = "City Name Here";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WeatherApp.Properties.Resources.Placeholder;
            this.pictureBox1.Location = new System.Drawing.Point(392, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(47, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "Overcast Clouds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(270, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Clouds: 42%";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(383, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Wind: Example numbers, blah blah";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(314, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pressure: 436";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(492, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "Humidity: 12%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(692, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 32);
            this.label7.TabIndex = 9;
            this.label7.Text = "Visibility: 2%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(792, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 120);
            this.label8.TabIndex = 10;
            this.label8.Text = "72°";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(995, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 32);
            this.label9.TabIndex = 11;
            this.label9.Text = "42* / 80*";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(995, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 28);
            this.label10.TabIndex = 12;
            this.label10.Text = "Feels Like: 50*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(771, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 32);
            this.label11.TabIndex = 13;
            this.label11.Text = "Sunrise: 6:00 AM";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(995, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 32);
            this.label12.TabIndex = 14;
            this.label12.Text = "Sunset: 7:00 PM";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.Controls.Add(this.label30, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label29, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label28, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label27, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label26, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox7, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label18, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label19, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label20, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label21, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label22, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label23, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label24, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label25, 3, 0);
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
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label30.Location = new System.Drawing.Point(740, 504);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(290, 41);
            this.label30.TabIndex = 44;
            this.label30.Text = "Temp: 62* (42* | 71*)";
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label29.Location = new System.Drawing.Point(740, 407);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(290, 41);
            this.label29.TabIndex = 43;
            this.label29.Text = "Temp: 62* (42* | 71*)";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label28.Location = new System.Drawing.Point(740, 312);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(290, 41);
            this.label28.TabIndex = 42;
            this.label28.Text = "Temp: 62* (42* | 71*)";
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label27.Location = new System.Drawing.Point(740, 217);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(290, 41);
            this.label27.TabIndex = 41;
            this.label27.Text = "Temp: 62* (42* | 71*)";
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label26.Location = new System.Drawing.Point(740, 122);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(290, 41);
            this.label26.TabIndex = 40;
            this.label26.Text = "Temp: 62* (42* | 71*)";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Location = new System.Drawing.Point(121, 480);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(171, 89);
            this.pictureBox5.TabIndex = 32;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox7.Location = new System.Drawing.Point(121, 383);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(171, 89);
            this.pictureBox7.TabIndex = 31;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Location = new System.Drawing.Point(121, 288);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(171, 89);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox6.Location = new System.Drawing.Point(121, 193);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(171, 89);
            this.pictureBox6.TabIndex = 29;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Location = new System.Drawing.Point(121, 98);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(171, 89);
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(35, 504);
            this.label18.Margin = new System.Windows.Forms.Padding(35, 0, 3, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 41);
            this.label18.TabIndex = 27;
            this.label18.Text = "Sun";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(35, 407);
            this.label17.Margin = new System.Windows.Forms.Padding(35, 0, 3, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 41);
            this.label17.TabIndex = 26;
            this.label17.Text = "Sat";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(35, 312);
            this.label16.Margin = new System.Windows.Forms.Padding(35, 0, 3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 41);
            this.label16.TabIndex = 25;
            this.label16.Text = "Fri";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(35, 217);
            this.label15.Margin = new System.Windows.Forms.Padding(35, 0, 3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 41);
            this.label15.TabIndex = 24;
            this.label15.Text = "Thu";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(35, 122);
            this.label14.Margin = new System.Windows.Forms.Padding(35, 0, 3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 41);
            this.label14.TabIndex = 23;
            this.label14.Text = "Wed";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = global::WeatherApp.Properties.Resources.Placeholder;
            this.pictureBox4.Location = new System.Drawing.Point(121, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(171, 89);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(35, 27);
            this.label13.Margin = new System.Windows.Forms.Padding(35, 0, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 41);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tue";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(298, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(233, 41);
            this.label19.TabIndex = 33;
            this.label19.Text = "Overcast Clouds";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(298, 122);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(233, 41);
            this.label20.TabIndex = 34;
            this.label20.Text = "Overcast Clouds";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(298, 217);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(233, 41);
            this.label21.TabIndex = 35;
            this.label21.Text = "Overcast Clouds";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(298, 312);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(233, 41);
            this.label22.TabIndex = 36;
            this.label22.Text = "Overcast Clouds";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(298, 407);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(233, 41);
            this.label23.TabIndex = 37;
            this.label23.Text = "Overcast Clouds";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(298, 504);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(233, 41);
            this.label24.TabIndex = 38;
            this.label24.Text = "Overcast Clouds";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(740, 27);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(290, 41);
            this.label25.TabIndex = 39;
            this.label25.Text = "Temp: 62* (42* | 71*)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 882);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DisplayedCityName);
            this.Controls.Add(this.CitySearchTextBox);
            this.Name = "Form1";
            this.Text = "Weather Application";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox CitySearchTextBox;
        private Label DisplayedCityName;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox7;
        private PictureBox pictureBox2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox3;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private PictureBox pictureBox4;
        private Label label13;
        private Label label19;
        private Label label30;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
    }
}