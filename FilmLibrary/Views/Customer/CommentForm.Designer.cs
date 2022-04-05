
namespace FilmLibrary.Views
{
    partial class CommentForm
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
            this.lbTypeYourComment = new System.Windows.Forms.Label();
            this.tBoxComment = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTypeYourComment
            // 
            this.lbTypeYourComment.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTypeYourComment.Location = new System.Drawing.Point(12, 9);
            this.lbTypeYourComment.Name = "lbTypeYourComment";
            this.lbTypeYourComment.Size = new System.Drawing.Size(198, 23);
            this.lbTypeYourComment.TabIndex = 0;
            this.lbTypeYourComment.Text = "Type your comment here:";
            // 
            // tBoxComment
            // 
            this.tBoxComment.Location = new System.Drawing.Point(16, 50);
            this.tBoxComment.Multiline = true;
            this.tBoxComment.Name = "tBoxComment";
            this.tBoxComment.Size = new System.Drawing.Size(332, 251);
            this.tBoxComment.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSend.Location = new System.Drawing.Point(103, 318);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(162, 36);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // CommentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(360, 366);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tBoxComment);
            this.Controls.Add(this.lbTypeYourComment);
            this.Name = "CommentForm";
            this.Text = "CommentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTypeYourComment;
        private System.Windows.Forms.TextBox tBoxComment;
        private System.Windows.Forms.Button btnSend;
    }
}