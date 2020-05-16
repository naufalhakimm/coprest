using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoprestLib;
using System.Data.SqlClient;

namespace Coprest
{
    public partial class CoprestMainForm : Form
    {
        PasienTable model = new PasienTable();
        Skor objUmum = new SkorUmum();
        Skor objKhusus = new SkorKhusus();
        Scoring score = new Scoring();
        Saran saran = new Saran();
        public CoprestMainForm()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = tb_Name.Text;
            user.Age = int.Parse(tb_Age.Text);

            score._ans1 = cb_Demam.Checked;
            score._ans2 = cb_BatukKering.Checked;
            score._ans3 = cb_Sesak.Checked;
            score._ans4 = cb_Diare.Checked;
            score._ans5 = cb_Pusing.Checked;
            score._ans6 = cb_Lidah.Checked;
            score._ans7 = cb_Travel.Checked;

           
            try
            {
                model.Nama = user.Name;
                model.Umur = user.Age;
                model.Ans1 = score._ans1;
                model.Ans2 = score._ans2;
                model.Ans3 = score._ans3;
                model.Ans4 = score._ans4;
                model.Ans5 = score._ans5;
                model.Ans6 = score._ans6;
                model.Ans7 = score._ans7;

                using (PasienDbEntities db = new PasienDbEntities())
                {
                    db.PasienTables.Add(model);
                    db.SaveChanges();
                }

            }
            catch
            {
                MessageBox.Show("Program ini membutuhkan SQLEXPRESS, klik Ok untuk melihat hasil.");
            }

            
           
            tb_HasilUmum.Text = objUmum.Calculate(score._ans1, score._ans2, score._ans3);
            tb_HasilKhusus.Text = objKhusus.Calculate(score._ans4, score._ans5, score._ans6);
            
        }

        private void btn_Saran_Click(object sender, EventArgs e)
        {   
            int umum;
            int khusus;
            umum = score.Calculate(score._ans1, score._ans2, score._ans3);
            khusus = score.Calculate(score._ans4, score._ans5, score._ans6);
            //MessageBox.Show(score._ans1.ToString() + umum.ToString() + khusus.ToString());
            tb_Saran.Text = score.GenerateSaran(umum, khusus, score._ans7); 
        }
        
    }
}
