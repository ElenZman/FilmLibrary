
namespace FilmLibrary.Forms
{
    partial class UserWelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserWelcomeForm));
            this.lbWelcome = new System.Windows.Forms.Label();
            this.lbWelocmeText = new System.Windows.Forms.Label();
            this.cBoxActor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxRate = new System.Windows.Forms.ComboBox();
            this.cBoxGenre = new System.Windows.Forms.ComboBox();
            this.lbSearchOptions = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cBoxDirectors = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFindFilmByActor = new System.Windows.Forms.Button();
            this.btnOtherSearchOptions = new System.Windows.Forms.Button();
            this.tbFilmName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnFindFilmByName = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWelcome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbWelcome.Location = new System.Drawing.Point(43, 46);
            this.lbWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(39, 24);
            this.lbWelcome.TabIndex = 2;
            this.lbWelcome.Text = "Hi,";
            this.lbWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbWelocmeText
            // 
            this.lbWelocmeText.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWelocmeText.Location = new System.Drawing.Point(38, 82);
            this.lbWelocmeText.Name = "lbWelocmeText";
            this.lbWelocmeText.Size = new System.Drawing.Size(473, 51);
            this.lbWelocmeText.TabIndex = 4;
            this.lbWelocmeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBoxActor
            // 
            this.cBoxActor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxActor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cBoxActor.BackColor = System.Drawing.SystemColors.Menu;
            this.cBoxActor.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBoxActor.FormattingEnabled = true;
            this.cBoxActor.ItemHeight = 24;
            this.cBoxActor.Items.AddRange(new object[] {
            "All"});
            this.cBoxActor.Location = new System.Drawing.Point(141, 234);
            this.cBoxActor.Name = "cBoxActor";
            this.cBoxActor.Size = new System.Drawing.Size(250, 32);
            this.cBoxActor.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(38, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Other search options:";
            // 
            // cBoxRate
            // 
            this.cBoxRate.BackColor = System.Drawing.SystemColors.Menu;
            this.cBoxRate.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBoxRate.FormattingEnabled = true;
            this.cBoxRate.ItemHeight = 24;
            this.cBoxRate.Items.AddRange(new object[] {
            "All",
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.cBoxRate.Location = new System.Drawing.Point(141, 387);
            this.cBoxRate.Name = "cBoxRate";
            this.cBoxRate.Size = new System.Drawing.Size(250, 32);
            this.cBoxRate.TabIndex = 16;
            // 
            // cBoxGenre
            // 
            this.cBoxGenre.BackColor = System.Drawing.SystemColors.Menu;
            this.cBoxGenre.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBoxGenre.FormattingEnabled = true;
            this.cBoxGenre.ItemHeight = 24;
            this.cBoxGenre.Items.AddRange(new object[] {
            "All"});
            this.cBoxGenre.Location = new System.Drawing.Point(141, 340);
            this.cBoxGenre.Name = "cBoxGenre";
            this.cBoxGenre.Size = new System.Drawing.Size(250, 32);
            this.cBoxGenre.TabIndex = 15;
            // 
            // lbSearchOptions
            // 
            this.lbSearchOptions.AutoSize = true;
            this.lbSearchOptions.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSearchOptions.Location = new System.Drawing.Point(41, 346);
            this.lbSearchOptions.Name = "lbSearchOptions";
            this.lbSearchOptions.Size = new System.Drawing.Size(72, 24);
            this.lbSearchOptions.TabIndex = 17;
            this.lbSearchOptions.Text = "Genre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(41, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Film:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(43, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Actor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(43, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Rate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(43, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "Director:";
            // 
            // cBoxDirectors
            // 
            this.cBoxDirectors.BackColor = System.Drawing.SystemColors.Menu;
            this.cBoxDirectors.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBoxDirectors.FormattingEnabled = true;
            this.cBoxDirectors.ItemHeight = 24;
            this.cBoxDirectors.Items.AddRange(new object[] {
            "All"});
            this.cBoxDirectors.Location = new System.Drawing.Point(141, 450);
            this.cBoxDirectors.Name = "cBoxDirectors";
            this.cBoxDirectors.Size = new System.Drawing.Size(250, 32);
            this.cBoxDirectors.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(407, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 24);
            this.label7.TabIndex = 32;
            this.label7.Text = "and/or";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(407, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 24);
            this.label8.TabIndex = 33;
            this.label8.Text = "and/or";
            // 
            // btnFindFilmByActor
            // 
            this.btnFindFilmByActor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFindFilmByActor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindFilmByActor.BackgroundImage")));
            this.btnFindFilmByActor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFindFilmByActor.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFindFilmByActor.Location = new System.Drawing.Point(411, 233);
            this.btnFindFilmByActor.Name = "btnFindFilmByActor";
            this.btnFindFilmByActor.Size = new System.Drawing.Size(65, 32);
            this.btnFindFilmByActor.TabIndex = 34;
            this.btnFindFilmByActor.UseVisualStyleBackColor = false;
            this.btnFindFilmByActor.Click += new System.EventHandler(this.btnFindFilmByActor_Click);
            // 
            // btnOtherSearchOptions
            // 
            this.btnOtherSearchOptions.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOtherSearchOptions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOtherSearchOptions.BackgroundImage")));
            this.btnOtherSearchOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOtherSearchOptions.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOtherSearchOptions.Location = new System.Drawing.Point(411, 450);
            this.btnOtherSearchOptions.Name = "btnOtherSearchOptions";
            this.btnOtherSearchOptions.Size = new System.Drawing.Size(65, 32);
            this.btnOtherSearchOptions.TabIndex = 35;
            this.btnOtherSearchOptions.UseVisualStyleBackColor = false;
            this.btnOtherSearchOptions.Click += new System.EventHandler(this.btnOtherSearchOptions_Click);
            // 
            // tbFilmName
            // 
            this.tbFilmName.BackColor = System.Drawing.SystemColors.Menu;
            this.tbFilmName.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFilmName.Location = new System.Drawing.Point(141, 170);
            this.tbFilmName.Multiline = true;
            this.tbFilmName.Name = "tbFilmName";
            this.tbFilmName.Size = new System.Drawing.Size(250, 31);
            this.tbFilmName.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(137, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 22);
            this.label9.TabIndex = 37;
            this.label9.Text = "Start typing film name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(137, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 22);
            this.label10.TabIndex = 38;
            this.label10.Text = "Start typing actor\'s name";
            // 
            // btnFindFilmByName
            // 
            this.btnFindFilmByName.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFindFilmByName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindFilmByName.BackgroundImage")));
            this.btnFindFilmByName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFindFilmByName.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFindFilmByName.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFindFilmByName.Location = new System.Drawing.Point(411, 170);
            this.btnFindFilmByName.Name = "btnFindFilmByName";
            this.btnFindFilmByName.Size = new System.Drawing.Size(65, 32);
            this.btnFindFilmByName.TabIndex = 14;
            this.btnFindFilmByName.UseVisualStyleBackColor = false;
            this.btnFindFilmByName.Click += new System.EventHandler(this.btnFindFilmByName_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(137, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 22);
            this.label6.TabIndex = 39;
            this.label6.Text = "Start typing genre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(137, 425);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(221, 22);
            this.label11.TabIndex = 40;
            this.label11.Text = "Start typing director\'s name";
            // 
            // UserWelcomeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(532, 560);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbFilmName);
            this.Controls.Add(this.btnOtherSearchOptions);
            this.Controls.Add(this.btnFindFilmByActor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cBoxDirectors);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBoxActor);
            this.Controls.Add(this.lbSearchOptions);
            this.Controls.Add(this.cBoxRate);
            this.Controls.Add(this.cBoxGenre);
            this.Controls.Add(this.btnFindFilmByName);
            this.Controls.Add(this.lbWelocmeText);
            this.Controls.Add(this.lbWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserWelcomeForm";
            this.Text = "Welcome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserWelcomeForm_FormClosed);
            this.Load += new System.EventHandler(this.UserWelcomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Label lbWelocmeText;
        private System.Windows.Forms.ComboBox cBoxActor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxRate;
        private System.Windows.Forms.ComboBox cBoxGenre;
        private System.Windows.Forms.Label lbSearchOptions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBoxDirectors;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFindFilmByActor;
        private System.Windows.Forms.Button btnOtherSearchOptions;
        private System.Windows.Forms.TextBox tbFilmName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnFindFilmByName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
    }
}