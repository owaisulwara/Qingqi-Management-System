namespace Qingqi_Management_System
{
    partial class QingqiMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QingqiMS));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.route = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.onroad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.travelrent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.qingqilabel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.reqarea = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.origin = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.cng = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.dtp);
            this.panel1.Controls.Add(this.route);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.onroad);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.travelrent);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.qingqilabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.reqarea);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.origin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Location = new System.Drawing.Point(104, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 427);
            this.panel1.TabIndex = 2;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(64, 191);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(198, 20);
            this.dtp.TabIndex = 3;
            // 
            // route
            // 
            this.route.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.route.FormattingEnabled = true;
            this.route.Location = new System.Drawing.Point(66, 65);
            this.route.Name = "route";
            this.route.Size = new System.Drawing.Size(198, 21);
            this.route.TabIndex = 0;
            this.route.Text = "Choose your travelling route";
            this.route.SelectedIndexChanged += new System.EventHandler(this.route_SelectedIndexChanged);
            this.route.TextChanged += new System.EventHandler(this.route_TextChanged);
            this.route.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.route_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(144, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "ROUTE";
            // 
            // onroad
            // 
            this.onroad.Location = new System.Drawing.Point(63, 381);
            this.onroad.Name = "onroad";
            this.onroad.Size = new System.Drawing.Size(199, 20);
            this.onroad.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(115, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "QINGQI ON ROAD";
            // 
            // travelrent
            // 
            this.travelrent.Location = new System.Drawing.Point(64, 334);
            this.travelrent.Name = "travelrent";
            this.travelrent.Size = new System.Drawing.Size(198, 20);
            this.travelrent.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(123, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "TRAVEL RENT";
            // 
            // qingqilabel
            // 
            this.qingqilabel.Location = new System.Drawing.Point(63, 290);
            this.qingqilabel.Name = "qingqilabel";
            this.qingqilabel.Size = new System.Drawing.Size(199, 20);
            this.qingqilabel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(124, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "QINGQI LABEL";
            // 
            // reqarea
            // 
            this.reqarea.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.reqarea.FormattingEnabled = true;
            this.reqarea.Location = new System.Drawing.Point(64, 157);
            this.reqarea.Name = "reqarea";
            this.reqarea.Size = new System.Drawing.Size(198, 21);
            this.reqarea.TabIndex = 2;
            this.reqarea.Text = "Choose your required location";
            this.reqarea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.reqarea_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(116, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "REQUIRED AREA";
            // 
            // origin
            // 
            this.origin.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.origin.FormattingEnabled = true;
            this.origin.Location = new System.Drawing.Point(64, 111);
            this.origin.Name = "origin";
            this.origin.Size = new System.Drawing.Size(198, 21);
            this.origin.TabIndex = 1;
            this.origin.Text = "Choose your origin location";
            this.origin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.origin_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(142, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ORIGIN";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(64, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "SUBMIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(131, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tracker";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(329, 427);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 63;
            this.lineShape1.X2 = 265;
            this.lineShape1.Y1 = 260;
            this.lineShape1.Y2 = 260;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.rectangleShape1.Location = new System.Drawing.Point(8, 7);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(313, 412);
            // 
            // cng
            // 
            this.cng.AutoSize = true;
            this.cng.ForeColor = System.Drawing.Color.White;
            this.cng.Location = new System.Drawing.Point(221, 436);
            this.cng.Name = "cng";
            this.cng.Size = new System.Drawing.Size(95, 13);
            this.cng.TabIndex = 3;
            this.cng.Text = "CNG Status: Open";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Qingqi_Management_System.Properties.Resources.logout_16;
            this.button1.Location = new System.Drawing.Point(440, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "LOGOUT";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QingqiMS
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(536, 451);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cng);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "QingqiMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QingqiMS";
            this.Load += new System.EventHandler(this.QingqiMS_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.TextBox onroad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox travelrent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox qingqilabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox reqarea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox origin;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.ComboBox route;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label cng;
        private System.Windows.Forms.Button button1;
    }
}