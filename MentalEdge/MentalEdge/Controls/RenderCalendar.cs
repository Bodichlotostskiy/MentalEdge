using System;
using System.Collections.Generic;
using System.Text;

namespace MentalEdge.Controls
{
    public class RenderCalendar
    {
        public static void test()
        {
            RenderCalendar c = new RenderCalendar();
            string s = c.Draw();
        }

        public static void SetImage(Xamarin.Forms.Image calendarpic)
        {
            RenderCalendar c = new RenderCalendar();
            string s = c.Draw();
            calendarpic.Source = FFImageLoading.Svg.Forms.SvgImageSource.FromSvgString(s);
        }

        public string Rect(int x, int y, string color = "6FCF97", float opacity = 1)
        {
            return "<rect width=\"46\" height=\"46\" transform=\"translate(" + x + " " + y + ")\" fill=\"" + color + "\" fill-opacity=\"" + opacity + "\"/>";
        }
        public string Text(int x, int y, String t, string color = "white", float opacity = 1)
        {
            string s = "<text font-family=\"Poppins,Arial\" font-size=\"16\" y=\"" + y + "\" x=\"" + x + "\" transform=\"translate(5 20)\" opacity=\"" + opacity + "\" stroke-width=\"0\" fill=\"" + color + "\">" + t + "</text>\n";
            return s;
        }

        string circle(int x, int y, string color, float opacity)
        {
            return "<circle cx=\"" + x + "\" cy=\"" + y + "\" r=\"4\" opacity=\"" + opacity + "\" fill=\"" + color + "\"/>\n";
        }

        string circlerow(int x, int y, string color, int count)
        {
            string s = "";
            for (int i = 0; i < 4; i++)
            {
                bool active = i < count;
                s += circle(x + i * 10, y, active ? color : "#AFACBC", active ? 1.0f : 0.1f);
            }
            return s;
        }

        string circledoublerow(int x, int y, int red_count, int green_count)
        {
            return
            circlerow(x, y, "#EB5757", red_count) +
            circlerow(x, y + 10, "#6FCF97", green_count);
        }

        public string Draw()
        {
            DateTime dt = new DateTime(2021, 3, 10);
            DateTime month1st = new DateTime(dt.Year, dt.Month, 1);
            int DayStart = (int)month1st.DayOfWeek; //Sunday = 0
            int Daysinmonth = DateTime.DaysInMonth(month1st.Year, month1st.Month);

            StringBuilder s = new StringBuilder();
            s.Append("<svg width=\"343\" height=\"284\" viewBox=\"0 0 343 284\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">\n");
            s.Append("<rect width=\"100%\" height=\"100%\" fill=\"gray\"/>");

            Random r = new Random();
            int dayindex = 1;
            for (int yy = 1; yy < 6; yy++)
            {
                for (int xx = 0; xx < 7; xx++)
                {
                    double profit = r.Next(100) - 50;
                    int red_count = r.Next(5);
                    int green_count = r.Next(5);
                    if (r.Next(100) < 20) { profit = 0; green_count = 0; red_count = 0; }


                    int x = 49 * xx;
                    int y = 48 * yy - 5;
                    bool GRAY = (yy == 1 && xx < DayStart) || (dayindex > Daysinmonth);
                    if (GRAY) continue;
                    bool dayoff = profit == 0;

                    string c = profit > 0 ? "#6FCF97" : "#EB5757";
                    if (dayoff || GRAY) c = "#979797";
                    s.Append(Rect(x, y, c, 0.4f));
                    s.Append(circledoublerow(x + 8, y + 26, red_count, green_count));
                    s.Append(Text(x, y - 2, dayindex.ToString()));
                    dayindex++;
                }

                if (dayindex >= Daysinmonth) break;

            }
            int dx = 49;
            s.Append(Text(dx * 0, 0, "SUN", "#EBEBF5", 0.3f));
            s.Append(Text(dx * 1, 0, "MON", "#EBEBF5", 0.3f));
            s.Append(Text(dx * 2, 0, "TUE", "#EBEBF5", 0.3f));
            s.Append(Text(dx * 3, 0, "WED", "#EBEBF5", 0.3f));
            s.Append(Text(dx * 4, 0, "THU", "#EBEBF5", 0.3f));
            s.Append(Text(dx * 5, 0, "FRI", "#EBEBF5", 0.3f));
            s.Append(Text(dx * 6, 0, "SAT", "#EBEBF5", 0.3f));

            s.Append("</svg>");
            return s.ToString();
        }
    }
}
