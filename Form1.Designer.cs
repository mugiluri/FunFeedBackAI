
namespace NewLiveChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.textBoxFeebBackIn = new System.Windows.Forms.TextBox();
            this.textBoxAnalyse = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonPost = new System.Windows.Forms.Button();
            this.labelFeedBackIn = new System.Windows.Forms.Label();
            this.labelYAxis = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(389, 26);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(358, 251);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // textBoxFeebBackIn
            // 
            this.textBoxFeebBackIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFeebBackIn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxFeebBackIn.Location = new System.Drawing.Point(27, 45);
            this.textBoxFeebBackIn.Multiline = true;
            this.textBoxFeebBackIn.Name = "textBoxFeebBackIn";
            this.textBoxFeebBackIn.Size = new System.Drawing.Size(240, 39);
            this.textBoxFeebBackIn.TabIndex = 1;
            // 
            // textBoxAnalyse
            // 
            this.textBoxAnalyse.BackColor = System.Drawing.SystemColors.ControlText;
            this.textBoxAnalyse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAnalyse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxAnalyse.Font = new System.Drawing.Font("Swis721 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnalyse.ForeColor = System.Drawing.Color.Lime;
            this.textBoxAnalyse.Location = new System.Drawing.Point(27, 187);
            this.textBoxAnalyse.Multiline = true;
            this.textBoxAnalyse.Name = "textBoxAnalyse";
            this.textBoxAnalyse.ReadOnly = true;
            this.textBoxAnalyse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAnalyse.Size = new System.Drawing.Size(240, 127);
            this.textBoxAnalyse.TabIndex = 2;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonLoad.Location = new System.Drawing.Point(528, 283);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(99, 31);
            this.buttonLoad.TabIndex = 3;
            this.buttonLoad.Text = "See Graph";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonPost
            // 
            this.buttonPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPost.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonPost.Location = new System.Drawing.Point(27, 90);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(75, 31);
            this.buttonPost.TabIndex = 4;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // labelFeedBackIn
            // 
            this.labelFeedBackIn.AutoSize = true;
            this.labelFeedBackIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeedBackIn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelFeedBackIn.Location = new System.Drawing.Point(24, 26);
            this.labelFeedBackIn.Name = "labelFeedBackIn";
            this.labelFeedBackIn.Size = new System.Drawing.Size(143, 15);
            this.labelFeedBackIn.TabIndex = 5;
            this.labelFeedBackIn.Text = "Enter your Fun Feedback";
            // 
            // labelYAxis
            // 
            this.labelYAxis.AutoSize = true;
            this.labelYAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYAxis.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelYAxis.Location = new System.Drawing.Point(24, 169);
            this.labelYAxis.Name = "labelYAxis";
            this.labelYAxis.Size = new System.Drawing.Size(49, 15);
            this.labelYAxis.TabIndex = 6;
            this.labelYAxis.Text = "Analyse";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "happy.png");
            this.imageList1.Images.SetKeyName(1, "sad.png");
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(297, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(63, 63);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(541, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 355);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelYAxis);
            this.Controls.Add(this.labelFeedBackIn);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textBoxAnalyse);
            this.Controls.Add(this.textBoxFeebBackIn);
            this.Controls.Add(this.cartesianChart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Fun Feedback Analyzer by Mugiluri";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.TextBox textBoxFeebBackIn;
        private System.Windows.Forms.TextBox textBoxAnalyse;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Label labelFeedBackIn;
        private System.Windows.Forms.Label labelYAxis;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

