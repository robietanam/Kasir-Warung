using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace PBO_Kasir.models
{
    public class kasbonModel
    {
        SqlDBHelper objSqlDb = new SqlDBHelper();

        public kasbonModel()
        {

        }
        public DataTable ambilKasbon()
        {
            string query = "SELECT row_number(*) over() as nomor,kode_kasbon, nama_bon,atas_nama,jumlah_bon,tanggal_pinjam,tenggat_bayar FROM kasbon;";
            DataTable dt = objSqlDb.ExecuteQuery(query);
            return dt;
        }
        public void hapusData(string kodeBon)
        {

            string query = "Delete From kasbon where kode_kasbon = '{0}' ";
            query = string.Format(query, kodeBon);
            objSqlDb.ExecuteNonQuery(query);
        }

        public void updateKason(string kodeBon, string namaBon, string atasnama, float jumlah, string tanggalPinjam, string tenggatBayar)
        {
            string query = @"update kasbon set kode_kasbon = :kode::varchar(255),
                                nama_bon = :namaBon::varchar(255),
                                atas_nama = :nama::varchar(255) , 
                                jumlah_bon = :jumlah::float,
                                tanggal_pinjam = :tanggalPinjam::date,
                                tenggat_bayar = :tenggatBayar::date
                                where kode_kasbon = :kode::varchar(255);";

            objSqlDb.ExecuteNonQuery(query,
                new NpgsqlParameter(":kode",kodeBon),
                new NpgsqlParameter(":namaBon", namaBon),
                new NpgsqlParameter(":nama", atasnama),
                new NpgsqlParameter(":jumlah", jumlah),
                new NpgsqlParameter(":tanggalPinjam", tanggalPinjam),
                new NpgsqlParameter(":tenggatBayar", tenggatBayar)
                );
        }

        public void tambahBon(string kodeBon, string namaBon, string atasNama,string jumlahBon, string tanggalPinjam, string tanggalBayar)
        {
            string query = "insert into kasbon (kode_kasbon, nama_bon, atas_nama, jumlah_bon, tanggal_pinjam, tenggat_bayar) values ('{0}','{1}','{2}','{3}','{4}','{5}');";
            query = string.Format(query, kodeBon, namaBon, atasNama, jumlahBon, tanggalPinjam, tanggalBayar);
            objSqlDb.ExecuteNonQuery(query);


        }

    }
}
