using dbms.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbms.editForms
{
    public partial class AwardForm : EditForm
    {
        public Award Award { get; private set; }
        private List<Employee> _employees;

        public AwardForm(Award award = null)
        {
            InitializeComponent();
            Award = award ?? new Award();
            textBoxReason.Text = Award.Reason;

            // Проверяем, что дата находится в допустимых пределах
            if (Award.Date == DateTime.MinValue || Award.Date < dateTimePicker.MinDate || Award.Date > dateTimePicker.MaxDate)
            {
                dateTimePicker.Value = DateTime.Today;
            }
            else
            {
                dateTimePicker.Value = Award.Date;
            }

            // Загружаем список наград
            using (var context = new AwardsContext())
            {
                _employees = context.Employees.ToList();
            }

            var employeesList = _employees
                .Select(emp => new { Id = (int?)emp.Id, Name = emp.ToString() })
                .ToList();
            //employeesList.Insert(0, new { Id = (int?)null, Name = "Нет награждённого" });

            comboBoxAwarded.DataSource = employeesList;
            comboBoxAwarded.DisplayMember = "Name";
            comboBoxAwarded.ValueMember = "Id";

            // Устанавливаем выбранную организацию (если сотрудник уже существует)
            if (Award.EmployeeId.HasValue)
            {
                comboBoxAwarded.SelectedValue = Award.EmployeeId;
            }
        }

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            // Проверяем, что основание не пустое
            if (string.IsNullOrWhiteSpace(textBoxReason.Text))
            {
                MessageBox.Show("Основание награждения не может быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxAwarded.SelectedValue is null || comboBoxAwarded.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Поле с сотрудником не может быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Обновляем поля
            Award.Reason = textBoxReason.Text;
            Award.Date = dateTimePicker.Value;

            Award.EmployeeId = (int?)comboBoxAwarded.SelectedValue;

            // Вызываем базовый метод для установки DialogResult и закрытия формы
            base.btnOK_Click(sender, e);
        }
    }
}
