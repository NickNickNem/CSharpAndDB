using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Exam{
    // 함수들을 재사용 하기 위해 따로 분리해둔 코드입니다
    internal class DBQuery{
        private SqlConnection con;
        private SqlCommand cmd;
        private static DBQuery instance;

        // 싱글톤 패턴을 위해 클래스 선언합니다
        public static DBQuery Instance {
            get {
                if(instance == null){
                    instance = new DBQuery();
                }
                return instance;
            }
        }

        // DB에 연결형 방식으로 접속합니다
        private DBQuery(){
            string str = "data source=localhost; database=Com; uid=JVision; pwd=JVision;";
            con = new SqlConnection(str);
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
        }

        // 입력받은 ID TextBox로 ID&PW를 찾고, 입력한 PW와 member.PW와 일치할 경우 true를 보내서 로그인 성공
        // bool type으로 한 이유는 크기가 가장 작기 때문에 했지만, 다른 코드들은 재사용성 때문에 bool로 하지 않았습니다
        public bool LoginVerify(string query, string ID, string PW){
            cmd.CommandText = query;
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@ID", SqlDbType.VarChar);
            cmd.Parameters["@ID"].Value = ID;

            SqlDataReader read = cmd.ExecuteReader();
            string CheckID = "";
            string CheckPW = "";
            while (read.Read()){
                CheckID = read["ID"].ToString();
                CheckPW = read["PW"].ToString();
            }
            read.Close();
            if (PW == CheckPW){
                return true;
            }
            return false;
        }

        // 기본키인 member.ID가 이미 존재할 경우 true를 반환하는 중복 ID 확인용 함수입니다
        // bool type으로 한 이유는 크기가 가장 작기 때문에 했지만, 다른 코드들은 재사용성 때문에 bool로 하지 않았습니다
        public bool FindID(string query, string ID){
            cmd.CommandText = query;
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@ID", SqlDbType.VarChar);
            cmd.Parameters["@ID"].Value = ID;

            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read()){
                string result = read["ID"].ToString();
                read.Close();
                return true;
            }
            read.Close();
            return false;
        }

        // .ExecuteNonQuery()를 통해 insert, update, delete를 실행합니다
        public void InsertInto(string query, params object[] para){
            try{
                cmd.CommandText = query;
                cmd.Parameters.Clear();

                if (para != null && para.Length > 0){
                    for (int i = 0; i < para.Length; i++){
                        cmd.Parameters.AddWithValue($"@p{i + 1}", para[i] ?? DBNull.Value);
                    }
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("SQL 명령 처리 완료");
                }
            }catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        // 특정 값 1개를 string으로 반환받기 위한 함수입니다
        public string SelectSingleStr(string query, string target, params object[] paras){
            string result = "";

            try{
                cmd.CommandText = query;
                cmd.Parameters.Clear();

                if (paras != null && paras.Length > 0){
                    for (int i = 0; i < paras.Length; i++){
                        cmd.Parameters.AddWithValue($"@p{i + 1}", paras[i] ?? DBNull.Value);
                    }
                }

                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read()){
                    result = read[target].ToString();
                }
                read.Close();
            }catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        // 특정 값 1개를 int로 반환받기 위한 함수입니다
        public int SelectSingleInt(string query, string target, params object[] paras){
            int result = 0;

            try{
                cmd.CommandText = query;
                cmd.Parameters.Clear();

                if (paras != null && paras.Length > 0){
                    for (int i = 0; i < paras.Length; i++){
                        cmd.Parameters.AddWithValue($"@p{i + 1}", paras[i] ?? DBNull.Value);
                    }
                }

                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read()){
                    result = Convert.ToInt32(read[target]);
                }
                read.Close();
            }catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        // 메인 화면과 게시글 관리 함수에서 표를 불러오는 함수입니다
        public List<string[]> LoadGrid(string query, string[] columns){
            List<string[]> result = new List<string[]>();

            try{
                cmd.CommandText = query;
                cmd.Parameters.Clear();

                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read()){
                    string[] slot = new string[columns.Length];
                    for (int i = 0; i < columns.Length; i++){
                        slot[i] = read[columns[i]].ToString();
                    }
                    result.Add(slot);
                }
                read.Close();

                // 분명 DB에서 작성일을 yyyy-MM-dd로 설정했지만, 여기서는 다시 "오전 12:00:00"까지 붙어버려서 split으로 분리 후 수정하기
                for (int i = 0; i < result.Count; i++){
                    result[i][5] = result[i][5].Split(' ')[0];
                }

                /* 아래는 query = select p_ID, m_ID, p_type, p_name, Price, p_CreateDate from post;에서 result[튜플 수][속성 수]로 저장하고
                (튜플 크기)만큼 반복하면서 m_ID 값을 select로 찾아서 member 테이블의 Nickname으로 변경했던 코드인데
                시진이형이 SQL Query를 보낼 때 Inner Join을 사용하는걸 보고 수정하여 폐기된 코드이다 */
                /*
                for(int i = 0; i < result.Count; i++){
                    cmd.CommandText = "select Nickname from member where ID = @ID;";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@ID", SqlDbType.VarChar);
                    cmd.Parameters["@ID"].Value = result[i][1];
                    read = cmd.ExecuteReader();
                    while (read.Read()){
                        result[i][1] = read[0].ToString();
                    }
                    read.Close();
                }
                */
            }catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        // [내 등록 정보] 화면에서 제품들 정보를 표로 확인하는 함수입니다
        public List<string[]> MyPost(string query, string[] columns, params object[] paras){
            List<string[]> result = new List<string[]>();

            try{
                cmd.CommandText = query;
                cmd.Parameters.Clear();

                if (paras != null && paras.Length > 0){
                    for (int i = 0; i < paras.Length; i++){
                        cmd.Parameters.AddWithValue($"@p{i + 1}", paras[i] ?? DBNull.Value);
                    }
                }

                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read()){
                    string[] slot = new string[columns.Length+1];
                    for (int i = 0; i < columns.Length; i++){
                        slot[i] = read[columns[i]].ToString();
                    }
                    result.Add(slot);
                }
                read.Close();

                for (int i = 0; i < result.Count; i++){
                    result[i][4] = result[i][4].Split(' ')[0];
                }
            }catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        // 게시글 화면에서 Textbox들에 값을 넣기 위한 함수입니다
        public string[] LoadMemPost(string query, string[] columns, params object[] paras){
            string[] result = new string[columns.Length];
            try{
                cmd.CommandText = query;
                cmd.Parameters.Clear();

                if (paras != null && paras.Length > 0){
                    for (int i = 0; i < paras.Length; i++){
                        cmd.Parameters.AddWithValue($"@p{i + 1}", paras[i] ?? DBNull.Value);
                    }
                }

                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read()){
                    for (int i = 0; i < columns.Length; i++){
                        result[i] = read[columns[i]].ToString();
                    }
                }
                read.Close();

                result[3] = result[3].Split(' ')[0];
                result[9] = result[9].Split(' ')[0];
            }catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        // [게시글] 화면에서 댓글들을 표로 확인하는 함수입니다
        public List<string[]> PostChat(string query, string[] columns, params object[] paras){
            List<string[]> result = new List<string[]>();

            try{
                cmd.CommandText = query;
                cmd.Parameters.Clear();

                if (paras != null && paras.Length > 0){
                    for (int i = 0; i < paras.Length; i++){
                        cmd.Parameters.AddWithValue($"@p{i + 1}", paras[i] ?? DBNull.Value);
                    }
                }

                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read()){
                    string[] slot = new string[columns.Length + 1];
                    for (int i = 0; i < columns.Length; i++){
                        slot[i] = read[columns[i]].ToString();
                    }
                    result.Add(slot);
                }
                read.Close();

                for (int i = 0; i < result.Count; i++){
                    result[i][2] = result[i][2].Split(' ')[0];
                }
            }catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        // 게시글 화면에서 게시글 주인을 찾는 함수입니다
        public string PostOwner(string query, int p_ID){
            string result = "";

            cmd.CommandText = query;
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@p_ID", SqlDbType.Int);
            cmd.Parameters["@p_ID"].Value = p_ID;

            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read()){
                result = read["ID"].ToString();
            }
            read.Close();

            return result;
        }

        // 게시글 수정 화면에서 Textbox들에 값을 넣기 위한 함수입니다
        public string[] EditPost(string query, string[] columns, params object[] paras){
            string[] result = new string[columns.Length];
            try{
                cmd.CommandText = query;
                cmd.Parameters.Clear();

                if (paras != null && paras.Length > 0){
                    for (int i = 0; i < paras.Length; i++){
                        cmd.Parameters.AddWithValue($"@p{i + 1}", paras[i] ?? DBNull.Value);
                    }
                }

                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read()){
                    for (int i = 0; i < columns.Length; i++){
                        result[i] = read[columns[i]].ToString();
                    }
                }
                read.Close();
            }catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
            return result;
        }
    }
}