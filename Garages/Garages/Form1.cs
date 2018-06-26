using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //maak table
            dataSetGarage.Tables.Add(CreateDataTableGarage());
            
            //koppel bindingSource aan datatable Personen
            bindingSourceGarage.DataSource = dataSetGarage.Tables["Garage"];

                        //koppelen van textbox aan een kolom
            //Text
            txbChassisnummer.DataBindings.Add("Text", bindingSourceGarage, "Chassisnummer");
            txbKenteken.DataBindings.Add("Text", bindingSourceGarage, "Kenteken");
            txbMerk.DataBindings.Add("Text", bindingSourceGarage, "Merk");
            txbType.DataBindings.Add("Text", bindingSourceGarage, "Type");
            txbModel.DataBindings.Add("Text", bindingSourceGarage, "Model");
            txbBrandstof.DataBindings.Add("Text", bindingSourceGarage, "Brandstof");
            txbAantalKilowats.DataBindings.Add("Text", bindingSourceGarage, "AantalKilowats");
            txbAantalPortieren.DataBindings.Add("Text", bindingSourceGarage, "AantalPortieren");
            //Trekhaak
            
            chbTrekhaak.DataBindings.Add("Checked", bindingSourceGarage, "TrekHaak", false, DataSourceUpdateMode.OnPropertyChanged);
            //Value
            dtpFabricageDatum.DataBindings.Add("Value", bindingSourceGarage, "FabricageDatum");
            dtpDatumOpKenteken.DataBindings.Add("Value", bindingSourceGarage, "DatumOpKenteken");
            //Kleur
            txbKleur.DataBindings.Add("Text", bindingSourceGarage, "Kleur");


            //koppelen van kolom aan een combobox
            cmbChassisnummer.DataSource = bindingSourceGarage;
            cmbChassisnummer.DisplayMember = "Chassisnummer";
            //
            cmbKenteken.DataSource = bindingSourceGarage;
            cmbKenteken.DisplayMember = "Kenteken";
            //
            cmbMerk.DataSource = bindingSourceGarage;
            cmbMerk.DisplayMember = "Merk";
            //
            cmbType.DataSource = bindingSourceGarage;
            cmbType.DisplayMember = "Type";
            //
            cmbModel.DataSource = bindingSourceGarage;
            cmbModel.DisplayMember = "Model";
            //



            //koppelen hele tabel aan datagridview
            dgvGarage.DataSource = bindingSourceGarage;
        }

        DataSet dataSetGarage = new DataSet("Garage");

        BindingSource bindingSourceGarage = new BindingSource();
        
        private DataTable CreateDataTableGarage()
        {
            DataTable dtGarage = new DataTable("Garage");

            //Id
            DataColumn Id = new DataColumn("Id", typeof(Int32));
            dtGarage.Columns.Add(Id);
            dtGarage.PrimaryKey = new DataColumn[] { Id };
            dtGarage.Columns["Id"].Unique = true;
            dtGarage.Columns["Id"].AutoIncrement = true;
            dtGarage.Columns["Id"].AllowDBNull = true;

            //Chassisnummer
            dtGarage.Columns.Add("Chassisnummer", typeof(string));
            dtGarage.Columns["Chassisnummer"].AllowDBNull = false;
            dtGarage.Columns["Chassisnummer"].Unique = true;

            //Kenteken
            dtGarage.Columns.Add("Kenteken", typeof(string));
            dtGarage.Columns["Kenteken"].MaxLength = 8;
            dtGarage.Columns["Kenteken"].Unique = true;
            dtGarage.Columns["Kenteken"].AllowDBNull = true;

            //FabricageDatum
            dtGarage.Columns.Add("FabricageDatum", typeof(DateTime));

            //DatumOpKenteken
            dtGarage.Columns.Add("DatumOpKenteken", typeof(DateTime));
            dtGarage.Columns["DatumOpKenteken"].AllowDBNull = true;
            
            //Merk
            dtGarage.Columns.Add("Merk", typeof(string));
            dtGarage.Columns["Merk"].MaxLength = 25;
            
            //Type
            dtGarage.Columns.Add("Type", typeof(string));
            dtGarage.Columns["Type"].MaxLength = 25;
            
            //Kleur
            dtGarage.Columns.Add("Kleur", typeof(Color));
            
            //Brandstof
            dtGarage.Columns.Add("Brandstof", typeof(string));
            dtGarage.Columns["Brandstof"].MaxLength = 10;
            
            //AantalKilowats
            dtGarage.Columns.Add("AantalKilowats", typeof(double));
            
            //AantalPortieren
            dtGarage.Columns.Add("AantalPortieren", typeof(byte));
            
            //Model
            dtGarage.Columns.Add("Model", typeof(string));
            dtGarage.Columns["Model"].MaxLength = 15;
            
            //Trekhaak
            dtGarage.Columns.Add("Trekhaak", typeof(CheckBox));

            return dtGarage;
        }

        private void txbKleur_Click(object sender, EventArgs e)
        {
            KleurPicker.ShowDialog();
            txbKleur.Text = Convert.ToString(KleurPicker.Color);
        }

        private void btnEinde_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
