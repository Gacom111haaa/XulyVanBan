using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;


namespace XuLyVanBan
{
    public partial class Mau001 : UserControl
    {
        public Mau001()
        {
            InitializeComponent();
            //dataString = new DataString();
            //textBoxNgay.Text = DateTime.Now.Day.ToString();
            //textBoxThang.Text = DateTime.Now.Month.ToString();
            //textBoxNam.Text = DateTime.Now.Year.ToString();
            //int ngay = int.Parse(textBoxNgay.Text.ToString());
            //int thang = int.Parse(textBoxThang.Text.ToString());
            //int nam = int.Parse(textBoxNam.Text.ToString());
            //dtpngay.Value = new DateTime(nam, thang, ngay);
           
        }

        int clickkt1 = 0, clickkt2 = 0, clickkt3 = 0, clickkt4 = 0, clickkt5 = 0, clickkt6 = 0, clickkt7 = 0, clickkt8 = 0, clickkt9 = 0, clickkt10 = 0, clickkt11 = 0, clickkt13 = 0, clickkt14 = 0;
        public void Progress()
        {
            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */
                                             //Start Word and create a new document.
            Microsoft.Office.Interop.Word._Application oWord = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word._Document oDoc = new Microsoft.Office.Interop.Word.Document();
            //oWord.Visible = true;
            oDoc = oWord.Documents.Add();
            object start = 0;
            object end = 0;
            var paragraph1 = oDoc.Content.Paragraphs.Add();


            Range tableLocation =new Range(ref start, ref end);
            Tables.Add(tableLocation, 3, 4);

            paragraph1.Range.Text = "Heading 1";
            paragraph1.Range.Font.Bold = 1;
            paragraph1.Format.SpaceAfter = 24;    //24 pt spacing after paragraph.
            paragraph1.

            oDoc.SaveAs2(@"C:\Users\MaiThuy\Desktop\TestDocumentWith1Paragraph.docx");

            oWord.Quit();

        }

        private void Range(ref object start, ref object end)
        {
            throw new NotImplementedException();
        }

