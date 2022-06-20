using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    public class BLLValidation
    {
        private static BLLValidation _Instance;

        public static BLLValidation Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLLValidation();
                }
                return _Instance;
            }
            private set { }
        }

        private BLLValidation()
        {

        }

        public bool CheckName(string name)
        {
            return Regex.IsMatch(name, "^[a-zA-Z\\sàáãạảăắằẳẵặâấầẩẫậèéẹẻẽêềếểễệđìíĩỉịòóõọỏôốồổỗộơớờởỡợùúũụủưứừửữựỳỵỷỹýÀÁÃẠẢĂẮẰẲẴẶÂẤẦẨẪẬÈÉẸẺẼÊỀẾỂỄỆĐÌÍĨỈỊÒÓÕỌỎÔỐỒỔỖỘƠỚỜỞỠỢÙÚŨỤỦƯỨỪỬỮỰỲỴỶỸÝ]+$");
        }

        public bool CheckPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, "^[0-9]{10}$");
        }

        public bool CheckNumber(string number)
        {
            return Regex.IsMatch(number, "^[0-9]+$");
        }
    }
}
