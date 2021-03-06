﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimetableOfClasses;
using LibOfTimetableOfClasses;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_MTeacher
    {
        [TestMethod]
        public void Issue_252_1()
        {
            try
            {
                MTeacher T = new MTeacher("", "", "", "", "", "");
                Assert.AreEqual(typeof(String), T.FullName.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void Issue_252_2()
        {
            try
            {
                MTeacher T = new MTeacher("", "", "", "", "", "");
                Assert.AreEqual(typeof(String), T.Note.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void Issue_252_3()
        {
            try
            {
                MTeacher T = new MTeacher("", "", "", "", "", "");
                Assert.AreEqual(typeof(String), T.Departament.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void Issue_252_4()
        {
            try
            {
                MTeacher T = new MTeacher("", "", "", "", "", "");
                Assert.AreEqual(typeof(String), T.MetodicalDays.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void Issue_252_5()
        {
            try
            {
                MTeacher T = new MTeacher("", "", "", "", "", "");
                Assert.AreEqual(typeof(String), T.Windows.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void Issue_252_6()
        {
            try
            {
                MTeacher T = new MTeacher("", "", "", "", "", "");
                Assert.AreEqual(typeof(String), T.Weekends.GetType(), "Ожидался тип поля String");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