        // kiem tra loi nhap
        private int loinhap()
        {
            int j = 0;
            ////return j;
            try
            {               
                if (clickkt1==0||textBoxQDSo.Text == "")
                {
                    MessageBox.Show("Nhập số văn bản!", "Chú ý");
                    j = 1;
                }

                else if (ktngay(textBoxNgay.Text.ToString()) == 1)
                {
                    MessageBox.Show("Ngày phải lớn hơn 0 và nhỏ hơn 31!", "Chú ý");
                    j = 1;
                }

                else if (ktthang(textBoxThang.Text.ToString()) == 1)
                {
                    MessageBox.Show("Tháng phải lớn hơn 0 và nhỏ hơn 12!", "Chú ý");
                    j = 1;
                }

                else if (ktnam(textBoxNam.Text.ToString()) == 1)
                {
                    MessageBox.Show("Năm phải nhập 4 chữ số!", "Chú ý");
                    j = 1;
                }
                else if (clickkt2 == 0 || textBoxVeViec.Text == "")
                {
                    MessageBox.Show("Nhập quyết định về việc!", "Chú ý");
                    j = 1;
                }
                else if (clickkt3 == 0 || textBoxCanCu1.Text == "")
                {
                    MessageBox.Show("Nhập căn cứ 1!", "Chú ý");
                    j = 1;
                }
                else if (clickkt4 == 0 || textBoxCanCu2.Text == "")
                {
                    MessageBox.Show("Nhập căn cứ 2!", "Chú ý");
                    j = 1;
                }
                else if (clickkt5 == 0 || textBoxTheoDeNghi.Text == "")
                {
                    MessageBox.Show("Nhập theo đề nghị!", "Chú ý");
                    j = 1;
                }
                else if (clickkt6 == 0 || textBoxDieu1.Text == "")
                {
                    MessageBox.Show("Nhập điều khoản 1!", "Chú ý");
                    j = 1;
                }
                else if (clickkt7 == 0 || textBoxdieu2.Text == "")
                {
                    MessageBox.Show("Nhập điều 2!", "Chú ý");
                    j = 1;
                }
                else if (clickkt8 == 0 || textBoxDieu3.Text == "")
                {
                    MessageBox.Show("Nhập điều 3!", "Chú ý");
                    j = 1;
                }
                else if (clickkt9 == 0 || textBoxNoiNhan.Text == "")
                {
                    MessageBox.Show("Nhập nơi nhận!", "Chú ý");
                    j = 1;
                }
                else if (clickkt11 == 0 || textBoxQuyenHanNguoiKi.Text == "")
                {
                    MessageBox.Show("Chọn quyền hạn người ký!", "Chú ý");
                    j = 1;
                }

                else if (clickkt13 == 0 || textBoxHoTenNguoiKi.Text == "")
                {
                    MessageBox.Show("Nhập họ tên người ký!", "Chú ý");
                    j = 1;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
            }


            return j;
        }

        private void buttonProgress_Click(object sender, EventArgs e)
        {
            Progress();
            //int i =loinhap();
            //if (i == 0)
            //{
            //    if (MessageBox.Show("Bạn muốn lưu thành file lại không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        Progress();
                    
            //        SaveFileDialog open = new SaveFileDialog();
                    
            //        open.Filter = "Word files (*.doc)|*.docx";
            //        //FileInfo fileInfo = new FileInfo(OUTPUTFILE);
            //        //open.FileName = "";// fileInfo.Name.Replace(".pdf", "");
            //        if (open.ShowDialog() == DialogResult.OK)
            //        {
            //            string pathSave = open.FileName;
            //            //oDoc.SaveAs(pathSave, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing);
            //        }


            //    }
            //}
        }

        private void dtpngay_ValueChanged(object sender, EventArgs e)
        {

            textBoxNgay.Text = dtpngay.Value.Date.Day.ToString("00");
            textBoxThang.Text = dtpngay.Value.Date.Month.ToString("00");
            textBoxNam.Text = dtpngay.Value.Date.Year.ToString("0000");
        }

       
        //xu ly hieu luc ngay-----------------------------------------------
     
        // xu ly ngay quyet dinh truoc-------------------------------------
        
        //-------------------------------------------------------------------
       
        //-------------------------------------------------------------------
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private int ktngay(string j)
        {
            int kt = 0;
            int n = int.Parse(j);
            if(n>31||n<1)
            {
                kt = 1;
            }
            return kt;
        }
        private int ktthang(string j)
        {
            int kt = 0;
            int n = int.Parse(j);
            if (n > 12 || n < 1)
            {
                kt = 1;
            }
            return kt;
        }
        private int ktnam(string j)
        {
            int kt = 0;
            int n = int.Parse(j);
            if (n > 9999 || n < 1000)
            {
                kt = 1;
            }
            return kt;
        }
       //====================================================================


        

        private void textBoxQDSo_Click(object sender, EventArgs e)
        {
            
            if (clickkt1 == 0)
            {
                textBoxQDSo.Text = "";
                textBoxQDSo.ForeColor = System.Drawing.Color.Black;
                clickkt1++;
            }
            
        }

        

        
        private void textBoxVeViec_Click(object sender, EventArgs e)
        {
            
            if (clickkt2 == 0)
            {
                textBoxVeViec.Text = "";
                textBoxVeViec.ForeColor = System.Drawing.Color.Black;
                clickkt2++;
            }
        }

        
        
        private void textBoxCanCu1_Click(object sender, EventArgs e)
        {
            
            if (clickkt3 == 0)
            {
                textBoxCanCu1.Text = "";
                textBoxCanCu1.ForeColor = System.Drawing.Color.Black;
                clickkt3++;
            }
        }


       
        private void textBoxCanCu2_Click(object sender, EventArgs e)
        {
            
            if (clickkt4 == 0)
            {
                textBoxCanCu2.Text = "";
                textBoxCanCu2.ForeColor = System.Drawing.Color.Black;
                clickkt4++;
            }
        }


        
        private void textBoxTheoDeNghi_Click(object sender, EventArgs e)
        {
            if (clickkt5 == 0)
            {
                textBoxTheoDeNghi.Text = "";
                textBoxTheoDeNghi.ForeColor = System.Drawing.Color.Black;
                clickkt5++;
            }
        }

       
        private void textBoxDieu1_Click(object sender, EventArgs e)
        {
            
            if (clickkt6 == 0)
            {
                textBoxDieu1.Text = "";
                textBoxDieu1.ForeColor = System.Drawing.Color.Black;
                clickkt6++;
            }
        }

        private void textBoxdieu2_Click(object sender, EventArgs e)
        {
            
            if (clickkt7 == 0)
            {
                textBoxdieu2.Text = "";
                textBoxdieu2.ForeColor = System.Drawing.Color.Black;
                clickkt7++;
            }
        }

        
        private void textBoxDieu3_Click(object sender, EventArgs e)
        {
            
            if (clickkt8 == 0)
            {
                textBoxDieu3.Text = "";
                textBoxDieu3.ForeColor = System.Drawing.Color.Black;
                clickkt8++;
            }
        }

        private void Mau001_Click(object sender, EventArgs e)
        {
            
        }

        
        private void textBoxNoiNhan_Click(object sender, EventArgs e)
        {
            
            if (clickkt9 == 0)
            {
                textBoxNoiNhan.Text = "";
                textBoxNoiNhan.ForeColor = System.Drawing.Color.Black;
                clickkt9++;
            }
        }

        
        private void textNoiLuu_Click(object sender, EventArgs e)
        {
            
            if (clickkt10 == 0)
            {
                textNoiLuu.Text = "";
                textNoiLuu.ForeColor = System.Drawing.Color.Black;
                clickkt10++;
            }
        }

        
        private void textBoxQuyenHanNguoiKi_Click(object sender, EventArgs e)
        {
            
            if (clickkt11 == 0)
            {
                textBoxQuyenHanNguoiKi.Text = "";
                textBoxQuyenHanNguoiKi.ForeColor = System.Drawing.Color.Black;
                clickkt11++;
            }
        }

        
        private void textBoxHoTenNguoiKi_Click(object sender, EventArgs e)
        {
            
            if (clickkt13 == 0)
            {
                textBoxHoTenNguoiKi.Text = "";
                textBoxHoTenNguoiKi.ForeColor = System.Drawing.Color.Black;
                clickkt13++;
            }
        }


       
        private void textBoxKiThay_Click(object sender, EventArgs e)
        {
            
            if (clickkt14 == 0)
            {
                textBoxKiThay.Text = "";
                textBoxKiThay.ForeColor = System.Drawing.Color.Black;
                clickkt14++;
            }
        }

        private void textBoxQuyenHanNguoiKi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clickkt11 == 0)
            {
                textBoxQuyenHanNguoiKi.ForeColor = System.Drawing.Color.Black;
                clickkt11++;
            }
        }
       
    }
    
}
