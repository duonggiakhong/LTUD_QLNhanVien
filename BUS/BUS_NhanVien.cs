using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAO_NhanVien;
using System.Data;

namespace BUS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dalNhanVien = new DAL_NhanVien();

        public DataTable LayDS()
        {
            return dalNhanVien.LayDSNhanVien();
        }
    }
}
