using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace WindowsFormsApplication1
{
    class common
    {
        //đường dẫn tới folder ảnh trong debug
        public static string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Picture\";

        //thêm cột hình ảnh


        public static void HidePanels(Panel pn)
        {
            foreach (Control c in pn.Controls)
            {
                if (c is Panel)
                {
                    c.Visible = false;
                }
            }
        }


        //load lại cột hình ảnh(đã thêm cột hình ảnh) sau mọi lần tìm kiếm
      
       
        //clear tất cả textbox, checkbox, radiobutton, picturebox
        public static void ClearTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }

                if (c.HasChildren)
                {
                    ClearTextBoxes(c);
                }

                if (c is CheckBox)
                {

                    ((CheckBox)c).Checked = false;
                }

                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }

                if (c is PictureBox)
                    ((PictureBox)c).Image = null;
            }
        }
        public static void ClearOnlyTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                if (c.HasChildren)
                {
                    ClearOnlyTextBoxes(c);
                }

            }
        }

        //chỉnh lại kích thước ảnh
     

        //copy vo clipboard
       

        //kt số nếu không phải return -1
        public static int ktint(string so)
        {
            int a = 0;
            if (int.TryParse(so, out a))
            {
                return a;
            }
            return -1;
        }
      
    }
}
