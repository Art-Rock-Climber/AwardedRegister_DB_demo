using dbms.editForms;
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
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dbms
{
    public partial class MainForm : Form
    {
        private AwardsContext _context;


        public MainForm()
        {
            InitializeComponent();
            _context = new AwardsContext();
            _context.Database.Delete();

            var orgNode = new TreeNode("Организации");
            //var empNode = new TreeNode("Сотрудники");
            //var awardNode = new TreeNode("Награды");
            trvData.Nodes.Add(orgNode);
            //trvData.Nodes.Add(empNode);
            //trvData.Nodes.Add(awardNode);

            if (true)
            {
                var org1 = new Organization { Name = "Соликамскбумпром" };
                var emp1 = new Employee { FirstName = "Иван", LastName = "Иванов", Organization = org1 };
                var award1 = new Award { Reason = "За успехи в работе", Date = DateTime.Now, Employee = emp1 };

                _context.Organizations.Add(org1);
                _context.Employees.Add(emp1);
                _context.Awards.Add(award1);

                var org2 = new Organization { Name = "Соликамский завод Урал" };
                var emp2 = new Employee { FirstName = "Петр", LastName = "Петров", Organization = org2 };
                var award2 = new Award { Reason = "В связи с праздником Весны и Труда", Date = DateTime.Now, Employee = emp2 };

                _context.Organizations.Add(org2);
                _context.Employees.Add(emp2);
                _context.Awards.Add(award2);

                var org3 = new Organization { Name = "Соликамский магниевый завод (СМЗ)" };
                var emp3 = new Employee { FirstName = "Петр", LastName = "Иванов", Organization = org3 };
                var award3 = new Award { Reason = "За успехи в работе", Date = DateTime.Now, Employee = emp3 };

                _context.Organizations.Add(org3);
                _context.Employees.Add(emp3);
                _context.Awards.Add(award3);

                _context.SaveChanges();
            }
        }

        private void LoadData()
        {
            trvData.Nodes.Clear();
            var orgNode = new TreeNode("Организации");
            //var empNode = new TreeNode("Сотрудники");
            //var awardNode = new TreeNode("Награды");

            // Загрузка организаций
            var organizations = _context.Organizations.ToList();
            foreach (var org in organizations)
            {
                var orgChildNode = new TreeNode(org.Name) { Tag = org };
                foreach (var emp in org.Employees)
                {
                    var empChildNode = new TreeNode(emp.ToString()) { Tag = emp };
                    foreach (var award in emp.Awards)
                    {
                        var awardChildNode = new TreeNode(award.ToString()) { Tag = award };
                        empChildNode.Nodes.Add(awardChildNode);
                        //awardNode.Nodes.Add((TreeNode)awardChildNode.Clone());
                        //awardNode.Nodes.Add(awardChildNode);
                    }
                    orgChildNode.Nodes.Add(empChildNode);
                    //empNode.Nodes.Add((TreeNode)empChildNode.Clone());
                    //empNode.Nodes.Add(empChildNode);
                }
                orgNode.Nodes.Add(orgChildNode);
            }

            trvData.Nodes.Add(orgNode);
            //trvData.Nodes.Add(empNode);
            //trvData.Nodes.Add(awardNode);
        }

        private void LoadDataNew()
        {
            LoadOrganizations();
            LoadEmployees();
            LoadAwards();
        }

        private void LoadOrganizations()
        {
            var orgNode = trvData.Nodes[0];
            orgNode.Nodes.Clear();
            foreach (var org in _context.Organizations.ToList())
                orgNode.Nodes.Add(new TreeNode(org.Name) { Tag = org });
        }

        private void LoadEmployees()
        {
            var empNode = trvData.Nodes[1];
            empNode.Nodes.Clear();
            foreach (var emp in _context.Employees.ToList())
                empNode.Nodes.Add(new TreeNode(emp.ToString()) { Tag = emp });
        }

        private void LoadAwards()
        {
            var awardNode = trvData.Nodes[2];
            awardNode.Nodes.Clear();
            foreach (var award in _context.Awards.ToList())
                awardNode.Nodes.Add(new TreeNode(award.ToString()) { Tag = award });
        }

        private void UpdateNode(TreeNode node)
        {
            if (node.Tag is Organization org)
            {
                // Обновляем узел организации
                node.Text = org.Name;
                node.Nodes.Clear();

                // Добавляем сотрудников организации
                foreach (var emp in org.Employees)
                {
                    var empChildNode = new TreeNode(emp.ToString()) { Tag = emp };

                    // Добавляем награды сотрудника
                    foreach (var award in emp.Awards)
                    {
                        var awardChildNode = new TreeNode(award.ToString()) { Tag = award };
                        empChildNode.Nodes.Add(awardChildNode);
                    }

                    node.Nodes.Add(empChildNode);
                }
            }
            else if (node.Tag is Employee emp)
            {
                // Обновляем узел сотрудника
                node.Text = $"{emp.LastName} {emp.FirstName}";
                node.Nodes.Clear();

                // Добавляем награды сотрудника
                foreach (var award in emp.Awards)
                {
                    var awardChildNode = new TreeNode(award.ToString()) { Tag = award };
                    node.Nodes.Add(awardChildNode);
                }
            }
            else if (node.Tag is Award award)
            {
                // Обновляем узел награды
                node.Text = award.ToString();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void trvData_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                trvData.SelectedNode = e.Node;
                if (trvData.SelectedNode?.Tag is Organization)
                    contextMenuOrg.Show(trvData, e.Location);
                else if (trvData.SelectedNode?.Tag is Employee)
                    contextMenuEmp.Show(trvData, e.Location);
                else if (trvData.SelectedNode?.Tag is Award)
                    contextMenuAward.Show(trvData, e.Location);
            }
        }

        private void добавитьОрганизациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new OrganizationForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _context.Organizations.Add(form.Organization);
                _context.SaveChanges();
                trvData.Nodes[0].Nodes.Add(new TreeNode(form.Organization.Name) { Tag = form.Organization });
            }
        }

        private void изменитьОрганизациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trvData.SelectedNode?.Tag is Organization org)
            {
                var form = new OrganizationForm(org);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _context.SaveChanges();
                    trvData.SelectedNode.Text = form.Organization.Name;
                    //LoadOrganizations();
                }
            }
        }

        private void удалитьОрганизациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trvData.SelectedNode?.Tag is Organization org)
            {
                _context.Organizations.Remove(org);
                _context.SaveChanges();
                trvData.SelectedNode.Remove();
                //LoadOrganizations();
            }
        }

        private void добавитьСотрудникаtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new EmployeeForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _context.Employees.Add(form.Employee);
                _context.SaveChanges();

                var orgNode = trvData.Nodes[0].Nodes
                    .Cast<TreeNode>()
                    .FirstOrDefault(node => node.Tag is Organization org && org.Id == form.Employee.OrganizationId);

                if (orgNode != null)
                {
                    var empNode = new TreeNode(form.Employee.ToString()) { Tag = form.Employee };
                    orgNode.Nodes.Add(empNode);
                    orgNode.Expand();
                }
            }
        }

        private void изменитьСотрудникаtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trvData.SelectedNode?.Tag is Employee emp)
            {
                var form = new EmployeeForm(emp);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _context.SaveChanges();
                    trvData.SelectedNode.Text = form.Employee.ToString();
                    //LoadEmployees();
                }
            }
        }

        private void удалитьСотрудникаtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trvData.SelectedNode?.Tag is Employee emp)
            {
                _context.Employees.Remove(emp);
                _context.SaveChanges();
                trvData.SelectedNode.Remove();
                //LoadEmployees();
            }
        }

        private void добавитьНаградуtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AwardForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _context.Awards.Add(form.Award);
                _context.SaveChanges();

                var empNode = trvData.Nodes[0].Nodes
                    .Cast<TreeNode>()
                    .SelectMany(orgNode => orgNode.Nodes.Cast<TreeNode>())
                    .FirstOrDefault(node => node.Tag is Employee emp && emp.Id == form.Award.EmployeeId);

                if (empNode != null)
                {
                    // Добавляем награду в узел сотрудника
                    var awardNode = new TreeNode(form.Award.ToString()) { Tag = form.Award };
                    empNode.Nodes.Add(awardNode);
                    empNode.Expand(); // Раскрываем узел сотрудника для отображения новой награды
                }
            }
        }

        private void изменитьНаградуtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trvData.SelectedNode?.Tag is Award award)
            {
                var form = new AwardForm(award);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _context.SaveChanges();
                    trvData.SelectedNode.Text = form.Award.ToString();
                    //LoadAwards();
                }
            }
        }

        private void удалитьНаградуtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trvData.SelectedNode?.Tag is Award award)
            {
                _context.Awards.Remove(award);
                _context.SaveChanges();
                trvData.SelectedNode.Remove();
                //LoadAwards();
            }
        }

        private void trvData_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));
            Point pt = trvData.PointToClient(new Point(e.X, e.Y));
            TreeNode targetNode = trvData.GetNodeAt(pt);

            if (draggedNode != null && targetNode != null)
            {
                // Если перетаскиваемый элемент - сотрудник, а целевой узел - организация
                if (draggedNode.Tag is Employee employee && targetNode.Tag is Organization organization)
                {
                    employee.Organization = organization;
                    _context.SaveChanges();

                    draggedNode.Remove();
                    targetNode.Nodes.Add((TreeNode)draggedNode.Clone());

                    UpdateNode(targetNode);
                }
                // Если перетаскиваемый элемент - награда, а целевой узел - сотрудник
                else if (draggedNode.Tag is Award award && targetNode.Tag is Employee emp)
                {
                    award.Employee = emp;
                    _context.SaveChanges();

                    draggedNode.Remove();
                    targetNode.Nodes.Add((TreeNode)draggedNode.Clone());

                    UpdateNode(targetNode);
                }
            }
        }

        private void trvData_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Item is TreeNode node && (node.Tag is Employee || node.Tag is Award))
            {
                DoDragDrop(e.Item, DragDropEffects.Move);
            }
        }

        private void trvData_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
    }
}
