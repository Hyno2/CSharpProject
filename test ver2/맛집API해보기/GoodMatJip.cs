using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 맛집API해보기
{
    public class GoodMatJip
    {
        // public string cnt { get; set; }
      //  public string OPENDATA_ID { get; set; }
        
        public string FD_CS { get; set; }// 카테고리
        public string BZ_NM { get; set; }// 상호명
        public string GNG_CS { get; set; }// 주소
        public string MBZ_HR { get; set; }// 영업시간
        public string MNU { get; set; }// 메뉴
        public string TLNO { get; set; }    // 매장 전화번호
        public string SMPL_DESC { get; set; }// 매장설명
        public string BKN_YN { get; set; }  // 예약가능 여부

        public GoodMatJip(string FD_CS, string BZ_NM, string GNG_CS, string MBZ_HR,  string MNU, string TLNO, string SMPL_DESC, string BKN_YN )
        {
            //this.cnt = cnt;
            //this.OPENDATA_ID = OPENDATA_ID;
            this.FD_CS = FD_CS; // 카테고리
            this.BZ_NM = BZ_NM; // 상호명
            this.GNG_CS = GNG_CS; // 주소
            this.MBZ_HR = MBZ_HR; // 영업시간
            this.MNU = MNU; // 메뉴
            this.TLNO = TLNO;
            this.SMPL_DESC = SMPL_DESC; // 매장설명
            this.BKN_YN = BKN_YN; // 예약가능 여부
            
        }

        public GoodMatJip()
        {
        }
    }

}
