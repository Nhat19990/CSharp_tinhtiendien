namespace CSharp_tinhtiendien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnthanhtien_Click(object sender, EventArgs e)
        {
            float kwh = float.Parse(txtKwh.Text);

            // Biểu giá điện theo từng mức (VND/kWh)
            float gia_dien_muc_1 = 1678;  // cho 50 kWh đầu tiên
            float gia_dien_muc_2 = 1734;  // cho 50 kWh tiếp theo (từ 51 đến 100 kWh)
            float gia_dien_muc_3 = 2014;  // cho 100 kWh tiếp theo (từ 101 đến 200 kWh)
            float gia_dien_muc_4 = 2536;  // cho 100 kWh tiếp theo (từ 201 đến 300 kWh)
            float gia_dien_muc_5 = 2834;  // cho 100 kWh tiếp theo (từ 301 đến 400 kWh)
            float gia_dien_muc_6 = 2927;  // cho phần còn lại (từ 401 kWh trở lên)

            // Tính tiền điện
            float tien_dien = 0;

            if (kwh <= 50)
            {
                tien_dien = kwh * gia_dien_muc_1;
            }
            else if (kwh <= 100)
            {
                tien_dien = 50 * gia_dien_muc_1 + (kwh - 50) * gia_dien_muc_2;
            }
            else if (kwh <= 200)
            {
                tien_dien = 50 * gia_dien_muc_1 + 50 * gia_dien_muc_2 + (kwh - 100) * gia_dien_muc_3;
            }
            else if (kwh <= 300)
            {
                tien_dien = 50 * gia_dien_muc_1 + 50 * gia_dien_muc_2 + 100 * gia_dien_muc_3 + (kwh - 200) * gia_dien_muc_4;
            }
            else if (kwh <= 400)
            {
                tien_dien = 50 * gia_dien_muc_1 + 50 * gia_dien_muc_2 + 100 * gia_dien_muc_3 + 100 * gia_dien_muc_4 + (kwh - 300) * gia_dien_muc_5;
            }
            else
            {
                tien_dien = 50 * gia_dien_muc_1 + 50 * gia_dien_muc_2 + 100 * gia_dien_muc_3 + 100 * gia_dien_muc_4 + 100 * gia_dien_muc_5 + (kwh - 400) * gia_dien_muc_6;
            }

            // Hiển thị kết quả
            labelResult.Text = $" {tien_dien} VND";
        }
    }
}
