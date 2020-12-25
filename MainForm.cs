

#region using statements

using DataJuggler.Win.Controls;
using DataJuggler.Win.Controls.Interfaces;
using DataJuggler.PixelDatabase;
using DataJuggler.RandomShuffler;
using System;
using System.Windows.Forms;
using DataJuggler.UltimateHelper;
using ImageRandomizer.Enumerations;
using System.Drawing;
using System.IO;

#endregion

namespace ImageRandomizer
{

    #region class MainForm
    /// <summary>
    /// This is the MainForm for this app
    /// </summary>
    public partial class MainForm : Form, ITextChanged
    {
        
        #region Private Variables
        private string targetImagePath;
        private string sliceImagePath;
        private PixelDatabase sliceDatabase;
        private PixelDatabase targetDatabase;
        private int numberSlices;
        private string outputPath;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'Form1' object.
        /// </summary>
        public MainForm()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion

        #region Events
            
            #region Button_Enter(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Button _ Enter
            /// </summary>
            private void Button_Enter(object sender, EventArgs e)
            {
                // Change the cursor to a hand
                Cursor = Cursors.Hand;
            }
            #endregion
            
            #region Button_Leave(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Button _ Leave
            /// </summary>
            private void Button_Leave(object sender, EventArgs e)
            {
                // Change the cursor back to the default pointer
                Cursor = Cursors.Default;
            }
            #endregion
            
            #region OnTextChanged(Control sender, string text)
            /// <summary>
            /// event is fired when On Text Changed
            /// </summary>
            public void OnTextChanged(Control sender, string text)
            {
                // if this is the SliceImageControl
                if (sender.Name == SliceImageControl.Name)
                {
                    // Store the property
                    SliceImagePath = text;

                    // Load the Slice
                    this.SliceImageViewer.BackgroundImage = Image.FromFile(text);

                    // load the pixelDatabase of the slice image
                    this.SliceDatabase = PixelDatabaseLoader.LoadPixelDatabase(SliceImageControl.Text, this.Callback);
                }
                else if (sender.Name == TargetImageControl.Name)
                {
                    // createa a fileInfo
                    FileInfo fileInfo = new FileInfo(text);

                    // Get the output path
                    OutputPath = fileInfo.Directory.FullName;

                    // create a shuffler
                    LargeNumberShuffler shuffler = new LargeNumberShuffler(6, 1, 100000, DataJuggler.RandomShuffler.Enumerations.NumberOutOfRangeOptionEnum.ReturnModulus);

                    // remove the extension add the random number put the extension back
                    string name = fileInfo.Name.Replace(fileInfo.Extension, "") + shuffler.PullNumber() + fileInfo.Extension;

                    // set the Text
                    this.NewFileNameControl.Text = name;

                    // Set the property
                    TargetImagePath = text;

                    // Load the Target
                    this.TargetImageViewer.BackgroundImage = Image.FromFile(text);    

                    // load the pixelDatabase of the target image
                    this.TargetDatabase = PixelDatabaseLoader.LoadPixelDatabase(TargetImageControl.Text, this.Callback);
                }
                else if (sender.Name == NumberSlicesControl.Name)
                {
                    // Set the NumberSlices
                    this.NumberSlices = NumberSlicesControl.IntValue;
                }
                
                // if both databases exist
                if ((HasSliceDatabase) && (HasTargetDatabase))
                {
                     double slices = targetDatabase.Height / sliceDatabase.Height;
                    this.NumberSlicesControl.Text = Math.Floor(slices).ToString();
                }
            }
            #endregion
            
