        //method to mask string
        public static string Maskify(string cc)
        {
            //if the string is less than 4, then no mask required
            if (cc.Length < 4) return cc;

            //variable
            string maskString = "";

            //adds # for anything prior to last for characters
            for (int x = 0; x < cc.Length - 4; x++)
            {
                maskString += "#";
            }

            //returns output of the # string plus the last four chars
            return maskString += cc.Substring(cc.Length - 4, 4);

        }
