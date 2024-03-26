using System.Text.Json;
using DOK_U.Classes;
using DOK_U.Forms;
using Microsoft.EntityFrameworkCore;


namespace DOK_U
{
    public partial class MainForm : Form
    {
        #region Vars

        public static Person currentUser;
        private int selectedDay;
        public static readonly string INITIAL_FILE = "../../../Source/Initial.json";
        private DatabaseContext db = new DatabaseContext();
        private bool selectedStudentChanged;

        #region Boxes

        private ComboBox[] lectureBoxes;
        private ComboBox[] cabinetBoxes;
        private ComboBox[] recordLectureBoxes;
        private ComboBox[] markBoxes;

        #endregion

        #endregion

        public MainForm()
        {
            InitializeComponent();
            contentTabs.SizeMode = TabSizeMode.Fixed;
            FormClosing += MainForm_FormClosing;
            FillArrays();
            notifyIcon.ContextMenuStrip = new ContextMenuStrip();
            notifyIcon.ContextMenuStrip.Items.Add("Закрыть приложение", null,
                delegate { Application.Exit(); });
            //db.Database.EnsureDeleted();
            LoadDB();
            //DBTest();
            LoadContent();
            Authorize();
            notifyIcon.Visible = true;
        }

        #region Test

        private void DBTest()
        {
            var groups = new Group[5];
            groups[0] = new Group(1, "--");
            groups[1] = new Group(2, "09-321(1)");
            groups[2] = new Group(3, "09-321(2)");
            groups[3] = new Group(4, "09-322(1)");
            groups[4] = new Group(5, "09-322(2)");

            var cabinets = new Cabinet[5];
            cabinets[0] = new Cabinet(1, "--");
            cabinets[1] = new Cabinet(2, "Двойка 1106");
            cabinets[2] = new Cabinet(3, "Двойка 108");
            cabinets[3] = new Cabinet(4, "Юрфак 100");
            cabinets[4] = new Cabinet(5, "УНИКС 2-й блок");


            var lectures = new Lecture[5];
            lectures[0] = new Lecture(1, 1, "--");
            lectures[1] = new Lecture(2, 3, "История России с Бродовской");
            lectures[2] = new Lecture(3, 3, "Матанализ с Сидоровым (Лекция)");
            lectures[3] = new Lecture(4, 5, "Физическая культура и спорт");
            lectures[4] = new Lecture(5, 2, "Практика по матанализу");

            var schedules = new Schedule[30];
            schedules[0] = new Schedule(1, 2, 1, 3, 3, 3, 3, 5, 1);
            schedules[1] = new Schedule(2, 2, 2, 3, 1, 3, 3, 5, 1);
            schedules[2] = new Schedule(3, 2, 3, 1, 1, 3, 3, 5, 1);
            schedules[3] = new Schedule(4, 2, 4, 1, 1, 1, 1, 1, 1);
            schedules[4] = new Schedule(5, 2, 5, 2, 2, 2, 5, 5, 1);
            schedules[5] = new Schedule(6, 2, 6, 4, 4, 4, 4, 1, 1);

            schedules[6] = new Schedule(7, 3, 1, 2, 3, 3, 3, 5, 1);
            schedules[7] = new Schedule(8, 3, 2, 2, 1, 3, 3, 5, 1);
            schedules[8] = new Schedule(9, 3, 3, 1, 1, 3, 3, 5, 1);
            schedules[9] = new Schedule(10, 3, 4, 5, 1, 1, 1, 1, 1);
            schedules[10] = new Schedule(11, 3, 5, 4, 2, 2, 5, 5, 1);
            schedules[11] = new Schedule(12, 3, 6, 4, 2, 4, 4, 1, 1);

            schedules[12] = new Schedule(13, 4, 1, 3, 3, 3, 3, 5, 1);
            schedules[13] = new Schedule(14, 4, 2, 3, 1, 3, 3, 5, 1);
            schedules[14] = new Schedule(15, 4, 3, 1, 1, 3, 3, 5, 1);
            schedules[15] = new Schedule(16, 4, 4, 1, 1, 1, 1, 1, 1);
            schedules[16] = new Schedule(17, 4, 5, 2, 2, 2, 5, 5, 1);
            schedules[17] = new Schedule(18, 4, 6, 4, 4, 4, 4, 1, 1);

            schedules[18] = new Schedule(19, 5, 1, 5, 4, 3, 2, 1, 1);
            schedules[19] = new Schedule(20, 5, 2, 5, 4, 3, 2, 1, 1);
            schedules[20] = new Schedule(21, 5, 3, 5, 4, 3, 2, 1, 1);
            schedules[21] = new Schedule(22, 5, 4, 5, 4, 3, 2, 1, 1);
            schedules[22] = new Schedule(23, 5, 5, 5, 4, 3, 2, 1, 1);
            schedules[23] = new Schedule(24, 5, 6, 5, 4, 3, 2, 1, 1);

            schedules[24] = new Schedule(25, 1, 1, 1, 1, 1, 1, 1, 1);
            schedules[25] = new Schedule(26, 1, 2, 1, 1, 1, 1, 1, 1);
            schedules[26] = new Schedule(27, 1, 3, 1, 1, 1, 1, 1, 1);
            schedules[27] = new Schedule(28, 1, 4, 1, 1, 1, 1, 1, 1);
            schedules[28] = new Schedule(29, 1, 5, 1, 1, 1, 1, 1, 1);
            schedules[29] = new Schedule(30, 1, 6, 1, 1, 1, 1, 1, 1);


            var users = new Person[5];
            users[0] = new Person(1,
                        "Деканат",
                        "Админ",
                        "Админович",
                        "М",
                        true,
                        "dekanat",
                        "ilovekpfu",
                        new DateTime(1804, 1, 1),
                        1,
                        "password");
            users[1] = new Person(2,
                        "Диана",
                        "Логинова",
                        "Романовна",
                        "Ж",
                        false,
                        "SLDR",
                        "12345678",
                        new DateTime(2005, 04, 25),
                        2,
                        "password");
            users[2] = new Person(3,
                        "Илья",
                        "Лещенко",
                        "Федорович",
                        "М",
                        false,
                        "mailofilyusha",
                        "12345678",
                        new DateTime(2005, 12, 29),
                        3,
                        "password");
            users[3] = new Person(4,
                        "Диана",
                        "Бекер",
                        "Вадимовна",
                        "Ж",
                        false,
                        "лучшийповарпм",
                        "cooking123",
                        new DateTime(2004, 7, 1),
                        5,
                        "password");
            users[4] = new Person(5,
                        "Мурад",
                        "Мурадович",
                        "Мурадов",
                        "М",
                        false,
                        "мурадка",
                        "12345678",
                        new DateTime(1, 1, 1),
                        3,
                        "password");

            var marks = new Mark[users.Count() * 8 * 7];
            for (int i = 0; i < marks.Count(); i++)
            {
                marks[i] = new Mark(i + 1, i % users.Count() + 1, 1, i % 8 + 1, "--");
            }

            foreach (var user in users)
            {
                db.Users.Add(user);
            }

            foreach (var group in groups)
            {
                db.Groups.Add(group);
            }

            foreach (var cabinet in cabinets)
            {
                db.Cabinets.Add(cabinet);
            }

            foreach (var schedule in schedules)
            {
                db.Schedules.Add(schedule);
            }

            foreach (var lecture in lectures)
            {
                db.Lectures.Add(lecture);
            }

            foreach (var mark in marks)
            {
                db.Marks.Add(mark);
            }

            db.SaveChanges();
        }

