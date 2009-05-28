using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SoftwareTelephone
{
    class ProcessListBox : ListBox
    {
        public ProcessListBox()
            : base()
        {
            base.DrawMode = DrawMode.OwnerDrawFixed;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);

            if (!this.DesignMode)
            {
                Rectangle currentBounds = e.Bounds;

                //                if (this.drawMode == DrawMode.Normal)
                {
                    e.DrawBackground();
                    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                        e.DrawFocusRectangle();
                }

                currentBounds.Width = 100;
                IPlugin CurrentItem = (IPlugin)Items[ e.Index ];
                e.Graphics.DrawString(CurrentItem.ToString(), e.Font, new SolidBrush(e.ForeColor), currentBounds);
                currentBounds.X += currentBounds.Width;
                e.Graphics.DrawString(CurrentItem.Output, e.Font, new SolidBrush(e.ForeColor), currentBounds);
                /*
                PropertyDescriptorCollection pdc = this.DataManager.GetItemProperties();

                for (int currentColumnIndex = 0; currentColumnIndex < realColumnCount; currentColumnIndex++)
                {
                    currentBounds.Width = ColumnWidths[currentColumnIndex];
                    e.Graphics.SetClip(currentBounds);
                    OnDrawSubItem(new DrawSubItemEventArgs(e.Graphics, e.Font, currentBounds, e.Index, currentColumnIndex, pdc[currentColumnIndex], e.State));
                    currentBounds.X += currentBounds.Width
                }*/
            }
        }
        /*
        protected virtual void OnDrawSubItem(DrawSubItemEventArgs e)
        {
            object value = this.GetItemAt(e.Index, e.SubIndex);
            if (DrawMode == DrawMode.Normal && Items.Count > 0)
            {
                if ((value as Image) != null)
                    e.Graphics.DrawImageUnscaled((Image)value, e.Bounds);
                else if ((value as Bitmap) != null)
                {
                    IntPtr hBmp = ((Bitmap)value).GetHbitmap();
                    e.Graphics.DrawImageUnscaled(Image.FromHbitmap(hBmp), e.Bounds);
                    WinAPI.DeleteObject(hBmp);
                }
                else if ((value as byte[]) != null)
                {
                    try
                    {
                        e.Graphics.DrawImageUnscaled(Image.FromStream(new MemoryStream((byte[])value)), e.Bounds);
                    }

                    catch (Exception ex)
                    {
                        defaultDraw(value, e);
                    }
                }
                else
                    defaultDraw(value, e);
            }
            else if (DrawSubItem.GetInvocationList() != null)
                DrawSubItem.DynamicInvoke(new object[] { this, e });
        }*/
    }
}
