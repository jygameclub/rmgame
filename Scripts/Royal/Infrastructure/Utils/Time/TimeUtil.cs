using UnityEngine;

namespace Royal.Infrastructure.Utils.Time
{
    public static class TimeUtil
    {
        // Fields
        private static string SecLocalized;
        private static string AgoLocalized;
        private static string MinLocalized;
        private static string MLocalized;
        public static string hLocalized;
        public static string sLocalized;
        private static string DLocalized;
        private static string DayLocalized;
        private static string DaysLocalized;
        private static bool IsAgoAtFront;
        private static readonly System.Text.StringBuilder StringBuilder;
        
        // Methods
        public static void CacheLocalizations()
        {
            var val_11;
            var val_12;
            bool val_13;
            val_11 = null;
            val_11 = null;
            Royal.Infrastructure.Utils.Time.TimeUtil.SecLocalized = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "sec");
            Royal.Infrastructure.Utils.Time.TimeUtil.AgoLocalized = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "ago");
            Royal.Infrastructure.Utils.Time.TimeUtil.MinLocalized = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "min");
            Royal.Infrastructure.Utils.Time.TimeUtil.DayLocalized = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "day");
            Royal.Infrastructure.Utils.Time.TimeUtil.DaysLocalized = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "days");
            Royal.Infrastructure.Utils.Time.TimeUtil.sLocalized = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "s");
            Royal.Infrastructure.Utils.Time.TimeUtil.MLocalized = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "m");
            Royal.Infrastructure.Utils.Time.TimeUtil.hLocalized = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "h");
            val_12 = null;
            Royal.Infrastructure.Utils.Time.TimeUtil.DLocalized = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "d");
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isFrench != false)
            {
                    val_13 = 1;
            }
            else
            {
                    val_13 = Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic;
            }
            
            val_12 = 1152921505126228152;
            Royal.Infrastructure.Utils.Time.TimeUtil.IsAgoAtFront = (val_13 == true) ? 1 : 0;
        }
        public static System.DateTime ToDateTime(long timestamp)
        {
            System.DateTime val_1 = 0.AddMilliseconds(value:  (double)timestamp);
            return (System.DateTime)val_1.dateData;
        }
        public static long CurrentTimeInMs()
        {
            System.DateTimeOffset val_1 = System.DateTimeOffset.UtcNow;
            return (long)val_1.m_dateTime.dateData.ToUnixTimeMilliseconds();
        }
        public static long CurrentLocalTimeInMs()
        {
            System.DateTimeOffset val_1 = System.DateTimeOffset.Now;
            System.DateTimeOffset val_2 = val_1.m_dateTime.dateData.ToLocalTime();
            return (long)val_2.m_dateTime.dateData.ToUnixTimeMilliseconds();
        }
        public static string GetRemainingTimeInFormat(long time)
        {
            null = null;
            System.Text.StringBuilder val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Clear();
            long val_2 = (-8608480567731124087) + time;
            long val_4 = (val_2 >> 5) + (val_2 >> 63);
            System.Text.StringBuilder val_6 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  val_4.ToString(format:  "D2"));
            System.Text.StringBuilder val_7 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  ':');
            long val_10 = 60;
            val_10 = time - (val_4 * val_10);
            System.Text.StringBuilder val_9 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  val_10.ToString(format:  "D2"));
            return (string)Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder;
        }
        public static string GetRemainingTimeInFormatWithHours(long totalSeconds)
        {
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic == false)
            {
                    return Royal.Infrastructure.Utils.Time.TimeUtil.GetRemainingTimeInFormatWithHoursDefault(totalSeconds:  totalSeconds);
            }
            
            return Royal.Infrastructure.Utils.Time.TimeUtil.GetRemainingTimeInFormatWithHoursArabic(totalSeconds:  totalSeconds);
        }
        private static string GetRemainingTimeInFormatWithHoursDefault(long totalSeconds)
        {
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            string val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            val_20 = totalSeconds;
            val_21 = null;
            val_21 = null;
            float val_21 = 60f;
            float val_20 = (float)val_20;
            val_20 = val_20 / val_21;
            val_21 = (float)W22 / val_21;
            float val_22 = (float)W23;
            val_22 = val_22 / 24f;
            System.Text.StringBuilder val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Clear();
            if(47591424 <= 0)
            {
                goto label_6;
            }
            
            val_23 = null;
            val_20 = 1094602752;
            if(==0)
            {
                goto label_7;
            }
            
            val_24 = null;
            System.Text.StringBuilder val_2 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  47591424);
            System.Text.StringBuilder val_3 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  Royal.Infrastructure.Utils.Time.TimeUtil.DLocalized);
            System.Text.StringBuilder val_4 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  ' ');
            System.Text.StringBuilder val_5 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  1094602752);
            val_25 = Royal.Infrastructure.Utils.Time.TimeUtil.hLocalized;
            goto label_32;
            label_6:
            val_26 = null;
            val_26 = null;
            val_22 = "D2";
            var val_23 = 0;
            val_23 = val_23 + W22;
            var val_7 = (val_23 >> 5) + (val_23 >> 31);
            System.Text.StringBuilder val_9 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  val_7.ToString(format:  "D2"));
            System.Text.StringBuilder val_10 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  ':');
            var val_24 = 60;
            val_24 = W22 - (val_7 * val_24);
            System.Text.StringBuilder val_12 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  val_24.ToString(format:  "D2"));
            System.Text.StringBuilder val_13 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  ':');
            long val_14 = (-8608480567731124087) + val_20;
            val_14 = (val_14 >> 5) + (val_14 >> 63);
            long val_25 = 60;
            val_25 = val_20 - (val_14 * val_25);
            val_25 = val_25.ToString(format:  "D2");
            goto label_32;
            label_7:
            val_27 = null;
            System.Text.StringBuilder val_17 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  47591424);
            System.Text.StringBuilder val_18 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  ' ');
            val_28 = null;
            if(47591424 == 1)
            {
                    val_29 = null;
                val_25 = Royal.Infrastructure.Utils.Time.TimeUtil.DayLocalized;
            }
            else
            {
                    val_30 = null;
                val_25 = Royal.Infrastructure.Utils.Time.TimeUtil.DaysLocalized;
            }
            
            label_32:
            System.Text.StringBuilder val_19 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  val_25);
            return (string)Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder;
        }
        private static string GetRemainingTimeInFormatWithHoursArabic(long totalSeconds)
        {
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            string val_28;
            var val_29;
            var val_30;
            var val_31;
            val_23 = totalSeconds;
            val_24 = null;
            val_24 = null;
            float val_24 = 60f;
            float val_23 = (float)val_23;
            val_23 = val_23 / val_24;
            val_24 = (float)W22 / val_24;
            float val_25 = (float)W23;
            val_25 = val_25 / 24f;
            System.Text.StringBuilder val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Clear();
            if(47591424 <= 0)
            {
                goto label_6;
            }
            
            val_23 = 1094602752;
            if(==0)
            {
                goto label_7;
            }
            
            val_26 = null;
            val_26 = null;
            System.Text.StringBuilder val_2 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  Royal.Infrastructure.Utils.Time.TimeUtil.hLocalized);
            System.Text.StringBuilder val_3 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  1094602752);
            System.Text.StringBuilder val_4 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  ' ');
            System.Text.StringBuilder val_5 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  Royal.Infrastructure.Utils.Time.TimeUtil.DLocalized);
            goto label_14;
            label_6:
            val_27 = null;
            val_27 = null;
            val_25 = "D2";
            var val_26 = 0;
            val_26 = val_26 + W22;
            var val_7 = (val_26 >> 5) + (val_26 >> 31);
            System.Text.StringBuilder val_9 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  val_7.ToString(format:  "D2"));
            System.Text.StringBuilder val_10 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  ':');
            var val_27 = 60;
            val_27 = W22 - (val_7 * val_27);
            System.Text.StringBuilder val_12 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  val_27.ToString(format:  "D2"));
            System.Text.StringBuilder val_13 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  ':');
            long val_14 = (-8608480567731124087) + val_23;
            val_14 = (val_14 >> 5) + (val_14 >> 63);
            long val_28 = 60;
            val_28 = val_23 - (val_14 * val_28);
            val_28 = val_28.ToString(format:  "D2");
            System.Text.StringBuilder val_17 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  val_28);
            return (string)Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder;
            label_7:
            val_29 = null;
            if(47591424 != 1)
            {
                goto label_23;
            }
            
            val_30 = null;
            System.Text.StringBuilder val_18 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  Royal.Infrastructure.Utils.Time.TimeUtil.DayLocalized);
            System.Text.StringBuilder val_19 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  ' ');
            val_28 = 1;
            goto label_29;
            label_23:
            val_31 = null;
            System.Text.StringBuilder val_20 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  Royal.Infrastructure.Utils.Time.TimeUtil.DaysLocalized);
            System.Text.StringBuilder val_21 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  ' ');
            label_14:
            val_28 = 47591424;
            label_29:
            System.Text.StringBuilder val_22 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  47591424);
            return (string)Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder;
        }
        public static string GetRemainingTimeInFormatWithMinutes(long totalSeconds)
        {
            null = null;
            System.Text.StringBuilder val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Clear();
            long val_2 = (-8608480567731124087) + totalSeconds;
            long val_4 = (val_2 >> 5) + (val_2 >> 63);
            System.Text.StringBuilder val_6 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  val_4.ToString(format:  "D2"));
            System.Text.StringBuilder val_7 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  ':');
            long val_10 = 60;
            val_10 = totalSeconds - (val_4 * val_10);
            System.Text.StringBuilder val_9 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  val_10.ToString(format:  "D2"));
            return (string)Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder;
        }
        public static System.DateTime MsToDateTime(long ms)
        {
            System.DateTime val_1 = System.DateTime.SpecifyKind(value:  new System.DateTime(), kind:  1);
            System.DateTime val_2 = val_1.dateData.AddMilliseconds(value:  (double)ms);
            return (System.DateTime)val_2.dateData;
        }
        public static float FramesToSeconds(float frames)
        {
            frames = frames / 60f;
            return (float)frames;
        }
        public static string GetPassedTimeInFormat(long time)
        {
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic == false)
            {
                    return Royal.Infrastructure.Utils.Time.TimeUtil.GetPassedTimeInFormatDefault(time:  time);
            }
            
            return Royal.Infrastructure.Utils.Time.TimeUtil.GetPassedTimeInFormatArabic(time:  time);
        }
        public static bool HasNegativeValue(long time)
        {
            long val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.CurrentTimeInMs();
            val_1 = (val_1 - time) >> 63;
            return (bool)val_1;
        }
        private static string GetPassedTimeInFormatDefault(long time)
        {
            var val_26;
            int val_27;
            var val_28;
            string val_29;
            var val_30;
            var val_31;
            var val_32;
            long val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.CurrentTimeInMs();
            val_26 = 1152921504781234176;
            float val_26 = (float)val_1 - time;
            val_26 = val_26 / 1000f;
            val_27 = (int)val_26;
            val_26 = (float)val_27 / 60f;
            System.Text.StringBuilder val_3 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Clear();
            if(val_1 <= 0)
            {
                goto label_6;
            }
            
            float val_4 = (float)val_1 / 60f;
            if(val_27 <= 0f)
            {
                goto label_9;
            }
            
            float val_27 = (float)val_27;
            val_27 = val_27 / 24f;
            if(val_26 <= 0)
            {
                goto label_12;
            }
            
            val_28 = null;
            val_28 = null;
            System.Text.StringBuilder val_6 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  1152921504781234176).Append(value:  ' ');
            System.Text.StringBuilder val_8 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  Royal.Infrastructure.Utils.Time.TimeUtil.DLocalized).Append(value:  ' ');
            System.Text.StringBuilder val_10 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  1102003048).Append(value:  ' ');
            val_29 = Royal.Infrastructure.Utils.Time.TimeUtil.hLocalized;
            goto label_47;
            label_6:
            val_30 = null;
            val_30 = null;
            System.Text.StringBuilder val_11 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  val_27);
            if(Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder != null)
            {
                goto label_26;
            }
            
            label_9:
            val_31 = null;
            val_31 = null;
            System.Text.StringBuilder val_13 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  val_1).Append(value:  ' ');
            System.Text.StringBuilder val_15 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  Royal.Infrastructure.Utils.Time.TimeUtil.MinLocalized).Append(value:  ' ');
            float val_28 = -60f;
            val_28 = (float)val_1 * val_28;
            val_28 = (float)val_27 + val_28;
            label_26:
            System.Text.StringBuilder val_17 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  val_28).Append(value:  ' ');
            val_29 = Royal.Infrastructure.Utils.Time.TimeUtil.SecLocalized;
            label_47:
            System.Text.StringBuilder val_18 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  val_29);
            return Royal.Infrastructure.Utils.Time.TimeUtil.AddAgo(text:  Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder);
            label_12:
            val_32 = null;
            val_32 = null;
            System.Text.StringBuilder val_20 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  val_27).Append(value:  ' ');
            System.Text.StringBuilder val_22 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  Royal.Infrastructure.Utils.Time.TimeUtil.hLocalized).Append(value:  ' ');
            System.Text.StringBuilder val_25 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  val_1 + (val_27 * 59)).Append(value:  ' ');
            goto label_47;
        }
        private static string GetPassedTimeInFormatArabic(long time)
        {
            var val_26;
            int val_27;
            var val_28;
            int val_29;
            var val_30;
            var val_31;
            var val_32;
            val_26 = 1152921504781234176;
            float val_26 = (float)Royal.Infrastructure.Utils.Time.TimeUtil.CurrentTimeInMs() - time;
            val_26 = val_26 / 1000f;
            val_27 = (int)val_26;
            val_26 = (float)val_27 / 60f;
            System.Text.StringBuilder val_3 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Clear();
            if(time <= 0)
            {
                goto label_6;
            }
            
            float val_4 = (float)time / 60f;
            if(val_27 <= 0f)
            {
                goto label_9;
            }
            
            float val_27 = (float)val_27;
            val_27 = val_27 / 24f;
            if(val_26 <= 0)
            {
                goto label_12;
            }
            
            val_28 = null;
            val_28 = null;
            System.Text.StringBuilder val_6 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  Royal.Infrastructure.Utils.Time.TimeUtil.hLocalized).Append(value:  ' ');
            System.Text.StringBuilder val_8 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  1102003048).Append(value:  ' ');
            System.Text.StringBuilder val_10 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  Royal.Infrastructure.Utils.Time.TimeUtil.DLocalized).Append(value:  ' ');
            val_29 = val_26;
            goto label_37;
            label_6:
            val_30 = null;
            val_30 = null;
            System.Text.StringBuilder val_11 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  Royal.Infrastructure.Utils.Time.TimeUtil.SecLocalized);
            if(Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder != null)
            {
                goto label_26;
            }
            
            label_9:
            val_31 = null;
            val_31 = null;
            System.Text.StringBuilder val_13 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  Royal.Infrastructure.Utils.Time.TimeUtil.SecLocalized).Append(value:  ' ');
            float val_28 = -60f;
            val_28 = (float)time * val_28;
            val_28 = (float)val_27 + val_28;
            System.Text.StringBuilder val_15 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  val_28).Append(value:  ' ');
            System.Text.StringBuilder val_17 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  Royal.Infrastructure.Utils.Time.TimeUtil.MinLocalized).Append(value:  ' ');
            val_29 = time;
            goto label_37;
            label_12:
            val_32 = null;
            val_32 = null;
            System.Text.StringBuilder val_19 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  Royal.Infrastructure.Utils.Time.TimeUtil.MinLocalized).Append(value:  ' ');
            System.Text.StringBuilder val_22 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  time + (val_27 * 59)).Append(value:  ' ');
            label_26:
            System.Text.StringBuilder val_24 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  Royal.Infrastructure.Utils.Time.TimeUtil.hLocalized).Append(value:  ' ');
            val_29 = val_27;
            label_37:
            System.Text.StringBuilder val_25 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  val_29);
            return Royal.Infrastructure.Utils.Time.TimeUtil.AddAgo(text:  Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder);
        }
        private static string AddAgo(string text)
        {
            var val_7;
            string val_10;
            val_7 = null;
            val_7 = null;
            System.Text.StringBuilder val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Clear();
            if(Royal.Infrastructure.Utils.Time.TimeUtil.IsAgoAtFront != false)
            {
                    System.Text.StringBuilder val_3 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  Royal.Infrastructure.Utils.Time.TimeUtil.AgoLocalized).Append(value:  ' ');
                val_10 = text;
            }
            else
            {
                    System.Text.StringBuilder val_5 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  text).Append(value:  ' ');
                val_10 = Royal.Infrastructure.Utils.Time.TimeUtil.AgoLocalized;
            }
            
            System.Text.StringBuilder val_6 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  val_10);
            goto typeof(System.Text.StringBuilder).__il2cppRuntimeField_160;
        }
        public static string GetLeftTimeInFormat(long totalSeconds)
        {
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic == false)
            {
                    return Royal.Infrastructure.Utils.Time.TimeUtil.GetLeftTimeInFormatDefault(totalSeconds:  totalSeconds);
            }
            
            return Royal.Infrastructure.Utils.Time.TimeUtil.GetLeftTimeInFormatArabic(totalSeconds:  totalSeconds);
        }
        private static string GetLeftTimeInFormatDefault(long totalSeconds)
        {
            long val_20;
            var val_21;
            var val_22;
            var val_23;
            string val_24;
            var val_25;
            var val_26;
            var val_27;
            val_20 = totalSeconds;
            val_21 = 1152921504781234176;
            val_22 = null;
            val_22 = null;
            float val_1 = (float)val_20 / 60f;
            System.Text.StringBuilder val_2 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Clear();
            if(47591424 <= 0)
            {
                goto label_6;
            }
            
            float val_3 = (4.759142E+07f) / 60f;
            if(val_20 <= 0)
            {
                goto label_9;
            }
            
            float val_20 = (float)val_20;
            val_20 = val_20 / 24f;
            if(val_21 <= 0)
            {
                goto label_12;
            }
            
            val_23 = null;
            val_23 = null;
            System.Text.StringBuilder val_4 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  1152921504781234176);
            System.Text.StringBuilder val_6 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  Royal.Infrastructure.Utils.Time.TimeUtil.DLocalized).Append(value:  ' ');
            System.Text.StringBuilder val_7 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  1102003048);
            val_24 = Royal.Infrastructure.Utils.Time.TimeUtil.hLocalized;
            goto label_34;
            label_6:
            val_25 = null;
            val_25 = null;
            System.Text.StringBuilder val_9 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  val_20).Append(value:  ' ');
            val_24 = Royal.Infrastructure.Utils.Time.TimeUtil.SecLocalized;
            goto label_34;
            label_9:
            val_26 = null;
            val_26 = null;
            System.Text.StringBuilder val_10 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  47591424);
            System.Text.StringBuilder val_12 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  Royal.Infrastructure.Utils.Time.TimeUtil.MLocalized).Append(value:  ' ');
            float val_21 = -60f;
            val_21 = (4.759142E+07f) * val_21;
            val_21 = (float)val_20 + val_21;
            System.Text.StringBuilder val_13 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  val_21);
            val_24 = Royal.Infrastructure.Utils.Time.TimeUtil.sLocalized;
            goto label_34;
            label_12:
            val_27 = null;
            val_27 = null;
            System.Text.StringBuilder val_14 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  val_20);
            System.Text.StringBuilder val_16 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  Royal.Infrastructure.Utils.Time.TimeUtil.hLocalized).Append(value:  ' ');
            System.Text.StringBuilder val_18 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  47591424 + (val_20 * 59));
            val_24 = Royal.Infrastructure.Utils.Time.TimeUtil.MLocalized;
            label_34:
            System.Text.StringBuilder val_19 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  val_24);
            goto typeof(System.Text.StringBuilder).__il2cppRuntimeField_160;
        }
        private static string GetLeftTimeInFormatArabic(long totalSeconds)
        {
            var val_21;
            var val_22;
            var val_23;
            long val_24;
            var val_25;
            var val_26;
            var val_27;
            val_21 = 1152921504781234176;
            val_22 = null;
            val_22 = null;
            float val_1 = (float)totalSeconds / 60f;
            System.Text.StringBuilder val_2 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Clear();
            if(47591424 <= 0)
            {
                goto label_6;
            }
            
            float val_3 = (4.759142E+07f) / 60f;
            if(totalSeconds <= 0)
            {
                goto label_9;
            }
            
            float val_21 = (float)totalSeconds;
            val_21 = val_21 / 24f;
            if(val_21 <= 0)
            {
                goto label_12;
            }
            
            val_23 = null;
            val_23 = null;
            System.Text.StringBuilder val_4 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  Royal.Infrastructure.Utils.Time.TimeUtil.hLocalized);
            System.Text.StringBuilder val_6 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  1102003048).Append(value:  ' ');
            System.Text.StringBuilder val_7 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  Royal.Infrastructure.Utils.Time.TimeUtil.DLocalized);
            val_24 = val_21;
            goto label_34;
            label_6:
            val_25 = null;
            val_25 = null;
            System.Text.StringBuilder val_9 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  Royal.Infrastructure.Utils.Time.TimeUtil.SecLocalized).Append(value:  ' ');
            val_24 = totalSeconds;
            System.Text.StringBuilder val_10 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  val_24);
            goto typeof(System.Text.StringBuilder).__il2cppRuntimeField_160;
            label_9:
            val_26 = null;
            val_26 = null;
            System.Text.StringBuilder val_11 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  Royal.Infrastructure.Utils.Time.TimeUtil.sLocalized);
            float val_22 = -60f;
            val_22 = (4.759142E+07f) * val_22;
            val_22 = (float)totalSeconds + val_22;
            System.Text.StringBuilder val_13 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  val_22).Append(value:  ' ');
            System.Text.StringBuilder val_14 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  Royal.Infrastructure.Utils.Time.TimeUtil.MLocalized);
            val_24 = 47591424;
            goto label_34;
            label_12:
            val_27 = null;
            val_27 = null;
            System.Text.StringBuilder val_15 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  Royal.Infrastructure.Utils.Time.TimeUtil.MLocalized);
            System.Text.StringBuilder val_18 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  47591424 + (totalSeconds * 59)).Append(value:  ' ');
            System.Text.StringBuilder val_19 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  Royal.Infrastructure.Utils.Time.TimeUtil.hLocalized);
            val_24 = totalSeconds;
            label_34:
            System.Text.StringBuilder val_20 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  val_24);
            goto typeof(System.Text.StringBuilder).__il2cppRuntimeField_160;
        }
        public static string GetDurationInMinutesOrHours(long totalMinutes)
        {
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic == false)
            {
                    return Royal.Infrastructure.Utils.Time.TimeUtil.GetDurationInMinutesOrHoursDefault(totalMinutes:  totalMinutes);
            }
            
            return Royal.Infrastructure.Utils.Time.TimeUtil.GetDurationInMinutesOrHoursArabic(totalMinutes:  totalMinutes);
        }
        private static string GetDurationInMinutesOrHoursDefault(long totalMinutes)
        {
            long val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_13;
            string val_14;
            var val_15;
            val_8 = totalMinutes;
            val_9 = null;
            val_9 = null;
            float val_8 = 60f;
            val_8 = (float)val_8 / val_8;
            System.Text.StringBuilder val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Clear();
            if(47591424 <= 0)
            {
                goto label_6;
            }
            
            val_10 = null;
            val_8 = val_8 - (2855485440 << );
            if(47591424 == 0)
            {
                goto label_7;
            }
            
            val_11 = null;
            System.Text.StringBuilder val_3 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  47591424).Append(value:  Royal.Infrastructure.Utils.Time.TimeUtil.hLocalized);
            System.Text.StringBuilder val_4 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  ' ');
            goto label_13;
            label_6:
            val_13 = null;
            val_13 = null;
            label_13:
            System.Text.StringBuilder val_5 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  val_8);
            val_14 = Royal.Infrastructure.Utils.Time.TimeUtil.MLocalized;
            goto label_18;
            label_7:
            val_15 = null;
            val_14 = Royal.Infrastructure.Utils.Time.TimeUtil.hLocalized;
            label_18:
            System.Text.StringBuilder val_7 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  47591424).Append(value:  val_14);
            goto typeof(System.Text.StringBuilder).__il2cppRuntimeField_160;
        }
        private static string GetDurationInMinutesOrHoursArabic(long totalMinutes)
        {
            var val_9;
            var val_10;
            var val_11;
            var val_13;
            long val_14;
            var val_15;
            long val_10 = totalMinutes;
            val_9 = null;
            val_9 = null;
            float val_9 = 60f;
            val_9 = (float)val_10 / val_9;
            System.Text.StringBuilder val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Clear();
            if(47591424 <= 0)
            {
                goto label_6;
            }
            
            val_10 = null;
            val_10 = val_10 - (2855485440 << );
            if(47591424 == 0)
            {
                goto label_7;
            }
            
            val_11 = null;
            System.Text.StringBuilder val_3 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  Royal.Infrastructure.Utils.Time.TimeUtil.MLocalized).Append(value:  val_10);
            System.Text.StringBuilder val_4 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  ' ');
            goto label_13;
            label_6:
            val_13 = null;
            val_13 = null;
            val_14 = val_10;
            System.Text.StringBuilder val_6 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  Royal.Infrastructure.Utils.Time.TimeUtil.MLocalized).Append(value:  val_14);
            goto typeof(System.Text.StringBuilder).__il2cppRuntimeField_160;
            label_7:
            val_15 = null;
            label_13:
            val_14 = 47591424;
            System.Text.StringBuilder val_8 = Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder.Append(value:  Royal.Infrastructure.Utils.Time.TimeUtil.hLocalized).Append(value:  47591424);
            goto typeof(System.Text.StringBuilder).__il2cppRuntimeField_160;
        }
        public static int ConvertMsToMinutes(long milliseconds)
        {
            System.TimeSpan val_1 = System.TimeSpan.FromMilliseconds(value:  (double)milliseconds);
            return (int)(int)val_1._ticks.TotalMinutes;
        }
        public static int ConvertMinToSec(int min)
        {
            min = min * 60;
            return (int)min;
        }
        private static TimeUtil()
        {
            Royal.Infrastructure.Utils.Time.TimeUtil.StringBuilder = new System.Text.StringBuilder();
        }
    
    }

}