        #endregion

        private void LoadDB()
        {
            db.Database.EnsureCreated();
            db.Users.Load();
            db.Groups.Load();
            db.Schedules.Load();
            db.Marks.Load();
            db.Lectures.Load();
            db.Cabinets.Load();
            DataContext = db.Users.Local.ToObservableCollection();
        }

        private void Authorize()
        {
            if (!TryAuthorize())
            {
                var authorize = new AuthorizeForm();
                authorize.ShowDialog();
                TryAuthorize();
            }

            SetupUser(currentUser);
        }

        private void SetupUser(Person user)
        {
            if (user != null)
            {
                nameContent.Text = currentUser.FullName();
                loginContent.Text = user.Login;
                birthdayContent.Text = $"{user.Birthday.Day:D2}.{user.Birthday.Month:D2}.{user.Birthday.Year}";
                sexContent.Text = user.Sex == "М" ? "Мужской" : "Женский";
                groupContent.Text = db.Groups.Find(currentUser.GroupId).GroupNumber;

                var today = (int)DateTime.Today.DayOfWeek;
                today = today == 7 ? 1 : today;
                selectedDay = today;

                studentBox.SelectedItem = currentUser.FullName();
                groupBox.SelectedItem = db.Groups.Find(currentUser.GroupId).GroupNumber;

                ToggleAdminSettings(currentUser.IsAdmin);
                LoadRecordsOf(int.Parse(semesterBox.SelectedItem.ToString()));
                LockDayButton(selectedDay);
                LoadScheduleOf(selectedDay);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                WindowState = FormWindowState.Minimized;
                ShowInTaskbar = false;
                e.Cancel = true;
            }
        }

