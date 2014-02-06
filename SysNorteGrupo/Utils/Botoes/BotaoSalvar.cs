using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SysNorteGrupo.Utils
{
    public class BotaoSalvar : Button
    {
        public BotaoSalvar()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor |
                      ControlStyles.Opaque |
                      ControlStyles.ResizeRedraw |
                      ControlStyles.OptimizedDoubleBuffer |
                      ControlStyles.CacheText, // We gain about 2% in painting by avoiding extra GetWindowText calls
                      true);

            //this.colorTable = new Colortable();

            //this.MouseLeave += new EventHandler(_MouseLeave);
            //this.MouseDown += new MouseEventHandler(_MouseDown);
            //this.MouseUp += new MouseEventHandler(_MouseUp);
            //this.MouseMove += new MouseEventHandler(_MouseMove);

            this.Image = global::SysNorteGrupo.Properties.Resources.save;
            this.Size = new System.Drawing.Size(93, 31);
            this.ImageAlign = ContentAlignment.MiddleLeft;
            this.TextAlign = ContentAlignment.MiddleRight;
            this.ForeColor = Color.White;
            this.BackColor = Color.FromArgb(0, 117, 199);
            this.Font = new Font("Segoe UI Light", 12, FontStyle.Regular);
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        }

        protected void PaintTransparentBackground(Graphics g, Rectangle clipRect)
        {
            // check if we have a parent
            if (this.Parent != null)
            {
                // convert the clipRects coordinates from ours to our parents
                clipRect.Offset(this.Location);

                PaintEventArgs e = new PaintEventArgs(g, clipRect);

                // save the graphics state so that if anything goes wrong 
                // we're not fubar
                GraphicsState state = g.Save();

                try
                {
                    // move the graphics object so that we are drawing in 
                    // the correct place
                    g.TranslateTransform((float)-this.Location.X, (float)-this.Location.Y);

                    // draw the parents background and foreground
                    this.InvokePaintBackground(this.Parent, e);
                    this.InvokePaint(this.Parent, e);

                    return;
                }
                finally
                {
                    // reset everything back to where they were before
                    g.Restore(state);
                    clipRect.Offset(-this.Location.X, -this.Location.Y);
                }
            }

            // we don't have a parent, so fill the rect with
            // the default control color
            g.FillRectangle(SystemBrushes.Control, clipRect);
        }

    }
}
