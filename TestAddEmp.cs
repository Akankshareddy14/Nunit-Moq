using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hands_T02_HOL_005;
using NUnit.Framework;
namespace TestClass
{
    [TestFixture]
    public class TestAddEmp
    {
        EmployeeManger em = new EmployeeManger();
        [TestCase]
        public void TestCase_AddEmployee()
        {
            int beforeInsert = em.HeadCount;
            Assert.AreEqual(0, beforeInsert);

            Employee model = new Employee
            {
                Id = 1001,
                Name = "Kishan"
            };


            em.AddEmployee(model);


            int afterInsert = em.HeadCount;
            Assert.AreEqual(1, afterInsert);
        }

    }
}