        private bool TryAuthorize()
        {
            if (File.Exists(INITIAL_FILE))
            {
                try
                {
                    currentUser = JsonSerializer.Deserialize<Person>(File.ReadAllText(INITIAL_FILE));
                    return true;
                }
                catch (IOException e)
                {
                    return false;
                }
                catch (JsonException e)
                {
                    return false;
                }
            }

            return false;
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            contentTabs.SelectTab("profile");
            profileButton.Enabled = false;
            diaryButton.Enabled = true;
            recordBookButton.Enabled = true;
            infoButton.Enabled = true;
        }

        private void diaryButton_Click(object sender, EventArgs e)
        {
            contentTabs.SelectTab("diary");
            LockDayButton(selectedDay);
            LoadScheduleOf(selectedDay);
            profileButton.Enabled = true;
            diaryButton.Enabled = false;
            recordBookButton.Enabled = true;
            infoButton.Enabled = true;
        }

        private void recordBookButton_Click(object sender, EventArgs e)
        {
            contentTabs.SelectTab("recordBook");
            profileButton.Enabled = true;
            diaryButton.Enabled = true;
            recordBookButton.Enabled = false;
            infoButton.Enabled = true;
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            contentTabs.SelectTab("info");
            profileButton.Enabled = true;
            diaryButton.Enabled = true;
            recordBookButton.Enabled = true;
            infoButton.Enabled = false;
        }

        private void notifyIcon_MouseClick(object sender, EventArgs eventArgs)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
                ShowInTaskbar = true;
            }

