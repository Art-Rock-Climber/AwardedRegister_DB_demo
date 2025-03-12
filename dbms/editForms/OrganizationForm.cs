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
    public partial class OrganizationForm : EditForm
    {
        public Organization Organization { get; private set; }

        public OrganizationForm(Organization org = null)
        {
            InitializeComponent();
            Organization = org ?? new Organization();
            textBoxName.Text = Organization.Name;
        }

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            // Проверяем, что название не пустое
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Название организации не может быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Обновляем название организации
            Organization.Name = textBoxName.Text;

            // Вызываем базовый метод для установки DialogResult и закрытия формы
            base.btnOK_Click(sender, e);
        }
    }
}
