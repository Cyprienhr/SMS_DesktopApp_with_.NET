using System.Data.SQLite;
using System.Data;
using System.IO;

namespace StudentManagementSystem
{
    public static class DatabaseHelper
    {
        private static readonly string connectionString = "Data Source=StudentDB.sqlite;Version=3;";

        public static void InitializeDatabase()
        {
            if (!File.Exists("StudentDB.sqlite"))
            {
                SQLiteConnection.CreateFile("StudentDB.sqlite");

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string createTableQuery = @"
                    CREATE TABLE Students (
                        StudentID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Age INTEGER NOT NULL,
                        Grade TEXT NOT NULL
                    );

                    INSERT INTO Students (Name, Age, Grade) VALUES 
                    ('John Doe', 20, 'A'),
                    ('Cyprien Rwendere', 22, 'B'),
                    ('Elvis Kabera', 19, 'C');";

                    var command = new SQLiteCommand(createTableQuery, connection);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static DataTable GetStudents()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("SELECT * FROM Students", connection);
                var adapter = new SQLiteDataAdapter(command);

                var table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public static void AddStudent(string name, int age, string grade)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("INSERT INTO Students (Name, Age, Grade) VALUES (@name, @age, @grade)", connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@grade", grade);
                command.ExecuteNonQuery();
            }
        }

        public static void UpdateStudent(int id, string name, int age, string grade)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("UPDATE Students SET Name=@name, Age=@age, Grade=@grade WHERE StudentID=@id", connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@grade", grade);
                command.ExecuteNonQuery();
            }
        }

        public static void DeleteStudent(int id)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("DELETE FROM Students WHERE StudentID=@id", connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}
