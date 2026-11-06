using System;
using System.Windows.Forms;
namespace MoralesTextFileLab02
{
    public partial class FrmLab1 : Form
    {
       
        public static string GetInputText = "";
        public FrmLab1()
        {
            InitializeComponent();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            GetInputText = txtInput.Text;
            
            FrmFileName frmFileName = new FrmFileName();
            frmFileName.ShowDialog();
        }
    }
}