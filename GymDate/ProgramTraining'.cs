using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymDate
{
    public class ProgramTraining_
    {
        public TrainingType trainingType;

        public ProgramTraining_()
        {

        }
    }

    public enum TrainingType
    {
        ТяжелаяАтлетика,
        Кардио,
        Кроссфит,
        Йога
    }
}
