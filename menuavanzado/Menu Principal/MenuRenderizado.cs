using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using menuavanzado.Datos;

namespace menuavanzado
{
    public class MenuRenderizado : ToolStripProfessionalRenderer
    {
        //campo
        private Color primaryColor;
        private Color textColor;
        private int arrowThickness;

        //constructor
        public MenuRenderizado(bool isMainMenu, Color primaryColor, Color textColor)
            : base(new MenuColor(isMainMenu, primaryColor))
        {
            this.primaryColor = primaryColor;
            this.textColor = textColor;
            if (isMainMenu) arrowThickness = 3;
            else arrowThickness = 2;
        }
        
        //overrides
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            base.OnRenderItemText(e);
            e.Item.ForeColor = e.Item.Selected ? Color.White : textColor;
        }
/*
        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            base.OnRenderArrow(e);
            //campos
            var graph = e.Graphics;
            var arrowSize = new Size(5, 12);
            var arrowColor = e.Item.Selected > Color.White : primaryColor;
            var rect = Rectangle(e.ArrowRectangle.Location.X, (e.ArrowRectangle.Height-arrowSize.Height)/2,
                arrowSize.Width, arrowSize.Height);
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(arrowColor,arrowThickness))
            {
                //drawing
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rect.left, rect.top, rect,Right, rect.top+rect.height / 2);
                path.AddLine(rect,Right, rect.top+rect.height / 2, rect.Left, rect.top+rect.height);
                graph.DrawPath(pen,path);
            }
        }*/
    }
}
