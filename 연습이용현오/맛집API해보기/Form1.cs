using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 맛집API해보기
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    List<Good> goods = new List<Good>();
        //    int count = 0;
        //    string[] matjips = new string[] { "중구", "동구" };
        //    //https://www.daegufood.go.kr/kor/api/tasty.html?mode=json&addr=%EC%A4%91%EA%B5%AC
        //    //"https://www.daegufood.go.kr/kor/api/Alley_food.html?mode=json&OPENDATA_ID=TL-11"
        //    WebClient wc = new WebClient();
        //    wc.Encoding = Encoding.UTF8;

        //    var json = wc.DownloadString("https://www.daegufood.go.kr/kor/api/tasty.html?mode=json&addr=%EC%A4%91%EA%B5%AC");

        //    var jArray =  JObject.Parse(json) ;
        //    var jarr = jArray["data"];
        //    var total = jArray["total"];

        //    while (count<int.Parse(total.ToString()))
        //    {
        //        // using 영역이 끝나면 wc의 메모리가 자동 해체됨
        //        //using (WebClient wc = new WebClient())
        //        //{
        //            wc.Encoding = Encoding.UTF8;

        //            //var json
        //            //    = wc.DownloadString("https://www.daegufood.go.kr/kor/api/tasty.html?mode=json&addr=%EC%A4%91%EA%B5%AC");
        //            //var jArray = JObject.Parse(json);
        //            //var jarr = jArray["data"];

        //            Good temp = new Good(
        //                jarr[count]["cnt"].ToString(),
        //                jarr[count]["OPENDATA_ID"].ToString(),
        //                jarr[count]["GNG_CS"].ToString(),
        //                jarr[count]["FD_CS"].ToString(),
        //                jarr[count]["BZ_NM"].ToString(),
        //                jarr[count]["MNU"].ToString(),
        //                jarr[count]["SMPL_DESC"].ToString(),
        //                jarr[count]["MBZ_HR"].ToString());
        //            count++;

        //            goods.Add(temp);
        //        //}
        //    }
        //    dataGridView1.DataSource = null;
        //    dataGridView1.DataSource = goods;
        //}



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Good> goods = new List<Good>();
            int count = 0;
            //string[] matjips = new string[] { "중구", "수성구", "남구", "동구", "북구", "서구", "달서구", "달성군" };
            WebClient wc = new WebClient();

            wc.Encoding = Encoding.UTF8;
            if (comboBox1.Text == "중구")
            {
                var json = wc.DownloadString("https://www.daegufood.go.kr/kor/api/tasty.html?mode=json&addr=%EC%A4%91%EA%B5%AC");
                var jArray = JObject.Parse(json);
                var jarr = jArray["data"];
                var total = jArray["total"];

                while (count < int.Parse(total.ToString()))
                {
                    // using 영역이 끝나면 wc의 메모리가 자동 해체됨
                    //using (WebClient wc = new WebClient())
                    //{
                    wc.Encoding = Encoding.UTF8;
                    //var json
                    //    = wc.DownloadString("https://www.daegufood.go.kr/kor/api/tasty.html?mode=json&addr=%EC%A4%91%EA%B5%AC");
                    //var jArray = JObject.Parse(json);
                    //var jarr = jArray["data"];

                    Good temp = new Good(
                        jarr[count]["cnt"].ToString(),
                        jarr[count]["BZ_NM"].ToString(),
                        jarr[count]["OPENDATA_ID"].ToString(),
                        jarr[count]["GNG_CS"].ToString(),
                        jarr[count]["FD_CS"].ToString(),
                        jarr[count]["MNU"].ToString().Replace("<br />", ", "),
                        jarr[count]["SMPL_DESC"].ToString(),
                        jarr[count]["MBZ_HR"].ToString());
                    count++;

                    goods.Add(temp);
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = goods;
            }
            else if (comboBox1.Text == "수성구")
            {
                var json = wc.DownloadString("https://www.daegufood.go.kr/kor/api/tasty.html?mode=json&addr=%EC%88%98%EC%84%B1%EA%B5%AC");

                var jArray = JObject.Parse(json);
                var jarr = jArray["data"];
                var total = jArray["total"];

                while (count < int.Parse(total.ToString()))
                {
                    wc.Encoding = Encoding.UTF8;
                    Good temp = new Good(
                        jarr[count]["cnt"].ToString(),
                        jarr[count]["OPENDATA_ID"].ToString(),
                        jarr[count]["GNG_CS"].ToString(),
                        jarr[count]["FD_CS"].ToString(),
                        jarr[count]["BZ_NM"].ToString(),
                        jarr[count]["MNU"].ToString().Replace("<br />", ", "),
                        jarr[count]["SMPL_DESC"].ToString(),
                        jarr[count]["MBZ_HR"].ToString());
                    count++;

                    goods.Add(temp);
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = goods;
            }
            else if (comboBox1.Text == "남구")
            {
                var json = wc.DownloadString("https://www.daegufood.go.kr/kor/api/tasty.html?mode=json&addr=%EB%82%A8%EA%B5%AC");

                var jArray = JObject.Parse(json);
                var jarr = jArray["data"];
                var total = jArray["total"];

                while (count < int.Parse(total.ToString()))
                {
                    wc.Encoding = Encoding.UTF8;
                    Good temp = new Good(
                        jarr[count]["cnt"].ToString(),
                        jarr[count]["OPENDATA_ID"].ToString(),
                        jarr[count]["GNG_CS"].ToString(),
                        jarr[count]["FD_CS"].ToString(),
                        jarr[count]["BZ_NM"].ToString(),
                        jarr[count]["MNU"].ToString().Replace("<br />", ", "),
                        jarr[count]["SMPL_DESC"].ToString(),
                        jarr[count]["MBZ_HR"].ToString());
                    count++;

                    goods.Add(temp);
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = goods;
            }
            else if (comboBox1.Text == "동구")
            {
                var json = wc.DownloadString("https://www.daegufood.go.kr/kor/api/tasty.html?mode=json&addr=%EB%8F%99%EA%B5%AC");

                var jArray = JObject.Parse(json);
                var jarr = jArray["data"];
                var total = jArray["total"];

                while (count < int.Parse(total.ToString()))
                {
                    wc.Encoding = Encoding.UTF8;
                    Good temp = new Good(
                        jarr[count]["cnt"].ToString(),
                        jarr[count]["OPENDATA_ID"].ToString(),
                        jarr[count]["GNG_CS"].ToString(),
                        jarr[count]["FD_CS"].ToString(),
                        jarr[count]["BZ_NM"].ToString(),
                        jarr[count]["MNU"].ToString().Replace("<br />", ", "),
                        jarr[count]["SMPL_DESC"].ToString(),
                        jarr[count]["MBZ_HR"].ToString());
                    count++;

                    goods.Add(temp);
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = goods;
            }
            else if (comboBox1.Text == "서구")
            {
                var json = wc.DownloadString("https://www.daegufood.go.kr/kor/api/tasty.html?mode=json&addr=%EC%84%9C%EA%B5%AC");

                var jArray = JObject.Parse(json);
                var jarr = jArray["data"];
                var total = jArray["total"];

                while (count < int.Parse(total.ToString()))
                {
                    wc.Encoding = Encoding.UTF8;
                    Good temp = new Good(
                        jarr[count]["cnt"].ToString(),
                        jarr[count]["OPENDATA_ID"].ToString(),
                        jarr[count]["GNG_CS"].ToString(),
                        jarr[count]["FD_CS"].ToString(),
                        jarr[count]["BZ_NM"].ToString(),
                        jarr[count]["MNU"].ToString().Replace("<br />", ", "),
                        jarr[count]["SMPL_DESC"].ToString(),
                        jarr[count]["MBZ_HR"].ToString());
                    count++;

                    goods.Add(temp);
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = goods;
            }
            else if (comboBox1.Text == "북구")
            {
                var json = wc.DownloadString("https://www.daegufood.go.kr/kor/api/tasty.html?mode=json&addr=%EB%B6%81%EA%B5%AC");

                var jArray = JObject.Parse(json);
                var jarr = jArray["data"];
                var total = jArray["total"];

                while (count < int.Parse(total.ToString()))
                {
                    wc.Encoding = Encoding.UTF8;
                    Good temp = new Good(
                        jarr[count]["cnt"].ToString(),
                        jarr[count]["OPENDATA_ID"].ToString(),
                        jarr[count]["GNG_CS"].ToString(),
                        jarr[count]["FD_CS"].ToString(),
                        jarr[count]["BZ_NM"].ToString(),
                        jarr[count]["MNU"].ToString().Replace("<br />", ", "),
                        jarr[count]["SMPL_DESC"].ToString(),
                        jarr[count]["MBZ_HR"].ToString());
                    count++;

                    goods.Add(temp);
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = goods;
            }
            else if (comboBox1.Text == "달서구")
            {
                var json = wc.DownloadString("https://www.daegufood.go.kr/kor/api/tasty.html?mode=json&addr=%EB%8B%AC%EC%84%9C%EA%B5%AC");

                var jArray = JObject.Parse(json);
                var jarr = jArray["data"];
                var total = jArray["total"];

                while (count < int.Parse(total.ToString()))
                {
                    wc.Encoding = Encoding.UTF8;
                    Good temp = new Good(
                        jarr[count]["cnt"].ToString(),
                        jarr[count]["OPENDATA_ID"].ToString(),
                        jarr[count]["GNG_CS"].ToString(),
                        jarr[count]["FD_CS"].ToString(),
                        jarr[count]["BZ_NM"].ToString(),
                        jarr[count]["MNU"].ToString().Replace("<br />", ", "),
                        jarr[count]["SMPL_DESC"].ToString(),
                        jarr[count]["MBZ_HR"].ToString());
                    count++;

                    goods.Add(temp);
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = goods;
            }
            else if (comboBox1.Text == "달성군")
            {
                var json = wc.DownloadString("https://www.daegufood.go.kr/kor/api/tasty.html?mode=json&addr=%EB%8B%AC%EC%84%B1%EA%B5%B0");

                var jArray = JObject.Parse(json);
                var jarr = jArray["data"];
                var total = jArray["total"];

                while (count < int.Parse(total.ToString()))
                {
                    wc.Encoding = Encoding.UTF8;
                    Good temp = new Good(
                        jarr[count]["cnt"].ToString(),
                        jarr[count]["OPENDATA_ID"].ToString(),
                        jarr[count]["GNG_CS"].ToString(),
                        jarr[count]["FD_CS"].ToString(),
                        jarr[count]["BZ_NM"].ToString(),
                        jarr[count]["MNU"].ToString().Replace("<br />", ", "),
                        jarr[count]["SMPL_DESC"].ToString(),
                        jarr[count]["MBZ_HR"].ToString());
                    count++;

                    goods.Add(temp);
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = goods;
            }


        }
    }
}

