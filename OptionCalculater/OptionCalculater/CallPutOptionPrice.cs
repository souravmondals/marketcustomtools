using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionCalculater
{
    public class CallPutOptionPrice
    {
        double S, K, r, q, T, v, Call;
        public CallPutOptionPrice(string Is, string Ik, string Ir, string Iq, string It, string Iv)
        {
            S = double.Parse(Is);
            K = double.Parse(Ik);
            r = Math.Round(double.Parse(Ir) / 100, 4);
            q = double.Parse(Iq);
            T = Math.Round(double.Parse(It) / 365, 6);
            v = Math.Round(double.Parse(Iv) / 100, 4);
        }
        public string callOptionPrice()
        {
            double d1 = (Math.Log(S / K) + (r - q + v * v / 2.0) * T) / v / Math.Sqrt(T);
            double d2 = d1 - v * Math.Sqrt(T);

            double b0 = 0.2316419;
            double b1 = 0.319381530;
            double b2 = -0.356563782;
            double b3 = 1.781477937;
            double b4 = -1.821255978;
            double b5 = 1.330274429;

            double pi = Math.PI;
            double phid1 = Math.Exp(-d1 * d1 / 2.0) / Math.Sqrt(2.0 * pi);
            double td1, cd1;
            double Nd1 = 0.5;
            if (d1 > 0.0)
            {
                td1 = 1.0 / (1.0 + b0 * d1);
                Nd1 = 1.0 - phid1 * (b1 * td1 + b2 * Math.Pow(td1, 2) + b3 * Math.Pow(td1, 3) + b4 * Math.Pow(td1, 4) + b5 * Math.Pow(td1, 5));
            }
            else if (d1 < 0.0)
            {
                d1 = -d1;
                td1 = 1.0 / (1.0 + b0 * d1);
                cd1 = 1.0 - phid1 * (b1 * td1 + b2 * Math.Pow(td1, 2) + b3 * Math.Pow(td1, 3) + b4 * Math.Pow(td1, 4) + b5 * Math.Pow(td1, 5));
                Nd1 = 1.0 - cd1;
            }
            double phid2 = Math.Exp(-d2 * d2 / 2.0) / Math.Sqrt(2.0 * pi);
            double td2, cd2;
            double Nd2 = 0.5;
            if (d2 > 0.0)
            {
                td2 = 1.0 / (1.0 + b0 * d2);
                Nd2 = 1.0 - phid2 * (b1 * td2 + b2 * Math.Pow(td2, 2) + b3 * Math.Pow(td2, 3) + b4 * Math.Pow(td2, 4) + b5 * Math.Pow(td2, 5));
            }
            else if (d2 < 0.0)
            {
                d2 = -d2;
                td2 = 1.0 / (1.0 + b0 * d2);
                cd2 = 1.0 - phid2 * (b1 * td2 + b2 * Math.Pow(td2, 2) + b3 * Math.Pow(td2, 3) + b4 * Math.Pow(td2, 4) + b5 * Math.Pow(td2, 5));
                Nd2 = 1.0 - cd2;
            }
            Call = S * Math.Exp(-q * T) * Nd1 - K * Math.Exp(-r * T) * Nd2;
            Call = Math.Round(Call, 0);
            return Call.ToString();
        }

        public string putOptionPrice()
        {
            double d1 = (Math.Log(S / K) + (r - q + v * v / 2.0) * T) / v / Math.Sqrt(T);
            double d2 = d1 - v * Math.Sqrt(T);

            d1 = -d1;
            d2 = -d2;

            double b0 = 0.2316419;
            double b1 = 0.319381530;
            double b2 = -0.356563782;
            double b3 = 1.781477937;
            double b4 = -1.821255978;
            double b5 = 1.330274429;

            double pi = Math.PI;
            double phid1 = Math.Exp(-d1 * d1 / 2.0) / Math.Sqrt(2.0 * pi);
            double td1, cd1;
            double Nd1 = 0.5;
            if (d1 > 0.0)
            {
                td1 = 1.0 / (1.0 + b0 * d1);
                Nd1 = 1.0 - phid1 * (b1 * td1 + b2 * Math.Pow(td1, 2) + b3 * Math.Pow(td1, 3) + b4 * Math.Pow(td1, 4) + b5 * Math.Pow(td1, 5));
            }
            else if (d1 < 0.0)
            {
                d1 = -d1;
                td1 = 1.0 / (1.0 + b0 * d1);
                cd1 = 1.0 - phid1 * (b1 * td1 + b2 * Math.Pow(td1, 2) + b3 * Math.Pow(td1, 3) + b4 * Math.Pow(td1, 4) + b5 * Math.Pow(td1, 5));
                Nd1 = 1.0 - cd1;
            }
            double phid2 = Math.Exp(-d2 * d2 / 2.0) / Math.Sqrt(2.0 * pi);
            double td2, cd2;
            double Nd2 = 0.5;
            if (d2 > 0.0)
            {
                td2 = 1.0 / (1.0 + b0 * d2);
                Nd2 = 1.0 - phid2 * (b1 * td2 + b2 * Math.Pow(td2, 2) + b3 * Math.Pow(td2, 3) + b4 * Math.Pow(td2, 4) + b5 * Math.Pow(td2, 5));
            }
            else if (d2 < 0.0)
            {
                d2 = -d2;
                td2 = 1.0 / (1.0 + b0 * d2);
                cd2 = 1.0 - phid2 * (b1 * td2 + b2 * Math.Pow(td2, 2) + b3 * Math.Pow(td2, 3) + b4 * Math.Pow(td2, 4) + b5 * Math.Pow(td2, 5));
                Nd2 = 1.0 - cd2;
            }
            
            Call = K * Math.Exp(-r * T) * Nd2 - S * Math.Exp(-q * T) * Nd1;
            Call = Math.Round(Call,0);
            return Call.ToString();
        }
    }
}
