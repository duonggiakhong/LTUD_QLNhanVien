using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_NhanVien
{
    public class DAO_NhanVien
    {
        string MaNV, GioiTinh, TDHocVan, MaThue, QuocTich, TonGiao, DanToc, HoVaTen, NoiSinh, DiaChi, MaLuong, Email, ChuyenMon;
        DateTime NgaySinh;
        int SoCMND, SDT;

        public DAO_NhanVien(string maNV, string gioiTinh, string tDHocVan, string maThue, string quocTich, string tonGiao, string danToc, string hoVaTen, string noiSinh, string diaChi, string maLuong, string email, string chuyenMon, DateTime ngaySinh, int soCMND, int sDT)
        {
            MaNV = maNV;
            GioiTinh = gioiTinh;
            TDHocVan = tDHocVan;
            MaThue = maThue;
            QuocTich = quocTich;
            TonGiao = tonGiao;
            DanToc = danToc;
            HoVaTen = hoVaTen;
            NoiSinh = noiSinh;
            DiaChi = diaChi;
            MaLuong = maLuong;
            Email = email;
            ChuyenMon = chuyenMon;
            NgaySinh = ngaySinh;
            SoCMND = soCMND;
            SDT = sDT;
        }

        public string ChuyenMon1
        {
            get
            {
                return ChuyenMon;
            }

            set
            {
                ChuyenMon = value;
            }
        }

        public string DanToc1
        {
            get
            {
                return DanToc;
            }

            set
            {
                DanToc = value;
            }
        }

        public string DiaChi1
        {
            get
            {
                return DiaChi;
            }

            set
            {
                DiaChi = value;
            }
        }

        public string Email1
        {
            get
            {
                return Email;
            }

            set
            {
                Email = value;
            }
        }

        public string GioiTinh1
        {
            get
            {
                return GioiTinh;
            }

            set
            {
                GioiTinh = value;
            }
        }

        public string HoVaTen1
        {
            get
            {
                return HoVaTen;
            }

            set
            {
                HoVaTen = value;
            }
        }

        public string MaLuong1
        {
            get
            {
                return MaLuong;
            }

            set
            {
                MaLuong = value;
            }
        }

        public string MaNV1
        {
            get
            {
                return MaNV;
            }

            set
            {
                MaNV = value;
            }
        }

        public string MaThue1
        {
            get
            {
                return MaThue;
            }

            set
            {
                MaThue = value;
            }
        }

        public DateTime NgaySinh1
        {
            get
            {
                return NgaySinh;
            }

            set
            {
                NgaySinh = value;
            }
        }

        public string NoiSinh1
        {
            get
            {
                return NoiSinh;
            }

            set
            {
                NoiSinh = value;
            }
        }

        public string QuocTich1
        {
            get
            {
                return QuocTich;
            }

            set
            {
                QuocTich = value;
            }
        }

        public int SDT1
        {
            get
            {
                return SDT;
            }

            set
            {
                SDT = value;
            }
        }

        public int SoCMND1
        {
            get
            {
                return SoCMND;
            }

            set
            {
                SoCMND = value;
            }
        }

        public string TDHocVan1
        {
            get
            {
                return TDHocVan;
            }

            set
            {
                TDHocVan = value;
            }
        }

        public string TonGiao1
        {
            get
            {
                return TonGiao;
            }

            set
            {
                TonGiao = value;
            }
        }
    }
}
