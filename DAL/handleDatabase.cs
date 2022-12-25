using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    class handleDatabase
    {
        public SqlConnection conSQL = new SqlConnection();
        public handleDatabase()
        {

            conSQL.ConnectionString = "Data Source=DESKTOP-1NVCLO2;Initial Catalog=qlNhanVien;Integrated Security=True";
            try
            {
                conSQL.Open();
                MessageBox.Show("Ket noi thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi " + ex);
            }

        }
    }
}
