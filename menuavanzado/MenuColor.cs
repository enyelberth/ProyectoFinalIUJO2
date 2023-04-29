using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using menuavanzado.Datos;

namespace menuavanzado
{
    public class MenuColor: ProfessionalColorTable
    {
        //campos
        private Color backcolor;
        private Color leftColumnColor;
        private Color borderColor;
        private Color menuItemBordeColor;
        private Color MenuItemSelectedColor;

        //constructor
        public MenuColor(bool isMainMenu, Color primaryColor)
        {
            if (isMainMenu)
            {
              //  backcolor = Color.FromArgb();
                //leftColumnColor = Color.FromArgb();
                //borderColor = Color.FromArgb();
                //menuItemBordeColor = primaryColor;
                MenuItemSelectedColor = primaryColor;
            }/*
            else
            {
                backcolor = Color.White;
                leftColumnColor = Color.LightGray;
                borderColor = Color.LightGray;
                menuItemBordeColor = primaryColor;
                MenuItemSelectedColor = primaryColor;
            }
        }

        public override Color ToolStripDropDownBackground
        {
            get
            {
                return backcolor;
            }
        }

        public override Color MenuBorder
        {
            get
            {
                return borderColor;
            }
        }
        public override Color MenuItemBorder
        {
            get
            {
                return menuItemBordeColor;
            }
        }

        public override Color MenuItemSelected
        {
            get
            {
                return MenuItemSelectedColor;
            }
        }

        public override Color ImageMarginGradientBegin
        {
            get
            {
                return leftColumnColor;
            }
        }

        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return leftColumnColor;
            }
        }

        public override Color ImageMarginGradientEnd
        {
            get
            {
                return leftColumnColor;
            }*/
        }
    }
}
