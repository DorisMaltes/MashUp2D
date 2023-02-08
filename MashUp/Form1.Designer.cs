namespace mashUp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PCT_CANVAS = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.PANEL_LEFT = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.PLAY = new System.Windows.Forms.Button();
            this.RECORD = new System.Windows.Forms.Button();
            this.ADD = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.framesLabel = new System.Windows.Forms.Label();
            this.panelDown = new System.Windows.Forms.Panel();
            this.PCT_SLIDEER_X = new System.Windows.Forms.PictureBox();
            this.panelR = new System.Windows.Forms.Panel();
            this.PCT_SLIDEER_Y = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.PANEL_LEFT.SuspendLayout();
            this.panelDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_SLIDEER_X)).BeginInit();
            this.panelR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_SLIDEER_Y)).BeginInit();
            this.SuspendLayout();
            // 
            // PCT_CANVAS
            // 
            this.PCT_CANVAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PCT_CANVAS.Location = new System.Drawing.Point(158, 101);
            this.PCT_CANVAS.Margin = new System.Windows.Forms.Padding(2);
            this.PCT_CANVAS.Name = "PCT_CANVAS";
            this.PCT_CANVAS.Size = new System.Drawing.Size(1150, 530);
            this.PCT_CANVAS.TabIndex = 0;
            this.PCT_CANVAS.TabStop = false;
            this.PCT_CANVAS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseClick);
            this.PCT_CANVAS.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseDoubleClick);
            this.PCT_CANVAS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseDown);
            this.PCT_CANVAS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseMove);
            this.PCT_CANVAS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseUp);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.trackBar1.Location = new System.Drawing.Point(160, 27);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(1148, 56);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // PANEL_LEFT
            // 
            this.PANEL_LEFT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PANEL_LEFT.Controls.Add(this.checkBox1);
            this.PANEL_LEFT.Controls.Add(this.PLAY);
            this.PANEL_LEFT.Controls.Add(this.RECORD);
            this.PANEL_LEFT.Controls.Add(this.ADD);
            this.PANEL_LEFT.Controls.Add(this.treeView1);
            this.PANEL_LEFT.Location = new System.Drawing.Point(0, 52);
            this.PANEL_LEFT.Margin = new System.Windows.Forms.Padding(2);
            this.PANEL_LEFT.Name = "PANEL_LEFT";
            this.PANEL_LEFT.Size = new System.Drawing.Size(150, 626);
            this.PANEL_LEFT.TabIndex = 9;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(3, 414);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(149, 23);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Animate all figures";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // PLAY
            // 
            this.PLAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLAY.Location = new System.Drawing.Point(9, 553);
            this.PLAY.Margin = new System.Windows.Forms.Padding(2);
            this.PLAY.Name = "PLAY";
            this.PLAY.Size = new System.Drawing.Size(125, 45);
            this.PLAY.TabIndex = 3;
            this.PLAY.Text = "▶";
            this.PLAY.UseVisualStyleBackColor = true;
            this.PLAY.Click += new System.EventHandler(this.PLAY_Click);
            // 
            // RECORD
            // 
            this.RECORD.BackgroundImage = global::mashUp.Properties.Resources.recording_video_icon;
            this.RECORD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RECORD.Location = new System.Drawing.Point(9, 497);
            this.RECORD.Margin = new System.Windows.Forms.Padding(2);
            this.RECORD.Name = "RECORD";
            this.RECORD.Size = new System.Drawing.Size(125, 45);
            this.RECORD.TabIndex = 2;
            this.RECORD.UseVisualStyleBackColor = true;
            this.RECORD.Click += new System.EventHandler(this.RECORD_Click);
            // 
            // ADD
            // 
            this.ADD.BackColor = System.Drawing.Color.Black;
            this.ADD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ADD.FlatAppearance.BorderSize = 0;
            this.ADD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ADD.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD.ForeColor = System.Drawing.Color.White;
            this.ADD.Location = new System.Drawing.Point(9, 445);
            this.ADD.Margin = new System.Windows.Forms.Padding(2);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(125, 45);
            this.ADD.TabIndex = 1;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = false;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.treeView1.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.Color.White;
            this.treeView1.Location = new System.Drawing.Point(3, 12);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(145, 386);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.treeView1_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(158, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 44);
            this.panel1.TabIndex = 10;
            // 
            // framesLabel
            // 
            this.framesLabel.AutoSize = true;
            this.framesLabel.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.framesLabel.ForeColor = System.Drawing.Color.White;
            this.framesLabel.Location = new System.Drawing.Point(41, 13);
            this.framesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.framesLabel.Name = "framesLabel";
            this.framesLabel.Size = new System.Drawing.Size(113, 37);
            this.framesLabel.TabIndex = 9;
            this.framesLabel.Text = "Frames:";
            // 
            // panelDown
            // 
            this.panelDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDown.Controls.Add(this.PCT_SLIDEER_X);
            this.panelDown.Location = new System.Drawing.Point(158, 636);
            this.panelDown.Margin = new System.Windows.Forms.Padding(2);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(1129, 42);
            this.panelDown.TabIndex = 11;
            // 
            // PCT_SLIDEER_X
            // 
            this.PCT_SLIDEER_X.Location = new System.Drawing.Point(14, 11);
            this.PCT_SLIDEER_X.Margin = new System.Windows.Forms.Padding(2);
            this.PCT_SLIDEER_X.Name = "PCT_SLIDEER_X";
            this.PCT_SLIDEER_X.Size = new System.Drawing.Size(1119, 15);
            this.PCT_SLIDEER_X.TabIndex = 0;
            this.PCT_SLIDEER_X.TabStop = false;
            this.PCT_SLIDEER_X.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sliderX_MouseDown);
            this.PCT_SLIDEER_X.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sliderX_MouseMove);
            this.PCT_SLIDEER_X.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sliderX_MouseUp);
            // 
            // panelR
            // 
            this.panelR.Controls.Add(this.PCT_SLIDEER_Y);
            this.panelR.Location = new System.Drawing.Point(1314, 52);
            this.panelR.Name = "panelR";
            this.panelR.Size = new System.Drawing.Size(150, 626);
            this.panelR.TabIndex = 4;
            // 
            // PCT_SLIDEER_Y
            // 
            this.PCT_SLIDEER_Y.Location = new System.Drawing.Point(19, 48);
            this.PCT_SLIDEER_Y.Margin = new System.Windows.Forms.Padding(2);
            this.PCT_SLIDEER_Y.Name = "PCT_SLIDEER_Y";
            this.PCT_SLIDEER_Y.Size = new System.Drawing.Size(15, 572);
            this.PCT_SLIDEER_Y.TabIndex = 0;
            this.PCT_SLIDEER_Y.TabStop = false;
            this.PCT_SLIDEER_Y.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sliderY_MouseDown);
            this.PCT_SLIDEER_Y.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sliderY_MouseMove);
            this.PCT_SLIDEER_Y.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sliderY_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1443, 708);
            this.Controls.Add(this.framesLabel);
            this.Controls.Add(this.panelR);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.panelDown);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PANEL_LEFT);
            this.Controls.Add(this.PCT_CANVAS);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "MashUp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.PANEL_LEFT.ResumeLayout(false);
            this.PANEL_LEFT.PerformLayout();
            this.panelDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PCT_SLIDEER_X)).EndInit();
            this.panelR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PCT_SLIDEER_Y)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PCT_CANVAS;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel PANEL_LEFT;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDown;
        private System.Windows.Forms.PictureBox PCT_SLIDEER_X;
        private System.Windows.Forms.Panel panelR;
        private System.Windows.Forms.PictureBox PCT_SLIDEER_Y;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button PLAY;
        private System.Windows.Forms.Button RECORD;
        private System.Windows.Forms.Label framesLabel;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

