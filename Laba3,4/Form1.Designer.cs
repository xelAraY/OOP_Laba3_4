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
            this.Draw_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
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
            // Draw_Button
            // 
            this.Draw_Button.Location = new System.Drawing.Point(483, 483);
            this.Draw_Button.Name = "Draw_Button";
            this.Draw_Button.Size = new System.Drawing.Size(133, 29);
            this.Draw_Button.TabIndex = 3;
            this.Draw_Button.Text = "Draw";
            this.Draw_Button.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(973, 538);
            this.Controls.Add(this.Draw_Button);
            this.Controls.Add(this.ColorSelect_Button);
            this.Controls.Add(this.Figure_ComboBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox Figure_ComboBox;
        private ColorDialog colorDialog1;
        private Button ColorSelect_Button;
        private Button Draw_Button;
    }
}