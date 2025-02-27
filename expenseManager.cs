using System.Data;
using System.Data.SQLite;

namespace Expense_Manager
{
    public partial class expenseManager : Form
    {
        private string connectionString = "Data Source=expenses.db;Version=3;";

        public expenseManager()
        {
            InitializeComponent();
            Load += ExpenseManager_Load;
            buttonEditEntry.Click += EditEntry;
            buttonDeleteEntry.Click += DeleteEntry;
            buttonConfirmFilter.Click += ApplyFilters;
            buttonResetFilter.Click += ResetFilters;
            buttonConfirmEntry.Click += ConfirmEntry;
            buttonCloseApp.Click += CloseApplication;
            CreateDatabase();
        }

        private void ExpenseManager_Load(object sender, EventArgs e)
        {
            comboBoxVendorsEntry.Items.Clear();
            comboBoxVendorsEntry.Items.AddRange(new string[]
            {
                "electricity", "water", "internet",
                "phone", "fuel", "food"
            });

            comboBoxVendorsFilter.Items.Clear();
            comboBoxVendorsFilter.Items.Add("All vendors");
            comboBoxVendorsFilter.Items.AddRange(new string[]
            {
                "electricity", "water", "internet",
                "phone", "fuel", "food"
            });
            comboBoxVendorsFilter.SelectedIndex = 0;

            LoadData();
        }

        private void CreateDatabase()
        {
            string dbPath = "expenses.db";
            if (!File.Exists(dbPath))
            {
                try
                {
                    SQLiteConnection.CreateFile(dbPath);
                    using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                    {
                        conn.Open();
                        string createTableQuery = @"CREATE TABLE IF NOT EXISTS Expenses (
                                                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                                    Vendor TEXT NOT NULL,
                                                    ExpenseDate DATE NOT NULL,
                                                    Amount REAL NOT NULL
                                                );";
                        using (SQLiteCommand cmd = new SQLiteCommand(createTableQuery, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }

        private void ConfirmEntry(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxVendorsEntry.SelectedItem == null || numericUpDownAmountEntry.Value == 0)
                {
                    MessageBox.Show("Please select a vendor and enter an amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
                    return;
                }

                string vendor = comboBoxVendorsEntry.SelectedItem.ToString();
                string expenseDate = dateTimePickerEntry.Value.ToString("yyyy-MM-dd");
                decimal amount = numericUpDownAmountEntry.Value;

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string insertQuery = "INSERT INTO Expenses (Vendor, ExpenseDate, Amount) VALUES (@Vendor, @ExpenseDate, @Amount)";
                    using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Vendor", vendor);
                        cmd.Parameters.AddWithValue("@ExpenseDate", expenseDate);
                        cmd.Parameters.AddWithValue("@Amount", amount);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void LoadData(string vendorFilter = "All vendors", DateTime? from = null, DateTime? to = null)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Id, Vendor, ExpenseDate, Amount FROM Expenses";
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Filtering by vendor
                    if (vendorFilter != "All vendors")
                    {
                        var filteredRows = dt.AsEnumerable()
                            .Where(row => row["Vendor"].ToString() == vendorFilter)
                            .ToList();

                        dt = filteredRows.Any() ? filteredRows.CopyToDataTable() : dt.Clone();
                    }

                    // Filtering by from date
                    if (from.HasValue)
                    {
                        var filteredRows = dt.AsEnumerable()
                            .Where(row => Convert.ToDateTime(row["ExpenseDate"]) >= from.Value)
                            .ToList();

                        dt = filteredRows.Any() ? filteredRows.CopyToDataTable() : dt.Clone();
                    }

                    // Filtering by to date
                    if (to.HasValue)
                    {
                        var filteredRows = dt.AsEnumerable()
                            .Where(row => Convert.ToDateTime(row["ExpenseDate"]) <= to.Value)
                            .ToList();

                        dt = filteredRows.Any() ? filteredRows.CopyToDataTable() : dt.Clone();
                    }

                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["Id"].Visible = false;
                    dataGridView1.Columns["Amount"].DefaultCellStyle.Format = "N2";

                    // Calculate total
                    decimal total = dt.AsEnumerable().Sum(row => Convert.ToDecimal(row.Field<double>("Amount")));
                    labelTotal.Text = $"Total: {total:F2}";
                }
            }
        }

        private void EditEntry(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row to edit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }

            // Edit row
            dataGridView1.ReadOnly = false;
            dataGridView1.BeginEdit(true);
        }

        private void DeleteEntry(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this entry?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM Expenses WHERE Id=@Id";
                    using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadData();
            }
        }

        private void ApplyFilters(object sender, EventArgs e)
        {
            string selectedVendor = comboBoxVendorsFilter.SelectedItem.ToString();
            DateTime? from = dateTimePickerFrom.Value;
            DateTime? to = dateTimePickerTo.Value;

            LoadData(selectedVendor, from, to);
        }

        private void ResetFilters(object sender, EventArgs e)
        {
            comboBoxVendorsFilter.SelectedIndex = 0;
            dateTimePickerFrom.Value = DateTime.Now.AddMonths(-1);
            dateTimePickerTo.Value = DateTime.Now;
            LoadData();
        }

        private void CloseApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
