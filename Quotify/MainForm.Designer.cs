namespace Quotify
{
    partial class MainForm
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
            this.author = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.setClipboard = new System.Windows.Forms.Button();
            this.grabClipboard = new System.Windows.Forms.Button();
            this.nowButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // author
            // 
            this.author.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.author.Location = new System.Drawing.Point(53, 19);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(301, 20);
            this.author.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Author:";
            // 
            // date
            // 
            this.date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.date.CustomFormat = "dddd MMM d, yyyy h:mm:ss tt";
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(53, 45);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(242, 20);
            this.date.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date:";
            // 
            // message
            // 
            this.message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.message.Location = new System.Drawing.Point(9, 71);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.message.Size = new System.Drawing.Size(345, 206);
            this.message.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.nowButton);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.message);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.author);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 314);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quote Information";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.setClipboard, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grabClipboard, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 283);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(345, 23);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // setClipboard
            // 
            this.setClipboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.setClipboard.Location = new System.Drawing.Point(141, 0);
            this.setClipboard.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.setClipboard.Name = "setClipboard";
            this.setClipboard.Size = new System.Drawing.Size(204, 23);
            this.setClipboard.TabIndex = 6;
            this.setClipboard.Text = "Copy to Clipboard";
            this.setClipboard.UseVisualStyleBackColor = true;
            this.setClipboard.Click += new System.EventHandler(this.setClipboard_Click);
            // 
            // grabClipboard
            // 
            this.grabClipboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.grabClipboard.Location = new System.Drawing.Point(0, 0);
            this.grabClipboard.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.grabClipboard.Name = "grabClipboard";
            this.grabClipboard.Size = new System.Drawing.Size(135, 23);
            this.grabClipboard.TabIndex = 5;
            this.grabClipboard.Text = "Grab from Clipboard";
            this.grabClipboard.UseVisualStyleBackColor = true;
            this.grabClipboard.Click += new System.EventHandler(this.grabClipboard_Click);
            // 
            // nowButton
            // 
            this.nowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nowButton.Location = new System.Drawing.Point(301, 45);
            this.nowButton.Name = "nowButton";
            this.nowButton.Size = new System.Drawing.Size(53, 20);
            this.nowButton.TabIndex = 7;
            this.nowButton.Text = "Now";
            this.nowButton.UseVisualStyleBackColor = true;
            this.nowButton.Click += new System.EventHandler(this.nowButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 336);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Skype Quote Editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button grabClipboard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button setClipboard;
        private System.Windows.Forms.Button nowButton;
    }
}

