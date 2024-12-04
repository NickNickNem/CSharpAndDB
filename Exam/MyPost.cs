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
    // 내가 등록한 게시글을 보는 화면의 코드입니다
    // 전반적으로 Main.cs와 유사하기에 일부 설명이 생략됩니다
    public partial class MyPost : Form{

        DBQuery DBquery;
        private int Numbering = 0;
        private string ID = "";
        private string type = "";

        public MyPost(){
            InitializeComponent();
        }

        public MyPost(string ID){
            InitializeComponent();
            this.ID = ID;
        }

        /*
        웹 사이트의 새로고침 기능을 누를 때, 상품들의 정보를 호출하기 위한 함수입니다
        query의 Query 결과는 "select (게시글 번호, 제품 종류, 게시글 제목, 가격, 게시글 작성일, 댓글 수) from (member + post) inner join where 회원ID = ID;"입니다
        카테고리 분류 검색, 새로고침 등 여러번 사용하기 때문에 함수를 따로 정의했습니다
        조건문은 카테고리 검색 기능을 사용했을 경우 → Query 문법의 맨 끝 세미콜론(;)을 기준으로 .split()을 통해 배열로 분리합니다
        세미콜론(;) 앞에 분리된 string에 카테고리 분류 조건(변수 type)을 추가시킵니다
        Type_T.Text는 메인 화면의 9시 방향에 있는, 검색 종류 : {All, IT, Book} 중 1개 값으로 갱신시킵니다
        */
        private void Loading(){
            AllProduct.Rows.Clear();
            string query = "select distinct p.p_ID, p.p_type, p.p_name, p.Price, p.p_CreateDate from (member as m inner join post as p on m.ID = p.m_ID) where m.ID = @p1";
            string viewType = "검색 Type :";

            if (type != ""){
                query = query + type;
                type = type.Split('=')[1];
                type = type.Split(';')[0];
                Type_T.Text = viewType + type;
            }else if (type == ""){
                query = query + ";";
                Type_T.Text = viewType + " All";
            }

            string[] columns = { "p_ID", "p_type", "p_name", "Price", "p_CreateDate" };
            List<string[]> PostList = new List<string[]>();
            PostList = DBquery.MyPost(query, columns, ID);

            /* MyPost는 post를 join하지 않았기에 댓글 수량 칸을 감안해서 1차 배열 길이를 +1 하고나서, 다시 select로 댓글 수량을 count 하여 추가하기
            이렇게 한 이유는 count를 사용하기 위해 group by를 사용해야하는데, 댓글이 없을 경우 찾을 수 없기 때문이다 */
            for (int i = 0; i < PostList.Count; i++){
                query = "select count(c.c_ID) as '댓글' from (post as p inner join chat as c on p.p_ID = c.c_PID) where p.p_ID = @p1";
                int count = DBquery.SelectSingleInt(query, "댓글", PostList[i][0]);
                PostList[i][5] = count.ToString();
            }

            foreach (string[] rows in PostList){
                AllProduct.Rows.Add(rows);
            }
        }

        private void MyPost_Load(object sender, EventArgs e){
            try{
                DBquery = DBQuery.Instance;

                string query = "select Numbering from member where ID = @p1;";
                Numbering = DBquery.SelectSingleInt(query, "Numbering", ID);

                if (Numbering > 1){
                    adminToolStripMenuItem.Visible = true;
                    MemberStat.Text = "관리자 계정입니다";
                    MemberStat.Visible = true;
                }else{
                    adminToolStripMenuItem.Visible = false;
                }
                query = "select Nickname from member where ID = @p1;";
                NickNem_T.Text = DBquery.SelectSingleStr(query, "Nickname", ID);
                Loading();
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void iTToolStripMenuItem_Click(object sender, EventArgs e){
            type = " and p.p_type = 'IT';";
            Loading();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e){
            type = " and p.p_type = 'Book';";
            Loading();
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e){
            type = "";
            Loading();
        }

        private void CloseBT_Click(object sender, EventArgs e){
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e){
            AddProduct form = new AddProduct(ID);
            this.Hide();
            form.ShowDialog();
            this.Show();
            Loading();
        }

        private void AllProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e){
            try{
                int p_ID = int.Parse(AllProduct.SelectedRows[0].Cells[0].Value.ToString());
                ProductPost form = new ProductPost(ID, p_ID);
                this.Hide();
                form.ShowDialog();
                this.Show();
                Loading();
            }catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }
    }
}