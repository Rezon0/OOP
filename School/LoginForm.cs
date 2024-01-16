using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using ClassLibrary1.Entity;

namespace School
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NoAutorisationForm form = new NoAutorisationForm();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (KursachContext db = new())
            {
                User user = SelectClass.select_users(db, textBoxLogin.Text);
                if (user != null)
                {
                    if (user.Privilege == "admin")
                    {
                        if (user.Password == textBoxPassword.Text)
                        {
                            NurseHome form = new NurseHome(user);
                            form.ShowDialog();
                            return;
                        }
                        else
                            MessageBox.Show("Неверный логин или пароль!");
                    }

                    if (user.Privilege == "user")
                    {
                        if (user.Password == textBoxPassword.Text)
                        {
                            StudentHome form = new StudentHome(user);
                            form.ShowDialog();
                            return;
                        }
                        else
                            MessageBox.Show("Неверный логин или пароль!");
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!");
                }
            }


        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (KursachContext db = new())
            {
                // ВЫБОРКА В СПИСКЕ ДОЛЖНОСТЕЙ
                Post select_post(string NamePost)
                {
                    var SelectPostes = db.Postes
                        .Where(b => b.NamePost == NamePost)
                        .FirstOrDefault();

                    return SelectPostes;
                }

                // ВЫБОРКА В СПИСКЕ ПРИВИВОК
                ClassVaccination select_class_vaccinations(string NameClassVaccination)
                {
                    var SelectClassVaccinations = db.ClassVaccinations
                        .Where(b => b.NameClassVaccination == NameClassVaccination)
                        .FirstOrDefault();

                    return SelectClassVaccinations;
                }

                // ВЫБОРКА В СПИСКЕ ПРИВИВОК
                Vaccination select_vaccinations(string NameNameVaccination)
                {
                    var SelectVaccinations = db.Vaccinations
                        .Where(b => b.NameVaccination == NameNameVaccination)
                        .FirstOrDefault();

                    return SelectVaccinations;
                }

                // ВЫБОРКА В СПИСКЕ УЧЕБНЫХ КЛАССОВ
                SchoolClass select_school_class(string NameClass)
                {
                    var SelectSchoolClasses = db.SchoolClasses
                        .Where(b => b.NameClass == NameClass)
                        .FirstOrDefault();

                    return SelectSchoolClasses;
                }

                // ВЫБОРКА В СПИСКЕ МЕДУЧРЕЖДЕНИЙ
                DirectoryOfMedicalInstitution select_dir_med_inst(string NameMedInst)
                {
                    var SelectDirMedInst = db.DirectoryOfMedicalInstitutions
                        .Where(b => b.NameMedInst == NameMedInst)
                        .FirstOrDefault();


                    return SelectDirMedInst;
                }

                // ВЫБОРКА В СПИСКЕ АЛЛЕРГИЙ
                DirectoryOfAllergy select_dir_allergy(string NameAllergen)
                {
                    var SelectDirAllergyes = db.DirectoryOfAllergys
                        .Where(b => b.NameAllergen == NameAllergen)
                        .FirstOrDefault();

                    return SelectDirAllergyes;
                }

                // ВЫБОРКА В СПИСКЕ ЗАКОННОГО ПРЕДСТАВИТЕЛЯ
                DirectoryOfRepresentation select_dir_representation(string NameRepresentation)
                {
                    var SelectDirRepresentation = db.DirectoryOfRepresentations
                        .Where(b => b.NameRepresentation == NameRepresentation)
                        .FirstOrDefault();

                    return SelectDirRepresentation;
                }

                // ВЫБОРКА ШКОЛЬНИКОВ
                Student select_students(string LastName, string Name, string Patronymic, DateOnly Birthday)
                {
                    var SelectStudent = db.Students
                        .Where(b => b.Name == Name && b.Lastname == LastName && b.Patronymic == Patronymic && b.Birthday == Birthday)
                        .FirstOrDefault();

                    return SelectStudent;
                }

                // ВЫБОРКА В СПИСКЕ РОДИТЕЛЕЙ
                Parent select_parents(string LastName, string Name, string Patronymic, DateOnly Birthday)
                {
                    var SelectParent = db.Parents
                        .Where(b => b.Name == Name && b.Lastname == LastName && b.Patronymic == Patronymic && b.Birthday == Birthday)
                        .FirstOrDefault();

                    return SelectParent;
                }

                // ВЫБОРКА В СПИСКЕ ДИАГНОЗОВ
                DirectoryOfDiagnoses select_dir_diagnoses(string NameDiagnoses)
                {
                    var SelectDirDiagnoses = db.DirectoryOfDiagnoseses
                        .Where(b => b.NameDiagnoses == NameDiagnoses)
                        .FirstOrDefault();

                    return SelectDirDiagnoses;
                }

                // ВЫБОРКА ПРИВИВОЧНЫХ СЕРТИФИКАТОВ
                VaccinationCertificate select_vaccination_certificate(KursachContext db, Guid ID_Student)
                {
                    var selectVC = db.VaccinationCertificates
                        .Where(b => b.ID_Student == ID_Student)
                        .FirstOrDefault();
                    return selectVC;
                }


                // ДОБАВЛЕНИЕ ДОЛЖНОСТЕЙ
                void add_postes()
                {
                    Post[] posts = new Post[3];

                    for (int i = 0; i < posts.Length; i++)
                    {
                        posts[i] = new Post();
                    }

                    posts[0].Add("Старшая медсестра", 30000, "...");
                    posts[1].Add("Медсестра", 22000, "...");
                    posts[2].Add("Лаборант", 14000, "...");

                    foreach (var item in posts)
                    {
                        db.Postes.Add(item);
                    }

                    db.SaveChanges();
                }

                // ДОБАВЛЕНИЕ МЕДСЕСТЕР
                void add_nurses()
                {
                    Nurse[] nurses = new Nurse[3];

                    for (int i = 0; i < nurses.Length; i++)
                    {
                        nurses[i] = new Nurse();
                    }

                    nurses[0].Add("Высшая", "Арина", null, 'Ж', new DateOnly(1955, 11, 11), "+76666666666", "ArinaFuaran@mail.ru", "Fuaran", "123", select_post("Медсестра"), "admin");
                    nurses[1].Add("Сорокина", "Екатерина", "Тигрёнок", 'Ж', new DateOnly(1985, 03, 25), "+78005553535", "Tigrenok@mail.ru", "Tigrenok", "123", select_post("Старшая медсестра"), "admin");
                    nurses[2].Add("Донникова", "Алиса", null, 'Ж', new DateOnly(1973, 05, 01), "+79531333312", "Alice@mail.ru", "Alice", "123", select_post("Лаборант"), "admin");

                    foreach (var item in nurses)
                    {
                        db.Nurses.Add(item);
                    }

                    db.SaveChanges();
                }

                // ДОБАВЛЕНИЕ МЕДУЧРЕЖДЕНИЯ
                void add_med_inst()
                {
                    DirectoryOfMedicalInstitution[] dirOfMedInst = new DirectoryOfMedicalInstitution[17];

                    for (int i = 0; i < dirOfMedInst.Length; i++)
                    {
                        dirOfMedInst[i] = new DirectoryOfMedicalInstitution();
                    }

                    dirOfMedInst[0].Add("Поликлиника № 1", "ул. Дерендяева, 97, Киров, Кировская обл.");
                    dirOfMedInst[1].Add("Поликлиника № 2 Кировская Городская Больница №9", "ул. Сурикова, 26А, Киров, Кировская обл.");
                    dirOfMedInst[2].Add("Поликлиника № 6 ККДЦ", "Красноармейская ул., 30Б, Киров, Кировская обл.");
                    dirOfMedInst[3].Add("Поликлиника № 3 ККДЦ", "ул. Молодой Гвардии, 98, Киров, Кировская обл.");
                    dirOfMedInst[4].Add("Поликлиника № 5 ККДЦ", "Московская ул., 6, Киров, Кировская обл.");
                    dirOfMedInst[5].Add("Поликлиника № 7 ККДЦ", "ул. Карла Маркса, 47, Киров, Кировская обл.");
                    dirOfMedInst[6].Add("Поликлиника № 2 Кировская Городская Больница №8", "Производственная ул., 6, Киров, Кировская обл.");
                    dirOfMedInst[7].Add("КОГБУЗ 'Центр травматологии, ортопедии и нейрохирургии'", "ул. Менделеева, 17, Киров, Кировская обл.");
                    dirOfMedInst[8].Add("КОГБУЗ 'Инфекционная клиническая больница'", "Ленина ул., 207, Киров, Кировская обл.");
                    dirOfMedInst[9].Add("КОГБУЗ 'Северная клиническая больница скорой медицинской помощи'", "ул. Свердлова, 4, Киров, Кировская обл.");
                    dirOfMedInst[10].Add("Кировская Городская Больница № 5", "ул. Семашко, 1, Киров, Кировская обл.");
                    dirOfMedInst[11].Add("Кировская областная клиническая психиатрическая больница им. академика В.М. Бехтерева", "ул. Центральная, Киров, Кировская обл.");
                    dirOfMedInst[12].Add("Детская поликлиника №1", "ул. Карла Маркса, 42, Киров, Кировская обл.");
                    dirOfMedInst[13].Add("Детская поликлиника №2", "ул. Некрасова, 14, Киров, Кировская обл.");
                    dirOfMedInst[14].Add("Детская поликлиника №3", "Пролетарская ул., 21, Киров, Кировская обл.");
                    dirOfMedInst[15].Add("Детская поликлиника №4. Филиал", "ул. Монтажников, 32, Киров, Кировская обл.");
                    dirOfMedInst[16].Add("КОГБУЗ 'Детский клинический консультативно-диагностический центр Детская поликлиника № 2'", "ул. Некрасова, 40, Киров, Кировская обл.");

                    foreach (var item in dirOfMedInst)
                    {
                        db.DirectoryOfMedicalInstitutions.Add(item);
                    }

                    db.SaveChanges();
                }

                // ДОБАВЛЕНИЕ СПРАВОЧНИКА АЛЛЕРГИЙ
                void add_dir_allergy()
                {
                    DirectoryOfAllergy[] allergies = new DirectoryOfAllergy[72];

                    for (int i = 0; i < allergies.Length; i++)
                    {
                        allergies[i] = new DirectoryOfAllergy();
                    }

                    allergies[0].Add("Свинорой пальчатый");
                    allergies[1].Add("Тростник обыкновенный");
                    allergies[2].Add("Плевел многолетний (райграсс)");
                    allergies[3].Add("Тимофеевка луговая");
                    allergies[4].Add("Акация");
                    allergies[5].Add("Китайский ясень (айлант)");
                    allergies[6].Add("Ольха");
                    allergies[7].Add("Кипарис");
                    allergies[8].Add("Ясень");
                    allergies[9].Add("Тополь");
                    allergies[10].Add("Финиковая пальма");
                    allergies[11].Add("Вяз");
                    allergies[12].Add("Лещина");
                    allergies[13].Add("Платан кленолистный");
                    allergies[14].Add("Горный кедр");
                    allergies[15].Add("Шелковица (тутовое дерево)");
                    allergies[16].Add("Бук европейский");
                    allergies[17].Add("Дуб белый");
                    allergies[18].Add("Олива");
                    allergies[19].Add("Береза бородавчатая");
                    allergies[20].Add("Криптомерия японская");
                    allergies[21].Add("Орех грецкий");
                    allergies[22].Add("Пролесник");
                    allergies[23].Add("Конопля");
                    allergies[24].Add("Марь белая");
                    allergies[25].Add("Полынь обыкновенная");
                    allergies[26].Add("Крапива");
                    allergies[27].Add("Амбарный клещ");
                    allergies[28].Add("Американский таракан");
                    allergies[29].Add("Клещ домашней пыли (D.farinae)");
                    allergies[30].Add("Рыжий таракан");
                    allergies[31].Add("Кошка");
                    allergies[32].Add("Корова");
                    allergies[33].Add("Собака");
                    allergies[34].Add("Коза");
                    allergies[35].Add("Оса обыкновенная");
                    allergies[36].Add("Пчела медоносная");
                    allergies[37].Add("Оса длинноголовая");
                    allergies[38].Add("Оса бумажная (полиста)");
                    allergies[39].Add("Ячмень");
                    allergies[40].Add("Гречиха");
                    allergies[41].Add("Кукуруза");
                    allergies[42].Add("Рожь");
                    allergies[43].Add("Просо");
                    allergies[44].Add("Овес");
                    allergies[45].Add("Маковое семя");
                    allergies[46].Add("Тыква");
                    allergies[47].Add("Рис");
                    allergies[48].Add("Кунжут");
                    allergies[49].Add("Пшеница");
                    allergies[50].Add("Яичный белок");
                    allergies[51].Add("Яичный желток");
                    allergies[52].Add("Молоко коровье");
                    allergies[53].Add("Козье молоко");
                    allergies[54].Add("Яблоко");
                    allergies[55].Add("Банан");
                    allergies[56].Add("Черника");
                    allergies[57].Add("Вишня");
                    allergies[58].Add("Инжир");
                    allergies[59].Add("Виноград");
                    allergies[60].Add("Киви");
                    allergies[61].Add("Манго");
                    allergies[62].Add("Дыня");
                    allergies[63].Add("Персик");
                    allergies[64].Add("Апельсин");
                    allergies[65].Add("Груша");
                    allergies[66].Add("Миндаль");
                    allergies[67].Add("Кешью");
                    allergies[68].Add("Фундук");
                    allergies[69].Add("Фисташки");
                    allergies[70].Add("Горох");
                    allergies[71].Add("Орех грецкий");

                    foreach (var item in allergies)
                    {
                        db.DirectoryOfAllergys.Add(item);
                    }

                    db.SaveChanges();
                }

                // ДОБАВЛЕНИЕ ДИАГНОЗОВ
                void add_dir_diagnoses()
                {
                    DirectoryOfDiagnoses[] diagnoses = new DirectoryOfDiagnoses[30];

                    for (int i = 0; i < diagnoses.Length; i++)
                    {
                        diagnoses[i] = new DirectoryOfDiagnoses();
                    }

                    diagnoses[0].Add("Туберкулез");
                    diagnoses[1].Add("Гепатит А");
                    diagnoses[2].Add("Гепатит B");
                    diagnoses[3].Add("Гепатит C");
                    diagnoses[4].Add("ВИЧ");
                    diagnoses[5].Add("Дифтерия");
                    diagnoses[6].Add("Лепра");
                    diagnoses[7].Add("Малярия");
                    diagnoses[8].Add("Холера");
                    diagnoses[9].Add("Чума");
                    diagnoses[10].Add("ОРВИ");
                    diagnoses[11].Add("ОРЗ");
                    diagnoses[12].Add("Анемия");
                    diagnoses[13].Add("Энцефалит");
                    diagnoses[14].Add("Бореллиоз");
                    diagnoses[15].Add("Дизентерия");
                    diagnoses[16].Add("Сальмонеллез");
                    diagnoses[17].Add("Брюшной тиф");
                    diagnoses[18].Add("Гастроэнтерит");
                    diagnoses[19].Add("Ветряная оспа");
                    diagnoses[20].Add("Герпес");
                    diagnoses[21].Add("Псориаз");
                    diagnoses[22].Add("Свинка");
                    diagnoses[23].Add("Корь");
                    diagnoses[24].Add("Краснуха");
                    diagnoses[25].Add("Желтуха");
                    diagnoses[26].Add("Опоясывающий лишай");
                    diagnoses[27].Add("Вирусный гастроэнтерит (желудочный грипп");
                    diagnoses[28].Add("Инфекционный мононуклеоз");
                    diagnoses[29].Add("Вирус папилломы человека (ВПЧ)");

                    foreach (var item in diagnoses)
                    {
                        db.DirectoryOfDiagnoseses.Add(item);
                    }

                    db.SaveChanges();
                }

                // ДОБАВЛЕНИЕ КЛАССА ПРИВИВОК
                void add_class_vaccination()
                {
                    ClassVaccination[] classVaccinations = new ClassVaccination[2];

                    for (int i = 0; i < classVaccinations.Length; i++)
                    {
                        classVaccinations[i] = new ClassVaccination();
                    }

                    classVaccinations[0].Add("Профилактическая прививка (делается один раз)");
                    classVaccinations[1].Add("Профилактических прививок по эпидемическим показаниям");

                    foreach (var item in classVaccinations)
                    {
                        db.ClassVaccinations.Add(item);
                    }

                    db.SaveChanges();
                }

                // ДОБАВЛЕНИЕ КЛАССА УЧЕНИКОВ
                void add_school_class()
                {
                    SchoolClass[] schoolClass = new SchoolClass[10];

                    for (int i = 0; i < schoolClass.Length; i++)
                    {
                        schoolClass[i] = new SchoolClass();
                    }

                    schoolClass[0].Add("11");
                    schoolClass[1].Add("10");
                    schoolClass[2].Add("9А");
                    schoolClass[3].Add("9Б");
                    schoolClass[4].Add("8А");
                    schoolClass[5].Add("8Б");
                    schoolClass[6].Add("7А");
                    schoolClass[7].Add("7Б");
                    schoolClass[8].Add("6А");
                    schoolClass[9].Add("6Б");

                    foreach (var item in schoolClass)
                    {
                        db.SchoolClasses.Add(item);
                    }

                    db.SaveChanges();
                }

                // ДОБАВЛЕНИЕ ПРИВИВОК
                void add_vaccination()
                {
                    Vaccination[] vaccinations = new Vaccination[55];

                    for (int i = 0; i < vaccinations.Length; i++)
                    {
                        vaccinations[i] = new Vaccination();
                    }

                    vaccinations[0].Add(select_class_vaccinations("Профилактическая прививка (делается один раз)"), "Первая вакцинация против вирусного гепатита В", DateTime.Now.Date.AddDays(1).Subtract(DateTime.Now.Date));
                    vaccinations[1].Add(select_class_vaccinations("Профилактическая прививка (делается один раз)"), "Вакцинация против туберкулеза", DateTime.Now.Date.AddDays(7).Subtract(DateTime.Now.Date));
                    vaccinations[2].Add(select_class_vaccinations("Профилактическая прививка (делается один раз)"), "Вторая вакцинация против вирусного гепатита В", DateTime.Now.Date.AddMonths(1).Subtract(DateTime.Now.Date));
                    vaccinations[3].Add(select_class_vaccinations("Профилактическая прививка (делается один раз)"), "Третья вакцинация против вирусного гепатита В (группы риска);", DateTime.Now.Date.AddMonths(2).Subtract(DateTime.Now.Date));
                    vaccinations[4].Add(select_class_vaccinations("Профилактическая прививка (делается один раз)"), "Первая вакцинация против пневмококковой инфекции", DateTime.Now.Date.AddMonths(2).Subtract(DateTime.Now.Date));
                    vaccinations[5].Add(select_class_vaccinations("Профилактическая прививка (делается один раз)"), "Первая вакцинация против дифтерии, коклюша, столбняка", DateTime.Now.Date.AddMonths(3).Subtract(DateTime.Now.Date));
                    vaccinations[6].Add(select_class_vaccinations("Профилактическая прививка (делается один раз)"), "Первая вакцинация против полиомиелита", DateTime.Now.Date.AddMonths(3).Subtract(DateTime.Now.Date));
                    vaccinations[7].Add(select_class_vaccinations("Профилактическая прививка (делается один раз)"), "Первая вакцинация против гемофильной инфекции типа b", DateTime.Now.Date.AddMonths(3).Subtract(DateTime.Now.Date));
                    vaccinations[8].Add(select_class_vaccinations("Профилактическая прививка (делается один раз)"), "Вторая вакцинация против дифтерии, коклюша, столбняка", DateTime.Now.Date.AddMonths(4).Subtract(DateTime.Now.Date));
                    vaccinations[9].Add(select_class_vaccinations("Профилактическая прививка (делается один раз)"), "Вторая вакцинация против гемофильной инфекции типа b", DateTime.Now.Date.AddMonths(4).Subtract(DateTime.Now.Date));
                    vaccinations[10].Add(select_class_vaccinations("Профилактическая прививка (делается один раз)"), "Вторая вакцинация против полиомиелита", DateTime.Now.Date.AddMonths(4).Subtract(DateTime.Now.Date));
                    vaccinations[11].Add(select_class_vaccinations("Профилактическая прививка (делается один раз)"), "Вторая вакцинация против пневмококковой инфекции", DateTime.Now.Date.AddMonths(4).Subtract(DateTime.Now.Date));
                    vaccinations[12].Add(select_class_vaccinations("Профилактическая прививка (делается один раз)"), "Третья вакцинация против дифтерии, коклюша, столбняка", DateTime.Now.Date.AddMonths(6).Subtract(DateTime.Now.Date));
                    vaccinations[13].Add(select_class_vaccinations("Профилактическая прививка (делается один раз)"), "Третья вакцинация против вирусного гепатита B", DateTime.Now.Date.AddMonths(6).Subtract(DateTime.Now.Date));
                    vaccinations[14].Add(select_class_vaccinations("Профилактическая прививка (делается один раз)"), "Третья вакцинация против полиомиелита", DateTime.Now.Date.AddMonths(6).Subtract(DateTime.Now.Date));
                    vaccinations[15].Add(select_class_vaccinations("Профилактическая прививка (делается один раз)"), "Третья вакцинация против гемофильной инфекции типа b", DateTime.Now.Date.AddMonths(6).Subtract(DateTime.Now.Date));
                    vaccinations[16].Add(select_class_vaccinations("Профилактическая прививка (делается один раз)"), "Вакцинация против кори, краснухи, эпидемического паротита", DateTime.Now.Date.AddMonths(12).Subtract(DateTime.Now.Date));
                    vaccinations[17].Add(select_class_vaccinations("Профилактическая прививка (делается один раз)"), "Четвертая вакцинация против вирусного гепатита B (группы риска)", DateTime.Now.Date.AddMonths(12).Subtract(DateTime.Now.Date));
                    vaccinations[18].Add(select_class_vaccinations("Профилактическая прививка (делается один раз)"), "Ревакцинация против пневмококковой инфекции", DateTime.Now.Date.AddMonths(15).Subtract(DateTime.Now.Date));
                    vaccinations[19].Add(select_class_vaccinations("Профилактическая прививка (делается один раз)"), "Первая ревакцинация против дифтерии, коклюша, столбняка", DateTime.Now.Date.AddMonths(18).Subtract(DateTime.Now.Date));
                    vaccinations[20].Add(select_class_vaccinations("Профилактическая прививка (делается один раз)"), "Первая ревакцинация против полиомиелита", DateTime.Now.Date.AddMonths(18).Subtract(DateTime.Now.Date));
                    vaccinations[21].Add(select_class_vaccinations("Профилактическая прививка (делается один раз)"), "Ревакцинация против гемофильной инфекции типа b", DateTime.Now.Date.AddMonths(18).Subtract(DateTime.Now.Date));
                    vaccinations[22].Add(select_class_vaccinations("Профилактическая прививка (делается один раз)"), "Вторая ревакцинация против полиомиелита", DateTime.Now.Date.AddMonths(20).Subtract(DateTime.Now.Date));
                    vaccinations[23].Add(select_class_vaccinations("Профилактическая прививка (делается один раз)"), "Ревакцинация против кори, краснухи, эпидемического паротита", DateTime.Now.Date.AddYears(6).Subtract(DateTime.Now.Date));
                    vaccinations[24].Add(select_class_vaccinations("Профилактическая прививка (делается один раз)"), "Третья ревакцинация против полиомиелита", DateTime.Now.Date.AddYears(6).Subtract(DateTime.Now.Date));
                    vaccinations[25].Add(select_class_vaccinations("Профилактическая прививка (делается один раз)"), "Вторая ревакцинация против дифтерии, столбняка", DateTime.Now.Date.AddYears(7).Subtract(DateTime.Now.Date));
                    vaccinations[26].Add(select_class_vaccinations("Профилактическая прививка (делается один раз)"), "Ревакцинация против туберкулеза", DateTime.Now.Date.AddYears(7).Subtract(DateTime.Now.Date));
                    vaccinations[27].Add(select_class_vaccinations("Профилактическая прививка (делается один раз)"), "Третья ревакцинация против дифтерии, столбняка", DateTime.Now.Date.AddYears(14).Subtract(DateTime.Now.Date));
                    vaccinations[28].Add(select_class_vaccinations("Профилактическая прививка (делается один раз)"), "Вакцинация против вирусного гепатита B", DateTime.Now.Date.AddYears(17).Subtract(DateTime.Now.Date));
                    vaccinations[29].Add(select_class_vaccinations("Профилактическая прививка (делается один раз)"), "Вакцинация против краснухи, ревакцинация против краснухи", DateTime.Now.Date.AddYears(17).Subtract(DateTime.Now.Date));
                    vaccinations[30].Add(select_class_vaccinations("Профилактическая прививка (делается один раз)"), "Вакцинация против кори, ревакцинация против кори", DateTime.Now.Date.AddYears(17).Subtract(DateTime.Now.Date));
                    vaccinations[31].Add(select_class_vaccinations("Профилактических прививок по эпидемическим показаниям"), "Против туляремии", TimeSpan.MaxValue);
                    vaccinations[32].Add(select_class_vaccinations("Профилактических прививок по эпидемическим показаниям"), "Против чумы", TimeSpan.MaxValue);
                    vaccinations[33].Add(select_class_vaccinations("Профилактических прививок по эпидемическим показаниям"), "Против бруцеллеза", TimeSpan.MaxValue);
                    vaccinations[34].Add(select_class_vaccinations("Профилактических прививок по эпидемическим показаниям"), "Против сибирской язвы", TimeSpan.MaxValue);
                    vaccinations[35].Add(select_class_vaccinations("Профилактических прививок по эпидемическим показаниям"), "Против бешенства", TimeSpan.MaxValue);
                    vaccinations[36].Add(select_class_vaccinations("Профилактических прививок по эпидемическим показаниям"), "Против лептоспироза", TimeSpan.MaxValue);
                    vaccinations[37].Add(select_class_vaccinations("Профилактических прививок по эпидемическим показаниям"), "Против клещевого вирусного энцефалита", TimeSpan.MaxValue);
                    vaccinations[38].Add(select_class_vaccinations("Профилактических прививок по эпидемическим показаниям"), "Против лихорадки Ку", TimeSpan.MaxValue);
                    vaccinations[39].Add(select_class_vaccinations("Профилактических прививок по эпидемическим показаниям"), "Против желтой лихорадки", TimeSpan.MaxValue);
                    vaccinations[40].Add(select_class_vaccinations("Профилактических прививок по эпидемическим показаниям"), "Против холеры", TimeSpan.MaxValue);
                    vaccinations[41].Add(select_class_vaccinations("Профилактических прививок по эпидемическим показаниям"), "Против брюшного тифа", TimeSpan.MaxValue);
                    vaccinations[42].Add(select_class_vaccinations("Профилактических прививок по эпидемическим показаниям"), "Против вирусного гепатита А", TimeSpan.MaxValue);
                    vaccinations[43].Add(select_class_vaccinations("Профилактических прививок по эпидемическим показаниям"), "Против шигеллезов", TimeSpan.MaxValue);
                    vaccinations[44].Add(select_class_vaccinations("Профилактических прививок по эпидемическим показаниям"), "Против менингококковой инфекции", TimeSpan.MaxValue);
                    vaccinations[45].Add(select_class_vaccinations("Профилактических прививок по эпидемическим показаниям"), "Против кори", TimeSpan.MaxValue);
                    vaccinations[46].Add(select_class_vaccinations("Профилактических прививок по эпидемическим показаниям"), "Против вирусного гепатита В", TimeSpan.MaxValue);
                    vaccinations[47].Add(select_class_vaccinations("Профилактических прививок по эпидемическим показаниям"), "Против дифтерии", TimeSpan.MaxValue);
                    vaccinations[48].Add(select_class_vaccinations("Профилактических прививок по эпидемическим показаниям"), "Против эпидемического паротита", TimeSpan.MaxValue);
                    vaccinations[49].Add(select_class_vaccinations("Профилактических прививок по эпидемическим показаниям"), "Против полиомиелита", TimeSpan.MaxValue);
                    vaccinations[50].Add(select_class_vaccinations("Профилактических прививок по эпидемическим показаниям"), "Против пневмококковой инфекции", TimeSpan.MaxValue);
                    vaccinations[51].Add(select_class_vaccinations("Профилактических прививок по эпидемическим показаниям"), "Против ротавирусной инфекции", TimeSpan.MaxValue);
                    vaccinations[52].Add(select_class_vaccinations("Профилактических прививок по эпидемическим показаниям"), "Против ветряной оспы", TimeSpan.MaxValue);
                    vaccinations[53].Add(select_class_vaccinations("Профилактических прививок по эпидемическим показаниям"), "Против гемофильной инфекции", TimeSpan.MaxValue);
                    vaccinations[54].Add(select_class_vaccinations("Профилактических прививок по эпидемическим показаниям"), "Против коронавирусной инфекции, вызываемой вирусом SARS-CoV-2", TimeSpan.MaxValue);

                    foreach (var item in vaccinations)
                    {
                        db.Vaccinations.Add(item);
                    }

                    db.SaveChanges();
                }

                // ДОБАВЛЕНИЕ УЧЕНИКОВ
                void add_student()
                {
                    Student[] students = new Student[10];

                    for (int i = 0; i < students.Length; i++)
                    {
                        students[i] = new Student();
                    }

                    students[0].Add("Бондаренко", "Алексей", "Петрович", 'М', new DateOnly(2001, 12, 16), "+79539539553", "bonAlex@mail.ru", "bondarenkoAlesha", "123", new DateOnly(2001, 12, 20), select_school_class("10"), select_dir_med_inst("Детская поликлиника №1"), "user");
                    students[1].Add("Шутов", "Антон", "Алексеевич", 'М', new DateOnly(2002, 09, 06), "+79539539552", "shutTosha@mail.ru", "shutovAnton", "123", new DateOnly(2002, 09, 12), select_school_class("10"), select_dir_med_inst("Детская поликлиника №2"), "user");
                    students[2].Add("Вотинцев", "Савелий", "Андреевич", 'М', new DateOnly(2003, 12, 29), "+79539539551", "votSav@mail.ru", "votincevSavely", "123", new DateOnly(2003, 12, 29), select_school_class("8А"), select_dir_med_inst("Детская поликлиника №3"), "user");
                    students[3].Add("Веккер", "Эльвира", "Викторовна", 'Ж', new DateOnly(2002, 07, 16), "+79539539550", "pirozhok2002@mail.ru", "vekkerElvira", "123", new DateOnly(2002, 07, 25), select_school_class("10"), select_dir_med_inst("Поликлиника № 1"), "user");
                    students[4].Add("Субботин", "Дмитрий", "Леонидович", 'М', new DateOnly(2001, 05, 15), "+79539539559", "subDmitry@mail.ru", "subbotinDmitry", "123", new DateOnly(2001, 05, 21), select_school_class("11"), select_dir_med_inst("Поликлиника № 2 Кировская Городская Больница №9"), "user");
                    students[5].Add("Бронников", "Александр", "Васильевич", 'М', new DateOnly(2002, 10, 22), "+79539539558", "sashaBro@mail.ru", "bronnikovAlexander", "123", new DateOnly(2002, 10, 30), select_school_class("10"), select_dir_med_inst("Детская поликлиника №1"), "user");
                    students[6].Add("Сысуев", "Иван", "Павлович", 'М', new DateOnly(2002, 10, 28), "+79539539557", "syivan@mail.ru", "sisyevIvan", "123", new DateOnly(2002, 11, 05), select_school_class("10"), select_dir_med_inst("Детская поликлиника №2"), "user");
                    students[7].Add("Хабаровская", "Анастасия", "Алексеевна", 'Ж', new DateOnly(2003, 07, 14), "+79539539556", "habNast@mail.ru", "habaroskyAnastasia", "123", new DateOnly(2003, 07, 22), select_school_class("9А"), select_dir_med_inst("Детская поликлиника №3"), "user");
                    students[8].Add("Тарасов", "Данила", null, 'М', new DateOnly(2005, 04, 08), "+79539539555", "tarasDanila@mail.ru", "tarasovDanila", "123", new DateOnly(2005, 04, 15), select_school_class("7Б"), select_dir_med_inst("Поликлиника № 1"), "user");
                    students[9].Add("Бушков", "Данил", null, 'М', new DateOnly(2000, 03, 15), "+79539539554", "bushDanil@mail.ru", "bushkovDanil", "123", new DateOnly(2000, 03, 22), select_school_class("11"), select_dir_med_inst("Поликлиника № 2 Кировская Городская Больница №9"), "user");

                    //Student[] students1 = new Student[10];
                    //for (int i = 0; i<10; i++)
                    //{

                    //    students1[i].Add("Бушков" +i, "Данил", null, 'М', new DateOnly(2000, 03, 15), "+79539539554", "bushDanil@mail.ru", "bushkovDanil", "123", new DateOnly(2000, 03, 22), select_school_class("11"), select_dir_med_inst("Поликлиника № 2 Кировская Городская Больница №9"), "user");


                    //}
                    //db.Students.AddRange(students1);

                    foreach (var item in students)
                    {
                        db.Students.Add(item);
                        item.SchoolClass.Quantity_Students++;
                        db.SchoolClasses.Update(item.SchoolClass);
                    }

                    //foreach (var item in students1)
                    //{
                    //    db.Students.Add(item);
                    //    item.SchoolClass.Quantity_Students++;
                    //    db.SchoolClasses.Update(item.SchoolClass);
                    //}

                    db.SaveChanges();

                    List<Vaccination> vaccinationList = SelectClass.select_vaccinations_list(db, "Профилактическая прививка (делается один раз)");
                    foreach (var item1 in students)
                    {
                        db.Students.Update(item1);
                        db.SaveChanges();

                        foreach (var item in vaccinationList)
                        {
                            Vaccination Vaccination = SelectClass.select_vaccinations(db, item.NameVaccination);
                            VaccinationAndCertificate vac = new VaccinationAndCertificate
                            {
                                Vaccination = Vaccination,
                                VaccinationCertificate = item1.vaccinationCertificate,
                                DateVaccine = DateOnly.MinValue,
                                ReactionOfVaccine = ""
                            };

                            Vaccination.VaccinationAndCertificates.Add(vac);
                            item1.vaccinationCertificate.VaccinationAndCertificates.Add(vac);

                            db.VaccinationCertificates.Update(item1.vaccinationCertificate);
                            db.Vaccinations.Update(Vaccination);
                            db.VaccinationsAndCertificates.Add(vac);

                            db.SaveChanges();
                        }
                    }

                }

                // ДОБАВЛЕНИЕ ЗАКОННОГО ПРЕДСТАВИТЕЛЯ
                void add_dir_representation()
                {
                    DirectoryOfRepresentation[] dirOfrepr = new DirectoryOfRepresentation[6];

                    for (int i = 0; i < dirOfrepr.Length; i++)
                    {
                        dirOfrepr[i] = new DirectoryOfRepresentation();
                    }

                    dirOfrepr[0].Add("Родитель");
                    dirOfrepr[1].Add("Приемный родитель");
                    dirOfrepr[2].Add("Усыновитель");
                    dirOfrepr[3].Add("Опекун");
                    dirOfrepr[4].Add("Попечитель");
                    dirOfrepr[5].Add("Попечитель");

                    foreach (var item in dirOfrepr)
                    {
                        db.DirectoryOfRepresentations.Add(item);
                    }

                    db.SaveChanges();
                }

                // ДОБАВЛЕНИЕ ЗАКОННЫХ ПРЕДСТАВИТЕЛЕЙ
                void add_parent()
                {
                    Parent[] parents = new Parent[12];

                    for (int i = 0; i < parents.Length; i++)
                    {
                        parents[i] = new Parent();
                    }

                    parents[0].Add("Бондаренко", "Наталья", "Васильевна", 'Ж', new DateOnly(1965, 03, 22), "+79531367552");
                    parents[1].Add("Вотинцев", "Андрей", null, 'Ж', new DateOnly(1970, 03, 02), "+72312312312");
                    parents[2].Add("Соломин", "Сергей", "Сергеевич", 'М', new DateOnly(1966, 08, 13), "+73232323232");
                    parents[3].Add("Русалеева", "Елена", null, 'Ж', new DateOnly(1976, 03, 22), "+79999999999");
                    parents[4].Add("Чулкин", "Сергей", "Максимович", 'М', new DateOnly(1975, 01, 11), "+78888888888");
                    parents[5].Add("Шутов", "Алексей", "Алексеевич", 'М', new DateOnly(1973, 04, 07), "+76666666666");
                    parents[6].Add("Сысуев", "Павел", null, 'М', new DateOnly(1977, 06, 01), "+75555555555");
                    parents[7].Add("Бронников", "Василий", null, 'М', new DateOnly(1971, 08, 22), "+71923901238");
                    parents[8].Add("Субботин", "Леонид", null, 'М', new DateOnly(1974, 11, 10), "+71823012983");
                    parents[9].Add("Тарасова", "Анастасия", null, 'М', new DateOnly(1978, 04, 02), "+74347928349");
                    parents[10].Add("Бушкова", "Наталья", null, 'М', new DateOnly(1972, 05, 11), "+71093180988");
                    parents[11].Add("Хабаровский", "Алексей", null, 'М', new DateOnly(1975, 06, 12), "+71238791827");

                    foreach (var item in parents)
                    {
                        db.Parents.Add(item);
                    }

                    db.SaveChanges();
                }

                // ДОБАВЛЕНИЕ АЛЛЕРГИЙ
                void add_allergyes()
                {
                    Student[] students = new Student[10];

                    students[0] = select_students("Бондаренко", "Алексей", "Петрович", new DateOnly(2001, 12, 16));
                    students[1] = select_students("Шутов", "Антон", "Алексеевич", new DateOnly(2002, 9, 06));
                    students[2] = select_students("Вотинцев", "Савелий", "Андреевич", new DateOnly(2003, 12, 29));
                    students[3] = select_students("Веккер", "Эльвира", "Викторовна", new DateOnly(2002, 7, 16));
                    students[4] = select_students("Субботин", "Дмитрий", "Леонидович", new DateOnly(2001, 5, 15));
                    students[5] = select_students("Бронников", "Александр", "Васильевич", new DateOnly(2002, 10, 22));
                    students[6] = select_students("Сысуев", "Иван", "Павлович", new DateOnly(2002, 10, 28));
                    students[7] = select_students("Хабаровская", "Анастасия", "Алексеевна", new DateOnly(2003, 7, 14));
                    students[8] = select_students("Тарасов", "Данила", null, new DateOnly(2005, 4, 08));
                    students[9] = select_students("Бушков", "Данил", null, new DateOnly(2000, 3, 15));

                    students[0].Add_Allergy(select_dir_allergy("Оса обыкновенная"), 10, "...");
                    students[1].Add_Allergy(select_dir_allergy("Кешью"), 20, "...");
                    students[2].Add_Allergy(select_dir_allergy("Виноград"), 17, "...");
                    students[3].Add_Allergy(select_dir_allergy("Молоко коровье"), 11, "...");
                    students[4].Add_Allergy(select_dir_allergy("Конопля"), 12, "...");
                    students[5].Add_Allergy(select_dir_allergy("Крапива"), 8, "...");
                    students[6].Add_Allergy(select_dir_allergy("Олива"), 6, "...");
                    students[7].Add_Allergy(select_dir_allergy("Тополь"), 3, "...");
                    students[8].Add_Allergy(select_dir_allergy("Акация"), 5, "...");
                    students[9].Add_Allergy(select_dir_allergy("Орех грецкий"), 2, "...");

                    foreach (var item in students)
                    {
                        db.Students.Update(item);
                    }

                    db.SaveChanges();
                }

                // ДОБАВЛЕНИЕ ПЕРЕНЕСЕННЫХ ЗАБОЛЕВАНИЙ
                void add_previous_illness()
                {
                    Student[] students = new Student[10];

                    students[0] = select_students("Бондаренко", "Алексей", "Петрович", new DateOnly(2001, 12, 16));
                    students[1] = select_students("Шутов", "Антон", "Алексеевич", new DateOnly(2002, 9, 06));
                    students[2] = select_students("Вотинцев", "Савелий", "Андреевич", new DateOnly(2003, 12, 29));
                    students[3] = select_students("Веккер", "Эльвира", "Викторовна", new DateOnly(2002, 7, 16));
                    students[4] = select_students("Субботин", "Дмитрий", "Леонидович", new DateOnly(2001, 5, 15));
                    students[5] = select_students("Бронников", "Александр", "Васильевич", new DateOnly(2002, 10, 22));
                    students[6] = select_students("Сысуев", "Иван", "Павлович", new DateOnly(2002, 10, 28));
                    students[7] = select_students("Хабаровская", "Анастасия", "Алексеевна", new DateOnly(2003, 7, 14));
                    students[8] = select_students("Тарасов", "Данила", null, new DateOnly(2005, 4, 08));
                    students[9] = select_students("Бушков", "Данил", null, new DateOnly(2000, 3, 15));

                    students[0].Add_Previous_Illness(select_dir_diagnoses("Псориаз"), new DateOnly(2017, 07, 28), new DateOnly(2023, 12, 01));
                    students[1].Add_Previous_Illness(select_dir_diagnoses("ОРВИ"), new DateOnly(2021, 12, 16), new DateOnly(2022, 01, 04));
                    students[2].Add_Previous_Illness(select_dir_diagnoses("ОРЗ"), new DateOnly(2023, 10, 16), new DateOnly(2023, 10, 26));
                    students[3].Add_Previous_Illness(select_dir_diagnoses("Дизентерия"), new DateOnly(2008, 11, 10), new DateOnly(2009, 02, 11));
                    students[4].Add_Previous_Illness(select_dir_diagnoses("Ветряная оспа"), new DateOnly(2006, 12, 16), new DateOnly(2007, 02, 16));
                    students[5].Add_Previous_Illness(select_dir_diagnoses("Сальмонеллез"), new DateOnly(2009, 11, 11), new DateOnly(2006, 12, 11));
                    students[6].Add_Previous_Illness(select_dir_diagnoses("Псориаз"), new DateOnly(2015, 08, 07), new DateOnly(2018, 12, 01));
                    students[7].Add_Previous_Illness(select_dir_diagnoses("Желтуха"), new DateOnly(2009, 01, 01), new DateOnly(2009, 07, 03));
                    students[8].Add_Previous_Illness(select_dir_diagnoses("Анемия"), new DateOnly(2008, 04, 13), new DateOnly(2023, 12, 09));
                    students[9].Add_Previous_Illness(select_dir_diagnoses("Чума"), new DateOnly(2007, 12, 22), new DateOnly(2008, 12, 22));

                    foreach (var item in students)
                    {
                        db.Students.Update(item);
                    }

                    db.SaveChanges();
                }

                // ДОБАВЛЕНИЕ ГОСПИТАЛИЗАЦИЙ
                void add_hospitalisations()
                {
                    Student[] students = new Student[10];

                    students[0] = select_students("Бондаренко", "Алексей", "Петрович", new DateOnly(2001, 12, 16));
                    students[1] = select_students("Шутов", "Антон", "Алексеевич", new DateOnly(2002, 9, 06));
                    students[2] = select_students("Вотинцев", "Савелий", "Андреевич", new DateOnly(2003, 12, 29));
                    students[3] = select_students("Веккер", "Эльвира", "Викторовна", new DateOnly(2002, 7, 16));
                    students[4] = select_students("Субботин", "Дмитрий", "Леонидович", new DateOnly(2001, 5, 15));
                    students[5] = select_students("Бронников", "Александр", "Васильевич", new DateOnly(2002, 10, 22));
                    students[6] = select_students("Сысуев", "Иван", "Павлович", new DateOnly(2002, 10, 28));
                    students[7] = select_students("Хабаровская", "Анастасия", "Алексеевна", new DateOnly(2003, 7, 14));
                    students[8] = select_students("Тарасов", "Данила", null, new DateOnly(2005, 4, 08));
                    students[9] = select_students("Бушков", "Данил", null, new DateOnly(2000, 3, 15));

                    students[0].Add_Hospitalisation(select_dir_diagnoses("Псориаз"), select_dir_med_inst("Кировская Городская Больница № 5"), new DateOnly(2017, 07, 28), new DateOnly(2023, 12, 01));
                    students[1].Add_Hospitalisation(select_dir_diagnoses("ОРВИ"), select_dir_med_inst("Поликлиника № 1"), new DateOnly(2021, 12, 16), new DateOnly(2022, 01, 04));
                    students[2].Add_Hospitalisation(select_dir_diagnoses("ОРЗ"), select_dir_med_inst("КОГБУЗ 'Северная клиническая больница скорой медицинской помощи'"), new DateOnly(2023, 10, 16), new DateOnly(2023, 10, 26));
                    students[3].Add_Hospitalisation(select_dir_diagnoses("Дизентерия"), select_dir_med_inst("КОГБУЗ 'Инфекционная клиническая больница'"), new DateOnly(2008, 11, 10), new DateOnly(2009, 02, 11));
                    students[4].Add_Hospitalisation(select_dir_diagnoses("Ветряная оспа"), select_dir_med_inst("КОГБУЗ 'Северная клиническая больница скорой медицинской помощи'"), new DateOnly(2006, 12, 16), new DateOnly(2007, 02, 16));
                    students[5].Add_Hospitalisation(select_dir_diagnoses("Сальмонеллез"), select_dir_med_inst("КОГБУЗ 'Инфекционная клиническая больница'"), new DateOnly(2009, 11, 11), new DateOnly(2006, 12, 11));
                    students[6].Add_Hospitalisation(select_dir_diagnoses("Псориаз"), select_dir_med_inst("Кировская Городская Больница № 5"), new DateOnly(2015, 08, 07), new DateOnly(2018, 12, 01));
                    students[7].Add_Hospitalisation(select_dir_diagnoses("Желтуха"), select_dir_med_inst("КОГБУЗ 'Инфекционная клиническая больница'"), new DateOnly(2009, 01, 01), new DateOnly(2009, 07, 03));
                    students[8].Add_Hospitalisation(select_dir_diagnoses("Анемия"), select_dir_med_inst("Поликлиника № 2 Кировская Городская Больница №8"), new DateOnly(2008, 04, 13), new DateOnly(2023, 12, 09));
                    students[9].Add_Hospitalisation(select_dir_diagnoses("Чума"), select_dir_med_inst("КОГБУЗ 'Инфекционная клиническая больница'"), new DateOnly(2007, 12, 22), new DateOnly(2008, 12, 22));
                }

                void add_studentAndparent(Student Student, Parent Parent, string Representation)
                {
                    //Student.Students_Parents.Add(new StudentAndParent { Parent = Parent, Representation = Representation });
                    //Student.Parents.Add(Parent);

                    StudentAndParent sap = new StudentAndParent
                    {
                        Student = Student,
                        Parent = Parent,
                        Representation = Representation
                    };

                    Student.Students_Parents.Add(sap);
                    Parent.Students_Parents.Add(sap);

                    db.Students.Update(Student);
                    db.Parents.Update(Parent);
                    db.Students_Parents.Add(sap);

                    db.SaveChanges();
                }

                void add_vaccinationAndvaccinationCertifficate(Vaccination Vaccination, VaccinationCertificate VaccinationCertificate, DateOnly DateVaccine, string ReactionOfVaccine)
                {
                    VaccinationAndCertificate vac = new VaccinationAndCertificate
                    {
                        Vaccination = Vaccination,
                        VaccinationCertificate = VaccinationCertificate,
                        DateVaccine = DateVaccine,
                        ReactionOfVaccine = "Реакция1"
                    };

                    Vaccination.VaccinationAndCertificates.Add(vac);
                    VaccinationCertificate.VaccinationAndCertificates.Add(vac);

                    db.VaccinationCertificates.Update(VaccinationCertificate);
                    db.Vaccinations.Update(Vaccination);
                    db.VaccinationsAndCertificates.Add(vac);

                    db.SaveChanges();
                }

                void delete_student(Student Student)
                {
                    db.Students.Remove(Student);
                    db.SaveChanges();
                }

                add_postes();

                add_nurses();

                add_med_inst();

                add_dir_allergy();

                add_dir_diagnoses();

                add_class_vaccination();

                add_school_class();

                add_vaccination();

                add_student();

                add_dir_representation();

                add_parent();

                add_allergyes();

                add_hospitalisations();

                add_previous_illness();

                //add_studentAndparent(select_students("Бондаренко", "Алексей", "Петрович", new DateOnly(2001, 12, 16)),
                //                   select_parents("Бондаренко", "Наталья", "Васильевна", new DateOnly(1965, 03, 22)),
                //                   select_dir_representation("Родитель").NameRepresentation);

                //add_vaccinationAndvaccinationCertifficate(select_vaccinations("Против клещевого вирусного энцефалита"),
                //                select_vaccination_certificate(db, select_students("Бондаренко", "Алексей", "Петрович", new DateOnly(2001, 12, 16)).Id),
                //                new DateOnly(2022, 04, 01),
                //                "..."
                //                );


                //Student student = select_students("Бондаренко", "Алексей", "Петрович", new DateOnly(2001, 12, 16));

                //db.Students.Remove(student);
                //db.SaveChanges();
            }
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            form.ShowDialog();
        }
    }
}
