using UnityEngine;

namespace I2.Loc
{
    internal class ArabicTable
    {
        // Fields
        private static System.Collections.Generic.List<I2.Loc.ArabicMapping> mapList;
        private static I2.Loc.ArabicTable arabicMapper;
        
        // Properties
        internal static I2.Loc.ArabicTable ArabicMapper { get; }
        
        // Methods
        private ArabicTable()
        {
            System.Collections.Generic.List<I2.Loc.ArabicMapping> val_1 = new System.Collections.Generic.List<I2.Loc.ArabicMapping>();
            I2.Loc.ArabicTable.mapList = val_1;
            .from = 1569;
            .to = 65152;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1575;
            .to = 65165;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1571;
            .to = 65155;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1572;
            .to = 65157;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1573;
            .to = 65159;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1609;
            .to = 64508;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1574;
            .to = 65161;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1576;
            .to = 65167;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1578;
            .to = 65173;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1579;
            .to = 65177;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1580;
            .to = 65181;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1581;
            .to = 65185;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1582;
            .to = 65189;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1583;
            .to = 65193;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1584;
            .to = 65195;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1585;
            .to = 65197;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1586;
            .to = 65199;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1587;
            .to = 65201;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1588;
            .to = 65205;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1589;
            .to = 65209;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1590;
            .to = 65213;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1591;
            .to = 65217;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1592;
            .to = 65221;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1593;
            .to = 65225;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1594;
            .to = 65229;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1601;
            .to = 65233;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1602;
            .to = 65237;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1603;
            .to = 65241;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1604;
            .to = 65245;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1605;
            .to = 65249;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1606;
            .to = 65253;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1607;
            .to = 65257;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1608;
            .to = 65261;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1610;
            .to = 65265;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1570;
            .to = 65153;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1577;
            .to = 65171;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1662;
            .to = 64342;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1670;
            .to = 64378;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1688;
            .to = 64394;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1711;
            .to = 64402;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
            .from = 1705;
            .to = 64398;
            val_1.Add(item:  new I2.Loc.ArabicMapping());
        }
        internal static I2.Loc.ArabicTable get_ArabicMapper()
        {
            I2.Loc.ArabicTable val_2;
            I2.Loc.ArabicTable val_3 = I2.Loc.ArabicTable.arabicMapper;
            if(val_3 != null)
            {
                    return val_3;
            }
            
            I2.Loc.ArabicTable val_1 = null;
            val_2 = val_1;
            val_1 = new I2.Loc.ArabicTable();
            I2.Loc.ArabicTable.arabicMapper = val_2;
            val_3 = I2.Loc.ArabicTable.arabicMapper;
            return val_3;
        }
        internal int Convert(int toBeConverted)
        {
            int val_2 = toBeConverted;
            List.Enumerator<T> val_1 = I2.Loc.ArabicTable.mapList.GetEnumerator();
            label_4:
            if(((-1568491384) & 1) == 0)
            {
                goto label_2;
            }
            
            if(0 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if(11993091 != val_2)
            {
                goto label_4;
            }
            
            val_2 = 1;
            label_2:
            0.Dispose();
            return (int)val_2;
        }
    
    }

}
