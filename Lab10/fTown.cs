using System.Xml.Linq;

namespace Lab10
{
    public partial class fTown : Form
    {
        private Town _town;
        public fTown(ref Town town)
        {
            InitializeComponent();
            _town = town;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            double yearIncome = double.Parse(tBYearIncome.Text);
            int population = int.Parse(tBPopulation.Text);
            double square = double.Parse(tBSquare.Text);

        // Оновлення властивостей об'єкту Town
            _town.Name = tBName.Text;
            _town.Country = tBCountry.Text;
            _town.Region = tBRegion.Text;
            _town.Population = population;
            _town.YearIncome = yearIncome;
            _town.Square = square;
            _town.HasPort = chBHasPort.Checked;
            _town.HasAirport = chBHasAiroport.Checked;

            DialogResult = DialogResult.OK;
            Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
