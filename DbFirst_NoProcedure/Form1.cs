using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DbFirst_NoProcedure
{
    public partial class Form1 : Form
    {
        private DbFirstAppEntities conn;

        public Form1()
        {
            InitializeComponent();
            conn = new DbFirstAppEntities();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData(); // Form yüklendiğinde verileri yükle
        }

        private void LoadData()
        {
            try
            {
                DGridView.DataSource = conn.Cars.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Car newCar = new Car
                {
                    CarSerialNo = Convert.ToInt32(TxtBxCSerialNo.Text),
                    Brand = TxtBxBrand.Text,
                    Model = TxtBxModel.Text,
                    Color = TxtBxColor.Text
                };

                conn.Cars.Add(newCar);
                conn.SaveChanges();

                LoadData(); // Verileri yeniden yükle

                MessageBox.Show("Yeni araç başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Araç kaydedilirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(TxtBxCSerialNo.Tag);
                var updateCar = conn.Cars.FirstOrDefault(c => c.Id == id);

                if (updateCar != null)
                {
                    updateCar.CarSerialNo = Convert.ToInt32(TxtBxCSerialNo.Text);
                    updateCar.Brand = TxtBxBrand.Text;
                    updateCar.Model = TxtBxModel.Text;
                    updateCar.Color = TxtBxColor.Text;

                    conn.SaveChanges();

                    LoadData(); // Verileri yeniden yükle

                    MessageBox.Show("Araç bilgileri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Güncellenecek araç bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Araç güncellenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(TxtBxCSerialNo.Tag);
                var deleteCar = conn.Cars.FirstOrDefault(c => c.Id == id);

                if (deleteCar != null)
                {
                    conn.Cars.Remove(deleteCar);
                    conn.SaveChanges();

                    LoadData(); // Verileri yeniden yükle

                    MessageBox.Show("Araç başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Silinecek araç bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Araç silinirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGridView.Rows[e.RowIndex];

                TxtBxCSerialNo.Tag = row.Cells["Id"].Value.ToString();
                TxtBxCSerialNo.Text = row.Cells["CarSerialNo"].Value.ToString();
                TxtBxBrand.Text = row.Cells["Brand"].Value.ToString();
                TxtBxModel.Text = row.Cells["Model"].Value.ToString();
                TxtBxColor.Text = row.Cells["Color"].Value.ToString();
            }
        }
    }
}
