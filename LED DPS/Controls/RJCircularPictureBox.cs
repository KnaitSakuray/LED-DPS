using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LED_DPS.RJControls
{
    public class RJCircularPictureBox : PictureBox
    {
        /// <summary>
        /// This class inherits from the <see cref = "PictureBox" /> class
        /// In this class you simply create a circular image box using the <see cref = "Region" /> property
        /// and the <see cref = "GraphicsPath" /> class to draw the contours of the shape, fill the interior of the shape,
        /// and create clipping regions.
        /// </summary>
        ///

        #region -> Constructor
        public RJCircularPictureBox()
        {
            this.Size = new Size(100, 100); // Default size
            this.SizeMode = PictureBoxSizeMode.StretchImage; // The image inside the PictureBox is stretched or shrunk to fit the size of the PictureBox.
            this.SizeChanged += new EventHandler(PictureBox_SizeChanged); // Occurs when the size of the control changes.
            this.Paint += new PaintEventHandler(PictureBox_Paint); // Occurs when the control is drawn.
        }
        #endregion

        #region -> Event methods
        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            using (GraphicsPath graphicsPath = new GraphicsPath()) // Initialize a new instance of the GraphicsPath class
            {
                /// <summary>
                /// Initializes a new instance of the <see cref = "Rectangle" /> structure with the specified location and size
                /// in this case, the following parameters set the following:
                /// <param name = "int x"> The x coordinate of the upper left corner of the bounding rectangle that defines the ellipse. </param>
                /// <param name = "int y"> The y coordinate of the upper left corner of the bounding rectangle that defines the ellipse. </param>
                /// <param name = "int widht"> The width of the bounding rectangle that defines the ellipse. </param>
                /// <param name = "int height"> The height of the bounding rectangle that defines the ellipse. </param>
                /// </summary>
                var rectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1); /// Creates a rectangle the same size as the control to enclose an ellipse (subtract border size)
                graphicsPath.AddEllipse(rectangle); // Add an ellipse with the dimensions of the rectangle.
                this.Region = new Region(graphicsPath); // Set a new region to the control with the elliptic chart path - basically converts the shape of the control into the created circle.

                /// PaintEventArgs- draw the border of the control to have a good quality of the circular image box.
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // Set the rendering quality (Smoothing)
                var pen = new Pen(new SolidBrush(this.BackColor), 1); // Create a pen of the same background color
                e.Graphics.DrawEllipse(pen, rectangle); // Draw the ellipse as the border of the control.
            }
        }
        private void PictureBox_SizeChanged(object sender, EventArgs e)
        {
            // The size must be the same width and height (perfect circle).
            this.Size = new Size(this.Size.Width, this.Size.Width);
        }

        #endregion
    }
}
