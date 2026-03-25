using MySql.Data.MySqlClient;
using System;

public class Class1
{
	public void getData()
	{
		string conString = "server = localhost; uid = root; pwd =; database = accounts"
		MySqlConnection con = new MySqlConnection(conString);
		con.Open();
	}
}
