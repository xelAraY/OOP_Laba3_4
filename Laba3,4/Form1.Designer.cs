namespace Laba3_4
{
    partial class MainForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Figure_ComboBox = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ColorSelect_Button = new System.Windows.Forms.Button();
            this.Redraw_Button = new System.Windows.Forms.Button();
            this.OpenImage_Button = new System.Windows.Forms.Button();
            this.SaveImage_Button = new System.Windows.Forms.Button();
            this.SelectShape_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.ClearCanvas_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(970, 466);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // Figure_ComboBox
            // 
            this.Figure_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Figure_ComboBox.FormattingEnabled = true;
            this.Figure_ComboBox.Items.AddRange(new object[] {
            "Square",
            "Rectangle",
            "Circle",
            "Ellipse",
            "Line",
            "Triangle"});
            this.Figure_ComboBox.Location = new System.Drawing.Point(12, 484);
            this.Figure_ComboBox.Name = "Figure_ComboBox";
            this.Figure_ComboBox.Size = new System.Drawing.Size(219, 28);
            this.Figure_ComboBox.TabIndex = 1;
            // 
            // ColorSelect_Button
            // 
            this.ColorSelect_Button.Location = new System.Drawing.Point(287, 484);
            this.ColorSelect_Button.Name = "ColorSelect_Button";
            this.ColorSelect_Button.Size = new System.Drawing.Size(149, 28);
            this.ColorSelect_Button.TabIndex = 2;
            this.ColorSelect_Button.Text = "Select color";
            this.ColorSelect_Button.UseVisualStyleBackColor = true;
            this.ColorSelect_Button.Click += new System.EventHandler(this.ColorSelect_Button_Click);
            // 
            // Redraw_Button
            // 
            this.Redraw_Button.Location = new System.Drawing.Point(472, 484);
            this.Redraw_Button.Name = "Redraw_Button";
            this.Redraw_Button.Size = new System.Drawing.Size(94, 29);
            this.Redraw_Button.TabIndex = 3;
            this.Redraw_Button.Text = "Redraw";
            this.Redraw_Button.UseVisualStyleBackColor = true;
            this.Redraw_Button.Click += new System.EventHandler(this.Redraw_Button_Click);
            // 
            // OpenImage_Button
            // 
            this.OpenImage_Button.Location = new System.Drawing.Point(604, 483);
            this.OpenImage_Button.Name = "OpenImage_Button";
            this.OpenImage_Button.Size = new System.Drawing.Size(121, 30);
            this.OpenImage_Button.TabIndex = 4;
            this.OpenImage_Button.Text = "Open Image";
            this.OpenImage_Button.UseVisualStyleBackColor = true;
            this.OpenImage_Button.Click += new System.EventHandler(this.OpenImage_Button_Click);
            // 
            // SaveImage_Button
            // 
            this.SaveImage_Button.Location = new System.Drawing.Point(604, 524);
            this.SaveImage_Button.Name = "SaveImage_Button";
            this.SaveImage_Button.Size = new System.Drawing.Size(121, 30);
            this.SaveImage_Button.TabIndex = 5;
            this.SaveImage_Button.Text = "Save Image";
            this.SaveImage_Button.UseVisualStyleBackColor = true;
            this.SaveImage_Button.Click += new System.EventHandler(this.SaveImage_Button_Click);
            // 
            // SelectShape_Button
            // 
            this.SelectShape_Button.Location = new System.Drawing.Point(757, 506);
            this.SelectShape_Button.Name = "SelectShape_Button";
            this.SelectShape_Button.Size = new System.Drawing.Size(94, 29);
            this.SelectShape_Button.TabIndex = 6;
            this.SelectShape_Button.Text = "Select";
            this.SelectShape_Button.UseVisualStyleBackColor = true;
            this.SelectShape_Button.Click += new System.EventHandler(this.SelectShape_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(812, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выделение";
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(857, 506);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(94, 29);
            this.Cancel_Button.TabIndex = 8;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // ClearCanvas_Button
            // 
            this.ClearCanvas_Button.Location = new System.Drawing.Point(472, 524);
            this.ClearCanvas_Button.Name = "ClearCanvas_Button";
            this.ClearCanvas_Button.Size = new System.Drawing.Size(94, 29);
            this.ClearCanvas_Button.TabIndex = 9;
            this.ClearCanvas_Button.Text = "Clear";
            this.ClearCanvas_Button.UseVisualStyleBackColor = true;
            this.ClearCanvas_Button.Click += new System.EventHandler(this.ClearCanvas_Button_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(973, 566);
            this.Controls.Add(this.ClearCanvas_Button);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectShape_Button);
            this.Controls.Add(this.SaveImage_Button);
            this.Controls.Add(this.OpenImage_Button);
            this.Controls.Add(this.Redraw_Button);
            this.Controls.Add(this.ColorSelect_Button);
            this.Controls.Add(this.Figure_ComboBox);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox Figure_ComboBox;
        private ColorDialog colorDialog1;
        private Button ColorSelect_Button;
        private Button Redraw_Button;
        private Button OpenImage_Button;
        private Button SaveImage_Button;
        private Button SelectShape_Button;
        private Label label1;
        private Button Cancel_Button;
        private Button ClearCanvas_Button;
    }
}