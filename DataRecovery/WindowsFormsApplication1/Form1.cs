using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (bcbzEntities db = new bcbzEntities())
            {
                string[] data = System.IO.File.ReadAllLines(@"d:\20130326UserIncome.txt");
                //int index = 0;
                int id = 0;

                int incomeType = 0;
                UserIncome ui = null;
                string[] id_type = null;
                foreach (var item in data)
                {
                    id_type = item.Split('\t');
                    try
                    {
                        id = int.Parse(id_type[0]);
                        incomeType = int.Parse(id_type[2]);
                        ui = db.UserIncome.First(w => w.Id == id);
                        ui.IncomeType = incomeType;
                        db.SaveChanges();
                    }
                    catch
                    {
                        //System.IO.File.AppendText("id:" + id + " update faild.\n");
                    }
                }
            }
        }

        private void btnWin_Click(object sender, EventArgs e)
        {
            using (bcbzEntities db = new bcbzEntities())
            {
                var userIds = db.PlayTogether.GroupBy(w => w.UserId).Select(w => w.Key);
                foreach (var item in userIds)
                {
                    UserPlayTogetherState upts = new UserPlayTogetherState
                    {
                        CreatedTime = DateTime.UtcNow,
                        UpdatedTime = DateTime.UtcNow,
                        UserId = item
                    };

                    int win = 0;
                    int total = 1;
                    win = db.PlayTogether.Where(w => w.BetOrder.WinFlag == 1 && w.UserId == item).Count();
                    total = db.PlayTogether.Where(w => w.UserId == item).Count();
                    upts.Win = win;
                    upts.Total = total;
                    db.UserPlayTogetherStates.AddObject(upts);
                    db.SaveChanges();
                }
            }
        }
    }
}
