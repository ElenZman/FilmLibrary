
namespace FilmLibrary.Forms
{
    partial class SearchOptionForm
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
            this.name = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.rbComments = new System.Windows.Forms.RadioButton();
            this.rbFilms_Actors = new System.Windows.Forms.RadioButton();
            this.rbAccess = new System.Windows.Forms.RadioButton();
            this.rbUsers = new System.Windows.Forms.RadioButton();
            this.rbGenres = new System.Windows.Forms.RadioButton();
            this.rbFilms = new System.Windows.Forms.RadioButton();
            this.rbActors = new System.Windows.Forms.RadioButton();
            this.rbCoutnries = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.rbDirectors = new System.Windows.Forms.RadioButton();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(78, 44);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(0, 22);
            this.name.TabIndex = 32;
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.Location = new System.Drawing.Point(10, 44);
            this.lbInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(0, 19);
            this.lbInfo.TabIndex = 34;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(82, 15);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 22);
            this.lbName.TabIndex = 35;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.rbDirectors);
            this.gbSearch.Controls.Add(this.rbComments);
            this.gbSearch.Controls.Add(this.rbFilms_Actors);
            this.gbSearch.Controls.Add(this.rbAccess);
            this.gbSearch.Controls.Add(this.rbUsers);
            this.gbSearch.Controls.Add(this.rbGenres);
            this.gbSearch.Controls.Add(this.rbFilms);
            this.gbSearch.Controls.Add(this.rbActors);
            this.gbSearch.Controls.Add(this.rbCoutnries);
            this.gbSearch.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbSearch.Location = new System.Drawing.Point(15, 15);
            this.gbSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSearch.Size = new System.Drawing.Size(353, 177);
            this.gbSearch.TabIndex = 39;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Choose Table";
            // 
            // rbComments
            // 
            this.rbComments.AutoSize = true;
            this.rbComments.Location = new System.Drawing.Point(162, 102);
            this.rbComments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbComments.Name = "rbComments";
            this.rbComments.Size = new System.Drawing.Size(115, 26);
            this.rbComments.TabIndex = 7;
            this.rbComments.TabStop = true;
            this.rbComments.Text = "Comments";
            this.rbComments.UseVisualStyleBackColor = true;
            // 
            // rbFilms_Actors
            // 
            this.rbFilms_Actors.AutoSize = true;
            this.rbFilms_Actors.Location = new System.Drawing.Point(162, 76);
            this.rbFilms_Actors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbFilms_Actors.Name = "rbFilms_Actors";
            this.rbFilms_Actors.Size = new System.Drawing.Size(135, 26);
            this.rbFilms_Actors.TabIndex = 6;
            this.rbFilms_Actors.Text = "Films_Actors";
            this.rbFilms_Actors.UseVisualStyleBackColor = true;
            // 
            // rbAccess
            // 
            this.rbAccess.AutoSize = true;
            this.rbAccess.Location = new System.Drawing.Point(162, 50);
            this.rbAccess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbAccess.Name = "rbAccess";
            this.rbAccess.Size = new System.Drawing.Size(85, 26);
            this.rbAccess.TabIndex = 5;
            this.rbAccess.TabStop = true;
            this.rbAccess.Text = "Access";
            this.rbAccess.UseVisualStyleBackColor = true;
            // 
            // rbUsers
            // 
            this.rbUsers.AutoSize = true;
            this.rbUsers.Location = new System.Drawing.Point(162, 20);
            this.rbUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbUsers.Name = "rbUsers";
            this.rbUsers.Size = new System.Drawing.Size(76, 26);
            this.rbUsers.TabIndex = 4;
            this.rbUsers.TabStop = true;
            this.rbUsers.Text = "Users";
            this.rbUsers.UseVisualStyleBackColor = true;
            // 
            // rbGenres
            // 
            this.rbGenres.AutoSize = true;
            this.rbGenres.Location = new System.Drawing.Point(4, 98);
            this.rbGenres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbGenres.Name = "rbGenres";
            this.rbGenres.Size = new System.Drawing.Size(88, 26);
            this.rbGenres.TabIndex = 3;
            this.rbGenres.TabStop = true;
            this.rbGenres.Text = "Genres";
            this.rbGenres.UseVisualStyleBackColor = true;
            // 
            // rbFilms
            // 
            this.rbFilms.AutoSize = true;
            this.rbFilms.Location = new System.Drawing.Point(4, 72);
            this.rbFilms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbFilms.Name = "rbFilms";
            this.rbFilms.Size = new System.Drawing.Size(75, 26);
            this.rbFilms.TabIndex = 2;
            this.rbFilms.TabStop = true;
            this.rbFilms.Text = "Films";
            this.rbFilms.UseVisualStyleBackColor = true;
            // 
            // rbActors
            // 
            this.rbActors.AutoSize = true;
            this.rbActors.Location = new System.Drawing.Point(4, 46);
            this.rbActors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbActors.Name = "rbActors";
            this.rbActors.Size = new System.Drawing.Size(82, 26);
            this.rbActors.TabIndex = 1;
            this.rbActors.TabStop = true;
            this.rbActors.Text = "Actors";
            this.rbActors.UseVisualStyleBackColor = true;
            // 
            // rbCoutnries
            // 
            this.rbCoutnries.AutoSize = true;
            this.rbCoutnries.Location = new System.Drawing.Point(4, 20);
            this.rbCoutnries.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbCoutnries.Name = "rbCoutnries";
            this.rbCoutnries.Size = new System.Drawing.Size(108, 26);
            this.rbCoutnries.TabIndex = 0;
            this.rbCoutnries.TabStop = true;
            this.rbCoutnries.Text = "Coutnries";
            this.rbCoutnries.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.Location = new System.Drawing.Point(118, 221);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(154, 38);
            this.btnOk.TabIndex = 40;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbDirectors
            // 
            this.rbDirectors.AutoSize = true;
            this.rbDirectors.Location = new System.Drawing.Point(4, 128);
            this.rbDirectors.Margin = new System.Windows.Forms.Padding(2);
            this.rbDirectors.Name = "rbDirectors";
            this.rbDirectors.Size = new System.Drawing.Size(105, 26);
            this.rbDirectors.TabIndex = 8;
            this.rbDirectors.TabStop = true;
            this.rbDirectors.Text = "Directors";
            this.rbDirectors.UseVisualStyleBackColor = true;
            // 
            // SearchOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 297);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.name);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SearchOptionForm";
            this.Text = "Search form";
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.RadioButton rbComments;
        private System.Windows.Forms.RadioButton rbFilms_Actors;
        private System.Windows.Forms.RadioButton rbAccess;
        private System.Windows.Forms.RadioButton rbUsers;
        private System.Windows.Forms.RadioButton rbGenres;
        private System.Windows.Forms.RadioButton rbFilms;
        private System.Windows.Forms.RadioButton rbActors;
        private System.Windows.Forms.RadioButton rbCoutnries;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.RadioButton rbDirectors;
    }
}