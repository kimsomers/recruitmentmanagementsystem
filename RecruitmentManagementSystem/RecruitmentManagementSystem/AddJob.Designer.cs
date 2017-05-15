namespace RecruitmentManagementSystem
{
    partial class AddJob
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
            this.btnCancelJob = new System.Windows.Forms.Button();
            this.btnSaveJob = new System.Windows.Forms.Button();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.txtBoxJobTitle = new System.Windows.Forms.TextBox();
            this.lblJobStatus = new System.Windows.Forms.Label();
            this.comboJobStatus = new System.Windows.Forms.ComboBox();
            this.lblJobCompany = new System.Windows.Forms.Label();
            this.lblJobAdded = new System.Windows.Forms.Label();
            this.txtBoxJobAdded = new System.Windows.Forms.TextBox();
            this.lblJobCategory = new System.Windows.Forms.Label();
            this.txtBoxJobCategory = new System.Windows.Forms.TextBox();
            this.txtBoxJobCompany = new System.Windows.Forms.TextBox();
            this.lblJobCity = new System.Windows.Forms.Label();
            this.txtBoxJobCity = new System.Windows.Forms.TextBox();
            this.lblJobCountry = new System.Windows.Forms.Label();
            this.txtBoxJobCountry = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelJob
            // 
            this.btnCancelJob.Location = new System.Drawing.Point(154, 213);
            this.btnCancelJob.Name = "btnCancelJob";
            this.btnCancelJob.Size = new System.Drawing.Size(75, 23);
            this.btnCancelJob.TabIndex = 0;
            this.btnCancelJob.Text = "Cancel";
            this.btnCancelJob.UseVisualStyleBackColor = true;
            this.btnCancelJob.Click += new System.EventHandler(this.btnCancelJob_Click);
            // 
            // btnSaveJob
            // 
            this.btnSaveJob.Location = new System.Drawing.Point(73, 213);
            this.btnSaveJob.Name = "btnSaveJob";
            this.btnSaveJob.Size = new System.Drawing.Size(75, 23);
            this.btnSaveJob.TabIndex = 1;
            this.btnSaveJob.Text = "Save";
            this.btnSaveJob.UseVisualStyleBackColor = true;
            this.btnSaveJob.Click += new System.EventHandler(this.btnSaveJob_Click);
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Location = new System.Drawing.Point(12, 16);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(50, 13);
            this.lblJobTitle.TabIndex = 2;
            this.lblJobTitle.Text = "Job Title:";
            // 
            // txtBoxJobTitle
            // 
            this.txtBoxJobTitle.AutoCompleteCustomSource.AddRange(new string[] {
            "Open",
            "Closed"});
            this.txtBoxJobTitle.Location = new System.Drawing.Point(73, 13);
            this.txtBoxJobTitle.Name = "txtBoxJobTitle";
            this.txtBoxJobTitle.Size = new System.Drawing.Size(156, 20);
            this.txtBoxJobTitle.TabIndex = 3;
            // 
            // lblJobStatus
            // 
            this.lblJobStatus.AutoSize = true;
            this.lblJobStatus.Location = new System.Drawing.Point(12, 126);
            this.lblJobStatus.Name = "lblJobStatus";
            this.lblJobStatus.Size = new System.Drawing.Size(40, 13);
            this.lblJobStatus.TabIndex = 4;
            this.lblJobStatus.Text = "Status:";
            // 
            // comboJobStatus
            // 
            this.comboJobStatus.AutoCompleteCustomSource.AddRange(new string[] {
            "Open",
            "Closed"});
            this.comboJobStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboJobStatus.FormattingEnabled = true;
            this.comboJobStatus.Items.AddRange(new object[] {
            "Open",
            "On Hold",
            "Closed"});
            this.comboJobStatus.Location = new System.Drawing.Point(73, 123);
            this.comboJobStatus.Name = "comboJobStatus";
            this.comboJobStatus.Size = new System.Drawing.Size(156, 21);
            this.comboJobStatus.TabIndex = 5;
            // 
            // lblJobCompany
            // 
            this.lblJobCompany.AutoSize = true;
            this.lblJobCompany.Location = new System.Drawing.Point(12, 42);
            this.lblJobCompany.Name = "lblJobCompany";
            this.lblJobCompany.Size = new System.Drawing.Size(54, 13);
            this.lblJobCompany.TabIndex = 6;
            this.lblJobCompany.Text = "Company:";
            // 
            // lblJobAdded
            // 
            this.lblJobAdded.AutoSize = true;
            this.lblJobAdded.Location = new System.Drawing.Point(12, 154);
            this.lblJobAdded.Name = "lblJobAdded";
            this.lblJobAdded.Size = new System.Drawing.Size(61, 13);
            this.lblJobAdded.TabIndex = 7;
            this.lblJobAdded.Text = "Job Added:";
            // 
            // txtBoxJobAdded
            // 
            this.txtBoxJobAdded.Location = new System.Drawing.Point(73, 151);
            this.txtBoxJobAdded.Name = "txtBoxJobAdded";
            this.txtBoxJobAdded.ReadOnly = true;
            this.txtBoxJobAdded.Size = new System.Drawing.Size(156, 20);
            this.txtBoxJobAdded.TabIndex = 8;
            this.txtBoxJobAdded.TextChanged += new System.EventHandler(this.txtBoxJobAdded_TextChanged);
            // 
            // lblJobCategory
            // 
            this.lblJobCategory.AutoSize = true;
            this.lblJobCategory.Location = new System.Drawing.Point(12, 180);
            this.lblJobCategory.Name = "lblJobCategory";
            this.lblJobCategory.Size = new System.Drawing.Size(52, 13);
            this.lblJobCategory.TabIndex = 9;
            this.lblJobCategory.Text = "Category:";
            // 
            // txtBoxJobCategory
            // 
            this.txtBoxJobCategory.Location = new System.Drawing.Point(73, 177);
            this.txtBoxJobCategory.Name = "txtBoxJobCategory";
            this.txtBoxJobCategory.Size = new System.Drawing.Size(156, 20);
            this.txtBoxJobCategory.TabIndex = 10;
            // 
            // txtBoxJobCompany
            // 
            this.txtBoxJobCompany.Location = new System.Drawing.Point(73, 39);
            this.txtBoxJobCompany.Name = "txtBoxJobCompany";
            this.txtBoxJobCompany.Size = new System.Drawing.Size(156, 20);
            this.txtBoxJobCompany.TabIndex = 11;
            // 
            // lblJobCity
            // 
            this.lblJobCity.AutoSize = true;
            this.lblJobCity.Location = new System.Drawing.Point(12, 69);
            this.lblJobCity.Name = "lblJobCity";
            this.lblJobCity.Size = new System.Drawing.Size(27, 13);
            this.lblJobCity.TabIndex = 12;
            this.lblJobCity.Text = "City:";
            // 
            // txtBoxJobCity
            // 
            this.txtBoxJobCity.Location = new System.Drawing.Point(73, 66);
            this.txtBoxJobCity.Name = "txtBoxJobCity";
            this.txtBoxJobCity.Size = new System.Drawing.Size(156, 20);
            this.txtBoxJobCity.TabIndex = 13;
            // 
            // lblJobCountry
            // 
            this.lblJobCountry.AutoSize = true;
            this.lblJobCountry.Location = new System.Drawing.Point(12, 95);
            this.lblJobCountry.Name = "lblJobCountry";
            this.lblJobCountry.Size = new System.Drawing.Size(46, 13);
            this.lblJobCountry.TabIndex = 14;
            this.lblJobCountry.Text = "Country:";
            // 
            // txtBoxJobCountry
            // 
            this.txtBoxJobCountry.AutoCompleteCustomSource.AddRange(new string[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "American Samoa",
            "Andorra",
            "Angola",
            "Anguilla",
            "Antarctica",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Aruba",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bermuda",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Bouvet Island",
            "Brazil",
            "British Indian Ocean Territory",
            "Brunei Darussalam",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cape Verde",
            "Cayman Islands",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Christmas Island",
            "Cocos (Keeling Islands)",
            "Colombia",
            "Comoros",
            "Congo",
            "Cook Islands",
            "Costa Rica",
            "Cote D\'Ivoire (Ivory Coast)",
            "Croatia (Hrvatska",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "East Timor",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Falkland Islands (Malvinas)",
            "Faroe Islands",
            "Fiji",
            "Finland",
            "France",
            "France, Metropolitan",
            "French Guiana",
            "French Polynesia",
            "French Southern Territories",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Gibraltar",
            "Greece",
            "Greenland",
            "Grenada",
            "Guadeloupe",
            "Guam",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Heard and McDonald Islands",
            "Honduras",
            "Hong Kong",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea (North)",
            "Korea (South)",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macau",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Martinique",
            "Mauritania",
            "Mauritius",
            "Mayotte",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montserrat",
            "Morocco",
            "Mozambique",
            "Myanmar",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "Netherlands Antilles",
            "New Caledonia",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Niue",
            "Norfolk Island",
            "Northern Mariana Islands",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Pitcairn",
            "Poland",
            "Portugal",
            "Puerto Rico",
            "Qatar",
            "Reunion",
            "Romania",
            "Russian Federation",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and The Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovak Republic",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "S. Georgia and S. Sandwich Isls.",
            "Spain",
            "Sri Lanka",
            "St. Helena",
            "St. Pierre and Miquelon",
            "Sudan",
            "Suriname",
            "Svalbard and Jan Mayen Islands",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Togo",
            "Tokelau",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Turks and Caicos Islands",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "US Minor Outlying Islands",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Vatican City State (Holy See)",
            "Venezuela",
            "Viet Nam",
            "Virgin Islands (British)",
            "Virgin Islands (US)",
            "Wallis and Futuna Islands",
            "Western Sahara",
            "Yemen",
            "Yugoslavia",
            "Zaire",
            "Zambia",
            "Zimbabwe"});
            this.txtBoxJobCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBoxJobCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBoxJobCountry.Location = new System.Drawing.Point(73, 92);
            this.txtBoxJobCountry.Name = "txtBoxJobCountry";
            this.txtBoxJobCountry.Size = new System.Drawing.Size(156, 20);
            this.txtBoxJobCountry.TabIndex = 15;
            // 
            // AddJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 248);
            this.Controls.Add(this.txtBoxJobCountry);
            this.Controls.Add(this.lblJobCountry);
            this.Controls.Add(this.txtBoxJobCity);
            this.Controls.Add(this.lblJobCity);
            this.Controls.Add(this.txtBoxJobCompany);
            this.Controls.Add(this.txtBoxJobCategory);
            this.Controls.Add(this.lblJobCategory);
            this.Controls.Add(this.txtBoxJobAdded);
            this.Controls.Add(this.lblJobAdded);
            this.Controls.Add(this.lblJobCompany);
            this.Controls.Add(this.comboJobStatus);
            this.Controls.Add(this.lblJobStatus);
            this.Controls.Add(this.txtBoxJobTitle);
            this.Controls.Add(this.lblJobTitle);
            this.Controls.Add(this.btnSaveJob);
            this.Controls.Add(this.btnCancelJob);
            this.MaximizeBox = false;
            this.Name = "AddJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Job";
            this.Load += new System.EventHandler(this.AddJob_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelJob;
        private System.Windows.Forms.Button btnSaveJob;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.TextBox txtBoxJobTitle;
        private System.Windows.Forms.Label lblJobStatus;
        private System.Windows.Forms.ComboBox comboJobStatus;
        private System.Windows.Forms.Label lblJobCompany;
        private System.Windows.Forms.Label lblJobAdded;
        private System.Windows.Forms.TextBox txtBoxJobAdded;
        private System.Windows.Forms.Label lblJobCategory;
        private System.Windows.Forms.TextBox txtBoxJobCategory;
        private System.Windows.Forms.TextBox txtBoxJobCompany;
        private System.Windows.Forms.Label lblJobCity;
        private System.Windows.Forms.TextBox txtBoxJobCity;
        private System.Windows.Forms.Label lblJobCountry;
        private System.Windows.Forms.TextBox txtBoxJobCountry;
    }
}