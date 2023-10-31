using System.DirectoryServices.ActiveDirectory;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using static Genotype.Main;
using Microsoft.VisualBasic.ApplicationServices;

namespace Genotype
{
    public partial class Main : Form
    {
        public static List<string> maleNamesList = FillListOfNames($"{Application.StartupPath}male_names_rus.txt");
        public static List<string> femaleNamesList = FillListOfNames($"{Application.StartupPath}female_names_rus.txt");

        public Essence mother;
        public Essence father;

        public List<Essence> offspring;
        public int offspringNumber;
        public int attrNumber;

        public List<GroupBoxList> GroupBoxListsMother;
        public List<GroupBoxList> GroupBoxListsFather;

        public readonly List<string> attrNames;
        public readonly List<string> alleleNames;

        private Point _CurrentPositionPoint;

        public Main()
        {
            InitializeComponent();

            Random random = new();

            GroupBoxListsMother = new List<GroupBoxList>();
            GroupBoxListsFather = new List<GroupBoxList>();

            attrNames = new List<string>() { "LineWidth", "FillColor", "LineColor" };
            alleleNames = new List<string>() { "Allele 1", "Allele 2" };

            attrNumber = random.Next(1, 4);
            TbAttributesNumber.Value = attrNumber;
            LbAttributesNow.Text = attrNumber.ToString();

            CreateGenesControls(FlpFather);
            UpdateFather();
            CreateGenesControls(FlpMother);
            UpdateMother();

            SetLabelValues();

            offspringNumber = random.Next(1, 101);
            TbOffspringNumber.Value = offspringNumber;
            LbOffspringNumberNow.Text = offspringNumber.ToString();

            _CurrentPositionPoint = new Point(2, 2);

            PbOffspring.Parent = PnOffspring;

            ListBoxChildren.DisplayMember = "Name";

            SetLbGeneNames();
        }

        private static List<string> FillListOfNames(in string filename)
        {
            string filePath = filename;
            List<string> names = new List<string>();

            StreamReader reader = new StreamReader(filePath);

            string line;

            while ((line = reader.ReadLine()) != null)
            {
                names.Add(line);
            }

            return names;
        }

        private void SetLbGeneNames()
        {
            LbGene1Name.Text = attrNames[0];
            LbGene2Name.Text = attrNames[1];
            LbGene3Name.Text = attrNames[2];
        }

        private void SetAllelesNames(Animal_tertiary essence)
        {
            if (essence != null)
            {
                LbGene1Allele1.Text = essence.Gene1.ToString(essence.Gene1.allele1);
                LbGene1Allele2.Text = essence.Gene1.ToString(essence.Gene1.allele2);

                LbGene2Allele1.Text = essence.Gene2.ToString(essence.Gene2.allele1);
                LbGene2Allele2.Text = essence.Gene2.ToString(essence.Gene2.allele2);

                LbGene3Allele1.Text = essence.Gene3.ToString(essence.Gene3.allele1);
                LbGene3Allele2.Text = essence.Gene3.ToString(essence.Gene3.allele2);
            }
        }

        private void UpdateFather()
        {
            father = CreateEssence(Sex.Male, GroupBoxListsFather);
            father.Draw(PbFather, new Point(4, 4), Essence.size);
        }
        private void UpdateMother()
        {
            mother = CreateEssence(Sex.Female, GroupBoxListsMother);
            mother.Draw(PbMother, new Point(4, 4), Essence.size);
        }

        public Essence CreateEssence(Sex sex, List<GroupBoxList> groupBoxLists, params Gene[] genes)
        {
            string name = (sex == Sex.Female) ? "Bagira" : "Balu";

            List<Gene> geneList = new List<Gene>(genes);

            foreach (GroupBoxList groupBoxList in groupBoxLists)
            {
                Allele allele1 = groupBoxList.Chekboxes[0].Checked ? Allele.Dominant : Allele.Recessive;
                Allele allele2 = groupBoxList.Chekboxes[1].Checked ? Allele.Dominant : Allele.Recessive;
                geneList.Add(new Gene(allele1, allele2, groupBoxList.GroupBox.Text));
            }

            return CreateEssenceInstance(name, sex, geneList);
        }

        private Essence CreateEssenceInstance(string name, Sex sex, List<Gene> geneList)
        {
            if (geneList.Count == 3)
            {
                return new Animal_tertiary(name, sex, geneList[0], geneList[1], geneList[2]);
            }
            else if (geneList.Count == 2)
            {
                return new Animal_secondary(name, sex, geneList[0], geneList[1]);
            }
            else if (geneList.Count == 1)
            {
                return new Animal(name, sex, geneList[0]);
            }
            else
            {
                throw new Exception("Unknown size");
            }
        }

        private void SetLabelValues()
        {
            LbMotherName.Text = $"Name: {mother.Name}";
            LbFatherName.Text = $"Name: {father.Name}";
        }

        public class GroupBoxList
        {
            public GroupBox GroupBox;
            public List<CheckBox> Chekboxes;

            public GroupBoxList(GroupBox groupBox)
            {
                GroupBox = groupBox;
                Chekboxes = new List<CheckBox>();
            }

            public void AddToGroupCheckBoxes(CheckBox checkBox)
            {
                GroupBox.Controls.Add(checkBox);
                Chekboxes.Add(checkBox);
            }
        }

