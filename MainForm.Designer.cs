
namespace ImageRandomizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SliceImageControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            this.TargetImageControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            this.RandomizeButton = new System.Windows.Forms.Button();
            this.TargetImageViewer = new System.Windows.Forms.PictureBox();
            this.SliceImageViewer = new System.Windows.Forms.PictureBox();
            this.MinValueControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.MaxValueControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.NumberSlicesControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.OrientationControl = new DataJuggler.Win.Controls.LabelComboBoxControl();
            this.StartXControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.StartYControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.Graph = new System.Windows.Forms.ProgressBar();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NewFileNameControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.TargetImageViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliceImageViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // SliceImageControl
            // 
            this.SliceImageControl.BackColor = System.Drawing.Color.Transparent;
            this.SliceImageControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.File;
            this.SliceImageControl.ButtonImage = ((System.Drawing.Image)(resources.GetObject("SliceImageControl.ButtonImage")));
            this.SliceImageControl.ButtonWidth = 48;
            this.SliceImageControl.DarkMode = false;
            this.SliceImageControl.DisabledLabelColor = System.Drawing.Color.Empty;
            this.SliceImageControl.Editable = false;
            this.SliceImageControl.EnabledLabelColor = System.Drawing.Color.Empty;
            this.SliceImageControl.Filter = null;
            this.SliceImageControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SliceImageControl.HideBrowseButton = false;
            this.SliceImageControl.LabelBottomMargin = 0;
            this.SliceImageControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.SliceImageControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SliceImageControl.LabelText = "Slice Image:";
            this.SliceImageControl.LabelTopMargin = 0;
            this.SliceImageControl.LabelWidth = 140;
            this.SliceImageControl.Location = new System.Drawing.Point(45, 28);
            this.SliceImageControl.Name = "SliceImageControl";
            this.SliceImageControl.OnTextChangedListener = null;
            this.SliceImageControl.OpenCallback = null;
            this.SliceImageControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SliceImageControl.SelectedPath = null;
            this.SliceImageControl.Size = new System.Drawing.Size(1090, 32);
            this.SliceImageControl.StartPath = null;
            this.SliceImageControl.TabIndex = 0;
            this.SliceImageControl.TextBoxBottomMargin = 0;
            this.SliceImageControl.TextBoxDisabledColor = System.Drawing.Color.Empty;
            this.SliceImageControl.TextBoxEditableColor = System.Drawing.Color.Empty;
            this.SliceImageControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SliceImageControl.TextBoxTopMargin = 0;
            this.SliceImageControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // TargetImageControl
            // 
            this.TargetImageControl.BackColor = System.Drawing.Color.Transparent;
            this.TargetImageControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.File;
            this.TargetImageControl.ButtonImage = ((System.Drawing.Image)(resources.GetObject("TargetImageControl.ButtonImage")));
            this.TargetImageControl.ButtonWidth = 48;
            this.TargetImageControl.DarkMode = false;
            this.TargetImageControl.DisabledLabelColor = System.Drawing.Color.Empty;
            this.TargetImageControl.Editable = false;
            this.TargetImageControl.EnabledLabelColor = System.Drawing.Color.Empty;
            this.TargetImageControl.Filter = null;
            this.TargetImageControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TargetImageControl.HideBrowseButton = false;
            this.TargetImageControl.LabelBottomMargin = 0;
            this.TargetImageControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.TargetImageControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TargetImageControl.LabelText = "Target Image:";
            this.TargetImageControl.LabelTopMargin = 0;
            this.TargetImageControl.LabelWidth = 140;
            this.TargetImageControl.Location = new System.Drawing.Point(45, 116);
            this.TargetImageControl.Name = "TargetImageControl";
            this.TargetImageControl.OnTextChangedListener = null;
            this.TargetImageControl.OpenCallback = null;
            this.TargetImageControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TargetImageControl.SelectedPath = null;
            this.TargetImageControl.Size = new System.Drawing.Size(1090, 32);
            this.TargetImageControl.StartPath = null;
            this.TargetImageControl.TabIndex = 1;
            this.TargetImageControl.TextBoxBottomMargin = 0;
            this.TargetImageControl.TextBoxDisabledColor = System.Drawing.Color.Empty;
            this.TargetImageControl.TextBoxEditableColor = System.Drawing.Color.Empty;
            this.TargetImageControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TargetImageControl.TextBoxTopMargin = 0;
            this.TargetImageControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // RandomizeButton
            // 
            this.RandomizeButton.BackColor = System.Drawing.Color.Transparent;
            this.RandomizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RandomizeButton.BackgroundImage")));
            this.RandomizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RandomizeButton.FlatAppearance.BorderSize = 0;
            this.RandomizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RandomizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RandomizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomizeButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RandomizeButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.RandomizeButton.Location = new System.Drawing.Point(921, 416);
            this.RandomizeButton.Name = "RandomizeButton";
            this.RandomizeButton.Size = new System.Drawing.Size(184, 47);
            this.RandomizeButton.TabIndex = 2;
            this.RandomizeButton.Text = "Randomize";
            this.RandomizeButton.UseVisualStyleBackColor = false;
            this.RandomizeButton.Click += new System.EventHandler(this.RandomizeButton_Click);
            this.RandomizeButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.RandomizeButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // TargetImageViewer
            // 
            this.TargetImageViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TargetImageViewer.Location = new System.Drawing.Point(186, 154);
            this.TargetImageViewer.Name = "TargetImageViewer";
            this.TargetImageViewer.Size = new System.Drawing.Size(582, 193);
            this.TargetImageViewer.TabIndex = 3;
            this.TargetImageViewer.TabStop = false;
            // 
            // SliceImageViewer
            // 
            this.SliceImageViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SliceImageViewer.Location = new System.Drawing.Point(184, 68);
            this.SliceImageViewer.Name = "SliceImageViewer";
            this.SliceImageViewer.Size = new System.Drawing.Size(582, 16);
            this.SliceImageViewer.TabIndex = 4;
            this.SliceImageViewer.TabStop = false;
            // 
            // MinValueControl
            // 
            this.MinValueControl.BackColor = System.Drawing.Color.Transparent;
            this.MinValueControl.BottomMargin = 0;
            this.MinValueControl.Editable = true;
            this.MinValueControl.Encrypted = false;
            this.MinValueControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinValueControl.LabelBottomMargin = 0;
            this.MinValueControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.MinValueControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MinValueControl.LabelText = "Min Value:";
            this.MinValueControl.LabelTopMargin = 0;
            this.MinValueControl.LabelWidth = 140;
            this.MinValueControl.Location = new System.Drawing.Point(783, 172);
            this.MinValueControl.MultiLine = false;
            this.MinValueControl.Name = "MinValueControl";
            this.MinValueControl.OnTextChangedListener = null;
            this.MinValueControl.PasswordMode = false;
            this.MinValueControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MinValueControl.Size = new System.Drawing.Size(322, 32);
            this.MinValueControl.TabIndex = 5;
            this.MinValueControl.TextBoxBottomMargin = 0;
            this.MinValueControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.MinValueControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.MinValueControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinValueControl.TextBoxTopMargin = 0;
            // 
            // MaxValueControl
            // 
            this.MaxValueControl.BackColor = System.Drawing.Color.Transparent;
            this.MaxValueControl.BottomMargin = 0;
            this.MaxValueControl.Editable = true;
            this.MaxValueControl.Encrypted = false;
            this.MaxValueControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaxValueControl.LabelBottomMargin = 0;
            this.MaxValueControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.MaxValueControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaxValueControl.LabelText = "Max Value:";
            this.MaxValueControl.LabelTopMargin = 0;
            this.MaxValueControl.LabelWidth = 140;
            this.MaxValueControl.Location = new System.Drawing.Point(783, 210);
            this.MaxValueControl.MultiLine = false;
            this.MaxValueControl.Name = "MaxValueControl";
            this.MaxValueControl.OnTextChangedListener = null;
            this.MaxValueControl.PasswordMode = false;
            this.MaxValueControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MaxValueControl.Size = new System.Drawing.Size(322, 32);
            this.MaxValueControl.TabIndex = 6;
            this.MaxValueControl.TextBoxBottomMargin = 0;
            this.MaxValueControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.MaxValueControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.MaxValueControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaxValueControl.TextBoxTopMargin = 0;
            // 
            // NumberSlicesControl
            // 
            this.NumberSlicesControl.BackColor = System.Drawing.Color.Transparent;
            this.NumberSlicesControl.BottomMargin = 0;
            this.NumberSlicesControl.Editable = true;
            this.NumberSlicesControl.Encrypted = false;
            this.NumberSlicesControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumberSlicesControl.LabelBottomMargin = 0;
            this.NumberSlicesControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.NumberSlicesControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumberSlicesControl.LabelText = "# Slices:";
            this.NumberSlicesControl.LabelTopMargin = 0;
            this.NumberSlicesControl.LabelWidth = 140;
            this.NumberSlicesControl.Location = new System.Drawing.Point(783, 248);
            this.NumberSlicesControl.MultiLine = false;
            this.NumberSlicesControl.Name = "NumberSlicesControl";
            this.NumberSlicesControl.OnTextChangedListener = null;
            this.NumberSlicesControl.PasswordMode = false;
            this.NumberSlicesControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NumberSlicesControl.Size = new System.Drawing.Size(322, 32);
            this.NumberSlicesControl.TabIndex = 7;
            this.NumberSlicesControl.TextBoxBottomMargin = 0;
            this.NumberSlicesControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.NumberSlicesControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.NumberSlicesControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumberSlicesControl.TextBoxTopMargin = 0;
            // 
            // OrientationControl
            // 
            this.OrientationControl.BackColor = System.Drawing.Color.Transparent;
            this.OrientationControl.ComboBoxLeftMargin = 1;
            this.OrientationControl.ComboBoxText = "";
            this.OrientationControl.ComoboBoxFont = null;
            this.OrientationControl.Editable = true;
            this.OrientationControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrientationControl.HideLabel = false;
            this.OrientationControl.LabelBottomMargin = 0;
            this.OrientationControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.OrientationControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrientationControl.LabelText = "Orientation:";
            this.OrientationControl.LabelTopMargin = 0;
            this.OrientationControl.LabelWidth = 140;
            this.OrientationControl.List = null;
            this.OrientationControl.Location = new System.Drawing.Point(783, 286);
            this.OrientationControl.Name = "OrientationControl";
            this.OrientationControl.SelectedIndex = -1;
            this.OrientationControl.SelectedIndexListener = null;
            this.OrientationControl.Size = new System.Drawing.Size(322, 33);
            this.OrientationControl.Sorted = true;
            this.OrientationControl.Source = null;
            this.OrientationControl.TabIndex = 8;
            // 
            // StartXControl
            // 
            this.StartXControl.BackColor = System.Drawing.Color.Transparent;
            this.StartXControl.BottomMargin = 0;
            this.StartXControl.Editable = true;
            this.StartXControl.Encrypted = false;
            this.StartXControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartXControl.LabelBottomMargin = 0;
            this.StartXControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.StartXControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartXControl.LabelText = "Start X:";
            this.StartXControl.LabelTopMargin = 0;
            this.StartXControl.LabelWidth = 140;
            this.StartXControl.Location = new System.Drawing.Point(783, 325);
            this.StartXControl.MultiLine = false;
            this.StartXControl.Name = "StartXControl";
            this.StartXControl.OnTextChangedListener = null;
            this.StartXControl.PasswordMode = false;
            this.StartXControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.StartXControl.Size = new System.Drawing.Size(322, 32);
            this.StartXControl.TabIndex = 9;
            this.StartXControl.TextBoxBottomMargin = 0;
            this.StartXControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.StartXControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.StartXControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartXControl.TextBoxTopMargin = 0;
            // 
            // StartYControl
            // 
            this.StartYControl.BackColor = System.Drawing.Color.Transparent;
            this.StartYControl.BottomMargin = 0;
            this.StartYControl.Editable = true;
            this.StartYControl.Encrypted = false;
            this.StartYControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartYControl.LabelBottomMargin = 0;
            this.StartYControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.StartYControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartYControl.LabelText = "Start Y:";
            this.StartYControl.LabelTopMargin = 0;
            this.StartYControl.LabelWidth = 140;
            this.StartYControl.Location = new System.Drawing.Point(783, 363);
            this.StartYControl.MultiLine = false;
            this.StartYControl.Name = "StartYControl";
            this.StartYControl.OnTextChangedListener = null;
            this.StartYControl.PasswordMode = false;
            this.StartYControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.StartYControl.Size = new System.Drawing.Size(322, 31);
            this.StartYControl.TabIndex = 10;
            this.StartYControl.TextBoxBottomMargin = 0;
            this.StartYControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.StartYControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.StartYControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartYControl.TextBoxTopMargin = 0;
            // 
            // Graph
            // 
            this.Graph.Location = new System.Drawing.Point(186, 353);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(582, 23);
            this.Graph.TabIndex = 11;
            this.Graph.Visible = false;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveButton.BackgroundImage")));
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.SaveButton.Location = new System.Drawing.Point(578, 391);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(188, 47);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Save Image";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            this.SaveButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.SaveButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // NewFileNameControl
            // 
            this.NewFileNameControl.BackColor = System.Drawing.Color.Transparent;
            this.NewFileNameControl.BottomMargin = 0;
            this.NewFileNameControl.Editable = true;
            this.NewFileNameControl.Encrypted = false;
            this.NewFileNameControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewFileNameControl.LabelBottomMargin = 0;
            this.NewFileNameControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.NewFileNameControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewFileNameControl.LabelText = "New Filename:";
            this.NewFileNameControl.LabelTopMargin = 0;
            this.NewFileNameControl.LabelWidth = 140;
            this.NewFileNameControl.Location = new System.Drawing.Point(45, 398);
            this.NewFileNameControl.MultiLine = false;
            this.NewFileNameControl.Name = "NewFileNameControl";
            this.NewFileNameControl.OnTextChangedListener = null;
            this.NewFileNameControl.PasswordMode = false;
            this.NewFileNameControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NewFileNameControl.Size = new System.Drawing.Size(481, 32);
            this.NewFileNameControl.TabIndex = 13;
            this.NewFileNameControl.TextBoxBottomMargin = 0;
            this.NewFileNameControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.NewFileNameControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.NewFileNameControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewFileNameControl.TextBoxTopMargin = 0;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1186, 538);
            this.Controls.Add(this.NewFileNameControl);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.StartYControl);
            this.Controls.Add(this.StartXControl);
            this.Controls.Add(this.OrientationControl);
            this.Controls.Add(this.NumberSlicesControl);
            this.Controls.Add(this.MaxValueControl);
            this.Controls.Add(this.MinValueControl);
            this.Controls.Add(this.SliceImageViewer);
            this.Controls.Add(this.TargetImageViewer);
            this.Controls.Add(this.RandomizeButton);
            this.Controls.Add(this.TargetImageControl);
            this.Controls.Add(this.SliceImageControl);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Randomizer";
            ((System.ComponentModel.ISupportInitialize)(this.TargetImageViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliceImageViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl SliceImageControl;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl TargetImageControl;
        private System.Windows.Forms.Button RandomizeButton;
        private System.Windows.Forms.PictureBox TargetImageViewer;
        private System.Windows.Forms.PictureBox SliceImageViewer;
        private DataJuggler.Win.Controls.LabelTextBoxControl MinValueControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl MaxValueControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl NumberSlicesControl;
        private DataJuggler.Win.Controls.LabelComboBoxControl OrientationControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl StartXControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl StartYControl;
        private System.Windows.Forms.ProgressBar Graph;
        private System.Windows.Forms.Button SaveButton;
        private DataJuggler.Win.Controls.LabelTextBoxControl NewFileNameControl;
    }
}

