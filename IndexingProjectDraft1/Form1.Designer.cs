namespace IndexingProjectDraft1
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
            this.components = new System.ComponentModel.Container();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.listViewfiles = new System.Windows.Forms.ListView();
            this.listboxindex = new System.Windows.Forms.ListBox();
            this.richTextBoxfileitems = new System.Windows.Forms.RichTextBox();
            this.txtboxpath = new System.Windows.Forms.TextBox();
            this.txtboxword = new System.Windows.Forms.TextBox();
            this.lblpath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.htmltxtbox = new System.Windows.Forms.TextBox();
            this.htmlbtn = new System.Windows.Forms.Button();
            this.reportbtn = new System.Windows.Forms.Button();
            this.reportrichtxtbox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(242, 124);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(75, 23);
            this.btnbrowse.TabIndex = 0;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(12, 254);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(100, 23);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // listViewfiles
            // 
            this.listViewfiles.Location = new System.Drawing.Point(12, 12);
            this.listViewfiles.Name = "listViewfiles";
            this.listViewfiles.Size = new System.Drawing.Size(305, 106);
            this.listViewfiles.TabIndex = 2;
            this.listViewfiles.UseCompatibleStateImageBehavior = false;
            // 
            // listboxindex
            // 
            this.listboxindex.FormattingEnabled = true;
            this.listboxindex.Location = new System.Drawing.Point(153, 166);
            this.listboxindex.Name = "listboxindex";
            this.listboxindex.Size = new System.Drawing.Size(182, 82);
            this.listboxindex.TabIndex = 3;
            this.listboxindex.SelectedIndexChanged += new System.EventHandler(this.listboxindex_SelectedIndexChanged);
            // 
            // richTextBoxfileitems
            // 
            this.richTextBoxfileitems.Location = new System.Drawing.Point(400, 28);
            this.richTextBoxfileitems.Name = "richTextBoxfileitems";
            this.richTextBoxfileitems.Size = new System.Drawing.Size(241, 362);
            this.richTextBoxfileitems.TabIndex = 4;
            this.richTextBoxfileitems.Text = "";
            // 
            // txtboxpath
            // 
            this.txtboxpath.Location = new System.Drawing.Point(59, 124);
            this.txtboxpath.Name = "txtboxpath";
            this.txtboxpath.Size = new System.Drawing.Size(177, 20);
            this.txtboxpath.TabIndex = 5;
            // 
            // txtboxword
            // 
            this.txtboxword.Location = new System.Drawing.Point(15, 206);
            this.txtboxword.Name = "txtboxword";
            this.txtboxword.Size = new System.Drawing.Size(100, 20);
            this.txtboxword.TabIndex = 6;
            // 
            // lblpath
            // 
            this.lblpath.AutoSize = true;
            this.lblpath.Location = new System.Drawing.Point(12, 129);
            this.lblpath.Name = "lblpath";
            this.lblpath.Size = new System.Drawing.Size(29, 13);
            this.lblpath.TabIndex = 7;
            this.lblpath.Text = "Path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Text File Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter Word to be searhed";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // htmltxtbox
            // 
            this.htmltxtbox.Location = new System.Drawing.Point(667, 294);
            this.htmltxtbox.Name = "htmltxtbox";
            this.htmltxtbox.Size = new System.Drawing.Size(139, 20);
            this.htmltxtbox.TabIndex = 10;
            // 
            // htmlbtn
            // 
            this.htmlbtn.Location = new System.Drawing.Point(667, 325);
            this.htmlbtn.Name = "htmlbtn";
            this.htmlbtn.Size = new System.Drawing.Size(139, 23);
            this.htmlbtn.TabIndex = 11;
            this.htmlbtn.Text = "HTMLSearch";
            this.htmlbtn.UseVisualStyleBackColor = true;
            this.htmlbtn.Click += new System.EventHandler(this.htmlbtn_Click);
            // 
            // reportbtn
            // 
            this.reportbtn.Location = new System.Drawing.Point(15, 367);
            this.reportbtn.Name = "reportbtn";
            this.reportbtn.Size = new System.Drawing.Size(87, 23);
            this.reportbtn.TabIndex = 12;
            this.reportbtn.Text = "Report";
            this.reportbtn.UseVisualStyleBackColor = true;
            this.reportbtn.Click += new System.EventHandler(this.reportbtn_Click);
            // 
            // reportrichtxtbox
            // 
            this.reportrichtxtbox.Location = new System.Drawing.Point(15, 294);
            this.reportrichtxtbox.Name = "reportrichtxtbox";
            this.reportrichtxtbox.Size = new System.Drawing.Size(320, 63);
            this.reportrichtxtbox.TabIndex = 13;
            this.reportrichtxtbox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 24);
            this.button1.TabIndex = 14;
            this.button1.Text = "OpenFile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(667, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(139, 56);
            this.listBox1.TabIndex = 15;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(667, 113);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(139, 56);
            this.listBox2.TabIndex = 16;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(667, 192);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(139, 56);
            this.listBox3.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(711, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Achor Tag";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(711, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Script Tag";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(711, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Title Tag";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 402);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportrichtxtbox);
            this.Controls.Add(this.reportbtn);
            this.Controls.Add(this.htmlbtn);
            this.Controls.Add(this.htmltxtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblpath);
            this.Controls.Add(this.txtboxword);
            this.Controls.Add(this.txtboxpath);
            this.Controls.Add(this.richTextBoxfileitems);
            this.Controls.Add(this.listboxindex);
            this.Controls.Add(this.listViewfiles);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnbrowse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.ListView listViewfiles;
        private System.Windows.Forms.ListBox listboxindex;
        private System.Windows.Forms.RichTextBox richTextBoxfileitems;
        private System.Windows.Forms.TextBox txtboxpath;
        private System.Windows.Forms.TextBox txtboxword;
        private System.Windows.Forms.Label lblpath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox htmltxtbox;
        private System.Windows.Forms.Button htmlbtn;
        private System.Windows.Forms.Button reportbtn;
        private System.Windows.Forms.RichTextBox reportrichtxtbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

