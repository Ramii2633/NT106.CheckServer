using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace CheckServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Lấy địa chỉ IP hoặc tên máy cần kiểm tra từ ô textbox
            string host = tbHost.Text.Trim();

            // Kiểm tra xem checkbox "Địa chỉ IP" được chọn hay không
            bool isIpChecked = cbIsIP.Checked;

            // Nếu checkbox được chọn, địa chỉ nhập vào được xem là địa chỉ IP
            IPAddress ipAddress = null;
            if (isIpChecked && !IPAddress.TryParse(host, out ipAddress))
            {
                MessageBox.Show("Địa chỉ nhập vào không phải là địa chỉ IP.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Nếu checkbox không được chọn, thử giải thích tên máy thành địa chỉ IP
            if (!isIpChecked)
            {
                try
                {
                    IPHostEntry hostEntry = Dns.GetHostEntry(host);
                    ipAddress = hostEntry.AddressList[0];
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể giải thích tên máy.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Tạo đối tượng Socket
            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

           
            try
            {
                // Kết nối tới cổng FTP (cổng 21) của máy
                socket.Connect(ipAddress, 21);

                if (socket.Connected)
                {
                    MessageBox.Show($"Dịch vụ FTP đang chạy trên máy {host} ({ipAddress}).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Dịch vụ FTP không đang chạy trên máy {host} ({ipAddress}).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Địa chỉ IP là null.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SocketException ex)
            {
                MessageBox.Show($"Dịch vụ FTP không đang chạy trên máy {host} ({ipAddress}).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                // Đóng kết nối
                socket.Close();
            }
        }

    }
}