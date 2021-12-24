using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;

namespace ManagementCenter.CustomControl
{
    class CustomGridImageEdit : GridImageEditControl
    {
        public CustomGridImageEdit()
        {
            Init();
        }

        private void Init()
        {
            this.ImageSizeMode = ImageSizeMode.CenterImage;
        }
    }
}
