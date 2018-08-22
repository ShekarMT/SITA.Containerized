
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SITA_MultiProject16.Entities;

namespace SITA_MultiProject16.Agent.Tests
{
    [TestClass]
    public class AirportAgentTest
    {
        #region Members
        FakeDbRepositoryAirport _AirportFakeDB;

        #endregion

        #region Ctor
        public AirportAgentTest()
        {
            _AirportFakeDB = new FakeDbRepositoryAirport();
        }
        #endregion

        #region Valid Test Cases

        #region Airport Tests

        [TestMethod]
        public void Airport_Create()
        {
            Airport entity = new Airport()
            {
                Id = 1,
            };
            var response = _AirportFakeDB.Create(entity);

            Assert.IsTrue(response.Result);
        }

        [TestMethod]
        public void Airport_Delete()
        {
            var response = _AirportFakeDB.Delete("1", typeof(Airport));

            Assert.IsTrue(response.Result);
        }

        [TestMethod]
        public void Airport_GetAll()
        {
            var response = _AirportFakeDB.GetAll(d => d.Id != null);

            Assert.IsNotNull(response.Result);
        }

        [TestMethod]
        public void Airport_Update()
        {
            Airport entity = new Airport()
            {
                Id = 1,
            };

            var response = _AirportFakeDB.Update("1", entity);

            Assert.IsTrue(response.Result);
        }

        #endregion

        #endregion

        #region Invalid Test Cases

        #region Airport Tests

        [TestMethod]
        public void Airport_CreateInvalid()
        {
            Airport entity = new Airport()
            {                
            };
            var response = _AirportFakeDB.Create(entity);

            Assert.IsFalse(response.Result);
        }

        [TestMethod]
        public void Airport_DeleteInvalid()
        {
            var response = _AirportFakeDB.Delete(null, typeof(Airport));

            Assert.IsFalse(response.Result);
        }

        [TestMethod]
        public void Airport_GetAllInvalid()
        {
            var response = _AirportFakeDB.GetAll();

            Assert.IsNull(response.Result);
        }

        [TestMethod]
        public void Airport_UpdateInvalidEntity()
        {
            var response = _AirportFakeDB.Update("1", new Airport());

            Assert.IsFalse(response.Result);
        }

		[TestMethod]
        public void Airport_UpdateInvalidId()
        {
            Airport entity = new Airport()
            {
                Id = 0,
            };
            var response = _AirportFakeDB.Update("", entity);

            Assert.IsFalse(response.Result);
        }

        #endregion

        #endregion

        #region Exception Test Cases [Not Implemented Yet]

        #region Airport Test Cases

        //[TestMethod]
        //[ExpectedException(typeof(FormatException))]
        //public void Airport_CreateException()
        //{
        //    Airport entity = new Airport()
        //    {
        //        Id = 0,
        //    };
        //    var response = _AirportFakeDB.Create(entity);

        //    Assert.IsTrue(response.Result);
        //}

        //[TestMethod]
        //public void Airport_DeleteException()
        //{
        //    var response = _AirportFakeDB.Delete("1", typeof(Airport));

        //    Assert.IsTrue(response.Result);
        //}

        //[TestMethod]
        //public void Airport_GetAllException()
        //{
        //    var response = _AirportFakeDB.GetAll(d => d.Id != null);

        //    Assert.IsNotNull(response.Result);
        //}

        //[TestMethod]
        //public void Airport_UpdateException()
        //{
        //    Airport entity = new Airport()
        //    {
        //        Id = 0,
        //    };

        //    var response = _AirportFakeDB.Update("1", entity);

        //    Assert.IsTrue(response.Result);
        //}

        #endregion

        #endregion
    }
}