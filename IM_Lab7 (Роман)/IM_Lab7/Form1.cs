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
        /// 
        private int _PrevcountPersons;
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
        private double _qualification=0;
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
        private int _expandSite = 1;
        /// <summary>
        /// Время расследование дела
        /// </summary>
        private double _timeInvestigationCases;
        /// <summary>
        /// Время обработки заявлений
        /// </summary>
        private double _timeProcessingDeclaration;


       

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
                _PrevcountPersons = _countPersons;
                _countCriminalCases = (int)countСriminalСase.Value;
                _qualification = 0;
                _expandSite = 1;
                for (int i=0; i< _countPersons; i++)
                _qualification += _random.NextDouble() / _countPersons;

             

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

            _inCome = _random.Next(3, 24);  //новые заявления

            _countCriminalCases += _inCome;

            _dangerLvl = _random.Next(0, 3); //уровень опасности дел

            for (int i = _PrevcountPersons; i < _countPersons; i++)
            {
                if (_random.NextDouble()>0.5)
                _qualification += _random.NextDouble() / _countPersons;
                else _qualification -= _random.NextDouble() / _countPersons;
            }
                
            _qualification =Math.Min(_qualification+ 0.008 * _dangerLvl , 2); //квалификация персонала
   
            _PrevcountPersons = _countPersons;

            if (_countExpandSite == 0) // штатный режим  работы
                _siteСongestion = _countCriminalCases / (_countPersons * 5 * _qualification + _expandSite);


            if (_countExpandSite >= 1 && _countExpandSite <= 4) //расширение штаба сотрудников
            {
                _countPersons = _countPersons +_random.Next(0, 2);              
                _siteСongestion = _countCriminalCases / (_countPersons * 5 * _qualification +  _expandSite);
                if (_countExpandSite == 4) _countExpandSite = 0;
                else _countExpandSite++;
            }

            if (_countExpandSite == 0)
            {
                if (_siteСongestion > 2) _countSiteСongestion++;   //обнаружение перегруженности участка
                if (_siteСongestion > 3) _countSiteСongestion+=3;   //обнаружение перегруженности участка
                if (_siteСongestion > 4) _countSiteСongestion += 6;   //обнаружение перегруженности участка
                if (_siteСongestion > 5) _countSiteСongestion += 10;  //обнаружение перегруженности участка
            }

            if (_countSiteСongestion > 50) //обнаружение перегруженности участка в течение продолжительного промежутка времени и расширение участка
            {
                _expandSite++;             
                _countExpandSite++;
                _countSiteСongestion = 0;
            }


            _timeProcessingDeclaration = (_inCome* 0.1 * (_siteСongestion/2 + 0.01 / _qualification));

            _timeInvestigationCases = ((_siteСongestion * 150 *( _timeProcessingDeclaration + 1/_qualification + _dangerLvl ))/_countCriminalCases); //average

            _outCome = Math.Min((int)(_countCriminalCases*(0.1/_timeInvestigationCases)), //кол-во расследованных дел
              (_countCriminalCases));
            
            _countCriminalCases -= _outCome;

            countPersons.Value= _countPersons;
            loadness.Value = (decimal)_siteСongestion;
            qualy.Value = (decimal)_qualification;
            site.Value = _expandSite;
            timeProc.Value = (decimal)_timeProcessingDeclaration;
            timeInvest.Value = (decimal)_timeInvestigationCases;
        }
    }
}
