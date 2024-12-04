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
    public partial class Form1 : Form{

        DBQuery dbquery;

        SqlConnection Con = null;
        SqlCommand Cmd = new SqlCommand();

        public Form1(){
            InitializeComponent();
            Status_T.Text = "Disconnect";
            Logout.Visible = false;
            Sell.Visible = false;
            Status.Visible = false;
            Interest.Visible = false;
            //Slot1.Load("C:\\Users\\User\\Desktop\\202318012 박세준 비밀보관함\\정장 3x4.jpg");
            Slot1.SizeMode = PictureBoxSizeMode.StretchImage;
            Slot1_N.Text = "Product_Name";
            Slot1_B.Text = "Product1\nInfo";
        }

        void ChangeUI(){
            ID_L.Visible = !ID_L.Visible;
            ID_T.Visible = !ID_T.Visible;
            Password_L.Visible = !Password_L.Visible;
            Password_T.Visible = !Password_T.Visible;
            Register.Visible = !Register.Visible;
            Login.Visible = !Login.Visible;
            Logout.Visible = !Logout.Visible;
            Sell.Visible = !Sell.Visible;
            Status.Visible = !Status.Visible;
            Interest.Visible = !Interest.Visible;
        }

        private void Login_Click(object sender, EventArgs e){
            string str = "select ID from member where ID = '" + ID_T.Text + "';";
            Cmd.CommandText = str;
            object result = Cmd.ExecuteScalar();

            if(result == null){
                MessageBox.Show("존재하지 않는 ID");
            }else{
                str = "select PW from member where ID = '" + result.ToString() + "';";
                Cmd.CommandText = str;
                result = Cmd.ExecuteScalar();
                if(result.ToString() == Password_T.Text){
                    ChangeUI();
                    str = "select Nickname from member where ID = '" + ID_T.Text + "';";
                    Cmd.CommandText = str;
                    result = Cmd.ExecuteScalar();
                    Status_T.Text = result.ToString();
                }else{
                    MessageBox.Show("비밀번호가 일치하지 않는데");
                }
                return;
            }
            
            if (ID_T.Text == "true" && Password_T.Text == "true"){
                ChangeUI();
                Status_T.Text = "SQL-Injected!";
            }
        }

        private void Logout_Click(object sender, EventArgs e){
            ChangeUI();
            Status_T.Text = "Disconnect";
        }

        private void Register_Click(object sender, EventArgs e){
            SignUp form = new SignUp();
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e){
            dbquery = new DBQuery();
            string str = "select * from @p1";
            string[] paras = {"", "", "", ""};
            dbquery.SelectAll(str, paras);
            /*string str = "data source=localhost; database=Com; uid=Admin; pwd=Admin";
            SqlConnection Con = new SqlConnection(str);
            Cmd.Connection = Con;
            Con.Open();*/
        }

        private void Sell_Click(object sender, EventArgs e){
            TradingPost form = new TradingPost();
            form.ShowDialog();
        }

        private void Status_Click(object sender, EventArgs e){
            Status form = new Status();
            form.ShowDialog();
        }
    }
}