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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Exam{
    // 사이트의 첫 홈페이지 화면의 코드입니다
    public partial class Main : Form{
        DBQuery DBquery;
        private int Numbering = 0;
        private string ID = "";
        private string type = "";
        
        // 로그인 화면에서 로그인 할 때 ID값을 넘겨받았을 경우 입니다
        public Main(string ID){
            InitializeComponent();
            this.ID = ID;
        }

        // 로그인 화면에서 [비회원으로 구경하기]를 통해서 빈 객체를 넘겨받았을 경우입니다
        public Main(){
            InitializeComponent();
            ID = "";
            Numbering = 0;
        }
        /*
        웹 사이트의 새로고침 기능을 누를 때, 상품들의 정보를 호출하기 위한 함수입니다
        카테고리 분류 검색, 새로고침 등 여러번 사용하기 때문에 함수를 따로 정의했습니다
        조건문은 카테고리 검색 기능을 사용했을 경우 → Query 문법의 맨 끝 세미콜론(;)을 기준으로 .split()을 통해 배열로 분리합니다
        세미콜론(;) 앞에 분리된 string에 카테고리 분류 조건(변수 type)을 추가시킵니다
        Type_T.Text는 메인 화면의 9시 방향에 있는, 검색 종류 : {All, IT, Book} 중 1개 값으로 갱신시킵니다
        */
        private void Loading(){
            AllProduct.Rows.Clear();
            string query = "select p.p_ID, m.Nickname, p.p_type, p.p_name, p.Price, p.p_CreateDate from (member as m inner join post as p on m.ID = p.m_ID) where p.Access > 0;";
            string viewType = "검색 Type :";

            // 만약 Type 검색을 했다면, query의 세미콜론(;) 앞의 단어들을 split으로 분리 후 type(where p.p_type = 검색한Type;) 을 추가하기
            if (type != ""){
                string temp = query.Split(';')[0];
                query = temp + type;
                // type = "where p.p_type = '???';" 상태에서 '???'를 받아오는 과정
                temp = type.Split('=')[1];
                temp = temp.Split(';')[0];
                Type_T.Text = viewType + temp;
            }else if (type == ""){
                Type_T.Text = viewType + " All";
            }

            string[] columns = { "p_ID", "Nickname", "p_type", "p_name", "Price", "p_CreateDate" };
            List<string[]> PostList = new List<string[]>();
            PostList = DBquery.LoadGrid(query, columns);
            foreach (string[] rows in PostList){
                AllProduct.Rows.Add(rows);
            }
        }
        /*
        처음 화면이 로딩될 때, 빈 객체(비회원으로 구경하기)인지 아닌지 확인 → 빈 객체라면 권한을 0으로 조정시키고, 회원에게 보여주는 UI를 숨깁니다
        인자값 있는 객체(로그인 성공)일 경우 → ID값을 파라미터로 넘겨서 member 테이블의 Numbering을 조회합니다
        권한(변수 Numbering)에 따라서 {관리자 권한 / 일반 이용자 권한 / 계정 정지됨} 3개에 적합한 UI를 보여주거나 숨깁니다
        UI 설정 후 다시 member 테이블의 Nickname을 조회하여 화면의 1시 방향 Textbox에 닉네임을 표기합니다
        로그인에 적합한 UI 표기가 끝난 후, 위에서 설명한 Loading() 함수를 실행하여 상품들을 표에 나열합니다
        */
        private void Main_Load(object sender, EventArgs e){
            try{
                DBquery = DBQuery.Instance;
                string query;

                // [비회원으로 구경하기] 버튼을 통해 들어왔는가?
                if (ID == ""){
                    Numbering = 0;
                    adminToolStripMenuItem.Visible = false;
                    ProductToolStripMenuItem.Visible = false;
                    NickNem_L.Visible = false;
                    NickNem_T.Text = "비회원 상태입니다.";
                    CloseBT.Text = "닫기";
                }else if (ID != ""){
                    query = "select Numbering from member where ID = @p1;";
                    Numbering = DBquery.SelectSingleInt(query, "Numbering", ID);

                    // 권한이 1(이용자) 보다 높을 경우, Admin(관리) 탭이 보입니다
                    if (Numbering > 1){
                        adminToolStripMenuItem.Visible = true;
                        MemberStat.Text = "관리자 계정입니다";
                        MemberStat.Visible = true;
                    }else{
                        adminToolStripMenuItem.Visible = false;
                    }
                    // 권한 0(이용 제한 계정)일 경우 상품 등록창 보이지 않습니다
                    if (Numbering == 0){
                        ProductToolStripMenuItem.Visible = false;
                        MemberStat.Text = "이용 제한된 계정입니다";
                        MemberStat.Visible = true;
                    }
                    query = "select Nickname from member where ID = @p1;";
                    NickNem_T.Text = DBquery.SelectSingleStr(query, "Nickname", ID);
                }
                Loading();
            }catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        // 웹 사이트의 새로고침 기능으로, 앞서 설명한 Loading() 함수를 실행하여 상품들을 표에 나열합니다
        private void 새로고침ToolStripMenuItem_Click(object sender, EventArgs e){
            Loading();
        }

        // 로그아웃 버튼을 누를 경우, 창을 닫습니다
        private void CloseBT_Click(object sender, EventArgs e){
            this.Close();
        }

        // Product 탭의 [판매 등록]을 누를 경우, ID 값을 포함한 상태로 객체를 생성합니다
        private void 판매등록ToolStripMenuItem_Click(object sender, EventArgs e){
            AddProduct form = new AddProduct(ID);
            this.Hide();
            form.ShowDialog();
            this.Show();
            Loading();
        }

        // Category 탭의 [IT]를 누를 경우, 검색 종류(type)을 수정하고 Loading() 함수를 실행합니다
        private void iTToolStripMenuItem_Click(object sender, EventArgs e){
            type = " and p.p_type = 'IT';";
            Loading();
        }

        // Category 탭의 [Book]를 누를 경우, 검색 종류(type)을 수정하고 Loading() 함수를 실행합니다
        private void bookToolStripMenuItem_Click(object sender, EventArgs e){
            type = " and p.p_type = 'Book';";
            Loading();
        }

        // Category 탭의 [All]를 누를 경우, 검색 종류(type)를 초기화하고 Loading() 함수를 실행합니다
        private void allToolStripMenuItem_Click(object sender, EventArgs e){
            type = "";
            Loading();
        }

        // 특정 상품에 대해 더블클릭을 할 경우, ID값을 상품 게시글 객체에 넣고 생성합니다
        // 클릭한 표(.SelectedRows[0])의 첫번째 열(.Cells[0])의 값(.Value)을 문자열(.ToString())로 받고, 그것을 정수(int.Parse())로 선언합니다
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

        // Product 탭의 [내 등록 정보]를 누를 경우, ID 값을 포함한 상태로 객체를 생성합니다
        private void 내등록정보ToolStripMenuItem_Click(object sender, EventArgs e){
            MyPost form = new MyPost(ID);
            this.Hide();
            form.ShowDialog();
            this.Show();
            Loading();
        }

        // Admin 탭의 [회원 관리]를 누를 경우, ID 값을 포함한 상태로 객체를 생성합니다
        private void 회원관리ToolStripMenuItem_Click(object sender, EventArgs e){
            MemberManage form = new MemberManage(ID);
            this.Hide();
            form.ShowDialog();
            this.Show();
            Loading();
        }

        // Admin 탭의 [게시글 관리]를 누를 경우, ID 값을 포함한 상태로 객체를 생성합니다
        private void 게시글관리ToolStripMenuItem_Click(object sender, EventArgs e){
            PostManage form = new PostManage(ID);
            this.Hide();
            form.ShowDialog();
            this.Show();
            Loading();
        }
    }
}