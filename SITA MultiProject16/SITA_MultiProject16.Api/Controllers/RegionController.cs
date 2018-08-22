
using System;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using SITA_MultiProject16.Entities;
using SITA_MultiProject16.BusinessAgent.Interface;

namespace SITA_MultiProject16.Api.Controllers
{
	/// <summary>
    /// Controller to act as endpoint for Region related functionalities
    /// </summary>
	[Authorize]
	public class RegionController : ApiController
	{
		#region Private Members
        private readonly IRegionManager _RegionManager;
        #endregion

		#region Ctor
        public RegionController(IRegionManager RegionManager)
        {
            //_salesVolumeManager = salesVolumeManager;
            _RegionManager = RegionManager;
        }

		public RegionController()
        {

        }

		#endregion


		#region HttpMethods

        #region HTTP POST
        [HttpPost]
        public async Task<IHttpActionResult> CreateRegion([FromBody] Region entity)
        {
            try
            {
                await _RegionManager.CreateRegion(entity);
                return Ok("Created");
            }
            catch (Exception ex)
            {
                return BadRequest(new SaveResult()
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Status = false,
                    Message = ex.Message
                }.ToString());
            }
        }
        #endregion

        #region HTTP GET
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            var response = await _RegionManager.GetAllRegion();
            if (response != null)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(new SaveResult()
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Status = false,
                    Message = "Could Not Retrieve Data"
                }.ToString());
            }
        }

        //[HttpGet]
        //public async Task<IHttpActionResult> GetRegionById([FromUri]string id)
        //{
        //    var response = await _RegionManager.GetRegion(id);
        //    if (response != null)
        //    {
        //        return Ok(response);
        //    }
        //    else
        //    {
        //        return BadRequest(new SaveResult()
        //        {
        //            StatusCode = HttpStatusCode.BadRequest,
        //            Status = false,
        //            Message = "Could Not Retrieve Data"
        //        }.ToString());
        //    }
        //}
        #endregion

        #region HTTP PUT
        [HttpPut]
        public async Task<IHttpActionResult> UpdateRegion([FromUri]string id, [FromBody] Region updatedRegion)
        {
            var response = await _RegionManager.UpdateRegion(id, updatedRegion);
            if (response)
            {
                return Ok(new SaveResult()
                {
                    StatusCode = HttpStatusCode.OK,
                    Status = true,
                    Message = "Successfully Updated!"
                }.ToString());
            }
            else
            {
                return BadRequest(new SaveResult()
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Status = false,
                    Message = "Update Unsuccessful!"
                }.ToString());
            }
        }
        #endregion

        #region HTTP DELETE
        [HttpDelete]
        public async Task<IHttpActionResult> DeleteRegion([FromUri] string id)
        {
            var response = await _RegionManager.DeleteRegion(id);
            if (response)
            {
                return Ok(new SaveResult()
                {
                    StatusCode = HttpStatusCode.OK,
                    Status = true,
                    Message = "Successfully Updated!"
                }.ToString());
            }
            else
            {
                return BadRequest(new SaveResult()
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Status = false,
                    Message = "Update Unsuccessful!"
                }.ToString());
            }
        }
        #endregion

        #endregion
	}
}

