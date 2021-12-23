using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_10
{
    class Corner
    {
        double gradus;  // эти переменные внутри класса называются поля , делаем их НЕ public
        double min;      // и делаем ниже для них св-ва с большой буквы Gradus, Min, Sec
        double sec;

        public double Gradus   // "телохраниетль" для поля double gradus
        {
            get // действие, кт нужно сделать при получении св-ва .
            {
                return gradus; // вернем значение в поле
            }
            set // действие кт нужно сделать при установки св-ва
            {
                gradus = value % 360;
            }
        }
        public double Min
        {
            get
            {
                return min;
            }
            set
            {
                Gradus += value / 60; //( в  1 градусе 60 минут,  если больше 60 += накапливаем в градусы)
                                      // накапливаем в свойства Gradus,а не в переменную gradus
                min = value % 60;  //  остаток от деления на 60 в переменную минуты
            }
        }

        public double Sec
        {
            get
            {
                return sec;
            }
            set
            {
                Min += value / 60; // накапливаем в свойства Min, а не в переменную min
                sec = value % 60;  
            }
        }

        public Corner (double gradus, double min, double sec) // сделали конструктор, тип (double) не пишем
                                                              // имя совпадает с имененем класса
        {
            this.Gradus = gradus;  // помещаем значения в свойства Gradus
            this.Min = min;        // помещаем значения в свойства Min
            this.Sec = sec;        // помещаем значения в свойства Sec
        }

        public double ToRadians()  //метод ToRadians для перевода угла в радианы
        {
            return (gradus + (min + sec / 60) / 60) * Math.PI / 180;  // вернем значение в радианах
        }
    }
}
