using System.Data;// veritabanı işlemleri için temel kütüphane
using System.Data.SqlClient;// sql işmlweri için ADONET kütüphanesi


namespace WindowsFormsAppAdoNetCRUD
{
    internal class OrtakDAL
    {
        internal SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB; Database=WindowsFormsAppAdoNetCrud; Integrated Security=True;");
        // veritabanımın bulunduğu server bilgisini connection stirng olarak burada tanımlıyorum.

        internal void ConnectionControl()
        {
            if (_connection.State != ConnectionState.Open) // Eğer veritabanı bağlantım açık değilse
            {
                _connection.Open();// Aç

            }
        }

        public DataTable GetDataTable(string sqlSorgu)
        {
            var dt = new DataTable();// geri döndüreceğim datatable nesnesini oluşturuyorum.

            ConnectionControl();// database bağlantısı kapalıysa açacak metot


            var command = new SqlCommand(sqlSorgu, _connection); // serverda sql sorgusu çalıştıracak command nesnesi oluşturuyorum.

            SqlDataReader reader = command.ExecuteReader();// sql sorgusunu çalıştırıp sonuçları reader nesnesine atıyorum.


            dt.Load(reader);// reader nesnesindeki verileri datatable nesnesine yüklüyorum.

            reader.Close();// reader nesnesini kapatıyorum.

            _connection.Close();// database bağlantısını kapatıyorum.(_connection nesnesini kapat)

            command.Dispose();// komutu bellekten atıyorum.(yoket)

            return dt;// db den okunan verileri gönder.

        }
    }
}
