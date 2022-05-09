using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;


namespace WCFBanKem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public Service1()
        {
            getConnect();
        }

        SqlConnection connect;
        SqlCommand command;
        //thực hiện kết nối với csdl
        void getConnect()
        {
            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Thang\OneDrive\Desktop\QuanLyQuanKem\QuanLyQuanKemWCF\QuanLyQuanKemWCF\iceCream.mdf;Integrated Security=True");
            command = connect.CreateCommand();
        }


        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        //hiển thị database
        public List<Ice_cream> getIceCream()
        {
            List<Ice_cream> list = new List<Ice_cream>();
            try
            {
                command.CommandText = "SELECT * FROM tbl_IceCream";
                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Ice_cream ice = new Ice_cream()
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["name"].ToString(),
                        price = Convert.ToDecimal(reader["price"]),
                        numberorder = Convert.ToInt32(reader["numberOrder"])
                    };
                    list.Add(ice);
                }

                return list;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connect!=null)
                {
                    connect.Close();
                }
            }
           
        }
        //thêm
        public int addIceCream(Ice_cream i)
        {
            try
            {
                command.CommandText = "INSERT INTO tbl_IceCream VALUES (@id,@name,@price,@numberorder)";
                command.Parameters.AddWithValue("id", i.Id);
                command.Parameters.AddWithValue("name", i.Name);
                command.Parameters.AddWithValue("price", i.price);
                command.Parameters.AddWithValue("numberorder", i.numberorder);
                command.CommandType = System.Data.CommandType.Text;
                connect.Open();

                return command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
           finally
            {
                if (connect!=null)
                {
                    connect.Close();
                }
            }          
        }
        //sửa
        public int editIceCream(Ice_cream i)
        {
            try
            {
                int condition = i.Id;
                command.CommandText = $"SELECT * FROM tbl_IceCream where Id = {condition}";
                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                if (command.ExecuteNonQuery()==0)
                {
                    return 0;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }

            try
            {
                command.CommandText = "UPDATE tbl_IceCream SET name= @name, price = @price, numberorder = @numberorder WHERE Id =@id";
                command.Parameters.AddWithValue("id", i.Id);
                command.Parameters.AddWithValue("name", i.Name);
                command.Parameters.AddWithValue("price", i.price);
                command.Parameters.AddWithValue("numberorder", i.numberorder);
                command.CommandType = System.Data.CommandType.Text;
                connect.Open();

                return command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }
        //xóa
        public int deleteIceCream(Ice_cream i)
        {
            try
            {
               
                command.CommandText = "DELETE FROM tbl_IceCream WHERE Id =@id";
                command.Parameters.AddWithValue("id", i.Id);
               
                command.CommandType = System.Data.CommandType.Text;
                connect.Open();

                return command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }
        //đặt kem
        public int datKem(Ice_cream i)
        {
            try
            {
                command.CommandText = "UPDATE tbl_IceCream SET numberorder = @numberorder WHERE Id =@id";
                command.Parameters.AddWithValue("id", i.Id);
                command.Parameters.AddWithValue("numberorder", (int)(i.numberorder + 1));
                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                return command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }
        //show kem bán chạy
        public List<Ice_cream> banduoc()
        {
            List<Ice_cream> list = new List<Ice_cream>();
            try
            {
                command.CommandText = "SELECT * FROM tbl_IceCream WHERE numberOrder >10";
                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Ice_cream ice = new Ice_cream()
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["name"].ToString(),
                        price = Convert.ToDecimal(reader["price"]),
                        numberorder = Convert.ToInt32(reader["numberOrder"])
                    };
                    list.Add(ice);
                }

                return list;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }
        //show kem bán ít
        public List<Ice_cream> tonlai()
        {
            List<Ice_cream> list = new List<Ice_cream>();
            try
            {
                command.CommandText = "SELECT * FROM tbl_IceCream WHERE numberOrder <10";
                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Ice_cream ice = new Ice_cream()
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["name"].ToString(),
                        price = Convert.ToDecimal(reader["price"]),
                        numberorder = Convert.ToInt32(reader["numberOrder"])
                    };
                    list.Add(ice);
                }

                return list;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }
        //tìm kiếm
        public List<Ice_cream> findIceCream(Ice_cream i)
        {
            List<Ice_cream> list = new List<Ice_cream>();
            try
            {
                command.CommandText = "SELECT * FROM tbl_IceCream where Id = @id";
                command.Parameters.AddWithValue("id", i.Id);
               
                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Ice_cream ice = new Ice_cream()
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["name"].ToString(),
                        price = Convert.ToDecimal(reader["price"]),
                        numberorder = Convert.ToInt32(reader["numberOrder"])
                    };
                    list.Add(ice);
                }

                return list;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }
       
    }
}
