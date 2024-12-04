using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam{
    // 등록된 게시글을 수정하는 화면의 코드입니다
    public partial class EditPost : Form{

        DBQuery DBquery;
        private string ID = "";
        private int p_ID = 0;

        public EditPost(){
            InitializeComponent();
        }

        public EditPost(string ID, int p_ID){
            InitializeComponent();
            this.ID = ID;
            this.p_ID = p_ID;
        }

        // 화면을 불러올 때, EditPost(ID, p_ID)에서 넘겨받은걸 이용해서 수정해야할 게시글을 찾고 {닉네임, 제품 종류, 글 제목, 가격, 희망하는 판매 장소, 희망하는 판매 시간대, 설명글}을 조회합니다
        // 그 후, 조회한 결과들을 Textbox에 적어놓습니다
        private void EditPost_Load(object sender, EventArgs e){
            try{
                DBquery = DBQuery.Instance;

                string query = "select m.Nickname, p.p_type, p.p_name, p.Price, p.p_activityArea, p.TradeTime, p.Explanation from (member as m inner join post as p on m.ID = p.m_ID) where p.p_ID = @p1";
                string[] columns = { "Nickname", "p_type", "p_name", "Price", "p_activityArea", "TradeTime", "Explanation" };
                string[] result = DBquery.EditPost(query, columns, p_ID);

                Nickname_T.Text = result[0];
                Type_C.Text = result[1];
                Name_T.Text = result[2];
                Price_T.Text = result[3];
                Area_T.Text = result[4];
                Time_T.Text = result[5];
                Explanation_T.Text = result[6];

            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        // [수정 완료]버튼을 누를 때 post 테이블의 not null 제약인 {닉네임, 제품 종류, 게시글 이름, 가격}이 공란인지 확인합니다
        // 현재 query에 있는 Query 결과는 "update post set {제품 종류, 게시글 이름, 가격, 희망하는 판매 장소, 희망하는 판매 시간대, 설명글} where = 게시글 ID;"입니다
        private void Submit_Click(object sender, EventArgs e){
            try{
                if (Nickname_T.Text == "" || Type_C.Text == "" || Name_T.Text == "" || Price_T.Text == ""){
                    MessageBox.Show("로그인 상태 or 카테고리 상태 or 글 제목 or 가격\n공란이 존재하니 재확인 부탁");
                }else if (Nickname_T.Text != "" && Type_C.Text != "" && Name_T.Text != "" && Price_T.Text != ""){
                    string query = "update post set p_type = @p1, p_name = @p2, Price = @p3, p_activityArea = @p4, TradeTime = @p5, Explanation = @p6 where p_ID = @p7";
                    DBquery.InsertInto(query, Type_C.Text, Name_T.Text, Price_T.Text, Area_T.Text, Time_T.Text, Explanation_T.Text, p_ID);
                    this.Close();
                }
            }catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        // 게시글 등록 화면에서 나가는 버튼입니다
        private void CloseBT_Click(object sender, EventArgs e){
            this.Close();
        }

        // 모든 입력 정보를 한번에 지우는 초기화 버튼입니다 (웹 사이트의 새로고침 기능과 유사합니다)
        private void Init_Click(object sender, EventArgs e){
            Name_T.Text = "";
            Price_T.Text = "";
            Area_T.Text = "";
            Time_T.Text = "";
            Explanation_T.Text = "";
            Name_T.Focus();
        }
    }
}