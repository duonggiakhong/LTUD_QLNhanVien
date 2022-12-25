using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_NhanVien
    {
        //handleDatabase dtBase = new handleDatabase();






        SqlConnection dtBase = new SqlConnection("Data Source=DESKTOP-1NVCLO2;Initial Catalog=qlNhanVien;Integrated Security=True");
        SqlDataAdapter dalNhanVien;
        SqlCommand cmdLNhanVien;
        DataTable dtlNhanVien;
        //lay du lieu tu database

        public DataTable LayDSNhanVien()
        {
            try
            {
                dtBase.Open();
                cmdLNhanVien = new SqlCommand();
                cmdLNhanVien.CommandText = "LayDSNhanVien";
                cmdLNhanVien.CommandType = CommandType.StoredProcedure;
                cmdLNhanVien.Connection = dtBase;

                dalNhanVien = new SqlDataAdapter(cmdLNhanVien);
                dtlNhanVien = new DataTable();
                dalNhanVien.Fill(dtlNhanVien);
            }
            catch (Exception)
            {
            }
            finally
            {
                dtBase.Close();
            }
            return dtlNhanVien;
        }
        public bool ThemNVK(DTO_NhanVien dto)
        {
            try
            {
                dtBase.Open();
                cmdLNhanVien = new SqlCommand();
                cmdLNhanVien.CommandType = CommandType.StoredProcedure;
                cmdLNhanVien.CommandText = "sp_ThemNVK";
                cmdLNhanVien.Connection = dtBase;
                //string maNV, string gioiTinh, string tDHocVan, string maThue, string quocTich, string tonGiao, 
                //    string danToc, string hoVaTen, string noiSinh, string diaChi, string maLuong, string email, 
                //    string chuyenMon, DateTime ngaySinh, int soCMND, int sDT
                cmdLNhanVien.Parameters.Add(new SqlParameter("@MaNV", dto.MaNV1));
                cmdLNhanVien.Parameters.Add(new SqlParameter("@GioiTinh", dto.GioiTinh1));
                cmdLNhanVien.Parameters.Add(new SqlParameter("@SoCMND", dto.SoCMND1));
                cmdLNhanVien.Parameters.Add(new SqlParameter("@TDHocVan", dto.TDHocVan1));
                cmdLNhanVien.Parameters.Add(new SqlParameter("@MaThue", dto.MaThue1));
                cmdLNhanVien.Parameters.Add(new SqlParameter("@QuocTich", dto.QuocTich1));
                cmdLNhanVien.Parameters.Add(new SqlParameter("@TonGiao", dto.TonGiao1));
                cmdLNhanVien.Parameters.Add(new SqlParameter("@DanToc", dto.DanToc1));
                cmdLNhanVien.Parameters.Add(new SqlParameter("@HoTen", dto.HoVaTen1));
                cmdLNhanVien.Parameters.Add(new SqlParameter("@NgaySinh", dto.NgaySinh1));
                cmdLNhanVien.Parameters.Add(new SqlParameter("@NoiSinh", dto.NoiSinh1));
                cmdLNhanVien.Parameters.Add(new SqlParameter("@DiaChi", dto.DiaChi1));
                cmdLNhanVien.Parameters.Add(new SqlParameter("@MaLuong", dto.MaLuong1));
                cmdLNhanVien.Parameters.Add(new SqlParameter("@Email", dto.Email1));
                cmdLNhanVien.Parameters.Add(new SqlParameter("@SDT", dto.SDT1));
                cmdLNhanVien.Parameters.Add(new SqlParameter("@ChuyenMon", dto.ChuyenMon1));

                if (cmdLNhanVien.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                dtBase.Close();
            }
            return false;
        }

        public bool SuaNV(DTO_NhanVien dto)
        {
            try
            {
                dtBase.Open();
                cmdLNhanVien = new SqlCommand();
                cmdLNhanVien.CommandType = CommandType.StoredProcedure;
                cmdLNhanVien.CommandText = "sp_SuaNVK";
                cmdLNhanVien.Connection = dtBase;

                cmdLNhanVien.Parameters.Add(new SqlParameter("@MaNV", dto.MaNV1));
                cmdLNhanVien.Parameters.Add(new SqlParameter("@GioiTinh", dto.GioiTinh1));
                cmdLNhanVien.Parameters.Add(new SqlParameter("@SoCMND", dto.SoCMND1));
                cmdLNhanVien.Parameters.Add(new SqlParameter("@TDHocVan", dto.TDHocVan1));
                cmdLNhanVien.Parameters.Add(new SqlParameter("@MaThue", dto.MaThue1));
                cmdLNhanVien.Parameters.Add(new SqlParameter("@QuocTich", dto.QuocTich1));
                cmdLNhanVien.Parameters.Add(new SqlParameter("@TonGiao", dto.TonGiao1));
                cmdLNhanVien.Parameters.Add(new SqlParameter("@DanToc", dto.DanToc1));
                cmdLNhanVien.Parameters.Add(new SqlParameter("@HoTen", dto.HoVaTen1));
                cmdLNhanVien.Parameters.Add(new SqlParameter("@NgaySinh", dto.NgaySinh1));
                cmdLNhanVien.Parameters.Add(new SqlParameter("@NoiSinh", dto.NoiSinh1));
                cmdLNhanVien.Parameters.Add(new SqlParameter("@DiaChi", dto.DiaChi1));
                cmdLNhanVien.Parameters.Add(new SqlParameter("@MaLuong", dto.MaLuong1));
                cmdLNhanVien.Parameters.Add(new SqlParameter("@Email", dto.Email1));
                cmdLNhanVien.Parameters.Add(new SqlParameter("@SDT", dto.SDT1));
                cmdLNhanVien.Parameters.Add(new SqlParameter("@ChuyenMon", dto.ChuyenMon1));


                if (cmdLNhanVien.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                dtBase.Close();
            }
            return false;
        }
        public bool XoaNVK(DTO_NhanVien dto)
        {
            try
            {
                dtBase.Open();
                cmdLNhanVien = new SqlCommand();
                cmdLNhanVien.CommandType = CommandType.StoredProcedure;
                cmdLNhanVien.CommandText = "sp_XoaNVK";
                cmdLNhanVien.Connection = dtBase;

                cmdLNhanVien.Parameters.Add(new SqlParameter("@MaNV", dto.MaNV1));
                if (cmdLNhanVien.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                dtBase.Close();
            }
            return false;
        }
    }
}
