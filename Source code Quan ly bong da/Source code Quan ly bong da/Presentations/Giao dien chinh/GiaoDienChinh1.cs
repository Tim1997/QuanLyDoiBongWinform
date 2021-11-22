using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentations.Giao_dien_chinh
{
    public partial class GiaoDienChinh1 : Form
    {
        #region Properties
        private readonly string NAME_PROJECT = "Quản Lý Giải Vô Địch Bóng Đá Toàn Quốc";
        private static GiaoDienChinh1 _instance;

        #endregion

        public GiaoDienChinh1()
        {
            InitializeComponent();
            Init();
        }

        #region Method
        public void AddChiTietDSDB()
        {
            pContent.Controls.Clear();
            ChiTietDanhSachDoiBong ctdb = new ChiTietDanhSachDoiBong();
            pContent.Controls.Add(ctdb);
        }

        public void AddChiTietDSCT()
        {
            pContent.Controls.Clear();
            ChiTietDanhSachCauThu ctct = new ChiTietDanhSachCauThu();
            pContent.Controls.Add(ctct);
        }

        public void AddQuanLyDoiBong()
        {
            pContent.Controls.Clear();
            QuanLyDoiBong qldb = new QuanLyDoiBong();
            pContent.Controls.Add(qldb);
        }
        public static GiaoDienChinh1 GetInstance()
        {
            return _instance;
        }

        void Init()
        {
            this.Text = NAME_PROJECT;
            _instance = this;
        }

        #endregion

        private void mHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help.chm");
        }

        private void mSearch_Click(object sender, EventArgs e)
        {
            pContent.Visible = true;
            pContent.Controls.Clear();
            TraCuu tc = new TraCuu();
            pContent.Controls.Add(tc);
            this.Text = mSearch.Text + " - " + NAME_PROJECT;
        }

        private void tmFootball_Click(object sender, EventArgs e)
        {
            QuanLyDoiBong qldb = new QuanLyDoiBong();
            pContent.Controls.Clear();
            pContent.Controls.Add(qldb);
            this.Text = tmFootball.Text + " - " + NAME_PROJECT;
        }

        private void tmReferee_Click(object sender, EventArgs e)
        {
            pContent.Controls.Clear();
            QuanLyTrongTai n = new QuanLyTrongTai();
            pContent.Controls.Add(n);
            n.LoadTT();
            this.Text = tmReferee.Text + " - " + NAME_PROJECT;
        }

        private void tmSchedule_Click(object sender, EventArgs e)
        {
            pContent.Controls.Clear();
            QuanLyThiDau n = new QuanLyThiDau();
            pContent.Controls.Add(n);
            n.LoadTranDau();
            n.LoadComboboxMaSan();
            n.LoadComboboxMaDB1_ComboboxMaDB2();
            this.Text = tmSchedule.Text + " - " + NAME_PROJECT;
        }

        private void tmCompetitionResults_Click(object sender, EventArgs e)
        {
            pContent.Controls.Clear();
            QuanLyKetQua kq = new QuanLyKetQua();
            pContent.Controls.Add(kq);
            kq.Load_KetQua();
            this.Text = tmCompetitionResults.Text + " - " + NAME_PROJECT;
        }
    }
}
