
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SITA_MultiProject16.Entities;

namespace SITA_MultiProject16.Agent.Tests
{
    [TestClass]
    public class RegionAgentTest
    {
        #region Members
        FakeDbRepositoryRegion _RegionFakeDB;

        #endregion

        #region Ctor
        public RegionAgentTest()
        {
            _RegionFakeDB = new FakeDbRepositoryRegion();
        }
        #endregion

        #region Valid Test Cases

        #region Region Tests

        [TestMethod]
        public void Region_Create()
        {
            Region entity = new Region()
            {
                Id = 1,
            };
            var response = _RegionFakeDB.Create(entity);

            Assert.IsTrue(response.Result);
        }

        [TestMethod]
        public void Region_Delete()
        {
            var response = _RegionFakeDB.Delete("1", typeof(Region));

            Assert.IsTrue(response.Result);
        }

        [TestMethod]
        public void Region_GetAll()
        {
            var response = _RegionFakeDB.GetAll(d => d.Id != null);

            Assert.IsNotNull(response.Result);
        }

        [TestMethod]
        public void Region_Update()
        {
            Region entity = new Region()
            {
                Id = 1,
            };

            var response = _RegionFakeDB.Update("1", entity);

            Assert.IsTrue(response.Result);
        }

        #endregion

        #endregion

        #region Invalid Test Cases

        #region Region Tests

        [TestMethod]
        public void Region_CreateInvalid()
        {
            Region entity = new Region()
            {                
            };
            var response = _RegionFakeDB.Create(entity);

            Assert.IsFalse(response.Result);
        }

        [TestMethod]
        public void Region_DeleteInvalid()
        {
            var response = _RegionFakeDB.Delete(null, typeof(Region));

            Assert.IsFalse(response.Result);
        }

        [TestMethod]
        public void Region_GetAllInvalid()
        {
            var response = _RegionFakeDB.GetAll();

            Assert.IsNull(response.Result);
        }

        [TestMethod]
        public void Region_UpdateInvalidEntity()
        {
            var response = _RegionFakeDB.Update("1", new Region());

            Assert.IsFalse(response.Result);
        }

		[TestMethod]
        public void Region_UpdateInvalidId()
        {
            Region entity = new Region()
            {
                Id = 0,
            };
            var response = _RegionFakeDB.Update("", entity);

            Assert.IsFalse(response.Result);
        }

        #endregion

        #endregion

        #region Exception Test Cases [Not Implemented Yet]

        #region Region Test Cases

        //[TestMethod]
        //[ExpectedException(typeof(FormatException))]
        //public void Region_CreateException()
        //{
        //    Region entity = new Region()
        //    {
        //        Id = 0,
        //    };
        //    var response = _RegionFakeDB.Create(entity);

        //    Assert.IsTrue(response.Result);
        //}

        //[TestMethod]
        //public void Region_DeleteException()
        //{
        //    var response = _RegionFakeDB.Delete("1", typeof(Region));

        //    Assert.IsTrue(response.Result);
        //}

        //[TestMethod]
        //public void Region_GetAllException()
        //{
        //    var response = _RegionFakeDB.GetAll(d => d.Id != null);

        //    Assert.IsNotNull(response.Result);
        //}

        //[TestMethod]
        //public void Region_UpdateException()
        //{
        //    Region entity = new Region()
        //    {
        //        Id = 0,
        //    };

        //    var response = _RegionFakeDB.Update("1", entity);

        //    Assert.IsTrue(response.Result);
        //}

        #endregion

        #endregion
    }
}