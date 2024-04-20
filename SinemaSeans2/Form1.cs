using SinemaSeans2.Services;
using SinemaSeans2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using static System.Collections.Specialized.BitVector32;

namespace SinemaSeans2
{
    public partial class Form1 : Form
    {
        private static string connectionString = "Data Source=..\\..\\Files\\SinemaSeansDb.db;Version=3;";
        string movieName;
        int movieId;
        int selected_session;
        List<string> occupiedSeats;
        string selectedSeat;

        public Form1()
        {
            InitializeComponent();
            ListFilms();
        }

        DbService _service = new DbService();

        private void ListFilms()
        {
            var movies = _service.GetMovies();
            cb_selectMovie.DataSource = movies.Select(m => m.movieName).ToList();
            cb_selectMovie.SelectedIndex = -1;
        }
        private void ClearAll()
        {
            cb_selectMovie.SelectedIndex = -1;
            ListSessions(null,null);
        }

        private void btn_confirmMovie_Click(object sender, EventArgs e)
        {
            if (cb_selectMovie.SelectedItem != null)
            {
                tabControl.SelectedTab = tabPage2;
                ListSessions(sender, e);
            }
            else
            {
                MessageBox.Show("Lütfen bir film seçin.");
            }
        }

        private void ListSessions(object sender, EventArgs e)
        {
            movieName = cb_selectMovie.SelectedItem.ToString();
            lb_movie.Text = movieName;
            movieId = _service.GetMovieIdByName(movieName);
            var sessions = _service.GetSessionsByMovie(movieId);
            dgv_session.Rows.Clear();
            foreach (var session in sessions)
            {
                dgv_session.Rows.Add(session.id, session.date, session.time, movieName, session.theaterId);
            }
        }

        private void dgv_session_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idColumnIndex = 0;
            int ClickedRowIndex = e.RowIndex;

            DataGridViewRow selectedRow = dgv_session.Rows[ClickedRowIndex];

            if (selectedRow.Cells[idColumnIndex].Value != null)
            {
                selected_session = Convert.ToInt32(selectedRow.Cells[idColumnIndex].Value);
                tabControl.SelectedTab = tabPage3;
                lb_selectedMovie.Text = "Seçilen Film: " + movieName;
                lb_selectedSession.Text = "Seçilen Seans: " + selected_session.ToString();
                ClearTheaterSeats();
                GetOccupiedSeats(selected_session);
                CreateTheaterSeats(3, 10, occupiedSeats);
            }
        }
        private void GetOccupiedSeats(int sessionId)
        {
            occupiedSeats = _service.GetSeatNumbersBySessionId(sessionId);
        }
        private void ClearTheaterSeats()
        {
            TabPage tabPage3 = tabControl.TabPages["tabPage3"];
            foreach (Control control in tabPage3.Controls.OfType<Button>().ToList())
            {
                if (control.Name != "bnt_confirmSeat")
                {
                    tabPage3.Controls.Remove(control);
                    control.Dispose();
                }
            }
        }

        private void CreateTheaterSeats(int rowCount, int columnCount, List<string> occupiedSeats)
        {
            const int seatGap = 5;
            const int seatWidth = 50;
            const int seatHeight = 50;

            char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            int totalWidth = columnCount * (seatWidth + seatGap);
            int totalHeight = rowCount * (seatHeight + seatGap);
            int startX = (ClientSize.Width - totalWidth) / 2;
            int startY = (ClientSize.Height - totalHeight) / 2;
            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < columnCount; col++)
                {
                    Button btnSeat = new Button();
                    btnSeat.Cursor = Cursors.Hand;
                    btnSeat.Name = $"btnSeat_{letters[row]}{col + 1}";
                    btnSeat.Text = $"{letters[row]}{col + 1}";
                    if (occupiedSeats.Contains(btnSeat.Text))
                    {
                        btnSeat.BackColor = Color.Red;
                        btnSeat.ForeColor = Color.Black;
                    }
                    btnSeat.Width = seatWidth;
                    btnSeat.Height = seatHeight;
                    btnSeat.Left = startX + col * (seatWidth + seatGap);
                    btnSeat.Top = startY + row * (seatHeight + seatGap);
                    btnSeat.Click += BtnSeat_Click;
                    tabPage3.Controls.Add(btnSeat);
                }
            }
        }
        private void BtnSeat_Click(object sender, EventArgs e)
        {
            string seatName = ((Button)sender).Name;
            string seatNumber = seatName.Substring(seatName.IndexOf('_') + 1);
            if (occupiedSeats.Contains(seatNumber))
            {
                MessageBox.Show("Koltuk Zaten Alındı");
                return;
            }
            selectedSeat = seatNumber;

            lb_selectedSeat.Text = $"Seçilen Koltuk: {selectedSeat}";
        }

        private void bnt_confirmSeat_Click(object sender, EventArgs e)
        {
            if (selectedSeat != null)
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string insertReservationQuery = $@"
                    INSERT INTO Reservations (seatNo, sessionId) VALUES ('{selectedSeat}', {selected_session});";

                    using (var command = new SQLiteCommand(insertReservationQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }


                movieName = null;
                movieId = -1;
                cb_selectMovie.SelectedIndex = -1;

                lb_movie.Text = "Film";
                selected_session = -1;
                dgv_session.Rows.Clear();

                lb_selectedMovie.Text = "Seçilen Film:";
                lb_selectedSession.Text = "Seçilen Seans:";
                ClearTheaterSeats();
                occupiedSeats = null;
                selectedSeat = null;
                lb_selectedSeat.Text = "Seçilen Koltuk";

                MessageBox.Show("İşleminiz Tamamlandı");
                tabControl.SelectedTab = tabPage1;
            }
        }
    }
}
