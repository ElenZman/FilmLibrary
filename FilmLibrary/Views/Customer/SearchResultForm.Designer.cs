
namespace FilmLibrary.Views
{
    partial class SearchResultForm
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
            this.viewSearchResult = new System.Windows.Forms.ListView();
            this.lbSearchResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // viewSearchResult
            // 
            this.viewSearchResult.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewSearchResult.FullRowSelect = true;
            this.viewSearchResult.HideSelection = false;
            this.viewSearchResult.Location = new System.Drawing.Point(19, 71);
            this.viewSearchResult.Margin = new System.Windows.Forms.Padding(6);
            this.viewSearchResult.MultiSelect = false;
            this.viewSearchResult.Name = "viewSearchResult";
            this.viewSearchResult.Size = new System.Drawing.Size(958, 273);
            this.viewSearchResult.TabIndex = 0;
            this.viewSearchResult.UseCompatibleStateImageBehavior = false;
            this.viewSearchResult.View = System.Windows.Forms.View.Details;
            this.viewSearchResult.SelectedIndexChanged += new System.EventHandler(this.viewSearchResult_SelectedIndexChanged);
            // 
            // lbSearchResults
            // 
            this.lbSearchResults.AutoSize = true;
            this.lbSearchResults.Location = new System.Drawing.Point(15, 19);
            this.lbSearchResults.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbSearchResults.Name = "lbSearchResults";
            this.lbSearchResults.Size = new System.Drawing.Size(125, 21);
            this.lbSearchResults.TabIndex = 1;
            this.lbSearchResults.Text = "Search Results: ";
            // 
            // SearchResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 360);
            this.Controls.Add(this.lbSearchResults);
            this.Controls.Add(this.viewSearchResult);
            this.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SearchResultForm";
            this.Text = "UserSearchResultForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserSearchResultForm_FormClosed);
            this.Load += new System.EventHandler(this.UserSearchResultForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView viewSearchResult;
        private System.Windows.Forms.Label lbSearchResults;
    }
}