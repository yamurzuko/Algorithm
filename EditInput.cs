using System;

namespace Algorithm
{
    public class EditInput
    {
        public bool CommaControl(string value)
        {
            foreach (var item in value)
            {
                if(Convert.ToString(item) == ",")
                {
                    return true;
                }
            }
            return false;
        }
        public bool IntControl(string value, Array arr)
        {
            foreach (var item in arr)
            {
                foreach (var character in value)
                {
                    if(Convert.ToString(item) == Convert.ToString(character))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}