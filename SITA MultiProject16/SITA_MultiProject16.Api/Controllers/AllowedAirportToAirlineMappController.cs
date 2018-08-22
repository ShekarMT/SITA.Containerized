
using System;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using SITA_MultiProject16.Entities;
using SITA_MultiProject16.BusinessAgent.Interface;

namespace SITA_MultiProject16.Api.Controllers
{
	/// <summary>
    /// Controller to act as endpoint for AllowedAirportToAirlineMapp related functionalities
    /// </summary>
	[Authorize]
	public class AllowedAirportToAirlineMappController : ApiController
	{
		#region Private Members
        private readonly IAllowedAirportToAirlineMappManager _AllowedAirportToAirlineMappManager;
        #endregion

		#region Ctor
        public AllowedAirportToAirlineMappController(IAllowedAirportToAirlineMappManager AllowedAirportToAirlineMappManager)
        {
            //_salesVolumeManager = salesVolumeManager;
            _AllowedAirportToAirlineMappManager = AllowedAirportToAirlineMappManager;
        }

		public AllowedAirportToAirlineMappController()
        {

        }

		#endregion


		#region HttpMethods

        #region HTTP POST
        [HttpPost]
        public async Task<IHttpActionResult> CreateAllowedAirportToAirlineMapp([FromBody] AllowedAirportToAirlineMapp entity)
        {
            try
            {
                await _AllowedAirportToAirlineMappManager.CreateAllowedAirportToAirlineMapp(entity);
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
            var response = await _AllowedAirportToAirlineMappManager.GetAllAllowedAirportToAirlineMapp();
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
        //public async Task<IHttpActionResult> GetAllowedAirportToAirlineMappById([FromUri]string id)
        //{
        //    var response = await _AllowedAirportToAirlineMappManager.GetAllowedAirportToAirlineMapp(id);
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
        public async Task<IHttpActionResult> UpdateAllowedAirportToAirlineMapp([FromUri]string id, [FromBody] AllowedAirportToAirlineMapp updatedAllowedAirportToAirlineMapp)
        {
            var response = await _AllowedAirportToAirlineMappManager.UpdateAllowedAirportToAirlineMapp(id, updatedAllowedAirportToAirlineMapp);
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
        public async Task<IHttpActionResult> DeleteAllowedAirportToAirlineMapp([FromUri] string id)
        {
            var response = await _AllowedAirportToAirlineMappManager.DeleteAllowedAirportToAirlineMapp(id);
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

