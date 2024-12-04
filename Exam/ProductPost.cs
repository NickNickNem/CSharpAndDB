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
    // 게시글 화면의 코드입니다
    public partial class ProductPost : Form{

        DBQuery DBquery;
        private string ID = "";
        private int p_ID = 0;

        public ProductPost(){
            InitializeComponent();
        }

        public ProductPost(string ID, int p_ID){
            InitializeComponent();
            this.ID = ID;
            this.p_ID = p_ID;
        }

        // 댓글 불러오는 함수로써 query의 Query 결과는 "select {회원명, 댓글 내용, 댓글 작성일} from {member + post + chat}3개 테이블 inner join where = 게시글 ID;" 입니다
        // 처음 화면을 로딩할 때, 댓글을 등록할 때 2번 사용되기 때문에 따로 정의했습니다
        private void LoadChatting(){
            string query = "select distinct m.Nickname, c.Chat, c.c_Date from (member as m inner join post as p on m.ID = p.m_ID) inner join chat as c on m.ID = c.c_MID where c.c_PID = @p1;";
            string[] c_columns = { "Nickname", "Chat", "c_Date" };
            List<string[]> c_result = new List<string[]>();
            c_result = DBquery.PostChat(query, c_columns, p_ID);

            Chat_G.Rows.Clear();
            foreach (string[] rows in c_result){
                Chat_G.Rows.Add(rows);
            }
        }
        /*
        처음 query는 게시글 등록자의 ID를 조회 → 이후 처음 조건문에서 현재 사용자의 ID와 동일할 경우 좌측 상단에 [게시글] 탭을 표기합니다
        두번째 query는 member 테이블과 post 테이블을 inner join을 사용했으며 이때 조회할 값은
        {닉네임, 거래 횟수, 신뢰도, 계정 생성일, 게시글 이름, 가격, 희망 거래지, 희망 시간대, 설명글, 게시글 생성일}를 한번에 다 찾습니다
        조건문은 권한(변수 Numbering)과 ID를 확인 → 정지된 계정 or 비회원일 경우, 게시글 수정 & 댓글 작성 UI를 숨깁니다
        다음 조건은 ID를 확인 → 현재 회원의 ID(변수 ID)와 게시글 작성자의 ID(변수 owner)가 다를 경우, 게시글 수정 UI를 숨깁니다
        그 후 {닉네임, 거래 횟수, 신뢰도, 계정 생성일, 게시글 이름, 가격, 희망 거래지, 희망 시간대, 설명글, 게시글 작성일}을 각각의 Textbox에 대입합니다
        모든 UI 설정이 끝난 후, 댓글들을 불러옵니다
        */
        private void ProductPost_Load(object sender, EventArgs e){
            string owner = "";
            try{
                DBquery = DBQuery.Instance;
                
                
                string query = "select m.ID from (member as m inner join post as p on p.m_ID = m.ID) where p.p_ID = @p_ID";
                owner = DBquery.PostOwner(query, p_ID);

                query = "select m.Nickname, m.TradeCount, m.Trust, m.CreateDate, p.p_name, p.Price, p.p_activityArea, p.TradeTime, p.Explanation, p.p_CreateDate from (member as m inner join post as p on p.m_ID = m.ID) where p.p_ID = @p1;";
                string[] columns = { "Nickname", "TradeCount", "Trust", "CreateDate", "p_name", "Price", "p_activityArea", "TradeTime", "Explanation", "p_CreateDate" };
                string[] result = DBquery.LoadMemPost(query, columns, p_ID);

                query = "select Numbering from member where ID = @p1;";
                int Numbering = DBquery.SelectSingleInt(query, "Numbering", ID);
                Console.WriteLine(Numbering);

                if (Numbering == 0 || ID == ""){
                    게시글ToolStripMenuItem.Visible = false;
                    Chat_T.Visible = false;
                    Chat_BT.Visible = false;
                }else if (ID != owner){
                    게시글ToolStripMenuItem.Visible = false;
                }

                Nickname_T.Text = result[0];
                Trade_T.Text = result[1];
                Trust_T.Text = result[2];
                MemDate_T.Text = result[3];
                Name_T.Text = result[4];
                Price_T.Text = result[5];
                Area_T.Text = result[6];
                Time_T.Text = result[7];
                Explanation_T.Text = result[8];
                Date_T.Text = result[9];

                LoadChatting();
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        // 게시글 화면에서 나가는 버튼입니다
        private void CloseBT_Click(object sender, EventArgs e){
            this.Close();
        }

        // 게시글 탭의 [수정]을 누를 경우, ID, 게시글 ID 값을 포함한 상태로 객체를 생성합니다
        private void 수정ToolStripMenuItem_Click(object sender, EventArgs e){
            EditPost form = new EditPost(ID, p_ID);
            this.Hide();
            form.ShowDialog();
            this.Show();
            this.OnLoad(EventArgs.Empty);
        }

        // 게시글 탭의 [삭제]을 누를 경우, ID, 게시글 ID 값을 포함한 상태로 객체를 생성합니다
        private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e){
            try{
                string query = "delete from post where p_ID = @p1";
                DBquery.InsertInto(query, p_ID);
                this.Close();
            }catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        // [댓글등록]버튼을 누를 경우, Textbox가 공란인지 확인합니다
        // 현재 query에 있는 Query 결과는 "insert into chat values(게시글 번호, 회원 ID, 댓글 내용, 댓글 생성일);"입니다
        private void Chat_BT_Click(object sender, EventArgs e){
            if (Chat_T.Text == ""){
                MessageBox.Show("채팅을 입력하지 않았습니다");
            }else if(Chat_T.Text != ""){
                try{
                    DateTime date = DateTime.Now;
                    string CreateDate = date.ToString("yy-MM-dd");

                    string query = $"insert into chat values(@p1, @p2, @p3, '{CreateDate}');";
                    DBquery.InsertInto(query, p_ID, ID, Chat_T.Text);

                    LoadChatting();
                    Chat_T.Text = "";
                }
                catch (Exception ex){
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // 웹 사이트의 새로고침 기능으로, 처음 화면 불러왔던 함수를 실행하여 댓글들을 표에 나열합니다
        private void Refresh_Click(object sender, EventArgs e){
            ProductPost_Load(sender, e);
        }
    }
}