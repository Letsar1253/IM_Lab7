using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IM_Lab7
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Кол-во сотрудников
        /// </summary>
        private int _countPersons;
        /// <summary>
        /// Кол-во дел
        /// </summary>
        private int _countCriminalCases;
        private int _time = 0;
        private Random _random = new Random();
        /// <summary>
        /// Загруженность участка
        /// </summary>
        private double _siteСongestion;
        /// <summary>
        /// Квалификация
        /// </summary>
        private double _qualification;
        /// <summary>
        /// Опасность дел
        /// </summary>
        private double _dangerLvl;
        private int _inCome;
        private int _outCome;
        /// <summary>
        /// Сколько ед. времени участок загруженность на максимум
        /// </summary>
        private int _countSiteСongestion = 0;
        /// <summary>
        /// Сколько ед. времени расширение участка применяется
        /// </summary>
        private int _countExpandSite = 0;
        /// <summary>
        /// Расширение участка
        /// </summary>
        private double _expandSite = 0;
        /// <summary>
        /// Время расследование дела
        /// </summary>
        private int _timeInvestigationCases;
        /// <summary>
        /// Время обработки заявлений
        /// </summary>
        private int _timeProcessingDeclaration;


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                chart1.Series[0].Points.Clear();
                _countPersons = (int)countPersons.Value;
                _countCriminalCases = (int)countСriminalСase.Value;
                _time = 0;
                timer1.Start();
                buttonStart.Text = "Стоп";
            }
            else
            {
                timer1.Stop();
                buttonStart.Text = "Старт";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            chart1.Series[0].Points.AddXY(_time, _countCriminalCases);
            _time++;

            
            _dangerLvl = _random.NextDouble();

            var randQualification = _random.NextDouble();
            randQualification += _dangerLvl * 0.3;
            _qualification = randQualification > 0.5 ? randQualification : randQualification + 0.5;

            _inCome = _random.Next(3, 24);
            
            _countCriminalCases += _inCome;

            _siteСongestion = _countCriminalCases / (_countPersons * 5 * _qualification);

            if (_expandSite > 0)
                _countExpandSite++;

            if (_countExpandSite == 1)
            {
                _countPersons = (int)(_countPersons * (1 + _expandSite));
                _siteСongestion = _countCriminalCases / (_countPersons * 5 * _qualification) - _expandSite;
            }

            if (_siteСongestion > 0.8)
                _countSiteСongestion++;

            if (_countSiteСongestion > 2)
            {
                _expandSite = _siteСongestion * _random.NextDouble();
                _countSiteСongestion = 0;
            }

            _timeProcessingDeclaration = Math.Min((int)(_siteСongestion * 10) + _inCome / 3,
                (int)(_siteСongestion * _qualification) + _inCome / 3);

            _timeInvestigationCases = 1 + Math.Min((int) (_siteСongestion * 10 + _timeProcessingDeclaration * 0.5),
                (int) (_qualification * 10 + _dangerLvl * 10));

            _outCome = (int)(100/_timeInvestigationCases);
            
            _countCriminalCases -= _outCome;
            _countCriminalCases = _countCriminalCases < 0 ? 0 : _countCriminalCases;
            if (_countCriminalCases == 0)
            {


            }

            if (_countExpandSite == 2)
            {
                _expandSite = 0;
                _countExpandSite = 0;
            }

            //_dangerLvl = 0;
            //for (int i = 0; i < _countCriminalCases; i++)
            //{

            //}


            //     Time++;

            //if (Time % ExpandPeriod == 0)
            //{
            //    ExpandCoeff = random.NextDouble();
            //    ExpandCoeffSumm += ExpandCoeff;

            //    StaffAmount += (int)(ExpandCoeff * StaffAmount);
            //    MaxPatients += (int)(ExpandCoeff * MaxPatients);
            //    MaxInCome += (int)(ExpandCoeff * MaxInCome);
            //}

            //InCome = Math.Min(MaxPatients - PatientAmount - ReAplications, random.Next(0, MaxInCome));

            //PatientAmount += InCome + ReAplications;

            //CureTime = random.Next(MinAnalysisTime, MaxAnalysisTime);
            ////* ((double)PatientAmount / MaxPatients);

            //HospitalCapacity = PatientAmount / (double)MaxPatients;

            //AllCureTime = (HospitalCapacity + 0.9) * CureTime;

            //int movablePatients = Math.Min((int)(PatientAmount * AllCureTime / 30), PatientAmount);
            //OutCome = (int)(movablePatients * 0.8);

            //PatientAmount -= OutCome;

            //chart.Series[0].Points.AddXY(Time, PatientAmount);

            //label_AllCureTime.Text = Math.Round(AllCureTime, 3).ToString();
            //label_Repeats.Text = ReAplications.ToString();
            //label_ExpandCoeffSumm.Text = Math.Round(ExpandCoeffSumm, 2).ToString();
            //label_HospitalCapacity.Text = Math.Round(HospitalCapacity * 100, 3) + " %";
            //label_Income.Text = InCome.ToString();
            //label_Outcome.Text = OutCome.ToString();

            //ReAplications = (int)(movablePatients * 0.2);
        }
    }
}
