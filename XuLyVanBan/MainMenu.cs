using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace XuLyVanBan
{
    public partial class MainMenu : Form
    {
        //private string INPUTFILE = Directory.GetCurrentDirectory() + @"\MauVanBan\Mau van ban0001.pdf";
        //private string OUTPUTFILE = @"C:\Users\LamPT\Desktop\Mau001.pdf";
        //private string STAMPFILE = Directory.GetCurrentDirectory() + @"\MauVanBan\Mau van ban0001 - 2.pdf";
        
        public MainMenu()
        {
            InitializeComponent();
            //this.Icon = new Icon(Directory.GetCurrentDirectory() + @"\icon.ico");
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            // Set the MinimizeBox to false to remove the minimize box.
            //this.MinimizeBox = false;
            // Set the start position of the form to the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen; 
        }

        public void clean()
        {
            //panel1.Controls.Clear();
        }
        private void mẫu001ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = null;
            panel1.Controls.Clear();
            Mau001 mau001 = new Mau001();
            mau001.Dock = DockStyle.Fill;
            mau001.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            panel1.Controls.Add(mau001);
            btnclear.Show();
        }

        private void mẫu002ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panel1.BackgroundImage = null;
            //btnclear.Show();
            //panel1.Controls.Clear();
            //Mau002 mau002 = new Mau002();
            //mau002.Dock = DockStyle.Fill;
            //mau002.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            //panel1.Controls.Add(mau002);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panel1.BackgroundImage = null;
            //btnclear.Show();
            //panel1.Controls.Clear();
            //Mau003 mau003 = new Mau003();
            //mau003.Dock = DockStyle.Fill;
            //mau003.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            //panel1.Controls.Add(mau003);
        }

        private void mẫu04ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panel1.BackgroundImage = null;
            //btnclear.Show();
            //panel1.Controls.Clear();
            //Mau004 mau004 = new Mau004();
            //mau004.Dock = DockStyle.Fill;
            //mau004.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            //panel1.Controls.Add(mau004);
        }

        private void mẫu05ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panel1.BackgroundImage = null;
            //btnclear.Show();
            //panel1.Controls.Clear();
            //Mau005 mau005 = new Mau005();
            //mau005.Dock = DockStyle.Fill;
            //mau005.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            //panel1.Controls.Add(mau005);
        }

        private void mẫu06GiấyỦyQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panel1.BackgroundImage = null;
            //btnclear.Show();
            //panel1.Controls.Clear();
            //Mau006 mau006 = new Mau006();
            //mau006.Dock = DockStyle.Fill;
            //mau006.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            //panel1.Controls.Add(mau006);
        }

        private void mẫu07GiấyMờiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panel1.BackgroundImage = null;
            //btnclear.Show();
            //panel1.Controls.Clear();
            //Mau007 mau007 = new Mau007();
            //mau007.Dock = DockStyle.Fill;
            //mau007.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            //panel1.Controls.Add(mau007);
        }

        private void mẫu08GiấyGiớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panel1.BackgroundImage = null;
            //btnclear.Show();
            //panel1.Controls.Clear();
            //Mau008 mau008 = new Mau008();
            //mau008.Dock = DockStyle.Fill;
            //mau008.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            //panel1.Controls.Add(mau008);
        }

        private void mẫu10ChỉThịLiênTịchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panel1.BackgroundImage = null;
            //btnclear.Show();
            //panel1.Controls.Clear();
            //Mau010 mau010 = new Mau010();
            //mau010.Dock = DockStyle.Fill;
            //mau010.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            //panel1.Controls.Add(mau010);
        }

        private void mẫu11ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //panel1.BackgroundImage = null;
            //btnclear.Show(); panel1.Controls.Clear();
            //Mau011 mau011 = new Mau011();
            //mau011.Dock = DockStyle.Fill;
            //mau011.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            //panel1.Controls.Add(mau011);
        }

        private void mẫu12TờTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //panel1.BackgroundImage = null;
            //btnclear.Show(); panel1.Controls.Clear();
            //Mau012 mau012 = new Mau012();
            //mau012.Dock = DockStyle.Fill;
            //mau012.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            //panel1.Controls.Add(mau012);
        }

        private void mẫu13PhiếuChuyểnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panel1.BackgroundImage = null;
            //btnclear.Show();
            //panel1.Controls.Clear();
            //Mau013 mau013 = new Mau013();
            //mau013.Dock = DockStyle.Fill;
            //mau013.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            //panel1.Controls.Add(mau013);
        }

        private void mẫu14PhiếuGửiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panel1.BackgroundImage = null;
            //btnclear.Show();
            //panel1.Controls.Clear();
            //Mau014 mau014 = new Mau014();
            //mau014.Dock = DockStyle.Fill;
            //mau014.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            //panel1.Controls.Add(mau014);
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            //btnclear.Hide();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            
            //panel1.Controls.Clear();
            //btnclear.Hide();
        }

        private void mẫu09GiấyĐiĐườngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panel1.BackgroundImage = null;
            //btnclear.Show();
            //panel1.Controls.Clear();
            //Mau009 mau009 = new Mau009();
            //mau009.Dock = DockStyle.Fill;
            //mau009.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            //panel1.Controls.Add(mau009);
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần mềm được phát triển bởi: \nMai Văn Thủy \nCông ty TNHH iSolar \nViện Công nghệ Thông tin \nViện Hàn Lâm KH & CN Việt Nam", "Thông tin phần mềm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r1 = MessageBox.Show("- Nhấn OK hoặc ESC để thoát !!! \n- Nhấn Help để được trợ giúp !!!",
                                   "Thông tin trợ giúp", MessageBoxButtons.OK,
                                   MessageBoxIcon.Question,
                                   MessageBoxDefaultButton.Button1,
                                   0,
                                   Directory.GetCurrentDirectory() + @"\Help\Help.chm");
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này đang được phát triển, chúng tôi sẽ cập nhật khi có phiên bản mới nhất. Xin cảm ơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
