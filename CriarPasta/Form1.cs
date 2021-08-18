using System;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;

namespace CriarPasta
{
    public partial class Carrier : Form
    {
        string carriers;
        int id, service;

        public Carrier()
        {
            InitializeComponent();
        }

        private void CreatDirectory_Click(object sender, EventArgs e)
        {



            service = int.Parse(ServiceClient.Text);
            id = int.Parse(IdClient.Text);
            carriers = Carriers.Text.ToUpper();
           
            IdClient.Clear();
            Carriers.Clear();
            ServiceClient.Clear();

            var customer = new Folder
            {
                Id = id,
                Carriers = carriers,
                Service = service   
            };
            
            var ORIGINAL_FOLDER = "ORIGINAL";

            var integration = $"INTEGRACAO_{DateTime.Now.Date.ToString("yyyyMMdd")}";

            Directory.CreateDirectory(Path.Combine(
                Environment.CurrentDirectory,
                customer.Id.ToString(),
                customer.Carriers,
                customer.Service.ToString(),
                integration,
                ORIGINAL_FOLDER));

            Thread.Sleep(1500);
            MessageBox.Show("Pasta criada com sucesso!");

        }
        private void Update_Click(object sender, EventArgs e)
        {
            service = int.Parse(ServiceClient.Text);
            id = int.Parse(IdClient.Text);
            carriers = Carriers.Text.ToUpper();

            IdClient.Clear();
            Carriers.Clear();
            ServiceClient.Clear();

            var customer = new Folder
            {
                Id = id,
                Carriers = carriers,
                Service = service
            };

            var ORIGINAL_FOLDER = "ORIGINAL";

            var integration = $"ATUALIZACAO_{DateTime.Now.Date.ToString("yyyyMMdd")}";

            Directory.CreateDirectory(Path.Combine(
                Environment.CurrentDirectory,
                customer.Id.ToString(),
                customer.Carriers,
                customer.Service.ToString(),
                integration,
                ORIGINAL_FOLDER));

            Thread.Sleep(1500);
            MessageBox.Show("Pasta criada com sucesso!");

        }
    }
        public class Folder
        {

            public int Id { get; set; }
            public string Carriers { get; set; }
            public int Service { get; set; }
        };

    
}