        void CreateGenesControls(FlowLayoutPanel flPanel)
        {
            if (flPanel != null)
                flPanel.Controls.Clear();
            for (int i = 0; i < attrNumber; ++i)
            {
                Random random = new();
                GroupBox grBox = new();
                Point locPoint = new Point(10, 20);

                grBox.Text = attrNames[i];
                GroupBoxList groupBox = new GroupBoxList(grBox);

                if (flPanel.Name == "FlpFather")
                {
                    GroupBoxListsFather.Add(groupBox);
                }
                else if (flPanel.Name == "FlpMother")
                {
                    GroupBoxListsMother.Add(groupBox);
                }

                for (int j = 0; j < 2; ++j)
                {
                    CheckBox check = new();

                    check.Text = alleleNames[j];
                    check.Checked = random.Next(2) == 0;
                    groupBox.AddToGroupCheckBoxes(check);
                    groupBox.Chekboxes[j].Location = locPoint;

                    locPoint = new Point(10, 20 + groupBox.Chekboxes[j].Height);
                }

                groupBox.GroupBox.Parent = flPanel;
            }
        }

        private void OffsetCurrentPositionPoint(string name)
        {
            _CurrentPositionPoint.X += Essence.size + 10 + name.Length;
            if (_CurrentPositionPoint.X + Essence.size + name.Length + (10 * Essence.size / 100) > PbOffspring.Width)
            {
                _CurrentPositionPoint.X = 4;
                _CurrentPositionPoint.Y += 2 * Essence.size - (10 * Essence.size / 100);

                if (_CurrentPositionPoint.Y + Essence.size + 20 + (10 * Essence.size / 100) > PbOffspring.Height)
                {
                    PbOffspring.Size = new Size(PbOffspring.Width, PbOffspring.Height + 2 * Essence.size + 20 + (10 * Essence.size / 100));
                }
            }
        }

        private void ResetCurrentPositionPoint()
        {
            _CurrentPositionPoint.X = 4;
            _CurrentPositionPoint.Y = 4;
        }

        private void BtStart_Click(object sender, EventArgs e)
        {
            PbOffspring.Refresh();
            PbOffspring.Controls.Clear();
            ListBoxChildren.Items.Clear();

            offspring = father.Breed(mother, offspringNumber);

            for (int i = 0; i < offspringNumber; ++i)
            {
                offspring[i].Draw(PbOffspring, _CurrentPositionPoint, Essence.size);
                ListBoxChildren.Items.Add(offspring[i]);
                OffsetCurrentPositionPoint(offspring[i].Name);
            }

            ResetCurrentPositionPoint();
        }

        private void BtSettings_Click(object sender, EventArgs e)
        {
            PnSettings.Visible = true;
            PnMain.Visible = false;
        }

        private void Main_Paint(object sender, PaintEventArgs e)
        {
            father.Draw(PbFather, _CurrentPositionPoint, Essence.size);
            mother.Draw(PbMother, _CurrentPositionPoint, Essence.size);
            ResetCurrentPositionPoint();

            if (offspring != null)
            {
                foreach (Essence child in offspring)
                {
                    child.Draw(PbOffspring, _CurrentPositionPoint, Essence.size);
                    OffsetCurrentPositionPoint(child.Name);
                }
                ResetCurrentPositionPoint();
            }
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            PnMain.Size = ClientSize;
            PnSettings.Size = ClientSize;
        }

        private void ListboxChildren_SelectedIndexChanged(object sender, EventArgs e)
        {
            Animal_tertiary selectedChild = (Animal_tertiary)ListBoxChildren.SelectedItem;
            if (selectedChild != null)
            {
                PbChild.Image = selectedChild.EssenceIcon;
                LbChildName.Text = selectedChild.Name;
                LbChildSex.Text = selectedChild.ToStringSex();
                SetAllelesNames(selectedChild);
            }
        }

        private void RbSortMale_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void RbSortFemale_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void CbSortName_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            if (offspring != null)
            {
                List<Essence> filteredList = new List<Essence>();
                if (RbSortMale.Checked)
                {
                    filteredList = offspring.Where(child => child.sex == Sex.Male).ToList();
                }
                else if (RbSortFemale.Checked)
                {
                    filteredList = offspring.Where(child => child.sex == Sex.Female).ToList();
                }
                else if (RbSortNone.Checked)
                {
                    filteredList = offspring.ToList();
                }
                else
                {
                    filteredList = offspring.ToList();
                }
                if (CbSortName.Checked)
                {
                    filteredList = filteredList.OrderBy(child => child.Name).ToList();
                }
                ListBoxChildren.Items.Clear();

                foreach (var child in filteredList)
                {
                    ListBoxChildren.Items.Add(child);
                }
            }
        }

        private void TsmiMain_Click(object sender, EventArgs e)
        {
            PnMain.Visible = true;
            PnSettings.Visible = false;
        }

        private void TsmiSettings_Click(object sender, EventArgs e)
        {
            PnMain.Visible = false;
            PnSettings.Visible = true;
        }

        private void TbOffspringNumber_Scroll(object sender, EventArgs e)
        {
            offspringNumber = TbOffspringNumber.Value;
            LbOffspringNumberNow.Text = offspringNumber.ToString();
        }

        private void TbAttributesNumber_Scroll(object sender, EventArgs e)
        {
            GroupBoxListsMother.Clear();
            GroupBoxListsFather.Clear();

            attrNumber = TbAttributesNumber.Value;
            LbAttributesNow.Text = attrNumber.ToString();

            CreateGenesControls(FlpFather);
            CreateGenesControls(FlpMother);
        }

        private void BtApply_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateFather();
                UpdateMother();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            PbOffspring.Invalidate();
        }
    }
}