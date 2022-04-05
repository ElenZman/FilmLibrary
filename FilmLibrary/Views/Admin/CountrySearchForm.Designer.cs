
namespace FilmLibrary.Forms
{
    partial class CountrySearchForm
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
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.lbSearchOption = new System.Windows.Forms.Label();
            this.textBoxEnterValue = new System.Windows.Forms.TextBox();
            this.btnFinfId = new System.Windows.Forms.Button();
            this.lbEnterValue = new System.Windows.Forms.Label();
            this.comboBoxSearchOption = new System.Windows.Forms.ComboBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.lbTableName = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.btShawAll = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.Label();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.lbSearchOption);
            this.gbSearch.Controls.Add(this.textBoxEnterValue);
            this.gbSearch.Controls.Add(this.btnFinfId);
            this.gbSearch.Controls.Add(this.lbEnterValue);
            this.gbSearch.Controls.Add(this.comboBoxSearchOption);
            this.gbSearch.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbSearch.Location = new System.Drawing.Point(13, 118);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(429, 164);
            this.gbSearch.TabIndex = 38;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search";
            // 
            // lbSearchOption
            // 
            this.lbSearchOption.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearchOption.Location = new System.Drawing.Point(6, 30);
            this.lbSearchOption.Name = "lbSearchOption";
            this.lbSearchOption.Size = new System.Drawing.Size(219, 26);
            this.lbSearchOption.TabIndex = 18;
            this.lbSearchOption.Text = "Search by:";
            // 
            // textBoxEnterValue
            // 
            this.textBoxEnterValue.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnterValue.Location = new System.Drawing.Point(225, 55);
            this.textBoxEnterValue.Multiline = true;
            this.textBoxEnterValue.Name = "textBoxEnterValue";
            this.textBoxEnterValue.Size = new System.Drawing.Size(198, 31);
            this.textBoxEnterValue.TabIndex = 23;
            // 
            // btnFinfId
            // 
            this.btnFinfId.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFinfId.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinfId.Location = new System.Drawing.Point(225, 92);
            this.btnFinfId.Name = "btnFinfId";
            this.btnFinfId.Size = new System.Drawing.Size(198, 38);
            this.btnFinfId.TabIndex = 25;
            this.btnFinfId.Text = "Find";
            this.btnFinfId.UseVisualStyleBackColor = false;
            this.btnFinfId.Click += new System.EventHandler(this.btnFinfId_Click);
            // 
            // lbEnterValue
            // 
            this.lbEnterValue.AutoSize = true;
            this.lbEnterValue.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnterValue.Location = new System.Drawing.Point(6, 64);
            this.lbEnterValue.Name = "lbEnterValue";
            this.lbEnterValue.Size = new System.Drawing.Size(132, 22);
            this.lbEnterValue.TabIndex = 29;
            this.lbEnterValue.Text = "Enter Value/ID:";
            // 
            // comboBoxSearchOption
            // 
            this.comboBoxSearchOption.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchOption.FormattingEnabled = true;
            this.comboBoxSearchOption.Location = new System.Drawing.Point(227, 19);
            this.comboBoxSearchOption.Name = "comboBoxSearchOption";
            this.comboBoxSearchOption.Size = new System.Drawing.Size(196, 30);
            this.comboBoxSearchOption.TabIndex = 30;
            // 
            // grid
            // 
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(16, 288);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 51;
            this.grid.RowTemplate.Height = 24;
            this.grid.Size = new System.Drawing.Size(429, 235);
            this.grid.TabIndex = 39;
            // 
            // lbTableName
            // 
            this.lbTableName.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTableName.Location = new System.Drawing.Point(9, 20);
            this.lbTableName.Name = "lbTableName";
            this.lbTableName.Size = new System.Drawing.Size(63, 23);
            this.lbTableName.TabIndex = 40;
            this.lbTableName.Text = "Table:";
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(64, 20);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(100, 23);
            this.lbName.TabIndex = 41;
            // 
            // btShawAll
            // 
            this.btShawAll.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btShawAll.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShawAll.Location = new System.Drawing.Point(243, 20);
            this.btShawAll.Name = "btShawAll";
            this.btShawAll.Size = new System.Drawing.Size(199, 38);
            this.btShawAll.TabIndex = 42;
            this.btShawAll.Text = "ShowAll";
            this.btShawAll.UseVisualStyleBackColor = false;
            this.btShawAll.Click += new System.EventHandler(this.btShawAll_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInfo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbInfo.Location = new System.Drawing.Point(12, 73);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(426, 29);
            this.lbInfo.TabIndex = 49;
            // 
            // CountrySearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 538);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btShawAll);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbTableName);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.gbSearch);
            this.Name = "CountrySearchForm";
            this.Text = "CountrySearchForm";
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Label lbSearchOption;
        private System.Windows.Forms.TextBox textBoxEnterValue;
        private System.Windows.Forms.Button btnFinfId;
        private System.Windows.Forms.Label lbEnterValue;
        private System.Windows.Forms.ComboBox comboBoxSearchOption;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label lbTableName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btShawAll;
        private System.Windows.Forms.Label lbInfo;
    }
}