            Activate();
        }

        private void FillArrays()
        {
            lectureBoxes = new[]
            {
                lectureBox1,
                lectureBox2,
                lectureBox3,
                lectureBox4,
                lectureBox5,
                lectureBox6
            };

            cabinetBoxes = new[]
            {
                cabinetBox1,
                cabinetBox2,
                cabinetBox3,
                cabinetBox4,
                cabinetBox5,
                cabinetBox6
            };

            recordLectureBoxes = new[]
            {
                recordLectureBox1,
                recordLectureBox2,
                recordLectureBox3,
                recordLectureBox4,
                recordLectureBox5,
                recordLectureBox6,
                recordLectureBox7
            };

            markBoxes = new[]
            {
                markBox1,
                markBox2,
                markBox3,
                markBox4,
                markBox5,
                markBox6,
                markBox7
            };
        }

        private void ToggleAdminSettings(bool value)
        {
            foreach (var box in lectureBoxes)
            {
                box.Enabled = value;
            }

            foreach (var box in cabinetBoxes)
            {
                box.Enabled = value;
            }

            foreach (var box in recordLectureBoxes)
            {
                box.Enabled = value;
            }

            foreach (var box in markBoxes)
            {
                box.Enabled = value;
            }

            groupBox.Enabled = value;
            studentBox.Enabled = value;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите выйти?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите выйти из учетной записи?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                File.Delete(INITIAL_FILE);
                Authorize();
            }
        }

        private void LoadRecordsOf(int termNumber)
        {
            selectedStudentChanged = true;
            var fio = studentBox.SelectedItem.ToString().Split(" ");
            var user = db.Users.FromSqlRaw(
                "SELECT * FROM Users " +
                "WHERE " +
                $"  LastName = '{fio[0]}' AND " +
                $"  FirstName = '{fio[1]}' AND " +
                $"  Surname = '{fio[2]}' " +
                $"LIMIT 1").ToList()[0];

            var term = db.Marks.FromSqlRaw(
                "SELECT * FROM Marks " +
                "WHERE " +
                $"  StudentId = {user.Id} AND " +
                $"  TermNumber = {termNumber}").ToList();

            for (int i = 0; i < term.Count; i++)
            {
                recordLectureBoxes[i].SelectedItem = db.Lectures.Find(term[i].LectureId).Value;
                markBoxes[i].SelectedItem = term[i].Value;
            }
            selectedStudentChanged = false;
        }

        private void LoadScheduleOf(int day)
        {
            try
            {
                var group = db.Groups.FromSqlRaw(
                    "SELECT * FROM Groups " +
                    "WHERE " +
                    $"  GroupNumber = '{groupBox.SelectedItem}' " +
                    $"LIMIT 1").ToList()[0];

                var schedule = db.Schedules.FromSqlRaw(
                    "SELECT * FROM Schedules " +
                    "WHERE " +
                    $"  GroupId = {group.Id} AND " +
                    $"  Day = {day} " +
                    $"LIMIT 1").ToList()[0];

                lectureBox1.SelectedItem = db.Lectures.Find(schedule.Lecture1Id).Value;
                lectureBox2.SelectedItem = db.Lectures.Find(schedule.Lecture2Id).Value;
                lectureBox3.SelectedItem = db.Lectures.Find(schedule.Lecture3Id).Value;
                lectureBox4.SelectedItem = db.Lectures.Find(schedule.Lecture4Id).Value;
                lectureBox5.SelectedItem = db.Lectures.Find(schedule.Lecture5Id).Value;
                lectureBox6.SelectedItem = db.Lectures.Find(schedule.Lecture6Id).Value;

                cabinetBox1.SelectedItem = db.Cabinets.Find(db.Lectures.Find(schedule.Lecture1Id).CabinetId).CabinetNumber;
                cabinetBox2.SelectedItem = db.Cabinets.Find(db.Lectures.Find(schedule.Lecture2Id).CabinetId).CabinetNumber;
                cabinetBox3.SelectedItem = db.Cabinets.Find(db.Lectures.Find(schedule.Lecture3Id).CabinetId).CabinetNumber;
                cabinetBox4.SelectedItem = db.Cabinets.Find(db.Lectures.Find(schedule.Lecture4Id).CabinetId).CabinetNumber;
                cabinetBox5.SelectedItem = db.Cabinets.Find(db.Lectures.Find(schedule.Lecture5Id).CabinetId).CabinetNumber;
                cabinetBox6.SelectedItem = db.Cabinets.Find(db.Lectures.Find(schedule.Lecture6Id).CabinetId).CabinetNumber;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Не удалось загрузить рассписание",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void LoadContent()
        {
            var lectures = db.Lectures.ToList();
            foreach (var box in lectureBoxes)
            {
                foreach (var lecture in lectures)
                {
                    box.Items.Add(lecture.Value);
                }
            }

            foreach (var box in recordLectureBoxes)
            {
                foreach (var lecture in lectures)
                {
                    box.Items.Add(lecture.Value);
                }
            }

            foreach (var box in markBoxes)
            {
                box.Items.Add("--");
                box.Items.Add("зач");
                box.Items.Add("незач");
                for (int i = 0; i <= 100; i++)
                {
                    box.Items.Add(i.ToString());
                }
            }

            var cabinets = db.Cabinets.ToList();
            foreach (var box in cabinetBoxes)
            {
                foreach (var cabinet in cabinets)
                {
                    box.Items.Add(cabinet.CabinetNumber);
                }
            }

            var groups = db.Groups.ToList();
            foreach (var group in groups)
            {
                groupBox.Items.Add(group.GroupNumber);
            }

            var students = db.Users.ToList();
            foreach (var student in students)
            {
                studentBox.Items.Add(student.FullName());
            }
        }

        private void mn_Click(object sender, EventArgs e)
        {
            selectedDay = 1;
            LockDayButton(1);
            LoadScheduleOf(1);
        }

        private void tu_Click(object sender, EventArgs e)
        {
            selectedDay = 2;
            LockDayButton(2);
            LoadScheduleOf(2);
        }

        private void wd_Click(object sender, EventArgs e)
        {
            selectedDay = 3;
            LockDayButton(3);
            LoadScheduleOf(3);
        }

        private void th_Click(object sender, EventArgs e)
        {
            selectedDay = 4;
            LockDayButton(4);
            LoadScheduleOf(4);
        }

        private void fr_Click(object sender, EventArgs e)
        {
            selectedDay = 5;
            LockDayButton(5);
            LoadScheduleOf(5);
        }

        private void st_Click(object sender, EventArgs e)
        {
            selectedDay = 6;
            LockDayButton(6);
            LoadScheduleOf(6);
        }

        private void today_Click(object sender, EventArgs e)
        {
            var today = DateTime.Today.DayOfWeek;
            if ((int)today == 7)
            {
                MessageBox.Show("Сегодня воскресенье",
                        "Воскресенье",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            else
            {
                LockDayButton((int)today);
                LoadScheduleOf((int)today);
            }
        }

        private void tommorow_Click(object sender, EventArgs e)
        {
            var today = DateTime.Today.DayOfWeek;
            if ((int)today + 1 == 7)
            {
                MessageBox.Show("Завтра воскресенье",
                        "Воскресенье",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            else
            {
                var morrow = ((int)today + 1) % 7;
                LockDayButton(morrow);
                LoadScheduleOf(morrow);
            }
        }

        private void LockDayButton(int number)
        {
            mn.Enabled = true;
            tu.Enabled = true;
            wd.Enabled = true;
            th.Enabled = true;
            fr.Enabled = true;
            st.Enabled = true;
            switch (number)
            {
                case 1:
                    mn.Enabled = false;
                    break;
                case 2:
                    tu.Enabled = false;
                    break;
                case 3:
                    wd.Enabled = false;
                    break;
                case 4:
                    th.Enabled = false;
                    break;
                case 5:
                    fr.Enabled = false;
                    break;
                case 6:
                    st.Enabled = false;
                    break;
            }
        }

        private void semesterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRecordsOf(int.Parse(semesterBox.SelectedItem.ToString()));
        }

        private void groupBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (semesterBox.SelectedItem == null)
            {
                semesterBox.SelectedItem = "1";
            }

            LockDayButton(selectedDay);
            LoadScheduleOf(selectedDay);
        }

        private void studentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (semesterBox.SelectedItem == null)
            {
                semesterBox.SelectedItem = "1";
            }

            LoadRecordsOf(int.Parse(semesterBox.SelectedItem.ToString()));
        }

        private void ChangeRecordLecture(ComboBox sender, int number)
        {
            var fio = studentBox.SelectedItem.ToString().Split(" ");
            var user = db.Users.FromSqlRaw(
                "SELECT * FROM Users " +
                "WHERE " +
                $"  LastName = '{fio[0]}' AND " +
                $"  FirstName = '{fio[1]}' AND " +
                $"  Surname = '{fio[2]}' " +
                $"LIMIT 1").ToList()[0];

            var lecture = db.Lectures.FromSqlRaw(
                "SELECT * FROM Lectures " +
                "WHERE " +
                $"  Value = '{sender.SelectedItem}' " +
                $"LIMIT 1").ToList()[0];

            var term = db.Marks.FromSqlRaw(
                "SELECT * FROM Marks " +
                "WHERE " +
                $"  StudentId = {user.Id} AND " +
                $"  TermNumber = {semesterBox.SelectedItem}").ToList();

            if (!selectedStudentChanged && lecture.Value != "--")
            {
                foreach (var mark in term)
                {
                    if (mark.LectureId == lecture.Id)
                    {
                        MessageBox.Show("Оценка за эту дисциплину уже выставленна",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        LoadRecordsOf(int.Parse(semesterBox.SelectedItem.ToString()));
                        return;
                    }
                }
            }

            if (term.Count < number)
            {
                return;
            }

            term[number - 1].LectureId = lecture.Id;
            db.SaveChanges();
            LoadRecordsOf(int.Parse(semesterBox.SelectedItem.ToString()));
        }

        private void ChangeScheduleLecture(ComboBox sender, int number)
        {
            var group = db.Groups.FromSqlRaw(
                "SELECT * FROM Groups " +
                "WHERE " +
                $"  GroupNumber = '{groupBox.SelectedItem}' " +
                $"LIMIT 1").ToList()[0];

            var lecture = db.Lectures.FromSqlRaw(
                "SELECT * FROM Lectures " +
                "WHERE " +
                $"  Value = '{sender.SelectedItem}' " +
                $"LIMIT 1").ToList()[0];

            var schedule = db.Schedules.FromSqlRaw(
                "SELECT * FROM Schedules " +
                "WHERE " +
                $"  GroupId = {group.Id} AND " +
                $"  Day = {selectedDay} " +
                $"LIMIT 1").ToList()[0];

            switch (number)
            {
                case 1:
                    schedule.Lecture1Id = lecture.Id;
                    break;
                case 2:
                    schedule.Lecture2Id = lecture.Id;
                    break;
                case 3:
                    schedule.Lecture3Id = lecture.Id;
                    break;
                case 4:
                    schedule.Lecture4Id = lecture.Id;
                    break;
                case 5:
                    schedule.Lecture5Id = lecture.Id;
                    break;
                case 6:
                    schedule.Lecture6Id = lecture.Id;
                    break;
            }

            db.SaveChanges();
            LoadScheduleOf(selectedDay);
        }

        private void ChangeCabinet(ComboBox sender, int number)
        {
            var lectureBox = lectureBoxes[number - 1];

            var lecture = db.Lectures.FromSqlRaw(
                "SELECT * FROM Lectures " +
                "WHERE " +
                $"  Value = '{lectureBox.SelectedItem}' " +
                $"LIMIT 1").ToList()[0];

            var cabinet = db.Cabinets.FromSqlRaw(
                "SELECT * FROM Cabinets " +
                "WHERE " +
                $"  CabinetNumber = '{sender.SelectedItem}' " +
                $"LIMIT 1").ToList()[0];

            lecture.CabinetId = cabinet.Id;

            db.SaveChanges();
            LoadScheduleOf(selectedDay);
        }

        private void ChangeMark(ComboBox sender, int number)
        {
            var fio = studentBox.SelectedItem.ToString().Split(" ");
            var user = db.Users.FromSqlRaw(
                "SELECT * FROM Users " +
                "WHERE " +
                $"  LastName = '{fio[0]}' AND " +
                $"  FirstName = '{fio[1]}' AND " +
                $"  Surname = '{fio[2]}' " +
                $"LIMIT 1").ToList()[0];

            var term = db.Marks.FromSqlRaw(
                "SELECT * FROM Marks " +
                "WHERE " +
                $"  StudentId = {user.Id} AND " +
                $"  TermNumber = {semesterBox.SelectedItem}").ToList();

            if (term.Count < number)
            {
                return;
            }

            term[number - 1].Value = sender.SelectedItem.ToString();
            db.SaveChanges();
            LoadRecordsOf(int.Parse(semesterBox.SelectedItem.ToString()));
        }

        private void recordLectureBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeRecordLecture((ComboBox)sender, 1);
        }

        private void recordLectureBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeRecordLecture((ComboBox)sender, 2);
        }

        private void recordLectureBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeRecordLecture((ComboBox)sender, 3);
        }

        private void recordLectureBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeRecordLecture((ComboBox)sender, 4);
        }

        private void recordLectureBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeRecordLecture((ComboBox)sender, 5);
        }

        private void recordLectureBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeRecordLecture((ComboBox)sender, 6);
        }

        private void recordLectureBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeRecordLecture((ComboBox)sender, 7);
        }

        private void markBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeMark((ComboBox)sender, 1);
        }

        private void markBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeMark((ComboBox)sender, 2);
        }

        private void markBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeMark((ComboBox)sender, 3);
        }

        private void markBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeMark((ComboBox)sender, 4);
        }

        private void markBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeMark((ComboBox)sender, 5);
        }

        private void markBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeMark((ComboBox)sender, 6);
        }

        private void markBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeMark((ComboBox)sender, 7);
        }

        private void lectureBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeScheduleLecture((ComboBox)sender, 1);
        }

        private void lectureBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeScheduleLecture((ComboBox)sender, 2);
        }

        private void lectureBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeScheduleLecture((ComboBox)sender, 3);
        }

        private void lectureBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeScheduleLecture((ComboBox)sender, 4);
        }

        private void lectureBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeScheduleLecture((ComboBox)sender, 5);
        }

        private void lectureBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeScheduleLecture((ComboBox)sender, 6);
        }

        private void cabinetBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeCabinet((ComboBox)sender, 1);
        }

        private void cabinetBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeCabinet((ComboBox)sender, 2);
        }

        private void cabinetBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeCabinet((ComboBox)sender, 3);
        }

        private void cabinetBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeCabinet((ComboBox)sender, 4);
        }

        private void cabinetBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeCabinet((ComboBox)sender, 5);
        }

        private void cabinetBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeCabinet((ComboBox)sender, 6);
        }

        private void extraCodesButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFileDialog.FileName;
            var rand = new Random(DateTime.Now.Microsecond);
            var code = rand.NextInt64(int.MaxValue, long.MaxValue).ToString("X");

            File.WriteAllText(filename,
                "Ваш резервный код для сброса пароля:\n" +
                "\n" +
                $"\t{code}" +
                "\n" +
                "\nСохраните его в надежном месте и не сообщайте никому!" +
                "\nДля сброса пароля воспользуйтесь кнопкой \"Забыли пароль?\" в окне входа");

            db.Users.Find(currentUser.Id).ReserveCode = code;
            db.SaveChanges();
            MessageBox.Show("Резервный код создан успешно!",
                        "Успешно!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
        }

        private void nameContent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Обратитесь в администрацию КФУ для изменения информации о ваших инициалах",
            "Информация",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void birthdayContent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Обратитесь в администрацию КФУ для изменения информации о вашей дате рождения",
            "Информация",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void sexContent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Обратитесь в администрацию КФУ для изменения информации о вашем поле",
            "Информация",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void groupContent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Обратитесь в администрацию КФУ для изменения информации о вашей группе",
            "Информация",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void loginContent_Click(object sender, EventArgs e)
        {
            var change = new ChangeLoginForm();
            change.ShowDialog();

            loginContent.Text = currentUser.Login;
        }
    }
}