using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Drawing.Printing;
using Microsoft.Reporting.WinForms;


namespace DoAn_2.MenuTab
{
    public partial class BanHangTT : Form
    {
        SqlConnection connect = ClassKetnoi.connect;
       
        ListBox listBox2 = new ListBox();
        public static string thoilai = "";
     
        int TienOK; 
        int txtno; 
        int thanhtoanno; 
        string sdtkh = xuathang.TenKH;
        string tenkh = xuathang.SDT;

        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        DataSet ds;
        SqlDataAdapter da;

        Label lbtenshop = new Label();
        Label lbdiachi = new Label();
        Label lbSDT = new Label();
        Label lbLoichao = new Label();
        public BanHangTT(ListBox.ObjectCollection Items)
        {
            InitializeComponent();
            txtTTOK.Text = xuathang.tt;
           

            listBox2.Items.AddRange(Items);


        }

        

        private void btnHuyTT_Click(object sender, EventArgs e)
        {
            Close();
           
        }

        private void btnOKTT_Click(object sender, EventArgs e)
        {
            // neu tiền thối lại âm thì sẽ tính là nợ
            string txttienthoi = txtTienThoiLai.Text;
            if (txtTienThoiLai.Text.StartsWith("-"))
            {
                if (string.IsNullOrEmpty(sdtkh) && string.IsNullOrEmpty(tenkh))
                {
                    MessageBox.Show("");
                    Close();
                }
                else
                {
                    string RemovetxtTienthoi = Regex.Replace(txttienthoi, @"[^0-9a-zA-Z]+", "");
                    MessageBox.Show(RemovetxtTienthoi);
                    txtno = int.Parse(RemovetxtTienthoi);
                    thanhtoanno = int.Parse(txtTienKhachDua.Text);//tien no trong sql
                    TienOK = thanhtoanno; //tienthanhtoan trong sql = tiền khách đưa khi nợ


                    try
                    {
                        using (var cmd = new SqlCommand("INSERT INTO Phieu (HDmasp,HDtensp,HDsl,HDdongia,HDloai,HDtt,HDdonvi,HDno,SDT,TenKH,HDtime,Nhanvien) VALUES (@HDmasp,@HDtensp,@HDsl,@HDdongia,@HDloai, @HDtt,@HDdonvi,@HDno,@SDT,@TenKH,@HDtime,@Nhanvien)"))
                        {
                            cmd.Connection = connect;
                            //  cmd.Parameters.AddWithValue("@IDhoadon", BanHang.IDhoadon);
                            cmd.Parameters.AddWithValue("@HDmasp", xuathang.HDmasp);
                            cmd.Parameters.AddWithValue("@HDtensp", xuathang.HDtensp);
                            cmd.Parameters.AddWithValue("@HDsl", xuathang.HDsl);
                            cmd.Parameters.AddWithValue("@HDdongia", xuathang.HDdongia);
                            cmd.Parameters.AddWithValue("@HDloai", xuathang.HDloai);
                            cmd.Parameters.AddWithValue("@HDthanhtoan", TienOK);//

                            cmd.Parameters.AddWithValue("@HDdonvi", xuathang.HDdonvi);
                            cmd.Parameters.AddWithValue("@HDno", txtno);

                            cmd.Parameters.AddWithValue("@SDT", xuathang.SDT);
                            cmd.Parameters.AddWithValue("@TenKH", xuathang.TenKH);
                            cmd.Parameters.Add("@HDtime", SqlDbType.DateTime);
                            cmd.Parameters["@HDtime"].Value = DateTime.Now;
                            cmd.Parameters.AddWithValue("@nvthanhtoan", MainControl.tennv);
                            connect.Open();
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                // MessageBox.Show("Đã thêm");
                                connect.Close();
                                PrintDialog printDialog = new PrintDialog();

                                PrintDocument printDocument = new PrintDocument();

                                printDialog.Document = printDocument; //add the document to the dialog box...        

                                printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing

                                //on a till you will not want to ask the user where to print but this is fine for the test envoironment.

                                DialogResult result = printDialog.ShowDialog();

                                if (result == DialogResult.OK)
                                {
                                    printDocument.Print();

                                }
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Thêm không thành công!");
                            }
                            connect.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        connect.Close();

                        MessageBox.Show("Error during insert: " + ex.Message);
                    }
                }


            }
            else
            {
                ////them vao sql khi khach không nợ
                txtno = 0;
                string tienthanhtoan = txtTTOK.Text;
                string CutTien = Regex.Replace(tienthanhtoan, @"[^0-9a-zA-Z]+", "");
                TienOK = int.Parse(CutTien);//tienthanhtoan trong sql = tiền thánh toán

                try
                {
                    using (var cmd = new SqlCommand("INSERT INTO Phieu (HDmasp,HDtensp,HDsl,HDdongia,HDloai,HDtt,HDdonvi,HDno,SDT,TenKH,HDtime,Nhanvien) VALUES (@HDmasp,@HDtensp,@HDsl,@HDdongia,@HDloai, @HDtt,@HDdonvi,@HDno,@SDT,@TenKH,@HDtime,@Nhanvien)"))
                    {
                        cmd.Connection = connect;
                       
                        cmd.Parameters.AddWithValue("@HDmasp", xuathang.HDmasp);
                        cmd.Parameters.AddWithValue("@HDtensp", xuathang.HDtensp);
                        cmd.Parameters.AddWithValue("@HDsl", xuathang.HDsl);
                        cmd.Parameters.AddWithValue("@HDdongia", xuathang.HDdongia);
                        cmd.Parameters.AddWithValue("@HDloai", xuathang.HDloai);
                        cmd.Parameters.AddWithValue("@HDtt", TienOK);//

                        cmd.Parameters.AddWithValue("@HDdonvi", xuathang.HDdonvi);
                        cmd.Parameters.AddWithValue("@HDno", txtno);

                        cmd.Parameters.AddWithValue("@SDT", xuathang.SDT);
                        cmd.Parameters.AddWithValue("@TenKH", xuathang.TenKH);
                        cmd.Parameters.Add("@HDtime", SqlDbType.DateTime);
                        cmd.Parameters["@HDtime"].Value = DateTime.Now;
                        cmd.Parameters.AddWithValue("@Nhanvien", MainControl.tennv);
                        connect.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            // MessageBox.Show("Đã thêm");
                            connect.Close();

                            //update sql so luong
                            //using (var cmd2 = new SqlCommand("update sanpham set soluongsp = soluongsp - 1 where masp=@masp"))
                            //{
                            //    cmd2.Connection = connect;
                            //    cmd2.Parameters.AddWithValue("@masp", txtid.Text);
                            //    connect.Open();
                            //    if (cmd2.ExecuteNonQuery() > 0)
                            //    {
                            //        MessageBox.Show("Đã xóa");                               
                            //    }
                            //    else
                            //    {
                            //        MessageBox.Show("Không thành công!");
                            //    }
                            //    connect.Close();
                            //}

                            ///print hoa don
                            PrintDialog printDialog = new PrintDialog();

                            PrintDocument printDocument = new PrintDocument();

                            printDialog.Document = printDocument; //add the document to the dialog box...        

                            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing

                            //on a till you will not want to ask the user where to print but this is fine for the test envoironment.

                            DialogResult result = printDialog.ShowDialog();

                            if (result == DialogResult.OK)
                            {
                                printDocument.Print();

                            }
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Thêm không thành công!");
                        }
                        connect.Close();
                    }
                }
                catch (Exception ex)
                {
                    connect.Close();

                    MessageBox.Show("Error during insert: " + ex.Message);
                }
            }

            
            Close();
        }

