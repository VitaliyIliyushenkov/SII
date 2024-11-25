using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace Ex_system
{
    public partial class Expert_system : Form
    {
        private List<Rule> _knowledgeBase;
        private readonly string _connectionString = "Data Source=patients.db;Version=3;";
        private string _currentDiagnosis;
        private string _currentRecommendation;

        public Expert_system()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadKnowledgeBase();
            PopulateInputs();
            LoadPatients();
        }

        private void InitializeDatabase()
        {
            if (!File.Exists("patients.db"))
            {
                SQLiteConnection.CreateFile("patients.db");
            }

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Patients (
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Age INTEGER NOT NULL,
                        Symptoms TEXT NOT NULL,
                        Diagnosis TEXT NOT NULL,
                        Recommendation TEXT NOT NULL
                    );";
                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        private void LoadKnowledgeBase()
        {
            try
            {
                var json = File.ReadAllText("KnowledgeBase.json");
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                var data = JsonSerializer.Deserialize<KnowledgeBase>(json, options);
                _knowledgeBase = data?.Rules ?? new List<Rule>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки базы знаний: {ex.Message}");
            }
        }

        private void PopulateInputs()
        {
            cmbTemperature.Items.AddRange(new[] { "нормальная", "субфебрильная", "высокая", "очень высокая" });
            cmbCough.Items.AddRange(new[] { "нет", "сухой", "влажный", "частый" });
            cmbHeadache.Items.AddRange(new[] { "нет", "легкая", "сильная" });
            cmbRunnyNose.Items.AddRange(new[] { "нет", "слабый", "сильный" });
            cmbFatigue.Items.AddRange(new[] { "нет", "легкая", "сильная" });
            cmbThroatPain.Items.AddRange(new[] { "нет", "есть" });
            cmbDrowsiness.Items.AddRange(new[] { "нет", "есть", "сильная" });

            cmbTemperature.SelectedIndex = 0;
            cmbCough.SelectedIndex = 0;
            cmbHeadache.SelectedIndex = 0;
            cmbRunnyNose.SelectedIndex = 0;
            cmbFatigue.SelectedIndex = 0;
            cmbThroatPain.SelectedIndex = 0;
            cmbDrowsiness.SelectedIndex = 0;
        }

        private void btnDiagnose_Click(object sender, EventArgs e)
        {
            var userInputs = new Dictionary<string, string>
            {
                { "temperature", cmbTemperature.SelectedItem.ToString() },
                { "cough", cmbCough.SelectedItem.ToString() },
                { "headache", cmbHeadache.SelectedItem.ToString() },
                { "runnyNose", cmbRunnyNose.SelectedItem.ToString() },
                { "fatigue", cmbFatigue.SelectedItem.ToString() },
                { "throatPain", cmbThroatPain.SelectedItem.ToString() },
                { "drowsiness", cmbDrowsiness.SelectedItem.ToString() }
            };

            var matchedRule = _knowledgeBase.FirstOrDefault(rule =>
                rule.Conditions.All(condition =>
                    userInputs.ContainsKey(condition.Key) &&
                    userInputs[condition.Key] == condition.Value
                ));

            if (matchedRule != null)
            {
                _currentDiagnosis = matchedRule.Diagnosis;
                _currentRecommendation = matchedRule.Recommendation;

                lblResult.Text = $"Диагноз: {_currentDiagnosis}\n" +
                                 $"Рекомендация: {_currentRecommendation}";
            }
            else
            {
                _currentDiagnosis = null;
                _currentRecommendation = null;
                lblResult.Text = "Диагноз для указанных симптомов не найден.";
            }
        }

        private void btnSaveToDatabase_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtAge.Text))
            {
                MessageBox.Show("Введите имя и возраст пациента.");
                return;
            }

            if (_currentDiagnosis == null || _currentRecommendation == null)
            {
                MessageBox.Show("Сначала выполните диагностику.");
                return;
            }

            try
            {
                var symptoms = string.Join(", ", new[]
                {
                    $"temperature: {cmbTemperature.SelectedItem}",
                    $"cough: {cmbCough.SelectedItem}",
                    $"headache: {cmbHeadache.SelectedItem}",
                    $"runnyNose: {cmbRunnyNose.SelectedItem}",
                    $"fatigue: {cmbFatigue.SelectedItem}",
                    $"throatPain: {cmbThroatPain.SelectedItem}",
                    $"drowsiness: {cmbDrowsiness.SelectedItem}"
                });

                using (var connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();
                    string insertQuery = @"
                        INSERT INTO Patients (Name, Age, Symptoms, Diagnosis, Recommendation)
                        VALUES (@Name, @Age, @Symptoms, @Diagnosis, @Recommendation);";

                    using (var command = new SQLiteCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Name", txtName.Text);
                        command.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
                        command.Parameters.AddWithValue("@Symptoms", symptoms);
                        command.Parameters.AddWithValue("@Diagnosis", _currentDiagnosis);
                        command.Parameters.AddWithValue("@Recommendation", _currentRecommendation);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Данные пациента успешно сохранены.");
                LoadPatients(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения данных пациента: {ex.Message}");
            }
        }

        private void LoadPatients()
        {
            try
            {
                using (var connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT * FROM Patients;";

                    using (var command = new SQLiteCommand(selectQuery, connection))
                    using (var adapter = new SQLiteDataAdapter(command))
                    {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgvPatients.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных пациентов: {ex.Message}");
            }
        }
    }

    public class KnowledgeBase
    {
        public List<Rule> Rules { get; set; }
    }

    public class Rule
    {
        public Dictionary<string, string> Conditions { get; set; }
        public string Diagnosis { get; set; }
        public string Recommendation { get; set; }
    }
}
