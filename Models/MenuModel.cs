using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sidebar.Models
{
    public class MenuModel
    {
        private string _characters = "abcdefABCDEF1234567890";
        public string Value { get; set; }
        private string Color { get; set; }
        public string Icon { get; set; }

        public string GetColor()
        {
            return Color;
        }
        public ErrorModel SetColor(string Hex)
        {
            ErrorModel Ret = new ErrorModel
            {
                Status = 0,
                Message = "This code is not a Color Hex."
            };
            if (!Hex.StartsWith("#")) return Ret;
            if ((Hex.Length != 4) && (Hex.Length != 7)) return Ret;
            for (int i = 0; i < Hex.Length; i++)
                if (!_characters.Contains(Hex[i])) return Ret;
            Ret.Status = 1;
            Ret.Message = "Sucess";
            Color = Hex;
            return Ret;
        }
    }
}
