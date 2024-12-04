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
    // 게시글 관리 화면의 코드입니다
    // 전반적으로 Main.cs와 유사하기에 일부 설명이 생략됩니다
    public partial class PostManage : Form{

        DBQuery DBquery;
        private string ID = "";
        private string type = "";

        public PostManage(){
            InitializeComponent();
        }

        public PostManage(string ID){
            InitializeComponent();
            this.ID = ID;
        }

        private void Loading(){
            AllProduct.Rows.Clear();
            string query = "select p.p_ID, m.Nickname, p.p_type, p.p_name, p.Price, p.p_CreateDate, p.Access from (member as m inner join post as p on m.ID = p.m_ID);";
            string viewType = "검색 Type :";

            if (type != ""){
                string temp = query.Split(';')[0];
                query = temp + type;
                temp = type.Split('=')[1];
                temp = temp.Split(';')[0];
                Type_T.Text = viewType + temp;
            }else if (type == ""){
                Type_T.Text = viewType + " All";
            }

            string[] columns = { "p_ID", "Nickname", "p_type", "p_name", "Price", "p_CreateDate", "Access" };
            List<string[]> PostList = new List<string[]>();
            PostList = DBquery.LoadGrid(query, columns);
            foreach (string[] rows in PostList){
                AllProduct.Rows.Add(rows);
            }
        }

        private void PostManage_Load(object sender, EventArgs e){
            try{
                DBquery = DBQuery.Instance;
                string query;

                query = "select Nickname from member where ID = @p1;";
                NickNem_T.Text = DBquery.SelectSingleStr(query, "Nickname", ID);

                Loading();
                Access_C.SelectedIndex = 0;
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void iTToolStripMenuItem_Click(object sender, EventArgs e){
            type = " where p.p_type = 'IT';";
            Loading();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e){
            type = " where p.p_type = 'Book';";
            Loading();
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e){
            type = "";
            Loading();
        }

        private void 새로고침ToolStripMenuItem_Click(object sender, EventArgs e){
            Loading();
        }

        // 관리자가 특정 게시글을 삭제시킬 수 있는 기능입니다
        // query의 Query 결과는 "delete from chat where 댓글 번호 = 선택한 줄의 글번호;"와 "delete from post where 게시글 번호 = 선택한 줄의 글번호;"입니다
        // 만약 삭제 순서를 게시글 먼저 지우려고 한다면, Foreign Key 제약 충돌이 발생하므로, 반드시 댓글 부터 delete 해야합니다
        private void PostDelete_Click(object sender, EventArgs e){
            string SelectedPost = AllProduct.SelectedRows[0].Cells[0].Value.ToString();

            string query = "delete from chat where c_PID = @p1;";
            DBquery.InsertInto(query, SelectedPost);

            query = "delete from post where p_ID = @p1;";
            DBquery.InsertInto(query, SelectedPost);
            Loading();
        }

        // 관리자가 특정 게시글을 비공개로 바꿔서 검열할 수 있습니다
        // query의 Query 결과는 "update post set 권한 = Combobox 선택값 where 글번호 = 선택한 줄의 글번호;" 입니다
        private void PostPrivate_Click(object sender, EventArgs e){
            string SelectedPost = AllProduct.SelectedRows[0].Cells[0].Value.ToString();
            string query = "update post set Access = @p1 where p_ID = @p2";

            string Num = Access_C.Text;
            Num = Num.Split(' ')[0];

            string SelectedID = AllProduct.SelectedRows[0].Cells[0].Value.ToString();

            DBquery.InsertInto(query, Num, SelectedID);

            Loading();
        }

        private void CloseBT_Click(object sender, EventArgs e){
            this.Close();
        }
    }
}