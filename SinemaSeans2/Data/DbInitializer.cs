using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SinemaSeans2.Data
{
    public static class DbInitializer
    {
        private static string connectionString = "Data Source=..\\..\\Files\\SinemaSeansDb.db;Version=3;";

        public static void InitializeDatabase()
        {
            if (!File.Exists("..\\..\\Files\\SinemaSeansDb.db"))
            {
                SQLiteConnection.CreateFile("..\\..\\Files\\SinemaSeansDb.db");

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Movies
                    string createMoviesTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Movies(
                        id INTEGER PRIMARY KEY NOT NULL,
                        movieName TEXT NOT NULL,
                        movieGenre TEXT NOT NULL
                    );";
                    string insertMovieQuery = @"
                    INSERT INTO Movies (movieName, movieGenre) VALUES ('The Hangover', 'Komedi');
                    INSERT INTO Movies (movieName, movieGenre) VALUES ('Recep İvedik 12', 'İlahi Komedi');";
          
                    
                    // Theaters
                    string createTheatersTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Theaters(
                        id INTEGER PRIMARY KEY NOT NULL,
                        theaterCapacity INTEGER NOT NULL
                    );";
                    string insertTheaterQuery = @"
                    INSERT INTO Theaters (theaterCapacity) VALUES (30);
                    INSERT INTO Theaters (theaterCapacity) VALUES (30);
                    INSERT INTO Theaters (theaterCapacity) VALUES (30);
                    INSERT INTO Theaters (theaterCapacity) VALUES (30);";

                    // Sessions
                    string createSessionsTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Sessions(
                        id INTEGER PRIMARY KEY NOT NULL,
                        date TEXT NOT NULL,
                        time TEXT NOT NULL,
                        movieId INTEGER NOT NULL,
                        theaterId INTEGER NOT NULL,

                        FOREIGN KEY (movieId) REFERENCES Movies(id),
                        FOREIGN KEY (theaterId) REFERENCES Theaters(id)
                    );";
                    string insertSessionQuery = @"
                    INSERT INTO Sessions (date, time, movieId, theaterId) VALUES ('01.01.2025', '19:00', 1, 1);
                    INSERT INTO Sessions (date, time, movieId, theaterId) VALUES ('01.01.2025', '23:00', 1, 1);
                    INSERT INTO Sessions (date, time, movieId, theaterId) VALUES ('01.01.2025', '19:00', 1, 2);
                    INSERT INTO Sessions (date, time, movieId, theaterId) VALUES ('01.01.2025', '23:00', 1, 2);

                    INSERT INTO Sessions (date, time, movieId, theaterId) VALUES ('01.01.2025', '19:00', 2, 3);
                    INSERT INTO Sessions (date, time, movieId, theaterId) VALUES ('01.01.2025', '23:00', 2, 3);
                    INSERT INTO Sessions (date, time, movieId, theaterId) VALUES ('01.01.2025', '19:00', 2, 4);
                    INSERT INTO Sessions (date, time, movieId, theaterId) VALUES ('01.01.2025', '23:00', 2, 4);";

                    // Reservation
                    string createReservationsTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Reservations(
                        id INTEGER PRIMARY KEY NOT NULL,
                        seatNo TEXT NOT NULL,
                        sessionId INTEGER NOT NULL,

                        FOREIGN KEY (sessionId) REFERENCES Sessions(id)
                    );";
                    string insertReservationQuery = @"
                    INSERT INTO Reservations (seatNo, sessionId) VALUES ('a1', 1);
                    INSERT INTO Reservations (seatNo, sessionId) VALUES ('a2', 1);
                    INSERT INTO Reservations (seatNo, sessionId) VALUES ('a3', 1);";

                    using (var command = new SQLiteCommand(connection))
                    {
                        // Movies
                        command.CommandText = createMoviesTableQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = insertMovieQuery;
                        command.ExecuteNonQuery();

                        // Theaters
                        command.CommandText = createTheatersTableQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = insertTheaterQuery;
                        command.ExecuteNonQuery();

                        // Sessions
                        command.CommandText = createSessionsTableQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = insertSessionQuery;
                        command.ExecuteNonQuery();

                        // Reservation
                        command.CommandText = createReservationsTableQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = insertReservationQuery;
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
