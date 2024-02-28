using Lotto5Adat.Data;
using Lotto5Adat.Models;
using Microsoft.EntityFrameworkCore.Storage;

namespace Lotto5Szimulacio
{
    public partial class Form1 : Form
    {
        private List<int> tippeltSzamok = new List<int>();
        private LottoContext _context =new LottoContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size = new Size(800, 700);
            panel.Size = new Size(480, 420);
            panel.BackColor = Color.Beige;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    CheckBox box = new CheckBox();
                    box.Text = (i * 10 + j + 1).ToString();
                    box.Tag = (i * 10 + j + 1).ToString();
                    box.CheckedChanged += checkBox1_CheckedChanged;
                    box.AutoSize = true;
                    box.Location = new Point(j * 40 + 40, i * 40 + 40);
                    panel.Controls.Add(box);
                }
            }
            btnSorsolas.Enabled = false;
            leredmenyek.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            if (box.Checked)
            {
                tippeltSzamok.Add(Convert.ToInt32(box.Tag));
                if (tippeltSzamok.Count == 5)
                {
                    btnSorsolas.Enabled = true;
                    this.Kapcsol(false);
                }
            }
            else
            {
                tippeltSzamok.Remove(Convert.ToInt32(box.Tag));
                if (tippeltSzamok.Count == 4)
                {
                    btnSorsolas.Enabled = false;
                    this.Kapcsol(true);
                }
            }
        }

        private void Kapcsol(bool be)
        {
            foreach (var item in panel.Controls)
            {
                if (item is CheckBox)
                {
                    if (be) ((CheckBox)item).Enabled = true;
                    else
                    {
                        if (!((CheckBox)item).Checked)
                            ((CheckBox)item).Enabled = false;
                    }
                }
            }
        }

        private void btnSorsolas_Click(object sender, EventArgs e)
        {
            HashSet<int> set = new HashSet<int>();
            Random rnd = new Random();
            do
            {
                //set.Add(rnd.Next(1, 6));
                set.Add(rnd.Next(1, 91));

            } while (set.Count != 5);

            leredmenyek.Text="A sorsolt számok: ("+String.Join(", ", set)+")\n";
            var talalat = set.Intersect(tippeltSzamok);
            leredmenyek.Text += "Ebbõl eltaláltál: " + (talalat.Count()) 
                + " db-ot! ("
                + String.Join(", ", talalat) + ")";
            _context.LottoSzam.Add(new LottoSzam(String.Join(";", set)));
            _context.SaveChanges();
        }
    }
}