        public void CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //--------------------------------------------//
            int total = 0;
            float cash = float.Parse(txtTienKhachDua.Text);
            float change = 0f;

            //this prints the reciept

            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 12); //must use a mono spaced font as the spaces need to line up

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString(lbtenshop.Text, new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);

            graphic.DrawString(lbdiachi.Text, font, new SolidBrush(Color.Black), startX, 40);

            graphic.DrawString(lbSDT.Text, font, new SolidBrush(Color.Black), startX, 60);
            offset = offset + 50;
            string top = "Sản phẩm".PadRight(21) + "SL".PadRight(10) + "Giá trị ĐH".PadRight(10);
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent


            float totalprice = 0f;

            foreach (string item in listBox2.Items)
            {
                var items = item.Split('/');
                string Ltensp = items[0].ToString();
                int Lsoluongsp = int.Parse(items[1].ToString());
                float Lgiasp = float.Parse(items[2].ToString());
           //    MessageBox.Show(productPrice.ToString());
                //create the string to print on the reciept
              //  string productDescription = item;
               //string productTotal = item.Substring(item.Length - 6, 6);
                float productTotal = float.Parse(txtTTOK.Text);
             //   float productPrice = float.Parse(item.Substring(item.Length - 5, 5));

                //totalprice += productPrice;
               totalprice = productTotal;

                string ten = Ltensp;
                string dongia = Lgiasp.ToString();
                string slsp = Lsoluongsp.ToString();
                graphic.DrawString(ten, font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(slsp, font, new SolidBrush(Color.Black), 230, startY + offset);
                graphic.DrawString(dongia, font, new SolidBrush(Color.Black), 320, startY + offset);
                offset = offset + (int)fontHeight + 5; //make the spacing consistent


            }

            change = float.Parse(txtTienThoiLai.Text);

            //when we have drawn all of the items add the total

            offset = offset + 20; //make some room so that the total stands out.

            graphic.DrawString("Tổng giá trị ĐH ".PadRight(30) + totalprice.ToString("###,###"), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + 30; //make some room so that the total stands out.
            graphic.DrawString("Đã xác nhận ".PadRight(30) + cash.ToString("###,###"), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 15;
            graphic.DrawString("".PadRight(30) + change.ToString("###,###"), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 30; //make some room so that the total stands out.
            graphic.DrawString(lbLoichao.Text, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 15;
        }

        private void BanHangTT_Load(object dataSource, EventArgs e)
        {

            try
            {
                connect.Open();
                cmd.CommandText = "select TenShop,Diachi,SDT,Loichao from ThongTinShop where ID='1'";
                cmd.Connection = connect;
                rdr = cmd.ExecuteReader();
                bool temp = false;
                while (rdr.Read())
                {
                    lbtenshop.Text = rdr.GetString(0);
                    lbSDT.Text = rdr.GetString(2);
                    lbdiachi.Text = rdr.GetString(1);
                    lbLoichao.Text = rdr.GetString(3);
                    temp = true;
                }
                if (temp == false)
                    MessageBox.Show("not found");
                connect.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnTraDu_Click(object sender, EventArgs e)
        {
            txtTienKhachDua.Text = txtTTOK.Text;
        }

        

        private void txtXacnhan_TextChanged(object sender, EventArgs e)
        {
            double tienTT;
            double tienkhacdua;
            double TienThoiLai;
            if (txtTienKhachDua.Text.Length > 0)
            {
                tienTT = double.Parse(txtTTOK.Text);
                tienkhacdua = double.Parse(txtTienKhachDua.Text);

                //tienTT = double.Parse(txtTTOK.Text);
                //tienkhacdua = double.Parse(txtTienKhachDua.Text);

                TienThoiLai = tienkhacdua - tienTT;
                if (TienThoiLai == 0)
                {
                    txtTienThoiLai.Text = "0";
                }
                else
                {
                    txtTienThoiLai.Text = TienThoiLai.ToString("###,###");
                }
            }
            else
            {
                MessageBox.Show("Khong duoc nhap chu");
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            int tien0k = 0;
            txtTienKhachDua.Text = tien0k.ToString();
        }
    }
}
