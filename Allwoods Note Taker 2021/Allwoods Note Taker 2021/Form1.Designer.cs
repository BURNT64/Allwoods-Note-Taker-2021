namespace Allwoods_Note_Taker_2021
{
    partial class Form1
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
            this.Title = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttNew = new System.Windows.Forms.Button();
            this.bttSave = new System.Windows.Forms.Button();
            this.bttRead = new System.Windows.Forms.Button();
            this.bttDelete = new System.Windows.Forms.Button();
            this.bttExit = new System.Windows.Forms.Button();
            this.txtMaintitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(259, 124);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(51, 23);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message.Location = new System.Drawing.Point(219, 158);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(95, 23);
            this.Message.TabIndex = 1;
            this.Message.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(320, 158);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(279, 208);
            this.txtMessage.TabIndex = 2;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(320, 124);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(279, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(637, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(169, 242);
            this.dataGridView1.TabIndex = 4;
            // 
            // bttNew
            // 
            this.bttNew.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNew.Location = new System.Drawing.Point(320, 384);
            this.bttNew.Name = "bttNew";
            this.bttNew.Size = new System.Drawing.Size(75, 23);
            this.bttNew.TabIndex = 5;
            this.bttNew.Text = "New";
            this.bttNew.UseVisualStyleBackColor = true;
            this.bttNew.Click += new System.EventHandler(this.bttNew_Click);
            // 
            // bttSave
            // 
            this.bttSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSave.Location = new System.Drawing.Point(411, 384);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(75, 23);
            this.bttSave.TabIndex = 6;
            this.bttSave.Text = "Save";
            this.bttSave.UseVisualStyleBackColor = true;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // bttRead
            // 
            this.bttRead.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttRead.Location = new System.Drawing.Point(637, 384);
            this.bttRead.Name = "bttRead";
            this.bttRead.Size = new System.Drawing.Size(75, 23);
            this.bttRead.TabIndex = 7;
            this.bttRead.Text = "Read";
            this.bttRead.UseVisualStyleBackColor = true;
            this.bttRead.Click += new System.EventHandler(this.bttRead_Click);
            // 
            // bttDelete
            // 
            this.bttDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDelete.Location = new System.Drawing.Point(731, 384);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(75, 23);
            this.bttDelete.TabIndex = 8;
            this.bttDelete.Text = "Delete";
            this.bttDelete.UseVisualStyleBackColor = true;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // bttExit
            // 
            this.bttExit.BackColor = System.Drawing.Color.Red;
            this.bttExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttExit.Location = new System.Drawing.Point(679, 425);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(85, 25);
            this.bttExit.TabIndex = 9;
            this.bttExit.Text = "Exit";
            this.bttExit.UseVisualStyleBackColor = false;
            this.bttExit.Click += new System.EventHandler(this.bttExit_Click);
            // 
            // txtMaintitle
            // 
            this.txtMaintitle.AutoSize = true;
            this.txtMaintitle.Font = new System.Drawing.Font("Arial Narrow", 48F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaintitle.Location = new System.Drawing.Point(82, 9);
            this.txtMaintitle.Name = "txtMaintitle";
            this.txtMaintitle.Size = new System.Drawing.Size(682, 75);
            this.txtMaintitle.TabIndex = 10;
            this.txtMaintitle.Text = "Allwoods Note Taker 2021";
            this.txtMaintitle.Click += new System.EventHandler(this.txtMaintitle_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(829, 475);
            this.Controls.Add(this.txtMaintitle);
            this.Controls.Add(this.bttExit);
            this.Controls.Add(this.bttDelete);
            this.Controls.Add(this.bttRead);
            this.Controls.Add(this.bttSave);
            this.Controls.Add(this.bttNew);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttNew;
        private System.Windows.Forms.Button bttSave;
        private System.Windows.Forms.Button bttRead;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.Button bttExit;
        private System.Windows.Forms.Label txtMaintitle;
    }
}

