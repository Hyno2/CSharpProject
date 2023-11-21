using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 맛집API해보기
{
    public class Convenience
    {
        #region 폼 빠르게 닫기
        public static void CloseFormOnEscape(KeyPressEventArgs e, Form form)
        {
            // ESC 키를 눌렀을 때
            if (e.KeyChar == (char)27)
            {
                form.Close(); // 현재 폼 닫기
            }
        }
        #endregion

    }
}
