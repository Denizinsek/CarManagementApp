using System;
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
                ShowErrorMessage("Veriler yüklenirken hata oluştu", ex);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var newCar = CreateCarFromInput();
                conn.Cars.Add(newCar);
                conn.SaveChanges();
                LoadData();
                ShowSuccessMessage("Yeni araç başarıyla kaydedildi.");
                ClearInputFields();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Araç kaydedilirken hata oluştu", ex);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int carId = GetSelectedCarId();
                var carToUpdate = conn.Cars.FirstOrDefault(c => c.Id == carId);

                if (carToUpdate != null)
                {
                    UpdateCarFromInput(carToUpdate);
                    conn.SaveChanges();
                    LoadData();
                    ShowSuccessMessage("Araç bilgileri başarıyla güncellendi.");
                }
                else
                {
                    ShowWarningMessage("Güncellenecek araç bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Araç güncellenirken hata oluştu", ex);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int carId = GetSelectedCarId();
                var carToDelete = conn.Cars.FirstOrDefault(c => c.Id == carId);

                if (carToDelete != null)
                {
                    conn.Cars.Remove(carToDelete);
                    conn.SaveChanges();
                    LoadData();
                    ShowSuccessMessage("Araç başarıyla silindi.");
                    ClearInputFields();
                }
                else
                {
                    ShowWarningMessage("Silinecek araç bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Araç silinirken hata oluştu", ex);
            }
        }

        private Car CreateCarFromInput()
        {
            return new Car
            {
                CarSerialNo = GetIntFromTextBox(TxtBxCSerialNo),
                Brand = TxtBxBrand.Text,
                Model = TxtBxModel.Text,
                Color = TxtBxColor.Text
            };
        }

        private void UpdateCarFromInput(Car car)
        {
            car.CarSerialNo = GetIntFromTextBox(TxtBxCSerialNo);
            car.Brand = TxtBxBrand.Text;
            car.Model = TxtBxModel.Text;
            car.Color = TxtBxColor.Text;
        }

        private int GetSelectedCarId()
        {
            return Convert.ToInt32(TxtBxCSerialNo.Tag);
        }

        private int GetIntFromTextBox(TextBox textBox)
        {
            return Convert.ToInt32(textBox.Text);
        }

        private void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowWarningMessage(string message)
        {
            MessageBox.Show(message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ShowErrorMessage(string message, Exception ex)
        {
            MessageBox.Show(message + ": " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ClearInputFields()
        {
            TxtBxCSerialNo.Text = "";
            TxtBxBrand.Text = "";
            TxtBxModel.Text = "";
            TxtBxColor.Text = "";
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
