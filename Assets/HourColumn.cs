﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace CoreSys
{
    public class HourColumn : MonoBehaviour
    {
        public InputField sundayInput, mondayInput, tuesdayInput, wednesdayInput, thursdayInput, fridayInput, saturdayInput;//use to disable fields
        public Text hourLabel;
        public DailyHourlyStaff staffPanel;

        public HourColumn() { }

        public void SetHourColumn(int hour, bool sun, bool mon, bool tue, bool wed, bool thu, bool fri, bool sat)
        {
            staffPanel = transform.parent.GetComponent<DailyHourlyStaff>();
            //Set Title
            string hourText = hour.ToString();
            transform.name = hourText + " Hour Column";
            if (hour > 9)
                hourLabel.text = hourText + "00";
            else
                hourLabel.text = "0" + hourText + "00";
            //End Set Title
            //Begin setting days per hour
            if (sun)
            {
                sundayInput.gameObject.SetActive(true);
                staffPanel.sundayList.Add(sundayInput);
            }
            if (mon)
            {
                mondayInput.gameObject.SetActive(true);
                staffPanel.mondayList.Add(mondayInput);
            }
            if (tue)
            {
                tuesdayInput.gameObject.SetActive(true);
                staffPanel.tuesdayList.Add(tuesdayInput);
            }
            if (wed)
            {
                wednesdayInput.gameObject.SetActive(true);
                staffPanel.wednesdayList.Add(wednesdayInput);
            }
            if (thu)
            {
                thursdayInput.gameObject.SetActive(true);
                staffPanel.thursdayList.Add(thursdayInput);
            }
            if (fri)
            {
                fridayInput.gameObject.SetActive(true);
                staffPanel.fridayList.Add(fridayInput);
            }
            if (sat)
            {
                saturdayInput.gameObject.SetActive(true);
                staffPanel.saturdayList.Add(saturdayInput);
            }
        }
    }
}