            #region RandomizeButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'RandomizeButton' is clicked.
            /// </summary>
            private void RandomizeButton_Click(object sender, EventArgs e)
            {
                // setup our images
                string sliceImage = SliceImageControl.Text;
                string targetImage = TargetImageControl.Text;
                int rowHeight = 0;
                int rowWidth = 0;
                bool isValid = false;
                int offSetX = 0;
                int offSetY = 0;
                
                // Set the orientation
                OrientationEnum orientation = (OrientationEnum) OrientationControl.SelectedIndex;
                
                // load the target database
                PixelDatabase targetDatabase = PixelDatabaseLoader.LoadPixelDatabase(targetImage, this.Callback);

                // verify both objects exist
                if (NullHelper.Exists(sliceDatabase, targetDatabase))
                {
                    // Set the height and width
                    rowHeight = sliceDatabase.Height;
                    rowWidth = sliceDatabase.Width;
                    int min = MinValueControl.IntValue;
                    int max = MaxValueControl.IntValue;
                    int startX = StartXControl.IntValue;
                    int startY = StartYControl.IntValue;
                    int row = -1;
                    int col = -1;
                        
                    // verify everything is in rage
                    if ((min > 0) && (max > 0) && (max > min))
                    {
                        // valid
                        isValid = true;

                        // setup the ProgressBar
                        this.Graph.Visible = true;
                        this.Graph.Minimum = 0;
                        this.Graph.Maximum = NumberSlicesControl.IntValue;
                            
                        // Create a new instance of a 'RandomShuffler' object.
                        RandomShuffler shuffler = new RandomShuffler(min, max, 2);

                        // if horizontal
                        if (orientation == OrientationEnum.Horizontal)
                        {
                            // setup the section
                            for (int section = 0; section < NumberSlices; section++)
                            {
                                // Update the graph
                                Graph.Value = section;    

                                // pull the next item
                                int indent = shuffler.PullNextItem();

                                // now we need to copy the entire sourceImage onto the target, using this indent
                                
                                // iterate the y pixels 
                                for (int x = 0; x < rowWidth; x++)
                                {
                                    for (int y = 0; y < rowHeight; y++)
                                    {
                                        // get this pixel
                                        PixelInformation pixel = sliceDatabase.GetPixel(x , y);

                                        if (NullHelper.Exists(pixel))
                                        {
                                            // get the new x
                                            offSetX = indent + startX + x;
                                            offSetY = (section * rowHeight) + y + startY;

                                            // Set the pixel color
                                            targetDatabase.SetPixelColor(offSetX, offSetY, pixel.Color, false, 0);
                                        }
                                        else
                                        {
                                            y = y + 1 - 1;
                                        }
                                    }
                                }
                            }

                            // Set the image
                            TargetImageViewer.BackgroundImage = targetDatabase.DirectBitmap.Bitmap;
                                
                            // UPdate this UI
                            Refresh();
                        }
                        else
                        {
                            // vertical

                            // to do: Vertical
                        }
                    }
                    else
                    {
                        // not valid
                        isValid = false;
                    }
                }
                else
                {
                    // not valid
                    isValid = false;
                }

                // Show the user a message
                if (!isValid)
                {
                    // show a message to the user
                    MessageBox.Show("Not valid", "Invalid");
                }
            }
            #endregion

            #region SaveButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'SaveButton' is clicked.
            /// </summary>
            private void SaveButton_Click(object sender, EventArgs e)
            {
                // verify we have everything we need to save
                if ((HasTargetDatabase) && (HasOutputPath))
                {   
                    // Get the new fileName
                    string fileName = Path.Combine(OutputPath, NewFileNameControl.Text);

                    // Perform the save
                    Bitmap bitmap = (Bitmap) TargetImageViewer.BackgroundImage;
                    
                    // save the file
                    bitmap.Save(fileName);

                    // Show the user a message
                    MessageBox.Show("The target database has been saved.", "Saved");
                }
            }
            #endregion
            
        #endregion

        #region Methods

            #region Callback(string message, int pixelsUpdated)
            /// <summary>
            /// This method Refresh
            /// </summary>
            public void Callback(string message, int pixelsUpdated)
            {
                // Refresh everythihng
                this.Refresh();
                Application.DoEvents();
            }
        #endregion

            #region Init()
            /// <summary>
            /// This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Load our items
                this.OrientationControl.LoadItems(typeof(OrientationEnum));

                // Select the first item
                this.OrientationControl.SelectedIndex = 0;

