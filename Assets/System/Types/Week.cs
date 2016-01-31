﻿using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using CoreSys.Employees;

namespace CoreSys
{
    public class Week
    {
        public int WeekID;
        public int JulianStartDay;
        public int earliestStart, latestEnd;
        public List<EmployeeScheduleWrapper> empList;//Including temp avail, as well as shifts(which can also be found daily)
        public DailySchedule sunday, monday, tuesday, wednesday, thursday, friday, saturday;
        //Position type(refer to CoreSystem for definition)
        //Dictionary<(Position), Dictionary<Day, Dictionary<Hour, Need>>>
        public Dictionary<int, Dictionary<int, Dictionary<int, int>>> staffingNeeds = new Dictionary<int, Dictionary<int, Dictionary<int, int>>>();
        // Use this for initialization

        /// <summary>
        /// Week should not be initialized with the default constructor || This exists for serialization
        /// </summary>
        public Week() { }

        public Week(int startDate)
        {
            JulianStartDay = startDate;
            WeekID = CoreSystem.GenerateWeekID();
        }

        public DailySchedule SelectDay(int i)
        {
            switch (i)
            {
                case 1:
                    return sunday;
                case 2:
                    return monday;
                case 3:
                    return tuesday;
                case 4:
                    return wednesday;
                case 5:
                    return thursday;
                case 6:
                    return friday;
                case 7:
                    return saturday;
                default:
                    Debug.Log("Default case chosen! || Week.cs || SelectDay");
                    return null;
            }
        }

        public void FillWeekDays(Dictionary<int, DailySchedule> days)
        {

        }

        //Set the basics of the week on a day to day basis.
        public void SetWeek(int suStartHour, int mStartHour, int tuStartHour, int wStartHour, int thStartHour, int fStartHour, int saStartHour, int suEndHour, int mEndHour,
            int tuEndHour, int wEndHour, int thEndHour, int fEndHour, int saEndHour, bool sun, bool mon, bool tue, bool wed, bool thu, bool fri, bool sat)
        {
            sunday.SetBaseInfo(sun, suStartHour, suEndHour);
            monday.SetBaseInfo(mon, mStartHour, mEndHour);
            tuesday.SetBaseInfo(tue, tuStartHour, tuEndHour);
            wednesday.SetBaseInfo(wed, wStartHour, wEndHour);
            thursday.SetBaseInfo(thu, thStartHour, thEndHour);
            friday.SetBaseInfo(fri, fStartHour, fEndHour);
            saturday.SetBaseInfo(sat, saStartHour, saEndHour);
            //End bool set
        }
    }
}