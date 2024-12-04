using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaybeAssignment{
    public partial class Status : Form{
        public Status(){
            InitializeComponent();
        }

        private void Status_Load(object sender, EventArgs e){
            //Slot1.Load("C:\\Users\\User\\Desktop\\202318012 박세준 비밀보관함\\정장 3x4.jpg");
            Slot1.SizeMode = PictureBoxSizeMode.StretchImage;
            Slot1_N.Text = "Product_Name";
            Slot1_D.Text = "YYYY-MM-DD";
            Slot1_B.Text = "Product1\nInfo";

            //Slot2.Load("C:\\Users\\User\\Desktop\\202318012 박세준 비밀보관함\\정장 3x4.jpg");
            Slot2.SizeMode = PictureBoxSizeMode.StretchImage;
            Slot2_N.Text = "무언가를 중고로 팝니다";
            Slot2_D.Text = "2024-09-11";
            Slot2_B.Text = "거래글 보러가기";
        }
    }
}