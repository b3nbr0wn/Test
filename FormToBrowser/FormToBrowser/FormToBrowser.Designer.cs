namespace FormToBrowser
    {
    partial class FormToBrowser
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
            this.txtBaseHTML = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNavToBase = new System.Windows.Forms.Button();
            this.txtContentIn = new System.Windows.Forms.TextBox();
            this.txtContentOut = new System.Windows.Forms.TextBox();
            this.btnInject = new System.Windows.Forms.Button();
            this.btnExtract = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBaseHTML
            // 
            this.txtBaseHTML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBaseHTML.Location = new System.Drawing.Point(3, 16);
            this.txtBaseHTML.Multiline = true;
            this.txtBaseHTML.Name = "txtBaseHTML";
            this.txtBaseHTML.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBaseHTML.Size = new System.Drawing.Size(265, 220);
            this.txtBaseHTML.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 16);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(809, 246);
            this.webBrowser1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(815, 537);
            this.splitContainer1.SplitterDistance = 268;
            this.splitContainer1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.btnExtract, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnInject, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtContentOut, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtContentIn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBaseHTML, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNavToBase, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(815, 268);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Base HTML";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.webBrowser1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(815, 265);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Browser";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Content In";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Content Out";
            // 
            // btnNavToBase
            // 
            this.btnNavToBase.Location = new System.Drawing.Point(3, 242);
            this.btnNavToBase.Name = "btnNavToBase";
            this.btnNavToBase.Size = new System.Drawing.Size(143, 23);
            this.btnNavToBase.TabIndex = 2;
            this.btnNavToBase.Text = "Load Base HTML  ↓↓↓↓ ";
            this.btnNavToBase.UseVisualStyleBackColor = true;
            this.btnNavToBase.Click += new System.EventHandler(this.btnNavToBase_Click);
            // 
            // txtContentIn
            // 
            this.txtContentIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContentIn.Location = new System.Drawing.Point(274, 16);
            this.txtContentIn.Multiline = true;
            this.txtContentIn.Name = "txtContentIn";
            this.txtContentIn.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContentIn.Size = new System.Drawing.Size(265, 220);
            this.txtContentIn.TabIndex = 3;
            // 
            // txtContentOut
            // 
            this.txtContentOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContentOut.Enabled = false;
            this.txtContentOut.Location = new System.Drawing.Point(545, 16);
            this.txtContentOut.Multiline = true;
            this.txtContentOut.Name = "txtContentOut";
            this.txtContentOut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContentOut.Size = new System.Drawing.Size(267, 220);
            this.txtContentOut.TabIndex = 4;
            // 
            // btnInject
            // 
            this.btnInject.Location = new System.Drawing.Point(274, 242);
            this.btnInject.Name = "btnInject";
            this.btnInject.Size = new System.Drawing.Size(143, 23);
            this.btnInject.TabIndex = 5;
            this.btnInject.Text = "Inject Content ↓↓↓↓ ";
            this.btnInject.UseVisualStyleBackColor = true;
            this.btnInject.Click += new System.EventHandler(this.btnInject_Click);
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(545, 242);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(143, 23);
            this.btnExtract.TabIndex = 6;
            this.btnExtract.Text = "Extract Content ↑↑↑↑";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // FormToBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 537);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormToBrowser";
            this.Text = "Form to Browser";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

            }

        #endregion

        private System.Windows.Forms.TextBox txtBaseHTML;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.Button btnInject;
        private System.Windows.Forms.TextBox txtContentOut;
        private System.Windows.Forms.TextBox txtContentIn;
        private System.Windows.Forms.Button btnNavToBase;
        }
    }

