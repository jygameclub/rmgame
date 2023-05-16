using UnityEngine;

namespace Royal.Infrastructure.Services.Native.Purchase
{
    public struct PurchaseProduct
    {
        // Fields
        public readonly string id;
        public readonly string priceText;
        public readonly string priceString;
        public readonly float price;
        public readonly string currency;
        public readonly int numberId;
        
        // Methods
        public PurchaseProduct(string id, string price, string currency)
        {
        
        }
        public override string ToString()
        {
            throw 36601404;
        }
        private static string GetPriceText(string price, string currency)
        {
            string val_7;
            var val_8;
            string val_9;
            var val_10;
            string val_11;
            uint val_1 = _PrivateImplementationDetails_.ComputeStringHash(s:  currency);
            if(val_1 > (-2086752179))
            {
                goto label_1;
            }
            
            if(val_1 == (-2086752179))
            {
                goto label_2;
            }
            
            if(val_1 == 961436151)
            {
                goto label_3;
            }
            
            if(val_1 != 1568567338)
            {
                    return price + " <size=96%>"(" <size=96%>") + currency + "</size>"("</size>");
            }
            
            if((System.String.op_Equality(a:  currency, b:  "JPY")) == false)
            {
                    return price + " <size=96%>"(" <size=96%>") + currency + "</size>"("</size>");
            }
            
            val_7 = "<size=96%>¥</size> ";
            goto label_19;
            label_1:
            if(val_1 > (-1017840985))
            {
                goto label_7;
            }
            
            if(val_1 == (-1687429721))
            {
                goto label_8;
            }
            
            if(val_1 != (-1017840985))
            {
                    return price + " <size=96%>"(" <size=96%>") + currency + "</size>"("</size>");
            }
            
            if((System.String.op_Equality(a:  currency, b:  "EUR")) == false)
            {
                    return price + " <size=96%>"(" <size=96%>") + currency + "</size>"("</size>");
            }
            
            val_8 = " <size=96%>€</size>";
            goto label_11;
            label_7:
            if(val_1 == (-655792908))
            {
                goto label_12;
            }
            
            if(val_1 != (-296197266))
            {
                    return price + " <size=96%>"(" <size=96%>") + currency + "</size>"("</size>");
            }
            
            if((System.String.op_Equality(a:  currency, b:  "TRY")) == false)
            {
                    return price + " <size=96%>"(" <size=96%>") + currency + "</size>"("</size>");
            }
            
            val_8 = " <size=96%>TL</size>";
            label_11:
            val_10 = price;
            return val_7 + val_9;
            label_2:
            val_11 = "AUD";
            goto label_17;
            label_3:
            val_11 = "CAD";
            goto label_17;
            label_8:
            val_11 = "USD";
            label_17:
            if((System.String.op_Equality(a:  currency, b:  val_11)) == false)
            {
                    return price + " <size=96%>"(" <size=96%>") + currency + "</size>"("</size>");
            }
            
            val_7 = "<size=96%>$</size> ";
            goto label_19;
            label_12:
            if((System.String.op_Equality(a:  currency, b:  "GBP")) == false)
            {
                    return price + " <size=96%>"(" <size=96%>") + currency + "</size>"("</size>");
            }
            
            val_7 = "<size=96%>£</size> ";
            label_19:
            val_9 = price;
            return val_7 + val_9;
        }
        private static string GetPriceString(string price, string currency)
        {
            string val_7;
            if((System.String.op_Equality(a:  currency, b:  "KRW")) != true)
            {
                    if((System.String.op_Equality(a:  currency, b:  "JPY")) == false)
            {
                goto label_2;
            }
            
            }
            
            double val_3 = System.Convert.ToDouble(value:  price);
            val_7 = "{0:N0}";
            return (string)System.String.Format(format:  val_7 = "{0:N2}", arg0:  System.Convert.ToDouble(value:  price));
            label_2:
            return (string)System.String.Format(format:  val_7, arg0:  System.Convert.ToDouble(value:  price));
        }
    
    }

}