                // Setup the listeners
                this.SliceImageControl.OnTextChangedListener = this;
                this.TargetImageControl.OnTextChangedListener = this;
                this.NumberSlicesControl.OnTextChangedListener = this;

                // Set Defaults
                this.MinValueControl.Text = "1";
                this.MaxValueControl.Text = "86";
                this.StartXControl.Text = "0";
                this.StartYControl.Text = "0";
            }
            #endregion

        #endregion

        #region Properties

            #region HasOutputPath
            /// <summary>
            /// This property returns true if the 'OutputPath' exists.
            /// </summary>
            public bool HasOutputPath
            {
                get
                {
                    // initial value
                    bool hasOutputPath = (!String.IsNullOrEmpty(this.OutputPath));
                    
                    // return value
                    return hasOutputPath;
                }
            }
            #endregion
            
            #region HasSliceDatabase
            /// <summary>
            /// This property returns true if this object has a 'SliceDatabase'.
            /// </summary>
            public bool HasSliceDatabase
            {
                get
                {
                    // initial value
                    bool hasSliceDatabase = (this.SliceDatabase != null);
                    
                    // return value
                    return hasSliceDatabase;
                }
            }
            #endregion
            
            #region HasSliceImagePath
            /// <summary>
            /// This property returns true if the 'SliceImagePath' exists.
            /// </summary>
            public bool HasSliceImagePath
            {
                get
                {
                    // initial value
                    bool hasSliceImagePath = (!String.IsNullOrEmpty(this.SliceImagePath));
                    
                    // return value
                    return hasSliceImagePath;
                }
            }
            #endregion
            
            #region HasTargetDatabase
            /// <summary>
            /// This property returns true if this object has a 'TargetDatabase'.
            /// </summary>
            public bool HasTargetDatabase
            {
                get
                {
                    // initial value
                    bool hasTargetDatabase = (this.TargetDatabase != null);
                    
                    // return value
                    return hasTargetDatabase;
                }
            }
            #endregion
            
            #region HasTargetImagePath
            /// <summary>
            /// This property returns true if the 'TargetImagePath' exists.
            /// </summary>
            public bool HasTargetImagePath
            {
                get
                {
                    // initial value
                    bool hasTargetImagePath = (!String.IsNullOrEmpty(this.TargetImagePath));
                    
                    // return value
                    return hasTargetImagePath;
                }
            }
            #endregion
            
            #region NumberSlices
            /// <summary>
            /// This property gets or sets the value for 'NumberSlices'.
            /// </summary>
            public int NumberSlices
            {
                get { return numberSlices; }
                set { numberSlices = value; }
            }
            #endregion
            
            #region OutputPath
            /// <summary>
            /// This property gets or sets the value for 'OutputPath'.
            /// </summary>
            public string OutputPath
            {
                get { return outputPath; }
                set { outputPath = value; }
            }
            #endregion
            
            #region SliceDatabase
            /// <summary>
            /// This property gets or sets the value for 'SliceDatabase'.
            /// </summary>
            public PixelDatabase SliceDatabase
            {
                get { return sliceDatabase; }
                set { sliceDatabase = value; }
            }
            #endregion
            
            #region SliceImagePath
            /// <summary>
            /// This property gets or sets the value for 'SliceImagePath'.
            /// </summary>
            public string SliceImagePath
            {
                get { return sliceImagePath; }
                set { sliceImagePath = value; }
            }
            #endregion
            
            #region TargetDatabase
            /// <summary>
            /// This property gets or sets the value for 'TargetDatabase'.
            /// </summary>
            public PixelDatabase TargetDatabase
            {
                get { return targetDatabase; }
                set { targetDatabase = value; }
            }
            #endregion
            
            #region TargetImagePath
            /// <summary>
            /// This property gets or sets the value for 'TargetImagePath'.
            /// </summary>
            public string TargetImagePath
            {
                get { return targetImagePath; }
                set { targetImagePath = value; }
            }
        #endregion

        #endregion

    }
    #endregion

}
