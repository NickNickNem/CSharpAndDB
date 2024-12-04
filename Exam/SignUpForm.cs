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
    // 회원 가입하는 화면의 코드입니다
    public partial class SignUpForm : Form{
        DBQuery DBquery;
        bool check = true;
        
        public SignUpForm(){
            InitializeComponent();
        }

        // 통상적인 회원 가입에 존재하는 ID 중복 확인 버튼입니다
        // ID Textbox가 공란인지 아닌지를 확인 → 공란이 아닐 경우, ID Textbox를 파라미터 값으로 넘깁니다
        // 파라미터로 넘겨받은 ID값을 where 조건을 붙여서 member 테이블을 조회합니다
        // member 테이블의 ID는 Primary Key로 설정했기 때문에, 중복된 값을 추가할 수 없습니다
        // 입력한 ID Textbox와 member 테이블의 조회 값이 같을 경우, 중복된 ID가 있다는 안내문을 띄웁니다
        private void Verify_Click(object sender, EventArgs e){
            if (ID_T.Text == ""){
                MessageBox.Show("ID가 빈칸입니다");
            }else if (ID_T.Text != ""){
                string query = "select ID from member where ID = @ID";
                check = DBquery.FindID(query, ID_T.Text);

                if (check == true){
                    MessageBox.Show("이미 존재하는 ID입니다 다시 생각해보자");
                    ID_T.Text = "";
                }else{
                    MessageBox.Show("생성 가능한 ID입니다");
                    ID_T.Enabled = false;
                    Verify.Visible = false;
                }
            }
        }

        // 모든 입력 정보를 한번에 지우는 초기화 버튼입니다 (웹 사이트의 새로고침 기능과 유사합니다)
        private void Init_Click(object sender, EventArgs e){
            ID_T.Enabled = true;
            Verify.Visible = true;
            check = true;
            ID_T.Text = "";
            PW_T.Text = "";
            NickNem_T.Text = "";
            Area_T.Text = "";
            ID_T.Focus();
        }

        // 로그인 화면이 로딩될 때, 함수 클래스에서 싱글톤 패턴으로 DB에 연동합니다
        // check를 true로 초기화 하여 인증 성공 → 재접속 or 새로고침 시 ID 중복 체크 성공했던 결과를 무효합니다
        private void SignUpForm_Load(object sender, EventArgs e){
            DBquery = DBQuery.Instance;
            check = true;
        }

        // 중복 확인(변수 check) 했는지 확인 → 했을 경우 공란이 존재하는지 확인 → 공란이 없을 경우 모두 파라미터 값을 넘깁니다
        // 통상적으로 회원 가입 날짜 까지만 표기하기 때문에 연-월-일 형식으로 변수를 CreateDate로 재정의 합니다
        // 현재 str에 있는 Query 결과는 "insert into member values(ID, 비밀번호, 닉네임, 활동지, 계정생성일, 0, 0.0, 1);"입니다
        private void Create_Click(object sender, EventArgs e){
            if (check == true) {
                MessageBox.Show("ID 중복 확인을 안했어");
            } else if (ID_T.Text == "" || PW_T.Text == "" || NickNem_T.Text == "" || Area_T.Text == ""){
                MessageBox.Show("빈칸이 존재해");
            } else if (ID_T.Text != "" && PW_T.Text != "" && NickNem_T.Text != "" || Area_T.Text != ""){
                DateTime date = DateTime.Now;
                string CreateDate = date.ToString("yyyy-MM-dd");
                
                string str = $"insert into member values(@p1, @p2, @p3, @p4, '{CreateDate}', 0, 0.0, 1);";
                DBquery.InsertInto(str, ID_T.Text, PW_T.Text, NickNem_T.Text, Area_T.Text);
                this.Close();
            }
        }
    }
}