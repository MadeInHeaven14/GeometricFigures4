

    partial class Draw_Redactor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GraphicEditor = new System.Windows.Forms.Label();
            this.picBox_Draw = new System.Windows.Forms.PictureBox();
            this.Choice_Figure = new System.Windows.Forms.Label();
            this.FigureChoice = new System.Windows.Forms.ComboBox();
            this.panel_Properties = new System.Windows.Forms.Panel();
            this.Choice_Width = new System.Windows.Forms.Label();
            this.trackBar_Width = new System.Windows.Forms.TrackBar();
            this.openColorDialog = new System.Windows.Forms.PictureBox();
            this.blue_color = new System.Windows.Forms.PictureBox();
            this.yellow_color = new System.Windows.Forms.PictureBox();
            this.red_color = new System.Windows.Forms.PictureBox();
            this.Choice_Color = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.labelHeight = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.Width = new System.Windows.Forms.TextBox();
            this.labelRadius = new System.Windows.Forms.Label();
            this.Radius = new System.Windows.Forms.TextBox();
            this.Load = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Draw = new System.Windows.Forms.Button();
            this.Y3 = new System.Windows.Forms.TextBox();
            this.labelY3 = new System.Windows.Forms.Label();
            this.X3 = new System.Windows.Forms.TextBox();
            this.labelX3 = new System.Windows.Forms.Label();
            this.Y2 = new System.Windows.Forms.TextBox();
            this.labelY2 = new System.Windows.Forms.Label();
            this.X2 = new System.Windows.Forms.TextBox();
            this.labelX2 = new System.Windows.Forms.Label();
            this.Y1 = new System.Windows.Forms.TextBox();
            this.labelY1 = new System.Windows.Forms.Label();
            this.X1 = new System.Windows.Forms.TextBox();
            this.labelX1 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog_Color = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Draw)).BeginInit();
            this.panel_Properties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openColorDialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow_color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red_color)).BeginInit();
            this.SuspendLayout();
            // 
            // GraphicEditor
            // 
            this.GraphicEditor.AutoSize = true;
            this.GraphicEditor.Font = new System.Drawing.Font("Segoe UI Black", 19.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GraphicEditor.Location = new System.Drawing.Point(336, 9);
            this.GraphicEditor.Name = "GraphicEditor";
            this.GraphicEditor.Size = new System.Drawing.Size(325, 36);
            this.GraphicEditor.TabIndex = 0;
            this.GraphicEditor.Text = "Графический редактор";
            // 
            // picBox_Draw
            // 
            this.picBox_Draw.BackColor = System.Drawing.SystemColors.Menu;
            this.picBox_Draw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox_Draw.Location = new System.Drawing.Point(12, 61);
            this.picBox_Draw.Name = "picBox_Draw";
            this.picBox_Draw.Size = new System.Drawing.Size(608, 508);
            this.picBox_Draw.TabIndex = 1;
            this.picBox_Draw.TabStop = false;
            this.picBox_Draw.ClientSizeChanged += new System.EventHandler(this.pictureBox1_ClientSizeChanged);
            // 
            // Choice_Figure
            // 
            this.Choice_Figure.AutoSize = true;
            this.Choice_Figure.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Choice_Figure.Location = new System.Drawing.Point(104, 14);
            this.Choice_Figure.Name = "Choice_Figure";
            this.Choice_Figure.Size = new System.Drawing.Size(138, 21);
            this.Choice_Figure.TabIndex = 2;
            this.Choice_Figure.Text = "Выберите фигуру:";
            // 
            // FigureChoice
            // 
            this.FigureChoice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FigureChoice.FormattingEnabled = true;
            this.FigureChoice.Items.AddRange(new object[] {
            "Rectangle",
            "Triangle",
            "Circle",
            "Line"});
            this.FigureChoice.Location = new System.Drawing.Point(104, 38);
            this.FigureChoice.Name = "FigureChoice";
            this.FigureChoice.Size = new System.Drawing.Size(138, 23);
            this.FigureChoice.TabIndex = 3;
            this.FigureChoice.SelectedIndexChanged += new System.EventHandler(this.FigureChoice_SelectedIndexChanged);
            // 
            // panel_Properties
            // 
            this.panel_Properties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Properties.Controls.Add(this.Choice_Width);
            this.panel_Properties.Controls.Add(this.trackBar_Width);
            this.panel_Properties.Controls.Add(this.openColorDialog);
            this.panel_Properties.Controls.Add(this.blue_color);
            this.panel_Properties.Controls.Add(this.yellow_color);
            this.panel_Properties.Controls.Add(this.red_color);
            this.panel_Properties.Controls.Add(this.Choice_Color);
            this.panel_Properties.Controls.Add(this.Clear);
            this.panel_Properties.Controls.Add(this.labelHeight);
            this.panel_Properties.Controls.Add(this.Height);
            this.panel_Properties.Controls.Add(this.labelWidth);
            this.panel_Properties.Controls.Add(this.Width);
            this.panel_Properties.Controls.Add(this.labelRadius);
            this.panel_Properties.Controls.Add(this.Radius);
            this.panel_Properties.Controls.Add(this.Load);
            this.panel_Properties.Controls.Add(this.Save);
            this.panel_Properties.Controls.Add(this.Draw);
            this.panel_Properties.Controls.Add(this.Y3);
            this.panel_Properties.Controls.Add(this.labelY3);
            this.panel_Properties.Controls.Add(this.X3);
            this.panel_Properties.Controls.Add(this.labelX3);
            this.panel_Properties.Controls.Add(this.Y2);
            this.panel_Properties.Controls.Add(this.labelY2);
            this.panel_Properties.Controls.Add(this.X2);
            this.panel_Properties.Controls.Add(this.labelX2);
            this.panel_Properties.Controls.Add(this.Y1);
            this.panel_Properties.Controls.Add(this.labelY1);
            this.panel_Properties.Controls.Add(this.X1);
            this.panel_Properties.Controls.Add(this.labelX1);
            this.panel_Properties.Controls.Add(this.Choice_Figure);
            this.panel_Properties.Controls.Add(this.FigureChoice);
            this.panel_Properties.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel_Properties.Location = new System.Drawing.Point(638, 61);
            this.panel_Properties.Name = "panel_Properties";
            this.panel_Properties.Size = new System.Drawing.Size(335, 508);
            this.panel_Properties.TabIndex = 4;
            this.panel_Properties.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Choice_Width
            // 
            this.Choice_Width.AutoSize = true;
            this.Choice_Width.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Choice_Width.Location = new System.Drawing.Point(104, 314);
            this.Choice_Width.Name = "Choice_Width";
            this.Choice_Width.Size = new System.Drawing.Size(150, 21);
            this.Choice_Width.TabIndex = 23;
            this.Choice_Width.Text = "Выберите толщину:";
            this.Choice_Width.Visible = false;
            // 
            // trackBar_Width
            // 
            this.trackBar_Width.Location = new System.Drawing.Point(32, 351);
            this.trackBar_Width.Name = "trackBar_Width";
            this.trackBar_Width.Size = new System.Drawing.Size(269, 45);
            this.trackBar_Width.TabIndex = 22;
            this.trackBar_Width.Visible = false;
            this.trackBar_Width.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // openColorDialog
            // 
            this.openColorDialog.BackColor = System.Drawing.Color.White;
            this.openColorDialog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.openColorDialog.Location = new System.Drawing.Point(168, 267);
            this.openColorDialog.Name = "openColorDialog";
            this.openColorDialog.Size = new System.Drawing.Size(20, 20);
            this.openColorDialog.TabIndex = 21;
            this.openColorDialog.TabStop = false;
            this.openColorDialog.Visible = false;
            this.openColorDialog.Click += new System.EventHandler(this.openColorDialog_Click);
            // 
            // blue_color
            // 
            this.blue_color.BackColor = System.Drawing.Color.Blue;
            this.blue_color.Location = new System.Drawing.Point(231, 231);
            this.blue_color.Name = "blue_color";
            this.blue_color.Size = new System.Drawing.Size(20, 20);
            this.blue_color.TabIndex = 21;
            this.blue_color.TabStop = false;
            this.blue_color.Visible = false;
            this.blue_color.Click += new System.EventHandler(this.blue_color_Click);
            // 
            // yellow_color
            // 
            this.yellow_color.BackColor = System.Drawing.Color.Yellow;
            this.yellow_color.Location = new System.Drawing.Point(168, 231);
            this.yellow_color.Name = "yellow_color";
            this.yellow_color.Size = new System.Drawing.Size(20, 20);
            this.yellow_color.TabIndex = 21;
            this.yellow_color.TabStop = false;
            this.yellow_color.Visible = false;
            this.yellow_color.Click += new System.EventHandler(this.yellow_color_Click);
            // 
            // red_color
            // 
            this.red_color.BackColor = System.Drawing.Color.Red;
            this.red_color.Location = new System.Drawing.Point(109, 231);
            this.red_color.Name = "red_color";
            this.red_color.Size = new System.Drawing.Size(20, 20);
            this.red_color.TabIndex = 21;
            this.red_color.TabStop = false;
            this.red_color.Visible = false;
            this.red_color.Click += new System.EventHandler(this.red_color_Click);
            // 
            // Choice_Color
            // 
            this.Choice_Color.AutoSize = true;
            this.Choice_Color.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Choice_Color.Location = new System.Drawing.Point(122, 195);
            this.Choice_Color.Name = "Choice_Color";
            this.Choice_Color.Size = new System.Drawing.Size(120, 21);
            this.Choice_Color.TabIndex = 20;
            this.Choice_Color.Text = "Выберите цвет:";
            this.Choice_Color.Visible = false;
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clear.Location = new System.Drawing.Point(32, 416);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 19;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHeight.Location = new System.Drawing.Point(75, 109);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(19, 15);
            this.labelHeight.TabIndex = 4;
            this.labelHeight.Text = "H:";
            this.labelHeight.Visible = false;
            // 
            // Height
            // 
            this.Height.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Height.Location = new System.Drawing.Point(104, 106);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(25, 23);
            this.Height.TabIndex = 5;
            this.Height.Visible = false;
            this.Height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X1_KeyPress);
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWidth.Location = new System.Drawing.Point(75, 76);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(21, 15);
            this.labelWidth.TabIndex = 4;
            this.labelWidth.Text = "W:";
            this.labelWidth.Visible = false;
            // 
            // Width
            // 
            this.Width.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Width.Location = new System.Drawing.Point(104, 73);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(25, 23);
            this.Width.TabIndex = 5;
            this.Width.Visible = false;
            this.Width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X1_KeyPress);
            // 
            // labelRadius
            // 
            this.labelRadius.AutoSize = true;
            this.labelRadius.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.labelRadius.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRadius.Location = new System.Drawing.Point(6, 142);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(17, 15);
            this.labelRadius.TabIndex = 8;
            this.labelRadius.Text = "R:";
            this.labelRadius.Visible = false;
            // 
            // Radius
            // 
            this.Radius.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Radius.Location = new System.Drawing.Point(32, 139);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(25, 23);
            this.Radius.TabIndex = 9;
            this.Radius.Visible = false;
            this.Radius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X1_KeyPress);
            // 
            // Load
            // 
            this.Load.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Load.Location = new System.Drawing.Point(235, 454);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(75, 23);
            this.Load.TabIndex = 18;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Save.Location = new System.Drawing.Point(32, 454);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 17;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Draw
            // 
            this.Draw.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Draw.Location = new System.Drawing.Point(133, 454);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(75, 23);
            this.Draw.TabIndex = 16;
            this.Draw.Text = "Draw";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // Y3
            // 
            this.Y3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Y3.Location = new System.Drawing.Point(307, 106);
            this.Y3.Name = "Y3";
            this.Y3.Size = new System.Drawing.Size(25, 23);
            this.Y3.TabIndex = 15;
            this.Y3.Visible = false;
            this.Y3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X1_KeyPress);
            // 
            // labelY3
            // 
            this.labelY3.AutoSize = true;
            this.labelY3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelY3.Location = new System.Drawing.Point(278, 109);
            this.labelY3.Name = "labelY3";
            this.labelY3.Size = new System.Drawing.Size(23, 15);
            this.labelY3.TabIndex = 14;
            this.labelY3.Text = "Y3:";
            this.labelY3.Visible = false;
            // 
            // X3
            // 
            this.X3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.X3.Location = new System.Drawing.Point(307, 73);
            this.X3.Name = "X3";
            this.X3.Size = new System.Drawing.Size(25, 23);
            this.X3.TabIndex = 13;
            this.X3.Visible = false;
            this.X3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X1_KeyPress);
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelX3.Location = new System.Drawing.Point(278, 76);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(23, 15);
            this.labelX3.TabIndex = 12;
            this.labelX3.Text = "X3:";
            this.labelX3.Visible = false;
            // 
            // Y2
            // 
            this.Y2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Y2.Location = new System.Drawing.Point(172, 106);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(25, 23);
            this.Y2.TabIndex = 11;
            this.Y2.Visible = false;
            this.Y2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X1_KeyPress);
            // 
            // labelY2
            // 
            this.labelY2.AutoSize = true;
            this.labelY2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelY2.Location = new System.Drawing.Point(143, 109);
            this.labelY2.Name = "labelY2";
            this.labelY2.Size = new System.Drawing.Size(23, 15);
            this.labelY2.TabIndex = 10;
            this.labelY2.Text = "Y2:";
            this.labelY2.Visible = false;
            // 
            // X2
            // 
            this.X2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.X2.Location = new System.Drawing.Point(172, 73);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(25, 23);
            this.X2.TabIndex = 9;
            this.X2.Visible = false;
            this.X2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X1_KeyPress);
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelX2.Location = new System.Drawing.Point(143, 76);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(23, 15);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "X2:";
            this.labelX2.Visible = false;
            // 
            // Y1
            // 
            this.Y1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Y1.Location = new System.Drawing.Point(32, 106);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(25, 23);
            this.Y1.TabIndex = 7;
            this.Y1.Visible = false;
            this.Y1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X1_KeyPress);
            // 
            // labelY1
            // 
            this.labelY1.AutoSize = true;
            this.labelY1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelY1.Location = new System.Drawing.Point(3, 109);
            this.labelY1.Name = "labelY1";
            this.labelY1.Size = new System.Drawing.Size(23, 15);
            this.labelY1.TabIndex = 6;
            this.labelY1.Text = "Y1:";
            this.labelY1.Visible = false;
            // 
            // X1
            // 
            this.X1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.X1.Location = new System.Drawing.Point(32, 73);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(25, 23);
            this.X1.TabIndex = 5;
            this.X1.Visible = false;
            this.X1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X1_KeyPress);
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelX1.Location = new System.Drawing.Point(3, 76);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(23, 15);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "X1:";
            this.labelX1.Visible = false;
            // 
            // openFileDialog_Color
            // 
            this.openFileDialog_Color.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 581);
            this.Controls.Add(this.panel_Properties);
            this.Controls.Add(this.picBox_Draw);
            this.Controls.Add(this.GraphicEditor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Draw)).EndInit();
            this.panel_Properties.ResumeLayout(false);
            this.panel_Properties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openColorDialog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow_color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red_color)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GraphicEditor;
    private System.Windows.Forms.PictureBox picBox_Draw;
    private System.Windows.Forms.Label Choice_Figure;
    private System.Windows.Forms.ComboBox FigureChoice;
    private System.Windows.Forms.Panel panel_Properties;
    private System.Windows.Forms.TextBox Y3;
    private System.Windows.Forms.Label labelY3;
    private System.Windows.Forms.TextBox X3;
    private System.Windows.Forms.Label labelX3;
    private System.Windows.Forms.TextBox Y2;
    private System.Windows.Forms.Label labelY2;
    private System.Windows.Forms.TextBox X2;
    private System.Windows.Forms.Label labelX2;
    private System.Windows.Forms.TextBox Y1;
    private System.Windows.Forms.Label labelY1;
    private System.Windows.Forms.TextBox X1;
    private System.Windows.Forms.Label labelX1;
    private System.Windows.Forms.Button Draw;
    private System.Windows.Forms.Button Load;
    private System.Windows.Forms.Button Save;
    private System.Windows.Forms.Label labelRadius;
    private System.Windows.Forms.TextBox Radius;
    private System.Windows.Forms.Label labelHeight;
    private System.Windows.Forms.TextBox Height;
    private System.Windows.Forms.Label labelWidth;
    private System.Windows.Forms.TextBox Width;
    private System.Windows.Forms.Button Clear;
    private System.Windows.Forms.SaveFileDialog saveFileDialog;
    private System.Windows.Forms.OpenFileDialog openFileDialog_Color;
    private System.Windows.Forms.ColorDialog colorDialog;
    private System.Windows.Forms.PictureBox openColorDialog;
    private System.Windows.Forms.PictureBox blue_color;
    private System.Windows.Forms.PictureBox yellow_color;
    private System.Windows.Forms.PictureBox red_color;
    private System.Windows.Forms.Label Choice_Color;
    private System.Windows.Forms.Label Choice_Width;
    private System.Windows.Forms.TrackBar trackBar_Width;
}


