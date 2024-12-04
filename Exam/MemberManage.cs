using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Exam{
    // 관리자가 회원의 권한을 관리하는 화면 코드입니다
    public partial class MemberManage : Form{

        DBQuery DBquery;
        private string ID = "";

        public MemberManage(){
            InitializeComponent();
        }

        public MemberManage(string ID){
            InitializeComponent();
            this.ID = ID;
        }

        // 회원 정보를 불러오는 함수로써 query의 Query 결과는 "select (회원 ID, 회원명, 계정 생성일, 권한) from member;" 입니다
        // 처음 화면을 로딩할 때, 계정 권한을 수정한 후 2번 사용되기 때문에 따로 정의했습니다
        private void LoadMem(){
            string query = "select distinct ID, Nickname, CreateDate, Numbering from member;";
            string[] c_columns = { "ID", "Nickname", "CreateDate", "Numbering" };
            List<string[]> c_result = new List<string[]>();
            c_result = DBquery.PostChat(query, c_columns);

            AllMember.Rows.Clear();
            foreach (string[] rows in c_result){
                AllMember.Rows.Add(rows);
            }
        }

        private void MemberManage_Load(object sender, EventArgs e){
            try{
                DBquery = DBQuery.Instance;
                string query;

                query = "select Nickname from member where ID = @p1;";
                NickNem_T.Text = DBquery.SelectSingleStr(query, "Nickname", ID);
                Numbering_C.SelectedIndex = 0;

                LoadMem();
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        // query의 Query 결과는 "update member set Numbering = Combobox에서 선택한 값 where ID = 표에서 선택한 ID;"입니다
        // 이 때 ComboBox.Text를 하면 모든 문자를 가져오기 때문에, .split()을 이용하여 숫자 있는 부분만 분리합니다
        // 클릭한 표(.SelectedRows[0])의 첫번째 열(.Cells[0]) 값(.Value)을 문자열(.ToString())로 받습니다
        // 그 후 LoadMem() 함수를 통해 회원 정보들을 갱신시킵니다
        private void UpdateBT_Click(object sender, EventArgs e){
            try{
                string query = "update member set Numbering = @p1 where ID = @p2";
                // 권한(Numbering)에 들어갈 값을 ComboBox에서 선택한 값의 맨 앞을 split으로 추출하여 숫자만 받아내기
                string Num = Numbering_C.Text;
                Num = Num.Split(' ')[0];

                string SelectedID = AllMember.SelectedRows[0].Cells[0].Value.ToString();

                DBquery.InsertInto(query, Num, SelectedID);
                LoadMem();

            }catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        // 회원 권한 관리 화면에서 나가는 버튼입니다
        private void CloseBT_Click(object sender, EventArgs e){
            this.Close();
        }
    }
}
