namespace SinemaSeans2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_confirmMovie = new System.Windows.Forms.Button();
            this.lb_selectMovie = new System.Windows.Forms.Label();
            this.cb_selectMovie = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lb_movie = new System.Windows.Forms.Label();
            this.dgv_session = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dasf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theaterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bnt_confirmSeat = new System.Windows.Forms.Button();
            this.lb_selectedSeat = new System.Windows.Forms.Label();
            this.lb_selectedMovie = new System.Windows.Forms.Label();
            this.lb_selectedSession = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_session)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_confirmMovie);
            this.tabPage1.Controls.Add(this.lb_selectMovie);
            this.tabPage1.Controls.Add(this.cb_selectMovie);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_confirmMovie
            // 
            this.btn_confirmMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_confirmMovie.Location = new System.Drawing.Point(213, 245);
            this.btn_confirmMovie.Name = "btn_confirmMovie";
            this.btn_confirmMovie.Size = new System.Drawing.Size(113, 40);
            this.btn_confirmMovie.TabIndex = 5;
            this.btn_confirmMovie.Text = "Onayla";
            this.btn_confirmMovie.UseVisualStyleBackColor = true;
            this.btn_confirmMovie.Click += new System.EventHandler(this.btn_confirmMovie_Click);
            // 
            // lb_selectMovie
            // 
            this.lb_selectMovie.AutoSize = true;
            this.lb_selectMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_selectMovie.Location = new System.Drawing.Point(208, 140);
            this.lb_selectMovie.Name = "lb_selectMovie";
            this.lb_selectMovie.Size = new System.Drawing.Size(118, 25);
            this.lb_selectMovie.TabIndex = 4;
            this.lb_selectMovie.Text = "Film Seçin:";
            // 
            // cb_selectMovie
            // 
            this.cb_selectMovie.FormattingEnabled = true;
            this.cb_selectMovie.Location = new System.Drawing.Point(348, 144);
            this.cb_selectMovie.Name = "cb_selectMovie";
            this.cb_selectMovie.Size = new System.Drawing.Size(236, 21);
            this.cb_selectMovie.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lb_movie);
            this.tabPage2.Controls.Add(this.dgv_session);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lb_movie
            // 
            this.lb_movie.AutoSize = true;
            this.lb_movie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_movie.Location = new System.Drawing.Point(370, 30);
            this.lb_movie.Name = "lb_movie";
            this.lb_movie.Size = new System.Drawing.Size(52, 25);
            this.lb_movie.TabIndex = 1;
            this.lb_movie.Text = "Film";
            // 
            // dgv_session
            // 
            this.dgv_session.AllowUserToAddRows = false;
            this.dgv_session.AllowUserToDeleteRows = false;
            this.dgv_session.AllowUserToResizeColumns = false;
            this.dgv_session.AllowUserToResizeRows = false;
            this.dgv_session.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_session.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.date,
            this.time,
            this.dasf,
            this.theaterId,
            this.select});
            this.dgv_session.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_session.Location = new System.Drawing.Point(3, 86);
            this.dgv_session.Name = "dgv_session";
            this.dgv_session.Size = new System.Drawing.Size(786, 335);
            this.dgv_session.TabIndex = 0;
            this.dgv_session.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_session_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // time
            // 
            this.time.HeaderText = "time";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // dasf
            // 
            this.dasf.HeaderText = "movieName";
            this.dasf.Name = "dasf";
            this.dasf.ReadOnly = true;
            // 
            // theaterId
            // 
            this.theaterId.HeaderText = "theaterId";
            this.theaterId.Name = "theaterId";
            this.theaterId.ReadOnly = true;
            // 
            // select
            // 
            this.select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.select.HeaderText = "select";
            this.select.Name = "select";
            this.select.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lb_selectedSession);
            this.tabPage3.Controls.Add(this.lb_selectedMovie);
            this.tabPage3.Controls.Add(this.bnt_confirmSeat);
            this.tabPage3.Controls.Add(this.lb_selectedSeat);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bnt_confirmSeat
            // 
            this.bnt_confirmSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bnt_confirmSeat.Location = new System.Drawing.Point(658, 362);
            this.bnt_confirmSeat.Name = "bnt_confirmSeat";
            this.bnt_confirmSeat.Size = new System.Drawing.Size(126, 49);
            this.bnt_confirmSeat.TabIndex = 1;
            this.bnt_confirmSeat.Text = "Onayla";
            this.bnt_confirmSeat.UseVisualStyleBackColor = true;
            this.bnt_confirmSeat.Click += new System.EventHandler(this.bnt_confirmSeat_Click);
            // 
            // lb_selectedSeat
            // 
            this.lb_selectedSeat.AutoSize = true;
            this.lb_selectedSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_selectedSeat.Location = new System.Drawing.Point(8, 374);
            this.lb_selectedSeat.Name = "lb_selectedSeat";
            this.lb_selectedSeat.Size = new System.Drawing.Size(155, 25);
            this.lb_selectedSeat.TabIndex = 0;
            this.lb_selectedSeat.Text = "Seçilen Koltuk:";
            // 
            // lb_selectedMovie
            // 
            this.lb_selectedMovie.AutoSize = true;
            this.lb_selectedMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_selectedMovie.Location = new System.Drawing.Point(8, 3);
            this.lb_selectedMovie.Name = "lb_selectedMovie";
            this.lb_selectedMovie.Size = new System.Drawing.Size(135, 25);
            this.lb_selectedMovie.TabIndex = 2;
            this.lb_selectedMovie.Text = "Seçilen Film:";
            // 
            // lb_selectedSession
            // 
            this.lb_selectedSession.AutoSize = true;
            this.lb_selectedSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_selectedSession.Location = new System.Drawing.Point(8, 39);
            this.lb_selectedSession.Name = "lb_selectedSession";
            this.lb_selectedSession.Size = new System.Drawing.Size(156, 25);
            this.lb_selectedSession.TabIndex = 3;
            this.lb_selectedSession.Text = "Seçilen Seans:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_session)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_confirmMovie;
        private System.Windows.Forms.Label lb_selectMovie;
        private System.Windows.Forms.ComboBox cb_selectMovie;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lb_movie;
        private System.Windows.Forms.DataGridView dgv_session;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn dasf;
        private System.Windows.Forms.DataGridViewTextBoxColumn theaterId;
        private System.Windows.Forms.DataGridViewButtonColumn select;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button bnt_confirmSeat;
        private System.Windows.Forms.Label lb_selectedSeat;
        private System.Windows.Forms.Label lb_selectedSession;
        private System.Windows.Forms.Label lb_selectedMovie;
    }
}

