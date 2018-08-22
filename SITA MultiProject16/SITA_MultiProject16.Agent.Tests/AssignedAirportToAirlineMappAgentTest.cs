
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SITA_MultiProject16.Entities;

namespace SITA_MultiProject16.Agent.Tests
{
    [TestClass]
    public class AssignedAirportToAirlineMappAgentTest
    {
        #region Members
        FakeDbRepositoryAssignedAirportToAirlineMapp _AssignedAirportToAirlineMappFakeDB;

        #endregion

        #region Ctor
        public AssignedAirportToAirlineMappAgentTest()
        {
            _AssignedAirportToAirlineMappFakeDB = new FakeDbRepositoryAssignedAirportToAirlineMapp();
        }
        #endregion

        #region Valid Test Cases

        #region AssignedAirportToAirlineMapp Tests

        [TestMethod]
        public void AssignedAirportToAirlineMapp_Create()
        {
            AssignedAirportToAirlineMapp entity = new AssignedAirportToAirlineMapp()
            {
                Id = 1,
            };
            var response = _AssignedAirportToAirlineMappFakeDB.Create(entity);

            Assert.IsTrue(response.Result);
        }

        [TestMethod]
        public void AssignedAirportToAirlineMapp_Delete()
        {
            var response = _AssignedAirportToAirlineMappFakeDB.Delete("1", typeof(AssignedAirportToAirlineMapp));

            Assert.IsTrue(response.Result);
        }

        [TestMethod]
        public void AssignedAirportToAirlineMapp_GetAll()
        {
            var response = _AssignedAirportToAirlineMappFakeDB.GetAll(d => d.Id != null);

            Assert.IsNotNull(response.Result);
        }

        [TestMethod]
        public void AssignedAirportToAirlineMapp_Update()
        {
            AssignedAirportToAirlineMapp entity = new AssignedAirportToAirlineMapp()
            {
                Id = 1,
            };

            var response = _AssignedAirportToAirlineMappFakeDB.Update("1", entity);

            Assert.IsTrue(response.Result);
        }

        #endregion

        #endregion

        #region Invalid Test Cases

        #region AssignedAirportToAirlineMapp Tests

        [TestMethod]
        public void AssignedAirportToAirlineMapp_CreateInvalid()
        {
            AssignedAirportToAirlineMapp entity = new AssignedAirportToAirlineMapp()
            {                
            };
            var response = _AssignedAirportToAirlineMappFakeDB.Create(entity);

            Assert.IsFalse(response.Result);
        }

        [TestMethod]
        public void AssignedAirportToAirlineMapp_DeleteInvalid()
        {
            var response = _AssignedAirportToAirlineMappFakeDB.Delete(null, typeof(AssignedAirportToAirlineMapp));

            Assert.IsFalse(response.Result);
        }

        [TestMethod]
        public void AssignedAirportToAirlineMapp_GetAllInvalid()
        {
            var response = _AssignedAirportToAirlineMappFakeDB.GetAll();

            Assert.IsNull(response.Result);
        }

        [TestMethod]
        public void AssignedAirportToAirlineMapp_UpdateInvalidEntity()
        {
            var response = _AssignedAirportToAirlineMappFakeDB.Update("1", new AssignedAirportToAirlineMapp());

            Assert.IsFalse(response.Result);
        }

		[TestMethod]
        public void AssignedAirportToAirlineMapp_UpdateInvalidId()
        {
            AssignedAirportToAirlineMapp entity = new AssignedAirportToAirlineMapp()
            {
                Id = 0,
            };
            var response = _AssignedAirportToAirlineMappFakeDB.Update("", entity);

            Assert.IsFalse(response.Result);
        }

        #endregion

        #endregion

        #region Exception Test Cases [Not Implemented Yet]

        #region AssignedAirportToAirlineMapp Test Cases

        //[TestMethod]
        //[ExpectedException(typeof(FormatException))]
        //public void AssignedAirportToAirlineMapp_CreateException()
        //{
        //    AssignedAirportToAirlineMapp entity = new AssignedAirportToAirlineMapp()
        //    {
        //        Id = 0,
        //    };
        //    var response = _AssignedAirportToAirlineMappFakeDB.Create(entity);

        //    Assert.IsTrue(response.Result);
        //}

        //[TestMethod]
        //public void AssignedAirportToAirlineMapp_DeleteException()
        //{
        //    var response = _AssignedAirportToAirlineMappFakeDB.Delete("1", typeof(AssignedAirportToAirlineMapp));

        //    Assert.IsTrue(response.Result);
        //}

        //[TestMethod]
        //public void AssignedAirportToAirlineMapp_GetAllException()
        //{
        //    var response = _AssignedAirportToAirlineMappFakeDB.GetAll(d => d.Id != null);

        //    Assert.IsNotNull(response.Result);
        //}

        //[TestMethod]
        //public void AssignedAirportToAirlineMapp_UpdateException()
        //{
        //    AssignedAirportToAirlineMapp entity = new AssignedAirportToAirlineMapp()
        //    {
        //        Id = 0,
        //    };

        //    var response = _AssignedAirportToAirlineMappFakeDB.Update("1", entity);

        //    Assert.IsTrue(response.Result);
        //}

        #endregion

        #endregion
    }
}