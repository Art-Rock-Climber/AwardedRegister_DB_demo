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

namespace dbms
{
    public partial class EmployeeForm : EditForm
    {
        public Employee Employee { get; private set; }
        private List<Organization> _organizations;

        public EmployeeForm(Employee emp = null)
        {
            InitializeComponent();
            Employee = emp ?? new Employee();
            textBoxLastName.Text = Employee.LastName;
            textBoxFirstName.Text = Employee.FirstName;
            textBoxMidName.Text = Employee.MiddleName;

            // Загружаем список организаций
            using (var context = new AwardsContext())
            {
                _organizations = context.Organizations.ToList();
            }

            var organizationsList = _organizations
                .Select(org => new { Id = (int?)org.Id, Name = org.Name })
                .ToList();
            organizationsList.Insert(0, new { Id = (int?)null, Name = "Нет организации" });

            comboBoxOrg.DataSource = organizationsList;
            comboBoxOrg.DisplayMember = "Name";
            comboBoxOrg.ValueMember = "Id";

            // Устанавливаем выбранную организацию (если сотрудник уже существует)
            if (Employee.OrganizationId.HasValue)
            {
                comboBoxOrg.SelectedValue = Employee.OrganizationId;
            }
        }

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            // Проверяем, что фамилия и имя не пустые
            if (string.IsNullOrWhiteSpace(textBoxLastName.Text))
            {
                MessageBox.Show("Фамилия не может быть пустой.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text))
            {
                MessageBox.Show("Имя не может быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Employee.LastName = textBoxLastName.Text;
            Employee.FirstName = textBoxFirstName.Text;
            Employee.MiddleName = textBoxMidName.Text;

            Employee.OrganizationId = (int?)comboBoxOrg.SelectedValue;

            base.btnOK_Click(sender, e);
        }
    }
}
