﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StandartBlock
{
    class Entity
    {
        static int s_nextSerialNo;
        int _serialNo;

        public Entity()
        {
            _serialNo = s_nextSerialNo++;
        }
        public int GetSerialNo()
        {
            return _serialNo;
        }
        public static int GetNextSerialNo()
        {
            return s_nextSerialNo;
        }
        public static void SetNextSeralNo(int value)
        {
            s_nextSerialNo = value;
        }
    }
}
