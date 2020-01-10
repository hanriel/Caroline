using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caroline
{
    class Emotions
    {

        static Random rnd = new Random();

        private List<string> angry = new List<string>();
        private List<string> fatigue = new List<string>();
        private List<string> happy = new List<string>();

        public Emotions()
        {
            angry.Add("٩(╬ʘ益ʘ╬)۶");
            angry.Add("o(≧o≦)o");
            angry.Add("(ノಠ益ಠ)ノ");
            angry.Add("(>_<)");
            fatigue.Add("(ᴗ˳ᴗ)");
            fatigue.Add("(∪｡∪)｡｡｡zzz");
            happy.Add("(✌ﾟ∀ﾟ)☞");
            happy.Add("ʘ‿ʘ");
            happy.Add("꒰⑅•ᴗ•⑅꒱");
        }

        

        public string feels(string text)
        {
            switch (text)
            {
                case "fury":
                    return "ಠ▃ಠ";
                case "angry":
                    int r_angry = rnd.Next(angry.Count());
                    return angry[r_angry];
                case "happy":
                    int r_happy = rnd.Next(happy.Count());
                    return happy[r_happy];
                case "cloud":
                    return "꒰⑅•ᴗ•⑅꒱";
                case "confused":
                    return "(☉_☉)";
                case "fatigue":
                    int r_fatigue = rnd.Next(fatigue.Count());
                    return fatigue[r_fatigue];

            }
            return "NULL";
        }
        
}
}
