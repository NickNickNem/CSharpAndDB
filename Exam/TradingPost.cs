using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaybeAssignment{
    public partial class TradingPost : Form{

        public TradingPost(){
            InitializeComponent();
        }

        private void TradingPost_Load(object sender, EventArgs e){
            //Preview.Load("C:\\Users\\User\\Desktop\\202318012 박세준 비밀보관함\\정장 3x4.jpg");
            Preview.SizeMode = PictureBoxSizeMode.StretchImage;
            Nickname.Text = "ID";
            CreateDate.Text = "계정 생성일";
            TradeCount.Text = "거래 횟수";
            Trust.Text = "평판";
        }
    }
}
