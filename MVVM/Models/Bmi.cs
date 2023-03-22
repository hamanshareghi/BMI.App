using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;

namespace BMI.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Bmi
    {
        public float Height { get; set; }
        public float Weight { get; set; }

        public float Result
        {
            get { return (Weight / Height) / Height * 10000; }
        }
    }
}
