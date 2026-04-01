using System.Data.SqlClient;

namespace WindowsFormsAppAdoNetCRUD
{
    internal class KullaniciDAL : OrtakDAL
    {
        public int Add(User user)
        {
            int sonuc = 0;
            ConnectionControl();
            var command = new SqlCommand("insert into users(Name, Surname, Email, Password, IsActive, CreateDate) values (@Name, @Surname, @Email, @Password, @IsActive, @CreateDate)", _connection);
            command.Parameters.AddWithValue("@Name", user.Name);
            command.Parameters.AddWithValue("@Surname", user.Surname);
            command.Parameters.AddWithValue("@Email", user.Email);
            command.Parameters.AddWithValue("@Password", user.Password);
            command.Parameters.AddWithValue("@IsActive", user.IsActive);
            command.Parameters.AddWithValue("@CreateDate", user.CreateDate);
            sonuc = command.ExecuteNonQuery(); // sonuc değişkenine sql de etkilenen kayıt sayısını ata.

            command.Dispose();
            _connection.Close();

            return sonuc;
        }

        public int Update(User user)
        {
            int sonuc = 0;
            ConnectionControl();
            var command = new SqlCommand("Update users set Name=@Name,Surname=@Surname, Email=@Email, Password=@Password, IsActive=@IsActive, CreateDate=@CreateDate where Id=@Id", _connection);
            command.Parameters.AddWithValue("@Id", user.Id);
            command.Parameters.AddWithValue("@Name", user.Name);
            command.Parameters.AddWithValue("@Surname", user.Surname);
            command.Parameters.AddWithValue("@Email", user.Email);
            command.Parameters.AddWithValue("@Password", user.Password);
            command.Parameters.AddWithValue("@IsActive", user.IsActive);
            command.Parameters.AddWithValue("@CreateDate", user.CreateDate);
            sonuc = command.ExecuteNonQuery(); // sonuc değişkenine sql de etkilenen kayıt sayısını ata.

            command.Dispose();
            _connection.Close();

            return sonuc;
        }

        public int Delete(User user)
        {
            int sonuc = 0;
            ConnectionControl();
            var command = new SqlCommand("delete from users where Id=@Id", _connection);
            command.Parameters.AddWithValue("@Id", user.Id);
            sonuc = command.ExecuteNonQuery(); // sonuc değişkenine sql de etkilenen kayıt sayısını ata.

            command.Dispose();
            _connection.Close();

            return sonuc;
        }
    }
}
