using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace XuLyVanBan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
   
        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word._Application oWord = new Microsoft.Office.Interop.Word.Application();

            oWord.Visible = true;

            var oDoc = oWord.Documents.Add();

            //Insert a paragraph at the beginning of the document.
            var paragraph1 = oDoc.Content.Paragraphs.Add();

            paragraph1.Range.Text = "Heading 1";
            paragraph1.Range.Font.Bold = 1;
            paragraph1.Format.SpaceAfter = 24;    //24 pt spacing after paragraph.
            paragraph1.Format.SpaceAfterAuto = 30;

            oDoc.SaveAs2(@"C:\Users\MaiThuy\Desktop\TestDocumentWith1Paragraph.docx");

            oWord.Quit();
        }
    }
}
