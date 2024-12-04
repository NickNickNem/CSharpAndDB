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
    // 상품을 등록하는 양식 화면의 코드입니다
    public partial class AddProduct : Form{

        DBQuery DBquery;
        private string ID = "";

        public AddProduct(){
            InitializeComponent();
        }

        public AddProduct(string ID){
            InitializeComponent();
            this.ID = ID;
        }

        // 화면을 처음 불러올 때, 화면의 11시 방향에 있는 ID Textbox를 현재 ID로 설정합니다
        private void AddProduct_Load(object sender, EventArgs e){
            try{
                DBquery = DBQuery.Instance;
                ID_T.Text = ID;
            }catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        // 등록하기 버튼을 누를 때, post 테이블에 not null 제약을 설정한 {ID, 제품 종류, 게시글 이름, 가격} 4개가 공란인지 확인합니다
        // 현재 query에 있는 Query 결과는 "insert into member values(닉네임, 제품 종류, 게시글 이름, 가격, 희망하는 판매 장소, 희망하는 판매 시간대, 설명글, 표기 권한, 게시글 생성일);"입니다
        private void Submit_Click(object sender, EventArgs e){
            try{
                if (ID_T.Text == "" || Type_C.Text == "" || Name_T.Text == "" || Price_T.Text == ""){
                    MessageBox.Show("로그인 상태 or 카테고리 상태 or 글 제목 or 가격\n공란이 존재하니 재확인 부탁");
                }else if (ID_T.Text != "" && Type_C.Text != "" && Name_T.Text != "" && Price_T.Text != ""){
                    DateTime date = DateTime.Now;
                    string CreateDate = date.ToString("yy-MM-dd");

                    string query = $"insert into post values(@p1, @p2, @p3, @p4, @p5, @p6, @p7, '1', '{CreateDate}');";
                    DBquery.InsertInto(query, ID_T.Text, Type_C.Text, Name_T.Text, Price_T.Text, Area_T.Text, Time_T.Text, Explanation_T.Text);
                    this.Close();
                }
            }catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
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

        // 게시글 등록 화면에서 나가는 버튼입니다
        private void CloseBT_Click(object sender, EventArgs e){
            this.Close();
        }
    }
}