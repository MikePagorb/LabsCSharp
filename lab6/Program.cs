using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

//Програмне забезпечення фірми, що володіє морськими судами.
// База даних містить наступну інформацію: інформація про суди : назва;
//рік будівництва; порт приписки; ПІБ капітана; чисельність екіпажу;
//рік останнього капітального ремонту; перелік перевезених вантажів
//(із зазначенням місткості для кожного виду вантажу); інформація про замовлення
//на перевезення вантажів : номер договору про замовлення; відомості про
//підприємство-замовника(назва , країна ); вид і кількість перевезеного вантажу;
// порт відправлення і порт призначення(із зазначенням країни); дата відправлення;
//дата прибуття в порт призначення ; розмір плати за перевезення вантажу.
//Назва судна унікальна.Місткість судна може залежати від типу вантажу
//(наприклад , судно може вміщати до 10 тис.тонн піску або до 7 тис.тонн
//мінеральних добрив). Кожне замовлення на перевезення вантажу пов'язане тільки 
//з одним судном і з одним видом вантажу.Для кожного судна може бути декілька
//замовлень на перевезення вантажу (з різними номерами і датами виконання ) .

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=LAPTOP-E1KKJ6T9\SQLEXPRESS;Initial Catalog=Firm;Integrated Security=True;Pooling=true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection open");
                    String sqlcommand = "SET IDENTITY_INSERT Orders ON INSERT INTO Orders (ShipId,Customer,CargoType,CargoAmount,PortDeparture,PortDestination,DepartureDate,DestinationDate,Cost) VALUES (9,'^_^','Metal',5000,'Port1','Port4',CONVERT(datetime, '2018-11-27', 120),CONVERT(datetime, '2018-12-27', 120),20000)";
                    SqlCommand command = new SqlCommand(sqlcommand, connection);
                    command.ExecuteNonQuery();
                    //delete
                    command.CommandText = "DELETE  FROM Orders WHERE PortDestination='Port4'";
                    command.ExecuteNonQuery();
                    //add
                    command.CommandText = "INSERT INTO Orders (ShipId,Customer,CargoType,CargoAmount,PortDeparture,PortDestination,DepartureDate,DestinationDate,Cost) VALUES (10,'^_^','Metal',5000,'Port1','Port4',CONVERT(datetime, '2019-11-27', 120),CONVERT(datetime, '2020-01-15', 120),200000)";
                    command.ExecuteNonQuery();
                    //update
                    command.CommandText = "update Orders set Customer='*_*' where PortDestination='Port4'";
                    command.ExecuteNonQuery();


                    //Where
                    command.CommandText = "Select * from Orders where ShipId>5";
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows) // если есть данные
                    {
                        // выводим названия столбцов
                        Console.WriteLine("{0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | {8}", reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3), reader.GetName(4),
                            reader.GetName(5), reader.GetName(6), reader.GetName(7), reader.GetName(8));

                        while (reader.Read()) // построчно считываем данные
                        {

                            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}", reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4),
                            reader.GetValue(5), reader.GetValue(6), reader.GetValue(7), reader.GetValue(8));
                        }
                    }
                    reader.Close();
                    Console.WriteLine("*******************************************");

                    //Order By
                    command.CommandText = "select Cost from Orders order by Cost";
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Console.WriteLine(reader.GetName(0));
                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetValue(0));
                        }
                    }
                    reader.Close();
                    Console.WriteLine("*******************************************");
                    //Group by
                    command.CommandText = "select ShipId,Sum(Cost) as 'Sum' from Orders group by ShipId";
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Console.WriteLine("{0}\t{1}", reader.GetName(0), reader.GetName(1));
                        while (reader.Read())
                        {
                            Console.WriteLine("{0}\t{1}", reader.GetValue(0), reader.GetValue(1));
                        }
                    }
                    reader.Close();

                    //distinct
                    command.CommandText = "select Distinct ShipId from Orders";
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Console.WriteLine(reader.GetName(0));
                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetValue(0));
                        }
                    }
                    reader.Close();
                    Console.WriteLine("*******************************************");

                    //Count
                    command.CommandText = "select COUNT(*) as 'Count' from Orders";
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Console.WriteLine(reader.GetName(0));
                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetValue(0));
                        }
                    }
                    reader.Close();
                    Console.WriteLine("*******************************************");
                    //Min
                    command.CommandText = "select Min(Cost) as 'Min' from Orders";
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Console.WriteLine(reader.GetName(0));
                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetValue(0));
                        }
                    }
                    reader.Close();
                    Console.WriteLine("*******************************************");
                    //Max
                    command.CommandText = "select Max(Cost) as 'Max' from Orders";
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Console.WriteLine(reader.GetName(0));
                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetValue(0));
                        }
                    }
                    reader.Close();
                    Console.WriteLine("*******************************************");

                    //Inner Join
                    command.CommandText = "select Ships.ShipName,Orders.Customer from Ships inner join Orders on Orders.ShipId=Ships.ShipId";
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Console.WriteLine("{0}\t{1}", reader.GetName(0), reader.GetName(1));
                        while (reader.Read())
                        {
                            Console.WriteLine("{0}\t{1}", reader.GetValue(0), reader.GetValue(1));
                        }
                    }
                    reader.Close();
                    Console.WriteLine("*******************************************");
                    //Full Outer join
                    command.CommandText = "select Ships.ShipName,Orders.Customer from Ships full Outer join Orders on Orders.ShipId=Ships.ShipId";
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Console.WriteLine("{0}\t{1}", reader.GetName(0), reader.GetName(1));
                        while (reader.Read())
                        {
                            Console.WriteLine("{0}\t{1}", reader.GetValue(0), reader.GetValue(1));
                        }
                    }
                    reader.Close();
                    Console.WriteLine("*******************************************");
                    //Case
                    command.CommandText = "select ShipName,case when CrewSize>450 then 'Bolshe 450' when CrewSize=450 then 'Ravno 450' else 'Menshe 450' end from Ships";
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Console.WriteLine("{0}\t{1}", reader.GetName(0), reader.GetName(1));
                        while (reader.Read())
                        {
                            Console.WriteLine("{0}\t{1}", reader.GetValue(0), reader.GetValue(1));
                        }
                    }
                    reader.Close();
                    Console.WriteLine("*******************************************");
                    //Sel where
                    Console.WriteLine("Write where :");
                    string werecond = Console.ReadLine();
                    command.CommandText = "select ShipName from Ships where " + werecond;
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Console.WriteLine(reader.GetName(0));
                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetValue(0));
                        }
                    }
                    reader.Close();
                    Console.WriteLine("--------------------------------------------------");



                    SqlDataAdapter adapter = new SqlDataAdapter("Select ShipId,ShipName from Ships", connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    foreach (DataTable dt in ds.Tables)
                    {
                        Console.WriteLine(dt.TableName); // название таблицы
                                                         // перебор всех столбцов
                        foreach (DataColumn column in dt.Columns)
                            Console.Write("\t{0}", column.ColumnName);
                        Console.WriteLine();
                        // перебор всех строк таблицы
                        foreach (DataRow row in dt.Rows)
                        {
                            // получаем все ячейки строки
                            var cells = row.ItemArray;
                            foreach (object cell in cells)
                                Console.Write("\t{0}", cell);
                            Console.WriteLine();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    // закрываем подключение
                    connection.Close();
                    Console.WriteLine("Connection close...");
                }
            }

        }
    }
}
