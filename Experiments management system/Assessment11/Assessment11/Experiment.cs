using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment11
{
    class Experiment
    {
        private string _StudentName;
        private int _ExperimentNumber;
        private string _ExperimentDescription;
        private double _ResultWeight;
        private string _ResultColor;
        private double _ResultVolume;

        //constructors
        public Experiment()  {}
        public Experiment(string name)
        {
            _StudentName = name;
        }
        public Experiment(int experimentNumber, string experimentDescription)
        {
            _ExperimentNumber = experimentNumber;
            _ExperimentDescription = experimentDescription;
        }

        //studentname public property
        public string StudentName
        {
            get { return _StudentName; }
            set { _StudentName = value; }
        }

        //enperiment number public property
        public int ExperimentNumber
        {
            get { return _ExperimentNumber; }
            set { _ExperimentNumber = value; }
        }

        //experiment description public property
        public string ExperimentDescription
        {
            get { return (_ExperimentDescription); }
            set { _ExperimentDescription = value; }
        }

        //resultweight public property 
        public double ResultWeight
        {
            get { return _ResultWeight; }
            set { _ResultWeight = value; }
        }

        //resultcolor public property
        public string ResultColor
        {
            get { return _ResultColor; }
            set { _ResultColor = value; }
        }

        //result volume public property
        public double ResultVolume
        {
            get { return _ResultVolume; }
            set { _ResultVolume = value; }
        }

    }
}
