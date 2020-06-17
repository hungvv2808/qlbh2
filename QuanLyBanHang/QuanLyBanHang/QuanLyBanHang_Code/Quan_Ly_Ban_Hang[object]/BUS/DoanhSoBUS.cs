﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_BanHang.DAL;
using System.Data;
using QL_BanHang.Object;

namespace QL_BanHang.BLL
{
    class DoanhSoBLL
    {
        DataConnect data = new DataConnect();

        public DataTable ShowDoanhThu()
        {
            string sql = "select * from DoanhThu";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public DataTable ShowTheoNgay(DateTime ngay)
        {
            string sql = "select * from DanhSachBan where NgayLap = '"+ngay+"'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public DataTable ShowTheoThang(DateTime ngay)
        {
            int x = ngay.Month;
            int y = ngay.Year;
            string sql = "select * from DanhSachBan where Month(NgayLap) = '" + x + "' and Year(NgayLap) = '" + y + "'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public DataTable ShowTheoNam(DateTime ngay)
        {
            int x = ngay.Year;
            string sql = "select * from DanhSachBan where Year(NgayLap) = '" + x + "'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }

        public int DoanhThuNgay()
        {
            int x;
            DateTime ngay = Convert.ToDateTime(QL_DoanhThu.fmDT.txtNgay.Text);
            string sql = "select sum(SoLuongBan*DonGiaBan) from DoanhThu where NgayLap = '" +ngay+ "' group by NgayLap";
            x = data.ExecuteScalar(sql);
            return x;
        }

        /*public int DoanhThuThang()
        {
            int x;
            DateTime y = Convert.ToDateTime(QL_DoanhThu.fmDT.txtThang.Text);
            int thang = y.Month;
            string sql = "select SUM(SoLuongBan*DonGiaBan) from DoanhThu where MONTH(NgayLap) = '" + thang + "'";
            x = data.ExecuteScalar(sql);
            return x;
        }*/

        public int DoanhThuThang(String theoThang)
        {
            int x;
            DateTime y = Convert.ToDateTime(theoThang);
            int thang = y.Month;
            string sql = "select SUM(SoLuongBan*DonGiaBan) from DoanhThu where MONTH(NgayLap) = '" + thang + "'";
            x = data.ExecuteScalar(sql);
            return x;
        }

        public int DoanhThuNam()
        {
            int x;
            int nam = Convert.ToInt32(QL_DoanhThu.fmDT.txtNam.Text);
            string sql = "select SUM(SoLuongBan*DonGiaBan) from DoanhThu where YEAR(NgayLap) = '" + nam + "'";
            x = data.ExecuteScalar(sql);
            return x;
        }
    }
}
