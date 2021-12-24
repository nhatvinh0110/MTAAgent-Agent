using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace ManagementCenter.CustomControl
{
    public enum RadialAction { Rename, Delete, Detail, Network, Event }
    public enum RadialActionRoom { Edit, Delete }
    public class CustomRadiaMenu : GridRadialMenuEditControl
    {
        public CustomRadiaMenu()
        {
            SetRadialMenu();
        }

        #region SetRadialMenu

        private void SetRadialMenu()
        {
            Symbol = "\uf085";
            SymbolSize = 13;
            Diameter = 190;

            RadialMenuItem item;

            item = new RadialMenuItem();
            item.Tag = RadialAction.Network;
            item.Text = Constant.NetworkConnection_vi;
            item.Symbol = "\uf1e6";
            this.Items.Add(item);

            item = new RadialMenuItem();
            item.Tag = RadialAction.Detail;
            item.Text = Constant.Detail_vi;
            item.Symbol = "\uf0ca";
            this.Items.Add(item);

            item = new RadialMenuItem();
            item.Tag = RadialAction.Delete;
            item.Text = Constant.Del_vi;
            item.Symbol = "\uf00d";
            this.Items.Add(item);

            item = new RadialMenuItem();
            item.Tag = RadialAction.Rename;
            item.Text = Constant.Rename_Room_vi;
            item.Symbol = "\uf044";
            this.Items.Add(item);

            item = new RadialMenuItem();
            item.Tag = RadialAction.Event;
            item.Text = Constant.Event_vi;
            item.Symbol = "\uf022";
            this.Items.Add(item);


        }

        #endregion

        #region InitializeContext

        public override void InitializeContext(GridCell cell, CellVisualStyle style)
        {
            base.InitializeContext(cell, style);

            if (style != null)
            {
                Symbol = "\uf085";
                Colors.RadialMenuButtonBackground = Color.LightGray;
                Colors.RadialMenuButtonBorder = Color.Black;

            }
        }

        #endregion
    }


    public class CustomRadiaMenuRoom : GridRadialMenuEditControl
    {
        public CustomRadiaMenuRoom()
        {
            SetRadialMenu();
        }

        #region SetRadialMenu

        private void SetRadialMenu()
        {
            Symbol = "\uf085";
            SymbolSize = 13;
            Diameter = 190;

            RadialMenuItem item;

            item = new RadialMenuItem();
            item.Tag = RadialActionRoom.Delete;
            item.Text = Constant.Del_vi;
            item.Symbol = "\uf00d";
            this.Items.Add(item);


            item = new RadialMenuItem();
            this.Items.Add(item);

            item = new RadialMenuItem();
            item.Tag = RadialActionRoom.Edit;
            item.Text = Constant.Edit_vi;
            item.Symbol = "\uf044";
            this.Items.Add(item);


            item = new RadialMenuItem();
            this.Items.Add(item);


        }

        #endregion

        #region InitializeContext

        public override void InitializeContext(GridCell cell, CellVisualStyle style)
        {
            base.InitializeContext(cell, style);

            if (style != null)
            {
                Symbol = "\uf085";
                Colors.RadialMenuButtonBackground = Color.LightGray;
                Colors.RadialMenuButtonBorder = Color.Black;

            }
        }

        #endregion
    }

}
