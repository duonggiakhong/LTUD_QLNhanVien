using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
