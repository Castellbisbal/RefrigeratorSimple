using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorSimple
{
    public class Refrigerator
    {
        private bool status;
        private bool superFreezing;
        private bool quickDefrosting;
        private bool vacation;
        private bool childProtection;
        private int temperature;
        private BrigthnessLevel brigthness;

        public Refrigerator(bool status, bool superFreezing, bool quickDefrosting, bool vacation, bool childProtection, int temperature, BrigthnessLevel brigthness)
        {
            this.status = status;
            this.superFreezing = superFreezing;
            this.quickDefrosting = quickDefrosting;
            this.vacation = vacation;
            this.childProtection = childProtection;

            if (temperature > -30 & temperature < 8)
            {
                this.temperature = temperature;
            }
            else
            {
                this.temperature = -15;
            }

            this.brigthness = brigthness;
        }

        public void On()
        {
            status = true;
        }

        public void Off()
        {
            status = false;
        }

        public void Increase()
        {
            if (temperature < 8)
            {
                temperature++;
            }
            else
            {
            }
        }

        public void Decrease()
        {
            if (temperature > -30)
            {
                temperature--;
            }
            else
            {
            }
        }

        public void FreezingOn()
        {
            superFreezing = true;
        }

        public void FreezingOff()
        {
            superFreezing = false;
        }

        public void DefrostingOn()
        {
            quickDefrosting = true;
        }

        public void DefrostingOff()
        {
            quickDefrosting = false;
        }

        public void VacOn()
        {
            vacation = true;
        }

        public void VacOff()
        {
            vacation = false;
        }

        public void ProtectOn()
        {
            childProtection = true;
        }

        public void ProtectOff()
        {
            childProtection = false;
        }

        public void HightLightTurn()
        {
            brigthness = BrigthnessLevel.High;
        }

        public void NormalLightTurn()
        {
            brigthness = BrigthnessLevel.Normal;
        }

        public void LowLightTurn()
        {
            brigthness = BrigthnessLevel.Low;
        }

        public string Info()
        {
            string status;
            if (this.status)
            {
                status = "включен";
            }
            else
            {
                status = "выключен";
            }

            string superFreesing;
            if (this.superFreezing)
            {
                superFreesing = "включена";
            }
            else
            {
                superFreesing = "отключена";
            }

            string quickDefrosting;
            if (this.quickDefrosting)
	        {
		         quickDefrosting="включена";
	        }
            else
            {
                quickDefrosting="отключена";
            }

            string vacation;
            if (this.vacation)
            {
                vacation = "включен";
            }
            else
            {
                vacation = "отключен";
            }

            string childProtection;
            if (this.childProtection)
            {
                childProtection = "включена";
            }
            else
            {
                childProtection = "отключена";
            }

            string brightness;
            if (this.brigthness==BrigthnessLevel.High)
	        {
                brightness="яркая";
	        }
            else
            {
                if (this.brigthness==BrigthnessLevel.Normal) 
                {
                    brightness="нормальная";
                }
                else
                {
                    brightness="тусклая";
                }
            }

            return "Холодильник " + status +"\n"+ "Температрура " + temperature +"\n"+ "Cуперзаморозка "+superFreesing+"\n"+"Быстрая разморозка "+ quickDefrosting+"\n"+"Защита от детей "+childProtection+"\n"+"Режим Отпуск "+vacation+"\n"+"Яркость подсветки "+brightness+"\n";
        }

    }
}
