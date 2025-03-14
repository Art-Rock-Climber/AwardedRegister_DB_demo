﻿using dbms.editForms;
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
            var empNode = new TreeNode("Сотрудники");
            var awardNode = new TreeNode("Награды");
            trvData.Nodes.Add(orgNode);
            trvData.Nodes.Add(empNode);
            trvData.Nodes.Add(awardNode);

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

        //private void LoadDataOld()
        //{
        //    trvData.Nodes.Clear();
        //    var orgNode = new TreeNode("Организации");
        //    var empNode = new TreeNode("Сотрудники");
        //    var awardNode = new TreeNode("Награды");

        //    // Загрузка организаций
        //    var organizations = _context.Organizations.ToList();
        //    foreach (var org in organizations)
        //    {
        //        var orgChildNode = new TreeNode(org.Name) { Tag = org };
        //        foreach (var emp in org.Employees)
        //        {
        //            var empChildNode = new TreeNode($"{emp.LastName} {emp.FirstName} {emp.MiddleName}") { Tag = emp };
        //            foreach (var award in emp.Awards)
        //            {
        //                var awardChildNode = new TreeNode($"{award.Reason} ({award.Date.ToShortDateString()})") { Tag = award };
        //                //empChildNode.Nodes.Add(awardChildNode);
        //                //awardNode.Nodes.Add((TreeNode)awardChildNode.Clone());
        //                awardNode.Nodes.Add(awardChildNode);
        //            }
        //            //orgChildNode.Nodes.Add(empChildNode);
        //            //empNode.Nodes.Add((TreeNode)empChildNode.Clone());
        //            empNode.Nodes.Add(empChildNode);
        //        }
        //        orgNode.Nodes.Add(orgChildNode);
        //    }

        //    trvData.Nodes.Add(orgNode);
        //    trvData.Nodes.Add(empNode);
        //    trvData.Nodes.Add(awardNode);
        //}

        private void LoadData()
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
                trvData.Nodes[1].Nodes.Add(new TreeNode(form.Employee.ToString()) { Tag = form.Employee });
                //LoadEmployees();
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
                trvData.Nodes[2].Nodes.Add(new TreeNode(form.Award.ToString()) { Tag = form.Award });
                //LoadAwards();
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
    }
}
