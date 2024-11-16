using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {            
            var values = db.Guide.ToList();            
            dataGridView1.DataSource = values;     // data grid wiew kısmına valuesi yazdır.  
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guide guide = new Guide();  // BÜYÜK olan sınıf küçük olan nesne örneği.
            guide.GuideName = txtName.Text;  // guidename dediğimiz değer txtNmaeden gelen deer olacak.
            guide.GuideSurname = txtSurname.Text;
            db.Guide.Add(guide);    // guide databesesine 33. satırdaki küçük guide nesnesini ekliyor. o nesnede 34 ve 35. satırdaki ad soyadı tutuyor.
            db.SaveChanges();  // kaydetmek için bunu yazdık.
            MessageBox.Show("Rehber Başarıyla Eklendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse (txtId.Text);
            var removeValue = db.Guide.Find(id);
            db.Guide.Remove(removeValue);
            MessageBox.Show("Rehber Başarıyle Silindi");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updateValue = db.Guide.Find(id);
            updateValue.GuideName = txtName.Text;
            updateValue.GuideSurname= txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla Güncellendi","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var values = db.Guide.Where(x=>x.GuideId==id).ToList();
            dataGridView1.DataSource=values;

        }
    }
}
