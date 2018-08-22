
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SITA_MultiProject16.Entities;

namespace SITA_MultiProject16.Agent.Tests
{
    [TestClass]
    public class AirlineAgentTest
    {
        #region Members
        FakeDbRepositoryAirline _AirlineFakeDB;

        #endregion

        #region Ctor
        public AirlineAgentTest()
        {
            _AirlineFakeDB = new FakeDbRepositoryAirline();
        }
        #endregion

        #region Valid Test Cases

        #region Airline Tests

        [TestMethod]
        public void Airline_Create()
        {
            Airline entity = new Airline()
            {
                Id = 1,
            };
            var response = _AirlineFakeDB.Create(entity);

            Assert.IsTrue(response.Result);
        }

        [TestMethod]
        public void Airline_Delete()
        {
            var response = _AirlineFakeDB.Delete("1", typeof(Airline));

            Assert.IsTrue(response.Result);
        }

        [TestMethod]
        public void Airline_GetAll()
        {
            var response = _AirlineFakeDB.GetAll(d => d.Id != null);

            Assert.IsNotNull(response.Result);
        }

        [TestMethod]
        public void Airline_Update()
        {
            Airline entity = new Airline()
            {
                Id = 1,
            };

            var response = _AirlineFakeDB.Update("1", entity);

            Assert.IsTrue(response.Result);
        }

        #endregion

        #endregion

        #region Invalid Test Cases

        #region Airline Tests

        [TestMethod]
        public void Airline_CreateInvalid()
        {
            Airline entity = new Airline()
            {                
            };
            var response = _AirlineFakeDB.Create(entity);

            Assert.IsFalse(response.Result);
        }

        [TestMethod]
        public void Airline_DeleteInvalid()
        {
            var response = _AirlineFakeDB.Delete(null, typeof(Airline));

            Assert.IsFalse(response.Result);
        }

        [TestMethod]
        public void Airline_GetAllInvalid()
        {
            var response = _AirlineFakeDB.GetAll();

            Assert.IsNull(response.Result);
        }

        [TestMethod]
        public void Airline_UpdateInvalidEntity()
        {
            var response = _AirlineFakeDB.Update("1", new Airline());

            Assert.IsFalse(response.Result);
        }

		[TestMethod]
        public void Airline_UpdateInvalidId()
        {
            Airline entity = new Airline()
            {
                Id = 0,
            };
            var response = _AirlineFakeDB.Update("", entity);

            Assert.IsFalse(response.Result);
        }

        #endregion

        #endregion

        #region Exception Test Cases [Not Implemented Yet]

        #region Airline Test Cases

        //[TestMethod]
        //[ExpectedException(typeof(FormatException))]
        //public void Airline_CreateException()
        //{
        //    Airline entity = new Airline()
        //    {
        //        Id = 0,
        //    };
        //    var response = _AirlineFakeDB.Create(entity);

        //    Assert.IsTrue(response.Result);
        //}

        //[TestMethod]
        //public void Airline_DeleteException()
        //{
        //    var response = _AirlineFakeDB.Delete("1", typeof(Airline));

        //    Assert.IsTrue(response.Result);
        //}

        //[TestMethod]
        //public void Airline_GetAllException()
        //{
        //    var response = _AirlineFakeDB.GetAll(d => d.Id != null);

        //    Assert.IsNotNull(response.Result);
        //}

        //[TestMethod]
        //public void Airline_UpdateException()
        //{
        //    Airline entity = new Airline()
        //    {
        //        Id = 0,
        //    };

        //    var response = _AirlineFakeDB.Update("1", entity);

        //    Assert.IsTrue(response.Result);
        //}

        #endregion

        #endregion
    }
}