using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam{
    // ID와 비밀번호를 입력하여 로그인 하는 화면의 코드입니다
    public partial class LogInForm : Form{
        DBQuery DBquery;
        
        public LogInForm(){
            InitializeComponent();
        }

        // 회원 가입 창을 띄우는 기능입니다
        private void SignUp_Click(object sender, EventArgs e){
            SignUpForm form = new SignUpForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        // 로그인 화면이 로딩될 때, 함수 클래스에서 싱글톤 패턴으로 DB에 연동합니다
        private void LogInForm_Load(object sender, EventArgs e){
            DBquery = DBQuery.Instance;
        }

        // 로그인 버튼을 누를 때, ID or 비밀번호 칸이 공란인지 확인 → 공란이 아닐 경우, ID Textbox를 파라미터 값으로 넘깁니다
        // member 테이블에서 파라미터로 넘겨받은 ID Textbox를 where 조건으로 select를 합니다
        // 회원가입했던 ID와 비밀번호가 현재 Textbox에 입력한 ID와 비밀번호와 일치한지 LoginVerify()를 통해 검증하여 성공/실패를 판단합니다
        // 로그인 성공 시, ID 값을 포함시켜서 Main화면 객체를 생성합니다
        private void Login_Click(object sender, EventArgs e){
            if (ID.Text == "" || PW.Text == ""){
                MessageBox.Show("ID or PW가 빈칸입니다");
            }else if (ID.Text != "" && PW.Text != ""){
                bool passing = false;
                string query = "select ID, PW from member where ID = @ID";
                passing = DBquery.LoginVerify(query, ID.Text, PW.Text);

                if (passing == false){
                    MessageBox.Show("ID & PW를 다시 확인해");
                }else{
                    MessageBox.Show("환영해");
                    Main form = new Main(ID.Text);
                    this.Hide();
                    form.ShowDialog();
                    this.Show();
                    ID.Text = "";
                    PW.Text = "";
                    ID.Focus();
                }
            }
        }

        // 비회원으로 구경하기 버튼을 누를 경우 빈 객체 생성(Spring Boot의 @NoArgsConstructor) 합니다
        private void OffLine_Click(object sender, EventArgs e){
            Main form = new Main();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}