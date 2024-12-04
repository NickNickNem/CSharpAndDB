using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaybeAssignment{
    public partial class SignUp : Form{
        public SignUp(){
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e){
            if(ID_T.Text == "" || Password_T.Text == "" || Nickname_T.Text == "" || ActivityArea_T.Text == ""){
                MessageBox.Show("빈칸 있어");
            }else{
                MessageBox.Show("-완-");
                Close();
            }
            
        }
    }
}