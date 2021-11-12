using Microsoft.VisualStudio.TestTools.UnitTesting;
using FakerLib;
using System;
using System.Collections.Generic;
using FakerApp;

namespace Test
{
    [TestClass]
    public class Tests
    {
        private Faker faker = new Faker();

        [TestMethod]
        public void TestSimpleType()
        {
            var testValue = faker.create<int>();
            Assert.IsInstanceOfType(testValue, typeof(int));
        }

        [TestMethod]
        public void TestCharType()
        {
            var testValue = faker.create<char>();
            Assert.IsInstanceOfType(testValue, typeof(char));
        }

        [TestMethod]
        public void TestDateType()
        {
            var testValue = faker.create<DateTime>();
            Assert.IsInstanceOfType(testValue, typeof(DateTime));
        }

        [TestMethod]
        public void TestCollectionType()
        {
            var testValue = faker.create<List<string>>();
            Assert.IsInstanceOfType(testValue[0], typeof(string));
        }

        [TestMethod]
        public void TestCollectionType2()
        {
            var testValue = faker.create<List<int>>();
            Assert.IsInstanceOfType(testValue[0], typeof(int));
        }

        [TestMethod]
        public void TestClass()
        {
            var testValue = faker.create<Class_>();
            Assert.IsInstanceOfType(testValue, typeof(Class_));
        }

        [TestMethod]
        public void TestRekursive()
        {
            var testValue = faker.create<A>();
            Assert.IsNull(testValue.b.c.a);
        }

        public class Class_
        {
            public int number;
            public string str;
            public DateTime dateTime;

            public Class_(int _number, string _str, DateTime _dateTime)
            {
                number = _number;
                str = _str;
                dateTime = new DateTime(_dateTime.Year, _dateTime.Month, _dateTime.Day, _dateTime.Hour, _dateTime.Minute, _dateTime.Second, _dateTime.Millisecond);

            }
        }

        public class A
        {
            public B b;
        }

        public class B
        {
            public C c;
        }
        public class C
        {
            public A a;
        }


    }
}
