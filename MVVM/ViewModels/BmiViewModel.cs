using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMI.MVVM.Models;

namespace BMI.MVVM.ViewModels
{
    public class BmiViewModel
    {
        public Bmi Bmi { get; set; }
        public BmiViewModel()
        {
            Bmi = new Bmi();
            Bmi.Weight = 73;
            Bmi.Height = 180;
        }


    }
}
