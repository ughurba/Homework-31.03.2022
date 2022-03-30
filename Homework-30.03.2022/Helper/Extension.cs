namespace Homework_30._03._2022.Models
{
    public static class Extension
    {
        public static bool CheckGroupNo(this string str, string groupNo)
        {
            if (groupNo.Length == 5)
            {

                bool num1 = false;
                bool num2 = false;
                bool num3 = false;
                bool num4 = false;
                bool num5 = false;
                //for (int i = 0; i < groupNo.Length; i++)
                //{

                if (char.IsUpper(groupNo[0]))
                {
                    num1 = true;
                }
                if (char.IsUpper(groupNo[1]))
                {
                    num2 = true;
                }
                if (char.IsNumber(groupNo[2]))
                {
                    num3 = true;
                }
                if (char.IsNumber(groupNo[3]))
                {
                    num4 = true;
                }
                if (char.IsNumber(groupNo[4]))
                {
                    num5 = true;
                }


                if (num1 == true && num2 == true && num3 == true && num4 == true && num5 == true)
                {
                    return true;
                }
            }
            return false;
        }



    }
}
