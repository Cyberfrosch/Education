using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genotype
{
    public partial class Settings : Form
    {
        public Main _main;

        public delegate void SettingsChangedEventHandler(object sender, EventArgs e);
        public event SettingsChangedEventHandler? SettingsChanged;

        public Settings(Main main)
        {
            InitializeComponent();

            // Set default values
            _main = main;

            LbMotherName.Text = $"Name: {_main.mother.Name}";
            SetRadioButtons(RdBtMotherAllele1Dominant, RdBtMotherAllele1Recessive, _main.mother.Genotype.allele1);
            SetRadioButtons(RdBtMotherAllele2Dominant, RdBtMotherAllele2Recessive, _main.mother.Genotype.allele2);

            LbFatherName.Text = $"Name: {_main.father.Name}";
            SetRadioButtons(RdBtFatherAllele1Dominant, RdBtFatherAllele1Recessive, _main.father.Genotype.allele1);
            SetRadioButtons(RdBtFatherAllele2Dominant, RdBtFatherAllele2Recessive, _main.father.Genotype.allele2);

            TrBrOffspringNumber.Value = _main.OffspringNumber;
            LbOffspringNumberNow.Text = TrBrOffspringNumber.Value.ToString();
        }

        private void TrBrOffspringNumber_Scroll(object sender, EventArgs e)
        {
            LbOffspringNumberNow.Text = TrBrOffspringNumber.Value.ToString();
            _main.OffspringNumber = TrBrOffspringNumber.Value;

            SettingsChanged?.Invoke(this, EventArgs.Empty);
        }

        private void SetRadioButtons(RadioButton dominantRadioButton, RadioButton recessiveRadioButton, Allele allele)
        {
            dominantRadioButton.Checked = (allele == Allele.Dominant);
            recessiveRadioButton.Checked = (allele == Allele.Recessive);
        }

        // Обработка события Click для всех RadioButton, чтобы не генерить кучу строк одинакового кода
        private void AlleleRadioButton_Click(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (Enum.TryParse(radioButton.Tag as string, out Allele allele))
            {
                // Чтобы не писать 8 блоков условия (а только 4), использовал костыль в виде определения части имени кнопки,
                // чтобы знать к какому аллелю (1 или 2) она относится
                if (radioButton.Name.StartsWith("RdBtMotherAllele1"))
                {
                    _main.mother.Genotype.allele1 = allele;
                }
                else if (radioButton.Name.StartsWith("RdBtMotherAllele2"))
                {
                    _main.mother.Genotype.allele2 = allele;
                }
                else if (radioButton.Name.StartsWith("RdBtFatherAllele1"))
                {
                    _main.father.Genotype.allele1 = allele;
                }
                else if (radioButton.Name.StartsWith("RdBtFatherAllele2"))
                {
                    _main.father.Genotype.allele2 = allele;
                }
                else
                {
                    _main.mother.Genotype.allele1 = Allele.Dominant;
                    _main.mother.Genotype.allele2 = Allele.Recessive;

                    _main.father.Genotype.allele1 = Allele.Recessive;
                    _main.father.Genotype.allele2 = Allele.Dominant;
                }

                SettingsChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
