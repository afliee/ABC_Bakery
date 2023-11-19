using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using ABC_Bakery.Helpers.Constants;
using Color = System.Drawing.Color;
using Image = System.Drawing.Image;
using RectangleF = System.Drawing.RectangleF;

namespace ABC_Bakery.Helpers.UI
{
    internal class DatetimePickerCustom : DateTimePicker
    {
        //Fields
        //-> Appearance
        private Color skinColor = ColorTranslator.FromHtml(Constants.Colors.Primary);
        private Color textColor = System.Drawing.Color.White;
        private Color borderColor = ColorTranslator.FromHtml(Constants.Colors.Primary);
        private int borderSize = 3;

        //-> Other Values
        private bool droppedDown = false;
        private Image calendarIcon = Properties.Resources.calendarWhite;
        private RectangleF iconButtonArea;
        private const int calendarIconWidth = 34;
        private const int arrowIconWidth = 17;

        //Properties
        public Color SkinColor
        {
            get { return skinColor; }
            set
            {
                skinColor = value;
                if (skinColor.GetBrightness() >= 0.8F)
                    calendarIcon = Properties.Resources.calendarDark;
                else calendarIcon = Properties.Resources.calendarWhite;
                this.Invalidate();
            }
        }

        public Color TextColor
        {
            get { return textColor; }
            set
            {
                textColor = value;
                this.Invalidate();
            }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        public DatetimePickerCustom()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.MinimumSize = new System.Drawing.Size(0, 50);
            this.Font = new Font(this.Font.Name, 9.5F);
        }

        //Overridden methods
        protected override void OnDropDown(EventArgs eventargs)
        {
            base.OnDropDown(eventargs);
            droppedDown = true;
        }
        protected override void OnCloseUp(EventArgs eventargs)
        {
            base.OnCloseUp(eventargs);
            droppedDown = false;
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = true;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            using (Graphics graphics = this.CreateGraphics())
            using (Pen penBorder = new Pen(borderColor, borderSize))
            using (SolidBrush skinBrush = new SolidBrush(skinColor))
            using (SolidBrush openIconBrush = new SolidBrush(Color.FromArgb(50, 64, 64, 64)))
            using (SolidBrush textBrush = new SolidBrush(textColor))
            using (StringFormat textFormat = new StringFormat())
            {
                //Set up
                textFormat.Alignment = StringAlignment.Near;

                RectangleF clientArea = new RectangleF(0, 0, this.Width - 0.5F, this.Height - 0.5F);
                RectangleF iconArea = new RectangleF(clientArea.Width - calendarIconWidth, 0, calendarIconWidth, clientArea.Height);
                penBorder.Alignment = PenAlignment.Inset;
                textFormat.LineAlignment = StringAlignment.Center;

                //Draw surface
                graphics.FillRectangle(skinBrush, clientArea);
                //Draw text
                graphics.DrawString("   " + this.Text, this.Font, textBrush, clientArea, textFormat);
                //Draw open calendar icon highlight
                if (droppedDown == true) graphics.FillRectangle(openIconBrush, iconArea);
                //Draw border 
                if (borderSize >= 1) graphics.DrawRectangle(penBorder, clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height);
                //Draw icon
               graphics.DrawImage(calendarIcon, this.Width - calendarIcon.Width - 9, (this.Height - calendarIcon.Height) / 2);


            }
        }
        private int GetIconButtonWidth()
        {
            int textWidh = TextRenderer.MeasureText(this.Text, this.Font).Width;
            if (textWidh <= this.Width - (calendarIconWidth + 20))
                return calendarIconWidth;
            else return arrowIconWidth;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            int iconWidth = GetIconButtonWidth();
            iconButtonArea = new RectangleF(this.Width - iconWidth, 0, iconWidth, this.Height);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (iconButtonArea.Contains(e.Location))
                this.Cursor = Cursors.Hand;
            else this.Cursor = Cursors.Default;
        }
    }
}
