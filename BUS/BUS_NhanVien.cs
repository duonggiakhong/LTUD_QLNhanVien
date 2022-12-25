using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
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
        public bool ThemNV(DTO_NhanVien dto)
        {
            return dalNhanVien.ThemNVK(dto);
        }
        public bool SuaNV(DTO_NhanVien et)
        {
            return dalNhanVien.SuaNV(et);
        }
        public bool XoaNVK(DTO_NhanVien et)
        {
            return dalNhanVien.XoaNVK(et);
        }
    }   
}
