using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace OptikLaboratory.SealedNotes
{
    public class ImageButton : Control
    {
        #region Private Variables
        private Image image;
        private Image image_pushed;
        private bool bPushed;
        private Bitmap m_bmpOffscreen;
        #endregion

        #region Public Properties
        public Image Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
            }
        }

        public Image Image_pushed
        {
            get
            {
                return image_pushed;
            }
            set
            {
                image_pushed = value;
            }
        }
        #endregion

        #region Standard Constructor
        public ImageButton()
        {
            bPushed = false;
            //default minimal size
            this.Size = new Size(21, 21);
        }
        #endregion

        #region Protected Handlers
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            Graphics gxOff;	   //Offscreen graphics
            Rectangle imgRect; //image rectangle
            Brush backBrush;   //brush for filling a backcolor

            if (m_bmpOffscreen == null) //Bitmap for doublebuffering
            {
                m_bmpOffscreen = new Bitmap(ClientSize.Width, ClientSize.Height);
            }

            gxOff = Graphics.FromImage(m_bmpOffscreen);

            gxOff.Clear(this.BackColor);

            //if (!bPushed)
                backBrush = new SolidBrush(Parent.BackColor);
            //else //change the background when it's pressed
            //    backBrush = new SolidBrush(Color.LightGray);

            gxOff.FillRectangle(backBrush, this.ClientRectangle);

            if (bPushed == false && image != null)
            {
                //Center the image relativelly to the control
                int imageLeft = (this.Width - image.Width) / 2;
                int imageTop = (this.Height - image.Height) / 2;

                //if (!bPushed)
                //{
                    imgRect = new Rectangle(imageLeft, imageTop, image.Width, image.Height);
                //}
                //else //The button was pressed
                //{
                //    //Shift the image by one pixel
                //    imgRect = new Rectangle(imageLeft + 1, imageTop + 1, image.Width, image.Height);
                //}
                //Set transparent key
                ImageAttributes imageAttr = new ImageAttributes();
                imageAttr.SetColorKey(BackgroundImageColor(image), BackgroundImageColor(image));
                //Draw image
                gxOff.DrawImage(image, imgRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttr);
            }
            else if (bPushed == true && image_pushed != null)
            {
                //Center the image relativelly to the control
                int imageLeft = (this.Width - image_pushed.Width) / 2;
                int imageTop = (this.Height - image_pushed.Height) / 2;
                imgRect = new Rectangle(imageLeft, imageTop, image_pushed.Width, image_pushed.Height);
                //Set transparent key
                ImageAttributes imageAttr = new ImageAttributes();
                imageAttr.SetColorKey(BackgroundImageColor(image_pushed), BackgroundImageColor(image_pushed));
                //Draw image
                gxOff.DrawImage(image_pushed, imgRect, 0, 0, image_pushed.Width, image_pushed.Height, GraphicsUnit.Pixel, imageAttr);
            }

            //if (bPushed) //The button was pressed
            //{
            //    //Prepare rectangle
            //    Rectangle rc = this.ClientRectangle;
            //    rc.Width--;
            //    rc.Height--;
            //    //Draw rectangle
            //    gxOff.DrawRectangle(new Pen(Color.Black), rc);
            //}

            //Draw from the memory bitmap
            e.Graphics.DrawImage(m_bmpOffscreen, 0, 0);

            base.OnPaint(e);
        }

        protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs e)
        {
            //Do nothing
        }

        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            bPushed = true;
            this.Invalidate();
        }

        protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e)
        {
            bPushed = false;
            this.Invalidate();
        }
        #endregion

        #region Private Methods
        private Color BackgroundImageColor(Image image)
        {
            Bitmap bmp = new Bitmap(image);
            return bmp.GetPixel(0, 0);
        }
        #endregion
    }
}
