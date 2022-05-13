using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onze.View
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            string endereco = @"C:\Senac\teste007.txt";
            try
            {
                if (!System.IO.File.Exists(endereco))
                {
                    throw new Exception("Arquivo teste007.txt não foi localizado.");
                }
            string[] dados = new string[4];


         System.IO.StreamReader Leitor = new System.IO.StreamReader(endereco);

                ltbLeitor.Items.Add("Código".PadRight(7) +
                "Cliente".PadRight(40) +
                "Cidade".PadRight(20) +
                "País"
                );
                ltbLeitor.Items.Add(new string('-', 80));

                while (!Leitor.EndOfStream)
                {
                    dados = Leitor.ReadLine().Split(';');
                    ltbLeitor.Items.Add(dados[0].PadRight(7) +
                                        dados[1].PadRight(40) +
                                        dados[2].PadRight(20) +
                                        dados[3]);
                }
                Leitor.Close();

            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
    }

