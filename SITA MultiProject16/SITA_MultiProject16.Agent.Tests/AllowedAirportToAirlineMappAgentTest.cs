
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SITA_MultiProject16.Entities;

namespace SITA_MultiProject16.Agent.Tests
{
    [TestClass]
    public class AllowedAirportToAirlineMappAgentTest
    {
        #region Members
        FakeDbRepositoryAllowedAirportToAirlineMapp _AllowedAirportToAirlineMappFakeDB;

        #endregion

        #region Ctor
        public AllowedAirportToAirlineMappAgentTest()
        {
            _AllowedAirportToAirlineMappFakeDB = new FakeDbRepositoryAllowedAirportToAirlineMapp();
        }
        #endregion

        #region Valid Test Cases

        #region AllowedAirportToAirlineMapp Tests

        [TestMethod]
        public void AllowedAirportToAirlineMapp_Create()
        {
            AllowedAirportToAirlineMapp entity = new AllowedAirportToAirlineMapp()
            {
                Id = 1,
            };
            var response = _AllowedAirportToAirlineMappFakeDB.Create(entity);

            Assert.IsTrue(response.Result);
        }

        [TestMethod]
        public void AllowedAirportToAirlineMapp_Delete()
        {
            var response = _AllowedAirportToAirlineMappFakeDB.Delete("1", typeof(AllowedAirportToAirlineMapp));

            Assert.IsTrue(response.Result);
        }

        [TestMethod]
        public void AllowedAirportToAirlineMapp_GetAll()
        {
            var response = _AllowedAirportToAirlineMappFakeDB.GetAll(d => d.Id != null);

            Assert.IsNotNull(response.Result);
        }

        [TestMethod]
        public void AllowedAirportToAirlineMapp_Update()
        {
            AllowedAirportToAirlineMapp entity = new AllowedAirportToAirlineMapp()
            {
                Id = 1,
            };

            var response = _AllowedAirportToAirlineMappFakeDB.Update("1", entity);

            Assert.IsTrue(response.Result);
        }

        #endregion

        #endregion

        #region Invalid Test Cases

        #region AllowedAirportToAirlineMapp Tests

        [TestMethod]
        public void AllowedAirportToAirlineMapp_CreateInvalid()
        {
            AllowedAirportToAirlineMapp entity = new AllowedAirportToAirlineMapp()
            {                
            };
            var response = _AllowedAirportToAirlineMappFakeDB.Create(entity);

            Assert.IsFalse(response.Result);
        }

        [TestMethod]
        public void AllowedAirportToAirlineMapp_DeleteInvalid()
        {
            var response = _AllowedAirportToAirlineMappFakeDB.Delete(null, typeof(AllowedAirportToAirlineMapp));

            Assert.IsFalse(response.Result);
        }

        [TestMethod]
        public void AllowedAirportToAirlineMapp_GetAllInvalid()
        {
            var response = _AllowedAirportToAirlineMappFakeDB.GetAll();

            Assert.IsNull(response.Result);
        }

        [TestMethod]
        public void AllowedAirportToAirlineMapp_UpdateInvalidEntity()
        {
            var response = _AllowedAirportToAirlineMappFakeDB.Update("1", new AllowedAirportToAirlineMapp());

            Assert.IsFalse(response.Result);
        }

		[TestMethod]
        public void AllowedAirportToAirlineMapp_UpdateInvalidId()
        {
            AllowedAirportToAirlineMapp entity = new AllowedAirportToAirlineMapp()
            {
                Id = 0,
            };
            var response = _AllowedAirportToAirlineMappFakeDB.Update("", entity);

            Assert.IsFalse(response.Result);
        }

        #endregion

        #endregion

        #region Exception Test Cases [Not Implemented Yet]

        #region AllowedAirportToAirlineMapp Test Cases

        //[TestMethod]
        //[ExpectedException(typeof(FormatException))]
        //public void AllowedAirportToAirlineMapp_CreateException()
        //{
        //    AllowedAirportToAirlineMapp entity = new AllowedAirportToAirlineMapp()
        //    {
        //        Id = 0,
        //    };
        //    var response = _AllowedAirportToAirlineMappFakeDB.Create(entity);

        //    Assert.IsTrue(response.Result);
        //}

        //[TestMethod]
        //public void AllowedAirportToAirlineMapp_DeleteException()
        //{
        //    var response = _AllowedAirportToAirlineMappFakeDB.Delete("1", typeof(AllowedAirportToAirlineMapp));

        //    Assert.IsTrue(response.Result);
        //}

        //[TestMethod]
        //public void AllowedAirportToAirlineMapp_GetAllException()
        //{
        //    var response = _AllowedAirportToAirlineMappFakeDB.GetAll(d => d.Id != null);

        //    Assert.IsNotNull(response.Result);
        //}

        //[TestMethod]
        //public void AllowedAirportToAirlineMapp_UpdateException()
        //{
        //    AllowedAirportToAirlineMapp entity = new AllowedAirportToAirlineMapp()
        //    {
        //        Id = 0,
        //    };

        //    var response = _AllowedAirportToAirlineMappFakeDB.Update("1", entity);

        //    Assert.IsTrue(response.Result);
        //}

        #endregion

        #endregion
    }
}