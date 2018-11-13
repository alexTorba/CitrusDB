using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CitrusDB.Model
{
    class Validate
    {
        bool lockerForPB = false;
        bool backLockerPB = false;

        public int DecreaseProgressBarLogic(int value, int points)
        {
            if (backLockerPB == true)
            {
                if (value != 0)
                    value -= points;

                lockerForPB = true;
                backLockerPB = false;
            }
            return value;
        }

        public int FillingProgressBarLogic(int value, int points)
        {
            if (lockerForPB == true)
            {
                value += points;

                lockerForPB = false;
                backLockerPB = true;
            }
            return value;
        }

        public void SetState(bool haveMistake)
        {
            if (haveMistake)
            {
                lockerForPB = true;
                backLockerPB = false;
            }
            else
            {
                lockerForPB = false;
                backLockerPB = true;
            }
        }

        public void SetState(bool haveMistake, bool isSingle)
        {
            if (haveMistake)
            {
                lockerForPB = true;
                backLockerPB = false;
            }
            else if (isSingle) Reset();
        }

        public void Reset()
        {
            lockerForPB = false;
            backLockerPB = false;
        }
       
    }
}