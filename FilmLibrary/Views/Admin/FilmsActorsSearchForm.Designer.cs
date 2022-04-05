
namespace FilmLibrary.Forms
{
    partial class FilmsActorsSearchForm
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
            this.btShawAll = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbTableName = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.lbSearchOption = new System.Windows.Forms.Label();
            this.textBoxEnterValue = new System.Windows.Forms.TextBox();
            this.btnFinfId = new System.Windows.Forms.Button();
            this.lbEnterValue = new System.Windows.Forms.Label();
            this.comboBoxSearchOption = new System.Windows.Forms.ComboBox();
            this.lbInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btShawAll
            // 
            this.btShawAll.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btShawAll.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShawAll.Location = new System.Drawing.Point(237, 9);
            this.btShawAll.Name = "btShawAll";
            this.btShawAll.Size = new System.Drawing.Size(186, 38);
            this.btShawAll.TabIndex = 57;
            this.btShawAll.Text = "ShowAll";
            this.btShawAll.UseVisualStyleBackColor = false;
            this.btShawAll.Click += new System.EventHandler(this.btShawAll_Click);
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(71, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(160, 23);
            this.lbName.TabIndex = 56;
            // 
            // lbTableName
            // 
            this.lbTableName.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTableName.Location = new System.Drawing.Point(3, 9);
            this.lbTableName.Name = "lbTableName";
            this.lbTableName.Size = new System.Drawing.Size(62, 23);
            this.lbTableName.TabIndex = 55;
            this.lbTableName.Text = "Table:";
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(7, 272);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 51;
            this.grid.RowTemplate.Height = 24;
            this.grid.Size = new System.Drawing.Size(429, 250);
            this.grid.TabIndex = 54;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.lbSearchOption);
            this.gbSearch.Controls.Add(this.textBoxEnterValue);
            this.gbSearch.Controls.Add(this.btnFinfId);
            this.gbSearch.Controls.Add(this.lbEnterValue);
            this.gbSearch.Controls.Add(this.comboBoxSearchOption);
            this.gbSearch.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbSearch.Location = new System.Drawing.Point(6, 98);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(429, 168);
            this.gbSearch.TabIndex = 53;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search";
            // 
            // lbSearchOption
            // 
            this.lbSearchOption.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearchOption.Location = new System.Drawing.Point(6, 35);
            this.lbSearchOption.Name = "lbSearchOption";
            this.lbSearchOption.Size = new System.Drawing.Size(188, 30);
            this.lbSearchOption.TabIndex = 18;
            this.lbSearchOption.Text = "Search by:";
            // 
            // textBoxEnterValue
            // 
            this.textBoxEnterValue.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnterValue.Location = new System.Drawing.Point(231, 61);
            this.textBoxEnterValue.Multiline = true;
            this.textBoxEnterValue.Name = "textBoxEnterValue";
            this.textBoxEnterValue.Size = new System.Drawing.Size(186, 31);
            this.textBoxEnterValue.TabIndex = 23;
            // 
            // btnFinfId
            // 
            this.btnFinfId.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFinfId.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinfId.Location = new System.Drawing.Point(231, 98);
            this.btnFinfId.Name = "btnFinfId";
            this.btnFinfId.Size = new System.Drawing.Size(186, 38);
            this.btnFinfId.TabIndex = 25;
            this.btnFinfId.Text = "Find";
            this.btnFinfId.UseVisualStyleBackColor = false;
            this.btnFinfId.Click += new System.EventHandler(this.btnFinfId_Click);
            // 
            // lbEnterValue
            // 
            this.lbEnterValue.AutoSize = true;
            this.lbEnterValue.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnterValue.Location = new System.Drawing.Point(6, 65);
            this.lbEnterValue.Name = "lbEnterValue";
            this.lbEnterValue.Size = new System.Drawing.Size(78, 22);
            this.lbEnterValue.TabIndex = 29;
            this.lbEnterValue.Text = "Enter ID:";
            // 
            // comboBoxSearchOption
            // 
            this.comboBoxSearchOption.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchOption.FormattingEnabled = true;
            this.comboBoxSearchOption.Location = new System.Drawing.Point(231, 25);
            this.comboBoxSearchOption.Name = "comboBoxSearchOption";
            this.comboBoxSearchOption.Size = new System.Drawing.Size(186, 30);
            this.comboBoxSearchOption.TabIndex = 30;
            // 
            // lbInfo
            // 
            this.lbInfo.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInfo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbInfo.Location = new System.Drawing.Point(9, 66);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(426, 29);
            this.lbInfo.TabIndex = 58;
            // 
            // FilmsActorsSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 534);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btShawAll);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbTableName);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.gbSearch);
            this.Name = "FilmsActorsSearchForm";
            this.Text = "FilmsActorsSearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btShawAll;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbTableName;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Label lbSearchOption;
        private System.Windows.Forms.TextBox textBoxEnterValue;
        private System.Windows.Forms.Button btnFinfId;
        private System.Windows.Forms.Label lbEnterValue;
        private System.Windows.Forms.ComboBox comboBoxSearchOption;
        private System.Windows.Forms.Label lbInfo;
    }
}