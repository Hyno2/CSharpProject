using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 맛집API해보기
{
    public class DataManager
    {
        public static List<GoodMatJip> matJips = new List<GoodMatJip>();

<<<<<<< HEAD
=======

>>>>>>> 47678d6a480fc802fdba62d9edcbe2f8c20ba068
        static DataManager()
        {
            Load();
        }
<<<<<<< HEAD
=======

        #region 전체 조회
>>>>>>> 47678d6a480fc802fdba62d9edcbe2f8c20ba068
        public static void Load()
        {
            try
            {

                DBHelper.selectQuery();
                matJips.Clear();
                foreach (DataRow item in DBHelper.dt.Rows)
                {
                    GoodMatJip Matjips = new GoodMatJip();
                    Matjips.OPENDATA_ID = item["OPENDATA_ID"].ToString();
                    Matjips.GNG_CS = item["GNG_CS"].ToString();
                    Matjips.FD_CS = item["FD_CS"].ToString();
                    Matjips.BZ_NM = item["BZ_NM"].ToString();
                    Matjips.MBZ_HR = item["MBZ_HR"].ToString();
                    Matjips.MNU = item["MNU"].ToString();
                    Matjips.SMPL_DESC = item["SMPL_DESC"].ToString();
                    matJips.Add(Matjips);


                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

            }



        }
<<<<<<< HEAD

=======
        #endregion

        #region 각각 조회
        public static void SLoad(string keyword)
        {
            try
            {
                DBHelper.SelectQ(keyword);
                matJips.Clear();
                foreach (DataRow item in DBHelper.dt.Rows)
                {
                    GoodMatJip Matjips = new GoodMatJip();
                    Matjips.OPENDATA_ID = item["OPENDATA_ID"].ToString();
                    Matjips.GNG_CS = item["GNG_CS"].ToString();
                    Matjips.FD_CS = item["FD_CS"].ToString();
                    Matjips.BZ_NM = item["BZ_NM"].ToString();
                    Matjips.MBZ_HR = item["MBZ_HR"].ToString();
                    Matjips.MNU = item["MNU"].ToString();
                    Matjips.SMPL_DESC = item["SMPL_DESC"].ToString();
                    matJips.Add(Matjips);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
        #endregion
>>>>>>> 47678d6a480fc802fdba62d9edcbe2f8c20ba068


    }
}
